using System;
using System.Configuration;

namespace ClinicManagementSystem.DataAccess
{
    public class clsDataAccessSettings
    {
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["Clinic_ConnectionString"].ConnectionString;
    }
}