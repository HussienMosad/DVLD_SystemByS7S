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

namespace DVLD.People.Forms.MainForm
{
    public partial class FrmFindPerson : UserControl
    {
        public delegate void OnCloseEvent();
        public event OnCloseEvent CloseEvent;
        public FrmFindPerson()
        {
            InitializeComponent();
            
        }

        public void UpdateComponent(ClsPerson Person)
        {
            if (Person.ID != -1) {
                ucPersonDetailsWithFilter.UpdateComponent(Person);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmHome.MainPanel.Controls.Remove(this);
            FrmHome.MainPanel.Controls[FrmHome.MainPanel.Controls.Count-1].Focus();
            FrmHome.MainPanel.Controls[0].Visible = true;
            
        }
    }
}
