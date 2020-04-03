using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_ProductManagement.DTO
{
    public class SetIDAutomatic
    {
        public static string getIDAutomatic2(string oldID)  // 2 ký số đầu
        {
            string IDHead = oldID.Substring(0, oldID.Length - 4);
            string IDTail = oldID.Substring(oldID.Length - 4);
            int indexLast = int.Parse(IDTail);
            indexLast++;
            
            if(indexLast < 9 && indexLast > 0)
            {
                return IDHead + "0" + indexLast;
            }
            return IDHead + "" + indexLast;
        }

        public static string getIDAutomatic3(string oldID)  // 3 ký số đầu
        {
            // NCC000025

            string IDHead = oldID.Substring(0, oldID.Length - 3);
            string IDTail = oldID.Substring(oldID.Length - 3);
            int indexLast = int.Parse(IDTail);
            indexLast++;

            if (indexLast < 9 && indexLast > 0)
            {
                return IDHead + "0" + indexLast;
            }
            return IDHead + "" + indexLast;
        }

    }
}
