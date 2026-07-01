using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class ClsTestAppointment
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int TestAppointmentID { set; get; }
        public ClsTestType.enTestType TestTypeID { set; get; }
        public ClsTestType TestType { set; get; }
        public int LocalDrivingLicenseApplicationID { set; get; }
        public ClsLocalDrivingLicenseApplication localDrivingLicenseApplication { get; set; }
        public DateTime AppointmentDate { set; get; }
        public float PaidFees { set; get; }
        public int CreatedByUserID { set; get; }
        public ClsUser User { set; get; }
        public bool IsLocked { set; get; }

        public int RetakeTestApplicationID { set; get; }
        
        public ClsTestAppointment()
        {
            this.TestAppointmentID = -1;
            this.TestTypeID = ClsTestType.enTestType.VisionTest;
            this.LocalDrivingLicenseApplicationID = -1;
            this.AppointmentDate = DateTime.Now;
            this.PaidFees = 0;
            this.CreatedByUserID = -1;
            this.IsLocked = false;
            this.RetakeTestApplicationID = -1;
            this.User = new ClsUser();
            localDrivingLicenseApplication = new ClsLocalDrivingLicenseApplication();
            TestType = new ClsTestType();
            Mode = enMode.AddNew;
        }

        private ClsTestAppointment(int TestAppointmentID, ClsTestType.enTestType TestTypeID,
            int LocalDrivingLicenseApplicationID, DateTime AppointmentDate, float PaidFees,
            int CreatedByUserID, bool IsLocked, int RetakeTestApplicationID)
        {
            this.TestAppointmentID = TestAppointmentID;
            this.TestTypeID = TestTypeID;
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.AppointmentDate = AppointmentDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsLocked = IsLocked;
            this.RetakeTestApplicationID = RetakeTestApplicationID;
            this.localDrivingLicenseApplication = ClsLocalDrivingLicenseApplication.Find(LocalDrivingLicenseApplicationID);
            this.TestType = ClsTestType.Find(TestTypeID);
            this.User = ClsUser.Find(CreatedByUserID);
            Mode = enMode.Update;
        }

        private bool _AddNewTestAppointment()
        {
            
            this.TestAppointmentID = ClsTestAppointmentsAccess.AddNewTestAppointment(
                (int)this.TestTypeID, this.LocalDrivingLicenseApplicationID, this.AppointmentDate,
                this.PaidFees, this.CreatedByUserID, this.IsLocked, this.RetakeTestApplicationID);

            return (this.TestAppointmentID != -1);
        }

        private bool _UpdateTestAppointment()
        {
         
            return ClsTestAppointmentsAccess.UpdateTestAppointment(
                this.TestAppointmentID,(int) this.TestTypeID, this.LocalDrivingLicenseApplicationID,
                this.AppointmentDate, this.PaidFees, this.CreatedByUserID, this.IsLocked,
                this.RetakeTestApplicationID);
        }

        public static ClsTestAppointment Find(int TestAppointmentID)
        {
            int TestTypeID = -1, LocalDrivingLicenseApplicationID = -1, CreatedByUserID = -1, RetakeTestApplicationID = -1;
            DateTime AppointmentDate = DateTime.Now;
            float PaidFees = 0;
            bool IsLocked = false;

            if (ClsTestAppointmentsAccess.GetTestAppointmentInfoByID(TestAppointmentID, ref TestTypeID,
                ref LocalDrivingLicenseApplicationID, ref AppointmentDate, ref PaidFees,
                ref CreatedByUserID, ref IsLocked, ref RetakeTestApplicationID))
            {
                return new ClsTestAppointment(TestAppointmentID, (ClsTestType.enTestType) TestTypeID, LocalDrivingLicenseApplicationID,
                    AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID);
            }
            else
                return null;
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewTestAppointment())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateTestAppointment();
            }

            return false;
        }

        public static DataTable GetAllTestAppointments()
        {
            return ClsTestAppointmentsAccess.GetAllTestAppointments();
        }

        public static bool DeleteTestAppointment(int TestAppointmentID)
        {
            return ClsTestAppointmentsAccess.DeleteTestAppointment(TestAppointmentID);
        }

        public static bool IsTestAppointmentExist(int TestAppointmentID)
        {
            return ClsTestAppointmentsAccess.IsTestAppointmentExist(TestAppointmentID);
        }

        public static DataTable GetApplicantAppointments(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            return ClsTestAppointmentsAccess.GetApplicantAppointments(LocalDrivingLicenseApplicationID, TestTypeID);
        }

        public static bool ThereIsAnActiveAppointment(int LocalDrivingLicenseApplicationID , int TestTypeID)
        {
            return ClsTestAppointmentsAccess.ThereIsAnActiveAppointment(LocalDrivingLicenseApplicationID, TestTypeID);
        }

        public static bool TestWasPassed(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            return ClsTestAppointmentsAccess.TestWasPassed(LocalDrivingLicenseApplicationID, TestTypeID);
        }

    }
}
