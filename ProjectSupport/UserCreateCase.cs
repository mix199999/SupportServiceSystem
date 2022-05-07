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
    public partial class UserCreateCase : UserControl
    {
        public EventHandler SendCase;
        public bool IsLoggedIn { get; set; }
        public UserCreateCase()
        {
            InitializeComponent();
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void sendBt_Click(object sender, EventArgs e)
        {
           
            EventHandler handler = SendCase;
            handler?.Invoke(this, e);
        }

        private void UserCreateCase_Load(object sender, EventArgs e)
        {

        }
    }
}
