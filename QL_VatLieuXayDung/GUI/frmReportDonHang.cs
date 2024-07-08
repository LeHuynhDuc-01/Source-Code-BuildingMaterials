using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.ReportProcessing.OnDemandReportObjectModel;

namespace GUI
{
    public partial class frmReportDonHang : Form
    {
        public string txtMaDH_CT;
        public frmReportDonHang()
        {
            InitializeComponent();
        }
        public frmReportDonHang(string maDH)
        {
            InitializeComponent();
            txtMaDH_CT = maDH;
        }
        private ChiTietPhieuThanhToanDTO ChiTietPhieuTTDTO = new ChiTietPhieuThanhToanDTO();
        private ChiTietPhieuThanhToanBLL ChiTietPhieuTTBLL = new ChiTietPhieuThanhToanBLL();
        private List<ChiTietPhieuThanhToanDTO> lstCTPN;
        private decimal tongTien = 0;

       

        private VatLieuBLL vatLieuBLL = new VatLieuBLL();
        public List<DonHangReport> lstRP()
        {
            List<DonHangReport> lst = new List<DonHangReport>();
            lstCTPN = ConvertDataTableToList<ChiTietPhieuThanhToanDTO>(ChiTietPhieuTTBLL.GetData());
            var stt = 1;
            foreach (var item in lstCTPN.Where(s=>s.MADH == txtMaDH_CT).ToList())
            {
                DonHangReport dhreportDTO = new DonHangReport();
                dhreportDTO.STT = stt;
                DataRow vatLieu = vatLieuBLL.GetDataByID(item.MAVL).Rows[0];
                dhreportDTO.TENVL = vatLieu["TENVL"].ToString();
                dhreportDTO.SOLUONGBAN = item.SOLUONGBAN;
                dhreportDTO.GIA = item.GIA;
                dhreportDTO.TONGTIEN = item.GIA * item.SOLUONGBAN;

                lst.Add(dhreportDTO);
                stt++;
            }
            return lst;
        }
        private List<T> ConvertDataTableToList<T>(DataTable dataTable) where T : new()
        {
            List<T> list = new List<T>();

            foreach (DataRow row in dataTable.Rows)
            {
                T item = new T();

                foreach (DataColumn column in dataTable.Columns)
                {
                    PropertyInfo prop = typeof(T).GetProperty(column.ColumnName);
                    if (prop != null && row[column] != DBNull.Value)
                    {
                        prop.SetValue(item, Convert.ChangeType(row[column], prop.PropertyType), null);
                    }
                }

                list.Add(item);
            }

            return list;
        }
        private void frmReportDonHang_Load(object sender, EventArgs e)
        {
            tongTien = lstRP().Sum(s => s.TONGTIEN);
            rpvHienThiChiTietDon.LocalReport.ReportPath = "rptDongHang.rdlc";
            var Parameter = new List<ReportParameter>
            {
                new ReportParameter("TongThanhToan", tongTien.ToString())
            };

            // Truyền tham số vào báo cáo
            rpvHienThiChiTietDon.LocalReport.SetParameters(Parameter);
            var source = new ReportDataSource("DonHangReport", lstRP());
            rpvHienThiChiTietDon.LocalReport.DataSources.Clear();
            rpvHienThiChiTietDon.LocalReport.DataSources.Add(source);
            

            this.rpvHienThiChiTietDon.RefreshReport();
        }

    }
}
