using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Hospital_ERP_Solution.Lab;

namespace Hospital_ERP_Solution.DynamicFields
{
    public partial class FrmShowDynamicFields : Form
    {
        public FrmShowDynamicFields()
        {
            InitializeComponent();
        }

        private void tileItem1_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            FrmTestCategoryAdd testCategory=new FrmTestCategoryAdd();testCategory.Show();

        }

        private void tileItem2_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            FrmSpecialistUI specialistUi=new FrmSpecialistUI();
            specialistUi.Show();
        }

        private void tileItem3_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            FrmDepartmentAdd departmentAdd=new FrmDepartmentAdd();
            departmentAdd.Show();
        }

        private void tileItem4_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            FrmDesignationAddUI frmDesignationAdd=new FrmDesignationAddUI();
            frmDesignationAdd.Show();
        }

        private void tileItem5_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            FrmTestEntryUI testEntry = new FrmTestEntryUI();
            testEntry.Show();}
    }
}
