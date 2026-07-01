using DVLD.Licenses.MainForms;
using DVLD.Licenses.SecondryForms;
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
    public partial class FrmReplacementForLostOrDamagedLicense : UserControl
    {
        public delegate void OnCloseEvent();
        public event OnCloseEvent CloseEvent;

        public ClsLocalLicense LocalLicense { get; set; }

        public FrmReplacementForLostOrDamagedLicense()
        {
            InitializeComponent();
            LocalLicense = new ClsLocalLicense();
            labAppDate.Text = DateTime.Now.ToShortDateString();
            labCreatedBy.Text = ClsGlobal.CurrentUser.UserName;
            labAppFees.Text = ClsApplicationType.Find((int)ClsApplication.enApplicationType.ReplaceDamagedDrivingLicense).Fees.ToString();
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

        private void btnShowLicensesHistory_Click(object sender, EventArgs e)
        {
            if (ucLicenseInfoWithFilter1.localLicense != null)
            {
                FrmHome.AddToMainPanel(new FrmShowPersonLicensesHistory(ucLicenseInfoWithFilter1.localLicense.DriverID));
            }
            else
            {
                MessageBox.Show("Please chose a license First.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShowLicenseInfo_Click(object sender, EventArgs e)
        {
            if (labReplacedLicenseID.Text.Trim() == "?".Trim())
            {
                FrmHome.AddToMainPanel(new FrmLicenseInfo(ucLicenseInfoWithFilter1.localLicense));
            }
            else
            {
                FrmHome.AddToMainPanel(new FrmLicenseInfo(LocalLicense.LicenseID));
            }
        }

        private void ucLicenseInfoWithFilter1_OnLicenseSelected()
        {
            labOldLicenseID.Text = ucLicenseInfoWithFilter1.localLicense.LicenseID.ToString();

            if (ucLicenseInfoWithFilter1.localLicense.IsActive == false)
            {
                MessageBox.Show("Sorry , this license is not Active ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnShowLicenseInfo.Enabled = true;
            }
            else if (ucLicenseInfoWithFilter1.localLicense.ExpirationDate < DateTime.Now)
            {
                MessageBox.Show("Sorry , this license is expired. ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnShowLicenseInfo.Enabled = true;
            }
            else if (ClsDetainedLicense.IsLicenseDetained(ucLicenseInfoWithFilter1.localLicense.LicenseID))
            {
                MessageBox.Show("Sorry , this license is Detained , release it first ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnShowLicenseInfo.Enabled = true;
            }
            else
            {
                btnReplace.Enabled = true;
            }
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            ClsApplication app = new ClsApplication();
            app.ApplicantPersonID = ucLicenseInfoWithFilter1.localLicense.Driver.PersonID;
            app.ApplicationDate = DateTime.Now;
            app.ApplicationTypeID = (Convert.ToInt16 (LabReplaceFor.Tag) == 0)? ClsApplication.enApplicationType.ReplaceDamagedDrivingLicense : ClsApplication.enApplicationType.ReplaceLostDrivingLicense;
            app.ApplicationStatus = ClsApplication.enApplicationStatus.Completed;
            app.LastStatusDate = DateTime.Now;
            app.PaidFees = Convert.ToSingle(labAppFees.Text.Trim());
            app.CreatedByUserID = ClsGlobal.CurrentUser.UserID;

            if (app.Save())
            {

                
                LocalLicense.ApplicationID = app.ApplicationID;
                LocalLicense.DriverID = ucLicenseInfoWithFilter1.localLicense.DriverID;
                LocalLicense.LicenseClassID = ucLicenseInfoWithFilter1.localLicense.LicenseClassID;
                LocalLicense.ExpirationDate = ucLicenseInfoWithFilter1.localLicense.ExpirationDate;
                LocalLicense.IssueDate = ucLicenseInfoWithFilter1.localLicense.IssueDate;
                LocalLicense.PaidFees = 0;
                LocalLicense.IsActive = true;
                LocalLicense.IssueReason = ClsLocalLicense.enIssueReason.DamagedReplacement;
                LocalLicense.CreatedByUserID = ClsGlobal.CurrentUser.UserID;
                LocalLicense.PersonID = app.ApplicantPersonID;
                if (LocalLicense.Save())
                {
                    labLicenseReplaceApplicationID.Text = app.ApplicationID.ToString();
                    labReplacedLicenseID.Text = LocalLicense.LicenseID.ToString();
                    ucLicenseInfoWithFilter1.localLicense.IsActive = false;
                    ucLicenseInfoWithFilter1.localLicense.Save();
                    btnShowLicenseInfo.Enabled = true;
                    btnReplace.Enabled = false;
                    MessageBox.Show("Done, license was replaced with id = " + LocalLicense.LicenseID, "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    ClsApplication.DeleteApplication(app.ApplicationID);
                    MessageBox.Show("Sorry, Some thing went wrong. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Sorry, Some thing went wrong. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LabReplaceFor_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt16(LabReplaceFor.Tag) == 0)
            {
                LabReplaceFor.Text = "Damaged license";
                LabReplaceFor.Tag = 1;
                labAppFees.Text = ClsApplicationType.Find((int)ClsApplication.enApplicationType.ReplaceDamagedDrivingLicense).Fees.ToString();
            }
            else 
            {
                LabReplaceFor.Text = "Lost License";
                LabReplaceFor.Tag = 0;
                labAppFees.Text = ClsApplicationType.Find((int)ClsApplication.enApplicationType.ReplaceLostDrivingLicense).Fees.ToString();
            }
        }

        private void LabReplaceFor_MouseEnter(object sender, EventArgs e)
        {
            LabReplaceFor.ForeColor = Color.Red;
        }

        private void LabReplaceFor_MouseLeave(object sender, EventArgs e)
        {
            LabReplaceFor.ForeColor = ClsSettings.BlueMainColor;
        }
    }
}
