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

namespace DVLD.Licenses.UserControls
{
    public partial class UcLicenseInfoWithFilter : UserControl
    {
        public event Action OnLicenseSelected;
        public UcLicenseInfoWithFilter()
        {
            InitializeComponent();
        }

        public ClsLocalLicense localLicense { get; set; }

        public void UpdateComponent(ClsLocalLicense LocalLicense)
        {
            this.localLicense = localLicense;
            ucLicenseInfo1.UpdateComponents(LocalLicense);
        }

        public void Search(int LicenseID)
        {
            txtFilterBy.Text = LicenseID.ToString().Trim();
            btnFindLicense_Click(null , null);
        }

        private void txtFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!ClsValidation.IsNumberOrControl(e.KeyChar)) e.Handled = true;
            else if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // for windows sound
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void btnFindLicense_Click(object sender, EventArgs e)
        {
            if (txtFilterBy.Text.Length == 0) return;
            
            localLicense = ClsLocalLicense.Find(Convert.ToInt16(txtFilterBy.Text));
            if (localLicense != null)
            {
                UpdateComponent(localLicense);
                OnLicenseSelected();
            }
            else
            {
                MessageBox.Show("Can not find License with ID = " + txtFilterBy.Text);
            }
        }

        private void btnSwitchFillColor(object sender, EventArgs e)
        {
            ClsUtil.btnSwitchFillColor(sender, e);
        }

        public void UnEnable()
        {
            txtFilterBy.Enabled = false;
            btnFindLicense.Enabled = false;
        }

    }
}
