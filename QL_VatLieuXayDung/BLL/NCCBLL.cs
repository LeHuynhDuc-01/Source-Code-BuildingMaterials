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
    public class NCCBLL
    {
        NCCAccess ncc = new NCCAccess();
        public DataTable GetData()
        {
            return ncc.getData();
        }
        public DataTable GetDataByID(string id)
        {
            return ncc.getDataByID(id);
        }
        public int Insert(NCCDTO obj)
        {
             return ncc.Insert(obj);
        }
        public int Update(NCCDTO obj)
        {
            return ncc.Update(obj);
        }
        public int Delete(string ID)
        {
            return ncc.Delete(ID);
        }
    }
}
