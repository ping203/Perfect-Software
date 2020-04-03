using QLBH_ProductManagement.DAO;
using QLBH_ProductManagement.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_ProductManagement.BUS
{
    public class TonKhoTongHopBUS
    {
        TonKhoTongHopDAO tkTongHopDAO = new TonKhoTongHopDAO();
        public List<TonKhoTongHop> getListTonKhoTongHop(int check, string maKho)
        {
            return tkTongHopDAO.getListTonKhoTongHop(check, maKho);
        }
    }
}
