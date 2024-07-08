using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class frmNhanVien : Form
    {
        private ContextMenuStrip contextMenu;
        private NhanVienDTO nVDTO = new NhanVienDTO();
        private NhanVienBLL nVBLL = new NhanVienBLL();
        private TaiKhoanDTO tkDTO = new TaiKhoanDTO();
        private TaiKhoanBLL tkBLL = new TaiKhoanBLL();

        private bool IsInsert = false;
        private List<NhanVienDTO> listNV = new List<NhanVienDTO>();
        private List<TaiKhoanDTO> listTK = new List<TaiKhoanDTO>();
        public frmNhanVien()
        {
            InitializeComponent();
            contextMenu = new ContextMenuStrip();
            ToolStripMenuItem menuItem1 = new ToolStripMenuItem("Refesh");
            menuItem1.Click += MenuItem1_Click;
            contextMenu.Items.Add(menuItem1);
            this.ContextMenuStrip = contextMenu;
        }
        
        //Chung
        private void MenuItem1_Click(object sender, EventArgs e)
        {
            khoaDK();
            khoaDK_TK();
            xoaTxt();
            tsbSearchtxtNV.Clear();
            tsbSearchtxtNV.Focus();
            tsbSearchtxtTK.Clear();
            tsbSearchtxtTK.Focus();
            pbNV_TK.Image = GUI.Properties.Resources.Image_NV;
            pbImage.Image = GUI.Properties.Resources.Image_NV;
            cbbNV_TK.Focus();
            HienThiNV();
            HienThiTK();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            khoaDK();
            khoaDK_TK();
            loadGioiTinh();
            loadCbbNV_TK();
            loafCbbLoai();
            HienThiNV();
            HienThiTK();
        }
        //Nhân viên
        public void khoaDK()
        {
            txtMaNV.Enabled = txtName.Enabled = cbbGioiTinh.Enabled = dtpNgaySinh.Enabled = txtDiaChi.Enabled = txtSDT.Enabled = txtEmail.Enabled = false;
            tsbThemNV.Enabled = tsbThemExcel.Enabled = tsbSuaNV.Enabled = tsbXoaNV.Enabled = tsbPrintNV.Enabled = true;
            tsbLuuNV.Enabled = false;
        }
        public void moKhoaDK()
        {
            txtName.Enabled = cbbGioiTinh.Enabled = dtpNgaySinh.Enabled = txtDiaChi.Enabled = txtSDT.Enabled = txtEmail.Enabled = true;
            tsbThemNV.Enabled = tsbThemExcel.Enabled = tsbSuaNV.Enabled = tsbXoaNV.Enabled = tsbPrintNV.Enabled = false;
            tsbLuuNV.Enabled = true;
        }
        public void xoaTxt()
        {
            txtMaNV.Text = txtName.Text = txtDiaChi.Text = txtSDT.Text = txtEmail.Text = string.Empty;
            txtUserName.Text = txtNameNV_TK.Text = txtPassWord.Text = string.Empty;
            cbbNV_TK.Focus();
            cbbGioiTinh.Focus();
            dtpNgaySinh.Focus();
        }
        //Tài khoản
        public void khoaDK_TK()
        {
            cbbNV_TK.Enabled = txtNameNV_TK.Enabled = txtUserName.Enabled = txtPassWord.Enabled = false;
            tsbThemTK.Enabled = tsbSuaTK.Enabled = tsbXoaTK.Enabled = true;
            cbbLoai.Enabled = false;
            tsbLuuTK.Enabled = false;
            chkbPassWord.Enabled = false;
        }
        public void moKhoaDK_TK()
        {
            cbbNV_TK.Enabled = txtNameNV_TK.Enabled = txtUserName.Enabled = txtPassWord.Enabled = true;
            tsbThemTK.Enabled = tsbSuaTK.Enabled = tsbXoaTK.Enabled = false;
            cbbLoai.Enabled = true;
            tsbLuuTK.Enabled = true;
            chkbPassWord.Enabled = true;
        }
       

        //Nhân viên
        public void loadGioiTinh()
        {
            cbbGioiTinh.Items.Add("Nam");
            cbbGioiTinh.Items.Add("Nữ");

            cbbGioiTinh.SelectedIndex = 0;
        }
        public void HienThiNV()
        {
            listNV = ConvertDataTableToListNV(nVBLL.GetData());
            dgvNhanVien.Columns["MANV"].DataPropertyName = "MANV";
            dgvNhanVien.Columns["TENNV"].DataPropertyName = "TENNV";
            dgvNhanVien.Columns["HINHANH"].DataPropertyName = "HINHANH";
            dgvNhanVien.Columns["GIOITINH"].DataPropertyName = "GIOITINH";
            dgvNhanVien.Columns["NGAYSINH"].DataPropertyName = "NGAYSINH";
            dgvNhanVien.Columns["DIACHI_NV"].DataPropertyName = "DIACHI_NV";
            dgvNhanVien.Columns["SDT_NV"].DataPropertyName = "SDT_NV";
            dgvNhanVien.Columns["EMAIL_NV"].DataPropertyName = "EMAIL_NV";
            dgvNhanVien.DataSource = listNV;
        }
        private List<NhanVienDTO> ConvertDataTableToListNV(DataTable dataTable)
        {
            List<NhanVienDTO> listNV = new List<NhanVienDTO>();

            foreach (DataRow row in dataTable.Rows)
            {
                NhanVienDTO nV = new NhanVienDTO
                {
                    MANV = row["MANV"].ToString(),
                    TENNV = row["TENNV"].ToString(),
                    GIOITINH = row["GIOITINH"].ToString(),
                    NGAYSINH = DateTime.Parse(row["NGAYSINH"].ToString()),
                    DIACHI_NV = row["DIACHI_NV"].ToString(),
                    SDT_NV = row["SDT_NV"].ToString(),
                    EMAIL_NV = row["EMAIL_NV"].ToString()
                };

                // Handle the image property separately
                if (row["HINHANH"] != DBNull.Value)
                {
                    nV.HINHANH = (byte[])row["HINHANH"];
                }

                listNV.Add(nV);
            }

            return listNV;
        }

        private void dgvNhanVien_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            e.Paint(e.CellBounds, DataGridViewPaintParts.All);
            using (Pen gridPen = new Pen(Color.Gray))
            {
                gridPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                e.Graphics.DrawLine(gridPen, e.CellBounds.Left, e.CellBounds.Bottom - 1, e.CellBounds.Right, e.CellBounds.Bottom - 1);
                e.Graphics.DrawLine(gridPen, e.CellBounds.Right - 1, e.CellBounds.Top, e.CellBounds.Right - 1, e.CellBounds.Bottom);
            }
            e.Handled = true;
        }

        static string GenerateNewCode(List<NhanVienDTO> list)
        {
            // Nếu danh sách rỗng, trả về mã mặc định
            if (list.Count == 0)
            {
                return "VL01";
            }

            // Lấy phần tử cuối cùng trong danh sách
            string lastCode = list.Last().MANV;

            // Tách "HD" và số từ mã cuối cùng
            string prefix = lastCode.Substring(0, 2);
            string numberPart = lastCode.Substring(2);

            // Chuyển số thành số nguyên và tăng lên 1
            int number = int.Parse(numberPart) + 1;

            // Tạo mã mới
            string newCode = $"{prefix}{number:D4}";

            return newCode;
        }
        private void tsbThemNV_Click(object sender, EventArgs e)
        {
            moKhoaDK();
            IsInsert = true;
            xoaTxt();
            txtMaNV.Text = GenerateNewCode(listNV);
        }

        private void tsbThemExcel_Click(object sender, EventArgs e)
        {

        }

        private void tsbSuaNV_Click(object sender, EventArgs e)
        {
            moKhoaDK();
            txtMaNV.Enabled = false;
            IsInsert = false;
        }

        private void tsbXoaNV_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa thông tin này không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    nVBLL.Delete(txtMaNV.Text);
                    MessageBox.Show("Đã xóa thông tin thành công!");
                    HienThiNV();
                    xoaTxt();
                    khoaDK();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        private void tsbLuuNV_Click(object sender, EventArgs e)
        {
            byte[] image = imageToByte(pbImage.Image);
            nVDTO.MANV = txtMaNV.Text;
            nVDTO.TENNV = txtName.Text;
            nVDTO.HINHANH = image;
            nVDTO.GIOITINH = cbbGioiTinh.SelectedItem.ToString();
            nVDTO.NGAYSINH = dtpNgaySinh.Value;
            nVDTO.DIACHI_NV = txtDiaChi.Text;
            nVDTO.SDT_NV = txtSDT.Text;
            nVDTO.EMAIL_NV = txtEmail.Text;
            if (IsInsert == true)
            {
                //Insert
                nVBLL.Insert(nVDTO);
                MessageBox.Show("Thêm thông tin thành công!");
                HienThiNV();
                xoaTxt();
                khoaDK();
            }
            else
            {
                //Update
                nVBLL.Update(nVDTO);
                MessageBox.Show("Sửa thông tin thành công!");
                HienThiNV();
                xoaTxt();
                khoaDK();
            }
            image = null;
        }


        private void tsbPrintNV_Click(object sender, EventArgs e)
        {

        }
        private void Search(string keyword)
        {
            var results = listNV.Where(nv =>
            nv.MANV != null && nv.MANV.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
            nv.TENNV != null && nv.TENNV.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
            nv.GIOITINH != null && nv.GIOITINH.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
            nv.DIACHI_NV != null && nv.DIACHI_NV.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
            nv.SDT_NV != null && nv.SDT_NV.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
            nv.EMAIL_NV != null && nv.EMAIL_NV.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0).ToList();

            dgvNhanVien.DataSource = results;
        }
        private void tsbSearchNV_Click(object sender, EventArgs e)
        {
            string keyword = tsbSearchtxtNV.Text.Trim();
            Search(keyword);
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            khoaDK();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];

                // Assuming you have textboxes named txtMaNV, txtName, txtGioiTinh, etc.
                txtMaNV.Text = row.Cells["MANV"].Value?.ToString();
                txtName.Text = row.Cells["TENNV"].Value?.ToString();
                cbbGioiTinh.Text = row.Cells["GIOITINH"].Value?.ToString();
                dtpNgaySinh.Value = DateTime.Parse(row.Cells["NGAYSINH"].Value?.ToString());
                txtDiaChi.Text = row.Cells["DIACHI_NV"].Value?.ToString();
                txtSDT.Text = row.Cells["SDT_NV"].Value?.ToString();
                txtEmail.Text = row.Cells["EMAIL_NV"].Value?.ToString();

                // Handle the image display if you have an image column
                if (row.Cells["HINHANH"].Value != DBNull.Value && row.Cells["HINHANH"].Value != null)
                {
                    byte[] imageBytes = (byte[])row.Cells["HINHANH"].Value;
                    if (imageBytes.Length > 0)
                    {
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            pbImage.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        // Handle the case when the image byte array is empty
                        pbImage.Image = null; // or set a default image
                    }
                }
                else
                {
                    // Handle the case when the value is DBNull or null
                    pbImage.Image = null; // or set a default image
                }
            }
        }

        private void btnThemImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbImage.Image = Image.FromFile(openFileDialog.FileName);
                //this.Text = openFileDialog.FileName;    
            }
        }
        private byte[] imageToByte(Image img)
        {
            using (MemoryStream m = new MemoryStream())
            {
                img.Save(m, System.Drawing.Imaging.ImageFormat.Png);
                return m.ToArray();
            }
        }



        //Tài khoản
        public void HienThiTK()
        {
            listTK = ConvertDataTableToListTK(tkBLL.GetData());
            dgvTaiKhoan.Columns["USERNAME"].DataPropertyName = "USERNAME";
            dgvTaiKhoan.Columns["PASSWORD"].DataPropertyName = "PASSWORD";
            dgvTaiKhoan.Columns["LOAI"].DataPropertyName = "LOAI";
            dgvTaiKhoan.Columns["MANV_TK"].DataPropertyName = "MANV";
            dgvTaiKhoan.DataSource = listTK;
        }
        private List<TaiKhoanDTO> ConvertDataTableToListTK(DataTable dataTable)
        {
            List<TaiKhoanDTO> listTK = new List<TaiKhoanDTO>();

            foreach (DataRow row in dataTable.Rows)
            {
                TaiKhoanDTO tk = new TaiKhoanDTO
                {
                    USERNAME = row["USERNAME"].ToString(),
                    PASSWORD = row["PASSWORD"].ToString(),
                    LOAI = int.Parse(row["LOAI"].ToString()),
                    MANV = row["MANV"].ToString()
                };

                listTK.Add(tk);
            }

            return listTK;
        }
        private void loadCbbNV_TK()
        {
            List<NhanVienDTO> lstNV = ConvertDataTableToListNV(nVBLL.GetData());
            cbbNV_TK.Items.Clear();
            foreach (NhanVienDTO nv in lstNV)
            {
               cbbNV_TK.Items.Add(nv.MANV);
            }
        }
        private void loafCbbLoai()
        {
            Dictionary<int, string> Loai = new Dictionary<int, string>
            {
                { 0, "Admin" },
                { 1, "User" }
            };
            cbbLoai.DataSource = new BindingSource(Loai, null);
            cbbLoai.DisplayMember = "Value";
            cbbLoai.ValueMember = "Key";
        }
        private void tsbThemTK_Click(object sender, EventArgs e)
        {
            moKhoaDK_TK();
            IsInsert = true;
            txtNameNV_TK.Enabled = false;
            xoaTxt();
        }
        private void tsbSuaTK_Click(object sender, EventArgs e)
        {
            moKhoaDK_TK();
            cbbNV_TK.Enabled = false;
            txtNameNV_TK.Enabled = false;
            txtUserName.Enabled = false;
            txtPassWord.Enabled = true;
            IsInsert = false;
        }

        private void tsbXoaTK_Click(object sender, EventArgs e)
        {
            khoaDK_TK();
            if (MessageBox.Show("Bạn có muốn xóa thông tin này không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    tkBLL.Delete(txtUserName.Text);
                    MessageBox.Show("Đã xóa thông tin thành công!");
                    xoaTxt();
                    HienThiTK();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        private void tsbLuuTK_Click(object sender, EventArgs e)
        {
            tkDTO.USERNAME = txtUserName.Text;
            tkDTO.PASSWORD = txtPassWord.Text;
            tkDTO.LOAI = ((KeyValuePair<int, string>)cbbLoai.SelectedItem).Key;
            tkDTO.MANV = cbbNV_TK.SelectedItem.ToString();
            if (IsInsert == true)
            {
                List<TaiKhoanDTO> lstTK = ConvertDataTableToListTK(tkBLL.GetData());
                if(lstTK.Any(tk => tk.MANV == tkDTO.MANV))
                {
                    MessageBox.Show("Thêm thông tin không thành công!");
                }
                else
                {
                    //Insert
                    tkBLL.Insert(tkDTO);
                    MessageBox.Show("Thêm thông tin thành công!");
                    HienThiTK();
                    xoaTxt();
                    khoaDK_TK();
                }
            }
            else
            {
                //Update
                tkBLL.Update(tkDTO);
                MessageBox.Show("Sửa thông tin thành công!");
                HienThiTK();
                xoaTxt();
                khoaDK_TK();
            }
        }

        private void SearchTK(string keyword)
        {
            var results = listTK.Where(TK =>
            TK.USERNAME != null && TK.USERNAME.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
            TK.LOAI.ToString() != null && TK.LOAI.ToString().IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
            TK.MANV != null && TK.MANV.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0).ToList();

            dgvTaiKhoan.DataSource = results;
        }
        private void tsbSearchTK_Click(object sender, EventArgs e)
        {
            string keyword = tsbSearchtxtTK.Text.Trim();
            SearchTK(keyword);
        }

        private void dgvTaiKhoan_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            e.Paint(e.CellBounds, DataGridViewPaintParts.All);
            using (Pen gridPen = new Pen(Color.Gray))
            {
                gridPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                e.Graphics.DrawLine(gridPen, e.CellBounds.Left, e.CellBounds.Bottom - 1, e.CellBounds.Right, e.CellBounds.Bottom - 1);
                e.Graphics.DrawLine(gridPen, e.CellBounds.Right - 1, e.CellBounds.Top, e.CellBounds.Right - 1, e.CellBounds.Bottom);
            }
            e.Handled = true;
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            khoaDK();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTaiKhoan.Rows[e.RowIndex];

                // Assuming you have textboxes named txtMANV_TK, txtNameNV_TK, txtUserName, txtPassWord
                cbbNV_TK.Text = row.Cells["MANV_TK"].Value?.ToString();

                // Retrieve the corresponding information from NhanVien table
                DataTable nvData = nVBLL.GetDataByID(row.Cells["MANV_TK"].Value?.ToString());
                if (nvData.Rows.Count > 0)
                {
                    txtNameNV_TK.Text = nvData.Rows[0]["TENNV"].ToString();
                    if (nvData.Rows[0]["HINHANH"] != DBNull.Value && nvData.Rows[0]["HINHANH"] != null)
                    {
                        byte[] imageBytes = (byte[])nvData.Rows[0]["HINHANH"];
                        if (imageBytes.Length > 0)
                        {
                            using (MemoryStream ms = new MemoryStream(imageBytes))
                            {
                                // Check if the stream contains a valid image
                                try
                                {
                                    pbNV_TK.Image = Image.FromStream(ms);
                                }
                                catch (ArgumentException)
                                {
                                    // Handle the case when the stream does not contain a valid image
                                    pbNV_TK.Image = null; // or set a default image
                                }
                            }
                        }
                        else
                        {
                            // Handle the case when the image byte array is empty
                            pbNV_TK.Image = null; // or set a default image
                        }
                    }
                    else
                    {
                        // Handle the case when the value is DBNull or null
                        pbNV_TK.Image = null; // or set a default image
                    }
                }

                // Assuming your columns are named correctly in the DataGridView
                txtUserName.Text = row.Cells["USERNAME"].Value?.ToString();
                txtPassWord.Text = row.Cells["PASSWORD"].Value?.ToString();
            }
        }

        private void chkbPassWord_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbPassWord.Checked)
            {
                txtPassWord.PasswordChar = '\0'; // Hiển thị mật khẩu không che đi
            }
            else
            {
                txtPassWord.PasswordChar = '*'; // Hoặc bạn có thể sử dụng ký tự khác để che đi
            }
        }
    }
}
