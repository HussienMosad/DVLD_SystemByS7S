using DVLD.InternationalLicenses.SecondryForms;
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
    public partial class FrmNewInternationalLicenseApplication : UserControl
    {
        public delegate void OnCloseEvent();
        public event OnCloseEvent CloseEvent;

        public ClsInternationalLicense internationalLicense {  get; set; }

        public FrmNewInternationalLicenseApplication()
        {
            InitializeComponent();
            labAppDate.Text = DateTime.Now.ToShortDateString();
            labIssueDate.Text = DateTime.Now.ToShortDateString();
            labExpirationDate.Text = (DateTime.Now.AddYears(1)).ToShortDateString();
            labCreatedBy.Text = ClsGlobal.CurrentUser.UserName;
            labFees.Text = ClsApplicationType.Find((int)ClsApplication.enApplicationType.NewInternationalLicense).Fees.ToString();
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
                MessageBox.Show("Please chose a license First." ,"Error!" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShowInternationalLicenseInfo_Click(object sender, EventArgs e)
        {
            FrmInternationalLicenseInfo f = new FrmInternationalLicenseInfo(internationalLicense.InternationalLicenseID);
            FrmHome.AddToMainPanel(f);
        }

        private void ucLicenseInfoWithFilter1_OnLicenseSelected()
        {
            labLicenseID.Text = ucLicenseInfoWithFilter1.localLicense.LicenseID.ToString();
            if (ucLicenseInfoWithFilter1.localLicense.LicenseClassID != 3)
            {
                MessageBox.Show("Sorry , license class not valid ,please get normal license to issue international one ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ucLicenseInfoWithFilter1.localLicense.ExpirationDate < DateTime.Now || ucLicenseInfoWithFilter1.localLicense.IsActive == false)
            {
                MessageBox.Show("Sorry , this license is not Active", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
                                
            //else if(اذا كانت محجوزة)
            //{
            //
            //}
            internationalLicense = ClsInternationalLicense.FindByLocalLicenseID(ucLicenseInfoWithFilter1.localLicense.LicenseID);
            if (internationalLicense != null && internationalLicense.IsActive == true)
            {
                MessageBox.Show("Sorry , this license is have an Active international license with id = " + internationalLicense.InternationalLicenseID, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnInternationalShowLicenseInfo.Enabled = true;
            }
            else
            {
                btnIssue.Enabled = true;
            }
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            ClsApplication App = new ClsApplication();
            App.ApplicantPersonID = ucLicenseInfoWithFilter1.localLicense.Driver.PersonID;
            App.ApplicationDate = DateTime.Now;
            App.ApplicationStatus = ClsApplication.enApplicationStatus.New;
            App.ApplicationTypeID = ClsApplication.enApplicationType.NewInternationalLicense;
            App.LastStatusDate = DateTime.Now;
            App.PaidFees = Convert.ToSingle(labFees.Text);
            App.CreatedByUserID = ClsGlobal.CurrentUser.UserID;

            if (App.Save())
            {
                internationalLicense = new ClsInternationalLicense();
                internationalLicense.DriverID = ucLicenseInfoWithFilter1.localLicense.DriverID;
                internationalLicense.IssuedUsingLocalLicenseID = ucLicenseInfoWithFilter1.localLicense.LicenseID;
                internationalLicense.IssueDate = DateTime.Now;
                internationalLicense.ExpirationDate = DateTime.Now.AddYears(ClsSettings.ValidityLengthForInternationalLicense);
                internationalLicense.IsActive = true;
                internationalLicense.CreatedByUserID = ClsGlobal.CurrentUser.UserID;
                internationalLicense.ApplicationID = App.ApplicationID;

                if (internationalLicense.Save())
                {
                    labInternationalLicenseApplicationID.Text = App.ApplicationID.ToString();
                    labInternationalLicenseID.Text = internationalLicense.InternationalLicenseID.ToString();
                    MessageBox.Show("International license has issued with id = " + internationalLicense.InternationalLicenseID, "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnIssue.Enabled = false;
                    btnInternationalShowLicenseInfo.Enabled = true;
                }
                else
                {
                    ClsApplication.DeleteApplication(App.ApplicationID);
                    MessageBox.Show("Sorry Something Went Wrong", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Sorry Something Went Wrong", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
