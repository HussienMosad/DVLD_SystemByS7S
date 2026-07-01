using DVLD.Properties;
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

namespace DVLD
{
    public partial class UcPersonDetails : UserControl
    {

        public void UpdateComponent(ClsPerson Person)
        {
            labID.Text = Person.ID.ToString();
            labName.Text = Person.FirstName + " " + Person.SecondName + " " + Person.ThirdName + " " + Person.LastName;
            labNationalNo.Text = Person.NationalNo;
            labCountry.Text = ClsCountry.Find(Person.CountryID).Name;
            labGender.Text = Person.Gender;
            labAddress.Text = Person.Address;
            labPhone.Text = Person.Phone;
            labEmail.Text = Person.Email;
            labDateOfBirth.Text = Person.DateOfBirth.ToShortDateString();
            if (Person.ImagePath == "")
            {
                if (labGender.Text == "MALE")
                {
                    picProfile.Image = Resources.DefaultMan;
                }
                else
                {
                    picProfile.Image = Resources.DefaultWoman;
                }
            }
            else
            {
                try
                {
                    picProfile.Image = Image.FromFile(Person.ImagePath);
                }
                catch
                {
                    if (labGender.Text == "MALE")
                    {
                        picProfile.Image = Resources.DefaultMan;
                    }
                    else
                    {
                        picProfile.Image = Resources.DefaultWoman;
                    }
                }
            }
        }

        public void EditFormatForUserChangePassword()
        {
            labDateOfBirth.Size = new System.Drawing.Size(322, 39);
            labAddress.Size = new System.Drawing.Size(322, 39);
        }
        


        public UcPersonDetails()
        {
            InitializeComponent();
            
        }

    }
}
