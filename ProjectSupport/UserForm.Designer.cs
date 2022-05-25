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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.naviUserPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userNameLb = new System.Windows.Forms.Label();
            this.showHelpBt = new System.Windows.Forms.Button();
            this.oldCaseBt = new System.Windows.Forms.Button();
            this.openCaseBt = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.searchClick = new System.Windows.Forms.PictureBox();
            this.searchTx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.naviUserPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchClick)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(245, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1021, 629);
            this.panel1.TabIndex = 0;
            // 
            // naviUserPanel
            // 
            this.naviUserPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.naviUserPanel.Controls.Add(this.pictureBox1);
            this.naviUserPanel.Controls.Add(this.userNameLb);
            this.naviUserPanel.Controls.Add(this.showHelpBt);
            this.naviUserPanel.Controls.Add(this.oldCaseBt);
            this.naviUserPanel.Controls.Add(this.openCaseBt);
            this.naviUserPanel.Location = new System.Drawing.Point(-3, 2);
            this.naviUserPanel.Name = "naviUserPanel";
            this.naviUserPanel.Size = new System.Drawing.Size(242, 688);
            this.naviUserPanel.TabIndex = 7;
            this.naviUserPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.NaviUserPanel_Paint);
            this.naviUserPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseDown);
            this.naviUserPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseMove);
            this.naviUserPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "C:\\SupportProject\\SupportServiceSystem\\icons\\userIcon.png";
            this.pictureBox1.Location = new System.Drawing.Point(78, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 72);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // userNameLb
            // 
            this.userNameLb.AutoSize = true;
            this.userNameLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.userNameLb.Location = new System.Drawing.Point(15, 137);
            this.userNameLb.MinimumSize = new System.Drawing.Size(206, 0);
            this.userNameLb.Name = "userNameLb";
            this.userNameLb.Size = new System.Drawing.Size(206, 20);
            this.userNameLb.TabIndex = 7;
            this.userNameLb.Text = "label1";
            this.userNameLb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // showHelpBt
            // 
            this.showHelpBt.FlatAppearance.BorderSize = 3;
            this.showHelpBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showHelpBt.Font = new System.Drawing.Font("Cascadia Code", 12.25F);
            this.showHelpBt.Image = global::ProjectSupport.Properties.Resources.question;
            this.showHelpBt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.showHelpBt.Location = new System.Drawing.Point(11, 171);
            this.showHelpBt.Name = "showHelpBt";
            this.showHelpBt.Size = new System.Drawing.Size(222, 63);
            this.showHelpBt.TabIndex = 6;
            this.showHelpBt.Text = "Help";
            this.showHelpBt.UseVisualStyleBackColor = true;
            this.showHelpBt.Click += new System.EventHandler(this.ShowHelpBt_Click);
            // 
            // oldCaseBt
            // 
            this.oldCaseBt.FlatAppearance.BorderSize = 3;
            this.oldCaseBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oldCaseBt.Font = new System.Drawing.Font("Cascadia Code", 12.25F);
            this.oldCaseBt.Image = ((System.Drawing.Image)(resources.GetObject("oldCaseBt.Image")));
            this.oldCaseBt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.oldCaseBt.Location = new System.Drawing.Point(11, 240);
            this.oldCaseBt.Name = "oldCaseBt";
            this.oldCaseBt.Size = new System.Drawing.Size(222, 63);
            this.oldCaseBt.TabIndex = 5;
            this.oldCaseBt.Text = "Your cases";
            this.oldCaseBt.UseVisualStyleBackColor = true;
            this.oldCaseBt.Click += new System.EventHandler(this.OldCaseBt_Click);
            // 
            // openCaseBt
            // 
            this.openCaseBt.FlatAppearance.BorderSize = 3;
            this.openCaseBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openCaseBt.Font = new System.Drawing.Font("Cascadia Code", 12.25F);
            this.openCaseBt.Image = ((System.Drawing.Image)(resources.GetObject("openCaseBt.Image")));
            this.openCaseBt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.openCaseBt.Location = new System.Drawing.Point(11, 309);
            this.openCaseBt.Name = "openCaseBt";
            this.openCaseBt.Size = new System.Drawing.Size(222, 63);
            this.openCaseBt.TabIndex = 3;
            this.openCaseBt.Text = "New case";
            this.openCaseBt.UseVisualStyleBackColor = true;
            this.openCaseBt.Click += new System.EventHandler(this.OpenCaseBt_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.searchClick);
            this.panel2.Controls.Add(this.searchTx);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, -5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1278, 63);
            this.panel2.TabIndex = 8;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.ImageLocation = "C:\\SupportProject\\SupportServiceSystem\\icons\\cross.png";
            this.pictureBox2.Location = new System.Drawing.Point(1237, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 28);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // searchClick
            // 
            this.searchClick.ImageLocation = "C:\\SupportProject\\SupportServiceSystem\\icons\\searchIcon48.png";
            this.searchClick.Location = new System.Drawing.Point(838, 17);
            this.searchClick.Name = "searchClick";
            this.searchClick.Size = new System.Drawing.Size(37, 32);
            this.searchClick.TabIndex = 2;
            this.searchClick.TabStop = false;
            this.searchClick.Click += new System.EventHandler(this.SearchClick_Click);
            // 
            // searchTx
            // 
            this.searchTx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchTx.Location = new System.Drawing.Point(584, 17);
            this.searchTx.Name = "searchTx";
            this.searchTx.Size = new System.Drawing.Size(248, 22);
            this.searchTx.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 16.25F);
            this.label1.Location = new System.Drawing.Point(33, 10);
            this.label1.MinimumSize = new System.Drawing.Size(0, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // UserForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1269, 688);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.naviUserPanel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseUp);
            this.naviUserPanel.ResumeLayout(false);
            this.naviUserPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchClick)).EndInit();
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
        private System.Windows.Forms.PictureBox searchClick;
        private System.Windows.Forms.TextBox searchTx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
    }
}