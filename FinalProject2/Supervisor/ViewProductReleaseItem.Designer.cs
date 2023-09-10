namespace FinalProject2
{
    partial class ViewProductReleaseItem
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
            this.DG_ViewProductReleasedItem = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.C_ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_AddNewProduct = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_VProductReleaseID = new System.Windows.Forms.TextBox();
            this.txt_VProductReleasedDate = new System.Windows.Forms.TextBox();
            this.txt_VProductReleasedFor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DG_ViewProductReleasedItem)).BeginInit();
            this.SuspendLayout();
            // 
            // DG_ViewProductReleasedItem
            // 
            this.DG_ViewProductReleasedItem.AllowUserToAddRows = false;
            this.DG_ViewProductReleasedItem.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DG_ViewProductReleasedItem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DG_ViewProductReleasedItem.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DG_ViewProductReleasedItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DG_ViewProductReleasedItem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_ViewProductReleasedItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DG_ViewProductReleasedItem.ColumnHeadersHeight = 30;
            this.DG_ViewProductReleasedItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C_ProductID,
            this.C_ProductName,
            this.C_Description,
            this.MUnit});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_ViewProductReleasedItem.DefaultCellStyle = dataGridViewCellStyle3;
            this.DG_ViewProductReleasedItem.DoubleBuffered = true;
            this.DG_ViewProductReleasedItem.EnableHeadersVisualStyles = false;
            this.DG_ViewProductReleasedItem.HeaderBgColor = System.Drawing.Color.White;
            this.DG_ViewProductReleasedItem.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.DG_ViewProductReleasedItem.Location = new System.Drawing.Point(12, 145);
            this.DG_ViewProductReleasedItem.Name = "DG_ViewProductReleasedItem";
            this.DG_ViewProductReleasedItem.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_ViewProductReleasedItem.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DG_ViewProductReleasedItem.Size = new System.Drawing.Size(736, 203);
            this.DG_ViewProductReleasedItem.TabIndex = 31;
            // 
            // C_ProductID
            // 
            this.C_ProductID.FillWeight = 81.21828F;
            this.C_ProductID.HeaderText = "Product ID";
            this.C_ProductID.Name = "C_ProductID";
            this.C_ProductID.ReadOnly = true;
            this.C_ProductID.Width = 150;
            // 
            // C_ProductName
            // 
            this.C_ProductName.FillWeight = 106.2606F;
            this.C_ProductName.HeaderText = "Product Name";
            this.C_ProductName.Name = "C_ProductName";
            this.C_ProductName.Width = 243;
            // 
            // C_Description
            // 
            this.C_Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.C_Description.FillWeight = 106.2606F;
            this.C_Description.HeaderText = "Quantity";
            this.C_Description.Name = "C_Description";
            // 
            // MUnit
            // 
            this.MUnit.HeaderText = "Measurement Unit";
            this.MUnit.Name = "MUnit";
            this.MUnit.Width = 150;
            // 
            // lbl_AddNewProduct
            // 
            this.lbl_AddNewProduct.AutoSize = true;
            this.lbl_AddNewProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_AddNewProduct.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AddNewProduct.Location = new System.Drawing.Point(8, 9);
            this.lbl_AddNewProduct.Name = "lbl_AddNewProduct";
            this.lbl_AddNewProduct.Size = new System.Drawing.Size(149, 19);
            this.lbl_AddNewProduct.TabIndex = 43;
            this.lbl_AddNewProduct.Text = "Product  Release ID :";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(8, 38);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(149, 19);
            this.bunifuCustomLabel1.TabIndex = 44;
            this.bunifuCustomLabel1.Text = "Released Date          :";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(8, 70);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(147, 19);
            this.bunifuCustomLabel2.TabIndex = 45;
            this.bunifuCustomLabel2.Text = "Released For            :";
            // 
            // txt_VProductReleaseID
            // 
            this.txt_VProductReleaseID.BackColor = System.Drawing.SystemColors.Control;
            this.txt_VProductReleaseID.Location = new System.Drawing.Point(175, 7);
            this.txt_VProductReleaseID.Name = "txt_VProductReleaseID";
            this.txt_VProductReleaseID.Size = new System.Drawing.Size(150, 20);
            this.txt_VProductReleaseID.TabIndex = 46;
            // 
            // txt_VProductReleasedDate
            // 
            this.txt_VProductReleasedDate.BackColor = System.Drawing.SystemColors.Control;
            this.txt_VProductReleasedDate.Location = new System.Drawing.Point(175, 37);
            this.txt_VProductReleasedDate.Name = "txt_VProductReleasedDate";
            this.txt_VProductReleasedDate.Size = new System.Drawing.Size(150, 20);
            this.txt_VProductReleasedDate.TabIndex = 47;
            // 
            // txt_VProductReleasedFor
            // 
            this.txt_VProductReleasedFor.BackColor = System.Drawing.SystemColors.Control;
            this.txt_VProductReleasedFor.Location = new System.Drawing.Point(175, 71);
            this.txt_VProductReleasedFor.Name = "txt_VProductReleasedFor";
            this.txt_VProductReleasedFor.Size = new System.Drawing.Size(150, 20);
            this.txt_VProductReleasedFor.TabIndex = 48;
            // 
            // ViewProductReleaseItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 360);
            this.Controls.Add(this.txt_VProductReleasedFor);
            this.Controls.Add(this.txt_VProductReleasedDate);
            this.Controls.Add(this.txt_VProductReleaseID);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.lbl_AddNewProduct);
            this.Controls.Add(this.DG_ViewProductReleasedItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewProductReleaseItem";
            this.Text = "ViewProductReleaseItem";
            ((System.ComponentModel.ISupportInitialize)(this.DG_ViewProductReleasedItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid DG_ViewProductReleasedItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn MUnit;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_AddNewProduct;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.TextBox txt_VProductReleaseID;
        private System.Windows.Forms.TextBox txt_VProductReleasedDate;
        private System.Windows.Forms.TextBox txt_VProductReleasedFor;
    }
}