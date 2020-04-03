using QLBH_ProductManagement.BUS;
using QLBH_ProductManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_ProductManagement.DAO
{
    public class TheKhoDAO
    {
        DetailTransWarehouseBUS detailWarehouse = new DetailTransWarehouseBUS();
        DetailSellGoodsBUS detailSellBUS = new DetailSellGoodsBUS();
        DetailBuyGoodsBUS detailBuyBUS = new DetailBuyGoodsBUS();

        InforTransWarehouseBUS inforWarehouse = new InforTransWarehouseBUS();
        InforDetailBuyBUS inforBuy = new InforDetailBuyBUS();
        InforSellBUS inforSell = new InforSellBUS();

        public List<TheKhoDTO> getListTheKho()
        {
            DataTable dataNhap = detailBuyBUS.getListChiTietPhieuNhap();
            DataTable dataXuat = detailSellBUS.getCTPhieuXuat();
            DataTable dataChuyenKho = detailWarehouse.getListChiTietChuyenKho();
            List<TheKhoDTO> listTheKho = new List<TheKhoDTO>();
            int slNhap = 0;
            int slXuat = 0;
            int slTon = 0;
            if (dataNhap.Rows.Count > 0)
            {
                foreach (DataRow dataRow in dataNhap.Rows)
                {
                    TheKhoDTO x = new TheKhoDTO();
                    x.MaHang = dataRow["MaHang"].ToString();
                    x.TenHang = dataRow["TenHang"].ToString();
                    x.NgayLap = DateTime.Parse(dataRow["NgayLap"].ToString());
                    x.MaPhieuNhap = dataRow["MaPhieu"].ToString();
                    x.SoLuongNhap = int.Parse(dataRow["SoLuong"].ToString());
                    x.Loai = "Nhập Kho";
                    slNhap += x.SoLuongNhap;
                    slTon = slNhap - slXuat;
                    x.SoLuongTon = slTon;
                    listTheKho.Add(x);
                }
            }
            if (dataChuyenKho.Rows.Count > 0)
            {
                foreach (DataRow dataRow in dataChuyenKho.Rows)
                {
                    TheKhoDTO x = new TheKhoDTO();
                    x.MaHang = dataRow["MaHang"].ToString();
                    x.TenHang = dataRow["TenHang"].ToString();
                    x.NgayLap = DateTime.Parse(dataRow["NgayLap"].ToString());
                    x.MaPhieuXuat = dataRow["MaPhieuChuyen"].ToString();
                    x.SoLuongXuat = int.Parse(dataRow["SoLuong"].ToString());
                    x.Loai = "Xuất Kho";
                    slXuat += x.SoLuongXuat;
                    slTon = slNhap - slXuat;
                    x.SoLuongTon = slTon;
                    listTheKho.Add(x);
                }
            }
            if (dataXuat.Rows.Count > 0)
            {
                foreach (DataRow dataRow in dataXuat.Rows)
                {
                    TheKhoDTO x = new TheKhoDTO();
                    x.MaHang = dataRow["MaHang"].ToString();
                    x.TenHang = dataRow["TenHang"].ToString();
                    x.NgayLap = DateTime.Parse(dataRow["NgayLap"].ToString());
                    x.MaPhieuXuat = dataRow["MaPhieuXuat"].ToString();
                    x.SoLuongXuat = int.Parse(dataRow["SoLuong"].ToString());
                    x.Loai = "Xuất Kho";
                    slXuat += x.SoLuongXuat;
                    slTon = slNhap - slXuat;
                    x.SoLuongTon = slTon;
                    listTheKho.Add(x);
                }
            }
            return listTheKho;
        }

        public List<TheKhoDTO> getListChungTu(int check, DateTime a, DateTime b)
        {
            DataTable dataNhap;
            DataTable dataXuat;
            DataTable dataChuyenKho;
            if (check == 0)
            {
                 dataNhap = inforBuy.getDatatableInforDetailBuy(0, a, b);
                 dataXuat = inforSell.getInforDetailSell(0, a, b);
                 dataChuyenKho = inforWarehouse.getInforDetailWarehouse(0, a, b);
            }
            else
            {
                 dataNhap = inforBuy.getDatatableInforDetailBuy(1, a, b);
                 dataXuat = inforSell.getInforDetailSell(1, a, b);
                 dataChuyenKho = inforWarehouse.getInforDetailWarehouse(1, a, b);
            }

            List<TheKhoDTO> ListChungTu = new List<TheKhoDTO>();

            if (dataNhap.Rows.Count > 0)
            {
                foreach (DataRow dataRow in dataNhap.Rows)
                {
                    TheKhoDTO x = new TheKhoDTO();

                    x.NgayLap = DateTime.Parse(dataRow["NgayLap"].ToString());
                    x.MaPhieuXuat = dataRow["MaPhieu"].ToString();
                    x.TongTien = float.Parse(dataRow["TongTienTra"].ToString());
                    x.Loai = "Nhập Kho";
                    ListChungTu.Add(x);
                }
            }
            if (dataChuyenKho.Rows.Count > 0)
            {
                foreach (DataRow dataRow in dataChuyenKho.Rows)
                {
                    TheKhoDTO x = new TheKhoDTO();

                    x.NgayLap = DateTime.Parse(dataRow["NgayLap"].ToString());
                    x.MaPhieuXuat = dataRow["MaPhieuChuyen"].ToString();
                    x.TongTien = float.Parse(dataRow["TongTienChuyen"].ToString());
                    x.Loai = "Chuyển Kho";
                    ListChungTu.Add(x);
                }
            }
            if (dataXuat.Rows.Count > 0)
            {
                foreach (DataRow dataRow in dataXuat.Rows)
                {
                    TheKhoDTO x = new TheKhoDTO();

                    x.NgayLap = DateTime.Parse(dataRow["NgayLap"].ToString());
                    x.MaPhieuXuat = dataRow["MaPhieu"].ToString();
                    x.TongTien = float.Parse(dataRow["TongTienNhan"].ToString());
                    x.Loai = "Xuất Kho";

                    ListChungTu.Add(x);
                }
            }
            return ListChungTu;
        }
    }
}
