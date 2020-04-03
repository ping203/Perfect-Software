using QLBH_ProductManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_ProductManagement.DAO
{
    public class PhieuChiTienDAO
    {
        public int InsertPhieuChiTien(PhieuChiTien pcTien)
        {
            string sql = string.Format("INSERT INTO [BANGKE_PHIEUCHITIEN] VALUES('{0}', '{1}', '{2}', '{3}', N'{4}', {5}, N'{6}' ,N'{7}')", pcTien.MaPhieu, pcTien.MaChungTu, pcTien.NgayLap, pcTien.MaNCC, pcTien.TenNCC, pcTien.SoTien, pcTien.TenNV ,pcTien.GhiChu);
            return ConnectionDB.ExcuteNonQuery(sql);
        }

        public string IDAuto()
        {
            return Convert.ToString(ConnectionDB.ExecScalar("select dbo.SetAutoIdBANGKE_PHIEUCHITIEN()"));
        }

        public DataTable LoadPhieuChiTien(DateTime a, DateTime b, int check)
        {
            string sql;
            if (check == 0)
            {
                sql = "SELECT * FROM BANGKE_PHIEUCHITIEN";
            }
            else
            {
                sql = string.Format("SELECT * FROM BANGKE_PHIEUCHITIEN WHERE NgayLap Between '{0}' and '{1}'", a, b);
            }

            return ConnectionDB.getData(sql);
        }

        public int DeletePhieuChi(string maPhieu)
        {
            string sql = string.Format("DELETE FROM [BANGKE_PHIEUCHITIEN] WHERE MaPhieuBangKe = '{0}'", maPhieu);
            return ConnectionDB.ExcuteNonQuery(sql);

        }

    }
}
