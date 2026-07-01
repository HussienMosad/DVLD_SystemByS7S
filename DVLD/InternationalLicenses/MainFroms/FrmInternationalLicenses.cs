using DVLD.ApplicationsFolder.MainForms;
using DVLD.InternationalLicenses.SecondryForms;
using DVLD.Licenses;
using DVLD.Licenses.MainForms;
using DVLD.Licenses.SecondryForms;
using DVLD.More;
using DVLD.Properties;
using DVLD.TestFolder.MainForms;
using DVLD_BusinessLayer;
using Guna.UI2.WinForms.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.InternationalLicenses
{
    public partial class FrmInternationalLicenses : UserControl
    {
        public FrmInternationalLicenses()
        {
            InitializeComponent();
        }

        private static DataTable dtAllInterNationalLicenses = ClsInternationalLicense.GetAllInternationalLicenses();
        private string FilterColumn;

        private void FrmInternationalLicenses_Load(object sender, EventArgs e)
        {
            RefreshInternationalLicensesData();
            if (dtAllInterNationalLicenses.Rows.Count > 0)
            {

                dgvInternationalLicenses.Columns[0].HeaderText = "Int.License ID";
                dgvInternationalLicenses.Columns[0].Width = 139;

                dgvInternationalLicenses.Columns[1].HeaderText = "Application ID";
                dgvInternationalLicenses.Columns[1].Width = 139;


                dgvInternationalLicenses.Columns[2].HeaderText = "Driver ID";
                dgvInternationalLicenses.Columns[2].Width = 139;

                dgvInternationalLicenses.Columns[3].HeaderText = "L.License ID";
                dgvInternationalLicenses.Columns[3].Width = 139;


                dgvInternationalLicenses.Columns[4].HeaderText = "Issue Date";
                dgvInternationalLicenses.Columns[4].Width = 169;

                dgvInternationalLicenses.Columns[5].HeaderText = "Expiration Date";
                dgvInternationalLicenses.Columns[5].Width = 169;

                dgvInternationalLicenses.Columns[6].HeaderText = "Is Active";
                dgvInternationalLicenses.Columns[6].Width = 149;

            }
        }

        public void RefreshInternationalLicensesData()
        {
            dtAllInterNationalLicenses = ClsInternationalLicense.GetAllInternationalLicenses();

            dgvInternationalLicenses.DataSource = dtAllInterNationalLicenses;
            txtFilterBy.Text = "";
            lblNumberOfRecords.Text = dgvInternationalLicenses.Rows.Count.ToString() + " Records";
        }

        private void btnSwitchFillColor(object sender, EventArgs e)
        {
            ClsUtil.btnSwitchFillColor(sender, e);
        }

        private void dgvInternationalLicenses_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.Handled = true;
                showCtmsForInternationalLicensesDGV();
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

        private void CmbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = CmbFilterBy.Text.Trim().ToLower();
            
            if (s == "International License ID".Trim().ToLower())
            {
                FilterColumn = "InternationalLicenseID";
                txtFilterBy.Visible = true;
                btnIsActive.Visible = false;
            }
            else if (s == "Application ID".Trim().ToLower())
            {
                FilterColumn = "ApplicationID";
                txtFilterBy.Visible = true;
                btnIsActive.Visible = false;
            }
            else if (s == "Driver ID".Trim().ToLower())
            {
                FilterColumn = "DriverID";
                txtFilterBy.Visible = true;
                btnIsActive.Visible = false;
            }
            else if (s == "Local License ID".Trim().ToLower())
            {
                FilterColumn = "IssuedUsingLocalLicenseID";
                txtFilterBy.Visible = false;
                btnIsActive.Visible = true;
            }
            else if (s == "Is Active".Trim().ToLower())
            {
                FilterColumn = "IsActive";
                txtFilterBy.Visible = false;
                btnIsActive.Visible = true;
            }
            else
            {
                FilterColumn = "None";
                txtFilterBy.Visible = false;
                btnIsActive.Visible = false;
                RefreshInternationalLicensesData();
            }


            txtFilterBy.Text = "";

        }

        private void btnIsActive_Click(object sender, EventArgs e)
        {
            if (Convert.ToByte(btnIsActive.Tag) == 1)
            {
                btnIsActive.Image = Resources.no_entry;
                btnIsActive.Tag = 0;
            }
            else
            {
                btnIsActive.Image = Resources.user_check;
                btnIsActive.Tag = 1;
            }

            if (FilterColumn.Trim().ToLower() == "IsActive".Trim().ToLower() && Convert.ToByte(btnIsActive.Tag) == 1)
                dtAllInterNationalLicenses.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, true);
            else
                dtAllInterNationalLicenses.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, false);

            lblNumberOfRecords.Text = dgvInternationalLicenses.Rows.Count.ToString() + " Records";
        }

        private void txtFilterBy_TextChanged(object sender, EventArgs e)
        {
            if (txtFilterBy.Text.Trim() == "" || FilterColumn == "None")
            {
                dtAllInterNationalLicenses.DefaultView.RowFilter = "";
                lblNumberOfRecords.Text = dgvInternationalLicenses.Rows.Count.ToString() + " Records";
                return;
            }


            dtAllInterNationalLicenses.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterBy.Text.Trim());

            lblNumberOfRecords.Text = dgvInternationalLicenses.Rows.Count.ToString() + " Records";

        }

        private void txtFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            string s = FilterColumn.Trim().ToLower();

            if (!ClsValidation.IsNumberOrControl(c)) e.Handled = true;
            
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; 
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void showCtmsForInternationalLicensesDGV()
        {
            if (dgvInternationalLicenses.CurrentCell != null)
            {
                Rectangle rect = dgvInternationalLicenses.GetCellDisplayRectangle(
                    dgvInternationalLicenses.CurrentCell.ColumnIndex,
                    dgvInternationalLicenses.CurrentCell.RowIndex,
                    false
                );
                ctmsForDLADGV.Show(dgvInternationalLicenses, rect.Left, rect.Bottom);
            }
        }

        private void dgvInternationalLicenses_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {

                showCtmsForInternationalLicensesDGV();

            }

        }

        private void PersonLicensesHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShowPersonLicensesHistory f = new FrmShowPersonLicensesHistory((int)dgvInternationalLicenses.CurrentRow.Cells[2].Value);
            FrmHome.AddToMainPanel(f);   
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHome.AddToMainPanel(new FrmPersonDetails(ClsDriver.FindByDriverID((int)dgvInternationalLicenses.CurrentRow.Cells[2].Value).PersonID));
        }

        private void ShowLicenseMenuItem_Click(object sender, EventArgs e)
        {
            FrmHome.AddToMainPanel(new FrmInternationalLicenseInfo((int)dgvInternationalLicenses.CurrentRow.Cells[0].Value));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmNewInternationalLicenseApplication f = new FrmNewInternationalLicenseApplication();
            f.CloseEvent += RefreshInternationalLicensesData;
            FrmHome.AddToMainPanel(f);
        }
    }
}
