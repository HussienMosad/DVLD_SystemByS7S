using DVLD.ApplicationsFolder.SecondryForms;
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

namespace DVLD.ApplicationsFolder.MainForms
{
    public partial class FrmTestTypes : UserControl
    {

        private static DataTable _dtAllTestTypes = ClsTestType.GetAllTestTypes();

        public void RefreshTestTypesData()
        {
            _dtAllTestTypes = ClsTestType.GetAllTestTypes();

            dgvTestTypes.DataSource = _dtAllTestTypes;

            lblNumberOfRecords.Text = dgvTestTypes.Rows.Count.ToString() + " Records";
        }

        private void FrmTestTypes_Load(object sender, EventArgs e)
        {
            RefreshTestTypesData();

            if (dgvTestTypes.Rows.Count > 0)
            {
                dgvTestTypes.Columns[0].HeaderText = "ID";
                dgvTestTypes.Columns[0].Width = 50;

                dgvTestTypes.Columns[1].HeaderText = "Title";
                dgvTestTypes.Columns[1].Width = 150;

                dgvTestTypes.Columns[2].HeaderText = "Description";
                dgvTestTypes.Columns[2].Width = 300;

                dgvTestTypes.Columns[3].HeaderText = "Fees";
                dgvTestTypes.Columns[3].Width = 80;
            }
        }

        public FrmTestTypes()
        {
            InitializeComponent();
        }

        private void dgvTestTypes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.Handled = true;

                if (dgvTestTypes.CurrentCell != null)
                {
                    Rectangle rect = dgvTestTypes.GetCellDisplayRectangle(
                        dgvTestTypes.CurrentCell.ColumnIndex,
                        dgvTestTypes.CurrentCell.RowIndex,
                        false
                    );

                    ctmsForTestTypesDGV.Show(dgvTestTypes, rect.Left, rect.Bottom);
                }
            }
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClsTestType.enTestType id = (ClsTestType.enTestType)dgvTestTypes.CurrentRow.Cells[0].Value;
            string title = (string)dgvTestTypes.CurrentRow.Cells[1].Value;
            string description = (string)dgvTestTypes.CurrentRow.Cells[2].Value;
            float fees = Convert.ToSingle(dgvTestTypes.CurrentRow.Cells[3].Value);

            ClsTestType testType = new ClsTestType(id, title, description, fees);
            
            FrmEditTestType f = new FrmEditTestType(testType);
            f.CloseEvent += RefreshTestTypesData;
            FrmHome.AddToMainPanel(f);
        }

        private void dgvTestTypes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                EditToolStripMenuItem_Click(sender, e);
            }
        }

    }
}
