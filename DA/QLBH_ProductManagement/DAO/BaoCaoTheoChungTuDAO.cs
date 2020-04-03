using QLBH_ProductManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace QLBH_ProductManagement.DAO
{
    public class BaoCaoTheoChungTuDAO
    {

        public int checkTonTaiDate(DateTime a, List<DateTime> b)
        {
            for(int i = 0; i < b.Count; i++)
            {
                if (a == b[i]) // đã có trong list
                    return 1;
            }
            return 0;
        }

        public List<DateTime> getListDateMuaBan()
        {
            string sql = "SELECT distinct NgayLap FROM THONGTIN_PHIEU_BANHANG "; // lấy ra danh sách ngày bán
            DataTable dataBan = ConnectionDB.getData(sql);
            List<DateTime> listDateTimeMuaBan = new List<DateTime>();
            foreach(DataRow dataRow in dataBan.Rows)
            {
                listDateTimeMuaBan.Add(DateTime.Parse(dataRow["NgayLap"].ToString()));
            }

            string sql1 = "SELECT distinct NgayLap FROM THONGTIN_PHIEUNHAPHANG "; // lấy ra danh sách ngày bán
            DataTable dataMua = ConnectionDB.getData(sql1);
          
            foreach (DataRow dataRow in dataMua.Rows)
            {
                DateTime x = new DateTime();
                x = DateTime.Parse(dataRow["NgayLap"].ToString());
                if(checkTonTaiDate(x, listDateTimeMuaBan) == 0)
                {
                    listDateTimeMuaBan.Add(x);
                }
            }
            return listDateTimeMuaBan;
        }

        public List<DateTime> getListDateMuaBanFromDate(DateTime a, DateTime b)
        {
            string sql = string.Format("SELECT distinct NgayLap FROM THONGTIN_PHIEU_BANHANG WHERE NgayLap Between '{0}' and '{1}' ", a, b); // lấy ra danh sách ngày bán
            DataTable dataBan = ConnectionDB.getData(sql);
            List<DateTime> listDateTimeMuaBan = new List<DateTime>();
            foreach (DataRow dataRow in dataBan.Rows)
            {
                listDateTimeMuaBan.Add(DateTime.Parse(dataRow["NgayLap"].ToString()));
            }

            string sql1 = string.Format("SELECT distinct NgayLap FROM THONGTIN_PHIEUNHAPHANG WHERE NgayLap Between '{0}' and '{1}' ", a, b); // lấy ra danh sách ngày bán
            DataTable dataMua = ConnectionDB.getData(sql1);

            foreach (DataRow dataRow in dataMua.Rows)
            {
                DateTime x = new DateTime();
                x = DateTime.Parse(dataRow["NgayLap"].ToString());
                if (checkTonTaiDate(x, listDateTimeMuaBan) == 0)
                {
                    listDateTimeMuaBan.Add(x);
                }
            }
            return listDateTimeMuaBan;
        }

        public float sumTienMua(DateTime a)
        {
            string sql = string.Format("SELECT sum(TongTienTra)  " +
                "FROM THONGTIN_PHIEUNHAPHANG where NgayLap = '{0}' ", a);
            if(ConnectionDB.ExcuteQuery(sql).ToString() == "")
            {
                return 0;
            }
            return (float)Convert.ToDouble(ConnectionDB.ExcuteQuery(sql));
        }

        public float sumTienBan(DateTime a)
        {
            string sql = string.Format("SELECT sum(TongTienNhan)  " +
                "FROM THONGTIN_PHIEU_BANHANG where NgayLap = '{0}' ", a);
            if (ConnectionDB.ExcuteQuery(sql).ToString() == "")
            {
                return 0;
            }
            return (float)Convert.ToDouble(ConnectionDB.ExcuteQuery(sql));
        }

        public List<BaoCaoTheoChungTu> getListBaoCaoTheoNgay(int check, DateTime a, DateTime b)
        {
            List<DateTime> listDateMuaBan = new List<DateTime>();
            if (check == 0)
            {
                listDateMuaBan = getListDateMuaBan();
            }
            else
            {
                listDateMuaBan = getListDateMuaBanFromDate(a, b);
            }
            List<BaoCaoTheoChungTu> ListBaoCaoTheoNgay = new List<BaoCaoTheoChungTu>();

            for (int i = 0; i < listDateMuaBan.Count; i++)
            {
                BaoCaoTheoChungTu x = new BaoCaoTheoChungTu();
                x.NgayLap = listDateMuaBan[i].ToString();
                x.TongTienNhap = sumTienMua(listDateMuaBan[i]).ToString();
                x.TongTienXuat = sumTienBan(listDateMuaBan[i]).ToString();
                ListBaoCaoTheoNgay.Add(x);
            }
            return ListBaoCaoTheoNgay;
        }

        public List<BaoCaoTheoChungTu> getListBaoCaoTheoHangHoa(int check, string maKho)
        {
            string sql;
            if(check == 0)
            {
                 sql = "SELECT  ct.MaHang, ct.TenHang, ct.DonVi,  ct.SoLuong,hh.GiaMua, nh.TenNhom, kh.TenKho,  " +
                " ct.DonGia, ct.ThanhToan FROM CT_PHIEUXUAT ct, THONGTIN_PHIEU_BANHANG tt, HANGHOA_DICHVU hh, NHOMHANG nh, KHOHANG kh " +
                "WHERE ct.MaPhieuXuat = tt.MaPhieu and hh.MaHang = ct.MaHang and hh.MaHang = ct.MaHang and hh.MaNhom = nh.MaNhom and tt.MaKho = kh.MaKho";

            }
            else
            {
                 sql = string.Format("SELECT  ct.MaHang, ct.TenHang, ct.DonVi,  ct.SoLuong,hh.GiaMua, nh.TenNhom, kh.TenKho,  " +
                " ct.DonGia, ct.ThanhToan FROM CT_PHIEUXUAT ct, THONGTIN_PHIEU_BANHANG tt, HANGHOA_DICHVU hh, NHOMHANG nh, KHOHANG kh " +
                "WHERE ct.MaPhieuXuat = tt.MaPhieu and hh.MaHang = ct.MaHang and hh.MaHang = ct.MaHang and hh.MaNhom = nh.MaNhom and tt.MaKho = kh.MaKho and tt.MaKho = '{0}'", maKho);

            }
            DataTable data = ConnectionDB.getData(sql);

            List<BaoCaoTheoChungTu> ListBaoCaoTheoHangHoa = new List<BaoCaoTheoChungTu>();

            if (data.Rows.Count > 0)
            {
                foreach(DataRow dataRow in data.Rows)
                {
                    BaoCaoTheoChungTu x = new BaoCaoTheoChungTu();
                    x.MaHang = dataRow["MaHang"].ToString();
                    x.TenHang = dataRow["TenHang"].ToString();
                    x.DonVi = dataRow["DonVi"].ToString();
                    x.SoLuong = (dataRow["SoLuong"].ToString());
                    x.DonGiaNhap = (dataRow["GiaMua"].ToString());
                    x.TongTienNhap = (int.Parse(x.SoLuong) * float.Parse(x.DonGiaNhap)).ToString();
                    x.DonGiaXuat = (dataRow["DonGia"].ToString());
                    x.TongTienXuat = (int.Parse(x.SoLuong) * float.Parse(x.DonGiaXuat)).ToString();
                    x.ChenhLech = (float.Parse(x.TongTienXuat) - float.Parse(x.TongTienNhap)).ToString();
                    x.KhoHang = dataRow["TenKho"].ToString();
                    x.NhomHang = dataRow["TenNhom"].ToString();
                    ListBaoCaoTheoHangHoa.Add(x);
                }
            }
            return ListBaoCaoTheoHangHoa;
        }

        public List<BaoCaoTheoChungTu> getListBaoCao(int check, DateTime a, DateTime b)
        {
            List<string> ListMaPhieuSell;
            if (check == 0)
            {
                ListMaPhieuSell = getMaPhieuInSell();
            }
            else
            {
                ListMaPhieuSell = getMaPhieuInSellNgay(a, b);
            }
            List<BaoCaoTheoChungTu> listBaoCaoTheoChungTu = new List<BaoCaoTheoChungTu>();

            for (int i = 0; i < ListMaPhieuSell.Count; i++)
            {
                DataTable data = getListBaoCao(ListMaPhieuSell[i]);

                BaoCaoTheoChungTu y = new BaoCaoTheoChungTu();

                y.TenKH = data.Rows[0]["TenKH"].ToString();
                y.MaKH = data.Rows[0]["MaKH"].ToString();
                y.MaPhieu = data.Rows[0]["MaPhieuXuat"].ToString();
                y.NgayLap =  (data.Rows[0]["NgayLap"].ToString());
              

                y.TienHang =  (data.Rows[0]["TongTienBan"].ToString());
                y.CK =  (data.Rows[0]["CK"].ToString());
                y.VAT =  (data.Rows[0]["VAT"].ToString());
                y.DoanhSo =  (data.Rows[0]["TongTienNhan"].ToString());
                

                
                float giaTriXuatKho = 0;
                foreach (DataRow dataRow in data.Rows)
                {
                    giaTriXuatKho += (int.Parse(dataRow["SoLuong"].ToString()) * float.Parse(dataRow["GiaMua"].ToString()));

                }
                y.GiaTriXuatKho = giaTriXuatKho.ToString();
                y.LoiNhuan = (Convert.ToDouble(y.DoanhSo) -Convert.ToDouble(y.GiaTriXuatKho)).ToString();
                listBaoCaoTheoChungTu.Add(y);

                if (data.Rows.Count > 0)
                {
                    foreach(DataRow dataRow in data.Rows)
                    {
                        BaoCaoTheoChungTu x = new BaoCaoTheoChungTu();
                        x.TenKH = dataRow["TenKH"].ToString();
                        x.MaKH = dataRow["MaKH"].ToString();
                        x.MaPhieu = dataRow["MaPhieuXuat"].ToString();
                        x.MaHang = dataRow["MaHang"].ToString();
                        x.TenHang = dataRow["TenHang"].ToString();
                        x.DonVi = dataRow["DonVi"].ToString();
                        x.SoLuong = (dataRow["SoLuong"].ToString());
                        x.DonGiaNhap =  (dataRow["GiaMua"].ToString());
                        x.TongTienNhap = (int.Parse(x.SoLuong) * float.Parse(x.DonGiaNhap)).ToString();
                        x.DonGiaXuat =  (dataRow["DonGia"].ToString());
                        x.TongTienXuat = (int.Parse(x.SoLuong) * float.Parse(x.DonGiaXuat)).ToString();
                        x.ChenhLech = (float.Parse(x.TongTienXuat) - float.Parse(x.TongTienNhap)).ToString();
                        
                        listBaoCaoTheoChungTu.Add(x);
                    }
                }

            }
            return listBaoCaoTheoChungTu;
        }

        public List<String> getMaPhieuInSell()
        {
            string sql = "select MaPhieu from THONGTIN_PHIEU_BANHANG ";
            DataTable data = ConnectionDB.getData(sql);
            List<String> ListMaPhieuSell = new List<string>();
            foreach (DataRow dataRow in data.Rows)
            {
                ListMaPhieuSell.Add(dataRow["MaPhieu"].ToString());
            }
            return ListMaPhieuSell;
        }

        public List<String> getMaPhieuInSellNgay(DateTime a, DateTime b)
        {
            string sql = string.Format("select MaPhieu from THONGTIN_PHIEU_BANHANG where NgayLap Between '{0}' and '{1}' ", a, b);
            DataTable data = ConnectionDB.getData(sql);
            List<String> ListMaPhieuSell = new List<string>();
            foreach (DataRow dataRow in data.Rows)
            {
                ListMaPhieuSell.Add(dataRow["MaPhieu"].ToString());
            }
            return ListMaPhieuSell;
        }

        public DataTable getListBaoCao(string maPhieuXuat)
        {
            string sql = string.Format(" SELECT tt.MaKH, tt.TenKH,ct.MaPhieuXuat ,tt.NgayLap, ct.MaHang, ct.TenHang, ct.DonVi, " +
                " ct.SoLuong,hh.GiaMua, " +
                " ct.DonGia, ct.ThanhToan, tt.TongTienBan, tt.CK, tt.VAT, tt.TongTienNhan " +
                "FROM CT_PHIEUXUAT ct, THONGTIN_PHIEU_BANHANG tt, HANGHOA_DICHVU hh " +
                "WHERE ct.MaPhieuXuat = tt.MaPhieu and hh.MaHang = ct.MaHang and ct.MaPhieuXuat = '{0}' ", maPhieuXuat);
            DataTable data = ConnectionDB.getData(sql);
            return data;
         
        }
    }
    
}
