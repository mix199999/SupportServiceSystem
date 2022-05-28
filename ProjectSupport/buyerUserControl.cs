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
        public EventHandler purchaseClicked;
        public EventHandler paymentClicked;
        public EventHandler deliveryClicked;

       

        public buyerUserControl()
        {
            InitializeComponent();

        }
      
       
        //protected virtual void OnButtonClicked(EventArgs e)
        //{
        //    EventHandler handler = ButtonClicked;
        //    handler?.Invoke(this, e);

        //}
        private void purchaseBt_Click(object sender, EventArgs e)
        {

            Button button = sender as Button;
            button.Tag = AnswearType.buyerPurchase;
            object tag = button.Tag;
            EventHandler handler = purchaseClicked;
            handler?.Invoke(button, e);


        }

        private void paymentBt_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Tag = AnswearType.buyerPayment;
            object tag = button.Tag;
            EventHandler handler = paymentClicked;
            handler?.Invoke(button, e);
        }

        private void deliveryBt_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Tag = AnswearType.buyerDelivery;
            object tag = button.Tag;
            EventHandler handler = deliveryClicked;
            handler?.Invoke(button, e);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
             foreach (var button in Controls.OfType<Button>())
            {
                button.BackColor = Colors.ColorsList[7];
                button.FlatAppearance.BorderColor = Colors.ColorsList[3];
            }
        }
    }
}
