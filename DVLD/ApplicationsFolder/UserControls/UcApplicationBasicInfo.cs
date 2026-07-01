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

namespace DVLD.ApplicationsFolder.UserControls
{
    public partial class UcApplicationBasicInfo : UserControl
    {
        public UcApplicationBasicInfo()
        {
            InitializeComponent();
        }

        public int PersonID { get; set; }
        public ClsApplication Application1 { get; set; }

        public void UpdateComponents(ClsApplication Application)
        {
            Application1 = Application;
            labAppID.Text = Application.ApplicationID.ToString();
            labStatus.Text = Application.ApplicationStatus.ToString();
            labFees.Text = Application.PaidFees.ToString();
            labApplicant.Text = Application.GetApplicantFullName(); 
            labDate.Text = Application.ApplicationDate.ToString();
            labDateStatus.Text = Application.LastStatusDate.ToString();
            labCreatedBy.Text = Application.User.UserName;
            PersonID = Application.Person.ID;
        }

        private void btnSwitchFillColor(object sender, EventArgs e)
        {
            ClsUtil.btnSwitchFillColor(sender, e);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        public void RefreshApplicantName()
        {
            Application1.Person = ClsPerson.Find(PersonID);
            labApplicant.Text = Application1.GetApplicantFullName();
        }

        private void btnShowPersonDetails_Click(object sender, EventArgs e)
        {
            FrmPersonDetails f = new FrmPersonDetails(PersonID);
            f.CloseEvent += RefreshApplicantName;
            FrmHome.AddToMainPanel(f);
        }
    }
}
