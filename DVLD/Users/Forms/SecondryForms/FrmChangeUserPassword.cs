using DVLD.More;
using DVLD_BusinessLayer;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DVLD.Users.Forms.SecondryForms
{
    public partial class FrmChangeUserPassword : UserControl
    {

        public delegate void OnCloseEvent();
        public event OnCloseEvent CloseEvent;

        private ClsUser User { get; set; }

        public FrmChangeUserPassword(int UserID)
        {
            InitializeComponent();
            ucUserDetails.EditFormatForUserChangePassword();
            User = ClsUser.Find(UserID);
            if (User != null)
            {
                UpdateComponent(User);
            }
            else
            {
                MessageBox.Show("sorry , User Not Found.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void UpdateComponent(ClsUser User)
        {
            ucUserDetails.UpdateComponent(User);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmHome.RemoveFromMainPanel();
            CloseEvent?.Invoke();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            ClsUtil.txtPassword_KeyPress(this,sender,e);
        }

        public void UpdateJustPersonComponent(ClsPerson Person)
        {
            ucUserDetails.UpdateJustPersonComponent(Person);
        }

        private void btnEditPerson_Click(object sender, EventArgs e)
        {
            FrmAddEditPersonInfo f = new FrmAddEditPersonInfo(User.PersonID);
            f.CloseEvent2 += UpdateJustPersonComponent;
            FrmHome.AddToMainPanel(f);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string UserName = User.UserName.Trim();
            string Password = txtCurrentPassword.Text.Trim();
            string NewPassword = txtNewPassword.Text.Trim();
            if (NewPassword != txtConfirmPassword.Text.Trim())
            {
                MessageBox.Show("Sorry , Please check the confirm password ", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ClsUser.IsUserExist(UserName))
            {
                string HashedPassword = ClsUser.GetHashedPassword(UserName);
                if (clsSecurity.IsTruePassword(Password, HashedPassword))
                {
                    if(!User.ChangePassword(clsSecurity.CreateNewHashPassword(NewPassword)))
                    {
                        MessageBox.Show("Sorry , Password didn't change .", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Password changed Successfully .", "Nice !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Sorry , Wrong password ", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Sorry , User is not found.", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSwitchFillColor(object sender, EventArgs e)
        {
            ClsUtil.btnSwitchFillColor(sender, e);
        }

        private void txtCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            ClsUtil.ttMessageForTxtPassword(sender, e);
        }
    }
}
