namespace FinalProject2
{
    partial class Estates
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estates));
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DG_Estates = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.C_EstateID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_EstateName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_AddEstates = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_Contact = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_Email = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btn_CancelUpdate = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_Update = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txt_Address = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_cancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_add = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txt_EstateID = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_EstateName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_addNewEstate = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbl_AddNewEstate = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Estates)).BeginInit();
            this.panel_AddEstates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_addNewEstate)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(339, 9);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(131, 31);
            this.bunifuCustomLabel5.TabIndex = 29;
            this.bunifuCustomLabel5.Text = "ESTATES";
            // 
            // DG_Estates
            // 
            this.DG_Estates.AllowUserToAddRows = false;
            this.DG_Estates.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DG_Estates.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DG_Estates.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DG_Estates.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DG_Estates.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_Estates.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DG_Estates.ColumnHeadersHeight = 30;
            this.DG_Estates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C_EstateID,
            this.C_EstateName,
            this.C_Address,
            this.Email,
            this.Contact});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(153)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_Estates.DefaultCellStyle = dataGridViewCellStyle3;
            this.DG_Estates.DoubleBuffered = true;
            this.DG_Estates.EnableHeadersVisualStyles = false;
            this.DG_Estates.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.DG_Estates.HeaderForeColor = System.Drawing.SystemColors.Control;
            this.DG_Estates.Location = new System.Drawing.Point(71, 56);
            this.DG_Estates.Name = "DG_Estates";
            this.DG_Estates.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_Estates.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DG_Estates.Size = new System.Drawing.Size(704, 226);
            this.DG_Estates.TabIndex = 31;
            // 
            // C_EstateID
            // 
            this.C_EstateID.FillWeight = 81.21828F;
            this.C_EstateID.HeaderText = "Estate ID";
            this.C_EstateID.Name = "C_EstateID";
            this.C_EstateID.ReadOnly = true;
            this.C_EstateID.Width = 117;
            // 
            // C_EstateName
            // 
            this.C_EstateName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.C_EstateName.FillWeight = 106.2606F;
            this.C_EstateName.HeaderText = "Estate Name";
            this.C_EstateName.Name = "C_EstateName";
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
            // panel_AddEstates
            // 
            this.panel_AddEstates.Controls.Add(this.bunifuCustomLabel6);
            this.panel_AddEstates.Controls.Add(this.txt_Contact);
            this.panel_AddEstates.Controls.Add(this.txt_Email);
            this.panel_AddEstates.Controls.Add(this.btn_CancelUpdate);
            this.panel_AddEstates.Controls.Add(this.btn_Update);
            this.panel_AddEstates.Controls.Add(this.txt_Address);
            this.panel_AddEstates.Controls.Add(this.bunifuCustomLabel3);
            this.panel_AddEstates.Controls.Add(this.btn_cancel);
            this.panel_AddEstates.Controls.Add(this.btn_add);
            this.panel_AddEstates.Controls.Add(this.txt_EstateID);
            this.panel_AddEstates.Controls.Add(this.bunifuCustomLabel1);
            this.panel_AddEstates.Controls.Add(this.bunifuCustomLabel4);
            this.panel_AddEstates.Controls.Add(this.txt_EstateName);
            this.panel_AddEstates.Controls.Add(this.bunifuCustomLabel2);
            this.panel_AddEstates.Location = new System.Drawing.Point(71, 339);
            this.panel_AddEstates.Name = "panel_AddEstates";
            this.panel_AddEstates.Size = new System.Drawing.Size(704, 261);
            this.panel_AddEstates.TabIndex = 37;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(354, 57);
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
            this.txt_Contact.Location = new System.Drawing.Point(491, 49);
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
            this.txt_Email.Location = new System.Drawing.Point(491, 4);
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
            this.btn_CancelUpdate.Location = new System.Drawing.Point(386, 186);
            this.btn_CancelUpdate.Margin = new System.Windows.Forms.Padding(5);
            this.btn_CancelUpdate.Name = "btn_CancelUpdate";
            this.btn_CancelUpdate.Size = new System.Drawing.Size(105, 31);
            this.btn_CancelUpdate.TabIndex = 32;
            this.btn_CancelUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btn_Update.Location = new System.Drawing.Point(253, 186);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(105, 31);
            this.btn_Update.TabIndex = 31;
            this.btn_Update.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.txt_Address.Location = new System.Drawing.Point(140, 97);
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
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(3, 103);
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
            this.btn_cancel.Location = new System.Drawing.Point(386, 187);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(5);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(105, 31);
            this.btn_cancel.TabIndex = 27;
            this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btn_add.Location = new System.Drawing.Point(253, 186);
            this.btn_add.Margin = new System.Windows.Forms.Padding(5);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(105, 31);
            this.btn_add.TabIndex = 26;
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_EstateID
            // 
            this.txt_EstateID.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.txt_EstateID.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_EstateID.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.txt_EstateID.BorderThickness = 1;
            this.txt_EstateID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_EstateID.Enabled = false;
            this.txt_EstateID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EstateID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_EstateID.isPassword = false;
            this.txt_EstateID.Location = new System.Drawing.Point(140, 4);
            this.txt_EstateID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_EstateID.Name = "txt_EstateID";
            this.txt_EstateID.Size = new System.Drawing.Size(209, 31);
            this.txt_EstateID.TabIndex = 21;
            this.txt_EstateID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(3, 13);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(74, 19);
            this.bunifuCustomLabel1.TabIndex = 20;
            this.bunifuCustomLabel1.Text = "Estate ID";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(354, 11);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(47, 19);
            this.bunifuCustomLabel4.TabIndex = 24;
            this.bunifuCustomLabel4.Text = "Email";
            // 
            // txt_EstateName
            // 
            this.txt_EstateName.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.txt_EstateName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_EstateName.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.txt_EstateName.BorderThickness = 1;
            this.txt_EstateName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_EstateName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EstateName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_EstateName.isPassword = false;
            this.txt_EstateName.Location = new System.Drawing.Point(140, 51);
            this.txt_EstateName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_EstateName.Name = "txt_EstateName";
            this.txt_EstateName.Size = new System.Drawing.Size(209, 31);
            this.txt_EstateName.TabIndex = 23;
            this.txt_EstateName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(3, 57);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(96, 19);
            this.bunifuCustomLabel2.TabIndex = 22;
            this.bunifuCustomLabel2.Text = "Estate Name";
            // 
            // btn_addNewEstate
            // 
            this.btn_addNewEstate.BackColor = System.Drawing.SystemColors.Control;
            this.btn_addNewEstate.Image = global::FinalProject2.Properties.Resources.icons8_add_new_100;
            this.btn_addNewEstate.ImageActive = null;
            this.btn_addNewEstate.Location = new System.Drawing.Point(728, 294);
            this.btn_addNewEstate.Name = "btn_addNewEstate";
            this.btn_addNewEstate.Size = new System.Drawing.Size(50, 35);
            this.btn_addNewEstate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_addNewEstate.TabIndex = 36;
            this.btn_addNewEstate.TabStop = false;
            this.btn_addNewEstate.Zoom = 10;
            this.btn_addNewEstate.Click += new System.EventHandler(this.btn_addNewEstate_Click);
            // 
            // lbl_AddNewEstate
            // 
            this.lbl_AddNewEstate.AutoSize = true;
            this.lbl_AddNewEstate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_AddNewEstate.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AddNewEstate.Location = new System.Drawing.Point(561, 300);
            this.lbl_AddNewEstate.Name = "lbl_AddNewEstate";
            this.lbl_AddNewEstate.Size = new System.Drawing.Size(137, 23);
            this.lbl_AddNewEstate.TabIndex = 35;
            this.lbl_AddNewEstate.Text = "Add New Estate";
            // 
            // Estates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 621);
            this.Controls.Add(this.panel_AddEstates);
            this.Controls.Add(this.btn_addNewEstate);
            this.Controls.Add(this.lbl_AddNewEstate);
            this.Controls.Add(this.DG_Estates);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Estates";
            this.Text = "Estates";
            this.Load += new System.EventHandler(this.Estates_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Estates)).EndInit();
            this.panel_AddEstates.ResumeLayout(false);
            this.panel_AddEstates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_addNewEstate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DG_Estates;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_EstateID;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_EstateName;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contact;
        private System.Windows.Forms.Panel panel_AddEstates;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Contact;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Email;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_CancelUpdate;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Update;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Address;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_cancel;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_add;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_EstateID;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_EstateName;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuImageButton btn_addNewEstate;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_AddNewEstate;
    }
}