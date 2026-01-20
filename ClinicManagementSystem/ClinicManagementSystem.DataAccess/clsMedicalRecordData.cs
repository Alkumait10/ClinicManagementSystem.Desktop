using System;
using System.Data;
using System.Data.SqlClient;

namespace ClinicManagementSystem.DataAccess
{
    public class clsMedicalRecordData
    {
        public static DataTable GetAllMedicalRecords()
        {
            var dt = new DataTable();

            string query = @"Select * From MedicalRecords;";

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

        public static bool GetMedicalRecordByID(int MedicalRecordID, ref string VisitDescription, ref string Diagnosis, ref string AdditionalNotes)
        {
            bool isFound = false;

            string query = @"Select * From MedicalRecords
                             Where MedicalRecordID = @MedicalRecordID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@MedicalRecordID", MedicalRecordID);

                    try
                    {
                        connection.Open();

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            isFound = true;

                            MedicalRecordID = (int)reader["MedicalRecordID"];
                            VisitDescription = (string)reader["VisitDescription"];
                            Diagnosis = (string)reader["Diagnosis"];
                            AdditionalNotes = (string)reader["AdditionalNotes"];
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

        public static int AddMedicalRecord(string VisitDescription, string Diagnosis, string AdditionalNotes)
        {
            int MedicalRecordID = -1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                string query = @"INSERT INTO MedicalRecords (VisitDescription,Diagnosis,AdditionalNotes)
                             VALUES(@VisitDescription,@Diagnosis,@AdditionalNotes);
                             SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@VisitDescription", VisitDescription);
                    command.Parameters.AddWithValue("@Diagnosis", Diagnosis);
                    command.Parameters.AddWithValue("@AdditionalNotes", AdditionalNotes);


                    try
                    {
                        connection.Open();

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            MedicalRecordID = insertedID;
                        }
                    }
                    catch (Exception)
                    {
                        MedicalRecordID = -1;
                    }
                    finally
                    {
                        connection.Close();
                    }

                    return MedicalRecordID;
                }
            }
        }

    }
}