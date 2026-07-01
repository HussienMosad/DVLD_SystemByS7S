namespace DVLD.TestFolder.MainForms
{
    partial class FrmTestAppointments
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTestAppointments));
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.picHeader = new System.Windows.Forms.PictureBox();
            this.dgvAppointments = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ctmsForAppointmentsDGV = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.TakeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RoundingTheDGV = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnBack = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnAddTestAppointment = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblNumberOfRecords = new System.Windows.Forms.Label();
            this.ucApplicationBasicInfo1 = new DVLD.ApplicationsFolder.UserControls.UcApplicationBasicInfo();
            this.ucDrivingLicenseApplicationInfo1 = new DVLD.ApplicationsFolder.UserControls.UcDrivingLicenseApplicationInfo();
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            this.ctmsForAppointmentsDGV.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Impact", 35F);
            this.lblHeaderTitle.Location = new System.Drawing.Point(22, 16);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(533, 59);
            this.lblHeaderTitle.TabIndex = 13;
            this.lblHeaderTitle.Text = "- Vision Test Appointments";
            this.lblHeaderTitle.UseMnemonic = false;
            // 
            // picHeader
            // 
            this.picHeader.Image = global::DVLD.Properties.Resources.eye__1_;
            this.picHeader.Location = new System.Drawing.Point(760, 4);
            this.picHeader.Name = "picHeader";
            this.picHeader.Size = new System.Drawing.Size(98, 92);
            this.picHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHeader.TabIndex = 14;
            this.picHeader.TabStop = false;
            // 
            // dgvAppointments
            // 
            this.dgvAppointments.AllowUserToAddRows = false;
            this.dgvAppointments.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Impact", 16F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            this.dgvAppointments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAppointments.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dgvAppointments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAppointments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAppointments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Impact", 16F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAppointments.ColumnHeadersHeight = 60;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Impact", 16F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAppointments.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAppointments.EnableHeadersVisualStyles = false;
            this.dgvAppointments.GridColor = System.Drawing.Color.Silver;
            this.dgvAppointments.Location = new System.Drawing.Point(23, 450);
            this.dgvAppointments.Name = "dgvAppointments";
            this.dgvAppointments.ReadOnly = true;
            this.dgvAppointments.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAppointments.RowHeadersVisible = false;
            this.dgvAppointments.RowTemplate.Height = 40;
            this.dgvAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAppointments.Size = new System.Drawing.Size(1044, 199);
            this.dgvAppointments.TabIndex = 2;
            this.dgvAppointments.TabStop = false;
            this.dgvAppointments.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Red;
            this.dgvAppointments.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dgvAppointments.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Impact", 16F);
            this.dgvAppointments.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvAppointments.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Teal;
            this.dgvAppointments.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvAppointments.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dgvAppointments.ThemeStyle.GridColor = System.Drawing.Color.Silver;
            this.dgvAppointments.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.dgvAppointments.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvAppointments.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Impact", 16F);
            this.dgvAppointments.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.dgvAppointments.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvAppointments.ThemeStyle.HeaderStyle.Height = 60;
            this.dgvAppointments.ThemeStyle.ReadOnly = true;
            this.dgvAppointments.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvAppointments.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAppointments.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Impact", 16F);
            this.dgvAppointments.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvAppointments.ThemeStyle.RowsStyle.Height = 40;
            this.dgvAppointments.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Teal;
            this.dgvAppointments.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvAppointments.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvAppoinments_KeyDown);
            this.dgvAppointments.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvLocalDrivingLicenseApplications_MouseDown);
            // 
            // ctmsForAppointmentsDGV
            // 
            this.ctmsForAppointmentsDGV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ctmsForAppointmentsDGV.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctmsForAppointmentsDGV.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctmsForAppointmentsDGV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditToolStripMenuItem,
            this.toolStripMenuItem1,
            this.TakeTestToolStripMenuItem});
            this.ctmsForAppointmentsDGV.Name = "ctmsForPeopleDGV";
            this.ctmsForAppointmentsDGV.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ctmsForAppointmentsDGV.Size = new System.Drawing.Size(161, 70);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.EditToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("EditToolStripMenuItem.Image")));
            this.EditToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(160, 30);
            this.EditToolStripMenuItem.Text = "Edit";
            this.EditToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(157, 6);
            // 
            // TakeTestToolStripMenuItem
            // 
            this.TakeTestToolStripMenuItem.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TakeTestToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.TakeTestToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("TakeTestToolStripMenuItem.Image")));
            this.TakeTestToolStripMenuItem.Name = "TakeTestToolStripMenuItem";
            this.TakeTestToolStripMenuItem.Size = new System.Drawing.Size(160, 30);
            this.TakeTestToolStripMenuItem.Text = "Take Test";
            this.TakeTestToolStripMenuItem.Click += new System.EventHandler(this.TakeTestToolStripMenuItem_Click);
            // 
            // RoundingTheDGV
            // 
            this.RoundingTheDGV.TargetControl = this.dgvAppointments;
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
            this.btnBack.Location = new System.Drawing.Point(48, 655);
            this.btnBack.Name = "btnBack";
            this.btnBack.ShadowDecoration.Parent = this.btnBack;
            this.btnBack.Size = new System.Drawing.Size(66, 49);
            this.btnBack.TabIndex = 4;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.Enter += new System.EventHandler(this.btnSwitchFillColor);
            this.btnBack.Leave += new System.EventHandler(this.btnSwitchFillColor);
            // 
            // btnAddTestAppointment
            // 
            this.btnAddTestAppointment.Animated = true;
            this.btnAddTestAppointment.BorderRadius = 20;
            this.btnAddTestAppointment.CheckedState.Parent = this.btnAddTestAppointment;
            this.btnAddTestAppointment.CustomImages.Parent = this.btnAddTestAppointment;
            this.btnAddTestAppointment.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnAddTestAppointment.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnAddTestAppointment.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddTestAppointment.ForeColor = System.Drawing.Color.White;
            this.btnAddTestAppointment.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnAddTestAppointment.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnAddTestAppointment.HoverState.Parent = this.btnAddTestAppointment;
            this.btnAddTestAppointment.Image = ((System.Drawing.Image)(resources.GetObject("btnAddTestAppointment.Image")));
            this.btnAddTestAppointment.ImageOffset = new System.Drawing.Point(2, 0);
            this.btnAddTestAppointment.ImageSize = new System.Drawing.Size(32, 32);
            this.btnAddTestAppointment.Location = new System.Drawing.Point(973, 655);
            this.btnAddTestAppointment.Name = "btnAddTestAppointment";
            this.btnAddTestAppointment.ShadowDecoration.Parent = this.btnAddTestAppointment;
            this.btnAddTestAppointment.Size = new System.Drawing.Size(66, 49);
            this.btnAddTestAppointment.TabIndex = 3;
            this.btnAddTestAppointment.Click += new System.EventHandler(this.btnAddTestAppointment_Click);
            this.btnAddTestAppointment.Enter += new System.EventHandler(this.btnSwitchFillColor);
            this.btnAddTestAppointment.Leave += new System.EventHandler(this.btnSwitchFillColor);
            // 
            // lblNumberOfRecords
            // 
            this.lblNumberOfRecords.AutoSize = true;
            this.lblNumberOfRecords.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfRecords.Location = new System.Drawing.Point(471, 667);
            this.lblNumberOfRecords.Name = "lblNumberOfRecords";
            this.lblNumberOfRecords.Size = new System.Drawing.Size(170, 26);
            this.lblNumberOfRecords.TabIndex = 29;
            this.lblNumberOfRecords.Text = "4 Appointment (s) .";
            this.lblNumberOfRecords.UseMnemonic = false;
            // 
            // ucApplicationBasicInfo1
            // 
            this.ucApplicationBasicInfo1.Application1 = null;
            this.ucApplicationBasicInfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ucApplicationBasicInfo1.Font = new System.Drawing.Font("Impact", 24F);
            this.ucApplicationBasicInfo1.ForeColor = System.Drawing.Color.White;
            this.ucApplicationBasicInfo1.Location = new System.Drawing.Point(0, 196);
            this.ucApplicationBasicInfo1.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.ucApplicationBasicInfo1.Name = "ucApplicationBasicInfo1";
            this.ucApplicationBasicInfo1.PersonID = 0;
            this.ucApplicationBasicInfo1.Size = new System.Drawing.Size(1086, 256);
            this.ucApplicationBasicInfo1.TabIndex = 1;
            this.ucApplicationBasicInfo1.Load += new System.EventHandler(this.ucApplicationBasicInfo1_Load);
            // 
            // ucDrivingLicenseApplicationInfo1
            // 
            this.ucDrivingLicenseApplicationInfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ucDrivingLicenseApplicationInfo1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucDrivingLicenseApplicationInfo1.ForeColor = System.Drawing.Color.White;
            this.ucDrivingLicenseApplicationInfo1.Location = new System.Drawing.Point(0, 92);
            this.ucDrivingLicenseApplicationInfo1.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.ucDrivingLicenseApplicationInfo1.Name = "ucDrivingLicenseApplicationInfo1";
            this.ucDrivingLicenseApplicationInfo1.Size = new System.Drawing.Size(1086, 113);
            this.ucDrivingLicenseApplicationInfo1.TabIndex = 0;
            this.ucDrivingLicenseApplicationInfo1.Load += new System.EventHandler(this.ucDrivingLicenseApplicationInfo1_Load);
            // 
            // FrmTestAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Controls.Add(this.lblNumberOfRecords);
            this.Controls.Add(this.btnAddTestAppointment);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvAppointments);
            this.Controls.Add(this.ucApplicationBasicInfo1);
            this.Controls.Add(this.picHeader);
            this.Controls.Add(this.lblHeaderTitle);
            this.Controls.Add(this.ucDrivingLicenseApplicationInfo1);
            this.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.Name = "FrmTestAppointments";
            this.Size = new System.Drawing.Size(1086, 723);
            this.Load += new System.EventHandler(this.FrmTestAppointments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            this.ctmsForAppointmentsDGV.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private ApplicationsFolder.UserControls.UcDrivingLicenseApplicationInfo ucDrivingLicenseApplicationInfo1;
        private ApplicationsFolder.UserControls.UcApplicationBasicInfo ucApplicationBasicInfo1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvAppointments;
        private Guna.UI2.WinForms.Guna2Elipse RoundingTheDGV;
        private System.Windows.Forms.ContextMenuStrip ctmsForAppointmentsDGV;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem TakeTestToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2GradientButton btnBack;
        private Guna.UI2.WinForms.Guna2GradientButton btnAddTestAppointment;
        private System.Windows.Forms.Label lblNumberOfRecords;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
    }
}
