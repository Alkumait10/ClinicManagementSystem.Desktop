using ClinicManagementSystem.BuisnessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagementSystem.Presentation
{
    public partial class frmListAppointments : Form
    {
        private static DataTable _AllAppointments;

        public frmListAppointments()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListAppointments_Load(object sender, EventArgs e)
        {
            _AllAppointments = clsAppointment.GetAllAppointments();
            dgvAppointments.DataSource = _AllAppointments;

            cbFilterBy.SelectedIndex = 0;

            _ConfigureAppointmentsGrid();


            lblRecordsCount.Text = _AllAppointments.Rows.Count.ToString();
        }

        private void _ConfigureAppointmentsGrid()
        {
            // Header
            dgvAppointments.EnableHeadersVisualStyles = false;
            dgvAppointments.ColumnHeadersHeight = 36;
            dgvAppointments.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            dgvAppointments.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvAppointments.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);
            dgvAppointments.ColumnHeadersDefaultCellStyle.SelectionBackColor =
                Color.FromArgb(240, 240, 240);
            dgvAppointments.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Black;

            // Cells
            dgvAppointments.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dgvAppointments.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue;
            dgvAppointments.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Behavior
            dgvAppointments.AllowUserToAddRows = false;
            dgvAppointments.ReadOnly = true;
            dgvAppointments.MultiSelect = false;
            dgvAppointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Layout
            dgvAppointments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAppointments.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvAppointments.ScrollBars = ScrollBars.Vertical;

            dgvAppointments.RowHeadersVisible = false;
            dgvAppointments.BackgroundColor = Color.White;
            dgvAppointments.BorderStyle = BorderStyle.FixedSingle;
        }

        private void frmListAppointments_Shown(object sender, EventArgs e)
        {
            dgvAppointments.ClearSelection();
            dgvAppointments.CurrentCell = null;
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cbFilterBy.Text != "None");

            if (cbFilterBy.Text == "None")
                txtFilterValue.Enabled = false;
            else
                txtFilterValue.Enabled = true;

            txtFilterValue.Text = "";
            txtFilterValue.Focus();
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            switch (cbFilterBy.Text)
            {
                case "AppointmentID":
                    FilterColumn = "AppointmentID";
                    break;
                case "PatientID":
                    FilterColumn = "PatientID";
                    break;
                case "PatientName":
                    FilterColumn = "PatientName";
                    break;
                case "DoctorID":
                    FilterColumn = "DoctorID";
                    break;
                case "DoctorName":
                    FilterColumn = "DoctorName";
                    break;
                default:
                    FilterColumn = "None";
                    break;
            }
            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _AllAppointments.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvAppointments.Rows.Count.ToString();
                return;
            }

            if (FilterColumn != "PatientName" && FilterColumn != "DoctorName")
                _AllAppointments.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
            else
                _AllAppointments.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());

            lblRecordsCount.Text = _AllAppointments.Rows.Count.ToString();
        }

        private void btnAddNewAppointment_Click(object sender, EventArgs e)
        {
            frmListPatients frm = new frmListPatients();
            frm.ShowDialog();

            frmListAppointments_Load(null, null);
        }

        private void addMedicalRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int AppointmentID = (int)dgvAppointments.CurrentRow.Cells["AppointmentID"].Value;

            frmAddMedicalRecord frm = new frmAddMedicalRecord(AppointmentID);
            frm.ShowDialog();

            frmListAppointments_Load(null, null);
        }

        private void showMedicalRecordDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int MedicalRecordID = (int)dgvAppointments.CurrentRow.Cells["MedicalRecordID"].Value;

            frmMedicalRecordDetails frm = new frmMedicalRecordDetails(MedicalRecordID);
            frm.ShowDialog();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            var cellValue = dgvAppointments.CurrentRow.Cells["MedicalRecordID"].Value;

            bool hasMedicalRecord = cellValue != DBNull.Value && cellValue != null && cellValue.ToString() != "";


            addMedicalRecordToolStripMenuItem.Enabled = !hasMedicalRecord;
            showMedicalRecordDetailsToolStripMenuItem.Enabled = hasMedicalRecord;
            rescheduleToolStripMenuItem.Enabled = !hasMedicalRecord;
            cancelToolStripMenuItem.Enabled = !hasMedicalRecord;

            string status = dgvAppointments.CurrentRow.Cells["Status"].Value.ToString();

            if (status == "Cancelled")
            {
                foreach (ToolStripItem item in contextMenuStrip1.Items)
                    item.Enabled = false;

                return;
            }

            bool hasPrescription = false;
            int MedicalRecordID = -1;

            if (hasMedicalRecord)
            {
                MedicalRecordID = (int)cellValue;
                hasPrescription = clsPrescription.IsPrescriptionExists(MedicalRecordID);
            }

            addPrescriptionToolStripMenuItem.Enabled = (hasMedicalRecord && !hasPrescription);
            showPrescriptionDetailsToolStripMenuItem.Enabled = hasPrescription;



            var cellValue2 = dgvAppointments.CurrentRow.Cells["PaymentID"].Value;
            bool hasPayment = cellValue2 != DBNull.Value && cellValue2 != null && cellValue2.ToString() != "";

            addPaymentToolStripMenuItem.Enabled = (hasMedicalRecord && hasPrescription && !hasPayment);
            showPaymentDetailsToolStripMenuItem.Enabled = hasPayment;
        }

        private void rescheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int AppointmentID = (int)dgvAppointments.CurrentRow.Cells["AppointmentID"].Value;
            DateTime CurrentDate = (DateTime)dgvAppointments.CurrentRow.Cells["Date"].Value;

            frmRescheduleAppointment frm = new frmRescheduleAppointment(AppointmentID, CurrentDate);
            frm.ShowDialog();

            frmListAppointments_Load(null, null);
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int AppointmentID = (int)dgvAppointments.CurrentRow.Cells["AppointmentID"].Value;

            if (MessageBox.Show("Are you sure you want to cancel this appointment?", "Confirm Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }

            if (clsAppointment.ChangeAppointmentStatus(AppointmentID, "Cancelled"))
            {
                MessageBox.Show("Appointment cancelled successfully.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to cancel appointment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            frmListAppointments_Load(null, null);
        }

        private void addPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int AppointmentID = (int)dgvAppointments.CurrentRow.Cells["AppointmentID"].Value;

            frmAddPayment frm = new frmAddPayment(AppointmentID);
            frm.ShowDialog();

            frmListAppointments_Load(null, null);
        }

        private void showPaymentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PaymentID = (int)dgvAppointments.CurrentRow.Cells["PaymentID"].Value;

            frmPaymentDetails frm = new frmPaymentDetails(PaymentID);
            frm.ShowDialog();
        }

        private void addPrescriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int MedicalRecordID = (int)dgvAppointments.CurrentRow.Cells["MedicalRecordID"].Value;

            frmAddPrescription frm = new frmAddPrescription(MedicalRecordID);
            frm.ShowDialog();

            frmListAppointments_Load(null, null);
        }

        private void showPrescriptionDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int MedicalRecordID = (int)dgvAppointments.CurrentRow.Cells["MedicalRecordID"].Value;

            frmPrescriptionDetails frm = new frmPrescriptionDetails(MedicalRecordID);
            frm.ShowDialog();

            frmListAppointments_Load(null, null);
        }
    }
}
