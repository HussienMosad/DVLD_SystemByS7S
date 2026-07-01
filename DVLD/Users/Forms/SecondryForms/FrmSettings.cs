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

namespace DVLD.Users.Forms.SecondryForms
{
    public partial class FrmSettings : UserControl
    {

        public delegate void SignOutDelegation();
        public event SignOutDelegation SignOutEvent;

        public FrmSettings()
        {
            InitializeComponent();
            InitializeBtns();

        }

        private void btnShowUserDetails_Click(object sender, EventArgs e)
        {
            FrmHome.AddToMainPanel(new FrmUserDetails(ClsGlobal.CurrentUser.UserID));
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            ClsGlobal.CurrentUser = null;
            SignOutEvent?.Invoke();

        }

        private void TurnOffBtnsLight()
        {
            foreach (Guna2GradientButton b in btnsFrmSettings)
            {
                b.FillColor = ClsSettings.GrayMainColor;
                b.FillColor2 = ClsSettings.GrayMainColor;
            }
        }

        private void btnFocusEffect_Enter(object sender, EventArgs e)
        {
            Guna2GradientButton b = (Guna2GradientButton)sender;
            TurnOffBtnsLight();
            ClsUtil.CheckTheButton(b);
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            FrmHome.AddToMainPanel(new FrmChangeUserPassword(ClsGlobal.CurrentUser.UserID));
        }
    }
}
