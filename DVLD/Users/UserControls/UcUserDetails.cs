using DVLD.Properties;
using DVLD_BusinessLayer;
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

namespace DVLD.Users.UserControls
{
    public partial class UcUserDetails : UserControl
    {
  

        public void UpdateComponent(ClsUser User)
        {
            
            if (User.Person != null)
            {
                ucPersonDetails.UpdateComponent(User.Person);
                if (User.IsActive)
                {
                    labIsActive.Text = "Yes";
                }
                else
                {
                    labIsActive.Text = "No";
                }
                labUserID.Text = User.UserID.ToString().Trim();
                labUserName.Text = User.UserName.ToString().Trim();
            }
            else
            {
                MessageBox.Show("sorry , Person Not Found." , "Error!" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void UpdateJustPersonComponent(ClsPerson Person)
        {
            if (Person != null)
            {
                ucPersonDetails.UpdateComponent(Person);
            }
        }
        public UcUserDetails()
        {
            InitializeComponent();
        }

        private void labUserID_Click(object sender, EventArgs e)
        {

        }

        public void EditFormatForUserChangePassword()
        {
            ucPersonDetails.EditFormatForUserChangePassword();
        }
    }
}
