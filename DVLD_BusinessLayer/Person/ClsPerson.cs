using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataAccess;
namespace DVLD_BusinessLayer
{
    public class ClsPerson
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int ID { set; get; }
        public string NationalNo { set; get; }
        public string FirstName { set; get; }
        public string SecondName { set; get; }
        public string ThirdName { set; get; }
        public string Gender { set; get; }
        public string LastName { set; get; }
        public string Email { set; get; }
        public string Phone { set; get; }
        public string Address { set; get; }
        public DateTime DateOfBirth { set; get; }

        public string ImagePath { set; get; }

        public int CountryID { set; get; }

        public ClsPerson()

        {
            this.ID = -1;
            this.NationalNo = "";
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.Gender = "";
            this.Email = "";
            this.Phone = "";
            this.Address = "";
            this.DateOfBirth = DateTime.Now;
            this.CountryID = -1;
            this.ImagePath = "";

            Mode = enMode.AddNew;

        }

        public ClsPerson(ClsPerson Person)
        {
            this.Mode = Person.Mode;
            this.ID = Person.ID;
            this.NationalNo = Person.NationalNo;
            this.FirstName = Person.FirstName;
            this.SecondName = Person.SecondName;
            this.ThirdName = Person.ThirdName;
            this.Gender = Person.Gender;
            this.LastName = Person.LastName;
            this.Email = Person.Email;
            this.Phone = Person.Phone;
            this.Address = Person.Address;
            this.DateOfBirth = Person.DateOfBirth;
            this.ImagePath = Person.ImagePath;
            this.CountryID = Person.CountryID;
        }

        private ClsPerson(int ID, string NationalNo, string FirstName, string SecondName, string ThirdName,
            string LastName, string Gender, string Email, string Phone, string Address, DateTime DateOfBirth,
            int CountryID, string ImagePath)
        {
            this.ID = ID;
            this.NationalNo = NationalNo;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.Gender = Gender;
            this.Email = Email;
            this.Phone = Phone;
            this.Address = Address;
            this.DateOfBirth = DateOfBirth;
            this.CountryID = CountryID;
            this.ImagePath = ImagePath;

            Mode = enMode.Update;
        }

        private bool _AddNewPerson() {
            this.ID = ClsPeopleAccess.AddNewPerson(this.NationalNo, this.FirstName, this.SecondName,
                                                               this.ThirdName, this.LastName, this.Gender,
                                                               this.Email, this.Phone, this.Address,
                                                               this.DateOfBirth, this.CountryID, this.ImagePath);

            return ID != -1;
        }

        private bool _UpdatePerson()
        {
            return ClsPeopleAccess.UpdatePerson(this.ID, this.NationalNo, this.FirstName,
                                                 this.SecondName, this.ThirdName, this.LastName,
                                                 this.Gender, this.Email, this.Phone,
                                                 this.Address, this.DateOfBirth, this.CountryID,
                                                 this.ImagePath);
        }

        public static bool DeletePerson(int PersonID)
        {
            return ClsPeopleAccess.DeletePerson(PersonID);
        }

        public static DataTable GetAllPeople()
        {
            return ClsPeopleAccess.GetAllPeople();
        }

        public bool Save()
        {


            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPerson())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdatePerson();

            }
            return false;
        }

        public static ClsPerson Find(int ID)
        {


            string NationalNo = "", FirstName = "", SecondName = "", ThirdName = "", LastName = "", Gender = "", Email = "", Phone = "", Address = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now;
            int CountryID = -1;

            if (ClsPeopleAccess.GetPersonInfoByID(ID, ref NationalNo, ref FirstName, ref SecondName,
                            ref ThirdName , ref LastName , ref Gender , ref Email , ref Phone , ref Address,
                            ref DateOfBirth , ref CountryID , ref ImagePath))
                {
                return new ClsPerson(ID, NationalNo, FirstName,
                                    SecondName, ThirdName, LastName,
                                    Gender, Email, Phone,
                                    Address, DateOfBirth, CountryID,
                                   ImagePath);
            }
            else
                return null;

        }

        public static ClsPerson Find(string NationalNo)
        {

            int ID = -1; string FirstName = "", SecondName = "", ThirdName = "", LastName = "", Gender = "", Email = "", Phone = "", Address = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now;
            int CountryID = -1;

            if (ClsPeopleAccess.GetPersonInfoByNationalNO(NationalNo, ref ID, ref FirstName,
                                                   ref SecondName, ref ThirdName, ref LastName,
                                                   ref Gender, ref Email, ref Phone,
                                                   ref Address, ref DateOfBirth, ref CountryID,
                                                   ref ImagePath))
            {

                return new ClsPerson(ID, NationalNo, FirstName,
                                     SecondName, ThirdName, LastName,
                                     Gender, Email, Phone,
                                     Address, DateOfBirth, CountryID,
                                     ImagePath);
            }
            else
                return null;
        }

        public static bool isPersonExist(int PersonID)
        {
            return ClsPeopleAccess.IsPersonExist(PersonID);
        }

    }
}
