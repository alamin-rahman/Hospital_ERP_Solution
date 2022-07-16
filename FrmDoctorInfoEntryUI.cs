using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hospital_ERP_Solution.DoctorInfoEntries
{
    public partial class FrmDoctorInfoEntryUI : Form
    {
        public FrmDoctorInfoEntryUI()
        {
            InitializeComponent();
        }

      HospitalERPDataContext dataContext=new HospitalERPDataContext();
        tbl_PermanentDoctorInfo _permanentDoctorInfo=new tbl_PermanentDoctorInfo();
        tbl_GuestDoctorInfo _guestDoctorInfo=new tbl_GuestDoctorInfo();



        
        
        
       

        public void Load_PDDepartment()
        {
            List<tbl_AddDepartment> _addDepartments = new HospitalERPDataContext().tbl_AddDepartments.ToList();
            cmbPDDepartment.DataSource = _addDepartments;
            cmbPDDepartment.DisplayMember = "Department";
            cmbPDDepartment.ValueMember = "DptID";
        }

        public void Load_PDSpecialist()
        {
            List<tbl_Specialist> _specialists = new HospitalERPDataContext().tbl_Specialists.ToList();
            cmbPDSpecialist.DataSource = _specialists;
            cmbPDSpecialist.DisplayMember = "Specialist";
            cmbPDSpecialist.ValueMember = "SpecialistID";
        }

        public void Load_PDDesignation()
        {
            List<tbl_Designation> _designations = new HospitalERPDataContext().tbl_Designations.ToList();
            cmbPDDesignation.DataSource = _designations;
            cmbPDDesignation.DisplayMember = "Designation";
            cmbPDDesignation.ValueMember = "DesignationID";}


        private void btnPrmDocInfoSave_Click(object sender, EventArgs e)
        {
            if(_permanentDoctorInfo==null)
            {
                _permanentDoctorInfo=new tbl_PermanentDoctorInfo();

                return;
            }
            _permanentDoctorInfo.PrmntDocInfoDate = DateTime.ParseExact(dtpPrmntDocInfo.Text,"dd/MM/yyyy",null);
            _permanentDoctorInfo.DocID = txtPDoctorID.Text;
            _permanentDoctorInfo.DoctorName = txtPDoctorName.Text;
            _permanentDoctorInfo.DateOfBirth = DateTime.ParseExact(dtpPDocBirth.Text,"dd/MM/yyyy",null);
            _permanentDoctorInfo.BloodGroup = cmbPDBloodGroup.Text;
            _permanentDoctorInfo.NationalID = txtPDNationalID.Text;
            _permanentDoctorInfo.DepartmantName = cmbPDDepartment.Text;
            _permanentDoctorInfo.Specialist = cmbPDSpecialist.Text;
            _permanentDoctorInfo.InstituteName = txtPDInstituteName.Text;
            _permanentDoctorInfo.EducationalQualification = txtPDEduQlfction.Text;
            _permanentDoctorInfo.Designation = cmbPDDesignation.Text;
            _permanentDoctorInfo.RegistrationNo = txtPDRegistrationNo.Text;
            //_permanentDoctorInfo.DoctorPhoto =Convert. ;
            _permanentDoctorInfo.Address = txtPDAddress.Text;
            _permanentDoctorInfo.Email = txtPDEmail.Text;
            _permanentDoctorInfo.ContactNo = txtPDContactNo.Text;
            _permanentDoctorInfo.AltContactNo = txtPDAltContactNo.Text;
            _permanentDoctorInfo.Website = txtPDWebsite.Text;
            _permanentDoctorInfo.SkypeID = txtPDSkypeID.Text;

            if(_permanentDoctorInfo.PrmntDocInfoID==0)
            {
                dataContext.tbl_PermanentDoctorInfos.InsertOnSubmit(_permanentDoctorInfo);

            }

            try
            {
                dataContext.SubmitChanges();
                MessageBox.Show("Doctor's Info Successfully Added!", "Success", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error");
            }
        }

        
        
    }
}
