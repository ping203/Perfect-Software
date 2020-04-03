using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_ProductManagement.DTO
{
    public class TonKho
    {
           public string MaHang { get; set; }
           //public string TenHang    {get; set;}
	       //public string DonVi      {get; set;}
	       public int SoLuongTon    {get; set;}
           public int SoLuongToiThieu { get; set; }
           public string MaKho      {get; set;}
	      // public string NhomHang   {get; set;}
	       public bool Active     {get; set;}


    }
}
