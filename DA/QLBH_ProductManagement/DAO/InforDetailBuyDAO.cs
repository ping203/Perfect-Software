using QLBH_ProductManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_ProductManagement.DAO
{
    public class InforDetailBuyDAO
    {
        public int DeleteInforDetailBuy(string maPhieu)
        {
            string sql = string.Format("DELETE FROM THONGTIN_PHIEUNHAPHANG WHERE MaPhieu = '{0}' ", maPhieu);
            int check = ConnectionDB.ExcuteNonQuery(sql);
            return check;
        }

        public int UpdateInforBuy(InforDetailBuy Infordetail)
        {
            string sql = string.Format("UPDATE [THONGTIN_PHIEUNHAPHANG] SET " +
                " MaNCC = '{1}' , TenNCC =  N'{2}', DiaChi = N'{3}', SoHoaDonVAT = '{4}' ,MaKho = '{5}', NgayLap = '{6}', HanThanhToan = '{7}', Ma_DieuKhoan =  {8}, Ma_PhuongThuc = '{9}', MaNVLap = '{10}', CK = {11}, VAT = {12}, TongTienMua = {13}, TongTienTra = {14}, ischeck = {15} " +
                " WHERE MaPhieu = '{0}'", Infordetail.MaPhieu,
                Infordetail.MaNCC, Infordetail.TenNCC, Infordetail.DiaChi, Infordetail.SoHoaDonVAT, Infordetail.MaKhoNhap, 
                Infordetail.NgayLap, Infordetail.HanThanhToan, Infordetail.Ma_DieuKhoan, Infordetail.Ma_PhuongThuc, Infordetail.MaNVLap, Infordetail.CK, Infordetail.VAT, Infordetail.TongTienMua, Infordetail.TongTienTra, 1);
            int check = ConnectionDB.ExcuteNonQuery(sql);
            return check;
        }

        public int InsertDetailBuyGoods(InforDetailBuy Infordetail)
        {
            string sql = string.Format("INSERT INTO  [THONGTIN_PHIEUNHAPHANG](MaPhieu ," +
                " MaNCC, TenNCC, DiaChi, SoHoaDonVAT ,MaKho, NgayLap, HanThanhToan, Ma_DieuKhoan, Ma_PhuongThuc, MaNVLap, CK, VAT, TongTienMua, TongTienTra, ischeck) " +
                "VALUES ('{0}', '{1}', N'{2}',N'{3}', '{4}', '{5}', '{6}', '{7}', {8}, '{9}', '{10}', {11}, {12}, {13}, {14}, {15})", Infordetail.MaPhieu,
                Infordetail.MaNCC, Infordetail.TenNCC, Infordetail.DiaChi, Infordetail.SoHoaDonVAT, Infordetail.MaKhoNhap,
                Infordetail.NgayLap, Infordetail.HanThanhToan, Infordetail.Ma_DieuKhoan, Infordetail.Ma_PhuongThuc, Infordetail.MaNVLap, Infordetail.CK, Infordetail.VAT, Infordetail.TongTienMua, Infordetail.TongTienTra, 1);
            int check = ConnectionDB.ExcuteNonQuery(sql);
            return check;
        }

        public int UpdateTongTien(float tongTienMua, string maPhieu, float TongTienTra)
        {
            string sql = string.Format("UPDATE THONGTIN_PHIEUNHAPHANG SET TongTienMua = {0}, TongTienTra = {1} WHERE MaPhieu = '{2}'", tongTienMua, TongTienTra, maPhieu);
            int check = ConnectionDB.ExcuteNonQuery(sql);
            return check;
        }

        public DataTable getInforDetailBuy() 
        {
            string sql = "SELECT tt.MaPhieu, tt.NgayLap, tt.SoPhieuNhapTay, tt.SoHoaDonVAT, tt.TenNCC, tt.TongTienMua, tt.GhiChu, kh.TenKho, tt.VAT, tt.CK, tt.Tongtientra " +
                " FROM THONGTIN_PHIEUNHAPHANG tt, KHOHANG kh WHERE tt.MaKho = kh.MaKho";
            DataTable data = ConnectionDB.getData(sql);
            return data;

        }

        public InforDetailBuy getInforDetailBuyFromMa(string maPhieu)
        {
            string sql = string.Format("SELECT * FROM THONGTIN_PHIEUNHAPHANG WHERE MaPhieu = '{0}'", maPhieu);
            DataTable data = ConnectionDB.getData(sql);
            InforDetailBuy inforX = new InforDetailBuy();
            if(data.Rows.Count > 0)
            {
                inforX.MaPhieu = data.Rows[0]["MaPhieu"].ToString();
                inforX.MaNCC = data.Rows[0]["MaNCC"].ToString();
                inforX.TenNCC = data.Rows[0]["TenNCC"].ToString();
                inforX.MaKhoNhap = data.Rows[0]["MaKho"].ToString();
                inforX.Ma_DieuKhoan = int.Parse(data.Rows[0]["Ma_DieuKhoan"].ToString());
                inforX.Ma_PhuongThuc = data.Rows[0]["Ma_PhuongThuc"].ToString();
                inforX.NgayLap = DateTime.Parse(data.Rows[0]["NgayLap"].ToString());
                inforX.MaNVLap = data.Rows[0]["MaNVLap"].ToString();
            }
            return inforX;
        }

        public int checkMaPhieuMua(string maPhieu)
        {
            string sql = string.Format("SELECT 1 FROM THONGTIN_PHIEUNHAPHANG WHERE MaPhieu = '{0}'", maPhieu);
            return Convert.ToInt32(ConnectionDB.ExcuteQuery(sql));
        }

        public DataTable getDatatableInforDetailBuy(int check, DateTime a, DateTime b)
        {
            string sql;
            if(check == 0)
            {
                 sql = "SELECT tt.MaPhieu, tt.NgayLap, tt.Tongtientra " +
                " FROM THONGTIN_PHIEUNHAPHANG tt";
            }
            else
            {
                 sql = string.Format("SELECT tt.MaPhieu, tt.NgayLap, tt.Tongtientra " +
                 " FROM THONGTIN_PHIEUNHAPHANG tt WHERE tt.NgayLap between '{0}' and '{1}'", a, b);
            }

            DataTable data = ConnectionDB.getData(sql);
            return data;

        }

        public List<InforDetailBuy> getListInforDetailBuy(DateTime a, DateTime b, int check)
        {
            string sql;
            if(check == 1)
            {
                sql = string.Format("SELECT tt.MaPhieu, tt.NgayLap, tt.SoPhieuNhapTay, tt.SoHoaDonVAT, tt.MaNCC, tt.TenNCC, tt.TongTienMua, " +
            "tt.GhiChu, kh.TenKho, tt.VAT, tt.CK, tt.Tongtientra " +
            " FROM THONGTIN_PHIEUNHAPHANG tt, KHOHANG kh WHERE tt.MaKho = kh.MaKho and tt.NgayLap Between '{0}' and '{1}'  ", a, b);
            }
            else
            {
                sql = "SELECT tt.MaPhieu, tt.NgayLap, tt.SoPhieuNhapTay, tt.SoHoaDonVAT, tt.MaNCC, tt.TenNCC, tt.TongTienMua, " +
               "tt.GhiChu, kh.TenKho, tt.VAT, tt.CK, tt.Tongtientra " +
               " FROM THONGTIN_PHIEUNHAPHANG tt, KHOHANG kh WHERE tt.MaKho = kh.MaKho";
            }
            
            DataTable data = ConnectionDB.getData(sql);
            List<InforDetailBuy> listInfor = new List<InforDetailBuy>();

            foreach(DataRow dataRow in data.Rows)
            {
                InforDetailBuy inforBuy = new InforDetailBuy();
                inforBuy.MaPhieu = dataRow["MaPhieu"].ToString();
                inforBuy.NgayLap = DateTime.Parse(dataRow["NgayLap"].ToString());
                inforBuy.SoPhieuNhapTay = dataRow["SoPhieuNhapTay"].ToString();
                inforBuy.SoHoaDonVAT = dataRow["SoHoaDonVAT"].ToString();
                inforBuy.TenNCC = dataRow["TenNCC"].ToString();
                inforBuy.MaNCC = dataRow["MaNCC"].ToString();
                if (dataRow["TongTienMua"].ToString() != null)
                {
                    inforBuy.TongTienMua = float.Parse(dataRow["TongTienMua"].ToString());
                }
                else
                {
                    inforBuy.TongTienMua = 0;
                }
               
                inforBuy.ghiChu = dataRow["GhiChu"].ToString();
                inforBuy.TenKho = dataRow["TenKho"].ToString();
                inforBuy.VAT = float.Parse(dataRow["VAT"].ToString());
                inforBuy.CK = float.Parse(dataRow["CK"].ToString());
                inforBuy.TongTienTra = float.Parse(dataRow["Tongtientra"].ToString());
                listInfor.Add(inforBuy);
            }
            return listInfor;
        }


        public List<InforDetailBuy> getListInforDetailBuyFormMaNCC(DateTime a, DateTime b, string maNCC)
        {
            string sql;
     
             sql = string.Format("SELECT tt.MaPhieu, tt.NgayLap, tt.SoPhieuNhapTay, tt.SoHoaDonVAT, tt.MaNCC, tt.TenNCC, tt.TongTienMua, " +
            "tt.GhiChu, kh.TenKho, tt.VAT, tt.CK, tt.Tongtientra " +
            " FROM THONGTIN_PHIEUNHAPHANG tt, KHOHANG kh WHERE tt.MaKho = kh.MaKho and tt.NgayLap Between '{0}' and '{1}' and tt.MaNCC = '{2}' ", a, b, maNCC);

          
            DataTable data = ConnectionDB.getData(sql);
            List<InforDetailBuy> listInfor = new List<InforDetailBuy>();

            foreach (DataRow dataRow in data.Rows)
            {
                InforDetailBuy inforBuy = new InforDetailBuy();
                inforBuy.MaPhieu = dataRow["MaPhieu"].ToString();
                inforBuy.NgayLap = DateTime.Parse(dataRow["NgayLap"].ToString());
                inforBuy.SoPhieuNhapTay = dataRow["SoPhieuNhapTay"].ToString();
                inforBuy.SoHoaDonVAT = dataRow["SoHoaDonVAT"].ToString();
                inforBuy.TenNCC = dataRow["TenNCC"].ToString();
                inforBuy.MaNCC = dataRow["MaNCC"].ToString();
                if (dataRow["TongTienMua"].ToString() != null)
                {
                    inforBuy.TongTienMua = float.Parse(dataRow["TongTienMua"].ToString());
                }
                else
                {
                    inforBuy.TongTienMua = 0;
                }

                inforBuy.ghiChu = dataRow["GhiChu"].ToString();
                inforBuy.TenKho = dataRow["TenKho"].ToString();
                inforBuy.VAT = float.Parse(dataRow["VAT"].ToString());
                inforBuy.CK = float.Parse(dataRow["CK"].ToString());
                inforBuy.TongTienTra = float.Parse(dataRow["Tongtientra"].ToString());
                listInfor.Add(inforBuy);
            }
            return listInfor;
        }

        public List<InforDetailBuy> getListInforDetailBuyConNo()
        {
            string sql = string.Format("SELECT distinct tt.MaPhieu, tt.NgayLap, tt.MaNCC, tt.TenNCC,  " +
                "tt.GhiChu, tt.Tongtientra " +
                " FROM THONGTIN_PHIEUNHAPHANG tt, KHOHANG kh WHERE tt.Ma_DieuKhoan = '{0}' and tt.Ischeck = {1}", 1, 1);
            DataTable data = ConnectionDB.getData(sql);
            List<InforDetailBuy> listInfor = new List<InforDetailBuy>();

            foreach (DataRow dataRow in data.Rows)
            {
                InforDetailBuy inforBuy = new InforDetailBuy();
                inforBuy.MaPhieu = dataRow["MaPhieu"].ToString();
                inforBuy.NgayLap = DateTime.Parse(dataRow["NgayLap"].ToString());

                inforBuy.TenNCC = dataRow["TenNCC"].ToString();
                inforBuy.MaNCC = dataRow["MaNCC"].ToString();
              
                inforBuy.ghiChu = dataRow["GhiChu"].ToString();

                inforBuy.TongTienTra = float.Parse(dataRow["Tongtientra"].ToString());
                listInfor.Add(inforBuy);
            }
            return listInfor;
        }

        public List<InforDetailBuy> getListInforDetailBuyConNoFromNgay(DateTime a, DateTime b)
        {
            string sql = string.Format("SELECT distinct tt.MaPhieu, tt.NgayLap, tt.MaNCC, tt.TenNCC,  " +
                "tt.GhiChu, tt.Tongtientra " +
                " FROM THONGTIN_PHIEUNHAPHANG tt, KHOHANG kh WHERE tt.Ma_DieuKhoan = '{0}' and tt.Ischeck = {1} and tt.NgayLap between '{2}' and '{3}'", 1, 1, a, b);
            DataTable data = ConnectionDB.getData(sql);
            List<InforDetailBuy> listInfor = new List<InforDetailBuy>();

            foreach (DataRow dataRow in data.Rows)
            {
                InforDetailBuy inforBuy = new InforDetailBuy();
                inforBuy.MaPhieu = dataRow["MaPhieu"].ToString();
                inforBuy.NgayLap = DateTime.Parse(dataRow["NgayLap"].ToString());

                inforBuy.TenNCC = dataRow["TenNCC"].ToString();
                inforBuy.MaNCC = dataRow["MaNCC"].ToString();

                inforBuy.ghiChu = dataRow["GhiChu"].ToString();

                inforBuy.TongTienTra = float.Parse(dataRow["Tongtientra"].ToString());
                listInfor.Add(inforBuy);
            }
            return listInfor;
        }


        public string IDAuto()
        {
            return Convert.ToString(ConnectionDB.ExecScalar("select dbo.SetAutoIdThongTin_PhieuNhapHang()"));
        }

        public DataTable getListMuaTraNgay(DateTime a, DateTime b, int check)
        {
            string sql;
            if(check == 0)
            {
                 sql = string.Format("SELECT tt.MaPhieu, tt.NgayLap, dk.TenDK,tt.MaNCC, tt.TenNCC, cc.DiaChi, TongTienTra, tt.ISCHECK " +
                "FROM THONGTIN_PHIEUNHAPHANG tt,DIEUKHOAN_THANHOAN dk, NCC cc " +
                " WHERE tt.Ma_DieuKhoan = dk.ID and cc.MaNCC = tt.MaNCC and dk.ID = {0} ", 2);
            }
            else
            {
                 sql = string.Format("SELECT tt.MaPhieu, tt.NgayLap, dk.TenDK,tt.MaNCC, tt.TenNCC, cc.DiaChi, TongTienTra, tt.ISCHECK " +
                  "FROM THONGTIN_PHIEUNHAPHANG tt,DIEUKHOAN_THANHOAN dk, NCC cc " +
                  " WHERE tt.Ma_DieuKhoan = dk.ID and cc.MaNCC = tt.MaNCC and dk.ID = {0} and tt.NgayLap Between '{1}' and '{2}' ", 2, a, b);
            }

            return ConnectionDB.getData(sql);
        }

        public int checkMaChungTuInPhieuChi(string maChungTu)
        {
            string sql = string.Format("SELECT 1 FROM [BANGKE_PHIEUCHITIEN] WHERE MAPHIEUCHI = '{0}'", maChungTu);
            return Convert.ToInt32(ConnectionDB.ExcuteQuery(sql));
        }

        public int UpdateIsCheck(string maPhieu, int isCheck)
        {
            string sql = string.Format("UPDATE [THONGTIN_PHIEUNHAPHANG] SET IsCheck = {0} WHERE MaPhieu = '{1}' ", isCheck, maPhieu);
            int check = ConnectionDB.ExcuteNonQuery(sql);
            return check;
        }

    }
}
