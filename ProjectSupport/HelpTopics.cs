using System;
using System.Windows.Forms;

namespace ProjectSupport
{


    public partial class HelpTopics : UserControl
    {
        public EventHandler backBtClickHelp;

        public selectSellerBuyerBar naviSelect = new selectSellerBuyerBar();
        public sellerUserControl naviSeller = new sellerUserControl();
        public buyerUserControl naviBuyer = new buyerUserControl();


        public HelpTopics()
        {
         
           
            //naviPanel.Controls.Add(naviSelect);

            //naviPanel.Controls.Add(naviSeller);
            //naviPanel.Controls.Add(naviBuyer);
            InitializeComponent();
            setDockHide(naviSelect);
            setDockHide(naviBuyer);
            setDockHide(naviSeller);


        }

        private void naviPanel_paint(object sender, PaintEventArgs e)
        {


        }

        private void faqUserControl_Load(object sender, EventArgs e)
        {

        }

        private void backBt_Click(object sender, EventArgs e)
        {
            EventHandler click = backBtClickHelp;
            click?.Invoke(this, e);
        }

        private void setDockHide(UserControl cont)
        {
            naviPanel.Controls.Add(cont);
            cont.Dock = DockStyle.Fill;
            cont.Visible = false;
            if(cont.Name ==naviSelect.Name)
            {
                cont.Visible = true;
            }

        }

       
    }
}
