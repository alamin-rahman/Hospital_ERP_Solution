namespace Hospital_ERP_Solution.Lab
{
    partial class frmViewTestInfoUI
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
            System.Windows.Forms.Button btnViewTestDelete;
            System.Windows.Forms.Button btnViewTestUpdate;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_ViewLabTest = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Column8 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnViewTestDelete = new System.Windows.Forms.Button();
            btnViewTestUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ViewLabTest)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnViewTestDelete
            // 
            btnViewTestDelete.BackColor = System.Drawing.Color.FloralWhite;
            btnViewTestDelete.FlatAppearance.BorderColor = System.Drawing.Color.Beige;
            btnViewTestDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnViewTestDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnViewTestDelete.ForeColor = System.Drawing.Color.Black;
            btnViewTestDelete.Location = new System.Drawing.Point(127, 11);
            btnViewTestDelete.Name = "btnViewTestDelete";
            btnViewTestDelete.Size = new System.Drawing.Size(112, 30);
            btnViewTestDelete.TabIndex = 9;
            btnViewTestDelete.Text = "Delete";
            btnViewTestDelete.UseVisualStyleBackColor = false;
            btnViewTestDelete.Click += new System.EventHandler(this.btnViewTestDelete_Click);
            // 
            // btnViewTestUpdate
            // 
            btnViewTestUpdate.BackColor = System.Drawing.Color.FloralWhite;
            btnViewTestUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Beige;
            btnViewTestUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnViewTestUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnViewTestUpdate.ForeColor = System.Drawing.Color.Black;
            btnViewTestUpdate.Location = new System.Drawing.Point(5, 11);
            btnViewTestUpdate.Name = "btnViewTestUpdate";
            btnViewTestUpdate.Size = new System.Drawing.Size(112, 30);
            btnViewTestUpdate.TabIndex = 8;
            btnViewTestUpdate.Text = "Update";
            btnViewTestUpdate.UseVisualStyleBackColor = false;
            // 
            // dgv_ViewLabTest
            // 
            this.dgv_ViewLabTest.AllowUserToAddRows = false;
            this.dgv_ViewLabTest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ViewLabTest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ViewLabTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ViewLabTest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgv_ViewLabTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ViewLabTest.Location = new System.Drawing.Point(0, 70);
            this.dgv_ViewLabTest.Name = "dgv_ViewLabTest";
            this.dgv_ViewLabTest.Size = new System.Drawing.Size(814, 415);
            this.dgv_ViewLabTest.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(814, 70);
            this.panel1.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(148, 28);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(165, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search By Test Name:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 413);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(814, 72);
            this.panel2.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(btnViewTestDelete);
            this.groupBox4.Controls.Add(btnViewTestUpdate);
            this.groupBox4.Location = new System.Drawing.Point(425, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(247, 47);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "checkbox";
            this.Column8.Name = "Column8";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "LabTestID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "TestCategory";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "TestID";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "TestName";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "TestPrice";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "RoomNo";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "TestDate";
            this.Column7.Name = "Column7";
            // 
            // frmViewTestInfoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 485);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgv_ViewLabTest);
            this.Controls.Add(this.panel1);
            this.Name = "frmViewTestInfoUI";
            this.Text = "frmViewTestInfoUI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmViewTestInfoUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ViewLabTest)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ViewLabTest;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}