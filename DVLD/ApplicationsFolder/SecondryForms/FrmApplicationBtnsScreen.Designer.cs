using Guna.UI2.WinForms;

namespace DVLD
{
    partial class FrmApplicationBtnsScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmApplicationBtnsScreen));
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.ctmsForBtnManageApplication = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.LocalDrivingLicenseApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.interationalLicenseApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnManageTestTypes = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnManageApplicationTypes = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnDetainLicences = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnManageApplications = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnDrivingLicencesServices = new Guna.UI2.WinForms.Guna2GradientButton();
            this.picHeader = new System.Windows.Forms.PictureBox();
            this.ctmsForBtnDetainLicenses = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ListDetainedtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ReleasetoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.DetaintoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmsForBtnManageApplication.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).BeginInit();
            this.ctmsForBtnDetainLicenses.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderTitle.Location = new System.Drawing.Point(20, 28);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(393, 80);
            this.lblHeaderTitle.TabIndex = 10;
            this.lblHeaderTitle.Text = "- Applications";
            this.lblHeaderTitle.UseMnemonic = false;
            // 
            // ctmsForBtnManageApplication
            // 
            this.ctmsForBtnManageApplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ctmsForBtnManageApplication.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctmsForBtnManageApplication.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctmsForBtnManageApplication.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LocalDrivingLicenseApplicationToolStripMenuItem,
            this.toolStripMenuItem1,
            this.interationalLicenseApplicationToolStripMenuItem});
            this.ctmsForBtnManageApplication.Name = "ctmsForPeopleDGV";
            this.ctmsForBtnManageApplication.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ctmsForBtnManageApplication.Size = new System.Drawing.Size(416, 78);
            // 
            // LocalDrivingLicenseApplicationToolStripMenuItem
            // 
            this.LocalDrivingLicenseApplicationToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LocalDrivingLicenseApplicationToolStripMenuItem.Font = new System.Drawing.Font("Impact", 18F);
            this.LocalDrivingLicenseApplicationToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.LocalDrivingLicenseApplicationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("LocalDrivingLicenseApplicationToolStripMenuItem.Image")));
            this.LocalDrivingLicenseApplicationToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LocalDrivingLicenseApplicationToolStripMenuItem.Name = "LocalDrivingLicenseApplicationToolStripMenuItem";
            this.LocalDrivingLicenseApplicationToolStripMenuItem.Size = new System.Drawing.Size(415, 34);
            this.LocalDrivingLicenseApplicationToolStripMenuItem.Text = "Local Driving License Applications";
            this.LocalDrivingLicenseApplicationToolStripMenuItem.Click += new System.EventHandler(this.LocalDrivingLicenseApplicationToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(412, 6);
            // 
            // interationalLicenseApplicationToolStripMenuItem
            // 
            this.interationalLicenseApplicationToolStripMenuItem.Font = new System.Drawing.Font("Impact", 18F);
            this.interationalLicenseApplicationToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.interationalLicenseApplicationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("interationalLicenseApplicationToolStripMenuItem.Image")));
            this.interationalLicenseApplicationToolStripMenuItem.Name = "interationalLicenseApplicationToolStripMenuItem";
            this.interationalLicenseApplicationToolStripMenuItem.Size = new System.Drawing.Size(415, 34);
            this.interationalLicenseApplicationToolStripMenuItem.Text = "Interational License Applications";
            this.interationalLicenseApplicationToolStripMenuItem.Click += new System.EventHandler(this.interationalLicenseApplicationToolStripMenuItem_Click);
            // 
            // btnManageTestTypes
            // 
            this.btnManageTestTypes.Animated = true;
            this.btnManageTestTypes.BorderRadius = 10;
            this.btnManageTestTypes.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnManageTestTypes.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnManageTestTypes.CheckedState.Font = new System.Drawing.Font("Impact", 25F);
            this.btnManageTestTypes.CheckedState.Parent = this.btnManageTestTypes;
            this.btnManageTestTypes.CustomImages.Parent = this.btnManageTestTypes;
            this.btnManageTestTypes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnManageTestTypes.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnManageTestTypes.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageTestTypes.ForeColor = System.Drawing.Color.White;
            this.btnManageTestTypes.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnManageTestTypes.HoverState.Font = new System.Drawing.Font("Impact", 25F);
            this.btnManageTestTypes.HoverState.Parent = this.btnManageTestTypes;
            this.btnManageTestTypes.Image = ((System.Drawing.Image)(resources.GetObject("btnManageTestTypes.Image")));
            this.btnManageTestTypes.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnManageTestTypes.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnManageTestTypes.ImageSize = new System.Drawing.Size(55, 55);
            this.btnManageTestTypes.Location = new System.Drawing.Point(240, 592);
            this.btnManageTestTypes.Margin = new System.Windows.Forms.Padding(0);
            this.btnManageTestTypes.Name = "btnManageTestTypes";
            this.btnManageTestTypes.ShadowDecoration.Parent = this.btnManageTestTypes;
            this.btnManageTestTypes.Size = new System.Drawing.Size(610, 82);
            this.btnManageTestTypes.TabIndex = 4;
            this.btnManageTestTypes.Tag = "2";
            this.btnManageTestTypes.Text = "Manage Test Types";
            this.btnManageTestTypes.Click += new System.EventHandler(this.btnManageTestTypes_Click);
            this.btnManageTestTypes.Enter += new System.EventHandler(this.btnFocusEffect_Enter);
            // 
            // btnManageApplicationTypes
            // 
            this.btnManageApplicationTypes.Animated = true;
            this.btnManageApplicationTypes.BorderRadius = 10;
            this.btnManageApplicationTypes.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnManageApplicationTypes.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnManageApplicationTypes.CheckedState.Font = new System.Drawing.Font("Impact", 25F);
            this.btnManageApplicationTypes.CheckedState.Parent = this.btnManageApplicationTypes;
            this.btnManageApplicationTypes.CustomImages.Parent = this.btnManageApplicationTypes;
            this.btnManageApplicationTypes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnManageApplicationTypes.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnManageApplicationTypes.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageApplicationTypes.ForeColor = System.Drawing.Color.White;
            this.btnManageApplicationTypes.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnManageApplicationTypes.HoverState.Font = new System.Drawing.Font("Impact", 25F);
            this.btnManageApplicationTypes.HoverState.Parent = this.btnManageApplicationTypes;
            this.btnManageApplicationTypes.Image = ((System.Drawing.Image)(resources.GetObject("btnManageApplicationTypes.Image")));
            this.btnManageApplicationTypes.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnManageApplicationTypes.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnManageApplicationTypes.ImageSize = new System.Drawing.Size(55, 55);
            this.btnManageApplicationTypes.Location = new System.Drawing.Point(240, 484);
            this.btnManageApplicationTypes.Margin = new System.Windows.Forms.Padding(0);
            this.btnManageApplicationTypes.Name = "btnManageApplicationTypes";
            this.btnManageApplicationTypes.ShadowDecoration.Parent = this.btnManageApplicationTypes;
            this.btnManageApplicationTypes.Size = new System.Drawing.Size(610, 82);
            this.btnManageApplicationTypes.TabIndex = 3;
            this.btnManageApplicationTypes.Tag = "2";
            this.btnManageApplicationTypes.Text = "Manage Application Types";
            this.btnManageApplicationTypes.Click += new System.EventHandler(this.btnManageApplicationTypes_Click);
            this.btnManageApplicationTypes.Enter += new System.EventHandler(this.btnFocusEffect_Enter);
            // 
            // btnDetainLicences
            // 
            this.btnDetainLicences.Animated = true;
            this.btnDetainLicences.BorderRadius = 10;
            this.btnDetainLicences.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnDetainLicences.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnDetainLicences.CheckedState.Font = new System.Drawing.Font("Impact", 25F);
            this.btnDetainLicences.CheckedState.Parent = this.btnDetainLicences;
            this.btnDetainLicences.CustomImages.Parent = this.btnDetainLicences;
            this.btnDetainLicences.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnDetainLicences.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnDetainLicences.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetainLicences.ForeColor = System.Drawing.Color.White;
            this.btnDetainLicences.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnDetainLicences.HoverState.Font = new System.Drawing.Font("Impact", 25F);
            this.btnDetainLicences.HoverState.Parent = this.btnDetainLicences;
            this.btnDetainLicences.Image = ((System.Drawing.Image)(resources.GetObject("btnDetainLicences.Image")));
            this.btnDetainLicences.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDetainLicences.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnDetainLicences.ImageSize = new System.Drawing.Size(55, 55);
            this.btnDetainLicences.Location = new System.Drawing.Point(240, 376);
            this.btnDetainLicences.Margin = new System.Windows.Forms.Padding(0);
            this.btnDetainLicences.Name = "btnDetainLicences";
            this.btnDetainLicences.ShadowDecoration.Parent = this.btnDetainLicences;
            this.btnDetainLicences.Size = new System.Drawing.Size(610, 82);
            this.btnDetainLicences.TabIndex = 2;
            this.btnDetainLicences.Tag = "2";
            this.btnDetainLicences.Text = "Detain Licenses";
            this.btnDetainLicences.Click += new System.EventHandler(this.btnDetainLicences_Click);
            this.btnDetainLicences.Enter += new System.EventHandler(this.btnFocusEffect_Enter);
            // 
            // btnManageApplications
            // 
            this.btnManageApplications.Animated = true;
            this.btnManageApplications.BorderRadius = 10;
            this.btnManageApplications.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnManageApplications.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnManageApplications.CheckedState.Font = new System.Drawing.Font("Impact", 25F);
            this.btnManageApplications.CheckedState.Parent = this.btnManageApplications;
            this.btnManageApplications.CustomImages.Parent = this.btnManageApplications;
            this.btnManageApplications.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnManageApplications.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnManageApplications.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageApplications.ForeColor = System.Drawing.Color.White;
            this.btnManageApplications.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnManageApplications.HoverState.Font = new System.Drawing.Font("Impact", 25F);
            this.btnManageApplications.HoverState.Parent = this.btnManageApplications;
            this.btnManageApplications.Image = ((System.Drawing.Image)(resources.GetObject("btnManageApplications.Image")));
            this.btnManageApplications.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnManageApplications.ImageSize = new System.Drawing.Size(55, 55);
            this.btnManageApplications.Location = new System.Drawing.Point(240, 268);
            this.btnManageApplications.Margin = new System.Windows.Forms.Padding(0);
            this.btnManageApplications.Name = "btnManageApplications";
            this.btnManageApplications.ShadowDecoration.Parent = this.btnManageApplications;
            this.btnManageApplications.Size = new System.Drawing.Size(610, 82);
            this.btnManageApplications.TabIndex = 1;
            this.btnManageApplications.Tag = "1";
            this.btnManageApplications.Text = "Manage Applications";
            this.btnManageApplications.Click += new System.EventHandler(this.btnManageApplications_Click);
            this.btnManageApplications.Enter += new System.EventHandler(this.btnFocusEffect_Enter);
            // 
            // btnDrivingLicencesServices
            // 
            this.btnDrivingLicencesServices.Animated = true;
            this.btnDrivingLicencesServices.BorderRadius = 10;
            this.btnDrivingLicencesServices.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnDrivingLicencesServices.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnDrivingLicencesServices.CheckedState.Font = new System.Drawing.Font("Impact", 25F);
            this.btnDrivingLicencesServices.CheckedState.Parent = this.btnDrivingLicencesServices;
            this.btnDrivingLicencesServices.CustomImages.Parent = this.btnDrivingLicencesServices;
            this.btnDrivingLicencesServices.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnDrivingLicencesServices.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnDrivingLicencesServices.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrivingLicencesServices.ForeColor = System.Drawing.Color.White;
            this.btnDrivingLicencesServices.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnDrivingLicencesServices.HoverState.Font = new System.Drawing.Font("Impact", 25F);
            this.btnDrivingLicencesServices.HoverState.Parent = this.btnDrivingLicencesServices;
            this.btnDrivingLicencesServices.Image = ((System.Drawing.Image)(resources.GetObject("btnDrivingLicencesServices.Image")));
            this.btnDrivingLicencesServices.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDrivingLicencesServices.ImageSize = new System.Drawing.Size(55, 55);
            this.btnDrivingLicencesServices.Location = new System.Drawing.Point(240, 160);
            this.btnDrivingLicencesServices.Margin = new System.Windows.Forms.Padding(0);
            this.btnDrivingLicencesServices.Name = "btnDrivingLicencesServices";
            this.btnDrivingLicencesServices.ShadowDecoration.Parent = this.btnDrivingLicencesServices;
            this.btnDrivingLicencesServices.Size = new System.Drawing.Size(610, 82);
            this.btnDrivingLicencesServices.TabIndex = 0;
            this.btnDrivingLicencesServices.Tag = "0";
            this.btnDrivingLicencesServices.Text = "Driving Licences Services";
            this.btnDrivingLicencesServices.Click += new System.EventHandler(this.btnDrivingLicensesServices_Click);
            this.btnDrivingLicencesServices.Enter += new System.EventHandler(this.btnFocusEffect_Enter);
            // 
            // picHeader
            // 
            this.picHeader.Image = global::DVLD.Properties.Resources.Applications;
            this.picHeader.Location = new System.Drawing.Point(405, 17);
            this.picHeader.Name = "picHeader";
            this.picHeader.Size = new System.Drawing.Size(110, 110);
            this.picHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHeader.TabIndex = 11;
            this.picHeader.TabStop = false;
            // 
            // ctmsForBtnDetainLicenses
            // 
            this.ctmsForBtnDetainLicenses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ctmsForBtnDetainLicenses.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctmsForBtnDetainLicenses.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctmsForBtnDetainLicenses.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ListDetainedtoolStripMenuItem,
            this.toolStripSeparator1,
            this.ReleasetoolStripMenuItem,
            this.toolStripMenuItem5,
            this.DetaintoolStripMenuItem});
            this.ctmsForBtnDetainLicenses.Name = "ctmsForPeopleDGV";
            this.ctmsForBtnDetainLicenses.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ctmsForBtnDetainLicenses.Size = new System.Drawing.Size(346, 140);
            // 
            // ListDetainedtoolStripMenuItem
            // 
            this.ListDetainedtoolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ListDetainedtoolStripMenuItem.Font = new System.Drawing.Font("Impact", 18F);
            this.ListDetainedtoolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ListDetainedtoolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ListDetainedtoolStripMenuItem.Image")));
            this.ListDetainedtoolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ListDetainedtoolStripMenuItem.Name = "ListDetainedtoolStripMenuItem";
            this.ListDetainedtoolStripMenuItem.Size = new System.Drawing.Size(345, 34);
            this.ListDetainedtoolStripMenuItem.Text = "Manage Detained Licenses";
            this.ListDetainedtoolStripMenuItem.Click += new System.EventHandler(this.ListDetainedtoolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(342, 6);
            // 
            // ReleasetoolStripMenuItem
            // 
            this.ReleasetoolStripMenuItem.Font = new System.Drawing.Font("Impact", 18F);
            this.ReleasetoolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ReleasetoolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ReleasetoolStripMenuItem.Image")));
            this.ReleasetoolStripMenuItem.Name = "ReleasetoolStripMenuItem";
            this.ReleasetoolStripMenuItem.Size = new System.Drawing.Size(345, 34);
            this.ReleasetoolStripMenuItem.Text = "Release license";
            this.ReleasetoolStripMenuItem.Click += new System.EventHandler(this.ReleasetoolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(342, 6);
            // 
            // DetaintoolStripMenuItem
            // 
            this.DetaintoolStripMenuItem.Font = new System.Drawing.Font("Impact", 18F);
            this.DetaintoolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.DetaintoolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("DetaintoolStripMenuItem.Image")));
            this.DetaintoolStripMenuItem.Name = "DetaintoolStripMenuItem";
            this.DetaintoolStripMenuItem.Size = new System.Drawing.Size(345, 34);
            this.DetaintoolStripMenuItem.Text = "Detain Lisense";
            this.DetaintoolStripMenuItem.Click += new System.EventHandler(this.DetaintoolStripMenuItem_Click);
            // 
            // FrmApplicationBtnsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Controls.Add(this.btnManageTestTypes);
            this.Controls.Add(this.btnManageApplicationTypes);
            this.Controls.Add(this.btnDetainLicences);
            this.Controls.Add(this.btnManageApplications);
            this.Controls.Add(this.btnDrivingLicencesServices);
            this.Controls.Add(this.picHeader);
            this.Controls.Add(this.lblHeaderTitle);
            this.Font = new System.Drawing.Font("Impact", 24F);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "FrmApplicationBtnsScreen";
            this.Size = new System.Drawing.Size(1086, 723);
            this.ctmsForBtnManageApplication.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).EndInit();
            this.ctmsForBtnDetainLicenses.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton btnDetainLicences;
        private Guna.UI2.WinForms.Guna2GradientButton btnManageApplications;
        private Guna.UI2.WinForms.Guna2GradientButton btnDrivingLicencesServices;
        private System.Windows.Forms.PictureBox picHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private Guna.UI2.WinForms.Guna2GradientButton btnManageApplicationTypes;
        private Guna.UI2.WinForms.Guna2GradientButton btnManageTestTypes;
        private Guna2GradientButton[] btnApplicationScreen = new Guna2GradientButton[5];
        private System.Windows.Forms.ContextMenuStrip ctmsForBtnManageApplication;
        private System.Windows.Forms.ToolStripMenuItem LocalDrivingLicenseApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem interationalLicenseApplicationToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ctmsForBtnDetainLicenses;
        private System.Windows.Forms.ToolStripMenuItem ListDetainedtoolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ReleasetoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DetaintoolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
    }
}
