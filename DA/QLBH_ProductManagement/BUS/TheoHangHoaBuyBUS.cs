using QLBH_ProductManagement.DAO;
using QLBH_ProductManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace QLBH_ProductManagement.BUS
{
    public class TheoHangHoaBuyBUS
    {
        TheoHangHoaBuyDAO hangHoa = new TheoHangHoaBuyDAO();
        public List<TheoHangHoaBuy> getChiTietHoangHoaBuy()
        {
            return hangHoa.getChiTietHoangHoaBuy();
        }

        public List<TheoHangHoaBuy> getChiTietHoangHoaBuyFromDate(DateTime a, DateTime b)
        {
            return hangHoa.getChiTietHoangHoaBuyFromDate(a, b);
        }
        public DataTable getChiTietHoangHoaBuyFromDateAndNCC(DateTime a, DateTime b, string maNCC)
        {
            return hangHoa.getChiTietHoangHoaBuyFromDateAndNCC(a, b, maNCC);
        }
    }

}
