using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class ClsDriver
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int DriverID { set; get; }
        public int PersonID { set; get; }
        public ClsPerson Person { set; get; }
        public int CreatedByUserID { set; get; }
        public DateTime CreatedDate { set; get; }




        public ClsDriver()
        {
            this.DriverID = -1;
            this.PersonID = -1;
            this.CreatedByUserID = -1;
            this.CreatedDate = DateTime.Now;
            this.Person = new ClsPerson();
            Mode = enMode.AddNew;
        }

        private ClsDriver(int DriverID, int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {
            this.DriverID = DriverID;
            this.PersonID = PersonID;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedDate = CreatedDate;


            this.Person = ClsPerson.Find(PersonID);

            Mode = enMode.Update;
        }

        private bool _AddNewDriver()
        {
            this.DriverID = ClsDriversAccess.AddNewDriver(this.PersonID, this.CreatedByUserID);
            return (this.DriverID != -1);
        }

        private bool _UpdateDriver()
        {
            return ClsDriversAccess.UpdateDriver(this.DriverID, this.PersonID, this.CreatedByUserID);
        }

        public static ClsDriver FindByDriverID(int DriverID)
        {
            int PersonID = -1, CreatedByUserID = -1;
            DateTime CreatedDate = DateTime.Now;

            if (ClsDriversAccess.GetDriverInfoByID(DriverID, ref PersonID, ref CreatedByUserID, ref CreatedDate))
            {
                return new ClsDriver(DriverID, PersonID, CreatedByUserID, CreatedDate);
            }
            else
                return null;
        }

        public static ClsDriver FindByPersonID(int PersonID)
        {
            int DriverID = -1, CreatedByUserID = -1;
            DateTime CreatedDate = DateTime.Now;

            if (ClsDriversAccess.GetDriverInfoByPersonID(PersonID, ref DriverID, ref CreatedByUserID, ref CreatedDate))
            {
                return new ClsDriver(DriverID, PersonID, CreatedByUserID, CreatedDate);
            }
            else
                return null;
        }



        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewDriver())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateDriver();
            }
            return false;
        }

        public static DataTable GetAllDrivers()
        {
            return ClsDriversAccess.GetAllDrivers();
        }

        public static bool IsDriverExistByPersonID(int PersonID)
        {
            return ClsDriversAccess.IsDriverExistByPersonID(PersonID);
        }
    }
}
