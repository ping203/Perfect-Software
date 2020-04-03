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
    public class EmployeesBUS
    {
        EmployeesDAO employeesDAO = new EmployeesDAO();
        public List<EmployeesDTO> getEmployeesMuaBan()
        {
            return employeesDAO.getEmployeesMuaBan();
        }

        public DataTable LayDuLieuNV(string sql)
        {
            return employeesDAO.LayDuLieuNV(sql);
        }
        public DataTable getEmployeesDataTable()
        {
            return employeesDAO.getEmployeesDataTable();
        }
        public List<EmployeesDTO> getEmployees()
        {
            return employeesDAO.getEmployees();
        }
        public string IDAuto()
        {
            return employeesDAO.IDAuto();
        }
        public int UpdateEmpoyees(EmployeesDTO employeesDTO)
        {
            return employeesDAO.UpdateEmployees(employeesDTO);
        }

        public int DeleteDepartment(string manv)
        {
            return employeesDAO.DeleteEmployees(manv);
        }

        public int InsertEmployees(EmployeesDTO employeesDTO)
        {
            return employeesDAO.InsertEmployees(employeesDTO);
        }
    }
}
