using System.Windows.Forms;

namespace ProjectSupport
{
    partial class UserPanel
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
            this.transactionTb = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.titleTx = new System.Windows.Forms.TextBox();
            this.descriptionRT = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // transactionTb
            // 
            this.transactionTb.AutoSize = true;
            this.transactionTb.Location = new System.Drawing.Point(14, 69);
            this.transactionTb.Name = "transactionTb";
            this.transactionTb.Size = new System.Drawing.Size(78, 13);
            this.transactionTb.TabIndex = 1;
            this.transactionTb.Text = "Transaction Id:";
            this.transactionTb.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(108, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Title:";
            // 
            // titleTx
            // 
            this.titleTx.Location = new System.Drawing.Point(108, 39);
            this.titleTx.Name = "titleTx";
            this.titleTx.Size = new System.Drawing.Size(121, 20);
            this.titleTx.TabIndex = 4;
            // 
            // descriptionRT
            // 
            this.descriptionRT.Location = new System.Drawing.Point(108, 117);
            this.descriptionRT.Name = "descriptionRT";
            this.descriptionRT.Size = new System.Drawing.Size(121, 209);
            this.descriptionRT.TabIndex = 5;
            this.descriptionRT.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Description:";
            // 
            // UserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.descriptionRT);
            this.Controls.Add(this.titleTx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.transactionTb);
            this.Name = "UserPanel";
            this.Size = new System.Drawing.Size(325, 360);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label transactionTb;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox titleTx;
        private System.Windows.Forms.RichTextBox descriptionRT;
        private System.Windows.Forms.Label label2;

        public Label TransactionTb { get => transactionTb; set => transactionTb = value; }
        public ComboBox ComboBox1 { get => comboBox1; set => comboBox1 = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public TextBox TitleTx { get => titleTx; set => titleTx = value; }
        public RichTextBox DescriptionRT { get => descriptionRT; set => descriptionRT = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        
    }
}
