using System;
using System.Data;
using System.Data.SqlClient;


namespace ClinicManagementSystem.DataAccess
{
    public class clsPrescriptionData
    {
        public static DataTable GetAllPrescriptions()
        {
            var dt = new DataTable();

            string query = @"Select * From Prescriptions;";

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

        public static bool GetPrescriptionByID(int PrescriptionID, ref int MedicalRecordID, ref string MedicationName, ref string Dosage, ref string Frequency, ref DateTime StartDate, ref DateTime EndDate, ref string SpecialInstructions)
        {
            bool isFound = false;

            string query = @"Select * From Prescriptions
                             Where PrescriptionID = @PrescriptionID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@PrescriptionID", PrescriptionID);

                    try
                    {
                        connection.Open();

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            isFound = true;

                            PrescriptionID = (int)reader["PrescriptionID"];
                            MedicalRecordID = (int)reader["MedicalRecordID"];
                            MedicationName = (string)reader["MedicationName"];
                            Dosage = (string)reader["Dosage"];
                            Frequency = (string)reader["Frequency"];
                            StartDate = (DateTime)reader["StartDate"];
                            EndDate = (DateTime)reader["EndDate"];
                            SpecialInstructions = (string)reader["SpecialInstructions"];
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

        public static bool GetPrescriptionByMedicalRecordID(int MedicalRecordID, ref int PrescriptionID, ref string MedicationName, ref string Dosage, ref string Frequency, ref DateTime StartDate, ref DateTime EndDate, ref string SpecialInstructions)
        {
            bool isFound = false;

            string query = @"Select * From Prescriptions
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
                            PrescriptionID = (int)reader["PrescriptionID"];
                            MedicationName = (string)reader["MedicationName"];
                            Dosage = (string)reader["Dosage"];
                            Frequency = (string)reader["Frequency"];
                            StartDate = (DateTime)reader["StartDate"];
                            EndDate = (DateTime)reader["EndDate"];
                            SpecialInstructions = (string)reader["SpecialInstructions"];
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

        public static int AddPrescription(int MedicalRecordID, string MedicationName, string Dosage, string Frequency, DateTime StartDate, DateTime EndDate, string SpecialInstructions)
        {
            int PrescriptionID = -1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                string query = @"INSERT INTO Prescriptions (MedicalRecordID,MedicationName,Dosage,Frequency,StartDate,EndDate,SpecialInstructions)
                             VALUES(@MedicalRecordID,@MedicationName,@Dosage,@Frequency,@StartDate,@EndDate,@SpecialInstructions);
                             SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MedicalRecordID", MedicalRecordID);
                    command.Parameters.AddWithValue("@MedicationName", MedicationName);
                    command.Parameters.AddWithValue("@Dosage", Dosage);
                    command.Parameters.AddWithValue("@Frequency", Frequency);
                    command.Parameters.AddWithValue("@StartDate", StartDate);
                    command.Parameters.AddWithValue("@EndDate", EndDate);
                    command.Parameters.AddWithValue("@SpecialInstructions", SpecialInstructions);


                    try
                    {
                        connection.Open();

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            PrescriptionID = insertedID;
                        }
                    }
                    catch (Exception)
                    {
                        PrescriptionID = -1;
                    }
                    finally
                    {
                        connection.Close();
                    }

                    return PrescriptionID;
                }
            }
        }

        public static bool IsPrescriptionExists(int MedicalRecordID)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                string query = "SELECT Found=1 FROM Prescriptions WHERE MedicalRecordID = @MedicalRecordID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@MedicalRecordID", MedicalRecordID);

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

    }
}