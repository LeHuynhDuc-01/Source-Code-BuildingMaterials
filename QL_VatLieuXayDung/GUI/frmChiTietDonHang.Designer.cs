namespace GUI
{
    partial class frmChiTietDonHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCTPN = new System.Windows.Forms.DataGridView();
            this.MADH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAVL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbVL = new System.Windows.Forms.ComboBox();
            this.txtMaDH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tsCTPN = new System.Windows.Forms.ToolStrip();
            this.tsbThem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSua = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbXoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbLuu = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSearchtxt = new System.Windows.Forms.ToolStripTextBox();
            this.tsbSearch = new System.Windows.Forms.ToolStripButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.tsbXoaAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPN)).BeginInit();
            this.panel1.SuspendLayout();
            this.tsCTPN.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCTPN
            // 
            this.dgvCTPN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCTPN.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCTPN.BackgroundColor = System.Drawing.Color.White;
            this.dgvCTPN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCTPN.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCTPN.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCTPN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTPN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MADH,
            this.MAVL,
            this.GIA,
            this.SOLUONG});
            this.dgvCTPN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvCTPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCTPN.GridColor = System.Drawing.Color.White;
            this.dgvCTPN.Location = new System.Drawing.Point(0, 185);
            this.dgvCTPN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvCTPN.Name = "dgvCTPN";
            this.dgvCTPN.ReadOnly = true;
            this.dgvCTPN.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvCTPN.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvCTPN.Size = new System.Drawing.Size(1208, 570);
            this.dgvCTPN.TabIndex = 10;
            this.dgvCTPN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTPN_CellClick);
            this.dgvCTPN.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvCTPN_CellPainting);
            // 
            // MADH
            // 
            this.MADH.HeaderText = "Mã đơn hàng";
            this.MADH.Name = "MADH";
            this.MADH.ReadOnly = true;
            // 
            // MAVL
            // 
            this.MAVL.HeaderText = "Vật liệu";
            this.MAVL.Name = "MAVL";
            this.MAVL.ReadOnly = true;
            // 
            // GIA
            // 
            this.GIA.HeaderText = "Giá";
            this.GIA.Name = "GIA";
            this.GIA.ReadOnly = true;
            // 
            // SOLUONG
            // 
            this.SOLUONG.HeaderText = "Số lượng";
            this.SOLUONG.Name = "SOLUONG";
            this.SOLUONG.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtSoLuong);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtGia);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbbVL);
            this.panel1.Controls.Add(this.txtMaDH);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1208, 147);
            this.panel1.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 116);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 21);
            this.label6.TabIndex = 34;
            this.label6.Text = "Danh sách: ";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtSoLuong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(699, 68);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(452, 29);
            this.txtSoLuong.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(612, 71);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 21);
            this.label5.TabIndex = 32;
            this.label5.Text = "Số lượng: ";
            // 
            // txtGia
            // 
            this.txtGia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtGia.Enabled = false;
            this.txtGia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.Location = new System.Drawing.Point(699, 10);
            this.txtGia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(455, 29);
            this.txtGia.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(612, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 21);
            this.label4.TabIndex = 30;
            this.label4.Text = "Giá: ";
            // 
            // cbbVL
            // 
            this.cbbVL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbVL.FormattingEnabled = true;
            this.cbbVL.Location = new System.Drawing.Point(136, 69);
            this.cbbVL.Name = "cbbVL";
            this.cbbVL.Size = new System.Drawing.Size(423, 28);
            this.cbbVL.TabIndex = 29;
            this.cbbVL.SelectedIndexChanged += new System.EventHandler(this.cbbVL_SelectedIndexChanged);
            // 
            // txtMaDH
            // 
            this.txtMaDH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtMaDH.Enabled = false;
            this.txtMaDH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDH.Location = new System.Drawing.Point(136, 13);
            this.txtMaDH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaDH.Name = "txtMaDH";
            this.txtMaDH.Size = new System.Drawing.Size(423, 29);
            this.txtMaDH.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 21);
            this.label1.TabIndex = 26;
            this.label1.Text = "Mã vật liệu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 21);
            this.label3.TabIndex = 25;
            this.label3.Text = "Mã đơn hàng: ";
            // 
            // tsCTPN
            // 
            this.tsCTPN.BackColor = System.Drawing.Color.White;
            this.tsCTPN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsCTPN.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbThem,
            this.toolStripSeparator4,
            this.tsbSua,
            this.toolStripSeparator6,
            this.tsbXoa,
            this.toolStripSeparator7,
            this.tsbXoaAll,
            this.toolStripSeparator1,
            this.tsbLuu,
            this.toolStripSeparator8,
            this.tsbSearchtxt,
            this.tsbSearch});
            this.tsCTPN.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.tsCTPN.Location = new System.Drawing.Point(0, 0);
            this.tsCTPN.Name = "tsCTPN";
            this.tsCTPN.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsCTPN.Size = new System.Drawing.Size(1208, 38);
            this.tsCTPN.TabIndex = 8;
            this.tsCTPN.Text = "tsNCC";
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lbTongTien);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btnThem);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(0, 755);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1208, 45);
            this.panel3.TabIndex = 11;
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Location = new System.Drawing.Point(104, 9);
            this.lbTongTien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(22, 25);
            this.lbTongTien.TabIndex = 2;
            this.lbTongTien.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tổng tiền: ";
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.BackColor = System.Drawing.Color.White;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(1097, 5);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(107, 35);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // tsbXoaAll
            // 
            this.tsbXoaAll.Image = global::GUI.Properties.Resources.Delete;
            this.tsbXoaAll.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbXoaAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbXoaAll.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.tsbXoaAll.Name = "tsbXoaAll";
            this.tsbXoaAll.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsbXoaAll.Size = new System.Drawing.Size(104, 34);
            this.tsbXoaAll.Text = " Xóa all";
            this.tsbXoaAll.Click += new System.EventHandler(this.tsbXoaAll_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // frmChiTietDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 800);
            this.Controls.Add(this.dgvCTPN);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tsCTPN);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmChiTietDonHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết đơn hàng";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmChiTietDonHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPN)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tsCTPN.ResumeLayout(false);
            this.tsCTPN.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCTPN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbVL;
        private System.Windows.Forms.TextBox txtMaDH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStrip tsCTPN;
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
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MADH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAVL;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.ToolStripButton tsbXoaAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}