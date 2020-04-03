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
    public class DetailSellGoodsBUS
    {
        DetailSellGoodsDAO detailSell = new DetailSellGoodsDAO();

        public DataTable getDataTheoHangHoa(int check, DateTime a, DateTime b)
        {
            return detailSell.getDataTheoHangHoa(check, a, b);
        }
        public List<DetailSellGoods> getListChiTietHoaDonBanHangFromMaPhieu(string maPhieu)
        {

            return detailSell.getListChiTietHoaDonBanHangFromMaPhieu(maPhieu);
        }

        public DataTable getDataTheoHangHoaFromMaKho(DateTime a, DateTime b, string maKho)
        {
            return detailSell.getDataTheoHangHoaFromMaKho(a, b, maKho);
        }

        public DataTable getHTDetailSellBuy()
        {
            return detailSell.getHTDetailSellBuy();
        }
        public int deleteChiTietHoaDonAo()
        {
            return detailSell.deleteChiTietHoaDonAo();
        }

        public int InsertChiTietHoaDonBanHang_Ao(DetailSellGoods detail)
        {
            return detailSell.InsertChiTietHoaDonBanHang_Ao(detail);
        }
            public int InsertDetailSell(DetailSellGoods detailSellGoods)
        {
            return detailSell.InsertDetailSell(detailSellGoods);
        }

        public DataTable getCTPhieuXuat() // cho phần hiển thị bên Theo Hàng hóa
        {
            return detailSell.getCTPhieuXuat();
        }

        public DataTable getCTPhieuXuatTheoKhachHang(string maKH, DateTime a, DateTime b, int check) // cho phần hiển thị bên Theo Hàng hóa
        {
            return detailSell.getCTPhieuXuatTheoKhachHang(maKH, a, b, check);
        }

        public DataTable getCTPhieuXuatFromNgay(DateTime a, DateTime b) // cho phần hiển thị bên Theo Hàng hóa
        {
            return detailSell.getCTPhieuXuatFromNgay(a, b);
        }
        public int DeleteDetailSell(string maPhieu)
        {
            return detailSell.DeleteDetailSell(maPhieu);
        }
        public List<InforDetailSell> getThongTinHoaDon(DateTime dtTu, DateTime dtDen, int check)// dùng bên chứng từ mua
        {
            return detailSell.getThongTinHoaDon(dtTu, dtDen, check);
        }
        public List<DetailSellGoods> getListChiTietMua() // chứng từ
        {
            return detailSell.getListChiTietMua();
        }
        public List<DetailSellGoods> getListChiTietMuaCongNo() // chứng từ
        {
            return detailSell.getListChiTietMuaCongNo(); // chứng từ
        }
        public int UpdateIsDeleteDetail(string maPhieu)
        {
            return detailSell.UpdateIsDeleteDetail(maPhieu);
        }

        public List<InforDetailSell> getThongTinHoaDonFromMaKH(DateTime dtTu, DateTime dtDen, string maKH)// dùng bên chứng từ mua
        {
            return detailSell.getThongTinHoaDonFromMaKH(dtTu, dtDen, maKH);
        }
    }

}
