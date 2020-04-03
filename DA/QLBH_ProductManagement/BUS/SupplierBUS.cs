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
    public class SupplierBUS
    {
        SupplierDAO supplierDAO = new SupplierDAO();
        public List<SupplierDTO> getListNCCMuaHang(int check, DateTime a, DateTime b)
        {
            return supplierDAO.getListNCCMuaHang(check, a, b);
        }

        public DataTable getNCC()
        {
            return supplierDAO.getNCC();
        }

        public int UpdateSup(SupplierDTO supDTO)
        {
            return supplierDAO.UpdateSup(supDTO);
        }

        public SupplierDTO getInforSup(string maNCC)
        {
            return supplierDAO.getInforSup(maNCC);
        }


        public string getMaNCCLast()
        {
            return supplierDAO.getMaNCCLast();
        }

        public int InsertSupplier(SupplierDTO sup)
        {
            return supplierDAO.InsertSupplier(sup);
        }

        public int DeleteSupplierFromNCC(string maNCC)
        {
            return supplierDAO.DeleteSupplierFromNCC(maNCC);
        }

        public List<SupplierDTO> getSupplierFromNCC(string maNCC)
        {
            return supplierDAO.getSupplierFromNCC(maNCC);
        }
        public List<SupplierDTO> getNCCBanHang()
        {
            return supplierDAO.getNCCBanHang();
        }
        public DataTable getNCCWithNCC()
        {
            return supplierDAO.getNCCWithNCC();
        }
    }


}