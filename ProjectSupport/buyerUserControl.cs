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
    public partial class buyerUserControl : UserControl
    {
        public bool purchaseBtStance = false;
        public bool paymentBtStance = false;
        //pu
        
        public buyerUserControl()
        {
            InitializeComponent();
        }

        private void purchaseBt_Click(object sender, EventArgs e)
        {
            purchaseBtStance = true;
        }

        private void paymentBt_Click(object sender, EventArgs e)
        {

        }

        private void deliveryBt_Click(object sender, EventArgs e)
        {

        }
    }
}
