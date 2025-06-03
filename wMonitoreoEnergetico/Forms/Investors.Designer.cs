namespace wMonitoreoEnergetico.Forms
{
    partial class frmInvestors
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMain = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonButton3 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnConstructors = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnInvestor = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnProjects = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cmbTypeInvestor = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lblEmailInvestor = new System.Windows.Forms.Label();
            this.lblNameInvestor = new System.Windows.Forms.Label();
            this.txtInvestorName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblPhoneInvestor = new System.Windows.Forms.Label();
            this.lblCountryInvestor = new System.Windows.Forms.Label();
            this.txtEmailInvestor = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtCountryInvestor = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblTypeInvesotr = new System.Windows.Forms.Label();
            this.txtPhoneInvestor = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnCreateInvestor = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnViewInvestor = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblInvestors = new System.Windows.Forms.Label();
            this.kryptonConfi = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTypeInvestor)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LimeGreen;
            this.panel2.Controls.Add(this.lblMain);
            this.panel2.Location = new System.Drawing.Point(194, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(750, 50);
            this.panel2.TabIndex = 11;
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Font = new System.Drawing.Font("Segoe UI Black", 18F);
            this.lblMain.ForeColor = System.Drawing.Color.White;
            this.lblMain.Location = new System.Drawing.Point(144, 9);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(480, 32);
            this.lblMain.TabIndex = 5;
            this.lblMain.Text = "Renewable Energy Management System";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LimeGreen;
            this.panel1.Controls.Add(this.kryptonButton3);
            this.panel1.Controls.Add(this.btnConstructors);
            this.panel1.Controls.Add(this.btnInvestor);
            this.panel1.Controls.Add(this.btnProjects);
            this.panel1.Location = new System.Drawing.Point(-6, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 466);
            this.panel1.TabIndex = 10;
            // 
            // kryptonButton3
            // 
            this.kryptonButton3.Location = new System.Drawing.Point(24, 414);
            this.kryptonButton3.Name = "kryptonButton3";
            this.kryptonButton3.Size = new System.Drawing.Size(150, 35);
            this.kryptonButton3.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton3.StateCommon.Border.Rounding = 20;
            this.kryptonButton3.TabIndex = 12;
            this.kryptonButton3.Values.Text = "Log out";
            this.kryptonButton3.Click += new System.EventHandler(this.kryptonButton3_Click);
            // 
            // btnConstructors
            // 
            this.btnConstructors.Location = new System.Drawing.Point(24, 238);
            this.btnConstructors.Name = "btnConstructors";
            this.btnConstructors.Size = new System.Drawing.Size(150, 35);
            this.btnConstructors.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnConstructors.StateCommon.Border.Rounding = 20;
            this.btnConstructors.TabIndex = 11;
            this.btnConstructors.Values.Text = "Constructors";
            this.btnConstructors.Click += new System.EventHandler(this.btnConstructors_Click);
            // 
            // btnInvestor
            // 
            this.btnInvestor.Location = new System.Drawing.Point(24, 197);
            this.btnInvestor.Name = "btnInvestor";
            this.btnInvestor.Size = new System.Drawing.Size(150, 35);
            this.btnInvestor.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnInvestor.StateCommon.Border.Rounding = 20;
            this.btnInvestor.TabIndex = 10;
            this.btnInvestor.Values.Text = "Investors";
            this.btnInvestor.Click += new System.EventHandler(this.btnInvestor_Click);
            // 
            // btnProjects
            // 
            this.btnProjects.Location = new System.Drawing.Point(24, 156);
            this.btnProjects.Name = "btnProjects";
            this.btnProjects.Size = new System.Drawing.Size(150, 35);
            this.btnProjects.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnProjects.StateCommon.Border.Rounding = 20;
            this.btnProjects.TabIndex = 9;
            this.btnProjects.Values.Text = "Projects";
            this.btnProjects.Click += new System.EventHandler(this.btnProjects_Click);
            // 
            // cmbTypeInvestor
            // 
            this.cmbTypeInvestor.DropDownWidth = 151;
            this.cmbTypeInvestor.Location = new System.Drawing.Point(666, 159);
            this.cmbTypeInvestor.Name = "cmbTypeInvestor";
            this.cmbTypeInvestor.Size = new System.Drawing.Size(165, 35);
            this.cmbTypeInvestor.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbTypeInvestor.StateCommon.ComboBox.Border.Rounding = 22;
            this.cmbTypeInvestor.TabIndex = 9;
            // 
            // lblEmailInvestor
            // 
            this.lblEmailInvestor.AutoSize = true;
            this.lblEmailInvestor.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblEmailInvestor.Location = new System.Drawing.Point(312, 201);
            this.lblEmailInvestor.Name = "lblEmailInvestor";
            this.lblEmailInvestor.Size = new System.Drawing.Size(48, 21);
            this.lblEmailInvestor.TabIndex = 15;
            this.lblEmailInvestor.Text = "Email";
            // 
            // lblNameInvestor
            // 
            this.lblNameInvestor.AutoSize = true;
            this.lblNameInvestor.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblNameInvestor.Location = new System.Drawing.Point(312, 135);
            this.lblNameInvestor.Name = "lblNameInvestor";
            this.lblNameInvestor.Size = new System.Drawing.Size(109, 21);
            this.lblNameInvestor.TabIndex = 14;
            this.lblNameInvestor.Text = "Investor name";
            // 
            // txtInvestorName
            // 
            this.txtInvestorName.Location = new System.Drawing.Point(316, 159);
            this.txtInvestorName.Name = "txtInvestorName";
            this.txtInvestorName.Size = new System.Drawing.Size(165, 35);
            this.txtInvestorName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtInvestorName.StateCommon.Border.Rounding = 20;
            this.txtInvestorName.TabIndex = 12;
            // 
            // lblPhoneInvestor
            // 
            this.lblPhoneInvestor.AutoSize = true;
            this.lblPhoneInvestor.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblPhoneInvestor.Location = new System.Drawing.Point(487, 201);
            this.lblPhoneInvestor.Name = "lblPhoneInvestor";
            this.lblPhoneInvestor.Size = new System.Drawing.Size(113, 21);
            this.lblPhoneInvestor.TabIndex = 19;
            this.lblPhoneInvestor.Text = "Phone number";
            // 
            // lblCountryInvestor
            // 
            this.lblCountryInvestor.AutoSize = true;
            this.lblCountryInvestor.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblCountryInvestor.Location = new System.Drawing.Point(487, 135);
            this.lblCountryInvestor.Name = "lblCountryInvestor";
            this.lblCountryInvestor.Size = new System.Drawing.Size(111, 21);
            this.lblCountryInvestor.TabIndex = 18;
            this.lblCountryInvestor.Text = "Origin country";
            // 
            // txtEmailInvestor
            // 
            this.txtEmailInvestor.Location = new System.Drawing.Point(316, 225);
            this.txtEmailInvestor.Name = "txtEmailInvestor";
            this.txtEmailInvestor.Size = new System.Drawing.Size(165, 35);
            this.txtEmailInvestor.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtEmailInvestor.StateCommon.Border.Rounding = 20;
            this.txtEmailInvestor.TabIndex = 17;
            // 
            // txtCountryInvestor
            // 
            this.txtCountryInvestor.Location = new System.Drawing.Point(491, 159);
            this.txtCountryInvestor.Name = "txtCountryInvestor";
            this.txtCountryInvestor.Size = new System.Drawing.Size(165, 35);
            this.txtCountryInvestor.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCountryInvestor.StateCommon.Border.Rounding = 20;
            this.txtCountryInvestor.TabIndex = 16;
            // 
            // lblTypeInvesotr
            // 
            this.lblTypeInvesotr.AutoSize = true;
            this.lblTypeInvesotr.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTypeInvesotr.Location = new System.Drawing.Point(662, 135);
            this.lblTypeInvesotr.Name = "lblTypeInvesotr";
            this.lblTypeInvesotr.Size = new System.Drawing.Size(111, 21);
            this.lblTypeInvesotr.TabIndex = 22;
            this.lblTypeInvesotr.Text = "Company type";
            // 
            // txtPhoneInvestor
            // 
            this.txtPhoneInvestor.Location = new System.Drawing.Point(491, 225);
            this.txtPhoneInvestor.Name = "txtPhoneInvestor";
            this.txtPhoneInvestor.Size = new System.Drawing.Size(165, 35);
            this.txtPhoneInvestor.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPhoneInvestor.StateCommon.Border.Rounding = 20;
            this.txtPhoneInvestor.TabIndex = 21;
            // 
            // btnCreateInvestor
            // 
            this.btnCreateInvestor.Location = new System.Drawing.Point(331, 317);
            this.btnCreateInvestor.Name = "btnCreateInvestor";
            this.btnCreateInvestor.Size = new System.Drawing.Size(150, 35);
            this.btnCreateInvestor.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCreateInvestor.StateCommon.Border.Rounding = 20;
            this.btnCreateInvestor.TabIndex = 13;
            this.btnCreateInvestor.Values.Text = "Create Investor";
            this.btnCreateInvestor.Click += new System.EventHandler(this.btnCreateInvestor_Click);
            // 
            // btnViewInvestor
            // 
            this.btnViewInvestor.Location = new System.Drawing.Point(668, 317);
            this.btnViewInvestor.Name = "btnViewInvestor";
            this.btnViewInvestor.Size = new System.Drawing.Size(150, 35);
            this.btnViewInvestor.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnViewInvestor.StateCommon.Border.Rounding = 20;
            this.btnViewInvestor.TabIndex = 23;
            this.btnViewInvestor.Values.Text = "View Investor";
            this.btnViewInvestor.Click += new System.EventHandler(this.btnViewInvestor_Click);
            // 
            // lblInvestors
            // 
            this.lblInvestors.AutoSize = true;
            this.lblInvestors.Font = new System.Drawing.Font("Segoe UI Black", 18F);
            this.lblInvestors.Location = new System.Drawing.Point(485, 53);
            this.lblInvestors.Name = "lblInvestors";
            this.lblInvestors.Size = new System.Drawing.Size(123, 32);
            this.lblInvestors.TabIndex = 24;
            this.lblInvestors.Text = "Investors";
            // 
            // kryptonConfi
            // 
            this.kryptonConfi.FormStyles.FormCommon.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonConfi.FormStyles.FormCommon.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonConfi.FormStyles.FormCommon.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonConfi.FormStyles.FormCommon.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonConfi.FormStyles.FormCommon.StateCommon.Border.Rounding = 12;
            this.kryptonConfi.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonConfi.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonConfi.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            this.kryptonConfi.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            // 
            // frmInvestors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(934, 461);
            this.Controls.Add(this.lblInvestors);
            this.Controls.Add(this.btnViewInvestor);
            this.Controls.Add(this.btnCreateInvestor);
            this.Controls.Add(this.lblTypeInvesotr);
            this.Controls.Add(this.txtPhoneInvestor);
            this.Controls.Add(this.lblPhoneInvestor);
            this.Controls.Add(this.lblCountryInvestor);
            this.Controls.Add(this.txtEmailInvestor);
            this.Controls.Add(this.txtCountryInvestor);
            this.Controls.Add(this.lblEmailInvestor);
            this.Controls.Add(this.lblNameInvestor);
            this.Controls.Add(this.txtInvestorName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbTypeInvestor);
            this.Name = "frmInvestors";
            this.Palette = this.kryptonConfi;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.Text = "Investors";
            this.Load += new System.EventHandler(this.frmInvestors_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbTypeInvestor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnConstructors;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnInvestor;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnProjects;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbTypeInvestor;
        private System.Windows.Forms.Label lblEmailInvestor;
        private System.Windows.Forms.Label lblNameInvestor;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtInvestorName;
        private System.Windows.Forms.Label lblPhoneInvestor;
        private System.Windows.Forms.Label lblCountryInvestor;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtEmailInvestor;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtCountryInvestor;
        private System.Windows.Forms.Label lblTypeInvesotr;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPhoneInvestor;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCreateInvestor;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnViewInvestor;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Label lblInvestors;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonConfi;
    }
}