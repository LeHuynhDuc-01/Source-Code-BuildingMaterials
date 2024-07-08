using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TaiKhoanAccess
    {
        SqlConnectionData db = new SqlConnectionData();
        public DataTable getData()
        {
            return db.GetDataTable("sp_SelectAll_TaiKhoan", null);
        }
        public DataTable getDataByID(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("USERNAME", ID)
            };
            return db.GetDataTable("sp_SelectByID_TaiKhoan", para);
        }

        public int Insert(TaiKhoanDTO obj)
        {
            SqlParameter[] para =
            {
            new SqlParameter("USERNAME", obj.USERNAME),
            new SqlParameter("PASSWORD", obj.PASSWORD),
            new SqlParameter("LOAI", obj.LOAI),
            new SqlParameter("MANV", obj.MANV)
            };
            return db.GetNonQuery("sp_Insert_TaiKhoan", para);
        }

        public int Update(TaiKhoanDTO obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("USERNAME", obj.USERNAME),
                new SqlParameter("PASSWORD", obj.PASSWORD),
                new SqlParameter("LOAI", obj.LOAI),
                new SqlParameter("MANV", obj.MANV)
            };
            return db.GetNonQuery("sp_Update_TaiKhoan", para);
        }

        // Sửa đổi phương thức Delete cho lớp TaiKhoanDTO
        public int Delete(string USERNAME)
        {
            SqlParameter[] para =
            {
            new SqlParameter("USERNAME", USERNAME)
            };
            return db.GetNonQuery("sp_Delete_TaiKhoan", para);
        }


        public string checklogin(TaiKhoanDTO taikhoan)
        {
            string info = db.CheckLogin(taikhoan);
            return info;
        }
        public int Checkquyen(TaiKhoanDTO taikhoan)
        {
            int info = db.CheckQuyen(taikhoan);
            return info;
        }
    }
}
