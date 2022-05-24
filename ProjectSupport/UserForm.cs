using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
namespace ProjectSupport
{
    public enum AnswearType
    {
        buyerPurchase,
        buyerPayment,
        buyerDelivery,
        sellerCases,
        sellerCommissions,
        sellerPromoting
    };
    public partial class UserForm : Form
    {
        public selectSellerBuyerBar naviSelect = new selectSellerBuyerBar();
        public sellerUserControl naviSeller = new sellerUserControl();
        public buyerUserControl naviBuyer = new buyerUserControl();


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
        private int _userId;
        public int UserID
        {
            get { return _userId; }
            set { _userId = value; }
        }



        SearchResultsUC resultsUC = new SearchResultsUC();
        UserChat userTextData = new UserChat();
        CaseTab userCaseData = new CaseTab();

        ProjectDB db;
        public UserOldCasesUC oldCases = new UserOldCasesUC();
        public UserForm()
        {


            InitializeComponent();
            SetDockHide(naviSelect);
            SetDockHide(naviBuyer);
            SetDockHide(naviSeller);
            naviBuyer.PurchaseBt.Tag = "dupa";

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            this.naviBuyer.paymentClicked += new EventHandler(CheckButtonHelp);
            this.naviBuyer.deliveryClicked += new EventHandler(CheckButtonHelp);
            this.naviBuyer.purchaseClicked += new EventHandler(CheckButtonHelp);
            this.naviSelect.buyerClick += new EventHandler(Buyer_Click);
            this.naviSelect.sellerClick += new EventHandler(Seller_Click);
            this.helpTopics.backBtClickHelp += new EventHandler(BackHelp_Click);
            this.naviSeller.caseClicked += new EventHandler(CheckButtonHelp);
            this.naviSeller.promoClicked += new EventHandler(CheckButtonHelp);
            this.naviSeller.commmissionsClicked += new EventHandler(CheckButtonHelp);
            this.userPanel.SendCase += new EventHandler(SendBt_Click);
            this.oldCases.Load += new EventHandler(OldCases_Load);
            this.oldCases.CasesListBox.Click += new EventHandler(CasesListBox_Clicked);


        }

        private void UserForm_Load(object sender, EventArgs e)
        {


            AddControls();
            Appearence();

            resultsUC.Visible = true;

            helpTopics.Visible = false;
            oldCases.Visible = false;
            userPanel.Visible = false;
            helpTopics.Dock = DockStyle.Fill;
            userPanel.Dock = DockStyle.Fill;
            oldCases.Dock = DockStyle.Fill;

            HideControls();


            userTextData.UserId = UserID;
            userCaseData.UserId = UserID;


        }



        private void OpenCaseBt_Click(object sender, EventArgs e)
        {

            resultsUC.Visible = false;
            userPanel.Visible = true;
            helpTopics.Visible = false;

            oldCases.Visible = false;


            using (db = new ProjectDB())
            {



                var fillQuery = (from user in db.Transactions
                                 where user.UserId == UserID
                                 select user).ToList();


                userPanel.ComboBox1.DataSource = fillQuery;
                userPanel.ComboBox1.ValueMember = "TransactionId";


            }
            db.Dispose();

        }



        private void SendBt_Click(object sender, EventArgs e)
        {
            userTextData.UserText = userPanel.DescriptionRT.Text;
            userCaseData.CaseName = userPanel.TitleTx.Text.Trim();
            userCaseData.TransactionId = Int32.Parse(userPanel.ComboBox1.Text);
            userCaseData.CaseStatus = "Open";


            using (db = new ProjectDB())
            {

                db.CaseTab.Add(userCaseData);
                db.SaveChanges();
                int lastId = db.CaseTab.Max(p => p.CaseId);



                userTextData.CaseId = lastId;


                db.UserChat.Add(userTextData);
                db.SaveChanges();



            }
            MessageBox.Show("Złożone", "ok", MessageBoxButtons.OK);
            db.Dispose();

        }



