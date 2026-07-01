using DVLD.More;
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

namespace DVLD.TestFolder.MainForms
{
    public partial class FrmTakeTest : UserControl
    {
        public delegate void OnCloseEvent();
        public event OnCloseEvent CloseEvent;

        public enum enMode { AddNew = 0, Show = 1 };
        public enMode Mode;

        public ClsTest Test {  get; set; }

        public int TestAppointmentID { get; set; }
        public FrmTakeTest()
        {
            InitializeComponent();
        }
        public int Trail {  get; set; }

        public FrmTakeTest(int TestAppointmentID)
        {
            InitializeComponent();
            this.TestAppointmentID = TestAppointmentID;
            
            Test = ClsTest.FindByTestAppointmentID(TestAppointmentID);
            ClsTestAppointment testAppointment = ClsTestAppointment.Find(TestAppointmentID);
            if (Test == null)
            {
                Test = new ClsTest();
                Test.TestAppointment = testAppointment;
                Test.TestAppointment.AppointmentDate = testAppointment.AppointmentDate;
                Mode = enMode.AddNew;
            }
            else
            {
                Test.TestAppointment = testAppointment;
                Mode = enMode.Show;
                Test.TestAppointment.AppointmentDate = testAppointment.AppointmentDate;
                txtNotes.Text = Test.Notes;
                lalTestID.Text = Test.TestID.ToString();
                if (Test.TestResult)
                {
                    btnTestResult.Text = "Pass";

                }
                else
                {
                    btnTestResult.Text = "Fail";
                }
                btnTestResult.Enabled = false;
                txtNotes.Enabled = false;
                btnSave.Enabled = false;
            }
            if (testAppointment.TestTypeID == ClsTestType.enTestType.VisionTest)
            {
                lblHeaderTitle.Text = "Take a Vision Test";
                picHeader.Image = Resources.eye__1_;

            }
            else if (testAppointment.TestTypeID == ClsTestType.enTestType.WrittenTest)
            {
                lblHeaderTitle.Text = "Take a Written Test";
                picHeader.Image = Resources.school__1_;
            }
            else if (testAppointment.TestTypeID == ClsTestType.enTestType.StreetTest)
            {
                lblHeaderTitle.Text = "Take a Street Test";
                picHeader.Image = Resources.drive__1_;
            }
            Trail = ClsTest.GetNumberOfTrail(testAppointment.localDrivingLicenseApplication.LocalDrivingLicenseApplicationID, (int)testAppointment.TestTypeID);

            ucForTestSchedule1.UpdateComponents(testAppointment, Trail);
            ucForTestSchedule1.UnEnableDateTimePicker();
        }


        private void btnSwitchFillColor(object sender, EventArgs e)
        {
            ClsUtil.btnSwitchFillColor(sender, e);
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            int t = Convert.ToByte(btnTestResult.Tag);
            if(t == 1)
            {
                btnTestResult.Tag = 0;
                btnTestResult.Text = "Fail";
            }
            else
            {
                btnTestResult.Tag = 1;
                btnTestResult.Text = "Pass";
            }
        }

        private void picRetakeFees_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmHome.RemoveFromMainPanel();
            CloseEvent?.Invoke();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Test.Notes = txtNotes.Text;
            Test.TestResult = (Convert.ToByte(btnTestResult.Tag) == 1);
            Test.CreatedByUserID = ClsGlobal.CurrentUser.UserID;
            Test.TestAppointmentID = this.TestAppointmentID;
            
            if(Test.Save())
            {
                lalTestID.Text = Test.TestID.ToString();
                MessageBox.Show("Data Saved Successfully.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Test.TestAppointment.IsLocked = true;
                Test.TestAppointment.Mode = ClsTestAppointment.enMode.Update;

                if(!Test.TestAppointment.Save())
                {
                    ClsTest.DeleteTest(Test.TestID);
                }
                btnBack_Click(null, null);
            }
            else
            {
                MessageBox.Show("Sorry , Data does not Saved.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
