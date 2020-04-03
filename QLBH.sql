
use master
Go
if(DB_ID('PM_QLBH')) is not null
	Drop Database PM_QLBH
Go


CREATE DATABASE PM_QLBH
GO

USE PM_QLBH
GO


-- BẢNG KHÁCH HÀNG

begin
CREATE TABLE [dbo].[KHACHHANG](
	[MaKH] [nchar](10) NOT NULL,
	[TenKH] [nvarchar](50) NULL,
	[NguoiLienHe] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[DienThoai] [nvarchar](20) NULL,
	[DiDong] [nvarchar](20) NULL,
	[Fax] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Website] [nvarchar](20) NULL,
	[MaSoThue] [nvarchar](50) NULL,
	[SoTK] [nvarchar](50) NULL,
	[TenNganHang] [nvarchar](50) NULL,
	[Active] [bit] NULL,
	[MaKV]  [nchar](10) NULL,
 CONSTRAINT [PK_KHACHHANG] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
) ON [PRIMARY] FILESTREAM_ON [FILESTREAM_CMMS_DATA]
) ON [PRIMARY] 
end
GO

INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [NguoiLienHe], [DiaChi], [DienThoai], [DiDong], [Fax], [Email], [Website], [MaSoThue], [SoTK], [TenNganHang], [Active], [MaKV]) VALUES (N'KH000001', N'Công ty Quang Phúc',				N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', 1 , N'KV000001')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [NguoiLienHe], [DiaChi], [DienThoai], [DiDong], [Fax], [Email], [Website], [MaSoThue], [SoTK], [TenNganHang], [Active], [MaKV]) VALUES (N'KH000002', N'Thông_ anh An 451 Hai Bà Trưng',	N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', 1 , N'KV000002')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [NguoiLienHe], [DiaChi], [DienThoai], [DiDong], [Fax], [Email], [Website], [MaSoThue], [SoTK], [TenNganHang], [Active], [MaKV]) VALUES (N'KH000003', N'Huệ_GPS Thủ Đức',					N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', 1 , N'KV000003')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [NguoiLienHe], [DiaChi], [DienThoai], [DiDong], [Fax], [Email], [Website], [MaSoThue], [SoTK], [TenNganHang], [Active], [MaKV]) VALUES (N'KH000004', N'Huệ_Lê Trực',						N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', 1 , N'KV000001')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [NguoiLienHe], [DiaChi], [DienThoai], [DiDong], [Fax], [Email], [Website], [MaSoThue], [SoTK], [TenNganHang], [Active], [MaKV]) VALUES (N'KH000005', N'Thông_lock & lock Trần Hưng',		N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', 1 , N'KV000002')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [NguoiLienHe], [DiaChi], [DienThoai], [DiDong], [Fax], [Email], [Website], [MaSoThue], [SoTK], [TenNganHang], [Active], [MaKV]) VALUES (N'KH000006', N'A Trang Hitech',					N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', 1 , N'KV000003')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [NguoiLienHe], [DiaChi], [DienThoai], [DiDong], [Fax], [Email], [Website], [MaSoThue], [SoTK], [TenNganHang], [Active], [MaKV]) VALUES (N'KH000007', N'Dũng_Bệnh viện 115',				N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', 1 , N'KV000001')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [NguoiLienHe], [DiaChi], [DienThoai], [DiDong], [Fax], [Email], [Website], [MaSoThue], [SoTK], [TenNganHang], [Active], [MaKV]) VALUES (N'KH000008', N'Dũng_công ty Kiều An',			N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', 1 , N'KV000002')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [NguoiLienHe], [DiaChi], [DienThoai], [DiDong], [Fax], [Email], [Website], [MaSoThue], [SoTK], [TenNganHang], [Active], [MaKV]) VALUES (N'KH000009', N'Huệ_ anh Chương Hùng Vương Plaza',N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', 1 , N'KV000003')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [NguoiLienHe], [DiaChi], [DienThoai], [DiDong], [Fax], [Email], [Website], [MaSoThue], [SoTK], [TenNganHang], [Active], [MaKV]) VALUES (N'KH000010', N'Tuấn_Tech VN',					N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', 1 , N'KV000001')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [NguoiLienHe], [DiaChi], [DienThoai], [DiDong], [Fax], [Email], [Website], [MaSoThue], [SoTK], [TenNganHang], [Active], [MaKV]) VALUES (N'KH000011', N'Tuấn_Etown',						N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', 1 , N'KV000002')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [NguoiLienHe], [DiaChi], [DienThoai], [DiDong], [Fax], [Email], [Website], [MaSoThue], [SoTK], [TenNganHang], [Active], [MaKV]) VALUES (N'KH000012', N'Tuấn_Ngọc Phát',					N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', 1 , N'KV000003')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [NguoiLienHe], [DiaChi], [DienThoai], [DiDong], [Fax], [Email], [Website], [MaSoThue], [SoTK], [TenNganHang], [Active], [MaKV]) VALUES (N'KH000013', N'Tuấn_BIDV',						N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', 1 , N'KV000001')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [NguoiLienHe], [DiaChi], [DienThoai], [DiDong], [Fax], [Email], [Website], [MaSoThue], [SoTK], [TenNganHang], [Active], [MaKV]) VALUES (N'KH000014', N'Cao Đế Năng-Chị Thảo',			N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', 1 , N'KV000002')



-- LOẠI KHÁCH HÀNG

begin
CREATE TABLE [dbo].[LOAIKHACHHANG](
	[MaLoai] [nchar](10) NOT NULL,
	[TenLoai] [nvarchar](50) NULL,
 CONSTRAINT [PK_LOAIKHACHHANG] PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
) ON [PRIMARY] FILESTREAM_ON [FILESTREAM_CMMS_DATA]
) ON [PRIMARY] 
end
GO

-- HÀNG HÓA

begin
CREATE TABLE [dbo].[HANGHOA](
	[MaHang] [nchar](10) NOT NULL,
	[TenHang] [nvarchar](50) NULL,
	[DonVi] [nvarchar](10) NULL,
	[LoaiGia] [nvarchar](10) NULL,
	[SoLuong] [int] NULL,
	[DonGia] [float] NULL,
	[ThanhTien] [float] NULL,
	[CK%] [float] NULL,
	[ChietKhau] [float] NULL,
	[ThanhToan] [float] NULL,
 CONSTRAINT [PK_HANGHOA] PRIMARY KEY CLUSTERED 
(
	[MaHang] ASC
) ON [PRIMARY]
) ON [PRIMARY] 
end
GO  

-- LOẠI HÀNG HÓA:

begin
CREATE TABLE [dbo].[LOAIHANGHOA](
	[MaLoai] [nchar](10) NOT NULL,
	[MaNhom] [nchar](10) NULL,
	[TenLoai] [nvarchar](50) NULL,
 CONSTRAINT [PK_LOAIHANGHOA] PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
) ON [PRIMARY]
) ON [PRIMARY]
end
GO


-- NHÀ CUNG CẤP:

begin
CREATE TABLE [dbo].[NCC](
	[MaNCC] [nchar](10) NOT NULL,
	[TenNCC] [nvarchar](50) NULL,
	[NguoiLH] [nvarchar](50) NULL,
	[ChucVu] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[DienThoai] [varchar](20) NULL,
	[DiDong] [varchar](50) NULL,
	[Fax] [varchar](20) NULL,
	[Active] [bit] NULL,
	[MaKV]  [nchar](10) NULL,
 CONSTRAINT [PK_NCC] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
) ON [PRIMARY]
) ON [PRIMARY]
end
GO


