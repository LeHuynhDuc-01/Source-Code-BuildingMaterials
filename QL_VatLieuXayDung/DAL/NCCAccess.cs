using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class NCCAccess
    {
        SqlConnectionData db = new SqlConnectionData();
        public DataTable getData()
        {
            return db.GetDataTable("sp_SelectAll_NhaCungCap", null);
        }
        public DataTable getDataByID(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaNCC", ID)
            };
            return db.GetDataTable("sp_SelectByID_NhaCungCap", para);
        }
        public int Insert(NCCDTO obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaNCC", obj.MANCC),
                new SqlParameter("TenNCC", obj.TENNCC),
                new SqlParameter("DiaChiNCC", obj.DIACHI_NCC),
                new SqlParameter("SDTNCC", obj.SDT_NCC),
                new SqlParameter("EmailNCC", obj.EMAIL_NCC)
            };
            return db.GetNonQuery("sp_Insert_NhaCungCap", para);
        }
        public int Update(NCCDTO obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaNCC", obj.MANCC),
                new SqlParameter("TenNCC", obj.TENNCC),
                new SqlParameter("DiaChiNCC", obj.DIACHI_NCC),
                new SqlParameter("SDTNCC", obj.SDT_NCC),
                new SqlParameter("EmailNCC", obj.EMAIL_NCC)
            };
            return db.GetNonQuery("sp_Update_NhaCungCap", para);
        }
        public int Delete(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaNCC", ID)
            };
            return db.GetNonQuery("sp_Delete_NhaCungCap", null);
        }
    }
}
