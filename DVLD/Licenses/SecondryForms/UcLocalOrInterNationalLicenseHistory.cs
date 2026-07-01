using DVLD.InternationalLicenses.SecondryForms;
using DVLD.More;
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

namespace DVLD.Licenses.SecondryForms
{
    public partial class UcLocalOrInterNationalLicenseHistory : UserControl
    {
        public enum enMode { Local = 0, International = 1 }
        public enMode Mode { get; set; }
        private static DataTable dtAllLicenses {  get; set; }

        public int DriverID {  get; set; }

        public UcLocalOrInterNationalLicenseHistory()
        {
            InitializeComponent();
        }

        public void RefreshLicensesData()
        {
            
            if (Mode == enMode.International)
            {
                dtAllLicenses = ClsInternationalLicense.GetLicenseHistory(DriverID);
                dgvLicenses.DataSource = dtAllLicenses;
                lblNumberOfRecords.Text = dgvLicenses.Rows.Count.ToString() + " Records";
            }
            else
            {
                dtAllLicenses = ClsLocalLicense.GetLicenseHistory(DriverID);
                dgvLicenses.DataSource = dtAllLicenses;
                lblNumberOfRecords.Text = dgvLicenses.Rows.Count.ToString() + " Records";
            }
        }

        private void FrmLicense_Load(object sender, EventArgs e)
        {
            RefreshLicensesData();
            if (dtAllLicenses.Rows.Count > 0)
            {
                if (Mode == enMode.Local)
                {
                    dgvLicenses.Columns[0].HeaderText = "License ID";
                    dgvLicenses.Columns[0].Width = 127;

                    dgvLicenses.Columns[1].HeaderText = "Application ID";
                    dgvLicenses.Columns[1].Width = 127;


                    dgvLicenses.Columns[2].HeaderText = "Class Name";
                    dgvLicenses.Columns[2].Width = 147;

                    dgvLicenses.Columns[3].HeaderText = "Issue Date";
                    dgvLicenses.Columns[3].Width = 167;


                    dgvLicenses.Columns[4].HeaderText = "Expiration Date";
                    dgvLicenses.Columns[4].Width = 167;

                    dgvLicenses.Columns[5].HeaderText = "Is Active";
                    dgvLicenses.Columns[5].Width = 149;
                }
                else
                {
                    dgvLicenses.Columns[0].HeaderText = "Int.License ID";
                    dgvLicenses.Columns[0].Width = 127;

                    dgvLicenses.Columns[1].HeaderText = "Application ID";
                    dgvLicenses.Columns[1].Width = 127;


                    dgvLicenses.Columns[2].HeaderText = "L.License ID";
                    dgvLicenses.Columns[2].Width = 147;

                    dgvLicenses.Columns[3].HeaderText = "Issue Date";
                    dgvLicenses.Columns[3].Width = 167;


                    dgvLicenses.Columns[4].HeaderText = "Expiration Date";
                    dgvLicenses.Columns[4].Width = 167;

                    dgvLicenses.Columns[5].HeaderText = "Is Active";
                    dgvLicenses.Columns[5].Width = 149;
                }
            }

        }

        public UcLocalOrInterNationalLicenseHistory(int DriverID)
        {
            InitializeComponent();
            this.DriverID = DriverID;
        }

        private void btnSwitchFillColor(object sender, EventArgs e)
        {
            ClsUtil.btnSwitchFillColor(sender, e);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmHome.RemoveFromMainPanel();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Mode == enMode.International)
            {
                
                FrmInternationalLicenseInfo f = new FrmInternationalLicenseInfo((int)dgvLicenses.CurrentRow.Cells[0].Value);
                FrmHome.AddToMainPanel(f);
            }
            else
            {
                int localDrivingLicenseApplicationID = ClsLocalDrivingLicenseApplication.GitLDLAIDbyApplicationID((int)dgvLicenses.CurrentRow.Cells[1].Value);
                FrmLicenseInfo f = new FrmLicenseInfo(localDrivingLicenseApplicationID);
                FrmHome.AddToMainPanel(f);
            }
        }

        private void dgv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.Handled = true;
                showCtmsForDLADGV();
            }
        }
        private void showCtmsForDLADGV()
        {
            if (dgvLicenses.CurrentCell != null)
            {
                Rectangle rect = dgvLicenses.GetCellDisplayRectangle(
                    dgvLicenses.CurrentCell.ColumnIndex,
                    dgvLicenses.CurrentCell.RowIndex,
                    false
                );
                ctmsForLicensesDGV.Show(dgvLicenses, rect.Left, rect.Bottom);
            }
        }
    }
}