GO
INSERT [dbo].[NCC] ([MaNCC], [TenNCC], [NguoiLH], [ChucVu], [DiaChi], [DienThoai], [DiDong], [Fax], [Active], [MaKV]) VALUES (N'NCC000001', N'Công ty CP Minh An',								N'', N'', N'', N'', N'', N'', 1, N'KV000003')
INSERT [dbo].[NCC] ([MaNCC], [TenNCC], [NguoiLH], [ChucVu], [DiaChi], [DienThoai], [DiDong], [Fax], [Active], [MaKV]) VALUES (N'NCC000004', N'Công ty TNHH TMDV Sao Việt',						N'', N'', N'', N'', N'', N'', 1, N'KV000001')
INSERT [dbo].[NCC] ([MaNCC], [TenNCC], [NguoiLH], [ChucVu], [DiaChi], [DienThoai], [DiDong], [Fax], [Active], [MaKV]) VALUES (N'NCC000005', N'Công ty Phúc Bình',								N'', N'', N'', N'', N'', N'', 1, N'KV000002')
INSERT [dbo].[NCC] ([MaNCC], [TenNCC], [NguoiLH], [ChucVu], [DiaChi], [DienThoai], [DiDong], [Fax], [Active], [MaKV]) VALUES (N'NCC000006', N'Công ty Hàn Việt',								N'', N'', N'', N'', N'', N'', 1, N'KV000003')
INSERT [dbo].[NCC] ([MaNCC], [TenNCC], [NguoiLH], [ChucVu], [DiaChi], [DienThoai], [DiDong], [Fax], [Active], [MaKV]) VALUES (N'NCC000007', N'Trung tâm kinh doanh di động BBMobile',           N'', N'', N'', N'', N'', N'', 1, N'KV000001')
INSERT [dbo].[NCC] ([MaNCC], [TenNCC], [NguoiLH], [ChucVu], [DiaChi], [DienThoai], [DiDong], [Fax], [Active], [MaKV]) VALUES (N'NCC000008', N'Công ty TNHH Thương mại Quốc Tế HPT Việt Nam',	N'', N'', N'', N'', N'', N'', 1, N'KV000002')
INSERT [dbo].[NCC] ([MaNCC], [TenNCC], [NguoiLH], [ChucVu], [DiaChi], [DienThoai], [DiDong], [Fax], [Active], [MaKV]) VALUES (N'NCC000009', N'Công ty MINH TÍN',								N'', N'', N'', N'', N'', N'', 1, N'KV000003')
INSERT [dbo].[NCC] ([MaNCC], [TenNCC], [NguoiLH], [ChucVu], [DiaChi], [DienThoai], [DiDong], [Fax], [Active], [MaKV]) VALUES (N'NCC000010', N'Công ty ESACO',									N'', N'', N'', N'', N'', N'', 1, N'KV000001')
INSERT [dbo].[NCC] ([MaNCC], [TenNCC], [NguoiLH], [ChucVu], [DiaChi], [DienThoai], [DiDong], [Fax], [Active], [MaKV]) VALUES (N'NCC000011', N'VŨ TOÀN THIỆN',									N'', N'', N'', N'', N'', N'', 1, N'KV000002')
INSERT [dbo].[NCC] ([MaNCC], [TenNCC], [NguoiLH], [ChucVu], [DiaChi], [DienThoai], [DiDong], [Fax], [Active], [MaKV]) VALUES (N'NCC000012', N'Công ty TNHH TMDV Sao Nam An',					N'', N'', N'', N'', N'', N'', 1, N'KV000003')
INSERT [dbo].[NCC] ([MaNCC], [TenNCC], [NguoiLH], [ChucVu], [DiaChi], [DienThoai], [DiDong], [Fax], [Active], [MaKV]) VALUES (N'NCC000013', N'Công ty TNHH Biển Bạc',							N'', N'', N'', N'', N'', N'', 1, N'KV000001')
INSERT [dbo].[NCC] ([MaNCC], [TenNCC], [NguoiLH], [ChucVu], [DiaChi], [DienThoai], [DiDong], [Fax], [Active], [MaKV]) VALUES (N'NCC000014', N'Tân Phát',										N'', N'', N'', N'', N'', N'', 1, N'KV000002')
INSERT [dbo].[NCC] ([MaNCC], [TenNCC], [NguoiLH], [ChucVu], [DiaChi], [DienThoai], [DiDong], [Fax], [Active], [MaKV]) VALUES (N'NCC000015', N'Công ty CP TM DV Thiết Bị Giám Sát Bảo Toàn',		N'', N'', N'', N'', N'', N'', 1, N'KV000003')
INSERT [dbo].[NCC] ([MaNCC], [TenNCC], [NguoiLH], [ChucVu], [DiaChi], [DienThoai], [DiDong], [Fax], [Active], [MaKV]) VALUES (N'NCC000016', N'Công ty TNHH TM DV Minh Nhãn',					N'', N'', N'', N'', N'', N'', 1, N'KV000001')
INSERT [dbo].[NCC] ([MaNCC], [TenNCC], [NguoiLH], [ChucVu], [DiaChi], [DienThoai], [DiDong], [Fax], [Active], [MaKV]) VALUES (N'NCC000017', N'Công ty Đại Minh',								N'', N'', N'', N'', N'', N'', 1, N'KV000002')
INSERT [dbo].[NCC] ([MaNCC], [TenNCC], [NguoiLH], [ChucVu], [DiaChi], [DienThoai], [DiDong], [Fax], [Active], [MaKV]) VALUES (N'NCC000018', N'Linh kiện vi tính Tân Phát',						N'', N'', N'', N'', N'', N'', 1, N'KV000003')
INSERT [dbo].[NCC] ([MaNCC], [TenNCC], [NguoiLH], [ChucVu], [DiaChi], [DienThoai], [DiDong], [Fax], [Active], [MaKV]) VALUES (N'NCC000019', N'Công ty  TNHH Đồng Bằng',							N'', N'', N'', N'', N'', N'', 1, N'KV000001')
INSERT [dbo].[NCC] ([MaNCC], [TenNCC], [NguoiLH], [ChucVu], [DiaChi], [DienThoai], [DiDong], [Fax], [Active], [MaKV]) VALUES (N'NCC000020', N'Công ty TNHH TMDV Truyền Thông Mặt Trời',			N'', N'', N'', N'', N'', N'', 1, N'KV000002')
INSERT [dbo].[NCC] ([MaNCC], [TenNCC], [NguoiLH], [ChucVu], [DiaChi], [DienThoai], [DiDong], [Fax], [Active], [MaKV]) VALUES (N'NCC000021', N'Cty TNHH Thương mại KT Tin Học Anh Ngọc',			N'', N'', N'', N'', N'', N'', 1, N'KV000003')
INSERT [dbo].[NCC] ([MaNCC], [TenNCC], [NguoiLH], [ChucVu], [DiaChi], [DienThoai], [DiDong], [Fax], [Active], [MaKV]) VALUES (N'NCC000022', N'Công ty CP Thế Giới Di Động',						N'', N'', N'', N'', N'', N'', 1, N'KV000001')
INSERT [dbo].[NCC] ([MaNCC], [TenNCC], [NguoiLH], [ChucVu], [DiaChi], [DienThoai], [DiDong], [Fax], [Active], [MaKV]) VALUES (N'NCC000023', N'Công ty TNHH TM TC Samsung',						N'', N'', N'', N'', N'', N'', 1, N'KV000002')
INSERT [dbo].[NCC] ([MaNCC], [TenNCC], [NguoiLH], [ChucVu], [DiaChi], [DienThoai], [DiDong], [Fax], [Active], [MaKV]) VALUES (N'NCC000024', N'Công ty CP TM Công Nghệ Điện Tử Viễn Thông TES',	N'', N'', N'', N'', N'', N'', 1, N'KV000003')




-- KHU VỰC

begin
CREATE TABLE [dbo].[KHUVUC](
	[MaKV] [nchar](10) NOT NULL,
	[TenKV] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](50) NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_KHUVUC] PRIMARY KEY CLUSTERED 
(
	[MaKV] ASC
) ON [PRIMARY]
) ON [PRIMARY]
end
GO


GO
INSERT [dbo].[KHUVUC] ([MaKV], [TenKV], [GhiChu], [Active]) VALUES (N'KV000001', N'Miền Nam', N'', 1)
INSERT [dbo].[KHUVUC] ([MaKV], [TenKV], [GhiChu], [Active]) VALUES (N'KV000002', N'Miền Bắc', N'', 1)
INSERT [dbo].[KHUVUC] ([MaKV], [TenKV], [GhiChu], [Active]) VALUES (N'KV000003', N'Miền Trung', N'', 1)

-- KHOHANG

