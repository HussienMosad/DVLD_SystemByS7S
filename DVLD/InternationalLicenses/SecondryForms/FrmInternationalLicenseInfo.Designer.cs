namespace DVLD.InternationalLicenses.SecondryForms
{
    partial class FrmInternationalLicenseInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInternationalLicenseInfo));
            this.lblUsersManegment = new System.Windows.Forms.Label();
            this.picUsers = new System.Windows.Forms.PictureBox();
            this.btnBack = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ucInternationalLicenseInfo1 = new DVLD.InternationalLicenses.UserControls.UcInternationalLicenseInfo();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsersManegment
            // 
            this.lblUsersManegment.AutoSize = true;
            this.lblUsersManegment.Font = new System.Drawing.Font("Impact", 35F);
            this.lblUsersManegment.Location = new System.Drawing.Point(32, 17);
            this.lblUsersManegment.Name = "lblUsersManegment";
            this.lblUsersManegment.Size = new System.Drawing.Size(655, 59);
            this.lblUsersManegment.TabIndex = 8;
            this.lblUsersManegment.Text = "- Show International License Info";
            this.lblUsersManegment.UseMnemonic = false;
            // 
            // picUsers
            // 
            this.picUsers.Image = ((System.Drawing.Image)(resources.GetObject("picUsers.Image")));
            this.picUsers.Location = new System.Drawing.Point(693, 3);
            this.picUsers.Name = "picUsers";
            this.picUsers.Size = new System.Drawing.Size(100, 106);
            this.picUsers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUsers.TabIndex = 9;
            this.picUsers.TabStop = false;
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
            this.btnBack.TabIndex = 31;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.Enter += new System.EventHandler(this.btnSwitchFillColor);
            this.btnBack.Leave += new System.EventHandler(this.btnSwitchFillColor);
            // 
            // ucInternationalLicenseInfo1
            // 
            this.ucInternationalLicenseInfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ucInternationalLicenseInfo1.Font = new System.Drawing.Font("Impact", 24F);
            this.ucInternationalLicenseInfo1.ForeColor = System.Drawing.Color.White;
            this.ucInternationalLicenseInfo1.Location = new System.Drawing.Point(0, 190);
            this.ucInternationalLicenseInfo1.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.ucInternationalLicenseInfo1.Name = "ucInternationalLicenseInfo1";
            this.ucInternationalLicenseInfo1.Size = new System.Drawing.Size(1086, 385);
            this.ucInternationalLicenseInfo1.TabIndex = 32;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(799, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // FrmInternationalLicenseID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ucInternationalLicenseInfo1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.picUsers);
            this.Controls.Add(this.lblUsersManegment);
            this.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "FrmInternationalLicenseID";
            this.Size = new System.Drawing.Size(1086, 723);
            ((System.ComponentModel.ISupportInitialize)(this.picUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picUsers;
        private System.Windows.Forms.Label lblUsersManegment;
        private Guna.UI2.WinForms.Guna2GradientButton btnBack;
        private UserControls.UcInternationalLicenseInfo ucInternationalLicenseInfo1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
