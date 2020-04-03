using QLBH_ProductManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_ProductManagement.DAO
{
    public class InforDetailSellDAO
    {
        public int InsertDetailSellGoods(InforDetailSell Infordetail)
        {
            string sql = string.Format("INSERT INTO [THONGTIN_PHIEU_BANHANG](MaPhieu ," +
                " MaKH, TenKH, DiaChi, SoHoaDonVAT ,MaKho, NgayLap, HanThanhToan, Ma_DieuKhoan, Ma_PhuongThuc, MaNVLap, CK, GhiChu, TongTienBan, TongTienNhan, VAT, IsCheck) " +
                "VALUES ('{0}', '{1}', N'{2}',N'{3}', '{4}', '{5}', '{6}', '{7}', {8}, '{9}', '{10}', {11}, N'{12}', {13}, {14}, {15}, {16})", Infordetail.MaPhieu,
                Infordetail.MaKH, Infordetail.TenKH, Infordetail.DiaChi, Infordetail.SoHoaDonVAT, Infordetail.MaKho,
                Infordetail.NgayLap, Infordetail.HanThanhToan, Infordetail.Ma_DieuKhoan, Infordetail.Ma_PhuongThuc, Infordetail.MaNVLap, Infordetail.CK, Infordetail.GhiChu, Infordetail.TongTienBan, Infordetail.TongTienNhan, Infordetail.VAT, 1);
            int check = ConnectionDB.ExcuteNonQuery(sql);
            return check;
        }

        public int checkMaPhieuBan(string maPhieu)
        {
            string sql = string.Format("SELECT 1 FROM THONGTIN_PHIEU_BANHANG WHERE MaPhieu = '{0}'", maPhieu);
            return Convert.ToInt32(ConnectionDB.ExcuteQuery(sql));
        }

        public int UpdateInforSell(InforDetailSell Infordetail)
        {
            string sql = string.Format("UPDATE [THONGTIN_PHIEU_BANHANG] SET " +
                " MaKH = '{1}' , TenKH =  N'{2}', DiaChi = N'{3}', SoHoaDonVAT = '{4}' ,MaKho = '{5}', NgayLap = '{6}', HanThanhToan = '{7}', Ma_DieuKhoan =  {8}, Ma_PhuongThuc = '{9}', MaNVLap = '{10}', CK = {11}, VAT = {12}, TongTienBan = {13}, TongTienNhan = {14}, ischeck = {15} " +
                " WHERE MaPhieu = '{0}'", Infordetail.MaPhieu,
                Infordetail.MaKH, Infordetail.TenKH, Infordetail.DiaChi, Infordetail.SoHoaDonVAT, Infordetail.MaKho,
                Infordetail.NgayLap, Infordetail.HanThanhToan, Infordetail.Ma_DieuKhoan, Infordetail.Ma_PhuongThuc, Infordetail.MaNVLap, Infordetail.CK, Infordetail.VAT, Infordetail.TongTienBan, Infordetail.TongTienNhan, 1);
            int check = ConnectionDB.ExcuteNonQuery(sql);
            return check;
        }

        public int UpdateTien(string maPhieu, float thanhTien, float thanhToan)
        {

            string sql = string.Format("UPDATE THONGTIN_PHIEU_BANHANG SET Tongtienban = {0}, TongTienNhan = {1} WHERE MaPhieu = '{2}'", thanhTien, thanhToan, maPhieu);
            return ConnectionDB.ExcuteNonQuery(sql);
        }

        public int DeleteInforDetailSell(string maPhieu)
        {
            string sql = string.Format("Delete from [THONGTIN_PHIEU_BANHANG] WHERE MaPhieu = '{0}' ", maPhieu);
            int check = ConnectionDB.ExcuteNonQuery(sql);
            return check;
        }

        public int UpdateIsCheck(string maPhieu, int isCheck)
        {
            string sql = string.Format("UPDATE [THONGTIN_PHIEU_BANHANG] SET IsCheck = {0} WHERE MaPhieu = '{1}' ", isCheck, maPhieu);
            int check = ConnectionDB.ExcuteNonQuery(sql);
            return check;
        }

        public string IDAuto()
        {
            return Convert.ToString(ConnectionDB.ExecScalar("select dbo.SetAutoIdThongTin_PhieuBanHang()"));
        }

        public DataTable getListThanhToanNgay(DateTime a, DateTime b, int check)
        {
            string sql;
            if(check == 0)
            {
                 sql = string.Format("SELECT tt.MaPhieu, tt.NgayLap, dk.TenDK, tt.MaKH, tt.TenKH, kh.DiaChi, tt.TongTienNhan, tt.ischeck " +
                 "FROM THONGTIN_PHIEU_BANHANG tt, DIEUKHOAN_THANHOAN dk, KHACHHANG kh " +
                 "WHERE tt.Ma_DieuKhoan = dk.ID and kh.MaKH = tt.MaKH and tt.Ma_DieuKhoan = {0} ", 2);
            }
            else
            {
                 sql = string.Format("SELECT tt.MaPhieu, tt.NgayLap, dk.TenDK, tt.MaKH, tt.TenKH, kh.DiaChi, tt.TongTienNhan, tt.ischeck " +
                 "FROM THONGTIN_PHIEU_BANHANG tt, DIEUKHOAN_THANHOAN dk, KHACHHANG kh " +
                 "WHERE tt.Ma_DieuKhoan = dk.ID and kh.MaKH = tt.MaKH and tt.Ma_DieuKhoan = {0} and tt.NgayLap between '{1}' and '{2}' ", 2, a, b);
            }

            return ConnectionDB.getData(sql);
        }

        public List<InforDetailSell> getListThanhToanCongNo(DateTime a, DateTime b, int check)
        {
            string sql;
            if(check == 0)
            {
                 sql = string.Format("SELECT MaPhieu, NgayLap, MaKH, TenKH, TongTienNhan, GhiChu " +
                 "FROM THONGTIN_PHIEU_BANHANG where Ma_DieuKhoan = {0} and isCheck = {1}", 1, 1);
            }
            else
            {
                sql = string.Format("SELECT MaPhieu, NgayLap, MaKH, TenKH, TongTienNhan, GhiChu " +
                "FROM THONGTIN_PHIEU_BANHANG where Ma_DieuKhoan = {0} and isCheck = {1}  and tt.NgayLap Between '{2}' and '{3}'", 1, 1, a, b);
            }

            DataTable data = ConnectionDB.getData(sql);
            List<InforDetailSell> listInforSell = new List<InforDetailSell>();
            if(data.Rows.Count > 0)
            {
                foreach(DataRow dataRow in data.Rows)
                {
                    InforDetailSell inforSell = new InforDetailSell();
                    inforSell.MaPhieu = dataRow["MaPhieu"].ToString();
                    inforSell.NgayLap = DateTime.Parse(dataRow["NgayLap"].ToString());
                    inforSell.MaKH = dataRow["MaKH"].ToString();
                    inforSell.TenKH = dataRow["TenKH"].ToString();
                    inforSell.TongTienNhan = float.Parse(dataRow["TongTienNhan"].ToString());
                    inforSell.GhiChu = dataRow["GhiChu"].ToString();
                    listInforSell.Add(inforSell);

                }
            }
            return listInforSell;
        }

        public int checkMaChungTuInPhieuThu(string maChungTu)
        {
            string sql = string.Format("SELECT 1 FROM BANGKE_PHIEUTHUTIEN WHERE MAPHIEUXUAT = '{0}'", maChungTu);
            return Convert.ToInt32(ConnectionDB.ExcuteQuery(sql));
        }
        public DataTable getInforDetailSell(int check, DateTime a, DateTime b)
        {
            string sql;
            if(check == 0)
            {
                sql = "SELECT tt.MaPhieu, tt.NgayLap, tt.TongtienNhan " +
                " FROM THONGTIN_PHIEU_BANHANG tt";
            }
            else
            {
                sql = string.Format("SELECT tt.MaPhieu, tt.NgayLap, tt.TongtienNhan " +
                " FROM THONGTIN_PHIEU_BANHANG tt where tt.NgayLap between '{0}' and '{1}'", a, b);
            }
             
            DataTable data = ConnectionDB.getData(sql);
            return data;

        }

        public InforDetailSell getInforDetailSellFromMa(string maPhieu)
        {
            string sql = string.Format("SELECT * FROM THONGTIN_PHIEU_BANHANG WHERE MaPhieu = '{0}'", maPhieu);
            DataTable data = ConnectionDB.getData(sql);
            InforDetailSell inforX = new InforDetailSell();
            if (data.Rows.Count > 0)
            {
                inforX.MaPhieu = data.Rows[0]["MaPhieu"].ToString();
                inforX.MaKH = data.Rows[0]["MaKH"].ToString();
                inforX.TenKH = data.Rows[0]["TenKH"].ToString();
                inforX.MaKho = data.Rows[0]["MaKho"].ToString();
                inforX.Ma_DieuKhoan = int.Parse(data.Rows[0]["Ma_DieuKhoan"].ToString());
                inforX.Ma_PhuongThuc = data.Rows[0]["Ma_PhuongThuc"].ToString();
                inforX.NgayLap = DateTime.Parse(data.Rows[0]["NgayLap"].ToString());
                inforX.MaNVLap = data.Rows[0]["MaNVLap"].ToString();
            }
            return inforX;
        }

    }
}
