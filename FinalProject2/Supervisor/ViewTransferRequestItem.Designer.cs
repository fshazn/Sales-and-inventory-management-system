namespace FinalProject2
{
    partial class ViewTransferRequestItem
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
            this.DG_TrItemView = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.C_ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_RequestFrom = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_rfrom = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.DG_TrItemView)).BeginInit();
            this.SuspendLayout();
            // 
            // DG_TrItemView
            // 
            this.DG_TrItemView.AllowUserToAddRows = false;
            this.DG_TrItemView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DG_TrItemView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DG_TrItemView.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DG_TrItemView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DG_TrItemView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_TrItemView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DG_TrItemView.ColumnHeadersHeight = 30;
            this.DG_TrItemView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.DG_TrItemView.DefaultCellStyle = dataGridViewCellStyle3;
            this.DG_TrItemView.DoubleBuffered = true;
            this.DG_TrItemView.EnableHeadersVisualStyles = false;
            this.DG_TrItemView.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.DG_TrItemView.HeaderForeColor = System.Drawing.SystemColors.Control;
            this.DG_TrItemView.Location = new System.Drawing.Point(12, 40);
            this.DG_TrItemView.Name = "DG_TrItemView";
            this.DG_TrItemView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_TrItemView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DG_TrItemView.Size = new System.Drawing.Size(736, 219);
            this.DG_TrItemView.TabIndex = 30;
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
            // lbl_RequestFrom
            // 
            this.lbl_RequestFrom.AutoSize = true;
            this.lbl_RequestFrom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_RequestFrom.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RequestFrom.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbl_RequestFrom.Location = new System.Drawing.Point(12, 267);
            this.lbl_RequestFrom.Name = "lbl_RequestFrom";
            this.lbl_RequestFrom.Size = new System.Drawing.Size(164, 19);
            this.lbl_RequestFrom.TabIndex = 37;
            this.lbl_RequestFrom.Text = "Requested From          :";
            // 
            // lbl_rfrom
            // 
            this.lbl_rfrom.AutoSize = true;
            this.lbl_rfrom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_rfrom.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rfrom.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbl_rfrom.Location = new System.Drawing.Point(165, 267);
            this.lbl_rfrom.Name = "lbl_rfrom";
            this.lbl_rfrom.Size = new System.Drawing.Size(0, 19);
            this.lbl_rfrom.TabIndex = 40;
            // 
            // ViewTransferRequestItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 335);
            this.Controls.Add(this.lbl_rfrom);
            this.Controls.Add(this.lbl_RequestFrom);
            this.Controls.Add(this.DG_TrItemView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewTransferRequestItem";
            this.Text = "ViewTransferRequestItem";
            this.Load += new System.EventHandler(this.ViewTransferRequestItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_TrItemView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid DG_TrItemView;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn MUnit;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_RequestFrom;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_rfrom;
    }
}