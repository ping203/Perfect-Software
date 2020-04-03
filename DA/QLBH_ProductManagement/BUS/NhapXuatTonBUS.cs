using QLBH_ProductManagement.DAO;
using QLBH_ProductManagement.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_ProductManagement.BUS
{

    public class NhapXuatTonBUS
    {
        NhapXuatTonDAO nhapXuattonDAO = new NhapXuatTonDAO();
        public List<NhapXuatTon> getListNhapXuatTon(int check, string maKho)
        {
            return nhapXuattonDAO.getListNhapXuatTon(check, maKho);
        }
    }
}
