using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class ClsApplicationType
    {
        public enum enMode { AddNew , Update};
        enMode Mode = enMode.AddNew;
        public int ID { get; set; }
        public string Title { get; set; }
        public float Fees { get; set; }
        public ClsApplicationType()
        {
            this.ID = -1;
            this.Title = "";
            this.Fees = 0;
            Mode = enMode.AddNew;

        }

        public ClsApplicationType(ClsApplicationType appType)
        {
            this.ID = appType.ID;
            this.Title = appType.Title;
            this.Fees = appType.Fees;
            Mode = enMode.Update;
        }

        public ClsApplicationType(int ID, string Title, float Fees)
        {
            this.ID = ID;
            this.Title = Title;
            this.Fees = Fees;
        }

        public static ClsApplicationType Find(int ID)
        {
            string Title = "";
            float Fees = 0;


            if (ClsApplicationTypesAccess.GetApplicationTypeInfoByID(ID, ref Title, ref Fees))
            {

                return new ClsApplicationType(ID, Title, Fees);
            }
            else
                return null;
        }

        public bool UpdateApplicationType()
        {

            return ClsApplicationTypesAccess.UpdateApplicationType(
                        this.ID,
                        this.Title,
                        this.Fees
                   );
        }

        private bool AddNewApplicationType()
        {
            this.ID = ClsApplicationTypesAccess.AddNewApplicationType(this.Title, this.Fees);
            return (this.ID != -1);
        }

        public static DataTable GetAllApplicationTypes()
        {
            return ClsApplicationTypesAccess.GetAllApplicationTypes();
        }


        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (AddNewApplicationType())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return UpdateApplicationType();
            }
            return false;
        }

      
        public static bool IsApplicationTypeExist(int ID)
        {
            return ClsApplicationTypesAccess.IsApplicationTypeExist(ID);
        }

    }
}