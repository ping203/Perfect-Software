using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_ProductManagement.DTO
{
    public class PhieuChiTien
    {
        public string MaPhieu { get; set; }
        public string MaChungTu { get; set; }
        public DateTime NgayLap { get; set; }
        public string MaNCC { get; set; }
        public string TenNCC { get; set; }
        public float SoTien { get; set; }
        public string TenNV { get; set; }
        public string GhiChu { get; set; }
    }
}
