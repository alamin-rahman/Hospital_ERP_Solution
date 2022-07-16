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
    public partial class frmViewTestInfoUI : Form
    {
        public frmViewTestInfoUI()
        {
            InitializeComponent();
        }

       public SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Hospital"]. ConnectionString);
        

        
        private void frmViewTestInfoUI_Load(object sender, EventArgs e)
       {
           loadTestInfo(); //calling
       }
        private void loadTestInfo()
        {

            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from tbl_LabTestEntry", con);
            DataTable dt = new DataTable(); 
            sda.Fill(dt);
            dgv_ViewLabTest.Rows.Clear();
            
            foreach (DataRow item  in dt.Rows)
            {
                int n = dgv_ViewLabTest.Rows.Add();
                dgv_ViewLabTest.Rows[n].Cells[0].Value = "false";
                dgv_ViewLabTest.Rows[n].Cells[1].Value = item["LabTestID"].ToString();
                dgv_ViewLabTest.Rows[n].Cells[2].Value = item["TestCategory"].ToString();
                dgv_ViewLabTest.Rows[n].Cells[3].Value = item["TestID"].ToString();
                dgv_ViewLabTest.Rows[n].Cells[4].Value = item["TestName"].ToString();
                dgv_ViewLabTest.Rows[n].Cells[5].Value = item["TestPrice"].ToString();
                dgv_ViewLabTest.Rows[n].Cells[6].Value = item["RoomNo"].ToString();
                dgv_ViewLabTest.Rows[n].Cells[7].Value = item["TestDate"].ToString();

                //dgv_ViewLabTest.DataSource = dt; (This Code can be used to show data in datagridView)
            }

            }

        private void btnViewTestDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dgv_ViewLabTest.Rows)
            {
                if (Convert.ToBoolean(item.Cells[0].Value.ToString())){
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from tbl_LabTestEntry where LabTestID='" +item.Cells[1].Value.ToString()+"'",con);
                    
                    cmd.ExecuteNonQuery();con.Close();
                }}
              loadTestInfo();
              MessageBox.Show("Deleted succesfully");
        }
    }
}
