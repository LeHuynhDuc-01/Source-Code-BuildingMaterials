using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuThanhToanDTO
    {
        public string MADH { get; set; }
        public string MAKH { get; set; }
        public string MANV { get; set; }
        public DateTime NGAYDAT { get; set; }
        public string TRANGTHAI { get; set; }
        public decimal TONGHOADON { get; set; }
    }
    public class ChiTietPhieuThanhToanDTO
    {
        public string MADH { get; set; }
        public string MAVL { get; set; }
        public decimal GIA { get; set; }
        public int SOLUONGBAN { get; set; }
    }
    
}
