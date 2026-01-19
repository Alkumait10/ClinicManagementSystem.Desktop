using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;


namespace ClinicManagementSystem.DataAccess
{
    public class clsDoctorData
    {
        public static int AddDoctor(int PersonID, string Specialization)
        {
            int DoctorID = -1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                string query = @"INSERT INTO Doctors (PersonID,Specialization)
                             VALUES(@PersonID,@Specialization);
                             SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PersonID", PersonID);
                    command.Parameters.AddWithValue("@Specialization", Specialization);

                    try
                    {
                        connection.Open();

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            DoctorID = insertedID;
                        }
                    }
                    catch (Exception)
                    {
                        DoctorID = -1;
                    }
                    finally
                    {
                        connection.Close();
                    }

                    return DoctorID;
                }
            }
        }

        public static bool IsDoctorExist(int PersonID)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                string query = "SELECT Found=1 FROM Doctors WHERE PersonID = @PersonID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@PersonID", PersonID);

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

        public static bool DeleteDoctor(int DoctorID)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                string query = @"Delete From Doctors 
                                where DoctorID = @DoctorID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@DoctorID", DoctorID);

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

        public static DataTable GetAllDoctors()
        {
            var dt = new DataTable();

            string query = @"Select Doctors.DoctorID,Doctors.PersonID,Persons.Name,Doctors.Specialization
                             from Doctors inner join Persons on Doctors.PersonID = Persons.PersonID;";

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

        public static List<Tuple<int, string>> GetDoctors()
        {
            var doctors = new List<Tuple<int, string>>();

            string query = @"Select Doctors.DoctorID,Persons.Name
                             from Doctors inner join Persons on Doctors.PersonID = Persons.PersonID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            doctors.Add(Tuple.Create(reader.GetInt32(0), reader.GetString(1)));
                        }
                    }
                }

                return doctors;
            }
        }

    }
}