namespace GUI
{
    partial class frmNhanVien
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
            this.tcNhanVien = new System.Windows.Forms.TabControl();
            this.tpNhanVien = new System.Windows.Forms.TabPage();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.MANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HINHANH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIOITINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYSINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHI_NV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT_NV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL_NV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cbbGioiTinh = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThemImage = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.tsNhanVien = new System.Windows.Forms.ToolStrip();
            this.tsbThemNV = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbThemExcel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSuaNV = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbXoaNV = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbLuuNV = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbPrintNV = new System.Windows.Forms.ToolStripButton();
            this.tsbSearchtxtNV = new System.Windows.Forms.ToolStripTextBox();
            this.tsbSearchNV = new System.Windows.Forms.ToolStripButton();
            this.tpAccount = new System.Windows.Forms.TabPage();
            this.dgvTaiKhoan = new System.Windows.Forms.DataGridView();
            this.USERNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PASSWORD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANV_TK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkbPassWord = new System.Windows.Forms.CheckBox();
            this.cbbLoai = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbbNV_TK = new System.Windows.Forms.ComboBox();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNameNV_TK = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pbNV_TK = new System.Windows.Forms.PictureBox();
            this.tsTaiKhoan = new System.Windows.Forms.ToolStrip();
            this.tsbThemTK = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSuaTK = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbXoaTK = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbLuuTK = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSearchtxtTK = new System.Windows.Forms.ToolStripTextBox();
            this.tsbSearchTK = new System.Windows.Forms.ToolStripButton();
            this.tcNhanVien.SuspendLayout();
            this.tpNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.tsNhanVien.SuspendLayout();
            this.tpAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNV_TK)).BeginInit();
            this.tsTaiKhoan.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcNhanVien
            // 
            this.tcNhanVien.Controls.Add(this.tpNhanVien);
            this.tcNhanVien.Controls.Add(this.tpAccount);
            this.tcNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcNhanVien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcNhanVien.Location = new System.Drawing.Point(0, 0);
            this.tcNhanVien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tcNhanVien.Name = "tcNhanVien";
            this.tcNhanVien.SelectedIndex = 0;
            this.tcNhanVien.Size = new System.Drawing.Size(1224, 839);
            this.tcNhanVien.TabIndex = 4;
            // 
            // tpNhanVien
            // 
            this.tpNhanVien.BackColor = System.Drawing.Color.White;
            this.tpNhanVien.Controls.Add(this.dgvNhanVien);
            this.tpNhanVien.Controls.Add(this.panel1);
            this.tpNhanVien.Controls.Add(this.tsNhanVien);
            this.tpNhanVien.Location = new System.Drawing.Point(4, 30);
            this.tpNhanVien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpNhanVien.Name = "tpNhanVien";
            this.tpNhanVien.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpNhanVien.Size = new System.Drawing.Size(1216, 805);
            this.tpNhanVien.TabIndex = 0;
            this.tpNhanVien.Text = "Nhân viên";
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvNhanVien.BackgroundColor = System.Drawing.Color.White;
            this.dgvNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNhanVien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MANV,
            this.TENNV,
            this.HINHANH,
            this.GIOITINH,
            this.NGAYSINH,
            this.DIACHI_NV,
            this.SDT_NV,
            this.EMAIL_NV});
            this.dgvNhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhanVien.GridColor = System.Drawing.Color.White;
            this.dgvNhanVien.Location = new System.Drawing.Point(4, 276);
            this.dgvNhanVien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvNhanVien.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvNhanVien.Size = new System.Drawing.Size(1208, 524);
            this.dgvNhanVien.TabIndex = 5;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            this.dgvNhanVien.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvNhanVien_CellPainting);
            // 
            // MANV
            // 
            this.MANV.HeaderText = "Mã nhân viên";
            this.MANV.Name = "MANV";
            this.MANV.ReadOnly = true;
            // 
            // TENNV
            // 
            this.TENNV.HeaderText = "Họ và Tên";
            this.TENNV.Name = "TENNV";
            this.TENNV.ReadOnly = true;
            // 
            // HINHANH
            // 
            this.HINHANH.HeaderText = "Hình ảnh";
            this.HINHANH.Name = "HINHANH";
            this.HINHANH.ReadOnly = true;
            this.HINHANH.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // GIOITINH
            // 
            this.GIOITINH.HeaderText = "Giới tính";
            this.GIOITINH.Name = "GIOITINH";
            this.GIOITINH.ReadOnly = true;
            // 
            // NGAYSINH
            // 
            this.NGAYSINH.HeaderText = "Ngày sinh";
            this.NGAYSINH.Name = "NGAYSINH";
            this.NGAYSINH.ReadOnly = true;
            // 
            // DIACHI_NV
            // 
            this.DIACHI_NV.HeaderText = "Địa chỉ";
            this.DIACHI_NV.Name = "DIACHI_NV";
            this.DIACHI_NV.ReadOnly = true;
            // 
            // SDT_NV
            // 
            this.SDT_NV.HeaderText = "Số điện thoại";
            this.SDT_NV.Name = "SDT_NV";
            this.SDT_NV.ReadOnly = true;
            // 
            // EMAIL_NV
            // 
            this.EMAIL_NV.HeaderText = "Email";
            this.EMAIL_NV.Name = "EMAIL_NV";
            this.EMAIL_NV.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dtpNgaySinh);
            this.panel1.Controls.Add(this.txtDiaChi);
            this.panel1.Controls.Add(this.txtSDT);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtMaNV);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.cbbGioiTinh);
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
            this.panel1.Location = new System.Drawing.Point(4, 43);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1208, 233);
            this.panel1.TabIndex = 4;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(719, 28);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(443, 29);
            this.dtpNgaySinh.TabIndex = 15;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(221, 180);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(941, 29);
            this.txtDiaChi.TabIndex = 14;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(719, 129);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(443, 29);
            this.txtSDT.TabIndex = 13;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(719, 76);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(443, 29);
            this.txtEmail.TabIndex = 12;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(221, 28);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(365, 29);
            this.txtMaNV.TabIndex = 10;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(221, 79);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(365, 29);
            this.txtName.TabIndex = 9;
            // 
            // cbbGioiTinh
            // 
            this.cbbGioiTinh.FormattingEnabled = true;
            this.cbbGioiTinh.Location = new System.Drawing.Point(220, 132);
            this.cbbGioiTinh.Name = "cbbGioiTinh";
            this.cbbGioiTinh.Size = new System.Drawing.Size(366, 29);
            this.cbbGioiTinh.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(617, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 21);
            this.label7.TabIndex = 7;
            this.label7.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(617, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "Số điện thoại: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(140, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Địa chỉ: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(617, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày sinh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Giới tính: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ và tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã số:";
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
            this.btnThemImage.Location = new System.Drawing.Point(17, 180);
            this.btnThemImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThemImage.Name = "btnThemImage";
            this.btnThemImage.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.btnThemImage.Size = new System.Drawing.Size(107, 35);
            this.btnThemImage.TabIndex = 0;
            this.btnThemImage.Text = "       Thêm ảnh";
            this.btnThemImage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemImage.UseMnemonic = false;
            this.btnThemImage.UseVisualStyleBackColor = false;
            this.btnThemImage.Click += new System.EventHandler(this.btnThemImage_Click);
            // 
            // pbImage
            // 
            this.pbImage.Image = global::GUI.Properties.Resources.Image_NV;
            this.pbImage.Location = new System.Drawing.Point(16, 28);
            this.pbImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(108, 142);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // tsNhanVien
            // 
            this.tsNhanVien.BackColor = System.Drawing.Color.White;
            this.tsNhanVien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsNhanVien.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbThemNV,
            this.toolStripSeparator7,
            this.tsbThemExcel,
            this.toolStripSeparator8,
            this.tsbSuaNV,
            this.toolStripSeparator9,
            this.tsbXoaNV,
            this.toolStripSeparator10,
            this.tsbLuuNV,
            this.toolStripSeparator11,
            this.tsbPrintNV,
            this.tsbSearchtxtNV,
            this.tsbSearchNV});
            this.tsNhanVien.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.tsNhanVien.Location = new System.Drawing.Point(4, 5);
            this.tsNhanVien.Name = "tsNhanVien";
            this.tsNhanVien.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsNhanVien.Size = new System.Drawing.Size(1208, 38);
            this.tsNhanVien.TabIndex = 3;
            this.tsNhanVien.Text = "tsNCC";
            // 
            // tsbThemNV
            // 
            this.tsbThemNV.Image = global::GUI.Properties.Resources.Add;
            this.tsbThemNV.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbThemNV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbThemNV.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.tsbThemNV.Name = "tsbThemNV";
            this.tsbThemNV.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsbThemNV.Size = new System.Drawing.Size(93, 34);
            this.tsbThemNV.Text = "Thêm";
            this.tsbThemNV.Click += new System.EventHandler(this.tsbThemNV_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 38);
            // 
            // tsbThemExcel
            // 
            this.tsbThemExcel.Image = global::GUI.Properties.Resources.Excel;
            this.tsbThemExcel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbThemExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbThemExcel.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.tsbThemExcel.Name = "tsbThemExcel";
            this.tsbThemExcel.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsbThemExcel.Size = new System.Drawing.Size(131, 34);
            this.tsbThemExcel.Text = "Thêm Excel";
            this.tsbThemExcel.Click += new System.EventHandler(this.tsbThemExcel_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 38);
            // 
            // tsbSuaNV
            // 
            this.tsbSuaNV.Image = global::GUI.Properties.Resources.Edit;
            this.tsbSuaNV.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbSuaNV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSuaNV.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.tsbSuaNV.Name = "tsbSuaNV";
            this.tsbSuaNV.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsbSuaNV.Size = new System.Drawing.Size(80, 34);
            this.tsbSuaNV.Text = "Sửa";
            this.tsbSuaNV.Click += new System.EventHandler(this.tsbSuaNV_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 38);
            // 
            // tsbXoaNV
            // 
            this.tsbXoaNV.Image = global::GUI.Properties.Resources.Delete;
            this.tsbXoaNV.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbXoaNV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbXoaNV.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.tsbXoaNV.Name = "tsbXoaNV";
            this.tsbXoaNV.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsbXoaNV.Size = new System.Drawing.Size(80, 34);
            this.tsbXoaNV.Text = "Xóa";
            this.tsbXoaNV.Click += new System.EventHandler(this.tsbXoaNV_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 38);
            // 
            // tsbLuuNV
            // 
            this.tsbLuuNV.Image = global::GUI.Properties.Resources.Save;
            this.tsbLuuNV.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbLuuNV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLuuNV.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.tsbLuuNV.Name = "tsbLuuNV";
            this.tsbLuuNV.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsbLuuNV.Size = new System.Drawing.Size(80, 34);
            this.tsbLuuNV.Text = "Lưu";
            this.tsbLuuNV.Click += new System.EventHandler(this.tsbLuuNV_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 38);
            // 
            // tsbPrintNV
            // 
            this.tsbPrintNV.Image = global::GUI.Properties.Resources.Print;
            this.tsbPrintNV.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbPrintNV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrintNV.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.tsbPrintNV.Name = "tsbPrintNV";
            this.tsbPrintNV.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsbPrintNV.Size = new System.Drawing.Size(67, 34);
            this.tsbPrintNV.Text = "In";
            this.tsbPrintNV.Click += new System.EventHandler(this.tsbPrintNV_Click);
            // 
            // tsbSearchtxtNV
            // 
            this.tsbSearchtxtNV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbSearchtxtNV.Margin = new System.Windows.Forms.Padding(5, 2, 1, 2);
            this.tsbSearchtxtNV.Name = "tsbSearchtxtNV";
            this.tsbSearchtxtNV.Size = new System.Drawing.Size(199, 34);
            // 
            // tsbSearchNV
            // 
            this.tsbSearchNV.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSearchNV.Image = global::GUI.Properties.Resources.Search;
            this.tsbSearchNV.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbSearchNV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSearchNV.Name = "tsbSearchNV";
            this.tsbSearchNV.Size = new System.Drawing.Size(34, 35);
            this.tsbSearchNV.Text = "toolStripButton1";
            this.tsbSearchNV.Click += new System.EventHandler(this.tsbSearchNV_Click);
            // 
            // tpAccount
            // 
            this.tpAccount.BackColor = System.Drawing.Color.White;
            this.tpAccount.Controls.Add(this.dgvTaiKhoan);
            this.tpAccount.Controls.Add(this.panel2);
            this.tpAccount.Controls.Add(this.tsTaiKhoan);
            this.tpAccount.Location = new System.Drawing.Point(4, 30);
            this.tpAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpAccount.Name = "tpAccount";
            this.tpAccount.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpAccount.Size = new System.Drawing.Size(1216, 805);
            this.tpAccount.TabIndex = 1;
            this.tpAccount.Text = "Tài khoản";
            // 
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTaiKhoan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTaiKhoan.BackgroundColor = System.Drawing.Color.White;
            this.dgvTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTaiKhoan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.USERNAME,
            this.PASSWORD,
            this.LOAI,
            this.MANV_TK});
            this.dgvTaiKhoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvTaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTaiKhoan.GridColor = System.Drawing.Color.White;
            this.dgvTaiKhoan.Location = new System.Drawing.Point(620, 43);
            this.dgvTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.ReadOnly = true;
            this.dgvTaiKhoan.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvTaiKhoan.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvTaiKhoan.Size = new System.Drawing.Size(592, 757);
            this.dgvTaiKhoan.TabIndex = 6;
            this.dgvTaiKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTaiKhoan_CellClick);
            this.dgvTaiKhoan.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvTaiKhoan_CellPainting);
            // 
            // USERNAME
            // 
            this.USERNAME.HeaderText = "User Name";
            this.USERNAME.Name = "USERNAME";
            this.USERNAME.ReadOnly = true;
            // 
            // PASSWORD
            // 
            this.PASSWORD.HeaderText = "Password";
            this.PASSWORD.Name = "PASSWORD";
            this.PASSWORD.ReadOnly = true;
            this.PASSWORD.Visible = false;
            // 
            // LOAI
            // 
            this.LOAI.HeaderText = "Quyền";
            this.LOAI.Name = "LOAI";
            this.LOAI.ReadOnly = true;
            this.LOAI.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // MANV_TK
            // 
            this.MANV_TK.DataPropertyName = "MANV_TK";
            this.MANV_TK.HeaderText = "Mã Nhân viên";
            this.MANV_TK.Name = "MANV_TK";
            this.MANV_TK.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chkbPassWord);
            this.panel2.Controls.Add(this.cbbLoai);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.cbbNV_TK);
            this.panel2.Controls.Add(this.txtPassWord);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtUserName);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtNameNV_TK);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.pbNV_TK);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(4, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(616, 757);
            this.panel2.TabIndex = 5;
            // 
            // chkbPassWord
            // 
            this.chkbPassWord.AutoSize = true;
            this.chkbPassWord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkbPassWord.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbPassWord.Location = new System.Drawing.Point(314, 223);
            this.chkbPassWord.Name = "chkbPassWord";
            this.chkbPassWord.Size = new System.Drawing.Size(108, 19);
            this.chkbPassWord.TabIndex = 24;
            this.chkbPassWord.Text = "Show Password";
            this.chkbPassWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkbPassWord.UseVisualStyleBackColor = true;
            this.chkbPassWord.CheckedChanged += new System.EventHandler(this.chkbPassWord_CheckedChanged);
            // 
            // cbbLoai
            // 
            this.cbbLoai.FormattingEnabled = true;
            this.cbbLoai.Location = new System.Drawing.Point(314, 248);
            this.cbbLoai.Name = "cbbLoai";
            this.cbbLoai.Size = new System.Drawing.Size(273, 29);
            this.cbbLoai.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(225, 251);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 21);
            this.label12.TabIndex = 22;
            this.label12.Text = "Loại:";
            // 
            // cbbNV_TK
            // 
            this.cbbNV_TK.FormattingEnabled = true;
            this.cbbNV_TK.Location = new System.Drawing.Point(314, 15);
            this.cbbNV_TK.Name = "cbbNV_TK";
            this.cbbNV_TK.Size = new System.Drawing.Size(273, 29);
            this.cbbNV_TK.TabIndex = 21;
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(314, 188);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.PasswordChar = '*';
            this.txtPassWord.Size = new System.Drawing.Size(273, 29);
            this.txtPassWord.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(225, 191);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 21);
            this.label11.TabIndex = 19;
            this.label11.Text = "PassWord:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(314, 130);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(273, 29);
            this.txtUserName.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(225, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 21);
            this.label10.TabIndex = 17;
            this.label10.Text = "UserName:";
            // 
            // txtNameNV_TK
            // 
            this.txtNameNV_TK.Location = new System.Drawing.Point(314, 72);
            this.txtNameNV_TK.Name = "txtNameNV_TK";
            this.txtNameNV_TK.Size = new System.Drawing.Size(273, 29);
            this.txtNameNV_TK.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(225, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 21);
            this.label8.TabIndex = 14;
            this.label8.Text = "Họ và tên:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(225, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 21);
            this.label9.TabIndex = 13;
            this.label9.Text = "Mã số:";
            // 
            // pbNV_TK
            // 
            this.pbNV_TK.Image = global::GUI.Properties.Resources.Image_NV;
            this.pbNV_TK.Location = new System.Drawing.Point(15, 15);
            this.pbNV_TK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbNV_TK.Name = "pbNV_TK";
            this.pbNV_TK.Size = new System.Drawing.Size(186, 252);
            this.pbNV_TK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNV_TK.TabIndex = 12;
            this.pbNV_TK.TabStop = false;
            // 
            // tsTaiKhoan
            // 
            this.tsTaiKhoan.BackColor = System.Drawing.Color.White;
            this.tsTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsTaiKhoan.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbThemTK,
            this.toolStripSeparator1,
            this.tsbSuaTK,
            this.toolStripSeparator3,
            this.tsbXoaTK,
            this.toolStripSeparator12,
            this.tsbLuuTK,
            this.toolStripSeparator13,
            this.tsbSearchtxtTK,
            this.tsbSearchTK});
            this.tsTaiKhoan.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.tsTaiKhoan.Location = new System.Drawing.Point(4, 5);
            this.tsTaiKhoan.Name = "tsTaiKhoan";
            this.tsTaiKhoan.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsTaiKhoan.Size = new System.Drawing.Size(1208, 38);
            this.tsTaiKhoan.TabIndex = 4;
            this.tsTaiKhoan.Text = "toolStrip2";
            // 
            // tsbThemTK
            // 
            this.tsbThemTK.Image = global::GUI.Properties.Resources.Add;
            this.tsbThemTK.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbThemTK.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbThemTK.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.tsbThemTK.Name = "tsbThemTK";
            this.tsbThemTK.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsbThemTK.Size = new System.Drawing.Size(93, 34);
            this.tsbThemTK.Text = "Thêm";
            this.tsbThemTK.Click += new System.EventHandler(this.tsbThemTK_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // tsbSuaTK
            // 
            this.tsbSuaTK.Image = global::GUI.Properties.Resources.Edit;
            this.tsbSuaTK.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbSuaTK.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSuaTK.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.tsbSuaTK.Name = "tsbSuaTK";
            this.tsbSuaTK.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsbSuaTK.Size = new System.Drawing.Size(80, 34);
            this.tsbSuaTK.Text = "Sửa";
            this.tsbSuaTK.Click += new System.EventHandler(this.tsbSuaTK_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 38);
            // 
            // tsbXoaTK
            // 
            this.tsbXoaTK.Image = global::GUI.Properties.Resources.Delete;
            this.tsbXoaTK.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbXoaTK.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbXoaTK.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.tsbXoaTK.Name = "tsbXoaTK";
            this.tsbXoaTK.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsbXoaTK.Size = new System.Drawing.Size(80, 34);
            this.tsbXoaTK.Text = "Xóa";
            this.tsbXoaTK.Click += new System.EventHandler(this.tsbXoaTK_Click);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(6, 38);
            // 
            // tsbLuuTK
            // 
            this.tsbLuuTK.Image = global::GUI.Properties.Resources.Save;
            this.tsbLuuTK.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbLuuTK.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLuuTK.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.tsbLuuTK.Name = "tsbLuuTK";
            this.tsbLuuTK.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsbLuuTK.Size = new System.Drawing.Size(80, 34);
            this.tsbLuuTK.Text = "Lưu";
            this.tsbLuuTK.Click += new System.EventHandler(this.tsbLuuTK_Click);
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(6, 38);
            // 
            // tsbSearchtxtTK
            // 
            this.tsbSearchtxtTK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbSearchtxtTK.Margin = new System.Windows.Forms.Padding(5, 2, 1, 2);
            this.tsbSearchtxtTK.Name = "tsbSearchtxtTK";
            this.tsbSearchtxtTK.Size = new System.Drawing.Size(199, 34);
            // 
            // tsbSearchTK
            // 
            this.tsbSearchTK.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSearchTK.Image = global::GUI.Properties.Resources.Search;
            this.tsbSearchTK.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbSearchTK.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSearchTK.Name = "tsbSearchTK";
            this.tsbSearchTK.Size = new System.Drawing.Size(34, 35);
            this.tsbSearchTK.Text = "toolStripButton1";
            this.tsbSearchTK.Click += new System.EventHandler(this.tsbSearchTK_Click);
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1224, 839);
            this.Controls.Add(this.tcNhanVien);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmNhanVien";
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            this.tcNhanVien.ResumeLayout(false);
            this.tpNhanVien.ResumeLayout(false);
            this.tpNhanVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.tsNhanVien.ResumeLayout(false);
            this.tsNhanVien.PerformLayout();
            this.tpAccount.ResumeLayout(false);
            this.tpAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNV_TK)).EndInit();
            this.tsTaiKhoan.ResumeLayout(false);
            this.tsTaiKhoan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tcNhanVien;
        private System.Windows.Forms.TabPage tpNhanVien;
        private System.Windows.Forms.TabPage tpAccount;
        private System.Windows.Forms.ToolStrip tsNhanVien;
        private System.Windows.Forms.ToolStripButton tsbThemNV;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton tsbThemExcel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton tsbSuaNV;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripButton tsbXoaNV;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripButton tsbLuuNV;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripButton tsbPrintNV;
        private System.Windows.Forms.ToolStripTextBox tsbSearchtxtNV;
        private System.Windows.Forms.ToolStripButton tsbSearchNV;
        private System.Windows.Forms.ToolStrip tsTaiKhoan;
        private System.Windows.Forms.ToolStripButton tsbSuaTK;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbXoaTK;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripButton tsbLuuTK;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripTextBox tsbSearchtxtTK;
        private System.Windows.Forms.ToolStripButton tsbSearchTK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btnThemImage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cbbGioiTinh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HINHANH;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIOITINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYSINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHI_NV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT_NV;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL_NV;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvTaiKhoan;
        private System.Windows.Forms.TextBox txtNameNV_TK;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pbNV_TK;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolStripButton tsbThemTK;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbbNV_TK;
        private System.Windows.Forms.ComboBox cbbLoai;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn USERNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn PASSWORD;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANV_TK;
        private System.Windows.Forms.CheckBox chkbPassWord;
    }
}