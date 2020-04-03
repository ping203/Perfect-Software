using QLBH_ProductManagement.DAO;
using QLBH_ProductManagement.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_ProductManagement.BUS
{
    public class BaoCaoTheoChungTuBUS
    {
        BaoCaoTheoChungTuDAO baoCaoDAO = new BaoCaoTheoChungTuDAO();
        public List<BaoCaoTheoChungTu> getListBaoCao(int check, DateTime a, DateTime b)
        {
            return baoCaoDAO.getListBaoCao(check, a, b);
        }
        public List<BaoCaoTheoChungTu> getListBaoCaoTheoHangHoa(int check, string maKho)
        {
            return baoCaoDAO.getListBaoCaoTheoHangHoa(check, maKho);
        }
        public List<BaoCaoTheoChungTu> getListBaoCaoTheoNgay(int check, DateTime a, DateTime b)
        {
            return baoCaoDAO.getListBaoCaoTheoNgay(check, a, b);
        }
    }
}
