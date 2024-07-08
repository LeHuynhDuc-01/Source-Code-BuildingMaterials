using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class frmKhachHang : Form
    {

        private ContextMenuStrip contextMenu;
        public frmKhachHang()
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
            HienThiKH();
        }
        private KhachHangDTO khDTO = new KhachHangDTO();
        private KhachHangBLL khBLL = new KhachHangBLL();
        private bool IsInsert = false;
        private List<KhachHangDTO> listKH = new List<KhachHangDTO>();

        public void khoaDK()
        {
            txtMaKH.Enabled = txtName.Enabled = txtAddress.Enabled = txtPhone.Enabled = txtEmail.Enabled = false;
            tsbThem.Enabled = tsbSua.Enabled = tsbXoa.Enabled = tsbPrint.Enabled = true;
            tsbLuu.Enabled = false;
        }
        public void moKhoaDK()
        {
            txtName.Enabled = txtAddress.Enabled = txtPhone.Enabled = txtEmail.Enabled = true;
            tsbThem.Enabled = tsbSua.Enabled = tsbXoa.Enabled = tsbPrint.Enabled = false;
            tsbLuu.Enabled = true;
        }
        public void xoaTxt()
        {
            txtMaKH.Text = txtName.Text = txtAddress.Text = txtPhone.Text = txtEmail.Text = string.Empty;
        }
        public void HienThiKH()
        {
            listKH = ConvertDataTableToList(khBLL.GetData());
            dgvKH.Columns["MAKH"].DataPropertyName = "MAKH";
            dgvKH.Columns["TENKH"].DataPropertyName = "TENKH";
            dgvKH.Columns["DIACHI"].DataPropertyName = "DIACHI";
            dgvKH.Columns["SDT_KH"].DataPropertyName = "SDT_KH";
            dgvKH.Columns["EMAIL_KH"].DataPropertyName = "EMAIL_KH";
            dgvKH.DataSource = listKH;
        }
        private List<KhachHangDTO> ConvertDataTableToList(DataTable dataTable)
        {
            List<KhachHangDTO> listKH = new List<KhachHangDTO>();

            foreach (DataRow row in dataTable.Rows)
            {
                KhachHangDTO KH = new KhachHangDTO
                {
                    MAKH = row["MAKH"].ToString(),
                    TENKH = row["TENKH"].ToString(),
                    DIACHI = row["DIACHI"].ToString(),
                    SDT_KH = row["SDT_KH"].ToString(),
                    EMAIL_KH = row["EMAIL_KH"].ToString()
                };

                listKH.Add(KH);
            }

            return listKH;
        }
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            khoaDK();
            HienThiKH();
        }

        static string GenerateNewCode(List<KhachHangDTO> list)
        {
            // Nếu danh sách rỗng, trả về mã mặc định
            if (list.Count == 0)
            {
                return "KH01";
            }

            // Lấy phần tử cuối cùng trong danh sách
            string lastCode = list.Last().MAKH;

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
            txtMaKH.Text = GenerateNewCode(listKH);
        }

        private void tsbSua_Click(object sender, EventArgs e)
        {
            moKhoaDK();
            txtMaKH.Enabled = false;
            IsInsert = false;
        }

        private void tsbXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa thông tin này không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    khBLL.Delete(txtMaKH.Text);
                    MessageBox.Show("Đã xóa thông tin thành công!");
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
            khDTO.MAKH = txtMaKH.Text;
            khDTO.TENKH= txtName.Text;
            khDTO.DIACHI = txtAddress.Text;
            khDTO.SDT_KH = txtPhone.Text;
            khDTO.EMAIL_KH = txtEmail.Text;
            if (IsInsert == true)
            {
                //Insert
                khBLL.Insert(khDTO);
                MessageBox.Show("Thêm thông tin thành công!");
                HienThiKH();
                xoaTxt();
                khoaDK();
            }
            else
            {
                //Update
                khBLL.Update(khDTO);
                MessageBox.Show("Sửa thông tin thành công!");
                HienThiKH();
                xoaTxt();
                khoaDK();
            }
        }

        private void tsbPrint_Click(object sender, EventArgs e)
        {

        }

        private void Search(string keyword)
        {
            var results = listKH
                .Where(kh =>
                     kh.MAKH != null && kh.MAKH.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
                     kh.TENKH != null && kh.TENKH.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
                     kh.DIACHI != null && kh.DIACHI.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
                     kh.SDT_KH != null && kh.SDT_KH.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
                     kh.EMAIL_KH != null && kh.EMAIL_KH.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0).ToList();

            dgvKH.DataSource = results;
        }
        private void tsbSearch_Click(object sender, EventArgs e)
        {
            string keyword = tsbSearchtxt.Text.Trim();
            Search(keyword);
        }
        private void dgvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            khoaDK();
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvKH.Rows[e.RowIndex];
                    txtMaKH.Text = row.Cells["MAKH"].Value.ToString();
                    txtName.Text = row.Cells["TENKH"].Value.ToString();
                    txtAddress.Text = row.Cells["DIACHI"].Value.ToString();
                    txtPhone.Text = row.Cells["SDT_KH"].Value.ToString();
                    txtEmail.Text = row.Cells["EMAIL_KH"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void dgvKH_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        
    }
}
