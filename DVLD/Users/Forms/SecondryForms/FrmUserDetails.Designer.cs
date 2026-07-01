namespace DVLD.Users.Forms.SecondryForms
{
    partial class FrmUserDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUserDetails));
            this.ucUserDetails1 = new DVLD.Users.UserControls.UcUserDetails();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.lblUserDetails = new System.Windows.Forms.Label();
            this.btnBack = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnEditPerson = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            this.SuspendLayout();
            // 
            // ucUserDetails1
            // 
            this.ucUserDetails1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ucUserDetails1.Font = new System.Drawing.Font("Impact", 24F);
            this.ucUserDetails1.ForeColor = System.Drawing.Color.White;
            this.ucUserDetails1.Location = new System.Drawing.Point(0, 158);
            this.ucUserDetails1.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.ucUserDetails1.Name = "ucUserDetails1";
            this.ucUserDetails1.Size = new System.Drawing.Size(1086, 451);
            this.ucUserDetails1.TabIndex = 0;
            this.ucUserDetails1.TabStop = false;
            // 
            // picUser
            // 
            this.picUser.Image = ((System.Drawing.Image)(resources.GetObject("picUser.Image")));
            this.picUser.Location = new System.Drawing.Point(417, 17);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(110, 110);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUser.TabIndex = 4;
            this.picUser.TabStop = false;
            // 
            // lblUserDetails
            // 
            this.lblUserDetails.AutoSize = true;
            this.lblUserDetails.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserDetails.Location = new System.Drawing.Point(20, 28);
            this.lblUserDetails.Name = "lblUserDetails";
            this.lblUserDetails.Size = new System.Drawing.Size(380, 80);
            this.lblUserDetails.TabIndex = 3;
            this.lblUserDetails.Text = "- User Details";
            this.lblUserDetails.UseMnemonic = false;
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
            this.btnBack.TabIndex = 1;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.Enter += new System.EventHandler(this.btnSwitchFillColor);
            this.btnBack.Leave += new System.EventHandler(this.btnSwitchFillColor);
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
            this.btnEditPerson.Location = new System.Drawing.Point(973, 655);
            this.btnEditPerson.Name = "btnEditPerson";
            this.btnEditPerson.ShadowDecoration.Parent = this.btnEditPerson;
            this.btnEditPerson.Size = new System.Drawing.Size(66, 49);
            this.btnEditPerson.TabIndex = 0;
            this.btnEditPerson.Click += new System.EventHandler(this.btnEditPerson_Click);
            this.btnEditPerson.Enter += new System.EventHandler(this.btnSwitchFillColor);
            this.btnEditPerson.Leave += new System.EventHandler(this.btnSwitchFillColor);
            // 
            // FrmUserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Controls.Add(this.btnEditPerson);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.picUser);
            this.Controls.Add(this.lblUserDetails);
            this.Controls.Add(this.ucUserDetails1);
            this.Font = new System.Drawing.Font("Impact", 24F);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "FrmUserDetails";
            this.Size = new System.Drawing.Size(1086, 723);
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.UcUserDetails ucUserDetails1;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.Label lblUserDetails;
        private Guna.UI2.WinForms.Guna2GradientButton btnBack;
        private Guna.UI2.WinForms.Guna2GradientButton btnEditPerson;
    }
}
