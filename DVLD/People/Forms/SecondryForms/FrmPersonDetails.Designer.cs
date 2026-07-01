namespace DVLD
{
    partial class FrmPersonDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonDetails));
            this.lblPersonDetails = new System.Windows.Forms.Label();
            this.btnBack = new Guna.UI2.WinForms.Guna2GradientButton();
            this.picPerson = new System.Windows.Forms.PictureBox();
            this.UcPersonDetails = new DVLD.UcPersonDetails();
            this.btnEditPerson = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.picPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPersonDetails
            // 
            this.lblPersonDetails.AutoSize = true;
            this.lblPersonDetails.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonDetails.Location = new System.Drawing.Point(19, 14);
            this.lblPersonDetails.Name = "lblPersonDetails";
            this.lblPersonDetails.Size = new System.Drawing.Size(443, 80);
            this.lblPersonDetails.TabIndex = 1;
            this.lblPersonDetails.Text = "- Person Details";
            this.lblPersonDetails.UseMnemonic = false;
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
            // picPerson
            // 
            this.picPerson.Image = ((System.Drawing.Image)(resources.GetObject("picPerson.Image")));
            this.picPerson.Location = new System.Drawing.Point(464, 3);
            this.picPerson.Name = "picPerson";
            this.picPerson.Size = new System.Drawing.Size(110, 110);
            this.picPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPerson.TabIndex = 2;
            this.picPerson.TabStop = false;
            // 
            // UcPersonDetails
            // 
            this.UcPersonDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.UcPersonDetails.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UcPersonDetails.ForeColor = System.Drawing.Color.White;
            this.UcPersonDetails.Location = new System.Drawing.Point(0, 158);
            this.UcPersonDetails.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.UcPersonDetails.Name = "UcPersonDetails";
            this.UcPersonDetails.Size = new System.Drawing.Size(1086, 451);
            this.UcPersonDetails.TabIndex = 2;
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
            // FrmPersonDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Controls.Add(this.btnEditPerson);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.UcPersonDetails);
            this.Controls.Add(this.picPerson);
            this.Controls.Add(this.lblPersonDetails);
            this.Font = new System.Drawing.Font("Impact", 24F);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "FrmPersonDetails";
            this.Size = new System.Drawing.Size(1086, 723);
            ((System.ComponentModel.ISupportInitialize)(this.picPerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPersonDetails;
        private System.Windows.Forms.PictureBox picPerson;
        private UcPersonDetails UcPersonDetails;
        private Guna.UI2.WinForms.Guna2GradientButton btnBack;
        private Guna.UI2.WinForms.Guna2GradientButton btnEditPerson;
    }
}
