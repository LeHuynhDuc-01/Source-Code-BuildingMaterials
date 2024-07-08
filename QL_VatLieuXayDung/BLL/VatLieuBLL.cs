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
    public class VatLieuBLL
    {
        VatLieuAccess vl = new VatLieuAccess();
        public DataTable GetData()
        {
            return vl.getData();
        }
        public DataTable GetDataByID(string id)
        {
            return vl.getDataByID(id);
        }
        public int Insert(VatLieuDTO obj)
        {
            return vl.Insert(obj);
        }
        public int Update(VatLieuDTO obj)
        {
            return vl.Update(obj);
        }
        public int Delete(string ID)
        {
            return vl.Delete(ID);
        }
    }
}
