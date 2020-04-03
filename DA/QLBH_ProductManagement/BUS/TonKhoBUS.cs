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
    public class TonKhoBUS
    {
        TonKhoDAO tkDao = new TonKhoDAO();
        public int getSoLuong(TonKho tk)
        {
            return tkDao.getSoLuong(tk);
        }

        public int UpdateSoLuong(TonKho tk, int soLuong)
        {
            return tkDao.UpdateSoLuong(tk, soLuong);
        }

        public int checkMatHang(string maHang, string maKho)
        {
            return tkDao.checkMatHang(maHang, maKho);
        }

        public int insertTonKho(TonKho tk, int sl)
        {
            return tkDao.insertTonKho(tk, sl);
        }

        public DataTable getTonKho()
        {
            return tkDao.getTonKho();
        }

        public DataTable getTonKhoFromMaKho(string maKHo)
        {
            return tkDao.getTonKhoFromMaKho(maKHo);
        }

        public int DeleteTonKhoHaveMaHang(string maHang)
        {
            return tkDao.DeleteTonKhoHaveMaHang(maHang);
        }
    }

}
