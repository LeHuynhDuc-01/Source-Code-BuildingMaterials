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
    public class PhieuNhapHangAccess
    {
        SqlConnectionData db = new SqlConnectionData();

        public DataTable GetData()
        {
            return db.GetDataTable("sp_SelectAll_PhieuNhapHang", null);
        }

        public DataTable GetDataByID(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MAPN", ID)
            };
            return db.GetDataTable("sp_SelectByID_PhieuNhapHang", para);
        }

        public int Insert(PhieuNhapDTO obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MAPN", obj.MAPN), // Thêm các trường tương ứng với PhieuNhapHangDTO
                new SqlParameter("MANCC", obj.MANCC),
                new SqlParameter("MANV", obj.MANV),
                new SqlParameter("NGAYNHAP", obj.NGAYNHAP),
                new SqlParameter("TONGNHAP", obj.TONGNHAP)
            };
            return db.GetNonQuery("sp_Insert_PhieuNhapHang", para);
        }

        public int Update(PhieuNhapDTO obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MAPN", obj.MAPN),
                new SqlParameter("MANCC", obj.MANCC),
                new SqlParameter("MANV", obj.MANV),
                new SqlParameter("TONGNHAP", obj.TONGNHAP),
                new SqlParameter("NGAYNHAP", obj.NGAYNHAP)
            };
            return db.GetNonQuery("sp_Update_PhieuNhapHang", para);
        }

        public int Delete(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MAPN", ID)
            };
            return db.GetNonQuery("sp_Delete_PhieuNhapHang", para);
        }
    }
    public class ChiTietPhieuNhapHangAccess
    {
        SqlConnectionData db = new SqlConnectionData();

        public DataTable GetData()
        {
            return db.GetDataTable("sp_SelectAll_ChiTietPhieuNhapHang", null);
        }

        public DataTable GetDataByID(string maPN, string maVL)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MAPN", maPN),
                new SqlParameter("MAVL", maVL)
            };
            return db.GetDataTable("sp_SelectByID_ChiTietPhieuNhapHang", para);
        }

        public int Insert(ChiTietPhieuNhapDTO obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MAPN", obj.MAPN), // Sửa dòng này để phản ánh MaPN thay vì MaNCC
                new SqlParameter("MAVL", obj.MAVL),
                new SqlParameter("GIANHAP", obj.GIANHAP),
                new SqlParameter("SOLUONGNHAP", obj.SOLUONGNHAP)
            };
            return db.GetNonQuery("sp_Insert_ChiTietPhieuNhapHang", para);
        }

        public int Update(ChiTietPhieuNhapDTO obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MAPN", obj.MAPN), // Sửa dòng này để phản ánh MaPN thay vì MaNCC
                new SqlParameter("MAVL", obj.MAVL),
                new SqlParameter("GIANHAP", obj.GIANHAP),
                new SqlParameter("SOLUONGNHAP", obj.SOLUONGNHAP)
            };
            return db.GetNonQuery("sp_Update_ChiTietPhieuNhapHang", para);
        }

        public int Delete(string maPN, string maVL)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MAPN", maPN),
                new SqlParameter("MAVL", maVL)
            };
            return db.GetNonQuery("sp_Delete_ChiTietPhieuNhapHang", para);
        }
        public int DeleteALL(string maPN)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MAPN", maPN)
            };
            return db.GetNonQuery("sp_Delete_AllChiTietPhieuNhap", para);
        }
        public int updateTongTienPN(string maPN)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MAPN", maPN)
            };
            return db.GetNonQuery("sp_Update_TongTien_PhieuNhap", para);
        }
    }
}
