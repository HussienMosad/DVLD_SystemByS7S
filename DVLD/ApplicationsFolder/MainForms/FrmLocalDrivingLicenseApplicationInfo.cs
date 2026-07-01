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

    public partial class FrmLocalDrivingLicenseApplicationInfo : UserControl
    {
        public delegate void OnCloseEvent();
        public event OnCloseEvent CloseEvent;

        public ClsLocalDrivingLicenseApplication localDrivingLicenseApplication { get; set; }

        public int localDrivingLicenseApplicationID { get; set; }

        public FrmLocalDrivingLicenseApplicationInfo()
        {
            InitializeComponent();
        }

        public int PassedTests {  get; set; }

        public FrmLocalDrivingLicenseApplicationInfo( int localDrivingLicenseApplicationID)
        {
            InitializeComponent();
            this.localDrivingLicenseApplicationID = localDrivingLicenseApplicationID;

            if(localDrivingLicenseApplicationID != -1)
            {
                PassedTests =  ClsLocalDrivingLicenseApplication.GetPassedTests(localDrivingLicenseApplicationID);
                this.localDrivingLicenseApplication = ClsLocalDrivingLicenseApplication.Find(localDrivingLicenseApplicationID);
                if(this.localDrivingLicenseApplication != null)
                {
                    ucApplicationBasicInfo1.UpdateComponents((ClsApplication)localDrivingLicenseApplication);
                    ucDrivingLicenseApplicationInfo1.UpdateComponents(localDrivingLicenseApplicationID, PassedTests, localDrivingLicenseApplication.LicenseClass.ClassName);
                }
                else
                {
                    MessageBox.Show("Sorry ,can not find the L.D.L.A with ID = " + localDrivingLicenseApplicationID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSwitchFillColor(object sender, EventArgs e)
        {
            ClsUtil.btnSwitchFillColor(sender, e);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmHome.RemoveFromMainPanel();
            CloseEvent?.Invoke();
        }
    }
}