begin
CREATE TABLE [dbo].[KHOHANG](
	[MaKho] [nchar](10) NOT NULL,
	[TenKho] [nvarchar](50) NULL,
	[LienHe] [nvarchar] (50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[DienThoai] [nvarchar](20) NULL,
	[KyHieu] [nvarchar](20) NULL,
	[GhiChu] [nvarchar](20) NULL,
	[MaNV] [nchar](10) NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_KHOHANG] PRIMARY KEY CLUSTERED 
(
	[MaKho] ASC
) ON [PRIMARY]
) ON [PRIMARY]
end
GO

GO
INSERT [dbo].[KHOHANG] ([MaKho], [TenKho], [LienHe], [DiaChi], [DienThoai], [KyHieu], [GhiChu], [MaNV], [Active]) VALUES (N'CT' , N'Kho công ty', N'', N'', N'', N'', N'',      NULL, 1)
INSERT [dbo].[KHOHANG] ([MaKho], [TenKho], [LienHe], [DiaChi], [DienThoai], [KyHieu], [GhiChu], [MaNV], [Active]) VALUES (N'CT2', N'Kho Hà Nội', N'', N'', N'', N'', N'',       NULL, 1)
INSERT [dbo].[KHOHANG] ([MaKho], [TenKho], [LienHe], [DiaChi], [DienThoai], [KyHieu], [GhiChu], [MaNV], [Active]) VALUES (N'CT3', N'Kho Phạm Văn Hai', N'', N'', N'', N'', N'', NULL, 1)
INSERT [dbo].[KHOHANG] ([MaKho], [TenKho], [LienHe], [DiaChi], [DienThoai], [KyHieu], [GhiChu], [MaNV], [Active]) VALUES (N'K000001', N'Kho 6 HCM', N'', N'', N'', N'', N'',    NULL, 1)


-- NHOMHANG

begin
CREATE TABLE [dbo].[NHOMHANG](
	[MaNhom] [nchar](10) NOT NULL,
	[TenNhom] [nvarchar](50) NULL,
	[GhiChu] [nvarchar] (50) NULL,
	[Active] [bit] NULL
 CONSTRAINT [PK_NHOMHANG] PRIMARY KEY CLUSTERED 
(
	[MaNhom] ASC
) ON [PRIMARY]
) ON [PRIMARY]
end
GO

GO
INSERT [dbo].[NHOMHANG] ([MaNhom], [TenNhom], [GhiChu], [Active]) VALUES (N'ANS' , N'An ninh siêu thị', N'', 1)
INSERT [dbo].[NHOMHANG] ([MaNhom], [TenNhom], [GhiChu], [Active]) VALUES (N'BAT', N'Báo trộm, báo cháy', N'', 1)
INSERT [dbo].[NHOMHANG] ([MaNhom], [TenNhom], [GhiChu], [Active]) VALUES (N'CAM', N'Camera quan sát', N'', 1)
INSERT [dbo].[NHOMHANG] ([MaNhom], [TenNhom], [GhiChu], [Active]) VALUES (N'CARCAM', N'Camera hành trình', N'', 1)
INSERT [dbo].[NHOMHANG] ([MaNhom], [TenNhom], [GhiChu], [Active]) VALUES (N'CHA' , N'Máy chấm công', N'', 1)
INSERT [dbo].[NHOMHANG] ([MaNhom], [TenNhom], [GhiChu], [Active]) VALUES (N'CHM', N'Chuông cửa màn hình', N'', 1)
INSERT [dbo].[NHOMHANG] ([MaNhom], [TenNhom], [GhiChu], [Active]) VALUES (N'DAC', N'Dây cáp', N'', 1)
INSERT [dbo].[NHOMHANG] ([MaNhom], [TenNhom], [GhiChu], [Active]) VALUES (N'DAG', N'Đầu ghi', N'', 1)
INSERT [dbo].[NHOMHANG] ([MaNhom], [TenNhom], [GhiChu], [Active]) VALUES (N'KIS' , N'Kiểm soát ra vào', N'', 1)
INSERT [dbo].[NHOMHANG] ([MaNhom], [TenNhom], [GhiChu], [Active]) VALUES (N'NH000001', N'Hàng cũ', N'', 1)
INSERT [dbo].[NHOMHANG] ([MaNhom], [TenNhom], [GhiChu], [Active]) VALUES (N'NH000002', N'Secure display', N'', 1)
INSERT [dbo].[NHOMHANG] ([MaNhom], [TenNhom], [GhiChu], [Active]) VALUES (N'OCU', N'Ổ cứng',N'', 1)
INSERT [dbo].[NHOMHANG] ([MaNhom], [TenNhom], [GhiChu], [Active]) VALUES (N'TBK' , N'Thiết bị khác', N'', 1)
INSERT [dbo].[NHOMHANG] ([MaNhom], [TenNhom], [GhiChu], [Active]) VALUES (N'TBN', N'Thiết bị hội nghị', N'', 1)
INSERT [dbo].[NHOMHANG] ([MaNhom], [TenNhom], [GhiChu], [Active]) VALUES (N'TBV', N'Thiết bị định vị', N'', 1)
INSERT [dbo].[NHOMHANG] ([MaNhom], [TenNhom], [GhiChu], [Active]) VALUES (N'TDKL', N'Tay dò kim loại', N'', 1)

-- DONVITINH

begin
CREATE TABLE [dbo].[DONVITINH](
	[MaDVT] [nchar](10) NOT NULL,
	[Ten] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](50) NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_DONVITINH] PRIMARY KEY CLUSTERED 
(
	[MaDVT] ASC
) ON [PRIMARY]
) ON [PRIMARY]
end
GO

go
INSERT [dbo].[DONVITINH] ([MaDVT], [Ten], [GhiChu], [Active]) VALUES (N'DV01', N'cái', N'', 1)
INSERT [dbo].[DONVITINH] ([MaDVT], [Ten], [GhiChu], [Active]) VALUES (N'DV02', N'bộ', N'', 1)
INSERT [dbo].[DONVITINH] ([MaDVT], [Ten], [GhiChu], [Active]) VALUES (N'DV03', N'Thùng', N'', 1)
INSERT [dbo].[DONVITINH] ([MaDVT], [Ten], [GhiChu], [Active]) VALUES (N'DV04', N'cái', N'', 1)


-- TIENTE

begin
CREATE TABLE [dbo].[TIENTE](
	[MaTT] [nchar](10) NOT NULL,
	[TenTT] [nvarchar](50) NULL,
	[TGQD] [float] NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_TIENTE] PRIMARY KEY CLUSTERED 
(
	[MaTT] ASC
) ON [PRIMARY]
) ON [PRIMARY]
end
GO

go
INSERT [dbo].[TIENTE] ([MaTT], [TenTT], [TGQD], [Active]) VALUES (N'VND', N'Việt Nam Đồng', 1, 1)
INSERT [dbo].[TIENTE] ([MaTT], [TenTT], [TGQD], [Active]) VALUES (N'USD', N'Dola My', 20.000, 1)
INSERT [dbo].[TIENTE] ([MaTT], [TenTT], [TGQD], [Active]) VALUES (N'GBP', N'Bang Anh', 26.149, 1)
INSERT [dbo].[TIENTE] ([MaTT], [TenTT], [TGQD], [Active]) VALUES (N'EUR', N'Đồng tiền chung EU', 17.988, 1)





begin
CREATE TABLE [dbo].[PHUONGTHUCTHANHTOAN](
	[MaPT] [nchar](10) NOT NULL,
	[TenPT] [nvarchar](50) NULL,
	[KiHieu] [nvarchar](50) NULL,

 CONSTRAINT [PK_PTTT] PRIMARY KEY CLUSTERED 
(
	[MaPT] ASC
) ON [PRIMARY]
) ON [PRIMARY] 
end

GO  

go
INSERT [dbo].[PHUONGTHUCTHANHTOAN] ([MaPT], [TenPT], [KiHieu]) VALUES (N'TM', N'Tiền mặt', '11111111-1111-1111-1111-1111111111111')
INSERT [dbo].[PHUONGTHUCTHANHTOAN] ([MaPT], [TenPT], [KiHieu]) VALUES (N'CK', N'Chuyển khoản', '22222222-2222-2222-222222222222')


