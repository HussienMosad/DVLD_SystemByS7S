using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;



namespace DVLD_BusinessLayer
{
    public class ClsApplication
    {
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode Mode = enMode.AddNew;

        
        public int ApplicationID { get; set; }
        public int  ApplicantPersonID { get; set; }
        public ClsPerson Person { get; set; }
        public DateTime ApplicationDate { get; set; }
        public enum enApplicationType
        {
            NewDrivingLicense = 1, RenewDrivingLicense = 2, ReplaceLostDrivingLicense = 3,
            ReplaceDamagedDrivingLicense = 4, ReleaseDetainedDrivingLicense = 5, NewInternationalLicense = 6, RetakeTest = 7
        };

        public string GetApplicantFullName()
        {
            return this.Person.FirstName + " " + this.Person.SecondName +" "+ this.Person.ThirdName +" "+ this.Person.LastName;
        }

        public enum enApplicationStatus { New = 1, Cancelled = 2, Completed = 3 };

        public enApplicationType ApplicationTypeID { get; set; }
        public ClsApplicationType ApplicationType { get; set; }
        public enApplicationStatus ApplicationStatus { get; set; }
        public DateTime LastStatusDate { get; set; }
        public float PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public ClsUser User { get; set; }

        public ClsApplication()
        {
            ApplicationID = -1;
            Person = new ClsPerson();
            ApplicationType = new ClsApplicationType();
            ApplicantPersonID = -1;
            ApplicationDate = DateTime.Today;
            ApplicationTypeID = enApplicationType.NewDrivingLicense;
            ApplicationStatus = 0;
            LastStatusDate = DateTime.Today;
            PaidFees = 0;
            CreatedByUserID = -1;
            User = new ClsUser();
            Mode = enMode.AddNew;
        }

        public ClsApplication(int ApplicationID, int ApplicantPersonID, DateTime ApplicationDate,
                               enApplicationType ApplicationTypeID , enApplicationStatus ApplicationStatus , DateTime LastStatusDate,
                               float PaidFees , int CreatedByUserID)
        {

            this.ApplicationID = ApplicationID;
            this.ApplicantPersonID = ApplicantPersonID;
            this.Person = ClsPerson.Find(this.ApplicantPersonID);
            this.ApplicationDate = ApplicationDate;
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationType = ClsApplicationType.Find((int)this.ApplicationTypeID);
            this.User = ClsUser.Find(CreatedByUserID);
            this.ApplicationStatus = ApplicationStatus;
            this.LastStatusDate = LastStatusDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            Mode = enMode.Update;
        }

        public static bool ThereIsAnActiveApplicationForLicenseClass(int PersonID,int ApplicationTypeID, int ClassID)
        {
            return ClsApplicationsAccess.ThereIsAnActiveApplicationForLicenseClass(PersonID,ApplicationTypeID ,ClassID);
        }

        public static bool ThereIsAnActiveApplication(int PersonID, int ApplicationTypeID)
        {
            return ClsApplicationsAccess.ThereIsAnActiveApplication(PersonID, ApplicationTypeID);
        }

        private bool AddNewApplication()
        {
            
            this.ApplicationID =ClsApplicationsAccess.AddNewApplication(
                this.ApplicantPersonID, this.ApplicationDate, (int)this.ApplicationTypeID,
                (int)this.ApplicationStatus, this.LastStatusDate, this.PaidFees, this.CreatedByUserID);

            return (this.ApplicationID != -1);
        }

        private bool UpdateApplication()
        {
            
            return ClsApplicationsAccess.UpdateApplication(
                this.ApplicationID, this.ApplicantPersonID, this.ApplicationDate,
                (int)this.ApplicationTypeID, (int)this.ApplicationStatus, this.LastStatusDate,
                this.PaidFees, this.CreatedByUserID);
        }

        public static ClsApplication FindBaseApplication(int ApplicationID)
        {
            int ApplicantPersonID = -1, ApplicationTypeID = -1, CreatedByUserID = -1;
            DateTime ApplicationDate = DateTime.Now, LastStatusDate = DateTime.Now;
            float PaidFees = 0;
            byte ApplicationStatus = 1;

            if (ClsApplicationsAccess.GetApplicationInfoByID(ApplicationID,
                ref ApplicantPersonID, ref ApplicationDate, ref ApplicationTypeID,
                ref ApplicationStatus, ref LastStatusDate, ref PaidFees, ref CreatedByUserID))
            {
                return new ClsApplication(ApplicationID, ApplicantPersonID, ApplicationDate,
                   (enApplicationType) ApplicationTypeID,(enApplicationStatus) ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID);
            }
            else
                return null;
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (AddNewApplication())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return UpdateApplication();
            }
            return false;
        }

        public static DataTable GetAllApplications()
        {
            return ClsApplicationsAccess.GetAllApplications();
        }

        public static bool DeleteApplication(int ApplicationID)
        {
            return ClsApplicationsAccess.DeleteApplication(ApplicationID);
        }

        public static bool IsApplicationExist(int ApplicationID)
        {
            return ClsApplicationsAccess.IsApplicationExist(ApplicationID);
        }

        public static bool UpdateStatus(int ApplicationID ,int Status)
        {
            return ClsApplicationsAccess.UpdateStatus(ApplicationID, Status);
        }

        public bool setCancel(int ApplicationID)
        {
            return ClsApplicationsAccess.UpdateStatus(ApplicationID, 2);
        }

        public bool setCompleted(int ApplicationID)
        {
            return ClsApplicationsAccess.UpdateStatus(ApplicationID, 3);
        }

    }
}
