using DVLD.Properties;
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

namespace DVLD.Licenses.SecondryForms
{
    public partial class UcLicenseInfo : UserControl
    {
        public UcLicenseInfo()
        {
            InitializeComponent();
        }

        public void UpdateComponents(ClsLocalLicense license)
        {
            labClass.Text = license.LicenseClass.ClassName;
            labApplicant.Text = license.LicenseApplication.GetApplicantFullName();
            labLicenseID.Text = license.LicenseID.ToString();
            labNationalNo.Text = license.LicenseApplication.Person.NationalNo;
            labGender.Text = license.LicenseApplication.Person.Gender;
            labIssueDate.Text = license.IssueDate.ToString();
            labIssueReason.Text = (license.IssueReason == ClsLocalLicense.enIssueReason.FirstTime) ? "First Time" : (license.IssueReason == ClsLocalLicense.enIssueReason.Renew) ? "Renew" : (license.IssueReason == ClsLocalLicense.enIssueReason.DamagedReplacement) ? "Damaged Replacement" : (license.IssueReason == ClsLocalLicense.enIssueReason.LostReplacement) ? "Lost Replacement" :"" ;
            labNotes.Text = license.Notes;
            labIsActive.Text = (license.IsActive) ? "Yes" : "No";
            labDriverID.Text = license.DriverID.ToString();
            labIsDetained.Text = (ClsDetainedLicense.IsLicenseDetained(license.LicenseID)) ? "Yes" : "No";
            labExpirationDate.Text = license.ExpirationDate.ToString();
            labDateOfBirth.Text = (license.LicenseApplication.Person.DateOfBirth).ToShortDateString();

            if (license.LicenseApplication.Person.ImagePath == "")
            {
                if (labGender.Text == "MALE")
                {
                    picProfile.Image = Resources.DefaultMan;
                }
                else
                {
                    picProfile.Image = Resources.DefaultWoman;
                }
            }
            else
            {
                try
                {
                    picProfile.Image = Image.FromFile(license.LicenseApplication.Person.ImagePath);
                }
                catch
                {
                    if (labGender.Text == "MALE")
                    {
                        picProfile.Image = Resources.DefaultMan;
                    }
                    else
                    {
                        picProfile.Image = Resources.DefaultWoman;
                    }
                }
            }

        }
    }
}
