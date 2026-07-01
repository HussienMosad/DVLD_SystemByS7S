using DVLD;
using DVLD.Drivers;
using DVLD.More;
using DVLD.People.Forms.MainForm;
using DVLD.Users.Forms.MainForm;
using DVLD.Users.Forms.SecondryForms;
using Guna.UI2.WinForms;
using System.Windows.Forms;

namespace DVLD
{
    partial class FrmHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            this.pnlLeftHome = new System.Windows.Forms.Panel();
            this.btnSettings = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnUsers = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnDrivers = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnPeople = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnApplactions = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblAslan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.picCar = new System.Windows.Forms.PictureBox();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pnlUpHome = new System.Windows.Forms.Panel();
            this.btnMinimizeTheFrm = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnClose = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlLeftHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCar)).BeginInit();
            this.pnlUpHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeftHome
            // 
            this.pnlLeftHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pnlLeftHome.Controls.Add(this.btnSettings);
            this.pnlLeftHome.Controls.Add(this.btnUsers);
            this.pnlLeftHome.Controls.Add(this.btnDrivers);
            this.pnlLeftHome.Controls.Add(this.btnPeople);
            this.pnlLeftHome.Controls.Add(this.btnApplactions);
            this.pnlLeftHome.Controls.Add(this.lblAslan);
            this.pnlLeftHome.Controls.Add(this.label1);
            this.pnlLeftHome.Controls.Add(this.lblProjectName);
            this.pnlLeftHome.Controls.Add(this.picCar);
            this.pnlLeftHome.Controls.Add(this.guna2GradientButton1);
            this.pnlLeftHome.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftHome.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlLeftHome.ForeColor = System.Drawing.Color.White;
            this.pnlLeftHome.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftHome.MaximumSize = new System.Drawing.Size(280, 788);
            this.pnlLeftHome.MinimumSize = new System.Drawing.Size(280, 788);
            this.pnlLeftHome.Name = "pnlLeftHome";
            this.pnlLeftHome.Size = new System.Drawing.Size(280, 788);
            this.pnlLeftHome.TabIndex = 0;
            this.pnlLeftHome.TabStop = true;
            // 
            // btnSettings
            // 
            this.btnSettings.Animated = true;
            this.btnSettings.BorderRadius = 10;
            this.btnSettings.CheckedState.Font = new System.Drawing.Font("Impact", 25F);
            this.btnSettings.CheckedState.Parent = this.btnSettings;
            this.btnSettings.CustomImages.Parent = this.btnSettings;
            this.btnSettings.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSettings.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSettings.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnSettings.HoverState.Font = new System.Drawing.Font("Impact", 25F);
            this.btnSettings.HoverState.Parent = this.btnSettings;
            this.btnSettings.Image = global::DVLD.Properties.Resources.Settings;
            this.btnSettings.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSettings.ImageOffset = new System.Drawing.Point(-3, -5);
            this.btnSettings.ImageSize = new System.Drawing.Size(55, 55);
            this.btnSettings.Location = new System.Drawing.Point(0, 551);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(0);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.ShadowDecoration.Parent = this.btnSettings;
            this.btnSettings.Size = new System.Drawing.Size(280, 82);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.Tag = "4";
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextOffset = new System.Drawing.Point(1, 0);
            this.btnSettings.Click += new System.EventHandler(this.btnsSideBarClick);
            this.btnSettings.Enter += new System.EventHandler(this.btnsSideBarEnter_Enter);
            // 
            // btnUsers
            // 
            this.btnUsers.Animated = true;
            this.btnUsers.BorderRadius = 10;
            this.btnUsers.CheckedState.Font = new System.Drawing.Font("Impact", 25F);
            this.btnUsers.CheckedState.Parent = this.btnUsers;
            this.btnUsers.CustomImages.Parent = this.btnUsers;
            this.btnUsers.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnUsers.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnUsers.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnUsers.HoverState.Font = new System.Drawing.Font("Impact", 25F);
            this.btnUsers.HoverState.Parent = this.btnUsers;
            this.btnUsers.Image = global::DVLD.Properties.Resources.Users;
            this.btnUsers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUsers.ImageOffset = new System.Drawing.Point(-4, -2);
            this.btnUsers.ImageSize = new System.Drawing.Size(55, 55);
            this.btnUsers.Location = new System.Drawing.Point(0, 469);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(0);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.ShadowDecoration.Parent = this.btnUsers;
            this.btnUsers.Size = new System.Drawing.Size(280, 82);
            this.btnUsers.TabIndex = 4;
            this.btnUsers.Tag = "3";
            this.btnUsers.Text = "Users";
            this.btnUsers.TextOffset = new System.Drawing.Point(-15, 0);
            this.btnUsers.Click += new System.EventHandler(this.btnsSideBarClick);
            this.btnUsers.Enter += new System.EventHandler(this.btnsSideBarEnter_Enter);
            // 
            // btnDrivers
            // 
            this.btnDrivers.Animated = true;
            this.btnDrivers.BorderRadius = 10;
            this.btnDrivers.CheckedState.Font = new System.Drawing.Font("Impact", 25F);
            this.btnDrivers.CheckedState.Parent = this.btnDrivers;
            this.btnDrivers.CustomImages.Parent = this.btnDrivers;
            this.btnDrivers.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnDrivers.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnDrivers.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrivers.ForeColor = System.Drawing.Color.White;
            this.btnDrivers.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnDrivers.HoverState.Font = new System.Drawing.Font("Impact", 25F);
            this.btnDrivers.HoverState.Parent = this.btnDrivers;
            this.btnDrivers.Image = global::DVLD.Properties.Resources.driver;
            this.btnDrivers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDrivers.ImageOffset = new System.Drawing.Point(-5, -5);
            this.btnDrivers.ImageSize = new System.Drawing.Size(55, 55);
            this.btnDrivers.Location = new System.Drawing.Point(0, 387);
            this.btnDrivers.Margin = new System.Windows.Forms.Padding(0);
            this.btnDrivers.Name = "btnDrivers";
            this.btnDrivers.ShadowDecoration.Parent = this.btnDrivers;
            this.btnDrivers.Size = new System.Drawing.Size(280, 82);
            this.btnDrivers.TabIndex = 3;
            this.btnDrivers.Tag = "2";
            this.btnDrivers.Text = "Drivers";
            this.btnDrivers.TextOffset = new System.Drawing.Point(-10, 0);
            this.btnDrivers.Click += new System.EventHandler(this.btnsSideBarClick);
            this.btnDrivers.Enter += new System.EventHandler(this.btnsSideBarEnter_Enter);
            // 
            // btnPeople
            // 
            this.btnPeople.Animated = true;
            this.btnPeople.BorderRadius = 10;
            this.btnPeople.CheckedState.Font = new System.Drawing.Font("Impact", 25F);
            this.btnPeople.CheckedState.Parent = this.btnPeople;
            this.btnPeople.CustomImages.Parent = this.btnPeople;
            this.btnPeople.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnPeople.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnPeople.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeople.ForeColor = System.Drawing.Color.White;
            this.btnPeople.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnPeople.HoverState.Font = new System.Drawing.Font("Impact", 25F);
            this.btnPeople.HoverState.Parent = this.btnPeople;
            this.btnPeople.Image = global::DVLD.Properties.Resources.People;
            this.btnPeople.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPeople.ImageOffset = new System.Drawing.Point(-5, -5);
            this.btnPeople.ImageSize = new System.Drawing.Size(55, 55);
            this.btnPeople.Location = new System.Drawing.Point(0, 305);
            this.btnPeople.Margin = new System.Windows.Forms.Padding(0);
            this.btnPeople.Name = "btnPeople";
            this.btnPeople.ShadowDecoration.Parent = this.btnPeople;
            this.btnPeople.Size = new System.Drawing.Size(280, 82);
            this.btnPeople.TabIndex = 2;
            this.btnPeople.Tag = "1";
            this.btnPeople.Text = "People";
            this.btnPeople.TextOffset = new System.Drawing.Point(-11, 0);
            this.btnPeople.Click += new System.EventHandler(this.btnsSideBarClick);
            this.btnPeople.Enter += new System.EventHandler(this.btnsSideBarEnter_Enter);
            // 
            // btnApplactions
            // 
            this.btnApplactions.Animated = true;
            this.btnApplactions.BorderRadius = 10;
            this.btnApplactions.CheckedState.Font = new System.Drawing.Font("Impact", 25F);
            this.btnApplactions.CheckedState.Parent = this.btnApplactions;
            this.btnApplactions.CustomImages.Parent = this.btnApplactions;
            this.btnApplactions.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnApplactions.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnApplactions.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplactions.ForeColor = System.Drawing.Color.White;
            this.btnApplactions.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnApplactions.HoverState.Font = new System.Drawing.Font("Impact", 25F);
            this.btnApplactions.HoverState.Parent = this.btnApplactions;
            this.btnApplactions.Image = global::DVLD.Properties.Resources.Applications;
            this.btnApplactions.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnApplactions.ImageOffset = new System.Drawing.Point(-11, -5);
            this.btnApplactions.ImageSize = new System.Drawing.Size(64, 64);
            this.btnApplactions.Location = new System.Drawing.Point(0, 223);
            this.btnApplactions.Margin = new System.Windows.Forms.Padding(0);
            this.btnApplactions.Name = "btnApplactions";
            this.btnApplactions.ShadowDecoration.Parent = this.btnApplactions;
            this.btnApplactions.Size = new System.Drawing.Size(280, 82);
            this.btnApplactions.TabIndex = 1;
            this.btnApplactions.Tag = "0";
            this.btnApplactions.Text = "Applications";
            this.btnApplactions.TextOffset = new System.Drawing.Point(20, 0);
            this.btnApplactions.Click += new System.EventHandler(this.btnsSideBarClick);
            this.btnApplactions.Enter += new System.EventHandler(this.btnsSideBarEnter_Enter);
            // 
            // lblAslan
            // 
            this.lblAslan.AutoSize = true;
            this.lblAslan.BackColor = System.Drawing.Color.White;
            this.lblAslan.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAslan.ForeColor = System.Drawing.Color.Gray;
            this.lblAslan.Location = new System.Drawing.Point(94, 89);
            this.lblAslan.Name = "lblAslan";
            this.lblAslan.Size = new System.Drawing.Size(87, 29);
            this.lblAslan.TabIndex = 2;
            this.lblAslan.Text = "S 7 S";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "by";
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.lblProjectName.Location = new System.Drawing.Point(12, 5);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(261, 39);
            this.lblProjectName.TabIndex = 0;
            this.lblProjectName.Text = "D          V          L          D";
            // 
            // picCar
            // 
            this.picCar.Image = global::DVLD.Properties.Resources.car;
            this.picCar.Location = new System.Drawing.Point(0, 0);
            this.picCar.Name = "picCar";
            this.picCar.Size = new System.Drawing.Size(280, 194);
            this.picCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCar.TabIndex = 0;
            this.picCar.TabStop = false;
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.Animated = true;
            this.guna2GradientButton1.BorderRadius = 10;
            this.guna2GradientButton1.CheckedState.Font = new System.Drawing.Font("Impact", 25F);
            this.guna2GradientButton1.CheckedState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.CustomImages.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.guna2GradientButton1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.guna2GradientButton1.HoverState.Font = new System.Drawing.Font("Impact", 25F);
            this.guna2GradientButton1.HoverState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton1.ImageOffset = new System.Drawing.Point(-11, -5);
            this.guna2GradientButton1.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2GradientButton1.Location = new System.Drawing.Point(127, 160);
            this.guna2GradientButton1.Margin = new System.Windows.Forms.Padding(0);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.ShadowDecoration.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Size = new System.Drawing.Size(10, 10);
            this.guna2GradientButton1.TabIndex = 0;
            this.guna2GradientButton1.Tag = "0";
            this.guna2GradientButton1.TextOffset = new System.Drawing.Point(20, 0);
            // 
            // pnlUpHome
            // 
            this.pnlUpHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.pnlUpHome.Controls.Add(this.btnMinimizeTheFrm);
            this.pnlUpHome.Controls.Add(this.btnClose);
            this.pnlUpHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUpHome.Location = new System.Drawing.Point(280, 0);
            this.pnlUpHome.Name = "pnlUpHome";
            this.pnlUpHome.Size = new System.Drawing.Size(1090, 45);
            this.pnlUpHome.TabIndex = 1;
            this.pnlUpHome.TabStop = true;
            // 
            // btnMinimizeTheFrm
            // 
            this.btnMinimizeTheFrm.Animated = true;
            this.btnMinimizeTheFrm.AutoRoundedCorners = true;
            this.btnMinimizeTheFrm.BorderRadius = 19;
            this.btnMinimizeTheFrm.CheckedState.Parent = this.btnMinimizeTheFrm;
            this.btnMinimizeTheFrm.CustomImages.Parent = this.btnMinimizeTheFrm;
            this.btnMinimizeTheFrm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnMinimizeTheFrm.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnMinimizeTheFrm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMinimizeTheFrm.ForeColor = System.Drawing.Color.White;
            this.btnMinimizeTheFrm.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnMinimizeTheFrm.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnMinimizeTheFrm.HoverState.Parent = this.btnMinimizeTheFrm;
            this.btnMinimizeTheFrm.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizeTheFrm.Image")));
            this.btnMinimizeTheFrm.ImageSize = new System.Drawing.Size(24, 24);
            this.btnMinimizeTheFrm.Location = new System.Drawing.Point(1001, 5);
            this.btnMinimizeTheFrm.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimizeTheFrm.Name = "btnMinimizeTheFrm";
            this.btnMinimizeTheFrm.ShadowDecoration.Parent = this.btnMinimizeTheFrm;
            this.btnMinimizeTheFrm.Size = new System.Drawing.Size(40, 40);
            this.btnMinimizeTheFrm.TabIndex = 0;
            this.btnMinimizeTheFrm.Click += new System.EventHandler(this.btnMinimizedTheFrm);
            this.btnMinimizeTheFrm.Enter += new System.EventHandler(this.btnSwitchFillColor);
            this.btnMinimizeTheFrm.Leave += new System.EventHandler(this.btnSwitchFillColor);
            // 
            // btnClose
            // 
            this.btnClose.Animated = true;
            this.btnClose.AutoRoundedCorners = true;
            this.btnClose.BorderRadius = 19;
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.CustomImages.Parent = this.btnClose;
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnClose.FillColor2 = System.Drawing.Color.DeepPink;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.DeepPink;
            this.btnClose.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Image = global::DVLD.Properties.Resources.close;
            this.btnClose.ImageOffset = new System.Drawing.Point(1, 0);
            this.btnClose.ImageSize = new System.Drawing.Size(24, 24);
            this.btnClose.Location = new System.Drawing.Point(1041, 5);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 1;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.Enter += new System.EventHandler(this.btnSwitchFillColor);
            this.btnClose.Leave += new System.EventHandler(this.btnSwitchFillColor);
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMain.Location = new System.Drawing.Point(280, 45);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1090, 704);
            this.pnlMain.TabIndex = 2;
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlUpHome);
            this.Controls.Add(this.pnlLeftHome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHome";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlLeftHome.ResumeLayout(false);
            this.pnlLeftHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCar)).EndInit();
            this.pnlUpHome.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void InitializeBtns()
        {
            BtnsFrmHome[0] = btnApplactions;
            BtnsFrmHome[1] = btnPeople;
            BtnsFrmHome[2] = btnDrivers;
            BtnsFrmHome[3] = btnUsers;
            BtnsFrmHome[4] = btnSettings;
        }

        private void AddFrmToPnlMain(byte tag)
        {
            MainPanel.Controls.Clear();
            if (tag == 0)
            {
                AddToMainPanel(new FrmApplicationBtnsScreen());
                
            }
            else if (tag == 1)
            {
                AddToMainPanel(new FrmPeople());
            }
            else if (tag == 2)
            {
                AddToMainPanel(new FrmDrivers());
            }
            else if (tag == 3)
            {
                AddToMainPanel(new FrmUsers());

            }
            else if (tag == 4)
            {
                FrmSettings frmSettings = new FrmSettings();
                frmSettings.SignOutEvent += CloseFrm;
                AddToMainPanel(frmSettings);
                
            }
            // think about it
            //this.SelectNextControl((Control)btnClose, true, true, true, true);
        }

        private void TurnOffBtnsLight()
        {
            foreach (Guna2GradientButton b in BtnsFrmHome)
            {
                b.FillColor = ClsSettings.GrayMainColor;
                b.FillColor2 = ClsSettings.GrayMainColor;
            }
        }

        #endregion

        private System.Windows.Forms.Panel pnlLeftHome;
        private System.Windows.Forms.Panel pnlUpHome;
        public static Panel MainPanel;
        private Guna.UI2.WinForms.Guna2GradientButton btnClose;
        private Guna.UI2.WinForms.Guna2GradientButton btnMinimizeTheFrm;
        private System.Windows.Forms.PictureBox picCar;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.Label lblAslan;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GradientButton btnApplactions;
        private Guna.UI2.WinForms.Guna2GradientButton btnPeople;
        private Guna.UI2.WinForms.Guna2GradientButton btnDrivers;
        private Guna.UI2.WinForms.Guna2GradientButton btnSettings;
        private Guna.UI2.WinForms.Guna2GradientButton btnUsers;
        private Guna2GradientButton[] BtnsFrmHome = new Guna2GradientButton[5];
        private Guna2GradientButton guna2GradientButton1;
        public Panel pnlMain;
    }
}