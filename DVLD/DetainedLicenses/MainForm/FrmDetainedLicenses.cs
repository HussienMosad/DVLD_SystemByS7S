using DVLD.ApplicationsFolder.MainForms;
using DVLD.DetainedLicenses.SecondForms;
using DVLD.Licenses;
using DVLD.Licenses.MainForms;
using DVLD.Licenses.SecondryForms;
using DVLD.More;
using DVLD.TestFolder.MainForms;
using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.DetainedLicenses.MainForm
{
    public partial class FrmDetainedLicenses : UserControl
    {
        private static DataTable dtAllDetainedLicensesDGV = ClsDetainedLicense.GetAllDetainedLicenses();
        private string FilterColumn;

        public FrmDetainedLicenses()
        {
            InitializeComponent();
        }

        private void FrmDetainedLicenses_Load(object sender, EventArgs e)
        {
            RefreshDetainedLicensesDGVData();
            if (dtAllDetainedLicensesDGV.Rows.Count > 0)
            {

                dgvDetainedLicenses.Columns[0].HeaderText = "D.ID";
                dgvDetainedLicenses.Columns[0].Width = 116;

                dgvDetainedLicenses.Columns[1].HeaderText = "L.DI";
                dgvDetainedLicenses.Columns[1].Width = 116;


                dgvDetainedLicenses.Columns[2].HeaderText = "D.Date";
                dgvDetainedLicenses.Columns[2].Width = 116;

                dgvDetainedLicenses.Columns[3].HeaderText = "Is Released";
                dgvDetainedLicenses.Columns[3].Width = 116;


                dgvDetainedLicenses.Columns[4].HeaderText = "Fine Fees";
                dgvDetainedLicenses.Columns[4].Width = 116;

                dgvDetainedLicenses.Columns[5].HeaderText = "R.Date";
                dgvDetainedLicenses.Columns[5].Width = 116;

                dgvDetainedLicenses.Columns[6].HeaderText = "National No";
                dgvDetainedLicenses.Columns[6].Width = 116;

                dgvDetainedLicenses.Columns[7].HeaderText = "Full Name";
                dgvDetainedLicenses.Columns[7].Width = 116;

                dgvDetainedLicenses.Columns[8].HeaderText = "R.App.ID";
                dgvDetainedLicenses.Columns[8].Width = 116;

            }
        }

        public void RefreshDetainedLicensesDGVData()
        {
            dtAllDetainedLicensesDGV = ClsDetainedLicense.GetAllDetainedLicenses();

            dgvDetainedLicenses.DataSource = dtAllDetainedLicensesDGV;
            txtFilterBy.Text = "";
            lblNumberOfRecords.Text = dgvDetainedLicenses.Rows.Count.ToString() + " Records";
        }

        private void btnSwitchFillColor(object sender, EventArgs e)
        {
            ClsUtil.btnSwitchFillColor(sender, e);
        }

        private void dgv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.Handled = true;
                showCtms();
                ResetCtms();
            }
        }

        private void dgv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                showDetailsToolStripMenuItem_Click(sender, e);
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

        private void CmbFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // for windows sound
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }


        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmPersonDetails f = new FrmPersonDetails(ClsPerson.Find((string)dgvDetainedLicenses.CurrentRow.Cells[6].Value).ID);
            f.CloseEvent += RefreshDetainedLicensesDGVData;
            FrmHome.AddToMainPanel(f);
        }

        private void CmbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = CmbFilterBy.Text.Trim().ToLower();

            if (s == "Detain ID".Trim().ToLower())
            {
                FilterColumn = "DetainID";
                txtFilterBy.Visible = true;
                btnIsRelease.Visible = false;
            }
            else if (s == "National No".Trim().ToLower())
            {
                FilterColumn = "NationalNo";
                txtFilterBy.Visible = true;
                btnIsRelease.Visible = false;
            }
            else if (s == "Full Name".Trim().ToLower())
            {
                FilterColumn = "FullName";
                txtFilterBy.Visible = true;
                btnIsRelease.Visible = false;
            }
            else if (s == "Is Released".Trim().ToLower())
            {
                FilterColumn = "IsReleased";
                txtFilterBy.Visible = false;
                btnIsRelease.Visible = true;
            }
            else if (s == "Release Application ID".Trim().ToLower())
            {
                FilterColumn = "ReleaseApplicationID";
                txtFilterBy.Visible = true;
                btnIsRelease.Visible = false;
            }
            else
            {
                FilterColumn = "None";
                txtFilterBy.Visible = false;
                btnIsRelease.Visible = false;
                RefreshDetainedLicensesDGVData();
            }



            txtFilterBy.Text = "";

        }

        private void txtFilterBy_TextChanged(object sender, EventArgs e)
        {
            if (txtFilterBy.Text.Trim() == "" || FilterColumn == "None")
            {
                dtAllDetainedLicensesDGV.DefaultView.RowFilter = "";
                lblNumberOfRecords.Text = dgvDetainedLicenses.Rows.Count.ToString() + " Records";
                return;
            }


            if (FilterColumn == "ReleaseApplicationID" || FilterColumn == "DetainID")
                //in this case we deal with integer not string.

                dtAllDetainedLicensesDGV.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterBy.Text.Trim());
            else
                dtAllDetainedLicensesDGV.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterBy.Text.Trim());

            lblNumberOfRecords.Text = dgvDetainedLicenses.Rows.Count.ToString() + " Records";

        }

        private void txtFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            string s = FilterColumn.Trim().ToLower();

            if (s == "ReleaseApplicationID".Trim().ToLower() || s == "DetainID".Trim().ToLower())
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

        private void btnIsRelease_Click(object sender, EventArgs e)
        {
            if (Convert.ToByte(btnIsRelease.Tag) == 0)
            {
                btnIsRelease.Text = "No";
                btnIsRelease.Tag = 1;
            }
            else if (Convert.ToByte(btnIsRelease.Tag) == 1)
            {
                btnIsRelease.Text = "Yes";
                btnIsRelease.Tag = 0;
            }
            if (FilterColumn.Trim().ToLower() == "IsActive".Trim().ToLower() && Convert.ToByte(btnIsRelease.Tag) == 0)
                dtAllDetainedLicensesDGV.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, true);
            else
                dtAllDetainedLicensesDGV.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, false);
            lblNumberOfRecords.Text = dgvDetainedLicenses.Rows.Count.ToString() + " Records";
        }

        private void ResetCtms()
        {
            ReleaseLicenseToolStripMenuItem.Enabled = false;
        }

        private void showCtms()
        {
            ResetCtms();
            if (dgvDetainedLicenses.CurrentCell != null)
            {
                bool i = (bool)dgvDetainedLicenses.CurrentRow.Cells[3].Value;
                if (!i) { ReleaseLicenseToolStripMenuItem.Enabled = true; }

                Rectangle rect = dgvDetainedLicenses.GetCellDisplayRectangle(
                    dgvDetainedLicenses.CurrentCell.ColumnIndex,
                    dgvDetainedLicenses.CurrentCell.RowIndex,
                    false
                );
                ctms.Show(dgvDetainedLicenses, rect.Left, rect.Bottom);
            }
        }

        private void dgvLocalDrivingLicenseApplications_MouseDown(object sender, MouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Right)
            {

                showCtms();

            }

        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLicenseInfo f = new FrmLicenseInfo((int)dgvDetainedLicenses.CurrentRow.Cells[1].Value);
            FrmHome.AddToMainPanel(f);
        }

        private void PersonLicensesHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            FrmDetainALicense f = new FrmDetainALicense();
            f.CloseEvent += RefreshDetainedLicensesDGVData;
            FrmHome.AddToMainPanel(f);
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            FrmReleaseALicense f = new FrmReleaseALicense(-1);
            f.CloseEvent += RefreshDetainedLicensesDGVData;
            FrmHome.AddToMainPanel(f);
        }

        private void ReleaseLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReleaseALicense f = new FrmReleaseALicense((int)dgvDetainedLicenses.CurrentRow.Cells[0].Value);
            f.CloseEvent += RefreshDetainedLicensesDGVData;
            FrmHome.AddToMainPanel(f);
        }
    }
}
