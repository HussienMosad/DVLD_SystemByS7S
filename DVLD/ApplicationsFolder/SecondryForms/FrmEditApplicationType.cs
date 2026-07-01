using DVLD.More;
using DVLD.Users.Forms.MainForm;
using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.ApplicationTypes.Forms
{
    public partial class FrmEditApplicationType : UserControl
    {
        public delegate void OnCloseEvent();
        public event OnCloseEvent CloseEvent;
        private ClsApplicationType ApplicationType;

        public FrmEditApplicationType(ClsApplicationType ApplicationType)
        {
            InitializeComponent();
            this.ApplicationType = ApplicationType;
            if (ApplicationType != null)
            {
                txtFees.Text = ApplicationType.Fees.ToString();
                txtTitle.Text = ApplicationType.Title;
                lblID.Text = ApplicationType.ID.ToString();
            }
        }

        private void btnSwitchFillColor(object sender, EventArgs e)
        {
           ClsUtil.btnSwitchFillColor(sender, e);
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                MessageBox.Show("Please Enter the all details ..." , "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ApplicationType.ID = Convert.ToInt32(lblID.Text);
            ApplicationType.Title = txtTitle.Text.Trim();
            ApplicationType.Fees = Convert.ToInt32(txtFees.Text);
            if(ApplicationType.Save())
            {
                MessageBox.Show("Details Saved Successfully ..." , "Done" , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Details did not Save...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmHome.RemoveFromMainPanel();
            CloseEvent?.Invoke();
        }

        private void txtFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // for windows sound
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
            if (!ClsValidation.IsNumberOrControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (txtFees.Text.Length == 6 && !ClsValidation.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            
        }

        private void txtFees_Validating(object sender, CancelEventArgs e)
        {
            ClsUtil.ttMessageCantBeEmpty(sender, e);
        }

        private void txtTitle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // for windows sound
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
            if (txtFees.Text.Length == 150 && !ClsValidation.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTitle_Validating(object sender, CancelEventArgs e)
        {
            ClsUtil.ttMessageCantBeEmpty(sender, e);
        }
    }
}
