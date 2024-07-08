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
    public partial class frmNCC : Form
    {
        private ContextMenuStrip contextMenu;
        public frmNCC()
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
            HienThiNCC();
        }
        private NCCDTO nccDTO = new NCCDTO();
        private NCCBLL nccBLL = new NCCBLL();
        private bool IsInsert = false;
        private List<NCCDTO> listNCC = new List<NCCDTO>();
        public void khoaDK()
        {
            txtMaNCC.Enabled = txtName.Enabled = txtAddress.Enabled = txtPhone.Enabled = txtEmail.Enabled = false;
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
            txtMaNCC.Text = txtName.Text = txtAddress.Text = txtPhone.Text = txtEmail.Text = string.Empty;
        }
        public void HienThiNCC()
        {
            listNCC = ConvertDataTableToList(nccBLL.GetData());
            dgvNCC.Columns["MANCC"].DataPropertyName = "MANCC";
            dgvNCC.Columns["TENNCC"].DataPropertyName = "TENNCC";
            dgvNCC.Columns["DIACHI_NCC"].DataPropertyName = "DIACHI_NCC";
            dgvNCC.Columns["SDT_NCC"].DataPropertyName = "SDT_NCC";
            dgvNCC.Columns["EMAIL_NCC"].DataPropertyName = "EMAIL_NCC";
            dgvNCC.DataSource = listNCC;
        }
        private List<NCCDTO> ConvertDataTableToList(DataTable dataTable)
        {
            List<NCCDTO> listNCC = new List<NCCDTO>();

            foreach (DataRow row in dataTable.Rows)
            {
                NCCDTO ncc = new NCCDTO
                {
                    MANCC = row["MANCC"].ToString(),
                    TENNCC = row["TENNCC"].ToString(),
                    DIACHI_NCC = row["DIACHI_NCC"].ToString(),
                    SDT_NCC = row["SDT_NCC"].ToString(),
                    EMAIL_NCC = row["EMAIL_NCC"].ToString()
                };

                listNCC.Add(ncc);
            }

            return listNCC;
        }
        private void dgvNCC_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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
        private void frmNCC_Load(object sender, EventArgs e)
        {
            khoaDK();
            HienThiNCC();
        }
        static string GenerateNewCode(List<NCCDTO> list)
        {
            // Nếu danh sách rỗng, trả về mã mặc định
            if (list.Count == 0)
            {
                return "NCC001";
            }

            // Lấy phần tử cuối cùng trong danh sách
            string lastCode = list.Last().MANCC;

            // Tách "HD" và số từ mã cuối cùng
            string prefix = lastCode.Substring(0, 3);
            string numberPart = lastCode.Substring(3);

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
            txtMaNCC.Text = GenerateNewCode(listNCC);
        }

        private void tsbSua_Click(object sender, EventArgs e)
        {
            moKhoaDK();
            txtMaNCC.Enabled = false;
            IsInsert = false;
        }

        private void tsbXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn xóa thông tin này không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    nccBLL.Delete(txtMaNCC.Text);
                    MessageBox.Show("Đã xóa thông tin thành công!");
                    xoaTxt();
                    khoaDK();
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        private void tsbLuu_Click(object sender, EventArgs e)
        {
            nccDTO.MANCC = txtMaNCC.Text;
            nccDTO.TENNCC = txtName.Text;
            nccDTO.DIACHI_NCC = txtAddress.Text;
            nccDTO.SDT_NCC = txtPhone.Text;
            nccDTO.EMAIL_NCC = txtEmail.Text;
            if(IsInsert == true)
            {
                //Insert
                nccBLL.Insert(nccDTO);
                MessageBox.Show("Thêm thông tin thành công!");
                HienThiNCC();
                xoaTxt();
                khoaDK();
            }
            else
            {
                //Update
                nccBLL.Update(nccDTO);
                MessageBox.Show("Sửa thông tin thành công!");
                HienThiNCC();
                xoaTxt();
                khoaDK();
            }
        }

        private void tsbPrint_Click(object sender, EventArgs e)
        {

        }

        private void Search(string keyword)
        {
            var results = listNCC.Where(NCC =>
            NCC.MANCC != null && NCC.MANCC.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
            NCC.TENNCC != null && NCC.TENNCC.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
            NCC.DIACHI_NCC != null && NCC.DIACHI_NCC.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
            NCC.SDT_NCC != null && NCC.SDT_NCC.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
            NCC.EMAIL_NCC != null && NCC.EMAIL_NCC.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0).ToList();

            dgvNCC.DataSource = results;
        }
        private void tsbSearch_Click(object sender, EventArgs e)
        {
            string keyword = tsbSearchtxt.Text.Trim();
            Search(keyword);
        }

        private void dgvNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            khoaDK();
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvNCC.Rows[e.RowIndex];
                    txtMaNCC.Text = row.Cells["MANCC"].Value.ToString();
                    txtName.Text = row.Cells["TENNCC"].Value.ToString();
                    txtAddress.Text = row.Cells["DIACHI_NCC"].Value.ToString();
                    txtPhone.Text = row.Cells["SDT_NCC"].Value.ToString();
                    txtEmail.Text = row.Cells["EMAIL_NCC"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
