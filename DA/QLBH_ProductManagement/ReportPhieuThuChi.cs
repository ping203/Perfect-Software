using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using QLBH_ProductManagement.DTO;

namespace QLBH_ProductManagement
{
    public partial class ReportPhieuThuChi : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportPhieuThuChi()
        {
            InitializeComponent();
        }

        public void initDataThu(PhieuThuTien ptTien)
        {
            pChungTuGoc.Value = ptTien.MaChungTu;
            pThuQuy.Value = ptTien.TenNV;
            pSoTien.Value = ptTien.SoTien;
            pNgay.Value = ptTien.NgayLap;
            pLyDo.Value = ptTien.GhiChu;
            pNguoiNopTien.Value = ptTien.TenKH;
            pNguoiLapPhieu.Value = ptTien.TenNV;
            pSoTienBangChu.Value = ChuyenSoThanhChu(ChuanHoaSoTien(ptTien.SoTien.ToString()));
            pMaPhieu.Value = ptTien.MaPhieu;
        }

        public void initDataChi(PhieuChiTien pcTien)
        {
            pChungTuGoc.Value = pcTien.MaChungTu;
            pThuQuy.Value = pcTien.TenNV;
            pSoTien.Value = pcTien.SoTien;
            pNgay.Value = pcTien.NgayLap;
            pLyDo.Value = pcTien.GhiChu;
            pNguoiNopTien.Value = pcTien.TenNCC;
            pNguoiLapPhieu.Value = pcTien.TenNV;

            pSoTienBangChu.Value = ChuyenSoThanhChu(ChuanHoaSoTien(pcTien.SoTien.ToString()));
            pMaPhieu.Value = pcTien.MaPhieu;
        }

        public string ChuanHoaSoTien(string soTien)
        {
            // số tiền ban đầu là abc.xyz
            // xóa '.'

            soTien = String.Join("", soTien.Split(',', '.'));
            return soTien;
        }

        public string ChuyenSoThanhChu(string number)
        {
            string[] dv = { "", "mươi", "trăm", "nghìn", "triệu", "tỉ" };
            string[] cs = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string doc;
            int i, j, k, n, len, found, ddv, rd;

            len = number.Length;
            number += "ss";
            doc = "";
            found = 0;
            ddv = 0;
            rd = 0;

            i = 0;
            while (i < len)
            {
                //So chu so o hang dang duyet
                n = (len - i + 2) % 3 + 1;

                //Kiem tra so 0
                found = 0;
                for (j = 0; j < n; j++)
                {
                    if (number[i + j] != '0')
                    {
                        found = 1;
                        break;
                    }
                }

                //Duyet n chu so
                if (found == 1)
                {
                    rd = 1;
                    for (j = 0; j < n; j++)
                    {
                        ddv = 1;
                        switch (number[i + j])
                        {
                            case '0':
                                if (n - j == 3) doc += cs[0] + " ";
                                if (n - j == 2)
                                {
                                    if (number[i + j + 1] != '0') doc += "lẻ ";
                                    ddv = 0;
                                }
                                break;
                            case '1':
                                if (n - j == 3) doc += cs[1] + " ";
                                if (n - j == 2)
                                {
                                    doc += "mười ";
                                    ddv = 0;
                                }
                                if (n - j == 1)
                                {
                                    if (i + j == 0) k = 0;
                                    else k = i + j - 1;

                                    if (number[k] != '1' && number[k] != '0')
                                        doc += "mốt ";
                                    else
                                        doc += cs[1] + " ";
                                }
                                break;
                            case '5':
                                if (i + j == len - 1)
                                    doc += "lăm ";
                                else
                                    doc += cs[5] + " ";
                                break;
                            default:
                                doc += cs[(int)number[i + j] - 48] + " ";
                                break;
                        }

                        //Doc don vi nho
                        if (ddv == 1)
                        {
                            doc += dv[n - j - 1] + " ";
                        }
                    }
                }


                //Doc don vi lon
                if (len - i - n > 0)
                {
                    if ((len - i - n) % 9 == 0)
                    {
                        if (rd == 1)
                            for (k = 0; k < (len - i - n) / 9; k++)
                                doc += "tỉ ";
                        rd = 0;
                    }
                    else
                        if (found != 0) doc += dv[((len - i - n + 1) % 9) / 3 + 2] + " ";
                }

                i += n;
            }

            if (len == 1)
                if (number[0] == '0' || number[0] == '5') return cs[(int)number[0] - 48];

            return doc;
        }

    }
}
