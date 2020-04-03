using System.Collections.Generic;
using QLBH_ProductManagement.DAO;
using QLBH_ProductManagement.DTO;
using System.Data;

namespace QLBH_ProductManagement.BUS
{

    public class WarehouseBUS
    {
        WarehouseDAO warehouseDAO = new WarehouseDAO();



        public DataTable LoadKhoHang()
        {
            return warehouseDAO.LoadKhoHang();
        }

        public string getNameKhoHang(string MaKho)
        {
            return warehouseDAO.getNameKhoHang(MaKho);

        }

        public List<WarehouseDTO> getWarehouse()
        {
            return warehouseDAO.getWarehouse();
        }

        public string IDAuto()
        {
            return warehouseDAO.IDAuto();
        }
        public int insertWarehouse(WarehouseDTO w)
        {
            return warehouseDAO.insertWarehouse(w);
        }

        public int updateWarehouse(WarehouseDTO w)
        {
            return warehouseDAO.updateWarehouse(w);
        }

        public int deleteWarehouse(string makho)
        {
            return warehouseDAO.deleteWarehouse(makho);
        }
        public List<WarehouseDTO> getKho()
        {
            return warehouseDAO.getKho();
        }
    }
}
