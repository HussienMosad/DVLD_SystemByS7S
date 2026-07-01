using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class ClsLocalDrivingLicenseApplication : ClsApplication
    {
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode Mode = enMode.AddNew;

        public int LocalDrivingLicenseApplicationID { get; set; }
        public int LicenseClassID { get; set; }
        public ClsLicenseClass LicenseClass { get; set; }

        public ClsLocalDrivingLicenseApplication() : base()
        {
            this.LicenseClassID = -1;
            LicenseClass = new ClsLicenseClass();
            this.LocalDrivingLicenseApplicationID = -1;
            Mode = enMode.AddNew;
        }

        public ClsLocalDrivingLicenseApplication(int ApplicationID, int ApplicantPersonID, DateTime ApplicationDate,
                               enApplicationType ApplicationTypeID, enApplicationStatus ApplicationStatus, DateTime LastStatusDate,
                               float PaidFees, int CreatedByUserID, int LocalDrivingLicenseApplicationID, int licenseClassID) :
                                                 
                                base(ApplicationID, ApplicantPersonID, ApplicationDate,
                                                 ApplicationTypeID, ApplicationStatus, LastStatusDate,
                                                 PaidFees, CreatedByUserID)
        {
            this.LicenseClassID = licenseClassID;
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            LicenseClass = ClsLicenseClass.Find(licenseClassID);
            Mode = enMode.Update;
        }

        private bool AddNewLocalDrivingLicenseApplication()
        {

            this.LocalDrivingLicenseApplicationID = ClsLocalDrivingLicenseApplicationsAccess.AddNewLocalDrivingLicenseApplication
                        (this.ApplicantPersonID, this.ApplicationDate, (int)this.ApplicationTypeID,
                         (byte) this.ApplicationStatus, this.LastStatusDate, this.PaidFees, this.CreatedByUserID,
                         this.LicenseClassID);
            return (this.LocalDrivingLicenseApplicationID != -1);
        }

        public bool Save()
        {

            switch (Mode)
            {
                case enMode.AddNew:
                    if (AddNewLocalDrivingLicenseApplication())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                       case enMode.Update:
                          return UpdateLocalDrivingLicenseApplication();

             }
            return false;

        }

        public static DataTable GetAllLocalDrivingLicenseApplications()
        {
            return ClsLocalDrivingLicenseApplicationsAccess.GetAllLocalDrivingLicenseApplications();

        }

        public static bool Delete(int LocalDrivingLicenseApplicationID)
        {
            return ClsLocalDrivingLicenseApplicationsAccess.DeleteLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID);
        }

        public static bool Cancel(int LocalDrivingLicenseApplicationID)
        {
            return ClsLocalDrivingLicenseApplicationsAccess.CancelLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID);
        }



        public static bool CheckPersonAge(DateTime DateOfBirth , int ClassID)
        {
            return ClsLocalDrivingLicenseApplicationsAccess.CheckPersonAge(DateOfBirth , ClassID);
        }


        private bool UpdateLocalDrivingLicenseApplication()
        {
            

            return ClsLocalDrivingLicenseApplicationsAccess.UpdateLocalDrivingLicenseApplication                
                (
                    this.LocalDrivingLicenseApplicationID , this.ApplicationID , this.ApplicantPersonID,
                    this.ApplicationDate , (int)this.ApplicationTypeID , (byte)this.ApplicationStatus , this.LastStatusDate , this.PaidFees,
                    this.CreatedByUserID , this.LicenseClassID
                );

        }

        public static ClsLocalDrivingLicenseApplication Find(int ID)
        {
            int ApplicationID = -1 , ApplicantPersonID=-1 , CreatedByUserID = -1 , licenseClassID = -1;
            DateTime ApplicationDate = DateTime.Now, LastStatusDate = DateTime.Now;
            byte ApplicationStatus = 0;
            int ApplicationTypeID = -1;
            float PaidFees = 0;

            if (ClsLocalDrivingLicenseApplicationsAccess.GetLocalDrivingLicenseApplicationInfoByID
                      (                                  ID , ref ApplicationID, ref ApplicantPersonID, ref ApplicationDate,
                                        ref ApplicationTypeID, ref ApplicationStatus, ref LastStatusDate,
                               ref PaidFees, ref CreatedByUserID,  ref licenseClassID))
            {

                return new ClsLocalDrivingLicenseApplication( ApplicationID,  ApplicantPersonID,  ApplicationDate,
                                (ClsApplication.enApplicationType)ApplicationTypeID, (ClsApplication.enApplicationStatus)ApplicationStatus,  LastStatusDate,
                                PaidFees,  CreatedByUserID,  ID,  licenseClassID);
            }
            else
                return null;
        }


        public static int GetPassedTests(int LocalDrivingLicenseApplicationID)
        {
            return ClsLocalDrivingLicenseApplicationsAccess.GetPassedTests(LocalDrivingLicenseApplicationID);
        }

        public static int GitLDLAIDbyApplicationID(int ApplicationID)
        {
            return ClsLocalDrivingLicenseApplicationsAccess.GitLDLAIDbyApplicationID(ApplicationID);
        }

    }
}
