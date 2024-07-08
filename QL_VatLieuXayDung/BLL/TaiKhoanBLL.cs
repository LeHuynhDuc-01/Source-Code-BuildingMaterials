using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class TaiKhoanBLL
    {
        TaiKhoanAccess tk = new TaiKhoanAccess();
        public DataTable GetData()
        {
            return tk.getData();
        }
        public DataTable GetDataByID(string id)
        {
            return tk.getDataByID(id);
        }
        public int Insert(TaiKhoanDTO obj)
        {
            return tk.Insert(obj);
        }

        public int Update(TaiKhoanDTO obj)
        {
            return tk.Update(obj);
        }
        public int Delete(string ID)
        {
            return tk.Delete(ID);
        }
        public string checklogin(TaiKhoanDTO taikhoan)
        {
            if (taikhoan.USERNAME == "")
            {
                return "requeid_taikhoan";
            }
            if (taikhoan.PASSWORD == "")
            {
                return "requeid_password";
            }
            string info = tk.checklogin(taikhoan);
            return info;
        }
        public int Checkquyen(TaiKhoanDTO taikhoan)
        {
            return tk.Checkquyen(taikhoan);
        }
    }
}
