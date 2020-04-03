using QLBH_ProductManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_ProductManagement.DAO
{
    public class TonKhoDAO
    {
        public int getSoLuong(TonKho tk)  // lấy so luongj tồn kho của mH
        {
            string sql = string.Format("SELECT SOLUONGTON FROM TONKHO WHERE MAKHO = '{0}' and MAHANG =  '{1}'", tk.MaKho, tk.MaHang);
            int sl = Convert.ToInt32(ConnectionDB.ExcuteQuery(sql));
            
            return sl;
        }

        public int UpdateSoLuong(TonKho tk, int soLuong)
        {
            string sql = string.Format("UPDATE TONKHO SET SOLUONGTON = {0}  where MaKHo = '{1}' and mahang = '{2}'", soLuong, tk.MaKho, tk.MaHang);
            return ConnectionDB.ExcuteNonQuery(sql);
        }

        public int checkMatHang(string maHang, string maKho)
        {
            string sql = string.Format("SELECT 1 FROM TONKHO WHERE MAHANG = N'{0}'and MAKHO = N'{1}'", maHang, maKho);
            int check = Convert.ToInt32(ConnectionDB.ExcuteQuery(sql));
            return check;
        }

        public int insertTonKho(TonKho tk, int sl)
        {
            string sql = string.Format("INSERT INTO TONKHO VALUES('{0}', N'{1}',{2},{3}, '{4}')", tk.MaKho, tk.MaHang , sl, 1, true);
            int check = ConnectionDB.ExcuteNonQuery(sql);
            return check;
        }

        public DataTable getTonKho()
        {
            string sql = string.Format("SELECT hh.MaHang, hh.TenHang, dvt.Ten, tk.SoLuongTon, nh.TenNhom, tk.Active, kh.TenKho, tk.MaKho" +
                " FROM TONKHO TK, HANGHOA_DICHVU hh, KHOHANG kh, DONVITINH dvt, NHOMHANG nh" +
                " WHERE TK.MAHang = hh.MaHang and tk.MaKho = kh.MaKho and hh.MaDV = dvt.MaDVT and hh.MaNhom = nh.MaNhom");
            
            return ConnectionDB.getData(sql);
        }



        public DataTable getTonKhoFromMaKho(string maKHo)
        {
            string sql = string.Format("SELECT hh.MaHang, hh.TenHang, dvt.Ten, tk.SoLuongTon, nh.TenNhom, tk.Active, kh.TenKho, tk.MaKho " +
                " FROM TONKHO TK, HANGHOA_DICHVU hh, KHOHANG kh, DONVITINH dvt, NHOMHANG nh" +
                " WHERE TK.MAHang = hh.MaHang and tk.MaKho = kh.MaKho and hh.MaDV = dvt.MaDVT and hh.MaNhom = nh.MaNhom and tk.SoLuongToiThieu >= {0} and tk.MaKho = '{1}'", 1, maKHo);
            return ConnectionDB.getData(sql);
        }

        public int DeleteTonKhoHaveMaHang(string maHang)
        {
            string sql = string.Format("DELETE FROM TONKHO WHERE Mahang = '{0}'", maHang);
            int check = ConnectionDB.ExcuteNonQuery(sql);
            return check;
        }

    }
}
