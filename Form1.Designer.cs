namespace Hospital_ERP_Solution
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.dgvIssueTestIfo = new System.Windows.Forms.DataGridView();
            this.slNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbtestCatagory = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CmbtestCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtRoomNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssueTestIfo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.dgvIssueTestIfo);
            this.groupBox8.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.groupBox8.Location = new System.Drawing.Point(12, 12);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(774, 230);
            this.groupBox8.TabIndex = 50;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Personal Info";
            // 
            // dgvIssueTestIfo
            // 
            this.dgvIssueTestIfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIssueTestIfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvIssueTestIfo.ColumnHeadersHeight = 30;
            this.dgvIssueTestIfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.slNo,
            this.cmbtestCatagory,
            this.CmbtestCode,
            this.txtTestName,
            this.txtRoomNo,
            this.txtQty,
            this.txtUnitPrice,
            this.Column7,
            this.txtPrice});
            this.dgvIssueTestIfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIssueTestIfo.Location = new System.Drawing.Point(3, 16);
            this.dgvIssueTestIfo.Name = "dgvIssueTestIfo";
            this.dgvIssueTestIfo.Size = new System.Drawing.Size(768, 211);
            this.dgvIssueTestIfo.TabIndex = 0;
            // 
            // slNo
            // 
            this.slNo.HeaderText = "SL NO";
            this.slNo.Name = "slNo";
            this.slNo.ReadOnly = true;
            // 
            // cmbtestCatagory
            // 
            this.cmbtestCatagory.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.cmbtestCatagory.HeaderText = "Test Category";
            this.cmbtestCatagory.Name = "cmbtestCatagory";
            this.cmbtestCatagory.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cmbtestCatagory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // CmbtestCode
            // 
            this.CmbtestCode.HeaderText = "Test Code";
            this.CmbtestCode.Name = "CmbtestCode";
            this.CmbtestCode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // txtTestName
            // 
            this.txtTestName.HeaderText = "Test Name";
            this.txtTestName.Name = "txtTestName";
            // 
            // txtRoomNo
            // 
            this.txtRoomNo.HeaderText = "Room No.";
            this.txtRoomNo.Name = "txtRoomNo";
            // 
            // txtQty
            // 
            this.txtQty.HeaderText = "Quantity";
            this.txtQty.Name = "txtQty";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.HeaderText = "Unit Price";
            this.txtUnitPrice.Name = "txtUnitPrice";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Discount (%)";
            this.Column7.Name = "Column7";
            // 
            // txtPrice
            // 
            this.txtPrice.HeaderText = "Price";
            this.txtPrice.Name = "txtPrice";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(83, 283);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(89, 20);
            this.dateTimePicker1.TabIndex = 51;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 477);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBox8);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssueTestIfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.DataGridView dgvIssueTestIfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn slNo;
        private System.Windows.Forms.DataGridViewComboBoxColumn cmbtestCatagory;
        private System.Windows.Forms.DataGridViewTextBoxColumn CmbtestCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtRoomNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPrice;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

