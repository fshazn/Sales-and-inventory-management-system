namespace FinalProject2
{
    partial class AddUpdateInvoice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUpdateInvoice));
            this.txt_total = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DG_InvoiceItem = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txt_UnitPrice = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cmb_RawMaterial = new System.Windows.Forms.ComboBox();
            this.btn_AddItem = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_SaveInvoice = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txt_Quantity = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cmb_DeliveryLocation = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_comment = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cmb_Supplier = new System.Windows.Forms.ComboBox();
            this.dtp_Invoice = new System.Windows.Forms.DateTimePicker();
            this.txt_InvoiceID = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_PONumber = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.C_TransferRequestID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_TransferRequestDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DG_InvoiceItem)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_total
            // 
            this.txt_total.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_total.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.Location = new System.Drawing.Point(592, 432);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(154, 27);
            this.txt_total.TabIndex = 111;
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(519, 435);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(43, 19);
            this.bunifuCustomLabel9.TabIndex = 110;
            this.bunifuCustomLabel9.Text = "Total";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(20, 149);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(100, 19);
            this.bunifuCustomLabel3.TabIndex = 105;
            this.bunifuCustomLabel3.Text = "Raw Material";
            // 
            // DG_InvoiceItem
            // 
            this.DG_InvoiceItem.AllowUserToAddRows = false;
            this.DG_InvoiceItem.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DG_InvoiceItem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DG_InvoiceItem.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DG_InvoiceItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DG_InvoiceItem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_InvoiceItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DG_InvoiceItem.ColumnHeadersHeight = 30;
            this.DG_InvoiceItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C_TransferRequestID,
            this.invoiceId,
            this.Column4,
            this.C_TransferRequestDate,
            this.Column3,
            this.dataGridViewTextBoxColumn1,
            this.Column1,
            this.Column2});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_InvoiceItem.DefaultCellStyle = dataGridViewCellStyle3;
            this.DG_InvoiceItem.DoubleBuffered = true;
            this.DG_InvoiceItem.EnableHeadersVisualStyles = false;
            this.DG_InvoiceItem.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.DG_InvoiceItem.HeaderForeColor = System.Drawing.SystemColors.Control;
            this.DG_InvoiceItem.Location = new System.Drawing.Point(12, 228);
            this.DG_InvoiceItem.Name = "DG_InvoiceItem";
            this.DG_InvoiceItem.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_InvoiceItem.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DG_InvoiceItem.RowHeadersVisible = false;
            this.DG_InvoiceItem.Size = new System.Drawing.Size(736, 179);
            this.DG_InvoiceItem.TabIndex = 109;
            // 
            // txt_UnitPrice
            // 
            this.txt_UnitPrice.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_UnitPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UnitPrice.Location = new System.Drawing.Point(159, 189);
            this.txt_UnitPrice.Name = "txt_UnitPrice";
            this.txt_UnitPrice.Size = new System.Drawing.Size(154, 27);
            this.txt_UnitPrice.TabIndex = 108;
            this.txt_UnitPrice.Leave += new System.EventHandler(this.txt_UnitPrice_Leave);
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(20, 192);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(76, 19);
            this.bunifuCustomLabel7.TabIndex = 107;
            this.bunifuCustomLabel7.Text = "Unit Price";
            // 
            // cmb_RawMaterial
            // 
            this.cmb_RawMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_RawMaterial.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_RawMaterial.FormattingEnabled = true;
            this.cmb_RawMaterial.Location = new System.Drawing.Point(159, 145);
            this.cmb_RawMaterial.Name = "cmb_RawMaterial";
            this.cmb_RawMaterial.Size = new System.Drawing.Size(154, 27);
            this.cmb_RawMaterial.TabIndex = 106;
            this.cmb_RawMaterial.SelectedIndexChanged += new System.EventHandler(this.cmb_RawMaterial_SelectedIndexChanged_1);
            // 
            // btn_AddItem
            // 
            this.btn_AddItem.ActiveBorderThickness = 1;
            this.btn_AddItem.ActiveCornerRadius = 20;
            this.btn_AddItem.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_AddItem.ActiveForecolor = System.Drawing.Color.White;
            this.btn_AddItem.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_AddItem.BackColor = System.Drawing.SystemColors.Control;
            this.btn_AddItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_AddItem.BackgroundImage")));
            this.btn_AddItem.ButtonText = "Add";
            this.btn_AddItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddItem.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_AddItem.IdleBorderThickness = 1;
            this.btn_AddItem.IdleCornerRadius = 20;
            this.btn_AddItem.IdleFillColor = System.Drawing.Color.White;
            this.btn_AddItem.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_AddItem.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_AddItem.Location = new System.Drawing.Point(641, 189);
            this.btn_AddItem.Margin = new System.Windows.Forms.Padding(5);
            this.btn_AddItem.Name = "btn_AddItem";
            this.btn_AddItem.Size = new System.Drawing.Size(105, 31);
            this.btn_AddItem.TabIndex = 103;
            this.btn_AddItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_AddItem.Click += new System.EventHandler(this.btn_AddItem_Click);
            // 
            // btn_SaveInvoice
            // 
            this.btn_SaveInvoice.ActiveBorderThickness = 1;
            this.btn_SaveInvoice.ActiveCornerRadius = 20;
            this.btn_SaveInvoice.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_SaveInvoice.ActiveForecolor = System.Drawing.Color.White;
            this.btn_SaveInvoice.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_SaveInvoice.BackColor = System.Drawing.SystemColors.Control;
            this.btn_SaveInvoice.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_SaveInvoice.BackgroundImage")));
            this.btn_SaveInvoice.ButtonText = "Save";
            this.btn_SaveInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SaveInvoice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveInvoice.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_SaveInvoice.IdleBorderThickness = 1;
            this.btn_SaveInvoice.IdleCornerRadius = 20;
            this.btn_SaveInvoice.IdleFillColor = System.Drawing.Color.White;
            this.btn_SaveInvoice.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_SaveInvoice.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_SaveInvoice.Location = new System.Drawing.Point(643, 480);
            this.btn_SaveInvoice.Margin = new System.Windows.Forms.Padding(5);
            this.btn_SaveInvoice.Name = "btn_SaveInvoice";
            this.btn_SaveInvoice.Size = new System.Drawing.Size(105, 31);
            this.btn_SaveInvoice.TabIndex = 104;
            this.btn_SaveInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_SaveInvoice.Click += new System.EventHandler(this.btn_SaveInvoice_Click);
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_Quantity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Quantity.Location = new System.Drawing.Point(420, 189);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(154, 27);
            this.txt_Quantity.TabIndex = 102;
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(347, 192);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(69, 19);
            this.bunifuCustomLabel8.TabIndex = 101;
            this.bunifuCustomLabel8.Text = "Quantity";
            // 
            // cmb_DeliveryLocation
            // 
            this.cmb_DeliveryLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_DeliveryLocation.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_DeliveryLocation.FormattingEnabled = true;
            this.cmb_DeliveryLocation.Location = new System.Drawing.Point(159, 103);
            this.cmb_DeliveryLocation.Name = "cmb_DeliveryLocation";
            this.cmb_DeliveryLocation.Size = new System.Drawing.Size(154, 27);
            this.cmb_DeliveryLocation.TabIndex = 100;
            this.cmb_DeliveryLocation.SelectedIndexChanged += new System.EventHandler(this.cmb_DeliveryLocation_SelectedIndexChanged_1);
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(20, 106);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(127, 19);
            this.bunifuCustomLabel6.TabIndex = 99;
            this.bunifuCustomLabel6.Text = "Delivery Location";
            // 
            // txt_comment
            // 
            this.txt_comment.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_comment.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_comment.Location = new System.Drawing.Point(12, 432);
            this.txt_comment.Multiline = true;
            this.txt_comment.Name = "txt_comment";
            this.txt_comment.Size = new System.Drawing.Size(200, 79);
            this.txt_comment.TabIndex = 98;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(12, 410);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(75, 19);
            this.bunifuCustomLabel5.TabIndex = 97;
            this.bunifuCustomLabel5.Text = "Comment";
            // 
            // cmb_Supplier
            // 
            this.cmb_Supplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Supplier.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Supplier.FormattingEnabled = true;
            this.cmb_Supplier.Location = new System.Drawing.Point(159, 62);
            this.cmb_Supplier.Name = "cmb_Supplier";
            this.cmb_Supplier.Size = new System.Drawing.Size(154, 27);
            this.cmb_Supplier.TabIndex = 96;
            this.cmb_Supplier.SelectedIndexChanged += new System.EventHandler(this.cmb_Supplier_SelectedIndexChanged_1);
            // 
            // dtp_Invoice
            // 
            this.dtp_Invoice.CustomFormat = "dd-MM-yyyy";
            this.dtp_Invoice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Invoice.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Invoice.Location = new System.Drawing.Point(546, 62);
            this.dtp_Invoice.Name = "dtp_Invoice";
            this.dtp_Invoice.Size = new System.Drawing.Size(154, 27);
            this.dtp_Invoice.TabIndex = 95;
            // 
            // txt_InvoiceID
            // 
            this.txt_InvoiceID.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_InvoiceID.Enabled = false;
            this.txt_InvoiceID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_InvoiceID.Location = new System.Drawing.Point(159, 22);
            this.txt_InvoiceID.Name = "txt_InvoiceID";
            this.txt_InvoiceID.Size = new System.Drawing.Size(154, 27);
            this.txt_InvoiceID.TabIndex = 94;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(20, 65);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(66, 19);
            this.bunifuCustomLabel4.TabIndex = 93;
            this.bunifuCustomLabel4.Text = "Supplier";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(499, 65);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(41, 19);
            this.bunifuCustomLabel2.TabIndex = 92;
            this.bunifuCustomLabel2.Text = "Date";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(20, 26);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(118, 19);
            this.bunifuCustomLabel1.TabIndex = 91;
            this.bunifuCustomLabel1.Text = "Invoice Number";
            // 
            // txt_PONumber
            // 
            this.txt_PONumber.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_PONumber.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PONumber.Location = new System.Drawing.Point(546, 18);
            this.txt_PONumber.Name = "txt_PONumber";
            this.txt_PONumber.Size = new System.Drawing.Size(154, 27);
            this.txt_PONumber.TabIndex = 113;
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(407, 22);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(89, 19);
            this.bunifuCustomLabel10.TabIndex = 112;
            this.bunifuCustomLabel10.Text = "PO Number";
            // 
            // C_TransferRequestID
            // 
            this.C_TransferRequestID.FillWeight = 81.21828F;
            this.C_TransferRequestID.HeaderText = "Material ID";
            this.C_TransferRequestID.Name = "C_TransferRequestID";
            this.C_TransferRequestID.ReadOnly = true;
            // 
            // invoiceId
            // 
            this.invoiceId.HeaderText = "INo";
            this.invoiceId.Name = "invoiceId";
            this.invoiceId.Visible = false;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "POID";
            this.Column4.Name = "Column4";
            this.Column4.Visible = false;
            // 
            // C_TransferRequestDate
            // 
            this.C_TransferRequestDate.FillWeight = 106.2606F;
            this.C_TransferRequestDate.HeaderText = "Name";
            this.C_TransferRequestDate.Name = "C_TransferRequestDate";
            this.C_TransferRequestDate.Width = 175;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantity";
            this.Column3.Name = "Column3";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 106.2606F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Measurement";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Unit Price";
            this.Column1.Name = "Column1";
            this.Column1.Width = 130;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Amount";
            this.Column2.Name = "Column2";
            // 
            // AddUpdateInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 530);
            this.Controls.Add(this.txt_PONumber);
            this.Controls.Add(this.bunifuCustomLabel10);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.bunifuCustomLabel9);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.DG_InvoiceItem);
            this.Controls.Add(this.txt_UnitPrice);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.cmb_RawMaterial);
            this.Controls.Add(this.btn_AddItem);
            this.Controls.Add(this.btn_SaveInvoice);
            this.Controls.Add(this.txt_Quantity);
            this.Controls.Add(this.bunifuCustomLabel8);
            this.Controls.Add(this.cmb_DeliveryLocation);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.txt_comment);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.cmb_Supplier);
            this.Controls.Add(this.dtp_Invoice);
            this.Controls.Add(this.txt_InvoiceID);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddUpdateInvoice";
            this.Text = "AddUpdateInvoice";
            this.Load += new System.EventHandler(this.AddUpdateInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_InvoiceItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_total;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DG_InvoiceItem;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_UnitPrice;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private System.Windows.Forms.ComboBox cmb_RawMaterial;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_AddItem;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_SaveInvoice;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_Quantity;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private System.Windows.Forms.ComboBox cmb_DeliveryLocation;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_comment;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private System.Windows.Forms.ComboBox cmb_Supplier;
        private System.Windows.Forms.DateTimePicker dtp_Invoice;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_InvoiceID;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_PONumber;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_TransferRequestID;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_TransferRequestDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}