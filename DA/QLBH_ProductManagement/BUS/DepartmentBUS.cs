using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBH_ProductManagement.DAO;
using QLBH_ProductManagement.DTO;

namespace QLBH_ProductManagement.BUS
{
    public class DepartmentBUS
    {
        DepartmentDAO departmentDAO = new DepartmentDAO();
        public List<DepartmentDTO> getDepartment()
        {
            return departmentDAO.getDepartment();
        }
        public string IDAuto()
        {
            return departmentDAO.IDAuto();
        }
        public int UpdateDepartment(DepartmentDTO departmentDTO)
        {
            return departmentDAO.UpdateDepartment(departmentDTO);
        }

        public int DeleteDepartment(string mabp)
        {
            return departmentDAO.DeleteDepartment(mabp);
        }

        public int InsertDepartment(string mabp, string tenbp, string ghichu, bool active)
        {
            return departmentDAO.InsertDepartment(mabp, tenbp, ghichu, active);
        }
    }
}
