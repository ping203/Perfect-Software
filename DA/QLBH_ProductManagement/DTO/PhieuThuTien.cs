﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_ProductManagement.DTO
{
    public class PhieuThuTien
    {
        public string MaPhieu { get; set; }
        public string MaChungTu { get; set; }
        public DateTime NgayLap { get; set; }
        public string MaKH { get; set; }
        public string TenKH { get; set; }
        public float SoTien { get; set; }
        public string TenNV { get; set; }
        public string GhiChu { get; set; }
    }
}
