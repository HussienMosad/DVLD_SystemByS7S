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

namespace DVLD.InternationalLicenses.UserControls
{
    public partial class UcInternationalLicenseInfo : UserControl
    {
        public UcInternationalLicenseInfo()
        {
            InitializeComponent();
        }

        public void UpdateComponents(ClsInternationalLicense InternationalLicense)
        {
            labApplicant.Text = InternationalLicense.IssuedUsingLocalLicense.LicenseApplication.GetApplicantFullName();
            labInternationalLicenseID.Text = InternationalLicense.InternationalLicenseID.ToString();
            labAppID.Text = InternationalLicense.ApplicationID.ToString();
            labLicenseID.Text = InternationalLicense.IssuedUsingLocalLicense.LicenseID.ToString();
            labNationalNo.Text = InternationalLicense.IssuedUsingLocalLicense.LicenseApplication.Person.NationalNo;
            labGender.Text = InternationalLicense.IssuedUsingLocalLicense.LicenseApplication.Person.Gender;
            labIssueDate.Text = InternationalLicense.IssuedUsingLocalLicense.IssueDate.ToString();
            labIsActive.Text = (InternationalLicense.IssuedUsingLocalLicense.IsActive) ? "Yes" : "No";
            labDriverID.Text = InternationalLicense.IssuedUsingLocalLicense.DriverID.ToString();
            labExpirationDate.Text = InternationalLicense.ExpirationDate.ToString();
            labDateOfBirth.Text = (InternationalLicense.IssuedUsingLocalLicense.LicenseApplication.Person.DateOfBirth).ToShortDateString();

            if (InternationalLicense.IssuedUsingLocalLicense.LicenseApplication.Person.ImagePath == "")
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
                    picProfile.Image = Image.FromFile(InternationalLicense.IssuedUsingLocalLicense.LicenseApplication.Person.ImagePath);
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
