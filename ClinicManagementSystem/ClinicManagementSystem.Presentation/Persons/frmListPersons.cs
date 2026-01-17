using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ClinicManagementSystem.BuisnessLogic;


namespace ClinicManagementSystem.Presentation
{
    public partial class frmListPersons : Form
    {
        private static DataTable _AllPersons;

        public frmListPersons()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListPersons_Load(object sender, EventArgs e)
        {
            _AllPersons = clsPerson.GetAllPersons();
            dgvPersons.DataSource = _AllPersons;

            cbFilterBy.SelectedIndex = 0;

            _ConfigurePersonsGrid();


            lblRecordsCount.Text = _AllPersons.Rows.Count.ToString();
        }

        private void _ConfigurePersonsGrid()
        {
            // Header
            dgvPersons.EnableHeadersVisualStyles = false;
            dgvPersons.ColumnHeadersHeight = 36;
            dgvPersons.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            dgvPersons.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvPersons.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);
            dgvPersons.ColumnHeadersDefaultCellStyle.SelectionBackColor =
                Color.FromArgb(240, 240, 240);
            dgvPersons.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Black;

            // Cells
            dgvPersons.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dgvPersons.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue;
            dgvPersons.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Behavior
            dgvPersons.AllowUserToAddRows = false;
            dgvPersons.ReadOnly = true;
            dgvPersons.MultiSelect = false;
            dgvPersons.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Layout
            dgvPersons.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPersons.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvPersons.ScrollBars = ScrollBars.Vertical;

            dgvPersons.RowHeadersVisible = false;
            dgvPersons.BackgroundColor = Color.White;
            dgvPersons.BorderStyle = BorderStyle.FixedSingle;
        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson();
            frm.ShowDialog();


            frmListPersons_Load(null, null);
        }

        private void frmListPersons_Shown(object sender, EventArgs e)
        {
            dgvPersons.ClearSelection();
            dgvPersons.CurrentCell = null;
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
                case "PersonID":
                    FilterColumn = "PersonID";
                    break;
                case "Name":
                    FilterColumn = "Name";
                    break;
                case "Gender":
                    FilterColumn = "Gender";
                    break;
                case "Address":
                    FilterColumn = "Address";
                    break;
                default:
                    FilterColumn = "None";
                    break;
            }
            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _AllPersons.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvPersons.Rows.Count.ToString();
                return;
            }

            if (FilterColumn != "Name" && FilterColumn != "Gender" && FilterColumn != "Address")
                _AllPersons.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
            else
                _AllPersons.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());

            lblRecordsCount.Text = _AllPersons.Rows.Count.ToString();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvPersons.CurrentRow == null)
                return;

            int PersonID = (int)dgvPersons.CurrentRow.Cells[0].Value;

            if (MessageBox.Show("Are you sure you want to delete this person?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                if (clsPerson.DeletePerson(PersonID))
                {
                    MessageBox.Show("Person has been deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    frmListPersons_Load(null, null);
                }
                else
                    MessageBox.Show("Person is not deleted due to data connected to it.", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvPersons.CurrentRow.Cells[0].Value;

            frmPersonDetails frm = new frmPersonDetails(PersonID);
            frm.ShowDialog();

            frmListPersons_Load(null, null);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvPersons.CurrentRow.Cells[0].Value;

            frmAddEditPerson frm = new frmAddEditPerson(PersonID);
            frm.ShowDialog();

            frmListPersons_Load(null, null);
        }
    }
}