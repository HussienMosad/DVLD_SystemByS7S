using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class ClsLocalDrivingLicenseApplicationsAccess
    {

        public static int GitLDLAIDbyApplicationID(int ApplicationID)
        {
            int LocalDrivingLicenseApplicationID = -1;

            using (SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString))
            {
                
                string query = @"Select l.LocalDrivingLicenseApplicationID from LocalDrivingLicenseApplications l 
                                 where l.ApplicationID = @ApplicationID;
";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            LocalDrivingLicenseApplicationID = insertedID;
                        }
                    }
                    catch (Exception ex)
                    {
                        throw;
                    }
                }
            }

            return LocalDrivingLicenseApplicationID;
        }
        
        
        public static int AddNewLocalDrivingLicenseApplication(
                            int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID,
                            byte ApplicationStatus, DateTime LastStatusDate, float PaidFees,
                            int CreatedByUserID, int LicenseClassID)
        {
            int LocalDrivingLicenseApplicationID = -1;

            using (SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString))
            {
                string query = @"
            BEGIN TRY
                BEGIN TRANSACTION;

                    INSERT INTO Applications 
                    (ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID)
                    VALUES 
                    (@ApplicantPersonID, @ApplicationDate, @ApplicationTypeID, @ApplicationStatus, @LastStatusDate, @PaidFees, @CreatedByUserID);
                    
                    
                    DECLARE @NewAppID INT = SCOPE_IDENTITY();

                    
                    INSERT INTO LocalDrivingLicenseApplications (ApplicationID, LicenseClassID)
                    VALUES (@NewAppID, @LicenseClassID);

                    
                    DECLARE @NewLocalAppID INT = SCOPE_IDENTITY();

                COMMIT TRANSACTION;
                SELECT @NewLocalAppID;

            END TRY
            BEGIN CATCH
                
                IF @@TRANCOUNT > 0
                    ROLLBACK TRANSACTION;
                
                SELECT -1;
            END CATCH";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    
                    command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
                    command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
                    command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
                    command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
                    command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
                    command.Parameters.AddWithValue("@PaidFees", PaidFees);
                    command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                    
                    command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            LocalDrivingLicenseApplicationID = insertedID;
                        }
                    }
                    catch (Exception ex)
                    {
                        throw;
                    }
                }
            }

            return LocalDrivingLicenseApplicationID;
        }


        public static bool CancelLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString))
            {
                string query = @"
            BEGIN TRY
                BEGIN TRANSACTION;
                    
                    DECLARE @AppID INT;
                    SELECT @AppID = ApplicationID FROM LocalDrivingLicenseApplications 
                    WHERE LocalDrivingLicenseApplicationID = @LDLAID;

                    UPDATE Applications
                        SET ApplicationStatus = 2, 
                        LastStatusDate = GETDATE() 
                        WHERE ApplicationID = @AppID;

                COMMIT TRANSACTION;
            END TRY
            BEGIN CATCH
                IF @@TRANCOUNT > 0
                    ROLLBACK TRANSACTION;
            END CATCH";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LDLAID", LocalDrivingLicenseApplicationID);

                    try
                    {
                        connection.Open();

                        rowsAffected = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw;
                    }
                }
            }

            return (rowsAffected > 0);
        }

        public static bool DeleteLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString))
            {
                string query = @"
            BEGIN TRY
                BEGIN TRANSACTION;
                    
                    DECLARE @AppID INT;
                    SELECT @AppID = ApplicationID FROM LocalDrivingLicenseApplications 
                    WHERE LocalDrivingLicenseApplicationID = @LDLAID;

                    DELETE FROM LocalDrivingLicenseApplications 
                    WHERE LocalDrivingLicenseApplicationID = @LDLAID;

                    DELETE FROM Applications 
                    WHERE ApplicationID = @AppID;
                    

                COMMIT TRANSACTION;
            END TRY
            BEGIN CATCH
                IF @@TRANCOUNT > 0
                    ROLLBACK TRANSACTION;
            END CATCH";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LDLAID", LocalDrivingLicenseApplicationID);

                    try
                    {
                        connection.Open();

                        rowsAffected = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw;
                    }
                }
            }

            return (rowsAffected > 0);
        }


        public static DataTable GetAllLocalDrivingLicenseApplications()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);

            string query =
                        @"SELECT * FROM LocalDrivingLicenseApplications_View";


            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)

                {
                    dt.Load(reader);
                }

                reader.Close();


            }

            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }

            return dt;

        }

        public static bool CheckPersonAge(DateTime DateOfBirth, int ClassID)
        {
            bool AcceptedAge = false;

            int Age = DateTime.Now.Year - DateOfBirth.Year  ;

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);

            string query = "select 1 from LicenseClasses lc where @ClassID = 1 and MinimumAllowedAge <= @Age;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ClassID", ClassID);
            command.Parameters.AddWithValue("@Age", Age);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                AcceptedAge = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
              
                AcceptedAge = false;
                throw;
            }
            finally
            {
                connection.Close();
            }

            return AcceptedAge;
        }



        public static bool GetLocalDrivingLicenseApplicationInfoByID(
                       int LocalDrivingLicenseApplicationID, ref int ApplicationID, ref int ApplicantPersonID,
                       ref DateTime ApplicationDate, ref int ApplicationTypeID, ref byte ApplicationStatus,
                       ref DateTime LastStatusDate, ref float PaidFees, ref int CreatedByUserID, ref int LicenseClassID)
        {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);

            string query = @"SELECT *
                     FROM LocalDrivingLicenseApplications 
                     INNER JOIN Applications ON LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID
                     WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    isFound = true;
                    ApplicationID = (int)reader["ApplicationID"];
                    ApplicantPersonID = (int)reader["ApplicantPersonID"];
                    ApplicationDate = (DateTime)reader["ApplicationDate"];
                    ApplicationTypeID = (int)reader["ApplicationTypeID"];
                    ApplicationStatus = Convert.ToByte(reader["ApplicationStatus"]);
                    LastStatusDate = (DateTime)reader["LastStatusDate"];
                    PaidFees = Convert.ToSingle(reader["PaidFees"]);
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    LicenseClassID = (int)reader["LicenseClassID"];
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                isFound = false;
                throw;

            }

            finally
            {
                connection.Close();
            }
            return isFound;
        }


        public static bool UpdateLocalDrivingLicenseApplication(

            int LocalDrivingLicenseApplicationID, int ApplicationID, int ApplicantPersonID,
            DateTime ApplicationDate, int ApplicationTypeID, byte ApplicationStatus,
            DateTime LastStatusDate, float PaidFees, int CreatedByUserID, int LicenseClassID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);            

            string query = @"UPDATE Applications 
                     SET ApplicantPersonID = @ApplicantPersonID,
                         ApplicationDate = @ApplicationDate,
                         ApplicationTypeID = @ApplicationTypeID,
                         ApplicationStatus = @ApplicationStatus,
                         LastStatusDate = @LastStatusDate,
                         PaidFees = @PaidFees,
                         CreatedByUserID = @CreatedByUserID
                     WHERE ApplicationID = @ApplicationID;
                     UPDATE LocalDrivingLicenseApplications
                     SET LicenseClassID = @LicenseClassID
                     WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return false;
                throw;
            }
            finally
            {
                connection.Close();
            }
            return (rowsAffected > 0);
        }

        public static int GetPassedTests(int LocalDrivingLicenseApplicationID)
        {
            int PassedTests = 0;

            using (SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString))
            {
                string query = @"

                select  COUNT(ta.TestTypeID) AS PassedTestCount  
                    FROM  Tests t INNER JOIN TestAppointments ta
			        ON    t.TestAppointmentID = ta.TestAppointmentID  
                    WHERE ta.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID AND t.TestResult = 1;
                ";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
                    

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int Count))
                        {
                            PassedTests = Count;
                        }
                    }
                    catch (Exception ex)
                    {
                        throw;
                    }
                }
            }

            return PassedTests;
        }

    }
}
