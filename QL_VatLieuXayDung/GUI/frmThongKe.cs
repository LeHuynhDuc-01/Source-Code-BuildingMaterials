using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmThongKe : Form
    {
        private ContextMenuStrip contextMenu;
        public frmThongKe()
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
            HienThiPhieuThanhToan();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Color topBorderColor = Color.LightSeaGreen;

            // Specify the width for the top border
            int topBorderWidth = 3;

            // Get the Graphics object from the panel
            Graphics g = e.Graphics;

            // Draw the top border using Pen
            using (Pen topBorderPen = new Pen(topBorderColor, topBorderWidth))
            {
                g.DrawLine(topBorderPen, 0, 0, panel1.Width - 1, 0);
            }
        }

        PhieuThanhToanDTO phieuThanhToanDTO = new PhieuThanhToanDTO();
        private PhieuThanhToanBLL phieuThanhToanBLL = new PhieuThanhToanBLL();
        private List<PhieuThanhToanDTO> lstPTT ;
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
        public void HienThiPhieuThanhToan(List<PhieuThanhToanDTO> lst)
        {
            dgvHoaDon.DataSource = lst;

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

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            loadcbbTrangThai();
            HienThiPhieuThanhToan();
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

        private void dtpToiNgay_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btnXemThongTin_Click(object sender, EventArgs e)
        {
            if (dtpTuNgay.Value > dtpToiNgay.Value)
            {
                MessageBox.Show("Thời gian bạn chọn không chính xác (Từ ngày phải < Tới ngày)");
            }
            else
            {
                if (cbbTrangThai.SelectedValue == null)
                {
                    List<PhieuThanhToanDTO> filteredList = lstPTT
                        .Where(item => item.NGAYDAT >= dtpTuNgay.Value && item.NGAYDAT <= dtpToiNgay.Value)
                        .ToList();
                   if(filteredList.Count > 0)
                    {
                        HienThiPhieuThanhToan(filteredList);
                        txtTongDoanhThu.Text = filteredList.Sum(s => s.TONGHOADON).ToString();
                    }
                    else
                    {
                        txtTongDoanhThu.Text = "0";
                        MessageBox.Show("Trong khoảng thời gian đó không có đơn hàng nào được tạo!");
                    }
                }
                else
                {
                    List<PhieuThanhToanDTO> filteredList = lstPTT
                        .Where(item => item.NGAYDAT >= dtpTuNgay.Value && item.NGAYDAT <= dtpToiNgay.Value && item.TRANGTHAI == cbbTrangThai.SelectedValue.ToString())
                        .ToList();
                    if (filteredList.Count > 0)
                    {
                        HienThiPhieuThanhToan(filteredList);
                        txtTongDoanhThu.Text = filteredList.Sum(s => s.TONGHOADON).ToString();
                    }
                    else
                    {
                        txtTongDoanhThu.Text = "0";
                        MessageBox.Show("Trong khoảng thời gian đó không có đơn hàng nào được tạo!");
                    }
                }
                }
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvHoaDon.Columns["CHITIET"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvHoaDon.Rows[e.RowIndex];
                frmChiTietDonHang ct = new frmChiTietDonHang(row.Cells["MADH"].Value.ToString());
                ct.Show();
                ct.BringToFront();
                this.BringToFront();
            }
        }
    }
}
