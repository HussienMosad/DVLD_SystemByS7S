
using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer { 
    public class ClsDetainedLicense
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int DetainID { get; set; }
        public int DetainedLicenseID { get; set; }
        public ClsLocalLicense DetainedLicense { get; set; }
        public DateTime DetainDate { get; set; }
        public float FineFees { get; set; }
        public int CreatedByUserID { get; set; }
        
        public bool IsReleased { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int ReleasedByUserID { get; set; }
        public int ReleaseApplicationID { get; set; }
        public ClsApplication Application { get; set; }

        public ClsDetainedLicense()
        {
            this.DetainID = -1;
            this.DetainedLicenseID = -1;
            this.DetainDate = DateTime.Now;
            this.FineFees = 0;
            this.CreatedByUserID = -1;
            this.IsReleased = false;
            this.ReleaseDate = DateTime.MinValue;
            this.ReleasedByUserID = -1;
            this.ReleaseApplicationID = -1;
            this.DetainedLicense = new ClsLocalLicense();
            this.Application = new ClsApplication();
            Mode = enMode.AddNew;
        }

        
        private ClsDetainedLicense(int DetainID, int LicenseID, DateTime DetainDate,
            float FineFees, int CreatedByUserID, bool IsReleased, DateTime ReleaseDate,
            int ReleasedByUserID, int ReleaseApplicationID)
        {
            this.DetainID = DetainID;
            this.DetainedLicenseID = LicenseID;
            this.DetainDate = DetainDate;
            this.FineFees = FineFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsReleased = IsReleased;
            this.ReleaseDate = ReleaseDate;
            this.ReleasedByUserID = ReleasedByUserID;
            this.ReleaseApplicationID = ReleaseApplicationID;
            this.DetainedLicense = ClsLocalLicense.Find(LicenseID);
            this.Application = ClsApplication.FindBaseApplication(ReleaseApplicationID);
            Mode = enMode.Update;
        }

        
        public static ClsDetainedLicense Find(int DetainID)
        {
            int LicenseID = -1, CreatedByUserID = -1, ReleasedByUserID = -1, ReleaseApplicationID = -1;
            DateTime DetainDate = DateTime.Now, ReleaseDate = DateTime.MinValue;
            float FineFees = 0;
            bool IsReleased = false;

            if (ClsDetainedLicensesAccess.GetDetainedLicenseInfoByID(DetainID, ref LicenseID, ref DetainDate,
                ref FineFees, ref CreatedByUserID, ref IsReleased, ref ReleaseDate,
                ref ReleasedByUserID, ref ReleaseApplicationID))
            {
                return new ClsDetainedLicense(DetainID, LicenseID, DetainDate, FineFees,
                    CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);
            }
            else
                return null;
        }

        public static ClsDetainedLicense FindByLicenseID(int LicenseID)
        {
            int DetainID = -1, CreatedByUserID = -1, ReleasedByUserID = -1, ReleaseApplicationID = -1;
            DateTime DetainDate = DateTime.Now, ReleaseDate = DateTime.MinValue;
            float FineFees = 0;
            bool IsReleased = false;

            if (ClsDetainedLicensesAccess.GetDetainedLicenseInfoByLicenseID(LicenseID,ref DetainID , ref DetainDate,
                ref FineFees, ref CreatedByUserID, ref IsReleased, ref ReleaseDate,
                ref ReleasedByUserID, ref ReleaseApplicationID))
            {
                return new ClsDetainedLicense(DetainID, LicenseID, DetainDate, FineFees,
                    CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);
            }
            else
                return null;
        }


        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewDetainedLicense())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                 
                    return _ReleaseDetainedLicense();
            }

            return false;
        }

        private bool _AddNewDetainedLicense()
        {
            this.DetainID = ClsDetainedLicensesAccess.AddNewDetainedLicense(this.DetainedLicenseID,
                this.DetainDate, this.FineFees, this.CreatedByUserID);

            return (this.DetainID != -1);
        }

        private bool _ReleaseDetainedLicense()
        {
            return ClsDetainedLicensesAccess.ReleaseDetainedLicense(this.DetainID,
                this.ReleasedByUserID, this.ReleaseApplicationID);
        }

        
        public static DataTable GetAllDetainedLicenses()
        {
            return ClsDetainedLicensesAccess.GetAllDetainedLicenses();
        }

        
        public static bool IsLicenseDetained(int LicenseID)
        {
            return ClsDetainedLicensesAccess.IsLicenseDetained(LicenseID);
        }
    }
}
