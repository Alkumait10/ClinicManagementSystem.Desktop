using System;
using System.Data;
using System.Data.SqlClient;


namespace ClinicManagementSystem.DataAccess
{
    public class clsPaymentData
    {
        public static DataTable GetAllPayments()
        {
            var dt = new DataTable();

            string query = @"Select * From Payments;";

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

        public static bool GetPaymentByID(int PaymentID, ref DateTime PaymentDate, ref string PaymentMethod, ref decimal AmountPaid, ref string AdditionalNotes)
        {
            bool isFound = false;

            string query = @"Select * From Payments
                             Where PaymentID = @PaymentID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@PaymentID", PaymentID);

                    try
                    {
                        connection.Open();

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            isFound = true;

                            PaymentID = (int)reader["PaymentID"];
                            PaymentDate = (DateTime)reader["PaymentDate"];
                            PaymentMethod = (string)reader["PaymentMethod"];
                            AmountPaid = (decimal)reader["AmountPaid"];
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

        public static int AddPayment(DateTime PaymentDate, string PaymentMethod, decimal AmountPaid, string AdditionalNotes)
        {
            int PaymentID = -1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                string query = @"INSERT INTO Payments (PaymentDate,PaymentMethod,AmountPaid,AdditionalNotes)
                             VALUES(@PaymentDate,@PaymentMethod,@AmountPaid,@AdditionalNotes);
                             SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PaymentDate", PaymentDate);
                    command.Parameters.AddWithValue("@PaymentMethod", PaymentMethod);
                    command.Parameters.AddWithValue("@AmountPaid", AmountPaid);
                    command.Parameters.AddWithValue("@AdditionalNotes", AdditionalNotes);


                    try
                    {
                        connection.Open();

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            PaymentID = insertedID;
                        }
                    }
                    catch (Exception)
                    {
                        PaymentID = -1;
                    }
                    finally
                    {
                        connection.Close();
                    }

                    return PaymentID;
                }
            }
        }
    }
}