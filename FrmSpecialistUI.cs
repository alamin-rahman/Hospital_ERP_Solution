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
    public partial class FrmSpecialistUI : Form
    {
        public FrmSpecialistUI()
        {
            InitializeComponent();
        }

        HospitalERPDataContext dataContext=new HospitalERPDataContext();
        tbl_Specialist _specialist=new tbl_Specialist();

        private SqlConnection con =
            new SqlConnection(ConfigurationManager.ConnectionStrings["Hospital"].ConnectionString);

        private SqlCommand command = null;


        private void btnSpecialistAdd_Click(object sender, EventArgs e)
        {

            

           con.Open();
          command =new SqlCommand("SELECT * From tbl_Specialist Where Specialist='" + txtSpecialist.Text + "' ", con);
            int count = Convert.ToInt32(command.ExecuteScalar());
            if (count > 0)
            {

                MessageBox.Show("Item Already Added");
                con.Close();
            }
                else
            {
               con.Close();
               
            

          //  if (_specialist == null)
           // {
                _specialist = new tbl_Specialist();
           // }

            _specialist.Specialist = txtSpecialist.Text;

            //if (_specialist.SpecialistID == 0)
           // {
                dataContext.tbl_Specialists.InsertOnSubmit(_specialist);
                // }

            try
            {
                dataContext.SubmitChanges();
                MessageBox.Show("Data Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadSpecialist();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
        public void LoadSpecialist()
        {
            con.Open();

            command = new SqlCommand("Select * from tbl_Specialist",con);
            SqlDataAdapter sda=new SqlDataAdapter(command);
            DataSet dts=new DataSet();
            sda.Fill(dts, "tbl_Specialist");
            dgvSpecialist.DataSource = dts.Tables["tbl_Specialist"].DefaultView;
            con.Close();
        
        }
        private void FrmSpecialistUI_Load(object sender, EventArgs e)
        {
            LoadSpecialist();
        
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadSpecialist();
        }
    }
}
