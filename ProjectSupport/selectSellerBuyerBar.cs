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
        public EventHandler buyerClick;
        public EventHandler sellerClick;

       

        public sellerUserControl sellerPanel = new sellerUserControl();
        public buyerUserControl buyerPanel = new buyerUserControl();
        public selectSellerBuyerBar()
        {
            InitializeComponent();


           
            foreach (var button in buyerPanel.Controls.OfType<Button>())
            {
                button.BackColor = Colors.ColorsList[7];
                button.FlatAppearance.BorderColor = Colors.ColorsList[3];
            }
            foreach (var button in sellerPanel.Controls.OfType<Button>())
            {
                button.BackColor = Colors.ColorsList[7];
                button.FlatAppearance.BorderColor = Colors.ColorsList[3];
            }

        }

        private void buyerBt_Click(object sender, EventArgs e)
        {
            EventHandler buyer = buyerClick;
            buyer?.Invoke(this, EventArgs.Empty);

           
        }

        private void sellerBt_Click(object sender, EventArgs e)
        {
           EventHandler seller = sellerClick;
            seller?.Invoke(this, EventArgs.Empty);
        }

        private void naviPanelSellBuy_Paint(object sender, PaintEventArgs e)
        {
            foreach (var button in Controls.OfType<Button>())
            {
                button.BackColor = Colors.ColorsList[7];
                button.FlatAppearance.BorderColor = Colors.ColorsList[3];
            }
            naviPanelSellBuy.Controls.Add(buyerPanel);
            buyerPanel.Dock = DockStyle.Fill;
            buyerPanel.Visible = false;
            sellerPanel.Dock = DockStyle.Fill;
            sellerPanel.Visible = false;

            naviPanelSellBuy.Controls.Add(sellerPanel);
            

        }
    }
}