-- PHIẾU NHẬP HÀNG

begin
CREATE TABLE [dbo].[PHIEUNHAPHANG](
	[MaPhieu] [nchar](10) NOT NULL,
	[TenNCC] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](10) NULL,
	[DienThoai] [float] NULL,
	[GhiChu] [float] NULL,
	[SoHoaDonVAT] [float] NULL,
	[SoPhieuVietTay] [float] NULL,
	[NgaylapPhieu] [datetime] NULL,
	[DKTT] [nvarchar](50) NULL,
	[ThoiHanTT] [datetime] NULL,
	[NhanVien] [nchar](10) NULL,
	[KhoNhap] [nchar](10) NULL,
	[MaNCC] [nchar](10) NULL,
	[ThanhToan] [nchar](10) NULL,
 CONSTRAINT [PK_PHIEUNHAPHANG] PRIMARY KEY CLUSTERED 
(
	[MaPhieu] ASC
) ON [PRIMARY]
) ON [PRIMARY] 
end
GO  


-- BỘ PHẬN

begin
CREATE TABLE [dbo].[BOPHAN](
	[MaBP] [nchar](10) NOT NULL,
	[TenBP] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](20) NULL,
	[Active] [bit] NULL
 CONSTRAINT [PK_BOPHAN] PRIMARY KEY CLUSTERED 
(
	[MaBP] ASC
) ON [PRIMARY]
) ON [PRIMARY]
end
GO  


go
INSERT [dbo].[BOPHAN] ([MaBP], [TenBP], [GhiChu], [Active]) VALUES (N'GD', N'Giám Đốc', N'', 1)
INSERT [dbo].[BOPHAN] ([MaBP], [TenBP], [GhiChu], [Active]) VALUES (N'KD', N'Phòng Kinh Doanh', N'', 1)
INSERT [dbo].[BOPHAN] ([MaBP], [TenBP], [GhiChu], [Active]) VALUES (N'KT', N'Phòng kế toán', N'', 1)
INSERT [dbo].[BOPHAN] ([MaBP], [TenBP], [GhiChu], [Active]) VALUES (N'KTH', N'Phòng Kỹ Thuật', N'', 1)


-- _NHANVIEN

begin
CREATE TABLE [dbo].[_NHANVIEN](
	[MaNV] [nchar](10) NOT NULL,
	[TenNV] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[DienThoai] [nchar](20)  NULL,
	[DiDong] [nvarchar](20) NULL,
	[Email] [nvarchar](20) NULL,
	[BoPhan] [nchar](10) NULL,
	[NguoiQL] [nchar](10) NULL,
	[Active] [bit] NULL
 CONSTRAINT [PK__NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
) ON [PRIMARY]
) ON [PRIMARY] 
end
GO  


go
INSERT [dbo].[_NHANVIEN] ([MaNV], [TenNV], [DiaChi], [DienThoai], [DiDong], [Email], [BoPhan], [NguoiQL], [Active]) VALUES (N'NV000001', N'Nguyễn Thị Minh  Huệ', N'', '0946 980 409', '0946 980 409', 'quangthong@hptvn.com', N'GD',     NULL, 1)
INSERT [dbo].[_NHANVIEN] ([MaNV], [TenNV], [DiaChi], [DienThoai], [DiDong], [Email], [BoPhan], [NguoiQL], [Active]) VALUES (N'NV000002', N'Phan Quang Thông', N'', '0946 980 409', '0946 980 409', 'hoangdung@hptvn.com', N'KD',          NULL, 1)
INSERT [dbo].[_NHANVIEN] ([MaNV], [TenNV], [DiaChi], [DienThoai], [DiDong], [Email], [BoPhan], [NguoiQL], [Active]) VALUES (N'NV000003', N'Nguyễn Hoàng Dũng', N'', '0946 980 409', '0946 980 409', 'quangthong@hptvn.com', N'KT',        NULL, 1)
INSERT [dbo].[_NHANVIEN] ([MaNV], [TenNV], [DiaChi], [DienThoai], [DiDong], [Email], [BoPhan], [NguoiQL], [Active]) VALUES (N'NV000004', N'Vũ Anh Tuấn', N'', '0946 980 409', '0946 980 409', 'quangthong@hptvn.com', N'KTH',             NULL, 1)
INSERT [dbo].[_NHANVIEN] ([MaNV], [TenNV], [DiaChi], [DienThoai], [DiDong], [Email], [BoPhan], [NguoiQL], [Active]) VALUES (N'NV000005', N'Huỳnh Thị Ngọc Lãnh', N'', '0946 980 409', '0946 980 409', 'quangthong@hptvn.com', N'KD',      NULL, 1)
INSERT [dbo].[_NHANVIEN] ([MaNV], [TenNV], [DiaChi], [DienThoai], [DiDong], [Email], [BoPhan], [NguoiQL], [Active]) VALUES (N'NV000006', N'Phạm Bảo Trung', N'', '0946 980 409', '0946 980 409', 'quangthong@hptvn.com', N'KT',           NULL, 1)
INSERT [dbo].[_NHANVIEN] ([MaNV], [TenNV], [DiaChi], [DienThoai], [DiDong], [Email], [BoPhan], [NguoiQL], [Active]) VALUES (N'NV000007', N'Phạm Thành Sơn', N'', '0946 980 409', '0946 980 409', 'quangthong@hptvn.com', N'GD',           NULL, 1)
INSERT [dbo].[_NHANVIEN] ([MaNV], [TenNV], [DiaChi], [DienThoai], [DiDong], [Email], [BoPhan], [NguoiQL], [Active]) VALUES (N'NV000008', N'Huỳnh Ngọc Trung', N'', '0946 980 409', '0946 980 409', 'quangthong@hptvn.com', N'KT',         NULL, 1)
INSERT [dbo].[_NHANVIEN] ([MaNV], [TenNV], [DiaChi], [DienThoai], [DiDong], [Email], [BoPhan], [NguoiQL], [Active]) VALUES (N'NV000009', N'Đoàn Thị Thu Thảoh', N'', '0946 980 409', '0946 980 409', 'thaodoan@hptvn.com', N'KD',         NULL, 1)
INSERT [dbo].[_NHANVIEN] ([MaNV], [TenNV], [DiaChi], [DienThoai], [DiDong], [Email], [BoPhan], [NguoiQL], [Active]) VALUES (N'NV000010', N'Mai Văn Thái', N'', '0946 980 409', '0946 980 409', 'quangthong@hptvn.com', N'KT',             NULL, 1)
INSERT [dbo].[_NHANVIEN] ([MaNV], [TenNV], [DiaChi], [DienThoai], [DiDong], [Email], [BoPhan], [NguoiQL], [Active]) VALUES (N'NV000011', N'Nguyễn Thị Thu Trang', N'', '0946 980 409', '0946 980 409', 'quangthong@hptvn.com', N'KTH',    NULL, 1)
INSERT [dbo].[_NHANVIEN] ([MaNV], [TenNV], [DiaChi], [DienThoai], [DiDong], [Email], [BoPhan], [NguoiQL], [Active]) VALUES (N'NV000012', N'Nguyễn Huỳnh Phước Đức', N'', '0946 980 409', '0946 980 409', 'quangthong@hptvn.com', N'KD',   NULL, 1)
INSERT [dbo].[_NHANVIEN] ([MaNV], [TenNV], [DiaChi], [DienThoai], [DiDong], [Email], [BoPhan], [NguoiQL], [Active]) VALUES (N'NV000013', N'Nguyễn Văn Viết  Sỹ', N'', '0946 980 409', '0946 980 409', 'quangthong@hptvn.com', N'KT',      NULL, 1)
INSERT [dbo].[_NHANVIEN] ([MaNV], [TenNV], [DiaChi], [DienThoai], [DiDong], [Email], [BoPhan], [NguoiQL], [Active]) VALUES (N'NV000014', N'Nguyễn Duy trung Chiến', N'', '0946 980 409', '0946 980 409', 'quangthong@hptvn.com', N'KD',   NULL, 1)
INSERT [dbo].[_NHANVIEN] ([MaNV], [TenNV], [DiaChi], [DienThoai], [DiDong], [Email], [BoPhan], [NguoiQL], [Active]) VALUES (N'NV000015', N'Nguyễn Đức Việt', N'', '0946 980 409', '0946 980 409', 'quangthong@hptvn.com', N'KTH',         NULL, 1)
												








