using System;

namespace QLBH_ProductManagement.DTO
{
    public class InforTransWarehouseDTO
    {
        public string MaPhieuChuyen { get; set; }
        public string MaKhoXuat { get; set; }
        public string MaKhoNhan { get; set; }
        public DateTime NgayLap { get; set; }
        public string GhiChu { get; set; }
        public string MaNVXuat { get; set; }
        public string MaNVNhan { get; set; }
        public string SoPhieuChuyenTay { get; set; }
        public float TongTienChuyen { get; set; }
    }
}
