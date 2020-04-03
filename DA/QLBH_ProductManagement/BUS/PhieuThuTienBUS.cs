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
    public class PhieuThuTienBUS
    {
        PhieuThuTienDAO ptTienDAO = new PhieuThuTienDAO();
        public int InsertPhieuThuTien(PhieuThuTien ptTien)
        {
            return ptTienDAO.InsertPhieuThuTien(ptTien);
        }

        public DataTable LoadPhieuThuTien(DateTime a, DateTime b, int check)
        {
            return ptTienDAO.LoadPhieuThuTien(a, b, check);
        }
        public int DeletePhieuThu(string maPhieu)
        {
            return ptTienDAO.DeletePhieuThu(maPhieu);
        }
        public string IDAuto()
        {
            return ptTienDAO.IDAuto();
        }
    }
}
