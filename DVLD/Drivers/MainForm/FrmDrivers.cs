using DVLD.ApplicationsFolder.MainForms;
using DVLD.Licenses.MainForms;
using DVLD.More;
using DVLD_BusinessLayer;
using Guna.UI2.WinForms.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Drivers
{
    public partial class FrmDrivers : UserControl
    {
        private static DataTable dtAllDrivers = ClsDriver.GetAllDrivers();
        private string FilterColumn;


        public FrmDrivers()
        {
            InitializeComponent();
        }

        private void FrmDrivers_Load(object sender, EventArgs e)
        {
            RefreshDriversData();
            if (dtAllDrivers.Rows.Count > 0)
            {

                dgvDrivers.Columns[0].HeaderText = "Driver ID";
                dgvDrivers.Columns[0].Width = 127;

                dgvDrivers.Columns[1].HeaderText = "Person ID";
                dgvDrivers.Columns[1].Width = 127;


                dgvDrivers.Columns[2].HeaderText = "National No";
                dgvDrivers.Columns[2].Width = 147;

                dgvDrivers.Columns[3].HeaderText = "Full Name";
                dgvDrivers.Columns[3].Width = 167;


                dgvDrivers.Columns[4].HeaderText = "Created Date";
                dgvDrivers.Columns[4].Width = 167;

                dgvDrivers.Columns[5].HeaderText = "Active License";
                dgvDrivers.Columns[5].Width = 149;

            }

        }

        public void RefreshDriversData()
        {
            dtAllDrivers = ClsDriver.GetAllDrivers();
            dgvDrivers.DataSource = dtAllDrivers;
            lblNumberOfRecords.Text = dgvDrivers.Rows.Count.ToString() + " Records";
            txtFilterBy.Text = "";
        }

        private void dgvDrivers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.Handled = true;
                showCtmsForDriversDGV();
            }
        }

        private void dgvDrivers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                showDetailsToolStripMenuItem_Click(sender, e);
            }
        }

        private void CmbFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // for windows sound
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void CmbFilterBy_Enter(object sender, EventArgs e)
        {
            CmbFilterBy.ForeColor = Color.Red;
        }

        private void CmbFilterBy_Leave(object sender, EventArgs e)
        {
            CmbFilterBy.ForeColor = ClsSettings.BlueMainColor;
        }

        private void CmbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = CmbFilterBy.Text.Trim().ToLower();

            if (s == "Driver ID".Trim().ToLower())
            {
                FilterColumn = "DriverID";
                txtFilterBy.Visible = true;
                
            }
            else if (s == "Person ID".Trim().ToLower())
            {
                FilterColumn = "PersonID";
                txtFilterBy.Visible = true;
            }
            else if (s == "Full Name".Trim().ToLower())
            {
                FilterColumn = "FullName";
                txtFilterBy.Visible = true;
            }
            else if (s == "National No".Trim().ToLower())
            {
                FilterColumn = "NationalNo";
                txtFilterBy.Visible = true;
            }
            else if (s == "Active License".Trim().ToLower())
            {
                FilterColumn = "ActiveLicense";
                txtFilterBy.Visible = true;
            }
            else
            {
                FilterColumn = "None";
                txtFilterBy.Visible = false;
                RefreshDriversData();
            }


            txtFilterBy.Text = "";

        }

        private void txtFilterBy_TextChanged(object sender, EventArgs e)
        {
            string s = FilterColumn.Trim().ToLower();
            if (txtFilterBy.Text.Trim() == "" || s == "None".Trim().ToLower())
            {
                dtAllDrivers.DefaultView.RowFilter = "";
                lblNumberOfRecords.Text = dgvDrivers.Rows.Count.ToString() + " Records";
                return;
            }


            if (s.Trim().ToLower() == "PersonID".Trim().ToLower() || s.Trim().ToLower() == "DriverID".Trim().ToLower() || s.Trim().ToLower() == "ActiveLicense".Trim().ToLower())
                
                dtAllDrivers.DefaultView.RowFilter = string.Format("[{0}] = {1}", s, txtFilterBy.Text.Trim());
            else
                dtAllDrivers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", s, txtFilterBy.Text.Trim());

            lblNumberOfRecords.Text = dgvDrivers.Rows.Count.ToString() + " Records";

        }

        private void txtFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            string s = FilterColumn.Trim().ToLower();

            if (s == "PersonID".Trim().ToLower() || s == "DriverID".Trim().ToLower() || s == "ActiveLicense".Trim().ToLower())
            {
                if (!ClsValidation.IsNumberOrControl(c)) e.Handled = true;
            }
            else
            {
                if (!ClsValidation.IsLetterOrControlOrSpace(c)) e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // for windows sound
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void showCtmsForDriversDGV()
        {
            if (dgvDrivers.CurrentCell != null)
            {
                Rectangle rect = dgvDrivers.GetCellDisplayRectangle(
                    dgvDrivers.CurrentCell.ColumnIndex,
                    dgvDrivers.CurrentCell.RowIndex,
                    false
                );
                ctmsForDLADGV.Show(dgvDrivers, rect.Left, rect.Bottom);
            }
        }

        private void dgvDrivers_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {

                showCtmsForDriversDGV();

            }

        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmPersonDetails f = new FrmPersonDetails((int)dgvDrivers.CurrentRow.Cells[1].Value);
            f.CloseEvent += RefreshDriversData;
            FrmHome.AddToMainPanel(f);
        }

        private void PersonLicensesHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHome.AddToMainPanel(new FrmShowPersonLicensesHistory((int)dgvDrivers.CurrentRow.Cells[0].Value));
        }
    }
}
