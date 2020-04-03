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
    public class NhapXuatTonDAO
    {
        TonKhoBUS tk = new TonKhoBUS();

        public List<NhapXuatTon> getListNhapXuatTon(int check, string maKho)
        {
            List<NhapXuatTon> ListNhapXuatTon = new List<NhapXuatTon>();
            DataTable data;
            if (check == 0)
            {
                data = tk.getTonKho();
            }
            else
            {
                data = tk.getTonKhoFromMaKho(maKho);
            }
            
            if(data.Rows.Count > 0)
            {
                foreach(DataRow dataRow in data.Rows)
                {
                    NhapXuatTon x = new NhapXuatTon();
                    x.MaHang = dataRow["MaHang"].ToString();
                    x.TenHang = dataRow["TenHang"].ToString();
                    x.TenKho = dataRow["TenKho"].ToString();
                    x.MaKho = dataRow["MaKho"].ToString(); ;
                    x.ConQuanLy = bool.Parse(dataRow["Active"].ToString());
                    x.DonVi = dataRow["Ten"].ToString();
                    x.slDauKy = 0;
                    x.TienDauKy = 0;
                    if(getSumSoLuongNhap(x.MaHang, x.MaKho).ToString() == "")
                    {
                        x.slNhapKho = 0;
                    }
                    else
                    {
                        x.slNhapKho = Convert.ToInt32(getSumSoLuongNhap(x.MaHang, x.MaKho));
                    }

                    if (getSumTongTienNhap(x.MaHang, x.MaKho).ToString() == "")
                    {
                        x.TienNhapKho = 0;
                    }
                    else
                    {
                        x.TienNhapKho = (float)Convert.ToDouble(getSumTongTienNhap(x.MaHang, x.MaKho));
                    }

                    if (getSumSoLuongXuat(x.MaHang, x.MaKho).ToString() == "")
                    {
                        x.slXuatKho = 0;
                    }
                    else
                    {
                        x.slXuatKho = Convert.ToInt32(getSumSoLuongXuat(x.MaHang, x.MaKho));
                    }

                    if (getSumTongTienXuat(x.MaHang, x.MaKho).ToString() == "")
                    {
                        x.TienXuatKho = 0;
                    }
                    else
                    {
                        x.TienXuatKho = (float)Convert.ToDouble(getSumTongTienXuat(x.MaHang, x.MaKho));
                    }

                    x.slCuoiKy = x.slNhapKho - x.slXuatKho;
                    x.TienCuoiKy = x.TienNhapKho - x.TienXuatKho;
                    ListNhapXuatTon.Add(x);
                }
            }
            return ListNhapXuatTon;
        }

        public object getSumSoLuongNhap(string maHang, string maKho)
        {
            string sql = string.Format("SELECT SUM( ct.SoLuong) FROM THONGTIN_PHIEUNHAPHANG tt, CT_PHIEUNHAP ct " +
                "WHERE ct.MaPhieu = tt.MaPhieu and ct.MaHang = '{0}' and tt.maKho = '{1}'", maHang, maKho);

            return ConnectionDB.ExcuteQuery(sql);
        }

        public object getSumTongTienNhap(string maHang, string maKho)
        {
            string sql = string.Format("SELECT SUM( ct.ThanhTien) FROM THONGTIN_PHIEUNHAPHANG tt, CT_PHIEUNHAP ct " +
                "WHERE ct.MaPhieu = tt.MaPhieu and ct.MaHang = '{0}' and tt.maKho = '{1}'", maHang, maKho);

            return ConnectionDB.ExcuteQuery(sql);
        }

        public object getSumSoLuongXuat(string maHang, string maKho)
        {
            string sql = string.Format("SELECT SUM( ct.SoLuong) FROM THONGTIN_PHIEU_BANHANG tt, CT_PHIEUXUAT ct " +
                "WHERE ct.MaPhieuXuat = tt.MaPhieu and ct.MaHang = '{0}' and tt.maKho = '{1}'", maHang, maKho);

            return ConnectionDB.ExcuteQuery(sql);
        }

        public object getSumTongTienXuat(string maHang, string maKho)
        {
            string sql = string.Format("SELECT SUM( ct.ThanhToan) FROM THONGTIN_PHIEU_BANHANG tt, CT_PHIEUXUAT ct " +
                "WHERE ct.MaPhieuXuat = tt.MaPhieu and ct.MaHang = '{0}' and tt.maKho = '{1}'", maHang, maKho);

            return ConnectionDB.ExcuteQuery(sql);
        }

    }
}
