using DVLD.Licenses;
using DVLD.Licenses.MainForms;
using DVLD.Licenses.SecondryForms;
using DVLD.More;
using DVLD.Properties;
using DVLD.TestFolder.MainForms;
using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DVLD.ApplicationsFolder.MainForms
{
    public partial class FrmLocalDrivingLicenseApplications : UserControl
    {

        
        private static DataTable dtAllLDLADGV = ClsLocalDrivingLicenseApplication.GetAllLocalDrivingLicenseApplications();
        private string FilterColumn;

        //private DataTable _dtPeople = _dtAllPeople.DefaultView.ToTable(false, "PersonID", "NationalNo",
        //                                                 "FirstName", "SecondName", "ThirdName", "LastName",
        //                                                 "Gender", "DateOfBirth", "CountryName",

        private void FrmLocalDrivingLicenseApplications_Load(object sender, EventArgs e)
        {
            RefreshLDLADGVData();
            if (dtAllLDLADGV.Rows.Count > 0)
            {

                dgvLocalDrivingLicenseApplications.Columns[0].HeaderText = "L.D.L.A.ID";
                dgvLocalDrivingLicenseApplications.Columns[0].Width = 129;

                dgvLocalDrivingLicenseApplications.Columns[1].HeaderText = "Class Name";
                dgvLocalDrivingLicenseApplications.Columns[1].Width = 169;


                dgvLocalDrivingLicenseApplications.Columns[2].HeaderText = "National No";
                dgvLocalDrivingLicenseApplications.Columns[2].Width = 139;

                dgvLocalDrivingLicenseApplications.Columns[3].HeaderText = "Full Name";
                dgvLocalDrivingLicenseApplications.Columns[3].Width = 159;


                dgvLocalDrivingLicenseApplications.Columns[4].HeaderText = "Application Date";
                dgvLocalDrivingLicenseApplications.Columns[4].Width = 149;

                dgvLocalDrivingLicenseApplications.Columns[5].HeaderText = "Passed Test Count";
                dgvLocalDrivingLicenseApplications.Columns[5].Width = 149;

                dgvLocalDrivingLicenseApplications.Columns[6].HeaderText = "Status";
                dgvLocalDrivingLicenseApplications.Columns[6].Width = 149;

            }
        }

        public void RefreshLDLADGVData()
        {
            dtAllLDLADGV = ClsLocalDrivingLicenseApplication.GetAllLocalDrivingLicenseApplications();
           
            dgvLocalDrivingLicenseApplications.DataSource = dtAllLDLADGV;
            txtFilterBy.Text = "";
            lblNumberOfRecords.Text = dgvLocalDrivingLicenseApplications.Rows.Count.ToString() + " Records";
        }

        public FrmLocalDrivingLicenseApplications()
        {
            InitializeComponent();
            

        }

        private void btnSwitchFillColor(object sender, EventArgs e)
        {
            ClsUtil.btnSwitchFillColor(sender, e);
        }

        private void dgvLocalDrivingLicenseApplications_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.Handled = true;
                showCtmsForDLADGV();
                ResetCtmsForDLADGV();
            }
        }

        private void dgvLocalDrivingLicenseApplications_KeyPress(object sender, KeyPressEventArgs e)
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
            
            FrmLocalDrivingLicenseApplicationInfo f = new FrmLocalDrivingLicenseApplicationInfo((int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value);
            f.CloseEvent += RefreshLDLADGVData;
            FrmHome.AddToMainPanel(f);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmNewLocalDrivingLicenseApplication f = new FrmNewLocalDrivingLicenseApplication(-1);
            f.CloseEvent += RefreshLDLADGVData;
            FrmHome.AddToMainPanel(f);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ClsLocalDrivingLicenseApplication.Delete((int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("Application Deleted Successfully");
            }
            else
            {
                MessageBox.Show("Application has not Deleted Successfully .");
            }
            RefreshLDLADGVData();
        }

        private void CancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ClsLocalDrivingLicenseApplication.Cancel((int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("Application Deleted Successfully");
            }
            else
            {
                MessageBox.Show("Application has not Deleted Successfully .");
            }
            RefreshLDLADGVData();
        }

        private void CmbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = CmbFilterBy.Text.Trim().ToLower();

            if (s == "L.D.L.AppID".Trim().ToLower())
            {
                FilterColumn = "LocalDrivingLicenseApplicationID";
                txtFilterBy.Visible = true;
                btnStatus.Visible = false;
            }
            else if (s == "National No".Trim().ToLower())
            {
                FilterColumn = "NationalNo";
                txtFilterBy.Visible = true;
                btnStatus.Visible = false;
            }
            else if (s == "Full Name".Trim().ToLower())
            {
                FilterColumn = "FullName";
                txtFilterBy.Visible = true;
                btnStatus.Visible = false;
            }
            else if (s == "Status".Trim().ToLower())
            {
                FilterColumn = "Status";
                txtFilterBy.Visible = false;
                btnStatus.Visible = true;
            }
            else
            {
                FilterColumn = "None";
                txtFilterBy.Visible = false;
                btnStatus.Visible = false;
                RefreshLDLADGVData();
            }


            txtFilterBy.Text = "";
            
        }

        private void txtFilterBy_TextChanged(object sender, EventArgs e)
        {
            if (txtFilterBy.Text.Trim() == "" || FilterColumn == "None")
            {
                dtAllLDLADGV.DefaultView.RowFilter = "";
                lblNumberOfRecords.Text = dgvLocalDrivingLicenseApplications.Rows.Count.ToString() + " Records";
                return;
            }


            if (FilterColumn == "LocalDrivingLicenseApplicationID")
                //in this case we deal with integer not string.

                dtAllLDLADGV.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterBy.Text.Trim());
            else
                dtAllLDLADGV.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterBy.Text.Trim());

            lblNumberOfRecords.Text = dgvLocalDrivingLicenseApplications.Rows.Count.ToString() + " Records";

        }

        private void txtFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            string s = FilterColumn.Trim().ToLower();

            if (s == "LocalDrivingLicenseApplicationID".Trim().ToLower())
            {
                if (!ClsValidation.IsNumberOrControl(c)) e.Handled = true;
            }
            else if (s == "FullName".Trim().ToLower())
            {
                if (!ClsValidation.IsLetterOrControlOrSpace(c)) e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // for windows sound
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void btnIsActive_Click(object sender, EventArgs e)
        {
            if (Convert.ToByte(btnStatus.Tag) == 3)
            {
                btnStatus.Text = "New";
                btnStatus.Tag = 1;
            }
            else if(Convert.ToByte(btnStatus.Tag) == 1)
            {
                btnStatus.Text = "Cancelled";
                btnStatus.Tag = 2;
            }
            else if (Convert.ToByte(btnStatus.Tag) == 2)
            {
                btnStatus.Text = "Completed";
                btnStatus.Tag = 3;
            }
            dtAllLDLADGV.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, btnStatus.Text);
            lblNumberOfRecords.Text = dgvLocalDrivingLicenseApplications.Rows.Count.ToString() + " Records";
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNewLocalDrivingLicenseApplication f = new FrmNewLocalDrivingLicenseApplication((int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value);
            f.CloseEvent += RefreshLDLADGVData;
            FrmHome.AddToMainPanel(f);
        }

        private void ScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ResetCtmsForDLADGV()
        {
            deleteToolStripMenuItem.Enabled = false;
            CancelToolStripMenuItem.Enabled = false;
            showLicenseToolStripMenuItem.Enabled = false;
            visionTestToolStripMenuItem.Enabled = false;
            writtenToolStripMenuItem.Enabled = false;
            streetTestToolStripMenuItem.Enabled=false;
            ScheduleToolStripMenuItem.Enabled = false;
            issueToolStripMenuItem.Enabled = false;
            EditToolStripMenuItem.Enabled = false;
        }

        private void showCtmsForDLADGV()
        {
            ResetCtmsForDLADGV();
            if (dgvLocalDrivingLicenseApplications.CurrentCell != null)
            {
                string s = dgvLocalDrivingLicenseApplications.CurrentRow.Cells[6].Value.ToString().Trim().ToLower();
                int i = (int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[5].Value;
                if (s =="New".ToLower().Trim())
                {
                    CancelToolStripMenuItem.Enabled = true;
                    if (i ==0)
                    {
                        EditToolStripMenuItem.Enabled = true;
                        deleteToolStripMenuItem.Enabled = true;
                        //CancelToolStripMenuItem.Enabled = true;
                        ScheduleToolStripMenuItem.Enabled = true;
                        visionTestToolStripMenuItem.Enabled = true;
                    }
                    else if(i ==1 ) 
                    {
                        //CancelToolStripMenuItem.Enabled = true;
                        ScheduleToolStripMenuItem.Enabled = true;
                        writtenToolStripMenuItem .Enabled = true;
                    }
                    else if (i == 2)
                    {
                        //CancelToolStripMenuItem.Enabled = true;
                        ScheduleToolStripMenuItem.Enabled = true;
                        streetTestToolStripMenuItem.Enabled = true;
                    }
                    else if (i == 3 )
                    {
                        issueToolStripMenuItem.Enabled = true;
                        //CancelToolStripMenuItem .Enabled = true;
                    }
                }
                else if (s == "cancelled".ToLower().Trim())
                {
                    if (i == 0)
                    {
                        deleteToolStripMenuItem.Enabled = true;
                    }
                }
                else if (s == "Completed".ToLower().Trim())
                {
                    showLicenseToolStripMenuItem.Enabled = true;
                }


                Rectangle rect = dgvLocalDrivingLicenseApplications.GetCellDisplayRectangle(
                    dgvLocalDrivingLicenseApplications.CurrentCell.ColumnIndex,
                    dgvLocalDrivingLicenseApplications.CurrentCell.RowIndex,
                    false
                );
                ctmsForDLADGV.Show(dgvLocalDrivingLicenseApplications, rect.Left, rect.Bottom);
            }
        }

        private void dgvLocalDrivingLicenseApplications_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                
                showCtmsForDLADGV();
                
            }
            
        }

        private void ScheduleTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTestAppointments f = new FrmTestAppointments((int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value);
            f.CloseEvent += RefreshLDLADGVData;
            FrmHome.AddToMainPanel(f);
        }

        private void ScheduleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void issueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIssueLicenseForTheFirstTime f = new FrmIssueLicenseForTheFirstTime((int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value);
            f.CloseEvent += RefreshLDLADGVData;
            FrmHome.AddToMainPanel(f);
        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLicenseInfo f = new FrmLicenseInfo((int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value); 
            FrmHome.AddToMainPanel(f);
        }

        private void PersonLicensesHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ClsDriver driver = ClsDriver.FindByPersonID(ClsPerson.Find((string)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[2].Value).ID);
            if (driver != null)
            {
                FrmShowPersonLicensesHistory f = new FrmShowPersonLicensesHistory(driver.DriverID);
                FrmHome.AddToMainPanel(f);
            }
            else
            {
                MessageBox.Show("Person is not a Driver.");
            }
        }
    }
}
