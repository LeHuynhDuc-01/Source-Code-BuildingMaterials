using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class LoaiVatLieuAccess
    {
        SqlConnectionData db = new SqlConnectionData();

        public List<LoaiVatLieuDTO> GetData()
        {
            DataTable dataTable = db.GetDataTable("SELECT * FROM LOAIVATLIEU");
            List<LoaiVatLieuDTO> list_LoaiVatLieu = new List<LoaiVatLieuDTO>();

            foreach (DataRow row in dataTable.Rows)
            {
                LoaiVatLieuDTO loaiVatLieu = new LoaiVatLieuDTO
                {
                    MALOAI = row["MALOAI"].ToString(),
                    TENLOAI = row["TENLOAI"].ToString(),
                    MOTA = row["MOTA"].ToString()
                };

                list_LoaiVatLieu.Add(loaiVatLieu);
            }

            return list_LoaiVatLieu;
        }

        public LoaiVatLieuDTO GetDataByID(string ID)
        {
            DataTable dataTable = db.GetDataTable("SELECT * FROM LOAIVATLIEU WHERE MALOAI = '" + ID + "'");

            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];
                LoaiVatLieuDTO loaiVatLieu = new LoaiVatLieuDTO
                {
                    MALOAI = row["MALOAI"].ToString(),
                    TENLOAI = row["TENLOAI"].ToString(),
                    MOTA = row["MOTA"].ToString()
                };

                return loaiVatLieu;
            }

            return null;
        }

        public int Insert(LoaiVatLieuDTO obj)
        {
            string query = $"INSERT INTO LOAIVATLIEU (MALOAI, TENLOAI, MOTA) " +
                           $"VALUES ('{obj.MALOAI}', N'{obj.TENLOAI}', N'{obj.MOTA}')";

            return db.GetNonQuery(query);
        }

        public int Update(LoaiVatLieuDTO obj)
        {
            string query = $"UPDATE LOAIVATLIEU SET TENLOAI = N'{obj.TENLOAI}', MOTA = N'{obj.MOTA}' " +
                           $"WHERE MALOAI = '{obj.MALOAI}'";

            return db.GetNonQuery(query);
        }

        public int Delete(string ID)
        {
            return db.GetNonQuery($"DELETE FROM LOAIVATLIEU WHERE MALOAI = '{ID}'");
        }
    }
}
