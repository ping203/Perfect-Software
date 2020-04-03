using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBH_ProductManagement.DTO;

namespace QLBH_ProductManagement.DAO
{
    public class UnitDAO
    {
        public DataTable getUnitDataTable()
        {
            string sql = "select Ten, MaDVT from DONVITINH";
            DataTable dt = ConnectionDB.getData(sql);
            return dt;
        }

        public string getNameUnit(string maDV)
        {
            string sql = string.Format("Select Ten from DONVITINH where MaDVT =  '{0}'", maDV);
            DataTable data = ConnectionDB.getData(sql);
            string name = data.Rows[0]["Ten"].ToString();
            return name;
        }

        public string getMaDVUnit(string nameDV)
        {
            string sql = string.Format("Select MADVT from DONVITINH where Ten =  N'{0}'", nameDV);
            DataTable data = ConnectionDB.getData(sql);
            string maDV = data.Rows[0]["MADVT"].ToString();
            return maDV;
        }

        public List<UnitDTO> getUnit()
        {
            string sql = "SELECT * FROM DONVITINH";
            DataTable data = ConnectionDB.getData(sql);
            List<UnitDTO> list = new List<UnitDTO>();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                UnitDTO unit = new UnitDTO();
                unit.iMaDVT = data.Rows[i]["MaDVT"].ToString();
                unit.iTen = data.Rows[i]["Ten"].ToString();
                unit.iGhiChu = data.Rows[i]["GhiChu"].ToString();
                unit.iActive = bool.Parse(data.Rows[i]["Active"].ToString());
                list.Add(unit);
            }
            return list;
        }


        public string IDAuto()
        {
            return Convert.ToString(ConnectionDB.ExecScalar("select dbo.SetAutoIdDVT()"));
        }
        public int insertUnit(UnitDTO unit)
        {
            string id = IDAuto();

            string sql = string.Format(" insert into DONVITINH (MaDVT, Ten, GhiChu, Active) values" +
                            "('{0}', N'{1}', N'{2}', N'{3}')", id, unit.iTen, unit.iGhiChu, unit.iActive);
            try
            {
                ConnectionDB.ExecNonQuery(sql);
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public int updateUnit(UnitDTO unit)
        {
            string sql = string.Format(" update DONVITINH " +
                                       " set Ten = N'{0}', GhiChu = N'{1}', Active = N'{2}' " +
                                       " where MaDVT = '{3}' ", unit.iTen, unit.iGhiChu, unit.iActive, unit.iMaDVT);

            try
            {
                ConnectionDB.ExecNonQuery(sql);
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public int deleteUnit(string madvt)
        {
            string sql = string.Format(" delete from DONVITINH where MaDVT = N'{0}'", madvt);

            try
            {
                ConnectionDB.ExecNonQuery(sql);
                return 1;
            }
            catch
            {
                return 0;
            }
        }
    }
}