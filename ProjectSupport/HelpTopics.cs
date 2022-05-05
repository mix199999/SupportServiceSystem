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
   

    public partial class HelpTopics : UserControl
    {
        selectSellerBuyerBar naviSelect = new selectSellerBuyerBar();
        public HelpTopics()
        {
            InitializeComponent();
        }

        private void naviPanel_paint(object sender, PaintEventArgs e)
        {
           
            naviPanel.Controls.Add(naviSelect);
        }

        private void faqUserControl_Load(object sender, EventArgs e)
        {

        }

        private void backBt_Click(object sender, EventArgs e)
        {
            naviPanel.Controls.Clear();
           // naviPanel.Dispose();
            naviSelect = new selectSellerBuyerBar();
            naviPanel.Controls.Add(naviSelect);
        }
    }
}
