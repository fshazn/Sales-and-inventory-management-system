namespace FinalProject2
{
    partial class WeeklyPlan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeeklyPlan));
            this.lbl_AddNewProduct = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel_WeeklyPlan = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_createNewWeeklyPlan = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_CancelNewPlan = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.btn_createNewWeeklyPlan)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_AddNewProduct
            // 
            this.lbl_AddNewProduct.AutoSize = true;
            this.lbl_AddNewProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_AddNewProduct.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AddNewProduct.Location = new System.Drawing.Point(616, 50);
            this.lbl_AddNewProduct.Name = "lbl_AddNewProduct";
            this.lbl_AddNewProduct.Size = new System.Drawing.Size(122, 19);
            this.lbl_AddNewProduct.TabIndex = 43;
            this.lbl_AddNewProduct.Text = "Create New Plan";
            // 
            // panel_WeeklyPlan
            // 
            this.panel_WeeklyPlan.Location = new System.Drawing.Point(35, 95);
            this.panel_WeeklyPlan.Name = "panel_WeeklyPlan";
            this.panel_WeeklyPlan.Size = new System.Drawing.Size(760, 510);
            this.panel_WeeklyPlan.TabIndex = 42;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(347, 9);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(162, 31);
            this.bunifuCustomLabel5.TabIndex = 41;
            this.bunifuCustomLabel5.Text = "Weekly Plan";
            // 
            // btn_createNewWeeklyPlan
            // 
            this.btn_createNewWeeklyPlan.BackColor = System.Drawing.SystemColors.Control;
            this.btn_createNewWeeklyPlan.Image = global::FinalProject2.Properties.Resources.icons8_add_new_100;
            this.btn_createNewWeeklyPlan.ImageActive = null;
            this.btn_createNewWeeklyPlan.Location = new System.Drawing.Point(744, 44);
            this.btn_createNewWeeklyPlan.Name = "btn_createNewWeeklyPlan";
            this.btn_createNewWeeklyPlan.Size = new System.Drawing.Size(50, 35);
            this.btn_createNewWeeklyPlan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_createNewWeeklyPlan.TabIndex = 44;
            this.btn_createNewWeeklyPlan.TabStop = false;
            this.btn_createNewWeeklyPlan.Zoom = 10;
            this.btn_createNewWeeklyPlan.Click += new System.EventHandler(this.btn_createNewWeeklyPlan_Click);
            // 
            // btn_CancelNewPlan
            // 
            this.btn_CancelNewPlan.ActiveBorderThickness = 1;
            this.btn_CancelNewPlan.ActiveCornerRadius = 20;
            this.btn_CancelNewPlan.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_CancelNewPlan.ActiveForecolor = System.Drawing.Color.White;
            this.btn_CancelNewPlan.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_CancelNewPlan.BackColor = System.Drawing.SystemColors.Control;
            this.btn_CancelNewPlan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_CancelNewPlan.BackgroundImage")));
            this.btn_CancelNewPlan.ButtonText = "Cancel";
            this.btn_CancelNewPlan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CancelNewPlan.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelNewPlan.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_CancelNewPlan.IdleBorderThickness = 1;
            this.btn_CancelNewPlan.IdleCornerRadius = 20;
            this.btn_CancelNewPlan.IdleFillColor = System.Drawing.Color.White;
            this.btn_CancelNewPlan.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_CancelNewPlan.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_CancelNewPlan.Location = new System.Drawing.Point(689, 615);
            this.btn_CancelNewPlan.Margin = new System.Windows.Forms.Padding(5);
            this.btn_CancelNewPlan.Name = "btn_CancelNewPlan";
            this.btn_CancelNewPlan.Size = new System.Drawing.Size(105, 31);
            this.btn_CancelNewPlan.TabIndex = 63;
            this.btn_CancelNewPlan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_CancelNewPlan.Click += new System.EventHandler(this.btn_CancelNewPlan_Click);
            // 
            // WeeklyPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 660);
            this.Controls.Add(this.btn_CancelNewPlan);
            this.Controls.Add(this.btn_createNewWeeklyPlan);
            this.Controls.Add(this.lbl_AddNewProduct);
            this.Controls.Add(this.panel_WeeklyPlan);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WeeklyPlan";
            this.Text = "WeeklyPlan";
            this.Load += new System.EventHandler(this.WeeklyPlan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_createNewWeeklyPlan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton btn_createNewWeeklyPlan;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_AddNewProduct;
        private System.Windows.Forms.Panel panel_WeeklyPlan;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_CancelNewPlan;
    }
}