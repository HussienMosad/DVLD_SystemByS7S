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

namespace DVLD.InternationalLicenses.SecondryForms
{
    public partial class FrmInternationalLicenseInfo : UserControl
    {
        public FrmInternationalLicenseInfo()
        {
            InitializeComponent();
        }

        public ClsInternationalLicense InternationalLicense { get; set; }

        public FrmInternationalLicenseInfo(int InternationalLicenseID)
        {
            InitializeComponent();
            // the better is to use a fast query ...
            InternationalLicense = ClsInternationalLicense.Find(InternationalLicenseID);
            if (InternationalLicense != null)
            {
                ucInternationalLicenseInfo1.UpdateComponents(InternationalLicense);
            }
            else
            {
                MessageBox.Show("Person Does not have international license yet.", "Sorry!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
