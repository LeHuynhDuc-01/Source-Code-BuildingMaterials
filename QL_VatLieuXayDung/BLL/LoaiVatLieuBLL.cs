using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class LoaiVatLieuBLL
    {
        LoaiVatLieuAccess vl = new LoaiVatLieuAccess();
        public List<LoaiVatLieuDTO> GetData()
        {
            return vl.GetData();
        }
        public LoaiVatLieuDTO GetDataByID(string id)
        {
            return vl.GetDataByID(id);
        }
        public int Insert(LoaiVatLieuDTO obj)
        {
            return vl.Insert(obj);
        }
        public int Update(LoaiVatLieuDTO obj)
        {
            return vl.Update(obj);
        }
        public int Delete(string ID)
        {
            return vl.Delete(ID);
        }
    }
}
