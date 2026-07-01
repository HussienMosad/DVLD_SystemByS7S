using DVLD.ApplicationsFolder.MainForms;
using DVLD.ApplicationTypes;
using DVLD.DetainedLicenses.SecondForms;
using DVLD.More;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.ApplicationsFolder.SecondryForms
{
    public partial class FrmDrivingLicensesServicesBtnsScreen : UserControl
    {
        
        public FrmDrivingLicensesServicesBtnsScreen()
        {
            InitializeComponent();
            InitializeBtns();
            
        }

        private void TurnOffBtnsLight()
        {
            foreach (Guna2GradientButton b in btnsFrmDrivingLicensesServicesScreen)
            {
                b.FillColor = ClsSettings.GrayMainColor;
                b.FillColor2 = ClsSettings.GrayMainColor;
            }
        }

        private void InitializeBtns()
        {
            btnsFrmDrivingLicensesServicesScreen[0] = btnNewDrivingLicense;
            btnsFrmDrivingLicensesServicesScreen[1] = btnRenewDrivingLicense;
            btnsFrmDrivingLicensesServicesScreen[2] = btnReplacementForLostOrDamagedLicense;
            btnsFrmDrivingLicensesServicesScreen[3] = btnReleaseDetainedDrivingLicense;
            btnsFrmDrivingLicensesServicesScreen[4] = btnRetakeTest;

        }

        private void btnNewDrivingLicense_Click(object sender, EventArgs e)
        {
            Rectangle rect = btnNewDrivingLicense.Bounds;
            ctmsForBtnNewDrivingLicense.Show(btnNewDrivingLicense, 400, 0);


        }

        private void btnFocusEffect_Enter(object sender, EventArgs e)
        {
            Guna2GradientButton b = (Guna2GradientButton)sender;
            TurnOffBtnsLight();
            ClsUtil.CheckTheButton(b);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmHome.MainPanel.Controls.Remove(this);
            FrmHome.MainPanel.Controls[FrmHome.MainPanel.Controls.Count - 1].Visible = true;
            FrmHome.MainPanel.Controls[FrmHome.MainPanel.Controls.Count - 1].Focus();
        }

        private void btnSwitchFillColor(object sender, EventArgs e)
        {
            ClsUtil.btnSwitchFillColor(sender, e);
        }

        private void LocalDrivingLicenseApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHome.AddToMainPanel(new FrmNewLocalDrivingLicenseApplication(-1));
        }

        private void internationalLicenseApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHome.AddToMainPanel(new FrmNewInternationalLicenseApplication());
        }

        private void btnRetakeTest_Click(object sender, EventArgs e)
        {
            FrmHome.AddToMainPanel(new FrmLocalDrivingLicenseApplicationInfo());
        }

        private void btnRenewDrivingLicense_Click(object sender, EventArgs e)
        {
            FrmHome.AddToMainPanel(new FrmRenewLocalLicense());
        }

        private void btnReplacementForLostOrDamagedLicense_Click(object sender, EventArgs e)
        {
            FrmHome.AddToMainPanel(new FrmReplacementForLostOrDamagedLicense());
        }

        private void btnReleaseDetainedDrivingLicense_Click(object sender, EventArgs e)
        {
            FrmHome.AddToMainPanel(new FrmReleaseALicense(-1));
        }
    }
}
