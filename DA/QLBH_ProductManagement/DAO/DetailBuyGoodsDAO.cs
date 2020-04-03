using QLBH_ProductManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_ProductManagement.DAO
{
    public class DetailBuyGoodsDAO
    {
        public int InsertDetailBuyGoods(DetailBuyGoods detailBuy)
        {
            string sql = string.Format("INSERT INTO [CT_PHIEUNHAP](MaPhieu, MaHang, TenHang, DonVi, SoLuong, DonGia, " +
                "ThanhTien, GhiChu) " +
                "VALUES ('{0}', '{1}', N'{2}',N'{3}', {4}, {5}, {6}, N'{7}')", detailBuy.MaPhieu, 
                detailBuy.MaHang, detailBuy.TenHang, detailBuy.DonVi, detailBuy.SoLuong, detailBuy.DonGia, detailBuy.ThanhTien, detailBuy.GhiChu);
            int check = ConnectionDB.ExcuteNonQuery(sql);
            return check;
        }

        public int UpdateDetailBuy(DetailBuyGoods detailBuy)
        {
            string sql = string.Format("UPDATE [CT_PHIEUNHAP] set MaHang ='{1}' , TenHang =  N'{2}', DonVi = N'{3}', SoLuong = {4}, DonGia = {5}, " +
                "ThanhTien = {6}, GhiChu = N'{7}' WHERE MaPhieu = '{0}'"
             , detailBuy.MaPhieu,
                detailBuy.MaHang, detailBuy.TenHang, detailBuy.DonVi, detailBuy.SoLuong, detailBuy.DonGia, detailBuy.ThanhTien, detailBuy.GhiChu);
            int check = ConnectionDB.ExcuteNonQuery(sql);
            return check;
        }

        public int checkMaHang(string MaHang, string maPhieu)
        {
            string sql = string.Format("Select 1 from [CT_PHIEUNHAP] where MaHang = '{0}' and MaPhieu = '{1}' ", MaHang, maPhieu );
            return Convert.ToInt32(ConnectionDB.ExcuteQuery(sql));

        }

        public DataTable getChiTietHoaDonMuaHang()
        {
            string sql = string.Format("Select * from [HIENTHI_PHIEUNHAP]");
            DataTable data = ConnectionDB.getData(sql);
            return data;
        }

        public int deleteChiTietHoaDonAo()
        {
            string sql = string.Format("Delete  from [HIENTHI_PHIEUNHAP]");
            return Execute.InsertUpdateDelete(sql);

        }

        public int InsertChiTietHoaDonMuaHang_Ao(string maPhieu, string maHang, string TenHang, string donVi, int soLuong, float donGia, float ThanhTien)
        {
            string sql = string.Format("INSERT INTO [HIENTHI_PHIEUNHAP](MaPhieu, MaHang, TenHang, DonVi, SoLuong, DonGia, " +
                "ThanhTien, GhiChu) " +
                "VALUES ('{0}', '{1}', N'{2}',N'{3}', {4}, {5}, {6}, N'{7}')", maPhieu,
                maHang, TenHang, donVi, soLuong, donGia, ThanhTien, "");
            int check = Execute.InsertUpdateDelete(sql);
            return check;
        }


        public DataTable getListChiTietPhieuNhap()
        {
            string sql = string.Format("SELECT ct.TenHang, ct.MaHang, ct.SoLuong, ct.MaPhieu, tt.NgayLap, tt.TongTienTra " +
                "FROM CT_PHIEUNHAP ct, THONGTIN_PHIEUNHAPHANG tt WHERE TT.MaPhieu = CT.MaPhieu");
            DataTable data = ConnectionDB.getData(sql);
            return data;
        }

        public int DeleteDetailBuy(string maPhieu)
        {
            string sql = string.Format("DELETE FROM CT_PHIEUNHAP WHERE MaPhieu = '{0}' ", maPhieu);
            int check = Execute.InsertUpdateDelete(sql);
            return check;
        }


        public List<DetailBuyGoods> getListChiTietHoaDonMuaHang()
        {
            string sql = string.Format("Select MaPhieu, MaHang, TenHang, DonVi, SoLuong, DonGia," +
                " ThanhTien from [CT_PHIEUNHAP]");
            DataTable data = ConnectionDB.getData(sql);
            List<DetailBuyGoods> listChiTiet = new List<DetailBuyGoods>();
            foreach(DataRow dataRow in data.Rows)
            {
                DetailBuyGoods detaiBuy = new DetailBuyGoods();
                detaiBuy.MaPhieu = dataRow["MaPhieu"].ToString();
                detaiBuy.MaHang = dataRow["MaHang"].ToString();
                detaiBuy.TenHang = dataRow["TenHang"].ToString();
                detaiBuy.DonVi = dataRow["DonVi"].ToString();
                detaiBuy.SoLuong = int.Parse(dataRow["SoLuong"].ToString());
                detaiBuy.DonGia = float.Parse(dataRow["DonGia"].ToString());
                detaiBuy.ThanhTien = float.Parse(dataRow["ThanhTien"].ToString());
                listChiTiet.Add(detaiBuy);
            }
            return listChiTiet;
        }

        public List<DetailBuyGoods> getListChiTietHoaDonMuaHangFromMaPhieu(string maPhieu)
        {
            string sql = string.Format("Select MaPhieu, MaHang, TenHang, DonVi, SoLuong, DonGia," +
                " ThanhTien from [CT_PHIEUNHAP] where MaPhieu = '{0}' ", maPhieu);
            DataTable data = ConnectionDB.getData(sql);
            List<DetailBuyGoods> listChiTiet = new List<DetailBuyGoods>();
            foreach (DataRow dataRow in data.Rows)
            {
                DetailBuyGoods detaiBuy = new DetailBuyGoods();
                detaiBuy.MaPhieu = dataRow["MaPhieu"].ToString();
                detaiBuy.MaHang = dataRow["MaHang"].ToString();
                detaiBuy.TenHang = dataRow["TenHang"].ToString();
                detaiBuy.DonVi = dataRow["DonVi"].ToString();
                detaiBuy.SoLuong = int.Parse(dataRow["SoLuong"].ToString());
                detaiBuy.DonGia = float.Parse(dataRow["DonGia"].ToString());
                detaiBuy.ThanhTien = float.Parse(dataRow["ThanhTien"].ToString());
                listChiTiet.Add(detaiBuy);
            }
            return listChiTiet;
        }
    }
}
