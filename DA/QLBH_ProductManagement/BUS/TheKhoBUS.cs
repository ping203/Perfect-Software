using QLBH_ProductManagement.DAO;
using QLBH_ProductManagement.DTO;
using System;
using System.Collections.Generic;

namespace QLBH_ProductManagement.BUS
{
    public class TheKhoBUS
    {
        TheKhoDAO theKho = new TheKhoDAO();
        public List<TheKhoDTO> getListTheKho()
        {
            return theKho.getListTheKho();
        }
        public List<TheKhoDTO> getListChungTu(int check, DateTime a, DateTime b)
        {
            return theKho.getListChungTu( check,  a,  b);
        }
    }
}
