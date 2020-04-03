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
    public class InforDetailBuyBUS
    {
        InforDetailBuyDAO inforDAO = new InforDetailBuyDAO();
        public int InsertDetailBuyGoods(InforDetailBuy Infordetail)
        {
            return inforDAO.InsertDetailBuyGoods(Infordetail);

        }

        public int UpdateInforBuy(InforDetailBuy Infordetail)
        {
            return inforDAO.UpdateInforBuy(Infordetail);
        }
            public InforDetailBuy getInforDetailBuyFromMa(string maPhieu)
        {
            return inforDAO.getInforDetailBuyFromMa(maPhieu);
        }

        public int checkMaPhieuMua(string maPhieu)
        {
            return inforDAO.checkMaPhieuMua(maPhieu);
        }

        public int DeleteInforDetailBuy(string maPhieu)
        {
            return inforDAO.DeleteInforDetailBuy(maPhieu);
        }

        public int UpdateTongTien(float tongTienMua, string maPhieu, float TongTienTra)
        {
            return inforDAO.UpdateTongTien(tongTienMua, maPhieu, TongTienTra);
        }
        public DataTable getInforDetailBuy() // lấy bên chứng từ
        {
            return inforDAO.getInforDetailBuy();
        }

        public DataTable getDatatableInforDetailBuy(int check, DateTime a, DateTime b)
        {
            return inforDAO.getDatatableInforDetailBuy( check,  a,  b);
               
        }
            public List<InforDetailBuy> getListInforDetailBuy(DateTime a, DateTime b, int check)
        {
            return inforDAO.getListInforDetailBuy(a, b, check);
        }

        public string IDAuto()
        {
            return inforDAO.IDAuto();
        }

        public List<InforDetailBuy> getListInforDetailBuyConNo()
        {
            return inforDAO.getListInforDetailBuyConNo();
        }
        public List<InforDetailBuy> getListInforDetailBuyConNoFromNgay(DateTime a, DateTime b)
        {
            return inforDAO.getListInforDetailBuyConNoFromNgay(a, b);
        }
        public DataTable getListMuaTraNgay(DateTime a, DateTime b, int check)
        {
            return inforDAO.getListMuaTraNgay(a, b, check);
        }

        public int checkMaChungTuInPhieuChi(string maChungTu)
        {
            return inforDAO.checkMaChungTuInPhieuChi(maChungTu);
        }
        public int UpdateIsCheck(string maPhieu, int isCheck)
        {
            return inforDAO.UpdateIsCheck(maPhieu, isCheck);
        }
        public List<InforDetailBuy> getListInforDetailBuyFormMaNCC(DateTime a, DateTime b, string maNCC)
        {
            return inforDAO.getListInforDetailBuyFormMaNCC(a, b, maNCC);
        }
    }
}
