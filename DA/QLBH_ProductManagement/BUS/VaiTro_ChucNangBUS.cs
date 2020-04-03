using QLBH_ProductManagement.DAO;
using QLBH_ProductManagement.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_ProductManagement.BUS
{
    public class VaiTro_ChucNangBUS
    {
        VaiTro_ChucNangDAO VaiTro_ChucNangDAO = new VaiTro_ChucNangDAO();
        public int ThemVTCN(VaiTro_ChucNangDTO vtcn)
        {
            return VaiTro_ChucNangDAO.ThemVTCN(vtcn);
        }

        public int SuaVTCN(VaiTro_ChucNangDTO vtcn)
        {
            return VaiTro_ChucNangDAO.SuaVTCN(vtcn);
        }

        public int XoaVTCN(string mavt)
        {
            return VaiTro_ChucNangDAO.XoaVTCN(mavt);
        }
    }
}
