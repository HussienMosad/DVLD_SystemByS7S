using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataAccess;

namespace DVLD_BusinessLayer
{
    public class ClsCountry
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public ClsCountry()
        {
            this.ID = -1;
            this.Name = "";
        }

        private ClsCountry(int ID , string CountryName)
        {
            this.Name = CountryName;
            this.ID = ID;
        }

        public static ClsCountry Find(int ID)
        {
            string CountryName = "";
            if (ClsCountryAccess.GetCountryInfoByID(ID, ref CountryName))
                return new ClsCountry(ID, CountryName);
            else
                return null;
        }

        public static ClsCountry Find(string CountryName)
        {
            int ID = -1;
            if (ClsCountryAccess.GetCountryInfoByName(ref ID, CountryName))
                return new ClsCountry(ID, CountryName);
            else
                return null;
        }

        public static DataTable GetAllCountries()
        {
            return ClsCountryAccess.GetAllCountries();
        }
    }
}
