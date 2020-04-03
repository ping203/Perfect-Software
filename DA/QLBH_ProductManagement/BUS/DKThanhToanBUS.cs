using QLBH_ProductManagement.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_ProductManagement.BUS
{
    public class DKThanhToanBUS
    {
        DKThanhToanDAO dkThanhToan = new DKThanhToanDAO();
        public DataTable loadDKThanhToan()
        {
            return dkThanhToan.loadDKThanhToan();
        }
    }
}
