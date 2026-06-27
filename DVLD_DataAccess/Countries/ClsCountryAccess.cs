using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public  class ClsCountryAccess
    {
        public static bool GetCountryInfoByID(int CountryID, ref string CountryName)
        {
            bool IsFound = false;

            string Query = @"SELECT *
                     FROM Countries
                     WHERE CountryID = @CountryID";

            using (SqlConnection connection =
                new SqlConnection(ClsDataAccessSettings.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.Parameters.AddWithValue("@CountryID", CountryID);

                try
                {
                    connection.Open();

                    using (SqlDataReader Reader = cmd.ExecuteReader())
                    {
                        if (Reader.Read())
                        {
                            IsFound = true;
                            CountryName = Reader["CountryName"].ToString().Trim();
                        }
                    }
                }
                catch
                {
                    IsFound = false;
                }
            }

            return IsFound;
        }

        public static bool GetCountryInfoByName(ref int CountryID, string CountryName) {
            bool IsFound = false;
            string Query = "SELECT * FROM Countries WHERE CountryName =@CountryName";

            using(SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.Parameters.AddWithValue("@CountryName", CountryName);
                try
                {
                    connection.Open();
                    using(SqlDataReader Reader = cmd.ExecuteReader())
                    {
                        if (Reader.Read())
                        {
                            IsFound = true;
                            CountryID = (int)Reader["CountryID"];
                        }
                    }
                }
                catch
                {
                    IsFound = false;
                }
            }

            return IsFound;
        }

        public static DataTable GetAllCountries()
        {
            DataTable dt = new DataTable();
            string query = "SELECT CountryID, CountryName FROM Countries";

            using (SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    using (SqlDataReader Reader = cmd.ExecuteReader())
                    {
                        if (Reader.HasRows)
                        {
                            dt.Load(Reader);
                        }
                    }


                }

                catch
                {

                }

            }
            return dt;
        }
    }
}
