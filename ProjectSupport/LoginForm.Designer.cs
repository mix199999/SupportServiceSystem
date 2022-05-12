using System.Drawing;

namespace ProjectSupport
{
    partial class LoginForm
    {


       
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.passwdTB = new System.Windows.Forms.TextBox();
            this.loginBt = new System.Windows.Forms.Button();
            this.loginTB = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 41);
            this.panel1.TabIndex = 5;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "C:\\SupportProject\\SupportServiceSystem\\icons\\cross.png";
            this.pictureBox1.Location = new System.Drawing.Point(274, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 32);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // passwdTB
            // 
            this.passwdTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwdTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.passwdTB.ForeColor = System.Drawing.SystemColors.Control;
            this.passwdTB.Location = new System.Drawing.Point(85, 295);
            this.passwdTB.MinimumSize = new System.Drawing.Size(0, 24);
            this.passwdTB.Name = "passwdTB";
            this.passwdTB.PasswordChar = '*';
            this.passwdTB.Size = new System.Drawing.Size(138, 19);
            this.passwdTB.TabIndex = 1;
            this.passwdTB.Text = "1234";
            this.passwdTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwdTB.UseSystemPasswordChar = true;
            // 
            // loginBt
            // 
            this.loginBt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.loginBt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.loginBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.loginBt.ForeColor = System.Drawing.SystemColors.Control;
            this.loginBt.Location = new System.Drawing.Point(114, 341);
            this.loginBt.Name = "loginBt";
            this.loginBt.Size = new System.Drawing.Size(78, 42);
            this.loginBt.TabIndex = 2;
            this.loginBt.Text = "Login";
            this.loginBt.UseVisualStyleBackColor = false;
            this.loginBt.Click += new System.EventHandler(this.loginBt_Click);
            // 
            // loginTB
            // 
            this.loginTB.BackColor = System.Drawing.SystemColors.Control;
            this.loginTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.loginTB.ForeColor = System.Drawing.SystemColors.Control;
            this.loginTB.Location = new System.Drawing.Point(85, 245);
            this.loginTB.MinimumSize = new System.Drawing.Size(0, 24);
            this.loginTB.Name = "loginTB";
            this.loginTB.Size = new System.Drawing.Size(138, 19);
            this.loginTB.TabIndex = 0;
            this.loginTB.Text = "User1";
            this.loginTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            this.pictureBox2.ImageLocation = "C:\\SupportProject\\SupportServiceSystem\\icons\\logo.png";
            this.pictureBox2.Location = new System.Drawing.Point(100, 92);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(111, 99);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseDown);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseMove);
            this.pictureBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseUp);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(305, 413);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.loginBt);
            this.Controls.Add(this.passwdTB);
            this.Controls.Add(this.loginTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseUp);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox passwdTB;
        private System.Windows.Forms.Button loginBt;
        private System.Windows.Forms.TextBox loginTB;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}