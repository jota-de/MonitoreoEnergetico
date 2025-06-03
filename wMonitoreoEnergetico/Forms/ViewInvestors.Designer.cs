namespace wMonitoreoEnergetico.Forms
{
    partial class frmViewInvestors
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
            this.kryptonConfi = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMain = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonButton3 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnConstructors = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnInvestor = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnProjects = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblInvestors = new System.Windows.Forms.Label();
            this.btnDeleteInvestor = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnUpdateInvestor = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblTypeInvesotr = new System.Windows.Forms.Label();
            this.txtPhoneInvestor = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblPhoneInvestor = new System.Windows.Forms.Label();
            this.lblCountryInvestor = new System.Windows.Forms.Label();
            this.txtEmailInvestor = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtCountryInvestor = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblEmailInvestor = new System.Windows.Forms.Label();
            this.lblNameInvestor = new System.Windows.Forms.Label();
            this.txtInvestorName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.cmbTypeInvestor = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.btnBackInvestor = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dgvInvestors = new System.Windows.Forms.DataGridView();
            this.lblInvestorId = new System.Windows.Forms.Label();
            this.txtInvestorId = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnSearchInvestor = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTypeInvestor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvestors)).BeginInit();
            this.SuspendLayout();
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LimeGreen;
            this.panel2.Controls.Add(this.lblMain);
            this.panel2.Location = new System.Drawing.Point(194, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(750, 50);
            this.panel2.TabIndex = 13;
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
            this.panel1.TabIndex = 12;
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
            // lblInvestors
            // 
            this.lblInvestors.AutoSize = true;
            this.lblInvestors.Font = new System.Drawing.Font("Segoe UI Black", 18F);
            this.lblInvestors.Location = new System.Drawing.Point(506, 53);
            this.lblInvestors.Name = "lblInvestors";
            this.lblInvestors.Size = new System.Drawing.Size(123, 32);
            this.lblInvestors.TabIndex = 37;
            this.lblInvestors.Text = "Investors";
            // 
            // btnDeleteInvestor
            // 
            this.btnDeleteInvestor.Location = new System.Drawing.Point(367, 414);
            this.btnDeleteInvestor.Name = "btnDeleteInvestor";
            this.btnDeleteInvestor.Size = new System.Drawing.Size(150, 35);
            this.btnDeleteInvestor.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDeleteInvestor.StateCommon.Border.Rounding = 20;
            this.btnDeleteInvestor.TabIndex = 36;
            this.btnDeleteInvestor.Values.Text = "Delete";
            this.btnDeleteInvestor.Click += new System.EventHandler(this.btnDeleteInvestor_Click);
            // 
            // btnUpdateInvestor
            // 
            this.btnUpdateInvestor.Location = new System.Drawing.Point(211, 414);
            this.btnUpdateInvestor.Name = "btnUpdateInvestor";
            this.btnUpdateInvestor.Size = new System.Drawing.Size(150, 35);
            this.btnUpdateInvestor.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnUpdateInvestor.StateCommon.Border.Rounding = 20;
            this.btnUpdateInvestor.TabIndex = 27;
            this.btnUpdateInvestor.Values.Text = "Update";
            this.btnUpdateInvestor.Click += new System.EventHandler(this.btnUpdateInvestor_Click);
            // 
            // lblTypeInvesotr
            // 
            this.lblTypeInvesotr.AutoSize = true;
            this.lblTypeInvesotr.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTypeInvesotr.Location = new System.Drawing.Point(476, 148);
            this.lblTypeInvesotr.Name = "lblTypeInvesotr";
            this.lblTypeInvesotr.Size = new System.Drawing.Size(111, 21);
            this.lblTypeInvesotr.TabIndex = 35;
            this.lblTypeInvesotr.Text = "Company type";
            // 
            // txtPhoneInvestor
            // 
            this.txtPhoneInvestor.Location = new System.Drawing.Point(752, 172);
            this.txtPhoneInvestor.Name = "txtPhoneInvestor";
            this.txtPhoneInvestor.Size = new System.Drawing.Size(130, 35);
            this.txtPhoneInvestor.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPhoneInvestor.StateCommon.Border.Rounding = 20;
            this.txtPhoneInvestor.TabIndex = 34;
            // 
            // lblPhoneInvestor
            // 
            this.lblPhoneInvestor.AutoSize = true;
            this.lblPhoneInvestor.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblPhoneInvestor.Location = new System.Drawing.Point(748, 148);
            this.lblPhoneInvestor.Name = "lblPhoneInvestor";
            this.lblPhoneInvestor.Size = new System.Drawing.Size(113, 21);
            this.lblPhoneInvestor.TabIndex = 33;
            this.lblPhoneInvestor.Text = "Phone number";
            // 
            // lblCountryInvestor
            // 
            this.lblCountryInvestor.AutoSize = true;
            this.lblCountryInvestor.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblCountryInvestor.Location = new System.Drawing.Point(340, 148);
            this.lblCountryInvestor.Name = "lblCountryInvestor";
            this.lblCountryInvestor.Size = new System.Drawing.Size(111, 21);
            this.lblCountryInvestor.TabIndex = 32;
            this.lblCountryInvestor.Text = "Origin country";
            // 
            // txtEmailInvestor
            // 
            this.txtEmailInvestor.Location = new System.Drawing.Point(616, 172);
            this.txtEmailInvestor.Name = "txtEmailInvestor";
            this.txtEmailInvestor.Size = new System.Drawing.Size(130, 35);
            this.txtEmailInvestor.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtEmailInvestor.StateCommon.Border.Rounding = 20;
            this.txtEmailInvestor.TabIndex = 31;
            // 
            // txtCountryInvestor
            // 
            this.txtCountryInvestor.Location = new System.Drawing.Point(344, 172);
            this.txtCountryInvestor.Name = "txtCountryInvestor";
            this.txtCountryInvestor.Size = new System.Drawing.Size(130, 35);
            this.txtCountryInvestor.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCountryInvestor.StateCommon.Border.Rounding = 20;
            this.txtCountryInvestor.TabIndex = 30;
            // 
            // lblEmailInvestor
            // 
            this.lblEmailInvestor.AutoSize = true;
            this.lblEmailInvestor.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblEmailInvestor.Location = new System.Drawing.Point(612, 148);
            this.lblEmailInvestor.Name = "lblEmailInvestor";
            this.lblEmailInvestor.Size = new System.Drawing.Size(48, 21);
            this.lblEmailInvestor.TabIndex = 29;
            this.lblEmailInvestor.Text = "Email";
            // 
            // lblNameInvestor
            // 
            this.lblNameInvestor.AutoSize = true;
            this.lblNameInvestor.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblNameInvestor.Location = new System.Drawing.Point(206, 148);
            this.lblNameInvestor.Name = "lblNameInvestor";
            this.lblNameInvestor.Size = new System.Drawing.Size(109, 21);
            this.lblNameInvestor.TabIndex = 28;
            this.lblNameInvestor.Text = "Investor name";
            // 
            // txtInvestorName
            // 
            this.txtInvestorName.Location = new System.Drawing.Point(210, 172);
            this.txtInvestorName.Name = "txtInvestorName";
            this.txtInvestorName.Size = new System.Drawing.Size(130, 35);
            this.txtInvestorName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtInvestorName.StateCommon.Border.Rounding = 20;
            this.txtInvestorName.TabIndex = 26;
            // 
            // cmbTypeInvestor
            // 
            this.cmbTypeInvestor.DropDownWidth = 151;
            this.cmbTypeInvestor.Location = new System.Drawing.Point(480, 172);
            this.cmbTypeInvestor.Name = "cmbTypeInvestor";
            this.cmbTypeInvestor.Size = new System.Drawing.Size(130, 35);
            this.cmbTypeInvestor.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbTypeInvestor.StateCommon.ComboBox.Border.Rounding = 22;
            this.cmbTypeInvestor.TabIndex = 25;
            // 
            // btnBackInvestor
            // 
            this.btnBackInvestor.Location = new System.Drawing.Point(762, 414);
            this.btnBackInvestor.Name = "btnBackInvestor";
            this.btnBackInvestor.Size = new System.Drawing.Size(120, 35);
            this.btnBackInvestor.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnBackInvestor.StateCommon.Border.Rounding = 20;
            this.btnBackInvestor.TabIndex = 39;
            this.btnBackInvestor.Values.Text = "Back";
            this.btnBackInvestor.Click += new System.EventHandler(this.btnBackInvestor_Click);
            // 
            // dgvInvestors
            // 
            this.dgvInvestors.BackgroundColor = System.Drawing.Color.White;
            this.dgvInvestors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvestors.Location = new System.Drawing.Point(211, 213);
            this.dgvInvestors.Name = "dgvInvestors";
            this.dgvInvestors.Size = new System.Drawing.Size(711, 195);
            this.dgvInvestors.TabIndex = 40;
            // 
            // lblInvestorId
            // 
            this.lblInvestorId.AutoSize = true;
            this.lblInvestorId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblInvestorId.Location = new System.Drawing.Point(207, 89);
            this.lblInvestorId.Name = "lblInvestorId";
            this.lblInvestorId.Size = new System.Drawing.Size(85, 21);
            this.lblInvestorId.TabIndex = 42;
            this.lblInvestorId.Text = "Investor ID";
            this.lblInvestorId.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtInvestorId
            // 
            this.txtInvestorId.Location = new System.Drawing.Point(211, 113);
            this.txtInvestorId.Name = "txtInvestorId";
            this.txtInvestorId.Size = new System.Drawing.Size(130, 35);
            this.txtInvestorId.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtInvestorId.StateCommon.Border.Rounding = 20;
            this.txtInvestorId.TabIndex = 41;
            this.txtInvestorId.TextChanged += new System.EventHandler(this.kryptonTextBox1_TextChanged_1);
            // 
            // btnSearchInvestor
            // 
            this.btnSearchInvestor.Location = new System.Drawing.Point(523, 414);
            this.btnSearchInvestor.Name = "btnSearchInvestor";
            this.btnSearchInvestor.Size = new System.Drawing.Size(120, 35);
            this.btnSearchInvestor.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSearchInvestor.StateCommon.Border.Rounding = 20;
            this.btnSearchInvestor.TabIndex = 43;
            this.btnSearchInvestor.Values.Text = "Search";
            this.btnSearchInvestor.Click += new System.EventHandler(this.btnSearchInvestor_Click);
            // 
            // frmViewInvestors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(934, 461);
            this.Controls.Add(this.btnSearchInvestor);
            this.Controls.Add(this.lblInvestorId);
            this.Controls.Add(this.txtInvestorId);
            this.Controls.Add(this.dgvInvestors);
            this.Controls.Add(this.btnBackInvestor);
            this.Controls.Add(this.lblInvestors);
            this.Controls.Add(this.btnDeleteInvestor);
            this.Controls.Add(this.btnUpdateInvestor);
            this.Controls.Add(this.lblTypeInvesotr);
            this.Controls.Add(this.txtPhoneInvestor);
            this.Controls.Add(this.lblPhoneInvestor);
            this.Controls.Add(this.lblCountryInvestor);
            this.Controls.Add(this.txtEmailInvestor);
            this.Controls.Add(this.txtCountryInvestor);
            this.Controls.Add(this.lblEmailInvestor);
            this.Controls.Add(this.lblNameInvestor);
            this.Controls.Add(this.txtInvestorName);
            this.Controls.Add(this.cmbTypeInvestor);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmViewInvestors";
            this.Palette = this.kryptonConfi;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.Text = "ViewInvestors";
            this.Load += new System.EventHandler(this.ViewInvestors_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbTypeInvestor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvestors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonConfi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnConstructors;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnInvestor;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnProjects;
        private System.Windows.Forms.Label lblInvestors;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDeleteInvestor;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnUpdateInvestor;
        private System.Windows.Forms.Label lblTypeInvesotr;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPhoneInvestor;
        private System.Windows.Forms.Label lblPhoneInvestor;
        private System.Windows.Forms.Label lblCountryInvestor;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtEmailInvestor;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtCountryInvestor;
        private System.Windows.Forms.Label lblEmailInvestor;
        private System.Windows.Forms.Label lblNameInvestor;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtInvestorName;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbTypeInvestor;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnBackInvestor;
        private System.Windows.Forms.DataGridView dgvInvestors;
        private System.Windows.Forms.Label lblInvestorId;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtInvestorId;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSearchInvestor;
    }
}