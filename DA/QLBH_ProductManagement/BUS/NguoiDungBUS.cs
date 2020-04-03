using QLBH_ProductManagement.DAO;
using QLBH_ProductManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_ProductManagement.BUS
{
    public class NguoiDungBUS
    {
        NguoiDungDAO nguoiDung = new NguoiDungDAO();
        public DataTable LayDuLieuNguoiDung(string sql)
        {
            return nguoiDung.LayDuLieuNguoiDung(sql);
        }
        public int DaTonTai(string TenDangNhap)
        {
            return nguoiDung.DaTonTai(TenDangNhap);
        }

        public int ThemNguoiDung(NguoiDung nd)
        {
            return nguoiDung.ThemNguoiDung(nd);
        }

        public int CapNhatNguoiDung(NguoiDung nd)
        {
            if (string.IsNullOrEmpty(nd.MaVaiTro))
                return 0;
            return nguoiDung.CapNhatNguoiDung(nd);
        }

        public int XoaNguoiDung(string tendangnhap)
        {
            return nguoiDung.XoaNguoiDung(tendangnhap);
        }

        public int TonTaiDangNhap(string tendangnhap, string pass)
        {
            return nguoiDung.TonTaiDangNhap(tendangnhap, pass);
        }

        /// <summary>
        /// lấy mã vai trò từ tên đăng nhập người dùng
        /// </summary>
        /// <param name="tendangnhap"></param>
        /// <returns></returns>
        public string LayMaVaiTro(string tendangnhap)
        {
            return nguoiDung.LayMaVaiTro(tendangnhap);
        }

        public string GetPassword(string username)
        {
            return nguoiDung.GetPassword(username);
        }

        public int CapNhatMatKhau(string username, string newPass)
        {
            return nguoiDung.CapNhatMatKhau(username, newPass);
        }

    }
}
