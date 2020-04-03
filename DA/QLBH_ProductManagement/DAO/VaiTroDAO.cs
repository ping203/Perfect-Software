using QLBH_ProductManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_ProductManagement.DAO
{
    public class VaiTroDAO
    {
        public DataTable LayDuLieuVaiTro(string sql)
        {
            return ConnectionDB.LayDuLieuBang(sql);
        }

        public int ThemVaiTro(VaiTro vt)
        {
            int kichhoat = vt.KichHoat == true ? 1 : 0;
            string sql = string.Format("insert into VAITRO(MaVaiTro, TenVaiTro, DienGiai, KichHoat) values" +
                "('{0}', '{1}', N'{2}', {3})", vt.MaVaiTro, vt.TenVaiTro, vt.DienGiai, kichhoat);

            return Execute.InsertUpdateDelete(sql);
        }

        public int SuaVaiTro(VaiTro vt)
        {
            int kichhoat = vt.KichHoat == true ? 1 : 0;
            string sql = string.Format("update VAITRO " +
                "set TenVaiTro = '{0}', DienGiai = N'{1}', KichHoat = {2} where MaVaiTro = '{3}'", vt.TenVaiTro, vt.DienGiai, kichhoat, vt.MaVaiTro);

            return ConnectionDB.ExcuteNonQuery(sql);
        }

        public int XoaVaiTro(string mavt)
        {
            string sql = "delete from VAITRO where MaVaiTro = '" + mavt + "'";

            return ConnectionDB.ExcuteNonQuery(sql);
        }
    }
}
