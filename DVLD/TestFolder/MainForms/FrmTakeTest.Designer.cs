namespace DVLD.TestFolder.MainForms
{
    partial class FrmTakeTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTakeTest));
            this.picHeader = new System.Windows.Forms.PictureBox();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.btnSave = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnBack = new Guna.UI2.WinForms.Guna2GradientButton();
            this.picTestResult = new System.Windows.Forms.PictureBox();
            this.lblTestResult = new System.Windows.Forms.Label();
            this.picNotes = new System.Windows.Forms.PictureBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtNotes = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnTestResult = new Guna.UI2.WinForms.Guna2GradientButton();
            this.picRetakeFees = new System.Windows.Forms.PictureBox();
            this.lblTestID = new System.Windows.Forms.Label();
            this.picTestID = new System.Windows.Forms.PictureBox();
            this.lalTestID = new System.Windows.Forms.Label();
            this.ucForTestSchedule1 = new DVLD.TestFolder.UserControls.UcForTestSchedule();
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTestResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRetakeFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTestID)).BeginInit();
            this.SuspendLayout();
            // 
            // picHeader
            // 
            this.picHeader.Image = global::DVLD.Properties.Resources.eye__1_;
            this.picHeader.Location = new System.Drawing.Point(580, 3);
            this.picHeader.Name = "picHeader";
            this.picHeader.Size = new System.Drawing.Size(98, 92);
            this.picHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHeader.TabIndex = 17;
            this.picHeader.TabStop = false;
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Impact", 45F);
            this.lblHeaderTitle.Location = new System.Drawing.Point(22, 16);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(524, 75);
            this.lblHeaderTitle.TabIndex = 16;
            this.lblHeaderTitle.Text = "- Take a Written Test";
            this.lblHeaderTitle.UseMnemonic = false;
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
            this.btnSave.TabIndex = 3;
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
            this.btnBack.TabIndex = 4;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.Enter += new System.EventHandler(this.btnSwitchFillColor);
            this.btnBack.Leave += new System.EventHandler(this.btnSwitchFillColor);
            // 
            // picTestResult
            // 
            this.picTestResult.Image = ((System.Drawing.Image)(resources.GetObject("picTestResult.Image")));
            this.picTestResult.Location = new System.Drawing.Point(38, 470);
            this.picTestResult.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.picTestResult.Name = "picTestResult";
            this.picTestResult.Size = new System.Drawing.Size(38, 35);
            this.picTestResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTestResult.TabIndex = 58;
            this.picTestResult.TabStop = false;
            this.picTestResult.Click += new System.EventHandler(this.picRetakeFees_Click);
            // 
            // lblTestResult
            // 
            this.lblTestResult.AutoSize = true;
            this.lblTestResult.Location = new System.Drawing.Point(75, 467);
            this.lblTestResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTestResult.Name = "lblTestResult";
            this.lblTestResult.Size = new System.Drawing.Size(209, 39);
            this.lblTestResult.TabIndex = 57;
            this.lblTestResult.Text = "Test Result       :";
            // 
            // picNotes
            // 
            this.picNotes.Image = ((System.Drawing.Image)(resources.GetObject("picNotes.Image")));
            this.picNotes.Location = new System.Drawing.Point(38, 533);
            this.picNotes.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.picNotes.Name = "picNotes";
            this.picNotes.Size = new System.Drawing.Size(38, 35);
            this.picNotes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNotes.TabIndex = 61;
            this.picNotes.TabStop = false;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(75, 530);
            this.lblNotes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(211, 39);
            this.lblNotes.TabIndex = 60;
            this.lblNotes.Text = "Notes                   :";
            // 
            // txtNotes
            // 
            this.txtNotes.Animated = true;
            this.txtNotes.BorderColor = System.Drawing.Color.Gray;
            this.txtNotes.BorderRadius = 10;
            this.txtNotes.BorderThickness = 2;
            this.txtNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNotes.DefaultText = "";
            this.txtNotes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNotes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNotes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNotes.DisabledState.Parent = this.txtNotes;
            this.txtNotes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNotes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txtNotes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtNotes.FocusedState.Parent = this.txtNotes;
            this.txtNotes.Font = new System.Drawing.Font("Impact", 18F);
            this.txtNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtNotes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.txtNotes.HoverState.ForeColor = System.Drawing.Color.Silver;
            this.txtNotes.HoverState.Parent = this.txtNotes;
            this.txtNotes.IconLeftOffset = new System.Drawing.Point(7, 0);
            this.txtNotes.Location = new System.Drawing.Point(292, 533);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(18);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.PasswordChar = '\0';
            this.txtNotes.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNotes.PlaceholderText = "";
            this.txtNotes.SelectedText = "";
            this.txtNotes.ShadowDecoration.Parent = this.txtNotes;
            this.txtNotes.Size = new System.Drawing.Size(747, 101);
            this.txtNotes.TabIndex = 2;
            this.txtNotes.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // btnTestResult
            // 
            this.btnTestResult.Animated = true;
            this.btnTestResult.BorderRadius = 20;
            this.btnTestResult.CheckedState.Parent = this.btnTestResult;
            this.btnTestResult.CustomImages.Parent = this.btnTestResult;
            this.btnTestResult.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnTestResult.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnTestResult.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestResult.ForeColor = System.Drawing.Color.White;
            this.btnTestResult.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnTestResult.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnTestResult.HoverState.Parent = this.btnTestResult;
            this.btnTestResult.ImageOffset = new System.Drawing.Point(0, 2);
            this.btnTestResult.ImageSize = new System.Drawing.Size(40, 40);
            this.btnTestResult.Location = new System.Drawing.Point(301, 464);
            this.btnTestResult.Name = "btnTestResult";
            this.btnTestResult.ShadowDecoration.Parent = this.btnTestResult;
            this.btnTestResult.Size = new System.Drawing.Size(738, 49);
            this.btnTestResult.TabIndex = 1;
            this.btnTestResult.Tag = "1";
            this.btnTestResult.Text = "Pass";
            this.btnTestResult.Click += new System.EventHandler(this.btnStatus_Click);
            this.btnTestResult.Enter += new System.EventHandler(this.btnSwitchFillColor);
            this.btnTestResult.Leave += new System.EventHandler(this.btnSwitchFillColor);
            // 
            // picRetakeFees
            // 
            this.picRetakeFees.Image = ((System.Drawing.Image)(resources.GetObject("picRetakeFees.Image")));
            this.picRetakeFees.Location = new System.Drawing.Point(38, 459);
            this.picRetakeFees.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.picRetakeFees.Name = "picRetakeFees";
            this.picRetakeFees.Size = new System.Drawing.Size(38, 35);
            this.picRetakeFees.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRetakeFees.TabIndex = 58;
            this.picRetakeFees.TabStop = false;
            // 
            // lblTestID
            // 
            this.lblTestID.AutoSize = true;
            this.lblTestID.Location = new System.Drawing.Point(73, 414);
            this.lblTestID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTestID.Name = "lblTestID";
            this.lblTestID.Size = new System.Drawing.Size(213, 39);
            this.lblTestID.TabIndex = 90;
            this.lblTestID.Text = "Test ID                 :";
            // 
            // picTestID
            // 
            this.picTestID.Image = ((System.Drawing.Image)(resources.GetObject("picTestID.Image")));
            this.picTestID.Location = new System.Drawing.Point(35, 416);
            this.picTestID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.picTestID.Name = "picTestID";
            this.picTestID.Size = new System.Drawing.Size(38, 35);
            this.picTestID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTestID.TabIndex = 91;
            this.picTestID.TabStop = false;
            // 
            // lalTestID
            // 
            this.lalTestID.AutoSize = true;
            this.lalTestID.Font = new System.Drawing.Font("Impact", 24F);
            this.lalTestID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.lalTestID.Location = new System.Drawing.Point(293, 413);
            this.lalTestID.Name = "lalTestID";
            this.lalTestID.Size = new System.Drawing.Size(34, 39);
            this.lalTestID.TabIndex = 99;
            this.lalTestID.Text = "?";
            // 
            // ucForTestSchedule1
            // 
            this.ucForTestSchedule1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ucForTestSchedule1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucForTestSchedule1.ForeColor = System.Drawing.Color.White;
            this.ucForTestSchedule1.Location = new System.Drawing.Point(0, 114);
            this.ucForTestSchedule1.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.ucForTestSchedule1.Name = "ucForTestSchedule1";
            this.ucForTestSchedule1.Size = new System.Drawing.Size(1086, 296);
            this.ucForTestSchedule1.TabIndex = 0;
            // 
            // FrmTakeTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Controls.Add(this.lalTestID);
            this.Controls.Add(this.picTestID);
            this.Controls.Add(this.lblTestID);
            this.Controls.Add(this.btnTestResult);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.picNotes);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.picTestResult);
            this.Controls.Add(this.lblTestResult);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.ucForTestSchedule1);
            this.Controls.Add(this.picHeader);
            this.Controls.Add(this.lblHeaderTitle);
            this.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "FrmTakeTest";
            this.Size = new System.Drawing.Size(1086, 723);
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTestResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRetakeFees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTestID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private UserControls.UcForTestSchedule ucForTestSchedule1;
        private Guna.UI2.WinForms.Guna2GradientButton btnSave;
        private Guna.UI2.WinForms.Guna2GradientButton btnBack;
        private System.Windows.Forms.PictureBox picTestResult;
        private System.Windows.Forms.Label lblTestResult;
        private System.Windows.Forms.PictureBox picNotes;
        private System.Windows.Forms.Label lblNotes;
        private Guna.UI2.WinForms.Guna2TextBox txtNotes;
        private Guna.UI2.WinForms.Guna2GradientButton btnTestResult;
        private System.Windows.Forms.PictureBox picRetakeFees;
        private System.Windows.Forms.Label lblTestID;
        private System.Windows.Forms.PictureBox picTestID;
        private System.Windows.Forms.Label lalTestID;
    }
}
