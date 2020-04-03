using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_ProductManagement.DTO
{
    public class CurrencyDTO
    {
        private string MaTT;
        private string TenTT;
        private float TGQD;
        private bool Active;

        public string iMaTT { get => MaTT; set => MaTT = value; }
        public string iTenTT { get => TenTT; set => TenTT = value; }
        public float iTGQD { get => TGQD; set => TGQD = value; }
        public bool iActive { get => Active; set => Active = value; }
    }
}
