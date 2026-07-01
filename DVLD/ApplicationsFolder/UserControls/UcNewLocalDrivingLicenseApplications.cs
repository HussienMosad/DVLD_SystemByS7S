using DVLD.More;
using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.ApplicationsFolder.MainForms
{
    public partial class UcNewLocalDrivingLicenseApplications : UserControl
    {

        public int ApplicationTypeID { get; set; }
       
        public UcNewLocalDrivingLicenseApplications()
        {
            InitializeComponent();
        }

        public void LoadFirstTime( int ApplicationTypeID)
        {
            this.ApplicationTypeID = ApplicationTypeID;
            if (ClsGlobal.CurrentUser != null)
            {
                lblCreatedBy.Text = ClsUser.Find(ClsGlobal.CurrentUser.UserID).UserName;
                lblDate.Text = DateTime.Now.ToString();
                lblFees.Text = ClsApplicationType.Find(ApplicationTypeID).Fees.ToString();
            }
        }

        public void UpdateComponent(ClsLocalDrivingLicenseApplication LocalDrivingLicenseApplication)
        {
            LoadFirstTime((int)LocalDrivingLicenseApplication.ApplicationTypeID);
            lblID.Text = LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
            CmbClass.SelectedIndex = LocalDrivingLicenseApplication.LicenseClassID - 1;
        }


        public float getPaidFees()
        {
            return Convert.ToSingle(lblFees.Text);
        }


        public int getCreatedByUserID()
        {
            return ClsGlobal.CurrentUser.UserID;
        }

        public int getClassID()
        {
            return CmbClass.SelectedIndex+1;
        }

        private void UcNewLocalDrivingLicenseApplications_Load(object sender, EventArgs e)
        {
            
            
        }

        private void CmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        public void setLblID(int id)
        {
            lblID.Text = id.ToString();
        }

       
    }
}
