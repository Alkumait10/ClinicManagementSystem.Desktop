using System;
using System.Data;
using System.Data.SqlClient;


namespace ClinicManagementSystem.DataAccess
{
    public class clsAppointmentData
    {
        public static DataTable GetAllAppointments()
        {
            var dt = new DataTable();

            string query = @"Select * From Appointments_View;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            dt.Load(reader);
                        }
                    }
                }

                return dt;
            }
        }

        public static bool GetAppointmentByID(int AppointmentID, ref int PatientID, ref int DoctorID, ref DateTime AppointmentDateTime, ref string AppointmentStatus, ref int MedicalRecordID, ref int PaymentID)
        {
            bool isFound = false;

            string query = @"Select * From Appointments
                             Where AppointmentID = @AppointmentID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@AppointmentID", AppointmentID);

                    try
                    {
                        connection.Open();

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            isFound = true;

                            AppointmentID = (int)reader["AppointmentID"];
                            PatientID = (int)reader["PatientID"];
                            DoctorID = (int)reader["DoctorID"];
                            AppointmentDateTime = (DateTime)reader["AppointmentDateTime"];
                            AppointmentStatus = (string)reader["AppointmentStatus"];
                            MedicalRecordID = (int)reader["MedicalRecordID"];
                            PaymentID = (int)reader["PaymentID"];
                        }
                        else
                            isFound = false;

                        reader.Close();
                    }
                    catch (Exception)
                    {
                        isFound = false;
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }

            return isFound;
        }

        public static int AddAppointment(int PatientID, int DoctorID, DateTime AppointmentDateTime)
        {
            int AppointmentID = -1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                string query = @"INSERT INTO Appointments (PatientID,DoctorID,AppointmentDateTime,AppointmentStatus)
                             VALUES(@PatientID,@DoctorID,@AppointmentDateTime,@AppointmentStatus);
                             SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PatientID", PatientID);
                    command.Parameters.AddWithValue("@DoctorID", DoctorID);
                    command.Parameters.AddWithValue("@AppointmentDateTime", AppointmentDateTime);
                    command.Parameters.AddWithValue("@AppointmentStatus", "Scheduled");


                    try
                    {
                        connection.Open();

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            AppointmentID = insertedID;
                        }
                    }
                    catch (Exception)
                    {
                        AppointmentID = -1;
                    }
                    finally
                    {
                        connection.Close();
                    }

                    return AppointmentID;
                }
            }
        }

        public static bool UpdateAppointmentDate(int AppointmentID, DateTime AppointmentDateTime)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                string query = @"Update Appointments
                                set
                                AppointmentDateTime = @AppointmentDateTime
                                where AppointmentID = @AppointmentID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AppointmentDateTime", AppointmentDateTime);
                    command.Parameters.AddWithValue("@AppointmentID", AppointmentID);

                    try
                    {
                        connection.Open();

                        rowsAffected = command.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {
                        rowsAffected = 0;
                    }

                    finally
                    {
                        connection.Close();
                    }

                    return (rowsAffected > 0);
                }
            }
        }

        public static bool UpdateAppointmentStatus(int AppointmentID, string AppointmentStatus)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                string query = @"Update Appointments
                                set
                                AppointmentStatus = @AppointmentStatus
                                where AppointmentID = @AppointmentID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AppointmentStatus", AppointmentStatus);
                    command.Parameters.AddWithValue("@AppointmentID", AppointmentID);

                    try
                    {
                        connection.Open();

                        rowsAffected = command.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {
                        rowsAffected = 0;
                    }

                    finally
                    {
                        connection.Close();
                    }

                    return (rowsAffected > 0);
                }
            }
        }

        public static bool IsAppointmentExists(int PatientID)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                string query = "SELECT Found=1 FROM Appointments WHERE PatientID = @PatientID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@PatientID", PatientID);

                    try
                    {
                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();

                        isFound = reader.HasRows;

                        reader.Close();
                    }
                    catch (Exception)
                    {
                        isFound = false;
                    }
                    finally
                    {
                        connection.Close();
                    }

                    return isFound;
                }
            }
        }

        public static bool UpdateAppointmentMedicalRecordID(int AppointmentID, int MedicalRecordID)
        {
            int rowsAffected = 0;

            string query = @"Update Appointments
                             Set MedicalRecordID = @MedicalRecordID
                             Where AppointmentID = @AppointmentID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MedicalRecordID", MedicalRecordID);
                    command.Parameters.AddWithValue("@AppointmentID", AppointmentID);

                    try
                    {
                        connection.Open();

                        rowsAffected = command.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {
                        rowsAffected = 0;
                    }

                    finally
                    {
                        connection.Close();
                    }

                    return (rowsAffected > 0);
                }
            }
        }

        public static bool UpdateAppointmentPaymentID(int AppointmentID, int PaymentID)
        {
            int rowsAffected = 0;

            string query = @"Update Appointments
                             Set PaymentID = @PaymentID
                             Where AppointmentID = @AppointmentID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PaymentID", PaymentID);
                    command.Parameters.AddWithValue("@AppointmentID", AppointmentID);

                    try
                    {
                        connection.Open();

                        rowsAffected = command.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {
                        rowsAffected = 0;
                    }

                    finally
                    {
                        connection.Close();
                    }

                    return (rowsAffected > 0);
                }
            }
        }

    }
}