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

namespace DVLD.People.UserControls
{
    public partial class UcPersonDetailsWithFilter : UserControl
    {
        public ClsPerson Person;

        public UcPersonDetailsWithFilter()
        {
            InitializeComponent();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            FrmHome.AddToMainPanel(new FrmAddEditPersonInfo(-1));
        }

        public void UpdateComponent(ClsPerson person)
        {
            this.Person = person;
            ucPersonDetails1.UpdateComponent(person);
        }

        private void txtFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CmbFilterBy.SelectedItem.ToString().Trim().ToLower() == "Person ID".Trim().ToLower())
            {
                if (!ClsValidation.IsNumberOrControl(e.KeyChar)) e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // for windows sound
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void btnFindPerson_Click(object sender, EventArgs e)
        {
            if(txtFilterBy.Text.Length == 0) return;

            if (CmbFilterBy.SelectedItem.ToString().Trim().ToLower() == "Person ID".Trim().ToLower())
            {
                Person = ClsPerson.Find(Convert.ToInt16(txtFilterBy.Text));
                if (Person != null)
                {
                    UpdateComponent(Person);
                }
                else
                {
                    MessageBox.Show("Can not find Person with ID = " +  txtFilterBy.Text);
                }
            }
            else if(CmbFilterBy.SelectedItem.ToString().Trim().ToLower() == "NationalNo".Trim().ToLower())
            {
                Person = ClsPerson.Find(txtFilterBy.Text);
                if (Person != null)
                {
                    UpdateComponent(Person);
                }
                else
                {
                    MessageBox.Show("Can not find Person with NationalNo = " + txtFilterBy.Text);
                }
            }
        }

        private void CmbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterBy.Text = "";
        }

        private void btnSwitchFillColor(object sender, EventArgs e)
        {
            ClsUtil.btnSwitchFillColor(sender, e);
        }

        private void CmbFilterBy_Enter(object sender, EventArgs e)
        {
            CmbFilterBy.ForeColor = Color.Red;
        }

        private void CmbFilterBy_Leave(object sender, EventArgs e)
        {
            CmbFilterBy.ForeColor = ClsSettings.BlueMainColor;
        }

        public void EditFormatForUserAddWithFilter()
        {
            ucPersonDetails1.EditFormatForUserChangePassword();
        }

        private void CmbFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // for windows sound
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }
        public void UnEnable()
        {
            btnFindPerson.Enabled = false;
            txtFilterBy.Enabled = false;
            CmbFilterBy.Enabled = false ;
            btnAddPerson.Enabled = false ;
        }
    }
}
