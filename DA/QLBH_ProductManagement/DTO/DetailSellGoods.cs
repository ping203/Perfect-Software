using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_ProductManagement.DTO
{
    public class DetailSellGoods
    {
        public string MaPhieuXuat { get; set; }
        public string DonVi { get; set; }
        public string MaHang { get; set; }
        public int SoLuong { get; set; }
        public float DonGia { get; set; }
        public string TenHang { get; set; }
        public float ThanhTien { get; set; }
        public string GhiChu { get; set; }
        public float CK { get; set; }
        public float ThanhToan { get; set; }


        // Bên công nợ :

        public float CKCN { get; set; }
        public float VATCN { get; set; }
        public float TongThanhTien { get; set; }
    }
}
