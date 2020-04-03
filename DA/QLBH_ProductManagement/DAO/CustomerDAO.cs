using QLBH_ProductManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace QLBH_ProductManagement.DAO
{
    public class CustomerDAO
    {
        public DataTable getCusDatatable()
        {
            string sql = "SELECT * FROM KHACHHANG";
            DataTable data = ConnectionDB.getData(sql);
            return data;
        }

        public DataTable getCusDatatableWithKV()
        {
            string sql = "SELECT kh.MaKH, kh.TenKH, kh.NguoiLienHe, kh.DiaChi, kh.DienThoai, " +
                "kh.DiDong, kh.Fax, kh.Email, kh.Website, kh.MaSoThue, kv.TenKV FROM KHACHHANG kh, KhuVuc kv where kh.Makv = kv.MaKV";
            DataTable data = ConnectionDB.getData(sql);
            return data;
        }

        public List<CustomerDTO> getListKhachHangMuaHang(DateTime a, DateTime b, int check)
        {
            string sql;
            if (check == 1)
            {
                sql = string.Format("SELECT distinct tt.MaKH, tt.TenKH, kv.TenKV " +
              "FROM THONGTIN_PHIEU_BANHANG tt, KHACHHANG kh, KHUVUC kv WHERE tt.MaKH = kh.MaKH and kh.MaKV = kv.MaKV and tt.NgayLap between '{0}' and '{1}'", a, b);
            }
            else
            {
                sql = string.Format("SELECT distinct tt.MaKH, tt.TenKH, kv.TenKV " +
              "FROM THONGTIN_PHIEU_BANHANG tt, KHACHHANG kh, KHUVUC kv WHERE tt.MaKH = kh.MaKH and kh.MaKV = kv.MaKV");
            }

            DataTable data = ConnectionDB.getData(sql);
            List<CustomerDTO> ListKhachHangMuaHang = new List<CustomerDTO>();
            foreach (DataRow dataRow in data.Rows)
            {
                CustomerDTO x = new CustomerDTO();
                x.MaKH = dataRow["MaKH"].ToString();
                x.TenKH = dataRow["TenKH"].ToString();
                x.KhuVuc = dataRow["TenKV"].ToString();
                x.TongChiPhi = getSumTienFromKH(x.MaKH);
                ListKhachHangMuaHang.Add(x);
            }
            return ListKhachHangMuaHang;
        }

        public float getSumTienFromKH(string maKH)
        {
            string sql = string.Format("SELECT sum(TongTienNhan) FROM THONGTIN_PHIEU_BANHANG where MaKH = '{0}'", maKH);
            if (ConnectionDB.ExcuteQuery(sql).ToString() == "")
            {
                return 0;
            }
            return (float)Convert.ToDouble(ConnectionDB.ExcuteQuery(sql));
        }


        public CustomerDTO getInforCustomer(string maKH)
        {
            string sql = string.Format("SELECT * FROM KHACHHANG WHERE MaKH = N'{0}'", maKH);
            CustomerDTO cusDTO = new CustomerDTO();
            DataTable data = ConnectionDB.getData(sql);
            if (data.Rows.Count > 0)
            {
                cusDTO.TenKH = data.Rows[0]["TenKH"].ToString();
                cusDTO.NguoiLienHe = data.Rows[0]["NguoiLienHe"].ToString();
                cusDTO.DiaChi = data.Rows[0]["DiaChi"].ToString();
                cusDTO.DienThoai = data.Rows[0]["DienThoai"].ToString();
                cusDTO.DiDong = data.Rows[0]["DiDong"].ToString();
                cusDTO.Fax = data.Rows[0]["Fax"].ToString();
                cusDTO.Email = data.Rows[0]["Email"].ToString();
                cusDTO.Website = data.Rows[0]["Website"].ToString();
                cusDTO.MaSoThue = data.Rows[0]["MaSoThue"].ToString();
                cusDTO.SoTK = data.Rows[0]["SoTK"].ToString();
                cusDTO.TenNganHang = data.Rows[0]["TenNganHang"].ToString();
                cusDTO.Active = bool.Parse(data.Rows[0]["Active"].ToString());
                cusDTO.MaKV = data.Rows[0]["MaKV"].ToString();
                cusDTO.MaKH = maKH;
            }
            return cusDTO;
        }

        public string getMaKHLast()
        {
            string sql = "select top 1 * from KhachHang order by MaKH DESC";
            return ConnectionDB.GetIDLast(sql);
        }
        public int UpdateKhachHang(CustomerDTO cusDTO)
        {
            string sql = string.Format("UPDATE KHACHHANG SET TenKH = N'{0}', NguoiLienHe = N'{1}', DiaChi = N'{2}', DienThoai = N'{3}', DiDong = N'{4}', FAX = N'{5}', EMAIL = N'{6}', Website = N'{7}', MaSoThue = N'{8}', SoTK = N'{9}', TenNganHang = N'{10}', Active = '{11}', MaKV = '{12}' WHERE MaKH = N'{13}'",
                cusDTO.TenKH, cusDTO.NguoiLienHe,
                cusDTO.DiaChi, cusDTO.DienThoai
                , cusDTO.DiDong, cusDTO.Fax, cusDTO.Email,
                cusDTO.Website, cusDTO.MaSoThue,
                cusDTO.SoTK, cusDTO.TenNganHang, cusDTO.Active, cusDTO.MaKV, cusDTO.MaKH);

            int check = ConnectionDB.ExcuteNonQuery(sql);
            return check;

            //ExecQuery
        }


        public int InsertKhachHang(CustomerDTO cusDTO)
        {
            string sql = string.Format("INSERT INTO KHACHHANG values('{0}', N'{1}', N'{2}',N'{3}', N'{4}'," +
                " N'{5}',N'{6}', N'{7}', N'{8}',N'{9}', N'{10}', N'{11}','{12}', N'{13}')", cusDTO.MaKH, cusDTO.TenKH, cusDTO.NguoiLienHe, cusDTO.DiaChi, cusDTO.DienThoai
                , cusDTO.DiDong, cusDTO.Fax, cusDTO.Email, cusDTO.Website, cusDTO.MaSoThue, cusDTO.SoTK, cusDTO.TenNganHang, cusDTO.Active, cusDTO.MaKV);
            int check = ConnectionDB.ExcuteNonQuery(sql);
            return check;
        }

        public int DeleteKhachHang(string Makh)
        {
            string sql = string.Format("Delete from KHACHHANG where MaKH = '{0}'", Makh);
            int check = ConnectionDB.ExcuteNonQuery(sql);
            return check;
        }


        public List<CustomerDTO> getDataCustomer(string makv)
        {
            string sql = string.Format("SELECT * FROM [KHACHHANG] where [MaKV] = '{0}'", makv);
            DataTable data = ConnectionDB.getData(sql);
            List<CustomerDTO> listCustomer = new List<CustomerDTO>();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                var customer = new CustomerDTO();
                customer.MaKH = data.Rows[i]["MaKH"].ToString();
                customer.TenKH = data.Rows[i]["TenKH"].ToString();
                customer.DiaChi = data.Rows[i]["DiaChi"].ToString();
                customer.NguoiLienHe = data.Rows[i]["NguoiLienHe"].ToString();
                customer.DiDong = data.Rows[i]["DiDong"].ToString();
                customer.Fax = data.Rows[i]["Fax"].ToString();
                customer.Email = data.Rows[i]["Email"].ToString();
                customer.Website = data.Rows[i]["Website"].ToString();
                customer.MaSoThue = data.Rows[i]["MaSoThue"].ToString();
                customer.DienThoai = data.Rows[i]["DienThoai"].ToString();
                listCustomer.Add(customer);
            }
            return listCustomer;
        }
    }
}