-----------
-----------Thêm

---- bẢNG Điều khoản thanh toán

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DIEUKHOAN_THANHOAN](
	ID INT IDENTITY(1,1) NOT NULL,
	
	TenDK [nvarchar](50) NULL,
	GHICHU [nvarchar](50) NULL,
	
 CONSTRAINT [FK_DIEUKHOAN_THANHOAN] PRIMARY KEY CLUSTERED 
(
	ID ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


INSERT [dbo].[DIEUKHOAN_THANHOAN] (TenDK, GHICHU) VALUES (N'Công nợ', N'Cho phép nợ')
INSERT [dbo].[DIEUKHOAN_THANHOAN] (TenDK, GHICHU) VALUES (N'Phiếu trả ngay', N'Trả ngay')



---------------------
--DROP TABLE [HANGHOA_DICHVU]

begin
CREATE TABLE [dbo].[HANGHOA_DICHVU](
	[MaHang] [nchar](10) NOT NULL,
	[MaKho] [nchar](10) NULL,
	[TenHang] [nvarchar](50) NULL,
	[MaDV] [char](10) NULL,
	[MaNhom] [nchar](10) NULL,
	[MaNCC] [nchar](10) NULL,
	[GiaMua] [float] NULL,
	[GiabanSi] [float] NULL,
	[GiaBanLe] [float] NULL,
	SoLuongToiThieu int NULL,
	[TinhChat] [nvarchar](20) NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_HH_DV] PRIMARY KEY CLUSTERED 
(
	[MaHang] ASC
)  ON [PRIMARY]
) ON [PRIMARY] 
end
GO  

-- TONKHO
--DROP TABLE TONKHO

begin
CREATE TABLE [dbo].[TONKHO](
	[MaKho] [nchar](10) not NULL,
	[MaHang] [nchar](10) NOT NULL,
	[SoLuongTon] int,
	[SoLuongToiThieu] int,
	[Active] [bit] NULL
 CONSTRAINT [PK_TONKHO] PRIMARY KEY CLUSTERED 
(
	[MaKho],
	[MaHang] ASC
) ON [PRIMARY]
) ON [PRIMARY]
end
GO

---
GO

--
--DROP TABLE [THONGTIN_PHIEUNHAPHANG]

begin
CREATE TABLE [dbo].[THONGTIN_PHIEUNHAPHANG](
	[MaPhieu] [nchar](10) NOT NULL,
	[MaNCC] [nchar](10) NULL,
	[TenNCC] [nvarchar](200) NULL,--
	[NgayLap][datetime] NULL,
	[GhiChu] [nvarchar](500)  NULL,
	DiaChi [nvarchar](50)  NULL,
	[SoHoaDonVAT] [nvarchar](200) NULL,
	[MaNVLap] [nchar](10) NULL,
	[SoPhieuNhapTay] [nvarchar](200) NULL,
	[MaKho] [nchar](10) NULL,--
	[Ma_DieuKhoan] int,--
	[Ma_PhuongThuc] nchar(10),--
	[HanThanhToan] [datetime] NULL,
	TongTienMua float,
	CK float,
	VAT float,
	TongTienTra float,
	ischeck int
 CONSTRAINT [PK_THONGTIN_PHIEUNHAPHANG] PRIMARY KEY CLUSTERED 
(
	[MaPhieu] ASC
) ON [PRIMARY]
) ON [PRIMARY] 
end
GO  




--DROP TABLE CT_PHIEUNHAP

begin
CREATE TABLE [dbo].[CT_PHIEUNHAP](

	ID INT IDENTITY(1,1) NOT NULL,
	[MaPhieu] [nchar](10) NOT NULL,  -- tham chiếu tới bảng thong tin
	[MaHang] [nchar](10) NOT NULL,
	[TenHang] [nvarchar](50) NULL,
	[DonVi] [nvarchar](10) NULL,
	[SoLuong] [int] NULL,
	[DonGia] [float] NULL,
	ThanhTien float,
	GhiChu [nvarchar](50) NULL,

 CONSTRAINT [PK_CT_PHIEUNHAP] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
) ON [PRIMARY]
) ON [PRIMARY] 
end
GO  


begin
CREATE TABLE [dbo].[HIENTHI_PHIEUNHAP](
	[MaPhieu] [nchar](10) NOT NULL,
	[MaHang] [nchar](10) NOT NULL,
	[TenHang] [nvarchar](50) NULL,
	[DonVi] [nvarchar](10) NULL,
	[SoLuong] [int] NULL,
	[DonGia] [float] NULL,
	ThanhTien float,
	GhiChu [nvarchar](50) NULL,
) 
end
GO  

------------------- Các bảng phần bán hành

-- PHIẾU XUẤT



begin
CREATE TABLE [dbo].[THONGTIN_PHIEU_BANHANG](

	[MaPhieu] [nchar](10) NOT NULL,
	MaKH [nchar](10) NULL,
	TenKH [nvarchar](200) NULL,--
	[NgayLap][datetime] NULL,
	[GhiChu] [nvarchar](500)  NULL,
	DiaChi [nvarchar](50)  NULL,
	[SoHoaDonVAT] [nvarchar](200) NULL,
	[MaNVLap] [nchar](10) NULL,
	[SoPhieuNhapTay] [nvarchar](200) NULL,
	[MaKho] [nchar](10) NULL,--
	[Ma_DieuKhoan] int,--
	[Ma_PhuongThuc] nchar(10),--
	[HanThanhToan] [datetime] NULL,
	TongTienBan float,
	CK float,
	VAT float,
	TongTienNhan float,
	ischeck int
 CONSTRAINT [FK_THONGTIN_PHIEU_BANHANG] PRIMARY KEY CLUSTERED 
(
	[MaPhieu] ASC
) ON [PRIMARY]
) ON [PRIMARY] 
end
GO 


--DROP TABLE CT_PHIEUXUAT

begin
CREATE TABLE [dbo].[CT_PHIEUXUAT](

	ID INT IDENTITY(1,1) NOT NULL,
	[MaPhieuXuat] [nchar](10) NOT NULL,	
	[MaHang] [nchar](10) NULL,
	TenHang [nvarchar](200) NULL,
	[DonVi] [nvarchar](10) NULL,
	[SoLuong] [int]  NULL,
	[DonGia] [float] NULL,
	ThanhTien float NULL,
	CK float,
	[ThanhToan] float NULL,
	
	 CONSTRAINT [PK_CT_PHIEUXUAT] PRIMARY KEY CLUSTERED 
(
	ID ASC
) ON [PRIMARY]
) ON [PRIMARY] 
end
GO  



begin
CREATE TABLE [dbo].[HIENTHI_PHIEUXUAT](

	[MaPhieu] [nchar](10) NOT NULL,
	[MaHang] [nchar](10) NULL,
	TenHang [nvarchar](200) NULL,
	[DonVi] [nvarchar](10) NULL,
	[SoLuong] [int]  NULL,
	[DonGia] [float] NULL,
	ThanhTien float NULL,
	CK float,
	ChietKhau int,
	[ThanhToan] float NULL,
) 
end
GO  


-------------ChuynKho

begin
CREATE TABLE [dbo].[HIENTHI_CHUYENKHO](
	[MaPhieu] [nchar](10) NOT NULL,
	[MaHang] [nchar](10) NOT NULL,
	[TenHang] [nvarchar](50) NULL,
	[DonVi] [nvarchar](10) NULL,
	[SoLuong] [int] NULL,
	[DonGia] [float] NULL,
	ThanhTien float,
) 
end
GO  



--- THÔNG TIN CHUYỂN KHO

 begin
 CREATE TABLE [dbo].[THONGTIN_CHUYENKHO](

 	[MaPhieuChuyen] [nchar](10) NOT NULL,
 	MaKhoXuat [nchar](10) NULL,
 	MaKhoNhan [nchar](10) NULL,
 	[NgayLap][datetime] NULL,
 	[GhiChu] [nvarchar](500)  NULL,
	
 	[MaNVXuat] [nchar](10) NULL,
 	[MaNVNhan] [nchar](10) NULL,
 	[SoPhieuChuyenTay] [nvarchar](200) NULL,

 	TongTienChuyen float
  CONSTRAINT [FK_THONGTIN_CHUYENKHO] PRIMARY KEY CLUSTERED 
 (
 	[MaPhieuChuyen] ASC
 ) ON [PRIMARY]
 ) ON [PRIMARY] 
 end
 GO 

