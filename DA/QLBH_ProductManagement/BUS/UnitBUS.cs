using System.Collections.Generic;
using QLBH_ProductManagement.DAO;
using QLBH_ProductManagement.DTO;
using System.Data;

namespace QLBH_ProductManagement.BUS
{
    public class UnitBUS
    {
        UnitDAO unitDAO = new UnitDAO();

        public string getMaDVUnit(string nameDV)
        {
            return unitDAO.getMaDVUnit(nameDV);
        }


            public DataTable getUnitDataTable()
        {
            return unitDAO.getUnitDataTable();
        }

        public string getNameUnit(string maDV)
        {
            return unitDAO.getNameUnit(maDV);
        }

         public List<UnitDTO> getUnit()
        {
            return unitDAO.getUnit();
        }

        public string IDAuto()
        {
            return unitDAO.IDAuto();
        }

        public int insertUnit(UnitDTO unit)
        {
            return unitDAO.insertUnit(unit);
        }

        public int updateUnit(UnitDTO unit)
        {
            return unitDAO.updateUnit(unit);
        }

        public int deleteUnit(string madvt)
        {
            return unitDAO.deleteUnit(madvt);
        }
    }
}
