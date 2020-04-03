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
    public class DetailBuyGoodsBUS
    {
        DetailBuyGoodsDAO detailBuyDAO = new DetailBuyGoodsDAO();

        public int InsertChiTietHoaDonMuaHang_Ao(string maPhieu, string maHang, string TenHang, string donVi, int soLuong, float donGia, float ThanhTien)
        {
            return detailBuyDAO.InsertChiTietHoaDonMuaHang_Ao( maPhieu,  maHang,  TenHang,  donVi,  soLuong,  donGia,  ThanhTien);
        }

        public int UpdateDetailBuy(DetailBuyGoods detailBuy)
        {
            return detailBuyDAO.UpdateDetailBuy(detailBuy);
        }

        public int checkMaHang(string MaHang, string maPhieu)
        {
            return detailBuyDAO.checkMaHang(MaHang, maPhieu);
        }

        public int deleteChiTietHoaDonAo()
        {
            return detailBuyDAO.deleteChiTietHoaDonAo();
        }
       
        public DataTable getChiTietHoaDonMuaHang()
        {
            return detailBuyDAO.getChiTietHoaDonMuaHang();
        }

        public int InsertDetailBuyGoods(DetailBuyGoods detailBuy)
        {
            return detailBuyDAO.InsertDetailBuyGoods(detailBuy);
        }
        public int DeleteDetailBuy(string maPhieu)
        {
            return detailBuyDAO.DeleteDetailBuy(maPhieu);
        }

        public List<DetailBuyGoods> getListChiTietHoaDonMuaHang()
        {
            return detailBuyDAO.getListChiTietHoaDonMuaHang();
        }

        public DataTable getListChiTietPhieuNhap()
        {
            return detailBuyDAO.getListChiTietPhieuNhap();
        }

        public List<DetailBuyGoods> getListChiTietHoaDonMuaHangFromMaPhieu(string maPhieu)
        {
            return detailBuyDAO.getListChiTietHoaDonMuaHangFromMaPhieu(maPhieu);
        }
    }


}
