using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_ProductManagement.DTO
{
    public class TheoHangHoaBuy
    {
        public string MaPhieu { get; set; }
        public DateTime NgayLap { get; set; }
        public string TenNCC { get; set; }
        public string MaHang { get; set; }
        public string TenHang { get; set; }
        public string DonVi { get; set; }
        public string TenKho { get; set; }
        public int SoLuong { get; set; }
        public float DonGia { get; set; }
        public float ThanhTien { get; set; }
        public string MaNV { get; set; }
    }
}
