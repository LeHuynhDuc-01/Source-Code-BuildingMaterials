using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL
{
    public class NhanVienBLL
    {
        NhanVienAccess nv = new NhanVienAccess();
        public DataTable GetData()
        {
            return nv.getData();
        }
        public DataTable GetDataByID(string id)
        {
            return nv.getDataByID(id);
        }
        public int Insert(NhanVienDTO obj)
        {
            return nv.Insert(obj);
        }
        public int Update(NhanVienDTO obj)
        {
            return nv.Update(obj);
        }
        public int Delete(string ID)
        {
            return nv.Delete(ID);
        }
    }
}
