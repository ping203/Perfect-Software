using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_ProductManagement.DAO
{
    public class Execute
    {
        public static int InsertUpdateDelete(string sql)
        {
            ConnectionDB connectionDB = new ConnectionDB();

            connectionDB.OpenConnection();

            int nRow = 0;
            nRow = connectionDB.ExecuteNonQuery(CommandType.Text, sql);

            connectionDB.CloseConnection();

            return nRow;
        }
    }
}
