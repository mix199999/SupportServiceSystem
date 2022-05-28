using System.Windows.Forms;

namespace ProjectSupport
{
    partial class HelpTopics
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
            this.answearRT = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.naviPanel = new System.Windows.Forms.Panel();
            this.backBt = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.answearRT);
            this.panel1.Location = new System.Drawing.Point(347, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(616, 484);
            this.panel1.TabIndex = 0;
            // 
            // answearRT
            // 
            this.answearRT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.answearRT.Location = new System.Drawing.Point(3, 0);
            this.answearRT.Name = "answearRT";
            this.answearRT.Size = new System.Drawing.Size(610, 481);
            this.answearRT.TabIndex = 0;
            this.answearRT.Text = "";
            this.answearRT.TextChanged += new System.EventHandler(this.answearRT_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "All help topics";
            // 
            // naviPanel
            // 
            this.naviPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.naviPanel.Location = new System.Drawing.Point(64, 150);
            this.naviPanel.Name = "naviPanel";
            this.naviPanel.Size = new System.Drawing.Size(204, 326);
            this.naviPanel.TabIndex = 6;
            this.naviPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.naviPanel_paint);
            // 
            // backBt
            // 
            this.backBt.AutoSize = true;
            this.backBt.Location = new System.Drawing.Point(236, 479);
            this.backBt.Name = "backBt";
            this.backBt.Size = new System.Drawing.Size(51, 20);
            this.backBt.TabIndex = 7;
            this.backBt.Text = "Back";
            this.backBt.Click += new System.EventHandler(this.backBt_Click);
            // 
            // HelpTopics
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.backBt);
            this.Controls.Add(this.naviPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.Name = "HelpTopics";
            this.Size = new System.Drawing.Size(1021, 629);
            this.Load += new System.EventHandler(this.faqUserControl_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel naviPanel;
        private System.Windows.Forms.Label backBt;
        private RichTextBox answearRT;

        public Panel Panel1 { get => panel1; set => panel1 = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public Panel NaviPanel { get => naviPanel; set => naviPanel = value; }
        public Label BackBt { get => backBt; set => backBt = value; }
        public RichTextBox AnswearRT { get => answearRT; set => answearRT = value; }
    }
}
