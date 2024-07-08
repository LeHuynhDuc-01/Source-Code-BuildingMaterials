namespace GUI
{
    partial class frmKho
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
            this.tsbThem = new System.Windows.Forms.ToolStripButton();
            this.tsbSua = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbXoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbLuu = new System.Windows.Forms.ToolStripButton();
            this.tsbSearchtxt = new System.Windows.Forms.ToolStripTextBox();
            this.tsbSearch = new System.Windows.Forms.ToolStripButton();
            this.tsNCC = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbNV = new System.Windows.Forms.ComboBox();
            this.cbbNCC = new System.Windows.Forms.ComboBox();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaPN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbAdress = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPhieuNhap = new System.Windows.Forms.DataGridView();
            this.MAPN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TONGNHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYNHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHITIET = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tsNCC.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).BeginInit();
            this.SuspendLayout();
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
            this.tsbSearchtxt,
            this.tsbSearch});
            this.tsNCC.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.tsNCC.Location = new System.Drawing.Point(0, 0);
            this.tsNCC.Name = "tsNCC";
            this.tsNCC.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsNCC.Size = new System.Drawing.Size(1224, 38);
            this.tsNCC.TabIndex = 4;
            this.tsNCC.Text = "tsNCC";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 38);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 38);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cbbNV);
            this.panel1.Controls.Add(this.cbbNCC);
            this.panel1.Controls.Add(this.dtpNgayNhap);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtMaPN);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbAdress);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1224, 167);
            this.panel1.TabIndex = 5;
            // 
            // cbbNV
            // 
            this.cbbNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbNV.FormattingEnabled = true;
            this.cbbNV.Location = new System.Drawing.Point(682, 74);
            this.cbbNV.Name = "cbbNV";
            this.cbbNV.Size = new System.Drawing.Size(408, 28);
            this.cbbNV.TabIndex = 24;
            // 
            // cbbNCC
            // 
            this.cbbNCC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbNCC.FormattingEnabled = true;
            this.cbbNCC.Location = new System.Drawing.Point(110, 76);
            this.cbbNCC.Name = "cbbNCC";
            this.cbbNCC.Size = new System.Drawing.Size(406, 28);
            this.cbbNCC.TabIndex = 23;
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayNhap.Location = new System.Drawing.Point(682, 18);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(408, 27);
            this.dtpNgayNhap.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 21);
            this.label3.TabIndex = 21;
            this.label3.Text = "Danh sách: ";
            // 
            // txtMaPN
            // 
            this.txtMaPN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtMaPN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPN.Location = new System.Drawing.Point(110, 18);
            this.txtMaPN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaPN.Name = "txtMaPN";
            this.txtMaPN.Size = new System.Drawing.Size(406, 29);
            this.txtMaPN.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(558, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "Thời gian nhập:";
            // 
            // lbAdress
            // 
            this.lbAdress.AutoSize = true;
            this.lbAdress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdress.Location = new System.Drawing.Point(558, 76);
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
            this.label2.Location = new System.Drawing.Point(19, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mã NCC:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mã Phiếu: ";
            // 
            // dgvPhieuNhap
            // 
            this.dgvPhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuNhap.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPhieuNhap.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhieuNhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPhieuNhap.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhieuNhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAPN,
            this.MANCC,
            this.MANV,
            this.TONGNHAP,
            this.NGAYNHAP,
            this.CHITIET});
            this.dgvPhieuNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhieuNhap.GridColor = System.Drawing.Color.White;
            this.dgvPhieuNhap.Location = new System.Drawing.Point(0, 205);
            this.dgvPhieuNhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvPhieuNhap.Name = "dgvPhieuNhap";
            this.dgvPhieuNhap.ReadOnly = true;
            this.dgvPhieuNhap.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvPhieuNhap.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvPhieuNhap.Size = new System.Drawing.Size(1224, 634);
            this.dgvPhieuNhap.TabIndex = 6;
            this.dgvPhieuNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuNhap_CellClick);
            this.dgvPhieuNhap.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvPhieuNhap_CellPainting);
            // 
            // MAPN
            // 
            this.MAPN.HeaderText = "Mã phiếu";
            this.MAPN.Name = "MAPN";
            this.MAPN.ReadOnly = true;
            // 
            // MANCC
            // 
            this.MANCC.HeaderText = "Tên nhà cung cấp";
            this.MANCC.Name = "MANCC";
            this.MANCC.ReadOnly = true;
            // 
            // MANV
            // 
            this.MANV.HeaderText = "Nhân viên nhập";
            this.MANV.Name = "MANV";
            this.MANV.ReadOnly = true;
            // 
            // TONGNHAP
            // 
            this.TONGNHAP.HeaderText = "Tổng số";
            this.TONGNHAP.Name = "TONGNHAP";
            this.TONGNHAP.ReadOnly = true;
            // 
            // NGAYNHAP
            // 
            this.NGAYNHAP.HeaderText = "Thời gian nhập";
            this.NGAYNHAP.Name = "NGAYNHAP";
            this.NGAYNHAP.ReadOnly = true;
            // 
            // CHITIET
            // 
            this.CHITIET.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CHITIET.HeaderText = "Xem chi tiết";
            this.CHITIET.Name = "CHITIET";
            this.CHITIET.ReadOnly = true;
            this.CHITIET.Text = "Xem chi tiết";
            this.CHITIET.UseColumnTextForButtonValue = true;
            // 
            // frmKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 839);
            this.Controls.Add(this.dgvPhieuNhap);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tsNCC);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmKho";
            this.Text = "Quản lý nhập hàng";
            this.Load += new System.EventHandler(this.frmKho_Load);
            this.tsNCC.ResumeLayout(false);
            this.tsNCC.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton tsbThem;
        private System.Windows.Forms.ToolStripButton tsbSua;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton tsbXoa;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton tsbLuu;
        private System.Windows.Forms.ToolStripTextBox tsbSearchtxt;
        private System.Windows.Forms.ToolStripButton tsbSearch;
        private System.Windows.Forms.ToolStrip tsNCC;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvPhieuNhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaPN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbAdress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.ComboBox cbbNV;
        private System.Windows.Forms.ComboBox cbbNCC;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TONGNHAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYNHAP;
        private System.Windows.Forms.DataGridViewButtonColumn CHITIET;
    }
}