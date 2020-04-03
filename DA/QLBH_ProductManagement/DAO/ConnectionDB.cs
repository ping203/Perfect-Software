using DevExpress.XtraScheduler.Outlook.Interop;
using System.Data;
using System.Data.SqlClient;

namespace QLBH_ProductManagement.DAO
{
    public class ConnectionDB
    {
        // Link Của Dũng

        //static string path = "Data Source=DESKTOP-EKT2OFS;Initial Catalog=PM_QLBH;Integrated Security=True";
        //static SqlConnection con = new SqlConnection(path);

        // Link Của Diễm 

        static SqlConnection con = new SqlConnection("Data Source=DIEMKIRI\\MYDIEM;Initial Catalog=PM_QLBH;Integrated Security=True");

        // Link Của Thi

       // static SqlConnection con = new SqlConnection(@"Data Source=ANHTHI\SQLSEVER;Initial Catalog=PM_QLBH;Integrated Security=True");

        public void OpenConnection()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public void CloseConnection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        public static DataTable getData(string sql)
        {
            DataTable data = new DataTable();
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(data);
            return data;
        }

        public static object ExcuteQuery(string sql)
        {
            ConnectionDB connectionDB = new ConnectionDB();
            connectionDB.OpenConnection();
            SqlCommand com = new SqlCommand(sql, con);
            object check = com.ExecuteScalar();
            connectionDB.CloseConnection();
            return check;
        }

        public static int ExcuteNonQuery(string sql)
        {

            ConnectionDB connectionDB = new ConnectionDB();

            connectionDB.OpenConnection();

            int nRow = 0;
            nRow = connectionDB.ExecuteNonQuery(CommandType.Text, sql);

            connectionDB.CloseConnection();

            return nRow;
        }
      
        // Insert, Update, Delete
        // Dùng tham số
        public int ExecuteNonQuery(CommandType cmdType, string strSql, params SqlParameter[] parameters)
        {
            try
            {
                SqlCommand command = con.CreateCommand();
                command.CommandText = strSql;
                command.CommandType = cmdType;
                if (parameters != null && parameters.Length > 0)
                {
                    command.Parameters.AddRange(parameters);
                }

                int nRow = command.ExecuteNonQuery();
                return nRow;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        // Insert, Update, Delete
        // Không dùng tham số
        public int ExecuteNonQuery(CommandType cmdType, string strSql)
        {
            try
            {
                SqlCommand command = con.CreateCommand();
                command.CommandText = strSql;
                command.CommandType = cmdType;

                int nRow = command.ExecuteNonQuery();
                return nRow;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }


        //Thực thi một câu lệnh truy vấn không quan tâm đến kết quả trả về.
        //Dùng cho insert, update, delete....
        public static void ExecNonQuery(string sql)
        {
            ConnectionDB connectionDB = new ConnectionDB();
            connectionDB.OpenConnection();

            SqlCommand command = con.CreateCommand();
            command.CommandText = sql;
            command.ExecuteNonQuery();

            connectionDB.CloseConnection();
        }

        //Thực thi một câu lệnh truy vấn trả về 1 kết quả duy nhất
        public static object ExecScalar(string sql)
        {
            ConnectionDB connectionDB = new ConnectionDB();
            connectionDB.OpenConnection();
            SqlCommand command = con.CreateCommand();
            command.CommandText = sql;
            object o = command.ExecuteScalar();
            connectionDB.CloseConnection();
            return o;
        }

        public static string GetIDLast(string sql)
        { 
            DataTable data = getData(sql);
            string idLast = data.Rows[0][0].ToString();
            return idLast;
        }
        public static void BackUpDatabase(string path, string db)
        {
            string sql = string.Format("Backup database {0} to disk = '{1}'",
                db, path);

            ConnectionDB connectionDB = new ConnectionDB();
            connectionDB.OpenConnection();

            connectionDB.ExecuteNonQuery(CommandType.Text, sql);

            connectionDB.CloseConnection();
        }
        public static void RestoreDatabase(string path, string db)
        {
            string sql = string.Format("Restore database {0} from disk = '{1}'",
                db, path);

            ConnectionDB connectionDB = new ConnectionDB();
            connectionDB.OpenConnection();

            connectionDB.ExecuteNonQuery(CommandType.Text, sql);

            connectionDB.CloseConnection();
        }
        public static DataTable LayDuLieuBang(string sql)
        {

            ConnectionDB connectionDB = new ConnectionDB();
            connectionDB.OpenConnection();

            DataTable dt = connectionDB.Select(CommandType.Text, sql);

            connectionDB.CloseConnection();

            return dt;
        }
        public DataTable Select(CommandType cmdType, string strSql)
        {
            try
            {
                SqlCommand command = con.CreateCommand();
                command.CommandText = strSql;
                command.CommandType = cmdType;

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int ExecuteScalar(CommandType cmdType, string strSql)
        {
            try
            {
                SqlCommand command = con.CreateCommand();
                command.CommandText = strSql;
                command.CommandType = cmdType;

                int nRow = (int)command.ExecuteScalar();
                return nRow;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public static int LaySoDong(string sql)
        {
            ConnectionDB connectionDB = new ConnectionDB();
            connectionDB.OpenConnection();

            int row = connectionDB.ExecuteScalar(CommandType.Text, sql);

            connectionDB.CloseConnection();

            return row;
        }
        public static string GenerateMa(string tenSP)
        {
            string sql = tenSP;

            ConnectionDB connectionDB = new ConnectionDB();
            connectionDB.OpenConnection();

            SqlParameter ma = new SqlParameter("@kq", SqlDbType.VarChar, 10);
            ma.Direction = ParameterDirection.Output;

            connectionDB.ExecuteNonQuery(CommandType.StoredProcedure, sql, ma);

            connectionDB.CloseConnection();

            return ma.Value.ToString();
        }
    }
}
