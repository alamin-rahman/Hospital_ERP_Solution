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
using Hospital_ERP_Solution.Report;

namespace Hospital_ERP_Solution.Lab
{
    public partial class InvoiceReprint : Form
    {
        public InvoiceReprint()
        {
            InitializeComponent();
        }

        private SqlConnection con =
            new SqlConnection(ConfigurationManager.ConnectionStrings["Hospital"].ConnectionString);

        private SqlCommand command = null;

        private void btnSearch_Click(object sender, EventArgs e)
        {
          RptInvoice rptInvoice=new RptInvoice();
            SqlDataAdapter sda=new SqlDataAdapter();
            DataSet ds=new DataSet();
            sda.SelectCommand = new SqlCommand("sp_IssueTest @InvoiceNo",con);
            sda.SelectCommand.Parameters.Add("@InvoiceNo", txtSearchPrint.Text);
            sda.Fill(ds);
           ReportIssueTest aReportIssueTest=new ReportIssueTest();
            rptInvoice.SetDataSource(ds.Tables[0]);
            aReportIssueTest.crystalReportViewer1.ReportSource = rptInvoice;
            aReportIssueTest.crystalReportViewer1.RefreshReport();
            aReportIssueTest.ShowDialog();


        }
    }
}
