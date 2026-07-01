using DVLD.More;
using DVLD_BusinessLayer;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class FrmPeople : UserControl
    {
        private string FilterColumn;
        private static DataTable _dtAllPeople = ClsPerson.GetAllPeople();

        private DataTable _dtPeople = _dtAllPeople.DefaultView.ToTable(
            false,
            "PersonID",
            "NationalNo",
            "FirstName",
            "SecondName",
            "ThirdName",
            "LastName",
            "Gender",
            "DateOfBirth",
            "CountryName",
            "Phone",
            "Email");

        public FrmPeople()
        {
            InitializeComponent();
        }


        private void deleteToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            ((ToolStripMenuItem)sender).ForeColor = Color.DeepPink;
        }

        private void deleteToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            ((ToolStripMenuItem)sender).ForeColor = Color.White;
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPersonDetails f = new FrmPersonDetails((int)dgvPeople.CurrentRow.Cells[0].Value);
            f.CloseEvent += RefreshPeopleData;
            FrmHome.AddToMainPanel(f);
            
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            FrmAddEditPersonInfo f = new FrmAddEditPersonInfo(-1);
            f.CloseEvent1 += RefreshPeopleData;
            FrmHome.AddToMainPanel(f);
        }

        public void RefreshPeopleData()
        {
            _dtAllPeople = ClsPerson.GetAllPeople();
            _dtPeople = _dtAllPeople.DefaultView.ToTable(false, "PersonID", "NationalNo",
                                                       "FirstName", "SecondName", "ThirdName", "LastName",
                                                       "Gender", "DateOfBirth", "CountryName",
                                                       "Phone", "Email");
            dgvPeople.DataSource = _dtPeople;
            txtFilterBy.Text = "";
            lblNumberOfRecords.Text = dgvPeople.Rows.Count.ToString() + " Records";
        }

        private void frmPeople_Load(object sender, EventArgs e)
        {
            RefreshPeopleData();
            if (dgvPeople.Rows.Count > 0)
            {

                dgvPeople.Columns[0].HeaderText = "Person ID";
                dgvPeople.Columns[0].Width = 60;

                dgvPeople.Columns[1].HeaderText = "National No";
                dgvPeople.Columns[1].Width = 75;


                dgvPeople.Columns[2].HeaderText = "First Name";
                dgvPeople.Columns[2].Width = 60;

                dgvPeople.Columns[3].HeaderText = "Second Name";
                dgvPeople.Columns[3].Width = 75;


                dgvPeople.Columns[4].HeaderText = "Third Name";
                dgvPeople.Columns[4].Width = 60;

                dgvPeople.Columns[5].HeaderText = "Last Name";
                dgvPeople.Columns[5].Width = 60;

                dgvPeople.Columns[6].HeaderText = "Gender";
                dgvPeople.Columns[6].Width = 65;

                dgvPeople.Columns[7].HeaderText = "Date Of Birth";
                dgvPeople.Columns[7].Width = 65;

                dgvPeople.Columns[8].HeaderText = "Nationality";
                dgvPeople.Columns[8].Width = 77;


                dgvPeople.Columns[9].HeaderText = "Phone";
                dgvPeople.Columns[9].Width = 70;


                dgvPeople.Columns[10].HeaderText = "Email";
                dgvPeople.Columns[10].Width = 70;
            }
        }

        private void EditPerson_Click(object sender, EventArgs e)
        {
            FrmAddEditPersonInfo f = new FrmAddEditPersonInfo((int)dgvPeople.CurrentRow.Cells[0].Value);
            f.CloseEvent1 += RefreshPeopleData;
            FrmHome.AddToMainPanel(f);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(ClsPerson.DeletePerson((int)dgvPeople.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("Person Deleted Successfully");
            }
            else
            {
                MessageBox.Show("Person has not Deleted Successfully .");
            }
            RefreshPeopleData();
        }

        private void txtFilterBy_TextChanged(object sender, EventArgs e)
        {
            
            if (txtFilterBy.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtPeople.DefaultView.RowFilter = "";
                lblNumberOfRecords.Text = dgvPeople.Rows.Count.ToString() + " Records";
                return;
            }


            if (FilterColumn == "PersonID")
                //in this case we deal with integer not string.

                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterBy.Text.Trim());
            else
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterBy.Text.Trim());

            lblNumberOfRecords.Text = dgvPeople.Rows.Count.ToString() + " Records";

        }

        private void dgvPeople_DoubleClick(object sender, EventArgs e)
        {
            showDetailsToolStripMenuItem_Click(sender, e);
           
        }

        

        private void CmbFilterBy_SelectedValueChanged(object sender, EventArgs e)
        {
            
            string s = CmbFilterBy.Text.Trim().ToLower();

            if (s == "Person ID".Trim().ToLower())
                FilterColumn = "PersonID";
            else if (s == "National No".Trim().ToLower())
                FilterColumn = "NationalNo";
            else if (s == "First Name".Trim().ToLower())
                FilterColumn = "FirstName";
            else if (s == "Second Name".Trim().ToLower())
                FilterColumn = "SecondName";
            else if (s == "Third Name".Trim().ToLower())
                FilterColumn = "ThirdName";
            else if (s == "Last Name".Trim().ToLower())
                FilterColumn = "LastName";
            else if (s == "Country Name".Trim().ToLower())
                FilterColumn = "CountryName";
            else if (s == "Gender".Trim().ToLower())
                FilterColumn = "Gender";
            else if (s == "Phone".Trim().ToLower())
                FilterColumn = "Phone";
            else if (s == "Email".Trim().ToLower())
                FilterColumn = "Email";
            else
                FilterColumn = "None";


            txtFilterBy.Text = "";
            if(s == "None".ToLower())
            {
                txtFilterBy.Enabled = false;
            }
            else
            {
                txtFilterBy.Enabled = true;
            }
        }

        private void txtFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            string s = FilterColumn.Trim().ToLower();

            if (s == "PersonID".Trim().ToLower())
            {
                if (!ClsValidation.IsNumberOrControl(c)) e.Handled = true;
            }
            else if (s== "FirstName".Trim().ToLower() || s == "LastName".Trim().ToLower() 
                || s == "SecondName".Trim().ToLower() || s == "ThirdName".Trim().ToLower())
            {
                if (!ClsValidation.IsLetterOrControl(c)) e.Handled = true;
            }
            else if (s == "Phone".Trim().ToLower())
            {
                if (!ClsValidation.Phone_PressKeyValidation(c, txtFilterBy.Text,txtFilterBy.SelectionStart)) e.Handled = true;
            }
            else if (FilterColumn.Trim().ToLower() == "Email".Trim().ToLower())
            {
                if(!ClsValidation.Email_PressKeyValidation(c,txtFilterBy.Text)) e.Handled = true;
            }
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

        private void btnAddPerson_Enter(object sender, EventArgs e)
        {
            ClsUtil.btnSwitchFillColor(sender, e);
        }

        private void btnSwitchFillColor(object sender, EventArgs e)
        {
            ClsUtil.btnSwitchFillColor(sender, e);
        }

        private void btnAddPerson_Leave(object sender, EventArgs e)
        {
            ClsUtil.btnSwitchFillColor(sender, e);
        }

        private void dgvPeople_KeyPress(object sender, KeyPressEventArgs e)
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

        private void dgvPeople_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.Handled = true;
                if (dgvPeople.CurrentCell != null)
                {
                    Rectangle rect = dgvPeople.GetCellDisplayRectangle(
                        dgvPeople.CurrentCell.ColumnIndex,
                        dgvPeople.CurrentCell.RowIndex,
                        false
                    );
                    ctmsForPeopleDGV.Show(dgvPeople, rect.Left, rect.Bottom);
                }
            }
        }
    }
}
