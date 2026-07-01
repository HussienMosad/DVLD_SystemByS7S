namespace DVLD
{
    partial class FrmAddEditPersonInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddEditPersonInfo));
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.picHeader = new System.Windows.Forms.PictureBox();
            this.btnBack = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSave = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnStrongBack = new Guna.UI2.WinForms.Guna2GradientButton();
            this.UcAddEditPersonInfo = new DVLD.UcAddEditPersonInfo();
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderTitle.Location = new System.Drawing.Point(19, 14);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(479, 80);
            this.lblHeaderTitle.TabIndex = 2;
            this.lblHeaderTitle.Text = "- Add New Person";
            this.lblHeaderTitle.UseMnemonic = false;
            // 
            // picHeader
            // 
            this.picHeader.Image = ((System.Drawing.Image)(resources.GetObject("picHeader.Image")));
            this.picHeader.Location = new System.Drawing.Point(494, 3);
            this.picHeader.Name = "picHeader";
            this.picHeader.Size = new System.Drawing.Size(110, 110);
            this.picHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHeader.TabIndex = 3;
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
            this.btnBack.Location = new System.Drawing.Point(193, 655);
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
            this.btnSave.TabIndex = 1;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.Enter += new System.EventHandler(this.btnSwitchFillColor);
            this.btnSave.Leave += new System.EventHandler(this.btnSwitchFillColor);
            // 
            // btnStrongBack
            // 
            this.btnStrongBack.Animated = true;
            this.btnStrongBack.BorderRadius = 20;
            this.btnStrongBack.CheckedState.Parent = this.btnStrongBack;
            this.btnStrongBack.CustomImages.Parent = this.btnStrongBack;
            this.btnStrongBack.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnStrongBack.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnStrongBack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnStrongBack.ForeColor = System.Drawing.Color.White;
            this.btnStrongBack.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnStrongBack.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnStrongBack.HoverState.Parent = this.btnStrongBack;
            this.btnStrongBack.Image = global::DVLD.Properties.Resources.back;
            this.btnStrongBack.ImageSize = new System.Drawing.Size(40, 40);
            this.btnStrongBack.Location = new System.Drawing.Point(48, 655);
            this.btnStrongBack.Name = "btnStrongBack";
            this.btnStrongBack.ShadowDecoration.Parent = this.btnStrongBack;
            this.btnStrongBack.Size = new System.Drawing.Size(66, 49);
            this.btnStrongBack.TabIndex = 3;
            this.btnStrongBack.Click += new System.EventHandler(this.btnStrongBack_Click);
            this.btnStrongBack.Enter += new System.EventHandler(this.btnSwitchFillColor);
            this.btnStrongBack.Leave += new System.EventHandler(this.btnSwitchFillColor);
            // 
            // UcAddEditPersonInfo
            // 
            this.UcAddEditPersonInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.UcAddEditPersonInfo.Font = new System.Drawing.Font("Impact", 24F);
            this.UcAddEditPersonInfo.ForeColor = System.Drawing.Color.White;
            this.UcAddEditPersonInfo.Location = new System.Drawing.Point(0, 162);
            this.UcAddEditPersonInfo.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.UcAddEditPersonInfo.Name = "UcAddEditPersonInfo";
            this.UcAddEditPersonInfo.Size = new System.Drawing.Size(1086, 451);
            this.UcAddEditPersonInfo.TabIndex = 0;
            // 
            // FrmAddEditPersonInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.UcAddEditPersonInfo);
            this.Controls.Add(this.picHeader);
            this.Controls.Add(this.lblHeaderTitle);
            this.Controls.Add(this.btnStrongBack);
            this.Font = new System.Drawing.Font("Impact", 24F);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "FrmAddEditPersonInfo";
            this.Size = new System.Drawing.Size(1086, 723);
            this.Load += new System.EventHandler(this.frmAddEditPersonInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.PictureBox picHeader;
        private UcAddEditPersonInfo UcAddEditPersonInfo;
        private Guna.UI2.WinForms.Guna2GradientButton btnBack;
        private Guna.UI2.WinForms.Guna2GradientButton btnSave;
        private Guna.UI2.WinForms.Guna2GradientButton btnStrongBack;
    }
}
