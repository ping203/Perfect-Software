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
    public class InforSellBUS
    {
        InforDetailSellDAO inforSell = new InforDetailSellDAO();
        public DataTable getInforDetailSell(int check, DateTime a, DateTime b)
        {
            return inforSell.getInforDetailSell(check, a, b);
        }
        public int InsertDetailSellGoods(InforDetailSell Infordetail)
        {
            return inforSell.InsertDetailSellGoods(Infordetail);
        }
        public int checkMaPhieuBan(string maPhieu)
        {
            return inforSell.checkMaPhieuBan(maPhieu);
        }
        public int UpdateTien(string maPhieu, float thanhTien, float thanhToan)
        {
            return inforSell.UpdateTien(maPhieu, thanhTien, thanhToan);
        }
        public int DeleteInforDetailSell(string maPhieu)
        {
            return inforSell.DeleteInforDetailSell(maPhieu);
        }

        public string IDAuto()
        {
            return inforSell.IDAuto();

        }
        public DataTable getListThanhToanNgay(DateTime a, DateTime b, int check)
        {
            return inforSell.getListThanhToanNgay(a, b, check);
        }
        public List<InforDetailSell> getListThanhToanCongNo(DateTime a, DateTime b, int check)
        {
            return inforSell.getListThanhToanCongNo(a, b, check);
        }
        public int UpdateIsCheck(string maPhieu, int isCheck)
        {
            return inforSell.UpdateIsCheck(maPhieu, isCheck);
        }

        public int checkMaChungTuInPhieuThu(string maChungTu)
        {
            return inforSell.checkMaChungTuInPhieuThu(maChungTu);
        }
        public InforDetailSell getInforDetailSellFromMa(string maPhieu)
        {
            return inforSell.getInforDetailSellFromMa(maPhieu);
        }
        public int UpdateInforSell(InforDetailSell Infordetail)
        {
            return inforSell.UpdateInforSell(Infordetail);
        }
    }
}
