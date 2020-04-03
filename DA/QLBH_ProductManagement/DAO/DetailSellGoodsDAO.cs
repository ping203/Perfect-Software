using QLBH_ProductManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace QLBH_ProductManagement.DAO
{
    public class DetailSellGoodsDAO
    {

        public DataTable getDataTheoHangHoa(int check, DateTime a, DateTime b)
        {
            string sql;
            if(check == 0)
            {
                sql = "SELECT ct.MaHang, ct.TenHang, nh.TenNhom, kh.TenKho, ct.DonVi, SUM(ct.SoLuong) as SL, SUM(CT.ThanhToan) as TIEN " +
              "FROM CT_PHIEUXUAT ct, THONGTIN_PHIEU_BANHANG tt, NHOMHANG nh, KHOHANG kh, HANGHOA_DICHVU hh " +
              "WHERE ct.MaPhieuXuat = tt.MaPhieu and tt.MaKho = kh.MaKho and ct.MaHang = hh.MaHang and hh.MaNhom = nh.MaNhom " +
              "GROUP BY  ct.MaHang,tt.MaKho, ct.TenHang, nh.TenNhom, kh.TenKho, ct.DonVi";
            }
            else
            {
                sql = string.Format("SELECT ct.MaHang, ct.TenHang, nh.TenNhom, kh.TenKho, ct.DonVi, SUM(ct.SoLuong) as SL, SUM(CT.ThanhToan) as TIEN " +
             "FROM CT_PHIEUXUAT ct, THONGTIN_PHIEU_BANHANG tt, NHOMHANG nh, KHOHANG kh, HANGHOA_DICHVU hh " +
             "WHERE ct.MaPhieuXuat = tt.MaPhieu and tt.MaKho = kh.MaKho and ct.MaHang = hh.MaHang and hh.MaNhom = nh.MaNhom and tt.NgayLap between '{0}' and '{1}' " +
             "GROUP BY  ct.MaHang,tt.MaKho, ct.TenHang, nh.TenNhom, kh.TenKho, ct.DonVi", a, b);
            }
           

            return ConnectionDB.getData(sql);
        }

        public DataTable getDataTheoHangHoaFromMaKho( DateTime a, DateTime b, string maKho)
        {
            string sql;
          
          
                sql = string.Format("SELECT ct.MaHang, ct.TenHang, nh.TenNhom, kh.TenKho, ct.DonVi, SUM(ct.SoLuong) as SL, SUM(CT.ThanhToan) as TIEN " +
             "FROM CT_PHIEUXUAT ct, THONGTIN_PHIEU_BANHANG tt, NHOMHANG nh, KHOHANG kh, HANGHOA_DICHVU hh " +
             "WHERE ct.MaPhieuXuat = tt.MaPhieu and tt.MaKho = kh.MaKho and ct.MaHang = hh.MaHang and hh.MaNhom = nh.MaNhom and tt.NgayLap between '{0}' and '{1}' and tt.maKho = '{2}' " +
             "GROUP BY  ct.MaHang,tt.MaKho, ct.TenHang, nh.TenNhom, kh.TenKho, ct.DonVi", a, b, maKho);
          


            return ConnectionDB.getData(sql);
        }

        public int deleteChiTietHoaDonAo()
        {
            string sql = string.Format("Delete  from [HIENTHI_PHIEUXUAT]");
            return ConnectionDB.ExcuteNonQuery(sql);
        }

        public DataTable getHTDetailSellBuy()
        {
            string sql = string.Format("Select * from [HIENTHI_PHIEUXUAT]");
            DataTable data = ConnectionDB.getData(sql);
            return data;
        }

        public int InsertChiTietHoaDonBanHang_Ao(DetailSellGoods detailSell)
        {
            string sql = string.Format("INSERT INTO [HIENTHI_PHIEUXUAT](MaPhieu, MaHang, TenHang, DonVi, SoLuong, DonGia, " +
                "ThanhTien,CK, ThanhToan ) " +
                "VALUES ('{0}', '{1}', N'{2}',N'{3}', {4}, {5}, {6}, '{7}', {8} )", detailSell.MaPhieuXuat,
                detailSell.MaHang, detailSell.TenHang, detailSell.DonVi, detailSell.SoLuong, detailSell.DonGia, detailSell.ThanhTien, detailSell.CK, detailSell.ThanhToan);
            int check = ConnectionDB.ExcuteNonQuery(sql);
            return check;
        }

        public int InsertDetailSell(DetailSellGoods detailSell)
        {
            string sql = string.Format("INSERT INTO CT_PHIEUXUAT  VALUES('{0}', N'{1}', N'{2}', N'{3}'," +
                " {4}, {5}, {6}, {7}, {8})", detailSell.MaPhieuXuat, detailSell.MaHang, detailSell.TenHang, 
                detailSell.DonVi, detailSell.SoLuong, detailSell.DonGia, detailSell.ThanhTien, detailSell.CK, detailSell.ThanhToan);
            return ConnectionDB.ExcuteNonQuery(sql);
        }

        public DataTable getCTPhieuXuat() // cho phần hiển thị bên Theo Hàng hóa
        {
            string sql = string.Format("SELECT ct.MaPhieuXuat, tt.NgayLap, tt.MaKH, tt.TenKH, ct.MaHang, ct.TenHang, tt.TongTienNhan, " +
                " kh.TenKho, ct.DonVi, ct.SoLuong, ct.CK, ct.ThanhTien, ct.ThanhToan, ct.DonGia " +
                " FROM CT_PHIEUXUAT ct, THONGTIN_PHIEU_BANHANG tt, KHOHANG kh" +
                " WHERE ct.MaPhieuXuat = tt.MaPhieu and tt.MaKho = kh.MaKho ");

            return ConnectionDB.getData(sql);
        }

        public DataTable getCTPhieuXuatTheoKhachHang(string maKH, DateTime a, DateTime b, int check) // cho phần hiển thị bên Theo Hàng hóa
        {
            string sql;
            if (check == 0)
            {
                 sql = string.Format("SELECT ct.MaPhieuXuat, tt.NgayLap, tt.MaKH, tt.TenKH, ct.MaHang, ct.TenHang, " +
               " kh.TenKho, ct.DonVi, ct.SoLuong, ct.CK, ct.ThanhTien, ct.ThanhToan, ct.DonGia " +
               " FROM CT_PHIEUXUAT ct, THONGTIN_PHIEU_BANHANG tt, KHOHANG kh" +
               " WHERE ct.MaPhieuXuat = tt.MaPhieu and tt.MaKho = kh.MaKho and tt.MaKH = '{0}' and tt.NgayLap between '{1}' and '{2}'", maKH, a, b);

            }
            else
            {
                 sql = string.Format("SELECT ct.MaPhieuXuat, tt.NgayLap, tt.MaKH, tt.TenKH, ct.MaHang, ct.TenHang, " +
               " kh.TenKho, ct.DonVi, ct.SoLuong, ct.CK, ct.ThanhTien, ct.ThanhToan, ct.DonGia " +
               " FROM CT_PHIEUXUAT ct, THONGTIN_PHIEU_BANHANG tt, KHOHANG kh" +
               " WHERE ct.MaPhieuXuat = tt.MaPhieu and tt.MaKho = kh.MaKho and tt.NgayLap between '{0}' and '{1}'", a, b);

            }

            return ConnectionDB.getData(sql);
        }

        public DataTable getCTPhieuXuatFromNgay(DateTime a, DateTime b) // cho phần hiển thị bên Theo Hàng hóa
        {
            string sql = string.Format("SELECT ct.MaPhieuXuat, tt.NgayLap, tt.MaKH, tt.TenKH, ct.MaHang , " +
                " kh.TenKho, ct.DonVi, ct.SoLuong, ct.CK, ct.ThanhTien, ct.ThanhToan, ct.DonGia " +
                " FROM CT_PHIEUXUAT ct, THONGTIN_PHIEU_BANHANG tt, KHOHANG kh" +
                " WHERE ct.MaPhieuXuat = tt.MaPhieu and tt.MaKho = kh.MaKho and tt.NgayLap Between '{0}' and '{1}'  ", a, b);

            return ConnectionDB.getData(sql);
        }

        public int DeleteDetailSell(string maPhieu)
        {
            string sql = string.Format("DELETE FROM CT_PHIEUXUAT  WHERE [MaPhieuXuat] = '{0}' ", maPhieu);
            int check = ConnectionDB.ExcuteNonQuery(sql);
            return check;
        }

        public List<InforDetailSell> getThongTinHoaDon(DateTime dtTu, DateTime dtDen, int check)// dùng bên chứng từ mua
        {
            string sql = "";
            if(check == 1)
            {
                sql = string.Format("SELECT kh.TenKho, tt.MaKH,tt.MaPhieu, tt.NgayLap, tt.SoHoaDonVAT, tt.SoPhieuNhapTay, " +
                " tt.TenKH, tt.CK, tt.VAT, tt.TongTienBan, tt.TongTienNhan, tt.GhiChu " +
                " FROM KHOHANG kh, THONGTIN_PHIEU_BANHANG tt WHERE kh.MaKho = tt.MaKho and tt.NgayLap Between '{0}' and '{1}'  ", dtTu, dtDen);
            }
            else
            {
                 sql = string.Format("SELECT kh.TenKho,  tt.MaKH,tt.MaPhieu, tt.NgayLap, tt.SoHoaDonVAT, tt.SoPhieuNhapTay, " +
                 " tt.TenKH, tt.CK, tt.VAT, tt.TongTienBan, tt.TongTienNhan, tt.GhiChu " +
                 " FROM KHOHANG kh, THONGTIN_PHIEU_BANHANG tt WHERE kh.MaKho = tt.MaKho ");
            }

            List<InforDetailSell> listInforSell = new List<InforDetailSell>();
            DataTable data = ConnectionDB.getData(sql);
            if(data.Rows.Count > 0)
            {
                foreach(DataRow dataRow in data.Rows)
                {
                    InforDetailSell inforSell = new InforDetailSell();
                    inforSell.TenKho = dataRow["TenKho"].ToString();
                    inforSell.MaPhieu = dataRow["MaPhieu"].ToString();
                    inforSell.NgayLap = DateTime.Parse(dataRow["NgayLap"].ToString());
                    inforSell.SoHoaDonVAT = dataRow["SoHoaDonVAT"].ToString();
                    inforSell.SoPhieuNhapTay = dataRow["SoPhieuNhapTay"].ToString();
                    inforSell.TenKH = dataRow["TenKH"].ToString();
                    inforSell.MaKH = dataRow["MaKH"].ToString();
                    inforSell.CK = float.Parse(dataRow["CK"].ToString());
                    inforSell.VAT = float.Parse(dataRow["VAT"].ToString());
                    inforSell.TongTienBan = float.Parse(dataRow["TongTienBan"].ToString());
                    inforSell.GhiChu = dataRow["GhiChu"].ToString();
                    inforSell.TongTienNhan = float.Parse(dataRow["TongTienNhan"].ToString());
                    listInforSell.Add(inforSell);
                }
            }
            return listInforSell;
        }

        public List<InforDetailSell> getThongTinHoaDonFromMaKH(DateTime dtTu, DateTime dtDen, string maKH)// dùng bên chứng từ mua
        {
            string sql = "";
            sql = string.Format("SELECT kh.TenKho, tt.MaPhieu, tt.NgayLap, tt.SoHoaDonVAT, tt.SoPhieuNhapTay, " +
                " tt.TenKH, tt.CK, tt.VAT, tt.TongTienBan, tt.TongTienNhan, tt.GhiChu " +
                " FROM KHOHANG kh, THONGTIN_PHIEU_BANHANG tt WHERE kh.MaKho = tt.MaKho and tt.NgayLap Between '{0}' and '{1}' and tt.MaKH = '{2}' ", dtTu, dtDen, maKH);
           
            List<InforDetailSell> listInforSell = new List<InforDetailSell>();
            DataTable data = ConnectionDB.getData(sql);
            if (data.Rows.Count > 0)
            {
                foreach (DataRow dataRow in data.Rows)
                {
                    InforDetailSell inforSell = new InforDetailSell();
                    inforSell.TenKho = dataRow["TenKho"].ToString();
                    inforSell.MaPhieu = dataRow["MaPhieu"].ToString();
                    inforSell.NgayLap = DateTime.Parse(dataRow["NgayLap"].ToString());
                    inforSell.SoHoaDonVAT = dataRow["SoHoaDonVAT"].ToString();
                    inforSell.SoPhieuNhapTay = dataRow["SoPhieuNhapTay"].ToString();
                    inforSell.TenKH = dataRow["TenKH"].ToString();
                    inforSell.CK = float.Parse(dataRow["CK"].ToString());
                    inforSell.VAT = float.Parse(dataRow["VAT"].ToString());
                    inforSell.TongTienBan = float.Parse(dataRow["TongTienBan"].ToString());
                    inforSell.GhiChu = dataRow["GhiChu"].ToString();
                    inforSell.TongTienNhan = float.Parse(dataRow["TongTienNhan"].ToString());
                    listInforSell.Add(inforSell);
                }
            }
            return listInforSell;
        }

        public List<DetailSellGoods> getListChiTietMua() // chứng từ
        {
            string sql = string.Format("SELECT MaPhieuXuat, MaHang, TenHang, DonVi, DonGia, SoLuong, ThanhTien, CK, ThanhToan " +
                " FROM CT_PHIEUXUAT");
            DataTable data = ConnectionDB.getData(sql);
            List<DetailSellGoods> listChiTietHoaDon = new List<DetailSellGoods>();
            if(data.Rows.Count > 0)
            {
                foreach(DataRow dataRow in data.Rows)
                {
                    DetailSellGoods detaiSell = new DetailSellGoods();
                    detaiSell.MaPhieuXuat = dataRow["MaPhieuXuat"].ToString();
                    detaiSell.MaHang = dataRow["MaHang"].ToString();
                    detaiSell.TenHang = dataRow["TenHang"].ToString();
                    detaiSell.DonVi = dataRow["DonVi"].ToString();
                    detaiSell.DonGia = float.Parse(dataRow["DonGia"].ToString());
                    detaiSell.SoLuong = int.Parse(dataRow["SoLuong"].ToString());
                    detaiSell.ThanhTien = float.Parse(dataRow["ThanhTien"].ToString());
                    detaiSell.CK = float.Parse(dataRow["CK"].ToString());
                    detaiSell.ThanhToan = float.Parse(dataRow["ThanhToan"].ToString());
                    listChiTietHoaDon.Add(detaiSell);
                }      
            }
            return listChiTietHoaDon;
        }

        public List<DetailSellGoods> getListChiTietMuaCongNo() // chứng từ
        {
            string sql;
          
                 sql = string.Format("SELECT ct.MaPhieuXuat, ct.MaHang, ct.TenHang, ct.DonVi, ct.SoLuong, " +
                "ct.DonGia, ct.ThanhToan, tt.CK, tt.VAT, tt.TongTienNhan " +
                "FROM CT_PHIEUXUAT ct, THONGTIN_PHIEU_BANHANG tt " +
                "WHERE ct.MaPhieuXuat = tt.MaPhieu and tt.Ma_DieuKhoan = {0} ", 1);
        
            DataTable data = ConnectionDB.getData(sql);
            List<DetailSellGoods> ListChiTietMuaCongNo = new List<DetailSellGoods>();
            if (data.Rows.Count > 0)
            {
                foreach (DataRow dataRow in data.Rows)
                {
                    DetailSellGoods detaiSell = new DetailSellGoods();
                    detaiSell.MaPhieuXuat = dataRow["MaPhieuXuat"].ToString();
                    detaiSell.MaHang = dataRow["MaHang"].ToString();
                    detaiSell.TenHang = dataRow["TenHang"].ToString();
                    detaiSell.DonVi = dataRow["DonVi"].ToString();
                    detaiSell.DonGia = float.Parse(dataRow["DonGia"].ToString());
                    detaiSell.SoLuong = int.Parse(dataRow["SoLuong"].ToString());
                    detaiSell.ThanhTien = float.Parse(dataRow["ThanhToan"].ToString());
                    detaiSell.CKCN = float.Parse(dataRow["CK"].ToString());
                    detaiSell.VATCN = float.Parse(dataRow["VAT"].ToString());
                    detaiSell.TongThanhTien = float.Parse(dataRow["TongTienNhan"].ToString());
                    ListChiTietMuaCongNo.Add(detaiSell);
                }
            }
            return ListChiTietMuaCongNo;
        }

        public int UpdateIsDeleteDetail(string maPhieu)
        {
            string sql = string.Format("UPDATE [CT_PHIEUXUAT] SET ISDELETE = {0} WHERE MaPhieu = '{1}' ", 0, maPhieu);
            int check = ConnectionDB.ExcuteNonQuery(sql);
            return check;
        }

        public List<DetailSellGoods> getListChiTietHoaDonBanHangFromMaPhieu(string maPhieu)
        {
            string sql = string.Format("Select MaPhieuXuat, MaHang, TenHang, DonVi, SoLuong, DonGia," +
                " ThanhTien, CK, ThanhToan from [CT_PHIEUXUAT] where MaPhieuXuat = '{0}' ", maPhieu);
            DataTable data = ConnectionDB.getData(sql);
            List<DetailSellGoods> listChiTiet = new List<DetailSellGoods>();
            foreach (DataRow dataRow in data.Rows)
            {
                DetailSellGoods detaiBuy = new DetailSellGoods();
                detaiBuy.MaPhieuXuat = dataRow["MaPhieuXuat"].ToString();
                detaiBuy.MaHang = dataRow["MaHang"].ToString();
                detaiBuy.TenHang = dataRow["TenHang"].ToString();
                detaiBuy.DonVi = dataRow["DonVi"].ToString();
                detaiBuy.SoLuong = int.Parse(dataRow["SoLuong"].ToString());
                detaiBuy.DonGia = float.Parse(dataRow["DonGia"].ToString());
                detaiBuy.ThanhTien = float.Parse(dataRow["ThanhTien"].ToString());
                detaiBuy.CK = float.Parse(dataRow["CK"].ToString());
                detaiBuy.ThanhToan = float.Parse(dataRow["ThanhToan"].ToString());
                listChiTiet.Add(detaiBuy);
            }
            return listChiTiet;
        }
    }
}
