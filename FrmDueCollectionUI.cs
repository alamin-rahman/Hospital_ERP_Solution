using System;
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
    public partial class FrmDueCollectionUI : Form
    {
        public FrmDueCollectionUI()
        {
            InitializeComponent();
        }
        private SqlConnection con =
         new SqlConnection(ConfigurationManager.ConnectionStrings["Hospital"].ConnectionString);

        private SqlCommand command = null;



        public void loadGroupCash()
        {
            con.Open();
            command = new SqlCommand("SELECT Sl,Name,UnderGroup,nature From tbl_Ledgers Where sl=2 ", con);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                txtGrpCshId.Text = reader[0].ToString();
                txtGrpCshName.Text = reader[1].ToString();
                txtCshUndrGrpDue.Text = reader[2].ToString();
                txtGrpCshTypDue.Text = reader[3].ToString();
            }

            con.Close();
        }

        private void LoadDueAmountCredit()
        {
            con.Open();
            command =
                new SqlCommand(
                    "SELECT (ISNULL(SUM(credit),0)) from tbl_LedgerAmount where LeaderId='" + txtSearchInvoiceNo.Text + "' ",
                    con);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                //txtToatalAmount.Text = reader[0].ToString();
                txtPaidAmount.Text = reader[0].ToString();
                txtTempPaidAmount.Text = reader[0].ToString();

            }


            con.Close();
        }


        private void LoadDueAmountDebit()
        {
            con.Open();
            command =
                new SqlCommand(
                    "SELECT credit from tbl_LedgerAmount where Particulars='" + txtSearchInvoiceNo.Text + "' ",
                    con);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                txtToatalAmount.Text = reader[0].ToString();
                //txtPaidAmount.Text = reader[1].ToString();

            }


            con.Close();
        }

        private void LoadDueAmountDrMinusCr()
        {
            con.Open();
            command =
                new SqlCommand(
                    "SELECT (ISNULL(SUM(debit),0)-ISNULL(SUM(credit),0)) from tbl_LedgerAmount where LeaderId='" + txtSearchInvoiceNo.Text + "' ",
                    con);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                txtDueAmount.Text = reader[0].ToString();
                txtTempDueAmnt.Text = reader[0].ToString();

            }


            con.Close();
        }










        private void FrmDueCollectionUI_Load(object sender, EventArgs e)
        {
            dgvDueCollectionBill.DefaultCellStyle.ForeColor = Color.Black;           
            
            
            SearchInvoiceNo();
            loadGroupCash();//loadIssueTest_DueCollection();
        }

        private void SearchInvoiceNo()
        {


            con.Open();
            command = new SqlCommand("SELECT DISTINCT InvoiceNo from tbl_invoice ", con);
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(command);
            sda.Fill(ds, "tbl_invoice");
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            int i = 0;
            for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
            {
                col.Add(ds.Tables[0].Rows[i]["InvoiceNo"].ToString());

            }
            txtSearchInvoiceNo.AutoCompleteSource = AutoCompleteSource.CustomSource;

            txtSearchInvoiceNo.AutoCompleteCustomSource = col;
            txtSearchInvoiceNo.AutoCompleteMode = AutoCompleteMode.Suggest;


            con.Close();





        }

        private void txtSearchInvoiceNo_TextChanged(object sender, EventArgs e)
        {

            con.Open();
            command = new SqlCommand("SELECT OrderDate,DeliveryDate,PatientName,Age,Gender,ContactNo,DoctorID,DoctorName,Specialist,Department from  tbl_invoice where InvoiceNo='" + txtSearchInvoiceNo.Text + "' ", con);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {

                dtpOrderDateDue.Text = reader[0].ToString();
                dtpDeliveryDateDue.Text = reader[1].ToString();
                txtPatientNameDueBill.Text = reader[2].ToString();
                txtAgeDueBill.Text = reader[3].ToString();
                txtGenderDueBill.Text = reader[4].ToString();
                txtContactNoDueBill.Text = reader[5].ToString();
                txtDoctorID.Text = reader[6].ToString();
                txtDoctorName.Text = reader[7].ToString();
                txtSpecialist.Text = reader[8].ToString();
                txtDoctorDepartment.Text = reader[9].ToString();
               
               
            }
            

            con.Close();
        }

        public void loadIssueTest_DueCollection()
        {
          
             con.Open();
             command = new SqlCommand("SELECT * from tbl_IssueTest where InvoiceNo='" + txtSearchInvoiceNo.Text + "' ", con);
             SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable(); 
            sda.Fill(dt);
        
           dgvDueCollectionBill.DataSource = dt;
            con.Close();
         }

        

        private void txtSearchInvoiceNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {



                loadIssueTest_DueCollection();
                SearchInvoiceNo();
                LoadDueAmountDebit();
                LoadDueAmountCredit();

                LoadDueAmountDrMinusCr();
            }
        }

    


        private void btnDueCollectionSave_Click(object sender, EventArgs e)
        {
            
            /////////////////////////Insert into tbl_LedgerAmount//////////////////////////
            con.Open();

            string Insert_LedgerAmount_Cash = "insert Into tbl_LedgerAmount(LeaderId,date,LadgerName,Undergrp,Nature,Particulars,credit,vchType)  Values(@a1,@a2,@a3,@a4,@a5,@a6,@a7,@a8)";
            command = new SqlCommand(Insert_LedgerAmount_Cash);
            command.Connection = con;
            command.Parameters.AddWithValue("@a1", txtSearchInvoiceNo.Text);
            command.Parameters.AddWithValue("@a2", dtpDeliveryDateDue.Text);
            command.Parameters.AddWithValue("@a3", txtPatientNameDueBill.Text);
            command.Parameters.AddWithValue("@a4", txtCshUndrGrpDue.Text);
            command.Parameters.AddWithValue("@a5", txtGrpCshTypDue.Text);
            command.Parameters.AddWithValue("@a6", txtParticularCashDue.Text);
            command.Parameters.AddWithValue("@a7", txtPayDueAmount.Text);
            command.Parameters.AddWithValue("@a8", txtVoucherReceiptDue.Text);


            con.Close();
            con.Open();
            command.ExecuteNonQuery();
            con.Close();

            //////////////////////////////Insert into tbl_DueCollection///////////////////////////



            con.Open();

            string insert_tbl_DueCollection = "insert Into tbl_DueCollection(InvoiceNo,OrderDate,DeliveryDate,PatientName,DoctorID,VoucherType,TotalAmount,PaidAmount,DueAmount,PayDueAmount)  Values(@a1,@a2,@a3,@a4,@a5,@a6,@a7,@a8,@a9,@a10)";
            command = new SqlCommand(insert_tbl_DueCollection);
            command.Connection = con;
            command.Parameters.AddWithValue("@a1", txtSearchInvoiceNo.Text);
            command.Parameters.AddWithValue("@a2", dtpOrderDateDue.Text);
            command.Parameters.AddWithValue("@a3", dtpDeliveryDateDue.Text);
            command.Parameters.AddWithValue("@a4", txtPatientNameDueBill.Text);
            command.Parameters.AddWithValue("@a5", txtDoctorID.Text);
            command.Parameters.AddWithValue("@a6", txtVoucherReceiptDue.Text);
            command.Parameters.AddWithValue("@a7", txtToatalAmount.Text);
            command.Parameters.AddWithValue("@a8", txtPaidAmount.Text);
            command.Parameters.AddWithValue("@a9", txtDueAmount.Text);
            command.Parameters.AddWithValue("@a10", txtPayDueAmount.Text);

            con.Close();
            con.Open();
            command.ExecuteNonQuery();
            con.Close();

            //////////////////////////////Insert into tbl_Cash for Due Collection///////////////////////////  


            con.Open();

            string Insert_Cash = "insert Into tbl_Cash (Cash,Date,Particular,InvoiceNo,VoucherType,Debit,GroupID,GroupName,UnderGroup,GroupType)  Values(@a1,@a2,@a3,@a4,@a5,@a6,@a7,@a8,@a9,@a10)";
            command = new SqlCommand(Insert_Cash);
            command.Connection = con;

            command.Parameters.AddWithValue("@a1", txtPayDueAmount.Text);
            command.Parameters.AddWithValue("@a2", dtpOrderDateDue.Text);
            command.Parameters.AddWithValue("@a3", txtSearchInvoiceNo.Text);
            command.Parameters.AddWithValue("@a4", txtSearchInvoiceNo.Text);
            command.Parameters.AddWithValue("@a5", txtVoucherReceiptDue.Text);
            command.Parameters.AddWithValue("@a6", txtPayDueAmount.Text);
            command.Parameters.AddWithValue("@a7", txtGrpCshId.Text);
            command.Parameters.AddWithValue("@a8", txtGrpCshName.Text);
            command.Parameters.AddWithValue("@a9", txtCshUndrGrpDue.Text);
            command.Parameters.AddWithValue("@a10", txtGrpCshTypDue.Text);



            con.Close();
            con.Open();
            command.ExecuteNonQuery();
            con.Close();


            MessageBox.Show("Due Paid Successfully", "Succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtPayDueAmount_TextChanged(object sender, EventArgs e)
        {
            //double TotalAmount;
            //double PaidAmount;

            //double.TryParse(txtToatalAmount.Text, out TotalAmount);
            //double.TryParse(txtPaidAmount.Text, out PaidAmount);

            //if (TotalAmount > PaidAmount)
            //{
            //    MessageBox.Show("Paid Amount:Over Flow");
            //}
            if(txtPayDueAmount.Text=="")
            {

                txtDueAmount.Text = txtTempDueAmnt.Text;
                txtPaidAmount.Text = txtTempPaidAmount.Text;


            }
            else
            {
                txtDueAmount.Text = (Convert.ToDouble(txtTempDueAmnt.Text) - Convert.ToDouble(txtPayDueAmount.Text)).ToString();
                txtPaidAmount.Text = (Convert.ToDouble(txtTempPaidAmount.Text) + Convert.ToDouble(txtPayDueAmount.Text)).ToString();
              
            }


            //try
            //{
               
            //}
            //catch (Exception)
            //{
            //   }
            
            
            
            //try
            //{

            //    double valueOne = 0;
            //    double valueTwo = 0;

            //    double.TryParse(txtDueAmount.Text, out valueOne);
            //    double.TryParse(txtPayDueAmount.Text, out valueTwo);
            //    valueOne = Math.Round(valueOne, 2);
            //    valueTwo = Math.Round(valueTwo, 2);
            //    double paidDueAmount = (valueOne - valueTwo);
            //    paidDueAmount = Math.Round(paidDueAmount, 2);
            //    txtDueAmount.Text = paidDueAmount.ToString();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //}
        }

        private void txtPaidAmount_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
