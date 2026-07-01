using DVLD.More;
using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Licenses
{
    public partial class FrmIssueLicenseForTheFirstTime : UserControl
    {

        public delegate void OnCloseEvent();
        public event OnCloseEvent CloseEvent;
        public ClsLocalLicense License { get; set; }
        public int localDrivingLicenseApplicationID {  get; set; }
        public ClsLocalDrivingLicenseApplication localDrivingLicenseApplication { get; set; }

        public FrmIssueLicenseForTheFirstTime(int localDrivingLicenseApplicationID)
        {
            InitializeComponent();
            this.localDrivingLicenseApplicationID = localDrivingLicenseApplicationID;

            int PassedTests = ClsLocalDrivingLicenseApplication.GetPassedTests(localDrivingLicenseApplicationID);

            if (localDrivingLicenseApplicationID != -1)
            {
                this.localDrivingLicenseApplication = ClsLocalDrivingLicenseApplication.Find(localDrivingLicenseApplicationID);
                if (this.localDrivingLicenseApplication != null)
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

        private void btnAddTestAppointment_Click(object sender, EventArgs e)
        {
            License = new ClsLocalLicense();
            License.ApplicationID = localDrivingLicenseApplication.ApplicationID;
            License.LicenseApplication = localDrivingLicenseApplication;
            License.LicenseClassID = localDrivingLicenseApplication.LicenseClassID;
            License.LicenseClass = localDrivingLicenseApplication.LicenseClass;
            License.IssueDate = DateTime.Now;
            License.ExpirationDate = DateTime.Now.AddYears(localDrivingLicenseApplication.LicenseClass.DefaultValidityLength); 
            License.Notes = txtNotes.Text;
            License.PaidFees = localDrivingLicenseApplication.LicenseClass.ClassFees;
            License.IsActive = true;
            License.IssueReason = ClsLocalLicense.enIssueReason.FirstTime;
            License.CreatedByUserID = ClsGlobal.CurrentUser.UserID;
            License.PersonID = localDrivingLicenseApplication.ApplicantPersonID;

            if (License.Save())
            {
                MessageBox.Show("License was Issued Successfully with id = " + License.LicenseID, "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnBack_Click(null, null);
            }
            else
            {
                MessageBox.Show("Sorry , Some thing went Wrong." , "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
