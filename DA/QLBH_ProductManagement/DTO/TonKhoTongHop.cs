using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_ProductManagement.DTO
{
    public class TonKhoTongHop
    {
        public string MaHang { get; set; }
        public string TenHang { get; set; }
        public string DonVi { get; set; }
        public int SoLuong { get; set; }
        public float DonGia { get; set; }
        public float ThanhTien { get; set; }
        public string NhomHang { get; set; }
        public string KhoHang { get; set; }
        public string MaKHo { get; set; }
        public bool ConQuanLy { get; set; }
    }
}