        private void Buyer_Click(object sender, EventArgs e)
        {
            naviSelect.Visible = false;
            naviBuyer.Visible = true;
        }
        private void Seller_Click(object sender, EventArgs e)
        {
            naviSelect.Visible = false;
            naviSeller.Visible = true;
        }

        private void BackHelp_Click(object sender, EventArgs e)
        {
            naviBuyer.Visible = false;
            naviSeller.Visible = false;
            naviSelect.Visible = true;
        }

        private void CheckButtonHelp(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string s = button.Tag.ToString();
            using (db = new ProjectDB())
            {
                foreach (var type in Enum.GetValues(typeof(AnswearType)))
                {
                    if (type.ToString() == s)
                    {

                        var findQuery = (from user in db.Answears
                                         where user.AnswearType == s
                                         select user.AnswearText).FirstOrDefault();

                        helpTopics.AnswearRT.Text = findQuery;

                    }


                }


            }


        }




        private void ShowHelpBt_Click(object sender, EventArgs e)
        {
            helpTopics.Visible = true;
            oldCases.Visible = false;
            userPanel.Visible = false;
            resultsUC.Visible = false;

        }




        private void NaviUserPanel_Paint(object sender, PaintEventArgs e)
        {


            using (db = new ProjectDB())
            {
                var userName = (from user in db.Users
                                where user.UserId == UserID
                                select user.UserName).FirstOrDefault();

                userNameLb.Text = "Hi, " + userName + "!";

            }

            db.Dispose();


        }

        private void OldCaseBt_Click(object sender, EventArgs e)
        {
            oldCases.Visible = true;
            userPanel.Visible = false;
            helpTopics.Visible = false;
            resultsUC.Visible = false;

        }


        private void HideControls()
        {
            if (oldCases.Visible == true)
            {
                userPanel.Visible = false;
                helpTopics.Visible = false;
            }
            else if (userPanel.Visible == true)
            {
                helpTopics.Visible = false;
                oldCases.Visible = false;
            }
            else if (helpTopics.Visible == true)
            {
                userPanel.Visible = (oldCases.Visible == false);
            }
        }


        private void OldCases_Load(object sender, EventArgs e)
        {


            using (db = new ProjectDB())
            {
                var getData = (from user in db.CaseTab
                               where user.UserId == UserID
                               select user).ToList();

                oldCases.CasesListBox.DataSource = getData;
                oldCases.CasesListBox.DisplayMember = "CaseName";
                oldCases.CasesListBox.ValueMember = "CaseStatus";

            }
            db.Dispose();

        }

        private void CasesListBox_Clicked(object a, EventArgs e)
        {

            oldCases.StatusLb.Text = oldCases.CasesListBox.GetItemText(oldCases.CasesListBox.SelectedValue);
            oldCases.TitleLb.Text = oldCases.CasesListBox.GetItemText(oldCases.CasesListBox.SelectedItem);

            GetRespondRtText();


        }


        private void GetRespondRtText()
        {
            oldCases.ReplyRt.Text = "";
            string Title = oldCases.CasesListBox.GetItemText(oldCases.CasesListBox.SelectedItem);

            using (db = new ProjectDB())
            {


                var getUserText = (from user in db.UserChat
                                   where Title == user.CaseTab.CaseName
                                   select user.UserText).ToArray();




                var getAdminText = (from admin in db.AdminChat
                                    where Title == admin.CaseTab.CaseName
                                    select admin.AdminText).ToArray();



                var displayChat = getUserText.Zip(getAdminText, (user, admin) => new { User = user, Admin = admin });
                foreach (var item in displayChat)
                {
                    if (item.User != null)
                    {
                        oldCases.ReplyRt.SelectionAlignment = HorizontalAlignment.Left;
                        oldCases.ReplyRt.AppendText(item.User + "\r\n");
                        oldCases.ReplyRt.AppendText("You \r\n");
                    }
                    if (item.Admin != null)
                    {
                        oldCases.ReplyRt.SelectionAlignment = HorizontalAlignment.Right;
                        oldCases.ReplyRt.AppendText(item.Admin + "\r\n");
                        oldCases.ReplyRt.AppendText("Admin \r\n");
                    }

                }

            }
            db.Dispose();

        }



