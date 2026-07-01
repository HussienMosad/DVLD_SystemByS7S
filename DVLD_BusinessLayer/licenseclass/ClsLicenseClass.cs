using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class ClsLicenseClass
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int LicenseClassID { get; set; }
        public string ClassName { get; set; }
        public string ClassDescription { get; set; }
        public byte MinimumAllowedAge { get; set; }
        public byte DefaultValidityLength { get; set; }
        public float ClassFees { get; set; }


        public ClsLicenseClass()
        {
            this.LicenseClassID = -1;
            this.ClassName = "";
            this.ClassDescription = "";
            this.MinimumAllowedAge = 18;
            this.DefaultValidityLength = 10;
            this.ClassFees = 0;

            Mode = enMode.AddNew;
        }

        private ClsLicenseClass(int ID, string Name, string Description, byte MinAge, byte Validity, float Fees)
        {
            this.LicenseClassID = ID;
            this.ClassName = Name;
            this.ClassDescription = Description;
            this.MinimumAllowedAge = MinAge;
            this.DefaultValidityLength = Validity;
            this.ClassFees = Fees;

            Mode = enMode.Update;
        }


        public static ClsLicenseClass Find(int LicenseClassID)
        {
            string ClassName = "", ClassDescription = "";
            byte MinimumAllowedAge = 0, DefaultValidityLength = 0;
            float ClassFees = 0;

            if (ClsLicenseClassesAccess.GetLicenseClassInfoByID(LicenseClassID, ref ClassName, ref ClassDescription,
                                                                ref MinimumAllowedAge, ref DefaultValidityLength, ref ClassFees))
            {
                return new ClsLicenseClass(LicenseClassID, ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees);
            }
            else
            {
                return null;
            }
        }


        private bool _AddNewLicenseClass()
        {
            this.LicenseClassID = ClsLicenseClassesAccess.AddNewLicenseClass(this.ClassName, this.ClassDescription,
                                                                              this.MinimumAllowedAge, this.DefaultValidityLength, this.ClassFees);
            return (this.LicenseClassID != -1);
        }

        private bool _UpdateLicenseClass()
        {
            return ClsLicenseClassesAccess.UpdateLicenseClass(this.LicenseClassID, this.ClassName, this.ClassDescription,
                                                               this.MinimumAllowedAge, this.DefaultValidityLength, this.ClassFees);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewLicenseClass())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateLicenseClass();
            }

            return false;
        }


        public static DataTable GetAllLicenseClasses()
        {
            return ClsLicenseClassesAccess.GetAllLicenseClasses();
        }


        public static bool DeleteLicenseClass(int LicenseClassID)
        {
            return ClsLicenseClassesAccess.DeleteLicenseClass(LicenseClassID);
        }


        public static bool IsLicenseClassExist(int LicenseClassID)
        {
            return ClsLicenseClassesAccess.IsLicenseClassExist(LicenseClassID);
        }

    }
}
