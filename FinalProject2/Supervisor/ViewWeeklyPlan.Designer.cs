namespace FinalProject2
{
    partial class ViewWeeklyPlan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewWeeklyPlan));
            this.DG_ViewWeeklyPlanItem = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.DG_WeeklyPlan = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btn_GenerateWP = new Bunifu.Framework.UI.BunifuThinButton2();
            this.productid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issuedfor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duedate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DG_ViewWeeklyPlanItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_WeeklyPlan)).BeginInit();
            this.SuspendLayout();
            // 
            // DG_ViewWeeklyPlanItem
            // 
            this.DG_ViewWeeklyPlanItem.AllowUserToAddRows = false;
            this.DG_ViewWeeklyPlanItem.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DG_ViewWeeklyPlanItem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DG_ViewWeeklyPlanItem.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DG_ViewWeeklyPlanItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DG_ViewWeeklyPlanItem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_ViewWeeklyPlanItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DG_ViewWeeklyPlanItem.ColumnHeadersHeight = 30;
            this.DG_ViewWeeklyPlanItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productid,
            this.productname,
            this.amount,
            this.unit});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_ViewWeeklyPlanItem.DefaultCellStyle = dataGridViewCellStyle3;
            this.DG_ViewWeeklyPlanItem.DoubleBuffered = true;
            this.DG_ViewWeeklyPlanItem.EnableHeadersVisualStyles = false;
            this.DG_ViewWeeklyPlanItem.HeaderBgColor = System.Drawing.Color.White;
            this.DG_ViewWeeklyPlanItem.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.DG_ViewWeeklyPlanItem.Location = new System.Drawing.Point(3, 249);
            this.DG_ViewWeeklyPlanItem.Name = "DG_ViewWeeklyPlanItem";
            this.DG_ViewWeeklyPlanItem.ReadOnly = true;
            this.DG_ViewWeeklyPlanItem.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_ViewWeeklyPlanItem.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DG_ViewWeeklyPlanItem.Size = new System.Drawing.Size(754, 203);
            this.DG_ViewWeeklyPlanItem.TabIndex = 35;
            // 
            // DG_WeeklyPlan
            // 
            this.DG_WeeklyPlan.AllowUserToAddRows = false;
            this.DG_WeeklyPlan.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DG_WeeklyPlan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DG_WeeklyPlan.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DG_WeeklyPlan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DG_WeeklyPlan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_WeeklyPlan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DG_WeeklyPlan.ColumnHeadersHeight = 30;
            this.DG_WeeklyPlan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.planid,
            this.issuedfor,
            this.date,
            this.duedate,
            this.description});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_WeeklyPlan.DefaultCellStyle = dataGridViewCellStyle7;
            this.DG_WeeklyPlan.DoubleBuffered = true;
            this.DG_WeeklyPlan.EnableHeadersVisualStyles = false;
            this.DG_WeeklyPlan.HeaderBgColor = System.Drawing.Color.White;
            this.DG_WeeklyPlan.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.DG_WeeklyPlan.Location = new System.Drawing.Point(3, 20);
            this.DG_WeeklyPlan.Name = "DG_WeeklyPlan";
            this.DG_WeeklyPlan.ReadOnly = true;
            this.DG_WeeklyPlan.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_WeeklyPlan.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DG_WeeklyPlan.Size = new System.Drawing.Size(754, 203);
            this.DG_WeeklyPlan.TabIndex = 34;
            this.DG_WeeklyPlan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_WeeklyPlan_CellClick);
            // 
            // btn_GenerateWP
            // 
            this.btn_GenerateWP.ActiveBorderThickness = 1;
            this.btn_GenerateWP.ActiveCornerRadius = 20;
            this.btn_GenerateWP.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_GenerateWP.ActiveForecolor = System.Drawing.Color.White;
            this.btn_GenerateWP.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_GenerateWP.BackColor = System.Drawing.SystemColors.Control;
            this.btn_GenerateWP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_GenerateWP.BackgroundImage")));
            this.btn_GenerateWP.ButtonText = "Generate";
            this.btn_GenerateWP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_GenerateWP.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GenerateWP.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_GenerateWP.IdleBorderThickness = 1;
            this.btn_GenerateWP.IdleCornerRadius = 20;
            this.btn_GenerateWP.IdleFillColor = System.Drawing.Color.White;
            this.btn_GenerateWP.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_GenerateWP.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_GenerateWP.Location = new System.Drawing.Point(285, 469);
            this.btn_GenerateWP.Margin = new System.Windows.Forms.Padding(5);
            this.btn_GenerateWP.Name = "btn_GenerateWP";
            this.btn_GenerateWP.Size = new System.Drawing.Size(105, 31);
            this.btn_GenerateWP.TabIndex = 36;
            this.btn_GenerateWP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // productid
            // 
            this.productid.FillWeight = 81.21828F;
            this.productid.HeaderText = "Activity";
            this.productid.Name = "productid";
            this.productid.ReadOnly = true;
            this.productid.Width = 200;
            // 
            // productname
            // 
            this.productname.HeaderText = "Product Name";
            this.productname.Name = "productname";
            this.productname.ReadOnly = true;
            this.productname.Width = 150;
            // 
            // amount
            // 
            this.amount.FillWeight = 106.2606F;
            this.amount.HeaderText = "Amount";
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            this.amount.Width = 150;
            // 
            // unit
            // 
            this.unit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.unit.FillWeight = 106.2606F;
            this.unit.HeaderText = "Measurement";
            this.unit.Name = "unit";
            this.unit.ReadOnly = true;
            // 
            // planid
            // 
            this.planid.FillWeight = 81.21828F;
            this.planid.HeaderText = "Plan ID";
            this.planid.Name = "planid";
            this.planid.ReadOnly = true;
            // 
            // issuedfor
            // 
            this.issuedfor.HeaderText = "Issued for";
            this.issuedfor.Name = "issuedfor";
            this.issuedfor.ReadOnly = true;
            this.issuedfor.Width = 150;
            // 
            // date
            // 
            this.date.FillWeight = 106.2606F;
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 150;
            // 
            // duedate
            // 
            this.duedate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.duedate.FillWeight = 106.2606F;
            this.duedate.HeaderText = "Due Date";
            this.duedate.Name = "duedate";
            this.duedate.ReadOnly = true;
            // 
            // description
            // 
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Width = 150;
            // 
            // ViewWeeklyPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 510);
            this.Controls.Add(this.btn_GenerateWP);
            this.Controls.Add(this.DG_ViewWeeklyPlanItem);
            this.Controls.Add(this.DG_WeeklyPlan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewWeeklyPlan";
            this.Text = "ViewWeeklyPlan";
            this.Load += new System.EventHandler(this.ViewWeeklyPlan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_ViewWeeklyPlanItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_WeeklyPlan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid DG_ViewWeeklyPlanItem;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DG_WeeklyPlan;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_GenerateWP;
        private System.Windows.Forms.DataGridViewTextBoxColumn productid;
        private System.Windows.Forms.DataGridViewTextBoxColumn productname;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn planid;
        private System.Windows.Forms.DataGridViewTextBoxColumn issuedfor;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn duedate;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
    }
}