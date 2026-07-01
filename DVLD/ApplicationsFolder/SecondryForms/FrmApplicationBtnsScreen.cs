using DVLD.ApplicationsFolder.MainForms;
using DVLD.ApplicationsFolder.SecondryForms;
using DVLD.ApplicationTypes;
using DVLD.DetainedLicenses.MainForm;
using DVLD.DetainedLicenses.SecondForms;
using DVLD.InternationalLicenses;
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

namespace DVLD
{
    public partial class FrmApplicationBtnsScreen : UserControl
    {


        public FrmApplicationBtnsScreen()
        {
            InitializeComponent();
            InitializeBtns();
            
        }

        private void btnFocusEffect_Enter(object sender, EventArgs e)
        {
            Guna2GradientButton b = (Guna2GradientButton)sender;
            TurnOffBtnsLight();
            ClsUtil.CheckTheButton(b);
        }

        private void TurnOffBtnsLight()
        {
            foreach (Guna2GradientButton b in btnApplicationScreen)
            {
                b.FillColor = ClsSettings.GrayMainColor;
                b.FillColor2 = ClsSettings.GrayMainColor;
            }
        }

        private void InitializeBtns()
        {
            btnApplicationScreen[0] = btnDrivingLicencesServices;
            btnApplicationScreen[1] = btnManageApplications;
            btnApplicationScreen[2] = btnDetainLicences;
            btnApplicationScreen[3] = btnManageApplicationTypes;
            btnApplicationScreen[4] = btnManageTestTypes;

        }

        private void btnManageApplicationTypes_Click(object sender, EventArgs e)
        {
            FrmHome.AddToMainPanel(new FrmApplicationTypes());
        }

        private void btnManageTestTypes_Click(object sender, EventArgs e)
        {
            FrmHome.AddToMainPanel(new FrmTestTypes());
        }

        private void btnManageApplications_Click(object sender, EventArgs e)
        {
            
                
                ctmsForBtnManageApplication.Show(btnManageApplications, 400,0);
            

        }

        private void btnDrivingLicensesServices_Click(object sender, EventArgs e)
        {
            FrmHome.AddToMainPanel(new FrmDrivingLicensesServicesBtnsScreen());
        }

        public void LocalDrivingLicenseApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHome.AddToMainPanel(new FrmLocalDrivingLicenseApplications());
        }

        private void interationalLicenseApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHome.AddToMainPanel(new FrmInternationalLicenses());
        }

        private void btnDetainLicences_Click(object sender, EventArgs e)
        {
            ctmsForBtnDetainLicenses.Show(btnManageApplications, 400, 0);
        }

        private void ListDetainedtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHome.AddToMainPanel(new FrmDetainedLicenses());
        }

        private void ReleasetoolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHome.AddToMainPanel(new FrmReleaseALicense(-1));
        }

        private void DetaintoolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHome.AddToMainPanel(new FrmDetainALicense());
        }
    }
}
