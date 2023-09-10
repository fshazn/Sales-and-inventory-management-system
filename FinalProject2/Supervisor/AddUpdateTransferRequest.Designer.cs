namespace FinalProject2
{
    partial class AddUpdateTransferRequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUpdateTransferRequest));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cmb_Estate = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_CancelTransferRequest = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_CreateTR = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_addTrItem = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txt_Quantity = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.cmb_Product = new System.Windows.Forms.ComboBox();
            this.txt_Description = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.dtp_RTDate = new System.Windows.Forms.DateTimePicker();
            this.txt_TRID = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DG_TrItem = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.productid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_TrItem)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bunifuCustomLabel7);
            this.panel1.Controls.Add(this.bunifuCustomLabel8);
            this.panel1.Controls.Add(this.cmb_Estate);
            this.panel1.Controls.Add(this.bunifuCustomLabel5);
            this.panel1.Controls.Add(this.btn_CancelTransferRequest);
            this.panel1.Controls.Add(this.btn_CreateTR);
            this.panel1.Controls.Add(this.btn_addTrItem);
            this.panel1.Controls.Add(this.txt_Quantity);
            this.panel1.Controls.Add(this.cmb_Product);
            this.panel1.Controls.Add(this.txt_Description);
            this.panel1.Controls.Add(this.dtp_RTDate);
            this.panel1.Controls.Add(this.txt_TRID);
            this.panel1.Controls.Add(this.bunifuCustomLabel6);
            this.panel1.Controls.Add(this.bunifuCustomLabel4);
            this.panel1.Controls.Add(this.bunifuCustomLabel3);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Location = new System.Drawing.Point(12, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 322);
            this.panel1.TabIndex = 39;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(224, 11);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(103, 19);
            this.bunifuCustomLabel7.TabIndex = 50;
            this.bunifuCustomLabel7.Text = "Request From";
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(4, 11);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(141, 19);
            this.bunifuCustomLabel8.TabIndex = 49;
            this.bunifuCustomLabel8.Text = "Transfer Request ID";
            // 
            // cmb_Estate
            // 
            this.cmb_Estate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Estate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Estate.FormattingEnabled = true;
            this.cmb_Estate.Location = new System.Drawing.Point(228, 40);
            this.cmb_Estate.Name = "cmb_Estate";
            this.cmb_Estate.Size = new System.Drawing.Size(154, 27);
            this.cmb_Estate.TabIndex = 48;
            this.cmb_Estate.SelectedIndexChanged += new System.EventHandler(this.cmb_Estate_SelectedIndexChanged);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(224, -19);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(103, 19);
            this.bunifuCustomLabel5.TabIndex = 47;
            this.bunifuCustomLabel5.Text = "Request From";
            // 
            // btn_CancelTransferRequest
            // 
            this.btn_CancelTransferRequest.ActiveBorderThickness = 1;
            this.btn_CancelTransferRequest.ActiveCornerRadius = 20;
            this.btn_CancelTransferRequest.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_CancelTransferRequest.ActiveForecolor = System.Drawing.Color.White;
            this.btn_CancelTransferRequest.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_CancelTransferRequest.BackColor = System.Drawing.SystemColors.Control;
            this.btn_CancelTransferRequest.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_CancelTransferRequest.BackgroundImage")));
            this.btn_CancelTransferRequest.ButtonText = "Cancel";
            this.btn_CancelTransferRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CancelTransferRequest.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelTransferRequest.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_CancelTransferRequest.IdleBorderThickness = 1;
            this.btn_CancelTransferRequest.IdleCornerRadius = 20;
            this.btn_CancelTransferRequest.IdleFillColor = System.Drawing.Color.White;
            this.btn_CancelTransferRequest.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_CancelTransferRequest.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_CancelTransferRequest.Location = new System.Drawing.Point(294, 288);
            this.btn_CancelTransferRequest.Margin = new System.Windows.Forms.Padding(5);
            this.btn_CancelTransferRequest.Name = "btn_CancelTransferRequest";
            this.btn_CancelTransferRequest.Size = new System.Drawing.Size(97, 31);
            this.btn_CancelTransferRequest.TabIndex = 46;
            this.btn_CancelTransferRequest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_CancelTransferRequest.Click += new System.EventHandler(this.btn_CancelTransferRequest_Click);
            // 
            // btn_CreateTR
            // 
            this.btn_CreateTR.ActiveBorderThickness = 1;
            this.btn_CreateTR.ActiveCornerRadius = 20;
            this.btn_CreateTR.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_CreateTR.ActiveForecolor = System.Drawing.Color.White;
            this.btn_CreateTR.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_CreateTR.BackColor = System.Drawing.SystemColors.Control;
            this.btn_CreateTR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_CreateTR.BackgroundImage")));
            this.btn_CreateTR.ButtonText = "Create";
            this.btn_CreateTR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CreateTR.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CreateTR.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_CreateTR.IdleBorderThickness = 1;
            this.btn_CreateTR.IdleCornerRadius = 20;
            this.btn_CreateTR.IdleFillColor = System.Drawing.Color.White;
            this.btn_CreateTR.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_CreateTR.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_CreateTR.Location = new System.Drawing.Point(191, 288);
            this.btn_CreateTR.Margin = new System.Windows.Forms.Padding(5);
            this.btn_CreateTR.Name = "btn_CreateTR";
            this.btn_CreateTR.Size = new System.Drawing.Size(97, 31);
            this.btn_CreateTR.TabIndex = 45;
            this.btn_CreateTR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_CreateTR.Click += new System.EventHandler(this.btn_CreateTR_Click);
            // 
            // btn_addTrItem
            // 
            this.btn_addTrItem.ActiveBorderThickness = 1;
            this.btn_addTrItem.ActiveCornerRadius = 20;
            this.btn_addTrItem.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_addTrItem.ActiveForecolor = System.Drawing.Color.White;
            this.btn_addTrItem.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_addTrItem.BackColor = System.Drawing.SystemColors.Control;
            this.btn_addTrItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_addTrItem.BackgroundImage")));
            this.btn_addTrItem.ButtonText = "Add Product";
            this.btn_addTrItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addTrItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addTrItem.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_addTrItem.IdleBorderThickness = 1;
            this.btn_addTrItem.IdleCornerRadius = 20;
            this.btn_addTrItem.IdleFillColor = System.Drawing.Color.White;
            this.btn_addTrItem.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_addTrItem.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_addTrItem.Location = new System.Drawing.Point(228, 201);
            this.btn_addTrItem.Margin = new System.Windows.Forms.Padding(5);
            this.btn_addTrItem.Name = "btn_addTrItem";
            this.btn_addTrItem.Size = new System.Drawing.Size(129, 31);
            this.btn_addTrItem.TabIndex = 44;
            this.btn_addTrItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_addTrItem.Click += new System.EventHandler(this.btn_addTrItem_Click);
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_Quantity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Quantity.Location = new System.Drawing.Point(228, 166);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(154, 27);
            this.txt_Quantity.TabIndex = 43;
            // 
            // cmb_Product
            // 
            this.cmb_Product.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Product.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Product.FormattingEnabled = true;
            this.cmb_Product.Location = new System.Drawing.Point(228, 103);
            this.cmb_Product.Name = "cmb_Product";
            this.cmb_Product.Size = new System.Drawing.Size(154, 27);
            this.cmb_Product.TabIndex = 42;
            this.cmb_Product.SelectedIndexChanged += new System.EventHandler(this.cmb_Product_SelectedIndexChanged);
            // 
            // txt_Description
            // 
            this.txt_Description.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_Description.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Description.Location = new System.Drawing.Point(7, 155);
            this.txt_Description.Multiline = true;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(200, 131);
            this.txt_Description.TabIndex = 41;
            // 
            // dtp_RTDate
            // 
            this.dtp_RTDate.CustomFormat = "dd-MM-yyyy";
            this.dtp_RTDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_RTDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_RTDate.Location = new System.Drawing.Point(7, 103);
            this.dtp_RTDate.Name = "dtp_RTDate";
            this.dtp_RTDate.Size = new System.Drawing.Size(200, 27);
            this.dtp_RTDate.TabIndex = 40;
            this.dtp_RTDate.Value = new System.DateTime(2022, 6, 16, 14, 2, 8, 0);
            // 
            // txt_TRID
            // 
            this.txt_TRID.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_TRID.Enabled = false;
            this.txt_TRID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TRID.Location = new System.Drawing.Point(7, 40);
            this.txt_TRID.Name = "txt_TRID";
            this.txt_TRID.Size = new System.Drawing.Size(200, 27);
            this.txt_TRID.TabIndex = 39;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(224, 136);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(69, 19);
            this.bunifuCustomLabel6.TabIndex = 38;
            this.bunifuCustomLabel6.Text = "Quantity";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(224, 80);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(64, 19);
            this.bunifuCustomLabel4.TabIndex = 37;
            this.bunifuCustomLabel4.Text = "Product";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(3, 133);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(86, 19);
            this.bunifuCustomLabel3.TabIndex = 36;
            this.bunifuCustomLabel3.Text = "Description";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(3, 73);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(159, 19);
            this.bunifuCustomLabel2.TabIndex = 35;
            this.bunifuCustomLabel2.Text = "Transfer Request Date";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(3, -19);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(141, 19);
            this.bunifuCustomLabel1.TabIndex = 34;
            this.bunifuCustomLabel1.Text = "Transfer Request ID";
            // 
            // DG_TrItem
            // 
            this.DG_TrItem.AllowUserToAddRows = false;
            this.DG_TrItem.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DG_TrItem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DG_TrItem.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DG_TrItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DG_TrItem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_TrItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DG_TrItem.ColumnHeadersHeight = 30;
            this.DG_TrItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productid,
            this.trid,
            this.productname,
            this.quantity,
            this.unit});
            this.DG_TrItem.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_TrItem.DefaultCellStyle = dataGridViewCellStyle7;
            this.DG_TrItem.DoubleBuffered = true;
            this.DG_TrItem.EnableHeadersVisualStyles = false;
            this.DG_TrItem.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.DG_TrItem.HeaderForeColor = System.Drawing.SystemColors.Control;
            this.DG_TrItem.Location = new System.Drawing.Point(411, 4);
            this.DG_TrItem.Name = "DG_TrItem";
            this.DG_TrItem.ReadOnly = true;
            this.DG_TrItem.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_TrItem.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DG_TrItem.RowHeadersVisible = false;
            this.DG_TrItem.Size = new System.Drawing.Size(346, 320);
            this.DG_TrItem.TabIndex = 62;
            this.DG_TrItem.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DG_TrItem_CellMouseUp);
            // 
            // productid
            // 
            this.productid.FillWeight = 81.21828F;
            this.productid.HeaderText = "ProductID";
            this.productid.Name = "productid";
            this.productid.ReadOnly = true;
            this.productid.Width = 90;
            // 
            // trid
            // 
            this.trid.HeaderText = "TRID";
            this.trid.Name = "trid";
            this.trid.ReadOnly = true;
            this.trid.Visible = false;
            // 
            // productname
            // 
            this.productname.FillWeight = 106.2606F;
            this.productname.HeaderText = "Product Name";
            this.productname.Name = "productname";
            this.productname.ReadOnly = true;
            this.productname.Width = 120;
            // 
            // quantity
            // 
            this.quantity.FillWeight = 106.2606F;
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Width = 80;
            // 
            // unit
            // 
            this.unit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.unit.HeaderText = "Unit";
            this.unit.Name = "unit";
            this.unit.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(118, 26);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // AddUpdateTransferRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 335);
            this.Controls.Add(this.DG_TrItem);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddUpdateTransferRequest";
            this.Text = "AddUpdateTransferRequest";
            this.Load += new System.EventHandler(this.AddUpdateTransferRequest_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_TrItem)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_CreateTR;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_addTrItem;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_Quantity;
        private System.Windows.Forms.ComboBox cmb_Product;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_Description;
        private System.Windows.Forms.DateTimePicker dtp_RTDate;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_TRID;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_CancelTransferRequest;
        private System.Windows.Forms.ComboBox cmb_Estate;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DG_TrItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn productid;
        private System.Windows.Forms.DataGridViewTextBoxColumn trid;
        private System.Windows.Forms.DataGridViewTextBoxColumn productname;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
    }
}