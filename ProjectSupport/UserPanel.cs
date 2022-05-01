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
    public partial class UserPanel : UserControl
    {
        public bool IsLoggedIn { get; set; }
        public UserPanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            IsLoggedIn = true;

        }
    }
}
