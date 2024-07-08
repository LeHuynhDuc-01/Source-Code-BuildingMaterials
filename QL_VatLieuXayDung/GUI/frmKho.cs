using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GUI
{
    public partial class frmKho : Form
    {
        private ContextMenuStrip contextMenu;
        public frmKho()
        {
            InitializeComponent();
            contextMenu = new ContextMenuStrip();
            ToolStripMenuItem menuItem1 = new ToolStripMenuItem("Refesh");
            menuItem1.Click += MenuItem1_Click;
            contextMenu.Items.Add(menuItem1);
            this.ContextMenuStrip = contextMenu;
        }
        private void MenuItem1_Click(object sender, EventArgs e)
        {
            KhoaDK();
            tsbSearchtxt.Clear();
            tsbSearchtxt.Focus();
            xoaTxt();
            HienThiPN();
        }
        private PhieuNhapDTO phieuNhapDTO = new PhieuNhapDTO();
        private PhieuNhapBLL phieuNhapBLL = new PhieuNhapBLL();
        private List<PhieuNhapDTO> lstPN = new List<PhieuNhapDTO>();
        private bool IsInsert = false;
        // khóa
        public void KhoaDK()
        {
            txtMaPN.Enabled = cbbNCC.Enabled = cbbNV.Enabled = dtpNgayNhap.Enabled = false;
            tsbThem.Enabled = tsbSua.Enabled = tsbXoa.Enabled = true;
            tsbLuu.Enabled = false;
        }
        public void moKhoaDK()
        {
            cbbNCC.Enabled = cbbNV.Enabled = dtpNgayNhap.Enabled = true;
            tsbThem.Enabled = tsbSua.Enabled = tsbXoa.Enabled = false;
            tsbLuu.Enabled = true;
        }
        public void xoaTxt()
        {
            txtMaPN.Text = string.Empty;
            cbbNCC.Text = string.Empty;
            cbbNV.Text = string.Empty;
            cbbNCC.Focus();
            cbbNV.Focus();
            dtpNgayNhap.Focus();
        }
        public void loadCBBNCC()
        {
            NCCBLL ncc = new NCCBLL();
            DataTable nccDataTable = ncc.GetData();

            // Convert DataTable to List<NCCDTO>
            List<NCCDTO> nccList = ConvertDataTableToList<NCCDTO>(nccDataTable);

            var bindingList = new BindingList<NCCDTO>(nccList);
            var source = new BindingSource(bindingList, null);

            cbbNCC.DataSource = source;
            cbbNCC.DisplayMember = "TENNCC";
            cbbNCC.ValueMember = "MANCC";
        }
        public void loadCBBNV()
        {
            NhanVienBLL nv = new NhanVienBLL();
            DataTable nvDataTable = nv.GetData();

            // Convert DataTable to List<NhanVienDTO>
            List<NhanVienDTO> nvList = ConvertDataTableToList<NhanVienDTO>(nvDataTable);

            var bindingList = new BindingList<NhanVienDTO>(nvList);
            var source = new BindingSource(bindingList, null);

            cbbNV.DataSource = source;
            cbbNV.DisplayMember = "TENNV";
            cbbNV.ValueMember = "MANV";
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
        public void HienThiPN()
        {
            lstPN = ConvertDataTableToList(phieuNhapBLL.GetData());
            dgvPhieuNhap.Columns["MAPN"].DataPropertyName = "MAPN";
            dgvPhieuNhap.Columns["MANCC"].DataPropertyName = "MANCC";
            dgvPhieuNhap.Columns["MANV"].DataPropertyName = "MANV";
            dgvPhieuNhap.Columns["TONGNHAP"].DataPropertyName = "TONGNHAP";
            dgvPhieuNhap.Columns["NGAYNHAP"].DataPropertyName = "NGAYNHAP";
            dgvPhieuNhap.DataSource = lstPN;
        }
        private List<PhieuNhapDTO> ConvertDataTableToList(DataTable dataTable)
        {
            List<PhieuNhapDTO> listPN = new List<PhieuNhapDTO>();

            foreach (DataRow row in dataTable.Rows)
            {
                PhieuNhapDTO pn = new PhieuNhapDTO
                {
                    MAPN = row["MAPN"].ToString(),
                    MANCC = row["MANCC"].ToString(),
                    MANV = row["MANV"].ToString(),
                    TONGNHAP = decimal.Parse(row["TONGNHAP"].ToString()),
                    NGAYNHAP = DateTime.Parse(row["NGAYNHAP"].ToString())
                };

                listPN.Add(pn);
            }

            return listPN;
        }
        private void frmKho_Load(object sender, EventArgs e)
        {
            KhoaDK();
            loadCBBNCC();
            loadCBBNV();
            HienThiPN();
        }
        static string GenerateNewCode(List<PhieuNhapDTO> list)
        {
            // Nếu danh sách rỗng, trả về mã mặc định
            if (list.Count == 0)
            {
                return "PN0001";
            }

            // Lấy phần tử cuối cùng trong danh sách
            string lastCode = list.Last().MAPN;

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
            xoaTxt();
            txtMaPN.Text = GenerateNewCode(lstPN);
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
                    phieuNhapBLL.Delete(txtMaPN.Text);
                    MessageBox.Show("Đã xóa thông tin thành công!");
                    xoaTxt();
                    KhoaDK();
                    HienThiPN();
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
                if (string.IsNullOrWhiteSpace(txtMaPN.Text) || cbbNCC.SelectedValue == null || cbbNV.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                    return;
                }

                phieuNhapDTO.MAPN = txtMaPN.Text;
                phieuNhapDTO.MANCC = cbbNCC.SelectedValue.ToString();
                phieuNhapDTO.MANV = cbbNV.SelectedValue.ToString();
                phieuNhapDTO.TONGNHAP = 0;
                phieuNhapDTO.NGAYNHAP = dtpNgayNhap.Value;

                if (IsInsert)
                {
                    // Thêm mới
                    phieuNhapBLL.Insert(phieuNhapDTO);
                    MessageBox.Show("Thêm thông tin thành công!");
                }
                else
                {
                    // Cập nhật
                    phieuNhapBLL.Update(phieuNhapDTO);
                    MessageBox.Show("Sửa thông tin thành công!");
                }

                // Refresh DataGridView
                HienThiPN();
                xoaTxt();
                KhoaDK();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }
        private void Search(string keyword)
        {
            var results = lstPN
            .Where(phieuNhap =>
                 phieuNhap.MAPN != null && phieuNhap.MAPN.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
                 phieuNhap.MANCC != null && phieuNhap.MANCC.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
                 phieuNhap.MANV != null && phieuNhap.MANV.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
                 phieuNhap.TONGNHAP.ToString().IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
                 phieuNhap.NGAYNHAP.ToString("yyyy-MM-dd").IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0)
            .ToList();

            dgvPhieuNhap.DataSource = results;
        }
        private void tsbSearch_Click(object sender, EventArgs e)
        {
            string keyword = tsbSearchtxt.Text.Trim();
            Search(keyword);
        }
        private void dgvPhieuNhap_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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


        private void dgvPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            KhoaDK();
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvPhieuNhap.Rows[e.RowIndex];
                    txtMaPN.Text = row.Cells["MAPN"].Value.ToString();
                    cbbNCC.Text = row.Cells["MANCC"].Value.ToString();
                    cbbNV.Text = row.Cells["MANV"].Value.ToString();
                    dtpNgayNhap.Value = DateTime.Parse(row.Cells["NGAYNHAP"].Value.ToString());
                }
                if (e.ColumnIndex == dgvPhieuNhap.Columns["CHITIET"].Index && e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvPhieuNhap.Rows[e.RowIndex];
                    frmChiTietPhieuNhap ct = new frmChiTietPhieuNhap(row.Cells["MAPN"].Value.ToString());
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
    }
}
