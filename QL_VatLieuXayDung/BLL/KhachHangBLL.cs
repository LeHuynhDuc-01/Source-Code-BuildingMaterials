using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using DTO;


namespace BLL
{
    public class KhachHangBLL
    {
        KhachHangAccess kh = new KhachHangAccess();
        public DataTable GetData()
        {
            return kh.getData();
        }
        public DataTable GetDataByID(string id)
        {
            return kh.getDataByID(id);
        }
        public int Insert(KhachHangDTO obj)
        {
            return kh.Insert(obj);
        }
        public int Update(KhachHangDTO obj)
        {
            return kh.Update(obj);
        }
        public int Delete(string ID)
        {
            return kh.Delete(ID);
        }
    }
}
