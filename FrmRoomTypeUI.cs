using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hospital_ERP_Solution.DynamicFields
{
    public partial class FrmRoomTypeUI : Form
    {
        public FrmRoomTypeUI()
        {
            InitializeComponent();
        }

        HospitalERPDataContext dbContext=new HospitalERPDataContext();
        tbl_RoomType _roomType=new tbl_RoomType();

        private void btnRoomType_Click(object sender, EventArgs e)
        {
            if(_roomType==null)
            {
                _roomType=new tbl_RoomType();
            }

            _roomType.RoomType = txtRoomType.Text;

            if(_roomType.RmTypID==0)
            {
                dbContext.tbl_RoomTypes.InsertOnSubmit(_roomType);
            }
            try
            {
                dbContext.SubmitChanges();
                MessageBox.Show("Room Type Added Successfully!","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
