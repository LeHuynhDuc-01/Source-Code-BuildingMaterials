namespace GUI
{
    partial class frmDonHang
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
            this.tsNCC = new System.Windows.Forms.ToolStrip();
            this.tsbThem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSua = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbXoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbLuu = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbIn = new System.Windows.Forms.ToolStripButton();
            this.tsbSearchtxt = new System.Windows.Forms.ToolStripTextBox();
            this.tsbSearch = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTongHoaDon = new System.Windows.Forms.TextBox();
            this.cbbTrangThai = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.cbbMAKH = new System.Windows.Forms.ComboBox();
            this.dtpNgayDat = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbAdress = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.tsNCC.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // tsNCC
            // 
            this.tsNCC.BackColor = System.Drawing.Color.White;
            this.tsNCC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsNCC.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbThem,
            this.toolStripSeparator4,
            this.tsbSua,
            this.toolStripSeparator6,
            this.tsbXoa,
            this.toolStripSeparator7,
            this.tsbLuu,
            this.toolStripSeparator8,
            this.tsbIn,
            this.tsbSearchtxt,
            this.tsbSearch});
            this.tsNCC.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.tsNCC.Location = new System.Drawing.Point(0, 0);
            this.tsNCC.Name = "tsNCC";
            this.tsNCC.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsNCC.Size = new System.Drawing.Size(1208, 38);
            this.tsNCC.TabIndex = 5;
            this.tsNCC.Text = "tsNCC";
            // 
            // tsbThem
            // 
            this.tsbThem.Image = global::GUI.Properties.Resources.Add;
            this.tsbThem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbThem.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.tsbThem.Name = "tsbThem";
            this.tsbThem.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsbThem.Size = new System.Drawing.Size(93, 34);
            this.tsbThem.Text = "Thêm";
            this.tsbThem.Click += new System.EventHandler(this.tsbThem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 38);
            // 
            // tsbSua
            // 
            this.tsbSua.Image = global::GUI.Properties.Resources.Edit;
            this.tsbSua.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSua.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.tsbSua.Name = "tsbSua";
            this.tsbSua.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsbSua.Size = new System.Drawing.Size(80, 34);
            this.tsbSua.Text = "Sửa";
            this.tsbSua.Click += new System.EventHandler(this.tsbSua_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 38);
            // 
            // tsbXoa
            // 
            this.tsbXoa.Image = global::GUI.Properties.Resources.Delete;
            this.tsbXoa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbXoa.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.tsbXoa.Name = "tsbXoa";
            this.tsbXoa.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsbXoa.Size = new System.Drawing.Size(80, 34);
            this.tsbXoa.Text = "Xóa";
            this.tsbXoa.Click += new System.EventHandler(this.tsbXoa_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 38);
            // 
            // tsbLuu
            // 
            this.tsbLuu.Image = global::GUI.Properties.Resources.Save;
            this.tsbLuu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLuu.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.tsbLuu.Name = "tsbLuu";
            this.tsbLuu.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsbLuu.Size = new System.Drawing.Size(80, 34);
            this.tsbLuu.Text = "Lưu";
            this.tsbLuu.Click += new System.EventHandler(this.tsbLuu_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 38);
            // 
            // tsbIn
            // 
            this.tsbIn.Image = global::GUI.Properties.Resources.Print;
            this.tsbIn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbIn.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.tsbIn.Name = "tsbIn";
            this.tsbIn.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsbIn.Size = new System.Drawing.Size(67, 34);
            this.tsbIn.Text = "In";
            this.tsbIn.Click += new System.EventHandler(this.tsbIn_Click);
            // 
            // tsbSearchtxt
            // 
            this.tsbSearchtxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbSearchtxt.Margin = new System.Windows.Forms.Padding(5, 2, 1, 2);
            this.tsbSearchtxt.Name = "tsbSearchtxt";
            this.tsbSearchtxt.Size = new System.Drawing.Size(199, 34);
            // 
            // tsbSearch
            // 
            this.tsbSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSearch.Image = global::GUI.Properties.Resources.Search;
            this.tsbSearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSearch.Name = "tsbSearch";
            this.tsbSearch.Size = new System.Drawing.Size(34, 35);
            this.tsbSearch.Text = "toolStripButton1";
            this.tsbSearch.Click += new System.EventHandler(this.tsbSearch_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtTongHoaDon);
            this.panel1.Controls.Add(this.cbbTrangThai);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtMaNV);
            this.panel1.Controls.Add(this.cbbMAKH);
            this.panel1.Controls.Add(this.dtpNgayDat);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtMaHD);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbAdress);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1208, 203);
            this.panel1.TabIndex = 6;
            // 
            // txtTongHoaDon
            // 
            this.txtTongHoaDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtTongHoaDon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongHoaDon.Location = new System.Drawing.Point(719, 116);
            this.txtTongHoaDon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTongHoaDon.Name = "txtTongHoaDon";
            this.txtTongHoaDon.Size = new System.Drawing.Size(408, 29);
            this.txtTongHoaDon.TabIndex = 28;
            this.txtTongHoaDon.Text = "0";
            // 
            // cbbTrangThai
            // 
            this.cbbTrangThai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbTrangThai.FormattingEnabled = true;
            this.cbbTrangThai.Location = new System.Drawing.Point(719, 68);
            this.cbbTrangThai.Name = "cbbTrangThai";
            this.cbbTrangThai.Size = new System.Drawing.Size(408, 28);
            this.cbbTrangThai.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(595, 119);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 21);
            this.label6.TabIndex = 26;
            this.label6.Text = "Tổng hóa đơn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(595, 70);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 21);
            this.label5.TabIndex = 25;
            this.label5.Text = "Trạng thái:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(147, 70);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(406, 29);
            this.txtMaNV.TabIndex = 24;
            // 
            // cbbMAKH
            // 
            this.cbbMAKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbMAKH.FormattingEnabled = true;
            this.cbbMAKH.Location = new System.Drawing.Point(147, 117);
            this.cbbMAKH.Name = "cbbMAKH";
            this.cbbMAKH.Size = new System.Drawing.Size(406, 28);
            this.cbbMAKH.TabIndex = 23;
            // 
            // dtpNgayDat
            // 
            this.dtpNgayDat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpNgayDat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayDat.Location = new System.Drawing.Point(719, 18);
            this.dtpNgayDat.Name = "dtpNgayDat";
            this.dtpNgayDat.Size = new System.Drawing.Size(408, 27);
            this.dtpNgayDat.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 21);
            this.label3.TabIndex = 21;
            this.label3.Text = "Danh sách: ";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtMaHD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHD.Location = new System.Drawing.Point(147, 18);
            this.txtMaHD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(406, 29);
            this.txtMaHD.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(595, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "Ngày đặt hàng:";
            // 
            // lbAdress
            // 
            this.lbAdress.AutoSize = true;
            this.lbAdress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdress.Location = new System.Drawing.Point(19, 73);
            this.lbAdress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAdress.Name = "lbAdress";
            this.lbAdress.Size = new System.Drawing.Size(88, 21);
            this.lbAdress.TabIndex = 13;
            this.lbAdress.Text = "Nhân viên: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mã Khách Hàng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mã Hóa Đơn: ";
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.dgvHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHoaDon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHoaDon.GridColor = System.Drawing.Color.White;
            this.dgvHoaDon.Location = new System.Drawing.Point(0, 241);
            this.dgvHoaDon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.ReadOnly = true;
            this.dgvHoaDon.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvHoaDon.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvHoaDon.Size = new System.Drawing.Size(1208, 559);
            this.dgvHoaDon.TabIndex = 7;
            this.dgvHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellClick);
            this.dgvHoaDon.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvHoaDon_CellPainting);
            // 
            // frmDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 800);
            this.Controls.Add(this.dgvHoaDon);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tsNCC);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDonHang";
            this.Text = "Quản lý đơn hàng";
            this.Load += new System.EventHandler(this.frmDonHang_Load);
            this.tsNCC.ResumeLayout(false);
            this.tsNCC.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsNCC;
        private System.Windows.Forms.ToolStripButton tsbThem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbSua;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton tsbXoa;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton tsbLuu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripTextBox tsbSearchtxt;
        private System.Windows.Forms.ToolStripButton tsbSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbbMAKH;
        private System.Windows.Forms.DateTimePicker dtpNgayDat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbAdress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTongHoaDon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.ComboBox cbbTrangThai;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.ToolStripButton tsbIn;
    }
}