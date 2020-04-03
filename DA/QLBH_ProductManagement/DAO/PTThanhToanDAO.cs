using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_ProductManagement.DAO
{
    public class PTThanhToanDAO
    {
        public DataTable loadPTThanhToan()
        {
            string sql = "SELECT * FROM PHUONGTHUCTHANHTOAN";
            return ConnectionDB.getData(sql);
        }
    }
}
