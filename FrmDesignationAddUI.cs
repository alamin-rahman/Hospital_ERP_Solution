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
    public partial class FrmDesignationAddUI : Form
    {
        public FrmDesignationAddUI()
        {
            InitializeComponent();
        }

        public SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Hospital"].ConnectionString);
        private SqlCommand command = null;


        HospitalERPDataContext dataContext=new HospitalERPDataContext();
        tbl_Designation _designation=new tbl_Designation();



        

        private void btnDesignationAdd_Click(object sender, EventArgs e)
        {
           // if(_designation==null)
           // {

            //con.Open();
            //command = new SqlCommand("SELECT Designation From tbl_Designation where Designation='"+txtDesignationAdd.Text+"'",con);

            

                _designation=new tbl_Designation();
           // }

            _designation.Designation = txtDesignationAdd.Text;
            

            //if(_designation.DesignationID==0)
           // {
                dataContext.tbl_Designations.InsertOnSubmit(_designation);
                
           // }
            try
            {
                dataContext.SubmitChanges();
                MessageBox.Show("Data successfully Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadDesignation();
                }
              
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            return;


          
            }

        public void loadDesignation()
        {
            con.Open();
            command = new SqlCommand("SELECT * From tbl_Designation",con);
            SqlDataAdapter sda=new SqlDataAdapter(command);
            DataTable dt=new DataTable();


            sda.Fill(dt);

            dgvViewDesignation.DataSource = dt;

            con.Close();



        }


        private void FrmDesignationAddUI_Load(object sender, EventArgs e)
        {
            loadDesignation();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadDesignation();
        }
    }
}
