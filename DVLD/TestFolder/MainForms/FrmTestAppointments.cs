using DVLD.ApplicationsFolder.UserControls;
using DVLD.More;
using DVLD.Properties;
using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.TestFolder.MainForms
{
    public partial class FrmTestAppointments : UserControl
    {
        private static DataTable dtAppointments {  get; set; }

        public delegate void OnCloseEvent();
        public event OnCloseEvent CloseEvent;

        
        public ClsTestType.enTestType FrmMode { get; set; }

        public ClsLocalDrivingLicenseApplication localDrivingLicenseApplication { get; set; }
        public int localDrivingLicenseApplicationID { get; set; }

        public FrmTestAppointments()
        {
            InitializeComponent();
        }

        public void RefreshAppointmentsData()
        {
            dtAppointments = ClsTestAppointment.GetApplicantAppointments(localDrivingLicenseApplicationID, (int)FrmMode);

            dgvAppointments.DataSource = dtAppointments;

            lblNumberOfRecords.Text = dgvAppointments.Rows.Count.ToString() + " Appointment.[s]";
        }

        public FrmTestAppointments( int localDrivingLicenseApplicationID)
        {
            InitializeComponent();
            this.localDrivingLicenseApplicationID = localDrivingLicenseApplicationID;

            int PassedTests = ClsLocalDrivingLicenseApplication.GetPassedTests(localDrivingLicenseApplicationID);

            if (localDrivingLicenseApplicationID != -1)
            {
                this.localDrivingLicenseApplication = ClsLocalDrivingLicenseApplication.Find(localDrivingLicenseApplicationID);
                if (this.localDrivingLicenseApplication != null)
                {
                    ucApplicationBasicInfo1.UpdateComponents((ClsApplication)localDrivingLicenseApplication);
                    ucDrivingLicenseApplicationInfo1.UpdateComponents(localDrivingLicenseApplicationID, PassedTests, localDrivingLicenseApplication.LicenseClass.ClassName);
                }
                else
                {
                    MessageBox.Show("Sorry ,can not find the L.D.L.A with ID = " + localDrivingLicenseApplicationID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (PassedTests == 0)
            {
                lblHeaderTitle.Text = "Vision Test Appointments";
                picHeader.Image = Resources.eye__1_;
                FrmMode = ClsTestType.enTestType.VisionTest;
            }
            else if (PassedTests == 1)
            {
                lblHeaderTitle.Text = "Written Test Appointments";
                picHeader.Image = Resources.school__1_;
                FrmMode = ClsTestType.enTestType.WrittenTest;
            }
            else if (PassedTests == 2)
            {
                lblHeaderTitle.Text = "Street Test Appointments";
                picHeader.Image = Resources.drive__1_;
                FrmMode = ClsTestType.enTestType.StreetTest;
            }
            // here or above refresh dgv for Appointments
        }

        private void ucDrivingLicenseApplicationInfo1_Load(object sender, EventArgs e)
        {

        }

        private void ucApplicationBasicInfo1_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmHome.RemoveFromMainPanel();
            CloseEvent?.Invoke();
        }

        private void btnAddTestAppointment_Click(object sender, EventArgs e)
        {
            // if not found not closed do :
            if (!ClsTestAppointment.ThereIsAnActiveAppointment(localDrivingLicenseApplicationID, (int)FrmMode))
            {
                if (!ClsTestAppointment.TestWasPassed(localDrivingLicenseApplicationID, (int)FrmMode))
                {   
                    FrmScheduleTest f = new FrmScheduleTest(-1);
                    f.CloseEvent += RefreshAppointmentsData;
                    FrmHome.AddToMainPanel(f);
                }
                else
                {
                    MessageBox.Show("Sorry ,Test Was Passed", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Sorry ,There is An Active Appointments for this Application" , "Error!" , MessageBoxButtons.OK , MessageBoxIcon.Error);
            }

            
        }

        private void FrmTestAppointments_Load(object sender, EventArgs e)
        {
            RefreshAppointmentsData();
            if (dgvAppointments.Rows.Count > 0)
            {

                dgvAppointments.Columns[0].HeaderText = "Appointment ID";
                dgvAppointments.Columns[0].Width = 266;

                dgvAppointments.Columns[1].HeaderText = "Appointment Date";
                dgvAppointments.Columns[1].Width = 266;


                dgvAppointments.Columns[2].HeaderText = "Paid Fees";
                dgvAppointments.Columns[2].Width = 266;

                dgvAppointments.Columns[3].HeaderText = "Is Locked";
                dgvAppointments.Columns[3].Width = 266;

            }
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmScheduleTest f = new FrmScheduleTest((int)dgvAppointments.CurrentRow.Cells[0].Value);
            f.CloseEvent += RefreshAppointmentsData;
            FrmHome.AddToMainPanel(f);
        }

        private void dgvLocalDrivingLicenseApplications_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {

                showCtmsForAppointmentsDGV();

            }

        }
        private void ResetCtmsForAppoinmentsDGV()
        {
            EditToolStripMenuItem.Enabled = false;
            TakeTestToolStripMenuItem.Enabled = false;
        }

        private void showCtmsForAppointmentsDGV()
        {
            ResetCtmsForAppoinmentsDGV();
            if (dgvAppointments.CurrentCell != null)
            {
                
                bool i = (bool)dgvAppointments.CurrentRow.Cells[3].Value;
                if(i)
                {
                    TakeTestToolStripMenuItem.Enabled = true;
                }
                else
                {
                    TakeTestToolStripMenuItem.Enabled = true;
                    EditToolStripMenuItem.Enabled = true;
                }

                    Rectangle rect = dgvAppointments.GetCellDisplayRectangle(
                        dgvAppointments.CurrentCell.ColumnIndex,
                        dgvAppointments.CurrentCell.RowIndex,
                        false
                    );
                ctmsForAppointmentsDGV.Show(dgvAppointments, rect.Left, rect.Bottom);
            }
        }

        private void dgvAppoinments_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.Handled = true;
                showCtmsForAppointmentsDGV();
                ResetCtmsForAppoinmentsDGV();
            }
        }

        private void TakeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTakeTest f = new FrmTakeTest((int)dgvAppointments.CurrentRow.Cells[0].Value);
            f.CloseEvent += RefreshAppointmentsData;
            FrmHome.AddToMainPanel(f);
        }

        private void btnSwitchFillColor(object sender, EventArgs e)
        {
            ClsUtil.btnSwitchFillColor(sender, e);
        }
    }
}
