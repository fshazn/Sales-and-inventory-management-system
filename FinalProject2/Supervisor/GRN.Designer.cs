namespace FinalProject2
{
    partial class GRN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GRN));
            this.lbl_AddNewProduct = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel_GRN = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_CancelNewGRN = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_createNewGRN = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.btn_createNewGRN)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_AddNewProduct
            // 
            this.lbl_AddNewProduct.AutoSize = true;
            this.lbl_AddNewProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_AddNewProduct.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AddNewProduct.Location = new System.Drawing.Point(616, 53);
            this.lbl_AddNewProduct.Name = "lbl_AddNewProduct";
            this.lbl_AddNewProduct.Size = new System.Drawing.Size(122, 19);
            this.lbl_AddNewProduct.TabIndex = 71;
            this.lbl_AddNewProduct.Text = "Create New GRN";
            // 
            // panel_GRN
            // 
            this.panel_GRN.Location = new System.Drawing.Point(34, 88);
            this.panel_GRN.Name = "panel_GRN";
            this.panel_GRN.Size = new System.Drawing.Size(760, 530);
            this.panel_GRN.TabIndex = 70;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(280, 9);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(252, 31);
            this.bunifuCustomLabel5.TabIndex = 69;
            this.bunifuCustomLabel5.Text = "Good Recieved Note";
            // 
            // btn_CancelNewGRN
            // 
            this.btn_CancelNewGRN.ActiveBorderThickness = 1;
            this.btn_CancelNewGRN.ActiveCornerRadius = 20;
            this.btn_CancelNewGRN.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_CancelNewGRN.ActiveForecolor = System.Drawing.Color.White;
            this.btn_CancelNewGRN.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_CancelNewGRN.BackColor = System.Drawing.SystemColors.Control;
            this.btn_CancelNewGRN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_CancelNewGRN.BackgroundImage")));
            this.btn_CancelNewGRN.ButtonText = "Cancel";
            this.btn_CancelNewGRN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CancelNewGRN.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelNewGRN.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_CancelNewGRN.IdleBorderThickness = 1;
            this.btn_CancelNewGRN.IdleCornerRadius = 20;
            this.btn_CancelNewGRN.IdleFillColor = System.Drawing.Color.White;
            this.btn_CancelNewGRN.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_CancelNewGRN.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_CancelNewGRN.Location = new System.Drawing.Point(689, 618);
            this.btn_CancelNewGRN.Margin = new System.Windows.Forms.Padding(5);
            this.btn_CancelNewGRN.Name = "btn_CancelNewGRN";
            this.btn_CancelNewGRN.Size = new System.Drawing.Size(105, 31);
            this.btn_CancelNewGRN.TabIndex = 73;
            this.btn_CancelNewGRN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_CancelNewGRN.Click += new System.EventHandler(this.btn_CancelNewGRN_Click);
            // 
            // btn_createNewGRN
            // 
            this.btn_createNewGRN.BackColor = System.Drawing.SystemColors.Control;
            this.btn_createNewGRN.Image = global::FinalProject2.Properties.Resources.icons8_add_new_100;
            this.btn_createNewGRN.ImageActive = null;
            this.btn_createNewGRN.Location = new System.Drawing.Point(744, 47);
            this.btn_createNewGRN.Name = "btn_createNewGRN";
            this.btn_createNewGRN.Size = new System.Drawing.Size(50, 35);
            this.btn_createNewGRN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_createNewGRN.TabIndex = 72;
            this.btn_createNewGRN.TabStop = false;
            this.btn_createNewGRN.Zoom = 10;
            this.btn_createNewGRN.Click += new System.EventHandler(this.btn_createNewGRN_Click);
            // 
            // GRN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 660);
            this.Controls.Add(this.btn_CancelNewGRN);
            this.Controls.Add(this.btn_createNewGRN);
            this.Controls.Add(this.lbl_AddNewProduct);
            this.Controls.Add(this.panel_GRN);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GRN";
            this.Text = "GRN";
            this.Load += new System.EventHandler(this.GRN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_createNewGRN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 btn_CancelNewGRN;
        private Bunifu.Framework.UI.BunifuImageButton btn_createNewGRN;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_AddNewProduct;
        private System.Windows.Forms.Panel panel_GRN;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
    }
}