namespace FinalProject2
{
    partial class PurchaseOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseOrder));
            this.btn_CancelNewPO = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_createNewPO = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbl_AddNewProduct = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel_PO = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.btn_createNewPO)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_CancelNewPO
            // 
            this.btn_CancelNewPO.ActiveBorderThickness = 1;
            this.btn_CancelNewPO.ActiveCornerRadius = 20;
            this.btn_CancelNewPO.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_CancelNewPO.ActiveForecolor = System.Drawing.Color.White;
            this.btn_CancelNewPO.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_CancelNewPO.BackColor = System.Drawing.SystemColors.Control;
            this.btn_CancelNewPO.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_CancelNewPO.BackgroundImage")));
            this.btn_CancelNewPO.ButtonText = "Cancel";
            this.btn_CancelNewPO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CancelNewPO.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelNewPO.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_CancelNewPO.IdleBorderThickness = 1;
            this.btn_CancelNewPO.IdleCornerRadius = 20;
            this.btn_CancelNewPO.IdleFillColor = System.Drawing.Color.White;
            this.btn_CancelNewPO.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_CancelNewPO.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_CancelNewPO.Location = new System.Drawing.Point(680, 618);
            this.btn_CancelNewPO.Margin = new System.Windows.Forms.Padding(5);
            this.btn_CancelNewPO.Name = "btn_CancelNewPO";
            this.btn_CancelNewPO.Size = new System.Drawing.Size(105, 31);
            this.btn_CancelNewPO.TabIndex = 68;
            this.btn_CancelNewPO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_CancelNewPO.Click += new System.EventHandler(this.btn_CancelNewPO_Click);
            // 
            // btn_createNewPO
            // 
            this.btn_createNewPO.BackColor = System.Drawing.SystemColors.Control;
            this.btn_createNewPO.Image = global::FinalProject2.Properties.Resources.icons8_add_new_100;
            this.btn_createNewPO.ImageActive = null;
            this.btn_createNewPO.Location = new System.Drawing.Point(744, 47);
            this.btn_createNewPO.Name = "btn_createNewPO";
            this.btn_createNewPO.Size = new System.Drawing.Size(50, 35);
            this.btn_createNewPO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_createNewPO.TabIndex = 67;
            this.btn_createNewPO.TabStop = false;
            this.btn_createNewPO.Zoom = 10;
            this.btn_createNewPO.Click += new System.EventHandler(this.btn_createNewPO_Click);
            // 
            // lbl_AddNewProduct
            // 
            this.lbl_AddNewProduct.AutoSize = true;
            this.lbl_AddNewProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_AddNewProduct.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AddNewProduct.Location = new System.Drawing.Point(616, 53);
            this.lbl_AddNewProduct.Name = "lbl_AddNewProduct";
            this.lbl_AddNewProduct.Size = new System.Drawing.Size(112, 19);
            this.lbl_AddNewProduct.TabIndex = 66;
            this.lbl_AddNewProduct.Text = "Create New PO";
            // 
            // panel_PO
            // 
            this.panel_PO.Location = new System.Drawing.Point(35, 98);
            this.panel_PO.Name = "panel_PO";
            this.panel_PO.Size = new System.Drawing.Size(760, 510);
            this.panel_PO.TabIndex = 65;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(317, 9);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(201, 31);
            this.bunifuCustomLabel5.TabIndex = 64;
            this.bunifuCustomLabel5.Text = "Purchase Order";
            // 
            // PurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 660);
            this.Controls.Add(this.btn_CancelNewPO);
            this.Controls.Add(this.btn_createNewPO);
            this.Controls.Add(this.lbl_AddNewProduct);
            this.Controls.Add(this.panel_PO);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PurchaseOrder";
            this.Text = "PurchaseOrder";
            this.Load += new System.EventHandler(this.PurchaseOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_createNewPO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 btn_CancelNewPO;
        private Bunifu.Framework.UI.BunifuImageButton btn_createNewPO;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_AddNewProduct;
        private System.Windows.Forms.Panel panel_PO;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
    }
}