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

namespace DVLD.Licenses.SecondryForms
{
    public partial class FrmLicenseInfo : UserControl
    {
        public ClsLocalLicense License { get; set; }
        public FrmLicenseInfo()
        {
            InitializeComponent();
        }
        public FrmLicenseInfo(int LocalDrivingLicenseApplication)
        {
            InitializeComponent();
            // the better is to use a fast query ...
            License = ClsLocalLicense.FindByApplicationID(ClsLocalDrivingLicenseApplication.Find(LocalDrivingLicenseApplication).ApplicationID);
            if (License != null)
            {
                ucLicenseInfo1.UpdateComponents(License);
            }
            else
            {
                MessageBox.Show("Person Does not have license yet.", "Sorry!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        public FrmLicenseInfo(ClsLocalLicense License)
        {
            InitializeComponent();
            if (License != null)
            {
                ucLicenseInfo1.UpdateComponents(License);
            }
            else
            {
                MessageBox.Show("Person Does not have license yet.", "Sorry!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnSwitchFillColor(object sender, EventArgs e)
        {
            ClsUtil.btnSwitchFillColor(sender, e);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmHome.RemoveFromMainPanel();
            
        }
    }
}
