using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBH_ProductManagement.DAO;
using QLBH_ProductManagement.DTO;

namespace QLBH_ProductManagement.BUS
{
    public class CurrencyBUS
    {
        CurrencyDAO ratesDAO = new CurrencyDAO();
        public List<CurrencyDTO> getRates()
        {
            return ratesDAO.getRates();
        }

        public int InsertCurrent(CurrencyDTO cur)
        {
            return ratesDAO.InsertCurrent(cur);
        }

        public CurrencyDTO getCurrentcy(string maPhieu)
        {
            return ratesDAO.getCurrentcy(maPhieu);
        }
        public int UpdateCur(CurrencyDTO cu)
        {
            return ratesDAO.UpdateCur(cu);
        }
        public int Delete(string ma)
        {
            return ratesDAO.Delete(ma);
        }
    }
}
