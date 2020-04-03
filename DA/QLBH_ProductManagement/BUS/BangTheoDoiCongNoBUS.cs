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
    public class BangTheoDoiCongNoBUS
    {
        BangTheoDoiCongNoDAO theoDoiDAO = new BangTheoDoiCongNoDAO();

        public List<BangTheoDoiCongNo> getListBangTheoDoiCongNo(DateTime a, DateTime b, int check)
        {
            return theoDoiDAO.getListBangTheoDoiCongNo(a, b, check);
        }
        public List<CustomerDTO> getKhachHangMua()
        {
            return theoDoiDAO.getKhachHangMua();
        }
        public List<BangTheoDoiCongNo> getListBangTheoDoiTheoNhomKH(string maKH, DateTime a, DateTime b, int check)
        {
            return theoDoiDAO.getListBangTheoDoiTheoNhomKH(maKH, a, b, check);
        }
        public List<BangTheoDoiCongNo> getListBangTheoDoiTheoNhomNCC(string maNCC, DateTime a, DateTime b, int check)
        {
            return theoDoiDAO.getListBangTheoDoiTheoNhomNCC(maNCC, a, b, check);
        }

        public DataTable getKhachHangMuaDatatable()
        {
            return theoDoiDAO.getKhachHangMuaDatatable();
        }
        public List<CustomerDTO> getListCongNoCuaKhachHang()
        {
            return theoDoiDAO.getListCongNoCuaKhachHang();
        }

        public List<BangTheoDoiCongNo> getListBangTheoDoiCongNoBuy(DateTime a, DateTime b, int check)
        {
            return theoDoiDAO.getListBangTheoDoiCongNoBuy(a, b, check);
        }

        public List<SupplierDTO> getListCongNoNCC()
        {
            return theoDoiDAO.getListCongNoNCC();
        }
    }
}
