namespace DVLD.TestFolder.MainForms
{
    partial class FrmScheduleTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmScheduleTest));
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.labRetakeFees = new System.Windows.Forms.Label();
            this.lblRetakeFees = new System.Windows.Forms.Label();
            this.labTotalFees = new System.Windows.Forms.Label();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.labRetakeAppID = new System.Windows.Forms.Label();
            this.lblRetakeAppID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picRetakeAppID = new System.Windows.Forms.PictureBox();
            this.picFees = new System.Windows.Forms.PictureBox();
            this.picRetakeFees = new System.Windows.Forms.PictureBox();
            this.ucForTestSchedule1 = new DVLD.TestFolder.UserControls.UcForTestSchedule();
            this.btnSave = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnBack = new Guna.UI2.WinForms.Guna2GradientButton();
            this.picHeader = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRetakeAppID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRetakeFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Impact", 45F);
            this.lblHeaderTitle.Location = new System.Drawing.Point(22, 16);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(569, 75);
            this.lblHeaderTitle.TabIndex = 14;
            this.lblHeaderTitle.Text = "- Vision Test Schedule";
            this.lblHeaderTitle.UseMnemonic = false;
            // 
            // labRetakeFees
            // 
            this.labRetakeFees.AutoEllipsis = true;
            this.labRetakeFees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.labRetakeFees.Location = new System.Drawing.Point(299, 32);
            this.labRetakeFees.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labRetakeFees.Name = "labRetakeFees";
            this.labRetakeFees.Size = new System.Drawing.Size(132, 39);
            this.labRetakeFees.TabIndex = 56;
            this.labRetakeFees.Text = "0";
            // 
            // lblRetakeFees
            // 
            this.lblRetakeFees.AutoSize = true;
            this.lblRetakeFees.Location = new System.Drawing.Point(80, 32);
            this.lblRetakeFees.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRetakeFees.Name = "lblRetakeFees";
            this.lblRetakeFees.Size = new System.Drawing.Size(215, 39);
            this.lblRetakeFees.TabIndex = 54;
            this.lblRetakeFees.Text = "Retake Fees      :";
            // 
            // labTotalFees
            // 
            this.labTotalFees.AutoEllipsis = true;
            this.labTotalFees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.labTotalFees.Location = new System.Drawing.Point(298, 87);
            this.labTotalFees.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labTotalFees.Name = "labTotalFees";
            this.labTotalFees.Size = new System.Drawing.Size(232, 39);
            this.labTotalFees.TabIndex = 59;
            this.labTotalFees.Text = "?";
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.AutoSize = true;
            this.lblTotalFees.Location = new System.Drawing.Point(80, 88);
            this.lblTotalFees.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(214, 39);
            this.lblTotalFees.TabIndex = 57;
            this.lblTotalFees.Text = "Total Fees          :";
            // 
            // labRetakeAppID
            // 
            this.labRetakeAppID.AutoEllipsis = true;
            this.labRetakeAppID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.labRetakeAppID.Location = new System.Drawing.Point(791, 31);
            this.labRetakeAppID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labRetakeAppID.Name = "labRetakeAppID";
            this.labRetakeAppID.Size = new System.Drawing.Size(232, 39);
            this.labRetakeAppID.TabIndex = 62;
            this.labRetakeAppID.Text = "N/A";
            // 
            // lblRetakeAppID
            // 
            this.lblRetakeAppID.AutoSize = true;
            this.lblRetakeAppID.Location = new System.Drawing.Point(572, 31);
            this.lblRetakeAppID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRetakeAppID.Name = "lblRetakeAppID";
            this.lblRetakeAppID.Size = new System.Drawing.Size(208, 39);
            this.lblRetakeAppID.TabIndex = 60;
            this.lblRetakeAppID.Text = "Retake App ID :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labRetakeAppID);
            this.panel1.Controls.Add(this.picRetakeAppID);
            this.panel1.Controls.Add(this.lblRetakeAppID);
            this.panel1.Controls.Add(this.labTotalFees);
            this.panel1.Controls.Add(this.picFees);
            this.panel1.Controls.Add(this.lblTotalFees);
            this.panel1.Controls.Add(this.labRetakeFees);
            this.panel1.Controls.Add(this.picRetakeFees);
            this.panel1.Controls.Add(this.lblRetakeFees);
            this.panel1.Location = new System.Drawing.Point(48, 433);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1037, 154);
            this.panel1.TabIndex = 63;
            // 
            // picRetakeAppID
            // 
            this.picRetakeAppID.Image = ((System.Drawing.Image)(resources.GetObject("picRetakeAppID.Image")));
            this.picRetakeAppID.Location = new System.Drawing.Point(535, 34);
            this.picRetakeAppID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.picRetakeAppID.Name = "picRetakeAppID";
            this.picRetakeAppID.Size = new System.Drawing.Size(38, 35);
            this.picRetakeAppID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRetakeAppID.TabIndex = 61;
            this.picRetakeAppID.TabStop = false;
            // 
            // picFees
            // 
            this.picFees.Image = ((System.Drawing.Image)(resources.GetObject("picFees.Image")));
            this.picFees.Location = new System.Drawing.Point(43, 91);
            this.picFees.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.picFees.Name = "picFees";
            this.picFees.Size = new System.Drawing.Size(38, 35);
            this.picFees.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFees.TabIndex = 58;
            this.picFees.TabStop = false;
            // 
            // picRetakeFees
            // 
            this.picRetakeFees.Image = ((System.Drawing.Image)(resources.GetObject("picRetakeFees.Image")));
            this.picRetakeFees.Location = new System.Drawing.Point(43, 35);
            this.picRetakeFees.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.picRetakeFees.Name = "picRetakeFees";
            this.picRetakeFees.Size = new System.Drawing.Size(38, 35);
            this.picRetakeFees.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRetakeFees.TabIndex = 55;
            this.picRetakeFees.TabStop = false;
            // 
            // ucForTestSchedule1
            // 
            this.ucForTestSchedule1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ucForTestSchedule1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucForTestSchedule1.ForeColor = System.Drawing.Color.White;
            this.ucForTestSchedule1.Location = new System.Drawing.Point(52, 158);
            this.ucForTestSchedule1.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.ucForTestSchedule1.Name = "ucForTestSchedule1";
            this.ucForTestSchedule1.Size = new System.Drawing.Size(1086, 296);
            this.ucForTestSchedule1.TabIndex = 0;
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
            // picHeader
            // 
            this.picHeader.Image = global::DVLD.Properties.Resources.eye__1_;
            this.picHeader.Location = new System.Drawing.Point(597, 3);
            this.picHeader.Name = "picHeader";
            this.picHeader.Size = new System.Drawing.Size(98, 92);
            this.picHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHeader.TabIndex = 15;
            this.picHeader.TabStop = false;
            // 
            // FrmScheduleTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.ucForTestSchedule1);
            this.Controls.Add(this.picHeader);
            this.Controls.Add(this.lblHeaderTitle);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "FrmScheduleTest";
            this.Size = new System.Drawing.Size(1086, 723);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRetakeAppID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRetakeFees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.PictureBox picHeader;
        private UserControls.UcForTestSchedule ucForTestSchedule1;
        private Guna.UI2.WinForms.Guna2GradientButton btnBack;
        private Guna.UI2.WinForms.Guna2GradientButton btnSave;
        private System.Windows.Forms.Label labRetakeFees;
        private System.Windows.Forms.PictureBox picRetakeFees;
        private System.Windows.Forms.Label lblRetakeFees;
        private System.Windows.Forms.Label labTotalFees;
        private System.Windows.Forms.PictureBox picFees;
        private System.Windows.Forms.Label lblTotalFees;
        private System.Windows.Forms.Label labRetakeAppID;
        private System.Windows.Forms.PictureBox picRetakeAppID;
        private System.Windows.Forms.Label lblRetakeAppID;
        private System.Windows.Forms.Panel panel1;
    }
}
