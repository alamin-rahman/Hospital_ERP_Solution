namespace Hospital_ERP_Solution.Lab
{
    partial class FrmTestEntryUI
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
            System.Windows.Forms.Button btnLabTestDelete;
            System.Windows.Forms.Button btnLabTestUpdate;
            System.Windows.Forms.Button btnLabTestSave;
            System.Windows.Forms.Button btnLabTestClear;
            System.Windows.Forms.Button btnLabTestNew;
            System.Windows.Forms.Button btnTestView;
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tbl_LabTestEntryDataGridView = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTest = new System.Windows.Forms.TextBox();
            this.dtpLabTest = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRoomNo = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtTestName = new System.Windows.Forms.TextBox();
            this.txtTestCategory = new System.Windows.Forms.TextBox();
            this.txtTestId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            btnLabTestDelete = new System.Windows.Forms.Button();
            btnLabTestUpdate = new System.Windows.Forms.Button();
            btnLabTestSave = new System.Windows.Forms.Button();
            btnLabTestClear = new System.Windows.Forms.Button();
            btnLabTestNew = new System.Windows.Forms.Button();
            btnTestView = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_LabTestEntryDataGridView)).BeginInit();
            this.panel7.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLabTestDelete
            // 
            btnLabTestDelete.BackColor = System.Drawing.Color.FloralWhite;
            btnLabTestDelete.FlatAppearance.BorderColor = System.Drawing.Color.Beige;
            btnLabTestDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLabTestDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnLabTestDelete.ForeColor = System.Drawing.Color.Black;
            btnLabTestDelete.Location = new System.Drawing.Point(248, 12);
            btnLabTestDelete.Name = "btnLabTestDelete";
            btnLabTestDelete.Size = new System.Drawing.Size(112, 30);
            btnLabTestDelete.TabIndex = 9;
            btnLabTestDelete.Text = "Delete";
            btnLabTestDelete.UseVisualStyleBackColor = false;
            // 
            // btnLabTestUpdate
            // 
            btnLabTestUpdate.BackColor = System.Drawing.Color.FloralWhite;
            btnLabTestUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Beige;
            btnLabTestUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLabTestUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnLabTestUpdate.ForeColor = System.Drawing.Color.Black;
            btnLabTestUpdate.Location = new System.Drawing.Point(128, 12);
            btnLabTestUpdate.Name = "btnLabTestUpdate";
            btnLabTestUpdate.Size = new System.Drawing.Size(112, 30);
            btnLabTestUpdate.TabIndex = 8;
            btnLabTestUpdate.Text = "Update";
            btnLabTestUpdate.UseVisualStyleBackColor = false;
            btnLabTestUpdate.Click += new System.EventHandler(this.btnLabTestUpdate_Click);
            // 
            // btnLabTestSave
            // 
            btnLabTestSave.BackColor = System.Drawing.Color.FloralWhite;
            btnLabTestSave.FlatAppearance.BorderColor = System.Drawing.Color.Beige;
            btnLabTestSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLabTestSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnLabTestSave.ForeColor = System.Drawing.Color.Black;
            btnLabTestSave.Location = new System.Drawing.Point(6, 12);
            btnLabTestSave.Name = "btnLabTestSave";
            btnLabTestSave.Size = new System.Drawing.Size(112, 30);
            btnLabTestSave.TabIndex = 7;
            btnLabTestSave.Text = "Save";
            btnLabTestSave.UseVisualStyleBackColor = false;
            btnLabTestSave.Click += new System.EventHandler(this.btnLabTestSave_Click);
            // 
            // btnLabTestClear
            // 
            btnLabTestClear.BackColor = System.Drawing.Color.FloralWhite;
            btnLabTestClear.FlatAppearance.BorderColor = System.Drawing.Color.Beige;
            btnLabTestClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLabTestClear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnLabTestClear.ForeColor = System.Drawing.Color.Black;
            btnLabTestClear.Location = new System.Drawing.Point(123, 11);
            btnLabTestClear.Name = "btnLabTestClear";
            btnLabTestClear.Size = new System.Drawing.Size(112, 30);
            btnLabTestClear.TabIndex = 8;
            btnLabTestClear.Text = "Clear";
            btnLabTestClear.UseVisualStyleBackColor = false;
            // 
            // btnLabTestNew
            // 
            btnLabTestNew.BackColor = System.Drawing.Color.FloralWhite;
            btnLabTestNew.FlatAppearance.BorderColor = System.Drawing.Color.Beige;
            btnLabTestNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLabTestNew.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnLabTestNew.ForeColor = System.Drawing.Color.Black;
            btnLabTestNew.Location = new System.Drawing.Point(5, 11);
            btnLabTestNew.Name = "btnLabTestNew";
            btnLabTestNew.Size = new System.Drawing.Size(112, 30);
            btnLabTestNew.TabIndex = 7;
            btnLabTestNew.Text = "New";
            btnLabTestNew.UseVisualStyleBackColor = false;
            // 
            // btnTestView
            // 
            btnTestView.BackColor = System.Drawing.Color.FloralWhite;
            btnTestView.FlatAppearance.BorderColor = System.Drawing.Color.Beige;
            btnTestView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnTestView.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnTestView.ForeColor = System.Drawing.Color.Black;
            btnTestView.Location = new System.Drawing.Point(241, 11);
            btnTestView.Name = "btnTestView";
            btnTestView.Size = new System.Drawing.Size(112, 30);
            btnTestView.TabIndex = 8;
            btnTestView.Text = "View";
            btnTestView.UseVisualStyleBackColor = false;
            btnTestView.Click += new System.EventHandler(this.btnTestView_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(991, 79);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(392, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lab Test Adding Panel";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox7);
            this.panel1.Controls.Add(this.txtTest);
            this.panel1.Controls.Add(this.dtpLabTest);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(991, 566);
            this.panel1.TabIndex = 2;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(btnTestView);
            this.groupBox5.Controls.Add(btnLabTestClear);
            this.groupBox5.Controls.Add(btnLabTestNew);
            this.groupBox5.Location = new System.Drawing.Point(606, 307);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(365, 45);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(btnLabTestDelete);
            this.groupBox4.Controls.Add(btnLabTestUpdate);
            this.groupBox4.Controls.Add(btnLabTestSave);
            this.groupBox4.Location = new System.Drawing.Point(230, 307);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(366, 47);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.panel6);
            this.groupBox7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox7.Location = new System.Drawing.Point(451, 54);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(530, 227);
            this.groupBox7.TabIndex = 10;
            this.groupBox7.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.AutoScroll = true;
            this.panel6.Controls.Add(this.tbl_LabTestEntryDataGridView);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 16);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(524, 208);
            this.panel6.TabIndex = 0;
            // 
            // tbl_LabTestEntryDataGridView
            // 
            this.tbl_LabTestEntryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_LabTestEntryDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_LabTestEntryDataGridView.Location = new System.Drawing.Point(0, 38);
            this.tbl_LabTestEntryDataGridView.Name = "tbl_LabTestEntryDataGridView";
            this.tbl_LabTestEntryDataGridView.Size = new System.Drawing.Size(524, 170);
            this.tbl_LabTestEntryDataGridView.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label9);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(524, 38);
            this.panel7.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(201, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 27);
            this.label9.TabIndex = 0;
            this.label9.Text = "View Test Info";
            // 
            // txtTest
            // 
            this.txtTest.Location = new System.Drawing.Point(305, 19);
            this.txtTest.Name = "txtTest";
            this.txtTest.Size = new System.Drawing.Size(89, 20);
            this.txtTest.TabIndex = 6;
            // 
            // dtpLabTest
            // 
            this.dtpLabTest.CustomFormat = "dd/MM/yyyy";
            this.dtpLabTest.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpLabTest.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpLabTest.Location = new System.Drawing.Point(606, 23);
            this.dtpLabTest.Name = "dtpLabTest";
            this.dtpLabTest.Size = new System.Drawing.Size(138, 21);
            this.dtpLabTest.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(556, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Date:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRoomNo);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.txtTestName);
            this.groupBox1.Controls.Add(this.txtTestCategory);
            this.groupBox1.Controls.Add(this.txtTestId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(52, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 215);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lab Test Entry";
            // 
            // txtRoomNo
            // 
            this.txtRoomNo.Location = new System.Drawing.Point(155, 169);
            this.txtRoomNo.Name = "txtRoomNo";
            this.txtRoomNo.Size = new System.Drawing.Size(165, 20);
            this.txtRoomNo.TabIndex = 9;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(155, 133);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(165, 20);
            this.txtPrice.TabIndex = 8;
            // 
            // txtTestName
            // 
            this.txtTestName.Location = new System.Drawing.Point(155, 98);
            this.txtTestName.Name = "txtTestName";
            this.txtTestName.Size = new System.Drawing.Size(165, 20);
            this.txtTestName.TabIndex = 7;
            this.txtTestName.TextChanged += new System.EventHandler(this.txtTestName_TextChanged);
            // 
            // txtTestCategory
            // 
            this.txtTestCategory.Location = new System.Drawing.Point(155, 30);
            this.txtTestCategory.Name = "txtTestCategory";
            this.txtTestCategory.Size = new System.Drawing.Size(165, 20);
            this.txtTestCategory.TabIndex = 6;
            // 
            // txtTestId
            // 
            this.txtTestId.Location = new System.Drawing.Point(155, 63);
            this.txtTestId.Name = "txtTestId";
            this.txtTestId.Size = new System.Drawing.Size(165, 20);
            this.txtTestId.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Test Category:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(55, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Test ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Test Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Room No:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 581);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(991, 64);
            this.panel3.TabIndex = 3;
            // 
            // FrmTestEntryUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 645);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FrmTestEntryUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTestEntryUI";
            this.Load += new System.EventHandler(this.FrmTestEntryUI_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_LabTestEntryDataGridView)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtRoomNo;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtTestName;
        private System.Windows.Forms.TextBox txtTestId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpLabTest;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
       // private Hospital_ERP_SolutionDataSet1 hospital_ERP_SolutionDataSet1;
        private System.Windows.Forms.BindingSource tbl_LabTestEntryBindingSource;
      //  private Hospital_ERP_SolutionDataSet1TableAdapters.tbl_LabTestEntryTableAdapter tbl_LabTestEntryTableAdapter;
       // private Hospital_ERP_SolutionDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tbl_LabTestEntryDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.TextBox txtTest;
        private System.Windows.Forms.TextBox txtTestCategory;
        private System.Windows.Forms.Label label1;
    }
}