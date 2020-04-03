using QLBH_ProductManagement.DAO;
using QLBH_ProductManagement.DTO;
using System.Collections.Generic;
using System.Data;

namespace QLBH_ProductManagement.BUS
{
    public class GoodBUS
    {
        GoodDAO gDAO = new GoodDAO();

        public string getTenDonVi(string maHang)
        {
            return gDAO.getTenDonVi(maHang);
        }

        //public GoodDTO getInforGoodsFromMaHang(string mahang)
        //{
        //    return gDAO.getInforGoodsFromMaHang(mahang);
        //}

        public GoodDTO getInforGoods(string mahang)
        {
            return gDAO.getInforGoods(mahang);
        }

        //public DataTable getChiTietHoaDonBan()
        //{
        //    return gDAO.getChiTietHoaDonBan();
        //}

        public DataTable getListGoods()
        {
            return gDAO.getListGoods();
        }

        public List<GoodDTO> getListGoodFromIDGroup(string maNhom)
        {
            return gDAO.getListGoodFromIDGroup(maNhom);
        }
        public string IDAuto()
        {
            return gDAO.IDAuto();
        }
        public int InsertGood(GoodDTO goodDTO)
        {
            return gDAO.InsertGood(goodDTO);
        }
        public int updateGood(GoodDTO goodDTO)
        {
            return gDAO.updateGoods(goodDTO);
        }
        public GoodDTO getInfoGoods(string mahang)
        {
            return gDAO.getInforGoods(mahang);
        }

        public int DeleteGood(string mahang)
        {
            return gDAO.DeleteGood(mahang);
        }

        public DataTable getListGoodsDaoDich()  // dung bên các dao dich
        {
            return gDAO.getListGoodsDaoDich();
        }

        public DataTable getListGoodsDaoDichChuyenKho()  // dung bên các dao dich
        {
            return gDAO.getListGoodsDaoDichChuyenKho();
        }

        public int checkMaHangTrongTonKho(string maHang)
        {
            return gDAO.checkMaHangTrongTonKho(maHang);
        }
    }
}
