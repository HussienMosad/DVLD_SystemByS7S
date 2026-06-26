using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    namespace DVLD_DataAccess
    {
        public static class ClsDataAccessHelper
        {
            public static object HandleDBNull(object value)
            {
                return value is string str && string.IsNullOrWhiteSpace(str)
                    ? DBNull.Value
                    : value ?? DBNull.Value;
            }

            public static string HandleDBNullToString(object value)
            {
                if (value == DBNull.Value)
                    return null;

                return value.ToString();
            }
        public static char ConvertGenderToDB(string gender)
        {
            return gender.ToUpper() == "FEMALE" ? 'F' : 'M';
        }

        public static string ConvertGenderFromDB(object value)
        {
            return value.ToString().ToUpper() == "F"
                ? "FEMALE"
                : "MALE";
        }

    }
    }