--CT_ChUYENKHO

begin
CREATE TABLE [dbo].[CT_ChUYENKHO](

	ID INT IDENTITY(1,1) NOT NULL,
	[MaPhieuChuyen] [nchar](10) NOT NULL,
	[MaHang] [nchar](10) NOT NULL,
	[TenHang] [nvarchar](50) NULL,
	[DonVi] [nvarchar](10) NULL,
	[SoLuong] [int] NULL,
	[DonGia] [float] NULL,
	ThanhTien float,
	
 CONSTRAINT [FK_CT_ChUYENKHO] PRIMARY KEY CLUSTERED 
(
	ID ASC
) ON [PRIMARY]
) ON [PRIMARY] 
end
GO 

-- bảng kê phiếu thu tiền: 
--drop table [BANGKE_PHIEUTHUTIEN]
begin
CREATE TABLE [dbo].[BANGKE_PHIEUTHUTIEN](

	[MaPhieuBangKe] [nchar](10) NOT NULL,
	[MaPhieuXuat] [nchar](10) NOT NULL,
	[NgayLap] datetime ,
	[MaKH] [nchar](10) NOT NULL,
	[TenKH] [nvarchar](50) NULL,
	ThanhTien float,
	TenNV [nchar](100) NOT NULL,
	[GhiChu] [nvarchar](200) NULL,
	
 CONSTRAINT [FK_BANGKE_PHIEUTHUTIEN] PRIMARY KEY CLUSTERED 
(
	MaPhieuBangKe ASC
) ON [PRIMARY]
) ON [PRIMARY] 
end
GO 


--DROP TABLE [BANGKE_PHIEUCHITIEN]

begin
CREATE TABLE [dbo].[BANGKE_PHIEUCHITIEN](

	[MaPhieuBangKe] [nchar](10) NOT NULL,
	[MaPhieuChi] [nchar](10) NOT NULL,
	[NgayLap] datetime ,
	[MaNCC] [nchar](10) NOT NULL,
	[TenNCC] [nvarchar](50) NULL,
	ThanhTien float,
	TenNV [nchar](100) NOT NULL,
	GhiChu [nvarchar](200) NULL,
	
 CONSTRAINT [FK_BANGKE_PHIEUCHITIEN] PRIMARY KEY CLUSTERED 
(
	MaPhieuBangKe ASC
) ON [PRIMARY]
) ON [PRIMARY] 
end
GO 



--------- TAB HỆ THỐNG ----------
-- PHÂN QUYỀN
create table VAITRO
(
	MaVaiTro nchar(10) primary key,
	TenVaiTro nvarchar(50),
	DienGiai nvarchar(50),
	KichHoat bit
)

go
create table NGUOIDUNG
(
	ID int identity(1,1) primary key,
	TenDangNhap varchar(20),
	Password varchar(50),
	MaVaiTro nchar(10), -- fk ma vai tro
	MaNV nchar(10), --fk ma nv
	DienGiai nvarchar(50),
	ConQuanLy bit
)

go
create table CHUCNANG
(
	MaChucNang int primary key,
	TenChucNang nvarchar(50),
	TatCa bit default(1),
	TruyCap bit default(1),
	Them bit default(1),
	Xoa bit default(1),
	Sua bit default(1),
	InAn bit default(1),
	Nhap bit default(1),
	Xuat bit default(1),
	TenTrongHeThong varchar(50),
	
	MaCha int -- fk ma chuc nang
)

go
create table VAITRO_CHUCNANG
(
	MaVaiTro nchar(10), -- fk ma vai tro
	MaChucNang int, -- fk ma chuc nang
	TatCa bit,
	TruyCap bit,
	Them bit,
	Xoa bit,
	Sua bit,
	InAn bit,
	Nhap bit,
	Xuat bit,

	Primary Key(MaVaiTro, MaChucNang)
)

go
alter table NGUOIDUNG add constraint FK_NGUOIDUNG_VAITRO foreign key (MaVaiTro) references VAITRO(MaVaiTro)
--alter table NGUOIDUNG add constraint FK_NGUOIDUNG_NHANVIEN foreign key (MANV) references NHANVIEN(MaNhanVien)
alter table CHUCNANG add constraint FK_CHUCNANG_CHUCNANG foreign key (MaCha) references CHUCNANG(MaChucNang)
alter table VAITRO_CHUCNANG add constraint FK_VTCN_VAITRO foreign key (MaVaiTro) references VAITRO(MaVaiTro)
alter table VAITRO_CHUCNANG add constraint FK_VTCN_CHUCNANG foreign key (MaChucNang) references CHUCNANG(MaChucNang)


INSERT [dbo].[VAITRO] ([MaVaiTro], [TenVaiTro], [DienGiai], [KichHoat]) VALUES (N'001', N'Admin', N'administrator', 1)
INSERT [dbo].[VAITRO] ([MaVaiTro], [TenVaiTro], [DienGiai], [KichHoat]) VALUES (N'002', N'Nhân Viên', N'', 1)
SET IDENTITY_INSERT [dbo].[NGUOIDUNG] ON 


INSERT [dbo].[NGUOIDUNG] ([ID], [TenDangNhap], [Password], [MaVaiTro], [MaNV], [DienGiai], [ConQuanLy]) VALUES (25, N'admin', N'', N'001', NULL, NULL, 1)
INSERT [dbo].[NGUOIDUNG] ([ID], [TenDangNhap], [Password], [MaVaiTro], [MaNV], [DienGiai], [ConQuanLy]) VALUES (26, N't', N't', N'002', N'001', N'Phạm Đình Luân', 1)
SET IDENTITY_INSERT [dbo].[NGUOIDUNG] OFF


