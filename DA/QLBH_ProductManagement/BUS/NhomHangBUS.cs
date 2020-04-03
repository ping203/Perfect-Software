using QLBH_ProductManagement.DAO;
using QLBH_ProductManagement.DTO;
using System.Collections.Generic;
using System.Data;

namespace QLBH_ProductManagement.BUS
{
    public class NhomHangBUS
    {
        NhomHangDAO nhDAO = new NhomHangDAO();

        public DataTable LoadNhomHang()
        {
            return nhDAO.LoadNhomHang();
        }

        public int DeleteNhomHang(string maNhom)
        {
            return nhDAO.DeleteListFromMa(maNhom);
        }

        public List<NhomHang> getListNhomHang()
        {
            return nhDAO.getListNhomHang();
        }
        public string IDAuto()
        {
            return nhDAO.IDAuto();
        }
        public int UpdateNhomHang(NhomHang nhomHang)
        {
            return nhDAO.UpdateNhomHang(nhomHang);
        }
        public int InsertNhomHang(string ma, string ten, string ghichu, bool active)
        {
            return nhDAO.InsertNhomHang(ma, ten, ghichu, active);
        }
    }
}
