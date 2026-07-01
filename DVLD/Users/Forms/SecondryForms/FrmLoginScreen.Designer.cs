namespace DVLD.Users.Forms.SecondryForms
{
    partial class FrmLoginScreen
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoginScreen));
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnLogin = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2GradientButton();
            this.picLoginScreen = new System.Windows.Forms.PictureBox();
            this.rbtnRememberMe = new Guna.UI2.WinForms.Guna2RadioButton();
            this.l1 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.l9 = new System.Windows.Forms.Label();
            this.l8 = new System.Windows.Forms.Label();
            this.l7 = new System.Windows.Forms.Label();
            this.l6 = new System.Windows.Forms.Label();
            this.l5 = new System.Windows.Forms.Label();
            this.lblBy = new System.Windows.Forms.Label();
            this.l4 = new System.Windows.Forms.Label();
            this.l3 = new System.Windows.Forms.Label();
            this.timerProjectName = new System.Windows.Forms.Timer(this.components);
            this.btnViewHide = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ttMessage = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            ((System.ComponentModel.ISupportInitialize)(this.picLoginScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(358, 325);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(151, 39);
            this.lblUserName.TabIndex = 7;
            this.lblUserName.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(358, 391);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(144, 39);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.Animated = true;
            this.btnLogin.BorderRadius = 20;
            this.btnLogin.CheckedState.Parent = this.btnLogin;
            this.btnLogin.CustomImages.Parent = this.btnLogin;
            this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnLogin.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnLogin.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnLogin.HoverState.Parent = this.btnLogin;
            this.btnLogin.Image = global::DVLD.Properties.Resources.login;
            this.btnLogin.ImageSize = new System.Drawing.Size(45, 45);
            this.btnLogin.Location = new System.Drawing.Point(525, 483);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ShadowDecoration.Parent = this.btnLogin;
            this.btnLogin.Size = new System.Drawing.Size(356, 49);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.Enter += new System.EventHandler(this.btnSwitchFillColor);
            this.btnLogin.Leave += new System.EventHandler(this.btnSwitchFillColor);
            // 
            // txtPassword
            // 
            this.txtPassword.Animated = true;
            this.txtPassword.BorderColor = System.Drawing.Color.Gray;
            this.txtPassword.BorderRadius = 10;
            this.txtPassword.BorderThickness = 2;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "1";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.Parent = this.txtPassword;
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtPassword.FocusedState.Parent = this.txtPassword;
            this.txtPassword.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtPassword.HoverState.ForeColor = System.Drawing.Color.Silver;
            this.txtPassword.HoverState.Parent = this.txtPassword;
            this.txtPassword.IconLeft = global::DVLD.Properties.Resources.padlock;
            this.txtPassword.IconLeftOffset = new System.Drawing.Point(7, 0);
            this.txtPassword.Location = new System.Drawing.Point(525, 383);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionStart = 1;
            this.txtPassword.ShadowDecoration.Parent = this.txtPassword;
            this.txtPassword.Size = new System.Drawing.Size(356, 47);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.TextOffset = new System.Drawing.Point(10, 0);
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.ttMessageForTxtPassword);
            // 
            // txtName
            // 
            this.txtName.Animated = true;
            this.txtName.BorderColor = System.Drawing.Color.Gray;
            this.txtName.BorderRadius = 10;
            this.txtName.BorderThickness = 2;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "z";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.Parent = this.txtName;
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtName.FocusedState.Parent = this.txtName;
            this.txtName.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtName.HoverState.ForeColor = System.Drawing.Color.Silver;
            this.txtName.HoverState.Parent = this.txtName;
            this.txtName.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtName.IconLeft")));
            this.txtName.IconLeftOffset = new System.Drawing.Point(7, 0);
            this.txtName.Location = new System.Drawing.Point(525, 321);
            this.txtName.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtName.PlaceholderText = "";
            this.txtName.SelectedText = "";
            this.txtName.SelectionStart = 1;
            this.txtName.ShadowDecoration.Parent = this.txtName;
            this.txtName.Size = new System.Drawing.Size(356, 47);
            this.txtName.TabIndex = 0;
            this.txtName.TextOffset = new System.Drawing.Point(10, 0);
            this.txtName.Enter += new System.EventHandler(this.txttName_Enter);
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.ttMessageCantBeEmpty);
            // 
            // btnClose
            // 
            this.btnClose.Animated = true;
            this.btnClose.AutoRoundedCorners = true;
            this.btnClose.BorderRadius = 19;
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.CustomImages.Parent = this.btnClose;
            this.btnClose.FillColor = System.Drawing.Color.DeepPink;
            this.btnClose.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnClose.HoverState.FillColor2 = System.Drawing.Color.DeepPink;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Image = global::DVLD.Properties.Resources.close;
            this.btnClose.ImageOffset = new System.Drawing.Point(1, 0);
            this.btnClose.ImageSize = new System.Drawing.Size(24, 24);
            this.btnClose.Location = new System.Drawing.Point(664, 62);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 5;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.Enter += new System.EventHandler(this.btnSwitchFillColor);
            this.btnClose.Leave += new System.EventHandler(this.btnSwitchFillColor);
            // 
            // picLoginScreen
            // 
            this.picLoginScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLoginScreen.Image = ((System.Drawing.Image)(resources.GetObject("picLoginScreen.Image")));
            this.picLoginScreen.Location = new System.Drawing.Point(0, 0);
            this.picLoginScreen.Name = "picLoginScreen";
            this.picLoginScreen.Size = new System.Drawing.Size(1386, 788);
            this.picLoginScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLoginScreen.TabIndex = 0;
            this.picLoginScreen.TabStop = false;
            // 
            // rbtnRememberMe
            // 
            this.rbtnRememberMe.AutoSize = true;
            this.rbtnRememberMe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rbtnRememberMe.CheckedState.BorderColor = System.Drawing.Color.White;
            this.rbtnRememberMe.CheckedState.BorderThickness = 1;
            this.rbtnRememberMe.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.rbtnRememberMe.CheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbtnRememberMe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnRememberMe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnRememberMe.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnRememberMe.ForeColor = System.Drawing.Color.White;
            this.rbtnRememberMe.Location = new System.Drawing.Point(525, 443);
            this.rbtnRememberMe.Name = "rbtnRememberMe";
            this.rbtnRememberMe.Size = new System.Drawing.Size(105, 24);
            this.rbtnRememberMe.TabIndex = 3;
            this.rbtnRememberMe.TabStop = true;
            this.rbtnRememberMe.Text = "remeber me";
            this.rbtnRememberMe.UncheckedState.BorderColor = System.Drawing.Color.Gray;
            this.rbtnRememberMe.UncheckedState.BorderThickness = 2;
            this.rbtnRememberMe.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbtnRememberMe.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbtnRememberMe.UseVisualStyleBackColor = true;
            this.rbtnRememberMe.Click += new System.EventHandler(this.rbtnRememberMe_Click);
            this.rbtnRememberMe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rbtnRememberMe_KeyPress);
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Italic);
            this.l1.ForeColor = System.Drawing.Color.White;
            this.l1.Location = new System.Drawing.Point(530, 225);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(42, 48);
            this.l1.TabIndex = 8;
            this.l1.Text = "D";
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Italic);
            this.l2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.l2.Location = new System.Drawing.Point(560, 225);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(40, 48);
            this.l2.TabIndex = 9;
            this.l2.Text = "V";
            // 
            // l9
            // 
            this.l9.AutoSize = true;
            this.l9.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Italic);
            this.l9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.l9.Location = new System.Drawing.Point(826, 225);
            this.l9.Name = "l9";
            this.l9.Size = new System.Drawing.Size(42, 48);
            this.l9.TabIndex = 17;
            this.l9.Text = "";
            // 
            // l8
            // 
            this.l8.AutoSize = true;
            this.l8.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Italic);
            this.l8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.l8.Location = new System.Drawing.Point(795, 225);
            this.l8.Name = "l8";
            this.l8.Size = new System.Drawing.Size(40, 48);
            this.l8.TabIndex = 16;
            this.l8.Text = "";
            // 
            // l7
            // 
            this.l7.AutoSize = true;
            this.l7.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Italic);
            this.l7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.l7.Location = new System.Drawing.Point(767, 225);
            this.l7.Name = "l7";
            this.l7.Size = new System.Drawing.Size(35, 48);
            this.l7.TabIndex = 15;
            this.l7.Text = "S";
            // 
            // l6
            // 
            this.l6.AutoSize = true;
            this.l6.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Italic);
            this.l6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.l6.Location = new System.Drawing.Point(735, 225);
            this.l6.Name = "l6";
            this.l6.Size = new System.Drawing.Size(41, 48);
            this.l6.TabIndex = 14;
            this.l6.Text = "7";
            // 
            // l5
            // 
            this.l5.AutoSize = true;
            this.l5.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Italic);
            this.l5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.l5.Location = new System.Drawing.Point(706, 225);
            this.l5.Name = "l5";
            this.l5.Size = new System.Drawing.Size(40, 48);
            this.l5.TabIndex = 13;
            this.l5.Text = "S";
            // 
            // lblBy
            // 
            this.lblBy.AutoSize = true;
            this.lblBy.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Italic);
            this.lblBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.lblBy.Location = new System.Drawing.Point(669, 244);
            this.lblBy.Name = "lblBy";
            this.lblBy.Size = new System.Drawing.Size(31, 25);
            this.lblBy.TabIndex = 12;
            this.lblBy.Text = "by";
            // 
            // l4
            // 
            this.l4.AutoSize = true;
            this.l4.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Italic);
            this.l4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.l4.Location = new System.Drawing.Point(616, 225);
            this.l4.Name = "l4";
            this.l4.Size = new System.Drawing.Size(42, 48);
            this.l4.TabIndex = 11;
            this.l4.Text = "D";
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Italic);
            this.l3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.l3.Location = new System.Drawing.Point(591, 225);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(35, 48);
            this.l3.TabIndex = 10;
            this.l3.Text = "L";
            // 
            // timerProjectName
            // 
            this.timerProjectName.Interval = 5000;
            this.timerProjectName.Tick += new System.EventHandler(this.timerProjectName_Tick);
            // 
            // btnViewHide
            // 
            this.btnViewHide.Animated = true;
            this.btnViewHide.BorderRadius = 10;
            this.btnViewHide.CheckedState.Parent = this.btnViewHide;
            this.btnViewHide.CustomImages.Parent = this.btnViewHide;
            this.btnViewHide.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnViewHide.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnViewHide.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnViewHide.ForeColor = System.Drawing.Color.White;
            this.btnViewHide.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnViewHide.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnViewHide.HoverState.Parent = this.btnViewHide;
            this.btnViewHide.Image = global::DVLD.Properties.Resources.view;
            this.btnViewHide.ImageSize = new System.Drawing.Size(21, 21);
            this.btnViewHide.Location = new System.Drawing.Point(886, 392);
            this.btnViewHide.Name = "btnViewHide";
            this.btnViewHide.ShadowDecoration.Parent = this.btnViewHide;
            this.btnViewHide.Size = new System.Drawing.Size(36, 28);
            this.btnViewHide.TabIndex = 2;
            this.btnViewHide.Click += new System.EventHandler(this.btnViewHide_Click);
            this.btnViewHide.Enter += new System.EventHandler(this.btnSwitchFillColor);
            this.btnViewHide.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnViewHide_KeyDown);
            this.btnViewHide.Leave += new System.EventHandler(this.btnSwitchFillColor);
            // 
            // ttMessage
            // 
            this.ttMessage.AllowLinksHandling = true;
            this.ttMessage.MaximumSize = new System.Drawing.Size(0, 0);
            // 
            // FrmLoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.btnViewHide);
            this.Controls.Add(this.lblBy);
            this.Controls.Add(this.rbtnRememberMe);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.l3);
            this.Controls.Add(this.l4);
            this.Controls.Add(this.l5);
            this.Controls.Add(this.l6);
            this.Controls.Add(this.l7);
            this.Controls.Add(this.l8);
            this.Controls.Add(this.l9);
            this.Controls.Add(this.picLoginScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLoginScreen";
            this.Text = "\'";
            this.Load += new System.EventHandler(this.FrmLoginScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLoginScreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLoginScreen;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private Guna.UI2.WinForms.Guna2GradientButton btnClose;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2GradientButton btnLogin;
        private Guna.UI2.WinForms.Guna2RadioButton rbtnRememberMe;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label l9;
        private System.Windows.Forms.Label l8;
        private System.Windows.Forms.Label l7;
        private System.Windows.Forms.Label l6;
        private System.Windows.Forms.Label l5;
        private System.Windows.Forms.Label lblBy;
        private System.Windows.Forms.Label l4;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.Timer timerProjectName;
        private Guna.UI2.WinForms.Guna2GradientButton btnViewHide;
        private Guna.UI2.WinForms.Guna2HtmlToolTip ttMessage;
    }
}