using DVLD.More;
using DVLD.Users.Forms.MainForm;
using DVLD.Users.Forms.SecondryForms;
using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DVLD
{
    public partial class FrmHome : Form
    {
        

        public FrmHome()
        {
            InitializeComponent();
            InitializeBtns();
            MainPanel = this.pnlMain;
        }

        public static void RemoveFromMainPanel()
        {
            UserControl Uc = (UserControl)MainPanel.Controls[MainPanel.Controls.Count - 1];
            MainPanel.Controls.Remove(Uc);
            Uc.Dispose();
            Uc = null;
            MainPanel.Controls[MainPanel.Controls.Count - 1].Visible = true;
            MainPanel.Controls[MainPanel.Controls.Count - 1].Focus();
        }
        public static void AddToMainPanel(UserControl Uc)
        {
            Uc.Dock = DockStyle.Fill;
            if (MainPanel.Controls.Count > 0)
            {
                MainPanel.Controls[MainPanel.Controls.Count - 1].Visible = false;
            }
            MainPanel.Controls.Add(Uc);
            Uc.Focus();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloseFrm()
        {
            this.Close();
        }

        private void btnMinimizedTheFrm(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            
        }

        private void btnsSideBarClick(object sender, EventArgs e)
        {
            Guna2GradientButton b = ((Guna2GradientButton)sender);
            TurnOffBtnsLight();
            ClsUtil.CheckTheButton(b);
            AddFrmToPnlMain(Convert.ToByte(b.Tag));
        }

        private void btnsSideBarEnter_Enter(object sender, EventArgs e)
        {
            Guna2GradientButton b = ((Guna2GradientButton)sender);
            TurnOffBtnsLight();
            ClsUtil.CheckTheButton(b);
        }

        private void btnSwitchFillColor(object sender, EventArgs e)
        {
            Guna2GradientButton b = (Guna2GradientButton)sender;
            Color t = b.FillColor;
            b.FillColor = b.FillColor2;
            b.FillColor2 = t;
        }
    }
}
