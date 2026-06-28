using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public  class ClsApplicationTypesAccess
    {
        public static bool GetApplicationTypeInfoByID(int ApplicationTypeID , ref string ApplicationTypeTitle , ref float ApplicationTypeFees)
        {
            bool IsFound = false;
            string query = "SELECT * FROM ApplicationTypes where ApplicationTypeID =@ApplicationTypeID";

            using (SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString))
            {
                using(SqlCommand cmd = new SqlCommand(query , connection))
                {
                    cmd.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
                    try
                    {
                        connection.Open();
                        using(SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;
                                ApplicationTypeTitle = ((string)reader["ApplicationTypeTitle"]).Trim();
                                ApplicationTypeFees = Convert.ToSingle(reader["ApplicationTypeFees"]);

                            }
                        }
                    }

                    catch(Exception ex)
                    {
                        ClsLogger.LogError($"Failed to retrieve application type info for ID: {ApplicationTypeID}", ex);
                    }
                }
            }

            return IsFound;
        }
        public static DataTable GetAllApplicationTypes()
        {
            string query = @"SELECT ApplicationTypeID, ApplicationTypeTitle, ApplicationTypeFees
                             FROM ApplicationTypes
                             ORDER BY ApplicationTypeTitle";

            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                
                    try
                    {
                        connection.Open();
                        using(SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                                dt.Load(reader);
                        }
                    }

                    catch (Exception ex)
                    {
                        dt = null;
                        ClsLogger.LogError("Failed to retrieve all application types table", ex);
                    }
                }
            }



            return dt;

        }
            public static bool UpdateApplicationType(int ApplicationTypeID,  string ApplicationTypeTitle,float ApplicationTypeFees)
        {
            int roweffected = 0;

            string query = @"UPDATE ApplicationTypes
                             SET ApplicationTypeTitle = @ApplicationTypeTitle,
                                 ApplicationTypeFees = @ApplicationTypeFees
                             WHERE ApplicationTypeID = @ApplicationTypeID";
            using (SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
                    cmd.Parameters.AddWithValue("@ApplicationTypeTitle", ApplicationTypeTitle);
                    cmd.Parameters.AddWithValue("@ApplicationTypeFees", ApplicationTypeFees);

                    try
                    {
                        connection.Open();
                        roweffected = cmd.ExecuteNonQuery();
                    }
                    catch(Exception ex)
                    {
                        ClsLogger.LogError($"Failed to update application type for ID: {ApplicationTypeID}", ex);
                        return false;
                    }
                }

            }

            return roweffected > 0;
        }
            public static bool IsApplicationTypeExist(int ApplicationTypeID) 
        {
            string query = "select 1 from ApplicationTypes where ApplicationTypeID =@ApplicationTypeID ";
            using (SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
                    try
                    {
                        connection.Open();
                        return cmd.ExecuteScalar() != null;
                    }
                    catch (Exception ex)
                    {
                        ClsLogger.LogError($"Error checking existence of application type ID: {ApplicationTypeID}", ex);
                    }
                }
            }

            return false;

        }
    }
}
