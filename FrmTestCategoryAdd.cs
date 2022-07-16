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
    public partial class FrmTestCategoryAdd : Form
    {
        public FrmTestCategoryAdd()
        {
            InitializeComponent();
           

        }

        public SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Hospital"].ConnectionString);
        private SqlCommand command = null;


        HospitalERPDataContext dbContext=new HospitalERPDataContext();
        tbl_Category _tblCategory=new tbl_Category();

        private void btnTestCategory_Click(object sender, EventArgs e)
        {
           // if(_tblCategory==null)
           // {

                _tblCategory=new tbl_Category();
            //}

            _tblCategory.TestCategory = txtTestCategory.Text;

           // if(_tblCategory.TestId==0)
           // {
               dbContext.tbl_Categories.InsertOnSubmit(_tblCategory);
            //}

            try
            {
                dbContext.SubmitChanges();
                MessageBox.Show("Test Category Saved");
                loadCategory();}
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                
            }
        }

        public void loadCategory()
        {
            con.Open();
            command = new SqlCommand("SELECT * From tbl_Category", con);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();


            sda.Fill(dt);

         dgTestCategory.DataSource = dt;

            con.Close();

            
        }


        private void FrmTestCategoryAdd_Load(object sender, EventArgs e)
        {
            loadCategory();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadCategory();
        }
    }
}
