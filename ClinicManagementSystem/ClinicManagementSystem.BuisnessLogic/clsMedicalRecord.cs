using System;
using System.Data;
using ClinicManagementSystem.DataAccess;


namespace ClinicManagementSystem.BuisnessLogic
{
    public class clsMedicalRecord
    {
        public int MedicalRecordID { get; set; }
        public string VisitDescription { get; set; }
        public string Diagnosis { get; set; }
        public string AdditionalNotes { get; set; }

        public clsMedicalRecord()
        {
            this.MedicalRecordID = -1;
            this.VisitDescription = "";
            this.Diagnosis = "";
            this.AdditionalNotes = "";
        }

        private clsMedicalRecord(int MedicalRecordID, string VisitDescription, string Diagnosis, string AdditionalNotes)
        {
            this.MedicalRecordID = MedicalRecordID;
            this.VisitDescription = VisitDescription;
            this.Diagnosis = Diagnosis;
            this.AdditionalNotes = AdditionalNotes;
        }

        public static int CreateMedicalRecord(string VisitDescription, string Diagnosis, string AdditionalNotes)
        {
            int MedicalRecordID = clsMedicalRecordData.AddMedicalRecord(VisitDescription, Diagnosis, AdditionalNotes);

            return MedicalRecordID;
        }

        public static clsMedicalRecord FindMedicalRecordByID(int MedicalRecordID)
        {
            string VisitDescription = "";
            string Diagnosis = "";
            string AdditionalNotes = "";

            bool IsFound = clsMedicalRecordData.GetMedicalRecordByID(MedicalRecordID, ref VisitDescription, ref Diagnosis, ref AdditionalNotes);

            if (IsFound)
                return new clsMedicalRecord(MedicalRecordID, VisitDescription, Diagnosis, AdditionalNotes);
            else
                return null;
        }

        public static DataTable GetAllMedicalRecords()
        {
            return clsMedicalRecordData.GetAllMedicalRecords();
        }

    }
}