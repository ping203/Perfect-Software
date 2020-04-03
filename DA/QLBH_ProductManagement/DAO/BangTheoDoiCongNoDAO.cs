using QLBH_ProductManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_ProductManagement.DAO
{
    public class BangTheoDoiCongNoDAO
    {


        /// Hàm theo dõi công nơ cho phần buy:
        /// 

        public List<BangTheoDoiCongNo> getListBangTheoDoiCongNoBuy(DateTime a, DateTime b, int check)
        {

            List<string> listMaNCC = getMaNCCBuy();

            List<BangTheoDoiCongNo> listBangCongNoTheoNhomNCC = new List<BangTheoDoiCongNo>();

            foreach (string maNCC in listMaNCC)
            {
                List<BangTheoDoiCongNo> listBangCongNoCuaNCC;
               if (check == 0)
                {
                    listBangCongNoCuaNCC = getListBangTheoDoiTheoNhomNCC(maNCC, a, b, 0);
                }
               else
                {
                    listBangCongNoCuaNCC = getListBangTheoDoiTheoNhomNCC(maNCC, a, b, 1);
                }
                foreach (BangTheoDoiCongNo x in listBangCongNoCuaNCC)
                {
                    listBangCongNoTheoNhomNCC.Add(x);
                }
            }
            return listBangCongNoTheoNhomNCC;
        }


        public List<string> getMaNCCBuy()
        {
            string sql = "SELECT DISTINCT MaNCC FROM THONGTIN_PHIEUNHAPHANG";
            DataTable dataMANCC = ConnectionDB.getData(sql);
            List<string> listMaNCC = new List<string>();

            foreach (DataRow dataRow in dataMANCC.Rows)
            {
                listMaNCC.Add(dataRow["MaNCC"].ToString());
            }
            return listMaNCC;
        }

        public List<BangTheoDoiCongNo> getListBangTheoDoiTheoNhomNCC(string maNCC, DateTime a, DateTime b, int check)
        {
            string sql;
            if(check == 0)
            {
                sql = string.Format("SELECT  MaPhieu, MaNCC, TenNCC, NgayLap, TongTienTra, Ma_DieuKhoan FROM THONGTIN_PHIEUNHAPHANG WHERE MaNCC = '{0}'", maNCC);
            }
            else
            {
                 sql = string.Format("SELECT  MaPhieu, MaNCC, TenNCC, NgayLap, TongTienTra, Ma_DieuKhoan FROM THONGTIN_PHIEUNHAPHANG WHERE MaNCC = '{0}' and NgayLap between '{1}' and '{2}'", maNCC, a, b);
            }
           
            DataTable data = ConnectionDB.getData(sql);

            float DauKy = 0;
            float ConLai = 0;
            List<BangTheoDoiCongNo> ListBangTheoDoiCongNoBuy = new List<BangTheoDoiCongNo>();
            if (data.Rows.Count > 0)
            {
                foreach (DataRow dataRow in data.Rows)
                {

                    BangTheoDoiCongNo theoDoi = new BangTheoDoiCongNo();
                    // nếu mà điều khoản = 2: Trả ngay: thì nợ = thu
                    // Do không có nhập số dư đầu kỳ nên đầu kỳ của Phiếu bán đầu tiên  của khác hàng = 0

                    // cột nợ là số tiền nhận thu được khi bán
                    theoDoi.MaPhieu = dataRow["MaPhieu"].ToString();
                    theoDoi.MaKH = dataRow["MaNCC"].ToString();
                    theoDoi.TenKH = dataRow["TenNCC"].ToString();
                    theoDoi.NgayLap = DateTime.Parse(dataRow["NgayLap"].ToString());
                    theoDoi.TongTienNhan = float.Parse(dataRow["TongTienTra"].ToString());
                    int Ma_Dk = int.Parse(dataRow["Ma_DieuKhoan"].ToString());

                    theoDoi.No = float.Parse(dataRow["TongTienTra"].ToString());
                    if (Ma_Dk == 2)  // Trả ngay
                    {
                        theoDoi.Thu = theoDoi.No;
                        theoDoi.DauKy = ConLai;
                        theoDoi.ConLai = ConLai;
                    }
                    if (Ma_Dk == 1) // công nợ
                    {
                        theoDoi.Thu = 0;
                        DauKy = ConLai;
                        theoDoi.DauKy = DauKy;
                        ConLai = DauKy + theoDoi.No;
                        theoDoi.ConLai = ConLai;
                    }
                    ListBangTheoDoiCongNoBuy.Add(theoDoi);
                }
            }
            return ListBangTheoDoiCongNoBuy;

        }


        /// <summary>
        ///    Hàm ccoong nợ cho phần sell
        /// </summary>
        /// <returns></returns>
        public List<BangTheoDoiCongNo> getListBangTheoDoiCongNo(DateTime a, DateTime b, int check)
        {

            List<string> listMAKH = getMaKH();

            List<BangTheoDoiCongNo> listBangCongNoTheoNhomKhachHang = new List<BangTheoDoiCongNo>();
            DateTime c = DateTime.Parse(DateTime.Now.ToString("M/d/yyyy"));
            foreach (string maKH in listMAKH)
            {
                List<BangTheoDoiCongNo> listBangCongNoCuaNhom;
                if (check == 0)
                {
                    listBangCongNoCuaNhom = getListBangTheoDoiTheoNhomKH(maKH, c, c, 0);  // xem như đây là câu SQL
                }
                else
                {
                    listBangCongNoCuaNhom = getListBangTheoDoiTheoNhomKH(maKH, a, b, 1);
                }
               
                foreach(BangTheoDoiCongNo x in listBangCongNoCuaNhom)
                {
                    listBangCongNoTheoNhomKhachHang.Add(x);
                }
            }
            return listBangCongNoTheoNhomKhachHang;
        }

        public List<string> getMaKH()
        {
            string sql = "SELECT DISTINCT MaKH FROM THONGTIN_PHIEU_BANHANG";
            DataTable dataMAKH = ConnectionDB.getData(sql);
            List<string> listMAKH = new List<string>();

            foreach (DataRow dataRow in dataMAKH.Rows)
            {
                listMAKH.Add(dataRow["MaKH"].ToString());
            }
            return listMAKH;
        }

        public List<BangTheoDoiCongNo> getListBangTheoDoiTheoNhomKH(string maKH, DateTime a, DateTime b, int check)
        {
            string sql;
            if(check == 0)
            {
                 sql = string.Format("SELECT  MaPhieu, Makh, TenKH, NgayLap, TongTienNhan, Ma_DieuKhoan FROM THONGTIN_PHIEU_BANHANG WHERE MAKH = '{0}'", maKH);
            }
            else
            {
                 sql = string.Format("SELECT  MaPhieu, Makh, TenKH, NgayLap, TongTienNhan, Ma_DieuKhoan FROM THONGTIN_PHIEU_BANHANG WHERE MAKH = '{0}' and NgayLap between '{1}' and '{2}'", maKH, a, b);
            }
            DataTable data = ConnectionDB.getData(sql);

            float DauKy = 0;
            float ConLai = 0;
            List<BangTheoDoiCongNo> ListBangTheoDoi = new List<BangTheoDoiCongNo>();
            if (data.Rows.Count > 0)
            {
                foreach(DataRow dataRow in data.Rows)
                {
                  
                    BangTheoDoiCongNo theoDoi = new BangTheoDoiCongNo();
                    // nếu mà điều khoản = 2: Trả ngay: thì nợ = thu
                    // Do không có nhập số dư đầu kỳ nên đầu kỳ của Phiếu bán đầu tiên  của khác hàng = 0

                    // cột nợ là số tiền nhận thu được khi bán
                    theoDoi.MaPhieu = dataRow["MaPhieu"].ToString();
                    theoDoi.MaKH = dataRow["Makh"].ToString();
                    theoDoi.TenKH = dataRow["TenKH"].ToString();
                    theoDoi.NgayLap = DateTime.Parse(dataRow["NgayLap"].ToString());
                    theoDoi.TongTienNhan = float.Parse(dataRow["TongTienNhan"].ToString());
                    int Ma_Dk = int.Parse(dataRow["Ma_DieuKhoan"].ToString());
                    
                    theoDoi.No = float.Parse(dataRow["TongTienNhan"].ToString());
                    if(Ma_Dk == 2)  // Trả ngay
                    {
                        theoDoi.Thu = theoDoi.No;
                        theoDoi.DauKy = ConLai;
                        theoDoi.ConLai = ConLai;
                    }
                    if(Ma_Dk == 1) // công nợ
                    {
                        theoDoi.Thu = 0;
                        DauKy = ConLai;
                        theoDoi.DauKy = DauKy;
                        ConLai = DauKy + theoDoi.No;
                        theoDoi.ConLai = ConLai;
                    }
                    ListBangTheoDoi.Add(theoDoi);
                }
            }
            return ListBangTheoDoi;

        }

        public List<CustomerDTO> getKhachHangMua()
        {
            string sql = "SELECT DISTINCT MaKH, TenKH FROM THONGTIN_PHIEU_BANHANG";
            DataTable data = ConnectionDB.getData(sql);
            List<CustomerDTO> listCustomerDTO = new List<CustomerDTO>();
            if(data.Rows.Count > 0)
            {
                CustomerDTO x = new CustomerDTO();
                x.MaKH = "All";
                x.TenKH = "Tất Cả";
                listCustomerDTO.Add(x);
                foreach (DataRow dataRow in data.Rows)
                {
                    CustomerDTO y = new CustomerDTO();
                    y.MaKH = dataRow["MaKH"].ToString();
                    y.TenKH = dataRow["TenKH"].ToString();
                    listCustomerDTO.Add(y);
                }
            }
            return listCustomerDTO;
        }

        public DataTable getKhachHangMuaDatatable()
        {
            string sql = "SELECT DISTINCT MaKH, TenKH FROM THONGTIN_PHIEU_BANHANG";
            DataTable data = ConnectionDB.getData(sql);
            return data;
        }

        //// Hàm tổng họp công nợ cho Buy:

        public float getTongCongNoCuaNCC(string Mancc, int maDK)
        {
            float congNo = 0;
            string sql = string.Format("SELECT TONGTIENTRA FROM THONGTIN_PHIEUNHAPHANG WHERE MaNCC = '{0}' AND MA_DieuKhoan = {1}", Mancc, maDK);
            DataTable data = ConnectionDB.getData(sql);
            if (data.Rows.Count > 0)
            {
                foreach (DataRow dataRow in data.Rows)
                {
                    congNo += float.Parse(dataRow["TONGTIENTRA"].ToString());
                }
            }
            return congNo;
        }

        public double getPhatSinhTrongKyNCC(string MaNCC)
        {
            double phatSinh = 0;
            string sql = string.Format("SELECT SUM(TONGTIENTRA) FROM THONGTIN_PHIEUNHAPHANG WHERE MaNCC = '{0}' ", MaNCC);
            phatSinh = Convert.ToDouble(ConnectionDB.ExcuteQuery(sql));
            return phatSinh;
        }

        public List<SupplierDTO> getListCongNoNCC()
        {
            string sql = "SELECT distinct tt.MaNCC, tt.TenNCC, kv.TenKV, cc.DiaChi" +
                " FROM THONGTIN_PHIEUNHAPHANG tt, KHUVUC kv, NCC cc " +
                "WHERE tt.MaNCC = cc.MaNCC and cc.MaKV = kv.MaKV";
            DataTable data = ConnectionDB.getData(sql);
            List<SupplierDTO> ListCongNoNCC = new List<SupplierDTO>();
            if (data.Rows.Count > 0)
            {
                foreach (DataRow dataRow in data.Rows)
                {
                    SupplierDTO x = new SupplierDTO();
                    x.TenNCC = dataRow["TenNCC"].ToString();
                    x.MaNCC = dataRow["MaNCC"].ToString();
                    x.KhuVuc = dataRow["TenKV"].ToString();
                    x.DiaChi = dataRow["DiaChi"].ToString();
                    x.SoDuDauKy = 0;

                    x.ChiTrongKy = getTongCongNoCuaNCC(x.MaNCC, 2);
                    x.PhatSinhTrongKy = (float)getPhatSinhTrongKyNCC(x.MaNCC);
                    x.SoDuCongNo = x.PhatSinhTrongKy - x.ChiTrongKy;
                    ListCongNoNCC.Add(x);
                }
            }
            return ListCongNoNCC;
        }




        /// <summary>
        ///   Haàm tổng hợp công nợ cho Sell
        /// </summary>
        /// <param name="maKH"></param>
        /// <param name="maDK"></param>
        /// <returns></returns>

        public float getTongCongNoCuaKhachHang(string maKH, int maDK)
        {
            float congNo = 0;
            string sql = string.Format("SELECT TONGTIENNHAN FROM THONGTIN_PHIEU_BANHANG WHERE MaKH = '{0}' AND MA_DieuKhoan = {1}", maKH, maDK);
            DataTable data = ConnectionDB.getData(sql);
            if(data.Rows.Count > 0)
            {
                foreach(DataRow dataRow in data.Rows)
                {
                    congNo += float.Parse(dataRow["TONGTIENNHAN"].ToString());
                }
            }
            return congNo;
        }

        public double getPhatSinhTrongKy(string maKH)
        {
            double phatSinh = 0;
            string sql = string.Format("SELECT SUM(TONGTIENNHAN) FROM THONGTIN_PHIEU_BANHANG WHERE MaKH = '{0}' ", maKH);
            phatSinh = Convert.ToDouble(ConnectionDB.ExcuteQuery(sql));
            return phatSinh;
        }

        public List<CustomerDTO > getListCongNoCuaKhachHang()
        {
            string sql = "SELECT distinct tt.MaKH, tt.TenKH, kv.TenKV, kh.DiaChi" +
                " FROM THONGTIN_PHIEU_BANHANG tt, KHUVUC kv, KHACHHANG kh " +
                "WHERE tt.MaKH = kh.MaKH and kh.MaKV = kv.MaKV";
            DataTable data = ConnectionDB.getData(sql);
            List<CustomerDTO> ListCongNoCuaKhachHang = new List<CustomerDTO>();
            if (data.Rows.Count > 0)
            {
                foreach(DataRow dataRow in data.Rows)
                {
                    CustomerDTO x = new CustomerDTO();
                    x.TenKH = dataRow["TenKH"].ToString();
                    x.MaKH = dataRow["MaKH"].ToString();
                    x.KhuVuc = dataRow["TenKV"].ToString();
                    x.DiaChi = dataRow["DiaChi"].ToString();
                    x.SoDuDauKy = 0;
                    
                    x.ThuTrongKy = getTongCongNoCuaKhachHang(x.MaKH, 2);
                    x.PhatSinhTrongKy = (float)getPhatSinhTrongKy(x.MaKH);
                    x.SoDuCongNo = x.PhatSinhTrongKy - x.ThuTrongKy;
                    ListCongNoCuaKhachHang.Add(x);
                }
            }
            return ListCongNoCuaKhachHang;
        }

    }
}
