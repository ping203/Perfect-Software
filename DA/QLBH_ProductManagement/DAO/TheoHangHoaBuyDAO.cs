using QLBH_ProductManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_ProductManagement.DAO
{
    public class TheoHangHoaBuyDAO
    {
        public List<TheoHangHoaBuy> getChiTietHoangHoaBuy()
        {
            string sql = "SELECT tt.MaPhieu, tt.NgayLap, tt.TenNCC, ct.MaHang, ct.TenHang," +
                " ct.DonVi, kh.TenKho, ct.SoLuong, ct.DonGia, ct.ThanhTien,  tt.maNVLap FROM THONGTIN_PHIEUNHAPHANG tt, " +
                "CT_PHIEUNHAP ct, KHOHANG kh WHERE tt.MaPhieu = ct.MaPhieu and tt.MaKho = kh.MaKho";
            DataTable data = new DataTable();
            data = ConnectionDB.getData(sql);
            List<TheoHangHoaBuy> listTheoHangHoa = new List<TheoHangHoaBuy>();
            if (data.Rows.Count > 0)
            {
                foreach (DataRow row in data.Rows)
                {
                    TheoHangHoaBuy hangHoaBuy = new TheoHangHoaBuy();
                    hangHoaBuy.MaPhieu = row["MaPhieu"].ToString();
                    hangHoaBuy.NgayLap = DateTime.Parse(row["NgayLap"].ToString());
                    hangHoaBuy.MaPhieu = row["MaPhieu"].ToString();
                    hangHoaBuy.MaNV = row["maNVLap"].ToString();
                    hangHoaBuy.TenHang = row["TenHang"].ToString();
                    hangHoaBuy.MaHang = row["MaHang"].ToString();
                    hangHoaBuy.TenNCC = row["TenNCC"].ToString();
                    hangHoaBuy.DonVi = row["DonVi"].ToString();
                    hangHoaBuy.TenKho = row["TenKho"].ToString();
                    hangHoaBuy.SoLuong = int.Parse(row["SoLuong"].ToString());
                    hangHoaBuy.DonGia = float.Parse(row["DonGia"].ToString());
                    hangHoaBuy.ThanhTien = float.Parse(row["ThanhTien"].ToString());

                    listTheoHangHoa.Add(hangHoaBuy);
                }
            }
            return listTheoHangHoa;
        }


        public List<TheoHangHoaBuy> getChiTietHoangHoaBuyFromDate(DateTime a, DateTime b)
        {
            string sql = string.Format("SELECT tt.MaPhieu, tt.NgayLap, tt.TenNCC, ct.MaHang, ct.TenHang," +
                " ct.DonVi, kh.TenKho, ct.SoLuong, ct.DonGia, ct.ThanhTien,  tt.maNVLap FROM THONGTIN_PHIEUNHAPHANG tt, " +
                "CT_PHIEUNHAP ct, KHOHANG kh WHERE tt.MaPhieu = ct.MaPhieu and tt.MaKho = kh.MaKho" +
                " and tt.NgayLap Between '{0}' and '{1}' ", a, b);
            DataTable data = new DataTable();
            data = ConnectionDB.getData(sql);
            List<TheoHangHoaBuy> listTheoHangHoa = new List<TheoHangHoaBuy>();
            if (data.Rows.Count > 0)
            {
                foreach (DataRow row in data.Rows)
                {
                    TheoHangHoaBuy hangHoaBuy = new TheoHangHoaBuy();
                    hangHoaBuy.MaPhieu = row["MaPhieu"].ToString();
                    hangHoaBuy.NgayLap = DateTime.Parse(row["NgayLap"].ToString());
                    hangHoaBuy.TenHang = row["TenHang"].ToString();
                    hangHoaBuy.MaNV = row["maNVLap"].ToString();
                    hangHoaBuy.MaHang = row["MaHang"].ToString();
                    hangHoaBuy.TenNCC = row["TenNCC"].ToString();
                    hangHoaBuy.DonVi = row["DonVi"].ToString();
                    hangHoaBuy.TenKho = row["TenKho"].ToString();
                    hangHoaBuy.SoLuong = int.Parse(row["SoLuong"].ToString());
                    hangHoaBuy.DonGia = float.Parse(row["DonGia"].ToString());
                    hangHoaBuy.ThanhTien = float.Parse(row["ThanhTien"].ToString());

                    listTheoHangHoa.Add(hangHoaBuy);
                }
            }
            return listTheoHangHoa;
        }
        public DataTable getChiTietHoangHoaBuyFromDateAndNCC(DateTime a, DateTime b, string maNCC)
        {
            string sql = string.Format("SELECT tt.MaPhieu, tt.NgayLap, tt.TenNCC, ct.MaHang, ct.TenHang," +
                " ct.DonVi, kh.TenKho, ct.SoLuong, ct.DonGia, ct.ThanhTien FROM THONGTIN_PHIEUNHAPHANG tt, " +
                "CT_PHIEUNHAP ct, KHOHANG kh WHERE tt.MaPhieu = ct.MaPhieu and tt.MaKho = kh.MaKho" +
                " and tt.NgayLap Between '{0}' and '{1}' and tt.MaNCC = '{2}' ", a, b, maNCC);
           
            return ConnectionDB.getData(sql);
        }
    }
}
