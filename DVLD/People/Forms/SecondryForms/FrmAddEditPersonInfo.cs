using DVLD.ApplicationsFolder.MainForms;
using DVLD.More;
using DVLD.People.Forms.MainForm;
using DVLD.Properties;
using DVLD.Users.Forms.MainForm;
using DVLD.Users.Forms.SecondryForms;
using DVLD_BusinessLayer;
using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class FrmAddEditPersonInfo : UserControl
    {
        public delegate void OnCloseEvent1();
        public event OnCloseEvent1 CloseEvent1;

        public delegate void OnCloseEvent2(ClsPerson person);
        public event OnCloseEvent2 CloseEvent2;

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode;

        public int PersonID;
        public ClsPerson Person;
        // think about why we don't use setter and getter 

        public FrmAddEditPersonInfo( int personID)
        {
            InitializeComponent();
            this.PersonID = personID;

            if (this.PersonID == -1)
                Mode = enMode.AddNew;
            else
                Mode = enMode.Update;
            this.BringToFront();
            
        }

        private bool DoYouWantToSaveChanges()
        {
            
                if (ThereAreChanges())
                {
                    if (MessageBox.Show("Do you want to save changes ?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (!UcAddEditPersonInfo.DetailsAreReadyToSave())
                        {
                            MessageBox.Show("You can not save Details , Please fill the previous fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                        else
                        {
                            SaveEvent();
                        }
                    }
                }
            
            return true;
        }

        

        private void LoadData()
        {
            // if add new person
            if (Mode == enMode.AddNew)
            {
                lblHeaderTitle.Text = "Add New Contact";
                picHeader.Image = Resources.add_user;
                Person = new ClsPerson();
                UcAddEditPersonInfo.UpdateComponent(Person);
                return;
            }

            Person = ClsPerson.Find(PersonID);

            if (Person == null)
            {
                MessageBox.Show("This form will be closed because No Contact with ID = " + PersonID);
                FrmHome.MainPanel.Controls.Remove(this);

                return;
            }
            UcAddEditPersonInfo.UpdateComponent(Person);
            lblHeaderTitle.Text = "Edit Person" ;
            picHeader.Image = Resources.edit_user;
            

        }

        private void frmAddEditPersonInfo_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveEvent();
        }

        private bool SaveEvent()
        {
            if (UcAddEditPersonInfo.Save())
            {
                Mode = enMode.Update;
                Person = UcAddEditPersonInfo.Person;
                lblHeaderTitle.Text = "Edit Person";
                picHeader.Image = Resources.edit_user;
                return true;
            }
            return false;

        }

        private bool ThereAreChanges()
        {

            return UcAddEditPersonInfo.ThereAreChanges();
        }
        
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (!DoYouWantToSaveChanges())
            {
                return;
            }
            CloseEvent1?.Invoke();
            CloseEvent2?.Invoke(Person);
            FrmHome.RemoveFromMainPanel();




            // here I knew why i should use the delegate event ........
            /*if (FrmHome.MainPanel.Controls.Count == 2)
            {
                // Update Content 
                if(FrmHome.MainPanel.Controls[1] is FrmAddEditUser)
                {
                    ((FrmAddEditUser)FrmHome.MainPanel.Controls[1]).UpdateUcPersonDetailsWithFilter(Person);
                    ((FrmUsers)FrmHome.MainPanel.Controls[0]).RefreshUsersData();
                }
                
                if (FrmHome.MainPanel.Controls[1] is FrmPersonDetails)
                {
                    ((FrmPersonDetails)FrmHome.MainPanel.Controls[1]).UpdateComponent(Person);
                    ((FrmPeople)FrmHome.MainPanel.Controls[0]).RefreshPeopleData();
                }
                if (FrmHome.MainPanel.Controls[1] is FrmUserDetails)
                {

                    ((FrmUserDetails)FrmHome.MainPanel.Controls[1]).UpdateJustPersonComponent(Person);
                    if (FrmHome.MainPanel.Controls[0] is FrmUsers)
                    {
                        ((FrmUsers)FrmHome.MainPanel.Controls[0]).RefreshUsersData();
                    }
                }
                if(FrmHome.MainPanel.Controls[1] is FrmChangeUserPassword)
                {
                    ((FrmChangeUserPassword)FrmHome.MainPanel.Controls[1]).UpdateJustPersonComponent(Person);
                    ((FrmUsers)FrmHome.MainPanel.Controls[0]).RefreshUsersData();



                    // here code if [0] is frmsettings
                }
            }
            else if(FrmHome.MainPanel.Controls.Count == 1)
            {
                if (FrmHome.MainPanel.Controls[0] is FrmPeople)
                {
                    ((FrmPeople)FrmHome.MainPanel.Controls[0]).RefreshPeopleData();
                }
            }
            else if(FrmHome.MainPanel.Controls.Count == 3)
            {
                if(FrmHome.MainPanel.Controls[1] is FrmApplicationBtnsScreen)
                {
                    ((FrmLocalDrivingLicenseApplications)FrmHome.MainPanel.Controls[1]).RefreshLDLADGVData();
                }
                ((FrmNewLocalDrivingLicenseApplication)FrmHome.MainPanel.Controls[2]).UpdateUcPersonDetailsWithFilter(Person);
            }*/

        }

        private void btnStrongBack_Click(object sender, EventArgs e)
        {
            if(!DoYouWantToSaveChanges())
            {
                return;
            }
            while (FrmHome.MainPanel.Controls.Count != 1 )
            {
                FrmHome.MainPanel.Controls.RemoveAt(FrmHome.MainPanel.Controls.Count-1);
            }
            FrmHome.MainPanel.Controls[FrmHome.MainPanel.Controls.Count - 1].Visible = true;
            FrmHome.MainPanel.Controls[FrmHome.MainPanel.Controls.Count - 1].Focus();
            if (FrmHome.MainPanel.Controls[0] is FrmPeople)
            { 
               
                ((FrmPeople)FrmHome.MainPanel.Controls[0]).RefreshPeopleData();
            }
            if (FrmHome.MainPanel.Controls[0] is FrmUsers)
            {
                ((FrmUsers)FrmHome.MainPanel.Controls[0]).RefreshUsersData();
            }
            
            
            

        }

        private void btn_Enter(object sender, EventArgs e)
        {
            ClsUtil.btnSwitchFillColor(sender, e);
        }

        private void btnSwitchFillColor(object sender, EventArgs e)
        {
            ClsUtil.btnSwitchFillColor(sender, e);
        }

    }
}
