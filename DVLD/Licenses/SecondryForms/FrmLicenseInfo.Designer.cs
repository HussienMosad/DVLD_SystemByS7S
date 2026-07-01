namespace DVLD.Licenses.SecondryForms
{
    partial class FrmLicenseInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLicenseInfo));
            this.lblUsersManegment = new System.Windows.Forms.Label();
            this.btnBack = new Guna.UI2.WinForms.Guna2GradientButton();
            this.picUsers = new System.Windows.Forms.PictureBox();
            this.ucLicenseInfo1 = new DVLD.Licenses.SecondryForms.UcLicenseInfo();
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
            this.lblUsersManegment.Size = new System.Drawing.Size(497, 59);
            this.lblUsersManegment.TabIndex = 6;
            this.lblUsersManegment.Text = "- Show local License Info";
            this.lblUsersManegment.UseMnemonic = false;
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
            this.btnBack.TabIndex = 30;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.Enter += new System.EventHandler(this.btnSwitchFillColor);
            this.btnBack.Leave += new System.EventHandler(this.btnSwitchFillColor);
            // 
            // picUsers
            // 
            this.picUsers.Image = ((System.Drawing.Image)(resources.GetObject("picUsers.Image")));
            this.picUsers.Location = new System.Drawing.Point(535, 3);
            this.picUsers.Name = "picUsers";
            this.picUsers.Size = new System.Drawing.Size(100, 106);
            this.picUsers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUsers.TabIndex = 7;
            this.picUsers.TabStop = false;
            // 
            // ucLicenseInfo1
            // 
            this.ucLicenseInfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ucLicenseInfo1.Font = new System.Drawing.Font("Impact", 24F);
            this.ucLicenseInfo1.ForeColor = System.Drawing.Color.White;
            this.ucLicenseInfo1.Location = new System.Drawing.Point(0, 174);
            this.ucLicenseInfo1.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.ucLicenseInfo1.Name = "ucLicenseInfo1";
            this.ucLicenseInfo1.Size = new System.Drawing.Size(1086, 402);
            this.ucLicenseInfo1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(641, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // FrmLicenseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.ucLicenseInfo1);
            this.Controls.Add(this.picUsers);
            this.Controls.Add(this.lblUsersManegment);
            this.Font = new System.Drawing.Font("Impact", 24F);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "FrmLicenseInfo";
            this.Size = new System.Drawing.Size(1086, 723);
            ((System.ComponentModel.ISupportInitialize)(this.picUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picUsers;
        private System.Windows.Forms.Label lblUsersManegment;
        private UcLicenseInfo ucLicenseInfo1;
        private Guna.UI2.WinForms.Guna2GradientButton btnBack;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
