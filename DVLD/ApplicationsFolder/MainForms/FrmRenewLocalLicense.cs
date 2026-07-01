using DVLD.Licenses.MainForms;
using DVLD.Licenses.SecondryForms;
using DVLD.More;
using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.ApplicationsFolder.MainForms
{
    public partial class FrmRenewLocalLicense : UserControl
    {
        public delegate void OnCloseEvent();
        public event OnCloseEvent CloseEvent;

        public ClsLocalLicense LocalLicense { get; set; }

        public FrmRenewLocalLicense()
        {
            InitializeComponent();
            LocalLicense = new ClsLocalLicense();
            labAppDate.Text = DateTime.Now.ToShortDateString();
            labIssueDate.Text = DateTime.Now.ToShortDateString();
            labCreatedBy.Text = ClsGlobal.CurrentUser.UserName;
            labAppFees.Text = ClsApplicationType.Find((int)ClsApplication.enApplicationType.RenewDrivingLicense).Fees.ToString();
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

        private void ucLicenseInfoWithFilter1_OnLicenseSelected()
        {
            labOldLicenseID.Text = ucLicenseInfoWithFilter1.localLicense.LicenseID.ToString();
            labExpirationDate.Text = DateTime.Now.AddYears(ucLicenseInfoWithFilter1.localLicense.LicenseClass.DefaultValidityLength).ToShortDateString() ;
            
            
            labLicenseFees.Text = ClsLicenseClass.Find(ucLicenseInfoWithFilter1.localLicense.LicenseClassID).ClassFees.ToString();
            labTotalFees.Text = (Convert.ToSingle(labLicenseFees.Text) + Convert.ToSingle(labAppFees.Text)).ToString();
            
            if(ucLicenseInfoWithFilter1.localLicense.ExpirationDate>DateTime.Now && ucLicenseInfoWithFilter1.localLicense.IsActive == true)
            {
                MessageBox.Show("Sorry , this license is Active and it has a valid exp date ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnShowLicenseInfo.Enabled = true;
            }

            else if(ClsDetainedLicense.IsLicenseDetained(ucLicenseInfoWithFilter1.localLicense.LicenseID))
            {
                MessageBox.Show("Sorry , this license is Detained , release it first ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnShowLicenseInfo.Enabled = true;
            }
            else
            {
                btnRenew.Enabled = true;
            }
        }

        private void btnShowLicenseInfo_Click(object sender, EventArgs e)
        {
            if (labRenewedLicenseID.Text.Trim() == "?".Trim())
            {
                FrmHome.AddToMainPanel(new FrmLicenseInfo(ucLicenseInfoWithFilter1.localLicense));
            }
            else
            {
                FrmHome.AddToMainPanel(new FrmLicenseInfo(LocalLicense.LicenseID));
            }
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            
            ClsApplication app = new ClsApplication();
            app.ApplicantPersonID = ucLicenseInfoWithFilter1.localLicense.Driver.PersonID;
            app.ApplicationDate = DateTime.Now;
            app.ApplicationTypeID = ClsApplication.enApplicationType.RenewDrivingLicense;
            app.ApplicationStatus = ClsApplication.enApplicationStatus.Completed;
            app.LastStatusDate = DateTime.Now;
            app.PaidFees = Convert.ToSingle(labAppFees.Text.Trim());
            app.CreatedByUserID = ClsGlobal.CurrentUser.UserID; 

            if(app.Save())
            {
                
                LocalLicense.Notes = txtNotes.Text;
                LocalLicense.ApplicationID = app.ApplicationID;
                LocalLicense.DriverID = ucLicenseInfoWithFilter1.localLicense.DriverID;
                LocalLicense.LicenseClassID = ucLicenseInfoWithFilter1.localLicense.LicenseClassID;
                LocalLicense.ExpirationDate = Convert.ToDateTime(labExpirationDate.Text.Trim());
                LocalLicense.IssueDate = Convert.ToDateTime(labIssueDate.Text.Trim());
                LocalLicense.PaidFees = Convert.ToSingle(labLicenseFees.Text.Trim());
                LocalLicense.IsActive = true;
                LocalLicense.IssueReason = ClsLocalLicense.enIssueReason.Renew;
                LocalLicense.CreatedByUserID = ClsGlobal.CurrentUser.UserID;
                LocalLicense.PersonID = app.ApplicantPersonID;
                if (LocalLicense.Save())
                {
                    labRenewLicenseApplicationID.Text = app.ApplicationID.ToString();
                    labRenewedLicenseID.Text = LocalLicense.LicenseID.ToString();
                    ucLicenseInfoWithFilter1.localLicense.IsActive = false;
                    ucLicenseInfoWithFilter1.localLicense.Save();
                    btnShowLicenseInfo.Enabled = true;
                    btnRenew.Enabled = false;
                    MessageBox.Show("Done, license was renewed with id = " + LocalLicense.LicenseID, "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void lblTotalFees_Click(object sender, EventArgs e)
        {

        }

        private void picTotalFees_Click(object sender, EventArgs e)
        {

        }

        private void picAppFees_Click(object sender, EventArgs e)
        {

        }

        private void lblAppFees_Click(object sender, EventArgs e)
        {

        }

        private void labTotalFees_Click(object sender, EventArgs e)
        {

        }

        private void labAppFees_Click(object sender, EventArgs e)
        {

        }

        private void labLicenseFees_Click(object sender, EventArgs e)
        {

        }

        private void lblLicenseFees_Click(object sender, EventArgs e)
        {

        }

        private void picLicenseFees_Click(object sender, EventArgs e)
        {

        }

        private void picOldLicenseID_Click(object sender, EventArgs e)
        {

        }

        private void picRenewLicenseID_Click(object sender, EventArgs e)
        {

        }

        private void lblOldLicenseID_Click(object sender, EventArgs e)
        {

        }

        private void lblRenewedLicenseID_Click(object sender, EventArgs e)
        {

        }

        private void labOldLicenseID_Click(object sender, EventArgs e)
        {

        }

        private void labRenewedLicenseID_Click(object sender, EventArgs e)
        {

        }

        private void lblRenewLicenseApplicationID_Click(object sender, EventArgs e)
        {

        }

        private void labRenewLicenseApplicationID_Click(object sender, EventArgs e)
        {

        }

        private void lblAppDate_Click(object sender, EventArgs e)
        {

        }

        private void lblIssueDate_Click(object sender, EventArgs e)
        {

        }

        private void labIssueDate_Click(object sender, EventArgs e)
        {

        }

        private void labExpirationDate_Click(object sender, EventArgs e)
        {

        }

        private void lblExpirationDate_Click(object sender, EventArgs e)
        {

        }

        private void lblCreatedBy_Click(object sender, EventArgs e)
        {

        }

        private void labCreatedBy_Click(object sender, EventArgs e)
        {

        }

        private void picCreatedBy_Click(object sender, EventArgs e)
        {

        }

        private void picExpirationDate_Click(object sender, EventArgs e)
        {

        }

        private void picIssueDate_Click(object sender, EventArgs e)
        {

        }

        private void picAppDate_Click(object sender, EventArgs e)
        {

        }

        private void picRenewLicenseApplicationID_Click(object sender, EventArgs e)
        {

        }

        private void labAppDate_Click(object sender, EventArgs e)
        {

        }
    }
}
