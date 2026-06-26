using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class ClsPeopleAccess
    {
        public static bool GetPersonInfoByID(
                                                                    int PersonID,
                                                                    ref string NationalNo,
                                                                    ref string FirstName,
                                                                    ref string SecondName,
                                                                    ref string ThirdName,
                                                                    ref string LastName,
                                                                    ref string Gender,
                                                                    ref string Email,
                                                                    ref string Phone,
                                                                    ref string Address,
                                                                    ref DateTime DateOfBirth,
                                                                    ref int CountryID,
                                                                    ref string ImagePath)
        {
            bool isFound = false;

            string query =
            "SELECT * FROM People WHERE PersonID = @PersonID";
            using (SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@PersonID", PersonID);


                try
                {
                    connection.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        if (reader.Read())
                        {
                            isFound = true;
                            NationalNo = ((string)reader["NationalNo"]).Trim();
                            FirstName = ((string)reader["FirstName"]).Trim();
                            SecondName = ((string)reader["SecondName"]).Trim();
                            ThirdName = ((string)reader["ThirdName"]).Trim();
                            LastName = ((string)reader["LastName"]).Trim();

                            Gender = ClsDataAccessHelper.ConvertGenderFromDB(reader["Gender"]);

                            ImagePath = ClsDataAccessHelper.HandleDBNullToString(reader["ImagePath"]);
                            Email = ClsDataAccessHelper.HandleDBNullToString(reader["Email"]);
                            Phone = ((string)reader["Phone"]).Trim();
                            Address = ((string)reader["Address"]).Trim();
                            DateOfBirth = (DateTime)reader["DateOfBirth"];
                            CountryID = (int)reader["CountryID"];

                        }
                        else
                            isFound = false;
                    }
                }
                catch
                {
                    isFound = false;
                }
               
            }
            return isFound;
        }


        public static bool GetPersonInfoByNationalNO(string NationalNo, ref int PersonID, ref string FirstName,
                                             ref string SecondName, ref string ThirdName, ref string LastName,
                                             ref string Gender, ref string Email, ref string Phone,
                                             ref string Address, ref DateTime DateOfBirth, ref int CountryID,
                                             ref string ImagePath)
        {
            bool isFound = false;

            string query =
            "SELECT * FROM People WHERE NationalNo = @NationalNo";
            using (SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@NationalNo", NationalNo);


                try
                {
                    connection.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        if (reader.Read())
                        {
                            isFound = true;
                            PersonID = ((int)reader["PersonID"]);
                            FirstName = ((string)reader["FirstName"]).Trim();
                            SecondName = ((string)reader["SecondName"]).Trim();
                            ThirdName = ((string)reader["ThirdName"]).Trim();
                            LastName = ((string)reader["LastName"]).Trim();

                            Gender = ClsDataAccessHelper.ConvertGenderFromDB(reader["Gender"]);

                            ImagePath = ClsDataAccessHelper.HandleDBNullToString(reader["ImagePath"]);
                            Email = ClsDataAccessHelper.HandleDBNullToString(reader["Email"]);
                            Phone = ((string)reader["Phone"]).Trim();
                            Address = ((string)reader["Address"]).Trim();
                            DateOfBirth = (DateTime)reader["DateOfBirth"];
                            CountryID = (int)reader["CountryID"];

                        }
                        else
                            isFound = false;
                    }
                }
                catch
                {
                    isFound = false;
                }

            }
            return isFound;

        }



        public static int AddNewPerson(string NationalNo, string FirstName, string SecondName,
                                        string ThirdName, string LastName, string Gender,
                                        string Email, string Phone, string Address,
                                        DateTime DateOfBirth, int CountryID, string ImagePath)
        {
            int ID = -1;

            string query = @"INSERT INTO People (NationalNo,FirstName,SecondName,ThirdName,LastName,Gender, Email, Phone, Address,DateOfBirth, CountryID,ImagePath)
                             VALUES (@NationalNo,@FirstName,@SecondName,@ThirdName ,@LastName,@Gender, @Email, @Phone, @Address,@DateOfBirth, @CountryID,@ImagePath);
                             SELECT SCOPE_IDENTITY();";
            using (SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString))
            {


                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@NationalNo", NationalNo);
                cmd.Parameters.AddWithValue("@FirstName", FirstName);
                cmd.Parameters.AddWithValue("@SecondName", SecondName);
                cmd.Parameters.AddWithValue("@ThirdName", ThirdName);
                cmd.Parameters.AddWithValue("@LastName", LastName);
                cmd.Parameters.AddWithValue("@Phone", Phone);

                cmd.Parameters.AddWithValue("@Email", ClsDataAccessHelper.HandleDBNull(Email));

                cmd.Parameters.AddWithValue("@ImagePath",
                     ClsDataAccessHelper.HandleDBNull(ImagePath));

                cmd.Parameters.AddWithValue("@Gender", ClsDataAccessHelper.ConvertGenderToDB(Gender));

                cmd.Parameters.AddWithValue("@Address", Address);
                cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                cmd.Parameters.AddWithValue("@CountryID", CountryID);


                try
                {
                    connection.Open();

                    object result = cmd.ExecuteScalar();


                    if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        ID = insertedID;
                }
                catch
                {

                }

                     }
            return ID;
        }

        public static bool UpdatePerson(
                                                        int PersonID,
                                                        string NationalNo,
                                                        string FirstName,
                                                        string SecondName,
                                                        string ThirdName,
                                                        string LastName,
                                                        string Gender,
                                                        string Email,
                                                        string Phone,
                                                        string Address,
                                                        DateTime DateOfBirth,
                                                        int CountryID,
                                                        string ImagePath
            )
        {
            int rowsAffected = 0;

            string query = @"UPDATE People
                     SET NationalNo = @NationalNo,
                         FirstName = @FirstName,
                         SecondName = @SecondName,
                         ThirdName = @ThirdName,
                         LastName = @LastName,
                         Gender = @Gender,
                         Email = @Email,
                         Phone = @Phone,
                         Address = @Address,
                         DateOfBirth = @DateOfBirth,
                         CountryID = @CountryID,
                         ImagePath = @ImagePath
                     WHERE PersonID = @PersonID";

            try
            {
                using (SqlConnection connection =
                    new SqlConnection(ClsDataAccessSettings.ConnectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@PersonID", PersonID);
                    command.Parameters.AddWithValue("@NationalNo", NationalNo);
                    command.Parameters.AddWithValue("@FirstName", FirstName);
                    command.Parameters.AddWithValue("@SecondName", SecondName);
                    command.Parameters.AddWithValue("@ThirdName", ThirdName);
                    command.Parameters.AddWithValue("@LastName", LastName);

                    command.Parameters.AddWithValue("@Gender",ClsDataAccessHelper.ConvertGenderToDB(Gender));

                    command.Parameters.AddWithValue("@Email", Email);
                    command.Parameters.AddWithValue("@Phone", Phone);
                    command.Parameters.AddWithValue("@Address", Address);
                    command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                    command.Parameters.AddWithValue("@CountryID", CountryID);

                    command.Parameters.AddWithValue("@ImagePath", ClsDataAccessHelper.HandleDBNull(ImagePath));

                    connection.Open();

                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            catch
            {
                return false;
            }

            return rowsAffected > 0;
        }


        public static DataTable GetAllPeople() 
        {
            DataTable Dt = new DataTable();
            string Query =
               @"SELECT People.PersonID, People.NationalNo,
              People.FirstName, People.SecondName, People.ThirdName, People.LastName, 
              People.Email, People.Phone,People.Address,
			  People.DateOfBirth,
				  CASE
                  WHEN People.Gender = 'm' THEN 'Male'

                  ELSE 'Female'

                  END as Gender,
			   
              People.CountryID, Countries.CountryName, People.ImagePath
              FROM            People INNER JOIN
                         Countries ON People.CountryID = Countries.CountryID
                ORDER BY People.FirstName";

            try
            {
                using (SqlConnection connection =
                            new SqlConnection(ClsDataAccessSettings.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand(Query, connection);

                    connection.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            Dt.Load(reader);
                        }
                    }
                }
            }

            catch
            {

            }

           
            return Dt;

        }


        public static bool DeletePerson(int PersonID)
        {
            int roweffected = 0;

            string Query = "delete from People WHERE PersonID =@PersonID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand(Query, connection);

                    cmd.Parameters.AddWithValue("@PersonID", PersonID);
                        connection.Open();
                    roweffected = cmd.ExecuteNonQuery();


                }
            }
            catch
            {
                return false;
            }

            return roweffected > 0;

    }

        public static bool IsPersonExist(int PersonID)
        {
            string query = "SELECT 1 FROM People WHERE PersonID = @PersonID";

            try
            {
                using (SqlConnection connection =
                       new SqlConnection(ClsDataAccessSettings.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);

                    cmd.Parameters.AddWithValue("@PersonID", PersonID);

                    connection.Open();

                    return cmd.ExecuteScalar() != null;
                }
            }
            catch
            {
                return false;
            }
        }

        public static bool IsPersonExist(string NationalNo)
        {
            string query = "SELECT 1 FROM People WHERE NationalNo = @NationalNo";

            try
            {
                using (SqlConnection connection =
                       new SqlConnection(ClsDataAccessSettings.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);

                    cmd.Parameters.AddWithValue("@NationalNo", NationalNo);

                    connection.Open();

                    return cmd.ExecuteScalar() != null;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}