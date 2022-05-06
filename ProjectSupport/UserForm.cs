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
        sellerCommissions
    };
    public partial class UserForm : Form
    {
        private int _userId;
        public int UserID
        {
            get { return _userId; }
            set { _userId = value; }
        }







        ProjectDB db;

        public UserForm()
        {
            
           
            InitializeComponent();
            this.helpTopics.naviBuyer.paymentClicked += new EventHandler(displayHelpPaymentBt);
            this.helpTopics.naviBuyer.deliveryClicked += new EventHandler(displayHelpDeliverytBt);
            this.helpTopics.naviBuyer.purchaseClicked += new EventHandler(displayHelpPurchaseBt);
            this.helpTopics.naviSelect.buyerClick += new EventHandler(buyer_Click);
            this.helpTopics.naviSelect.sellerClick += new EventHandler(seller_Click);
            this.helpTopics.backBtClickHelp += new EventHandler(backHelp_Click);
            //this.helpTopics

        }
         
        private void UserForm_Load(object sender, EventArgs e)
        {
            helpTopics.Dock = DockStyle.Fill;
            panel1.Controls.Add(helpTopics);
            userData.UserId = UserID;


            

            //userData.UserId = UserID;

            dataGridView1.Visible = false;

            //dataGridView1.DataSource = fillQuery;
            //dataGridView1.Columns["UserId"].Visible = false;
            //dataGridView1.Columns["Items"].Visible = false;
            //dataGridView1.Columns["Users"].Visible = false;
            //dataGridView1.Columns["ItemId"].Visible = false;
            //dataGridView1.Columns["CaseTab"].Visible = false;


            
           

            // checkHelpTopics(helpTopics);

        }

        private void cos_Click(object sender, EventArgs e)
        {
            helpTopics.AnswearRT.Text = "dupa";
        }

        private void openCaseBt_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            userPanel.Dock = DockStyle.Fill;
            panel1.Controls.Add(userPanel);
            sendBt.Visible = true;
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

        private void sample(object sender, EventArgs e)
        {
            helpTopics.AnswearRT.Text = "cipa";
        }

        private void sendBt_Click(object sender, EventArgs e)
        {
            userData.TransactionId = Int32.Parse(userPanel.ComboBox1.Text);
            userData.CaseStatus = "Open";
           userData.UserText = userPanel.DescriptionRT.Text;
           userData.CaseName= userPanel.TitleTx.Text.Trim();

            using(db = new ProjectDB())
            {
               db.CaseTab.Add(userData);
                db.SaveChanges();

                
            }
            MessageBox.Show("Złożone","ok",MessageBoxButtons.OK);
            db.Dispose();
        }

        private void buyer_Click(object sender, EventArgs e)
        {
            helpTopics.naviSelect.Visible = false;
            helpTopics.naviBuyer.Visible = true;
        }
        private void seller_Click(object sender, EventArgs e)
        {
            helpTopics.naviSelect.Visible=false;
            helpTopics.naviSeller.Visible=true;
        }

        private void backHelp_Click(object sender, EventArgs e)
        {
            helpTopics.naviBuyer.Visible=false;
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

    }
}
