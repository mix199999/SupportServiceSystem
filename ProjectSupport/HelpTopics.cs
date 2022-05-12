using System;
using System.Windows.Forms;
using System.Drawing;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.InteropServices;
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
            //foreach (Control c in this.Controls)
            //{
            //    c.BackColor = Colors.ColorsList[7];
            //    foreach (Control p in c.Controls.OfType<Panel>())
            //    {
            //        p.BackColor = Colors.ColorsList[7];
            //        foreach (Control b in p.Controls.OfType<Button>())
            //        {
            //            b.BackColor = Colors.ColorsList[7];
            //            //c.ForeColor = Colors.ColorsList[3];   //3
            //            //(c as Button).FlatAppearance.BorderColor = Colors.ColorsList[3];
            //            //c.BackColor = Color.Red;
            //        }
            //    }


            //}

          //  naviSelect.BackColor = Color.Red;
            foreach(Control b in naviSelect.Controls)
            {
                if(b is Button)
                b.BackColor = Color.Red;
            }
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

        private void answearRT_TextChanged(object sender, EventArgs e)
        {
            answearRT.ReadOnly = true;
        }
    }
}
