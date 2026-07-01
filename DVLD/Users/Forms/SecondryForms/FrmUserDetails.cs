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

namespace DVLD.Users.Forms.SecondryForms
{
    public partial class FrmUserDetails : UserControl
    {
        public delegate void OnCloseEvent();
        public event OnCloseEvent CloseEvent;

        private ClsUser User { get; set; }


        public FrmUserDetails(int UserID)
        {
            InitializeComponent();
            User = ClsUser.Find(UserID);
            if (User != null)
            {
                UpdateComponent(User);
            }
            else
            {
                MessageBox.Show("Sorry , Can not found the user." , "Error!" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public void UpdateComponent(ClsUser User)
        {
            ucUserDetails1.UpdateComponent(User);
        }

        public void UpdateJustPersonComponent(ClsPerson Person)
        {
            ucUserDetails1.UpdateJustPersonComponent(Person);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
            CloseEvent?.Invoke();
            FrmHome.RemoveFromMainPanel();

        }

        private void btnEditPerson_Click(object sender, EventArgs e)
        {
            FrmAddEditPersonInfo f = new FrmAddEditPersonInfo(User.PersonID);
            f.CloseEvent2 += UpdateJustPersonComponent;
            FrmHome.AddToMainPanel(f);
        }

        private void btnSwitchFillColor(object sender, EventArgs e)
        {
            ClsUtil.btnSwitchFillColor(sender, e);
        }
    }
}
