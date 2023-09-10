namespace FinalProject2
{
    partial class Invoices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Invoices));
            this.lbl_AddNewProduct = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel_GRN = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_CancelNewInvoice = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_createNewInvoice = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.btn_createNewInvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_AddNewProduct
            // 
            this.lbl_AddNewProduct.AutoSize = true;
            this.lbl_AddNewProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_AddNewProduct.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AddNewProduct.Location = new System.Drawing.Point(575, 48);
            this.lbl_AddNewProduct.Name = "lbl_AddNewProduct";
            this.lbl_AddNewProduct.Size = new System.Drawing.Size(151, 19);
            this.lbl_AddNewProduct.TabIndex = 76;
            this.lbl_AddNewProduct.Text = "Add Supplier Invoice";
            // 
            // panel_GRN
            // 
            this.panel_GRN.Location = new System.Drawing.Point(35, 82);
            this.panel_GRN.Name = "panel_GRN";
            this.panel_GRN.Size = new System.Drawing.Size(760, 530);
            this.panel_GRN.TabIndex = 75;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(305, 9);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(217, 31);
            this.bunifuCustomLabel5.TabIndex = 74;
            this.bunifuCustomLabel5.Text = "Supplier Invoices";
            // 
            // btn_CancelNewInvoice
            // 
            this.btn_CancelNewInvoice.ActiveBorderThickness = 1;
            this.btn_CancelNewInvoice.ActiveCornerRadius = 20;
            this.btn_CancelNewInvoice.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_CancelNewInvoice.ActiveForecolor = System.Drawing.Color.White;
            this.btn_CancelNewInvoice.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_CancelNewInvoice.BackColor = System.Drawing.SystemColors.Control;
            this.btn_CancelNewInvoice.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_CancelNewInvoice.BackgroundImage")));
            this.btn_CancelNewInvoice.ButtonText = "Cancel";
            this.btn_CancelNewInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CancelNewInvoice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelNewInvoice.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_CancelNewInvoice.IdleBorderThickness = 1;
            this.btn_CancelNewInvoice.IdleCornerRadius = 20;
            this.btn_CancelNewInvoice.IdleFillColor = System.Drawing.Color.White;
            this.btn_CancelNewInvoice.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_CancelNewInvoice.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_CancelNewInvoice.Location = new System.Drawing.Point(679, 619);
            this.btn_CancelNewInvoice.Margin = new System.Windows.Forms.Padding(5);
            this.btn_CancelNewInvoice.Name = "btn_CancelNewInvoice";
            this.btn_CancelNewInvoice.Size = new System.Drawing.Size(105, 31);
            this.btn_CancelNewInvoice.TabIndex = 78;
            this.btn_CancelNewInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_CancelNewInvoice.Click += new System.EventHandler(this.btn_CancelNewInvoice_Click);
            // 
            // btn_createNewInvoice
            // 
            this.btn_createNewInvoice.BackColor = System.Drawing.SystemColors.Control;
            this.btn_createNewInvoice.Image = global::FinalProject2.Properties.Resources.icons8_add_new_100;
            this.btn_createNewInvoice.ImageActive = null;
            this.btn_createNewInvoice.Location = new System.Drawing.Point(732, 41);
            this.btn_createNewInvoice.Name = "btn_createNewInvoice";
            this.btn_createNewInvoice.Size = new System.Drawing.Size(50, 35);
            this.btn_createNewInvoice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_createNewInvoice.TabIndex = 77;
            this.btn_createNewInvoice.TabStop = false;
            this.btn_createNewInvoice.Zoom = 10;
            this.btn_createNewInvoice.Click += new System.EventHandler(this.btn_createNewInvoice_Click);
            // 
            // Invoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 660);
            this.Controls.Add(this.btn_CancelNewInvoice);
            this.Controls.Add(this.btn_createNewInvoice);
            this.Controls.Add(this.lbl_AddNewProduct);
            this.Controls.Add(this.panel_GRN);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Invoices";
            this.Text = "Invoices";
            this.Load += new System.EventHandler(this.Invoices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_createNewInvoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 btn_CancelNewInvoice;
        private Bunifu.Framework.UI.BunifuImageButton btn_createNewInvoice;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_AddNewProduct;
        private System.Windows.Forms.Panel panel_GRN;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
    }
}