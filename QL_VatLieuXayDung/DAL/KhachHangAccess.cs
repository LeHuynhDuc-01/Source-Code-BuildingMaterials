using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KhachHangAccess
    {
        SqlConnectionData db = new SqlConnectionData();
        public DataTable getData()
        {
            return db.GetDataTable("sp_SelectAll_KhachHang", null);
        }
        public DataTable getDataByID(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaKH", ID)
            };
            return db.GetDataTable("sp_SelectByID_KhachHang", para);
        }
        public int Insert(KhachHangDTO obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaKH", obj.MAKH),
                new SqlParameter("TenKH", obj.TENKH),
                new SqlParameter("DiaChiKH", obj.DIACHI),
                new SqlParameter("SDT_KH", obj.SDT_KH),
                new SqlParameter("Email_KH", obj.EMAIL_KH)
            };
            return db.GetNonQuery("sp_Insert_KhachHang", para);
        }
        public int Update(KhachHangDTO obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaKH", obj.MAKH),
                new SqlParameter("TenKH", obj.TENKH),
                new SqlParameter("DiaChiKH", obj.DIACHI),
                new SqlParameter("SDT_KH", obj.SDT_KH),
                new SqlParameter("Email_KH", obj.EMAIL_KH)
            };
            return db.GetNonQuery("sp_Update_KhachHang", para);
        }
        public int Delete(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaKH", ID)
            };
            return db.GetNonQuery("sp_Delete_KhachHang", null);
        }
    }
}

