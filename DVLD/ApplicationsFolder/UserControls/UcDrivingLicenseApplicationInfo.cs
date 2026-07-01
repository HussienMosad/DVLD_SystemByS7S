using DVLD.Licenses.MainForms;
using DVLD.Licenses.SecondryForms;
using DVLD.More;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.ApplicationsFolder.UserControls
{
    public partial class UcDrivingLicenseApplicationInfo : UserControl
    {
        public UcDrivingLicenseApplicationInfo()
        {
            InitializeComponent();
        }

        public void UpdateComponents(int LDLAID , int PassedTests , string LicenseClassName)
        {
            labLDLAID.Text = LDLAID.ToString();
            labPassedTests.Text = PassedTests.ToString()+"/3";
            labLicenseClass.Text = LicenseClassName;
        }

        private void btnSwitchFillColor(object sender, EventArgs e)
        {
            ClsUtil.btnSwitchFillColor(sender, e);
        }

        private void btnShowLicense_Click(object sender, EventArgs e)
        {   
                FrmLicenseInfo f = new FrmLicenseInfo(Convert.ToInt16(labLDLAID.Text.Trim()));
                FrmHome.AddToMainPanel(f);
            
        }
    }
}
