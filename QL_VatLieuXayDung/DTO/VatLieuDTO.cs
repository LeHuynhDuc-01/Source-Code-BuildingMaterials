using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class VatLieuDTO
    {
        public string MAVL { get; set; }
        public string MALOAI { get; set; }
        public string TENVL { get; set; }
        public byte[] HINHANH { get; set; }
        public string MOTA { get; set; }
        public string DONVITINH { get; set; }
        public decimal GIA { get; set; }
        public DateTime NGAYSX { get; set; }
        public DateTime HANSD { get; set; }
        public string XUATXU { get; set; }
        public int SOLUONGCON { get; set; }
    }
}
