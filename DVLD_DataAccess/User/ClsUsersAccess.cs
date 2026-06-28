using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public  class ClsUsersAccess
    {
        public static bool GetUserByID(int UserID, ref int PersonID, ref string UserName, ref string Password, ref bool IsActive)
        {
            bool IsFound = false;
            string query = "SELECT * FROM Users WHERE UserID =@UserID";

            using(SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@UserID", UserID);
                try
                {
                    connection.Open();
                        using(SqlDataReader Reader = cmd.ExecuteReader())
                    {
                        if (Reader.Read())
                        {
                            IsFound = true;
                            PersonID = (Reader["PersonID"] != DBNull.Value) ?   (int)Reader["PersonID"] : -1;
                            UserName  = (Reader["UserName"] != DBNull.Value)   ?  ( (string)Reader["UserName"]).Trim() : "";
                            Password = (Reader["Password"] != DBNull.Value) ?   ((string)Reader["Password"]).Trim() : "";
                            IsActive = (Reader["IsActive"] != DBNull.Value) ?   (bool)Reader["IsActive"] : false;
                        }
                    }

                }
                catch(Exception ex)
                {
                    IsFound = false;
                    ClsLogger.LogError($"Failed to fetch data for UserID: {UserID}", ex);
                }
            }

            return IsFound;
        }

        public static bool GetHashedPassword(string UserName, ref string HashedPassword)
        {
            bool IsFound = false;
            string query = "SELECT * FROM Users WHERE UserName =@UserName";

            using (SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@UserName", UserName);
                try
                {
                    connection.Open();
                    using (SqlDataReader Reader = cmd.ExecuteReader())
                    {
                        if (Reader.Read())
                        {
                            IsFound = true;
                            HashedPassword = (Reader["Password"] != DBNull.Value) ? ((string)Reader["Password"]).Trim() : "";
                        }
                    }

                }
                catch (Exception ex)
                {
                    IsFound = false;
                    ClsLogger.LogError($"Failed to fetch data for UserName: {UserName}", ex);
                }
            }

            return IsFound = true;
        }

        public static bool GetUserByName(string UserName, ref int UserID, ref int PersonID, ref string Password, ref bool IsActive)
        {
            bool IsFound = false;
            string query = "SELECT * FROM Users WHERE UserName =@UserName";

            using (SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@UserName", UserName);
                try
                {
                    connection.Open();
                    using (SqlDataReader Reader = cmd.ExecuteReader())
                    {
                        if (Reader.Read())
                        {
                            IsFound = true;
                            PersonID = (Reader["PersonID"] != DBNull.Value) ? (int)Reader["PersonID"] : -1;
                            UserID = (Reader["UserID"] != DBNull.Value) ? (int)Reader["UserID"] : -1;
                            Password = (Reader["Password"] != DBNull.Value) ? ((string)Reader["Password"]).Trim() : "";
                            IsActive = (Reader["IsActive"] != DBNull.Value) ? (bool)Reader["IsActive"] : false;
                        }
                    }

                }
                catch (Exception ex)
                {
                    IsFound = false;
                    ClsLogger.LogError($"Failed to fetch data for UserName: {UserName}", ex);
                }
            }

            return IsFound;
        }

        public static bool GetUserByPersonID(int PersonID, ref int UserID, ref string UserName, ref string Password, ref bool IsActive)
        {
            bool IsFound = false;
            string query = "SELECT * FROM Users WHERE PersonID =@PersonID";

            using (SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@PersonID", PersonID);
                try
                {
                    connection.Open();
                    using (SqlDataReader Reader = cmd.ExecuteReader())
                    {
                        if (Reader.Read())
                        {
                            IsFound = true;
                            UserName = (Reader["UserName"] != DBNull.Value) ? ((string)Reader["UserName"]).Trim() : "";
                            UserID = (Reader["UserID"] != DBNull.Value) ? (int)Reader["UserID"] : -1;
                            Password = (Reader["Password"] != DBNull.Value) ? ((string)Reader["Password"]).Trim() : "";
                            IsActive = (Reader["IsActive"] != DBNull.Value) ? (bool)Reader["IsActive"] : false;
                        }
                    }

                }
                catch (Exception ex)
                {
                    IsFound = false;
                    ClsLogger.LogError($"Failed to fetch data for PersonID: {PersonID}", ex);
                }
            }

            return IsFound = true;
        }

        public static int AddNewUser(int PersonID, string UserName, string Password, bool IsActive)
        {
            int ID = -1; 


            string query = @"
            INSERT INTO Users (PersonID, UserName, Password, IsActive)
            VALUES (@PersonID, @UserName, @Password, @IsActive);
            SELECT SCOPE_IDENTITY();";
            
            using (SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString))
            {
                

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PersonID", PersonID);
                command.Parameters.AddWithValue("@UserName", UserName ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Password", Password ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@IsActive", IsActive);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString() , out int InsertedID))
                    {
                        ID = InsertedID;
                    }
                  }
                catch(Exception ex)
                {
                    ClsLogger.LogError($"Failed to Add User With PersonID : {PersonID}");
                }

            }

            return ID; 
        }

        public static bool UpdateUser(int UserID, int PersonID, string UserName, string Password, bool IsActive)
        {
            int roweffected = 0;
            string query =
    @"UPDATE Users  SET PersonID = @PersonID, UserName = @UserName, Password = @Password, IsActive = @IsActive where UserID = @UserID";
            using(SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@PersonID", PersonID);
                cmd.Parameters.AddWithValue("@UserID", UserID);
                cmd.Parameters.AddWithValue("@Password", Password);
                cmd.Parameters.AddWithValue("@IsActive", IsActive);
                try
                {
                    connection.Open();
                    roweffected = cmd.ExecuteNonQuery();
                }

                catch(Exception ex)
                {
                    ClsLogger.LogError($"Failed To Update User With UserID : {UserID}", ex);
                    return false;
                }


            }


            return roweffected > 0;
        }

        public static DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();
            string query = @"SELECT    Users.UserID, Users.PersonID, FullName = People.FirstName + ' ' + People.SecondName + ' ' + 
                                       People.ThirdName + ' ' + People.LastName , Users.UserName, Users.IsActive
                             FROM      Users INNER JOIN
                                       People ON Users.PersonID = People.PersonID";
          

            using(SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            dt.Load(reader);
                        }
                    }
                }

                catch(Exception ex)
                {
                    ClsLogger.LogError("Failed to retrieve all users list", ex);
                }
            }
            return dt;
        }

        public static bool DeleteUser(int UserID)
        {
            int roweffected = 0;
            string query = "DELETE FROM Users WHERE UserID=@UserID";
            using(SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@UserID", UserID);
                try
                {
                    connection.Open();
                    roweffected = cmd.ExecuteNonQuery();

                }
                catch(Exception ex)
                {
                    ClsLogger.LogError($"Failed To Delete User With ID : {UserID}", ex);
                }
            }
            return roweffected > 0;
        }

        public static bool IsUserExistByPersonID(int PersonID)
        {
           
            string query = "SELECT 1 FROM Users where PersonID = @PersonID";
            using(SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@PersonID", PersonID);
                try
                {
                    connection.Open();

                    return cmd.ExecuteScalar() != null;
                }
                catch(Exception ex)
                {
                    ClsLogger.LogError($"Error verifying user existence by PersonID: {PersonID}", ex);
                }
            }

            return false;
        }

        public static bool IsUserExist(int UserID)
        {
            string query = "SELECT 1 FROM Users where UserID = @UserID";
            using (SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@UserID", UserID);
                    try
                    {
                        connection.Open();

                        return cmd.ExecuteScalar() != null;
                    }
                    catch (Exception ex)
                    {
                        ClsLogger.LogError($"Error verifying user existence by UserID: {UserID}", ex);
                    }
                }
            }

            return false;

        }

        public static bool IsUserExist(string UserName)
        {
            string query = "SELECT 1 FROM Users WHERE UserName = @UserName";

            using (SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@UserName", UserName);

                    try
                    {
                        connection.Open();
                        return cmd.ExecuteScalar() != null;
                    }
                    catch (Exception ex)
                    {
                        ClsLogger.LogError($"Error verifying user existence by UserName: {UserName}", ex);
                    }
                }
            }

            return false;
        }

        public static bool IsUserExist(string UserName, string Password)
        {
            string query = "SELECT 1 FROM Users WHERE UserName = @UserName AND Password = @Password";

            using (SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@UserName", UserName);
                    cmd.Parameters.AddWithValue("@Password", Password);

                    try
                    {
                        connection.Open();
                        return cmd.ExecuteScalar() != null;
                    }
                    catch (Exception ex)
                    {
                        ClsLogger.LogError($"Error verifying credentials existence for UserName: {UserName}", ex);
                    }
                }
            }

            return false;
        }
        public static bool IsUserActive(string UserName)
        {
            string query = "SELECT 1 FROM Users where UserName =@UserName And IsActive = 1";
            using (SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@UserName", UserName);

                    try
                    {
                        connection.Open();
                        return cmd.ExecuteScalar() != null;
                    }
                    catch(Exception ex)
                    {
                        ClsLogger.LogError($"Error checking activity status for UserName: {UserName}", ex);
                    }
                }


            }
            return false;
        }

        public static bool ChangePassword(int UserID, string Password)
        {
            int roweffected = 0;
            string query = "UPDATE Users SET Password =@Password twhere UserID =@UserID";
            using (SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString))
            {
                try
                {

                }

                catch(Exception ex)
                {
                    ClsLogger.LogError($"failed To ChangePassword For User  With User ID : {UserID}", ex);
                }
            }



                return roweffected > 0;
        }

    }
}
