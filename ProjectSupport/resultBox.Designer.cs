using System.Windows.Forms;

namespace ProjectSupport
{
    partial class resultBox
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
            this.resultBoxTitle = new System.Windows.Forms.TextBox();
            this.resultBoxTx = new System.Windows.Forms.TextBox();
            this.resultBoxPanel = new System.Windows.Forms.Panel();
            this.resultBoxPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // resultBoxTitle
            // 
            this.resultBoxTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultBoxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.resultBoxTitle.Location = new System.Drawing.Point(17, 16);
            this.resultBoxTitle.Name = "resultBoxTitle";
            this.resultBoxTitle.ReadOnly = true;
            this.resultBoxTitle.Size = new System.Drawing.Size(587, 22);
            this.resultBoxTitle.TabIndex = 0;
            this.resultBoxTitle.Text = "Title";
            // 
            // resultBoxTx
            // 
            this.resultBoxTx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultBoxTx.Location = new System.Drawing.Point(17, 44);
            this.resultBoxTx.Multiline = true;
            this.resultBoxTx.Name = "resultBoxTx";
            this.resultBoxTx.ReadOnly = true;
            this.resultBoxTx.Size = new System.Drawing.Size(587, 44);
            this.resultBoxTx.TabIndex = 1;
            this.resultBoxTx.Text = "Searchtext";
            // 
            // resultBoxPanel
            // 
            this.resultBoxPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultBoxPanel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.resultBoxPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.resultBoxPanel.Controls.Add(this.resultBoxTx);
            this.resultBoxPanel.Controls.Add(this.resultBoxTitle);
            this.resultBoxPanel.Location = new System.Drawing.Point(0, 0);
            this.resultBoxPanel.Name = "resultBoxPanel";
            this.resultBoxPanel.Size = new System.Drawing.Size(610, 98);
            this.resultBoxPanel.TabIndex = 2;
            this.resultBoxPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.resultBoxPanel_Paint);
            // 
            // resultBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.resultBoxPanel);
            this.Name = "resultBox";
            this.Size = new System.Drawing.Size(610, 98);
            this.resultBoxPanel.ResumeLayout(false);
            this.resultBoxPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox resultBoxTitle;
        private System.Windows.Forms.TextBox resultBoxTx;
        private System.Windows.Forms.Panel resultBoxPanel;

        public TextBox ResultBoxTitle { get => resultBoxTitle; set => resultBoxTitle = value; }
        public TextBox ResultBoxTx { get => resultBoxTx; set => resultBoxTx = value; }
        public Panel ResultBoxPanel { get => resultBoxPanel; set => resultBoxPanel = value; }
    }
}
