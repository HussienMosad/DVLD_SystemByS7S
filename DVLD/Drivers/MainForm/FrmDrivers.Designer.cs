namespace DVLD.Drivers
{
    partial class FrmDrivers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDrivers));
            this.CmbFilterBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblFilterBy = new System.Windows.Forms.Label();
            this.dgvDrivers = new Guna.UI2.WinForms.Guna2DataGridView();
            this.picHeader = new System.Windows.Forms.PictureBox();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.lblNumberOfRecords = new System.Windows.Forms.Label();
            this.txtFilterBy = new Guna.UI2.WinForms.Guna2TextBox();
            this.RoundingTheDGV = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ctmsForDLADGV = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.issueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.PersonLicensesHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrivers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).BeginInit();
            this.ctmsForDLADGV.SuspendLayout();
            this.SuspendLayout();
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
            "Driver ID",
            "Full Name",
            "National No",
            "None",
            "Person ID"});
            this.CmbFilterBy.ItemsAppearance.Parent = this.CmbFilterBy;
            this.CmbFilterBy.Location = new System.Drawing.Point(161, 132);
            this.CmbFilterBy.Name = "CmbFilterBy";
            this.CmbFilterBy.ShadowDecoration.Parent = this.CmbFilterBy;
            this.CmbFilterBy.Size = new System.Drawing.Size(213, 36);
            this.CmbFilterBy.Sorted = true;
            this.CmbFilterBy.StartIndex = 3;
            this.CmbFilterBy.TabIndex = 0;
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
            this.lblFilterBy.TabIndex = 21;
            this.lblFilterBy.Text = "Filter By :";
            this.lblFilterBy.UseMnemonic = false;
            // 
            // dgvDrivers
            // 
            this.dgvDrivers.AllowUserToAddRows = false;
            this.dgvDrivers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Impact", 16F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            this.dgvDrivers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDrivers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDrivers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dgvDrivers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDrivers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDrivers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Impact", 20F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDrivers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDrivers.ColumnHeadersHeight = 75;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Impact", 16F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDrivers.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDrivers.EnableHeadersVisualStyles = false;
            this.dgvDrivers.GridColor = System.Drawing.Color.Silver;
            this.dgvDrivers.Location = new System.Drawing.Point(19, 176);
            this.dgvDrivers.Name = "dgvDrivers";
            this.dgvDrivers.ReadOnly = true;
            this.dgvDrivers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDrivers.RowHeadersVisible = false;
            this.dgvDrivers.RowTemplate.Height = 40;
            this.dgvDrivers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDrivers.Size = new System.Drawing.Size(1044, 513);
            this.dgvDrivers.TabIndex = 2;
            this.dgvDrivers.TabStop = false;
            this.dgvDrivers.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Red;
            this.dgvDrivers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dgvDrivers.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Impact", 16F);
            this.dgvDrivers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvDrivers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Teal;
            this.dgvDrivers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDrivers.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dgvDrivers.ThemeStyle.GridColor = System.Drawing.Color.Silver;
            this.dgvDrivers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.dgvDrivers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvDrivers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Impact", 20F);
            this.dgvDrivers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.dgvDrivers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDrivers.ThemeStyle.HeaderStyle.Height = 75;
            this.dgvDrivers.ThemeStyle.ReadOnly = true;
            this.dgvDrivers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvDrivers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDrivers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Impact", 16F);
            this.dgvDrivers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvDrivers.ThemeStyle.RowsStyle.Height = 40;
            this.dgvDrivers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Teal;
            this.dgvDrivers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDrivers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvDrivers_KeyDown);
            this.dgvDrivers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvDrivers_KeyPress);
            this.dgvDrivers.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvDrivers_MouseDown);
            // 
            // picHeader
            // 
            this.picHeader.Image = ((System.Drawing.Image)(resources.GetObject("picHeader.Image")));
            this.picHeader.Location = new System.Drawing.Point(625, 3);
            this.picHeader.Name = "picHeader";
            this.picHeader.Size = new System.Drawing.Size(110, 110);
            this.picHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHeader.TabIndex = 20;
            this.picHeader.TabStop = false;
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Impact", 48F);
            this.lblHeaderTitle.Location = new System.Drawing.Point(19, 14);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(607, 80);
            this.lblHeaderTitle.TabIndex = 19;
            this.lblHeaderTitle.Text = "- Drivers Management";
            this.lblHeaderTitle.UseMnemonic = false;
            // 
            // lblNumberOfRecords
            // 
            this.lblNumberOfRecords.AutoSize = true;
            this.lblNumberOfRecords.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfRecords.Location = new System.Drawing.Point(24, 690);
            this.lblNumberOfRecords.Name = "lblNumberOfRecords";
            this.lblNumberOfRecords.Size = new System.Drawing.Size(226, 26);
            this.lblNumberOfRecords.TabIndex = 22;
            this.lblNumberOfRecords.Text = "Number Of Records : 1100";
            this.lblNumberOfRecords.UseMnemonic = false;
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
            this.txtFilterBy.Size = new System.Drawing.Size(687, 48);
            this.txtFilterBy.TabIndex = 1;
            this.txtFilterBy.TextOffset = new System.Drawing.Point(10, 0);
            this.txtFilterBy.Visible = false;
            this.txtFilterBy.TextChanged += new System.EventHandler(this.txtFilterBy_TextChanged);
            this.txtFilterBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterBy_KeyPress);
            // 
            // RoundingTheDGV
            // 
            this.RoundingTheDGV.TargetControl = this.dgvDrivers;
            // 
            // ctmsForDLADGV
            // 
            this.ctmsForDLADGV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ctmsForDLADGV.Font = new System.Drawing.Font("Impact", 15F);
            this.ctmsForDLADGV.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctmsForDLADGV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.toolStripMenuItem5,
            this.issueToolStripMenuItem,
            this.toolStripSeparator2,
            this.PersonLicensesHistoryToolStripMenuItem});
            this.ctmsForDLADGV.Name = "ctmsForPeopleDGV";
            this.ctmsForDLADGV.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ctmsForDLADGV.Size = new System.Drawing.Size(308, 128);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showDetailsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.showDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showDetailsToolStripMenuItem.Image")));
            this.showDetailsToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(307, 30);
            this.showDetailsToolStripMenuItem.Text = "Show details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(304, 6);
            // 
            // issueToolStripMenuItem
            // 
            this.issueToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.issueToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("issueToolStripMenuItem.Image")));
            this.issueToolStripMenuItem.Name = "issueToolStripMenuItem";
            this.issueToolStripMenuItem.Size = new System.Drawing.Size(307, 30);
            this.issueToolStripMenuItem.Text = "Issue International License";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(304, 6);
            // 
            // PersonLicensesHistoryToolStripMenuItem
            // 
            this.PersonLicensesHistoryToolStripMenuItem.Font = new System.Drawing.Font("Impact", 15F);
            this.PersonLicensesHistoryToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.PersonLicensesHistoryToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("PersonLicensesHistoryToolStripMenuItem.Image")));
            this.PersonLicensesHistoryToolStripMenuItem.Name = "PersonLicensesHistoryToolStripMenuItem";
            this.PersonLicensesHistoryToolStripMenuItem.Size = new System.Drawing.Size(307, 30);
            this.PersonLicensesHistoryToolStripMenuItem.Text = "Person Licenses History";
            this.PersonLicensesHistoryToolStripMenuItem.Click += new System.EventHandler(this.PersonLicensesHistoryToolStripMenuItem_Click);
            // 
            // FrmDrivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Controls.Add(this.CmbFilterBy);
            this.Controls.Add(this.lblFilterBy);
            this.Controls.Add(this.dgvDrivers);
            this.Controls.Add(this.picHeader);
            this.Controls.Add(this.lblHeaderTitle);
            this.Controls.Add(this.lblNumberOfRecords);
            this.Controls.Add(this.txtFilterBy);
            this.Font = new System.Drawing.Font("Impact", 24F);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "FrmDrivers";
            this.Size = new System.Drawing.Size(1086, 723);
            this.Load += new System.EventHandler(this.FrmDrivers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrivers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).EndInit();
            this.ctmsForDLADGV.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox CmbFilterBy;
        private System.Windows.Forms.Label lblFilterBy;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDrivers;
        private System.Windows.Forms.PictureBox picHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblNumberOfRecords;
        private Guna.UI2.WinForms.Guna2TextBox txtFilterBy;
        private Guna.UI2.WinForms.Guna2Elipse RoundingTheDGV;
        private System.Windows.Forms.ContextMenuStrip ctmsForDLADGV;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem issueToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem PersonLicensesHistoryToolStripMenuItem;
    }
}
