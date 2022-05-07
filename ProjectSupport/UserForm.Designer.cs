namespace ProjectSupport
{
    partial class UserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        //CaseTab userData = new CaseTab();
        UserCreateCase userPanel = new UserCreateCase();
        HelpTopics helpTopics = new HelpTopics();
        
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.openCaseBt = new System.Windows.Forms.Button();
            this.oldCaseBt = new System.Windows.Forms.Button();
            this.showHelpBt = new System.Windows.Forms.Button();
            this.naviUserPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userNameLb = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.naviUserPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(237, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(990, 699);
            this.panel1.TabIndex = 0;
            // 
            // openCaseBt
            // 
            this.openCaseBt.Font = new System.Drawing.Font("Cascadia Code", 12.25F);
            this.openCaseBt.Location = new System.Drawing.Point(10, 357);
            this.openCaseBt.Name = "openCaseBt";
            this.openCaseBt.Size = new System.Drawing.Size(186, 73);
            this.openCaseBt.TabIndex = 3;
            this.openCaseBt.Text = "Open new case";
            this.openCaseBt.UseVisualStyleBackColor = true;
            this.openCaseBt.Click += new System.EventHandler(this.openCaseBt_Click);
            // 
            // oldCaseBt
            // 
            this.oldCaseBt.Font = new System.Drawing.Font("Cascadia Code", 12.25F);
            this.oldCaseBt.Location = new System.Drawing.Point(10, 277);
            this.oldCaseBt.Name = "oldCaseBt";
            this.oldCaseBt.Size = new System.Drawing.Size(186, 73);
            this.oldCaseBt.TabIndex = 5;
            this.oldCaseBt.Text = "Open old cases";
            this.oldCaseBt.UseVisualStyleBackColor = true;
            this.oldCaseBt.Click += new System.EventHandler(this.oldCaseBt_Click);
            // 
            // showHelpBt
            // 
            this.showHelpBt.Font = new System.Drawing.Font("Cascadia Code", 12.25F);
            this.showHelpBt.Location = new System.Drawing.Point(10, 197);
            this.showHelpBt.Name = "showHelpBt";
            this.showHelpBt.Size = new System.Drawing.Size(186, 73);
            this.showHelpBt.TabIndex = 6;
            this.showHelpBt.Text = "Help";
            this.showHelpBt.UseVisualStyleBackColor = true;
            this.showHelpBt.Click += new System.EventHandler(this.showHelpBt_Click);
            // 
            // naviUserPanel
            // 
            this.naviUserPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.naviUserPanel.Controls.Add(this.pictureBox1);
            this.naviUserPanel.Controls.Add(this.userNameLb);
            this.naviUserPanel.Controls.Add(this.showHelpBt);
            this.naviUserPanel.Controls.Add(this.oldCaseBt);
            this.naviUserPanel.Controls.Add(this.openCaseBt);
            this.naviUserPanel.Location = new System.Drawing.Point(2, 2);
            this.naviUserPanel.Name = "naviUserPanel";
            this.naviUserPanel.Size = new System.Drawing.Size(206, 788);
            this.naviUserPanel.TabIndex = 7;
            this.naviUserPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.naviUserPanel_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "C:\\SupportProject\\SupportServiceSystem\\icons\\userIcon.png";
            this.pictureBox1.Location = new System.Drawing.Point(68, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 83);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // userNameLb
            // 
            this.userNameLb.AutoSize = true;
            this.userNameLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.userNameLb.Location = new System.Drawing.Point(0, 145);
            this.userNameLb.MinimumSize = new System.Drawing.Size(206, 0);
            this.userNameLb.Name = "userNameLb";
            this.userNameLb.Size = new System.Drawing.Size(206, 20);
            this.userNameLb.TabIndex = 7;
            this.userNameLb.Text = "label1";
            this.userNameLb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.userNameLb.Click += new System.EventHandler(this.userNameLb_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(210, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1056, 48);
            this.panel2.TabIndex = 8;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(570, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(423, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 16.25F);
            this.label1.Location = new System.Drawing.Point(22, 0);
            this.label1.MinimumSize = new System.Drawing.Size(0, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1264, 786);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.naviUserPanel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.naviUserPanel.ResumeLayout(false);
            this.naviUserPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button openCaseBt;
        private System.Windows.Forms.Button oldCaseBt;
        private System.Windows.Forms.Button showHelpBt;
        private System.Windows.Forms.Panel naviUserPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label userNameLb;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}