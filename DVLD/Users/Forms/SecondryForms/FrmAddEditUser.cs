using DVLD.More;
using DVLD.Properties;
using DVLD.Users.Forms.MainForm;
using DVLD_BusinessLayer;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DVLD.Users.Forms.SecondryForms
{
    public partial class FrmAddEditUser : UserControl
    {
        public delegate void OnCloseEvent();
        public event OnCloseEvent CloseEvent;

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode;

        private ClsUser User { get; set; }

        public FrmAddEditUser( int UserID)
        {
            InitializeComponent();
            ucPersonDetailsWithFilter.EditFormatForUserAddWithFilter();
            if (UserID != -1)
            {
                User = ClsUser.Find(UserID);
                TurnItToFrmEditUser();
                ucPersonDetailsWithFilter.UpdateComponent(User.Person);
                labUserID.Text = UserID.ToString();
                txtNewUserName.Text = User.UserName.Trim();
                if (User.IsActive)
                {
                    btnIsActive.Text = "YES";
                }
                else
                { 
                    btnIsActive.Text = "NO";
                }
                Mode = enMode.Update;
            }
            else
            {
                User = new ClsUser();
                Mode = enMode.AddNew;
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsUtil.txtPassword_KeyPress(this , sender, e);
        }

        private void txtNewUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*if (!ClsValidation.IsLetterOrControlOrNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            if (ClsValidation.IsNumber(e.KeyChar) && txtNewUserName.Text.Length == 0)
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // for windows sound
                this.SelectNextControl((Control)sender, true, true, true, true);
            }*/
            ClsUtil.txtNewUserName_KeyPress((ContainerControl)this , sender, e);
        }

        private void btnIsActive_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // for windows sound
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void btnIsActive_Click(object sender, EventArgs e)
        {
            Guna2GradientButton b = ((Guna2GradientButton)sender);

            if (b.Text.ToUpper() == "NO".ToUpper())
            {
                b.Text = "Yes".ToUpper();
            }
            else
            {
                b.Text = "NO".ToUpper();
            }
        }

        private void btnSwitchFillColor(object sender, EventArgs e)
        {
            ClsUtil.btnSwitchFillColor(sender, e);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmHome.RemoveFromMainPanel();
            CloseEvent?.Invoke();
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            ClsUtil.ttMessageForTxtPassword(sender, e);
        }
        private void ttMessageCantBeEmpty(object sender, CancelEventArgs e)
        {
            ClsUtil.ttMessageCantBeEmpty(sender, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string UserName = txtNewUserName.Text.Trim();
            string Password = txtPassword.Text.Trim();
            string ConfirmedPassword = txtConfirmPassword.Text.Trim();

            if (UserName.Length == 0 || Password.Length == 0 || ConfirmedPassword.Length == 0)
            {
                MessageBox.Show("Sorry , Please Enter User Details. ", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(ucPersonDetailsWithFilter.Person.ID == -1)
            {
                MessageBox.Show("Sorry , Please Search for a valid person. ", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ConfirmedPassword != Password)
            {
                MessageBox.Show("Sorry , Please check the confirm password. ", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Mode == enMode.AddNew)
            { 

                if (ClsUser.IsUserExist(UserName))
                {
                    MessageBox.Show("Sorry , The User is already exits. ", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (ClsUser.IsUserExistByPersonID(ucPersonDetailsWithFilter.Person.ID))
                {
                    MessageBox.Show("Sorry , The Person Has a user Account . ", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (Save())
                    {
                        TurnItToFrmEditUser();
                    }
                }
            }
            else if (Mode == enMode.Update) 
            {
                Save();
            }
            
        }

        public void UpdateUcPersonDetailsWithFilter(ClsPerson Person)
        {
            if (Person.ID != -1)
            {
                ucPersonDetailsWithFilter.UpdateComponent(Person);
            }
        }

        private void TurnItToFrmEditUser()
        {
            Mode = enMode.Update;
            lblHeaderTitle.Text = "Edit User";
            picHeader.Image = Resources.edit_user;
            ucPersonDetailsWithFilter.UnEnable();
            lblNewUserName.Text = "User Name               :";
        }

        private bool Save()
        {
            User.UserName = txtNewUserName.Text.Trim();
            User.IsActive = (btnIsActive.Text.ToLower().Trim() == "yes".ToLower().Trim());
            User.Password = clsSecurity.CreateNewHashPassword(txtPassword.Text.Trim());
            User.PersonID = ucPersonDetailsWithFilter.Person.ID;
            if(User.Save())
            {
                MessageBox.Show("Data Saved Successfully.");
                lblUserID.Text = User.UserID.ToString();
                return true;
            }
            else
            {
                MessageBox.Show("Sorry , this User Name is exists or something gone wrong." , "Error!",MessageBoxButtons.OK , MessageBoxIcon.Error);
                return false;
            }
        }

        private void btnEditPerson_Click(object sender, EventArgs e)
        {
            
            if (ucPersonDetailsWithFilter.Person != null)
            {
                FrmAddEditPersonInfo f = new FrmAddEditPersonInfo(ucPersonDetailsWithFilter.Person.ID);
                f.CloseEvent2 += ucPersonDetailsWithFilter.UpdateComponent;
                FrmHome.AddToMainPanel(f);
            }
            else
            {
                MessageBox.Show("Sorry , Chose A person First.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
