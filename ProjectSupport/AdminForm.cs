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
   
    public partial class AdminForm : Form
    {

        private int _userId;
        public int UserID
        {
            get { return _userId; }
            set { _userId = value; }
        }

        ProjectDB adminDB = new ProjectDB();
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
           
            caseTabBindingSource1.DataSource = adminDB.CaseTab.ToList();
            label1.Text = UserID.ToString();


        }

        private async void SaveBt_Click(object sender, EventArgs e)
        {
            
            try
            {
                caseTabBindingSource1.EndEdit();
                await adminDB.SaveChangesAsync();
                dataGridView1.Refresh();
                MessageBox.Show("text Added","message", MessageBoxButtons.OK);
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void InsertBt_Click(object sender, EventArgs e)
        {
            try
            {
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void caseTabBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
