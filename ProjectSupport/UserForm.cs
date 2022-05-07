using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        private int _userId;
        public int UserID
        {
            get { return _userId; }
            set { _userId = value; }
        }




        UserChat userTextData = new UserChat();
        CaseTab userCaseData = new CaseTab();

        ProjectDB db;
        public UserOldCasesUC oldCases = new UserOldCasesUC();
        public UserForm()
        {


            InitializeComponent();

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
            panel1.Controls.Add(helpTopics);
            helpTopics.Visible = true;
            oldCases.Visible = false;
            userPanel.Visible = false;
            helpTopics.Dock = DockStyle.Fill;
            userPanel.Dock = DockStyle.Fill;
            oldCases.Dock = DockStyle.Fill;
            panel1.Controls.Add(oldCases);
            
            panel1.Controls.Add(userPanel);



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

        private void HelpTopics_Load(object a, EventArgs e)
        {
        
        
        
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




        }


        private void getRespondRtText()
        {
            string Title = oldCases.CasesListBox.GetItemText(oldCases.CasesListBox.SelectedItem);

            using(db = new ProjectDB())
            {

                var getUserText = (from user in db.UserChat
                                  where user.CaseId == user.CaseTab.CaseId
                                 select user.UserText).ToArray();


                //var getAdminText = (from user in db.CaseChat
                //                   where user.CaseTab.CaseName == Title
                //                   select user.AdminText).SingleOrDefault();

                var getAdminText = (from user in db.AdminChat
                                   where user.CaseId == user.CaseTab.CaseId
                                   select user.AdminText).ToArray();

                foreach (var item in getUserText)
                        {
                             oldCases.ReplyRt.AppendText(item);
                            addAdmin();
                        }
               
                    void addAdmin()
                    {
                    
                        foreach (var item in getAdminText)
                        oldCases.ReplyRt.AppendText(item);
                    }
                   
                

                


                //oldCases.RespondsRt.AppendText("Admin:"+getAdminText+"\n");



            }
            db.Dispose();
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }   
} 

