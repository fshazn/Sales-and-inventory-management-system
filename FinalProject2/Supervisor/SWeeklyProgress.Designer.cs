namespace FinalProject2.Supervisor
{
    partial class SWeeklyProgress
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
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DG_ViewWeeklyProgressItem = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.DG_WeeklyProgress = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.progressid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agunit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DG_ViewWeeklyProgressItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_WeeklyProgress)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(311, 9);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(210, 31);
            this.bunifuCustomLabel5.TabIndex = 46;
            this.bunifuCustomLabel5.Text = "Weekly Progress";
            // 
            // DG_ViewWeeklyProgressItem
            // 
            this.DG_ViewWeeklyProgressItem.AllowUserToAddRows = false;
            this.DG_ViewWeeklyProgressItem.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DG_ViewWeeklyProgressItem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DG_ViewWeeklyProgressItem.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DG_ViewWeeklyProgressItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DG_ViewWeeklyProgressItem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_ViewWeeklyProgressItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DG_ViewWeeklyProgressItem.ColumnHeadersHeight = 30;
            this.DG_ViewWeeklyProgressItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.DG_ViewWeeklyProgressItem.DefaultCellStyle = dataGridViewCellStyle3;
            this.DG_ViewWeeklyProgressItem.DoubleBuffered = true;
            this.DG_ViewWeeklyProgressItem.EnableHeadersVisualStyles = false;
            this.DG_ViewWeeklyProgressItem.HeaderBgColor = System.Drawing.Color.White;
            this.DG_ViewWeeklyProgressItem.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.DG_ViewWeeklyProgressItem.Location = new System.Drawing.Point(38, 343);
            this.DG_ViewWeeklyProgressItem.Name = "DG_ViewWeeklyProgressItem";
            this.DG_ViewWeeklyProgressItem.ReadOnly = true;
            this.DG_ViewWeeklyProgressItem.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_ViewWeeklyProgressItem.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DG_ViewWeeklyProgressItem.Size = new System.Drawing.Size(754, 203);
            this.DG_ViewWeeklyProgressItem.TabIndex = 48;
            // 
            // DG_WeeklyProgress
            // 
            this.DG_WeeklyProgress.AllowUserToAddRows = false;
            this.DG_WeeklyProgress.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DG_WeeklyProgress.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DG_WeeklyProgress.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DG_WeeklyProgress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DG_WeeklyProgress.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_WeeklyProgress.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DG_WeeklyProgress.ColumnHeadersHeight = 30;
            this.DG_WeeklyProgress.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.progressid,
            this.planid,
            this.agunit,
            this.date,
            this.description});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_WeeklyProgress.DefaultCellStyle = dataGridViewCellStyle7;
            this.DG_WeeklyProgress.DoubleBuffered = true;
            this.DG_WeeklyProgress.EnableHeadersVisualStyles = false;
            this.DG_WeeklyProgress.HeaderBgColor = System.Drawing.Color.White;
            this.DG_WeeklyProgress.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.DG_WeeklyProgress.Location = new System.Drawing.Point(38, 114);
            this.DG_WeeklyProgress.Name = "DG_WeeklyProgress";
            this.DG_WeeklyProgress.ReadOnly = true;
            this.DG_WeeklyProgress.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_WeeklyProgress.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DG_WeeklyProgress.Size = new System.Drawing.Size(754, 203);
            this.DG_WeeklyProgress.TabIndex = 47;
            // 
            // progressid
            // 
            this.progressid.FillWeight = 81.21828F;
            this.progressid.HeaderText = "Progress ID";
            this.progressid.Name = "progressid";
            this.progressid.ReadOnly = true;
            this.progressid.Width = 150;
            // 
            // planid
            // 
            this.planid.HeaderText = "Plan ID";
            this.planid.Name = "planid";
            this.planid.ReadOnly = true;
            // 
            // agunit
            // 
            this.agunit.HeaderText = "Estate";
            this.agunit.Name = "agunit";
            this.agunit.ReadOnly = true;
            this.agunit.Width = 125;
            // 
            // date
            // 
            this.date.FillWeight = 106.2606F;
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 150;
            // 
            // description
            // 
            this.description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            this.description.ReadOnly = true;
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
            // SWeeklyProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 660);
            this.Controls.Add(this.DG_ViewWeeklyProgressItem);
            this.Controls.Add(this.DG_WeeklyProgress);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SWeeklyProgress";
            this.Text = "SWeeklyProgress";
            ((System.ComponentModel.ISupportInitialize)(this.DG_ViewWeeklyProgressItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_WeeklyProgress)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DG_ViewWeeklyProgressItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn productid;
        private System.Windows.Forms.DataGridViewTextBoxColumn productname;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DG_WeeklyProgress;
        private System.Windows.Forms.DataGridViewTextBoxColumn progressid;
        private System.Windows.Forms.DataGridViewTextBoxColumn planid;
        private System.Windows.Forms.DataGridViewTextBoxColumn agunit;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
    }
}