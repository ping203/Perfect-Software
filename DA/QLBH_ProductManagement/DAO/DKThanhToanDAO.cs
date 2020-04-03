using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_ProductManagement.DAO
{
    public class DKThanhToanDAO
    {
        public DataTable loadDKThanhToan()
        {
            string sql = "SELECT * FROM DIEUKHOAN_THANHOAN";
            return ConnectionDB.getData(sql);
        }
    }
}
