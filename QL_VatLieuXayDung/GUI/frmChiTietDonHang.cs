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
    public partial class frmChiTietDonHang : Form
    {
        private string txtMaDH_CT;
        public frmChiTietDonHang()
        {
            InitializeComponent();
        }
        public frmChiTietDonHang(string maDH)
        {
            InitializeComponent();
            txtMaDH_CT = maDH;
        }
        private ChiTietPhieuThanhToanDTO chiTietPhieuThanhToanDTO = new ChiTietPhieuThanhToanDTO();
        private ChiTietPhieuThanhToanBLL chiTietPhieuThanhToanBLL = new ChiTietPhieuThanhToanBLL();
        private VatLieuBLL vl = new VatLieuBLL();
        private List<ChiTietPhieuThanhToanDTO> lstCTPTT;
        private bool IsInsert = false;
        private decimal tongTien = 0;

        public void khoaDK()
        {
            txtMaDH.Enabled = cbbVL.Enabled = txtGia.Enabled = txtSoLuong.Enabled = false;
            tsbThem.Enabled = tsbSua.Enabled = tsbXoa.Enabled = tsbXoaAll.Enabled = true;
            tsbLuu.Enabled = false;
        }
        public void moKhoaDK()
        {
            cbbVL.Enabled = txtSoLuong.Enabled = true;
            tsbThem.Enabled = tsbSua.Enabled = tsbXoa.Enabled = tsbXoaAll.Enabled = false;
            tsbLuu.Enabled = true;
        }
        public void xoaTxt()
        {
            txtMaDH.Text = txtGia.Text = txtSoLuong.Text = string.Empty;
            cbbVL.Focus();
        }
        public void loadVatLieu()
        {
            DataTable dt = vl.GetData();
            List<VatLieuDTO> nvList = ConvertDataTableToList<VatLieuDTO>(dt);

            var bindingList = new BindingList<VatLieuDTO>(nvList);
            var source = new BindingSource(bindingList, null);

            cbbVL.DataSource = source;
            cbbVL.DisplayMember = "TENVL";
            cbbVL.ValueMember = "MAVL";
        }
        public void HienThiCTPN()
        {
            lstCTPTT = ConvertDataTableToList<ChiTietPhieuThanhToanDTO>(chiTietPhieuThanhToanBLL.GetData());
            dgvCTPN.Columns["MADH"].DataPropertyName = "MADH";
            dgvCTPN.Columns["MAVL"].DataPropertyName = "MAVL";
            dgvCTPN.Columns["GIA"].DataPropertyName = "GIA";
            dgvCTPN.Columns["SOLUONG"].DataPropertyName = "SOLUONGBAN";
            dgvCTPN.DataSource = lstCTPTT.Where(s => s.MADH == txtMaDH_CT).ToList();

            tongTien = lstCTPTT.Where(s => s.MADH == txtMaDH_CT).Sum(s => s.SOLUONGBAN * s.GIA);
            lbTongTien.Text = tongTien.ToString();
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

        private void frmChiTietDonHang_Load(object sender, EventArgs e)
        {
            khoaDK();
            txtMaDH.Text = txtMaDH_CT;
            loadVatLieu();
            HienThiCTPN();
        }

        private void tsbThem_Click(object sender, EventArgs e)
        {
            moKhoaDK();
            IsInsert = true;
            xoaTxt();
            txtMaDH.Text = txtMaDH_CT;
        }

        private void tsbSua_Click(object sender, EventArgs e)
        {
            moKhoaDK();
            txtMaDH.Enabled = false;
            IsInsert = false;
        }

        private void tsbXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa thông tin này không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    chiTietPhieuThanhToanBLL.Delete(txtMaDH.Text, cbbVL.SelectedValue.ToString());
                    MessageBox.Show("Đã xóa thông tin thành công!");
                    xoaTxt();
                    khoaDK();
                    HienThiCTPN();
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
                chiTietPhieuThanhToanDTO.MADH = txtMaDH.Text;
                chiTietPhieuThanhToanDTO.MAVL = cbbVL.SelectedValue.ToString();
                chiTietPhieuThanhToanDTO.GIA = decimal.Parse(txtGia.Text);
                chiTietPhieuThanhToanDTO.SOLUONGBAN = int.Parse(txtSoLuong.Text);

                List<VatLieuDTO> lstVL = ConvertDataTableToList<VatLieuDTO>(vl.GetData());
                VatLieuDTO vatLieu = lstVL.FirstOrDefault(s => s.MAVL == chiTietPhieuThanhToanDTO.MAVL);
                if (chiTietPhieuThanhToanDTO.SOLUONGBAN > vatLieu.SOLUONGCON)
                {
                    MessageBox.Show($"Vật liệu {vatLieu.TENVL} số lượng còn lại trong kho chỉ còn {vatLieu.SOLUONGCON}");
                }
                else
                {
                    if (IsInsert)
                    {
                        // Thêm mới
                        chiTietPhieuThanhToanBLL.Insert(chiTietPhieuThanhToanDTO);
                        MessageBox.Show("Thêm thông tin thành công!");
                        // Refresh DataGridView
                        HienThiCTPN();
                        xoaTxt();
                        khoaDK();
                        lbTongTien.Text = tongTien.ToString();
                    }
                    else
                    {
                        // Cập nhật
                        chiTietPhieuThanhToanBLL.Update(chiTietPhieuThanhToanDTO);
                        MessageBox.Show("Sửa thông tin thành công!");
                        // Refresh DataGridView
                        HienThiCTPN();
                        xoaTxt();
                        khoaDK();
                        lbTongTien.Text = tongTien.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void Search(string keyword)
        {
            var results = lstCTPTT
            .Where(ctpn =>
                 ctpn.MADH != null && ctpn.MADH.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
                 ctpn.MAVL != null && ctpn.MAVL.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
                 ctpn.GIA.ToString().IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
                 ctpn.SOLUONGBAN.ToString().IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0)
            .ToList();

            dgvCTPN.DataSource = results;
        }
        private void tsbSearch_Click(object sender, EventArgs e)
        {
            string keyword = tsbSearchtxt.Text.Trim();
            Search(keyword);
        }

        private void dgvCTPN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            khoaDK();
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvCTPN.Rows[e.RowIndex];
                    txtMaDH.Text = row.Cells["MADH"].Value.ToString();
                    cbbVL.SelectedValue = row.Cells["MAVL"].Value.ToString();
                    txtGia.Text = row.Cells["GIA"].Value.ToString();
                    txtSoLuong.Text = row.Cells["SOLUONG"].Value.ToString();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void dgvCTPN_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            chiTietPhieuThanhToanBLL.updateTongTien(txtMaDH_CT);
            MessageBox.Show("Thêm chi tiết phiếu nhập thành công!");
            this.Close();
        }

        private void cbbVL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbVL.SelectedValue != null)
            {
                string ma = cbbVL.SelectedValue.ToString();

                // Lấy giá trị của cột "GIA" từ DataTable dựa trên giá trị đã chọn từ ComboBox
                DataRow[] selectedRows = vl.GetData().Select($"MAVL = '{ma}'");

                if (selectedRows.Length > 0)
                {
                    // Kiểm tra xem có ít nhất một dòng được chọn không
                    txtGia.Text = selectedRows[0]["GIA"].ToString();
                }
                else
                {
                    // Xử lý trường hợp không tìm thấy dòng
                    txtGia.Text = "N/A";
                }
            }
        }

        private void tsbXoaAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa tất cả chi tiết đơn hàng này không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    chiTietPhieuThanhToanBLL.DeleteALL(txtMaDH.Text);
                    MessageBox.Show("Đã xóa thông tin thành công!");
                    xoaTxt();
                    khoaDK();
                    HienThiCTPN();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
    }
}
