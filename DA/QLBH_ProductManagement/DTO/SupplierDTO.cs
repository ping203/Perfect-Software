namespace QLBH_ProductManagement.DTO
{
    public class SupplierDTO
    {
           public string MaNCC {get;set;}
           public string TenNCC {get;set;}
	       public string NguoiLienHe {get;set;}
	       public string ChucVu {get;set;}
	       public string DiaChi {get;set;}
	       public string DienThoai {get;set;}
	       public string DiDong {get;set;}
	       public string Fax {get;set;}
	       public bool Active {get;set;}
	       public string MaKV  {get;set;}

        // công nợ:

           public float SoDuDauKy { get; set; }
           public float PhatSinhTrongKy { get; set; }
           public float ChiTrongKy { get; set; }
           public float SoDuCongNo { get; set; }
           public string KhuVuc { get; set; }

        // Báo Cao Ngầy

            public float TongChiPhi { get; set; }

    }
}
