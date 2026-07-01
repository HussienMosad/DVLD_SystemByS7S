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

namespace DVLD
{
    public partial class FrmPersonDetails : UserControl
    {
        public delegate void OnCloseEvent();
        public event OnCloseEvent CloseEvent;

        private ClsPerson Person { get; set; }

        public FrmPersonDetails(int PersonID)
        {
            InitializeComponent();
            Person = ClsPerson.Find(PersonID);
            if (Person != null)
            {
                UpdateComponent(Person);
            }
          

        }

        public void UpdateComponent(ClsPerson Person)
        {
            UcPersonDetails.UpdateComponent(Person);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // is it need to be generic ?

            FrmHome.RemoveFromMainPanel();
            CloseEvent?.Invoke();

        }

        private void btnEditPerson_Click(object sender, EventArgs e)
        {
            FrmAddEditPersonInfo f = new FrmAddEditPersonInfo(Person.ID);
            f.CloseEvent2 += UpdateComponent;
            FrmHome.AddToMainPanel(f);
        }

        private void btnSwitchFillColor(object sender, EventArgs e)
        {
            ClsUtil.btnSwitchFillColor(sender, e);
        }
    }
}
