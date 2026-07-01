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

namespace DVLD.DetainedLicenses.SecondForms
{
    public partial class FrmReleaseALicense : UserControl
    {
        public ClsLocalLicense LocalLicense { get; set; }
        public ClsDetainedLicense DetainedLicense { get; set; }
        public delegate void OnCloseEvent();
        public event OnCloseEvent CloseEvent;

        public enum enMode { }

        public FrmReleaseALicense(int DetainedLicenseID)
        {
            InitializeComponent();
            if (DetainedLicenseID != -1)
            {

                DetainedLicense = ClsDetainedLicense.Find(DetainedLicenseID);
                ucLicenseInfoWithFilter1.Search(DetainedLicense.DetainedLicenseID);
                ucLicenseInfoWithFilter1.UnEnable();
            }
            {
                LocalLicense = new ClsLocalLicense();
            }
            labCreatedBy.Text = ClsGlobal.CurrentUser.UserName;
            labAppFees.Text = ClsApplicationType.Find((int)ClsApplication.enApplicationType.ReleaseDetainedDrivingLicense).Fees.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmHome.RemoveFromMainPanel();
            CloseEvent?.Invoke();
        }
        private void btnSwitchFillColor(object sender, EventArgs e)
        {
            ClsUtil.btnSwitchFillColor(sender, e);
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
                FrmHome.AddToMainPanel(new FrmLicenseInfo(ucLicenseInfoWithFilter1.localLicense));
        }

        private void ucLicenseInfoWithFilter1_OnLicenseSelected()
        {
            labLicenseID.Text = ucLicenseInfoWithFilter1.localLicense.LicenseID.ToString();


            
            if (!ClsDetainedLicense.IsLicenseDetained(ucLicenseInfoWithFilter1.localLicense.LicenseID))
            {
                    
                    MessageBox.Show("sorry , that is not detained license", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnShowLicenseInfo.Enabled = true;
                }
                else
                {
                    ClsDetainedLicense detainedLicense = ClsDetainedLicense.Find(ucLicenseInfoWithFilter1.localLicense.LicenseID);
                    if (detainedLicense != null)
                    {
                        labDetainDate.Text = detainedLicense.DetainDate.ToShortDateString();
                        labDetainID.Text = detainedLicense.DetainID.ToString();
                        labFineFees.Text = detainedLicense.FineFees.ToString();
                        labTotalFees.Text = (detainedLicense.FineFees + Convert.ToSingle(labAppFees.Text)).ToString();
                        
                    }
                    btnRelease.Enabled = true;
                }
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            ClsApplication app = new ClsApplication();
            app.ApplicantPersonID = ucLicenseInfoWithFilter1.localLicense.Driver.PersonID;
            app.ApplicationDate = DateTime.Now;
            app.ApplicationTypeID = ClsApplication.enApplicationType.ReleaseDetainedDrivingLicense;
            app.ApplicationStatus = ClsApplication.enApplicationStatus.Completed;
            app.LastStatusDate = DateTime.Now;
            app.PaidFees = Convert.ToSingle(labAppFees.Text.Trim());
            app.CreatedByUserID = ClsGlobal.CurrentUser.UserID;

            if (app.Save())
            {

                DetainedLicense.IsReleased = true;
                DetainedLicense.ReleaseDate = DateTime.Now;
                DetainedLicense.ReleasedByUserID = ClsGlobal.CurrentUser.UserID;
                DetainedLicense.ReleaseApplicationID = app.ApplicationID;
                DetainedLicense.Mode = ClsDetainedLicense.enMode.Update;
                if (DetainedLicense.Save())
                {
                    labDetainApplicationID.Text = app.ApplicationID.ToString();
                    
                    ucLicenseInfoWithFilter1.localLicense.IsActive = true;
                    ucLicenseInfoWithFilter1.localLicense.Save();
                    btnShowLicenseInfo.Enabled = true;
                    btnRelease.Enabled = false;
                    MessageBox.Show("Done, license was Released successfully.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
