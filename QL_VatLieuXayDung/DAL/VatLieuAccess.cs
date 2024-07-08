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
    public class VatLieuAccess
    {
        SqlConnectionData db = new SqlConnectionData();

        public DataTable getData()
        {
            // Thay đổi tên stored procedure thành phù hợp với table VATLIEU
            return db.GetDataTable("sp_SelectAll_VatLieu", null);
        }

        public DataTable getDataByID(string ID)
        {
            // Sửa lại tên tham số thành MAVL
            SqlParameter[] para =
            {
                new SqlParameter("MAVL", ID)
            };
            return db.GetDataTable("sp_SelectByID_VatLieu", para);
        }

        public int Insert(VatLieuDTO obj)
        {
            // Thêm các trường khác vào câu lệnh SQL
            SqlParameter[] para =
            {
                new SqlParameter("MAVL", obj.MAVL),
                new SqlParameter("MALOAI", obj.MALOAI),
                new SqlParameter("TENVL", obj.TENVL),
                new SqlParameter("HINHANH", obj.HINHANH),
                new SqlParameter("MOTA", obj.MOTA),
                new SqlParameter("DONVITINH", obj.DONVITINH),
                new SqlParameter("GIA", obj.GIA),
                new SqlParameter("NGAYSX", obj.NGAYSX),
                new SqlParameter("HANSD", obj.HANSD),
                new SqlParameter("XUATXU", obj.XUATXU),
                new SqlParameter("SOLUONGCON", obj.SOLUONGCON)
            };
            return db.GetNonQuery("sp_Insert_VatLieu", para);
        }

        public int Update(VatLieuDTO obj)
        {
            // Thêm các trường khác vào câu lệnh SQL
            SqlParameter[] para =
            {
                new SqlParameter("MAVL", obj.MAVL),
                new SqlParameter("MALOAI", obj.MALOAI),
                new SqlParameter("TENVL", obj.TENVL),
                new SqlParameter("HINHANH", obj.HINHANH),
                new SqlParameter("MOTA", obj.MOTA),
                new SqlParameter("DONVITINH", obj.DONVITINH),
                new SqlParameter("GIA", obj.GIA),
                new SqlParameter("NGAYSX", obj.NGAYSX),
                new SqlParameter("HANSD", obj.HANSD),
                new SqlParameter("XUATXU", obj.XUATXU),
                new SqlParameter("SOLUONGCON", obj.SOLUONGCON)
            };
            return db.GetNonQuery("sp_Update_VatLieu", para);
        }

        // Sửa đổi phương thức Delete cho lớp TaiKhoanAccess
        public int Delete(string MAVL)
        {
            // Sửa lại tên tham số thành MAVL
            SqlParameter[] para =
            {
                new SqlParameter("MAVL", MAVL)
            };
            return db.GetNonQuery("sp_Delete_VatLieu", para);
        }
    }
}
