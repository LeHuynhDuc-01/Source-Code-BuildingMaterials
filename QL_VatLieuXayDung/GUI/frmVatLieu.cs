using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GUI
{
    public partial class frmVatLieu : Form
    {
        private ContextMenuStrip contextMenu;
        public frmVatLieu()
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
            khoaDK();
            tsbSearchtxt.Clear();
            tsbSearchtxt.Focus();
            xoaTxt();
            HienThiVatLieu();
        }
        private VatLieuDTO vlDTO = new VatLieuDTO();
        private VatLieuBLL vlBLL = new VatLieuBLL();
        private bool IsInsert = false;
        private List<VatLieuDTO> listVL;
        public void khoaDK()
        {
            txtMaVL.Enabled = cbbLoaiVatLieu.Enabled = txtTenVL.Enabled = txtMoTa.Enabled = cbbDonViTinh.Enabled = txtGia.Enabled = dtpNgaySX.Enabled = dtpHanSD.Enabled = txtXuatXu.Enabled = txtSoLuong.Enabled = false;
            tsbThem.Enabled = tsbSua.Enabled = tsbXoa.Enabled = true;
            tsbLuu.Enabled = false;
            btnThemImage.Enabled = false;
        }
        public void moKhoaDK()
        {
            cbbLoaiVatLieu.Enabled = txtTenVL.Enabled = txtMoTa.Enabled = cbbDonViTinh.Enabled = txtGia.Enabled = dtpNgaySX.Enabled = dtpHanSD.Enabled = txtXuatXu.Enabled = txtSoLuong.Enabled = true;
            tsbThem.Enabled = tsbSua.Enabled = tsbXoa.Enabled = false;
            tsbLuu.Enabled = true;
            btnThemImage.Enabled = true;
        }
        public void xoaTxt()
        {
            txtMaVL.Text = txtTenVL.Text = txtMoTa.Text = txtGia.Text = txtXuatXu.Text = txtSoLuong.Text = string.Empty;
            cbbLoaiVatLieu.Focus();
            cbbDonViTinh.Focus();
            dtpNgaySX.Focus();
            dtpHanSD.Focus();
        }
        public void HienThiVatLieu()
        {
            listVL = ConvertDataTableToList<VatLieuDTO>(vlBLL.GetData());
            dgvVatLieu.Columns["CL1"].DataPropertyName = "MAVL";
            dgvVatLieu.Columns["CL2"].DataPropertyName = "MALOAI";
            dgvVatLieu.Columns["CL3"].DataPropertyName = "TENVL";
            dgvVatLieu.Columns["CL4"].DataPropertyName = "HINHANH";
            dgvVatLieu.Columns["CL5"].DataPropertyName = "NGAYSX";
            dgvVatLieu.Columns["CL6"].DataPropertyName = "HANSD";
            dgvVatLieu.Columns["CL7"].DataPropertyName = "XUATXU";
            dgvVatLieu.Columns["CL8"].DataPropertyName = "DONVITINH";
            dgvVatLieu.Columns["CL9"].DataPropertyName = "GIA";
            dgvVatLieu.Columns["CL10"].DataPropertyName = "SOLUONGCON";
            dgvVatLieu.Columns["CL11"].DataPropertyName = "MOTA";
            dgvVatLieu.DataSource = listVL;
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

        public void loadCBBLoaiVatLieu()
        {
            cbbLoaiVatLieu.Items.Clear();
            LoaiVatLieuBLL ts = new LoaiVatLieuBLL();
            List<LoaiVatLieuDTO> lst = ts.GetData();
            var bindingList = new BindingList<LoaiVatLieuDTO>(lst);
            cbbLoaiVatLieu.DataSource = new BindingSource(bindingList, null);
            cbbLoaiVatLieu.DisplayMember = "TENLOAI";
            cbbLoaiVatLieu.ValueMember = "MALOAI";
            if (cbbLoaiVatLieu.Items.Count > 0)
            {
                cbbLoaiVatLieu.SelectedIndex = 0;
            }
        }
        public void loadCBBDonViTinh()
        {
            Dictionary<int, string> Dv = new Dictionary<int, string>
            {
                { 0, "m3" },
                { 1, "Viên" },
                { 2, "m2" },
                { 3, "Thùng" },
                { 4, "Cây" },
                { 5, "Bao" },
                { 6, "Cái" }
            };
            cbbDonViTinh.DataSource = new BindingSource(Dv, null);
            cbbDonViTinh.DisplayMember = "Value";
            cbbDonViTinh.ValueMember = "Value";
            cbbDonViTinh.SelectedIndex = 0;
        }
        private void dgvVatLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            khoaDK();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvVatLieu.Rows[e.RowIndex];

                txtMaVL.Text = row.Cells["CL1"].Value?.ToString();
                cbbLoaiVatLieu.SelectedValue = row.Cells["CL2"].Value?.ToString();
                txtTenVL.Text = row.Cells["CL3"].Value?.ToString();
                txtMoTa.Text = row.Cells["CL11"].Value?.ToString();
                cbbDonViTinh.SelectedValue = row.Cells["CL8"].Value?.ToString();
                txtGia.Text = row.Cells["CL9"].Value?.ToString();
                if (DateTime.TryParse(row.Cells["CL5"].Value?.ToString(), out DateTime ngaySX))
                {
                    if(ngaySX != DateTime.MinValue)
                    {
                        dtpNgaySX.Value = ngaySX;
                    }
                    else
                    {
                        dtpNgaySX.Value = DateTime.Today;
                    }
                }
                if (DateTime.TryParse(row.Cells["CL6"].Value?.ToString(), out DateTime hanSD))
                {
                    if (hanSD != DateTime.MinValue)
                    {
                        dtpHanSD.Value = hanSD;
                    }
                    else
                    {
                        dtpHanSD.Value = DateTime.Today;
                    }
                }
                txtXuatXu.Text = row.Cells["CL7"].Value?.ToString();
                txtSoLuong.Text = row.Cells["CL10"].Value?.ToString();

                if (row.Cells["CL4"].Value != DBNull.Value && row.Cells["CL4"].Value != null)
                {
                    byte[] imageBytes = (byte[])row.Cells["CL4"].Value;
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

        private void dgvVatLieu_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void frmVatLieu_Load(object sender, EventArgs e)
        {
            khoaDK();
            loadCBBLoaiVatLieu();
            loadCBBDonViTinh();
            HienThiVatLieu();
        }
        static string GenerateNewCode(List<VatLieuDTO> list)
        {
            // Nếu danh sách rỗng, trả về mã mặc định
            if (list.Count == 0)
            {
                return "VL01";
            }

            // Lấy phần tử cuối cùng trong danh sách
            string lastCode = list.Last().MAVL;

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
            txtMaVL.Text = GenerateNewCode(listVL);
        }

        private void tsbSua_Click(object sender, EventArgs e)
        {
            moKhoaDK();
            txtMaVL.Enabled = false;
            IsInsert = false;
        }

        private void tsbXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa thông tin này không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    vlBLL.Delete(txtMaVL.Text);
                    MessageBox.Show("Đã xóa thông tin thành công!");
                    HienThiVatLieu();
                    xoaTxt();
                    khoaDK();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        private void tsbLuu_Click(object sender, EventArgs e)
        {
            byte[] image = imageToByte(pbImage.Image);
            vlDTO.MAVL = txtMaVL.Text;
            vlDTO.MALOAI = cbbLoaiVatLieu.SelectedValue.ToString();
            vlDTO.TENVL = txtTenVL.Text;
            vlDTO.HINHANH = image;
            vlDTO.MOTA = txtMoTa.Text;
            vlDTO.DONVITINH = cbbDonViTinh.SelectedValue.ToString();
            vlDTO.GIA = decimal.Parse(txtGia.Text);
            vlDTO.NGAYSX = DateTime.Parse(dtpNgaySX.Value.ToString());
            vlDTO.HANSD = DateTime.Parse(dtpHanSD.Value.ToString());
            vlDTO.XUATXU = txtXuatXu.Text;
            vlDTO.SOLUONGCON = int.Parse(txtSoLuong.Text);
            if (IsInsert == true)
            {
                //Insert
                vlBLL.Insert(vlDTO);
                MessageBox.Show("Thêm thông tin thành công!");
                HienThiVatLieu();
                xoaTxt();
                khoaDK();
            }
            else
            {
                //Update
                vlBLL.Update(vlDTO);
                MessageBox.Show("Sửa thông tin thành công!");
                HienThiVatLieu();
                xoaTxt();
                khoaDK();
            }
            image = null;
        }
        private void Search(string keyword)
        {
            var results = listVL
            .Where(vatLieu =>
                 vatLieu.MAVL != null && vatLieu.MAVL.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
                 vatLieu.MALOAI != null && vatLieu.MALOAI.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
                 vatLieu.TENVL != null && vatLieu.TENVL.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
                 vatLieu.MOTA != null && vatLieu.MOTA.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
                 vatLieu.DONVITINH != null && vatLieu.DONVITINH.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
                 vatLieu.GIA.ToString().IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
                 vatLieu.NGAYSX.ToString("yyyy-MM-dd").IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
                 vatLieu.HANSD.ToString("yyyy-MM-dd").IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
                 vatLieu.XUATXU != null && vatLieu.XUATXU.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
                 vatLieu.SOLUONGCON.ToString().IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0)
            .ToList();

            dgvVatLieu.DataSource = results;
        }
        private void tsbSearch_Click(object sender, EventArgs e)
        {
            string keyword = tsbSearchtxt.Text.Trim();
            Search(keyword);
        }

        private void btnThemImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
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
    }
}
