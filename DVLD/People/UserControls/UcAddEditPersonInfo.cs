using DVLD.More;
using DVLD.Properties;
using DVLD_BusinessLayer;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DVLD
{
    public partial class UcAddEditPersonInfo : UserControl
    {
        public ClsPerson Person { get; set; }

        public UcAddEditPersonInfo()
        {

            InitializeComponent();
            dtpBirthDate.MaxDate = DateTime.Now.AddYears(-18);

        }

        public void UpdateComponent(ClsPerson Person)
        {
            this.Person = Person;
            if (Person.ID != -1)
            {
                labID.Text = Person.ID.ToString().Trim();
                txtNationalNo.Text = Person.NationalNo.Trim();
                txtFirstName.Text = Person.FirstName.Trim();
                txtSecondName.Text = Person.SecondName.Trim();
                txtThirdName.Text = Person.ThirdName.Trim();
                txtLastName.Text = Person.LastName.Trim();
                labGender.Text = Person.Gender.Trim();
                txtEmail.Text = Regex.Replace(Person.Email, "@Gmail.com", "@Gmail.com", RegexOptions.IgnoreCase).Trim();
                txtPhone.Text = Person.Phone.Trim();
                txtAddress.Text = Person.Address.Trim();
                dtpBirthDate.Value = Person.DateOfBirth;

                // Handle Image
                if (!string.IsNullOrWhiteSpace(Person.ImagePath))
                {
                    try
                    {
                        picProfile.Load(Person.ImagePath.Trim());
                    }
                    catch
                    {
                        if (labGender.Text.ToUpper() == "MALE")
                        {
                            picProfile.Image = Resources.DefaultMan;
                        }
                        else
                        {
                            picProfile.Image = Resources.DefaultWoman;
                        }
                    }
                }
                else
                {
                    if (Person.Gender.ToUpper() == "FEMALE")
                        picProfile.Image = Resources.DefaultWoman;
                    else
                        picProfile.Image = Resources.DefaultMan;
                }

                cmbCountry.SelectedIndex = cmbCountry.FindString(ClsCountry.Find(Person.CountryID).Name);
            }
            else
            {
                // Necessary
                dtpBirthDate.Value = dtpBirthDate.MaxDate;
            }
        }

        private void picProfile_MouseEnter(object sender, EventArgs e)
        {
            picEditImage.Visible = true;
        }

        private void picProfile_MouseLeave(object sender, EventArgs e)
        {
            picEditImage.Visible = false;
        }

        public bool DetailsAreReadyToSave()
        {
            if (txtFirstName.Text.ToLower().Equals("First".ToLower()) || txtSecondName.Text.ToLower().Equals("Second".ToLower()) || txtThirdName.Text.ToLower().Equals("Third".ToLower())
                || txtLastName.Text.ToLower().Equals("Last".ToLower()) || txtNationalNo.Text.ToLower().Equals("0000".ToLower()) || cmbCountry.SelectedIndex == -1 ||
                txtPhone.Text.ToLower().Equals("Enter Phone".ToLower()) || txtAddress.Text.ToLower().Equals("Enter Your Address".ToLower())
                || txtEmail.Text.ToLower().Equals("EnterYourEmail@Gmail.com".ToLower()) )
            {
                return false;
            }
            return true;
        }

        public bool ThereAreChanges()
        {
            if (!txtFirstName.Text.Equals(Person.FirstName)
                || !txtSecondName.Text.Equals(Person.SecondName)
                || !txtThirdName.Text.Equals(Person.ThirdName)
                || !txtLastName.Text.Equals(Person.LastName)
                || !labGender.Text.Equals(Person.Gender)
                || !txtNationalNo.Text.Equals(Person.NationalNo)
                || !cmbCountry.SelectedItem.ToString().Equals(ClsCountry.Find(Person.CountryID).Name)
                || !txtPhone.Text.Equals(Person.Phone)
                || !txtAddress.Text.Equals(Person.Address)
                || !txtEmail.Text.ToLower().Equals(Person.Email.ToLower())
                || !(dtpBirthDate.Value == Person.DateOfBirth)
                || !(Person.ImagePath == picProfile.ImageLocation || picProfile.ImageLocation == null) 
                )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Save()
        {
            if(!DetailsAreReadyToSave())
            {
                MessageBox.Show("Can not save Details , Please fill the previous fields.");
                return false;
            }
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Can not save Details");
                return false;
            }
            if(!HandlePersonImage())
            {
                return false;
            }
            ClsPerson personObjToSaveDetails = new ClsPerson(Person);
            Person.NationalNo = txtNationalNo.Text.Trim();
            Person.FirstName = txtFirstName.Text.Trim();

            Person.SecondName = txtSecondName.Text.Trim();
            Person.ThirdName = txtThirdName.Text.Trim();
            Person.LastName = txtLastName.Text.Trim();
            Person.Gender = labGender.Text.Trim();
            
            Person.Email = Regex.Replace(txtEmail.Text, "@Gmail.com", "@Gmail.com", RegexOptions.IgnoreCase).Trim(); ;
            Person.Phone = txtPhone.Text.Trim();
            Person.Address = txtAddress.Text.Trim();
            Person.DateOfBirth = dtpBirthDate.Value;
            int CountryID = ClsCountry.Find(cmbCountry.Text).ID;
            Person.CountryID = CountryID;

            if (picProfile.ImageLocation != null)
                Person.ImagePath = picProfile.ImageLocation.Trim();
            else
                Person.ImagePath = "";

            if (Person.Save())
            {
                MessageBox.Show("Data Saved Successfully.");
                labID.Text = Person.ID.ToString();
                return true;
            }
            else
            {
                MessageBox.Show("Error: Data Is not Saved Successfully.");

                Person = new ClsPerson(personObjToSaveDetails);

                /*Person.Mode = personObjToSaveDetails.Mode;
                Person.ID = personObjToSaveDetails.ID;
                Person.NationalNo = personObjToSaveDetails.NationalNo;
                Person.FirstName = personObjToSaveDetails.FirstName;
                Person.SecondName = personObjToSaveDetails.SecondName;
                Person.ThirdName = personObjToSaveDetails.ThirdName;
                Person.Gender = personObjToSaveDetails.Gender;
                Person.LastName = personObjToSaveDetails.LastName;
                Person.Email = personObjToSaveDetails.Email;
                Person.Phone = personObjToSaveDetails.Phone;
                Person.Address = personObjToSaveDetails.Address;
                Person.DateOfBirth = personObjToSaveDetails.DateOfBirth;
                Person.ImagePath = personObjToSaveDetails.ImagePath;
                Person.CountryID = personObjToSaveDetails.CountryID;
                */
                return false;
            }



        }

        private void btnGender_Click(object sender, EventArgs e)
        {

            Guna2GradientButton b = ((Guna2GradientButton)sender);

            if (b.Text.ToUpper() == "FEMALE".ToUpper())
            {
                b.Text = "MALE".ToUpper();
            }
            else
            { 
                b.Text = "FEMALE".ToUpper();
            }
            if (Person.ImagePath == "" && picProfile.ImageLocation == null)
            {
                if (b.Text == "MALE")
                {
                    picProfile.Image = Resources.DefaultMan;
                }
                else
                {
                    picProfile.Image = Resources.DefaultWoman;
                }
            }
        }

        private void btnGender_MouseEnter(object sender, EventArgs e)
        {
            Guna2GradientButton b = ((Guna2GradientButton)sender);
            b.ForeColor = Color.Teal;
        }

        private void btnGender_MouseLeave(object sender, EventArgs e)
        {
            Guna2GradientButton b = ((Guna2GradientButton)sender);
            b.ForeColor = labID.ForeColor;
        }

        private void EditProfileImage()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Chose An Image";
            ofd.Filter = "type|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picProfile.Load(ofd.FileName);
            }
        }

        private void picProfile_Click(object sender, EventArgs e)
        {
            EditProfileImage();
        }

        private void txtFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!ClsValidation.IsLetterOrControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (((Guna2TextBox)sender).Text.Length >= 50 && !ClsValidation.IsControl(e.KeyChar)) e.Handled = true;
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // for windows sound
                this.SelectNextControl((Control)sender, true, true, true, true);
            }

        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text.ToUpper().Trim() == "EnterYourEmail@gmail.com".ToUpper().Trim())
            {
                txtEmail.Text = "";
            }

        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!ClsValidation.Email_PressKeyValidation(e.KeyChar, txtEmail.Text)) e.Handled = true;
            if (txtEmail.Text.Length >= 100 && !ClsValidation.IsControl(e.KeyChar)) e.Handled = true;
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // for windows sound
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!ClsValidation.Phone_PressKeyValidation(e.KeyChar, txtPhone.Text, txtPhone.SelectionStart)) e.Handled = true;
            if (txtPhone.Text.Length >= 15 && !ClsValidation.IsControl(e.KeyChar)) e.Handled = true;
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // for windows sound
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }


        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            string s = Regex.Replace(txtEmail.Text, "@gmail.com", "", RegexOptions.IgnoreCase);
            if (!(txtEmail.Text.Trim().ToLower().EndsWith("@gmail.com".ToLower()) && !char.IsNumber(txtEmail.Text[0]))|| s.Contains('@') || s.Contains('.'))
            {
                e.Cancel = true;
                txtEmail.ForeColor = Color.DeepPink;
                ClsUtil.ttMessage.Show("Email Must starts with letter and ends with /@gmail.com/ \n and must be a valid Email .", txtEmail, 0, txtEmail.Height, 10000);
            }
        }

        private void txtEmail_Validated(object sender, EventArgs e)
        {
            txtEmail.ForeColor = labID.ForeColor;
        }

        private void txtPhone_Enter(object sender, EventArgs e)
        {
            if (txtPhone.Text.ToUpper().Trim() == "Enter Phone".ToUpper().Trim())
            {
                txtPhone.Text = "";
            }
        }

        

        private void txtNationalNo_Enter(object sender, EventArgs e)
        {
            if (txtNationalNo.Text.ToUpper().Trim() == "0000".ToUpper().Trim())
            {
                txtNationalNo.Text = "";
            }
        }

        private void txtAddress_Enter(object sender, EventArgs e)
        {
            if (txtAddress.Text.ToUpper().Trim() == "Enter Your Address".ToUpper().Trim())
            {
                txtAddress.Text = "";
            }
        }

        private void ttMessageCantBeEmpty( object sender , CancelEventArgs e)
        {
            ClsUtil.ttMessageCantBeEmpty(sender, e);
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            ttMessageCantBeEmpty(sender,e);
            if (txtPhone.Text.Length != 0)
            {
                if (txtPhone.Text[0] == '+' && txtPhone.Text.Length < 7)
                {
                    e.Cancel = true;
                    ClsUtil.ttMessage.Show("Enter More than 6 Numbers.", txtPhone, 0, txtPhone.Height, 10000);
                }
                else if (txtPhone.Text.Length < 6)
                {
                    e.Cancel = true;
                    ClsUtil.ttMessage.Show("Enter More than 6 Numbers.", txtPhone, 0, txtPhone.Height, 10000);
                }
            }
        }

        private void txtFirstName_Enter(object sender, EventArgs e)
        {
            if (txtFirstName.Text.ToUpper().Trim() == "First".ToUpper().Trim())
            {
                txtFirstName.Text = "";
            }
        }

        private void txtSecondName_Enter(object sender, EventArgs e)
        {
            if (txtSecondName.Text.ToUpper().Trim() == "Second".ToUpper().Trim())
            {
                txtSecondName.Text = "";
            }
        }

        private void txtThirdName_Enter(object sender, EventArgs e)
        {
            if (txtThirdName.Text.ToUpper().Trim() == "Third".ToUpper().Trim())
            {
                txtThirdName.Text = "";
            }
        }

        private void txtLastName_Enter(object sender, EventArgs e)
        {
            if (txtLastName.Text.ToUpper().Trim() == "Last".ToUpper().Trim())
            {
                txtLastName.Text = "";
            }
        }

        private void btnDeletePhoto_Click(object sender, EventArgs e)
        {
            Person.ImagePath = ""; 
            picProfile.ImageLocation = null;
            if (labGender.Text.Trim().ToLower() == "Male".Trim().ToLower())
            {
                picProfile.Image = Resources.DefaultMan;
            }
            else
            {
                picProfile.Image = Resources.DefaultWoman;
            }
            
        }


        private bool HandlePersonImage()
        {
            if (Person.ImagePath == picProfile.ImageLocation)
            {
                return true;
            }






            if (Person.ImagePath != "")
            {
                try { File.Delete(Person.ImagePath); }
                catch (IOException) { }
            }

            if (picProfile.ImageLocation != null)
            {
                string SourceImageFile = picProfile.ImageLocation.ToString();
                if (ClsUtil.CopyImageToProjectImagesFolder(ref SourceImageFile))
                {
                    picProfile.ImageLocation = SourceImageFile;
                    return true;
                }
                else
                {
                    MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;
        }

        private void txtAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(txtAddress.Text.Length >= 200 && !ClsValidation.IsControl(e.KeyChar)) e.Handled = true;
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // for windows sound
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txtNationalNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtNationalNo.Text.Length >= 50 && !ClsValidation.IsControl(e.KeyChar)) e.Handled = true;
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // for windows sound
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void btnSetPhoto_Click(object sender, EventArgs e)
        {
            EditProfileImage();
        }

        private void btnSwitchFillColor(object sender, EventArgs e)
        {
            ClsUtil.btnSwitchFillColor(sender, e);
        }

        private void cmbCountry_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // for windows sound
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void dtpBirthDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // for windows sound
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void labGender_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // for windows sound
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }
        private void CmbCountry_Enter(object sender, EventArgs e)
        {
            cmbCountry.ForeColor = Color.Red;
        }

        private void CmbCountry_Leave(object sender, EventArgs e)
        {
            cmbCountry.ForeColor = ClsSettings.BlueMainColor;
        }
    }
}
