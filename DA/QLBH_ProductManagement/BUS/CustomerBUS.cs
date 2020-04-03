using QLBH_ProductManagement.DAO;
using QLBH_ProductManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace QLBH_ProductManagement.BUS
{
    public class CustomerBUS
    {
        CustomerDAO customer = new CustomerDAO();

        public List<CustomerDTO> getListKhachHangMuaHang(DateTime a, DateTime b, int check)
        {
            return customer.getListKhachHangMuaHang(a, b, check);
        }
        public DataTable getCusDatatable()
        {
            return customer.getCusDatatable();
        }

        public int UpdateKhachHang(CustomerDTO cusDTO)
        {
            return customer.UpdateKhachHang(cusDTO);
        }

        public CustomerDTO getInforCustomer(string maKH)
        {
            return customer.getInforCustomer(maKH);
        }


        public string getMaKHLast()
        {
            return customer.getMaKHLast();
        }
        public int InsertKhachHang(CustomerDTO cusDTO)
        {
            return customer.InsertKhachHang(cusDTO);
        }

        public int DeleteKhachHang(string maKH)
        {
            return customer.DeleteKhachHang(maKH);
        }

        public List<CustomerDTO> getDataCustomer(string makv)
        {
            return customer.getDataCustomer(makv);
        }

        public DataTable getCusDatatableWithKV()
        {
            return customer.getCusDatatableWithKV();
        }
    }
}
