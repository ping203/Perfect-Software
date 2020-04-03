using QLBH_ProductManagement.DAO;
using QLBH_ProductManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_ProductManagement.BUS
{
    public class VaiTroBUS
    {
        VaiTroDAO vaiTroDAO = new VaiTroDAO();
        public DataTable LayDuLieuVaiTro(string sql)
        {
            return vaiTroDAO.LayDuLieuVaiTro(sql);
        }

        public int ThemVaiTro(VaiTro vt)
        {
            return vaiTroDAO.ThemVaiTro(vt);
        }

        public int SuaVaiTro(VaiTro vt)
        {
            return vaiTroDAO.SuaVaiTro(vt);
        }

        public int XoaVaiTro(string mavt)
        {
            return vaiTroDAO.XoaVaiTro(mavt);
        }
    }
}
