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
    public class InforTransWarehouseBUS
    {
        InforTransWarehouseDAO inforDAO = new InforTransWarehouseDAO();

        public string IDAuto()
        {
            return inforDAO.IDAuto();
        }
        public DataTable getInforDetailWarehouse(int check, DateTime a, DateTime b)
        {
            return inforDAO.getInforDetailWarehouse(check, a, b);
        }

        public int InsertInforTranWarehouse(InforTransWarehouseDTO infor)
        {
            return inforDAO.InsertInforTranWarehouse(infor);
        }
        public int DeleteInforTransWarehouse(string maPhieu)
        {
            return inforDAO.DeleteInforTransWarehouse(maPhieu);
        }
        public List<InforTransWarehouseDTO> getListInforTrans(DateTime a, DateTime b, int check)
        {
            return inforDAO.getListInforTrans(a, b, check);
        }
        public InforTransWarehouseDTO getDetailTransFromMa(string maPhieuChuyen)
        {
            return inforDAO.getDetailTransFromMa(maPhieuChuyen);
        }

        public int checkMaPhieuChuyenKho(string maPhieu)
        {
            return inforDAO.checkMaPhieuChuyenKho(maPhieu);
        }
        public int UpdateInforTranWarehouse(InforTransWarehouseDTO infor)
        {
            return inforDAO.UpdateInforTranWarehouse(infor);
        }

    }
}
