using DVLD.More;
using DVLD.Properties;
using DVLD.Users.Forms.SecondryForms;
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

namespace DVLD.Users.Forms.MainForm
{
    public partial class FrmUsers : UserControl
    {
        
        private static DataTable _dtAllUsers = ClsUser.GetAllUsers();
        private string FilterColumn;

        private DataTable _dtUsers = _dtAllUsers.DefaultView.ToTable(false, "UserID", "PersonID",
                                                         "FullName", "UserName", "IsActive");

        public FrmUsers()
        {
            InitializeComponent();
        }


        public void RefreshUsersData()
        {
            _dtAllUsers = ClsUser.GetAllUsers();
            _dtUsers = _dtAllUsers.DefaultView.ToTable(false, "UserID", "PersonID",
                                                         "FullName", "UserName", "IsActive");
            dgvUsers.DataSource = _dtUsers;
            txtFilterBy.Text = "";
            lblNumberOfRecords.Text = dgvUsers.Rows.Count.ToString() + " Records";
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            RefreshUsersData();
            if (dgvUsers.Rows.Count > 0)
            {

                dgvUsers.Columns[0].HeaderText = "User ID";
                dgvUsers.Columns[0].Width = 30;

                dgvUsers.Columns[1].HeaderText = "Person ID";
                dgvUsers.Columns[1].Width = 30;


                dgvUsers.Columns[2].HeaderText = "Full Name";
                dgvUsers.Columns[2].Width = 50;

                dgvUsers.Columns[3].HeaderText = "User Name";
                dgvUsers.Columns[3].Width = 30;


                dgvUsers.Columns[4].HeaderText = "Is Active";
                dgvUsers.Columns[4].Width = 150;

            }
        }
        private void CmbFilterBy_SelectedValueChanged(object sender, EventArgs e)
        {

            string s = CmbFilterBy.Text.Trim().ToLower();

            if (s == "Person ID".Trim().ToLower())
            {
                FilterColumn = "PersonID";
                txtFilterBy.Visible = true;
                btnIsActive.Visible = false;
            }
            else if (s == "User ID".Trim().ToLower())
            {
                FilterColumn = "UserID";
                txtFilterBy.Visible = true;
                btnIsActive.Visible = false;
            }
            else if (s == "Full Name".Trim().ToLower())
            {
                FilterColumn = "FullName";
                txtFilterBy.Visible = true;
                btnIsActive.Visible = false;
            }
            else if (s == "User Name".Trim().ToLower())
            {
                FilterColumn = "UserName";
                txtFilterBy.Visible = true;
                btnIsActive.Visible = false;
            }
            else if (s == "Is Active".Trim().ToLower())
            {
                FilterColumn = "IsActive";
                btnIsActive.Visible = true;
                txtFilterBy.Visible = false;
            }
            else if (s == "None".ToLower())
            {
                FilterColumn = "None";
                txtFilterBy.Visible = false;
                btnIsActive.Visible = false;
                RefreshUsersData();
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
                _dtUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, true );
            else
                _dtUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn,false);

            lblNumberOfRecords.Text = dgvUsers.Rows.Count.ToString() + " Records";
        }

        

        private void txtFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            string s = FilterColumn.Trim().ToLower();

            if (s == "PersonID".Trim().ToLower() || s == "UserID".Trim().ToLower())
            {
                if (!ClsValidation.IsNumberOrControl(c)) e.Handled = true;
            }
            else if (s == "FullName".Trim().ToLower())
            {
                if (!ClsValidation.IsLetterOrControlOrSpace(c)) e.Handled = true;
            }
            else if (s == "UserName".Trim().ToLower())
            {
                if (!ClsValidation.IsLetterOrControlOrNumber(c)) e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // for windows sound
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txtFilterBy_TextChanged(object sender, EventArgs e)
        {
            /*
             // this method will refresh The data every time you enter a char 
             if (txtFilterBy.Text.Trim() == "") 
            {
                RefreshPeopleData();
            }
            else
            {
                RefreshPeopleData(CmbFilterBy.SelectedItem.ToString(), txtFilterBy.Text.Trim());
            }*/
            //Reset the filters in case nothing selected or filter value conains nothing.
            if (txtFilterBy.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtUsers.DefaultView.RowFilter = "";
                lblNumberOfRecords.Text = dgvUsers.Rows.Count.ToString() + " Records";
                return;
            }
            else if (FilterColumn.Trim().ToLower() == "PersonID".Trim().ToLower() || FilterColumn.Trim().ToLower() == "UserID".Trim().ToLower())
                //in this case we deal with integer not string.

               _dtUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterBy.Text.Trim());
            else
               _dtUsers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterBy.Text.Trim());

            lblNumberOfRecords.Text = dgvUsers.Rows.Count.ToString() + " Records";
            

        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUserDetails f = new FrmUserDetails((int)dgvUsers.CurrentRow.Cells[0].Value);
            f.CloseEvent += RefreshUsersData;
            FrmHome.AddToMainPanel(f);
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChangeUserPassword f = new FrmChangeUserPassword((int)dgvUsers.CurrentRow.Cells[0].Value);
            f.CloseEvent += RefreshUsersData;
            FrmHome.AddToMainPanel(f);
        }

        private void CmbFilterBy_Enter(object sender, EventArgs e)
        {
            CmbFilterBy.ForeColor = Color.Red;
        }

        private void CmbFilterBy_Leave(object sender, EventArgs e)
        {
            CmbFilterBy.ForeColor = ClsSettings.BlueMainColor;
        }

        private void btnSwitchFillColor(object sender, EventArgs e)
        {
            ClsUtil.btnSwitchFillColor(sender, e);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddEditUser f = new FrmAddEditUser((int)dgvUsers.CurrentRow.Cells[0].Value);
            f.CloseEvent += RefreshUsersData;
            FrmHome.AddToMainPanel(f);
        }

        private void dgvUsers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.Handled = true;
                if (dgvUsers.CurrentCell != null)
                {
                    Rectangle rect = dgvUsers.GetCellDisplayRectangle(
                        dgvUsers.CurrentCell.ColumnIndex,
                        dgvUsers.CurrentCell.RowIndex,
                        false
                    );
                    ctmsForUsersDGV.Show(dgvUsers, rect.Left, rect.Bottom);
                }
            }
        }

        private void dgvUsers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                showDetailsToolStripMenuItem_Click(sender, e);
            }
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAddUser_Click(sender, e);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(ClsUser.DeleteUser((int)dgvUsers.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("User Deleted Successfully");
            }
            else
            {
                MessageBox.Show("User has not Deleted Successfully .");
            }
            RefreshUsersData();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            FrmAddEditUser f = new FrmAddEditUser(-1);
            f.CloseEvent += RefreshUsersData;
            FrmHome.AddToMainPanel(f);
        }

        private void CmbFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // for windows sound
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }
    }
}
