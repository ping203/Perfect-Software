using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBH_ProductManagement.DTO;

namespace QLBH_ProductManagement.DAO
{
    public class WarehouseDAO
    {

        public DataTable LoadKhoHang()
        {
            string sql = "select TenKho, MaKho from KHOHANG";
            DataTable dt = ConnectionDB.getData(sql);
            return dt;
        }

    
        public string getNameKhoHang(string MaKho)
        {
            string sql = string.Format("Select TenKho from KhoHang where MaKHo = '{0}'", MaKho);
            DataTable data = ConnectionDB.getData(sql);
            string name = data.Rows[0]["TenKho"].ToString();
            return name;
        }

        public List<WarehouseDTO> getWarehouse()
        {
            string sql = "SELECT * FROM KHOHANG";
            DataTable data = ConnectionDB.getData(sql);
            List<WarehouseDTO> list = new List<WarehouseDTO>();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                WarehouseDTO warehouse = new WarehouseDTO();
                warehouse.iMaKho = data.Rows[i]["MaKho"].ToString();
                warehouse.iTenKho = data.Rows[i]["TenKho"].ToString();
                warehouse.iLienHe = data.Rows[i]["LienHe"].ToString();
                warehouse.iDiaChi = data.Rows[i]["DiaChi"].ToString();
                warehouse.iDienThoai = data.Rows[i]["DienThoai"].ToString();
                warehouse.iKyHieu = data.Rows[i]["KyHieu"].ToString();
                warehouse.iGhiChu = data.Rows[i]["GhiChu"].ToString();
                warehouse.iActive = bool.Parse(data.Rows[i]["Active"].ToString());
                list.Add(warehouse);
            }
            return list;
        }

        public string IDAuto()
        {

            return Convert.ToString(ConnectionDB.ExecScalar("select dbo.SetAutoIdKhoHang()"));
        }
        public int insertWarehouse(WarehouseDTO w)
        {
            string id = IDAuto();

            string sql = string.Format(" insert into KHOHANG (MaKho, TenKho, LienHe, DiaChi, DienThoai, KyHieu, GhiChu, MaNV, Active) values" +
                            "('{0}', N'{1}', N'{2}', N'{3}', N'{4}', N'{5}', N'{6}', N'{7}' , N'{8}')",
                            w.iMaKho, w.iTenKho, w.iLienHe, w.iDiaChi, w.iDienThoai, w.iKyHieu, w.iGhiChu, w.iMaNV, w.iActive);
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
        public int updateWarehouse(WarehouseDTO w)
        {
            string sql = string.Format(" update KHOHANG " +
                                       " set TenKho = N'{0}', LienHe = N'{1}', DiaChi = N'{2}', DienThoai = N'{3}', KyHieu = N'{4}', GhiChu = N'{5}', MaNV = N'{6}', Active = N'{7}' " +
                                       " where MaKho = '{8}' ", w.iTenKho, w.iLienHe, w.iDiaChi, w.iDienThoai, w.iKyHieu, w.iGhiChu, w.iMaNV, w.iActive, w.iMaKho);

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

        public int deleteWarehouse(string makho)
        {
            string sql = string.Format(" delete from KHOHANG where MaKho = N'{0}'", makho);

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


        public List<WarehouseDTO> getKho()
        {
            string sql = "SELECT distinct  tk.MaKho, kh.TenKho FROM TONKHO tk, KHOHANG kh where tk.MaKho = kh.MaKho";
            DataTable data = ConnectionDB.getData(sql);
            List<WarehouseDTO> listWarehouseDTO = new List<WarehouseDTO>();
            if (data.Rows.Count > 0)
            {
                WarehouseDTO x = new WarehouseDTO();
                x.iMaKho = "All";
                x.iTenKho = "Tất Cả";
                listWarehouseDTO.Add(x);
                foreach (DataRow dataRow in data.Rows)
                {
                    WarehouseDTO y = new WarehouseDTO();
                    y.iTenKho = dataRow["TenKho"].ToString();
                    y.iMaKho = dataRow["MaKho"].ToString();
                    listWarehouseDTO.Add(y);
                }
            }
            return listWarehouseDTO;
        }
    }
}
