namespace FinalProject2
{
    partial class TransferRequest
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransferRequest));
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DG_TransferRequest = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.C_TransferRequestID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_TransferRequestDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_TransferRequest = new System.Windows.Forms.Panel();
            this.btn_addNewTransferRequest = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbl_AddNewProduct = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_Refresh = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.DG_TransferRequest)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_addNewTransferRequest)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(302, 9);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(216, 31);
            this.bunifuCustomLabel5.TabIndex = 30;
            this.bunifuCustomLabel5.Text = "Transfer Request";
            // 
            // DG_TransferRequest
            // 
            this.DG_TransferRequest.AllowUserToAddRows = false;
            this.DG_TransferRequest.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DG_TransferRequest.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DG_TransferRequest.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DG_TransferRequest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DG_TransferRequest.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_TransferRequest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DG_TransferRequest.ColumnHeadersHeight = 30;
            this.DG_TransferRequest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C_TransferRequestID,
            this.C_TransferRequestDate,
            this.aid,
            this.C_Description});
            this.DG_TransferRequest.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_TransferRequest.DefaultCellStyle = dataGridViewCellStyle7;
            this.DG_TransferRequest.DoubleBuffered = true;
            this.DG_TransferRequest.EnableHeadersVisualStyles = false;
            this.DG_TransferRequest.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.DG_TransferRequest.HeaderForeColor = System.Drawing.SystemColors.Control;
            this.DG_TransferRequest.Location = new System.Drawing.Point(38, 82);
            this.DG_TransferRequest.Name = "DG_TransferRequest";
            this.DG_TransferRequest.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_TransferRequest.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DG_TransferRequest.RowHeadersVisible = false;
            this.DG_TransferRequest.Size = new System.Drawing.Size(760, 199);
            this.DG_TransferRequest.TabIndex = 29;
            this.DG_TransferRequest.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_TransferRequest_CellClick);
            this.DG_TransferRequest.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DG_TransferRequest_CellMouseUp);
            // 
            // C_TransferRequestID
            // 
            this.C_TransferRequestID.FillWeight = 81.21828F;
            this.C_TransferRequestID.HeaderText = "Transfer Request ID";
            this.C_TransferRequestID.Name = "C_TransferRequestID";
            this.C_TransferRequestID.ReadOnly = true;
            this.C_TransferRequestID.Width = 200;
            // 
            // C_TransferRequestDate
            // 
            this.C_TransferRequestDate.FillWeight = 106.2606F;
            this.C_TransferRequestDate.HeaderText = "Request Date";
            this.C_TransferRequestDate.Name = "C_TransferRequestDate";
            this.C_TransferRequestDate.Width = 200;
            // 
            // aid
            // 
            this.aid.HeaderText = "AID";
            this.aid.Name = "aid";
            this.aid.Visible = false;
            // 
            // C_Description
            // 
            this.C_Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.C_Description.FillWeight = 106.2606F;
            this.C_Description.HeaderText = "Description";
            this.C_Description.Name = "C_Description";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(118, 48);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            // 
            // panel_TransferRequest
            // 
            this.panel_TransferRequest.Location = new System.Drawing.Point(38, 318);
            this.panel_TransferRequest.Name = "panel_TransferRequest";
            this.panel_TransferRequest.Size = new System.Drawing.Size(760, 335);
            this.panel_TransferRequest.TabIndex = 31;
            // 
            // btn_addNewTransferRequest
            // 
            this.btn_addNewTransferRequest.BackColor = System.Drawing.SystemColors.Control;
            this.btn_addNewTransferRequest.Image = global::FinalProject2.Properties.Resources.icons8_add_new_100;
            this.btn_addNewTransferRequest.ImageActive = null;
            this.btn_addNewTransferRequest.Location = new System.Drawing.Point(747, 42);
            this.btn_addNewTransferRequest.Name = "btn_addNewTransferRequest";
            this.btn_addNewTransferRequest.Size = new System.Drawing.Size(50, 35);
            this.btn_addNewTransferRequest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_addNewTransferRequest.TabIndex = 40;
            this.btn_addNewTransferRequest.TabStop = false;
            this.btn_addNewTransferRequest.Zoom = 10;
            this.btn_addNewTransferRequest.Click += new System.EventHandler(this.btn_addNewTransferRequest_Click);
            // 
            // lbl_AddNewProduct
            // 
            this.lbl_AddNewProduct.AutoSize = true;
            this.lbl_AddNewProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_AddNewProduct.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AddNewProduct.Location = new System.Drawing.Point(551, 50);
            this.lbl_AddNewProduct.Name = "lbl_AddNewProduct";
            this.lbl_AddNewProduct.Size = new System.Drawing.Size(190, 19);
            this.lbl_AddNewProduct.TabIndex = 39;
            this.lbl_AddNewProduct.Text = "Add New Transfer Request";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.ActiveBorderThickness = 1;
            this.btn_Refresh.ActiveCornerRadius = 20;
            this.btn_Refresh.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_Refresh.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Refresh.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Refresh.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Refresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Refresh.BackgroundImage")));
            this.btn_Refresh.ButtonText = "Refresh";
            this.btn_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Refresh.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_Refresh.IdleBorderThickness = 1;
            this.btn_Refresh.IdleCornerRadius = 20;
            this.btn_Refresh.IdleFillColor = System.Drawing.Color.White;
            this.btn_Refresh.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_Refresh.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Refresh.Location = new System.Drawing.Point(700, 279);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(97, 31);
            this.btn_Refresh.TabIndex = 47;
            this.btn_Refresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // TransferRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 660);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_addNewTransferRequest);
            this.Controls.Add(this.lbl_AddNewProduct);
            this.Controls.Add(this.panel_TransferRequest);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.DG_TransferRequest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TransferRequest";
            this.Text = "TransferRequest";
            this.Load += new System.EventHandler(this.TransferRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_TransferRequest)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_addNewTransferRequest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DG_TransferRequest;
        private System.Windows.Forms.Panel panel_TransferRequest;
        private Bunifu.Framework.UI.BunifuImageButton btn_addNewTransferRequest;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_AddNewProduct;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Refresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_TransferRequestID;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_TransferRequestDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn aid;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Description;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
    }
}