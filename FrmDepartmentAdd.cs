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

namespace Hospital_ERP_Solution.DynamicFields
{
    public partial class FrmDepartmentAdd : Form
    {
        public FrmDepartmentAdd()
        {
            InitializeComponent();
        }

        public SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Hospital"].ConnectionString);
        private SqlCommand command = null;



        HospitalERPDataContext dbContext=new HospitalERPDataContext();
        tbl_AddDepartment _addDepartment=new tbl_AddDepartment();


        private void btnDptAdd_Click(object sender, EventArgs e)
        {
           // if(_addDepartment==null)
           // {
                _addDepartment=new tbl_AddDepartment();
            //}

            _addDepartment.Department = txtDptAdd.Text;

          //  if(_addDepartment.DptID==0)
           // {
                dbContext.tbl_AddDepartments.InsertOnSubmit(_addDepartment);
            //}

            try
            {
                dbContext.SubmitChanges();
                MessageBox.Show("Department added Successfully", "Success", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                loadDepartment();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }


        public void loadDepartment()
        {
            con.Open();
            command = new SqlCommand("SELECT * From tbl_AddDepartment", con);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();


            sda.Fill(dt);

           dgvViewDepartment.DataSource = dt;

            con.Close();



        }

        private void FrmDepartmentAdd_Load(object sender, EventArgs e)
        {
            loadDepartment();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadDepartment();
        }

       }
    }

