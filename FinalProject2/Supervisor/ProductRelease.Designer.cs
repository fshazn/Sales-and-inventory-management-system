namespace FinalProject2
{
    partial class ProductRelease
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DG_ProductRelease = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.C_ProductReleaseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_ProductReleasedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Releasedfor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_AddNewProduct = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel_Prodcutrelease = new System.Windows.Forms.Panel();
            this.btn_addNewProductRelease = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.DG_ProductRelease)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_addNewProductRelease)).BeginInit();
            this.SuspendLayout();
            // 
            // DG_ProductRelease
            // 
            this.DG_ProductRelease.AllowUserToAddRows = false;
            this.DG_ProductRelease.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DG_ProductRelease.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.DG_ProductRelease.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DG_ProductRelease.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DG_ProductRelease.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_ProductRelease.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.DG_ProductRelease.ColumnHeadersHeight = 30;
            this.DG_ProductRelease.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C_ProductReleaseID,
            this.C_ProductReleasedDate,
            this.C_Releasedfor});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_ProductRelease.DefaultCellStyle = dataGridViewCellStyle11;
            this.DG_ProductRelease.DoubleBuffered = true;
            this.DG_ProductRelease.EnableHeadersVisualStyles = false;
            this.DG_ProductRelease.HeaderBgColor = System.Drawing.Color.White;
            this.DG_ProductRelease.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.DG_ProductRelease.Location = new System.Drawing.Point(28, 78);
            this.DG_ProductRelease.Name = "DG_ProductRelease";
            this.DG_ProductRelease.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_ProductRelease.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.DG_ProductRelease.Size = new System.Drawing.Size(760, 199);
            this.DG_ProductRelease.TabIndex = 30;
            // 
            // C_ProductReleaseID
            // 
            this.C_ProductReleaseID.FillWeight = 81.21828F;
            this.C_ProductReleaseID.HeaderText = "Product Release ID";
            this.C_ProductReleaseID.Name = "C_ProductReleaseID";
            this.C_ProductReleaseID.ReadOnly = true;
            this.C_ProductReleaseID.Width = 150;
            // 
            // C_ProductReleasedDate
            // 
            this.C_ProductReleasedDate.FillWeight = 106.2606F;
            this.C_ProductReleasedDate.HeaderText = "Product Released Date";
            this.C_ProductReleasedDate.Name = "C_ProductReleasedDate";
            this.C_ProductReleasedDate.Width = 243;
            // 
            // C_Releasedfor
            // 
            this.C_Releasedfor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.C_Releasedfor.FillWeight = 106.2606F;
            this.C_Releasedfor.HeaderText = "Released for";
            this.C_Releasedfor.Name = "C_Releasedfor";
            // 
            // lbl_AddNewProduct
            // 
            this.lbl_AddNewProduct.AutoSize = true;
            this.lbl_AddNewProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_AddNewProduct.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AddNewProduct.Location = new System.Drawing.Point(542, 45);
            this.lbl_AddNewProduct.Name = "lbl_AddNewProduct";
            this.lbl_AddNewProduct.Size = new System.Drawing.Size(186, 19);
            this.lbl_AddNewProduct.TabIndex = 42;
            this.lbl_AddNewProduct.Text = "Add New Product Release";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(300, 9);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(204, 31);
            this.bunifuCustomLabel5.TabIndex = 41;
            this.bunifuCustomLabel5.Text = "Product Release";
            // 
            // panel_Prodcutrelease
            // 
            this.panel_Prodcutrelease.Location = new System.Drawing.Point(28, 284);
            this.panel_Prodcutrelease.Name = "panel_Prodcutrelease";
            this.panel_Prodcutrelease.Size = new System.Drawing.Size(760, 360);
            this.panel_Prodcutrelease.TabIndex = 44;
            // 
            // btn_addNewProductRelease
            // 
            this.btn_addNewProductRelease.BackColor = System.Drawing.SystemColors.Control;
            this.btn_addNewProductRelease.Image = global::FinalProject2.Properties.Resources.icons8_add_new_100;
            this.btn_addNewProductRelease.ImageActive = null;
            this.btn_addNewProductRelease.Location = new System.Drawing.Point(738, 37);
            this.btn_addNewProductRelease.Name = "btn_addNewProductRelease";
            this.btn_addNewProductRelease.Size = new System.Drawing.Size(50, 35);
            this.btn_addNewProductRelease.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_addNewProductRelease.TabIndex = 43;
            this.btn_addNewProductRelease.TabStop = false;
            this.btn_addNewProductRelease.Zoom = 10;
            this.btn_addNewProductRelease.Click += new System.EventHandler(this.btn_addNewProductRelease_Click);
            // 
            // ProductRelease
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 660);
            this.Controls.Add(this.panel_Prodcutrelease);
            this.Controls.Add(this.btn_addNewProductRelease);
            this.Controls.Add(this.lbl_AddNewProduct);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.DG_ProductRelease);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductRelease";
            this.Text = "ProductRelease";
            ((System.ComponentModel.ISupportInitialize)(this.DG_ProductRelease)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_addNewProductRelease)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid DG_ProductRelease;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_ProductReleaseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_ProductReleasedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Releasedfor;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_AddNewProduct;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private System.Windows.Forms.Panel panel_Prodcutrelease;
        public Bunifu.Framework.UI.BunifuImageButton btn_addNewProductRelease;
    }
}