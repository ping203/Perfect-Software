using QLBH_ProductManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_ProductManagement.DAO
{
    public class DetailTransWarehouseDAO
    {
        // CHuyển kho:
        public DataTable getChiTietHienThiChuyenKho()
        {
            string sql = string.Format("Select * from [HIENTHI_CHUYENKHO]");
            DataTable data = ConnectionDB.getData(sql);
            return data;
        }

        public DataTable getListChiTietChuyenKho()
        {
            string sql = string.Format("SELECT ct.TenHang, ct.MaHang, ct.SoLuong, ct.MaPhieuChuyen, tt.NgayLap, tt.TongTienChuyen " +
                "FROM CT_ChUYENKHO ct, THONGTIN_CHUYENKHO tt WHERE TT.MaPhieuChuyen = CT.MaPhieuChuyen");
            DataTable data = ConnectionDB.getData(sql);
            return data;
        }

        public int InsertDetailTransWarehouse(DetailTransWarehouseDTO detailTrans)
        {
            string sql = string.Format("INSERT INTO [CT_CHUYENKHO](MAPHIEUCHUYEN, MAHANG, TENHANG, DONVI, DONGIA, SOLUONG, THANHTIEN) VALUES('{0}', '{1}', N'{2}', N'{3}', {4}, {5}, {6})", detailTrans.MaPhieuChuyen,
               detailTrans.MaHang, detailTrans.TenHang, detailTrans.DonVi, detailTrans.DonGia, detailTrans.SoLuong, detailTrans.ThanhTien);
            return ConnectionDB.ExcuteNonQuery(sql);
        }

        // Load phaanf theo hành hóa:
        public DataTable getDetailTransWarehouse(DateTime a, DateTime b, int check)
        {
            string sql;
            if(check == 0)
            {
                sql = "SELECT ct.MaPhieuChuyen, tt.NgayLap , kh.TenKho as [KhoChuyen], " +
               " kh1.TenKho as [KhoNhan],ct.MaHang , ct.TenHang , ct.DonVi , ct.DonGia, ct.SoLuong ,ct.ThanhTien " +
               "FROM CT_ChUYENKHO ct, THONGTIN_CHUYENKHO tt, KHOHANG kh, KHOHANG kh1 " +
               "where ct.MaPhieuChuyen = tt.MaPhieuChuyen and kh.MaKho = tt.MaKhoXuat and kh1.MaKho = tt.MaKhoNhan";
            }
            else
            {
                sql = string.Format("SELECT ct.MaPhieuChuyen, tt.NgayLap , kh.TenKho as [KhoChuyen], " +
               " kh1.TenKho as [KhoNhan],ct.MaHang , ct.TenHang , ct.DonVi , ct.DonGia, ct.SoLuong ,ct.ThanhTien " +
               "FROM CT_ChUYENKHO ct, THONGTIN_CHUYENKHO tt, KHOHANG kh, KHOHANG kh1 " +
               "where ct.MaPhieuChuyen = tt.MaPhieuChuyen and kh.MaKho = tt.MaKhoXuat and kh1.MaKho = tt.MaKhoNhan and tt.NgayLap Between '{0}' and '{1}'", a, b);
            }
           
            return ConnectionDB.getData(sql);
        }

        public int DeleteDetailTransWarehouse(string maPhieu)
        {
            string sql = string.Format("DELETE FROM CT_ChUYENKHO WHERE MaPhieuChuyen = '{0}'", maPhieu);
            return ConnectionDB.ExcuteNonQuery(sql);
        }
        public List<DetailTransWarehouseDTO> getListDetailTrans()
        {
            string sql = "SELECT * FROM CT_ChUYENKHO";
            DataTable data = ConnectionDB.getData(sql);
            List<DetailTransWarehouseDTO> listDetailTrans = new List<DetailTransWarehouseDTO>();
            if(data.Rows.Count > 0)
            {
                foreach(DataRow dataRow in data.Rows)
                {
                    DetailTransWarehouseDTO detailTrans = new DetailTransWarehouseDTO();
                    detailTrans.MaPhieuChuyen = dataRow["MaPhieuChuyen"].ToString();
                    detailTrans.MaHang = dataRow["MaHang"].ToString();
                    detailTrans.TenHang = dataRow["TenHang"].ToString();
                    detailTrans.DonVi = dataRow["DonVi"].ToString();
                    detailTrans.DonGia = float.Parse(dataRow["DonGia"].ToString());
                    detailTrans.SoLuong = int.Parse(dataRow["SoLuong"].ToString());
                    detailTrans.ThanhTien = float.Parse(dataRow["ThanhTien"].ToString());
                    listDetailTrans.Add(detailTrans);
                }
            }
            return listDetailTrans;
        }

        public DataTable getDetailTransFromMa(string maPhieuChuyen)
        {
            string sql = string.Format("SELECT TT.MaPhieuChuyen ,tt.MaKhoNhan, tt.MaKhoXuat, ct.MaHang, ct.SoLuong  " +
                " FROM THONGTIN_CHUYENKHO tt, CT_ChUYENKHO ct " +
                " WHERE tt.MaPhieuChuyen = ct.MaPhieuChuyen and tt.MaPhieuChuyen = '{0}'", maPhieuChuyen);

            return ConnectionDB.getData(sql);
        }

        public List<DetailTransWarehouseDTO> getListDetailTransFromMa(string maChuyen)
        {
            string sql = string.Format("SELECT * FROM CT_ChUYENKHO where maPhieuChuyen = '{0}' ", maChuyen);
            DataTable data = ConnectionDB.getData(sql);
            List<DetailTransWarehouseDTO> listDetailTrans = new List<DetailTransWarehouseDTO>();
            if (data.Rows.Count > 0)
            {
                foreach (DataRow dataRow in data.Rows)
                {
                    DetailTransWarehouseDTO detailTrans = new DetailTransWarehouseDTO();
                    detailTrans.MaPhieuChuyen = dataRow["MaPhieuChuyen"].ToString();
                    detailTrans.MaHang = dataRow["MaHang"].ToString();
                    detailTrans.TenHang = dataRow["TenHang"].ToString();
                    detailTrans.DonVi = dataRow["DonVi"].ToString();
                    detailTrans.DonGia = float.Parse(dataRow["DonGia"].ToString());
                    detailTrans.SoLuong = int.Parse(dataRow["SoLuong"].ToString());
                    detailTrans.ThanhTien = float.Parse(dataRow["ThanhTien"].ToString());
                    listDetailTrans.Add(detailTrans);
                }
            }
            return listDetailTrans;
        }

    }
}
