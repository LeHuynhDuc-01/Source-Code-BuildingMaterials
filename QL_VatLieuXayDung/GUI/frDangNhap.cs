using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class frDangNhap : Form
    {
        TaiKhoanDTO taikhoan = new TaiKhoanDTO();
        TaiKhoanBLL tkbll = new TaiKhoanBLL();
        public frDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            taikhoan.USERNAME = txtusername.Text;
            taikhoan.PASSWORD = txtpassword.Text;
            //taikhoan.USERNAME = "caotri55";
            //taikhoan.PASSWORD = "caotri551";
            string getuser = tkbll.checklogin(taikhoan);
            switch (getuser)
            {
                case "requeid_taikhoan":
                    MessageBox.Show("Không được để username trống");
                    return;

                case "requeid_password":
                    MessageBox.Show("Không được để password trống");
                    return;
                case "Tài khoản hoặc mật khẩu không chính xác":
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");
                    return;
            }

            int quyen = tkbll.Checkquyen(taikhoan);
            DataRow nguoiDung = tkbll.GetDataByID(getuser).Rows[0];
            string maND = nguoiDung["MANV"].ToString();

            if (quyen == 0)
            {
                MessageBox.Show("Dăng nhập thành công dưới quyen admin");
                frm_Main fm = new frm_Main(maND, quyen);
                fm.BringToFront();
                fm.Show();
                this.Hide();
            }
            else if (quyen == 1)
            {
                MessageBox.Show("Dăng nhập  thành công dưới quyền nhân viên");
                frm_Main fc = new frm_Main(maND, quyen);
                fc.BringToFront();
                fc.Show();
                this.Hide();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtpassword.PasswordChar = chkShowPassword.Checked ? '\0' : '*';
        }
    }
}
