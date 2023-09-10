namespace FinalProject2
{
    partial class ViewGRN
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DG_ViewGRNItem = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.DG_ViewGRN = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.GrnNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Invoiceno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliverylocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DG_ViewGRNItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_ViewGRN)).BeginInit();
            this.SuspendLayout();
            // 
            // DG_ViewGRNItem
            // 
            this.DG_ViewGRNItem.AllowUserToAddRows = false;
            this.DG_ViewGRNItem.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DG_ViewGRNItem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DG_ViewGRNItem.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DG_ViewGRNItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DG_ViewGRNItem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_ViewGRNItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DG_ViewGRNItem.ColumnHeadersHeight = 30;
            this.DG_ViewGRNItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_ViewGRNItem.DefaultCellStyle = dataGridViewCellStyle3;
            this.DG_ViewGRNItem.DoubleBuffered = true;
            this.DG_ViewGRNItem.EnableHeadersVisualStyles = false;
            this.DG_ViewGRNItem.HeaderBgColor = System.Drawing.Color.White;
            this.DG_ViewGRNItem.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.DG_ViewGRNItem.Location = new System.Drawing.Point(0, 287);
            this.DG_ViewGRNItem.Name = "DG_ViewGRNItem";
            this.DG_ViewGRNItem.ReadOnly = true;
            this.DG_ViewGRNItem.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_ViewGRNItem.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DG_ViewGRNItem.RowHeadersVisible = false;
            this.DG_ViewGRNItem.Size = new System.Drawing.Size(760, 202);
            this.DG_ViewGRNItem.TabIndex = 22;
            // 
            // DG_ViewGRN
            // 
            this.DG_ViewGRN.AllowUserToAddRows = false;
            this.DG_ViewGRN.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DG_ViewGRN.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DG_ViewGRN.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DG_ViewGRN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DG_ViewGRN.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_ViewGRN.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DG_ViewGRN.ColumnHeadersHeight = 30;
            this.DG_ViewGRN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GrnNo,
            this.Pono,
            this.Invoiceno,
            this.date,
            this.supplier,
            this.deliverylocation,
            this.comment});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_ViewGRN.DefaultCellStyle = dataGridViewCellStyle7;
            this.DG_ViewGRN.DoubleBuffered = true;
            this.DG_ViewGRN.EnableHeadersVisualStyles = false;
            this.DG_ViewGRN.HeaderBgColor = System.Drawing.Color.White;
            this.DG_ViewGRN.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.DG_ViewGRN.Location = new System.Drawing.Point(0, 21);
            this.DG_ViewGRN.Name = "DG_ViewGRN";
            this.DG_ViewGRN.ReadOnly = true;
            this.DG_ViewGRN.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_ViewGRN.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DG_ViewGRN.RowHeadersVisible = false;
            this.DG_ViewGRN.Size = new System.Drawing.Size(760, 242);
            this.DG_ViewGRN.TabIndex = 21;
            this.DG_ViewGRN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_ViewInvoice_CellClick);
            // 
            // GrnNo
            // 
            this.GrnNo.FillWeight = 81.21828F;
            this.GrnNo.HeaderText = "GRN No";
            this.GrnNo.Name = "GrnNo";
            this.GrnNo.ReadOnly = true;
            this.GrnNo.Width = 80;
            // 
            // Pono
            // 
            this.Pono.HeaderText = "PO No";
            this.Pono.Name = "Pono";
            this.Pono.ReadOnly = true;
            this.Pono.Width = 80;
            // 
            // Invoiceno
            // 
            this.Invoiceno.HeaderText = "Invoice No";
            this.Invoiceno.Name = "Invoiceno";
            this.Invoiceno.ReadOnly = true;
            // 
            // date
            // 
            this.date.FillWeight = 106.2606F;
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 120;
            // 
            // supplier
            // 
            this.supplier.HeaderText = "Supplier";
            this.supplier.Name = "supplier";
            this.supplier.ReadOnly = true;
            // 
            // deliverylocation
            // 
            this.deliverylocation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.deliverylocation.HeaderText = "Delivery Location";
            this.deliverylocation.Name = "deliverylocation";
            this.deliverylocation.ReadOnly = true;
            this.deliverylocation.Width = 145;
            // 
            // comment
            // 
            this.comment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.comment.HeaderText = "Comment";
            this.comment.Name = "comment";
            this.comment.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 81.21828F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Material ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Material";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.FillWeight = 106.2606F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Measurement";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 120;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn5.HeaderText = "Unit Price";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // ViewGRN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 510);
            this.Controls.Add(this.DG_ViewGRNItem);
            this.Controls.Add(this.DG_ViewGRN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewGRN";
            this.Text = "ViewGRN";
            this.Load += new System.EventHandler(this.ViewGRN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_ViewGRNItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_ViewGRN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid DG_ViewGRNItem;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DG_ViewGRN;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrnNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Invoiceno;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliverylocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn comment;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}