using QLBH_ProductManagement.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_ProductManagement.DAO
{
    public class VaiTro_ChucNangDAO
    {
        public int ThemVTCN(VaiTro_ChucNangDTO vtcn)
        {
            string sql = string.Format("insert into VAITRO_CHUCNANG values" +
                "('{0}',{1},{2},{3},{4},{5},{6},{7},{8},{9})", vtcn.MaVaiTro, vtcn.MaChucNang, vtcn.TatCa, vtcn.TruyCap, vtcn.Them, vtcn.Xoa, vtcn.Sua, vtcn.InAn, vtcn.Nhap, vtcn.Xuat);

            return Execute.InsertUpdateDelete(sql);
        }

        public int SuaVTCN(VaiTro_ChucNangDTO vtcn)
        {
            string sql = "update VAITRO_CHUCNANG " +
                string.Format("set TatCa={0} , TruyCap={1} , Them={2} , Xoa={3} , Sua={4} , InAn={5} , Nhap={6} , Xuat={7}  where MaVaiTro ='{8}' and MaChucNang={9}",
                vtcn.TatCa, vtcn.TruyCap, vtcn.Them, vtcn.Xoa, vtcn.Sua, vtcn.InAn, vtcn.Nhap, vtcn.Xuat, vtcn.MaVaiTro, vtcn.MaChucNang);

            return ConnectionDB.ExcuteNonQuery(sql);
        }

        public int XoaVTCN(string mavt)
        {
            string sql = "delete from VAITRO_CHUCNANG where MaVaiTro = '" + mavt + "'";

            return ConnectionDB.ExcuteNonQuery(sql);
        }
    }
}
