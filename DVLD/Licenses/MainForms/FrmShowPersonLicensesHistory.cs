using DVLD.Licenses.SecondryForms;
using DVLD.More;
using DVLD.People.UserControls;
using DVLD_BusinessLayer;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Licenses.MainForms
{
    public partial class FrmShowPersonLicensesHistory : UserControl
    {
        public delegate void OnCloseEvent();
        public event OnCloseEvent CloseEvent;

        public ClsDriver Driver {  get; set; }

        public FrmShowPersonLicensesHistory()
        { 
        
        }

        public FrmShowPersonLicensesHistory(int DriverID)
        {
            InitializeComponent();

            Driver = ClsDriver.FindByDriverID(DriverID);
            ucPersonDetailsWithFilter1.UpdateComponent(Driver.Person);
            ucPersonDetailsWithFilter1.UnEnable(); 
        }

        private void btnSwitchFillColor(object sender, EventArgs e)
        {
            ClsUtil.btnSwitchFillColor(sender, e);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmHome.RemoveFromMainPanel();
            CloseEvent?.Invoke();
        }

        private void btnLocal_Click(object sender, EventArgs e)
        {
            UcLocalOrInterNationalLicenseHistory f = new UcLocalOrInterNationalLicenseHistory(Driver.DriverID);
            f.Mode = UcLocalOrInterNationalLicenseHistory.enMode.Local;
            FrmHome.AddToMainPanel(f);
        }

        private void btnInternational_Click(object sender, EventArgs e)
        {
            UcLocalOrInterNationalLicenseHistory f = new UcLocalOrInterNationalLicenseHistory(Driver.DriverID);
            f.Mode = UcLocalOrInterNationalLicenseHistory.enMode.International;
            FrmHome.AddToMainPanel(f);
        }
    }
}
