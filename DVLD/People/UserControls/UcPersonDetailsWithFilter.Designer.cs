namespace DVLD.People.UserControls
{
    partial class UcPersonDetailsWithFilter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcPersonDetailsWithFilter));
            this.CmbFilterBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblFilterBy = new System.Windows.Forms.Label();
            this.btnAddPerson = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtFilterBy = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnFindPerson = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ucPersonDetails1 = new DVLD.UcPersonDetails();
            this.SuspendLayout();
            // 
            // CmbFilterBy
            // 
            this.CmbFilterBy.Animated = true;
            this.CmbFilterBy.AutoRoundedCorners = true;
            this.CmbFilterBy.BackColor = System.Drawing.Color.Transparent;
            this.CmbFilterBy.BorderColor = System.Drawing.Color.White;
            this.CmbFilterBy.BorderRadius = 17;
            this.CmbFilterBy.BorderThickness = 0;
            this.CmbFilterBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbFilterBy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.CmbFilterBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbFilterBy.FocusedColor = System.Drawing.Color.Empty;
            this.CmbFilterBy.FocusedState.Parent = this.CmbFilterBy;
            this.CmbFilterBy.Font = new System.Drawing.Font("Impact", 18.25F);
            this.CmbFilterBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.CmbFilterBy.FormattingEnabled = true;
            this.CmbFilterBy.HoverState.Font = new System.Drawing.Font("Impact", 23.25F);
            this.CmbFilterBy.HoverState.ForeColor = System.Drawing.Color.Teal;
            this.CmbFilterBy.HoverState.Parent = this.CmbFilterBy;
            this.CmbFilterBy.IntegralHeight = false;
            this.CmbFilterBy.ItemHeight = 30;
            this.CmbFilterBy.Items.AddRange(new object[] {
            "NationalNo",
            "Person ID"});
            this.CmbFilterBy.ItemsAppearance.Parent = this.CmbFilterBy;
            this.CmbFilterBy.Location = new System.Drawing.Point(175, 20);
            this.CmbFilterBy.Name = "CmbFilterBy";
            this.CmbFilterBy.ShadowDecoration.Parent = this.CmbFilterBy;
            this.CmbFilterBy.Size = new System.Drawing.Size(213, 36);
            this.CmbFilterBy.Sorted = true;
            this.CmbFilterBy.StartIndex = 1;
            this.CmbFilterBy.TabIndex = 0;
            this.CmbFilterBy.SelectedIndexChanged += new System.EventHandler(this.CmbFilterBy_SelectedIndexChanged);
            this.CmbFilterBy.Enter += new System.EventHandler(this.CmbFilterBy_Enter);
            this.CmbFilterBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmbFilterBy_KeyPress);
            this.CmbFilterBy.Leave += new System.EventHandler(this.CmbFilterBy_Leave);
            // 
            // lblFilterBy
            // 
            this.lblFilterBy.AutoSize = true;
            this.lblFilterBy.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterBy.Location = new System.Drawing.Point(36, 16);
            this.lblFilterBy.Name = "lblFilterBy";
            this.lblFilterBy.Size = new System.Drawing.Size(133, 39);
            this.lblFilterBy.TabIndex = 7;
            this.lblFilterBy.Text = "Filter By :";
            this.lblFilterBy.UseMnemonic = false;
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Animated = true;
            this.btnAddPerson.BorderRadius = 20;
            this.btnAddPerson.CheckedState.Parent = this.btnAddPerson;
            this.btnAddPerson.CustomImages.Parent = this.btnAddPerson;
            this.btnAddPerson.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnAddPerson.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnAddPerson.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddPerson.ForeColor = System.Drawing.Color.White;
            this.btnAddPerson.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnAddPerson.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnAddPerson.HoverState.Parent = this.btnAddPerson;
            this.btnAddPerson.Image = ((System.Drawing.Image)(resources.GetObject("btnAddPerson.Image")));
            this.btnAddPerson.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAddPerson.Location = new System.Drawing.Point(718, 12);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.ShadowDecoration.Parent = this.btnAddPerson;
            this.btnAddPerson.Size = new System.Drawing.Size(66, 49);
            this.btnAddPerson.TabIndex = 3;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            this.btnAddPerson.Enter += new System.EventHandler(this.btnSwitchFillColor);
            this.btnAddPerson.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmbFilterBy_KeyPress);
            this.btnAddPerson.Leave += new System.EventHandler(this.btnSwitchFillColor);
            // 
            // txtFilterBy
            // 
            this.txtFilterBy.Animated = true;
            this.txtFilterBy.AutoRoundedCorners = true;
            this.txtFilterBy.BorderColor = System.Drawing.Color.Gray;
            this.txtFilterBy.BorderRadius = 23;
            this.txtFilterBy.BorderThickness = 2;
            this.txtFilterBy.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilterBy.DefaultText = "";
            this.txtFilterBy.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFilterBy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFilterBy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilterBy.DisabledState.Parent = this.txtFilterBy;
            this.txtFilterBy.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilterBy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txtFilterBy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtFilterBy.FocusedState.Parent = this.txtFilterBy;
            this.txtFilterBy.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterBy.ForeColor = System.Drawing.Color.Gray;
            this.txtFilterBy.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtFilterBy.HoverState.ForeColor = System.Drawing.Color.Silver;
            this.txtFilterBy.HoverState.Parent = this.txtFilterBy;
            this.txtFilterBy.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtFilterBy.IconLeft")));
            this.txtFilterBy.IconLeftOffset = new System.Drawing.Point(7, 0);
            this.txtFilterBy.Location = new System.Drawing.Point(390, 13);
            this.txtFilterBy.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.txtFilterBy.Name = "txtFilterBy";
            this.txtFilterBy.PasswordChar = '\0';
            this.txtFilterBy.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFilterBy.PlaceholderText = "";
            this.txtFilterBy.SelectedText = "";
            this.txtFilterBy.ShadowDecoration.Parent = this.txtFilterBy;
            this.txtFilterBy.Size = new System.Drawing.Size(241, 48);
            this.txtFilterBy.TabIndex = 1;
            this.txtFilterBy.TextOffset = new System.Drawing.Point(10, 0);
            this.txtFilterBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterBy_KeyPress);
            // 
            // btnFindPerson
            // 
            this.btnFindPerson.Animated = true;
            this.btnFindPerson.BorderRadius = 20;
            this.btnFindPerson.CheckedState.Parent = this.btnFindPerson;
            this.btnFindPerson.CustomImages.Parent = this.btnFindPerson;
            this.btnFindPerson.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnFindPerson.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnFindPerson.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFindPerson.ForeColor = System.Drawing.Color.White;
            this.btnFindPerson.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnFindPerson.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnFindPerson.HoverState.Parent = this.btnFindPerson;
            this.btnFindPerson.Image = ((System.Drawing.Image)(resources.GetObject("btnFindPerson.Image")));
            this.btnFindPerson.ImageSize = new System.Drawing.Size(40, 40);
            this.btnFindPerson.Location = new System.Drawing.Point(642, 12);
            this.btnFindPerson.Name = "btnFindPerson";
            this.btnFindPerson.ShadowDecoration.Parent = this.btnFindPerson;
            this.btnFindPerson.Size = new System.Drawing.Size(66, 49);
            this.btnFindPerson.TabIndex = 2;
            this.btnFindPerson.Click += new System.EventHandler(this.btnFindPerson_Click);
            this.btnFindPerson.Enter += new System.EventHandler(this.btnSwitchFillColor);
            this.btnFindPerson.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmbFilterBy_KeyPress);
            this.btnFindPerson.Leave += new System.EventHandler(this.btnSwitchFillColor);
            // 
            // ucPersonDetails1
            // 
            this.ucPersonDetails1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ucPersonDetails1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucPersonDetails1.ForeColor = System.Drawing.Color.White;
            this.ucPersonDetails1.Location = new System.Drawing.Point(0, 79);
            this.ucPersonDetails1.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.ucPersonDetails1.Name = "ucPersonDetails1";
            this.ucPersonDetails1.Size = new System.Drawing.Size(1086, 451);
            this.ucPersonDetails1.TabIndex = 0;
            this.ucPersonDetails1.TabStop = false;
            // 
            // UcPersonDetailsWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Controls.Add(this.btnFindPerson);
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.txtFilterBy);
            this.Controls.Add(this.CmbFilterBy);
            this.Controls.Add(this.lblFilterBy);
            this.Controls.Add(this.ucPersonDetails1);
            this.Font = new System.Drawing.Font("Impact", 24F);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.MaximumSize = new System.Drawing.Size(1086, 564);
            this.Name = "UcPersonDetailsWithFilter";
            this.Size = new System.Drawing.Size(1086, 564);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UcPersonDetails ucPersonDetails1;
        private Guna.UI2.WinForms.Guna2GradientButton btnAddPerson;
        private Guna.UI2.WinForms.Guna2TextBox txtFilterBy;
        private Guna.UI2.WinForms.Guna2ComboBox CmbFilterBy;
        private System.Windows.Forms.Label lblFilterBy;
        private Guna.UI2.WinForms.Guna2GradientButton btnFindPerson;
    }
}
