namespace FinalProject2.Supervisor
{
    partial class Supplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Supplier));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_addNewSupplier = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel_AddSupplier = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_Contact = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_Email = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btn_CancelUpdate = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_Update = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txt_Address = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_cancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_add = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txt_SupplierID = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_SupplierName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DG_Suppliers = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.C_SupplierID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_SupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_AddNewSupplier = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.btn_addNewSupplier)).BeginInit();
            this.panel_AddSupplier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Suppliers)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_addNewSupplier
            // 
            this.btn_addNewSupplier.BackColor = System.Drawing.SystemColors.Control;
            this.btn_addNewSupplier.Image = global::FinalProject2.Properties.Resources.icons8_add_new_100;
            this.btn_addNewSupplier.ImageActive = null;
            this.btn_addNewSupplier.Location = new System.Drawing.Point(226, 335);
            this.btn_addNewSupplier.Name = "btn_addNewSupplier";
            this.btn_addNewSupplier.Size = new System.Drawing.Size(50, 35);
            this.btn_addNewSupplier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_addNewSupplier.TabIndex = 43;
            this.btn_addNewSupplier.TabStop = false;
            this.btn_addNewSupplier.Zoom = 10;
            this.btn_addNewSupplier.Click += new System.EventHandler(this.btn_addNewSupplier_Click);
            // 
            // panel_AddSupplier
            // 
            this.panel_AddSupplier.Controls.Add(this.bunifuCustomLabel6);
            this.panel_AddSupplier.Controls.Add(this.txt_Contact);
            this.panel_AddSupplier.Controls.Add(this.txt_Email);
            this.panel_AddSupplier.Controls.Add(this.btn_CancelUpdate);
            this.panel_AddSupplier.Controls.Add(this.btn_Update);
            this.panel_AddSupplier.Controls.Add(this.txt_Address);
            this.panel_AddSupplier.Controls.Add(this.bunifuCustomLabel3);
            this.panel_AddSupplier.Controls.Add(this.btn_cancel);
            this.panel_AddSupplier.Controls.Add(this.btn_add);
            this.panel_AddSupplier.Controls.Add(this.txt_SupplierID);
            this.panel_AddSupplier.Controls.Add(this.bunifuCustomLabel1);
            this.panel_AddSupplier.Controls.Add(this.bunifuCustomLabel4);
            this.panel_AddSupplier.Controls.Add(this.txt_SupplierName);
            this.panel_AddSupplier.Controls.Add(this.bunifuCustomLabel2);
            this.panel_AddSupplier.Location = new System.Drawing.Point(46, 389);
            this.panel_AddSupplier.Name = "panel_AddSupplier";
            this.panel_AddSupplier.Size = new System.Drawing.Size(744, 222);
            this.panel_AddSupplier.TabIndex = 44;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(382, 49);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(61, 19);
            this.bunifuCustomLabel6.TabIndex = 35;
            this.bunifuCustomLabel6.Text = "Contact";
            // 
            // txt_Contact
            // 
            this.txt_Contact.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.txt_Contact.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Contact.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.txt_Contact.BorderThickness = 1;
            this.txt_Contact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Contact.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Contact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Contact.isPassword = false;
            this.txt_Contact.Location = new System.Drawing.Point(519, 43);
            this.txt_Contact.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Contact.Name = "txt_Contact";
            this.txt_Contact.Size = new System.Drawing.Size(209, 31);
            this.txt_Contact.TabIndex = 34;
            this.txt_Contact.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_Email
            // 
            this.txt_Email.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.txt_Email.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Email.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.txt_Email.BorderThickness = 1;
            this.txt_Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Email.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Email.isPassword = false;
            this.txt_Email.Location = new System.Drawing.Point(519, 4);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(209, 31);
            this.txt_Email.TabIndex = 33;
            this.txt_Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.btn_CancelUpdate.Location = new System.Drawing.Point(392, 148);
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
            this.btn_Update.Location = new System.Drawing.Point(259, 148);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(105, 31);
            this.btn_Update.TabIndex = 31;
            this.btn_Update.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // txt_Address
            // 
            this.txt_Address.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.txt_Address.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Address.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.txt_Address.BorderThickness = 1;
            this.txt_Address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Address.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Address.isPassword = false;
            this.txt_Address.Location = new System.Drawing.Point(140, 82);
            this.txt_Address.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(209, 31);
            this.txt_Address.TabIndex = 30;
            this.txt_Address.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(3, 88);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(64, 19);
            this.bunifuCustomLabel3.TabIndex = 29;
            this.bunifuCustomLabel3.Text = "Address";
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
            this.btn_cancel.Location = new System.Drawing.Point(392, 148);
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
            this.btn_add.Location = new System.Drawing.Point(259, 147);
            this.btn_add.Margin = new System.Windows.Forms.Padding(5);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(105, 31);
            this.btn_add.TabIndex = 26;
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_SupplierID
            // 
            this.txt_SupplierID.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.txt_SupplierID.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_SupplierID.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.txt_SupplierID.BorderThickness = 1;
            this.txt_SupplierID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SupplierID.Enabled = false;
            this.txt_SupplierID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SupplierID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_SupplierID.isPassword = false;
            this.txt_SupplierID.Location = new System.Drawing.Point(140, 4);
            this.txt_SupplierID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SupplierID.Name = "txt_SupplierID";
            this.txt_SupplierID.Size = new System.Drawing.Size(209, 31);
            this.txt_SupplierID.TabIndex = 21;
            this.txt_SupplierID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(3, 13);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(86, 19);
            this.bunifuCustomLabel1.TabIndex = 20;
            this.bunifuCustomLabel1.Text = "Supplier ID";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(382, 11);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(47, 19);
            this.bunifuCustomLabel4.TabIndex = 24;
            this.bunifuCustomLabel4.Text = "Email";
            // 
            // txt_SupplierName
            // 
            this.txt_SupplierName.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.txt_SupplierName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_SupplierName.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.txt_SupplierName.BorderThickness = 1;
            this.txt_SupplierName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SupplierName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SupplierName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_SupplierName.isPassword = false;
            this.txt_SupplierName.Location = new System.Drawing.Point(140, 43);
            this.txt_SupplierName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SupplierName.Name = "txt_SupplierName";
            this.txt_SupplierName.Size = new System.Drawing.Size(209, 31);
            this.txt_SupplierName.TabIndex = 23;
            this.txt_SupplierName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(3, 49);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(108, 19);
            this.bunifuCustomLabel2.TabIndex = 22;
            this.bunifuCustomLabel2.Text = "Supplier Name";
            // 
            // DG_Suppliers
            // 
            this.DG_Suppliers.AllowUserToAddRows = false;
            this.DG_Suppliers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DG_Suppliers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DG_Suppliers.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DG_Suppliers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DG_Suppliers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_Suppliers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DG_Suppliers.ColumnHeadersHeight = 30;
            this.DG_Suppliers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C_SupplierID,
            this.C_SupplierName,
            this.C_Address,
            this.Email,
            this.Contact});
            this.DG_Suppliers.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(153)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_Suppliers.DefaultCellStyle = dataGridViewCellStyle3;
            this.DG_Suppliers.DoubleBuffered = true;
            this.DG_Suppliers.EnableHeadersVisualStyles = false;
            this.DG_Suppliers.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.DG_Suppliers.HeaderForeColor = System.Drawing.SystemColors.Control;
            this.DG_Suppliers.Location = new System.Drawing.Point(63, 99);
            this.DG_Suppliers.Name = "DG_Suppliers";
            this.DG_Suppliers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_Suppliers.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DG_Suppliers.Size = new System.Drawing.Size(704, 226);
            this.DG_Suppliers.TabIndex = 40;
            this.DG_Suppliers.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DG_Suppliers_CellMouseUp);
            // 
            // C_SupplierID
            // 
            this.C_SupplierID.FillWeight = 81.21828F;
            this.C_SupplierID.HeaderText = "Supplier ID";
            this.C_SupplierID.Name = "C_SupplierID";
            this.C_SupplierID.ReadOnly = true;
            this.C_SupplierID.Width = 117;
            // 
            // C_SupplierName
            // 
            this.C_SupplierName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.C_SupplierName.FillWeight = 106.2606F;
            this.C_SupplierName.HeaderText = "Supplier Name";
            this.C_SupplierName.Name = "C_SupplierName";
            // 
            // C_Address
            // 
            this.C_Address.FillWeight = 106.2606F;
            this.C_Address.HeaderText = "Address";
            this.C_Address.Name = "C_Address";
            this.C_Address.Width = 120;
            // 
            // Email
            // 
            this.Email.FillWeight = 106.2606F;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.Width = 150;
            // 
            // Contact
            // 
            this.Contact.HeaderText = "Contact";
            this.Contact.Name = "Contact";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(334, 33);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(164, 31);
            this.bunifuCustomLabel5.TabIndex = 41;
            this.bunifuCustomLabel5.Text = "SUPPLIERS";
            // 
            // lbl_AddNewSupplier
            // 
            this.lbl_AddNewSupplier.AutoSize = true;
            this.lbl_AddNewSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_AddNewSupplier.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AddNewSupplier.Location = new System.Drawing.Point(59, 341);
            this.lbl_AddNewSupplier.Name = "lbl_AddNewSupplier";
            this.lbl_AddNewSupplier.Size = new System.Drawing.Size(153, 23);
            this.lbl_AddNewSupplier.TabIndex = 42;
            this.lbl_AddNewSupplier.Text = "Add New Supplier";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 660);
            this.Controls.Add(this.btn_addNewSupplier);
            this.Controls.Add(this.panel_AddSupplier);
            this.Controls.Add(this.DG_Suppliers);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.lbl_AddNewSupplier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Supplier";
            this.Text = "Supplier";
            this.Load += new System.EventHandler(this.Supplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_addNewSupplier)).EndInit();
            this.panel_AddSupplier.ResumeLayout(false);
            this.panel_AddSupplier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Suppliers)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton btn_addNewSupplier;
        private System.Windows.Forms.Panel panel_AddSupplier;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Contact;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Email;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_CancelUpdate;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Update;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Address;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_cancel;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_add;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_SupplierID;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_SupplierName;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DG_Suppliers;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_SupplierID;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_SupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contact;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_AddNewSupplier;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
    }
}