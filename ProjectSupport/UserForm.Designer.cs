namespace ProjectSupport
{
    partial class UserForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.openCaseBt = new System.Windows.Forms.Button();
            this.sendBt = new System.Windows.Forms.Button();
            this.oldCaseBt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(358, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 521);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(73, 279);
            this.listBox1.MultiColumn = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(73, 214);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(110, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // openCaseBt
            // 
            this.openCaseBt.Location = new System.Drawing.Point(1076, 42);
            this.openCaseBt.Name = "openCaseBt";
            this.openCaseBt.Size = new System.Drawing.Size(124, 23);
            this.openCaseBt.TabIndex = 3;
            this.openCaseBt.Text = "Open new case";
            this.openCaseBt.UseVisualStyleBackColor = true;
            this.openCaseBt.Click += new System.EventHandler(this.openCaseBt_Click);
            // 
            // sendBt
            // 
            this.sendBt.Location = new System.Drawing.Point(1111, 632);
            this.sendBt.Name = "sendBt";
            this.sendBt.Size = new System.Drawing.Size(106, 23);
            this.sendBt.TabIndex = 4;
            this.sendBt.Text = "Send";
            this.sendBt.UseVisualStyleBackColor = true;
            this.sendBt.Visible = false;
            this.sendBt.Click += new System.EventHandler(this.sendBt_Click);
            // 
            // oldCaseBt
            // 
            this.oldCaseBt.Location = new System.Drawing.Point(946, 42);
            this.oldCaseBt.Name = "oldCaseBt";
            this.oldCaseBt.Size = new System.Drawing.Size(124, 23);
            this.oldCaseBt.TabIndex = 5;
            this.oldCaseBt.Text = "Open old cases";
            this.oldCaseBt.UseVisualStyleBackColor = true;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.oldCaseBt);
            this.Controls.Add(this.sendBt);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.openCaseBt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel1);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button openCaseBt;
        private System.Windows.Forms.Button sendBt;
        private System.Windows.Forms.Button oldCaseBt;
    }
}