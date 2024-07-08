using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_Main : Form
    {
        [DllImport("user32.dll")]
        public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        private string txtMaND;
        private int quyen;
        public frm_Main()
        {
            InitializeComponent();
        }
        public frm_Main(string maND, int quyen)
        {
            InitializeComponent();
            txtMaND = maND;
            // Truyền giá trị quyền vào và lưu lại cho sử dụng sau này
            this.quyen = quyen;

            // Gọi hàm kiểm tra quyền để ẩn hoặc hiển thị chức năng
            KiemTraQuyen();
        }
        private void KiemTraQuyen()
        {
            // Kiểm tra giá trị quyền và ẩn hoặc hiển thị các chức năng
            if (quyen == 1) 
            {
                pn2.Visible = false;
                pn5.Visible = false;
                pn6.Visible = false;
                pn7.Visible = false;
                lbUserName.Text = "User";
            }
            else
            {
                lbUserName.Text = "Admin";
            }
        }
        private Form FormChild;
        private void OpenChildForm(Form child)
        {
            if (FormChild != null)
            {
                FormChild.Close();
            }
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            pnChild.Controls.Clear();
            pnChild.Controls.Add(child);
            pnChild.Tag = child;
            child.BringToFront();
            child.Show();
        }

        private void ptbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void frm_Main_Load(object sender, EventArgs e)
        {
            frmVatLieu x = new frmVatLieu();
            OpenChildForm(x);
            lbMenu.Text = "       " + x.Text;
        }
        private void ptbAdmin_Click(object sender, EventArgs e)
        {
            if (FormChild != null)
            {
                FormChild.Close();
            }
            lbMenu.Text = "       Home";
        }

        private void btnVatLieu_Click(object sender, EventArgs e)
        {
            frmVatLieu x = new frmVatLieu();
            OpenChildForm(x);
            lbMenu.Text = "       " + x.Text;
        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            frmKho x = new frmKho();
            OpenChildForm(x);
            lbMenu.Text = "       " + x.Text;
        }

        private void btnDonHang_Click(object sender, EventArgs e)
        {
            frmDonHang x = new frmDonHang(txtMaND);
            OpenChildForm(x);
            lbMenu.Text = "       " + x.Text;
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            frmKhachHang x = new frmKhachHang();
            OpenChildForm(x);
            lbMenu.Text = "       " + x.Text;
        }

        private void btnNcc_Click(object sender, EventArgs e)
        {
            frmNCC x = new frmNCC();
            OpenChildForm(x);
            lbMenu.Text = "       " + x.Text;
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien x = new frmNhanVien();
            OpenChildForm(x);
            lbMenu.Text = "       " + x.Text;
        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            frmThongKe x = new frmThongKe();
            OpenChildForm(x);
            lbMenu.Text = "       " + x.Text;
        }


        private void ptbSetting_Click(object sender, EventArgs e)
        {

        }

        //setup thanh công cụ
        private void ptbMaxSize_RestoreDown_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void ptbMaxSize_RestoreDown_MouseEnter(object sender, EventArgs e)
        {
            ptbMaxSize_RestoreDown.BackColor = Color.Gainsboro;
        }

        private void ptbMaxSize_RestoreDown_MouseLeave(object sender, EventArgs e)
        {
            ptbMaxSize_RestoreDown.BackColor = Color.Transparent;
        }

        private void ptbClose_MouseEnter(object sender, EventArgs e)
        {
            ptbClose.BackColor = Color.Gainsboro;
        }

        private void ptbClose_MouseLeave(object sender, EventArgs e)
        {
            ptbClose.BackColor = Color.Transparent;
        }
        private void ptbMinisize_Click(object sender, EventArgs e)
        {
            IntPtr hWnd = this.Handle;

            // Sử dụng hàm ShowWindow để thu nhỏ cửa sổ
            ShowWindow(hWnd, 6);
        }
        private void ptbMinisize_MouseEnter(object sender, EventArgs e)
        {
            ptbMinisize.BackColor = Color.Gainsboro;
        }

        private void ptbMinisize_MouseLeave(object sender, EventArgs e)
        {
            ptbMinisize.BackColor = Color.Transparent;
        }


    }
}
