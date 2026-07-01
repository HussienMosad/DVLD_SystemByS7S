using DVLD.ApplicationsFolder.MainForms;
using DVLD.More;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using DVLD_BusinessLayer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.ApplicationsFolder.SecondryForms
{
    public partial class FrmEditTestType : UserControl
    {
        public delegate void OnCloseEvent();
        public event OnCloseEvent CloseEvent;

        private ClsTestType TestType;

        public FrmEditTestType(ClsTestType TestType)
        {
            InitializeComponent();
            this.TestType = TestType;

            if (TestType != null)
            {
                txtFees.Text = TestType.TestTypeFees.ToString();
                txtTitle.Text = TestType.TestTypeTitle;
                lblID.Text = ((int)TestType.ID).ToString();
                txtDescription.Text = TestType.TestTypeDescription;
            }
        }

        private void btnSwitchFillColor(object sender, EventArgs e)
        {
            ClsUtil.btnSwitchFillColor(sender, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Please enter all details ...", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TestType.ID = (ClsTestType.enTestType)Convert.ToInt32(lblID.Text);
            TestType.TestTypeTitle = txtTitle.Text.Trim();
            TestType.TestTypeFees = Convert.ToSingle(txtFees.Text);
            TestType.TestTypeDescription = txtDescription.Text.Trim();

            if (TestType.Save())
            {
                MessageBox.Show("Details Saved Successfully ...", "Done",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Details did not Save...", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                e.Handled = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }

            if (!ClsValidation.IsNumberOrControl(e.KeyChar))
                e.Handled = true;

            if (txtFees.Text.Length == 6 && !ClsValidation.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtFees_Validating(object sender, CancelEventArgs e)
        {
            ClsUtil.ttMessageCantBeEmpty(sender, e);
        }

        private void txtTitle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }

            if (txtTitle.Text.Length == 150 && !ClsValidation.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtTitle_Validating(object sender, CancelEventArgs e)
        {
            ClsUtil.ttMessageCantBeEmpty(sender, e);
        }

        private void txtDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }

            if (txtDescription.Text.Length == 500 && !ClsValidation.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            ClsUtil.ttMessageCantBeEmpty(sender, e);
        }
    }
}
