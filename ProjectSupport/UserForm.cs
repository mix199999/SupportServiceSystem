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
           

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        
            this.helpTopics.naviBuyer.paymentClicked += new EventHandler(displayHelpPaymentBt);
            this.helpTopics.naviBuyer.deliveryClicked += new EventHandler(displayHelpDeliverytBt);
            this.helpTopics.naviBuyer.purchaseClicked += new EventHandler(displayHelpPurchaseBt);
            this.helpTopics.naviSelect.buyerClick += new EventHandler(buyer_Click);
            this.helpTopics.naviSelect.sellerClick += new EventHandler(seller_Click);
            this.helpTopics.backBtClickHelp += new EventHandler(backHelp_Click);
            this.helpTopics.naviSeller.caseClicked += new EventHandler(displayHelpCasetBt);
            this.helpTopics.naviSeller.promoClicked += new EventHandler(displayHelpPromoBt);
            this.helpTopics.naviSeller.commmissionsClicked += new EventHandler(displayHelpCommissionsBt);
            this.userPanel.SendCase += new EventHandler(sendBt_Click);
            this.oldCases.Load += new EventHandler(OldCases_Load);
            this.oldCases.CasesListBox.Click += new EventHandler(CasesListBox_Clicked);

           

            //this.helpTopics

        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            panel1.Controls.Add(resultsUC);
            panel1.Controls.Add(helpTopics);
            panel1.Controls.Add(oldCases);
            panel1.Controls.Add(userPanel);

            appearence();

            resultsUC.Visible = true;
           
            helpTopics.Visible = false;
            oldCases.Visible = false;
            userPanel.Visible = false;
            helpTopics.Dock = DockStyle.Fill;
            userPanel.Dock = DockStyle.Fill;
            oldCases.Dock = DockStyle.Fill;
           
            
            
           



            // userTextData.Users.UserId = UserID;
             HideControls();

            


            userTextData.UserId = UserID;
            userCaseData.UserId = UserID;


            //dataGridView1.DataSource = fillQuery;
            //dataGridView1.Columns["UserId"].Visible = false;
            //dataGridView1.Columns["Items"].Visible = false;
            //dataGridView1.Columns["Users"].Visible = false;
            //dataGridView1.Columns["ItemId"].Visible = false;
            //dataGridView1.Columns["CaseTab"].Visible = false;





            // checkHelpTopics(helpTopics);

        }



        private void openCaseBt_Click(object sender, EventArgs e)
        {
            //TUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUU
            resultsUC.Visible = false;
            userPanel.Visible = true;
            helpTopics.Visible = false;
            
            oldCases.Visible = false;
            

            using (db = new ProjectDB())
            {



                var fillQuery = (from user in db.Transactions
                                 where user.UserId == UserID
                                 select user).ToList();
                // listBox1.DataSource = fillQuery;

                userPanel.ComboBox1.DataSource = fillQuery;
                userPanel.ComboBox1.ValueMember = "TransactionId";


            }
            db.Dispose();

        }

        

        private void sendBt_Click(object sender, EventArgs e)
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

      

        private void buyer_Click(object sender, EventArgs e)
        {
            helpTopics.naviSelect.Visible = false;
            helpTopics.naviBuyer.Visible = true;
        }
        private void seller_Click(object sender, EventArgs e)
        {
            helpTopics.naviSelect.Visible = false;
            helpTopics.naviSeller.Visible = true;
        }

        private void backHelp_Click(object sender, EventArgs e)
        {
            helpTopics.naviBuyer.Visible = false;
            helpTopics.naviSeller.Visible = false;
            helpTopics.naviSelect.Visible = true;
        }

        //200iq but i m still working on that
        private void displayHelpPaymentBt(object sender, EventArgs e)
        {

            checkButtonHelp(helpTopics.naviBuyer.PaymentBt);


        }
        private void displayHelpPurchaseBt(object sender, EventArgs e)
        {

            checkButtonHelp(helpTopics.naviBuyer.PurchaseBt);


        }
        private void displayHelpDeliverytBt(object sender, EventArgs e)
        {

            checkButtonHelp(helpTopics.naviBuyer.DeliveryBt);


        }

        private void displayHelpCasetBt(object s, EventArgs e)
        {
            checkButtonHelp(helpTopics.naviSeller.CasesBt);
        }
        private void displayHelpPromoBt(object s, EventArgs e)
        {
            checkButtonHelp(helpTopics.naviSeller.PromotingBt);
        }
        private void displayHelpCommissionsBt(object s, EventArgs e)
        {
            checkButtonHelp(helpTopics.naviSeller.CommissionsBt);
        }

        //i was wrong that is 1000iq
        private void checkButtonHelp(Button button)
        {

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




        private void showHelpBt_Click(object sender, EventArgs e)
        {
            helpTopics.Visible = true;
            oldCases.Visible = false;
            userPanel.Visible = false;
            resultsUC.Visible = false;

        }

        private void userNameLb_Click(object sender, EventArgs e)
        {

           
        }

        
            private void naviUserPanel_Paint(object sender, PaintEventArgs e)
             {
                

                            using (db = new ProjectDB())
                            {
                                var userName = (from user in db.Users
                                where user.UserId == UserID
                                select user.UserName).FirstOrDefault();

                            userNameLb.Text ="Hi, " + userName +"!" ;

                            }

           
            }

        private void oldCaseBt_Click(object sender, EventArgs e)
        {
            oldCases.Visible = true;
            userPanel.Visible = false;
            helpTopics.Visible = false;
            
        }


        private void HideControls()
        {
            if(oldCases.Visible == true)
            {
                userPanel.Visible=false;
                helpTopics.Visible=false;
            }
            else if(userPanel.Visible == true)
            {
                helpTopics.Visible=false;
                oldCases.Visible=false;
            }
            else if(helpTopics.Visible== true)
            {
                userPanel.Visible=(oldCases.Visible==false);
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
            getRespondRtText();



            //?

        }


        private void getRespondRtText()
        {
            string Title = oldCases.CasesListBox.GetItemText(oldCases.CasesListBox.SelectedItem);
            
            using (db = new ProjectDB())
            {

               
                var getUserText = (from user in db.UserChat
                                   where Title == user.CaseTab.CaseName
                                   select user.UserText).ToArray();




                var getAdminText = (from admin in db.AdminChat
                                   where Title == admin.CaseTab.CaseName
                                   select admin.AdminText).ToArray();

               
                //oldCases.TestList.ValueMember = "CaseStatus";


               
                var displayChat = getUserText.Zip(getAdminText, (user, admin) => new { User = user, Admin = admin });
                foreach (var item in displayChat)
                {
                    if (item.User != null)
                    {
                        oldCases.ReplyRt.SelectionAlignment = HorizontalAlignment.Left;
                        oldCases.ReplyRt.AppendText(item.User +"\r\n");
                        oldCases.ReplyRt.AppendText("You \r\n");
                    }
                    if (item.Admin != null)
                    {
                        oldCases.ReplyRt.SelectionAlignment = HorizontalAlignment.Right;
                        oldCases.ReplyRt.AppendText( item.Admin + "\r\n");
                        oldCases.ReplyRt.AppendText("Admin \r\n");
                    }
                    
                   
                    
                }

                             
                
                
            }
            db.Dispose();
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void searchClick_Click(object sender, EventArgs e)
        {
         
          
            searchTopics();
        }


        private void searchTopics()
        {
           


            string searchText = searchTx.Text;
            
            List<string> splitSearchList = new List<string>();

            splitSearchList = searchText.Split(' ').ToList();//\u0020

            resultsUC.Visible = true;
            helpTopics.Visible = false;
            oldCases.Visible = false;
            userPanel.Visible = false;
            
            //testRt.Text = "";

                                                                                                
            

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
                                         }).ToHashSet(); //200iq
                                       
                           


                    

                    foreach (var search in searchResults.Select(b => new { b.resText, b.resTitle }).ToList()) 
                    {

                        
                        Description.Add(search.resText);
                        Title.Add(search.resTitle);
                       
                    }
                   

                 

                }
                
                


                
                


                int resultsCount = Title.Count();

                resultsPanelFill(resultsCount,Title,Description);

            }
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void resultsPanelFill(int count, List<string> title, List<string> description)
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


        public void appearence()
        {
            //Colors appearanceColors = new Colors();


            
           

            //Color.FromArgb(24, 49, 83), //darkblue0
            //    Color.FromArgb(99, 230, 190),//green1
            //    Color.FromArgb(36, 35, 80),//darkviolet2
            //    Color.FromArgb(22, 160, 133),//darkgreen3
            //    Color.FromArgb(52, 73, 94),//lightblue4
            //    Color.FromArgb(44, 62, 80),//darkblue5
            //    Color.FromArgb(26, 188, 156),//lightgreen6
            //    Color.FromArgb(31, 44, 56)//medium dark blue7

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
            this.searchTx.BackColor= Colors.ColorsList[4];
            this.searchTx.ForeColor= Colors.ColorsList[3];
            
            



            //userNameLb.ForeColor = Color.White;

            // resultsUC.AutoSize = false;
            //helpTopics.AutoSize = false;
            //oldCases.AutoSize = false;
            //userPanel.AutoSize = false;

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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }





    

}

