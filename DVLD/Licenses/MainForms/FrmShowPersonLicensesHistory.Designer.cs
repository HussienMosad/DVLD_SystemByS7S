namespace DVLD.Licenses.MainForms
{
    partial class FrmShowPersonLicensesHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmShowPersonLicensesHistory));
            this.picUsers = new System.Windows.Forms.PictureBox();
            this.lblUsersManegment = new System.Windows.Forms.Label();
            this.btnLocal = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnBack = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnInternational = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label1 = new System.Windows.Forms.Label();
            this.ucPersonDetailsWithFilter1 = new DVLD.People.UserControls.UcPersonDetailsWithFilter();
            ((System.ComponentModel.ISupportInitialize)(this.picUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // picUsers
            // 
            this.picUsers.Image = ((System.Drawing.Image)(resources.GetObject("picUsers.Image")));
            this.picUsers.Location = new System.Drawing.Point(541, 3);
            this.picUsers.Name = "picUsers";
            this.picUsers.Size = new System.Drawing.Size(100, 106);
            this.picUsers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUsers.TabIndex = 7;
            this.picUsers.TabStop = false;
            // 
            // lblUsersManegment
            // 
            this.lblUsersManegment.AutoSize = true;
            this.lblUsersManegment.Font = new System.Drawing.Font("Impact", 35F);
            this.lblUsersManegment.Location = new System.Drawing.Point(27, 17);
            this.lblUsersManegment.Name = "lblUsersManegment";
            this.lblUsersManegment.Size = new System.Drawing.Size(508, 59);
            this.lblUsersManegment.TabIndex = 6;
            this.lblUsersManegment.Text = "- Person Licenses History";
            this.lblUsersManegment.UseMnemonic = false;
            // 
            // btnLocal
            // 
            this.btnLocal.Animated = true;
            this.btnLocal.BorderRadius = 20;
            this.btnLocal.CheckedState.Parent = this.btnLocal;
            this.btnLocal.CustomImages.Parent = this.btnLocal;
            this.btnLocal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnLocal.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnLocal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLocal.ForeColor = System.Drawing.Color.White;
            this.btnLocal.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnLocal.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnLocal.HoverState.Parent = this.btnLocal;
            this.btnLocal.Image = ((System.Drawing.Image)(resources.GetObject("btnLocal.Image")));
            this.btnLocal.ImageOffset = new System.Drawing.Point(1, 0);
            this.btnLocal.ImageSize = new System.Drawing.Size(40, 40);
            this.btnLocal.Location = new System.Drawing.Point(973, 655);
            this.btnLocal.Name = "btnLocal";
            this.btnLocal.ShadowDecoration.Parent = this.btnLocal;
            this.btnLocal.Size = new System.Drawing.Size(66, 49);
            this.btnLocal.TabIndex = 1;
            this.btnLocal.Click += new System.EventHandler(this.btnLocal_Click);
            this.btnLocal.Enter += new System.EventHandler(this.btnSwitchFillColor);
            this.btnLocal.Leave += new System.EventHandler(this.btnSwitchFillColor);
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
            this.btnBack.TabIndex = 3;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.Enter += new System.EventHandler(this.btnSwitchFillColor);
            this.btnBack.Leave += new System.EventHandler(this.btnSwitchFillColor);
            // 
            // btnInternational
            // 
            this.btnInternational.Animated = true;
            this.btnInternational.BorderRadius = 20;
            this.btnInternational.CheckedState.Parent = this.btnInternational;
            this.btnInternational.CustomImages.Parent = this.btnInternational;
            this.btnInternational.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnInternational.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnInternational.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnInternational.ForeColor = System.Drawing.Color.White;
            this.btnInternational.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnInternational.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnInternational.HoverState.Parent = this.btnInternational;
            this.btnInternational.Image = ((System.Drawing.Image)(resources.GetObject("btnInternational.Image")));
            this.btnInternational.ImageOffset = new System.Drawing.Point(1, 0);
            this.btnInternational.ImageSize = new System.Drawing.Size(40, 40);
            this.btnInternational.Location = new System.Drawing.Point(882, 655);
            this.btnInternational.Name = "btnInternational";
            this.btnInternational.ShadowDecoration.Parent = this.btnInternational;
            this.btnInternational.Size = new System.Drawing.Size(66, 49);
            this.btnInternational.TabIndex = 2;
            this.btnInternational.Click += new System.EventHandler(this.btnInternational_Click);
            this.btnInternational.Enter += new System.EventHandler(this.btnSwitchFillColor);
            this.btnInternational.Leave += new System.EventHandler(this.btnSwitchFillColor);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(666, 666);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 26);
            this.label1.TabIndex = 34;
            this.label1.Text = "Chose License Type :";
            this.label1.UseMnemonic = false;
            // 
            // ucPersonDetailsWithFilter1
            // 
            this.ucPersonDetailsWithFilter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ucPersonDetailsWithFilter1.Font = new System.Drawing.Font("Impact", 24F);
            this.ucPersonDetailsWithFilter1.ForeColor = System.Drawing.Color.White;
            this.ucPersonDetailsWithFilter1.Location = new System.Drawing.Point(0, 117);
            this.ucPersonDetailsWithFilter1.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.ucPersonDetailsWithFilter1.MaximumSize = new System.Drawing.Size(1086, 564);
            this.ucPersonDetailsWithFilter1.Name = "ucPersonDetailsWithFilter1";
            this.ucPersonDetailsWithFilter1.Size = new System.Drawing.Size(1086, 527);
            this.ucPersonDetailsWithFilter1.TabIndex = 0;
            // 
            // FrmShowPersonLicensesHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInternational);
            this.Controls.Add(this.btnLocal);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.ucPersonDetailsWithFilter1);
            this.Controls.Add(this.picUsers);
            this.Controls.Add(this.lblUsersManegment);
            this.Font = new System.Drawing.Font("Impact", 24F);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "FrmShowPersonLicensesHistory";
            this.Size = new System.Drawing.Size(1086, 723);
            ((System.ComponentModel.ISupportInitialize)(this.picUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picUsers;
        private System.Windows.Forms.Label lblUsersManegment;
        private People.UserControls.UcPersonDetailsWithFilter ucPersonDetailsWithFilter1;
        private Guna.UI2.WinForms.Guna2GradientButton btnLocal;
        private Guna.UI2.WinForms.Guna2GradientButton btnBack;
        private Guna.UI2.WinForms.Guna2GradientButton btnInternational;
        private System.Windows.Forms.Label label1;
    }
}
