using QLBH_ProductManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace QLBH_ProductManagement.DAO
{
    public class SupplierDAO
    {

        public List<SupplierDTO> getListNCCMuaHang(int check, DateTime a, DateTime b)
        {
            string sql;
            if (check == 0)
            {
                sql = "SELECT distinct kv.TenKV, tt.MaNCC, tt.TenNCC " +
                "FROM THONGTIN_PHIEUNHAPHANG tt, NCC cc, KHUVUC kv WHERE tt.MaNCC = cc.MaNCC and cc.MaKV = kv.MaKV";
            }
            else
            {
                sql = string.Format("SELECT distinct kv.TenKV, tt.MaNCC, tt.TenNCC " +
                "FROM THONGTIN_PHIEUNHAPHANG tt, NCC cc, KHUVUC kv WHERE tt.MaNCC = cc.MaNCC and cc.MaKV = kv.MaKV and tt.NgayLap between '{0}' and '{1}' ", a, b);
            }

            DataTable data = ConnectionDB.getData(sql);
            List<SupplierDTO> ListNCCMuaHang = new List<SupplierDTO>();
            foreach (DataRow dataRow in data.Rows)
            {
                SupplierDTO x = new SupplierDTO();
                x.MaNCC = dataRow["MaNCC"].ToString();
                x.TenNCC = dataRow["TenNCC"].ToString();
                x.KhuVuc = dataRow["TenKV"].ToString();
                x.TongChiPhi = getSumTienFromNCC(x.MaNCC);
                ListNCCMuaHang.Add(x);
            }
            return ListNCCMuaHang;

        }

        public float getSumTienFromNCC(string maNCC)
        {
            string sql = string.Format("SELECT sum(TongTienTra) FROM THONGTIN_PHIEUNHAPHANG where MaNCC = '{0}'", maNCC);
            if (ConnectionDB.ExcuteQuery(sql).ToString() == "")
            {
                return 0;
            }
            return (float)Convert.ToDouble(ConnectionDB.ExcuteQuery(sql));
        }

        public DataTable getNCC()
        {
            string sql = "SELECT * FROM NCC";
            DataTable data = ConnectionDB.getData(sql);
            return data;
        }

        public DataTable getNCCWithNCC()
        {
            string sql = "SELECT cc.MaNCC, cc.TenNCC, cc.NguoiLH, cc.ChucVu, cc.DiaChi,  " +
                "cc.DienThoai, cc.DiDong, cc.Fax, cc.Active, kv.TenKV FROM NCC cc, KhuVuc kv where cc.Makv = kv.MaKV";
            DataTable data = ConnectionDB.getData(sql);
            return data;
        }

        public int UpdateSup(SupplierDTO supDTO)
        {
            string sql = string.Format("UPDATE NCC SET TenNCC = N'{0}', NguoiLH = N'{1}'," +
                " DiaChi = N'{2}', DienThoai = N'{3}', DiDong = N'{4}', FAX = N'{5}', ChucVu = N'{6}'," +
                " Active = '{7}', MaKV = '{8}' where MaNCC = '{9}'",
               supDTO.TenNCC, supDTO.NguoiLienHe,
               supDTO.DiaChi, supDTO.DienThoai
               , supDTO.DiDong, supDTO.Fax, supDTO.ChucVu,
               supDTO.Active, supDTO.MaKV, supDTO.MaNCC);
            int check = Execute.InsertUpdateDelete(sql);
            return check;

        }

        public SupplierDTO getInforSup(string maNCC)
        {
            string sql = string.Format("SELECT * FROM [NCC] where [MaNCC] = '{0}'", maNCC);
            DataTable data = ConnectionDB.getData(sql);
            SupplierDTO sup = new SupplierDTO();

            if (data.Rows.Count > 0)
            {
                sup.TenNCC = data.Rows[0]["TenNCC"].ToString();
                sup.NguoiLienHe = data.Rows[0]["NguoiLH"].ToString();
                sup.DiaChi = data.Rows[0]["DiaChi"].ToString();
                sup.DienThoai = data.Rows[0]["DienThoai"].ToString();
                sup.DiDong = data.Rows[0]["DiDong"].ToString();
                sup.Fax = data.Rows[0]["Fax"].ToString();
                sup.ChucVu = data.Rows[0]["ChucVu"].ToString();
                sup.Active = bool.Parse(data.Rows[0]["Active"].ToString());
                sup.MaKV = data.Rows[0]["MaKV"].ToString();
                sup.MaNCC = maNCC;
            }
            return sup;
        }

        public string getMaNCCLast()
        {
            string sql = "select top 1 * from NCC order by MaNCC DESC";
            return ConnectionDB.GetIDLast(sql);
        }

        public int InsertSupplier(SupplierDTO sup)
        {
            string sql = string.Format("INSERT INTO NCC values('{0}', N'{1}', N'{2}',N'{3}', N'{4}'," +
               " N'{5}',N'{6}', N'{7}', N'{8}',N'{9}')", sup.MaNCC, sup.TenNCC, sup.NguoiLienHe, sup.ChucVu, sup.DiaChi, sup.DienThoai, sup.DiDong, sup.Fax, sup.Active, sup.MaKV);

            int check = Execute.InsertUpdateDelete(sql);
            return check;
        }

        public int DeleteSupplierFromNCC(string maNCC)
        {
            string sql = string.Format("Delete from NCC where MaNCC = '{0}'", maNCC);
            int check = Execute.InsertUpdateDelete(sql);
            return check;
        }

        public List<SupplierDTO> getSupplierFromNCC(string maNCC)
        {
            string sql = string.Format("SELECT * from [NCC] where [MaKV] = '{0}'", maNCC);
            DataTable data = ConnectionDB.getData(sql);
            List<SupplierDTO> listSupplier = new List<SupplierDTO>();
            foreach (DataRow row in data.Rows)
            {
                var SupplierDTO = new SupplierDTO();
                SupplierDTO.MaNCC = row["MaNCC"].ToString();
                SupplierDTO.TenNCC = row["TenNCC"].ToString();
                SupplierDTO.NguoiLienHe = row["NguoiLH"].ToString();
                SupplierDTO.ChucVu = row["ChucVu"].ToString();
                SupplierDTO.DiaChi = row["DiaChi"].ToString();
                SupplierDTO.DienThoai = row["DienThoai"].ToString();
                SupplierDTO.DiDong = row["DiDong"].ToString();
                SupplierDTO.Fax = row["Fax"].ToString();
                SupplierDTO.Active = bool.Parse(row["Active"].ToString());
                listSupplier.Add(SupplierDTO);

            }
            return listSupplier;
        }

        public List<SupplierDTO> getNCCBanHang()
        {
            string sql = "SELECT DISTINCT MaNCC, TenNCC FROM THONGTIN_PHIEUNHAPHANG";
            DataTable data = ConnectionDB.getData(sql);
            List<SupplierDTO> listNCC = new List<SupplierDTO>();
            if (data.Rows.Count > 0)
            {
                SupplierDTO x = new SupplierDTO();
                x.MaNCC = "All";
                x.TenNCC = "Tất Cả";
                listNCC.Add(x);
                foreach (DataRow dataRow in data.Rows)
                {
                    SupplierDTO y = new SupplierDTO();
                    y.MaNCC = dataRow["MaNCC"].ToString();
                    y.TenNCC = dataRow["TenNCC"].ToString();
                    listNCC.Add(y);
                }
            }
            return listNCC;
        }
    }
}
