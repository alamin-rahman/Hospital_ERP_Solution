using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Hospital_ERP_Solution.DoctorInfoEntries;
using Hospital_ERP_Solution.DynamicFields;
using Hospital_ERP_Solution.Non_Printable_Report;

namespace Hospital_ERP_Solution.Lab
{
    public partial class LabMasterPage : Form
    {
        public LabMasterPage()
        {
            InitializeComponent();
        }

        private void tileItem2_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            FrmTestEntryUI TestEntry=new FrmTestEntryUI();
            TestEntry.Show();
        }

        private void tileItem1_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            FrmDoctorPercentageUI DoctorsPercentage=new FrmDoctorPercentageUI();
            DoctorsPercentage.Show();
        }

        private void tileItem3_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            FrmBillingUI billing=new FrmBillingUI();
            billing.Show();
        }

        private void tileItem4_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            FrmDueCollectionUI dueCollection = new FrmDueCollectionUI();
            dueCollection.Show();}

        private void tileItem6_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            FrmDoctorInfoEntryUI doctorInfo=new FrmDoctorInfoEntryUI();
            doctorInfo.Show();
        }

        private void tileItem5_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
          FrmShowDynamicFields  aShowDynamicFields=new FrmShowDynamicFields();
            aShowDynamicFields.Show();
        }

        
        private void tileItem8_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            FrmDoctorPercentageUI doctorPercentage=new FrmDoctorPercentageUI();
            doctorPercentage.Show();
        }

        private void tileItem9_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            FrmNonPrintableReport printableReport=new FrmNonPrintableReport();
            printableReport.Show();
        }
    }}