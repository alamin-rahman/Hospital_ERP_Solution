using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hospital_ERP_Solution.Lab
{
    public partial class FrmTestEntryUI : Form
    {
        public FrmTestEntryUI()
        {
            InitializeComponent();

        }

        public SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Hospital"].ConnectionString);

        public SqlCommand command=new SqlCommand();

     
        
        HospitalERPDataContext dataContext=new HospitalERPDataContext();
        tbl_LabTestEntry _labTest=new tbl_LabTestEntry();

        
        private void btnLabTestSave_Click(object sender, EventArgs e)
        {
           // if(_labTest==null)
            //{
                _labTest =new tbl_LabTestEntry();
            //}
               // _labTest.Test = Convert.ToInt16(txtTest.Text);
            _labTest.TestCategory = txtTestCategory.Text;
            _labTest.TestID = txtTestId.Text;
            _labTest.TestName = txtTestName.Text;
            _labTest.TestPrice = Convert.ToDecimal(txtPrice.Text);
            _labTest.RoomNo = txtRoomNo.Text;
            _labTest.TestDate = DateTime.ParseExact(dtpLabTest.Text,"dd/MM/yyyy",null);
         // if(_labTest.LabTestID==0)
          //{dataContext.tbl_LabTestEntries.InsertOnSubmit(_labTest);
         // }
            try
            {
                dataContext.SubmitChanges();
                MessageBox.Show("Test Information Saved Successfully","Success Message",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error Message",MessageBoxButtons.OK,MessageBoxIcon.Error);

                
            }
            Clear();
        }

        public  void Clear()
        {
            txtTestId.ResetText();
            txtTestName.ResetText();
            txtPrice.ResetText();
            txtRoomNo.ResetText();
           

        }

        private void FrmTestEntryUI_Load(object sender, EventArgs e)
        {
            AutoLoadTestCategory();
            

        }

       
        private void btnTestView_Click(object sender, EventArgs e)
        {
           // frmViewTestInfoUI vutestinfo=new frmViewTestInfoUI();
           // vutestinfo.Show();
        }

        private void AutoLoadTestCategory()
        {


            con.Open();
            command = new SqlCommand("SELECT DISTINCT TestCategory  from tbl_Category ", con);
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(command);
            sda.Fill(ds, "tbl_Category");
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            int i = 0;
            for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
            {

                col.Add(ds.Tables[0].Rows[i]["TestCategory"].ToString());

            }
            txtTestCategory.AutoCompleteSource = AutoCompleteSource.CustomSource;

            txtTestCategory.AutoCompleteCustomSource = col;
            txtTestCategory.AutoCompleteMode = AutoCompleteMode.Suggest;


            con.Close();

        }

        private void btnLabTestUpdate_Click(object sender, EventArgs e)
        {

        }

        private void txtTestName_TextChanged(object sender, EventArgs e)
        {
            if (txtTestName.Text.Length > 0)
            {
                char[] v = txtTestName.Text.ToCharArray();
                string s = v[0].ToString().ToUpper();
                for (int b = 1; b < v.Length; b++)
                    s += v[b].ToString().ToLower();
                txtTestName.Text = s;
                txtTestName.Select(txtTestName.Text.Length, 0);
            }
            else
                
                txtTestName.Text = "";}

        

    }

}
