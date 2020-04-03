using QLBH_ProductManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace QLBH_ProductManagement.DAO
{
    public class InforTransWarehouseDAO
    {
        public int InsertInforTranWarehouse(InforTransWarehouseDTO infor)
        {
            string sql = string.Format("INSERT INTO [THONGTIN_CHUYENKHO] VALUES('{0}', '{1}', '{2}', '{3}', N'{4}', '{5}', '{6}', N'{7}', {8})", infor.MaPhieuChuyen,
                infor.MaKhoXuat, infor.MaKhoNhan, infor.NgayLap, infor.GhiChu, infor.MaNVXuat, infor.MaNVNhan, infor.SoPhieuChuyenTay, infor.TongTienChuyen);
            return ConnectionDB.ExcuteNonQuery(sql);
        }

        public string IDAuto()
        {
            return Convert.ToString(ConnectionDB.ExecScalar("select dbo.SetAutoIdThongTin_ChuyenKho()"));
        }

        public int DeleteInforTransWarehouse(string maPhieu)
        {
            string sql = string.Format("DELETE FROM THONGTIN_CHUYENKHO WHERE MaPhieuChuyen = '{0}'", maPhieu);
            return ConnectionDB.ExcuteNonQuery(sql);
        }

        public List<InforTransWarehouseDTO> getListInforTrans(DateTime a, DateTime b, int check)
        {

            string sql;
            if (check == 0)
            {
                sql = "SELECT tt.MaPhieuChuyen as [Chứng Từ], tt.NgayLap as [Ngày Lập], kh.TenKho as [Kho Chuyển],  " +
             "kh1.TenKho as [Kho Nhận], nv1.TenNV as [Nhân Viên Chuyển], nv2.TenNV as [Nhân Viên Nhận]" +
             "  ,tt.TongTienChuyen as [Thành Tiền], tt.GhiChu as [Ghi Chú] " +
             "FROM THONGTIN_CHUYENKHO tt, KHOHANG kh, KHOHANG kh1, _NHANVIEN nv1, _NHANVIEN nv2 " +
             "where kh.MaKho = tt.MaKhoNhan and kh1.MaKho = tt.MaKhoXuat and tt.MaNVXuat = nv1.MaNV and tt.MaNVNhan = nv2.MaNV";

            }
            else
            {
                sql = string.Format("SELECT tt.MaPhieuChuyen as [Chứng Từ], tt.NgayLap as [Ngày Lập], kh.TenKho as [Kho Chuyển],  " +
              "kh1.TenKho as [Kho Nhận], nv1.TenNV as [Nhân Viên Chuyển], nv2.TenNV as [Nhân Viên Nhận]" +
              "  ,tt.TongTienChuyen as [Thành Tiền], tt.GhiChu as [Ghi Chú] " +
              "FROM THONGTIN_CHUYENKHO tt, KHOHANG kh, KHOHANG kh1, _NHANVIEN nv1, _NHANVIEN nv2 " +
              "where kh.MaKho = tt.MaKhoNhan and kh1.MaKho = tt.MaKhoXuat and tt.MaNVXuat = nv1.MaNV and tt.MaNVNhan = nv2.MaNV and tt.NgayLap Between '{0}' and '{1}'", a, b);

            }
            DataTable data = ConnectionDB.getData(sql);
            List<InforTransWarehouseDTO> listInforTrans = new List<InforTransWarehouseDTO>();
            if (data.Rows.Count > 0)
            {
                foreach (DataRow dataRow in data.Rows)
                {
                    InforTransWarehouseDTO inforTrans = new InforTransWarehouseDTO();
                    inforTrans.MaPhieuChuyen = dataRow[0].ToString();
                    inforTrans.NgayLap = DateTime.Parse(dataRow[1].ToString());
                    inforTrans.MaKhoNhan = dataRow[2].ToString();
                    inforTrans.MaKhoXuat = dataRow[3].ToString();
                    inforTrans.MaNVXuat = dataRow[4].ToString();
                    inforTrans.MaNVNhan = dataRow[5].ToString();
                    inforTrans.TongTienChuyen = float.Parse(dataRow[6].ToString());
                    inforTrans.GhiChu = dataRow[7].ToString();

                    listInforTrans.Add(inforTrans);
                }
            }
            return listInforTrans;
        }

        public DataTable getInforDetailWarehouse(int check, DateTime a, DateTime b)
        {
            string sql;
            if (check == 0)
            {
                sql = "SELECT tt.MaPhieuChuyen, tt.NgayLap, tt.TongtienChuyen " +
                " FROM THONGTIN_CHUYENKHO tt";
            }
            else
            {
                sql = string.Format("SELECT tt.MaPhieuChuyen, tt.NgayLap, tt.TongtienChuyen " +
                " FROM THONGTIN_CHUYENKHO tt where tt.NgayLap between '{0}' and '{1}'", a, b);
            }

            DataTable data = ConnectionDB.getData(sql);
            return data;

        }

        public InforTransWarehouseDTO getDetailTransFromMa(string maPhieuChuyen)
        {
            string sql = string.Format("SELECT * FROM THONGTIN_CHUYENKHO where maPhieuChuyen = '{0}' ", maPhieuChuyen);

            DataTable data = ConnectionDB.getData(sql);

            InforTransWarehouseDTO inforX = new InforTransWarehouseDTO();

            if (data.Rows.Count > 0)
            {
                inforX.MaPhieuChuyen = data.Rows[0]["MaPhieuChuyen"].ToString();
                inforX.MaKhoXuat = data.Rows[0]["MaKhoXuat"].ToString();
                inforX.MaKhoNhan = data.Rows[0]["MaKhoNhan"].ToString();
                inforX.NgayLap = DateTime.Parse(data.Rows[0]["NgayLap"].ToString());
                inforX.GhiChu = data.Rows[0]["GhiChu"].ToString();
                inforX.MaNVXuat = data.Rows[0]["MaNVXuat"].ToString();

                inforX.MaNVNhan = data.Rows[0]["MaNVNhan"].ToString();
                inforX.SoPhieuChuyenTay = data.Rows[0]["SoPhieuChuyenTay"].ToString();

            }
            return inforX;
        }

        public int checkMaPhieuChuyenKho(string maPhieu)
        {
            string sql = string.Format("SELECT 1 FROM THONGTIN_CHUYENKHO WHERE MaPhieuChuyen = '{0}'", maPhieu);
            return Convert.ToInt32(ConnectionDB.ExcuteQuery(sql));
        }

        public int UpdateInforTranWarehouse(InforTransWarehouseDTO infor)
        {
            string sql = string.Format("UPDATE [THONGTIN_CHUYENKHO] SET MaKhoXuat = '{0}', MaKhoNhan = '{1}',NgayLap = '{2}', GhiChu = N'{3}', MaNVXuat = '{4}', MaNVNhan = '{5}', SoPhieuChuyenTay = '{6}', TongTienChuyen = {7} WHERE MaPhieuChuyen = '{8}'", 
                infor.MaKhoXuat, infor.MaKhoNhan, infor.NgayLap, infor.GhiChu, infor.MaNVXuat, infor.MaNVNhan, infor.SoPhieuChuyenTay, infor.TongTienChuyen, infor.MaPhieuChuyen);
            return ConnectionDB.ExcuteNonQuery(sql);
        }
    }
}
