using QLBH_ProductManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace QLBH_ProductManagement.DAO
{
    public class GoodDAO
    {

        public int checkMaHangTrongTonKho(string maHang)
        {
            string sql = string.Format("SELECT 1 FROM TONKHO where MaHang = '{0}' and Soluongton >= {1} ", maHang, 1);
            return Convert.ToInt32(ConnectionDB.ExcuteQuery(sql));
        }

        public string getTenDonVi(string maHang)
        {
            string tenDTV = "";
            string sql = "Select dv.Ten from DonViTinh dv, HANGHOA_DICHVU hh where dv.MaDVT = hh.MaDV";
            DataTable data = new DataTable();
            data = ConnectionDB.getData(sql);
            if(data.Rows.Count > 0)
            {
                tenDTV = data.Rows[0]["Ten"].ToString();
            }
            return tenDTV;
        }

       

        //public DataTable getChiTietHoaDonBan()
        //{
        //    string sql = string.Format("Select * from [CHITIETHOADONBAN]");
        //    DataTable data = ConnectionDB.getData(sql);
        //    return data;
        //}

        public DataTable getListGoods()  // dung bên các mặt hàng
        {

            string sql = "SELECT DISTINCT hh.MaHang, hh.TenHang, hh.GiaBanLe, hh.GiabanSi, hh.GiaMua ,  " +
                " dvt.Ten, hh.SoLuongToiThieu, hh.TinhChat, kh.TenKho, nh.TenNhom, hh.Active " +
                "FROM HANGHOA_DICHVU hh, TONKHO tk, DONVITINH dvt, KHOHANG kh, NHOMHANG nh " +
                "WHERE hh.MaDV = dvt.MaDVT and hh.MaKho = kh.MaKho and nh.MaNhom = hh.MaNhom";


            DataTable data = ConnectionDB.getData(sql);
            return data;
        }

        public DataTable getListGoodsDaoDich()  // dung bên các dao dich
        {

            string sql = "SELECT DISTINCT tk.MaHang, hh.TenHang, hh.GiaBanLe, hh.GiabanSi, hh.GiaMua , " +
                "kh.TenKho, tk.SoLuongTon FROM HANGHOA_DICHVU hh, TONKHO tk, KHOHANG kh " +
                " WHERE tk.MaKho = kh.MaKho and hh.mahang = tk.mahang";


            DataTable data = ConnectionDB.getData(sql);
            return data;
        }

        public DataTable getListGoodsDaoDichChuyenKho()  // dung bên các dao dich
        {
            string sql = "SELECT DISTINCT tk.MaHang , hh.TenHang, hh.GiaMua," +
                " kh.TenKho, tk.SoLuongTon  FROM HANGHOA_DICHVU hh, TONKHO tk, KHOHANG kh " +
                "WHERE tk.MaKho = kh.MaKho and hh.mahang = tk.mahang";
            DataTable data = ConnectionDB.getData(sql);
            return data;
        }

        public GoodDTO getInforGoods(string maHang)
        {
            GoodDTO goodDTO = new GoodDTO();
            string sql = string.Format("SELECT hh.MaHang, hh.TenHang, hh.GiaBanLe, hh.GiabanSi, hh.GiaMua ,  " +
                " dvt.Ten, tk.SoLuongToiThieu, hh.TinhChat, kh.TenKho, nh.TenNhom, hh.Active " +
                "FROM HANGHOA_DICHVU hh, TONKHO tk, DONVITINH dvt, KHOHANG kh, NHOMHANG nh " +
                "WHERE hh.MaDV = dvt.MaDVT and tk.mahang = hh.MaHang and hh.MaKho = kh.MaKho and nh.MaNhom = hh.MaNhom and hh.MaHang = '{0}'", maHang);

            DataTable data = ConnectionDB.getData(sql);
           if(data.Rows.Count > 0)
            {
                goodDTO.MaHang = data.Rows[0]["MaHang"].ToString();
                goodDTO.TenHang = data.Rows[0]["TenHang"].ToString();
                goodDTO.GiabanLe = float.Parse(data.Rows[0]["GiaBanLe"].ToString());
                goodDTO.GiaBanSi = float.Parse(data.Rows[0]["GiabanSi"].ToString());
                goodDTO.GiaMua = float.Parse(data.Rows[0]["GiaMua"].ToString());
                goodDTO.TenKho = data.Rows[0]["TenKho"].ToString();
                goodDTO.SoLuongToiThieu = int.Parse(data.Rows[0]["SoLuongToiThieu"].ToString());
                goodDTO.TinhChat = data.Rows[0]["TinhChat"].ToString();
                goodDTO.TenDV = data.Rows[0]["Ten"].ToString();
                goodDTO.TenNhom = data.Rows[0]["TenNhom"].ToString();
                goodDTO.Active = bool.Parse(data.Rows[0]["Active"].ToString());
            }
            return goodDTO;
        }

        public List<GoodDTO> getListGoodFromIDGroup(string maNhom)
        {
            string sql = string.Format("Select * from [HANGHOA_DICHVU] where MaNhom = '{0}'", maNhom);

            DataTable data = ConnectionDB.getData(sql);
            List<GoodDTO> ListGood = new List<GoodDTO>();
            foreach (DataRow row in data.Rows)
            {
                GoodDTO good = new GoodDTO();
                good.MaHang = row["MaHang"].ToString();
                good.TenHang = row["TenHang"].ToString();
                good.MaDonVi = row["MaDV"].ToString();
                good.GiaMua = float.Parse(row["GiaMua"].ToString());
                good.GiabanLe = float.Parse(row["GiaBanLe"].ToString());
                good.GiaBanSi = float.Parse(row["GiaBanSi"].ToString());
               
                good.TinhChat = row["TinhChat"].ToString();
                good.MaKho = row["MaKho"].ToString();
                good.Active = bool.Parse(row["Active"].ToString());
                ListGood.Add(good);
                
            }
            return ListGood;
        }
        public string IDAuto()
        {
            return Convert.ToString(ConnectionDB.ExecScalar("select dbo.SetAutoIdHangHoa()"));
        }
        //public GoodDTO getInforGoodsFromMaHang(string mahang)
        //{
        //    string sql = string.Format("SELECT * FROM [HANGHOA_DICHVU] where [MaHang] = '{0}'", mahang);
        //    DataTable data = ConnectionDB.getData(sql);
        //    GoodDTO goodDTO = new GoodDTO();

        //    if (data.Rows.Count > 0)
        //    {
        //        goodDTO.MaHang = data.Rows[0]["MaHang"].ToString();
        //        goodDTO.TenHang = data.Rows[0]["TenHang"].ToString();
        //        goodDTO.MaDonVi = data.Rows[0]["MaDV"].ToString();
        //        goodDTO.GiaMua = float.Parse(data.Rows[0]["GiaMua"].ToString());
        //        goodDTO.GiaBanSi = float.Parse(data.Rows[0]["GiabanSi"].ToString());
        //        goodDTO.GiabanLe = float.Parse(data.Rows[0]["GiaBanLe"].ToString());
              

        //        //goodDTO.TinhChat = "Hàng hóa";
        //        goodDTO.MaKho = data.Rows[0]["MaKho"].ToString();
        //        goodDTO.MaNhom = data.Rows[0]["MaNhom"].ToString();
        //        goodDTO.MaNCC = data.Rows[0]["MaNCC"].ToString();
        //        goodDTO.Active = bool.Parse(data.Rows[0]["Active"].ToString());
        //    }
        //    return goodDTO;
        //}
        public int InsertGood(GoodDTO goodDTO)
        {
            string sql = string.Format("INSERT INTO HANGHOA_DICHVU (MaHang, TenHang, MaDV, GiaMua, " +
                "  GiabanLe, GiaBanSi, TinhChat, MaKho, Active, MaNhom, MaNCC, SoLuongToiThieu) values('{0}', N'{1}', '{2}', {3}, {4}," +
               " {5}, N'{6}', N'{7}', '{8}', N'{9}', '{10}', {11})", goodDTO.MaHang, goodDTO.TenHang, goodDTO.MaDonVi, goodDTO.GiaMua, 
               goodDTO.GiabanLe, goodDTO.GiaBanSi, goodDTO.TinhChat, goodDTO.MaKho, goodDTO.Active, goodDTO.MaNhom, goodDTO.MaNCC, goodDTO.SoLuongToiThieu);

            int check = ConnectionDB.ExcuteNonQuery(sql);
            return check;
        }

        public int updateGoods(GoodDTO g)
        {
            string sql = string.Format(" update [HANGHOA_DICHVU] " +
                        " set TenHang = N'{0}', MaDV = N'{1}', GiaMua = {2}, GiaBanSi = {3}, GiaBanLe = {4}, " +
                        "     SoLuongToiThieu = {5}, MaKho = N'{6}', Active =  '{7}', MaNhom = '{8}', MaNCC = '{9}', TinhChat = N'{10}' " +
                        " where MaHang = N'{11}' ", g.TenHang, g.MaDonVi, g.GiaMua, g.GiaBanSi, g.GiabanLe, g.SoLuongToiThieu,
                        g.MaKho, g.Active, g.MaNhom, g.MaNCC, g.TinhChat,  g.MaHang);

            return ConnectionDB.ExcuteNonQuery(sql);
        }

        public int DeleteGood(string mahang)
        {
            string sql = string.Format("Delete from HANGHOA_DICHVU where MaHang = '{0}'", mahang);
            int check = ConnectionDB.ExcuteNonQuery(sql);
            return check;
        }
    }
}
