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
    public class NhanVienAccess
    {
        SqlConnectionData db = new SqlConnectionData();
        public DataTable getData()
        {
            return db.GetDataTable("sp_SelectAll_NhanVien", null);
        }
        public DataTable getDataByID(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MANV", ID)
            };
            return db.GetDataTable("sp_SelectByID_NhanVien", para);
        }
        public int Insert(NhanVienDTO obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MANV", obj.MANV),
                new SqlParameter("TENNV", obj.TENNV),
                new SqlParameter("HINHANH", obj.HINHANH),
                new SqlParameter("GIOITINH", obj.GIOITINH),
                new SqlParameter("NGAYSINH", obj.NGAYSINH),
                new SqlParameter("DIACHI_NV", obj.DIACHI_NV),
                new SqlParameter("SDT_NV", obj.SDT_NV),
                new SqlParameter("EMAIL_NV", obj.EMAIL_NV)
            };
            return db.GetNonQuery("sp_Insert_NhanVien", para);
        }
        public int Update(NhanVienDTO obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MANV", obj.MANV),
                new SqlParameter("TENNV", obj.TENNV),
                new SqlParameter("HINHANH", obj.HINHANH),
                new SqlParameter("GIOITINH", obj.GIOITINH),
                new SqlParameter("NGAYSINH", obj.NGAYSINH),
                new SqlParameter("DIACHI_NV", obj.DIACHI_NV),
                new SqlParameter("SDT_NV", obj.SDT_NV),
                new SqlParameter("EMAIL_NV", obj.EMAIL_NV)
            };
            return db.GetNonQuery("sp_Update_NhanVien", para);
        }
        public int Delete(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MANV", ID)
            };
            return db.GetNonQuery("sp_Delete_NhanVien", para);
        }
    }
}
