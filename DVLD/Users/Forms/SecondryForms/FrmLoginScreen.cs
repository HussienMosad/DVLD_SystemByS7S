using DVLD.More;
using DVLD.Properties;
using DVLD_BusinessLayer;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DVLD.Users.Forms.SecondryForms
{
    public partial class FrmLoginScreen : Form
    {
        private string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "RememberMe.txt");
        private string RegistryPath = @"HKEY_CURRENT_USER\SOFTWARE\zDVLD";
        public static bool CloseApp = false;
        private int ProjectNameCharTimerCounter = 0;

        private Label[] lblsPojectName = new Label[9];

        

        public FrmLoginScreen()
        {
            InitializeComponent();
            lblsPojectName = new Label[]{ l1,l2,l3,l4,l5,l6,l7,l8,l9 };
            timerProjectName.Start();
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            CloseApp = true;
            this.Close();
        }

        private void rbtnRememberMe_Click(object sender, EventArgs e)
        {
            if (rbtnRememberMe.Checked)
            {
                rbtnRememberMe.Checked = false;
            }
            else rbtnRememberMe.Checked = true;
        }

        private void txttName_Enter(object sender, EventArgs e)
        {
            lblUserName.ForeColor = lblBy.ForeColor;
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            lblUserName.ForeColor = Color.White;
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            lblPassword.ForeColor = lblBy.ForeColor;
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (ActiveControl != btnViewHide)
            {
                lblPassword.ForeColor = Color.White;
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            ClsUtil.txtNewUserName_KeyPress((ContainerControl)this,sender,e);
        }

        private void timerProjectName_Tick(object sender, EventArgs e)
        {
            lblsPojectName[ProjectNameCharTimerCounter].ForeColor = lblBy.ForeColor;
            if (ProjectNameCharTimerCounter == 8) ProjectNameCharTimerCounter = 0;
            else ProjectNameCharTimerCounter++;
            lblsPojectName[ProjectNameCharTimerCounter].ForeColor = Color.White;

        }

        private void btnViewHide_Click(object sender, EventArgs e)
        {
            btnViewHide_KeyDown(sender, new KeyEventArgs(Keys.Enter));

            if (txtPassword.PasswordChar.Equals('*'))
            {
                txtPassword.PasswordChar = '\0';
                btnViewHide.Image = Resources.view;
            }
            else
            {
                txtPassword.PasswordChar = '*';
                btnViewHide.Image = Resources.hide;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            string UserName = txtName.Text.Trim();
            string Password = txtPassword.Text.Trim();

            if (ClsUser.IsUserExist(UserName))
            {
                if (ClsUser.IsUserActive(UserName))
                {
                    ClsUser user = ClsUser.Find(UserName);
                    string HashedPassword = user.Password;
                    if (clsSecurity.IsTruePassword(Password, HashedPassword))
                    {
                        Logger.LogInfo($"User '{UserName}' logged in successfully at {DateTime.Now}");
                        ClsGlobal.CurrentUser = user;
                        if (rbtnRememberMe.Checked)
                        {
                            string EncryptedPassword = clsSecurity.SymmetricEncrypt(Password);
                            File.WriteAllText(filePath, UserName + "&" + EncryptedPassword);

                            Registry.SetValue(RegistryPath, "User Name", UserName, RegistryValueKind.String);
                            Registry.SetValue(RegistryPath, "Password", EncryptedPassword, RegistryValueKind.String);
                        }
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Sorry , Wrong password ", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Sorry ,your account is not Active ", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Sorry , User is not found.", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmLoginScreen_Load(object sender, EventArgs e)
        {

            
            try
            {
                string UserName = Registry.GetValue(RegistryPath, "User Name", "") as string;
                string Password = Registry.GetValue(RegistryPath, "Password", "") as string;
                txtName.Text = UserName;
                txtPassword.Text = clsSecurity.SymmetricDecrypt(Password); ;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsUtil.txtPassword_KeyPress(this, sender, e);
        }

        private void btnSwitchFillColor(object sender, EventArgs e)
        {
            ClsUtil.btnSwitchFillColor(sender, e);
        }

        private void rbtnRememberMe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                if (rbtnRememberMe.Checked)
                {
                    rbtnRememberMe.Checked = false;
                }
                else rbtnRememberMe.Checked = true;

                e.Handled = true; 
                btnLogin.Focus();
            }
            
        }

        private void btnViewHide_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                e.Handled = true; // for windows sound
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void ttMessageCantBeEmpty(object sender, CancelEventArgs e)
        {
            ClsUtil.ttMessageCantBeEmpty(sender, e);

        }

        private void ttMessageForTxtPassword(object sender, CancelEventArgs e)
        {
            ClsUtil.ttMessageForTxtPassword(sender, e);
        }

    }
}
