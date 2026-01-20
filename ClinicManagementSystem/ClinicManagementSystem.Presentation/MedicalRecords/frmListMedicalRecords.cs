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
    public partial class frmListMedicalRecords : Form
    {
        private static DataTable _AllMedicalRecords;

        public frmListMedicalRecords()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListMedicalRecords_Load(object sender, EventArgs e)
        {
            _AllMedicalRecords = clsMedicalRecord.GetAllMedicalRecords();
            dgvMedicalRecords.DataSource = _AllMedicalRecords;

            _ConfigureMedicalRecordsGrid();


            lblRecordsCount.Text = _AllMedicalRecords.Rows.Count.ToString();
        }

        private void _ConfigureMedicalRecordsGrid()
        {
            // Header
            dgvMedicalRecords.EnableHeadersVisualStyles = false;
            dgvMedicalRecords.ColumnHeadersHeight = 36;
            dgvMedicalRecords.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            dgvMedicalRecords.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvMedicalRecords.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);
            dgvMedicalRecords.ColumnHeadersDefaultCellStyle.SelectionBackColor =
                Color.FromArgb(240, 240, 240);
            dgvMedicalRecords.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Black;

            // Cells
            dgvMedicalRecords.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dgvMedicalRecords.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue;
            dgvMedicalRecords.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Behavior
            dgvMedicalRecords.AllowUserToAddRows = false;
            dgvMedicalRecords.ReadOnly = true;
            dgvMedicalRecords.MultiSelect = false;
            dgvMedicalRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Layout
            dgvMedicalRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMedicalRecords.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvMedicalRecords.ScrollBars = ScrollBars.Vertical;

            dgvMedicalRecords.RowHeadersVisible = false;
            dgvMedicalRecords.BackgroundColor = Color.White;
            dgvMedicalRecords.BorderStyle = BorderStyle.FixedSingle;
        }

        private void frmListMedicalRecords_Shown(object sender, EventArgs e)
        {
            dgvMedicalRecords.ClearSelection();
            dgvMedicalRecords.CurrentCell = null;
        }

        private void addPrescriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int MedicalRecordID = (int)dgvMedicalRecords.CurrentRow.Cells["MedicalRecordID"].Value;

            frmAddPrescription frm = new frmAddPrescription(MedicalRecordID);
            frm.ShowDialog();

            frmListMedicalRecords_Load(null, null);
        }

        private void showPrescriptionDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int MedicalRecordID = (int)dgvMedicalRecords.CurrentRow.Cells["MedicalRecordID"].Value;

            frmPrescriptionDetails frm = new frmPrescriptionDetails(MedicalRecordID);
            frm.ShowDialog();

            frmListMedicalRecords_Load(null, null);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            int MedicalRecordID = (int)dgvMedicalRecords.CurrentRow.Cells["MedicalRecordID"].Value;

            bool hasPrescription = clsPrescription.IsPrescriptionExists(MedicalRecordID);

            addPrescriptionToolStripMenuItem.Enabled = !hasPrescription;
            showPrescriptionDetailsToolStripMenuItem.Enabled = hasPrescription;

        }
    }
}
