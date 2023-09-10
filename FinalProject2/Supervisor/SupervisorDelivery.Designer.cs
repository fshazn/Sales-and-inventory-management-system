namespace FinalProject2.Supervisor
{
    partial class SupervisorDelivery
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DG_ViewDeliveryItems = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.pid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Measurement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG_ViewDeliveries = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.purchaseorderid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estateno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.podate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.transferGoodsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DG_ViewDeliveryItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_ViewDeliveries)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DG_ViewDeliveryItems
            // 
            this.DG_ViewDeliveryItems.AllowUserToAddRows = false;
            this.DG_ViewDeliveryItems.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DG_ViewDeliveryItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DG_ViewDeliveryItems.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DG_ViewDeliveryItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DG_ViewDeliveryItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_ViewDeliveryItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DG_ViewDeliveryItems.ColumnHeadersHeight = 30;
            this.DG_ViewDeliveryItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pid,
            this.Product,
            this.Quantity,
            this.Measurement});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_ViewDeliveryItems.DefaultCellStyle = dataGridViewCellStyle3;
            this.DG_ViewDeliveryItems.DoubleBuffered = true;
            this.DG_ViewDeliveryItems.EnableHeadersVisualStyles = false;
            this.DG_ViewDeliveryItems.HeaderBgColor = System.Drawing.Color.White;
            this.DG_ViewDeliveryItems.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.DG_ViewDeliveryItems.Location = new System.Drawing.Point(177, 353);
            this.DG_ViewDeliveryItems.Name = "DG_ViewDeliveryItems";
            this.DG_ViewDeliveryItems.ReadOnly = true;
            this.DG_ViewDeliveryItems.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_ViewDeliveryItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DG_ViewDeliveryItems.RowHeadersVisible = false;
            this.DG_ViewDeliveryItems.Size = new System.Drawing.Size(500, 268);
            this.DG_ViewDeliveryItems.TabIndex = 77;
            // 
            // pid
            // 
            this.pid.HeaderText = "Product ID";
            this.pid.Name = "pid";
            this.pid.ReadOnly = true;
            // 
            // Product
            // 
            this.Product.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Product.HeaderText = "Product";
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Measurement
            // 
            this.Measurement.HeaderText = "Measurement";
            this.Measurement.Name = "Measurement";
            this.Measurement.ReadOnly = true;
            this.Measurement.Width = 110;
            // 
            // DG_ViewDeliveries
            // 
            this.DG_ViewDeliveries.AllowUserToAddRows = false;
            this.DG_ViewDeliveries.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DG_ViewDeliveries.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DG_ViewDeliveries.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DG_ViewDeliveries.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DG_ViewDeliveries.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_ViewDeliveries.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DG_ViewDeliveries.ColumnHeadersHeight = 30;
            this.DG_ViewDeliveries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.purchaseorderid,
            this.estateno,
            this.aid,
            this.podate,
            this.supplier});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_ViewDeliveries.DefaultCellStyle = dataGridViewCellStyle7;
            this.DG_ViewDeliveries.DoubleBuffered = true;
            this.DG_ViewDeliveries.EnableHeadersVisualStyles = false;
            this.DG_ViewDeliveries.HeaderBgColor = System.Drawing.Color.White;
            this.DG_ViewDeliveries.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.DG_ViewDeliveries.Location = new System.Drawing.Point(103, 93);
            this.DG_ViewDeliveries.Name = "DG_ViewDeliveries";
            this.DG_ViewDeliveries.ReadOnly = true;
            this.DG_ViewDeliveries.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_ViewDeliveries.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DG_ViewDeliveries.RowHeadersVisible = false;
            this.DG_ViewDeliveries.Size = new System.Drawing.Size(644, 227);
            this.DG_ViewDeliveries.TabIndex = 76;
            this.DG_ViewDeliveries.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_ViewDeliveries_CellClick);
            this.DG_ViewDeliveries.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DG_ViewDeliveries_CellMouseUp);
            // 
            // purchaseorderid
            // 
            this.purchaseorderid.FillWeight = 81.21828F;
            this.purchaseorderid.HeaderText = "Delivery No";
            this.purchaseorderid.Name = "purchaseorderid";
            this.purchaseorderid.ReadOnly = true;
            // 
            // estateno
            // 
            this.estateno.HeaderText = "Date";
            this.estateno.Name = "estateno";
            this.estateno.ReadOnly = true;
            // 
            // aid
            // 
            this.aid.HeaderText = "Estate ID";
            this.aid.Name = "aid";
            this.aid.ReadOnly = true;
            this.aid.Width = 150;
            // 
            // podate
            // 
            this.podate.FillWeight = 106.2606F;
            this.podate.HeaderText = "Estate";
            this.podate.Name = "podate";
            this.podate.ReadOnly = true;
            this.podate.Width = 120;
            // 
            // supplier
            // 
            this.supplier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.supplier.FillWeight = 106.2606F;
            this.supplier.HeaderText = "Status";
            this.supplier.Name = "supplier";
            this.supplier.ReadOnly = true;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(374, 20);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(131, 31);
            this.bunifuCustomLabel5.TabIndex = 75;
            this.bunifuCustomLabel5.Text = "Deliveries";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transferGoodsToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 26);
            // 
            // transferGoodsToolStripMenuItem
            // 
            this.transferGoodsToolStripMenuItem.Name = "transferGoodsToolStripMenuItem";
            this.transferGoodsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.transferGoodsToolStripMenuItem.Text = "Transfer Goods";
            this.transferGoodsToolStripMenuItem.Click += new System.EventHandler(this.transferGoodsToolStripMenuItem_Click);
            // 
            // SupervisorDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 660);
            this.Controls.Add(this.DG_ViewDeliveryItems);
            this.Controls.Add(this.DG_ViewDeliveries);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SupervisorDelivery";
            this.Text = "SupervisorDelivery";
            this.Load += new System.EventHandler(this.SupervisorDelivery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_ViewDeliveryItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_ViewDeliveries)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid DG_ViewDeliveryItems;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DG_ViewDeliveries;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem transferGoodsToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn pid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Measurement;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseorderid;
        private System.Windows.Forms.DataGridViewTextBoxColumn estateno;
        private System.Windows.Forms.DataGridViewTextBoxColumn aid;
        private System.Windows.Forms.DataGridViewTextBoxColumn podate;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier;
    }
}