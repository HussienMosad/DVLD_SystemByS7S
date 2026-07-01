using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class ClsTestType
    {
        public enum enMode { AddNew = 0, Update = 1};
        public enMode Mode = enMode.AddNew;

        public enum enTestType { VisionTest =1 , WrittenTest = 2 , StreetTest =  3}
        public enTestType ID {  get; set; }
        public string TestTypeTitle { get; set; }
        public string TestTypeDescription { get; set; }
        public float TestTypeFees { get; set; }

        public ClsTestType()
        {
            ID = enTestType.VisionTest;
            this.TestTypeTitle = "";
            this.TestTypeDescription = "";
            this.TestTypeFees = 0;
        }

        public ClsTestType(enTestType id, string title, string description, float fees)
        {
            this.ID = id;
            this.TestTypeTitle = title;
            this.TestTypeDescription = description;
            this.TestTypeFees = fees;
        }

        private bool AddNewTestType()
        {
            this.ID = (enTestType)ClsTestTypesAccess.AddNewTestType(this.TestTypeTitle,this.TestTypeDescription,this.TestTypeFees);
            return (this.TestTypeTitle != "");
        }

        private bool UpdateTestType()
        {
            return ClsTestTypesAccess.UpdateTestType(
                (int)this.ID,
                this.TestTypeTitle,
                this.TestTypeDescription,
                this.TestTypeFees
            );
        }

        public static ClsTestType Find(enTestType ID)
        {
            string Title = "", Description = "";
            float Fees = 0;


            if (ClsTestTypesAccess.GetTestTypeInfoByID((int)ID ,ref Title,ref Description,ref Fees))
            {

                return new ClsTestType(ID, Title, Description, Fees);
            }
            else
                return null;
        }

        public static DataTable GetAllTestTypes()
        {
            return ClsTestTypesAccess.GetAllTestTypes();
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (AddNewTestType())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return UpdateTestType();

            }
            return false;

        }
    }
}
