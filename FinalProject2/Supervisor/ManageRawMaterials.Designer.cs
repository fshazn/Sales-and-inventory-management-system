namespace FinalProject2
{
    partial class ManageRawMaterials
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageRawMaterials));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmb_MeasurementUnit = new System.Windows.Forms.ComboBox();
            this.panel_AddRaw = new System.Windows.Forms.Panel();
            this.btn_CancelUpdate = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_UpdateRawMat = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_cancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_add = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txt_rawMaterialID = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_rawMaterialName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_AddNewProduct = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DG_RawMaterial = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.C_RawMaterialID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_RawMaterialName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_addNewRawMat = new Bunifu.Framework.UI.BunifuImageButton();
            this.DG_RawStock = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_r = new System.Windows.Forms.Label();
            this.lbl_RawMaterial = new System.Windows.Forms.Label();
            this.panel_AddRaw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_RawMaterial)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_addNewRawMat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_RawStock)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_MeasurementUnit
            // 
            this.cmb_MeasurementUnit.BackColor = System.Drawing.SystemColors.Control;
            this.cmb_MeasurementUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_MeasurementUnit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_MeasurementUnit.Items.AddRange(new object[] {
            "Kg",
            "g",
            "Packs"});
            this.cmb_MeasurementUnit.Location = new System.Drawing.Point(156, 122);
            this.cmb_MeasurementUnit.Name = "cmb_MeasurementUnit";
            this.cmb_MeasurementUnit.Size = new System.Drawing.Size(206, 27);
            this.cmb_MeasurementUnit.TabIndex = 28;
            // 
            // panel_AddRaw
            // 
            this.panel_AddRaw.Controls.Add(this.btn_CancelUpdate);
            this.panel_AddRaw.Controls.Add(this.btn_UpdateRawMat);
            this.panel_AddRaw.Controls.Add(this.cmb_MeasurementUnit);
            this.panel_AddRaw.Controls.Add(this.btn_cancel);
            this.panel_AddRaw.Controls.Add(this.btn_add);
            this.panel_AddRaw.Controls.Add(this.txt_rawMaterialID);
            this.panel_AddRaw.Controls.Add(this.bunifuCustomLabel1);
            this.panel_AddRaw.Controls.Add(this.bunifuCustomLabel4);
            this.panel_AddRaw.Controls.Add(this.txt_rawMaterialName);
            this.panel_AddRaw.Controls.Add(this.bunifuCustomLabel2);
            this.panel_AddRaw.Location = new System.Drawing.Point(406, 370);
            this.panel_AddRaw.Name = "panel_AddRaw";
            this.panel_AddRaw.Size = new System.Drawing.Size(367, 278);
            this.panel_AddRaw.TabIndex = 32;
            // 
            // btn_CancelUpdate
            // 
            this.btn_CancelUpdate.ActiveBorderThickness = 1;
            this.btn_CancelUpdate.ActiveCornerRadius = 20;
            this.btn_CancelUpdate.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_CancelUpdate.ActiveForecolor = System.Drawing.Color.White;
            this.btn_CancelUpdate.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_CancelUpdate.BackColor = System.Drawing.SystemColors.Control;
            this.btn_CancelUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_CancelUpdate.BackgroundImage")));
            this.btn_CancelUpdate.ButtonText = "Cancel";
            this.btn_CancelUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CancelUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelUpdate.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_CancelUpdate.IdleBorderThickness = 1;
            this.btn_CancelUpdate.IdleCornerRadius = 20;
            this.btn_CancelUpdate.IdleFillColor = System.Drawing.Color.White;
            this.btn_CancelUpdate.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_CancelUpdate.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_CancelUpdate.Location = new System.Drawing.Point(196, 198);
            this.btn_CancelUpdate.Margin = new System.Windows.Forms.Padding(5);
            this.btn_CancelUpdate.Name = "btn_CancelUpdate";
            this.btn_CancelUpdate.Size = new System.Drawing.Size(105, 31);
            this.btn_CancelUpdate.TabIndex = 30;
            this.btn_CancelUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_CancelUpdate.Click += new System.EventHandler(this.btn_CancelUpdate_Click);
            // 
            // btn_UpdateRawMat
            // 
            this.btn_UpdateRawMat.ActiveBorderThickness = 1;
            this.btn_UpdateRawMat.ActiveCornerRadius = 20;
            this.btn_UpdateRawMat.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_UpdateRawMat.ActiveForecolor = System.Drawing.Color.White;
            this.btn_UpdateRawMat.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_UpdateRawMat.BackColor = System.Drawing.SystemColors.Control;
            this.btn_UpdateRawMat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_UpdateRawMat.BackgroundImage")));
            this.btn_UpdateRawMat.ButtonText = "Update";
            this.btn_UpdateRawMat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_UpdateRawMat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UpdateRawMat.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_UpdateRawMat.IdleBorderThickness = 1;
            this.btn_UpdateRawMat.IdleCornerRadius = 20;
            this.btn_UpdateRawMat.IdleFillColor = System.Drawing.Color.White;
            this.btn_UpdateRawMat.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_UpdateRawMat.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_UpdateRawMat.Location = new System.Drawing.Point(63, 198);
            this.btn_UpdateRawMat.Margin = new System.Windows.Forms.Padding(5);
            this.btn_UpdateRawMat.Name = "btn_UpdateRawMat";
            this.btn_UpdateRawMat.Size = new System.Drawing.Size(105, 31);
            this.btn_UpdateRawMat.TabIndex = 29;
            this.btn_UpdateRawMat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_UpdateRawMat.Click += new System.EventHandler(this.btn_UpdateRawMat_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.ActiveBorderThickness = 1;
            this.btn_cancel.ActiveCornerRadius = 20;
            this.btn_cancel.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_cancel.ActiveForecolor = System.Drawing.Color.White;
            this.btn_cancel.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_cancel.BackColor = System.Drawing.SystemColors.Control;
            this.btn_cancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cancel.BackgroundImage")));
            this.btn_cancel.ButtonText = "Cancel";
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_cancel.IdleBorderThickness = 1;
            this.btn_cancel.IdleCornerRadius = 20;
            this.btn_cancel.IdleFillColor = System.Drawing.Color.White;
            this.btn_cancel.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_cancel.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_cancel.Location = new System.Drawing.Point(196, 239);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(5);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(105, 31);
            this.btn_cancel.TabIndex = 27;
            this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_add
            // 
            this.btn_add.ActiveBorderThickness = 1;
            this.btn_add.ActiveCornerRadius = 20;
            this.btn_add.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_add.ActiveForecolor = System.Drawing.Color.White;
            this.btn_add.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_add.BackColor = System.Drawing.SystemColors.Control;
            this.btn_add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_add.BackgroundImage")));
            this.btn_add.ButtonText = "Add";
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_add.IdleBorderThickness = 1;
            this.btn_add.IdleCornerRadius = 20;
            this.btn_add.IdleFillColor = System.Drawing.Color.White;
            this.btn_add.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_add.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_add.Location = new System.Drawing.Point(63, 239);
            this.btn_add.Margin = new System.Windows.Forms.Padding(5);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(105, 31);
            this.btn_add.TabIndex = 26;
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_rawMaterialID
            // 
            this.txt_rawMaterialID.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.txt_rawMaterialID.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_rawMaterialID.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.txt_rawMaterialID.BorderThickness = 1;
            this.txt_rawMaterialID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_rawMaterialID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rawMaterialID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_rawMaterialID.isPassword = false;
            this.txt_rawMaterialID.Location = new System.Drawing.Point(156, 4);
            this.txt_rawMaterialID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_rawMaterialID.Name = "txt_rawMaterialID";
            this.txt_rawMaterialID.Size = new System.Drawing.Size(206, 31);
            this.txt_rawMaterialID.TabIndex = 21;
            this.txt_rawMaterialID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(3, 13);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(124, 19);
            this.bunifuCustomLabel1.TabIndex = 20;
            this.bunifuCustomLabel1.Text = "Raw Material ID";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(3, 124);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(135, 19);
            this.bunifuCustomLabel4.TabIndex = 24;
            this.bunifuCustomLabel4.Text = "Measurement Unit";
            // 
            // txt_rawMaterialName
            // 
            this.txt_rawMaterialName.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.txt_rawMaterialName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_rawMaterialName.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.txt_rawMaterialName.BorderThickness = 1;
            this.txt_rawMaterialName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_rawMaterialName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rawMaterialName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_rawMaterialName.isPassword = false;
            this.txt_rawMaterialName.Location = new System.Drawing.Point(156, 43);
            this.txt_rawMaterialName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_rawMaterialName.Name = "txt_rawMaterialName";
            this.txt_rawMaterialName.Size = new System.Drawing.Size(206, 31);
            this.txt_rawMaterialName.TabIndex = 23;
            this.txt_rawMaterialName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(3, 49);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(146, 19);
            this.bunifuCustomLabel2.TabIndex = 22;
            this.bunifuCustomLabel2.Text = "Raw Material Name";
            // 
            // lbl_AddNewProduct
            // 
            this.lbl_AddNewProduct.AutoSize = true;
            this.lbl_AddNewProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_AddNewProduct.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AddNewProduct.Location = new System.Drawing.Point(402, 335);
            this.lbl_AddNewProduct.Name = "lbl_AddNewProduct";
            this.lbl_AddNewProduct.Size = new System.Drawing.Size(194, 23);
            this.lbl_AddNewProduct.TabIndex = 30;
            this.lbl_AddNewProduct.Text = "Add New Raw Material";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(274, 23);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(245, 31);
            this.bunifuCustomLabel5.TabIndex = 28;
            this.bunifuCustomLabel5.Text = "RAW MATERIALS";
            // 
            // DG_RawMaterial
            // 
            this.DG_RawMaterial.AllowUserToAddRows = false;
            this.DG_RawMaterial.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DG_RawMaterial.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DG_RawMaterial.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DG_RawMaterial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DG_RawMaterial.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_RawMaterial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DG_RawMaterial.ColumnHeadersHeight = 30;
            this.DG_RawMaterial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C_RawMaterialID,
            this.C_RawMaterialName,
            this.C_Quantity,
            this.mUnit});
            this.DG_RawMaterial.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(153)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_RawMaterial.DefaultCellStyle = dataGridViewCellStyle3;
            this.DG_RawMaterial.DoubleBuffered = true;
            this.DG_RawMaterial.EnableHeadersVisualStyles = false;
            this.DG_RawMaterial.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.DG_RawMaterial.HeaderForeColor = System.Drawing.SystemColors.Control;
            this.DG_RawMaterial.Location = new System.Drawing.Point(54, 72);
            this.DG_RawMaterial.Name = "DG_RawMaterial";
            this.DG_RawMaterial.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_RawMaterial.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DG_RawMaterial.Size = new System.Drawing.Size(704, 226);
            this.DG_RawMaterial.TabIndex = 27;
            this.DG_RawMaterial.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_RawMaterial_CellClick);
            this.DG_RawMaterial.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DG_RawMaterial_CellMouseUp);
            // 
            // C_RawMaterialID
            // 
            this.C_RawMaterialID.FillWeight = 81.21828F;
            this.C_RawMaterialID.HeaderText = "Raw Material ID";
            this.C_RawMaterialID.Name = "C_RawMaterialID";
            this.C_RawMaterialID.ReadOnly = true;
            this.C_RawMaterialID.Width = 150;
            // 
            // C_RawMaterialName
            // 
            this.C_RawMaterialName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.C_RawMaterialName.FillWeight = 106.2606F;
            this.C_RawMaterialName.HeaderText = "Raw Material Name";
            this.C_RawMaterialName.Name = "C_RawMaterialName";
            // 
            // C_Quantity
            // 
            this.C_Quantity.FillWeight = 106.2606F;
            this.C_Quantity.HeaderText = "Quantity";
            this.C_Quantity.Name = "C_Quantity";
            this.C_Quantity.Width = 120;
            // 
            // mUnit
            // 
            this.mUnit.FillWeight = 106.2606F;
            this.mUnit.HeaderText = "Measurement Unit";
            this.mUnit.Name = "mUnit";
            this.mUnit.Width = 150;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(118, 48);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            // 
            // btn_addNewRawMat
            // 
            this.btn_addNewRawMat.BackColor = System.Drawing.SystemColors.Control;
            this.btn_addNewRawMat.Image = global::FinalProject2.Properties.Resources.icons8_add_new_100;
            this.btn_addNewRawMat.ImageActive = null;
            this.btn_addNewRawMat.Location = new System.Drawing.Point(602, 329);
            this.btn_addNewRawMat.Name = "btn_addNewRawMat";
            this.btn_addNewRawMat.Size = new System.Drawing.Size(50, 35);
            this.btn_addNewRawMat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_addNewRawMat.TabIndex = 31;
            this.btn_addNewRawMat.TabStop = false;
            this.btn_addNewRawMat.Zoom = 10;
            this.btn_addNewRawMat.Click += new System.EventHandler(this.btn_addNewRawMat_Click);
            // 
            // DG_RawStock
            // 
            this.DG_RawStock.AllowUserToAddRows = false;
            this.DG_RawStock.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DG_RawStock.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DG_RawStock.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DG_RawStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DG_RawStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_RawStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DG_RawStock.ColumnHeadersHeight = 30;
            this.DG_RawStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(153)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_RawStock.DefaultCellStyle = dataGridViewCellStyle7;
            this.DG_RawStock.DoubleBuffered = true;
            this.DG_RawStock.EnableHeadersVisualStyles = false;
            this.DG_RawStock.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.DG_RawStock.HeaderForeColor = System.Drawing.SystemColors.Control;
            this.DG_RawStock.Location = new System.Drawing.Point(46, 370);
            this.DG_RawStock.Name = "DG_RawStock";
            this.DG_RawStock.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_RawStock.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DG_RawStock.RowHeadersVisible = false;
            this.DG_RawStock.Size = new System.Drawing.Size(340, 243);
            this.DG_RawStock.TabIndex = 33;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 81.21828F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Location";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 106.2606F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.FillWeight = 106.2606F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Unit";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // lbl_r
            // 
            this.lbl_r.AutoSize = true;
            this.lbl_r.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_r.Location = new System.Drawing.Point(50, 345);
            this.lbl_r.Name = "lbl_r";
            this.lbl_r.Size = new System.Drawing.Size(104, 19);
            this.lbl_r.TabIndex = 35;
            this.lbl_r.Text = "Raw Material:";
            // 
            // lbl_RawMaterial
            // 
            this.lbl_RawMaterial.AutoSize = true;
            this.lbl_RawMaterial.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RawMaterial.Location = new System.Drawing.Point(156, 345);
            this.lbl_RawMaterial.Name = "lbl_RawMaterial";
            this.lbl_RawMaterial.Size = new System.Drawing.Size(0, 19);
            this.lbl_RawMaterial.TabIndex = 34;
            // 
            // ManageRawMaterials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 660);
            this.Controls.Add(this.lbl_r);
            this.Controls.Add(this.lbl_RawMaterial);
            this.Controls.Add(this.DG_RawStock);
            this.Controls.Add(this.panel_AddRaw);
            this.Controls.Add(this.btn_addNewRawMat);
            this.Controls.Add(this.lbl_AddNewProduct);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.DG_RawMaterial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageRawMaterials";
            this.Text = "ManageRawMaterials";
            this.Load += new System.EventHandler(this.ManageRawMaterials_Load);
            this.panel_AddRaw.ResumeLayout(false);
            this.panel_AddRaw.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_RawMaterial)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_addNewRawMat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_RawStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_MeasurementUnit;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_add;
        private System.Windows.Forms.Panel panel_AddRaw;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_cancel;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_rawMaterialID;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_rawMaterialName;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuImageButton btn_addNewRawMat;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_AddNewProduct;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DG_RawMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_RawMaterialID;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_RawMaterialName;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn mUnit;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_CancelUpdate;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_UpdateRawMat;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DG_RawStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label lbl_r;
        private System.Windows.Forms.Label lbl_RawMaterial;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
    }
}