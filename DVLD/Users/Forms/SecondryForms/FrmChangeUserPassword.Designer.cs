namespace DVLD.Users.Forms.SecondryForms
{
    partial class FrmChangeUserPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChangeUserPassword));
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.txtCurrentPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCurrentPassword = new System.Windows.Forms.Label();
            this.txtNewPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.ucUserDetails = new DVLD.Users.UserControls.UcUserDetails();
            this.btnEditPerson = new Guna.UI2.WinForms.Guna2GradientButton();
            this.picConfirmPassword = new System.Windows.Forms.PictureBox();
            this.picNewPassword = new System.Windows.Forms.PictureBox();
            this.picCurrentPassword = new System.Windows.Forms.PictureBox();
            this.btnBack = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSave = new Guna.UI2.WinForms.Guna2GradientButton();
            this.picHeader = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picConfirmPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNewPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCurrentPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderTitle.Location = new System.Drawing.Point(19, 14);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(531, 80);
            this.lblHeaderTitle.TabIndex = 4;
            this.lblHeaderTitle.Text = "- Change Password";
            this.lblHeaderTitle.UseMnemonic = false;
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.Animated = true;
            this.txtCurrentPassword.BorderColor = System.Drawing.Color.Gray;
            this.txtCurrentPassword.BorderRadius = 10;
            this.txtCurrentPassword.BorderThickness = 2;
            this.txtCurrentPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCurrentPassword.DefaultText = "";
            this.txtCurrentPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCurrentPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCurrentPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCurrentPassword.DisabledState.Parent = this.txtCurrentPassword;
            this.txtCurrentPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCurrentPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txtCurrentPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtCurrentPassword.FocusedState.Parent = this.txtCurrentPassword;
            this.txtCurrentPassword.Font = new System.Drawing.Font("Impact", 16F);
            this.txtCurrentPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtCurrentPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtCurrentPassword.HoverState.ForeColor = System.Drawing.Color.Silver;
            this.txtCurrentPassword.HoverState.Parent = this.txtCurrentPassword;
            this.txtCurrentPassword.IconLeftOffset = new System.Drawing.Point(7, 0);
            this.txtCurrentPassword.Location = new System.Drawing.Point(833, 487);
            this.txtCurrentPassword.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.PasswordChar = '\0';
            this.txtCurrentPassword.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtCurrentPassword.PlaceholderText = "";
            this.txtCurrentPassword.SelectedText = "";
            this.txtCurrentPassword.ShadowDecoration.Parent = this.txtCurrentPassword;
            this.txtCurrentPassword.Size = new System.Drawing.Size(246, 39);
            this.txtCurrentPassword.TabIndex = 3;
            this.txtCurrentPassword.TextOffset = new System.Drawing.Point(10, 0);
            this.txtCurrentPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            this.txtCurrentPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtCurrentPassword_Validating);
            // 
            // lblCurrentPassword
            // 
            this.lblCurrentPassword.AutoSize = true;
            this.lblCurrentPassword.Font = new System.Drawing.Font("Impact", 15F);
            this.lblCurrentPassword.Location = new System.Drawing.Point(666, 492);
            this.lblCurrentPassword.Name = "lblCurrentPassword";
            this.lblCurrentPassword.Size = new System.Drawing.Size(167, 25);
            this.lblCurrentPassword.TabIndex = 55;
            this.lblCurrentPassword.Text = "Current Password  :";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Animated = true;
            this.txtNewPassword.BorderColor = System.Drawing.Color.Gray;
            this.txtNewPassword.BorderRadius = 10;
            this.txtNewPassword.BorderThickness = 2;
            this.txtNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPassword.DefaultText = "";
            this.txtNewPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNewPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNewPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewPassword.DisabledState.Parent = this.txtNewPassword;
            this.txtNewPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txtNewPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtNewPassword.FocusedState.Parent = this.txtNewPassword;
            this.txtNewPassword.Font = new System.Drawing.Font("Impact", 16F);
            this.txtNewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtNewPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtNewPassword.HoverState.ForeColor = System.Drawing.Color.Silver;
            this.txtNewPassword.HoverState.Parent = this.txtNewPassword;
            this.txtNewPassword.IconLeftOffset = new System.Drawing.Point(7, 0);
            this.txtNewPassword.Location = new System.Drawing.Point(833, 527);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '\0';
            this.txtNewPassword.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNewPassword.PlaceholderText = "";
            this.txtNewPassword.SelectedText = "";
            this.txtNewPassword.ShadowDecoration.Parent = this.txtNewPassword;
            this.txtNewPassword.Size = new System.Drawing.Size(246, 39);
            this.txtNewPassword.TabIndex = 4;
            this.txtNewPassword.TextOffset = new System.Drawing.Point(10, 0);
            this.txtNewPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            this.txtNewPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtCurrentPassword_Validating);
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Impact", 16F);
            this.lblNewPassword.Location = new System.Drawing.Point(666, 532);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(165, 27);
            this.lblNewPassword.TabIndex = 58;
            this.lblNewPassword.Text = "New Password     :";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Animated = true;
            this.txtConfirmPassword.BorderColor = System.Drawing.Color.Gray;
            this.txtConfirmPassword.BorderRadius = 10;
            this.txtConfirmPassword.BorderThickness = 2;
            this.txtConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmPassword.DefaultText = "";
            this.txtConfirmPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtConfirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtConfirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfirmPassword.DisabledState.Parent = this.txtConfirmPassword;
            this.txtConfirmPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfirmPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txtConfirmPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtConfirmPassword.FocusedState.Parent = this.txtConfirmPassword;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Impact", 16F);
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtConfirmPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtConfirmPassword.HoverState.ForeColor = System.Drawing.Color.Silver;
            this.txtConfirmPassword.HoverState.Parent = this.txtConfirmPassword;
            this.txtConfirmPassword.IconLeftOffset = new System.Drawing.Point(7, 0);
            this.txtConfirmPassword.Location = new System.Drawing.Point(833, 567);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '\0';
            this.txtConfirmPassword.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtConfirmPassword.PlaceholderText = "";
            this.txtConfirmPassword.SelectedText = "";
            this.txtConfirmPassword.ShadowDecoration.Parent = this.txtConfirmPassword;
            this.txtConfirmPassword.Size = new System.Drawing.Size(246, 39);
            this.txtConfirmPassword.TabIndex = 5;
            this.txtConfirmPassword.TextOffset = new System.Drawing.Point(10, 0);
            this.txtConfirmPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            this.txtConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtCurrentPassword_Validating);
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Impact", 14F);
            this.lblConfirmPassword.Location = new System.Drawing.Point(666, 572);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(165, 23);
            this.lblConfirmPassword.TabIndex = 61;
            this.lblConfirmPassword.Text = "Confirm Password  :";
            // 
            // ucUserDetails
            // 
            this.ucUserDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ucUserDetails.Font = new System.Drawing.Font("Impact", 24F);
            this.ucUserDetails.ForeColor = System.Drawing.Color.White;
            this.ucUserDetails.Location = new System.Drawing.Point(0, 158);
            this.ucUserDetails.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.ucUserDetails.Name = "ucUserDetails";
            this.ucUserDetails.Size = new System.Drawing.Size(1086, 451);
            this.ucUserDetails.TabIndex = 6;
            this.ucUserDetails.TabStop = false;
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
            this.btnEditPerson.Location = new System.Drawing.Point(497, 655);
            this.btnEditPerson.Name = "btnEditPerson";
            this.btnEditPerson.ShadowDecoration.Parent = this.btnEditPerson;
            this.btnEditPerson.Size = new System.Drawing.Size(66, 49);
            this.btnEditPerson.TabIndex = 1;
            this.btnEditPerson.Click += new System.EventHandler(this.btnEditPerson_Click);
            this.btnEditPerson.Enter += new System.EventHandler(this.btnSwitchFillColor);
            this.btnEditPerson.Leave += new System.EventHandler(this.btnSwitchFillColor);
            // 
            // picConfirmPassword
            // 
            this.picConfirmPassword.Image = ((System.Drawing.Image)(resources.GetObject("picConfirmPassword.Image")));
            this.picConfirmPassword.Location = new System.Drawing.Point(623, 571);
            this.picConfirmPassword.Name = "picConfirmPassword";
            this.picConfirmPassword.Size = new System.Drawing.Size(30, 27);
            this.picConfirmPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picConfirmPassword.TabIndex = 62;
            this.picConfirmPassword.TabStop = false;
            // 
            // picNewPassword
            // 
            this.picNewPassword.Image = ((System.Drawing.Image)(resources.GetObject("picNewPassword.Image")));
            this.picNewPassword.Location = new System.Drawing.Point(623, 531);
            this.picNewPassword.Name = "picNewPassword";
            this.picNewPassword.Size = new System.Drawing.Size(30, 27);
            this.picNewPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNewPassword.TabIndex = 59;
            this.picNewPassword.TabStop = false;
            // 
            // picCurrentPassword
            // 
            this.picCurrentPassword.Image = ((System.Drawing.Image)(resources.GetObject("picCurrentPassword.Image")));
            this.picCurrentPassword.Location = new System.Drawing.Point(623, 491);
            this.picCurrentPassword.Name = "picCurrentPassword";
            this.picCurrentPassword.Size = new System.Drawing.Size(30, 27);
            this.picCurrentPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCurrentPassword.TabIndex = 56;
            this.picCurrentPassword.TabStop = false;
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
            this.btnBack.TabIndex = 2;
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
            this.btnSave.Location = new System.Drawing.Point(973, 655);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(66, 49);
            this.btnSave.TabIndex = 0;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.Enter += new System.EventHandler(this.btnSwitchFillColor);
            this.btnSave.Leave += new System.EventHandler(this.btnSwitchFillColor);
            // 
            // picHeader
            // 
            this.picHeader.Image = global::DVLD.Properties.Resources.reset_password;
            this.picHeader.Location = new System.Drawing.Point(541, 3);
            this.picHeader.Name = "picHeader";
            this.picHeader.Size = new System.Drawing.Size(110, 110);
            this.picHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHeader.TabIndex = 5;
            this.picHeader.TabStop = false;
            // 
            // FrmChangeUserPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Controls.Add(this.btnEditPerson);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.picConfirmPassword);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.picNewPassword);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.txtCurrentPassword);
            this.Controls.Add(this.picCurrentPassword);
            this.Controls.Add(this.lblCurrentPassword);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ucUserDetails);
            this.Controls.Add(this.picHeader);
            this.Controls.Add(this.lblHeaderTitle);
            this.Font = new System.Drawing.Font("Impact", 24F);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "FrmChangeUserPassword";
            this.Size = new System.Drawing.Size(1086, 723);
            ((System.ComponentModel.ISupportInitialize)(this.picConfirmPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNewPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCurrentPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private UserControls.UcUserDetails ucUserDetails;
        private Guna.UI2.WinForms.Guna2GradientButton btnSave;
        private Guna.UI2.WinForms.Guna2GradientButton btnBack;
        private Guna.UI2.WinForms.Guna2TextBox txtCurrentPassword;
        private System.Windows.Forms.PictureBox picCurrentPassword;
        private System.Windows.Forms.Label lblCurrentPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtNewPassword;
        private System.Windows.Forms.PictureBox picNewPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtConfirmPassword;
        private System.Windows.Forms.PictureBox picConfirmPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private Guna.UI2.WinForms.Guna2GradientButton btnEditPerson;
    }
}