INSERT [dbo].[CHUCNANG] ([MaChucNang], [TenChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat], [TenTrongHeThong], [MaCha]) VALUES (1, N'Hệ Thống', 1, 1, 1, 1, 1, 1, 1, 1, N'rbpHeThong', NULL)
INSERT [dbo].[CHUCNANG] ([MaChucNang], [TenChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat], [TenTrongHeThong], [MaCha]) VALUES (2, N'Danh Mục', 1, 1, 1, 1, 1, 1, 1, 1, N'rbpDanhMuc', NULL)
INSERT [dbo].[CHUCNANG] ([MaChucNang], [TenChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat], [TenTrongHeThong], [MaCha]) VALUES (3, N'Chức Năng', 1, 1, 1, 1, 1, 1, 1, 1, N'rbpChucNang', NULL)
INSERT [dbo].[CHUCNANG] ([MaChucNang], [TenChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat], [TenTrongHeThong], [MaCha]) VALUES (5, N'Bảo Mật', 1, 1, 1, 1, 1, 1, 1, 1, N'rpgBaoMat', 1)
INSERT [dbo].[CHUCNANG] ([MaChucNang], [TenChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat], [TenTrongHeThong], [MaCha]) VALUES (6, N'Dữ Liệu', 1, 1, 1, 1, 1, 1, 1, 1, N'rpgDuLieu', 1)
INSERT [dbo].[CHUCNANG] ([MaChucNang], [TenChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat], [TenTrongHeThong], [MaCha]) VALUES (8, N'Quản Lý Phân Quyền', 1, 1, 1, 1, 1, 1, 1, 1, N'btnPhanQuyen', 5)
INSERT [dbo].[CHUCNANG] ([MaChucNang], [TenChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat], [TenTrongHeThong], [MaCha]) VALUES (9, N'Đổi Mật Khẩu', 1, 1, 1, 1, 1, 1, 1, 1, N'btnDoiMatKhau', 5)
INSERT [dbo].[CHUCNANG] ([MaChucNang], [TenChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat], [TenTrongHeThong], [MaCha]) VALUES (10, N'Nhật Ký Hệ Thống', 1, 1, 1, 1, 1, 1, 1, 1, N'btnNhatKy', 5)
INSERT [dbo].[CHUCNANG] ([MaChucNang], [TenChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat], [TenTrongHeThong], [MaCha]) VALUES (13, N'Sao Lưu', 1, 1, 1, 1, 1, 1, 1, 1, N'btnSaoLuu', 6)
INSERT [dbo].[CHUCNANG] ([MaChucNang], [TenChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat], [TenTrongHeThong], [MaCha]) VALUES (14, N'Phục Hồi', 1, 1, 1, 1, 1, 1, 1, 1, N'btnPhucHoi', 6)
INSERT [dbo].[CHUCNANG] ([MaChucNang], [TenChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat], [TenTrongHeThong], [MaCha]) VALUES (17, N'Đối Tác', 1, 1, 1, 1, 1, 1, 1, 1, N'rpgDoiTac', 2)
INSERT [dbo].[CHUCNANG] ([MaChucNang], [TenChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat], [TenTrongHeThong], [MaCha]) VALUES (18, N'Kho Hàng', 1, 1, 1, 1, 1, 1, 1, 1, N'rpgKhoHang', 2)
INSERT [dbo].[CHUCNANG] ([MaChucNang], [TenChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat], [TenTrongHeThong], [MaCha]) VALUES (19, N'Tổ Chức', 1, 1, 1, 1, 1, 1, 1, 1, N'rpgToChuc', 2)
INSERT [dbo].[CHUCNANG] ([MaChucNang], [TenChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat], [TenTrongHeThong], [MaCha]) VALUES (20, N'Khu Vực', 1, 1, 1, 1, 1, 1, 1, 1, N'btnKhuVuc', 17)
INSERT [dbo].[CHUCNANG] ([MaChucNang], [TenChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat], [TenTrongHeThong], [MaCha]) VALUES (21, N'Khách Hàng', 1, 1, 1, 1, 1, 1, 1, 1, N'btnKhachHang', 17)
INSERT [dbo].[CHUCNANG] ([MaChucNang], [TenChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat], [TenTrongHeThong], [MaCha]) VALUES (22, N'Nhà Phân Phối', 1, 1, 1, 1, 1, 1, 1, 1, N'btnKhuVuc', 17)
INSERT [dbo].[CHUCNANG] ([MaChucNang], [TenChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat], [TenTrongHeThong], [MaCha]) VALUES (23, N'Kho', 1, 1, 1, 1, 1, 1, 1, 1, N'btnKhoHang', 18)
INSERT [dbo].[CHUCNANG] ([MaChucNang], [TenChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat], [TenTrongHeThong], [MaCha]) VALUES (24, N'Đơn Vị', 1, 1, 1, 1, 1, 1, 1, 1, N'btnDonViTinh', 18)
INSERT [dbo].[CHUCNANG] ([MaChucNang], [TenChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat], [TenTrongHeThong], [MaCha]) VALUES (25, N'Nhóm Hàng', 1, 1, 1, 1, 1, 1, 1, 1, N'btnNhomHang', 18)
INSERT [dbo].[CHUCNANG] ([MaChucNang], [TenChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat], [TenTrongHeThong], [MaCha]) VALUES (26, N'Hàng Hóa', 1, 1, 1, 1, 1, 1, 1, 1, N'btnHangHoa', 18)
INSERT [dbo].[CHUCNANG] ([MaChucNang], [TenChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat], [TenTrongHeThong], [MaCha]) VALUES (28, N'Tỷ Giá', 1, 1, 1, 1, 1, 1, 1, 1, N'btnTyGia', 18)
INSERT [dbo].[CHUCNANG] ([MaChucNang], [TenChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat], [TenTrongHeThong], [MaCha]) VALUES (30, N'Bộ Phận', 1, 1, 1, 1, 1, 1, 1, 1, N'btnBoPhan', 19)
INSERT [dbo].[CHUCNANG] ([MaChucNang], [TenChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat], [TenTrongHeThong], [MaCha]) VALUES (31, N'Nhân Viên', 1, 1, 1, 1, 1, 1, 1, 1, N'btnNhanVien', 19)
INSERT [dbo].[CHUCNANG] ([MaChucNang], [TenChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat], [TenTrongHeThong], [MaCha]) VALUES (32, N'Nhập Xuất', 1, 1, 1, 1, 1, 1, 1, 1, N'rpgNhapXuat', 3)
INSERT [dbo].[CHUCNANG] ([MaChucNang], [TenChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat], [TenTrongHeThong], [MaCha]) VALUES (33, N'Công Nợ', 1, 1, 1, 1, 1, 1, 1, 1, N'rpgCongNo', 3)
INSERT [dbo].[CHUCNANG] ([MaChucNang], [TenChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat], [TenTrongHeThong], [MaCha]) VALUES (34, N'Kho Hàng', 1, 1, 1, 1, 1, 1, 1, 1, N'rpgKhoHangcn', 3)
INSERT [dbo].[CHUCNANG] ([MaChucNang], [TenChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat], [TenTrongHeThong], [MaCha]) VALUES (37, N'Báo Cáo', 1, 1, 1, 1, 1, 1, 1, 1, N'rpgBaoCao', 3)
INSERT [dbo].[CHUCNANG] ([MaChucNang], [TenChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat], [TenTrongHeThong], [MaCha]) VALUES (39, N'Mua Hàng', 1, 1, 1, 1, 1, 1, 1, 1, N'btnMuaHang', 32)
INSERT [dbo].[CHUCNANG] ([MaChucNang], [TenChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat], [TenTrongHeThong], [MaCha]) VALUES (40, N'Bán Hàng', 1, 1, 1, 1, 1, 1, 1, 1, N'btnBanHang', 32)
INSERT [dbo].[CHUCNANG] ([MaChucNang], [TenChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat], [TenTrongHeThong], [MaCha]) VALUES (43, N'Thu Tiền', 1, 1, 1, 1, 1, 1, 1, 1, N'btnThuTien', 33)
INSERT [dbo].[CHUCNANG] ([MaChucNang], [TenChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat], [TenTrongHeThong], [MaCha]) VALUES (44, N'Trả Tiền', 1, 1, 1, 1, 1, 1, 1, 1, N'btnTraTien', 33)
INSERT [dbo].[CHUCNANG] ([MaChucNang], [TenChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat], [TenTrongHeThong], [MaCha]) VALUES (45, N'Chuyển Kho', 1, 1, 1, 1, 1, 1, 1, 1, N'btnChuyenKho', 34)
INSERT [dbo].[CHUCNANG] ([MaChucNang], [TenChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat], [TenTrongHeThong], [MaCha]) VALUES (47, N'Tồn Kho', 1, 1, 1, 1, 1, 1, 1, 1, N'btnTonKho', 34)
INSERT [dbo].[CHUCNANG] ([MaChucNang], [TenChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat], [TenTrongHeThong], [MaCha]) VALUES (54, N'Báo cáo Kho Hàng', 1, 1, 1, 1, 1, 1, 1, 1, N'btnBCKhoHang', 37)
INSERT [dbo].[CHUCNANG] ([MaChucNang], [TenChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat], [TenTrongHeThong], [MaCha]) VALUES (55, N'Báo cáo Bán Hàng', 1, 1, 1, 1, 1, 1, 1, 1, N'btnBCKhoHang', 37)
INSERT [dbo].[CHUCNANG] ([MaChucNang], [TenChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat], [TenTrongHeThong], [MaCha]) VALUES (56, N'Chứng Từ', 1, 1, 1, 1, 1, 1, 1, 1, N'btnChungTu', 37)


