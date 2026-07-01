namespace DVLD.ApplicationsFolder.MainForms
{
    partial class FrmNewInternationalLicenseApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNewInternationalLicenseApplication));
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.picHeader = new System.Windows.Forms.PictureBox();
            this.btnBack = new Guna.UI2.WinForms.Guna2GradientButton();
            this.labInternationalLicenseApplicationID = new System.Windows.Forms.Label();
            this.picInternationalLicenseApplicationID = new System.Windows.Forms.PictureBox();
            this.lblInternationalLicenseApplicationID = new System.Windows.Forms.Label();
            this.labInternationalLicenseID = new System.Windows.Forms.Label();
            this.picInternationalLicenseID = new System.Windows.Forms.PictureBox();
            this.lblInternationalLicenseID = new System.Windows.Forms.Label();
            this.labAppDate = new System.Windows.Forms.Label();
            this.picAppDate = new System.Windows.Forms.PictureBox();
            this.lblAppDate = new System.Windows.Forms.Label();
            this.labIssueDate = new System.Windows.Forms.Label();
            this.picIssueDate = new System.Windows.Forms.PictureBox();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.labExpirationDate = new System.Windows.Forms.Label();
            this.picExpirationDate = new System.Windows.Forms.PictureBox();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.labLicenseID = new System.Windows.Forms.Label();
            this.picLicenseID = new System.Windows.Forms.PictureBox();
            this.lblLicenseID = new System.Windows.Forms.Label();
            this.labCreatedBy = new System.Windows.Forms.Label();
            this.picCreatedBy = new System.Windows.Forms.PictureBox();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.labFees = new System.Windows.Forms.Label();
            this.picFees = new System.Windows.Forms.PictureBox();
            this.lblFees = new System.Windows.Forms.Label();
            this.btnIssue = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnShowLicensesHistory = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnInternationalShowLicenseInfo = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ucLicenseInfoWithFilter1 = new DVLD.Licenses.UserControls.UcLicenseInfoWithFilter();
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInternationalLicenseApplicationID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInternationalLicenseID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAppDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIssueDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExpirationDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLicenseID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCreatedBy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFees)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Impact", 12F);
            this.lblHeaderTitle.Location = new System.Drawing.Point(35, 0);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(252, 20);
            this.lblHeaderTitle.TabIndex = 12;
            this.lblHeaderTitle.Text = "- New International License Appliction";
            this.lblHeaderTitle.UseMnemonic = false;
            // 
            // picHeader
            // 
            this.picHeader.Image = ((System.Drawing.Image)(resources.GetObject("picHeader.Image")));
            this.picHeader.Location = new System.Drawing.Point(288, 5);
            this.picHeader.Name = "picHeader";
            this.picHeader.Size = new System.Drawing.Size(17, 17);
            this.picHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHeader.TabIndex = 13;
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
            this.btnBack.Location = new System.Drawing.Point(48, 655);
            this.btnBack.Name = "btnBack";
            this.btnBack.ShadowDecoration.Parent = this.btnBack;
            this.btnBack.Size = new System.Drawing.Size(66, 49);
            this.btnBack.TabIndex = 32;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.Enter += new System.EventHandler(this.btnSwitchFillColor);
            this.btnBack.Leave += new System.EventHandler(this.btnSwitchFillColor);
            // 
            // labInternationalLicenseApplicationID
            // 
            this.labInternationalLicenseApplicationID.AutoEllipsis = true;
            this.labInternationalLicenseApplicationID.Font = new System.Drawing.Font("Impact", 24F);
            this.labInternationalLicenseApplicationID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.labInternationalLicenseApplicationID.Location = new System.Drawing.Point(281, 448);
            this.labInternationalLicenseApplicationID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labInternationalLicenseApplicationID.Name = "labInternationalLicenseApplicationID";
            this.labInternationalLicenseApplicationID.Size = new System.Drawing.Size(135, 39);
            this.labInternationalLicenseApplicationID.TabIndex = 100;
            this.labInternationalLicenseApplicationID.Text = "?";
            // 
            // picInternationalLicenseApplicationID
            // 
            this.picInternationalLicenseApplicationID.Image = ((System.Drawing.Image)(resources.GetObject("picInternationalLicenseApplicationID.Image")));
            this.picInternationalLicenseApplicationID.Location = new System.Drawing.Point(35, 450);
            this.picInternationalLicenseApplicationID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.picInternationalLicenseApplicationID.Name = "picInternationalLicenseApplicationID";
            this.picInternationalLicenseApplicationID.Size = new System.Drawing.Size(38, 35);
            this.picInternationalLicenseApplicationID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picInternationalLicenseApplicationID.TabIndex = 99;
            this.picInternationalLicenseApplicationID.TabStop = false;
            // 
            // lblInternationalLicenseApplicationID
            // 
            this.lblInternationalLicenseApplicationID.AutoSize = true;
            this.lblInternationalLicenseApplicationID.Location = new System.Drawing.Point(84, 447);
            this.lblInternationalLicenseApplicationID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInternationalLicenseApplicationID.Name = "lblInternationalLicenseApplicationID";
            this.lblInternationalLicenseApplicationID.Size = new System.Drawing.Size(199, 39);
            this.lblInternationalLicenseApplicationID.TabIndex = 98;
            this.lblInternationalLicenseApplicationID.Text = "i.L.App ID          :";
            // 
            // labInternationalLicenseID
            // 
            this.labInternationalLicenseID.AutoEllipsis = true;
            this.labInternationalLicenseID.Font = new System.Drawing.Font("Impact", 24F);
            this.labInternationalLicenseID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.labInternationalLicenseID.Location = new System.Drawing.Point(709, 450);
            this.labInternationalLicenseID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labInternationalLicenseID.Name = "labInternationalLicenseID";
            this.labInternationalLicenseID.Size = new System.Drawing.Size(318, 39);
            this.labInternationalLicenseID.TabIndex = 103;
            this.labInternationalLicenseID.Text = "?";
            // 
            // picInternationalLicenseID
            // 
            this.picInternationalLicenseID.Image = ((System.Drawing.Image)(resources.GetObject("picInternationalLicenseID.Image")));
            this.picInternationalLicenseID.Location = new System.Drawing.Point(515, 450);
            this.picInternationalLicenseID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.picInternationalLicenseID.Name = "picInternationalLicenseID";
            this.picInternationalLicenseID.Size = new System.Drawing.Size(38, 35);
            this.picInternationalLicenseID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picInternationalLicenseID.TabIndex = 102;
            this.picInternationalLicenseID.TabStop = false;
            // 
            // lblInternationalLicenseID
            // 
            this.lblInternationalLicenseID.AutoSize = true;
            this.lblInternationalLicenseID.Location = new System.Drawing.Point(557, 448);
            this.lblInternationalLicenseID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInternationalLicenseID.Name = "lblInternationalLicenseID";
            this.lblInternationalLicenseID.Size = new System.Drawing.Size(157, 39);
            this.lblInternationalLicenseID.TabIndex = 101;
            this.lblInternationalLicenseID.Text = "i.L.App ID   :";
            // 
            // labAppDate
            // 
            this.labAppDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.labAppDate.Location = new System.Drawing.Point(283, 495);
            this.labAppDate.Name = "labAppDate";
            this.labAppDate.Size = new System.Drawing.Size(225, 39);
            this.labAppDate.TabIndex = 109;
            this.labAppDate.Text = "?";
            // 
            // picAppDate
            // 
            this.picAppDate.Image = ((System.Drawing.Image)(resources.GetObject("picAppDate.Image")));
            this.picAppDate.Location = new System.Drawing.Point(35, 495);
            this.picAppDate.Name = "picAppDate";
            this.picAppDate.Size = new System.Drawing.Size(38, 35);
            this.picAppDate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAppDate.TabIndex = 108;
            this.picAppDate.TabStop = false;
            // 
            // lblAppDate
            // 
            this.lblAppDate.AutoSize = true;
            this.lblAppDate.Location = new System.Drawing.Point(81, 495);
            this.lblAppDate.Name = "lblAppDate";
            this.lblAppDate.Size = new System.Drawing.Size(205, 39);
            this.lblAppDate.TabIndex = 107;
            this.lblAppDate.Text = "App Date           :";
            // 
            // labIssueDate
            // 
            this.labIssueDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.labIssueDate.Location = new System.Drawing.Point(283, 543);
            this.labIssueDate.Name = "labIssueDate";
            this.labIssueDate.Size = new System.Drawing.Size(225, 39);
            this.labIssueDate.TabIndex = 112;
            this.labIssueDate.Text = "?";
            // 
            // picIssueDate
            // 
            this.picIssueDate.Image = ((System.Drawing.Image)(resources.GetObject("picIssueDate.Image")));
            this.picIssueDate.Location = new System.Drawing.Point(35, 544);
            this.picIssueDate.Name = "picIssueDate";
            this.picIssueDate.Size = new System.Drawing.Size(38, 35);
            this.picIssueDate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIssueDate.TabIndex = 111;
            this.picIssueDate.TabStop = false;
            // 
            // lblIssueDate
            // 
            this.lblIssueDate.AutoSize = true;
            this.lblIssueDate.Location = new System.Drawing.Point(81, 543);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Size = new System.Drawing.Size(203, 39);
            this.lblIssueDate.TabIndex = 110;
            this.lblIssueDate.Text = "Issue Date       :";
            // 
            // labExpirationDate
            // 
            this.labExpirationDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.labExpirationDate.Location = new System.Drawing.Point(281, 590);
            this.labExpirationDate.Name = "labExpirationDate";
            this.labExpirationDate.Size = new System.Drawing.Size(225, 39);
            this.labExpirationDate.TabIndex = 115;
            this.labExpirationDate.Text = "?";
            // 
            // picExpirationDate
            // 
            this.picExpirationDate.Image = ((System.Drawing.Image)(resources.GetObject("picExpirationDate.Image")));
            this.picExpirationDate.Location = new System.Drawing.Point(35, 594);
            this.picExpirationDate.Name = "picExpirationDate";
            this.picExpirationDate.Size = new System.Drawing.Size(38, 35);
            this.picExpirationDate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picExpirationDate.TabIndex = 114;
            this.picExpirationDate.TabStop = false;
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.Location = new System.Drawing.Point(81, 593);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(204, 39);
            this.lblExpirationDate.TabIndex = 113;
            this.lblExpirationDate.Text = "Exp Date            :";
            // 
            // labLicenseID
            // 
            this.labLicenseID.AutoEllipsis = true;
            this.labLicenseID.Font = new System.Drawing.Font("Impact", 24F);
            this.labLicenseID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.labLicenseID.Location = new System.Drawing.Point(709, 492);
            this.labLicenseID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labLicenseID.Name = "labLicenseID";
            this.labLicenseID.Size = new System.Drawing.Size(339, 39);
            this.labLicenseID.TabIndex = 118;
            this.labLicenseID.Text = "?";
            // 
            // picLicenseID
            // 
            this.picLicenseID.Image = ((System.Drawing.Image)(resources.GetObject("picLicenseID.Image")));
            this.picLicenseID.Location = new System.Drawing.Point(513, 495);
            this.picLicenseID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.picLicenseID.Name = "picLicenseID";
            this.picLicenseID.Size = new System.Drawing.Size(38, 35);
            this.picLicenseID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLicenseID.TabIndex = 117;
            this.picLicenseID.TabStop = false;
            // 
            // lblLicenseID
            // 
            this.lblLicenseID.AutoSize = true;
            this.lblLicenseID.Location = new System.Drawing.Point(557, 494);
            this.lblLicenseID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLicenseID.Name = "lblLicenseID";
            this.lblLicenseID.Size = new System.Drawing.Size(162, 39);
            this.lblLicenseID.TabIndex = 116;
            this.lblLicenseID.Text = "License ID :";
            // 
            // labCreatedBy
            // 
            this.labCreatedBy.AutoEllipsis = true;
            this.labCreatedBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.labCreatedBy.Location = new System.Drawing.Point(708, 544);
            this.labCreatedBy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labCreatedBy.Name = "labCreatedBy";
            this.labCreatedBy.Size = new System.Drawing.Size(340, 47);
            this.labCreatedBy.TabIndex = 121;
            this.labCreatedBy.Text = "?";
            // 
            // picCreatedBy
            // 
            this.picCreatedBy.Image = ((System.Drawing.Image)(resources.GetObject("picCreatedBy.Image")));
            this.picCreatedBy.Location = new System.Drawing.Point(515, 543);
            this.picCreatedBy.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.picCreatedBy.Name = "picCreatedBy";
            this.picCreatedBy.Size = new System.Drawing.Size(38, 35);
            this.picCreatedBy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCreatedBy.TabIndex = 120;
            this.picCreatedBy.TabStop = false;
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Location = new System.Drawing.Point(555, 540);
            this.lblCreatedBy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(165, 39);
            this.lblCreatedBy.TabIndex = 119;
            this.lblCreatedBy.Text = "Created By:";
            // 
            // labFees
            // 
            this.labFees.AutoEllipsis = true;
            this.labFees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.labFees.Location = new System.Drawing.Point(708, 587);
            this.labFees.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labFees.Name = "labFees";
            this.labFees.Size = new System.Drawing.Size(232, 47);
            this.labFees.TabIndex = 124;
            this.labFees.Text = "?";
            // 
            // picFees
            // 
            this.picFees.Image = ((System.Drawing.Image)(resources.GetObject("picFees.Image")));
            this.picFees.Location = new System.Drawing.Point(515, 593);
            this.picFees.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.picFees.Name = "picFees";
            this.picFees.Size = new System.Drawing.Size(38, 35);
            this.picFees.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFees.TabIndex = 123;
            this.picFees.TabStop = false;
            // 
            // lblFees
            // 
            this.lblFees.AutoSize = true;
            this.lblFees.Location = new System.Drawing.Point(556, 589);
            this.lblFees.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(161, 39);
            this.lblFees.TabIndex = 122;
            this.lblFees.Text = "Fees             :";
            // 
            // btnIssue
            // 
            this.btnIssue.Animated = true;
            this.btnIssue.BorderRadius = 20;
            this.btnIssue.CheckedState.Parent = this.btnIssue;
            this.btnIssue.CustomImages.Parent = this.btnIssue;
            this.btnIssue.Enabled = false;
            this.btnIssue.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnIssue.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnIssue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnIssue.ForeColor = System.Drawing.Color.White;
            this.btnIssue.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnIssue.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnIssue.HoverState.Parent = this.btnIssue;
            this.btnIssue.Image = ((System.Drawing.Image)(resources.GetObject("btnIssue.Image")));
            this.btnIssue.ImageOffset = new System.Drawing.Point(1, 0);
            this.btnIssue.ImageSize = new System.Drawing.Size(40, 40);
            this.btnIssue.Location = new System.Drawing.Point(973, 659);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.ShadowDecoration.Parent = this.btnIssue;
            this.btnIssue.Size = new System.Drawing.Size(66, 49);
            this.btnIssue.TabIndex = 125;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            this.btnIssue.Enter += new System.EventHandler(this.btnSwitchFillColor);
            this.btnIssue.Leave += new System.EventHandler(this.btnSwitchFillColor);
            // 
            // btnShowLicensesHistory
            // 
            this.btnShowLicensesHistory.Animated = true;
            this.btnShowLicensesHistory.BorderRadius = 20;
            this.btnShowLicensesHistory.CheckedState.Parent = this.btnShowLicensesHistory;
            this.btnShowLicensesHistory.CustomImages.Parent = this.btnShowLicensesHistory;
            this.btnShowLicensesHistory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnShowLicensesHistory.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnShowLicensesHistory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnShowLicensesHistory.ForeColor = System.Drawing.Color.White;
            this.btnShowLicensesHistory.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnShowLicensesHistory.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnShowLicensesHistory.HoverState.Parent = this.btnShowLicensesHistory;
            this.btnShowLicensesHistory.Image = ((System.Drawing.Image)(resources.GetObject("btnShowLicensesHistory.Image")));
            this.btnShowLicensesHistory.ImageOffset = new System.Drawing.Point(1, 0);
            this.btnShowLicensesHistory.ImageSize = new System.Drawing.Size(40, 40);
            this.btnShowLicensesHistory.Location = new System.Drawing.Point(370, 655);
            this.btnShowLicensesHistory.Name = "btnShowLicensesHistory";
            this.btnShowLicensesHistory.ShadowDecoration.Parent = this.btnShowLicensesHistory;
            this.btnShowLicensesHistory.Size = new System.Drawing.Size(66, 49);
            this.btnShowLicensesHistory.TabIndex = 126;
            this.btnShowLicensesHistory.Click += new System.EventHandler(this.btnShowLicensesHistory_Click);
            this.btnShowLicensesHistory.Enter += new System.EventHandler(this.btnSwitchFillColor);
            this.btnShowLicensesHistory.Leave += new System.EventHandler(this.btnSwitchFillColor);
            // 
            // btnInternationalShowLicenseInfo
            // 
            this.btnInternationalShowLicenseInfo.Animated = true;
            this.btnInternationalShowLicenseInfo.BorderRadius = 20;
            this.btnInternationalShowLicenseInfo.CheckedState.Parent = this.btnInternationalShowLicenseInfo;
            this.btnInternationalShowLicenseInfo.CustomImages.Parent = this.btnInternationalShowLicenseInfo;
            this.btnInternationalShowLicenseInfo.Enabled = false;
            this.btnInternationalShowLicenseInfo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnInternationalShowLicenseInfo.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnInternationalShowLicenseInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnInternationalShowLicenseInfo.ForeColor = System.Drawing.Color.White;
            this.btnInternationalShowLicenseInfo.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnInternationalShowLicenseInfo.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnInternationalShowLicenseInfo.HoverState.Parent = this.btnInternationalShowLicenseInfo;
            this.btnInternationalShowLicenseInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnInternationalShowLicenseInfo.Image")));
            this.btnInternationalShowLicenseInfo.ImageOffset = new System.Drawing.Point(1, 1);
            this.btnInternationalShowLicenseInfo.ImageSize = new System.Drawing.Size(40, 40);
            this.btnInternationalShowLicenseInfo.Location = new System.Drawing.Point(664, 655);
            this.btnInternationalShowLicenseInfo.Name = "btnInternationalShowLicenseInfo";
            this.btnInternationalShowLicenseInfo.ShadowDecoration.Parent = this.btnInternationalShowLicenseInfo;
            this.btnInternationalShowLicenseInfo.Size = new System.Drawing.Size(66, 49);
            this.btnInternationalShowLicenseInfo.TabIndex = 127;
            this.btnInternationalShowLicenseInfo.Click += new System.EventHandler(this.btnShowInternationalLicenseInfo_Click);
            this.btnInternationalShowLicenseInfo.Enter += new System.EventHandler(this.btnSwitchFillColor);
            this.btnInternationalShowLicenseInfo.Leave += new System.EventHandler(this.btnSwitchFillColor);
            // 
            // ucLicenseInfoWithFilter1
            // 
            this.ucLicenseInfoWithFilter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ucLicenseInfoWithFilter1.Font = new System.Drawing.Font("Impact", 24F);
            this.ucLicenseInfoWithFilter1.ForeColor = System.Drawing.Color.White;
            this.ucLicenseInfoWithFilter1.localLicense = null;
            this.ucLicenseInfoWithFilter1.Location = new System.Drawing.Point(0, 5);
            this.ucLicenseInfoWithFilter1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.ucLicenseInfoWithFilter1.Name = "ucLicenseInfoWithFilter1";
            this.ucLicenseInfoWithFilter1.Size = new System.Drawing.Size(1086, 448);
            this.ucLicenseInfoWithFilter1.TabIndex = 14;
            this.ucLicenseInfoWithFilter1.OnLicenseSelected += new System.Action(this.ucLicenseInfoWithFilter1_OnLicenseSelected);
            // 
            // FrmNewInternationalLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Controls.Add(this.btnInternationalShowLicenseInfo);
            this.Controls.Add(this.btnShowLicensesHistory);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.labFees);
            this.Controls.Add(this.picFees);
            this.Controls.Add(this.lblFees);
            this.Controls.Add(this.labCreatedBy);
            this.Controls.Add(this.picCreatedBy);
            this.Controls.Add(this.lblCreatedBy);
            this.Controls.Add(this.labLicenseID);
            this.Controls.Add(this.picLicenseID);
            this.Controls.Add(this.lblLicenseID);
            this.Controls.Add(this.labExpirationDate);
            this.Controls.Add(this.picExpirationDate);
            this.Controls.Add(this.lblExpirationDate);
            this.Controls.Add(this.labIssueDate);
            this.Controls.Add(this.picIssueDate);
            this.Controls.Add(this.lblIssueDate);
            this.Controls.Add(this.labAppDate);
            this.Controls.Add(this.picAppDate);
            this.Controls.Add(this.lblAppDate);
            this.Controls.Add(this.labInternationalLicenseID);
            this.Controls.Add(this.picInternationalLicenseID);
            this.Controls.Add(this.lblInternationalLicenseID);
            this.Controls.Add(this.labInternationalLicenseApplicationID);
            this.Controls.Add(this.picInternationalLicenseApplicationID);
            this.Controls.Add(this.lblInternationalLicenseApplicationID);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.picHeader);
            this.Controls.Add(this.lblHeaderTitle);
            this.Controls.Add(this.ucLicenseInfoWithFilter1);
            this.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "FrmNewInternationalLicenseApplication";
            this.Size = new System.Drawing.Size(1086, 723);
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInternationalLicenseApplicationID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInternationalLicenseID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAppDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIssueDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExpirationDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLicenseID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCreatedBy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private Licenses.UserControls.UcLicenseInfoWithFilter ucLicenseInfoWithFilter1;
        private Guna.UI2.WinForms.Guna2GradientButton btnBack;
        private System.Windows.Forms.Label labInternationalLicenseApplicationID;
        private System.Windows.Forms.PictureBox picInternationalLicenseApplicationID;
        private System.Windows.Forms.Label lblInternationalLicenseApplicationID;
        private System.Windows.Forms.Label labInternationalLicenseID;
        private System.Windows.Forms.PictureBox picInternationalLicenseID;
        private System.Windows.Forms.Label lblInternationalLicenseID;
        private System.Windows.Forms.Label labAppDate;
        private System.Windows.Forms.PictureBox picAppDate;
        private System.Windows.Forms.Label lblAppDate;
        private System.Windows.Forms.Label labIssueDate;
        private System.Windows.Forms.PictureBox picIssueDate;
        private System.Windows.Forms.Label lblIssueDate;
        private System.Windows.Forms.Label labExpirationDate;
        private System.Windows.Forms.PictureBox picExpirationDate;
        private System.Windows.Forms.Label lblExpirationDate;
        private System.Windows.Forms.Label labLicenseID;
        private System.Windows.Forms.PictureBox picLicenseID;
        private System.Windows.Forms.Label lblLicenseID;
        private System.Windows.Forms.Label labCreatedBy;
        private System.Windows.Forms.PictureBox picCreatedBy;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label labFees;
        private System.Windows.Forms.PictureBox picFees;
        private System.Windows.Forms.Label lblFees;
        private Guna.UI2.WinForms.Guna2GradientButton btnIssue;
        private Guna.UI2.WinForms.Guna2GradientButton btnShowLicensesHistory;
        private Guna.UI2.WinForms.Guna2GradientButton btnInternationalShowLicenseInfo;
    }
}
