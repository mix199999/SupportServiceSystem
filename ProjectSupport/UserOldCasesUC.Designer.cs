using System.Windows.Forms;

namespace ProjectSupport
{
    partial class UserOldCasesUC
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
            this.replyBt = new System.Windows.Forms.Button();
            this.yourCasesLb = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.replyRt = new System.Windows.Forms.RichTextBox();
            this.statusLb = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.titleLb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.casesListBox = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // replyBt
            // 
            this.replyBt.FlatAppearance.BorderSize = 3;
            this.replyBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.replyBt.Location = new System.Drawing.Point(584, 489);
            this.replyBt.Name = "replyBt";
            this.replyBt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.replyBt.Size = new System.Drawing.Size(104, 51);
            this.replyBt.TabIndex = 1;
            this.replyBt.Text = "Reply";
            this.replyBt.UseVisualStyleBackColor = true;
            this.replyBt.Click += new System.EventHandler(this.replyBt_Click);
            // 
            // yourCasesLb
            // 
            this.yourCasesLb.AutoSize = true;
            this.yourCasesLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.yourCasesLb.Location = new System.Drawing.Point(64, 59);
            this.yourCasesLb.Name = "yourCasesLb";
            this.yourCasesLb.Size = new System.Drawing.Size(112, 24);
            this.yourCasesLb.TabIndex = 3;
            this.yourCasesLb.Text = "Your Cases:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.replyRt);
            this.panel1.Controls.Add(this.statusLb);
            this.panel1.Controls.Add(this.replyBt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.titleLb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(250, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 571);
            this.panel1.TabIndex = 4;
            // 
            // replyRt
            // 
            this.replyRt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.replyRt.Location = new System.Drawing.Point(96, 85);
            this.replyRt.Name = "replyRt";
            this.replyRt.Size = new System.Drawing.Size(410, 280);
            this.replyRt.TabIndex = 5;
            this.replyRt.Text = "";
            // 
            // statusLb
            // 
            this.statusLb.AutoSize = true;
            this.statusLb.Location = new System.Drawing.Point(565, 45);
            this.statusLb.Name = "statusLb";
            this.statusLb.Size = new System.Drawing.Size(82, 20);
            this.statusLb.TabIndex = 3;
            this.statusLb.Text = "statusLb";
            this.statusLb.Click += new System.EventHandler(this.statusLb_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(502, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Status:";
            // 
            // titleLb
            // 
            this.titleLb.AutoSize = true;
            this.titleLb.Location = new System.Drawing.Point(312, 11);
            this.titleLb.Name = "titleLb";
            this.titleLb.Size = new System.Drawing.Size(62, 20);
            this.titleLb.TabIndex = 1;
            this.titleLb.Text = "titleLb";
            this.titleLb.Click += new System.EventHandler(this.titleLb_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Title:";
            // 
            // casesListBox
            // 
            this.casesListBox.FormattingEnabled = true;
            this.casesListBox.ItemHeight = 20;
            this.casesListBox.Location = new System.Drawing.Point(19, 97);
            this.casesListBox.Name = "casesListBox";
            this.casesListBox.Size = new System.Drawing.Size(212, 104);
            this.casesListBox.TabIndex = 5;
            // 
            // UserOldCasesUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.casesListBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.yourCasesLb);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.Name = "UserOldCasesUC";
            this.Size = new System.Drawing.Size(1033, 629);
            this.Load += new System.EventHandler(this.UserOldCasesUC_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button replyBt;
        private System.Windows.Forms.Label yourCasesLb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox replyRt;
        private System.Windows.Forms.Label statusLb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label titleLb;
        private System.Windows.Forms.Label label2;
        private ListBox casesListBox;

        public Button ReplyBt { get => replyBt; set => replyBt = value; }
        public ListBox CasesListBox { get => casesListBox; set => casesListBox = value; }
        public Label YourCasesLb { get => yourCasesLb; set => yourCasesLb = value; }
        public Panel Panel1 { get => panel1; set => panel1 = value; }
        public RichTextBox ReplyRt { get => replyRt; set => replyRt = value; }
        
        public Label StatusLb { get => statusLb; set => statusLb = value; }
        public Label Label4 { get => label4; set => label4 = value; }
        public Label TitleLb { get => titleLb; set => titleLb = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        
       
       
    }
}