INSERT [dbo].[VAITRO_CHUCNANG] ([MaVaiTro], [MaChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat]) VALUES (N'001', 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[VAITRO_CHUCNANG] ([MaVaiTro], [MaChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat]) VALUES (N'001', 2, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[VAITRO_CHUCNANG] ([MaVaiTro], [MaChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat]) VALUES (N'001', 3, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[VAITRO_CHUCNANG] ([MaVaiTro], [MaChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat]) VALUES (N'001', 5, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[VAITRO_CHUCNANG] ([MaVaiTro], [MaChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat]) VALUES (N'001', 6, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[VAITRO_CHUCNANG] ([MaVaiTro], [MaChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat]) VALUES (N'001', 8, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[VAITRO_CHUCNANG] ([MaVaiTro], [MaChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat]) VALUES (N'001', 9, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[VAITRO_CHUCNANG] ([MaVaiTro], [MaChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat]) VALUES (N'001', 10, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[VAITRO_CHUCNANG] ([MaVaiTro], [MaChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat]) VALUES (N'001', 13, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[VAITRO_CHUCNANG] ([MaVaiTro], [MaChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat]) VALUES (N'001', 14, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[VAITRO_CHUCNANG] ([MaVaiTro], [MaChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat]) VALUES (N'001', 17, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[VAITRO_CHUCNANG] ([MaVaiTro], [MaChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat]) VALUES (N'001', 18, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[VAITRO_CHUCNANG] ([MaVaiTro], [MaChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat]) VALUES (N'001', 19, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[VAITRO_CHUCNANG] ([MaVaiTro], [MaChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat]) VALUES (N'001', 20, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[VAITRO_CHUCNANG] ([MaVaiTro], [MaChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat]) VALUES (N'001', 21, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[VAITRO_CHUCNANG] ([MaVaiTro], [MaChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat]) VALUES (N'001', 22, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[VAITRO_CHUCNANG] ([MaVaiTro], [MaChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat]) VALUES (N'001', 23, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[VAITRO_CHUCNANG] ([MaVaiTro], [MaChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat]) VALUES (N'001', 24, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[VAITRO_CHUCNANG] ([MaVaiTro], [MaChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat]) VALUES (N'001', 25, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[VAITRO_CHUCNANG] ([MaVaiTro], [MaChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat]) VALUES (N'001', 26, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[VAITRO_CHUCNANG] ([MaVaiTro], [MaChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat]) VALUES (N'001', 28, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[VAITRO_CHUCNANG] ([MaVaiTro], [MaChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat]) VALUES (N'001', 30, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[VAITRO_CHUCNANG] ([MaVaiTro], [MaChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat]) VALUES (N'001', 31, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[VAITRO_CHUCNANG] ([MaVaiTro], [MaChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat]) VALUES (N'001', 32, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[VAITRO_CHUCNANG] ([MaVaiTro], [MaChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat]) VALUES (N'001', 33, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[VAITRO_CHUCNANG] ([MaVaiTro], [MaChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat]) VALUES (N'001', 34, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[VAITRO_CHUCNANG] ([MaVaiTro], [MaChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat]) VALUES (N'001', 37, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[VAITRO_CHUCNANG] ([MaVaiTro], [MaChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat]) VALUES (N'001', 39, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[VAITRO_CHUCNANG] ([MaVaiTro], [MaChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat]) VALUES (N'001', 40, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[VAITRO_CHUCNANG] ([MaVaiTro], [MaChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat]) VALUES (N'001', 43, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[VAITRO_CHUCNANG] ([MaVaiTro], [MaChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat]) VALUES (N'001', 44, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[VAITRO_CHUCNANG] ([MaVaiTro], [MaChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat]) VALUES (N'001', 45, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[VAITRO_CHUCNANG] ([MaVaiTro], [MaChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat]) VALUES (N'001', 47, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[VAITRO_CHUCNANG] ([MaVaiTro], [MaChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat]) VALUES (N'001', 54, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[VAITRO_CHUCNANG] ([MaVaiTro], [MaChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat]) VALUES (N'001', 55, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[VAITRO_CHUCNANG] ([MaVaiTro], [MaChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat]) VALUES (N'001', 56, 1, 1, 1, 1, 1, 1, 1, 1)

INSERT [dbo].[VAITRO_CHUCNANG] ([MaVaiTro], [MaChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat]) VALUES (N'002', 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[VAITRO_CHUCNANG] ([MaVaiTro], [MaChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat]) VALUES (N'002', 2, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[VAITRO_CHUCNANG] ([MaVaiTro], [MaChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat]) VALUES (N'002', 3, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[VAITRO_CHUCNANG] ([MaVaiTro], [MaChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat]) VALUES (N'002', 5, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[VAITRO_CHUCNANG] ([MaVaiTro], [MaChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat]) VALUES (N'002', 6, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[VAITRO_CHUCNANG] ([MaVaiTro], [MaChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat]) VALUES (N'002', 8, 0, 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[VAITRO_CHUCNANG] ([MaVaiTro], [MaChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat]) VALUES (N'002', 9, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[VAITRO_CHUCNANG] ([MaVaiTro], [MaChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat]) VALUES (N'002', 10, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[VAITRO_CHUCNANG] ([MaVaiTro], [MaChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat]) VALUES (N'002', 13, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[VAITRO_CHUCNANG] ([MaVaiTro], [MaChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat]) VALUES (N'002', 14, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[VAITRO_CHUCNANG] ([MaVaiTro], [MaChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat]) VALUES (N'002', 17, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[VAITRO_CHUCNANG] ([MaVaiTro], [MaChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat]) VALUES (N'002', 18, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[VAITRO_CHUCNANG] ([MaVaiTro], [MaChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat]) VALUES (N'002', 19, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[VAITRO_CHUCNANG] ([MaVaiTro], [MaChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat]) VALUES (N'002', 20, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[VAITRO_CHUCNANG] ([MaVaiTro], [MaChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat]) VALUES (N'002', 21, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[VAITRO_CHUCNANG] ([MaVaiTro], [MaChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat]) VALUES (N'002', 22, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[VAITRO_CHUCNANG] ([MaVaiTro], [MaChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat]) VALUES (N'002', 23, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[VAITRO_CHUCNANG] ([MaVaiTro], [MaChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat]) VALUES (N'002', 24, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[VAITRO_CHUCNANG] ([MaVaiTro], [MaChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat]) VALUES (N'002', 25, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[VAITRO_CHUCNANG] ([MaVaiTro], [MaChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat]) VALUES (N'002', 26, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[VAITRO_CHUCNANG] ([MaVaiTro], [MaChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat]) VALUES (N'002', 28, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[VAITRO_CHUCNANG] ([MaVaiTro], [MaChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat]) VALUES (N'002', 30, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[VAITRO_CHUCNANG] ([MaVaiTro], [MaChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat]) VALUES (N'002', 31, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[VAITRO_CHUCNANG] ([MaVaiTro], [MaChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat]) VALUES (N'002', 32, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[VAITRO_CHUCNANG] ([MaVaiTro], [MaChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat]) VALUES (N'002', 33, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[VAITRO_CHUCNANG] ([MaVaiTro], [MaChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat]) VALUES (N'002', 34, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[VAITRO_CHUCNANG] ([MaVaiTro], [MaChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat]) VALUES (N'002', 37, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[VAITRO_CHUCNANG] ([MaVaiTro], [MaChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat]) VALUES (N'002', 39, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[VAITRO_CHUCNANG] ([MaVaiTro], [MaChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat]) VALUES (N'002', 40, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[VAITRO_CHUCNANG] ([MaVaiTro], [MaChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat]) VALUES (N'002', 43, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[VAITRO_CHUCNANG] ([MaVaiTro], [MaChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat]) VALUES (N'002', 44, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[VAITRO_CHUCNANG] ([MaVaiTro], [MaChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat]) VALUES (N'002', 45, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[VAITRO_CHUCNANG] ([MaVaiTro], [MaChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat]) VALUES (N'002', 47, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[VAITRO_CHUCNANG] ([MaVaiTro], [MaChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat]) VALUES (N'002', 54, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[VAITRO_CHUCNANG] ([MaVaiTro], [MaChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat]) VALUES (N'002', 55, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[VAITRO_CHUCNANG] ([MaVaiTro], [MaChucNang], [TatCa], [TruyCap], [Them], [Xoa], [Sua], [InAn], [Nhap], [Xuat]) VALUES (N'002', 56, 1, 1, 1, 1, 1, 1, 1, 1)

