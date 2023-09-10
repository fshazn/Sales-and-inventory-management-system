namespace FinalProject2
{
    partial class Weekly_Plan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Weekly_Plan));
            this.lbl_AddNewProduct = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DG_WeeklyPlans = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.C_WeeklyPlanID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_WeeklyPlanDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_WeeklyPlanDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_AID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DG_ViewWeeklyPlans = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.activity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_AddNewWeeklyPlan = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_add = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.DG_WeeklyPlans)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_ViewWeeklyPlans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_AddNewWeeklyPlan)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_AddNewProduct
            // 
            this.lbl_AddNewProduct.AutoSize = true;
            this.lbl_AddNewProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_AddNewProduct.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AddNewProduct.Location = new System.Drawing.Point(562, 64);
            this.lbl_AddNewProduct.Name = "lbl_AddNewProduct";
            this.lbl_AddNewProduct.Size = new System.Drawing.Size(176, 19);
            this.lbl_AddNewProduct.TabIndex = 43;
            this.lbl_AddNewProduct.Text = "Create New Weekly Plan";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(299, 22);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(215, 31);
            this.bunifuCustomLabel5.TabIndex = 42;
            this.bunifuCustomLabel5.Text = "WEEKLY PLAN";
            // 
            // DG_WeeklyPlans
            // 
            this.DG_WeeklyPlans.AllowUserToAddRows = false;
            this.DG_WeeklyPlans.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DG_WeeklyPlans.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DG_WeeklyPlans.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DG_WeeklyPlans.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DG_WeeklyPlans.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_WeeklyPlans.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DG_WeeklyPlans.ColumnHeadersHeight = 30;
            this.DG_WeeklyPlans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C_WeeklyPlanID,
            this.C_WeeklyPlanDate,
            this.C_WeeklyPlanDueDate,
            this.C_Description,
            this.C_AID});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_WeeklyPlans.DefaultCellStyle = dataGridViewCellStyle3;
            this.DG_WeeklyPlans.DoubleBuffered = true;
            this.DG_WeeklyPlans.EnableHeadersVisualStyles = false;
            this.DG_WeeklyPlans.HeaderBgColor = System.Drawing.Color.White;
            this.DG_WeeklyPlans.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.DG_WeeklyPlans.Location = new System.Drawing.Point(0, 3);
            this.DG_WeeklyPlans.Name = "DG_WeeklyPlans";
            this.DG_WeeklyPlans.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_WeeklyPlans.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DG_WeeklyPlans.Size = new System.Drawing.Size(760, 199);
            this.DG_WeeklyPlans.TabIndex = 41;
            // 
            // C_WeeklyPlanID
            // 
            this.C_WeeklyPlanID.FillWeight = 81.21828F;
            this.C_WeeklyPlanID.HeaderText = "Weekly Plan ID";
            this.C_WeeklyPlanID.Name = "C_WeeklyPlanID";
            this.C_WeeklyPlanID.ReadOnly = true;
            this.C_WeeklyPlanID.Width = 150;
            // 
            // C_WeeklyPlanDate
            // 
            this.C_WeeklyPlanDate.FillWeight = 106.2606F;
            this.C_WeeklyPlanDate.HeaderText = "Date";
            this.C_WeeklyPlanDate.Name = "C_WeeklyPlanDate";
            this.C_WeeklyPlanDate.Width = 120;
            // 
            // C_WeeklyPlanDueDate
            // 
            this.C_WeeklyPlanDueDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.C_WeeklyPlanDueDate.FillWeight = 106.2606F;
            this.C_WeeklyPlanDueDate.HeaderText = "Due Date";
            this.C_WeeklyPlanDueDate.Name = "C_WeeklyPlanDueDate";
            // 
            // C_Description
            // 
            this.C_Description.HeaderText = "Description";
            this.C_Description.Name = "C_Description";
            this.C_Description.Width = 200;
            // 
            // C_AID
            // 
            this.C_AID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.C_AID.HeaderText = "Issued For";
            this.C_AID.Name = "C_AID";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.DG_ViewWeeklyPlans);
            this.panel1.Controls.Add(this.DG_WeeklyPlans);
            this.panel1.Location = new System.Drawing.Point(38, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 551);
            this.panel1.TabIndex = 45;
            // 
            // DG_ViewWeeklyPlans
            // 
            this.DG_ViewWeeklyPlans.AllowUserToAddRows = false;
            this.DG_ViewWeeklyPlans.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DG_ViewWeeklyPlans.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DG_ViewWeeklyPlans.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DG_ViewWeeklyPlans.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DG_ViewWeeklyPlans.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_ViewWeeklyPlans.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DG_ViewWeeklyPlans.ColumnHeadersHeight = 30;
            this.DG_ViewWeeklyPlans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.activity,
            this.product,
            this.amount});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_ViewWeeklyPlans.DefaultCellStyle = dataGridViewCellStyle7;
            this.DG_ViewWeeklyPlans.DoubleBuffered = true;
            this.DG_ViewWeeklyPlans.EnableHeadersVisualStyles = false;
            this.DG_ViewWeeklyPlans.HeaderBgColor = System.Drawing.Color.White;
            this.DG_ViewWeeklyPlans.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.DG_ViewWeeklyPlans.Location = new System.Drawing.Point(55, 264);
            this.DG_ViewWeeklyPlans.Name = "DG_ViewWeeklyPlans";
            this.DG_ViewWeeklyPlans.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_ViewWeeklyPlans.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DG_ViewWeeklyPlans.Size = new System.Drawing.Size(661, 199);
            this.DG_ViewWeeklyPlans.TabIndex = 42;
            // 
            // activity
            // 
            this.activity.FillWeight = 81.21828F;
            this.activity.HeaderText = "Activity";
            this.activity.Name = "activity";
            this.activity.ReadOnly = true;
            this.activity.Width = 250;
            // 
            // product
            // 
            this.product.FillWeight = 106.2606F;
            this.product.HeaderText = "Product";
            this.product.Name = "product";
            this.product.Width = 170;
            // 
            // amount
            // 
            this.amount.FillWeight = 106.2606F;
            this.amount.HeaderText = "Amount";
            this.amount.Name = "amount";
            this.amount.Width = 299;
            // 
            // btn_AddNewWeeklyPlan
            // 
            this.btn_AddNewWeeklyPlan.BackColor = System.Drawing.SystemColors.Control;
            this.btn_AddNewWeeklyPlan.Image = global::FinalProject2.Properties.Resources.icons8_add_new_100;
            this.btn_AddNewWeeklyPlan.ImageActive = null;
            this.btn_AddNewWeeklyPlan.Location = new System.Drawing.Point(737, 56);
            this.btn_AddNewWeeklyPlan.Name = "btn_AddNewWeeklyPlan";
            this.btn_AddNewWeeklyPlan.Size = new System.Drawing.Size(51, 35);
            this.btn_AddNewWeeklyPlan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_AddNewWeeklyPlan.TabIndex = 44;
            this.btn_AddNewWeeklyPlan.TabStop = false;
            this.btn_AddNewWeeklyPlan.Zoom = 10;
            // 
            // btn_add
            // 
            this.btn_add.ActiveBorderThickness = 1;
            this.btn_add.ActiveCornerRadius = 20;
            this.btn_add.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_add.ActiveForecolor = System.Drawing.Color.White;
            this.btn_add.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_add.BackColor = System.Drawing.SystemColors.Control;
            this.btn_add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_add.BackgroundImage")));
            this.btn_add.ButtonText = "Generate Plan";
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_add.IdleBorderThickness = 1;
            this.btn_add.IdleCornerRadius = 20;
            this.btn_add.IdleFillColor = System.Drawing.Color.White;
            this.btn_add.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_add.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_add.Location = new System.Drawing.Point(312, 499);
            this.btn_add.Margin = new System.Windows.Forms.Padding(5);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(146, 31);
            this.btn_add.TabIndex = 60;
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Weekly_Plan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 660);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_AddNewWeeklyPlan);
            this.Controls.Add(this.lbl_AddNewProduct);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Weekly_Plan";
            this.Text = "Weekly_Plan";
            ((System.ComponentModel.ISupportInitialize)(this.DG_WeeklyPlans)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DG_ViewWeeklyPlans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_AddNewWeeklyPlan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton btn_AddNewWeeklyPlan;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_AddNewProduct;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DG_WeeklyPlans;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_WeeklyPlanID;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_WeeklyPlanDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_WeeklyPlanDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_AID;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DG_ViewWeeklyPlans;
        private System.Windows.Forms.DataGridViewTextBoxColumn activity;
        private System.Windows.Forms.DataGridViewTextBoxColumn product;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_add;
    }
}