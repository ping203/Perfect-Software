using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_ProductManagement.DTO
{
    public class InforDetailBuy
    {
        public string MaPhieu { get; set; }
        public string MaNCC { get; set; }
        public string TenNCC { get; set; }
        public DateTime NgayLap { get; set; }
        public string SoHoaDonVAT { get; set; }
        public string DiaChi { get; set; }
        public string MaNVLap { get; set; }
        public string SoPhieuNhapTay { get; set; }
        public string MaKhoNhap { get; set; }
        public int Ma_DieuKhoan { get; set; }
        public string Ma_PhuongThuc { get; set; }
        public DateTime HanThanhToan { get; set; }
        public float TongTienMua { get; set; }
        public float CK         {get; set;}
	    public float VAT    {get; set;}
	    public float TongTienTra { get; set; }
        public string ghiChu { get; set; }
        public string TenKho { get; set; }
    }
}
