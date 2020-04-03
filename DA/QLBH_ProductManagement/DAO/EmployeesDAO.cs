using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBH_ProductManagement.DTO;


namespace QLBH_ProductManagement.DAO
{
    public class EmployeesDAO
    {
        public DataTable LayDuLieuNV(string sql)
        {
            return ConnectionDB.LayDuLieuBang(sql);
        }
        public List<EmployeesDTO> getEmployees()
        {
            string sql = "SELECT * FROM _NHANVIEN";
            DataTable data = ConnectionDB.getData(sql);
            List<EmployeesDTO> list = new List<EmployeesDTO>();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                EmployeesDTO employees = new EmployeesDTO();
                employees.iMaNV = data.Rows[i]["MaNV"].ToString();
                employees.iTenNV = data.Rows[i]["TenNV"].ToString();
                employees.iDiaChi = data.Rows[i]["DiaChi"].ToString();
                employees.iDiDong = data.Rows[i]["DiDong"].ToString();
                employees.iDienThoai = data.Rows[i]["DienThoai"].ToString();
                employees.iEmail = data.Rows[i]["Email"].ToString();
                employees.iActive = bool.Parse(data.Rows[i]["Active"].ToString());
                list.Add(employees);
            }
            return list;
        }

        public List<EmployeesDTO> getEmployeesMuaBan()
        {
            string sql = "SELECT * FROM _NHANVIEN";
            DataTable data = ConnectionDB.getData(sql);
            List<EmployeesDTO> list = new List<EmployeesDTO>();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                EmployeesDTO employees = new EmployeesDTO();
                employees.iMaNV = data.Rows[i]["MaNV"].ToString();
                employees.iTenNV = data.Rows[i]["TenNV"].ToString();
                employees.iDiaChi = data.Rows[i]["DiaChi"].ToString();
                
                employees.iDienThoai = data.Rows[i]["DienThoai"].ToString();
                employees.TongSoMuaHang = getSumTienMua(employees.iMaNV);
                employees.TongSoBanHang = getSumTienBan(employees.iMaNV);
                list.Add(employees);
            }
            return list;
        }

        public float getSumTienMua(string maNV)
        {
            string sql = string.Format("SELECT sum(ThanhTien) FROM THONGTIN_PHIEUNHAPHANG tt, CT_PHIEUNHAP ct " +
                "WHERE tt.MaPhieu = ct.MaPhieu and tt.MaNVLap = '{0}'", maNV);
            if (ConnectionDB.ExcuteQuery(sql).ToString() == "")
            {
                return 0;
            }
            return (float)Convert.ToDouble(ConnectionDB.ExcuteQuery(sql));
        }

        public float getSumTienBan(string maNV)
        {
            string sql = string.Format("SELECT sum(ThanhToan) FROM THONGTIN_PHIEU_BANHANG tt, CT_PHIEUXUAT ct " +
                "WHERE tt.MaPhieu = ct.MaPhieuXuat and tt.MaNVLap = '{0}'", maNV);
            if (ConnectionDB.ExcuteQuery(sql).ToString() == "")
            {
                return 0;
            }
            return (float)Convert.ToDouble(ConnectionDB.ExcuteQuery(sql));
        }

        public string IDAuto()
        {
            return Convert.ToString(ConnectionDB.ExecScalar("select dbo.SetAutoIdNhanVien()"));
        }
        public int InsertEmployees(EmployeesDTO employeesDTO)
        {
            //string bophan = employeesDTO.iBoPhan != null ? string.Format("'{0}'", employeesDTO.iBoPhan) : "null";
            //string nql = employeesDTO.iNguoiQL != null ? string.Format("'{0}'", employeesDTO.iNguoiQL) : "null";
            string id = IDAuto();
            string sql = string.Format("INSERT INTO _NHANVIEN Values(N'{0}', N'{1}', N'{2}', N'{3}', N'{4}', N'{5}', N'{6}', N'{7}', '{8}')", id,
                employeesDTO.iTenNV, employeesDTO.iDiaChi, employeesDTO.iDienThoai, employeesDTO.iDiDong, employeesDTO.iEmail,
                employeesDTO.iBoPhan, employeesDTO.iNguoiQL, employeesDTO.iActive);
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

        public int UpdateEmployees(EmployeesDTO employeesDTO)
        {
            string sql = "update _NHANVIEN set " +
                 string.Format("TenNV = N'{0}', DiaChi = N'{1}', Email = '{2}',",
                 employeesDTO.iTenNV, employeesDTO.iDiaChi, employeesDTO.iEmail) +
                 string.Format("DienThoai = '{0}', DiDong = '{1}', BoPhan = '{2}', NguoiQL = '{3}'",
                 employeesDTO.iDienThoai, employeesDTO.iDiDong, employeesDTO.iBoPhan, employeesDTO.iNguoiQL) +
                 string.Format("ConQuanLy={0} where MaNV='{1}'",
                 employeesDTO.iActive, employeesDTO.iMaNV);
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
        public int DeleteEmployees(string manv)
        {
            string sql = string.Format("Delete from _NHANVIEN where MaNV = '{0}'", manv);
            int check = ConnectionDB.ExcuteNonQuery(sql);
            return check;
        }

        public DataTable getEmployeesDataTable()
        {
            string sql = "SELECT * FROM _NHANVIEN";
            DataTable data = ConnectionDB.getData(sql);
            return data;
        }

    }
}
