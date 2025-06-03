namespace wMonitoreoEnergetico.Forms
{
    partial class ViewProject
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
            this.txtIdInvestor = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblIdInvestor = new System.Windows.Forms.Label();
            this.txtIdConstructor = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.txtPower = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblTypeEnergy = new System.Windows.Forms.Label();
            this.txtMunicipality = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblMunicipality = new System.Windows.Forms.Label();
            this.lblProvince = new System.Windows.Forms.Label();
            this.txtUnits = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtProvince = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblUnits = new System.Windows.Forms.Label();
            this.lblNameProject = new System.Windows.Forms.Label();
            this.txtProjectName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.cmbTypeEnergy = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lblProjects = new System.Windows.Forms.Label();
            this.dvgProject = new System.Windows.Forms.DataGridView();
            this.btnSearchProject = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnBackProject = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnDeleteProject = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnUpdateProject = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtIdProject = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblProjectId = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTypeEnergy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgProject)).BeginInit();
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
            this.panel2.Location = new System.Drawing.Point(193, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(750, 50);
            this.panel2.TabIndex = 17;
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
            this.panel1.Location = new System.Drawing.Point(-7, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 466);
            this.panel1.TabIndex = 16;
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
            // 
            // txtIdInvestor
            // 
            this.txtIdInvestor.Location = new System.Drawing.Point(565, 172);
            this.txtIdInvestor.Name = "txtIdInvestor";
            this.txtIdInvestor.Size = new System.Drawing.Size(165, 35);
            this.txtIdInvestor.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtIdInvestor.StateCommon.Border.Rounding = 20;
            this.txtIdInvestor.TabIndex = 58;
            // 
            // lblIdInvestor
            // 
            this.lblIdInvestor.AutoSize = true;
            this.lblIdInvestor.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblIdInvestor.Location = new System.Drawing.Point(561, 148);
            this.lblIdInvestor.Name = "lblIdInvestor";
            this.lblIdInvestor.Size = new System.Drawing.Size(85, 21);
            this.lblIdInvestor.TabIndex = 57;
            this.lblIdInvestor.Text = "ID investor";
            // 
            // txtIdConstructor
            // 
            this.txtIdConstructor.Location = new System.Drawing.Point(736, 172);
            this.txtIdConstructor.Name = "txtIdConstructor";
            this.txtIdConstructor.Size = new System.Drawing.Size(165, 35);
            this.txtIdConstructor.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtIdConstructor.StateCommon.Border.Rounding = 20;
            this.txtIdConstructor.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(732, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 21);
            this.label2.TabIndex = 55;
            this.label2.Text = "ID Contructor";
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblCapacity.Location = new System.Drawing.Point(386, 148);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(103, 21);
            this.lblCapacity.TabIndex = 54;
            this.lblCapacity.Text = "Power output";
            // 
            // txtPower
            // 
            this.txtPower.Location = new System.Drawing.Point(390, 172);
            this.txtPower.Name = "txtPower";
            this.txtPower.Size = new System.Drawing.Size(165, 35);
            this.txtPower.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPower.StateCommon.Border.Rounding = 20;
            this.txtPower.TabIndex = 53;
            // 
            // lblTypeEnergy
            // 
            this.lblTypeEnergy.AutoSize = true;
            this.lblTypeEnergy.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTypeEnergy.Location = new System.Drawing.Point(732, 84);
            this.lblTypeEnergy.Name = "lblTypeEnergy";
            this.lblTypeEnergy.Size = new System.Drawing.Size(121, 21);
            this.lblTypeEnergy.TabIndex = 52;
            this.lblTypeEnergy.Text = "Generation type";
            // 
            // txtMunicipality
            // 
            this.txtMunicipality.Location = new System.Drawing.Point(565, 108);
            this.txtMunicipality.Name = "txtMunicipality";
            this.txtMunicipality.Size = new System.Drawing.Size(165, 35);
            this.txtMunicipality.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtMunicipality.StateCommon.Border.Rounding = 20;
            this.txtMunicipality.TabIndex = 51;
            // 
            // lblMunicipality
            // 
            this.lblMunicipality.AutoSize = true;
            this.lblMunicipality.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblMunicipality.Location = new System.Drawing.Point(561, 84);
            this.lblMunicipality.Name = "lblMunicipality";
            this.lblMunicipality.Size = new System.Drawing.Size(95, 21);
            this.lblMunicipality.TabIndex = 50;
            this.lblMunicipality.Text = "Municipality";
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblProvince.Location = new System.Drawing.Point(386, 84);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(70, 21);
            this.lblProvince.TabIndex = 49;
            this.lblProvince.Text = "Province";
            // 
            // txtUnits
            // 
            this.txtUnits.Location = new System.Drawing.Point(215, 172);
            this.txtUnits.Name = "txtUnits";
            this.txtUnits.Size = new System.Drawing.Size(165, 35);
            this.txtUnits.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtUnits.StateCommon.Border.Rounding = 20;
            this.txtUnits.TabIndex = 48;
            // 
            // txtProvince
            // 
            this.txtProvince.Location = new System.Drawing.Point(390, 108);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Size = new System.Drawing.Size(165, 35);
            this.txtProvince.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtProvince.StateCommon.Border.Rounding = 20;
            this.txtProvince.TabIndex = 47;
            // 
            // lblUnits
            // 
            this.lblUnits.AutoSize = true;
            this.lblUnits.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblUnits.Location = new System.Drawing.Point(211, 148);
            this.lblUnits.Name = "lblUnits";
            this.lblUnits.Size = new System.Drawing.Size(108, 21);
            this.lblUnits.TabIndex = 46;
            this.lblUnits.Text = "Units installed";
            // 
            // lblNameProject
            // 
            this.lblNameProject.AutoSize = true;
            this.lblNameProject.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblNameProject.Location = new System.Drawing.Point(211, 84);
            this.lblNameProject.Name = "lblNameProject";
            this.lblNameProject.Size = new System.Drawing.Size(101, 21);
            this.lblNameProject.TabIndex = 45;
            this.lblNameProject.Text = "Project name";
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(215, 108);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(165, 35);
            this.txtProjectName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtProjectName.StateCommon.Border.Rounding = 20;
            this.txtProjectName.TabIndex = 44;
            // 
            // cmbTypeEnergy
            // 
            this.cmbTypeEnergy.DropDownWidth = 151;
            this.cmbTypeEnergy.Location = new System.Drawing.Point(736, 108);
            this.cmbTypeEnergy.Name = "cmbTypeEnergy";
            this.cmbTypeEnergy.Size = new System.Drawing.Size(165, 35);
            this.cmbTypeEnergy.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbTypeEnergy.StateCommon.ComboBox.Border.Rounding = 22;
            this.cmbTypeEnergy.TabIndex = 43;
            // 
            // lblProjects
            // 
            this.lblProjects.AutoSize = true;
            this.lblProjects.Font = new System.Drawing.Font("Segoe UI Black", 18F);
            this.lblProjects.Location = new System.Drawing.Point(210, 52);
            this.lblProjects.Name = "lblProjects";
            this.lblProjects.Size = new System.Drawing.Size(109, 32);
            this.lblProjects.TabIndex = 59;
            this.lblProjects.Text = "Projects";
            // 
            // dvgProject
            // 
            this.dvgProject.BackgroundColor = System.Drawing.Color.White;
            this.dvgProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgProject.Location = new System.Drawing.Point(199, 213);
            this.dvgProject.Name = "dvgProject";
            this.dvgProject.Size = new System.Drawing.Size(732, 195);
            this.dvgProject.TabIndex = 60;
            // 
            // btnSearchProject
            // 
            this.btnSearchProject.Location = new System.Drawing.Point(536, 414);
            this.btnSearchProject.Name = "btnSearchProject";
            this.btnSearchProject.Size = new System.Drawing.Size(120, 35);
            this.btnSearchProject.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSearchProject.StateCommon.Border.Rounding = 20;
            this.btnSearchProject.TabIndex = 65;
            this.btnSearchProject.Values.Text = "Search";
            this.btnSearchProject.Click += new System.EventHandler(this.btnSearchProject_Click);
            // 
            // btnBackProject
            // 
            this.btnBackProject.Location = new System.Drawing.Point(775, 414);
            this.btnBackProject.Name = "btnBackProject";
            this.btnBackProject.Size = new System.Drawing.Size(120, 35);
            this.btnBackProject.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnBackProject.StateCommon.Border.Rounding = 20;
            this.btnBackProject.TabIndex = 64;
            this.btnBackProject.Values.Text = "Back";
            this.btnBackProject.Click += new System.EventHandler(this.btnBackProject_Click);
            // 
            // btnDeleteProject
            // 
            this.btnDeleteProject.Location = new System.Drawing.Point(380, 414);
            this.btnDeleteProject.Name = "btnDeleteProject";
            this.btnDeleteProject.Size = new System.Drawing.Size(150, 35);
            this.btnDeleteProject.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDeleteProject.StateCommon.Border.Rounding = 20;
            this.btnDeleteProject.TabIndex = 63;
            this.btnDeleteProject.Values.Text = "Delete";
            this.btnDeleteProject.Click += new System.EventHandler(this.btnDeleteProject_Click);
            // 
            // btnUpdateProject
            // 
            this.btnUpdateProject.Location = new System.Drawing.Point(224, 414);
            this.btnUpdateProject.Name = "btnUpdateProject";
            this.btnUpdateProject.Size = new System.Drawing.Size(150, 35);
            this.btnUpdateProject.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnUpdateProject.StateCommon.Border.Rounding = 20;
            this.btnUpdateProject.TabIndex = 62;
            this.btnUpdateProject.Values.Text = "Update";
            this.btnUpdateProject.Click += new System.EventHandler(this.btnUpdateProject_Click);
            // 
            // txtIdProject
            // 
            this.txtIdProject.Location = new System.Drawing.Point(565, 51);
            this.txtIdProject.Name = "txtIdProject";
            this.txtIdProject.Size = new System.Drawing.Size(165, 35);
            this.txtIdProject.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtIdProject.StateCommon.Border.Rounding = 20;
            this.txtIdProject.TabIndex = 67;
            // 
            // lblProjectId
            // 
            this.lblProjectId.AutoSize = true;
            this.lblProjectId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblProjectId.Location = new System.Drawing.Point(470, 56);
            this.lblProjectId.Name = "lblProjectId";
            this.lblProjectId.Size = new System.Drawing.Size(77, 21);
            this.lblProjectId.TabIndex = 66;
            this.lblProjectId.Text = "ID Project";
            // 
            // ViewProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(934, 461);
            this.Controls.Add(this.txtIdProject);
            this.Controls.Add(this.lblProjectId);
            this.Controls.Add(this.btnSearchProject);
            this.Controls.Add(this.btnBackProject);
            this.Controls.Add(this.lblProjects);
            this.Controls.Add(this.btnDeleteProject);
            this.Controls.Add(this.btnUpdateProject);
            this.Controls.Add(this.dvgProject);
            this.Controls.Add(this.txtIdInvestor);
            this.Controls.Add(this.lblIdInvestor);
            this.Controls.Add(this.txtIdConstructor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCapacity);
            this.Controls.Add(this.txtPower);
            this.Controls.Add(this.lblTypeEnergy);
            this.Controls.Add(this.txtMunicipality);
            this.Controls.Add(this.lblMunicipality);
            this.Controls.Add(this.lblProvince);
            this.Controls.Add(this.txtUnits);
            this.Controls.Add(this.txtProvince);
            this.Controls.Add(this.lblUnits);
            this.Controls.Add(this.lblNameProject);
            this.Controls.Add(this.txtProjectName);
            this.Controls.Add(this.cmbTypeEnergy);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ViewProject";
            this.Palette = this.kryptonConfi;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.Text = "ViewProject";
            this.Load += new System.EventHandler(this.ViewProject_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbTypeEnergy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgProject)).EndInit();
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
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtIdInvestor;
        private System.Windows.Forms.Label lblIdInvestor;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtIdConstructor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCapacity;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPower;
        private System.Windows.Forms.Label lblTypeEnergy;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtMunicipality;
        private System.Windows.Forms.Label lblMunicipality;
        private System.Windows.Forms.Label lblProvince;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtUnits;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtProvince;
        private System.Windows.Forms.Label lblUnits;
        private System.Windows.Forms.Label lblNameProject;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtProjectName;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbTypeEnergy;
        private System.Windows.Forms.Label lblProjects;
        private System.Windows.Forms.DataGridView dvgProject;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSearchProject;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnBackProject;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDeleteProject;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnUpdateProject;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtIdProject;
        private System.Windows.Forms.Label lblProjectId;
    }
}