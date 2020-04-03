using QLBH_ProductManagement.DAO;
using QLBH_ProductManagement.DTO;
using System;
using System.Data;

namespace QLBH_ProductManagement.BUS
{
    public class PhieuChiTienBUS
    {
        PhieuChiTienDAO pcTienDAO = new PhieuChiTienDAO();
        public int InsertPhieuChiTien(PhieuChiTien ptTien)
        {
            return pcTienDAO.InsertPhieuChiTien(ptTien);
        }

        public DataTable LoadPhieuChiTien(DateTime a, DateTime b, int check)
        {
            return pcTienDAO.LoadPhieuChiTien(a, b, check);
        }
        public int DeletePhieuChi(string maPhieu)
        {
            return pcTienDAO.DeletePhieuChi(maPhieu);
        }
        public string IDAuto()
        {
            return pcTienDAO.IDAuto();
        }
    }
}
