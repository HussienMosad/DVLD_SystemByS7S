using Guna.UI2.WinForms;

namespace DVLD.Users.Forms.SecondryForms
{
    partial class FrmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettings));
            this.lblUserDetails = new System.Windows.Forms.Label();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.btnCurrentUserDetails = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnChangePassword = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSignOut = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserDetails
            // 
            this.lblUserDetails.AutoSize = true;
            this.lblUserDetails.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserDetails.Location = new System.Drawing.Point(20, 28);
            this.lblUserDetails.Name = "lblUserDetails";
            this.lblUserDetails.Size = new System.Drawing.Size(283, 80);
            this.lblUserDetails.TabIndex = 5;
            this.lblUserDetails.Text = "- Settings";
            this.lblUserDetails.UseMnemonic = false;
            // 
            // picUser
            // 
            this.picUser.Image = global::DVLD.Properties.Resources.Settings;
            this.picUser.Location = new System.Drawing.Point(307, 17);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(110, 110);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUser.TabIndex = 6;
            this.picUser.TabStop = false;
            // 
            // btnCurrentUserDetails
            // 
            this.btnCurrentUserDetails.Animated = true;
            this.btnCurrentUserDetails.BorderRadius = 10;
            this.btnCurrentUserDetails.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnCurrentUserDetails.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnCurrentUserDetails.CheckedState.Font = new System.Drawing.Font("Impact", 25F);
            this.btnCurrentUserDetails.CheckedState.Parent = this.btnCurrentUserDetails;
            this.btnCurrentUserDetails.CustomImages.Parent = this.btnCurrentUserDetails;
            this.btnCurrentUserDetails.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnCurrentUserDetails.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnCurrentUserDetails.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCurrentUserDetails.ForeColor = System.Drawing.Color.White;
            this.btnCurrentUserDetails.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnCurrentUserDetails.HoverState.Font = new System.Drawing.Font("Impact", 25F);
            this.btnCurrentUserDetails.HoverState.Parent = this.btnCurrentUserDetails;
            this.btnCurrentUserDetails.Image = ((System.Drawing.Image)(resources.GetObject("btnCurrentUserDetails.Image")));
            this.btnCurrentUserDetails.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCurrentUserDetails.ImageSize = new System.Drawing.Size(55, 55);
            this.btnCurrentUserDetails.Location = new System.Drawing.Point(240, 187);
            this.btnCurrentUserDetails.Margin = new System.Windows.Forms.Padding(0);
            this.btnCurrentUserDetails.Name = "btnCurrentUserDetails";
            this.btnCurrentUserDetails.ShadowDecoration.Parent = this.btnCurrentUserDetails;
            this.btnCurrentUserDetails.Size = new System.Drawing.Size(610, 82);
            this.btnCurrentUserDetails.TabIndex = 0;
            this.btnCurrentUserDetails.Tag = "0";
            this.btnCurrentUserDetails.Text = "Current User Details";
            this.btnCurrentUserDetails.Click += new System.EventHandler(this.btnShowUserDetails_Click);
            this.btnCurrentUserDetails.Enter += new System.EventHandler(this.btnFocusEffect_Enter);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Animated = true;
            this.btnChangePassword.BorderRadius = 10;
            this.btnChangePassword.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnChangePassword.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnChangePassword.CheckedState.Font = new System.Drawing.Font("Impact", 25F);
            this.btnChangePassword.CheckedState.Parent = this.btnChangePassword;
            this.btnChangePassword.CustomImages.Parent = this.btnChangePassword;
            this.btnChangePassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnChangePassword.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnChangePassword.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnChangePassword.HoverState.Font = new System.Drawing.Font("Impact", 25F);
            this.btnChangePassword.HoverState.Parent = this.btnChangePassword;
            this.btnChangePassword.Image = global::DVLD.Properties.Resources.reset_password;
            this.btnChangePassword.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnChangePassword.ImageSize = new System.Drawing.Size(55, 55);
            this.btnChangePassword.Location = new System.Drawing.Point(240, 348);
            this.btnChangePassword.Margin = new System.Windows.Forms.Padding(0);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.ShadowDecoration.Parent = this.btnChangePassword;
            this.btnChangePassword.Size = new System.Drawing.Size(610, 82);
            this.btnChangePassword.TabIndex = 1;
            this.btnChangePassword.Tag = "1";
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            this.btnChangePassword.Enter += new System.EventHandler(this.btnFocusEffect_Enter);
            // 
            // btnSignOut
            // 
            this.btnSignOut.Animated = true;
            this.btnSignOut.BorderRadius = 10;
            this.btnSignOut.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnSignOut.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSignOut.CheckedState.Font = new System.Drawing.Font("Impact", 25F);
            this.btnSignOut.CheckedState.Parent = this.btnSignOut;
            this.btnSignOut.CustomImages.Parent = this.btnSignOut;
            this.btnSignOut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSignOut.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSignOut.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.ForeColor = System.Drawing.Color.White;
            this.btnSignOut.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnSignOut.HoverState.Font = new System.Drawing.Font("Impact", 25F);
            this.btnSignOut.HoverState.Parent = this.btnSignOut;
            this.btnSignOut.Image = ((System.Drawing.Image)(resources.GetObject("btnSignOut.Image")));
            this.btnSignOut.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSignOut.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnSignOut.ImageSize = new System.Drawing.Size(55, 55);
            this.btnSignOut.Location = new System.Drawing.Point(240, 509);
            this.btnSignOut.Margin = new System.Windows.Forms.Padding(0);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.ShadowDecoration.Parent = this.btnSignOut;
            this.btnSignOut.Size = new System.Drawing.Size(610, 82);
            this.btnSignOut.TabIndex = 2;
            this.btnSignOut.Tag = "2";
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            this.btnSignOut.Enter += new System.EventHandler(this.btnFocusEffect_Enter);
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.btnCurrentUserDetails);
            this.Controls.Add(this.picUser);
            this.Controls.Add(this.lblUserDetails);
            this.Font = new System.Drawing.Font("Impact", 24F);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "FrmSettings";
            this.Size = new System.Drawing.Size(1086, 723);
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void InitializeBtns()
        {
            btnsFrmSettings[0] = btnCurrentUserDetails;
            btnsFrmSettings[1] = btnChangePassword;
            btnsFrmSettings[2] = btnSignOut;

        }

        #endregion

        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.Label lblUserDetails;
        private Guna.UI2.WinForms.Guna2GradientButton btnCurrentUserDetails;
        private Guna.UI2.WinForms.Guna2GradientButton btnChangePassword;
        private Guna.UI2.WinForms.Guna2GradientButton btnSignOut;
        private Guna2GradientButton[] btnsFrmSettings = new Guna2GradientButton[3];
    }
}
