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
    public partial class sellerUserControl : UserControl
    {
        public sellerUserControl()
        {
            InitializeComponent();
        }

        private void backBt_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
