using DVLD.ApplicationTypes.Forms;
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

namespace DVLD.ApplicationTypes
{
    public partial class FrmApplicationTypes : UserControl
    {


        private static DataTable _dtAllApplicationTypes = ClsApplicationType.GetAllApplicationTypes();

        public void RefreshApplicationTypesData()
        {
            _dtAllApplicationTypes = ClsApplicationType.GetAllApplicationTypes();
   
            dgvApplicationTypes.DataSource = _dtAllApplicationTypes;

            lblNumberOfRecords.Text = dgvApplicationTypes.Rows.Count.ToString() + " Records";
        }

        private void frmApplicationTypes_Load(object sender, EventArgs e)
        {
            RefreshApplicationTypesData();
            if (dgvApplicationTypes.Rows.Count > 0)
            {

                dgvApplicationTypes.Columns[0].HeaderText = "ID";
                dgvApplicationTypes.Columns[0].Width = 10;

                dgvApplicationTypes.Columns[1].HeaderText = "Title";
                dgvApplicationTypes.Columns[1].Width = 50;


                dgvApplicationTypes.Columns[2].HeaderText = "Fees";
                dgvApplicationTypes.Columns[2].Width = 200;
            }
        }

        public FrmApplicationTypes()
        {

            InitializeComponent();
        }

        private void dgvApplicationTypes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.Handled = true;
                if (dgvApplicationTypes.CurrentCell != null)
                {
                    Rectangle rect = dgvApplicationTypes.GetCellDisplayRectangle(
                        dgvApplicationTypes.CurrentCell.ColumnIndex,
                        dgvApplicationTypes.CurrentCell.RowIndex,
                        false
                    );
                    ctmsForMAppTypeDGV.Show(dgvApplicationTypes, rect.Left, rect.Bottom);
                }
            }
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = (int)dgvApplicationTypes.CurrentRow.Cells[0].Value;
            string title = (string)dgvApplicationTypes.CurrentRow.Cells[1].Value;
            float fees = Convert.ToSingle(dgvApplicationTypes.CurrentRow.Cells[2].Value);

            ClsApplicationType applicationType = new ClsApplicationType(id, title, fees);
            
            FrmEditApplicationType f = new FrmEditApplicationType(applicationType);
            f.CloseEvent += RefreshApplicationTypesData;
            FrmHome.AddToMainPanel(f);
        }

        private void dgvApplicationTypes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                EditToolStripMenuItem_Click(sender, e);
            }

        }
    }
}
