namespace FinalProject2
{
    partial class POReciept
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POReciept));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_CancelGeneratePO = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FinalProject2.Reports.POReciept.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(92, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(852, 659);
            this.reportViewer1.TabIndex = 0;
            // 
            // btn_CancelGeneratePO
            // 
            this.btn_CancelGeneratePO.ActiveBorderThickness = 1;
            this.btn_CancelGeneratePO.ActiveCornerRadius = 20;
            this.btn_CancelGeneratePO.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_CancelGeneratePO.ActiveForecolor = System.Drawing.Color.White;
            this.btn_CancelGeneratePO.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_CancelGeneratePO.BackColor = System.Drawing.SystemColors.Control;
            this.btn_CancelGeneratePO.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_CancelGeneratePO.BackgroundImage")));
            this.btn_CancelGeneratePO.ButtonText = "Cancel";
            this.btn_CancelGeneratePO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CancelGeneratePO.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelGeneratePO.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_CancelGeneratePO.IdleBorderThickness = 1;
            this.btn_CancelGeneratePO.IdleCornerRadius = 20;
            this.btn_CancelGeneratePO.IdleFillColor = System.Drawing.Color.White;
            this.btn_CancelGeneratePO.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_CancelGeneratePO.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_CancelGeneratePO.Location = new System.Drawing.Point(481, 669);
            this.btn_CancelGeneratePO.Margin = new System.Windows.Forms.Padding(5);
            this.btn_CancelGeneratePO.Name = "btn_CancelGeneratePO";
            this.btn_CancelGeneratePO.Size = new System.Drawing.Size(105, 31);
            this.btn_CancelGeneratePO.TabIndex = 63;
            this.btn_CancelGeneratePO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_CancelGeneratePO.Click += new System.EventHandler(this.btn_CancelGeneratePO_Click);
            // 
            // POReciept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 700);
            this.Controls.Add(this.btn_CancelGeneratePO);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "POReciept";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POReciept";
            this.Load += new System.EventHandler(this.POReciept_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_CancelGeneratePO;
    }
}