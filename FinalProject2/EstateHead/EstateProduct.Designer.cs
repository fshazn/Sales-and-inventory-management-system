namespace FinalProject2.EstateHead
{
    partial class EstateProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EstateProduct));
            this.btn_addNewProduct = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbl_AddNewProduct = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DG_Product = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.C_ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_AddProduct = new System.Windows.Forms.Panel();
            this.txt_Quantity = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_cancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_add = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cmb_Estateproduct = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.btn_addNewProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Product)).BeginInit();
            this.panel_AddProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_addNewProduct
            // 
            this.btn_addNewProduct.BackColor = System.Drawing.SystemColors.Control;
            this.btn_addNewProduct.Image = global::FinalProject2.Properties.Resources.icons8_add_new_100;
            this.btn_addNewProduct.ImageActive = null;
            this.btn_addNewProduct.Location = new System.Drawing.Point(720, 438);
            this.btn_addNewProduct.Name = "btn_addNewProduct";
            this.btn_addNewProduct.Size = new System.Drawing.Size(50, 35);
            this.btn_addNewProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_addNewProduct.TabIndex = 23;
            this.btn_addNewProduct.TabStop = false;
            this.btn_addNewProduct.Zoom = 10;
            // 
            // lbl_AddNewProduct
            // 
            this.lbl_AddNewProduct.AutoSize = true;
            this.lbl_AddNewProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_AddNewProduct.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AddNewProduct.Location = new System.Drawing.Point(589, 442);
            this.lbl_AddNewProduct.Name = "lbl_AddNewProduct";
            this.lbl_AddNewProduct.Size = new System.Drawing.Size(130, 23);
            this.lbl_AddNewProduct.TabIndex = 22;
            this.lbl_AddNewProduct.Text = "Add New Stock";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(328, 12);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(165, 31);
            this.bunifuCustomLabel5.TabIndex = 21;
            this.bunifuCustomLabel5.Text = "PRODUCTS";
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
            this.DG_Product.Location = new System.Drawing.Point(60, 55);
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
            this.DG_Product.Size = new System.Drawing.Size(704, 375);
            this.DG_Product.TabIndex = 20;
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
            // panel_AddProduct
            // 
            this.panel_AddProduct.Controls.Add(this.bunifuCustomLabel1);
            this.panel_AddProduct.Controls.Add(this.cmb_Estateproduct);
            this.panel_AddProduct.Controls.Add(this.txt_Quantity);
            this.panel_AddProduct.Controls.Add(this.bunifuCustomLabel3);
            this.panel_AddProduct.Controls.Add(this.btn_cancel);
            this.panel_AddProduct.Controls.Add(this.btn_add);
            this.panel_AddProduct.Location = new System.Drawing.Point(398, 478);
            this.panel_AddProduct.Name = "panel_AddProduct";
            this.panel_AddProduct.Size = new System.Drawing.Size(366, 170);
            this.panel_AddProduct.TabIndex = 27;
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.txt_Quantity.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Quantity.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.txt_Quantity.BorderThickness = 1;
            this.txt_Quantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Quantity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Quantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Quantity.isPassword = false;
            this.txt_Quantity.Location = new System.Drawing.Point(80, 76);
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
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(10, 88);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(67, 19);
            this.bunifuCustomLabel3.TabIndex = 29;
            this.bunifuCustomLabel3.Text = "Quantity";
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
            this.btn_cancel.Location = new System.Drawing.Point(184, 127);
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
            this.btn_add.Location = new System.Drawing.Point(36, 127);
            this.btn_add.Margin = new System.Windows.Forms.Padding(5);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(105, 31);
            this.btn_add.TabIndex = 26;
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // cmb_Estateproduct
            // 
            this.cmb_Estateproduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Estateproduct.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Estateproduct.FormattingEnabled = true;
            this.cmb_Estateproduct.Location = new System.Drawing.Point(80, 34);
            this.cmb_Estateproduct.Name = "cmb_Estateproduct";
            this.cmb_Estateproduct.Size = new System.Drawing.Size(209, 27);
            this.cmb_Estateproduct.TabIndex = 43;
            this.cmb_Estateproduct.SelectedIndexChanged += new System.EventHandler(this.cmb_Estateproduct_SelectedIndexChanged);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(10, 37);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(60, 19);
            this.bunifuCustomLabel1.TabIndex = 44;
            this.bunifuCustomLabel1.Text = "Product";
            // 
            // EstateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 660);
            this.Controls.Add(this.panel_AddProduct);
            this.Controls.Add(this.btn_addNewProduct);
            this.Controls.Add(this.lbl_AddNewProduct);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.DG_Product);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EstateProduct";
            this.Text = "EstateProduct";
            this.Load += new System.EventHandler(this.EstateProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_addNewProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Product)).EndInit();
            this.panel_AddProduct.ResumeLayout(false);
            this.panel_AddProduct.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton btn_addNewProduct;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_AddNewProduct;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DG_Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn mUnit;
        private System.Windows.Forms.Panel panel_AddProduct;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Quantity;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_cancel;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_add;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.ComboBox cmb_Estateproduct;
    }
}