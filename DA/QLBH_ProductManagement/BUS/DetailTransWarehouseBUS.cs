using QLBH_ProductManagement.DAO;
using QLBH_ProductManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace QLBH_ProductManagement.BUS
{
    public class DetailTransWarehouseBUS
    {
        DetailTransWarehouseDAO ckDao = new DetailTransWarehouseDAO();

        public DataTable getListChiTietChuyenKho()
        {
            return ckDao.getListChiTietChuyenKho();
        }

        public DataTable getChiTietHienThiChuyenKho()
        {
            return ckDao.getChiTietHienThiChuyenKho();
        }
        public int InsertDetailTransWarehouse(DetailTransWarehouseDTO detailTrans)
        {
            return ckDao.InsertDetailTransWarehouse(detailTrans);
        }
        public DataTable getDetailTransWarehouse(DateTime a, DateTime b, int check)  // hiển thị chi tiết chuyển kho theo hàng hóa
        {
            return ckDao.getDetailTransWarehouse(a, b, check);
        }
        public int DeleteDetailTransWarehouse(string maPhieu)
        {
            return ckDao.DeleteDetailTransWarehouse(maPhieu);
        }
        public List<DetailTransWarehouseDTO> getListDetailTrans()
        {
            return ckDao.getListDetailTrans();
        }
        public DataTable getDetailTransFromMa(string maPhieuChuyen)
        {
            return ckDao.getDetailTransFromMa(maPhieuChuyen);
        }

        public List<DetailTransWarehouseDTO> getListDetailTransFromMa(string maChuyen)
        {
            return ckDao.getListDetailTransFromMa(maChuyen);
        }
      
    }
}
