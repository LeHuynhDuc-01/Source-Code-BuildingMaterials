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
    public class PhieuThanhToanBLL
    {
        PhieuThanhToanAccess pnh = new PhieuThanhToanAccess();
        public DataTable GetData()
        {
            return pnh.GetData();
        }
        public DataTable GetDataByID(string id)
        {
            return pnh.GetDataByID(id);
        }
        public int Insert(PhieuThanhToanDTO obj)
        {
            return pnh.Insert(obj);
        }
        public int Update(PhieuThanhToanDTO obj)
        {
            return pnh.Update(obj);
        }
        public int Delete(string ID)
        {
            return pnh.Delete(ID);
        }
    }
    public class ChiTietPhieuThanhToanBLL
    {
        ChiTietPhieuThanhToanAccess pnhct = new ChiTietPhieuThanhToanAccess();
        public DataTable GetData()
        {
            return pnhct.GetData();
        }
        public DataTable GetDataByID(string maPN, string maLV)
        {
            return pnhct.GetDataByID(maPN, maLV);
        }
        public int Insert(ChiTietPhieuThanhToanDTO obj)
        {
            return pnhct.Insert(obj);
        }
        public int Update(ChiTietPhieuThanhToanDTO obj)
        {
            return pnhct.Update(obj);
        }
        public int Delete(string maPN, string maLV)
        {
            return pnhct.Delete(maPN, maLV);
        }
        public int DeleteALL(string maPN)
        {
            return pnhct.DeleteAll(maPN);
        }
        public int updateTongTien(string maPN)
        {
            return pnhct.updateTongTienPN(maPN);
        }
    }
}
