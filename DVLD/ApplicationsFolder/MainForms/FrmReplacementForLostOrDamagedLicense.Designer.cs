namespace DVLD.ApplicationsFolder.MainForms
{
    partial class FrmReplacementForLostOrDamagedLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReplacementForLostOrDamagedLicense));
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.picHeader = new System.Windows.Forms.PictureBox();
            this.ucLicenseInfoWithFilter1 = new DVLD.Licenses.UserControls.UcLicenseInfoWithFilter();
            this.btnShowLicenseInfo = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnShowLicensesHistory = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnReplace = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnBack = new Guna.UI2.WinForms.Guna2GradientButton();
            this.labAppDate = new System.Windows.Forms.Label();
            this.picAppDate = new System.Windows.Forms.PictureBox();
            this.lblAppDate = new System.Windows.Forms.Label();
            this.labAppFees = new System.Windows.Forms.Label();
            this.picAppFees = new System.Windows.Forms.PictureBox();
            this.lblAppFees = new System.Windows.Forms.Label();
            this.labCreatedBy = new System.Windows.Forms.Label();
            this.picCreatedBy = new System.Windows.Forms.PictureBox();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.labOldLicenseID = new System.Windows.Forms.Label();
            this.picOldLicenseID = new System.Windows.Forms.PictureBox();
            this.lblOldLicenseID = new System.Windows.Forms.Label();
            this.labReplacedLicenseID = new System.Windows.Forms.Label();
            this.picReplacedLicenseID = new System.Windows.Forms.PictureBox();
            this.lblReplacedLicenseID = new System.Windows.Forms.Label();
            this.labLicenseReplaceApplicationID = new System.Windows.Forms.Label();
            this.picLicenseReplaceApplicationID = new System.Windows.Forms.PictureBox();
            this.lblLicenseReplaceApplicationID = new System.Windows.Forms.Label();
            this.guna2GradientPanel4 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.LabReplaceFor = new System.Windows.Forms.Label();
            this.lblReplaceFor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAppDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAppFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCreatedBy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOldLicenseID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReplacedLicenseID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLicenseReplaceApplicationID)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Impact", 14F);
            this.lblHeaderTitle.Location = new System.Drawing.Point(29, 3);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(268, 23);
            this.lblHeaderTitle.TabIndex = 85;
            this.lblHeaderTitle.Text = "-Replacement for Driving License";
            this.lblHeaderTitle.UseMnemonic = false;
            // 
            // picHeader
            // 
            this.picHeader.Image = ((System.Drawing.Image)(resources.GetObject("picHeader.Image")));
            this.picHeader.Location = new System.Drawing.Point(300, 3);
            this.picHeader.Name = "picHeader";
            this.picHeader.Size = new System.Drawing.Size(30, 27);
            this.picHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHeader.TabIndex = 86;
            this.picHeader.TabStop = false;
            // 
            // ucLicenseInfoWithFilter1
            // 
            this.ucLicenseInfoWithFilter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ucLicenseInfoWithFilter1.Font = new System.Drawing.Font("Impact", 24F);
            this.ucLicenseInfoWithFilter1.ForeColor = System.Drawing.Color.White;
            this.ucLicenseInfoWithFilter1.localLicense = null;
            this.ucLicenseInfoWithFilter1.Location = new System.Drawing.Point(0, 0);
            this.ucLicenseInfoWithFilter1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.ucLicenseInfoWithFilter1.Name = "ucLicenseInfoWithFilter1";
            this.ucLicenseInfoWithFilter1.Size = new System.Drawing.Size(1086, 446);
            this.ucLicenseInfoWithFilter1.TabIndex = 87;
            this.ucLicenseInfoWithFilter1.OnLicenseSelected += new System.Action(this.ucLicenseInfoWithFilter1_OnLicenseSelected);
            // 
            // btnShowLicenseInfo
            // 
            this.btnShowLicenseInfo.Animated = true;
            this.btnShowLicenseInfo.BorderRadius = 20;
            this.btnShowLicenseInfo.CheckedState.Parent = this.btnShowLicenseInfo;
            this.btnShowLicenseInfo.CustomImages.Parent = this.btnShowLicenseInfo;
            this.btnShowLicenseInfo.Enabled = false;
            this.btnShowLicenseInfo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnShowLicenseInfo.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnShowLicenseInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnShowLicenseInfo.ForeColor = System.Drawing.Color.White;
            this.btnShowLicenseInfo.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnShowLicenseInfo.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnShowLicenseInfo.HoverState.Parent = this.btnShowLicenseInfo;
            this.btnShowLicenseInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnShowLicenseInfo.Image")));
            this.btnShowLicenseInfo.ImageOffset = new System.Drawing.Point(1, 1);
            this.btnShowLicenseInfo.ImageSize = new System.Drawing.Size(40, 40);
            this.btnShowLicenseInfo.Location = new System.Drawing.Point(901, 655);
            this.btnShowLicenseInfo.Name = "btnShowLicenseInfo";
            this.btnShowLicenseInfo.ShadowDecoration.Parent = this.btnShowLicenseInfo;
            this.btnShowLicenseInfo.Size = new System.Drawing.Size(66, 49);
            this.btnShowLicenseInfo.TabIndex = 135;
            this.btnShowLicenseInfo.Enter += new System.EventHandler(this.btnSwitchFillColor);
            this.btnShowLicenseInfo.Leave += new System.EventHandler(this.btnSwitchFillColor);
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
            this.btnShowLicensesHistory.Location = new System.Drawing.Point(829, 655);
            this.btnShowLicensesHistory.Name = "btnShowLicensesHistory";
            this.btnShowLicensesHistory.ShadowDecoration.Parent = this.btnShowLicensesHistory;
            this.btnShowLicensesHistory.Size = new System.Drawing.Size(66, 49);
            this.btnShowLicensesHistory.TabIndex = 134;
            this.btnShowLicensesHistory.Click += new System.EventHandler(this.btnShowLicensesHistory_Click);
            this.btnShowLicensesHistory.Enter += new System.EventHandler(this.btnSwitchFillColor);
            this.btnShowLicensesHistory.Leave += new System.EventHandler(this.btnSwitchFillColor);
            // 
            // btnReplace
            // 
            this.btnReplace.Animated = true;
            this.btnReplace.BorderRadius = 20;
            this.btnReplace.CheckedState.Parent = this.btnReplace;
            this.btnReplace.CustomImages.Parent = this.btnReplace;
            this.btnReplace.Enabled = false;
            this.btnReplace.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnReplace.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnReplace.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReplace.ForeColor = System.Drawing.Color.White;
            this.btnReplace.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnReplace.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnReplace.HoverState.Parent = this.btnReplace;
            this.btnReplace.Image = ((System.Drawing.Image)(resources.GetObject("btnReplace.Image")));
            this.btnReplace.ImageOffset = new System.Drawing.Point(1, 0);
            this.btnReplace.ImageSize = new System.Drawing.Size(40, 40);
            this.btnReplace.Location = new System.Drawing.Point(973, 655);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.ShadowDecoration.Parent = this.btnReplace;
            this.btnReplace.Size = new System.Drawing.Size(66, 49);
            this.btnReplace.TabIndex = 133;
            this.btnReplace.Click += new System.EventHandler(this.btnRenew_Click);
            this.btnReplace.Enter += new System.EventHandler(this.btnSwitchFillColor);
            this.btnReplace.Leave += new System.EventHandler(this.btnSwitchFillColor);
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
            this.btnBack.TabIndex = 132;
            this.btnBack.Click += new System.EventHandler(this.btnSwitchFillColor);
            this.btnBack.Enter += new System.EventHandler(this.btnSwitchFillColor);
            this.btnBack.Leave += new System.EventHandler(this.btnSwitchFillColor);
            // 
            // labAppDate
            // 
            this.labAppDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.labAppDate.Location = new System.Drawing.Point(282, 511);
            this.labAppDate.Name = "labAppDate";
            this.labAppDate.Size = new System.Drawing.Size(225, 39);
            this.labAppDate.TabIndex = 140;
            this.labAppDate.Text = "?";
            // 
            // picAppDate
            // 
            this.picAppDate.Image = ((System.Drawing.Image)(resources.GetObject("picAppDate.Image")));
            this.picAppDate.Location = new System.Drawing.Point(33, 515);
            this.picAppDate.Name = "picAppDate";
            this.picAppDate.Size = new System.Drawing.Size(38, 35);
            this.picAppDate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAppDate.TabIndex = 139;
            this.picAppDate.TabStop = false;
            // 
            // lblAppDate
            // 
            this.lblAppDate.AutoSize = true;
            this.lblAppDate.Location = new System.Drawing.Point(82, 512);
            this.lblAppDate.Name = "lblAppDate";
            this.lblAppDate.Size = new System.Drawing.Size(205, 39);
            this.lblAppDate.TabIndex = 138;
            this.lblAppDate.Text = "App Date           :";
            // 
            // labAppFees
            // 
            this.labAppFees.AutoEllipsis = true;
            this.labAppFees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.labAppFees.Location = new System.Drawing.Point(711, 570);
            this.labAppFees.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labAppFees.Name = "labAppFees";
            this.labAppFees.Size = new System.Drawing.Size(232, 47);
            this.labAppFees.TabIndex = 158;
            this.labAppFees.Text = "?";
            // 
            // picAppFees
            // 
            this.picAppFees.Image = ((System.Drawing.Image)(resources.GetObject("picAppFees.Image")));
            this.picAppFees.Location = new System.Drawing.Point(514, 573);
            this.picAppFees.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.picAppFees.Name = "picAppFees";
            this.picAppFees.Size = new System.Drawing.Size(38, 35);
            this.picAppFees.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAppFees.TabIndex = 157;
            this.picAppFees.TabStop = false;
            // 
            // lblAppFees
            // 
            this.lblAppFees.AutoSize = true;
            this.lblAppFees.Location = new System.Drawing.Point(559, 570);
            this.lblAppFees.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAppFees.Name = "lblAppFees";
            this.lblAppFees.Size = new System.Drawing.Size(157, 39);
            this.lblAppFees.TabIndex = 156;
            this.lblAppFees.Text = "App Fees   :";
            // 
            // labCreatedBy
            // 
            this.labCreatedBy.AutoEllipsis = true;
            this.labCreatedBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.labCreatedBy.Location = new System.Drawing.Point(282, 570);
            this.labCreatedBy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labCreatedBy.Name = "labCreatedBy";
            this.labCreatedBy.Size = new System.Drawing.Size(187, 47);
            this.labCreatedBy.TabIndex = 164;
            this.labCreatedBy.Text = "?";
            // 
            // picCreatedBy
            // 
            this.picCreatedBy.Image = ((System.Drawing.Image)(resources.GetObject("picCreatedBy.Image")));
            this.picCreatedBy.Location = new System.Drawing.Point(33, 573);
            this.picCreatedBy.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.picCreatedBy.Name = "picCreatedBy";
            this.picCreatedBy.Size = new System.Drawing.Size(38, 35);
            this.picCreatedBy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCreatedBy.TabIndex = 163;
            this.picCreatedBy.TabStop = false;
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Location = new System.Drawing.Point(84, 570);
            this.lblCreatedBy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(201, 39);
            this.lblCreatedBy.TabIndex = 162;
            this.lblCreatedBy.Text = "Created By      :";
            // 
            // labOldLicenseID
            // 
            this.labOldLicenseID.AutoEllipsis = true;
            this.labOldLicenseID.Font = new System.Drawing.Font("Impact", 24F);
            this.labOldLicenseID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.labOldLicenseID.Location = new System.Drawing.Point(711, 511);
            this.labOldLicenseID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labOldLicenseID.Name = "labOldLicenseID";
            this.labOldLicenseID.Size = new System.Drawing.Size(212, 39);
            this.labOldLicenseID.TabIndex = 161;
            this.labOldLicenseID.Text = "?";
            // 
            // picOldLicenseID
            // 
            this.picOldLicenseID.Image = ((System.Drawing.Image)(resources.GetObject("picOldLicenseID.Image")));
            this.picOldLicenseID.Location = new System.Drawing.Point(514, 515);
            this.picOldLicenseID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.picOldLicenseID.Name = "picOldLicenseID";
            this.picOldLicenseID.Size = new System.Drawing.Size(38, 35);
            this.picOldLicenseID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOldLicenseID.TabIndex = 160;
            this.picOldLicenseID.TabStop = false;
            // 
            // lblOldLicenseID
            // 
            this.lblOldLicenseID.AutoSize = true;
            this.lblOldLicenseID.Location = new System.Drawing.Point(558, 512);
            this.lblOldLicenseID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOldLicenseID.Name = "lblOldLicenseID";
            this.lblOldLicenseID.Size = new System.Drawing.Size(158, 39);
            this.lblOldLicenseID.TabIndex = 159;
            this.lblOldLicenseID.Text = "Old L ID       :";
            // 
            // labReplacedLicenseID
            // 
            this.labReplacedLicenseID.AutoEllipsis = true;
            this.labReplacedLicenseID.Font = new System.Drawing.Font("Impact", 24F);
            this.labReplacedLicenseID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.labReplacedLicenseID.Location = new System.Drawing.Point(710, 454);
            this.labReplacedLicenseID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labReplacedLicenseID.Name = "labReplacedLicenseID";
            this.labReplacedLicenseID.Size = new System.Drawing.Size(197, 39);
            this.labReplacedLicenseID.TabIndex = 170;
            this.labReplacedLicenseID.Text = "?";
            // 
            // picReplacedLicenseID
            // 
            this.picReplacedLicenseID.Image = ((System.Drawing.Image)(resources.GetObject("picReplacedLicenseID.Image")));
            this.picReplacedLicenseID.Location = new System.Drawing.Point(514, 457);
            this.picReplacedLicenseID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.picReplacedLicenseID.Name = "picReplacedLicenseID";
            this.picReplacedLicenseID.Size = new System.Drawing.Size(38, 35);
            this.picReplacedLicenseID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picReplacedLicenseID.TabIndex = 169;
            this.picReplacedLicenseID.TabStop = false;
            // 
            // lblReplacedLicenseID
            // 
            this.lblReplacedLicenseID.AutoSize = true;
            this.lblReplacedLicenseID.Location = new System.Drawing.Point(558, 454);
            this.lblReplacedLicenseID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReplacedLicenseID.Name = "lblReplacedLicenseID";
            this.lblReplacedLicenseID.Size = new System.Drawing.Size(157, 39);
            this.lblReplacedLicenseID.TabIndex = 168;
            this.lblReplacedLicenseID.Text = "R.L ID           :";
            // 
            // labLicenseReplaceApplicationID
            // 
            this.labLicenseReplaceApplicationID.AutoEllipsis = true;
            this.labLicenseReplaceApplicationID.Font = new System.Drawing.Font("Impact", 24F);
            this.labLicenseReplaceApplicationID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.labLicenseReplaceApplicationID.Location = new System.Drawing.Point(282, 454);
            this.labLicenseReplaceApplicationID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labLicenseReplaceApplicationID.Name = "labLicenseReplaceApplicationID";
            this.labLicenseReplaceApplicationID.Size = new System.Drawing.Size(135, 39);
            this.labLicenseReplaceApplicationID.TabIndex = 167;
            this.labLicenseReplaceApplicationID.Text = "?";
            // 
            // picLicenseReplaceApplicationID
            // 
            this.picLicenseReplaceApplicationID.Image = ((System.Drawing.Image)(resources.GetObject("picLicenseReplaceApplicationID.Image")));
            this.picLicenseReplaceApplicationID.Location = new System.Drawing.Point(33, 457);
            this.picLicenseReplaceApplicationID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.picLicenseReplaceApplicationID.Name = "picLicenseReplaceApplicationID";
            this.picLicenseReplaceApplicationID.Size = new System.Drawing.Size(38, 35);
            this.picLicenseReplaceApplicationID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLicenseReplaceApplicationID.TabIndex = 166;
            this.picLicenseReplaceApplicationID.TabStop = false;
            // 
            // lblLicenseReplaceApplicationID
            // 
            this.lblLicenseReplaceApplicationID.AutoSize = true;
            this.lblLicenseReplaceApplicationID.Location = new System.Drawing.Point(80, 454);
            this.lblLicenseReplaceApplicationID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLicenseReplaceApplicationID.Name = "lblLicenseReplaceApplicationID";
            this.lblLicenseReplaceApplicationID.Size = new System.Drawing.Size(208, 39);
            this.lblLicenseReplaceApplicationID.TabIndex = 165;
            this.lblLicenseReplaceApplicationID.Text = "L.R.App ID          :";
            // 
            // guna2GradientPanel4
            // 
            this.guna2GradientPanel4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.guna2GradientPanel4.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.guna2GradientPanel4.Location = new System.Drawing.Point(0, 443);
            this.guna2GradientPanel4.Name = "guna2GradientPanel4";
            this.guna2GradientPanel4.ShadowDecoration.Parent = this.guna2GradientPanel4;
            this.guna2GradientPanel4.Size = new System.Drawing.Size(1086, 2);
            this.guna2GradientPanel4.TabIndex = 171;
            // 
            // LabReplaceFor
            // 
            this.LabReplaceFor.AutoEllipsis = true;
            this.LabReplaceFor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.LabReplaceFor.Location = new System.Drawing.Point(458, 654);
            this.LabReplaceFor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabReplaceFor.Name = "LabReplaceFor";
            this.LabReplaceFor.Size = new System.Drawing.Size(342, 47);
            this.LabReplaceFor.TabIndex = 173;
            this.LabReplaceFor.Tag = "0";
            this.LabReplaceFor.Text = "Lost License";
            this.LabReplaceFor.Click += new System.EventHandler(this.LabReplaceFor_Click);
            this.LabReplaceFor.MouseEnter += new System.EventHandler(this.LabReplaceFor_MouseEnter);
            this.LabReplaceFor.MouseLeave += new System.EventHandler(this.LabReplaceFor_MouseLeave);
            // 
            // lblReplaceFor
            // 
            this.lblReplaceFor.AutoSize = true;
            this.lblReplaceFor.Location = new System.Drawing.Point(259, 655);
            this.lblReplaceFor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReplaceFor.Name = "lblReplaceFor";
            this.lblReplaceFor.Size = new System.Drawing.Size(201, 39);
            this.lblReplaceFor.TabIndex = 172;
            this.lblReplaceFor.Text = "Replace for     :";
            // 
            // FrmReplacementForLostOrDamagedLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Controls.Add(this.LabReplaceFor);
            this.Controls.Add(this.lblReplaceFor);
            this.Controls.Add(this.guna2GradientPanel4);
            this.Controls.Add(this.labReplacedLicenseID);
            this.Controls.Add(this.picReplacedLicenseID);
            this.Controls.Add(this.lblReplacedLicenseID);
            this.Controls.Add(this.labLicenseReplaceApplicationID);
            this.Controls.Add(this.picLicenseReplaceApplicationID);
            this.Controls.Add(this.lblLicenseReplaceApplicationID);
            this.Controls.Add(this.labCreatedBy);
            this.Controls.Add(this.picCreatedBy);
            this.Controls.Add(this.lblCreatedBy);
            this.Controls.Add(this.labOldLicenseID);
            this.Controls.Add(this.picOldLicenseID);
            this.Controls.Add(this.lblOldLicenseID);
            this.Controls.Add(this.labAppFees);
            this.Controls.Add(this.picAppFees);
            this.Controls.Add(this.lblAppFees);
            this.Controls.Add(this.labAppDate);
            this.Controls.Add(this.picAppDate);
            this.Controls.Add(this.lblAppDate);
            this.Controls.Add(this.lblHeaderTitle);
            this.Controls.Add(this.btnShowLicenseInfo);
            this.Controls.Add(this.btnShowLicensesHistory);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.picHeader);
            this.Controls.Add(this.ucLicenseInfoWithFilter1);
            this.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "FrmReplacementForLostOrDamagedLicense";
            this.Size = new System.Drawing.Size(1086, 723);
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAppDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAppFees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCreatedBy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOldLicenseID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReplacedLicenseID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLicenseReplaceApplicationID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.PictureBox picHeader;
        private Licenses.UserControls.UcLicenseInfoWithFilter ucLicenseInfoWithFilter1;
        private Guna.UI2.WinForms.Guna2GradientButton btnShowLicenseInfo;
        private Guna.UI2.WinForms.Guna2GradientButton btnShowLicensesHistory;
        private Guna.UI2.WinForms.Guna2GradientButton btnReplace;
        private Guna.UI2.WinForms.Guna2GradientButton btnBack;
        private System.Windows.Forms.Label labAppDate;
        private System.Windows.Forms.PictureBox picAppDate;
        private System.Windows.Forms.Label lblAppDate;
        private System.Windows.Forms.Label labAppFees;
        private System.Windows.Forms.PictureBox picAppFees;
        private System.Windows.Forms.Label lblAppFees;
        private System.Windows.Forms.Label labCreatedBy;
        private System.Windows.Forms.PictureBox picCreatedBy;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label labOldLicenseID;
        private System.Windows.Forms.PictureBox picOldLicenseID;
        private System.Windows.Forms.Label lblOldLicenseID;
        private System.Windows.Forms.Label labReplacedLicenseID;
        private System.Windows.Forms.PictureBox picReplacedLicenseID;
        private System.Windows.Forms.Label lblReplacedLicenseID;
        private System.Windows.Forms.Label labLicenseReplaceApplicationID;
        private System.Windows.Forms.PictureBox picLicenseReplaceApplicationID;
        private System.Windows.Forms.Label lblLicenseReplaceApplicationID;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel4;
        private System.Windows.Forms.Label LabReplaceFor;
        private System.Windows.Forms.Label lblReplaceFor;
    }
}
