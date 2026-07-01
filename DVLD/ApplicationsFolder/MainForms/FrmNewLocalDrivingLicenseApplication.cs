using DVLD.ApplicationsFolder.SecondryForms;
using DVLD.More;
using DVLD.Properties;
using DVLD.Users.Forms.MainForm;
using 
    
    
    
    
    
    
    
    
    
    DVLD_BusinessLayer;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net.Cache;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.ApplicationsFolder.MainForms
{
    public partial class FrmNewLocalDrivingLicenseApplication : UserControl
    {
        public delegate void OnCloseEvent();
        public event OnCloseEvent CloseEvent;
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode;
        public int LocalDrivingLicenseApplicationID { get; set; }
        private ClsLocalDrivingLicenseApplication LocalDrivingLicenseApplication { get; set; }

        public FrmNewLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID)
        {
            InitializeComponent();
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            ucNewLocalDrivingLicenseApplications1.LoadFirstTime((int)ClsApplication.enApplicationType.NewDrivingLicense);
            if (LocalDrivingLicenseApplicationID != -1)
            {
                LocalDrivingLicenseApplication = ClsLocalDrivingLicenseApplication.Find(LocalDrivingLicenseApplicationID);
                ucPersonDetailsWithFilter.UpdateComponent(LocalDrivingLicenseApplication.Person);
                ucNewLocalDrivingLicenseApplications1.UpdateComponent(LocalDrivingLicenseApplication);
                TurnToEditForm();
            }
            else
            {
                LocalDrivingLicenseApplication = new ClsLocalDrivingLicenseApplication();
                Mode = enMode.AddNew;
            }
        }

        public void TurnToEditForm()
        {
            ucPersonDetailsWithFilter.UnEnable();
            lblHeaderTitle.Text = "Edit Local Driving License Application";
            picHeader.Image = Resources.edit__1_;
            ucNewLocalDrivingLicenseApplications1.setLblID(LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID);
            Mode = enMode.Update;
        }


        private void btnSwitchFillColor(object sender, EventArgs e)
        {
            ClsUtil.btnSwitchFillColor(sender, e);
        }

        public void UpdateUcPersonDetailsWithFilter(ClsPerson Person)
        {
            if (Person.ID != -1)
            {
                ucPersonDetailsWithFilter.UpdateComponent(Person);
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmHome.RemoveFromMainPanel();
            CloseEvent?.Invoke();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (ucPersonDetailsWithFilter.Person != null)
            {
                btnNext.Visible = false;
                btnNext.TabStop = false;

                btnBack.Visible = false;
                btnBack.TabStop = false;

                btnEditPerson.Visible = false;
                btnEditPerson.TabStop = false;

                btnReserveNext.Visible = true;
                btnReserveNext.TabStop = true;

                btnSave.Visible = true;
                btnSave.TabStop = true;
                ucNewLocalDrivingLicenseApplications1.BringToFront();
                ucPersonDetailsWithFilter.SendToBack();
                ucNewLocalDrivingLicenseApplications1.Focus();
            }
            else
            {
                MessageBox.Show("Please Chose a Person first");
            }
        }

        private void btnReserveNext_Click(object sender, EventArgs e)
        {
            btnNext.Visible = true;
            btnNext.TabStop = true;

            btnBack.Visible = true;
            btnBack.TabStop = true;

            btnEditPerson.Visible = true;
            btnEditPerson.TabStop = true;

            btnReserveNext.Visible = false;
            btnReserveNext.TabStop = false;

            btnSave.Visible = false;
            btnSave.TabStop = false;
            ucPersonDetailsWithFilter.Focus();
            ucPersonDetailsWithFilter.BringToFront();
            ucNewLocalDrivingLicenseApplications1.SendToBack();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ucPersonDetailsWithFilter.Person == null)
            {
                MessageBox.Show("Chose A person First");
                return;
            }

            if (Mode == enMode.AddNew)
            {

                LocalDrivingLicenseApplication.ApplicantPersonID = ucPersonDetailsWithFilter.Person.ID;
                LocalDrivingLicenseApplication.Person = ucPersonDetailsWithFilter.Person;
                LocalDrivingLicenseApplication.ApplicationDate = DateTime.Now;
                LocalDrivingLicenseApplication.ApplicationTypeID = ClsApplication.enApplicationType.NewDrivingLicense;
                LocalDrivingLicenseApplication.ApplicationStatus = ClsApplication.enApplicationStatus.New;
                LocalDrivingLicenseApplication.LastStatusDate = DateTime.Now;
                LocalDrivingLicenseApplication.PaidFees = ucNewLocalDrivingLicenseApplications1.getPaidFees();
                LocalDrivingLicenseApplication.CreatedByUserID = ucNewLocalDrivingLicenseApplications1.getCreatedByUserID();
                LocalDrivingLicenseApplication.LicenseClassID = ucNewLocalDrivingLicenseApplications1.getClassID();
            }
            else
            {
                LocalDrivingLicenseApplication.LicenseClassID = ucNewLocalDrivingLicenseApplications1.getClassID();
            }
            
            if (ClsApplication.ThereIsAnActiveApplicationForLicenseClass(LocalDrivingLicenseApplication.ApplicantPersonID, (int)LocalDrivingLicenseApplication.ApplicationTypeID, LocalDrivingLicenseApplication.LicenseClassID))
            {
                MessageBox.Show("Application Is already exists .", "Sorry.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ClsLocalLicense.IsLicenseExistsByPersonID(LocalDrivingLicenseApplication.ApplicantPersonID, LocalDrivingLicenseApplication.LicenseClassID))
            {
                MessageBox.Show("Person have this License Class", "Sorry.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int Age = DateTime.Now.Year - LocalDrivingLicenseApplication.Person.DateOfBirth.Year;
            if (Age < ClsLicenseClass.Find(LocalDrivingLicenseApplication.LicenseClassID).MinimumAllowedAge)
            {
                MessageBox.Show("Person age is less than the minimum allowed age for this Class .", "Sorry.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // or
            /*if(!ClsLocalDrivingLicenseApplication.CheckPersonAge(LocalDrivingLicenseApplication.Person.DateOfBirth , LocalDrivingLicenseApplication.LicenseClassID))
            {
                MessageBox.Show("Person age is less than the minimum allowed age for this Class .", "Sorry.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }*/

            if (LocalDrivingLicenseApplication.Save())
            {
                if (Mode == enMode.AddNew)
                {
                    TurnToEditForm();
                    MessageBox.Show("Data Saved Successfully.", "Done.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data Updated Successfully.", "Done.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Data didn't Save .", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }
    }
}