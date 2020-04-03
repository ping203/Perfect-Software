using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_ProductManagement.DTO
{
    public class GoodDTO
    {
        public string MaHang      {get; set;}
        
        public string TenHang     {get; set;}
	    public float GiaMua      {get; set;}
	    public float GiabanLe      {get; set;}
	    public float GiaBanSi      {get; set;}
	    
	    public string TinhChat      {get; set;}	  
	    public bool Active      {get; set;}
	    public string MaNhom      {get; set;}
        public string MaDonVi { get; set; }
        public string MaNCC { get; set; }
        public string MaKho { get; set; }

       public int SoLuongToiThieu {get; set;}
       public string TenKho       {get; set;}
        public string TenDV { get; set; }
        public string TenNhom { get; set;}
        

    }
}
