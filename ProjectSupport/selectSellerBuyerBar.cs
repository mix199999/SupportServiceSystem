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

    public partial class selectSellerBuyerBar : UserControl
    {
        sellerUserControl sellerPanel = new sellerUserControl();
        buyerUserControl buyerPanel = new buyerUserControl();
        public selectSellerBuyerBar()
        {
            InitializeComponent();
        }

        private void buyerBt_Click(object sender, EventArgs e)
        {

            buyerPanel.Dock = DockStyle.Fill;
            naviPanelSellBuy.Controls.Clear();
            naviPanelSellBuy.Controls.Add(buyerPanel);
        }

        private void sellerBt_Click(object sender, EventArgs e)
        {
            sellerPanel.Dock = DockStyle.Fill;
            naviPanelSellBuy.Controls.Clear();
            naviPanelSellBuy.Controls.Add(sellerPanel);
        }
    }
}
