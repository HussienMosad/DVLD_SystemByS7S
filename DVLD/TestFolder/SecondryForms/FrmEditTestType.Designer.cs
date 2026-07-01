namespace DVLD.ApplicationsFolder.SecondryForms
{
    partial class FrmEditTestType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditTestType));
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.picHeader = new System.Windows.Forms.PictureBox();
            this.btnBack = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSave = new Guna.UI2.WinForms.Guna2GradientButton();
            this.labDescription = new System.Windows.Forms.Label();
            this.picDescription = new System.Windows.Forms.PictureBox();
            this.txtDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.labFees = new System.Windows.Forms.Label();
            this.labTitle = new System.Windows.Forms.Label();
            this.picFees = new System.Windows.Forms.PictureBox();
            this.txtFees = new Guna.UI2.WinForms.Guna2TextBox();
            this.picTitle = new System.Windows.Forms.PictureBox();
            this.txtTitle = new Guna.UI2.WinForms.Guna2TextBox();
            this.picCurrentPassword = new System.Windows.Forms.PictureBox();
            this.labID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCurrentPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderTitle.Location = new System.Drawing.Point(19, 14);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(419, 80);
            this.lblHeaderTitle.TabIndex = 4;
            this.lblHeaderTitle.Text = "- Edit Test Type";
            this.lblHeaderTitle.UseMnemonic = false;
            // 
            // picHeader
            // 
            this.picHeader.Image = ((System.Drawing.Image)(resources.GetObject("picHeader.Image")));
            this.picHeader.Location = new System.Drawing.Point(430, 3);
            this.picHeader.Name = "picHeader";
            this.picHeader.Size = new System.Drawing.Size(110, 110);
            this.picHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHeader.TabIndex = 5;
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
            this.btnBack.TabIndex = 69;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.Enter += new System.EventHandler(this.btnSwitchFillColor);
            this.btnBack.Leave += new System.EventHandler(this.btnSwitchFillColor);
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
            this.btnSave.TabIndex = 68;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.Enter += new System.EventHandler(this.btnSwitchFillColor);
            this.btnSave.Leave += new System.EventHandler(this.btnSwitchFillColor);
            // 
            // labDescription
            // 
            this.labDescription.AutoSize = true;
            this.labDescription.Font = new System.Drawing.Font("Impact", 20F);
            this.labDescription.Location = new System.Drawing.Point(176, 458);
            this.labDescription.Name = "labDescription";
            this.labDescription.Size = new System.Drawing.Size(159, 34);
            this.labDescription.TabIndex = 89;
            this.labDescription.Text = "Description  :";
            // 
            // picDescription
            // 
            this.picDescription.Image = ((System.Drawing.Image)(resources.GetObject("picDescription.Image")));
            this.picDescription.Location = new System.Drawing.Point(79, 436);
            this.picDescription.Name = "picDescription";
            this.picDescription.Size = new System.Drawing.Size(80, 80);
            this.picDescription.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDescription.TabIndex = 88;
            this.picDescription.TabStop = false;
            // 
            // txtDescription
            // 
            this.txtDescription.Animated = true;
            this.txtDescription.BorderColor = System.Drawing.Color.Gray;
            this.txtDescription.BorderRadius = 10;
            this.txtDescription.BorderThickness = 2;
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.DefaultText = "";
            this.txtDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescription.DisabledState.Parent = this.txtDescription;
            this.txtDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescription.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txtDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtDescription.FocusedState.Parent = this.txtDescription;
            this.txtDescription.Font = new System.Drawing.Font("Impact", 18F);
            this.txtDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtDescription.HoverState.ForeColor = System.Drawing.Color.Silver;
            this.txtDescription.HoverState.Parent = this.txtDescription;
            this.txtDescription.IconLeftOffset = new System.Drawing.Point(7, 0);
            this.txtDescription.Location = new System.Drawing.Point(343, 453);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(18);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtDescription.PlaceholderText = "";
            this.txtDescription.SelectedText = "";
            this.txtDescription.ShadowDecoration.Parent = this.txtDescription;
            this.txtDescription.Size = new System.Drawing.Size(671, 184);
            this.txtDescription.TabIndex = 87;
            this.txtDescription.TextOffset = new System.Drawing.Point(10, 0);
            this.txtDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescription_KeyPress);
            this.txtDescription.Validating += new System.ComponentModel.CancelEventHandler(this.txtDescription_Validating);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Impact", 28F);
            this.lblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.lblID.Location = new System.Drawing.Point(361, 185);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(40, 46);
            this.lblID.TabIndex = 98;
            this.lblID.Text = "?";
            // 
            // labFees
            // 
            this.labFees.AutoSize = true;
            this.labFees.Font = new System.Drawing.Font("Impact", 28F);
            this.labFees.Location = new System.Drawing.Point(174, 361);
            this.labFees.Name = "labFees";
            this.labFees.Size = new System.Drawing.Size(162, 46);
            this.labFees.TabIndex = 97;
            this.labFees.Text = "Fees         :";
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.Font = new System.Drawing.Font("Impact", 28F);
            this.labTitle.Location = new System.Drawing.Point(172, 272);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(160, 46);
            this.labTitle.TabIndex = 96;
            this.labTitle.Text = "Title         :";
            // 
            // picFees
            // 
            this.picFees.Image = ((System.Drawing.Image)(resources.GetObject("picFees.Image")));
            this.picFees.Location = new System.Drawing.Point(82, 348);
            this.picFees.Name = "picFees";
            this.picFees.Size = new System.Drawing.Size(80, 80);
            this.picFees.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFees.TabIndex = 95;
            this.picFees.TabStop = false;
            // 
            // txtFees
            // 
            this.txtFees.Animated = true;
            this.txtFees.BorderColor = System.Drawing.Color.Gray;
            this.txtFees.BorderRadius = 10;
            this.txtFees.BorderThickness = 2;
            this.txtFees.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFees.DefaultText = "";
            this.txtFees.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFees.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFees.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFees.DisabledState.Parent = this.txtFees;
            this.txtFees.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFees.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txtFees.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtFees.FocusedState.Parent = this.txtFees;
            this.txtFees.Font = new System.Drawing.Font("Impact", 28F);
            this.txtFees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtFees.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtFees.HoverState.ForeColor = System.Drawing.Color.Silver;
            this.txtFees.HoverState.Parent = this.txtFees;
            this.txtFees.IconLeftOffset = new System.Drawing.Point(7, 0);
            this.txtFees.Location = new System.Drawing.Point(343, 359);
            this.txtFees.Margin = new System.Windows.Forms.Padding(41, 42, 41, 42);
            this.txtFees.Name = "txtFees";
            this.txtFees.PasswordChar = '\0';
            this.txtFees.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFees.PlaceholderText = "";
            this.txtFees.SelectedText = "";
            this.txtFees.ShadowDecoration.Parent = this.txtFees;
            this.txtFees.Size = new System.Drawing.Size(671, 60);
            this.txtFees.TabIndex = 91;
            this.txtFees.TextOffset = new System.Drawing.Point(10, 0);
            this.txtFees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFees_KeyPress);
            this.txtFees.Validating += new System.ComponentModel.CancelEventHandler(this.txtFees_Validating);
            // 
            // picTitle
            // 
            this.picTitle.Image = ((System.Drawing.Image)(resources.GetObject("picTitle.Image")));
            this.picTitle.Location = new System.Drawing.Point(81, 259);
            this.picTitle.Name = "picTitle";
            this.picTitle.Size = new System.Drawing.Size(80, 80);
            this.picTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTitle.TabIndex = 94;
            this.picTitle.TabStop = false;
            // 
            // txtTitle
            // 
            this.txtTitle.Animated = true;
            this.txtTitle.BorderColor = System.Drawing.Color.Gray;
            this.txtTitle.BorderRadius = 10;
            this.txtTitle.BorderThickness = 2;
            this.txtTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTitle.DefaultText = "";
            this.txtTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTitle.DisabledState.Parent = this.txtTitle;
            this.txtTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTitle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txtTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtTitle.FocusedState.Parent = this.txtTitle;
            this.txtTitle.Font = new System.Drawing.Font("Impact", 24F);
            this.txtTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtTitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtTitle.HoverState.ForeColor = System.Drawing.Color.Silver;
            this.txtTitle.HoverState.Parent = this.txtTitle;
            this.txtTitle.IconLeftOffset = new System.Drawing.Point(7, 0);
            this.txtTitle.Location = new System.Drawing.Point(343, 268);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(23, 24, 23, 24);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.PasswordChar = '\0';
            this.txtTitle.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTitle.PlaceholderText = "";
            this.txtTitle.SelectedText = "";
            this.txtTitle.ShadowDecoration.Parent = this.txtTitle;
            this.txtTitle.Size = new System.Drawing.Size(671, 60);
            this.txtTitle.TabIndex = 90;
            this.txtTitle.TextOffset = new System.Drawing.Point(10, 0);
            this.txtTitle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTitle_KeyPress);
            this.txtTitle.Validating += new System.ComponentModel.CancelEventHandler(this.txtTitle_Validating);
            // 
            // picCurrentPassword
            // 
            this.picCurrentPassword.Image = ((System.Drawing.Image)(resources.GetObject("picCurrentPassword.Image")));
            this.picCurrentPassword.Location = new System.Drawing.Point(73, 152);
            this.picCurrentPassword.Name = "picCurrentPassword";
            this.picCurrentPassword.Size = new System.Drawing.Size(100, 100);
            this.picCurrentPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCurrentPassword.TabIndex = 93;
            this.picCurrentPassword.TabStop = false;
            // 
            // labID
            // 
            this.labID.AutoSize = true;
            this.labID.Font = new System.Drawing.Font("Impact", 28F);
            this.labID.Location = new System.Drawing.Point(176, 185);
            this.labID.Name = "labID";
            this.labID.Size = new System.Drawing.Size(158, 46);
            this.labID.TabIndex = 92;
            this.labID.Text = "ID              :";
            // 
            // FrmEditTestType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.labFees);
            this.Controls.Add(this.labTitle);
            this.Controls.Add(this.picFees);
            this.Controls.Add(this.txtFees);
            this.Controls.Add(this.picTitle);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.picCurrentPassword);
            this.Controls.Add(this.labID);
            this.Controls.Add(this.labDescription);
            this.Controls.Add(this.picDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.picHeader);
            this.Controls.Add(this.lblHeaderTitle);
            this.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "FrmEditTestType";
            this.Size = new System.Drawing.Size(1086, 723);
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCurrentPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private Guna.UI2.WinForms.Guna2GradientButton btnBack;
        private Guna.UI2.WinForms.Guna2GradientButton btnSave;
        private System.Windows.Forms.Label labDescription;
        private System.Windows.Forms.PictureBox picDescription;
        private Guna.UI2.WinForms.Guna2TextBox txtDescription;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label labFees;
        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.PictureBox picFees;
        private Guna.UI2.WinForms.Guna2TextBox txtFees;
        private System.Windows.Forms.PictureBox picTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtTitle;
        private System.Windows.Forms.PictureBox picCurrentPassword;
        private System.Windows.Forms.Label labID;
    }
}
