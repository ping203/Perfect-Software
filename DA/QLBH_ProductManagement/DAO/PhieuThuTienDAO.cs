using QLBH_ProductManagement.DTO;
using System;
using System.Data;

namespace QLBH_ProductManagement.DAO
{
    public class PhieuThuTienDAO
    {
        public int InsertPhieuThuTien(PhieuThuTien ptTien)
        {
            string sql = string.Format("INSERT INTO [BANGKE_PHIEUTHUTIEN] VALUES('{0}', '{1}', '{2}', '{3}', N'{4}', {5},N'{6}' ,N'{7}')", ptTien.MaPhieu, ptTien.MaChungTu, ptTien.NgayLap, ptTien.MaKH, ptTien.TenKH, ptTien.SoTien, ptTien.TenNV, ptTien.GhiChu);
            return ConnectionDB.ExcuteNonQuery(sql);
        }

        public string IDAuto()
        {
            return Convert.ToString(ConnectionDB.ExecScalar("select dbo.SetAutoIdBANGKE_PHIEUTHUTIEN()"));
        }

        public DataTable LoadPhieuThuTien(DateTime a, DateTime b, int check)
        {
            string sql;
            if(check == 0)
            {
                sql = "SELECT * FROM BANGKE_PHIEUTHUTIEN";
            }
            else
            {
                sql = string.Format("SELECT * FROM BANGKE_PHIEUTHUTIEN WHERE NgayLap Between '{0}' and '{1}'", a, b);
            }
            
            return ConnectionDB.getData(sql);
        }

        public int DeletePhieuThu(string maPhieu)
        {
            string sql = string.Format("DELETE FROM [BANGKE_PHIEUTHUTIEN] WHERE MaPhieuBangKe = '{0}'", maPhieu);
            return ConnectionDB.ExcuteNonQuery(sql);
               
        }
    }
}
