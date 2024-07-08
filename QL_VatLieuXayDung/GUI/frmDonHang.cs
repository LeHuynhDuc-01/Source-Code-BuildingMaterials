using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmDonHang : Form
    {

        private ContextMenuStrip contextMenu;
        private string txtMaND;
        public frmDonHang()
        {
            InitializeComponent();
            contextMenu = new ContextMenuStrip();
            ToolStripMenuItem menuItem1 = new ToolStripMenuItem("Refesh");
            menuItem1.Click += MenuItem1_Click;
            contextMenu.Items.Add(menuItem1);
            this.ContextMenuStrip = contextMenu;
        }
        public frmDonHang(string maND)
        {
            InitializeComponent();
            contextMenu = new ContextMenuStrip();
            ToolStripMenuItem menuItem1 = new ToolStripMenuItem("Refesh");
            menuItem1.Click += MenuItem1_Click;
            contextMenu.Items.Add(menuItem1);
            this.ContextMenuStrip = contextMenu;
            txtMaND = maND;
        }
        private void MenuItem1_Click(object sender, EventArgs e)
        {
            KhoaDK();
            tsbSearchtxt.Clear();
            tsbSearchtxt.Focus();
            xoaTxt();
            txtMaNV.Text = txtMaND;
            HienThiPhieuThanhToan();
        }

        PhieuThanhToanDTO phieuThanhToanDTO = new PhieuThanhToanDTO();
        private PhieuThanhToanBLL phieuThanhToanBLL = new PhieuThanhToanBLL();
        private List<PhieuThanhToanDTO> lstPTT;
        private bool IsInsert = false;
        // khóa
        public void KhoaDK()
        {
            txtMaHD.Enabled = txtMaNV.Enabled = txtTongHoaDon.Enabled = cbbMAKH.Enabled = cbbTrangThai.Enabled = dtpNgayDat.Enabled = false;
            tsbThem.Enabled = tsbSua.Enabled = tsbXoa.Enabled = true;
            tsbLuu.Enabled = false;
        }
        public void moKhoaDK()
        {
            txtMaHD.Enabled = cbbMAKH.Enabled = cbbTrangThai.Enabled = dtpNgayDat.Enabled = true;
            tsbThem.Enabled = tsbSua.Enabled = tsbXoa.Enabled = false;
            tsbLuu.Enabled = true;
        }
        public void xoaTxt()
        {
            txtMaHD.Text = string.Empty;
            txtTongHoaDon.Text = "0";
            cbbMAKH.Focus();
            cbbTrangThai.Focus();
            dtpNgayDat.Focus();
        }
        public void loadCBBKH()
        {
            KhachHangBLL khBLL = new KhachHangBLL();
            DataTable kh = khBLL.GetData();

            // Convert DataTable to List<NCCDTO>
            List<KhachHangDTO> khList = ConvertDataTableToList<KhachHangDTO>(kh);

            var bindingList = new BindingList<KhachHangDTO>(khList);
            var source = new BindingSource(bindingList, null);

            cbbMAKH.DataSource = source;
            cbbMAKH.DisplayMember = "TENKH";
            cbbMAKH.ValueMember = "MAKH";
        }

        public void loadcbbTrangThai()
        {
            Dictionary<int, string> trangThai = new Dictionary<int, string>
            {
                { 0, "Đang xử lý" },
                { 1, "Đã giao" }
            };
            cbbTrangThai.DataSource = new BindingSource(trangThai, null);
            cbbTrangThai.DisplayMember = "Value";
            cbbTrangThai.ValueMember = "Value";
            cbbTrangThai.SelectedIndex = 0;
        }

        
        public void HienThiPhieuThanhToan()
        {
            lstPTT = ConvertDataTableToList<PhieuThanhToanDTO>(phieuThanhToanBLL.GetData());
            dgvHoaDon.DataSource = lstPTT;

            // Kiểm tra xem cột xemChiTiet đã tồn tại chưa
            if (dgvHoaDon.Columns["CHITIET"] == null)
            {
                // Nếu chưa tồn tại, thêm mới
                DataGridViewButtonColumn xemChiTiet = new DataGridViewButtonColumn();
                xemChiTiet.HeaderText = "Thêm và xem chi tiết";
                xemChiTiet.Name = "CHITIET";
                xemChiTiet.Text = "Chi tiết";
                xemChiTiet.UseColumnTextForButtonValue = true;
                dgvHoaDon.Columns.Add(xemChiTiet);
            }
        }
        private List<T> ConvertDataTableToList<T>(DataTable dataTable) where T : new()
        {
            List<T> list = new List<T>();

            foreach (DataRow row in dataTable.Rows)
            {
                T item = new T();

                foreach (DataColumn column in dataTable.Columns)
                {
                    PropertyInfo prop = typeof(T).GetProperty(column.ColumnName);
                    if (prop != null && row[column] != DBNull.Value)
                    {
                        prop.SetValue(item, Convert.ChangeType(row[column], prop.PropertyType), null);
                    }
                }

                list.Add(item);
            }

            return list;
        }
        private void frmDonHang_Load(object sender, EventArgs e)
        {
            KhoaDK();
            loadCBBKH();
            loadcbbTrangThai();
            txtMaNV.Text = txtMaND;
            HienThiPhieuThanhToan();
        }
        static string GenerateNewCode(List<PhieuThanhToanDTO> list)
        {
            // Nếu danh sách rỗng, trả về mã mặc định
            if (list.Count == 0)
            {
                return "HD0001";
            }

            // Lấy phần tử cuối cùng trong danh sách
            string lastCode = list.Last().MADH;

            // Tách "HD" và số từ mã cuối cùng
            string prefix = lastCode.Substring(0, 2);
            string numberPart = lastCode.Substring(2);

            // Chuyển số thành số nguyên và tăng lên 1
            int number = int.Parse(numberPart) + 1;

            // Tạo mã mới
            string newCode = $"{prefix}{number:D4}";

            return newCode;
        }
        private void tsbThem_Click(object sender, EventArgs e)
        {
            moKhoaDK();
            IsInsert = true;
            txtMaHD.Enabled = false;
            xoaTxt();
            txtMaHD.Text = GenerateNewCode(lstPTT);
        }

        private void tsbSua_Click(object sender, EventArgs e)
        {
            moKhoaDK();
            txtMaHD.Enabled = false;
            IsInsert = false;
        }

        private void tsbXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa thông tin này không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    phieuThanhToanBLL.Delete(txtMaHD.Text);
                    MessageBox.Show("Đã xóa thông tin thành công!");
                    xoaTxt();
                    KhoaDK();
                    HienThiPhieuThanhToan();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        private void tsbLuu_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra dữ liệu hợp lệ
                if (cbbMAKH.SelectedValue == null || cbbTrangThai.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                    return;
                }

                phieuThanhToanDTO.MADH = txtMaHD.Text;
                phieuThanhToanDTO.MAKH = cbbMAKH.SelectedValue.ToString();
                phieuThanhToanDTO.MANV = txtMaNV.Text;
                phieuThanhToanDTO.NGAYDAT = dtpNgayDat.Value;
                phieuThanhToanDTO.TRANGTHAI = cbbTrangThai.SelectedValue.ToString();
                phieuThanhToanDTO.TONGHOADON = decimal.Parse(txtTongHoaDon.Text);

                if (IsInsert)
                {
                    phieuThanhToanBLL.Insert(phieuThanhToanDTO);
                    MessageBox.Show("Thêm thông tin thành công!");
                }
                else
                {
                    // Cập nhật
                    phieuThanhToanBLL.Update(phieuThanhToanDTO);
                    MessageBox.Show("Sửa thông tin thành công!");
                }

                // Refresh DataGridView
                xoaTxt();
                KhoaDK();
                HienThiPhieuThanhToan();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }
        private void Search(string keyword)
        {
            var results = lstPTT
            .Where(ptt =>
                ptt.MADH != null && ptt.MADH.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
                ptt.MAKH != null && ptt.MAKH.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
                ptt.MANV != null && ptt.MANV.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
                ptt.NGAYDAT.ToString("yyyy-MM-dd").IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
                ptt.TRANGTHAI != null && ptt.TRANGTHAI.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
                ptt.TONGHOADON.ToString().IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0)
            .ToList();

            dgvHoaDon.DataSource = results;
        }
        private void tsbSearch_Click(object sender, EventArgs e)
        {
            string keyword = tsbSearchtxt.Text.Trim();
            Search(keyword);
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            KhoaDK();
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvHoaDon.Rows[e.RowIndex];
                    txtMaHD.Text = row.Cells["MADH"].Value.ToString();
                    cbbMAKH.SelectedValue = row.Cells["MAKH"].Value.ToString();
                    txtMaNV.Text = row.Cells["MANV"].Value.ToString();
                    dtpNgayDat.Value = DateTime.Parse(row.Cells["NGAYDAT"].Value.ToString());
                    txtTongHoaDon.Text = row.Cells["TONGHOADON"].Value.ToString();
                }
                if (e.ColumnIndex == dgvHoaDon.Columns["CHITIET"].Index && e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvHoaDon.Rows[e.RowIndex];
                    frmChiTietDonHang ct = new frmChiTietDonHang(row.Cells["MADH"].Value.ToString());
                    ct.Show();
                    ct.BringToFront();
                    this.BringToFront();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void dgvHoaDon_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void tsbIn_Click(object sender, EventArgs e)
        {
            frmReportDonHang frmReportDonHang = new frmReportDonHang(txtMaHD.Text);
            frmReportDonHang.BringToFront();
            frmReportDonHang.Show();
        }
    }
}
