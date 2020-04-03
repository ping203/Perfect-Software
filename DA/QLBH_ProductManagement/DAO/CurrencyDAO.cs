using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBH_ProductManagement.DTO;

namespace QLBH_ProductManagement.DAO
{
    public class CurrencyDAO
    {
        public List<CurrencyDTO> getRates()
        {
            string sql = "SELECT * FROM TIENTE";
            DataTable data = ConnectionDB.getData(sql);
            List<CurrencyDTO> list = new List<CurrencyDTO>();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                CurrencyDTO rates = new CurrencyDTO();
                rates.iMaTT = data.Rows[i]["MaTT"].ToString();
                rates.iTenTT = data.Rows[i]["TenTT"].ToString();
                rates.iTGQD = float.Parse(data.Rows[i]["TGQD"].ToString());
                rates.iActive = bool.Parse(data.Rows[i]["Active"].ToString());
                list.Add(rates);
            }
            return list;
        }
        public int InsertCurrent(CurrencyDTO cur)
        {
            string sql = string.Format("INSERT INTO TIENTE VALUES('{0}', N'{1}', {2}, {3})", cur.iMaTT, cur.iTenTT, cur.iTGQD, 1);
            return ConnectionDB.ExcuteNonQuery(sql);
        }

        public int Delete(string ma)
        {
            string sql = string.Format("DELETE FROM TIENTE WHERE maTT = '{0}'", ma);
            return ConnectionDB.ExcuteNonQuery(sql);
        }

        public int UpdateCur(CurrencyDTO cu)
        {
            string sql = string.Format("Update TIENTE SET Active = '{0}', TenTT = N'{1}', TGQD = {2} where MaTT = '{3}'", cu.iActive, cu.iTenTT, cu.iTGQD, cu.iMaTT);
            return ConnectionDB.ExcuteNonQuery(sql);
        }

        public CurrencyDTO getCurrentcy(string maPhieu)
        {
            string sql = string.Format("SELECT * FROM TIENTE WHERE MaTT = '{0}'", maPhieu);
            DataTable data = ConnectionDB.getData(sql);
            CurrencyDTO curDTO = new CurrencyDTO();
            if (data.Rows.Count > 0)
            {

                curDTO.iMaTT = data.Rows[0]["MaTT"].ToString();
                curDTO.iTenTT = data.Rows[0]["TenTT"].ToString();

                curDTO.iTGQD = float.Parse(data.Rows[0]["TGQD"].ToString());
                curDTO.iActive = bool.Parse(data.Rows[0]["Active"].ToString());
            }
            return curDTO;
        }
    }
}
