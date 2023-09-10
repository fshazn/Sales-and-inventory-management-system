namespace FinalProject2
{
    partial class UpdateTransferRequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateTransferRequest));
            this.DG_UpdateTRItem = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.productid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cmb_UpdateTREstate = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_CancelTransferRequest = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_UpdateTR = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txt_UpdateTRQuantity = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.cmb_UpdateTRProduct = new System.Windows.Forms.ComboBox();
            this.txt_UpdateDescription = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.dtp_UpdateTRDate = new System.Windows.Forms.DateTimePicker();
            this.txt_UpdateTRID = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_UpdateTRProduct = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.DG_UpdateTRItem)).BeginInit();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DG_UpdateTRItem
            // 
            this.DG_UpdateTRItem.AllowUserToAddRows = false;
            this.DG_UpdateTRItem.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DG_UpdateTRItem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DG_UpdateTRItem.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DG_UpdateTRItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DG_UpdateTRItem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_UpdateTRItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DG_UpdateTRItem.ColumnHeadersHeight = 30;
            this.DG_UpdateTRItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productid,
            this.trid,
            this.productname,
            this.quantity,
            this.unit});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_UpdateTRItem.DefaultCellStyle = dataGridViewCellStyle3;
            this.DG_UpdateTRItem.DoubleBuffered = true;
            this.DG_UpdateTRItem.EnableHeadersVisualStyles = false;
            this.DG_UpdateTRItem.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.DG_UpdateTRItem.HeaderForeColor = System.Drawing.SystemColors.Control;
            this.DG_UpdateTRItem.Location = new System.Drawing.Point(407, 5);
            this.DG_UpdateTRItem.Name = "DG_UpdateTRItem";
            this.DG_UpdateTRItem.ReadOnly = true;
            this.DG_UpdateTRItem.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_UpdateTRItem.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DG_UpdateTRItem.RowHeadersVisible = false;
            this.DG_UpdateTRItem.Size = new System.Drawing.Size(346, 320);
            this.DG_UpdateTRItem.TabIndex = 64;
            this.DG_UpdateTRItem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_UpdateTRItem_CellClick);
            this.DG_UpdateTRItem.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DG_UpdateTRItem_CellMouseUp);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_UpdateTRProduct);
            this.panel1.Controls.Add(this.bunifuCustomLabel7);
            this.panel1.Controls.Add(this.bunifuCustomLabel8);
            this.panel1.Controls.Add(this.cmb_UpdateTREstate);
            this.panel1.Controls.Add(this.bunifuCustomLabel5);
            this.panel1.Controls.Add(this.btn_CancelTransferRequest);
            this.panel1.Controls.Add(this.btn_UpdateTR);
            this.panel1.Controls.Add(this.txt_UpdateTRQuantity);
            this.panel1.Controls.Add(this.cmb_UpdateTRProduct);
            this.panel1.Controls.Add(this.txt_UpdateDescription);
            this.panel1.Controls.Add(this.dtp_UpdateTRDate);
            this.panel1.Controls.Add(this.txt_UpdateTRID);
            this.panel1.Controls.Add(this.bunifuCustomLabel6);
            this.panel1.Controls.Add(this.bunifuCustomLabel4);
            this.panel1.Controls.Add(this.bunifuCustomLabel3);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Location = new System.Drawing.Point(8, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 322);
            this.panel1.TabIndex = 63;
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
            // cmb_UpdateTREstate
            // 
            this.cmb_UpdateTREstate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_UpdateTREstate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_UpdateTREstate.FormattingEnabled = true;
            this.cmb_UpdateTREstate.Location = new System.Drawing.Point(228, 40);
            this.cmb_UpdateTREstate.Name = "cmb_UpdateTREstate";
            this.cmb_UpdateTREstate.Size = new System.Drawing.Size(154, 27);
            this.cmb_UpdateTREstate.TabIndex = 48;
            this.cmb_UpdateTREstate.SelectedIndexChanged += new System.EventHandler(this.cmb_UpdateTREstate_SelectedIndexChanged);
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
            // 
            // btn_UpdateTR
            // 
            this.btn_UpdateTR.ActiveBorderThickness = 1;
            this.btn_UpdateTR.ActiveCornerRadius = 20;
            this.btn_UpdateTR.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_UpdateTR.ActiveForecolor = System.Drawing.Color.White;
            this.btn_UpdateTR.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_UpdateTR.BackColor = System.Drawing.SystemColors.Control;
            this.btn_UpdateTR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_UpdateTR.BackgroundImage")));
            this.btn_UpdateTR.ButtonText = "Update";
            this.btn_UpdateTR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_UpdateTR.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UpdateTR.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_UpdateTR.IdleBorderThickness = 1;
            this.btn_UpdateTR.IdleCornerRadius = 20;
            this.btn_UpdateTR.IdleFillColor = System.Drawing.Color.White;
            this.btn_UpdateTR.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_UpdateTR.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_UpdateTR.Location = new System.Drawing.Point(191, 288);
            this.btn_UpdateTR.Margin = new System.Windows.Forms.Padding(5);
            this.btn_UpdateTR.Name = "btn_UpdateTR";
            this.btn_UpdateTR.Size = new System.Drawing.Size(97, 31);
            this.btn_UpdateTR.TabIndex = 45;
            this.btn_UpdateTR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_UpdateTRQuantity
            // 
            this.txt_UpdateTRQuantity.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_UpdateTRQuantity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UpdateTRQuantity.Location = new System.Drawing.Point(228, 166);
            this.txt_UpdateTRQuantity.Name = "txt_UpdateTRQuantity";
            this.txt_UpdateTRQuantity.Size = new System.Drawing.Size(154, 27);
            this.txt_UpdateTRQuantity.TabIndex = 43;
            // 
            // cmb_UpdateTRProduct
            // 
            this.cmb_UpdateTRProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_UpdateTRProduct.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_UpdateTRProduct.FormattingEnabled = true;
            this.cmb_UpdateTRProduct.Location = new System.Drawing.Point(228, 103);
            this.cmb_UpdateTRProduct.Name = "cmb_UpdateTRProduct";
            this.cmb_UpdateTRProduct.Size = new System.Drawing.Size(154, 27);
            this.cmb_UpdateTRProduct.TabIndex = 42;
            this.cmb_UpdateTRProduct.SelectedIndexChanged += new System.EventHandler(this.cmb_UpdateTRProduct_SelectedIndexChanged);
            // 
            // txt_UpdateDescription
            // 
            this.txt_UpdateDescription.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_UpdateDescription.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UpdateDescription.Location = new System.Drawing.Point(7, 155);
            this.txt_UpdateDescription.Multiline = true;
            this.txt_UpdateDescription.Name = "txt_UpdateDescription";
            this.txt_UpdateDescription.Size = new System.Drawing.Size(200, 131);
            this.txt_UpdateDescription.TabIndex = 41;
            // 
            // dtp_UpdateTRDate
            // 
            this.dtp_UpdateTRDate.CustomFormat = "yyyy-mm-dd";
            this.dtp_UpdateTRDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_UpdateTRDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_UpdateTRDate.Location = new System.Drawing.Point(7, 103);
            this.dtp_UpdateTRDate.Name = "dtp_UpdateTRDate";
            this.dtp_UpdateTRDate.Size = new System.Drawing.Size(200, 27);
            this.dtp_UpdateTRDate.TabIndex = 40;
            // 
            // txt_UpdateTRID
            // 
            this.txt_UpdateTRID.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_UpdateTRID.Enabled = false;
            this.txt_UpdateTRID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UpdateTRID.Location = new System.Drawing.Point(7, 40);
            this.txt_UpdateTRID.Name = "txt_UpdateTRID";
            this.txt_UpdateTRID.Size = new System.Drawing.Size(200, 27);
            this.txt_UpdateTRID.TabIndex = 39;
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
            // btn_UpdateTRProduct
            // 
            this.btn_UpdateTRProduct.ActiveBorderThickness = 1;
            this.btn_UpdateTRProduct.ActiveCornerRadius = 20;
            this.btn_UpdateTRProduct.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_UpdateTRProduct.ActiveForecolor = System.Drawing.Color.White;
            this.btn_UpdateTRProduct.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_UpdateTRProduct.BackColor = System.Drawing.SystemColors.Control;
            this.btn_UpdateTRProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_UpdateTRProduct.BackgroundImage")));
            this.btn_UpdateTRProduct.ButtonText = "Update Product";
            this.btn_UpdateTRProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_UpdateTRProduct.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UpdateTRProduct.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_UpdateTRProduct.IdleBorderThickness = 1;
            this.btn_UpdateTRProduct.IdleCornerRadius = 20;
            this.btn_UpdateTRProduct.IdleFillColor = System.Drawing.Color.White;
            this.btn_UpdateTRProduct.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_UpdateTRProduct.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_UpdateTRProduct.Location = new System.Drawing.Point(228, 201);
            this.btn_UpdateTRProduct.Margin = new System.Windows.Forms.Padding(5);
            this.btn_UpdateTRProduct.Name = "btn_UpdateTRProduct";
            this.btn_UpdateTRProduct.Size = new System.Drawing.Size(154, 31);
            this.btn_UpdateTRProduct.TabIndex = 51;
            this.btn_UpdateTRProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_UpdateTRProduct.Click += new System.EventHandler(this.btn_UpdateTRProduct_Click);
            // 
            // UpdateTransferRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 335);
            this.Controls.Add(this.DG_UpdateTRItem);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateTransferRequest";
            this.Text = "UpdateTransferRequest";
            this.Load += new System.EventHandler(this.UpdateTransferRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_UpdateTRItem)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid DG_UpdateTRItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn productid;
        private System.Windows.Forms.DataGridViewTextBoxColumn trid;
        private System.Windows.Forms.DataGridViewTextBoxColumn productname;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private System.Windows.Forms.ComboBox cmb_UpdateTREstate;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_CancelTransferRequest;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_UpdateTRQuantity;
        private System.Windows.Forms.ComboBox cmb_UpdateTRProduct;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_UpdateDescription;
        private System.Windows.Forms.DateTimePicker dtp_UpdateTRDate;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_UpdateTRID;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_UpdateTR;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_UpdateTRProduct;
    }
}