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

namespace DVLD.TestFolder.UserControls
{
    public partial class UcForTestSchedule : UserControl
    {
        public ClsTestType.enTestType TestType { get; set; }
        public UcForTestSchedule()
        {
            InitializeComponent();
            dtpTestDate.MaxDate = DateTime.Now.AddYears(1);
        }

        public int GetLDLAID()
        {
            return Convert.ToInt16(labLDLAID.Text);
        }

        public void UpdateComponents( ClsTestAppointment TestAppointment ,int Trail)
        {
            labLDLAID.Text = TestAppointment.localDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
            labApplicant.Text = TestAppointment.localDrivingLicenseApplication.GetApplicantFullName();
            labLicenseClass.Text = TestAppointment.localDrivingLicenseApplication.LicenseClass.ClassName.ToString();
            labTrail.Text = Trail.ToString();
            labFees.Text = TestAppointment.TestType.TestTypeFees.ToString();
            if (TestAppointment.AppointmentDate < DateTime.Now)
            {
                dtpTestDate.MinDate = DateTime.Now;
                dtpTestDate.Value = DateTime.Now;
            }
            else
            {
                dtpTestDate.MinDate = DateTime.Now;
                dtpTestDate.Value = TestAppointment.AppointmentDate;
            }
        }

        public void UnEnableDateTimePicker()
        {
            dtpTestDate.Enabled = false;
        }

        public void SetDateTimePickerValue(DateTime dateTime)
        {
            if (dateTime > dtpTestDate.MinDate)
            {
                dtpTestDate.Value = dateTime;
            }
            else
            {
                dtpTestDate.Enabled = true;
                MessageBox.Show("Test Was Cancelled" , "Error!" , MessageBoxButtons.OK , MessageBoxIcon.Error);

            }
        }

        public DateTime GetAppointmentDate()
        {
            return dtpTestDate.Value;
        }

        public float GetFees()
        {
            return Convert.ToSingle(labFees.Text);
        }
    }
}
