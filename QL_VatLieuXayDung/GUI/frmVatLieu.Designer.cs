namespace GUI
{
    partial class frmVatLieu
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
            this.tsVatLieu = new System.Windows.Forms.ToolStrip();
            this.tsbThem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSua = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbXoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbLuu = new System.Windows.Forms.ToolStripButton();
            this.tsbSearchtxt = new System.Windows.Forms.ToolStripTextBox();
            this.tsbSearch = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpHanSD = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbbDonViTinh = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpNgaySX = new System.Windows.Forms.DateTimePicker();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.txtXuatXu = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtMaVL = new System.Windows.Forms.TextBox();
            this.txtTenVL = new System.Windows.Forms.TextBox();
            this.cbbLoaiVatLieu = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThemImage = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.dgvVatLieu = new System.Windows.Forms.DataGridView();
            this.CL1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CL2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CL3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CL4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CL5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CL6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CL7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CL8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CL9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CL10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CL11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsVatLieu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVatLieu)).BeginInit();
            this.SuspendLayout();
            // 
            // tsVatLieu
            // 
            this.tsVatLieu.BackColor = System.Drawing.Color.White;
            this.tsVatLieu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsVatLieu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbThem,
            this.toolStripSeparator7,
            this.tsbSua,
            this.toolStripSeparator9,
            this.tsbXoa,
            this.toolStripSeparator10,
            this.tsbLuu,
            this.tsbSearchtxt,
            this.tsbSearch});
            this.tsVatLieu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.tsVatLieu.Location = new System.Drawing.Point(0, 0);
            this.tsVatLieu.Name = "tsVatLieu";
            this.tsVatLieu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsVatLieu.Size = new System.Drawing.Size(1208, 38);
            this.tsVatLieu.TabIndex = 4;
            this.tsVatLieu.Text = "tsNCC";
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
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 38);
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
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 38);
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
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 38);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dtpHanSD);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtGia);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cbbDonViTinh);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.dtpNgaySX);
            this.panel1.Controls.Add(this.txtMoTa);
            this.panel1.Controls.Add(this.txtXuatXu);
            this.panel1.Controls.Add(this.txtSoLuong);
            this.panel1.Controls.Add(this.txtMaVL);
            this.panel1.Controls.Add(this.txtTenVL);
            this.panel1.Controls.Add(this.cbbLoaiVatLieu);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnThemImage);
            this.panel1.Controls.Add(this.pbImage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1208, 227);
            this.panel1.TabIndex = 5;
            // 
            // dtpHanSD
            // 
            this.dtpHanSD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHanSD.Location = new System.Drawing.Point(519, 66);
            this.dtpHanSD.Name = "dtpHanSD";
            this.dtpHanSD.Size = new System.Drawing.Size(276, 27);
            this.dtpHanSD.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(445, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 20);
            this.label10.TabIndex = 36;
            this.label10.Text = "Hạn SD:";
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(931, 68);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(242, 27);
            this.txtGia.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(823, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 20);
            this.label9.TabIndex = 34;
            this.label9.Text = "Đơn vị tính:";
            // 
            // cbbDonViTinh
            // 
            this.cbbDonViTinh.FormattingEnabled = true;
            this.cbbDonViTinh.Location = new System.Drawing.Point(931, 17);
            this.cbbDonViTinh.Name = "cbbDonViTinh";
            this.cbbDonViTinh.Size = new System.Drawing.Size(242, 28);
            this.cbbDonViTinh.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(823, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 20);
            this.label8.TabIndex = 32;
            this.label8.Text = "Số lượng còn: ";
            // 
            // dtpNgaySX
            // 
            this.dtpNgaySX.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySX.Location = new System.Drawing.Point(519, 18);
            this.dtpNgaySX.Name = "dtpNgaySX";
            this.dtpNgaySX.Size = new System.Drawing.Size(276, 27);
            this.dtpNgaySX.TabIndex = 31;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(248, 175);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(925, 27);
            this.txtMoTa.TabIndex = 30;
            // 
            // txtXuatXu
            // 
            this.txtXuatXu.Location = new System.Drawing.Point(519, 123);
            this.txtXuatXu.Name = "txtXuatXu";
            this.txtXuatXu.Size = new System.Drawing.Size(276, 27);
            this.txtXuatXu.TabIndex = 29;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(931, 122);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(242, 27);
            this.txtSoLuong.TabIndex = 28;
            // 
            // txtMaVL
            // 
            this.txtMaVL.Location = new System.Drawing.Point(248, 17);
            this.txtMaVL.Name = "txtMaVL";
            this.txtMaVL.Size = new System.Drawing.Size(167, 27);
            this.txtMaVL.TabIndex = 27;
            // 
            // txtTenVL
            // 
            this.txtTenVL.Location = new System.Drawing.Point(248, 123);
            this.txtTenVL.Name = "txtTenVL";
            this.txtTenVL.Size = new System.Drawing.Size(168, 27);
            this.txtTenVL.TabIndex = 26;
            // 
            // cbbLoaiVatLieu
            // 
            this.cbbLoaiVatLieu.FormattingEnabled = true;
            this.cbbLoaiVatLieu.Location = new System.Drawing.Point(248, 65);
            this.cbbLoaiVatLieu.Name = "cbbLoaiVatLieu";
            this.cbbLoaiVatLieu.Size = new System.Drawing.Size(168, 28);
            this.cbbLoaiVatLieu.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(823, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Giá bán:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(445, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Xuất xứ: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Mô tả: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(445, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Ngày SX:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Loại vật liệu: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tên vật liệu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mã vật liệu:";
            // 
            // btnThemImage
            // 
            this.btnThemImage.BackColor = System.Drawing.Color.White;
            this.btnThemImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThemImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemImage.FlatAppearance.BorderSize = 0;
            this.btnThemImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemImage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemImage.ForeColor = System.Drawing.Color.Black;
            this.btnThemImage.Image = global::GUI.Properties.Resources.add_image;
            this.btnThemImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemImage.Location = new System.Drawing.Point(23, 169);
            this.btnThemImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThemImage.Name = "btnThemImage";
            this.btnThemImage.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.btnThemImage.Size = new System.Drawing.Size(107, 35);
            this.btnThemImage.TabIndex = 16;
            this.btnThemImage.Text = "       Thêm ảnh";
            this.btnThemImage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemImage.UseMnemonic = false;
            this.btnThemImage.UseVisualStyleBackColor = false;
            this.btnThemImage.Click += new System.EventHandler(this.btnThemImage_Click);
            // 
            // pbImage
            // 
            this.pbImage.Enabled = false;
            this.pbImage.Image = global::GUI.Properties.Resources.Icon_vatLieuXayDung;
            this.pbImage.Location = new System.Drawing.Point(22, 17);
            this.pbImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(108, 142);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 17;
            this.pbImage.TabStop = false;
            // 
            // dgvVatLieu
            // 
            this.dgvVatLieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVatLieu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvVatLieu.BackgroundColor = System.Drawing.Color.White;
            this.dgvVatLieu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVatLieu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvVatLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVatLieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CL1,
            this.CL2,
            this.CL3,
            this.CL4,
            this.CL5,
            this.CL6,
            this.CL7,
            this.CL8,
            this.CL9,
            this.CL10,
            this.CL11});
            this.dgvVatLieu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvVatLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVatLieu.GridColor = System.Drawing.Color.White;
            this.dgvVatLieu.Location = new System.Drawing.Point(0, 265);
            this.dgvVatLieu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvVatLieu.Name = "dgvVatLieu";
            this.dgvVatLieu.ReadOnly = true;
            this.dgvVatLieu.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvVatLieu.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvVatLieu.Size = new System.Drawing.Size(1208, 535);
            this.dgvVatLieu.TabIndex = 6;
            this.dgvVatLieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVatLieu_CellClick);
            this.dgvVatLieu.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvVatLieu_CellPainting);
            // 
            // CL1
            // 
            this.CL1.HeaderText = "Mã vật liệu";
            this.CL1.Name = "CL1";
            this.CL1.ReadOnly = true;
            // 
            // CL2
            // 
            this.CL2.HeaderText = "Mã loại";
            this.CL2.Name = "CL2";
            this.CL2.ReadOnly = true;
            // 
            // CL3
            // 
            this.CL3.HeaderText = "Tên vật liệu";
            this.CL3.Name = "CL3";
            this.CL3.ReadOnly = true;
            // 
            // CL4
            // 
            this.CL4.HeaderText = "Hình ảnh";
            this.CL4.Name = "CL4";
            this.CL4.ReadOnly = true;
            this.CL4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // CL5
            // 
            this.CL5.HeaderText = "Ngày sản xuất";
            this.CL5.Name = "CL5";
            this.CL5.ReadOnly = true;
            // 
            // CL6
            // 
            this.CL6.HeaderText = "Hạn sử dụng";
            this.CL6.Name = "CL6";
            this.CL6.ReadOnly = true;
            // 
            // CL7
            // 
            this.CL7.HeaderText = "Xuất xứ";
            this.CL7.Name = "CL7";
            this.CL7.ReadOnly = true;
            // 
            // CL8
            // 
            this.CL8.HeaderText = "Đơn vị tính";
            this.CL8.Name = "CL8";
            this.CL8.ReadOnly = true;
            // 
            // CL9
            // 
            this.CL9.HeaderText = "Giá";
            this.CL9.Name = "CL9";
            this.CL9.ReadOnly = true;
            // 
            // CL10
            // 
            this.CL10.HeaderText = "Số lượng";
            this.CL10.Name = "CL10";
            this.CL10.ReadOnly = true;
            // 
            // CL11
            // 
            this.CL11.HeaderText = "Mô tả";
            this.CL11.Name = "CL11";
            this.CL11.ReadOnly = true;
            // 
            // frmVatLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 800);
            this.Controls.Add(this.dgvVatLieu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tsVatLieu);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmVatLieu";
            this.Text = "Quản lý vật liệu";
            this.Load += new System.EventHandler(this.frmVatLieu_Load);
            this.tsVatLieu.ResumeLayout(false);
            this.tsVatLieu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVatLieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsVatLieu;
        private System.Windows.Forms.ToolStripButton tsbThem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton tsbSua;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripButton tsbXoa;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripButton tsbLuu;
        private System.Windows.Forms.ToolStripTextBox tsbSearchtxt;
        private System.Windows.Forms.ToolStripButton tsbSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvVatLieu;
        private System.Windows.Forms.DateTimePicker dtpNgaySX;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.TextBox txtXuatXu;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtMaVL;
        private System.Windows.Forms.TextBox txtTenVL;
        private System.Windows.Forms.ComboBox cbbLoaiVatLieu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThemImage;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.DateTimePicker dtpHanSD;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbbDonViTinh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn CL1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CL2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CL3;
        private System.Windows.Forms.DataGridViewTextBoxColumn CL4;
        private System.Windows.Forms.DataGridViewTextBoxColumn CL5;
        private System.Windows.Forms.DataGridViewTextBoxColumn CL6;
        private System.Windows.Forms.DataGridViewTextBoxColumn CL7;
        private System.Windows.Forms.DataGridViewTextBoxColumn CL8;
        private System.Windows.Forms.DataGridViewTextBoxColumn CL9;
        private System.Windows.Forms.DataGridViewTextBoxColumn CL10;
        private System.Windows.Forms.DataGridViewTextBoxColumn CL11;
    }
}