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
        public  EventHandler promoClicked;
        public  EventHandler commmissionsClicked;
        public  EventHandler caseClicked;
        public sellerUserControl()
        {
            InitializeComponent();
            promotingBt.BackColor = Colors.ColorsList[7];
            promotingBt.FlatAppearance.BorderColor = Colors.ColorsList[3];


        }

       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            foreach(var b in Controls.OfType<Button>())
            {
                
                b.FlatAppearance.BorderColor= Colors.ColorsList[3];
            }
            panel1.BackColor = Colors.ColorsList[7];
        }

        private void promotingBt_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Tag = AnswearType.sellerPromoting;
            object tag = button.Tag;
            EventHandler handler = promoClicked;
            handler?.Invoke(this, e);
        }

        private void commissionsBt_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Tag = AnswearType.sellerCommissions;
            object tag = button.Tag;
            EventHandler handler = commmissionsClicked;
            handler?.Invoke(this, e);
        }

        private void casesBt_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Tag = AnswearType.sellerCases;
            object tag = button.Tag;
            EventHandler handler = caseClicked;
            handler?.Invoke(this, e);
        }
    }
}
