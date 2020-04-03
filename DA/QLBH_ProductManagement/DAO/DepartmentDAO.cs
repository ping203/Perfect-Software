using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBH_ProductManagement.DTO;


namespace QLBH_ProductManagement.DAO
{
    public class DepartmentDAO
    {
        public List<DepartmentDTO> getDepartment()
        {
            string sql = "SELECT * FROM BOPHAN";
            DataTable data = ConnectionDB.getData(sql);
            List<DepartmentDTO> list = new List<DepartmentDTO>();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                DepartmentDTO department = new DepartmentDTO();
                department.iMaBP = data.Rows[i]["MaBP"].ToString();
                department.iTenBP = data.Rows[i]["TenBP"].ToString();
                department.iGhiChu = data.Rows[i]["GhiChu"].ToString();
                department.iActive = bool.Parse(data.Rows[i]["Active"].ToString());
                list.Add(department);
            }
            return list;
        }
        public string IDAuto()
        {
            return Convert.ToString(ConnectionDB.ExecScalar("select dbo.SetAutoIdBoPhan()"));
        }

        public int InsertDepartment(string mabp, string tenbp, string ghichu, bool active)
        {
            string id = IDAuto();
            string sql = string.Format("INSERT INTO BOPHAN Values(N'{0}', N'{1}', N'{2}', '{3}')", id, tenbp, ghichu, active);
            int check = ConnectionDB.ExcuteNonQuery(sql);
            return check;
        }
        public int UpdateDepartment(DepartmentDTO departmentDTO)
        {
            string sql = string.Format("Update BOPHAN set TenBP = N'{0}', GhiChu = N'{1}', Active = '{2}' where MaBP = '{3}'", departmentDTO.iTenBP, departmentDTO.iGhiChu, departmentDTO.iActive, departmentDTO.iActive);
            try
            {
                ConnectionDB.ExecNonQuery(sql);
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public int DeleteDepartment(string mabp)
        {
            string sql = string.Format("Delete from BOPHAN where MaBP = '{0}'", mabp);
            int check = ConnectionDB.ExcuteNonQuery(sql);
            return check;
        }
        public DataTable getDepartmentDataTable()
        {
            string sql = "SELECT * FROM BOPHAN";
            DataTable data = ConnectionDB.getData(sql);
            return data;
        }
    }
}
