using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuNhapDTO
    {
        public string MAPN { get; set; }
        public string MANCC { get; set; }
        public string MANV { get; set; }
        public decimal TONGNHAP { get; set; }
        public DateTime NGAYNHAP { get; set; }
    }
    public class ChiTietPhieuNhapDTO
    {
        public string MAPN { get; set; }
        public string MAVL { get; set; }
        public decimal GIANHAP { get; set; }
        public int SOLUONGNHAP { get; set; }
    }
}
