using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DVLD_BusinessLayer
{
    public class ClsInternationalLicense
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;


        public int InternationalLicenseID { get; set; }

        public int ApplicationID { get; set; }

        public int DriverID { get; set; }
        public ClsDriver Driver { get; set; }

        public int IssuedUsingLocalLicenseID { get; set; }
        public ClsLocalLicense IssuedUsingLocalLicense { get; set; }

        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }
        public int CreatedByUserID { get; set; }
        public ClsUser CreatedByUser { get; set; }


        public ClsInternationalLicense()
        {
            this.InternationalLicenseID = -1;
            this.ApplicationID = -1;
            this.DriverID = -1;
            this.IssuedUsingLocalLicenseID = -1;
            this.IssueDate = DateTime.Now;
            this.ExpirationDate = DateTime.Now.AddYears(1);
            this.IsActive = true;
            this.CreatedByUserID = -1;
            this.Driver = new ClsDriver();
            this.CreatedByUser = new ClsUser();
            this.IssuedUsingLocalLicense = new ClsLocalLicense();
            Mode = enMode.AddNew;
        }


        private ClsInternationalLicense(int InternationalLicenseID, int ApplicationID, int DriverID,
            int IssuedUsingLocalLicenseID, DateTime IssueDate, DateTime ExpirationDate,
            bool IsActive, int CreatedByUserID)
        {
            this.InternationalLicenseID = InternationalLicenseID;
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.IssuedUsingLocalLicenseID = IssuedUsingLocalLicenseID;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.IsActive = IsActive;
            this.CreatedByUserID = CreatedByUserID;
            this.Driver = ClsDriver.FindByDriverID(DriverID);
            this.CreatedByUser = ClsUser.Find(CreatedByUserID);
            this.IssuedUsingLocalLicense = ClsLocalLicense.Find(IssuedUsingLocalLicenseID);
            Mode = enMode.Update;
        }


        private bool _AddNewInternationalLicense()
        {

            this.InternationalLicenseID = ClsInternationalLicensesAccess.AddNewInternationalLicense(
                this.ApplicationID, this.DriverID, this.IssuedUsingLocalLicenseID,
                this.IssueDate, this.ExpirationDate, this.IsActive, this.CreatedByUserID);

            return (this.InternationalLicenseID != -1);
        }


        private bool _UpdateInternationalLicense()
        {

            return ClsInternationalLicensesAccess.UpdateInternationalLicense(
                this.InternationalLicenseID, this.ApplicationID, this.DriverID,
                this.IssuedUsingLocalLicenseID, this.IssueDate, this.ExpirationDate,
                this.IsActive, this.CreatedByUserID);
        }


        public static ClsInternationalLicense Find(int InternationalLicenseID)
        {
            int ApplicationID = -1, DriverID = -1, IssuedUsingLocalLicenseID = -1, CreatedByUserID = -1;
            DateTime IssueDate = DateTime.Now, ExpirationDate = DateTime.Now;
            bool IsActive = true;

            if (ClsInternationalLicensesAccess.GetInternationalLicenseInfoByID(InternationalLicenseID,
                ref ApplicationID, ref DriverID, ref IssuedUsingLocalLicenseID,
                ref IssueDate, ref ExpirationDate, ref IsActive, ref CreatedByUserID))
            {
                return new ClsInternationalLicense(InternationalLicenseID, ApplicationID, DriverID,
                    IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID);
            }
            else
                return null;
        }

        public static ClsInternationalLicense FindByLocalLicenseID(int IssuedUsingLocalLicenseID)
        {
            int ApplicationID = -1, DriverID = -1, InternationalLicenseID = -1, CreatedByUserID = -1;
            DateTime IssueDate = DateTime.Now, ExpirationDate = DateTime.Now;
            bool IsActive = true;

            if (ClsInternationalLicensesAccess.GetInternationalLicenseInfoByLocalLicenseID(IssuedUsingLocalLicenseID,
                ref ApplicationID, ref DriverID, ref InternationalLicenseID,
                ref IssueDate, ref ExpirationDate, ref IsActive, ref CreatedByUserID))
            {
                return new ClsInternationalLicense(InternationalLicenseID, ApplicationID, DriverID,
                    IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID);
            }
            else
                return null;
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewInternationalLicense())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdateInternationalLicense();
            }

            return false;
        }

        public static DataTable GetAllInternationalLicenses()
        {
            return ClsInternationalLicensesAccess.GetAllInternationalLicenses();
        }

        public static bool Delete(int InternationalLicenseID)
        {
            return ClsInternationalLicensesAccess.DeleteInternationalLicense(InternationalLicenseID);
        }


        public static bool IsExist(int InternationalLicenseID)
        {
            return ClsInternationalLicensesAccess.IsInternationalLicenseExist(InternationalLicenseID);
        }

        public static DataTable GetLicenseHistory(int DriverID)
        {
            return ClsInternationalLicensesAccess.GetLicenseHistory(DriverID);
        }
    }
}
