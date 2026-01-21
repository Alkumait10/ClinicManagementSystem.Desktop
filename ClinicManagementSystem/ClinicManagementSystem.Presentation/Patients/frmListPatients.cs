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
    public partial class frmListPatients : Form
    {
        private static DataTable _AllPatients;

        public frmListPatients()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListPatients_Load(object sender, EventArgs e)
        {
            _AllPatients = clsPatient.GetAllPatients();
            dgvPatients.DataSource = _AllPatients;

            cbFilterBy.SelectedIndex = 0;

            _ConfigurePatientsGrid();


            lblRecordsCount.Text = _AllPatients.Rows.Count.ToString();
        }

        private void _ConfigurePatientsGrid()
        {
            // Header
            dgvPatients.EnableHeadersVisualStyles = false;
            dgvPatients.ColumnHeadersHeight = 36;
            dgvPatients.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            dgvPatients.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvPatients.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);
            dgvPatients.ColumnHeadersDefaultCellStyle.SelectionBackColor =
                Color.FromArgb(240, 240, 240);
            dgvPatients.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Black;

            // Cells
            dgvPatients.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dgvPatients.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue;
            dgvPatients.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Behavior
            dgvPatients.AllowUserToAddRows = false;
            dgvPatients.ReadOnly = true;
            dgvPatients.MultiSelect = false;
            dgvPatients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Layout
            dgvPatients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPatients.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvPatients.ScrollBars = ScrollBars.Vertical;

            dgvPatients.RowHeadersVisible = false;
            dgvPatients.BackgroundColor = Color.White;
            dgvPatients.BorderStyle = BorderStyle.FixedSingle;
        }

        private void frmListPatients_Shown(object sender, EventArgs e)
        {
            dgvPatients.ClearSelection();
            dgvPatients.CurrentCell = null;
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
                case "PatientID":
                    FilterColumn = "PatientID";
                    break;
                case "PersonID":
                    FilterColumn = "PersonID";
                    break;
                case "Name":
                    FilterColumn = "Name";
                    break;
                default:
                    FilterColumn = "None";
                    break;
            }
            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _AllPatients.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvPatients.Rows.Count.ToString();
                return;
            }

            if (FilterColumn != "Name")
                _AllPatients.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
            else
                _AllPatients.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());

            lblRecordsCount.Text = _AllPatients.Rows.Count.ToString();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PatientID = (int)dgvPatients.CurrentRow.Cells[0].Value;
            int PersonID = (int)dgvPatients.CurrentRow.Cells[1].Value;

            frmPatientDetails frm = new frmPatientDetails(PatientID, PersonID);
            frm.ShowDialog();

            frmListPatients_Load(null, null);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvPatients.CurrentRow == null)
                return;

            int PatientID = (int)dgvPatients.CurrentRow.Cells[0].Value;

            if (MessageBox.Show("Are you sure you want to delete this patient?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                if (clsPatient.DeletePatient(PatientID))
                {
                    MessageBox.Show("Patient has been deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    frmListPatients_Load(null, null);
                }
                else
                    MessageBox.Show("Patient is not deleted due to data connected to it.", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addNewAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PatientID = (int)dgvPatients.CurrentRow.Cells[0].Value;
            string Name = (string)dgvPatients.CurrentRow.Cells[2].Value;

            frmAddAppointment frm = new frmAddAppointment(PatientID, Name);
            frm.ShowDialog();

            this.Close();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (dgvPatients.CurrentRow == null)
            {
                e.Cancel = true;
                return;
            }

            int PatientID = (int)dgvPatients.SelectedRows[0].Cells["PatientID"].Value;

            if (clsAppointment.IsAppointmentExists(PatientID))
                addNewAppointmentToolStripMenuItem.Enabled = false;
            else
                addNewAppointmentToolStripMenuItem.Enabled = true;
        }
    }
}
