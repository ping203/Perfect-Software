﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_ProductManagement.DTO
{
    public class DetailTransWarehouseDTO
    {
        public int ID { get; set; }
        public string MaPhieuChuyen { get; set; }
        public string MaHang { get; set; }
        public string TenHang { get; set; }
        public string DonVi { get; set; }
        public int SoLuong { get; set; }
        public float DonGia { get; set; }
        public float ThanhTien { get; set; }
    }
}
