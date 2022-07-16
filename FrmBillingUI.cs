using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hospital_ERP_Solution.Lab
{
    public partial class FrmBillingUI : Form
    {
        public FrmBillingUI()
        {
            InitializeComponent();
           
        }

        private SqlConnection con =
            new SqlConnection(ConfigurationManager.ConnectionStrings["Hospital"].ConnectionString);

        private SqlCommand command = null;


        private HospitalERPDataContext data = new HospitalERPDataContext();
        private tbl_IssueTest _issueTest = new tbl_IssueTest();
        private tbl_invoice _invoice = new tbl_invoice();
        private tbl_Cash _cash = new tbl_Cash();



        private void AutoIncreamentBill()
        {
            int Num = 0;
            con.Open();
            string incre_BillNo = "SELECT MAX(InvoiceID+1) FROM tbl_invoice";command = new SqlCommand(incre_BillNo);
            command.Connection = con;

            if (Convert.IsDBNull(command.ExecuteScalar()))
            {
                Num = 1;
                //txtPatientName.Text = Convert.ToString(Num);
                txtInvoice.Text = Convert.ToString("Bill/InvoiceNo  :" + Num);
            }
            else
            {
                Num = (int)(command.ExecuteScalar());
                txtInvoice.Text = Convert.ToString(Num);
                txtInvoice.Text = Convert.ToString("Bill/InvoiceNo :" + Num);

            }
            command.Dispose();
            con.Close();


        }

        public void loadGroupInvoice()
        {
            con.Open();
            command = new SqlCommand("SELECT Sl,Name,UnderGroup,nature From tbl_Ledgers Where sl=3 ", con);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {

                txtGroupIDInvoice.Text = reader[0].ToString();
                txtGroupNameInvoice.Text = reader[1].ToString();
                txtUnderInvoice.Text = reader[2].ToString();
                txtGroupTypeInvoice.Text = reader[3].ToString();
            }
            con.Close();
        }
        public void loadGroupService()
        {
            con.Open();
            command = new SqlCommand("SELECT Sl,Name,UnderGroup,nature From tbl_Ledgers Where sl=1 ", con);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {

                txtSlService.Text = reader[0].ToString();
                txtNameService.Text = reader[1].ToString();
                txtUnderGroupService.Text = reader[2].ToString();
                txtNatureService.Text = reader[3].ToString();
            }

            con.Close();
        }

        public void loadGroupCash()
        {
            con.Open();
            command = new SqlCommand("SELECT Sl,Name,UnderGroup,nature From tbl_Ledgers Where sl=2 ", con);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                txtGrpCshId.Text = reader[0].ToString();
                txtGrpCshName.Text = reader[1].ToString();
                txtCshUndrGrp.Text = reader[2].ToString();
                txtGrpCshTyp.Text = reader[3].ToString();
            }

            con.Close();
        }


        public void loadGroupDoctorCommission()
        {
            con.Open();
            command = new SqlCommand("SELECT Sl,Name,UnderGroup,nature From tbl_Ledgers Where sl=4 ", con);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                txtDocComSl.Text = reader[0].ToString();
                txtDocComName.Text = reader[1].ToString();
                txtDocComUnderGroup.Text = reader[2].ToString();
                txtDocComNature.Text = reader[3].ToString();
            }
            con.Close();
        }

        public void loadDoctorPercentage()
        {
            con.Open();
            command = new SqlCommand("SELECT Percentage From tbl_DoctorPercentage Where TestCategory='" + txtTestCategoryBil.Text + "' AND DoctorID='"+txtDoctorID.Text+"' ", con);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {

               
                txtDocPercentage.Text = reader[0].ToString();
                
            }

            con.Close();
        }



        private void FrmBillingUI_Load(object sender, EventArgs e)
        {
            txtViewDocCommision.Text = "0.00";

            loadGroupDoctorCommission();
            loadGroupCash();
            loadGroupInvoice();
            AutoIncreamentBill();
            AutoLoadTestName();
            AutoLoadDoctorID();
            txtPatientName.Focus();
            loadGroupService();
            loadDoctorPercentage();

            groupBox11.Hide();
            groupBox12.Hide();
            groupBox13.Hide();
            groupBox15.Hide();

            //dgvIssueTestIfo.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void AutoLoadTestName()
        {

            con.Open();
            command = new SqlCommand("SELECT DISTINCT TestName  from tbl_LabTestEntry ", con);
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(command);
            sda.Fill(ds, "tbl_LabTestEntry");
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            int i = 0;
            for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
            {

                col.Add(ds.Tables[0].Rows[i]["TestName"].ToString());

            }
            txtTestName.AutoCompleteSource = AutoCompleteSource.CustomSource;

            txtTestName.AutoCompleteCustomSource = col;
            txtTestName.AutoCompleteMode = AutoCompleteMode.Suggest;


            con.Close();





        }

        private void AutoLoadDoctorID()
        {


            con.Open();
            command = new SqlCommand("SELECT DISTINCT DocID  from tbl_PermanentDoctorInfo ", con);
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(command);
            sda.Fill(ds, "tbl_PermanentDoctorInfo");
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            int i = 0;
            for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
            {
                col.Add(ds.Tables[0].Rows[i]["DocID"].ToString());

            }
            txtDoctorID.AutoCompleteSource = AutoCompleteSource.CustomSource;

            txtDoctorID.AutoCompleteCustomSource = col;
            txtDoctorID.AutoCompleteMode = AutoCompleteMode.Suggest;


            con.Close();





        }
        public void checkField()
        {
            if (txtPatientName.Text == "")
            {
                MessageBox.Show("Please Enter Patient's Name", "Input Missing", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtPatientName.Focus(); 
                return;
                
            }

            if (txtAge.Text == "")
            {
                MessageBox.Show("Please Enter Patient's Age", "Input Missing", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtAge.Focus(); return;
            }

            if (cmbGender.Text == "")
            {
                MessageBox.Show("Please Select Patient's Gender", "Input Missing", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                cmbGender.Focus(); return;
            }

            if (txtContactNo.Text == "")
            {
                MessageBox.Show("Please Enter Patient's Contact No.", "Input Missing", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtContactNo.Focus(); return;
            }

            if (txtDoctorID.Text == "")
            {
                MessageBox.Show("Please Select Doctor's ID", "Input Missing", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtDoctorID.Focus(); 
                return;
            }

        }





        private void btnSaveTestInfo_Click(object sender, EventArgs e)
        {
            
            SaveInvoiceIssueCash();
            


            
        }




    

        public void test()
        {

            con.Open();
            command =
                new SqlCommand(
                    "SELECT TestCategory,TestID,RoomNo,TestPrice from tbl_LabTestEntry where TestName='" + txtTestName.Text + "' ",
                    con);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                txtTestCategoryBil.Text = reader[0].ToString();
                txtTestID.Text = reader[1].ToString();
                txtRoomNo.Text = reader[2].ToString();
                txtUnitPrice.Text = reader[3].ToString();}


            con.Close();

        }

        private void txtTestName_TextChanged(object sender, EventArgs e)
        {
           
            if (txtTestName.Text == string.Empty)
            {
                
                txtTestID.Text = "";
                txtRoomNo.Text = "";
                txtUnitPrice.Text = "";
                txtDocPercentage.Text = "";
                txtTestCategoryBil.Text = "";
            }
            test();
            loadDoctorPercentage();
        }

        private void txtTestID_TextChanged(object sender, EventArgs e)
        {

        }

        public void Reset()
        {
            txtTestID.Text = "";
            txtRoomNo.Text = "";
            txtUnitPrice.Text = "";
            txtTestName.Text = "";
            txtPrice.ResetText();
            txtQuantity.ResetText();
            txtDiscount.ResetText();
            txtDocPercentageAmount.ResetText();
            }



        public void AddList()
        {


            ListViewItem item1 = LstIssuTestInfo.FindItemWithText(txtTestName.Text.Trim());
            if (item1 == null)
            {
                ListViewItem item = new ListViewItem(txtTestID.Text);

                item.SubItems.Add(txtTestName.Text);
                item.SubItems.Add(txtRoomNo.Text);
                item.SubItems.Add(txtUnitPrice.Text);
                item.SubItems.Add(txtQuantity.Text);
                item.SubItems.Add(txtDiscount.Text);
                item.SubItems.Add(txtPrice.Text);
                item.SubItems.Add(txtDocPercentageAmount.Text);
                item.SubItems.Add(txtDocPercentage.Text);
                item.SubItems.Add(txtTestCategoryBil.Text);
                

                LstIssuTestInfo.Items.Add(item);

                Reset();


            }
            else
            {
                MessageBox.Show("Please Add Another Test");
            }

            txtTotalAmount.Text = TotalCount().ToString();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {


            AddList();


        }

        public void Calculate()
        {

            //try
            //{
                
                    
                
               // double valueOne = 0;double valueTwo = 0;
             
               if (txtDiscount.Text != "")
                {
                    //valueOne =
                    //    Convert.ToDouble((Convert.ToDouble(txtUnitPrice.Text) * Convert.ToDouble(txtDiscount.Text) / 100));
                    //valueOne = Math.Round(valueOne, 0);
                    //valueTwo = Convert.ToDouble(txtUnitPrice.Text);
                    //txtPrice.Text = Convert.ToDouble(valueTwo - valueOne).ToString();
                    txtTempPrice.Text = Convert.ToDouble((Convert.ToDouble(txtUnitPrice.Text) * Convert.ToDouble(txtQuantity.Text))).ToString();
                    txtDiscountAmnt.Text = Convert.ToDouble((Convert.ToDouble(txtTempPrice.Text) * Convert.ToDouble(txtDiscount.Text) / 100)).ToString();
                    txtPrice.Text = Convert.ToDouble((Convert.ToDouble(txtTempPrice.Text) - Convert.ToDouble(txtDiscountAmnt.Text))).ToString();
                    txtDocPercentageAmount.Text = Convert.ToDouble((Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtDocPercentage.Text) / 100)).ToString();
              }

                

                
                  //}
            //catch (Exception ex)
            //{//    //txtTempPrice.Text = "0";
            //    //txtDiscountAmnt.Text = "0";
            //    //txtPrice.Text = "0";
            //    //txtDocPercentageAmount.Text = "0";
                
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //}

        }


        public double TotalCount()
        {
            int i = 0;
            int j = 0;
            double k = 0;



            try
            {

                j =LstIssuTestInfo.Items.Count;

                for (i = 0; i <= j - 1; i++)
                {
                    k = k + Convert.ToDouble(LstIssuTestInfo.Items[i].SubItems[6].Text);// subitems []  listview price column..
                    k = Math.Round(k, 2);
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return k;

        }


        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            
            
            
               
           try
            {
                
                double valueOne = 0;
                double valueTwo = 0;

                double.TryParse(txtUnitPrice.Text, out valueOne);
                double.TryParse(txtQuantity.Text, out valueTwo);
                valueOne = Math.Round(valueOne, 2);
                valueTwo = Math.Round(valueTwo, 2);
               double price = (valueOne * valueTwo);
                price = Math.Round(price, 2);
                txtPrice.Text = price.ToString();
                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }




        }


        public void SaveInvoiceIssueCash()
        {
            try
            {


                if (txtPatientName.Text == "")
                {
                    MessageBox.Show("Please Enter Patient's Name", "Input Missing", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    txtPatientName.Focus();
                    return;

                }

                if (txtAge.Text == "")
                {
                    MessageBox.Show("Please Enter Patient's Age", "Input Missing", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    txtAge.Focus(); return;
                }

                if (cmbGender.Text == "---Please Select---")
                {
                    MessageBox.Show("Please Select Patient's Gender", "Input Missing", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    cmbGender.Focus(); return;
                }

                if (txtContactNo.Text == "")
                {
                    MessageBox.Show("Please Enter Patient's Contact No.", "Input Missing", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    txtContactNo.Focus(); return;
                }

                if (txtDoctorID.Text == "")
                {
                    MessageBox.Show("Please Select Doctor's ID", "Input Missing", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    txtDoctorID.Focus();
                    return;
                }


          
             con.Open();
             
                string insert = "insert Into tbl_Invoice(InvoiceNo,OrderDate,DeliveryDate,PatientName,Age,DoctorName,DoctorID,Specialist,Department,Gender,ContactNo,Total,Adjust,NetPay,Cash,Due,GroupID,GroupName,Under,Type) VALUES ('" + txtInvoice.Text + "','" + DateTime.ParseExact(dtpOrderDate.Text, "dd/MM/yyyy", null) + "','" + DateTime.ParseExact(dtpDeliveryDate.Text, "dd/MM/yyyy", null) + "'," +
                             "'" + txtPatientName.Text + "','" + txtAge.Text + "','" + txtDoctorName.Text + "','" + txtDoctorID.Text + "','" + txtSpecialist.Text + "','" + txtDoctorDepartment.Text + "','" + cmbGender.Text + "','" + txtContactNo.Text + "','" + txtTotalAmount.Text + "','" + txtAdjustAmount.Text + "', '" + txtNetPay.Text + "', '" + txtCash.Text + "','" + txtDueAmount.Text + "','" + txtGroupIDInvoice.Text + "','" + txtGroupNameInvoice.Text + "','" + txtUnderInvoice.Text + "','" + txtGroupTypeInvoice.Text + "' )";
                command = new SqlCommand(insert);command.Connection = con;
                command.ExecuteReader();

                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Close();

               // con.Open();

                for (int i = 0; i <= LstIssuTestInfo.Items.Count - 1; i++)
                {
                  
                   con.Open();
                   string Insert_Issue = "insert Into tbl_IssueTest (InvoiceNo,OrderDate,DeliveryDate,TestID,TestName,RoomNo,Quantity,UnitPrice,Discount,Price)  Values(@a1,@a2,@a3,@a4,@a5,@a6,@a7,@a8,@a9,@a10)";
                    command = new SqlCommand(Insert_Issue);
                    command.Connection = con;
                    command.Parameters.AddWithValue("@a1", txtInvoice.Text);
                    command.Parameters.AddWithValue("@a2", DateTime.ParseExact(dtpOrderDate.Text, "dd/MM/yyyy", null));
                    command.Parameters.AddWithValue("@a3", DateTime.ParseExact(dtpDeliveryDate.Text, "dd/MM/yyyy", null));
                    command.Parameters.AddWithValue("@a4", LstIssuTestInfo.Items[i].SubItems[0].Text);
                    command.Parameters.AddWithValue("@a5", LstIssuTestInfo.Items[i].SubItems[1].Text);
                    command.Parameters.AddWithValue("@a6", LstIssuTestInfo.Items[i].SubItems[2].Text);
                    command.Parameters.AddWithValue("@a7", LstIssuTestInfo.Items[i].SubItems[3].Text);
                    command.Parameters.AddWithValue("@a8", LstIssuTestInfo.Items[i].SubItems[4].Text);
                    command.Parameters.AddWithValue("@a9", LstIssuTestInfo.Items[i].SubItems[5].Text);
                    command.Parameters.AddWithValue("@a10", LstIssuTestInfo.Items[i].SubItems[6].Text);
                    con.Close();
                    con.Open();
                    command.ExecuteNonQuery();
                    con.Close();
                    //insert data Cash Table

                  //  con.Open();

                  //  string Insert_Cash = "insert Into tbl_Cash (Cash,Date,InvoiceNo)  Values(@a1,@a2,@a3)";
                  //  command = new SqlCommand(Insert_Cash);
                  //  command.Connection = con;
                  //  command.Parameters.AddWithValue("@a1",txtCashBill.Text);
                  //  command.Parameters.AddWithValue("@a2", dtOrderBill.Text);
                  //  command.Parameters.AddWithValue("@a3", txtPatientBillNo.Text);
                  //// command.Parameters.AddWithValue("@a2", .Text);
                  //  //command.Parameters.AddWithValue("@a2", dtDeliveryBill.Text);
                  // // command.Parameters.AddWithValue("@a2", dtDeliveryBill.Text);
                  // // command.Parameters.AddWithValue("@a2", dtDeliveryBill.Text);
                  ////  command.Parameters.AddWithValue("@a8", txtUnderCash.Text);
                  // // command.Parameters.AddWithValue("@a9", txtGroupTypeCash.Text);

                  //  con.Close();
                  //  con.Open();
                  //  command.ExecuteNonQuery();
                  //  con.Close();


                   }
                // service----> insert  tbl_LedgerAmount ////
                con.Open();

                string Insert_LedgerAmount_Service = "insert Into tbl_LedgerAmount (LeaderId,date,LadgerName,Undergrp,Nature,Particulars,credit,vchType)  Values(@a1,@a2,@a3,@a4,@a5,@a6,@a7,@a8)";
                command = new SqlCommand(Insert_LedgerAmount_Service);
                command.Connection = con;
                command.Parameters.AddWithValue("@a1", txtSlService.Text);
                command.Parameters.AddWithValue("@a2", dtpOrderDate.Text);
                command.Parameters.AddWithValue("@a3", txtNameService.Text);
                command.Parameters.AddWithValue("@a4", txtUnderGroupService.Text);
                command.Parameters.AddWithValue("@a5", txtNatureService.Text);
                command.Parameters.AddWithValue("@a6", txtInvoice.Text);
                command.Parameters.AddWithValue("@a7", txtNetPay.Text);
                command.Parameters.AddWithValue("@a8", txtVoucherJournal.Text);
                
                

                con.Close();
                con.Open();
                command.ExecuteNonQuery();
                con.Close();

                // Invoice ----> insert  tbl_LedgerAmount ////
                con.Open();

                string Insert_LedgerAmount_Invoice = "insert Into tbl_LedgerAmount (LeaderId,date,LadgerName,Undergrp,Nature,Particulars,debit,vchType)  Values(@a1,@a2,@a3,@a4,@a5,@a6,@a7,@a8)";
                command = new SqlCommand(Insert_LedgerAmount_Invoice);
                command.Connection = con;
                command.Parameters.AddWithValue("@a1", txtInvoice.Text);
                command.Parameters.AddWithValue("@a2", dtpOrderDate.Text);
                command.Parameters.AddWithValue("@a3", txtPatientName.Text);
                command.Parameters.AddWithValue("@a4", txtUnderInvoice.Text);
                command.Parameters.AddWithValue("@a5", txtGroupTypeInvoice.Text);
                command.Parameters.AddWithValue("@a6", txtParticularService.Text);
                command.Parameters.AddWithValue("@a7", txtNetPay.Text);
                command.Parameters.AddWithValue("@a8", txtVoucherJournal.Text);



                con.Close();
                con.Open();
                command.ExecuteNonQuery();
                con.Close();

                // Cash ----> insert  tbl_LedgerAmount ////
                con.Open();

                string Insert_LedgerAmount_Cash = "insert Into tbl_LedgerAmount (LeaderId,date,LadgerName,Undergrp,Nature,Particulars,credit,vchType)  Values(@a1,@a2,@a3,@a4,@a5,@a6,@a7,@a8)";
                command = new SqlCommand(Insert_LedgerAmount_Cash);
                command.Connection = con;
                command.Parameters.AddWithValue("@a1", txtInvoice.Text);
                command.Parameters.AddWithValue("@a2", dtpOrderDate.Text);
                command.Parameters.AddWithValue("@a3", txtPatientName.Text);
                command.Parameters.AddWithValue("@a4", txtCshUndrGrp.Text);
                command.Parameters.AddWithValue("@a5", txtGrpCshTyp.Text);
                command.Parameters.AddWithValue("@a6", txtParticularCash.Text);
                command.Parameters.AddWithValue("@a7", txtCash.Text);
                command.Parameters.AddWithValue("@a8", txtVoucherReceipt.Text);


                con.Close();
                con.Open();
                command.ExecuteNonQuery();
                con.Close();


                // Cash ----> insert  tbl_Cash ////
                con.Open();

                string Insert_Cash = "insert Into tbl_Cash (Cash,Date,Particular,InvoiceNo,VoucherType,Debit,GroupID,GroupName,UnderGroup,GroupType)  Values(@a1,@a2,@a3,@a4,@a5,@a6,@a7,@a8,@a9,@a10)";
                command = new SqlCommand(Insert_Cash);
                command.Connection = con;

                command.Parameters.AddWithValue("@a1", txtCash.Text);
                command.Parameters.AddWithValue("@a2", dtpOrderDate.Text);
                command.Parameters.AddWithValue("@a3", txtInvoice.Text);
                command.Parameters.AddWithValue("@a4", txtInvoice.Text);
                command.Parameters.AddWithValue("@a5", txtVoucherReceipt.Text);
                command.Parameters.AddWithValue("@a6", txtCash.Text);
                command.Parameters.AddWithValue("@a7", txtGrpCshId.Text);
                command.Parameters.AddWithValue("@a8", txtGrpCshName.Text);
                command.Parameters.AddWithValue("@a9", txtCshUndrGrp.Text);
                command.Parameters.AddWithValue("@a10", txtGrpCshTyp.Text);
                


                con.Close();
                con.Open();
                command.ExecuteNonQuery();
                con.Close();


                // Doctor Commission ----> insert  tbl_LedgerAmount ////
                con.Open();

                string Insert_LedgerAmount_DoctorCommission = "insert Into tbl_LedgerAmount (LeaderId,date,LadgerName,Undergrp,Nature,Particulars,Debit,vchType)  Values(@a1,@a2,@a3,@a4,@a5,@a6,@a7,@a8)";
                command = new SqlCommand(Insert_LedgerAmount_DoctorCommission);
                command.Connection = con;
                command.Parameters.AddWithValue("@a1", txtInvoice.Text);
                command.Parameters.AddWithValue("@a2", dtpOrderDate.Text);
                command.Parameters.AddWithValue("@a3", txtDoctorID.Text);
                command.Parameters.AddWithValue("@a4", txtDocComUnderGroup.Text);
                command.Parameters.AddWithValue("@a5", txtDocComNature.Text);
                command.Parameters.AddWithValue("@a6", txtParticularCash.Text);
                command.Parameters.AddWithValue("@a7", txtViewDocCommision.Text);
                command.Parameters.AddWithValue("@a8", txtVoucherPayment.Text);


                con.Close();
                con.Open();
                command.ExecuteNonQuery();
                con.Close();


                // Doctor Commission ----> insert  tbl_DoctorCommission ////
                for (int i = 0; i <= LstIssuTestInfo.Items.Count - 1; i++)
                {

                    con.Open();
                    string Insert_DoctorCommission =
                        "insert Into tbl_DoctorCommission (Date,InvoiceNo,DoctorID,DoctorPercentage,DoctorCommission,VoucherType,TestCategory,TestName,TotalPrice,GroupID,GroupName,Under,GroupType)  Values(@a1,@a2,@a3,@a4,@a5,@a6,@a7,@a8,@a9,@a10,@a11,@a12,@a13)";
                    command = new SqlCommand(Insert_DoctorCommission);
                    command.Connection = con;
                    command.Parameters.AddWithValue("@a1", DateTime.ParseExact(dtpOrderDate.Text, "dd/MM/yyyy", null));
                    command.Parameters.AddWithValue("@a2", txtInvoice.Text);
                    command.Parameters.AddWithValue("@a3", txtDoctorID.Text);

                    command.Parameters.AddWithValue("@a4", LstIssuTestInfo.Items[i].SubItems[8].Text);
                    command.Parameters.AddWithValue("@a5", LstIssuTestInfo.Items[i].SubItems[7].Text);
                    command.Parameters.AddWithValue("@a6", txtVoucherPayment.Text);
                    command.Parameters.AddWithValue("@a7", LstIssuTestInfo.Items[i].SubItems[9].Text);
                    command.Parameters.AddWithValue("@a8", LstIssuTestInfo.Items[i].SubItems[0].Text);
                    command.Parameters.AddWithValue("@a9", LstIssuTestInfo.Items[i].SubItems[6].Text);

                    command.Parameters.AddWithValue("@a10", txtDocComSl.Text);
                    command.Parameters.AddWithValue("@a11", txtDocComName.Text);
                    command.Parameters.AddWithValue("@a12", txtDocComUnderGroup.Text);
                    command.Parameters.AddWithValue("@a13", txtDocComNature.Text);

                    con.Close();
                    con.Open();
                    command.ExecuteNonQuery();
                    con.Close();
                }


                MessageBox.Show("Record Successfully Added ", "Succed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }





        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            
            Calculate();

        }
        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
           //checkField();
            //lblSave.Visible = false;

            //try
            //{
            if (e.KeyChar == 13)
            {
                e.Handled = true;

                // To Add Doctor Total Commission from Individual Test
                txtViewDocCommision.Text = Convert.ToDouble((Convert.ToDouble(txtDocPercentageAmount.Text) + Convert.ToDouble(txtViewDocCommision.Text))).ToString();
                AddList();
                Reset();
            }

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            //}
            //catch (Exception)
            //{

            //    txtViewDocCommision.Text = "0";
            //}
          
            


            //try
            //{
            //    if (e.KeyChar == 13 || !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            //    {
            //        e.Handled = true;

            //        txtTestName.Focus(); _issueTest = new tbl_IssueTest();
            //        _issueTest.InvoiceNo = txtInvoice.Text;
            //        _issueTest.OrderDate = DateTime.ParseExact(dtpOrderDate.Text, "dd/MM/yyyy", null);
            //        _issueTest.DeliveryDate = DateTime.ParseExact(dtpDeliveryDate.Text, "dd/MM/yyyy", null);
            //        _issueTest.TestCode = txtTestID.Text;
            //        _issueTest.TestName = txtTestName.Text;
            //        _issueTest.RoomNo = txtRoomNo.Text;
            //        _issueTest.Quantity = txtQuantity.Text;
            //        _issueTest.UnitPrice = Convert.ToDecimal(txtUnitPrice.Text);
            //        _issueTest.Discount = Convert.ToDecimal(txtDiscount.Text);
            //        _issueTest.Price = Convert.ToDecimal(txtPrice.Text);

            //        data.tbl_IssueTests.InsertOnSubmit(_issueTest);
            //        data.SubmitChanges();
            //        lblSave.Show();
            //        //lblSave.Text = "Entry Save Successfully"; 
            //        lblSave.Text = txtTestName.Text + " Saved";

            //    }
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message, "Error");}
           
            }

        private void txtDoctorName_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtDoctorID_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            command = new SqlCommand("SELECT DoctorName,Specialist,DepartmantName from tbl_PermanentDoctorInfo where DocID='" + txtDoctorID.Text + "' ", con);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                txtDoctorName.Text = reader[0].ToString();
                txtSpecialist.Text = reader[1].ToString();
                txtDoctorDepartment.Text = reader[2].ToString();

            }



            con.Close();
        }

        private void txtAdjustAmount_TextChanged(object sender, EventArgs e)
        {
            txtNetPay.Text = txtAdjustAmount.Text.ToString();}

        private void txtTotalAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double adjustValue = 0;


                double.TryParse(txtTotalAmount.Text, out adjustValue);

                adjustValue = Math.Round(adjustValue, 0);



                txtAdjustAmount.Text = adjustValue.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txtCash_TextChanged(object sender, EventArgs e)
        {
            double netpayable, cash,returnAmount;

            try
            {


                double.TryParse(txtNetPay.Text, out netpayable);
                double.TryParse(txtCash.Text, out cash);
         
                    
                netpayable = Math.Round(netpayable, 2);
                cash = Math.Round(cash, 2);
                
                
                double balance_due = (netpayable - cash);
                balance_due = Math.Round(balance_due, 2);
                txtDueAmount.Text = balance_due.ToString();

                //if (returnTk < 0)
                //{
                //    //lblMessage.Text = "Please return TK. "+ txtReturnAmount.Text;
                //    txtDueAmount.Text = "Please return TK. " + txtRetrnAmntPositive.Text;
                //}

                //else
                //{
                    
                    
                //}
            }
            catch (Exception)
            {
                txtDueAmount.Text = "0.00";
            }
        }


        private double removeTestAmount = 0;

        
        public void DeleteItem()
        {

            if (LstIssuTestInfo.SelectedItems.Count > 0)
            {
                ListViewItem items = LstIssuTestInfo.SelectedItems[0];

                removeTestAmount = (TotalCount() - Convert.ToDouble(items.SubItems[6].Text));

                txtTotalAmount.Text = removeTestAmount.ToString();

                foreach (ListViewItem list in LstIssuTestInfo.SelectedItems)
                {
                    list.Remove();
                }
            }
        }
       
       
        
       
        private void txtCash_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
            }
            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            double netpayable, cash, returnAmount;
 
            try
            {
                double.TryParse(txtDueAmount.Text, out returnAmount);
                double.TryParse(txtNetPay.Text, out netpayable);
                double.TryParse(txtCash.Text, out cash);

               
                double returnTk = (netpayable - cash);
                returnTk = Math.Round(returnTk, 2);
                txtReturnAmount.Text = returnTk.ToString();

                
                double PositivereturnTk = (cash - netpayable);
                PositivereturnTk = Math.Round(PositivereturnTk, 2);
                txtRetrnAmntPositive.Text = PositivereturnTk.ToString();
                if (returnTk < 0)
                {
                    MessageBox.Show("Please return TK. " + txtRetrnAmntPositive.Text, "Return!");
                    txtCash.Text = txtNetPay.Text;}
                
                
            }
            catch (Exception)
            {
                
                //throw;
            }
            
        }

        private void txtBillingClear_Click(object sender, EventArgs e)
        {
            txtTotalAmount.ResetText();
            txtAdjustAmount.ResetText();
            txtNetPay.ResetText();
            txtReturnAmount.ResetText();
            txtRetrnAmntPositive.ResetText();
            txtCash.ResetText();
            txtDueAmount.ResetText();
        }

        
        

       

        private void txtQuantity_MouseClick(object sender, MouseEventArgs e)
        {
            txtQuantity.Text = "";
        
        }

        private void txtDiscount_MouseClick(object sender, MouseEventArgs e)
        {
          txtDiscount.Text = "";
        }

        private void LstIssuTestInfo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LstIssuTestInfo_KeyDown(object sender, KeyEventArgs e)
        {
            if(Keys.Delete==e.KeyCode)
            {
                DeleteItem();}
        }
       
       

       
      
     }
}