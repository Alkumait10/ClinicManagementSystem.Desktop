using System;
using System.Data;
using ClinicManagementSystem.DataAccess;


namespace ClinicManagementSystem.BuisnessLogic
{
    public class clsPrescription
    {
        public int PrescriptionID { get; set; }
        public int MedicalRecordID { get; set; }
        public string MedicationName { get; set; }
        public string Dosage { get; set; }
        public string Frequency { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string SpecialInstructions { get; set; }


        public clsPrescription()
        {
            this.PrescriptionID = -1;
            this.MedicalRecordID = -1;
            this.MedicationName = "";
            this.Dosage = "";
            this.Frequency = "";
            this.StartDate = DateTime.Now;
            this.EndDate = DateTime.Now;
            this.SpecialInstructions = "";
        }

        private clsPrescription(int PrescriptionID, int MedicalRecordID, string MedicationName, string Dosage, string Frequency, DateTime StartDate, DateTime EndDate, string SpecialInstructions)
        {
            this.PrescriptionID = PrescriptionID;
            this.MedicalRecordID = MedicalRecordID;
            this.MedicationName = MedicationName;
            this.Dosage = Dosage;
            this.Frequency = Frequency;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.SpecialInstructions = SpecialInstructions;
        }

        public static int AddPrescription(int MedicalRecordID, string MedicationName, string Dosage, string Frequency, DateTime StartDate, DateTime EndDate, string SpecialInstructions)
        {
            int PrescriptionID = clsPrescriptionData.AddPrescription(MedicalRecordID, MedicationName, Dosage, Frequency, StartDate, EndDate, SpecialInstructions);

            return PrescriptionID;
        }

        public static clsPrescription FindPrescriptionByID(int PrescriptionID)
        {
            int MedicalRecordID = -1;
            string MedicationName = "";
            string Dosage = "";
            string Frequency = "";
            DateTime StartDate = DateTime.Now;
            DateTime EndDate = DateTime.Now;
            string SpecialInstructions = "";

            bool IsFound = clsPrescriptionData.GetPrescriptionByID(PrescriptionID, ref MedicalRecordID, ref MedicationName, ref Dosage, ref Frequency, ref StartDate, ref EndDate, ref SpecialInstructions);

            if (IsFound)
                return new clsPrescription(PrescriptionID, MedicalRecordID, MedicationName, Dosage, Frequency, StartDate, EndDate, SpecialInstructions);
            else
                return null;
        }

        public static clsPrescription FindPrescriptionByMedicalRecordID(int MedicalRecordID)
        {
            int PrescriptionID = -1;
            string MedicationName = "";
            string Dosage = "";
            string Frequency = "";
            DateTime StartDate = DateTime.Now;
            DateTime EndDate = DateTime.Now;
            string SpecialInstructions = "";

            bool IsFound = clsPrescriptionData.GetPrescriptionByMedicalRecordID(MedicalRecordID, ref PrescriptionID, ref MedicationName, ref Dosage, ref Frequency, ref StartDate, ref EndDate, ref SpecialInstructions);

            if (IsFound)
                return new clsPrescription(PrescriptionID, MedicalRecordID, MedicationName, Dosage, Frequency, StartDate, EndDate, SpecialInstructions);
            else
                return null;
        }


        public static DataTable GetAllPrescriptions()
        {
            return clsPrescriptionData.GetAllPrescriptions();
        }

        public static bool IsPrescriptionExists(int MedicalRecordID)
        {
            return clsPrescriptionData.IsPrescriptionExists(MedicalRecordID);
        }
    }
}