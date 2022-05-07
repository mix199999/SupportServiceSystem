using System.Windows.Forms;

namespace ProjectSupport
{
    partial class sellerUserControl
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
            this.promotingBt = new System.Windows.Forms.Button();
            this.commissionsBt = new System.Windows.Forms.Button();
            this.casesBt = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.promotingBt);
            this.panel1.Controls.Add(this.commissionsBt);
            this.panel1.Controls.Add(this.casesBt);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 326);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // promotingBt
            // 
            this.promotingBt.Location = new System.Drawing.Point(22, 212);
            this.promotingBt.Name = "promotingBt";
            this.promotingBt.Size = new System.Drawing.Size(163, 88);
            this.promotingBt.TabIndex = 2;
            this.promotingBt.Text = "Methods of promoting offers";
            this.promotingBt.UseVisualStyleBackColor = true;
            this.promotingBt.Click += new System.EventHandler(this.promotingBt_Click);
            // 
            // commissionsBt
            // 
            this.commissionsBt.Location = new System.Drawing.Point(22, 118);
            this.commissionsBt.Name = "commissionsBt";
            this.commissionsBt.Size = new System.Drawing.Size(163, 88);
            this.commissionsBt.TabIndex = 1;
            this.commissionsBt.Text = "Commissions";
            this.commissionsBt.UseVisualStyleBackColor = true;
            this.commissionsBt.Click += new System.EventHandler(this.commissionsBt_Click);
            // 
            // casesBt
            // 
            this.casesBt.Location = new System.Drawing.Point(22, 24);
            this.casesBt.Name = "casesBt";
            this.casesBt.Size = new System.Drawing.Size(163, 88);
            this.casesBt.TabIndex = 0;
            this.casesBt.Text = "Cases";
            this.casesBt.UseVisualStyleBackColor = true;
            this.casesBt.Click += new System.EventHandler(this.casesBt_Click);
            // 
            // sellerUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "sellerUserControl";
            this.Size = new System.Drawing.Size(204, 327);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button casesBt;
        private System.Windows.Forms.Button promotingBt;
        private System.Windows.Forms.Button commissionsBt;

        public Panel Panel1 { get => panel1; set => panel1 = value; }
        public Button PromotingBt { get => promotingBt; set => promotingBt = value; }
        public Button CommissionsBt { get => commissionsBt; set => commissionsBt = value; }
        public Button CasesBt { get => casesBt; set => casesBt = value; }
    }
}
