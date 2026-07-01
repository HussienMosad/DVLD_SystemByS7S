using DVLD.More;
using DVLD.Properties;
using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.TestFolder.MainForms
{
    public partial class FrmScheduleTest : UserControl
    {
        public delegate void OnCloseEvent();
        public event OnCloseEvent CloseEvent;

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode;

        ClsTestAppointment TestAppointment { get; set; }
        public int Trail {  get; set; }
        public FrmScheduleTest()
        {
            InitializeComponent();
            
        }

        public FrmScheduleTest(int TestAppointmentID)
        {
            InitializeComponent();

            ;
            this.TestAppointment = ClsTestAppointment.Find(TestAppointmentID);
          
            if (this.TestAppointment != null)
            {

                Mode = enMode.Update;
            }
            else
            {
                Mode = enMode.AddNew;
              
                this.TestAppointment = new ClsTestAppointment();
                this.TestAppointment.localDrivingLicenseApplication = ((FrmTestAppointments)FrmHome.MainPanel.Controls[FrmHome.MainPanel.Controls.Count - 1]).localDrivingLicenseApplication;
                this.TestAppointment.TestTypeID = ((FrmTestAppointments)FrmHome.MainPanel.Controls[FrmHome.MainPanel.Controls.Count - 1]).FrmMode;
                this.TestAppointment.TestType = ClsTestType.Find(this.TestAppointment.TestTypeID);
                this.TestAppointment.IsLocked = false;
                this.TestAppointment.PaidFees = this.TestAppointment.TestType.TestTypeFees;
                this.TestAppointment.CreatedByUserID = ClsGlobal.CurrentUser.UserID;
                this.TestAppointment.User = ClsUser.Find(ClsGlobal.CurrentUser.UserID);
                this.TestAppointment.LocalDrivingLicenseApplicationID = this.TestAppointment.localDrivingLicenseApplication.LocalDrivingLicenseApplicationID;
                this.TestAppointment.AppointmentDate = new DateTime();
                this.TestAppointment.AppointmentDate = DateTime.Now;
            }

            Trail = ClsTest.GetNumberOfTrail(this.TestAppointment.LocalDrivingLicenseApplicationID, (int)this.TestAppointment.TestTypeID);

            if (this.TestAppointment.TestTypeID == ClsTestType.enTestType.VisionTest)
            {
                lblHeaderTitle.Text = "Vision Test Schedule";
                picHeader.Image = Resources.eye__1_;

            }
            else if (this.TestAppointment.TestTypeID == ClsTestType.enTestType.WrittenTest)
            {
                lblHeaderTitle.Text = "Written Test Schedule";
                picHeader.Image = Resources.school__1_;
            }
            else if (this.TestAppointment.TestTypeID == ClsTestType.enTestType.StreetTest)
            {
                lblHeaderTitle.Text = "Street Test Schedule";
                picHeader.Image = Resources.drive__1_;
            }


            ucForTestSchedule1.UpdateComponents(this.TestAppointment, Trail);

            if (Trail > 0)
            {
                labTotalFees.Text = (this.TestAppointment.TestType.TestTypeFees + ClsApplicationType.Find((int)ClsApplication.enApplicationType.RetakeTest).Fees).ToString();
                lblHeaderTitle.Text = "Retake " + lblHeaderTitle.Text;
                labRetakeFees.Text = ClsApplicationType.Find((int)ClsApplication.enApplicationType.RetakeTest).Fees.ToString();
            }
            else
            {
                labTotalFees.Text = (this.TestAppointment.TestType.TestTypeFees).ToString().Trim();
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

        private void btnSave_Click(object sender, EventArgs e)
        {

            
            
            TestAppointment.AppointmentDate = ucForTestSchedule1.GetAppointmentDate();
            TestAppointment.PaidFees = ucForTestSchedule1.GetFees();

            ClsApplication App = new ClsApplication();
            if (Trail >0)
            {
                
                App.ApplicationStatus = ClsApplication.enApplicationStatus.New;
                App.ApplicantPersonID = TestAppointment.localDrivingLicenseApplication.ApplicantPersonID;
                App.ApplicationDate = DateTime.Now ;
                App.ApplicationTypeID = ClsApplication.enApplicationType.RetakeTest;
                App.LastStatusDate = DateTime.Now ;
                App.CreatedByUserID = TestAppointment.CreatedByUserID;
                App.PaidFees = ClsApplicationType.Find((int)ClsApplication.enApplicationType.RetakeTest).Fees;
                App.Save();
                if (App.ApplicationID == -1)
                {
                    
                    return;
                }
                else
                {
                    TestAppointment.RetakeTestApplicationID = App.ApplicationID;
                }
            }
            else
            {
                TestAppointment.RetakeTestApplicationID = -1;
            }

            if (TestAppointment.Save())
            {
                MessageBox.Show("Data Saved Successfully.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnBack_Click(null, null);
            }
            else
            {
                if (App.ApplicationID != -1)
                {
                    ClsApplication.DeleteApplication(App.ApplicationID);
                }
                MessageBox.Show("Data does not Saved Successfully.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
