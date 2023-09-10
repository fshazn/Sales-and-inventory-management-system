namespace FinalProject2
{
    partial class ProductScreen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductScreen));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DG_Product = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.C_ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_AddNewProduct = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_addNewProduct = new Bunifu.Framework.UI.BunifuImageButton();
            this.txt_productID = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_productName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel_AddProduct = new System.Windows.Forms.Panel();
            this.btn_CancelUpdate = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_Update = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txt_Quantity = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cmb_Munit = new System.Windows.Forms.ComboBox();
            this.btn_cancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_add = new Bunifu.Framework.UI.BunifuThinButton2();
            this.DG_ProductStock = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_Product = new System.Windows.Forms.Label();
            this.lbl_p = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_addNewProduct)).BeginInit();
            this.panel_AddProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_ProductStock)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DG_Product
            // 
            this.DG_Product.AllowUserToAddRows = false;
            this.DG_Product.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DG_Product.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DG_Product.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DG_Product.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DG_Product.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_Product.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DG_Product.ColumnHeadersHeight = 30;
            this.DG_Product.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C_ProductID,
            this.C_ProductName,
            this.C_Quantity,
            this.mUnit});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(153)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_Product.DefaultCellStyle = dataGridViewCellStyle3;
            this.DG_Product.DoubleBuffered = true;
            this.DG_Product.EnableHeadersVisualStyles = false;
            this.DG_Product.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.DG_Product.HeaderForeColor = System.Drawing.SystemColors.Control;
            this.DG_Product.Location = new System.Drawing.Point(59, 68);
            this.DG_Product.Name = "DG_Product";
            this.DG_Product.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_Product.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DG_Product.Size = new System.Drawing.Size(704, 226);
            this.DG_Product.TabIndex = 0;
            this.DG_Product.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Product_CellClick);
            this.DG_Product.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DG_Product_CellMouseUp);
            // 
            // C_ProductID
            // 
            this.C_ProductID.FillWeight = 81.21828F;
            this.C_ProductID.HeaderText = "Product ID";
            this.C_ProductID.Name = "C_ProductID";
            this.C_ProductID.ReadOnly = true;
            this.C_ProductID.Width = 117;
            // 
            // C_ProductName
            // 
            this.C_ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.C_ProductName.FillWeight = 106.2606F;
            this.C_ProductName.HeaderText = "Product Name";
            this.C_ProductName.Name = "C_ProductName";
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
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(327, 25);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(165, 31);
            this.bunifuCustomLabel5.TabIndex = 16;
            this.bunifuCustomLabel5.Text = "PRODUCTS";
            // 
            // lbl_AddNewProduct
            // 
            this.lbl_AddNewProduct.AutoSize = true;
            this.lbl_AddNewProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_AddNewProduct.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AddNewProduct.Location = new System.Drawing.Point(562, 329);
            this.lbl_AddNewProduct.Name = "lbl_AddNewProduct";
            this.lbl_AddNewProduct.Size = new System.Drawing.Size(149, 23);
            this.lbl_AddNewProduct.TabIndex = 18;
            this.lbl_AddNewProduct.Text = "Add New Product";
            // 
            // btn_addNewProduct
            // 
            this.btn_addNewProduct.BackColor = System.Drawing.SystemColors.Control;
            this.btn_addNewProduct.Image = global::FinalProject2.Properties.Resources.icons8_add_new_100;
            this.btn_addNewProduct.ImageActive = null;
            this.btn_addNewProduct.Location = new System.Drawing.Point(716, 323);
            this.btn_addNewProduct.Name = "btn_addNewProduct";
            this.btn_addNewProduct.Size = new System.Drawing.Size(50, 35);
            this.btn_addNewProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_addNewProduct.TabIndex = 19;
            this.btn_addNewProduct.TabStop = false;
            this.btn_addNewProduct.Zoom = 10;
            this.btn_addNewProduct.Click += new System.EventHandler(this.btn_addNewProduct_Click);
            // 
            // txt_productID
            // 
            this.txt_productID.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.txt_productID.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_productID.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.txt_productID.BorderThickness = 1;
            this.txt_productID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_productID.Enabled = false;
            this.txt_productID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_productID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_productID.isPassword = false;
            this.txt_productID.Location = new System.Drawing.Point(140, 4);
            this.txt_productID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_productID.Name = "txt_productID";
            this.txt_productID.Size = new System.Drawing.Size(209, 31);
            this.txt_productID.TabIndex = 21;
            this.txt_productID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(3, 13);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(82, 19);
            this.bunifuCustomLabel1.TabIndex = 20;
            this.bunifuCustomLabel1.Text = "Product ID";
            // 
            // txt_productName
            // 
            this.txt_productName.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.txt_productName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_productName.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.txt_productName.BorderThickness = 1;
            this.txt_productName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_productName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_productName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_productName.isPassword = false;
            this.txt_productName.Location = new System.Drawing.Point(140, 43);
            this.txt_productName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_productName.Name = "txt_productName";
            this.txt_productName.Size = new System.Drawing.Size(209, 31);
            this.txt_productName.TabIndex = 23;
            this.txt_productName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(3, 49);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(104, 19);
            this.bunifuCustomLabel2.TabIndex = 22;
            this.bunifuCustomLabel2.Text = "Product Name";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(3, 120);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(135, 19);
            this.bunifuCustomLabel4.TabIndex = 24;
            this.bunifuCustomLabel4.Text = "Measurement Unit";
            // 
            // panel_AddProduct
            // 
            this.panel_AddProduct.Controls.Add(this.btn_CancelUpdate);
            this.panel_AddProduct.Controls.Add(this.btn_Update);
            this.panel_AddProduct.Controls.Add(this.txt_Quantity);
            this.panel_AddProduct.Controls.Add(this.bunifuCustomLabel3);
            this.panel_AddProduct.Controls.Add(this.cmb_Munit);
            this.panel_AddProduct.Controls.Add(this.btn_cancel);
            this.panel_AddProduct.Controls.Add(this.btn_add);
            this.panel_AddProduct.Controls.Add(this.txt_productID);
            this.panel_AddProduct.Controls.Add(this.bunifuCustomLabel1);
            this.panel_AddProduct.Controls.Add(this.bunifuCustomLabel4);
            this.panel_AddProduct.Controls.Add(this.txt_productName);
            this.panel_AddProduct.Controls.Add(this.bunifuCustomLabel2);
            this.panel_AddProduct.Location = new System.Drawing.Point(402, 366);
            this.panel_AddProduct.Name = "panel_AddProduct";
            this.panel_AddProduct.Size = new System.Drawing.Size(366, 243);
            this.panel_AddProduct.TabIndex = 26;
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
            this.btn_CancelUpdate.Location = new System.Drawing.Point(184, 207);
            this.btn_CancelUpdate.Margin = new System.Windows.Forms.Padding(5);
            this.btn_CancelUpdate.Name = "btn_CancelUpdate";
            this.btn_CancelUpdate.Size = new System.Drawing.Size(105, 31);
            this.btn_CancelUpdate.TabIndex = 32;
            this.btn_CancelUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_CancelUpdate.Click += new System.EventHandler(this.btn_CancelUpdate_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.ActiveBorderThickness = 1;
            this.btn_Update.ActiveCornerRadius = 20;
            this.btn_Update.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_Update.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Update.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Update.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Update.BackgroundImage")));
            this.btn_Update.ButtonText = "Update";
            this.btn_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Update.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_Update.IdleBorderThickness = 1;
            this.btn_Update.IdleCornerRadius = 20;
            this.btn_Update.IdleFillColor = System.Drawing.Color.White;
            this.btn_Update.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_Update.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Update.Location = new System.Drawing.Point(51, 207);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(105, 31);
            this.btn_Update.TabIndex = 31;
            this.btn_Update.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.txt_Quantity.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Quantity.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.txt_Quantity.BorderThickness = 1;
            this.txt_Quantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Quantity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Quantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Quantity.isPassword = false;
            this.txt_Quantity.Location = new System.Drawing.Point(140, 82);
            this.txt_Quantity.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(209, 31);
            this.txt_Quantity.TabIndex = 30;
            this.txt_Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(3, 88);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(67, 19);
            this.bunifuCustomLabel3.TabIndex = 29;
            this.bunifuCustomLabel3.Text = "Quantity";
            // 
            // cmb_Munit
            // 
            this.cmb_Munit.BackColor = System.Drawing.SystemColors.Control;
            this.cmb_Munit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Munit.Items.AddRange(new object[] {
            "Kg",
            "Packs"});
            this.cmb_Munit.Location = new System.Drawing.Point(140, 120);
            this.cmb_Munit.Name = "cmb_Munit";
            this.cmb_Munit.Size = new System.Drawing.Size(209, 27);
            this.cmb_Munit.TabIndex = 28;
            this.cmb_Munit.Text = "Select";
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
            this.btn_cancel.Location = new System.Drawing.Point(184, 207);
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
            this.btn_add.Location = new System.Drawing.Point(51, 207);
            this.btn_add.Margin = new System.Windows.Forms.Padding(5);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(105, 31);
            this.btn_add.TabIndex = 26;
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // DG_ProductStock
            // 
            this.DG_ProductStock.AllowUserToAddRows = false;
            this.DG_ProductStock.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DG_ProductStock.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DG_ProductStock.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DG_ProductStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DG_ProductStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_ProductStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DG_ProductStock.ColumnHeadersHeight = 30;
            this.DG_ProductStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.DG_ProductStock.DefaultCellStyle = dataGridViewCellStyle7;
            this.DG_ProductStock.DoubleBuffered = true;
            this.DG_ProductStock.EnableHeadersVisualStyles = false;
            this.DG_ProductStock.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.DG_ProductStock.HeaderForeColor = System.Drawing.SystemColors.Control;
            this.DG_ProductStock.Location = new System.Drawing.Point(56, 366);
            this.DG_ProductStock.Name = "DG_ProductStock";
            this.DG_ProductStock.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_ProductStock.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DG_ProductStock.RowHeadersVisible = false;
            this.DG_ProductStock.Size = new System.Drawing.Size(340, 243);
            this.DG_ProductStock.TabIndex = 27;
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
            // lbl_Product
            // 
            this.lbl_Product.AutoSize = true;
            this.lbl_Product.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product.Location = new System.Drawing.Point(129, 329);
            this.lbl_Product.Name = "lbl_Product";
            this.lbl_Product.Size = new System.Drawing.Size(0, 19);
            this.lbl_Product.TabIndex = 28;
            // 
            // lbl_p
            // 
            this.lbl_p.AutoSize = true;
            this.lbl_p.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_p.Location = new System.Drawing.Point(55, 329);
            this.lbl_p.Name = "lbl_p";
            this.lbl_p.Size = new System.Drawing.Size(68, 19);
            this.lbl_p.TabIndex = 29;
            this.lbl_p.Text = "Product:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.removeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "Update";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // ProductScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 660);
            this.Controls.Add(this.lbl_p);
            this.Controls.Add(this.lbl_Product);
            this.Controls.Add(this.DG_ProductStock);
            this.Controls.Add(this.panel_AddProduct);
            this.Controls.Add(this.btn_addNewProduct);
            this.Controls.Add(this.lbl_AddNewProduct);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.DG_Product);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductScreen";
            this.Text = "ProductScreen";
            this.Load += new System.EventHandler(this.ProductScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_addNewProduct)).EndInit();
            this.panel_AddProduct.ResumeLayout(false);
            this.panel_AddProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_ProductStock)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid DG_Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn mUnit;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_AddNewProduct;
        private Bunifu.Framework.UI.BunifuImageButton btn_addNewProduct;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_productID;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_productName;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.Panel panel_AddProduct;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_add;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_cancel;
        private System.Windows.Forms.ComboBox cmb_Munit;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Quantity;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DG_ProductStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label lbl_Product;
        private System.Windows.Forms.Label lbl_p;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_CancelUpdate;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Update;
    }
}