namespace DVLD.Users.Forms.SecondryForms
{
    partial class FrmAddEditUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddEditUser));
            this.picHeader = new System.Windows.Forms.PictureBox();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.btnBack = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.picConfirmPassword = new System.Windows.Forms.PictureBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.picPassword = new System.Windows.Forms.PictureBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtNewUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.picNewUserName = new System.Windows.Forms.PictureBox();
            this.lblNewUserName = new System.Windows.Forms.Label();
            this.labUserID = new System.Windows.Forms.Label();
            this.picUserID = new System.Windows.Forms.PictureBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.picIsActive = new System.Windows.Forms.PictureBox();
            this.lblIsActive = new System.Windows.Forms.Label();
            this.btnIsActive = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSave = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnEditPerson = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ucPersonDetailsWithFilter = new DVLD.People.UserControls.UcPersonDetailsWithFilter();
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picConfirmPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNewUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIsActive)).BeginInit();
            this.SuspendLayout();
            // 
            // picHeader
            // 
            this.picHeader.Image = ((System.Drawing.Image)(resources.GetObject("picHeader.Image")));
            this.picHeader.Location = new System.Drawing.Point(419, 1);
            this.picHeader.Name = "picHeader";
            this.picHeader.Size = new System.Drawing.Size(110, 110);
            this.picHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHeader.TabIndex = 7;
            this.picHeader.TabStop = false;
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderTitle.Location = new System.Drawing.Point(19, 14);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(416, 80);
            this.lblHeaderTitle.TabIndex = 6;
            this.lblHeaderTitle.Text = "- Add New User";
            this.lblHeaderTitle.UseMnemonic = false;
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
            this.btnBack.TabIndex = 6;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.Enter += new System.EventHandler(this.btnSwitchFillColor);
            this.btnBack.Leave += new System.EventHandler(this.btnSwitchFillColor);
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
            this.txtConfirmPassword.Location = new System.Drawing.Point(830, 562);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '\0';
            this.txtConfirmPassword.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtConfirmPassword.PlaceholderText = "";
            this.txtConfirmPassword.SelectedText = "";
            this.txtConfirmPassword.ShadowDecoration.Parent = this.txtConfirmPassword;
            this.txtConfirmPassword.Size = new System.Drawing.Size(246, 39);
            this.txtConfirmPassword.TabIndex = 3;
            this.txtConfirmPassword.TextOffset = new System.Drawing.Point(10, 0);
            this.txtConfirmPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            this.txtConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // picConfirmPassword
            // 
            this.picConfirmPassword.Image = ((System.Drawing.Image)(resources.GetObject("picConfirmPassword.Image")));
            this.picConfirmPassword.Location = new System.Drawing.Point(620, 566);
            this.picConfirmPassword.Name = "picConfirmPassword";
            this.picConfirmPassword.Size = new System.Drawing.Size(30, 27);
            this.picConfirmPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picConfirmPassword.TabIndex = 71;
            this.picConfirmPassword.TabStop = false;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Impact", 14F);
            this.lblConfirmPassword.Location = new System.Drawing.Point(663, 567);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(165, 23);
            this.lblConfirmPassword.TabIndex = 70;
            this.lblConfirmPassword.Text = "Confirm Password  :";
            // 
            // txtPassword
            // 
            this.txtPassword.Animated = true;
            this.txtPassword.BorderColor = System.Drawing.Color.Gray;
            this.txtPassword.BorderRadius = 10;
            this.txtPassword.BorderThickness = 2;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.Parent = this.txtPassword;
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtPassword.FocusedState.Parent = this.txtPassword;
            this.txtPassword.Font = new System.Drawing.Font("Impact", 16F);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtPassword.HoverState.ForeColor = System.Drawing.Color.Silver;
            this.txtPassword.HoverState.Parent = this.txtPassword;
            this.txtPassword.IconLeftOffset = new System.Drawing.Point(7, 0);
            this.txtPassword.Location = new System.Drawing.Point(830, 522);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.SelectedText = "";
            this.txtPassword.ShadowDecoration.Parent = this.txtPassword;
            this.txtPassword.Size = new System.Drawing.Size(246, 39);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.TextOffset = new System.Drawing.Point(10, 0);
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // picPassword
            // 
            this.picPassword.Image = ((System.Drawing.Image)(resources.GetObject("picPassword.Image")));
            this.picPassword.Location = new System.Drawing.Point(620, 526);
            this.picPassword.Name = "picPassword";
            this.picPassword.Size = new System.Drawing.Size(30, 27);
            this.picPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPassword.TabIndex = 69;
            this.picPassword.TabStop = false;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Impact", 16F);
            this.lblPassword.Location = new System.Drawing.Point(663, 527);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(164, 27);
            this.lblPassword.TabIndex = 68;
            this.lblPassword.Text = "User Password    :";
            // 
            // txtNewUserName
            // 
            this.txtNewUserName.Animated = true;
            this.txtNewUserName.BorderColor = System.Drawing.Color.Gray;
            this.txtNewUserName.BorderRadius = 10;
            this.txtNewUserName.BorderThickness = 2;
            this.txtNewUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewUserName.DefaultText = "";
            this.txtNewUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNewUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNewUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewUserName.DisabledState.Parent = this.txtNewUserName;
            this.txtNewUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewUserName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txtNewUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtNewUserName.FocusedState.Parent = this.txtNewUserName;
            this.txtNewUserName.Font = new System.Drawing.Font("Impact", 16F);
            this.txtNewUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtNewUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtNewUserName.HoverState.ForeColor = System.Drawing.Color.Silver;
            this.txtNewUserName.HoverState.Parent = this.txtNewUserName;
            this.txtNewUserName.IconLeftOffset = new System.Drawing.Point(7, 0);
            this.txtNewUserName.Location = new System.Drawing.Point(830, 482);
            this.txtNewUserName.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtNewUserName.Name = "txtNewUserName";
            this.txtNewUserName.PasswordChar = '\0';
            this.txtNewUserName.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNewUserName.PlaceholderText = "";
            this.txtNewUserName.SelectedText = "";
            this.txtNewUserName.ShadowDecoration.Parent = this.txtNewUserName;
            this.txtNewUserName.Size = new System.Drawing.Size(246, 39);
            this.txtNewUserName.TabIndex = 1;
            this.txtNewUserName.TextOffset = new System.Drawing.Point(10, 0);
            this.txtNewUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNewUserName_KeyPress);
            this.txtNewUserName.Validating += new System.ComponentModel.CancelEventHandler(this.ttMessageCantBeEmpty);
            // 
            // picNewUserName
            // 
            this.picNewUserName.Image = ((System.Drawing.Image)(resources.GetObject("picNewUserName.Image")));
            this.picNewUserName.Location = new System.Drawing.Point(620, 486);
            this.picNewUserName.Name = "picNewUserName";
            this.picNewUserName.Size = new System.Drawing.Size(30, 27);
            this.picNewUserName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNewUserName.TabIndex = 67;
            this.picNewUserName.TabStop = false;
            // 
            // lblNewUserName
            // 
            this.lblNewUserName.AutoSize = true;
            this.lblNewUserName.Font = new System.Drawing.Font("Impact", 15F);
            this.lblNewUserName.Location = new System.Drawing.Point(663, 487);
            this.lblNewUserName.Name = "lblNewUserName";
            this.lblNewUserName.Size = new System.Drawing.Size(161, 25);
            this.lblNewUserName.TabIndex = 66;
            this.lblNewUserName.Text = "New User Name     :";
            // 
            // labUserID
            // 
            this.labUserID.AutoEllipsis = true;
            this.labUserID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.labUserID.Location = new System.Drawing.Point(574, 198);
            this.labUserID.Name = "labUserID";
            this.labUserID.Size = new System.Drawing.Size(179, 39);
            this.labUserID.TabIndex = 74;
            this.labUserID.Text = "?";
            // 
            // picUserID
            // 
            this.picUserID.Image = global::DVLD.Properties.Resources.id;
            this.picUserID.Location = new System.Drawing.Point(385, 200);
            this.picUserID.Name = "picUserID";
            this.picUserID.Size = new System.Drawing.Size(38, 35);
            this.picUserID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUserID.TabIndex = 73;
            this.picUserID.TabStop = false;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(426, 195);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(140, 39);
            this.lblUserID.TabIndex = 72;
            this.lblUserID.Text = "User ID    :";
            // 
            // picIsActive
            // 
            this.picIsActive.Image = global::DVLD.Properties.Resources.user_check;
            this.picIsActive.Location = new System.Drawing.Point(620, 602);
            this.picIsActive.Name = "picIsActive";
            this.picIsActive.Size = new System.Drawing.Size(30, 27);
            this.picIsActive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIsActive.TabIndex = 76;
            this.picIsActive.TabStop = false;
            // 
            // lblIsActive
            // 
            this.lblIsActive.AutoSize = true;
            this.lblIsActive.Font = new System.Drawing.Font("Impact", 16F);
            this.lblIsActive.Location = new System.Drawing.Point(663, 602);
            this.lblIsActive.Name = "lblIsActive";
            this.lblIsActive.Size = new System.Drawing.Size(95, 27);
            this.lblIsActive.TabIndex = 75;
            this.lblIsActive.Text = "Is Active :";
            // 
            // btnIsActive
            // 
            this.btnIsActive.Animated = true;
            this.btnIsActive.BorderRadius = 10;
            this.btnIsActive.CheckedState.Parent = this.btnIsActive;
            this.btnIsActive.CustomImages.Parent = this.btnIsActive;
            this.btnIsActive.FillColor = System.Drawing.Color.Empty;
            this.btnIsActive.FillColor2 = System.Drawing.Color.Empty;
            this.btnIsActive.Font = new System.Drawing.Font("Impact", 16F);
            this.btnIsActive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnIsActive.HoverState.Parent = this.btnIsActive;
            this.btnIsActive.ImageOffset = new System.Drawing.Point(2, 0);
            this.btnIsActive.ImageSize = new System.Drawing.Size(21, 21);
            this.btnIsActive.Location = new System.Drawing.Point(836, 607);
            this.btnIsActive.Name = "btnIsActive";
            this.btnIsActive.ShadowDecoration.Parent = this.btnIsActive;
            this.btnIsActive.Size = new System.Drawing.Size(69, 22);
            this.btnIsActive.TabIndex = 4;
            this.btnIsActive.Text = "NO";
            this.btnIsActive.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnIsActive.Click += new System.EventHandler(this.btnIsActive_Click);
            this.btnIsActive.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnIsActive_KeyPress);
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
            this.btnSave.TabIndex = 5;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.Enter += new System.EventHandler(this.btnSwitchFillColor);
            this.btnSave.Leave += new System.EventHandler(this.btnSwitchFillColor);
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
            this.btnEditPerson.TabIndex = 77;
            this.btnEditPerson.Click += new System.EventHandler(this.btnEditPerson_Click);
            this.btnEditPerson.Enter += new System.EventHandler(this.btnSwitchFillColor);
            this.btnEditPerson.Leave += new System.EventHandler(this.btnSwitchFillColor);
            // 
            // ucPersonDetailsWithFilter
            // 
            this.ucPersonDetailsWithFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ucPersonDetailsWithFilter.Font = new System.Drawing.Font("Impact", 24F);
            this.ucPersonDetailsWithFilter.ForeColor = System.Drawing.Color.White;
            this.ucPersonDetailsWithFilter.Location = new System.Drawing.Point(0, 115);
            this.ucPersonDetailsWithFilter.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.ucPersonDetailsWithFilter.MaximumSize = new System.Drawing.Size(1086, 564);
            this.ucPersonDetailsWithFilter.Name = "ucPersonDetailsWithFilter";
            this.ucPersonDetailsWithFilter.Size = new System.Drawing.Size(1086, 528);
            this.ucPersonDetailsWithFilter.TabIndex = 0;
            // 
            // FrmAddEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Controls.Add(this.btnEditPerson);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnIsActive);
            this.Controls.Add(this.picIsActive);
            this.Controls.Add(this.lblIsActive);
            this.Controls.Add(this.labUserID);
            this.Controls.Add(this.picUserID);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.picConfirmPassword);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.picPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtNewUserName);
            this.Controls.Add(this.picNewUserName);
            this.Controls.Add(this.lblNewUserName);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.ucPersonDetailsWithFilter);
            this.Controls.Add(this.lblHeaderTitle);
            this.Controls.Add(this.picHeader);
            this.Font = new System.Drawing.Font("Impact", 24F);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "FrmAddEditUser";
            this.Size = new System.Drawing.Size(1086, 723);
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picConfirmPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNewUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIsActive)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private People.UserControls.UcPersonDetailsWithFilter ucPersonDetailsWithFilter;
        private Guna.UI2.WinForms.Guna2GradientButton btnBack;
        private Guna.UI2.WinForms.Guna2TextBox txtConfirmPassword;
        private System.Windows.Forms.PictureBox picConfirmPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private System.Windows.Forms.PictureBox picPassword;
        private System.Windows.Forms.Label lblPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtNewUserName;
        private System.Windows.Forms.PictureBox picNewUserName;
        private System.Windows.Forms.Label lblNewUserName;
        private System.Windows.Forms.Label labUserID;
        private System.Windows.Forms.PictureBox picUserID;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.PictureBox picIsActive;
        private System.Windows.Forms.Label lblIsActive;
        private Guna.UI2.WinForms.Guna2GradientButton btnIsActive;
        private Guna.UI2.WinForms.Guna2GradientButton btnSave;
        private Guna.UI2.WinForms.Guna2GradientButton btnEditPerson;
    }
}
