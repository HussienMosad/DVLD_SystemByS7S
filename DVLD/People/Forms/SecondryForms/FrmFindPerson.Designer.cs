namespace DVLD.People.Forms.MainForm
{
    partial class FrmFindPerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFindPerson));
            this.lblFindPerson = new System.Windows.Forms.Label();
            this.picFind = new System.Windows.Forms.PictureBox();
            this.btnBack = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ucPersonDetailsWithFilter = new DVLD.People.UserControls.UcPersonDetailsWithFilter();
            ((System.ComponentModel.ISupportInitialize)(this.picFind)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFindPerson
            // 
            this.lblFindPerson.AutoSize = true;
            this.lblFindPerson.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFindPerson.Location = new System.Drawing.Point(19, 14);
            this.lblFindPerson.Name = "lblFindPerson";
            this.lblFindPerson.Size = new System.Drawing.Size(367, 80);
            this.lblFindPerson.TabIndex = 9;
            this.lblFindPerson.Text = "- Find Person";
            this.lblFindPerson.UseMnemonic = false;
            // 
            // picFind
            // 
            this.picFind.Image = ((System.Drawing.Image)(resources.GetObject("picFind.Image")));
            this.picFind.Location = new System.Drawing.Point(382, 20);
            this.picFind.Name = "picFind";
            this.picFind.Size = new System.Drawing.Size(75, 71);
            this.picFind.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFind.TabIndex = 10;
            this.picFind.TabStop = false;
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
            // FrmFindPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Controls.Add(this.ucPersonDetailsWithFilter);
            this.Controls.Add(this.picFind);
            this.Controls.Add(this.lblFindPerson);
            this.Controls.Add(this.btnBack);
            this.Font = new System.Drawing.Font("Impact", 24F);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "FrmFindPerson";
            this.Size = new System.Drawing.Size(1086, 723);
            ((System.ComponentModel.ISupportInitialize)(this.picFind)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GradientButton btnBack;
        private System.Windows.Forms.PictureBox picFind;
        private System.Windows.Forms.Label lblFindPerson;
        private UserControls.UcPersonDetailsWithFilter ucPersonDetailsWithFilter;
    }
}
