namespace DVLD.DetainedLicenses.MainForm
{
    partial class FrmDetainedLicenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDetainedLicenses));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtFilterBy = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnRelease = new Guna.UI2.WinForms.Guna2GradientButton();
            this.CmbFilterBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblFilterBy = new System.Windows.Forms.Label();
            this.dgvDetainedLicenses = new Guna.UI2.WinForms.Guna2DataGridView();
            this.picHeader = new System.Windows.Forms.PictureBox();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.lblNumberOfRecords = new System.Windows.Forms.Label();
            this.btnIsRelease = new Guna.UI2.WinForms.Guna2GradientButton();
            this.RoundingTheDGV = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ctms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showPersonDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.ReleaseLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDetain = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetainedLicenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).BeginInit();
            this.ctms.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFilterBy
            // 
            this.txtFilterBy.Animated = true;
            this.txtFilterBy.AutoRoundedCorners = true;
            this.txtFilterBy.BorderColor = System.Drawing.Color.Gray;
            this.txtFilterBy.BorderRadius = 23;
            this.txtFilterBy.BorderThickness = 2;
            this.txtFilterBy.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilterBy.DefaultText = "";
            this.txtFilterBy.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFilterBy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFilterBy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilterBy.DisabledState.Parent = this.txtFilterBy;
            this.txtFilterBy.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilterBy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txtFilterBy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtFilterBy.FocusedState.Parent = this.txtFilterBy;
            this.txtFilterBy.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterBy.ForeColor = System.Drawing.Color.Gray;
            this.txtFilterBy.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtFilterBy.HoverState.ForeColor = System.Drawing.Color.Silver;
            this.txtFilterBy.HoverState.Parent = this.txtFilterBy;
            this.txtFilterBy.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtFilterBy.IconLeft")));
            this.txtFilterBy.IconLeftOffset = new System.Drawing.Point(7, 0);
            this.txtFilterBy.Location = new System.Drawing.Point(376, 125);
            this.txtFilterBy.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.txtFilterBy.Name = "txtFilterBy";
            this.txtFilterBy.PasswordChar = '\0';
            this.txtFilterBy.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFilterBy.PlaceholderText = "";
            this.txtFilterBy.SelectedText = "";
            this.txtFilterBy.ShadowDecoration.Parent = this.txtFilterBy;
            this.txtFilterBy.Size = new System.Drawing.Size(533, 48);
            this.txtFilterBy.TabIndex = 17;
            this.txtFilterBy.TextOffset = new System.Drawing.Point(10, 0);
            this.txtFilterBy.Visible = false;
            this.txtFilterBy.TextChanged += new System.EventHandler(this.txtFilterBy_TextChanged);
            this.txtFilterBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterBy_KeyPress);
            // 
            // btnRelease
            // 
            this.btnRelease.Animated = true;
            this.btnRelease.BorderRadius = 20;
            this.btnRelease.CheckedState.Parent = this.btnRelease;
            this.btnRelease.CustomImages.Parent = this.btnRelease;
            this.btnRelease.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnRelease.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnRelease.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRelease.ForeColor = System.Drawing.Color.White;
            this.btnRelease.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnRelease.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnRelease.HoverState.Parent = this.btnRelease;
            this.btnRelease.Image = ((System.Drawing.Image)(resources.GetObject("btnRelease.Image")));
            this.btnRelease.ImageOffset = new System.Drawing.Point(2, 0);
            this.btnRelease.ImageSize = new System.Drawing.Size(40, 40);
            this.btnRelease.Location = new System.Drawing.Point(987, 121);
            this.btnRelease.Name = "btnRelease";
            this.btnRelease.ShadowDecoration.Parent = this.btnRelease;
            this.btnRelease.Size = new System.Drawing.Size(66, 49);
            this.btnRelease.TabIndex = 19;
            this.btnRelease.Click += new System.EventHandler(this.btnRelease_Click);
            this.btnRelease.Enter += new System.EventHandler(this.btnSwitchFillColor);
            this.btnRelease.Leave += new System.EventHandler(this.btnSwitchFillColor);
            // 
            // CmbFilterBy
            // 
            this.CmbFilterBy.Animated = true;
            this.CmbFilterBy.AutoRoundedCorners = true;
            this.CmbFilterBy.BackColor = System.Drawing.Color.Transparent;
            this.CmbFilterBy.BorderColor = System.Drawing.Color.White;
            this.CmbFilterBy.BorderRadius = 17;
            this.CmbFilterBy.BorderThickness = 0;
            this.CmbFilterBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbFilterBy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.CmbFilterBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbFilterBy.FocusedColor = System.Drawing.Color.Empty;
            this.CmbFilterBy.FocusedState.Parent = this.CmbFilterBy;
            this.CmbFilterBy.Font = new System.Drawing.Font("Impact", 18.25F);
            this.CmbFilterBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.CmbFilterBy.FormattingEnabled = true;
            this.CmbFilterBy.HoverState.Font = new System.Drawing.Font("Impact", 23.25F);
            this.CmbFilterBy.HoverState.ForeColor = System.Drawing.Color.Teal;
            this.CmbFilterBy.HoverState.Parent = this.CmbFilterBy;
            this.CmbFilterBy.IntegralHeight = false;
            this.CmbFilterBy.ItemHeight = 30;
            this.CmbFilterBy.Items.AddRange(new object[] {
            "Detain ID",
            "Full Name",
            "Is Released",
            "National No",
            "None",
            "Release Application ID"});
            this.CmbFilterBy.ItemsAppearance.Parent = this.CmbFilterBy;
            this.CmbFilterBy.Location = new System.Drawing.Point(161, 132);
            this.CmbFilterBy.Name = "CmbFilterBy";
            this.CmbFilterBy.ShadowDecoration.Parent = this.CmbFilterBy;
            this.CmbFilterBy.Size = new System.Drawing.Size(213, 36);
            this.CmbFilterBy.Sorted = true;
            this.CmbFilterBy.StartIndex = 4;
            this.CmbFilterBy.TabIndex = 16;
            this.CmbFilterBy.SelectedIndexChanged += new System.EventHandler(this.CmbFilterBy_SelectedIndexChanged);
            this.CmbFilterBy.Enter += new System.EventHandler(this.CmbFilterBy_Enter);
            this.CmbFilterBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmbFilterBy_KeyPress);
            this.CmbFilterBy.Leave += new System.EventHandler(this.CmbFilterBy_Leave);
            // 
            // lblFilterBy
            // 
            this.lblFilterBy.AutoSize = true;
            this.lblFilterBy.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterBy.Location = new System.Drawing.Point(24, 130);
            this.lblFilterBy.Name = "lblFilterBy";
            this.lblFilterBy.Size = new System.Drawing.Size(133, 39);
            this.lblFilterBy.TabIndex = 23;
            this.lblFilterBy.Text = "Filter By :";
            this.lblFilterBy.UseMnemonic = false;
            // 
            // dgvDetainedLicenses
            // 
            this.dgvDetainedLicenses.AllowUserToAddRows = false;
            this.dgvDetainedLicenses.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Impact", 16F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Teal;
            this.dgvDetainedLicenses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDetainedLicenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetainedLicenses.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dgvDetainedLicenses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetainedLicenses.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDetainedLicenses.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Impact", 16F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetainedLicenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDetainedLicenses.ColumnHeadersHeight = 75;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Impact", 16F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetainedLicenses.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvDetainedLicenses.EnableHeadersVisualStyles = false;
            this.dgvDetainedLicenses.GridColor = System.Drawing.Color.Silver;
            this.dgvDetainedLicenses.Location = new System.Drawing.Point(19, 176);
            this.dgvDetainedLicenses.Name = "dgvDetainedLicenses";
            this.dgvDetainedLicenses.ReadOnly = true;
            this.dgvDetainedLicenses.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDetainedLicenses.RowHeadersVisible = false;
            this.dgvDetainedLicenses.RowTemplate.Height = 40;
            this.dgvDetainedLicenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetainedLicenses.Size = new System.Drawing.Size(1044, 513);
            this.dgvDetainedLicenses.TabIndex = 20;
            this.dgvDetainedLicenses.TabStop = false;
            this.dgvDetainedLicenses.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Red;
            this.dgvDetainedLicenses.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dgvDetainedLicenses.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Impact", 16F);
            this.dgvDetainedLicenses.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvDetainedLicenses.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Teal;
            this.dgvDetainedLicenses.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDetainedLicenses.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dgvDetainedLicenses.ThemeStyle.GridColor = System.Drawing.Color.Silver;
            this.dgvDetainedLicenses.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.dgvDetainedLicenses.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvDetainedLicenses.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Impact", 16F);
            this.dgvDetainedLicenses.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.dgvDetainedLicenses.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDetainedLicenses.ThemeStyle.HeaderStyle.Height = 75;
            this.dgvDetainedLicenses.ThemeStyle.ReadOnly = true;
            this.dgvDetainedLicenses.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvDetainedLicenses.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDetainedLicenses.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Impact", 16F);
            this.dgvDetainedLicenses.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvDetainedLicenses.ThemeStyle.RowsStyle.Height = 40;
            this.dgvDetainedLicenses.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Teal;
            this.dgvDetainedLicenses.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDetainedLicenses.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv_KeyDown);
            this.dgvDetainedLicenses.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgv_KeyPress);
            this.dgvDetainedLicenses.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvLocalDrivingLicenseApplications_MouseDown);
            // 
            // picHeader
            // 
            this.picHeader.Image = ((System.Drawing.Image)(resources.GetObject("picHeader.Image")));
            this.picHeader.Location = new System.Drawing.Point(580, 3);
            this.picHeader.Name = "picHeader";
            this.picHeader.Size = new System.Drawing.Size(110, 110);
            this.picHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHeader.TabIndex = 22;
            this.picHeader.TabStop = false;
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Impact", 35F);
            this.lblHeaderTitle.Location = new System.Drawing.Point(19, 14);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(563, 59);
            this.lblHeaderTitle.TabIndex = 21;
            this.lblHeaderTitle.Text = "- Manage Detained Licenses";
            this.lblHeaderTitle.UseMnemonic = false;
            // 
            // lblNumberOfRecords
            // 
            this.lblNumberOfRecords.AutoSize = true;
            this.lblNumberOfRecords.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfRecords.Location = new System.Drawing.Point(24, 690);
            this.lblNumberOfRecords.Name = "lblNumberOfRecords";
            this.lblNumberOfRecords.Size = new System.Drawing.Size(226, 26);
            this.lblNumberOfRecords.TabIndex = 24;
            this.lblNumberOfRecords.Text = "Number Of Records : 1100";
            this.lblNumberOfRecords.UseMnemonic = false;
            // 
            // btnIsRelease
            // 
            this.btnIsRelease.Animated = true;
            this.btnIsRelease.BorderRadius = 20;
            this.btnIsRelease.CheckedState.Parent = this.btnIsRelease;
            this.btnIsRelease.CustomImages.Parent = this.btnIsRelease;
            this.btnIsRelease.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnIsRelease.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnIsRelease.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIsRelease.ForeColor = System.Drawing.Color.White;
            this.btnIsRelease.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnIsRelease.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnIsRelease.HoverState.Parent = this.btnIsRelease;
            this.btnIsRelease.ImageOffset = new System.Drawing.Point(0, 2);
            this.btnIsRelease.ImageSize = new System.Drawing.Size(40, 40);
            this.btnIsRelease.Location = new System.Drawing.Point(376, 122);
            this.btnIsRelease.Name = "btnIsRelease";
            this.btnIsRelease.ShadowDecoration.Parent = this.btnIsRelease;
            this.btnIsRelease.Size = new System.Drawing.Size(533, 49);
            this.btnIsRelease.TabIndex = 18;
            this.btnIsRelease.Tag = "0";
            this.btnIsRelease.Visible = false;
            this.btnIsRelease.Click += new System.EventHandler(this.btnIsRelease_Click);
            // 
            // RoundingTheDGV
            // 
            this.RoundingTheDGV.TargetControl = this.dgvDetainedLicenses;
            // 
            // ctms
            // 
            this.ctms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ctms.Font = new System.Drawing.Font("Impact", 15F);
            this.ctms.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonDetailsToolStripMenuItem,
            this.showLicenseToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.ReleaseLicenseToolStripMenuItem});
            this.ctms.Name = "ctmsForPeopleDGV";
            this.ctms.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ctms.Size = new System.Drawing.Size(281, 152);
            // 
            // showPersonDetailsToolStripMenuItem
            // 
            this.showPersonDetailsToolStripMenuItem.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPersonDetailsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.showPersonDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showPersonDetailsToolStripMenuItem.Image")));
            this.showPersonDetailsToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.showPersonDetailsToolStripMenuItem.Name = "showPersonDetailsToolStripMenuItem";
            this.showPersonDetailsToolStripMenuItem.Size = new System.Drawing.Size(280, 30);
            this.showPersonDetailsToolStripMenuItem.Text = "Show Person Details";
            this.showPersonDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // showLicenseToolStripMenuItem
            // 
            this.showLicenseToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.showLicenseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showLicenseToolStripMenuItem.Image")));
            this.showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            this.showLicenseToolStripMenuItem.Size = new System.Drawing.Size(280, 30);
            this.showLicenseToolStripMenuItem.Text = "Show License";
            this.showLicenseToolStripMenuItem.Click += new System.EventHandler(this.showLicenseToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Impact", 15F);
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(280, 30);
            this.toolStripMenuItem1.Text = "Person Licenses History";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.PersonLicensesHistoryToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(277, 6);
            // 
            // ReleaseLicenseToolStripMenuItem
            // 
            this.ReleaseLicenseToolStripMenuItem.Font = new System.Drawing.Font("Impact", 15F);
            this.ReleaseLicenseToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ReleaseLicenseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ReleaseLicenseToolStripMenuItem.Image")));
            this.ReleaseLicenseToolStripMenuItem.Name = "ReleaseLicenseToolStripMenuItem";
            this.ReleaseLicenseToolStripMenuItem.Size = new System.Drawing.Size(280, 30);
            this.ReleaseLicenseToolStripMenuItem.Text = "Release License";
            this.ReleaseLicenseToolStripMenuItem.Click += new System.EventHandler(this.ReleaseLicenseToolStripMenuItem_Click);
            // 
            // btnDetain
            // 
            this.btnDetain.Animated = true;
            this.btnDetain.BorderRadius = 20;
            this.btnDetain.CheckedState.Parent = this.btnDetain;
            this.btnDetain.CustomImages.Parent = this.btnDetain;
            this.btnDetain.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnDetain.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnDetain.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDetain.ForeColor = System.Drawing.Color.White;
            this.btnDetain.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnDetain.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnDetain.HoverState.Parent = this.btnDetain;
            this.btnDetain.Image = ((System.Drawing.Image)(resources.GetObject("btnDetain.Image")));
            this.btnDetain.ImageSize = new System.Drawing.Size(40, 40);
            this.btnDetain.Location = new System.Drawing.Point(915, 121);
            this.btnDetain.Name = "btnDetain";
            this.btnDetain.ShadowDecoration.Parent = this.btnDetain;
            this.btnDetain.Size = new System.Drawing.Size(66, 49);
            this.btnDetain.TabIndex = 26;
            this.btnDetain.Click += new System.EventHandler(this.btnDetain_Click);
            this.btnDetain.Enter += new System.EventHandler(this.btnSwitchFillColor);
            this.btnDetain.Leave += new System.EventHandler(this.btnSwitchFillColor);
            // 
            // FrmDetainedLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Controls.Add(this.btnDetain);
            this.Controls.Add(this.txtFilterBy);
            this.Controls.Add(this.btnRelease);
            this.Controls.Add(this.CmbFilterBy);
            this.Controls.Add(this.lblFilterBy);
            this.Controls.Add(this.dgvDetainedLicenses);
            this.Controls.Add(this.picHeader);
            this.Controls.Add(this.lblHeaderTitle);
            this.Controls.Add(this.lblNumberOfRecords);
            this.Controls.Add(this.btnIsRelease);
            this.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "FrmDetainedLicenses";
            this.Size = new System.Drawing.Size(1086, 723);
            this.Load += new System.EventHandler(this.FrmDetainedLicenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetainedLicenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).EndInit();
            this.ctms.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtFilterBy;
        private Guna.UI2.WinForms.Guna2GradientButton btnRelease;
        private Guna.UI2.WinForms.Guna2ComboBox CmbFilterBy;
        private System.Windows.Forms.Label lblFilterBy;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDetainedLicenses;
        private System.Windows.Forms.PictureBox picHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblNumberOfRecords;
        private Guna.UI2.WinForms.Guna2GradientButton btnIsRelease;
        private Guna.UI2.WinForms.Guna2Elipse RoundingTheDGV;
        private System.Windows.Forms.ContextMenuStrip ctms;
        private System.Windows.Forms.ToolStripMenuItem showPersonDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReleaseLicenseToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2GradientButton btnDetain;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
    }
}
