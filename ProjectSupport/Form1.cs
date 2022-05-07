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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        UserCreateCase userPanel = new UserCreateCase();

        private void Form1_Load(object sender, EventArgs e)
        {
            userPanel.Dock = DockStyle.Fill;
            userPanel.BackColor = Color.Gray;
            panel1.Controls.Add(userPanel);
            if (userPanel.IsLoggedIn == true)
            {
                
            }
        }
    }
    
}
