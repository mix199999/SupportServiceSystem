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
        private string[] greetings = { "Hello there",
                                       "Hi",
                                       "Welcome",
                                       "Welcome back",
                                       "What's up",
                                       "Always a pleasure to see you"};
        private int _userId;
        public int UserID
        {
            get {  return _userId; }
            set { _userId = value; }
        }
        private ProjectDB db;
        private bool _drag = false;
        private Point _dragCursorPoint;
        private Point _dragFormPoint;


        // Setup for creating rounded corners for the window
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect,
                                                         int nTopRect,      
                                                         int nRightRect,    
                                                         int nBottomRect,   
                                                         int nWidthEllipse, 
                                                         int nHeightEllipse);

        public AdminForm()
        {
            InitializeComponent();

            // Creating rounded corners for the window
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            
            SetAppearance();
            rfsh();
        }


        private void SetAppearance()
        {
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

            using (db = new ProjectDB())
            {
                string username = (from user in db.Users
                                   where user.UserId == UserID
                                   select user.UserName).FirstOrDefault();
                this.greetingLabel.Text = $"{Greeting()} {username}";
            }
            db.Dispose();
        }


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

        private void HideCaseInfo()
        {
            this.caseIDLabel.Visible = false;
            this.caseNameLabel.Visible = false;
            this.userIDLabel.Visible = false;
            this.userNameLabel.Visible = false;
            this.transactionIDLabel.Visible = false;
        }

        private string Greeting()
        {
            Random rnd = new Random();
            return greetings[rnd.Next(0, greetings.Count() - 1)];
        }


        // TODO: this
        private void replyBtn_Click(object sender, EventArgs e)
        {
            // do stuff
            // take the stuff from the replyTxtBox and append the adminchat or something?
            // close the current case (status = "Closed")

            rfsh();
        }


        private void refreshBtn_Click(object sender, EventArgs e)
        {
            rfsh();
        }

        private void rfsh()
        {
            HideCaseInfo();
            this.chatBox.Clear();
            GetUnhandledCases();
            this.auxLabel1.Visible = true;
            this.replyMsgTxtBox.Text = "<reply with message>";
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

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoadSelectedCase(object sender, EventArgs e)
        {
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

                // TODO: do it differently or nah?
                /*var chat = usrChat.Zip(adminChat, (user, admin) => new { User = user, Admin = admin } );
                foreach (var item in chat)
                {
                    if (item.User != null)
                    {
                        this.chatBox.SelectionAlignment = HorizontalAlignment.Left;
                        this.chatBox.AppendText("User\r\n");
                        this.chatBox.AppendText(item.User + "\r\n");
                    }
                    if (item.Admin != null)
                    {
                        this.chatBox.SelectionAlignment = HorizontalAlignment.Right;
                        this.chatBox.AppendText("Admin\r\n");
                        this.chatBox.AppendText(item.Admin + "\r\n");
                    }
                }*/

                // Length of both of those should be the same, but let's be proper and act cautiously
                int len = adminChat.Length >= usrChat.Length ? adminChat.Length : usrChat.Length;
                for (int i = 0; i < len; i++)
                {
                    if (i < usrChat.Length)
                    {
                        this.chatBox.SelectionAlignment = HorizontalAlignment.Left;
                        if ((i - 1) < adminChat.Length)
                        {
                            this.chatBox.AppendText("User:\r\n");
                        }
                        this.chatBox.AppendText($"{usrChat[i]}\r\n");
                    }
                    if (i < adminChat.Length)
                    {
                        this.chatBox.SelectionAlignment = HorizontalAlignment.Right;
                        if ((i - 1) < usrChat.Length)
                        {
                            this.chatBox.AppendText("Admin:\r\n");
                        }
                        this.chatBox.AppendText($"{adminChat[i]}\r\n");
                    }
                }
            }
            db.Dispose();
        }
    }
}