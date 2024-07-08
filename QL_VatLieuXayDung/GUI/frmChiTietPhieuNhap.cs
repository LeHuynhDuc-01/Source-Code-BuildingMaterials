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
    public partial class frmChiTietPhieuNhap : Form
    {
        private string txtMAPN_PN;
        public frmChiTietPhieuNhap()
        {
            InitializeComponent();
        }
        public frmChiTietPhieuNhap(string mAPN)
        {
            InitializeComponent();
            txtMAPN_PN = mAPN;
        }
        private ChiTietPhieuNhapDTO ChiTietPhieuNhapDTO = new ChiTietPhieuNhapDTO();
        private ChiTietPhieuNhapBLL ChiTietPhieuNhapBLL = new ChiTietPhieuNhapBLL();
        private VatLieuBLL vl = new VatLieuBLL();
        private List<ChiTietPhieuNhapDTO> lstCTPN;
        private bool IsInsert = false;
        private decimal tongTien = 0;

        public void khoaDK()
        {
            txtMaPN.Enabled = cbbVL.Enabled = txtGia.Enabled = txtSoLuong.Enabled = false;
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
            txtMaPN.Text = txtGia.Text = txtSoLuong.Text = string.Empty;
            cbbVL.Focus();
        }
        public void loadVatLieu()
        {
            VatLieuBLL vl = new VatLieuBLL();
            DataTable nvDataTable = vl.GetData();

            List<VatLieuDTO> nvList = ConvertDataTableToList<VatLieuDTO>(nvDataTable);

            var bindingList = new BindingList<VatLieuDTO>(nvList);
            var source = new BindingSource(bindingList, null);

            cbbVL.DataSource = source;
            cbbVL.DisplayMember = "TENVL";
            cbbVL.ValueMember = "MAVL";
        }

        public void HienThiCTPN()
        {
            lstCTPN = ConvertDataTableToList<ChiTietPhieuNhapDTO>(ChiTietPhieuNhapBLL.GetData());
            dgvCTPN.Columns["MAPN"].DataPropertyName = "MAPN";
            dgvCTPN.Columns["MAVL"].DataPropertyName = "MAVL";
            dgvCTPN.Columns["GIANHAP"].DataPropertyName = "GIANHAP";
            dgvCTPN.Columns["SOLUONG"].DataPropertyName = "SOLUONGNHAP";
            dgvCTPN.DataSource = lstCTPN.Where(s=>s.MAPN==txtMAPN_PN).ToList();

            tongTien = lstCTPN.Where(s => s.MAPN == txtMAPN_PN).Sum(s => s.SOLUONGNHAP * s.GIANHAP);
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
        private void frmChiTietPhieuNhap_Load(object sender, EventArgs e)
        {
            khoaDK();
            txtMaPN.Text = txtMAPN_PN;
            loadVatLieu();
            HienThiCTPN();
        }

        private void tsbThem_Click(object sender, EventArgs e)
        {
            moKhoaDK();
            IsInsert = true;
            xoaTxt();
            txtMaPN.Text = txtMAPN_PN;
        }

        private void tsbSua_Click(object sender, EventArgs e)
        {
            moKhoaDK();
            txtMaPN.Enabled = false;
            IsInsert = false;
        }

        private void tsbXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa thông tin này không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    ChiTietPhieuNhapBLL.Delete(txtMaPN.Text, cbbVL.SelectedValue.ToString());
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

        private void tsbXoaAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa tất cả phiếu chi tiết không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    ChiTietPhieuNhapBLL.DeleteALL(txtMaPN.Text);
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
                ChiTietPhieuNhapDTO.MAPN = txtMaPN.Text;
                ChiTietPhieuNhapDTO.MAVL = cbbVL.SelectedValue.ToString();
                ChiTietPhieuNhapDTO.SOLUONGNHAP = int.Parse(txtSoLuong.Text);
                ChiTietPhieuNhapDTO.GIANHAP = decimal.Parse(txtGia.Text);

                if (IsInsert)
                {
                    // Thêm mới
                    ChiTietPhieuNhapBLL.Insert(ChiTietPhieuNhapDTO);
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
                    ChiTietPhieuNhapBLL.Update(ChiTietPhieuNhapDTO);
                    MessageBox.Show("Sửa thông tin thành công!");
                    // Refresh DataGridView
                    HienThiCTPN();
                    xoaTxt();
                    khoaDK();
                    lbTongTien.Text = tongTien.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }
        private void Search(string keyword)
        {
            var results = lstCTPN
            .Where(ctpn =>
                 ctpn.MAPN != null && ctpn.MAPN.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
                 ctpn.MAVL != null && ctpn.MAVL.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
                 ctpn.GIANHAP.ToString().IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
                 ctpn.SOLUONGNHAP.ToString().IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0)
            .ToList();

            dgvCTPN.DataSource = results;
        }
        private void tsbSearch_Click(object sender, EventArgs e)
        {
            string keyword = tsbSearchtxt.Text.Trim();
            Search(keyword);
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
            ChiTietPhieuNhapBLL.updateTongTien(txtMAPN_PN);
            MessageBox.Show("Thêm chi tiết phiếu nhập thành công!");
            this.Close();
        }

        private void dgvCTPN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            khoaDK();
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvCTPN.Rows[e.RowIndex];
                    txtMaPN.Text = row.Cells["MAPN"].Value.ToString();
                    // Các thuộc tính khác của ChiTietPhieuNhapDTO tương ứng
                    cbbVL.SelectedValue = row.Cells["MAVL"].Value.ToString();
                    txtGia.Text = row.Cells["GIANHAP"].Value.ToString();
                    txtSoLuong.Text = row.Cells["SOLUONG"].Value.ToString();
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
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

    }
}
