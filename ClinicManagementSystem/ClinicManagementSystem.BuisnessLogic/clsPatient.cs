using System;
using System.Data;
using ClinicManagementSystem.DataAccess;


namespace ClinicManagementSystem.BuisnessLogic
{
    public class clsPatient
    {
        public enum enMode { AddNew = 0 };
        public enMode Mode = enMode.AddNew;

        public int PatientID { get; set; }
        public int PersonID { get; set; }
        public clsPerson Person { get; set; }

        public clsPatient()
        {
            this.PatientID = -1;
            this.PersonID = -1;

            Mode = enMode.AddNew;
        }

        private clsPatient(int PatientID, int PersonID)
        {
            this.PatientID = PatientID;

            this.PersonID = PersonID;
            this.Person = clsPerson.FindPersonByID(PersonID);

            Mode = enMode.AddNew;
        }

        public static bool AddNewPatient(int PersonID)
        {
            int ID = clsPatientData.AddPatient(PersonID);

            return (ID != -1);
        }

        public static DataTable GetAllPatients()
        {
            return clsPatientData.GetAllPatients();
        }

        public static bool DeletePatient(int ID)
        {
            return clsPatientData.DeletePatient(ID);
        }

        public static bool IsPatientExist(int PersonID)
        {
            return clsPatientData.IsPatientExist(PersonID);
        }
    }
}