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
    public partial class FrmDoctorPercentageUI : Form
    {
        public FrmDoctorPercentageUI()
        {
            InitializeComponent();
        }


        private SqlConnection con =
            new SqlConnection(ConfigurationManager.ConnectionStrings["Hospital"].ConnectionString);

        private SqlCommand command = null;

        private HospitalERPDataContext dataContext = new HospitalERPDataContext();
        private tbl_DoctorPercentage _doctorPercentage = new tbl_DoctorPercentage();


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

        private void clear()
        {
            txtDoctorID.ResetText();
            txtDocName.ResetText();
            txtSpecialist.ResetText();
            txtTestCategory.ResetText();
            txtDocPercentage.ResetText();
        }



        private void AutoLoadTestCategory()
        {


            con.Open();
            command = new SqlCommand("SELECT DISTINCT TestCategory  from tbl_Category ", con);
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(command);
            sda.Fill(ds, "tbl_LabTestEntry");
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            int i = 0;
            for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++){

                col.Add(ds.Tables[0].Rows[i]["TestCategory"].ToString());

            }
            txtTestCategory.AutoCompleteSource = AutoCompleteSource.CustomSource;

            txtTestCategory.AutoCompleteCustomSource = col;
            txtTestCategory.AutoCompleteMode = AutoCompleteMode.Suggest;


            con.Close();

        }



        private void DataGridDoctorPercentage()
        {

            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from tbl_DoctorPercentage", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);


            //dgvDoctorPercentage.Rows.Clear();

            dgvDoctorPercentage.DataSource = dt;

        }



        private void BtnDocPrcntSave_Click(object sender, EventArgs e)
        {
            //if (_doctorPercentage == null)
           // {

            if (txtDoctorID.Text != string.Empty && txtDocName.Text != string.Empty && txtSpecialist.Text != string.Empty &&
                txtTestCategory.Text != string.Empty && txtDocPercentage.Text != string.Empty)
                
                           // }
            {
                _doctorPercentage=new tbl_DoctorPercentage();
                _doctorPercentage.DoctorID = txtDoctorID.Text;
                _doctorPercentage.DoctorName = txtDocName.Text;
                _doctorPercentage.Specialist = txtSpecialist.Text;
                _doctorPercentage.TestCategory = txtTestCategory.Text;
                _doctorPercentage.Percentage = Convert.ToDecimal(txtDocPercentage.Text);
            }
        else
            {
                MessageBox.Show("Please Fill up the required field");
                return;}
           

           // if (_doctorPercentage.DocPrcntID == 0)
            //{
                dataContext.tbl_DoctorPercentages.InsertOnSubmit(_doctorPercentage);
           // }

            try
            {
                dataContext.SubmitChanges();
                MessageBox.Show("Doctor Information Added Successfully!", "Success", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                con.Close(); 
                DataGridDoctorPercentage();
                clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error");
            }
        }




        //con.Open();


        //    string update_Commission = "UPDATE tbl_DoctorCommission SET DoctorID=@d1,DoctorName=@d2,Specialist=@d3,TestCategory=@d4,Percentage=@d5 WHERE DoctorCommisionID='" + txtCommisionID.Text + "'";
        //    command = new SqlCommand(update_Commission, con);
        //    command.Parameters.AddWithValue("@d1", txtDoctorIDPercentage.Text);
        //    command.Parameters.AddWithValue("@d2", txtDoctorNamePercentage.Text);
        //    command.Parameters.AddWithValue("@d3", txtSpecialistPercentage.Text);
        //    command.Parameters.AddWithValue("@d4", cmbTestCategoryPercentage.Text);
        //    command.Parameters.AddWithValue("@d5", txtPercentage.Text);


        //    command.ExecuteNonQuery();
        //    con.Close();
        //    MessageBox.Show("Doctor Commission  Updated Successfully", "Data Modified", MessageBoxButtons.OK, MessageBoxIcon.Information);






        private void FrmDoctorPercentageUI_Load(object sender, EventArgs e)
        {
            btnDocPercentDelete.Enabled = false;
            btnDocPercentUpdate.Enabled = false;
            AutoLoadDoctorID();
            AutoLoadTestCategory();
            DataGridDoctorPercentage();
   
        }

        private void txtDoctorID_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            command =
                new SqlCommand(
                    "SELECT DoctorName,Specialist from tbl_PermanentDoctorInfo where DocID='" + txtDoctorID.Text + "' ", con);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                txtDocName.Text = reader[0].ToString();
                txtSpecialist.Text = reader[1].ToString();

            }
            con.Close();}

        private void dgvDoctorPercentage_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            BtnDocPrcntSave.Enabled = false;
            btnDocPercentUpdate.Enabled = true;

            txtDoctorID.ReadOnly = true;
            txtDocName.ReadOnly = true;
            txtSpecialist.ReadOnly = true;
            txtTestCategory.ReadOnly = true;try
            {
                DataGridViewRow dataGrid = dgvDoctorPercentage.SelectedRows[0];
                


                txtDoctorID.Text = dataGrid.Cells[1].Value.ToString();
                txtDocName.Text = dataGrid.Cells[2].Value.ToString();
                txtSpecialist.Text = dataGrid.Cells[3].Value.ToString();
                txtTestCategory.Text = dataGrid.Cells[4].Value.ToString();
                txtDocPercentage.Text = dataGrid.Cells[5].Value.ToString();
                //aStudentInfo.BtnStndInfoSave.Enabled = false;
                //aStudentInfo.BtnStndInfoDelete.Enabled = true;
                //aStudentInfo.BtnStndInfoUpdate.Enabled = true;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
      

        private void btnDocPercentUpdate_Click(object sender, EventArgs e)
        {
            

            try
            {
                con.Open();
                string Check_Doc_Commision = "SELECT  Count(*) From tbl_DoctorPercentage  Where Percentage='" +
                                             txtDocPercentage.Text + "'";
                command = new SqlCommand(Check_Doc_Commision, con);
                int count = Convert.ToInt32(command.ExecuteScalar());
                if (count > 0)
                {
                    MessageBox.Show("This percentage  Already Exist", "Existed Data");
                    con.Close();
                }
                else{   con.Close();
                    con.Open();

                    if (txtDoctorID.Text != string.Empty && txtDocName.Text != string.Empty &&
                        txtSpecialist.Text != string.Empty &&
                        txtTestCategory.Text != string.Empty && txtDocPercentage.Text != string.Empty)
                    {
                        string load =
                            string.Format(
                                "UPDATE tbl_DoctorPercentage SET DoctorID='{0}',  DoctorName='{1}',Specialist='{2}',TestCategory='{3}',Percentage='{4}' WHERE DoctorID='{0}'",
                                txtDoctorID.Text, txtDocName.Text, txtSpecialist.Text, txtTestCategory.Text,
                                txtDocPercentage.Text);
                        SqlCommand aSqlCommand = new SqlCommand(load, con);
                        aSqlCommand.ExecuteReader();
                        con.Close();
                        MessageBox.Show("Record Updated!", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DataGridDoctorPercentage();}
                    else
                    {
                        MessageBox.Show("Nothing to Update", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        con.Close();
                    }
                }
            }
                catch
                (Exception
                ex)
                {

                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
        }

    }

