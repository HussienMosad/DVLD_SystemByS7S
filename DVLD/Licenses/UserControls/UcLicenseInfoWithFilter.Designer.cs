namespace DVLD.Licenses.UserControls
{
    partial class UcLicenseInfoWithFilter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcLicenseInfoWithFilter));
            this.btnFindLicense = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtFilterBy = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblFilterBy = new System.Windows.Forms.Label();
            this.ucLicenseInfo1 = new DVLD.Licenses.SecondryForms.UcLicenseInfo();
            this.SuspendLayout();
            // 
            // btnFindLicense
            // 
            this.btnFindLicense.Animated = true;
            this.btnFindLicense.BorderRadius = 20;
            this.btnFindLicense.CheckedState.Parent = this.btnFindLicense;
            this.btnFindLicense.CustomImages.Parent = this.btnFindLicense;
            this.btnFindLicense.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnFindLicense.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnFindLicense.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFindLicense.ForeColor = System.Drawing.Color.White;
            this.btnFindLicense.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnFindLicense.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnFindLicense.HoverState.Parent = this.btnFindLicense;
            this.btnFindLicense.Image = ((System.Drawing.Image)(resources.GetObject("btnFindLicense.Image")));
            this.btnFindLicense.ImageSize = new System.Drawing.Size(40, 40);
            this.btnFindLicense.Location = new System.Drawing.Point(685, 4);
            this.btnFindLicense.Name = "btnFindLicense";
            this.btnFindLicense.ShadowDecoration.Parent = this.btnFindLicense;
            this.btnFindLicense.Size = new System.Drawing.Size(66, 49);
            this.btnFindLicense.TabIndex = 9;
            this.btnFindLicense.Click += new System.EventHandler(this.btnFindLicense_Click);
            this.btnFindLicense.Enter += new System.EventHandler(this.btnSwitchFillColor);
            this.btnFindLicense.Leave += new System.EventHandler(this.btnSwitchFillColor);
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
            this.txtFilterBy.Location = new System.Drawing.Point(433, 4);
            this.txtFilterBy.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.txtFilterBy.Name = "txtFilterBy";
            this.txtFilterBy.PasswordChar = '\0';
            this.txtFilterBy.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFilterBy.PlaceholderText = "";
            this.txtFilterBy.SelectedText = "";
            this.txtFilterBy.ShadowDecoration.Parent = this.txtFilterBy;
            this.txtFilterBy.Size = new System.Drawing.Size(241, 48);
            this.txtFilterBy.TabIndex = 8;
            this.txtFilterBy.TextOffset = new System.Drawing.Point(10, 0);
            this.txtFilterBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterBy_KeyPress);
            // 
            // lblFilterBy
            // 
            this.lblFilterBy.AutoSize = true;
            this.lblFilterBy.Font = new System.Drawing.Font("Impact", 16F);
            this.lblFilterBy.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblFilterBy.Location = new System.Drawing.Point(329, 15);
            this.lblFilterBy.Name = "lblFilterBy";
            this.lblFilterBy.Size = new System.Drawing.Size(93, 27);
            this.lblFilterBy.TabIndex = 10;
            this.lblFilterBy.Text = "Filter By :";
            this.lblFilterBy.UseMnemonic = false;
            // 
            // ucLicenseInfo1
            // 
            this.ucLicenseInfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ucLicenseInfo1.Font = new System.Drawing.Font("Impact", 24F);
            this.ucLicenseInfo1.ForeColor = System.Drawing.Color.White;
            this.ucLicenseInfo1.Location = new System.Drawing.Point(0, 38);
            this.ucLicenseInfo1.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.ucLicenseInfo1.Name = "ucLicenseInfo1";
            this.ucLicenseInfo1.Size = new System.Drawing.Size(1086, 402);
            this.ucLicenseInfo1.TabIndex = 0;
            // 
            // UcLicenseInfoWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Controls.Add(this.btnFindLicense);
            this.Controls.Add(this.txtFilterBy);
            this.Controls.Add(this.lblFilterBy);
            this.Controls.Add(this.ucLicenseInfo1);
            this.Font = new System.Drawing.Font("Impact", 24F);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "UcLicenseInfoWithFilter";
            this.Size = new System.Drawing.Size(1086, 446);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SecondryForms.UcLicenseInfo ucLicenseInfo1;
        private Guna.UI2.WinForms.Guna2GradientButton btnFindLicense;
        private Guna.UI2.WinForms.Guna2TextBox txtFilterBy;
        private System.Windows.Forms.Label lblFilterBy;
    }
}
