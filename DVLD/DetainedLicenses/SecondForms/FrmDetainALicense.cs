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
    public partial class FrmDetainALicense : UserControl
    {
        public delegate void OnCloseEvent();
        public event OnCloseEvent CloseEvent;

        public ClsDetainedLicense DetainedLicense { get; set; }

        public FrmDetainALicense()
        {
            InitializeComponent();
            labCreatedBy.Text = ClsGlobal.CurrentUser.UserName;
            labDetainDate.Text = DateTime.Now.ToShortDateString();
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
            FrmHome.AddToMainPanel(new FrmLicenseInfo(ucLicenseInfoWithFilter1.localLicense));
        }

        private void ucLicenseInfoWithFilter1_OnLicenseSelected()
        {
            labLicenseID.Text = ucLicenseInfoWithFilter1.localLicense.LicenseID.ToString();
            txtFineFees.Text = "";
            txtFineFees.Enabled = true;


            if (ClsDetainedLicense.IsLicenseDetained(ucLicenseInfoWithFilter1.localLicense.LicenseID))
            {
                
                    MessageBox.Show("sorry , this license is detained license", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnShowLicenseInfo.Enabled = true;
                    ClsDetainedLicense detainedLicense = ClsDetainedLicense.Find(ucLicenseInfoWithFilter1.localLicense.LicenseID);
                    if (detainedLicense != null)
                    {
                        labDetainDate.Text = detainedLicense.DetainDate.ToShortDateString();
                        labDetainID.Text = detainedLicense.DetainID.ToString();
                        txtFineFees.Text = detainedLicense.FineFees.ToString();

                        txtFineFees.Enabled = false;


                    }
                
            }
            else if (!ucLicenseInfoWithFilter1.localLicense.IsActive || ucLicenseInfoWithFilter1.localLicense.ExpirationDate < DateTime.Now)
            {
                MessageBox.Show("sorry , this license is not Active", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                btnDetain.Enabled = true;
            }
        }

        private void txtFineFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!ClsValidation.IsNumberOrControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtFineFees.Text) )
            {
                MessageBox.Show("Please Enter The fine fees first");
                return;
            }
            DetainedLicense = new ClsDetainedLicense();
            DetainedLicense.DetainDate = DateTime.Now;
            DetainedLicense.DetainedLicenseID = ucLicenseInfoWithFilter1.localLicense.LicenseID;
            DetainedLicense.FineFees = Convert.ToSingle(txtFineFees.Text);
            DetainedLicense.CreatedByUserID = ClsGlobal.CurrentUser.UserID;
            
            if (DetainedLicense.Save())
            {
                labDetainID.Text = DetainedLicense.DetainID.ToString();

                ucLicenseInfoWithFilter1.localLicense.IsActive = false;
                ucLicenseInfoWithFilter1.localLicense.Save();
                btnShowLicenseInfo.Enabled = true;
                btnDetain.Enabled = false;
                MessageBox.Show("Done, license was Detained successfully.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                
                MessageBox.Show("Sorry, Some thing went wrong. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
