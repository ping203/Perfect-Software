using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_ProductManagement.DTO
{
    public class NhapXuatTon
    {
        public string MaHang { get; set; }
        public string TenHang { get; set; }
        public string MaKho { get; set; }
        public string TenKho { get; set; }
        
        public bool ConQuanLy { get; set; }
        public string DonVi { get; set; }
        public int slDauKy { get; set; }
        public float TienDauKy { get; set; }
        public int slNhapKho { get; set; }
        public float TienNhapKho { get; set; }
        public int slXuatKho { get; set; }
        public float TienXuatKho { get; set; }
        public int slCuoiKy { get; set; }
        public float TienCuoiKy { get; set; }
    }
}
