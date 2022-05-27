using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ProjectSupport
{
    public partial class AdminForm : Form
    {
        // TODO: can't create two cases with the same name?

        // Array of strings that can be used for greeting the user that logs in
        private string[] greetings = { "Hello there",
                                       "Hi",
                                       "Welcome",
                                       "Welcome back",
                                       "What's up",
                                       "Always a pleasure to see you"};

        private string defaultReplyMsg = "<reply with message>";    // Default message for the replyMsgTxtBox

        private int _userId;
        public int UserID
        {
            get { return _userId; }
            set { _userId = value; }
        }

        private ProjectDB db;                                       // Handle of the ProjectDB object used for
                                                                    // communication with the database

        private bool _drag = false;                                 // *
        private Point _dragCursorPoint;                             // * * Objects used for dragging the window
        private Point _dragFormPoint;                               // *

        private UInt32 replyCharLimit = 150;                        // Max length of reply message, dictated by
                                                                    // database requirements

        private int lastListBoxIndex;                               // Auxiliary variable used by LoadSelectedCase()

        private LoginForm parentForm;                               // Reference to the LoginForm that instantiated
                                                                    // this form


        // Setup for creating rounded corners for the window
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect,
                                                         int nTopRect,
                                                         int nRightRect,
                                                         int nBottomRect,
                                                         int nWidthEllipse,
                                                         int nHeightEllipse);

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="loginForm">Reference to the LoginForm that created this AdminForm</param>
        public AdminForm(LoginForm loginForm)
        {
            parentForm = loginForm;
            InitializeComponent();

            // Creating rounded corners for the window
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            SetAppearance();
            rfsh();
            DisableRplyCntrls();
        }


        /// <summary>
        /// Sets the appearance of the form
        /// </summary>
        /// <remarks>To be invoked once: in the constructor</remarks>
        private void SetAppearance()
        {
            // Since the colors used here are custom and not present in designer
            // the colors and styles needed to be set programmatically
            this.BackColor = Colors.ColorsList[7];
            this.ForeColor = Colors.ColorsList[3];
            this.panel1.BackColor = Colors.ColorsList[5];
            this.panel1.ForeColor = Colors.ColorsList[3];
            this.breakPanel.BackColor = Colors.ColorsList[3];
            this.chatBox.BackColor = Colors.ColorsList[5];
            this.chatBox.ForeColor = Colors.ColorsList[3];
            this.replyMsgTxtBox.BackColor = Colors.ColorsList[5];
            this.replyMsgTxtBox.ForeColor = Colors.ColorsList[3];
            this.replyBtn.BackColor = Colors.ColorsList[5];
            this.replyBtn.ForeColor = Colors.ColorsList[3];
            this.replyBtn.FlatStyle = FlatStyle.Flat;
            this.replyBtn.FlatAppearance.BorderColor = Colors.ColorsList[3];
            this.refreshBtn.FlatStyle = FlatStyle.Flat;
            this.refreshBtn.FlatAppearance.BorderColor = Colors.ColorsList[3];
            this.refreshBtn.BackColor = Colors.ColorsList[7];
            this.refreshBtn.ForeColor = Colors.ColorsList[3];
            this.casesList.BackColor = Colors.ColorsList[7];
            this.casesList.ForeColor = Colors.ColorsList[3];
            this.backPanel.BackColor = Colors.ColorsList[3];
            this.panel2.BackColor = Colors.ColorsList[3];
            this.logOutBtn.BackColor = Colors.ColorsList[7];

            // Greeting the logged in user
            using (db = new ProjectDB())
            {
                string username = (from user in db.Users
                                   where user.UserId == UserID
                                   select user.UserName).FirstOrDefault();
                this.greetingLabel.Text = $"{Greeting()} {username}";
            }
            db.Dispose();
        }

        /// <summary>
        /// Returns a random greeting
        /// </summary>
        private string Greeting()
        {
            Random rnd = new Random();
            return greetings[rnd.Next(0, greetings.Count() - 1)];
        }


        /// <summary>
        /// Downloads and lists out all of the unhandled cases from the database
        /// </summary>
        private void GetUnhandledCases()
        {
            using (db = new ProjectDB())
            {
                var getCases = (from unhandledCase in db.CaseTab
                                where unhandledCase.CaseStatus == "Open"
                                select unhandledCase).ToList();

                this.casesList.DataSource = getCases;
                this.casesList.DisplayMember = "CaseName";
                this.casesList.ValueMember = "CaseStatus";
                this.casesNrLabel.Text = $"There are {getCases.Count} cases left to be handled:";
            }
        }


        /// <summary>
        /// Displays case descriptors and chat history of the slected case from the unhandled-cases list
        /// </summary>
        private void LoadSelectedCase(object sender, EventArgs e)
        {
            if (!CheckForUnsentReply())
            {
                this.casesList.SelectedIndex = lastListBoxIndex;
                return;
            }
            lastListBoxIndex = this.casesList.SelectedIndex;

            this.auxLabel1.Visible = false;
            this.chatBox.Clear();
            GetCaseInfo();

            string title = this.casesList.GetItemText(this.casesList.SelectedItem);
            using (db = new ProjectDB())
            {
                var adminChat = (from admin in db.AdminChat
                                 where admin.CaseTab.CaseName == title
                                 select admin.AdminText).ToArray();

                var usrChat = (from user in db.UserChat
                               where user.CaseTab.CaseName == title
                               select user.UserText).ToArray();


                int len = adminChat.Length >= usrChat.Length ? adminChat.Length : usrChat.Length;
                for (int i = 0; i < len; i++)
                {
                    if (i < usrChat.Length)
                    {
                        this.chatBox.SelectionAlignment = HorizontalAlignment.Left;

                        // Should never happen but if there were multiple messages by the same side (user or admin)
                        // at the end of the chat history this will print out the descriptor (User: / Admin: ) just once
                        if ((i - 1) < adminChat.Length)
                        {
                            this.chatBox.AppendText("User:\r\n");
                        }
                        this.chatBox.AppendText($"{usrChat[i]}\r\n");
                    }
                    if (i < adminChat.Length)
                    {
                        this.chatBox.SelectionAlignment = HorizontalAlignment.Right;

                        // See comment above
                        if ((i - 1) < usrChat.Length)
                        {
                            this.chatBox.AppendText("Admin:\r\n");
                        }
                        this.chatBox.AppendText($"{adminChat[i]}\r\n");
                    }
                }
            }
            db.Dispose();
            EnableRplyCntrls();
        }


        /// <summary>
        /// Displays the descriptors of the currently open case
        /// </summary>
        private void GetCaseInfo()
        {
            using (db = new ProjectDB())
            {
                string csName = this.casesList.GetItemText(this.casesList.SelectedItem);
                var selCase = (from cs in db.CaseTab
                               where cs.CaseName == csName
                               select cs).FirstOrDefault();

                this.caseIDLabel.Text = $"CaseID: {selCase.CaseId.ToString()}";
                this.caseNameLabel.Text = $"Case name: {selCase.CaseName}";
                this.userIDLabel.Text = $"UserID: {selCase.UserId.ToString()}";
                this.transactionIDLabel.Text = $"TransactionID: {selCase.TransactionId.ToString()}";
                string usrName = (from user in db.Users
                                  where user.UserId == selCase.UserId
                                  select user.UserName).FirstOrDefault();
                this.userNameLabel.Text = $"Username: {usrName}";
            }

            this.caseIDLabel.Visible = true;
            this.caseNameLabel.Visible = true;
            this.userIDLabel.Visible = true;
            this.userNameLabel.Visible = true;
            this.transactionIDLabel.Visible = true;
        }

        /// <summary>
        /// Hides the descriptors of the currently open case
        /// </summary>
        private void HideCaseInfo()
        {
            this.caseIDLabel.Visible = false;
            this.caseNameLabel.Visible = false;
            this.userIDLabel.Visible = false;
            this.userNameLabel.Visible = false;
            this.transactionIDLabel.Visible = false;
        }


        /// <summary>
        /// Validates the message in replyMsgTxtBox, then sends the reply to the database,
        /// and changes the case status to "Closed"
        /// </summary>
        private void replyBtn_Click(object sender, EventArgs e)
        {
            // Validate the reply isn't empty or isn't the default text; do nothing if it is
            bool replyEmpty = String.IsNullOrEmpty(this.replyMsgTxtBox.Text);
            bool replyDefault = String.Equals(this.replyMsgTxtBox.Text, defaultReplyMsg);
            if (replyEmpty || replyDefault)
            {
                return;
            }

            // Check if the reply is too long
            bool replyTooLong = this.replyMsgTxtBox.Text.Length > replyCharLimit;
            if (replyTooLong)
            {
                MessageBox.Show("Reply message too long! Please reply in 150 characters or less",
                                "Character limit exceeded",
                                MessageBoxButtons.OK);
                return;
            }

            AdminChat adminReplyData = new AdminChat();     // New object that will be sent to the database

            string caseTitle = this.casesList.GetItemText(this.casesList.SelectedItem);

            adminReplyData.AdminText = this.replyMsgTxtBox.Text;
            adminReplyData.CaseId = Int32.Parse(this.caseIDLabel.Text.Substring(8));
            adminReplyData.UserId = UserID;

            using (db = new ProjectDB())
            {
                var updateCaseStatus = (from cs in db.CaseTab
                                        where cs.CaseId == adminReplyData.CaseId
                                        select cs).SingleOrDefault();

                db.AdminChat.Add(adminReplyData);
                updateCaseStatus.CaseStatus = "Closed";
                db.SaveChanges();
            }

            rfsh();
        }

        /// <summary>
        /// Refreshes the form. See rfrsh method
        /// </summary>
        private void refreshBtn_Click(object sender, EventArgs e)
        {
            rfsh();
        }


        /// <summary>
        /// Makes the replyMsgTxtBox readonly and disables the replyBtn
        /// </summary>
        private void DisableRplyCntrls()
        {
            // this.replyMsgTxtBox.Enabled = false; 
            // Didn't work since disabling it defaults its BackColor to white

            this.replyMsgTxtBox.ReadOnly = true;
            this.replyMsgTxtBox.Text = "";
            this.replyBtn.Enabled = false; 
            this.replyBtn.Text = "";
            // temp hide btn image?
        }

        /// <summary>
        /// Enables replyBtn and disables the readonly mode of replyMsgTxtBox
        /// </summary>
        private void EnableRplyCntrls()
        {
            this.replyMsgTxtBox.ReadOnly = false;
            this.replyMsgTxtBox.Text = defaultReplyMsg;
            this.replyBtn.Enabled = true;
            this.replyBtn.Text = "Send";
            // show temp hidden image?
        }


        /// <summary>
        /// Refreshes this form: Hides all currently open info, clears the replyMsgTxtBox
        /// and redownloads unhandled cases
        /// </summary>
        private void rfsh()
        {
            if (!CheckForUnsentReply())
            {
                return;
            }

            HideCaseInfo();
            this.chatBox.Clear();
            DisableRplyCntrls();
            GetUnhandledCases();
            this.auxLabel1.Visible = true;
        }

        /*** Window dragging logic */
        private void AdminForm_MouseDown(object sender, MouseEventArgs e)
        {
            _drag = true;
            _dragCursorPoint = Cursor.Position;
            _dragFormPoint = this.Location;
        }

        private void AdminForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (_drag)
            {
                Point difference = Point.Subtract(Cursor.Position, new Size(_dragCursorPoint));
                this.Location = Point.Add(_dragFormPoint, new Size(difference));
            }
        }

        private void AdminForm_MouseUp(object sender, MouseEventArgs e)
        {
            _drag = false;
        }
        /* ***/

        /// <summary>
        /// Closes this form and shows the LoginForm
        /// </summary>
        private void logOutBtn_Click(object sender, EventArgs e)
        {
            if (!CheckForUnsentReply())
            {
                return;
            }

            parentForm.Show();
            this.Close();
        }

        /// <summary>
        /// Exits the application
        /// </summary>
        private void exitBtn_Click(object sender, EventArgs e)
        {
            if (!CheckForUnsentReply())
            {
                return;
            }

            Application.Exit();
        }

        /// <summary>
        /// Checks the replyMsgTxtBox for an existing string that isn't the defaultReplyMsg and
        /// if it finds one it then asks whether the user wants to continue and discard the message or not
        /// </summary>
        /// <returns>
        /// true If user wants to discard the message<br>
        /// false If the user doesn't want to discard the message</br>
        /// </returns>
        private bool CheckForUnsentReply()
        {
            bool isReplyDefault = String.Equals(this.replyMsgTxtBox.Text, defaultReplyMsg);
            bool filledWithText = !String.IsNullOrEmpty(this.replyMsgTxtBox.Text);

            if (isReplyDefault || !filledWithText)
            {
                return true;
            }

            // If we get here the reply isn't a default one and the txtbox isn't empty (see if above)
            DialogResult choice;
            choice = MessageBox.Show("You have an unsent reply in the reply box! Do you wish to continue and discard the message?",
                                         "Unsent message",
                                         MessageBoxButtons.YesNo);

            if (choice == DialogResult.Yes)
            {
                this.replyMsgTxtBox.Text = defaultReplyMsg;
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}