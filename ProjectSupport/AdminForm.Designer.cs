namespace ProjectSupport
{
    partial class AdminForm
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
            this.components = new System.ComponentModel.Container();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.InsertBt = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SaveBt = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.caseIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caseStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caseTabBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caseTabBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(804, 82);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(482, 362);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // InsertBt
            // 
            this.InsertBt.Location = new System.Drawing.Point(1159, 538);
            this.InsertBt.Name = "InsertBt";
            this.InsertBt.Size = new System.Drawing.Size(75, 23);
            this.InsertBt.TabIndex = 2;
            this.InsertBt.Text = "ADD";
            this.InsertBt.UseVisualStyleBackColor = true;
            this.InsertBt.Click += new System.EventHandler(this.InsertBt_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(746, 538);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // SaveBt
            // 
            this.SaveBt.Location = new System.Drawing.Point(1007, 538);
            this.SaveBt.Name = "SaveBt";
            this.SaveBt.Size = new System.Drawing.Size(75, 23);
            this.SaveBt.TabIndex = 4;
            this.SaveBt.Text = "Save";
            this.SaveBt.UseVisualStyleBackColor = true;
            this.SaveBt.Click += new System.EventHandler(this.SaveBt_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.caseIdDataGridViewTextBoxColumn,
            this.caseNameDataGridViewTextBoxColumn,
            this.transactionIdDataGridViewTextBoxColumn,
            this.userIdDataGridViewTextBoxColumn,
            this.userTextDataGridViewTextBoxColumn,
            this.adminTextDataGridViewTextBoxColumn,
            this.caseStatusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.caseTabBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(750, 424);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // caseIdDataGridViewTextBoxColumn
            // 
            this.caseIdDataGridViewTextBoxColumn.DataPropertyName = "CaseId";
            this.caseIdDataGridViewTextBoxColumn.HeaderText = "CaseId";
            this.caseIdDataGridViewTextBoxColumn.Name = "caseIdDataGridViewTextBoxColumn";
            // 
            // caseNameDataGridViewTextBoxColumn
            // 
            this.caseNameDataGridViewTextBoxColumn.DataPropertyName = "CaseName";
            this.caseNameDataGridViewTextBoxColumn.HeaderText = "CaseName";
            this.caseNameDataGridViewTextBoxColumn.Name = "caseNameDataGridViewTextBoxColumn";
            // 
            // transactionIdDataGridViewTextBoxColumn
            // 
            this.transactionIdDataGridViewTextBoxColumn.DataPropertyName = "TransactionId";
            this.transactionIdDataGridViewTextBoxColumn.HeaderText = "TransactionId";
            this.transactionIdDataGridViewTextBoxColumn.Name = "transactionIdDataGridViewTextBoxColumn";
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            // 
            // userTextDataGridViewTextBoxColumn
            // 
            this.userTextDataGridViewTextBoxColumn.DataPropertyName = "UserText";
            this.userTextDataGridViewTextBoxColumn.HeaderText = "UserText";
            this.userTextDataGridViewTextBoxColumn.Name = "userTextDataGridViewTextBoxColumn";
            // 
            // adminTextDataGridViewTextBoxColumn
            // 
            this.adminTextDataGridViewTextBoxColumn.DataPropertyName = "AdminText";
            this.adminTextDataGridViewTextBoxColumn.HeaderText = "AdminText";
            this.adminTextDataGridViewTextBoxColumn.Name = "adminTextDataGridViewTextBoxColumn";
            // 
            // caseStatusDataGridViewTextBoxColumn
            // 
            this.caseStatusDataGridViewTextBoxColumn.DataPropertyName = "CaseStatus";
            this.caseStatusDataGridViewTextBoxColumn.HeaderText = "CaseStatus";
            this.caseStatusDataGridViewTextBoxColumn.Name = "caseStatusDataGridViewTextBoxColumn";
            // 
            // caseTabBindingSource1
            // 
            this.caseTabBindingSource1.DataSource = typeof(ProjectSupport.CaseTab);
            this.caseTabBindingSource1.CurrentChanged += new System.EventHandler(this.caseTabBindingSource1_CurrentChanged);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1425, 641);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SaveBt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.InsertBt);
            this.Controls.Add(this.richTextBox1);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caseTabBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button InsertBt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button SaveBt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn caseIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caseNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caseStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource caseTabBindingSource1;
    }
}