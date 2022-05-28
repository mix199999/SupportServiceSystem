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
        public UserCasesUC userCases = new UserCasesUC();
        public UserForm()
        {


            InitializeComponent();
            SetDockHide(naviSelect);
            SetDockHide(naviBuyer);
            SetDockHide(naviSeller);
            

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
            this.userCases.Load += new EventHandler(OldCases_Load);
            this.userCases.CasesListBox.Click += new EventHandler(CasesListBox_Clicked);
            this.userCases.replyBtClicked += new EventHandler(SendUserReply);
            


        }
       
        private void UserForm_Load(object sender, EventArgs e)
        {


            AddControls();
            Appearence();

            resultsUC.Visible = true;

            helpTopics.Visible = false;
            userCases.Visible = false;
            userPanel.Visible = false;
            helpTopics.Dock = DockStyle.Fill;
            userPanel.Dock = DockStyle.Fill;
            userCases.Dock = DockStyle.Fill;

            HideControls();


            userTextData.UserId = UserID;
            userCaseData.UserId = UserID;

            
           

        }

       

        private void OpenCaseBt_Click(object sender, EventArgs e)
        {

            resultsUC.Visible = false;
            userPanel.Visible = true;
            helpTopics.Visible = false;

            userCases.Visible = false;


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
            userCases.Visible = false;
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
            userCases.Visible = true;
            userPanel.Visible = false;
            helpTopics.Visible = false;
            resultsUC.Visible = false;

        }


        private void HideControls()
        {
            if (userCases.Visible == true)
            {
                userPanel.Visible = false;
                helpTopics.Visible = false;
            }
            else if (userPanel.Visible == true)
            {
                helpTopics.Visible = false;
                userCases.Visible = false;
            }
            else if (helpTopics.Visible == true)
            {
                userPanel.Visible = (userCases.Visible == false);
            }
        }


        private void OldCases_Load(object sender, EventArgs e)
        {

            
            using (db = new ProjectDB())
            {
                var getData = (from user in db.CaseTab
                               where user.UserId == UserID
                               select user).ToList();

                userCases.CasesListBox.DataSource = getData;
                userCases.CasesListBox.DisplayMember = "CaseName";
                userCases.CasesListBox.ValueMember = "CaseStatus";

            }
            db.Dispose();

        }

        private void CasesListBox_Clicked(object a, EventArgs e)
        {
            GetCaseId();
            
            label1.Text = userTextData.CaseId.ToString();
            userCases.StatusLb.Text = userCases.CasesListBox.GetItemText(userCases.CasesListBox.SelectedValue);
            userCases.TitleLb.Text = userCases.CasesListBox.GetItemText(userCases.CasesListBox.SelectedItem);
            string status = userCases.StatusLb.Text;
            if (status == "Closed")
            {
                userCases.ReplyBt.Visible = true;
                userCases.UserReplyRt.Visible = true;

            }
            else if (status == "Open")
            {
                userCases.ReplyBt.Visible = false;
                userCases.UserReplyRt.Visible = false;
            }
            GetRespondRtText();



        }


        private void GetRespondRtText()
        {
            userCases.ReplyRt.Text = "";
            string title = userCases.CasesListBox.GetItemText(userCases.CasesListBox.SelectedItem);
          


            using (db = new ProjectDB())
            {


                var getUserText = (from casee in db.CaseTab
                                   join user in db.UserChat on casee.UserId equals user.UserId
                                   where user.CaseTab.CaseName == title
                                   orderby user.DialogId
                                   select user.UserText
                                   ).ToHashSet().ToArray();



                var getAdminText = (from casee in db.CaseTab
                                    join admin in db.AdminChat on casee.CaseId equals admin.CaseId
                                    where admin.CaseTab.CaseName == title 
                                    orderby admin.DialogId
                                    select admin.AdminText).ToHashSet().ToArray();


                IEnumerable<string> userTextArray = getUserText;
                IEnumerable<string> adminTextArray = getAdminText;

                if (getUserText.Length < getAdminText.Length)
                {
                    userTextArray = getUserText.Concat(Enumerable.Repeat("", getAdminText.Length - getUserText.Length));
                    var displayChat1 = getUserText.Zip(userTextArray, (user, admin) => new { User = user, Admin = admin });
                    foreach (var item in displayChat1)
                    {
                        if(item.User != "")
                        {
                            userCases.ReplyRt.SelectionAlignment = HorizontalAlignment.Left;
                            userCases.ReplyRt.AppendText(item.User + "\r\n");
                            userCases.ReplyRt.AppendText("You \r\n");

                        }
                        


                        if(item.Admin != "")
                        {
                            userCases.ReplyRt.SelectionAlignment = HorizontalAlignment.Right;
                            userCases.ReplyRt.AppendText(item.Admin + "\r\n");
                            userCases.ReplyRt.AppendText("Admin \r\n");

                        }


                    }
                }

                else if(getUserText.Length > getAdminText.Length)
                {
                    adminTextArray = getAdminText.Concat(Enumerable.Repeat("", getUserText.Length - getAdminText.Length));

                    var displayChat2 = getUserText.Zip(adminTextArray, (user, admin) => new { User = user, Admin = admin });
                    foreach (var item in displayChat2)
                    {
                        if (item.User != "")
                        {
                            userCases.ReplyRt.SelectionAlignment = HorizontalAlignment.Left;
                            userCases.ReplyRt.AppendText(item.User + "\r\n");
                            userCases.ReplyRt.AppendText("You \r\n");

                        }



                        if (item.Admin != "")
                        {
                            userCases.ReplyRt.SelectionAlignment = HorizontalAlignment.Right;
                            userCases.ReplyRt.AppendText(item.Admin + "\r\n");
                            userCases.ReplyRt.AppendText("Admin \r\n");

                        }


                    }
                }


                else
                {
                    var displayChat3 = getUserText.Zip(getAdminText, (user, admin) => new { User = user, Admin = admin });
                    foreach (var item in displayChat3)
                    {
                        if (item.User != "")
                        {
                            userCases.ReplyRt.SelectionAlignment = HorizontalAlignment.Left;
                            userCases.ReplyRt.AppendText(item.User + "\r\n");
                            userCases.ReplyRt.AppendText("You \r\n");

                        }



                        if (item.Admin != "")
                        {
                            userCases.ReplyRt.SelectionAlignment = HorizontalAlignment.Right;
                            userCases.ReplyRt.AppendText(item.Admin + "\r\n");
                            userCases.ReplyRt.AppendText("Admin \r\n");

                        }


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
            userCases.Visible = false;
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
            this.userCases.ReplyBt.Visible = false;
            this.userCases.UserReplyRt.Visible = false;
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
            panel1.Controls.Add(userCases);
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
        private void SendUserReply(object s, EventArgs e)
        {
            if (!String.IsNullOrEmpty(userCases.UserReplyRt.Text))
            {
              
                string caseTitle = userCases.CasesListBox.GetItemText(userCases.CasesListBox.SelectedItem);
                userTextData.UserText = userCases.UserReplyRt.Text;
               
                label1.Text = userTextData.CaseId.ToString();



                using (db = new ProjectDB())
                {



                    var insertUserText = (from user in db.UserChat
                                          where user.UserId == userTextData.UserId
                                          select user.UserId).ToHashSet().SingleOrDefault();

                    var updateCaseStatus = (from casee in db.CaseTab
                                            where casee.CaseId == userTextData.CaseId
                                            select casee.CaseStatus).SingleOrDefault();
                   
                    if (insertUserText != null)
                    {
                        if(insertUserText.Value != 0)
                        label2.Text = "ok";
                        updateCaseStatus = "Open";
                        db.UserChat.Add(userTextData);
                        db.SaveChanges();
                        userCases.ReplyBt.Visible = false;
                        userCases.UserReplyRt.Visible = false;
                        userCases.Refresh();


                    }




                }
                db.Dispose();
            }
        }

        private void GetCaseId()
        {
            string caseTitle = userCases.CasesListBox.GetItemText(userCases.CasesListBox.SelectedItem);
            using (db = new ProjectDB())
            {
                var getCaseId = (from user in db.UserChat
                                 where user.CaseTab.CaseName == caseTitle && user.UserId == userTextData.UserId
                                 select user.CaseId).ToHashSet().SingleOrDefault();

                if (getCaseId != null)
                {

                    userTextData.CaseId = getCaseId;
                }
                else
                    userTextData.CaseId = 0;
                
                
            }

            



        }

    }
   



}

