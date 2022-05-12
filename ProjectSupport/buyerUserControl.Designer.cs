using System.Windows.Forms;

namespace ProjectSupport
{
    partial class buyerUserControl
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.deliveryBt = new System.Windows.Forms.Button();
            this.paymentBt = new System.Windows.Forms.Button();
            this.purchaseBt = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.deliveryBt);
            this.panel1.Controls.Add(this.paymentBt);
            this.panel1.Controls.Add(this.purchaseBt);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 326);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // deliveryBt
            // 
            this.deliveryBt.FlatAppearance.BorderSize = 3;
            this.deliveryBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deliveryBt.Location = new System.Drawing.Point(15, 217);
            this.deliveryBt.Name = "deliveryBt";
            this.deliveryBt.Size = new System.Drawing.Size(163, 88);
            this.deliveryBt.TabIndex = 2;
            this.deliveryBt.Text = "Delivery";
            this.deliveryBt.UseVisualStyleBackColor = true;
            this.deliveryBt.Click += new System.EventHandler(this.deliveryBt_Click);
            // 
            // paymentBt
            // 
            this.paymentBt.FlatAppearance.BorderSize = 3;
            this.paymentBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paymentBt.Location = new System.Drawing.Point(15, 123);
            this.paymentBt.Name = "paymentBt";
            this.paymentBt.Size = new System.Drawing.Size(163, 88);
            this.paymentBt.TabIndex = 1;
            this.paymentBt.Text = "Payment";
            this.paymentBt.UseVisualStyleBackColor = true;
            this.paymentBt.Click += new System.EventHandler(this.paymentBt_Click);
            // 
            // purchaseBt
            // 
            this.purchaseBt.FlatAppearance.BorderSize = 3;
            this.purchaseBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.purchaseBt.Location = new System.Drawing.Point(15, 29);
            this.purchaseBt.Name = "purchaseBt";
            this.purchaseBt.Size = new System.Drawing.Size(163, 88);
            this.purchaseBt.TabIndex = 0;
            this.purchaseBt.Text = "Purchase";
            this.purchaseBt.UseVisualStyleBackColor = true;
            this.purchaseBt.Click += new System.EventHandler(this.purchaseBt_Click);
            // 
            // buyerUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel1);
            this.Name = "buyerUserControl";
            this.Size = new System.Drawing.Size(204, 326);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button deliveryBt;
        private System.Windows.Forms.Button paymentBt;
        private System.Windows.Forms.Button purchaseBt;

        public Panel Panel1 { get => panel1; set => panel1 = value; }
        public Button DeliveryBt { get => deliveryBt; set => deliveryBt = value; }
        public Button PaymentBt { get => paymentBt; set => paymentBt = value; }
        public Button PurchaseBt { get => purchaseBt; set => purchaseBt = value; }
    }
}
