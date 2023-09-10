namespace FinalProject2
{
    partial class WeeklyProgress
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeeklyProgress));
            this.lbl_AddNewProduct = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel_WeeklyProgress = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_CancelWeeklyProgress = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_addNewWeeklyProgress = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.btn_addNewWeeklyProgress)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_AddNewProduct
            // 
            this.lbl_AddNewProduct.AutoSize = true;
            this.lbl_AddNewProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_AddNewProduct.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AddNewProduct.Location = new System.Drawing.Point(534, 61);
            this.lbl_AddNewProduct.Name = "lbl_AddNewProduct";
            this.lbl_AddNewProduct.Size = new System.Drawing.Size(204, 19);
            this.lbl_AddNewProduct.TabIndex = 47;
            this.lbl_AddNewProduct.Text = "Create New Weekly Progress";
            // 
            // panel_WeeklyProgress
            // 
            this.panel_WeeklyProgress.Location = new System.Drawing.Point(35, 96);
            this.panel_WeeklyProgress.Name = "panel_WeeklyProgress";
            this.panel_WeeklyProgress.Size = new System.Drawing.Size(760, 510);
            this.panel_WeeklyProgress.TabIndex = 46;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(326, 10);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(210, 31);
            this.bunifuCustomLabel5.TabIndex = 45;
            this.bunifuCustomLabel5.Text = "Weekly Progress";
            // 
            // btn_CancelWeeklyProgress
            // 
            this.btn_CancelWeeklyProgress.ActiveBorderThickness = 1;
            this.btn_CancelWeeklyProgress.ActiveCornerRadius = 20;
            this.btn_CancelWeeklyProgress.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_CancelWeeklyProgress.ActiveForecolor = System.Drawing.Color.White;
            this.btn_CancelWeeklyProgress.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_CancelWeeklyProgress.BackColor = System.Drawing.SystemColors.Control;
            this.btn_CancelWeeklyProgress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_CancelWeeklyProgress.BackgroundImage")));
            this.btn_CancelWeeklyProgress.ButtonText = "Cancel";
            this.btn_CancelWeeklyProgress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CancelWeeklyProgress.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelWeeklyProgress.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_CancelWeeklyProgress.IdleBorderThickness = 1;
            this.btn_CancelWeeklyProgress.IdleCornerRadius = 20;
            this.btn_CancelWeeklyProgress.IdleFillColor = System.Drawing.Color.White;
            this.btn_CancelWeeklyProgress.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_CancelWeeklyProgress.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_CancelWeeklyProgress.Location = new System.Drawing.Point(687, 615);
            this.btn_CancelWeeklyProgress.Margin = new System.Windows.Forms.Padding(5);
            this.btn_CancelWeeklyProgress.Name = "btn_CancelWeeklyProgress";
            this.btn_CancelWeeklyProgress.Size = new System.Drawing.Size(105, 31);
            this.btn_CancelWeeklyProgress.TabIndex = 35;
            this.btn_CancelWeeklyProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_CancelWeeklyProgress.Click += new System.EventHandler(this.btn_CancelWeeklyProgress_Click);
            // 
            // btn_addNewWeeklyProgress
            // 
            this.btn_addNewWeeklyProgress.BackColor = System.Drawing.SystemColors.Control;
            this.btn_addNewWeeklyProgress.Image = global::FinalProject2.Properties.Resources.icons8_add_new_100;
            this.btn_addNewWeeklyProgress.ImageActive = null;
            this.btn_addNewWeeklyProgress.Location = new System.Drawing.Point(744, 56);
            this.btn_addNewWeeklyProgress.Name = "btn_addNewWeeklyProgress";
            this.btn_addNewWeeklyProgress.Size = new System.Drawing.Size(50, 35);
            this.btn_addNewWeeklyProgress.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_addNewWeeklyProgress.TabIndex = 48;
            this.btn_addNewWeeklyProgress.TabStop = false;
            this.btn_addNewWeeklyProgress.Zoom = 10;
            this.btn_addNewWeeklyProgress.Click += new System.EventHandler(this.btn_addNewWeeklyProgress_Click);
            // 
            // WeeklyProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 660);
            this.Controls.Add(this.btn_CancelWeeklyProgress);
            this.Controls.Add(this.lbl_AddNewProduct);
            this.Controls.Add(this.panel_WeeklyProgress);
            this.Controls.Add(this.btn_addNewWeeklyProgress);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WeeklyProgress";
            this.Text = "WeeklyProgress";
            this.Load += new System.EventHandler(this.WeeklyProgress_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_addNewWeeklyProgress)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel lbl_AddNewProduct;
        private System.Windows.Forms.Panel panel_WeeklyProgress;
        private Bunifu.Framework.UI.BunifuImageButton btn_addNewWeeklyProgress;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_CancelWeeklyProgress;
    }
}