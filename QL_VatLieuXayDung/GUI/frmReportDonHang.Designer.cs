namespace GUI
{
    partial class frmReportDonHang
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
            this.rpvHienThiChiTietDon = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvHienThiChiTietDon
            // 
            this.rpvHienThiChiTietDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvHienThiChiTietDon.Location = new System.Drawing.Point(0, 0);
            this.rpvHienThiChiTietDon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rpvHienThiChiTietDon.Name = "rpvHienThiChiTietDon";
            this.rpvHienThiChiTietDon.ServerReport.BearerToken = null;
            this.rpvHienThiChiTietDon.Size = new System.Drawing.Size(1208, 800);
            this.rpvHienThiChiTietDon.TabIndex = 0;
            // 
            // frmReportDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 800);
            this.Controls.Add(this.rpvHienThiChiTietDon);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmReportDonHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReportDonHang";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmReportDonHang_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvHienThiChiTietDon;
    }
}