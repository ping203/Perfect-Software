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
    public class TonKhoTongHopDAO
    {
        TonKhoBUS tkBus = new TonKhoBUS();
        public List<TonKhoTongHop> getListTonKhoTongHop(int check, string maKho)
        {
            DataTable data;
            if (check == 0)
            {
               data = tkBus.getTonKho();
            }
            else
            {
               data =  tkBus.getTonKhoFromMaKho(maKho);
            }
            List<TonKhoTongHop> listTonKhoTongHop = new List<TonKhoTongHop>();

            if(data.Rows.Count > 0)
            {
                foreach (DataRow dataRow in data.Rows)
                {
                    TonKhoTongHop tkTongHop = new TonKhoTongHop();
                    tkTongHop.MaHang = dataRow["MaHang"].ToString();
                    tkTongHop.TenHang = dataRow["TenHang"].ToString();
                    tkTongHop.NhomHang = dataRow["TenNhom"].ToString();
                    tkTongHop.KhoHang = dataRow["TenKho"].ToString();
                    tkTongHop.MaKHo = dataRow["MaKho"].ToString(); ;
                    tkTongHop.ConQuanLy = bool.Parse(dataRow["Active"].ToString());
                    tkTongHop.DonVi = dataRow["Ten"].ToString();
                    tkTongHop.SoLuong = int.Parse(dataRow["SoLuongTon"].ToString());
                    if(tkTongHop.SoLuong <= 0)
                    {
                        tkTongHop.ThanhTien = tkTongHop.DonGia = 0;
                    }
                    else
                    {
                        object tien = sumDonGiaNhap(tkTongHop.MaHang, tkTongHop.MaKHo);
                        if(tien.ToString() == "")
                        {
                            tien = 0.0;
                        }
                        else
                        {
                            tien = (float)Convert.ToDouble(tien);
                        }

                        tkTongHop.DonGia = ((float)Convert.ToDouble(tien) / tkTongHop.SoLuong);

                        tkTongHop.ThanhTien = tkTongHop.DonGia * tkTongHop.SoLuong;

                    }
                    listTonKhoTongHop.Add(tkTongHop);
                }
            }
            return listTonKhoTongHop;

        }

        public object sumDonGiaNhap(string maHang, string MaKho)
        {
            string sql = string.Format("SELECT SUM( ct.ThanhTien) " +
                "FROM THONGTIN_PHIEUNHAPHANG tt, CT_PHIEUNHAP ct " +
                "WHERE ct.MaPhieu = tt.MaPhieu and tt.MaKho = '{0}' and ct.MaHang = '{1}'", MaKho, maHang);
            return ConnectionDB.ExcuteQuery(sql);
        }
    }
}
