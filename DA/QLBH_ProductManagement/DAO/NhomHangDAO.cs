using QLBH_ProductManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace QLBH_ProductManagement.DAO
{
    public class NhomHangDAO
    {

        public DataTable LoadNhomHang()
        {
            string sql = "select  TenNhom, MaNhom from NHOMHANG";
            DataTable dt = ConnectionDB.getData(sql);
            return dt;
        }

        public int DeleteListFromMa(string maNhomHang)
        {
            string sql = string.Format("Delete from [NHOMHANG] where MaNhom = '{0}'", maNhomHang);
            int check = ConnectionDB.ExcuteNonQuery(sql);
            return check;
        }

        public List<NhomHang> getListNhomHang()
        {
            List<NhomHang> listNhomHang = new List<NhomHang>();
            string sql = "SELECT * FROM [NHOMHANG]";
            DataTable data = ConnectionDB.getData(sql);

            foreach(DataRow row in data.Rows)
            {
                NhomHang nh = new NhomHang();
                nh.maNhomHang = row["MaNhom"].ToString();
                nh.tenNhomHang = row["TenNhom"].ToString();
                nh.ghiChu = row["GhiChu"].ToString();
                nh.kichHoat = bool.Parse(row["Active"].ToString());
                listNhomHang.Add(nh);
            }
            return listNhomHang;         
        }
        public string IDAuto()
        {
            return Convert.ToString(ConnectionDB.ExecScalar("select dbo.SetAutoIdNhomHang()"));
        }

        public int InsertNhomHang(string ma, string ten, string ghichu, bool active)
        {
            string id = IDAuto();
            string sql = string.Format("INSERT INTO NHOMHANG Values(N'{0}', N'{1}', N'{2}', '{3}')", ma, ten, ghichu, active);
            int check = ConnectionDB.ExcuteNonQuery(sql);
            return check;
        }
        public int UpdateNhomHang(NhomHang nhomHang)
        {
            string sql = string.Format("Update NHOMHANG set TenNhom = N'{0}', GhiChu = N'{1}', Active = '{2}' where MaNhom = '{3}'", nhomHang.tenNhomHang, nhomHang.ghiChu, nhomHang.kichHoat, nhomHang.maNhomHang);
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
    }
}
