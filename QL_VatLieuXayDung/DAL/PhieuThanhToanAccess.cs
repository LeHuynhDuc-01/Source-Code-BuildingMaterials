using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class PhieuThanhToanAccess
    {
        SqlConnectionData db = new SqlConnectionData();

        public DataTable GetData()
        {
            return db.GetDataTable("sp_SelectAll_PhieuThanhToan", null);
        }

        public DataTable GetDataByID(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MADH", ID)
            };
            return db.GetDataTable("sp_SelectByID_PhieuThanhToan", para);
        }

        public int Insert(PhieuThanhToanDTO obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MADH", obj.MADH), // Thêm các trường tương ứng với PhieuThanhToanDTO
                new SqlParameter("MAKH", obj.MAKH),
                new SqlParameter("MANV", obj.MANV),
                new SqlParameter("NGAYDAT", obj.NGAYDAT),
                new SqlParameter("TRANGTHAI", obj.TRANGTHAI),
                new SqlParameter("TONGHOADON", obj.TONGHOADON)
            };
            return db.GetNonQuery("sp_Insert_PhieuThanhToan", para);
        }

        public int Update(PhieuThanhToanDTO obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MADH", obj.MADH), // Thêm các trường tương ứng với PhieuThanhToanDTO
                new SqlParameter("MAKH", obj.MAKH),
                new SqlParameter("MANV", obj.MANV),
                new SqlParameter("NGAYDAT", obj.NGAYDAT),
                new SqlParameter("TRANGTHAI", obj.TRANGTHAI),
                new SqlParameter("TONGHOADON", obj.TONGHOADON)
            };
            return db.GetNonQuery("sp_Update_PhieuThanhToan", para);
        }

        public int Delete(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MADH", ID)
            };
            return db.GetNonQuery("sp_Delete_PhieuThanhToan", para);
        }
    }
    public class ChiTietPhieuThanhToanAccess
    {
        SqlConnectionData db = new SqlConnectionData();

        public DataTable GetData()
        {
            return db.GetDataTable("sp_SelectAll_ChiTietPhieuThanhToan", null);
        }

        public DataTable GetDataByID(string maDH, string maVL)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MADH", maDH),
                new SqlParameter("MAVL", maVL)
            };
            return db.GetDataTable("sp_SelectByID_ChiTietPhieuThanhToan", para);
        }

        public int Insert(ChiTietPhieuThanhToanDTO obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MADH", obj.MADH), // Sửa dòng này để phản ánh maDH thay vì MaNCC
                new SqlParameter("MAVL", obj.MAVL),
                new SqlParameter("GIA", obj.GIA),
                new SqlParameter("SOLUONGBAN", obj.SOLUONGBAN)
            };
            return db.GetNonQuery("sp_Insert_ChiTietPhieuThanhToan", para);
        }

        public int Update(ChiTietPhieuThanhToanDTO obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MADH", obj.MADH), // Sửa dòng này để phản ánh maDH thay vì MaNCC
                new SqlParameter("MAVL", obj.MAVL),
                new SqlParameter("GIA", obj.GIA),
                new SqlParameter("SOLUONGBAN", obj.SOLUONGBAN)
            };
            return db.GetNonQuery("sp_Update_ChiTietPhieuThanhToan", para);
        }

        public int Delete(string maDH, string maVL)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MADH", maDH),
                new SqlParameter("MAVL", maVL)
            };
            return db.GetNonQuery("sp_Delete_ChiTietPhieuThanhToan", para);
        }
        public int DeleteAll(string maDH)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MADH", maDH)
            };
            return db.GetNonQuery("sp_Delete_AllChiTietPhieuThanhToan", para);
        }
        public int updateTongTienPN(string maDH)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MADH", maDH)
            };
            return db.GetNonQuery("sp_Update_TongTien_PhieuThanhToan", para);
        }
    }
}