        private void SearchClick_Click(object sender, EventArgs e)
        {

            SearchTopics();
        }


        private void SearchTopics()
        {

            string searchText = searchTx.Text;

            List<string> splitSearchList = new List<string>();

            splitSearchList = searchText.Split(' ').ToList();//\u0020

            resultsUC.Visible = true;
            helpTopics.Visible = false;
            oldCases.Visible = false;
            userPanel.Visible = false;


            List<string> Description = new List<string>();
            List<string> Title = new List<string>();



            using (db = new ProjectDB())
            {


                foreach (string element in splitSearchList)
                {
                    var searchResults = (from search in db.Answears
                                         where search.AnswearText.Contains(element)
                                         select new
                                         {
                                             resText = search.AnswearText,
                                             resTitle = search.AnswearTitle
                                         }).ToHashSet();


                    foreach (var search in searchResults.Select(b => new { b.resText, b.resTitle }).ToList())
                    {


                        Description.Add(search.resText);
                        Title.Add(search.resTitle);

                    }


                }

                int resultsCount = Title.Count();

                ResultsPanelFill(resultsCount, Title, Description);

            }
        }



        private void ResultsPanelFill(int count, List<string> title, List<string> description)
        {
            resultsUC.ResultsFlowPanel.Controls.Clear();
            resultBox[] resultsList = new resultBox[count];

            for (int i = 0; i < resultsList.Length; i++)
            {
                resultsList[i] = new resultBox();
                resultsList[i].ResultBoxTx.Text = description[i];
                resultsList[i].ResultBoxTitle.Text = title[i];
            }

            foreach (resultBox item in resultsList)
            {
                resultsUC.ResultsFlowPanel.Controls.Add(item);
            }


        }


        public void Appearence()
        {

            this.panel2.BackColor = Colors.ColorsList[5];
            this.naviUserPanel.BackColor = Colors.ColorsList[4];
            this.searchTx.BackColor = Color.White;
            this.ForeColor = Colors.ColorsList[3];
            this.BackColor = Colors.ColorsList[7];
            this.AutoScaleMode = AutoScaleMode.None;
            this.resultsUC.ResultsFlowPanel.BackColor = Colors.ColorsList[7];
            this.helpTopics.BackColor = Colors.ColorsList[7];
            this.helpTopics.ForeColor = Colors.ColorsList[3];
            this.helpTopics.NaviPanel.BorderStyle = BorderStyle.None;
            this.helpTopics.AnswearRT.BackColor = Colors.ColorsList[7];
            this.helpTopics.AnswearRT.ForeColor = Colors.ColorsList[3];
            this.helpTopics.AnswearRT.ReadOnly = true;
            this.searchTx.BackColor = Colors.ColorsList[4];
            this.searchTx.ForeColor = Colors.ColorsList[3];

        }


        bool mouseDown;
        Point mousePos;


        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            mousePos.X = e.X;
            mousePos.Y = e.Y;
            mouseDown = true;
        }



        private void LoginForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {

                Point currentPos = PointToScreen(e.Location);
                Location = new Point(currentPos.X - mousePos.X, currentPos.Y - mousePos.Y);
            }
        }




        private void AddControls()
        {
            panel1.Controls.Add(resultsUC);
            panel1.Controls.Add(helpTopics);
            panel1.Controls.Add(oldCases);
            panel1.Controls.Add(userPanel);
        }

        private void SetDockHide(UserControl cont)
        {
            helpTopics.NaviPanel.Controls.Add(cont);
            cont.Dock = DockStyle.Fill;
            cont.Visible = false;
            if (cont.Name == naviSelect.Name)
            {
                cont.Visible = true;
            }

        }
        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

    }



}

