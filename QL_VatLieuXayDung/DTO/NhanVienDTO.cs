using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVienDTO
    {
        public string MANV { get; set; }
        public string TENNV { get; set; }
        public byte[] HINHANH { get; set; }
        public string GIOITINH { get; set; }
        public DateTime NGAYSINH { get; set; }
        public string DIACHI_NV { get; set; }
        public string SDT_NV { get; set; }
        public string EMAIL_NV { get; set; }
    }
}
