using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class ClsTest
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        
        public int TestID { set; get; }
        public int TestAppointmentID { set; get; }
        public ClsTestAppointment TestAppointment {  set; get; }
        public bool TestResult { set; get; } 
        public string Notes { set; get; }
        public int CreatedByUserID { set; get; }

        public ClsTest()
        {
            this.TestID = -1;
            this.TestAppointmentID = -1;
            this.TestAppointment = new ClsTestAppointment();
            this.TestResult = false;
            this.Notes = "";
            this.CreatedByUserID = -1;

            Mode = enMode.AddNew;
        }

        private ClsTest(int TestID, int TestAppointmentID, bool TestResult,
                        string Notes, int CreatedByUserID)
        {
            this.TestID = TestID;
            this.TestAppointmentID = TestAppointmentID;
            this.TestAppointment = ClsTestAppointment.Find(TestAppointmentID);
            this.TestResult = TestResult;
            this.Notes = Notes;
            this.CreatedByUserID = CreatedByUserID;

            Mode = enMode.Update;
        }

        private bool AddNewTest()
        {
            
            this.TestID = ClsTestsAccess.AddNewTest(this.TestAppointmentID,
                                                 this.TestResult, this.Notes, this.CreatedByUserID);

            return (this.TestID != -1);
        }

        private bool UpdateTest()
        {
            
            return ClsTestsAccess.UpdateTest(this.TestID, this.TestAppointmentID,
                                          this.TestResult, this.Notes, this.CreatedByUserID);
        }

        public static ClsTest Find(int TestID)
        {
            int TestAppointmentID = -1;
            bool TestResult = false;
            string Notes = "";
            int CreatedByUserID = -1;

            if (ClsTestsAccess.GetTestInfoByID(TestID, ref TestAppointmentID,
                                            ref TestResult, ref Notes, ref CreatedByUserID))
            {
                return new ClsTest(TestID, TestAppointmentID, TestResult, Notes, CreatedByUserID);
            }
            else
                return null;
        }
        

        public static ClsTest FindByTestAppointmentID(int TestAppointmentID)
        {
            int TestID = -1;
            bool TestResult = false;
            string Notes = "";
            int CreatedByUserID = -1;

            if (ClsTestsAccess.GetTestInfoByTestAppointmentID(TestAppointmentID, ref TestID,
                                            ref TestResult, ref Notes, ref CreatedByUserID))
            {
                return new ClsTest(TestID, TestAppointmentID, TestResult, Notes, CreatedByUserID);
            }
            else
                return null;
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (AddNewTest())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return UpdateTest();
            }
            return false;
        }

        public static DataTable GetAllTests()
        {
            return ClsTestsAccess.GetAllTests();
        }

        public static bool DeleteTest(int TestID)
        {
            return ClsTestsAccess.DeleteTest(TestID);
        }

        public static bool IsTestExist(int TestID)
        {
            return ClsTestsAccess.IsTestExist(TestID);
        }
        public static int GetNumberOfTrail(int localDrivingLicenseApplicationID , int testTypeID)
        {
            return ClsTestsAccess.GetNumberOfTrail(localDrivingLicenseApplicationID , testTypeID);
        }
    }
}
