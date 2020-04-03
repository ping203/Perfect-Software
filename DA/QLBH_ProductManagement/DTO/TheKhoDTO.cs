using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_ProductManagement.DTO
{
    public class TheKhoDTO
    {
        public string MaPhieuNhap { get; set; }
        public string MaPhieuXuat { get; set; }
        public string MaHang { get; set; }
        public string TenHang { get; set; }
        public DateTime NgayLap { get; set; }
        public int SoLuong { get; set; }
        public string Loai { get; set; }
        public int SoLuongNhap { get; set; }
        public int SoLuongXuat { get; set; }
        public string GhiChu { get; set; }
        public int SoLuongTon { get; set; } 
        public float TongTien { get; set; }
    }
}
