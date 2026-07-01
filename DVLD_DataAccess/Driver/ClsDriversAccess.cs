using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public  class ClsDriversAccess
    {
        public static bool GetDriverInfoByID(int DriverID, ref int PersonID,
     ref int CreatedByUserID, ref DateTime CreatedDate)
        {
            bool isFound = false;

            string query = @"SELECT *
                     FROM Drivers
                     WHERE DriverID = @DriverID";

            using (SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@DriverID", DriverID);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                PersonID = (int)reader["PersonID"];
                                CreatedByUserID = (int)reader["CreatedByUserID"];
                                CreatedDate = (DateTime)reader["CreatedDate"];
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        throw;
                    }
                }
            }

            return isFound;
        }

        public static bool GetDriverInfoByPersonID(int PersonID, ref int DriverID, ref int CreatedByUserID, ref DateTime CreatedDate) {
            bool isfound = false;
            string query = "select * from Drivers WHERE PersonID = @PersonID";

            using (SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@PersonID", PersonID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isfound = true;
                                DriverID = (int)reader["DriverID"];
                                CreatedByUserID = (int)reader["CreatedByUserID"];
                                CreatedDate = (DateTime)reader["CreatedDate"];
                            }
                        }

                    }
                    catch
                    {

                    }

                }

            }

            return isfound;
        }


        public static int AddNewDriver(int PersonID, int CreatedByUserID)
        {
            int DriverID = -1;
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Drivers (PersonID, CreatedByUserID, CreatedDate)
                             VALUES (@PersonID, @CreatedByUserID, @CreatedDate);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@CreatedDate", DateTime.Now);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    DriverID = insertedID;
            }
            catch (Exception) { }
            finally { connection.Close(); }

            return DriverID;
        }

        public static bool UpdateDriver(int DriverID, int PersonID, int CreatedByUserID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);

            string query = @"UPDATE Drivers 
                             SET PersonID = @PersonID, 
                                 CreatedByUserID = @CreatedByUserID
                             WHERE DriverID = @DriverID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception) { return false; }
            finally { connection.Close(); }

            return (rowsAffected > 0);
        }

        public static DataTable GetAllDrivers()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);


            string query = @"SELECT Drivers.DriverID, Drivers.PersonID, 
                             People.NationalNo, People.FirstName + ' ' + People.SecondName + ' ' + People.ThirdName + ' ' + People.LastName AS FullName, 
                             Drivers.CreatedDate, ActiveLicense = (select count(l.LicenseID) from Licenses l where l.DriverID = Drivers.DriverID)
                             FROM Drivers 
                             INNER JOIN People ON Drivers.PersonID = People.PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows) dt.Load(reader);
                reader.Close();
            }
            catch (Exception) { }
            finally { connection.Close(); }

            return dt;
        }

        public static bool IsDriverExistByPersonID(int PersonID)
        {
            using (SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString))
            {
                string query = "SELECT 1 FROM Drivers WHERE PersonID = @PersonID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PersonID", PersonID);

                try
                {
                    connection.Open();
                    return command.ExecuteScalar() != null;
                }
                catch
                {
                    return false;
                }
            }
        }

    }
}
