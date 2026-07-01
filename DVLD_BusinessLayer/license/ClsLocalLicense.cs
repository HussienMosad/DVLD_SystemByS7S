using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DVLD_BusinessLayer
{
    public class ClsLocalLicense
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int LicenseID { set; get; }

        public int ApplicationID { set; get; }
        public ClsApplication LicenseApplication { get; set; } 

        public int DriverID { set; get; }
        public ClsDriver Driver { get; set; }
        public int LicenseClassID { set; get; }
        public ClsLicenseClass LicenseClass { get; set; }
        public DateTime IssueDate { set; get; }
        public DateTime ExpirationDate { set; get; }
        public string Notes { set; get; }
        public float PaidFees { set; get; }
        public bool IsActive { set; get; }
        public enum enIssueReason { FirstTime = 1, Renew = 2, DamagedReplacement = 3, LostReplacement = 4 };

        public enIssueReason IssueReason { set; get; }
        public int CreatedByUserID { set; get; }

        
        public int PersonID { set; get; }
        public ClsPerson Person { get; set; }
        public ClsLocalLicense()
        {
            this.LicenseID = -1;
            this.ApplicationID = -1;
            this.DriverID = -1;
            this.LicenseClassID = -1;
            this.IssueDate = DateTime.Now;
            this.ExpirationDate = DateTime.Now;
            this.Notes = "";
            this.PaidFees = 0;
            this.IsActive = true;
            this.IssueReason = enIssueReason.FirstTime;
            this.CreatedByUserID = -1;
            this.LicenseClass = new ClsLicenseClass();
            this.LicenseApplication = new ClsApplication();
            this.Driver = new ClsDriver();
            this.Person = new ClsPerson();
            Mode = enMode.AddNew;
        }

        private ClsLocalLicense(int LicenseID, int ApplicationID, int DriverID, int LicenseClassID,
            DateTime IssueDate, DateTime ExpirationDate, string Notes, float PaidFees,
            bool IsActive, enIssueReason IssueReason, int CreatedByUserID)
        {
            this.LicenseID = LicenseID;
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.LicenseClassID = LicenseClassID;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.Notes = Notes;
            this.PaidFees = PaidFees;
            this.IsActive = IsActive;
            this.IssueReason = IssueReason;
            this.CreatedByUserID = CreatedByUserID;
            this.Driver = ClsDriver.FindByDriverID(DriverID);
            this.LicenseClass = ClsLicenseClass.Find(LicenseClassID);
            this.LicenseApplication = ClsApplication.FindBaseApplication(ApplicationID);
            this.Person = ClsPerson.Find(LicenseApplication.ApplicantPersonID);
            Mode = enMode.Update;
        }

        private bool _AddNewLicense()
        {

            this.LicenseID = ClsLicenseAccess.AddNewLicenseForTheFirstTime(
                this.PersonID, this.ApplicationID, this.LicenseClassID,
                this.IssueDate, this.ExpirationDate, this.Notes, this.PaidFees,
                this.IsActive, (byte)this.IssueReason, this.CreatedByUserID);

            return (this.LicenseID != -1);
        }

        private bool _UpdateLicense()
        {
            return ClsLicenseAccess.UpdateLicense(
                this.LicenseID, this.ApplicationID, this.DriverID, this.LicenseClassID,
                this.IssueDate, this.ExpirationDate, this.Notes, this.PaidFees,
                this.IsActive, (byte)this.IssueReason, this.CreatedByUserID);
        }

        public static ClsLocalLicense Find(int LicenseID)
        {
            int ApplicationID = -1, DriverID = -1, LicenseClassID = -1, CreatedByUserID = -1;
            DateTime IssueDate = DateTime.Now, ExpirationDate = DateTime.Now;
            string Notes = "";
            float PaidFees = 0;
            bool IsActive = true;
            byte IssueReason = 1;

            if (ClsLicenseAccess.GetLicenseInfoByID(LicenseID, ref ApplicationID, ref DriverID,
                ref LicenseClassID, ref IssueDate, ref ExpirationDate, ref Notes,
                ref PaidFees, ref IsActive, ref IssueReason, ref CreatedByUserID))
            {
                return new ClsLocalLicense(LicenseID, ApplicationID, DriverID, LicenseClassID,
                    IssueDate, ExpirationDate, Notes, PaidFees, IsActive,(enIssueReason) IssueReason, CreatedByUserID);
            }
            else
                return null;
        }
        
        public static ClsLocalLicense FindByApplicationID(int ApplicationID)
        {
            int LicenseID =-1 , DriverID = -1, LicenseClassID = -1, CreatedByUserID = -1;
            DateTime IssueDate = DateTime.Now, ExpirationDate = DateTime.Now;
            string Notes = "";
            float PaidFees = 0;
            bool IsActive = true;
            byte IssueReason = 1;

            if (ClsLicenseAccess.GetLicenseInfoByApplicationID(ApplicationID,ref LicenseID,  ref DriverID,
                ref LicenseClassID, ref IssueDate, ref ExpirationDate, ref Notes,
                ref PaidFees, ref IsActive, ref IssueReason, ref CreatedByUserID))
            {
                return new ClsLocalLicense(LicenseID, ApplicationID, DriverID, LicenseClassID,
                    IssueDate, ExpirationDate, Notes, PaidFees, IsActive, (enIssueReason)IssueReason, CreatedByUserID);
            }
            else
                return null;
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewLicense())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateLicense();
            }
            return false;
        }

        public static DataTable GetAllLicenses()
        {
            return ClsLicenseAccess.GetAllLicenses();
        }

        public static DataTable GetLicenseHistory(int DriverID)
        {
            return ClsLicenseAccess.GetLicenseHistory(DriverID);
        }

        public static bool DeleteLicense(int LicenseID)
        {
            return ClsLicenseAccess.DeleteLicense(LicenseID);
        }

        public static bool IsLicenseExist(int LicenseID)
        {
            return ClsLicenseAccess.IsLicenseExist(LicenseID);
        }

        public static bool IsLicenseExistsByPersonID(int PersonID, int LicenseClassID)
        {
            ClsDriver d = ClsDriver.FindByPersonID(PersonID);
            if (d != null)
            {
                return ClsLicenseAccess.IsLicenseExistsByDriverID(d.DriverID, LicenseClassID);
            }
            else
            {
                return false;
            }
        }
    }
}
