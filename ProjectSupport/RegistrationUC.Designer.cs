namespace ProjectSupport
{
    partial class RegistrationUC
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
            this.loginTb = new System.Windows.Forms.TextBox();
            this.passwordTb = new System.Windows.Forms.TextBox();
            this.loginLb = new System.Windows.Forms.Label();
            this.passwordLb = new System.Windows.Forms.Label();
            this.signUpBt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.repasswordTb = new System.Windows.Forms.TextBox();
            this.backLb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginTb
            // 
            this.loginTb.Location = new System.Drawing.Point(104, 97);
            this.loginTb.Name = "loginTb";
            this.loginTb.Size = new System.Drawing.Size(100, 20);
            this.loginTb.TabIndex = 0;
            // 
            // passwordTb
            // 
            this.passwordTb.Location = new System.Drawing.Point(104, 159);
            this.passwordTb.Name = "passwordTb";
            this.passwordTb.Size = new System.Drawing.Size(100, 20);
            this.passwordTb.TabIndex = 1;
            // 
            // loginLb
            // 
            this.loginLb.AutoSize = true;
            this.loginLb.Location = new System.Drawing.Point(32, 100);
            this.loginLb.Name = "loginLb";
            this.loginLb.Size = new System.Drawing.Size(36, 13);
            this.loginLb.TabIndex = 2;
            this.loginLb.Text = "Login:";
            // 
            // passwordLb
            // 
            this.passwordLb.AutoSize = true;
            this.passwordLb.Location = new System.Drawing.Point(33, 166);
            this.passwordLb.Name = "passwordLb";
            this.passwordLb.Size = new System.Drawing.Size(56, 13);
            this.passwordLb.TabIndex = 3;
            this.passwordLb.Text = "Password:";
            // 
            // signUpBt
            // 
            this.signUpBt.Location = new System.Drawing.Point(113, 288);
            this.signUpBt.Name = "signUpBt";
            this.signUpBt.Size = new System.Drawing.Size(75, 23);
            this.signUpBt.TabIndex = 4;
            this.signUpBt.Text = "Sign Up";
            this.signUpBt.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Retype Password:";
            // 
            // repasswordTb
            // 
            this.repasswordTb.Location = new System.Drawing.Point(104, 217);
            this.repasswordTb.Name = "repasswordTb";
            this.repasswordTb.Size = new System.Drawing.Size(100, 20);
            this.repasswordTb.TabIndex = 6;
            // 
            // backLb
            // 
            this.backLb.AutoSize = true;
            this.backLb.Location = new System.Drawing.Point(257, 346);
            this.backLb.Name = "backLb";
            this.backLb.Size = new System.Drawing.Size(32, 13);
            this.backLb.TabIndex = 7;
            this.backLb.Text = "Back";
            // 
            // RegistrationUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.backLb);
            this.Controls.Add(this.repasswordTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.signUpBt);
            this.Controls.Add(this.passwordLb);
            this.Controls.Add(this.loginLb);
            this.Controls.Add(this.passwordTb);
            this.Controls.Add(this.loginTb);
            this.Name = "RegistrationUC";
            this.Size = new System.Drawing.Size(305, 370);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginTb;
        private System.Windows.Forms.TextBox passwordTb;
        private System.Windows.Forms.Label loginLb;
        private System.Windows.Forms.Label passwordLb;
        private System.Windows.Forms.Button signUpBt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox repasswordTb;
        private System.Windows.Forms.Label backLb;
    }
}
