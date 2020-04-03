using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_ProductManagement.DTO
{
    public class EmployeesDTO
    {
        private string MaNV;
        private string TenNV;
        private string DiaChi;
        private string DienThoai;
        private string DiDong;
        private string Email;
        private string BoPhan;
        private string NguoiQL;
        private bool Active;
        public float TongSoMuaHang { get; set; }
        public float TongSoBanHang { get; set; }
        public string iMaNV { get => MaNV; set => MaNV = value; }
        public string iTenNV { get => TenNV; set => TenNV = value; }
        public string iDiaChi { get => DiaChi; set => DiaChi = value; }
        public string iDienThoai { get => DienThoai; set => DienThoai = value; }
        public string iDiDong { get => DiDong; set => DiDong = value; }
        public string iEmail { get => Email; set => Email = value; }
        public string iBoPhan { get => BoPhan; set => BoPhan = value; }
        public string iNguoiQL { get => NguoiQL; set => NguoiQL = value; }
        public bool iActive { get => Active; set => Active = value; }
    }
}
