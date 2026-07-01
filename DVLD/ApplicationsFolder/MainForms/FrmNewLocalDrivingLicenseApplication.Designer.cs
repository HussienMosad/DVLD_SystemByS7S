using System;

namespace DVLD.ApplicationsFolder.MainForms
{
    partial class FrmNewLocalDrivingLicenseApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNewLocalDrivingLicenseApplication));
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.ucPersonDetailsWithFilter = new DVLD.People.UserControls.UcPersonDetailsWithFilter();
            this.ucNewLocalDrivingLicenseApplications1 = new DVLD.ApplicationsFolder.MainForms.UcNewLocalDrivingLicenseApplications();
            this.btnEditPerson = new Guna.UI2.WinForms.Guna2GradientButton();
            this.picHeader = new System.Windows.Forms.PictureBox();
            this.btnBack = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnReserveNext = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnNext = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSave = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Impact", 35F);
            this.lblHeaderTitle.Location = new System.Drawing.Point(19, 14);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(769, 59);
            this.lblHeaderTitle.TabIndex = 81;
            this.lblHeaderTitle.Text = "- New Local Driving License Application";
            this.lblHeaderTitle.UseMnemonic = false;
            // 
            // ucPersonDetailsWithFilter
            // 
            this.ucPersonDetailsWithFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ucPersonDetailsWithFilter.Font = new System.Drawing.Font("Impact", 24F);
            this.ucPersonDetailsWithFilter.ForeColor = System.Drawing.Color.White;
            this.ucPersonDetailsWithFilter.Location = new System.Drawing.Point(0, 115);
            this.ucPersonDetailsWithFilter.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.ucPersonDetailsWithFilter.MaximumSize = new System.Drawing.Size(1086, 564);
            this.ucPersonDetailsWithFilter.Name = "ucPersonDetailsWithFilter";
            this.ucPersonDetailsWithFilter.Size = new System.Drawing.Size(1086, 528);
            this.ucPersonDetailsWithFilter.TabIndex = 0;
            // 
            // ucNewLocalDrivingLicenseApplications1
            // 
            this.ucNewLocalDrivingLicenseApplications1.ApplicationTypeID = 0;
            this.ucNewLocalDrivingLicenseApplications1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ucNewLocalDrivingLicenseApplications1.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucNewLocalDrivingLicenseApplications1.ForeColor = System.Drawing.Color.White;
            this.ucNewLocalDrivingLicenseApplications1.Location = new System.Drawing.Point(0, 123);
            this.ucNewLocalDrivingLicenseApplications1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.ucNewLocalDrivingLicenseApplications1.Name = "ucNewLocalDrivingLicenseApplications1";
            this.ucNewLocalDrivingLicenseApplications1.Size = new System.Drawing.Size(1086, 526);
            this.ucNewLocalDrivingLicenseApplications1.TabIndex = 4;
            // 
            // btnEditPerson
            // 
            this.btnEditPerson.Animated = true;
            this.btnEditPerson.BorderRadius = 20;
            this.btnEditPerson.CheckedState.Parent = this.btnEditPerson;
            this.btnEditPerson.CustomImages.Parent = this.btnEditPerson;
            this.btnEditPerson.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnEditPerson.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnEditPerson.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditPerson.ForeColor = System.Drawing.Color.White;
            this.btnEditPerson.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnEditPerson.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnEditPerson.HoverState.Parent = this.btnEditPerson;
            this.btnEditPerson.Image = global::DVLD.Properties.Resources.edit_user;
            this.btnEditPerson.ImageOffset = new System.Drawing.Point(1, 0);
            this.btnEditPerson.ImageSize = new System.Drawing.Size(40, 40);
            this.btnEditPerson.Location = new System.Drawing.Point(497, 659);
            this.btnEditPerson.Name = "btnEditPerson";
            this.btnEditPerson.ShadowDecoration.Parent = this.btnEditPerson;
            this.btnEditPerson.Size = new System.Drawing.Size(66, 49);
            this.btnEditPerson.TabIndex = 2;
            this.btnEditPerson.Click += new System.EventHandler(this.btnEditPerson_Click);
            this.btnEditPerson.Enter += new System.EventHandler(this.btnSwitchFillColor);
            this.btnEditPerson.Leave += new System.EventHandler(this.btnSwitchFillColor);
            // 
            // picHeader
            // 
            this.picHeader.Image = ((System.Drawing.Image)(resources.GetObject("picHeader.Image")));
            this.picHeader.Location = new System.Drawing.Point(792, 1);
            this.picHeader.Name = "picHeader";
            this.picHeader.Size = new System.Drawing.Size(110, 110);
            this.picHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHeader.TabIndex = 82;
            this.picHeader.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Animated = true;
            this.btnBack.BorderRadius = 20;
            this.btnBack.CheckedState.Parent = this.btnBack;
            this.btnBack.CustomImages.Parent = this.btnBack;
            this.btnBack.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnBack.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnBack.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnBack.HoverState.Parent = this.btnBack;
            this.btnBack.Image = global::DVLD.Properties.Resources.left_arrow;
            this.btnBack.ImageSize = new System.Drawing.Size(40, 40);
            this.btnBack.Location = new System.Drawing.Point(48, 659);
            this.btnBack.Name = "btnBack";
            this.btnBack.ShadowDecoration.Parent = this.btnBack;
            this.btnBack.Size = new System.Drawing.Size(66, 49);
            this.btnBack.TabIndex = 3;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.Enter += new System.EventHandler(this.btnSwitchFillColor);
            this.btnBack.Leave += new System.EventHandler(this.btnSwitchFillColor);
            // 
            // btnReserveNext
            // 
            this.btnReserveNext.Animated = true;
            this.btnReserveNext.BorderRadius = 20;
            this.btnReserveNext.CheckedState.Parent = this.btnReserveNext;
            this.btnReserveNext.CustomImages.Parent = this.btnReserveNext;
            this.btnReserveNext.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnReserveNext.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnReserveNext.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReserveNext.ForeColor = System.Drawing.Color.White;
            this.btnReserveNext.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnReserveNext.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnReserveNext.HoverState.Parent = this.btnReserveNext;
            this.btnReserveNext.Image = global::DVLD.Properties.Resources.left_arrow;
            this.btnReserveNext.ImageSize = new System.Drawing.Size(40, 40);
            this.btnReserveNext.Location = new System.Drawing.Point(48, 659);
            this.btnReserveNext.Name = "btnReserveNext";
            this.btnReserveNext.ShadowDecoration.Parent = this.btnReserveNext;
            this.btnReserveNext.Size = new System.Drawing.Size(66, 49);
            this.btnReserveNext.TabIndex = 6;
            this.btnReserveNext.Click += new System.EventHandler(this.btnReserveNext_Click);
            this.btnReserveNext.Enter += new System.EventHandler(this.btnSwitchFillColor);
            this.btnReserveNext.Leave += new System.EventHandler(this.btnSwitchFillColor);
            // 
            // btnNext
            // 
            this.btnNext.Animated = true;
            this.btnNext.BorderRadius = 20;
            this.btnNext.CheckedState.Parent = this.btnNext;
            this.btnNext.CustomImages.Parent = this.btnNext;
            this.btnNext.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnNext.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnNext.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnNext.HoverState.Parent = this.btnNext;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageOffset = new System.Drawing.Point(2, 0);
            this.btnNext.ImageSize = new System.Drawing.Size(40, 40);
            this.btnNext.Location = new System.Drawing.Point(973, 659);
            this.btnNext.Name = "btnNext";
            this.btnNext.ShadowDecoration.Parent = this.btnNext;
            this.btnNext.Size = new System.Drawing.Size(66, 49);
            this.btnNext.TabIndex = 1;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            this.btnNext.Enter += new System.EventHandler(this.btnSwitchFillColor);
            this.btnNext.Leave += new System.EventHandler(this.btnSwitchFillColor);
            // 
            // btnSave
            // 
            this.btnSave.Animated = true;
            this.btnSave.BorderRadius = 20;
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSave.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnSave.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.Image = global::DVLD.Properties.Resources.save;
            this.btnSave.ImageOffset = new System.Drawing.Point(2, 0);
            this.btnSave.ImageSize = new System.Drawing.Size(32, 32);
            this.btnSave.Location = new System.Drawing.Point(973, 659);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(66, 49);
            this.btnSave.TabIndex = 5;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.Enter += new System.EventHandler(this.btnSwitchFillColor);
            this.btnSave.Leave += new System.EventHandler(this.btnSwitchFillColor);
            // 
            // FrmNewLocalDrivingLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Controls.Add(this.btnEditPerson);
            this.Controls.Add(this.lblHeaderTitle);
            this.Controls.Add(this.picHeader);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnReserveNext);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ucPersonDetailsWithFilter);
            this.Controls.Add(this.ucNewLocalDrivingLicenseApplications1);
            this.Controls.Add(this.btnNext);
            this.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "FrmNewLocalDrivingLicenseApplication";
            this.Size = new System.Drawing.Size(1086, 723);
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton btnEditPerson;
        private Guna.UI2.WinForms.Guna2GradientButton btnNext;
        private Guna.UI2.WinForms.Guna2GradientButton btnBack;
        private People.UserControls.UcPersonDetailsWithFilter ucPersonDetailsWithFilter;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.PictureBox picHeader;
        private UcNewLocalDrivingLicenseApplications ucNewLocalDrivingLicenseApplications1;
        private Guna.UI2.WinForms.Guna2GradientButton btnSave;
        private Guna.UI2.WinForms.Guna2GradientButton btnReserveNext;
    }
}
