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
        }
         CaseTab userData = new CaseTab();
        UserPanel userPanel = new UserPanel();
        HelpTopics helpTopics = new HelpTopics();
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




        }

        private void userPanel1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
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
        }
    }
}
