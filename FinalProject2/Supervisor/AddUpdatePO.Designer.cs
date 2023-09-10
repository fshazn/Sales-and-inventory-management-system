namespace FinalProject2
{
    partial class AddUpdatePO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUpdatePO));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_Quantity = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cmb_DeliveryLocation = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_comment = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cmb_Supplier = new System.Windows.Forms.ComboBox();
            this.dtp_PO = new System.Windows.Forms.DateTimePicker();
            this.txt_POID = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cmb_RawMaterial = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_AddItem = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_SavePO = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txt_UnitPrice = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DG_POItem = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txt_total = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.C_TransferRequestID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_TransferRequestDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DG_POItem)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_Quantity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Quantity.Location = new System.Drawing.Point(420, 176);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(154, 27);
            this.txt_Quantity.TabIndex = 80;
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(347, 179);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(69, 19);
            this.bunifuCustomLabel8.TabIndex = 79;
            this.bunifuCustomLabel8.Text = "Quantity";
            // 
            // cmb_DeliveryLocation
            // 
            this.cmb_DeliveryLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_DeliveryLocation.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_DeliveryLocation.FormattingEnabled = true;
            this.cmb_DeliveryLocation.Location = new System.Drawing.Point(159, 90);
            this.cmb_DeliveryLocation.Name = "cmb_DeliveryLocation";
            this.cmb_DeliveryLocation.Size = new System.Drawing.Size(154, 27);
            this.cmb_DeliveryLocation.TabIndex = 76;
            this.cmb_DeliveryLocation.SelectedIndexChanged += new System.EventHandler(this.cmb_DeliveryLocation_SelectedIndexChanged);
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(20, 93);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(127, 19);
            this.bunifuCustomLabel6.TabIndex = 75;
            this.bunifuCustomLabel6.Text = "Delivery Location";
            // 
            // txt_comment
            // 
            this.txt_comment.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_comment.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_comment.Location = new System.Drawing.Point(12, 419);
            this.txt_comment.Multiline = true;
            this.txt_comment.Name = "txt_comment";
            this.txt_comment.Size = new System.Drawing.Size(200, 79);
            this.txt_comment.TabIndex = 74;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(12, 397);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(75, 19);
            this.bunifuCustomLabel5.TabIndex = 73;
            this.bunifuCustomLabel5.Text = "Comment";
            // 
            // cmb_Supplier
            // 
            this.cmb_Supplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Supplier.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Supplier.FormattingEnabled = true;
            this.cmb_Supplier.Location = new System.Drawing.Point(159, 49);
            this.cmb_Supplier.Name = "cmb_Supplier";
            this.cmb_Supplier.Size = new System.Drawing.Size(154, 27);
            this.cmb_Supplier.TabIndex = 70;
            this.cmb_Supplier.SelectedIndexChanged += new System.EventHandler(this.cmb_Supplier_SelectedIndexChanged);
            // 
            // dtp_PO
            // 
            this.dtp_PO.CustomFormat = "dd-MM-yyyy";
            this.dtp_PO.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_PO.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_PO.Location = new System.Drawing.Point(501, 7);
            this.dtp_PO.Name = "dtp_PO";
            this.dtp_PO.Size = new System.Drawing.Size(200, 27);
            this.dtp_PO.TabIndex = 69;
            // 
            // txt_POID
            // 
            this.txt_POID.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_POID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_POID.Location = new System.Drawing.Point(159, 9);
            this.txt_POID.Name = "txt_POID";
            this.txt_POID.Size = new System.Drawing.Size(154, 27);
            this.txt_POID.TabIndex = 68;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(20, 52);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(66, 19);
            this.bunifuCustomLabel4.TabIndex = 67;
            this.bunifuCustomLabel4.Text = "Supplier";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(454, 11);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(41, 19);
            this.bunifuCustomLabel2.TabIndex = 66;
            this.bunifuCustomLabel2.Text = "Date";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(20, 13);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(133, 19);
            this.bunifuCustomLabel1.TabIndex = 65;
            this.bunifuCustomLabel1.Text = "Purchase Order ID";
            // 
            // cmb_RawMaterial
            // 
            this.cmb_RawMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_RawMaterial.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_RawMaterial.FormattingEnabled = true;
            this.cmb_RawMaterial.Location = new System.Drawing.Point(159, 132);
            this.cmb_RawMaterial.Name = "cmb_RawMaterial";
            this.cmb_RawMaterial.Size = new System.Drawing.Size(154, 27);
            this.cmb_RawMaterial.TabIndex = 85;
            this.cmb_RawMaterial.SelectedIndexChanged += new System.EventHandler(this.cmb_RawMaterial_SelectedIndexChanged);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(20, 136);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(100, 19);
            this.bunifuCustomLabel3.TabIndex = 84;
            this.bunifuCustomLabel3.Text = "Raw Material";
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
            this.btn_AddItem.Location = new System.Drawing.Point(641, 176);
            this.btn_AddItem.Margin = new System.Windows.Forms.Padding(5);
            this.btn_AddItem.Name = "btn_AddItem";
            this.btn_AddItem.Size = new System.Drawing.Size(105, 31);
            this.btn_AddItem.TabIndex = 81;
            this.btn_AddItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_AddItem.Click += new System.EventHandler(this.btn_AddItem_Click);
            // 
            // btn_SavePO
            // 
            this.btn_SavePO.ActiveBorderThickness = 1;
            this.btn_SavePO.ActiveCornerRadius = 20;
            this.btn_SavePO.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_SavePO.ActiveForecolor = System.Drawing.Color.White;
            this.btn_SavePO.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_SavePO.BackColor = System.Drawing.SystemColors.Control;
            this.btn_SavePO.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_SavePO.BackgroundImage")));
            this.btn_SavePO.ButtonText = "Save";
            this.btn_SavePO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SavePO.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SavePO.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_SavePO.IdleBorderThickness = 1;
            this.btn_SavePO.IdleCornerRadius = 20;
            this.btn_SavePO.IdleFillColor = System.Drawing.Color.White;
            this.btn_SavePO.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_SavePO.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_SavePO.Location = new System.Drawing.Point(643, 467);
            this.btn_SavePO.Margin = new System.Windows.Forms.Padding(5);
            this.btn_SavePO.Name = "btn_SavePO";
            this.btn_SavePO.Size = new System.Drawing.Size(105, 31);
            this.btn_SavePO.TabIndex = 83;
            this.btn_SavePO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_SavePO.Click += new System.EventHandler(this.btn_SavePO_Click);
            // 
            // txt_UnitPrice
            // 
            this.txt_UnitPrice.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_UnitPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UnitPrice.Location = new System.Drawing.Point(159, 176);
            this.txt_UnitPrice.Name = "txt_UnitPrice";
            this.txt_UnitPrice.Size = new System.Drawing.Size(154, 27);
            this.txt_UnitPrice.TabIndex = 87;
            this.txt_UnitPrice.Leave += new System.EventHandler(this.txt_UnitPrice_Leave);
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(20, 179);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(76, 19);
            this.bunifuCustomLabel7.TabIndex = 86;
            this.bunifuCustomLabel7.Text = "Unit Price";
            // 
            // DG_POItem
            // 
            this.DG_POItem.AllowUserToAddRows = false;
            this.DG_POItem.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DG_POItem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DG_POItem.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DG_POItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DG_POItem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_POItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DG_POItem.ColumnHeadersHeight = 30;
            this.DG_POItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C_TransferRequestID,
            this.Column4,
            this.C_TransferRequestDate,
            this.Column3,
            this.dataGridViewTextBoxColumn1,
            this.Column1,
            this.Column2});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_POItem.DefaultCellStyle = dataGridViewCellStyle7;
            this.DG_POItem.DoubleBuffered = true;
            this.DG_POItem.EnableHeadersVisualStyles = false;
            this.DG_POItem.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.DG_POItem.HeaderForeColor = System.Drawing.SystemColors.Control;
            this.DG_POItem.Location = new System.Drawing.Point(12, 215);
            this.DG_POItem.Name = "DG_POItem";
            this.DG_POItem.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_POItem.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DG_POItem.RowHeadersVisible = false;
            this.DG_POItem.Size = new System.Drawing.Size(736, 179);
            this.DG_POItem.TabIndex = 88;
            // 
            // txt_total
            // 
            this.txt_total.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_total.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.Location = new System.Drawing.Point(592, 419);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(154, 27);
            this.txt_total.TabIndex = 90;
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(519, 422);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(43, 19);
            this.bunifuCustomLabel9.TabIndex = 89;
            this.bunifuCustomLabel9.Text = "Total";
            // 
            // C_TransferRequestID
            // 
            this.C_TransferRequestID.FillWeight = 81.21828F;
            this.C_TransferRequestID.HeaderText = "Material ID";
            this.C_TransferRequestID.Name = "C_TransferRequestID";
            this.C_TransferRequestID.ReadOnly = true;
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
            // AddUpdatePO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 510);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.bunifuCustomLabel9);
            this.Controls.Add(this.DG_POItem);
            this.Controls.Add(this.txt_UnitPrice);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.cmb_RawMaterial);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.btn_AddItem);
            this.Controls.Add(this.btn_SavePO);
            this.Controls.Add(this.txt_Quantity);
            this.Controls.Add(this.bunifuCustomLabel8);
            this.Controls.Add(this.cmb_DeliveryLocation);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.txt_comment);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.cmb_Supplier);
            this.Controls.Add(this.dtp_PO);
            this.Controls.Add(this.txt_POID);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddUpdatePO";
            this.Text = "AddUpdatePO";
            this.Load += new System.EventHandler(this.AddUpdatePO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_POItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuThinButton2 btn_AddItem;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_SavePO;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_Quantity;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private System.Windows.Forms.ComboBox cmb_DeliveryLocation;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_comment;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private System.Windows.Forms.ComboBox cmb_Supplier;
        private System.Windows.Forms.DateTimePicker dtp_PO;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_POID;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.ComboBox cmb_RawMaterial;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_UnitPrice;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DG_POItem;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_total;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_TransferRequestID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_TransferRequestDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}