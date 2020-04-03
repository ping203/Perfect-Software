-- tự động set Id cho đơn vị tính

USE PM_QLBH
GO


go
create function SetAutoIdDVT()
returns nvarchar(10)
as
begin
	declare @sttIDmoi int
	declare @IDmoi nchar(10)
	set @sttIDmoi = 1

	while(not (@sttIDmoi != all (select cast(SUBSTRING(MaDVT, 3, 2) as int)
									 from DONVITINH)
			  )
		 )
	begin
		set @sttIDmoi = @sttIDmoi + 1
	end
	if(@sttIDmoi < 10)
		set @IDmoi = concat('DV', '0', @sttIDmoi)
	else  
		set @IDmoi = concat('DV', @sttIDmoi)

	return @IDmoi
end
go

-- tự động set Id cho Bộ phận
go
create function SetAutoIdBoPhan()
returns nchar(10)
as
begin
	declare @sttIDmoi int
	declare @IDmoi nchar(10)
	set @sttIDmoi = 1

	while(@sttIDmoi in (select cast(SUBSTRING(MaBP, 3, 6) as int)
						from BOPHAN where left(MaBP, 2) = 'BP')		  
		 )
	begin
		set @sttIDmoi = @sttIDmoi + 1
	end
	if(@sttIDmoi < 10)
		set @IDmoi = concat('BP', '00000', @sttIDmoi)
	else  if(@sttIDmoi < 100)
		set @IDmoi = concat('BP', '0000', @sttIDmoi)
	else  if(@sttIDmoi < 1000)
		set @IDmoi = concat('BP', '000', @sttIDmoi)
	else  if(@sttIDmoi < 10000)
		set @IDmoi = concat('BP', '00', @sttIDmoi)
	else  if(@sttIDmoi < 100000)
		set @IDmoi = concat('BP', '0', @sttIDmoi)
	else
		set @IDmoi = concat('BP', @sttIDmoi)

	return @IDmoi
end
go

-- tự động set Id cho kho hàng
go
create function SetAutoIdKhoHang()
returns nchar(10)
as
begin
	declare @sttIDmoi int
	declare @IDmoi nchar(10)
	set @sttIDmoi = 1

	while(@sttIDmoi in (select cast(SUBSTRING(MaKho, 2, 6) as int)
						from KHOHANG where left(MaKho, 1) = 'K')		  
		 )
	begin
		set @sttIDmoi = @sttIDmoi + 1
	end
	if(@sttIDmoi < 10)
		set @IDmoi = concat('K', '00000', @sttIDmoi)
	else  if(@sttIDmoi < 100)
		set @IDmoi = concat('K', '0000', @sttIDmoi)
	else  if(@sttIDmoi < 1000)
		set @IDmoi = concat('K', '000', @sttIDmoi)
	else  if(@sttIDmoi < 10000)
		set @IDmoi = concat('K', '00', @sttIDmoi)
	else  if(@sttIDmoi < 100000)
		set @IDmoi = concat('K', '0', @sttIDmoi)
	else
		set @IDmoi = concat('K', @sttIDmoi)

	return @IDmoi
end
go

-- tự động set Id cho nhan vien

go
create function SetAutoIdNhanVien()
returns nvarchar(10)
as
begin
	declare @sttIDmoi int
	declare @IDmoi nchar(10)
	set @sttIDmoi = 1

	while(not (@sttIDmoi != all (select cast(SUBSTRING(MaNV, 3, 6) as int)
									 from _NHANVIEN)
			  )
		 )
	begin
		set @sttIDmoi = @sttIDmoi + 1
	end
	if(@sttIDmoi < 10)
		set @IDmoi = concat('NV', '00000', @sttIDmoi)
	else  if(@sttIDmoi < 100)
		set @IDmoi = concat('NV', '0000', @sttIDmoi)
	else  if(@sttIDmoi < 1000)
		set @IDmoi = concat('NV', '000', @sttIDmoi)
	else  if(@sttIDmoi < 10000)
		set @IDmoi = concat('NV', '00', @sttIDmoi)
	else  if(@sttIDmoi < 100000)
		set @IDmoi = concat('NV', '0', @sttIDmoi)
	else
		set @IDmoi = concat('NV', @sttIDmoi)

	return @IDmoi
end
go


-- tự động set Id cho hanghoa

go
create  function SetAutoIdHangHoa()
returns nvarchar(10)
as
begin
	declare @sttIDmoi int
	declare @IDmoi nchar(10)
	set @sttIDmoi = 1

	while(not (@sttIDmoi != all (select cast(SUBSTRING(MaHang, 3, 6) as int)
									 from HANGHOA_DICHVU where LEFT(MaHang, 2) = 'HH')
			  )
		 )
	begin
		set @sttIDmoi = @sttIDmoi + 1
	end
	if(@sttIDmoi < 10)
		set @IDmoi = concat('HH', '00000', @sttIDmoi)
	else  if(@sttIDmoi < 100)
		set @IDmoi = concat('HH', '0000', @sttIDmoi)
	else  if(@sttIDmoi < 1000)
		set @IDmoi = concat('HH', '000', @sttIDmoi)
	else  if(@sttIDmoi < 10000)
		set @IDmoi = concat('HH', '00', @sttIDmoi)
	else  if(@sttIDmoi < 100000)
		set @IDmoi = concat('HH', '0', @sttIDmoi)
	else
		set @IDmoi = concat('HH', @sttIDmoi)

	return @IDmoi
end
go


-- tự động set Id cho NHOMHANG

go
create function SetAutoIdNhomHang()
returns nchar(10)
as
begin
	declare @sttIDmoi int
	declare @IDmoi nchar(10)
	set @sttIDmoi = 1

	while(@sttIDmoi in (select cast(SUBSTRING(MaNhom, 3, 6) as int)
						from NHOMHANG where left(MaNhom, 2) = 'NH')		  
		 )
	begin
		set @sttIDmoi = @sttIDmoi + 1
	end
	if(@sttIDmoi < 10)
		set @IDmoi = concat('NH', '00000', @sttIDmoi)
	else  if(@sttIDmoi < 100)
		set @IDmoi = concat('NH', '0000', @sttIDmoi)
	else  if(@sttIDmoi < 1000)
		set @IDmoi = concat('NH', '000', @sttIDmoi)
	else  if(@sttIDmoi < 10000)
		set @IDmoi = concat('NH', '00', @sttIDmoi)
	else  if(@sttIDmoi < 100000)
		set @IDmoi = concat('NH', '0', @sttIDmoi)
	else
		set @IDmoi = concat('NH', @sttIDmoi)

	return @IDmoi
end
go


--kiểm tra mật khẩu có đúng với username hay không(đúng: 1 || sai: 0)
go
create function checkPasswordCorrect(@username nvarchar(50), @password varchar(50))
returns int
as
begin
	if(@password = (select [Password] from SYS_USER where UserName = @username))
	begin
		return 1
	end
	
	return 0
end
go

--kiểm tra đăng nhập (= 1: đăng nhập thành công, = 0: đăng nhập thất bại)
go
create function checkLogin(@username nvarchar(50), @password varchar(50))
returns int
as
begin
	if(@username not in (select UserName from SYS_USER))
	begin
		return 0
	end

	if(@password = (select [Password] from SYS_USER where UserName = @username))
	begin
		return 1
	end

	return 0
end
go

-- tự động set Id cho THONGTIN_PHIEUNHAPHANG
go
create function SetAutoIdThongTin_PhieuNhapHang()
returns nchar(10)
as
begin
	declare @sttIDmoi int
	declare @IDmoi nchar(10)
	set @sttIDmoi = 1

	while(@sttIDmoi in (select cast(right(MaPhieu, 6) as int)
						from [THONGTIN_PHIEUNHAPHANG])		  
		 )
	begin
		set @sttIDmoi = @sttIDmoi + 1
	end
	if(@sttIDmoi < 10)
		set @IDmoi = concat('MPNH', '00000', @sttIDmoi)
	else  if(@sttIDmoi < 100)
		set @IDmoi = concat('MPNH', '0000', @sttIDmoi)
	else  if(@sttIDmoi < 1000)
		set @IDmoi = concat('MPNH', '000', @sttIDmoi)
	else  if(@sttIDmoi < 10000)
		set @IDmoi = concat('MPNH', '00', @sttIDmoi)
	else  if(@sttIDmoi < 100000)
		set @IDmoi = concat('MPNH', '0', @sttIDmoi)
	else
		set @IDmoi = concat('MPNH', @sttIDmoi)

	return @IDmoi
end
go

-- tự động set Id cho THONGTIN_PHIEUBANHANG
go
CREATE function SetAutoIdThongTin_PhieuBanHang()
returns nchar(10)
as
begin
	declare @sttIDmoi int
	declare @IDmoi nchar(10)
	set @sttIDmoi = 1

	while(@sttIDmoi in (select cast(right(MaPhieu, 6) as int)
						from THONGTIN_PHIEU_BANHANG)		  
		 )
	begin
		set @sttIDmoi = @sttIDmoi + 1
	end
	if(@sttIDmoi < 10)
		set @IDmoi = concat('MPBH', '00000', @sttIDmoi)
	else  if(@sttIDmoi < 100)
		set @IDmoi = concat('MPBH', '0000', @sttIDmoi)
	else  if(@sttIDmoi < 1000)
		set @IDmoi = concat('MPBH', '000', @sttIDmoi)
	else  if(@sttIDmoi < 10000)
		set @IDmoi = concat('MPBH', '00', @sttIDmoi)
	else  if(@sttIDmoi < 100000)
		set @IDmoi = concat('MPBH', '0', @sttIDmoi)
	else
		set @IDmoi = concat('MPBH', @sttIDmoi)

	return @IDmoi
end
go


-- tự động set Id cho THONGTIN_CHUYENKHO
go
CREATE function SetAutoIdThongTin_ChuyenKho()
returns nchar(10)
as
begin
	declare @sttIDmoi int
	declare @IDmoi nchar(10)
	set @sttIDmoi = 1

	while(@sttIDmoi in (select cast(right(MaPhieuChuyen, 6) as int)
						from THONGTIN_CHUYENKHO)		  
		 )
	begin
		set @sttIDmoi = @sttIDmoi + 1
	end
	if(@sttIDmoi < 10)
		set @IDmoi = concat('MPCK', '00000', @sttIDmoi)
	else  if(@sttIDmoi < 100)
		set @IDmoi = concat('MPCK', '0000', @sttIDmoi)
	else  if(@sttIDmoi < 1000)
		set @IDmoi = concat('MPCK', '000', @sttIDmoi)
	else  if(@sttIDmoi < 10000)
		set @IDmoi = concat('MPCK', '00', @sttIDmoi)
	else  if(@sttIDmoi < 100000)
		set @IDmoi = concat('MPCK', '0', @sttIDmoi)
	else
		set @IDmoi = concat('MPCK', @sttIDmoi)

	return @IDmoi
end
go

-- tự động set Id cho BANGKE_PHIEUTHUTIEN
go
CREATE function SetAutoIdBANGKE_PHIEUTHUTIEN()
returns nchar(10)
as
begin
	declare @sttIDmoi int
	declare @IDmoi nchar(10)
	set @sttIDmoi = 1

	while(@sttIDmoi in (select cast(right(MaPhieuBangKe, 6) as int)
						from BANGKE_PHIEUTHUTIEN)		  
		 )
	begin
		set @sttIDmoi = @sttIDmoi + 1
	end
	if(@sttIDmoi < 10)
		set @IDmoi = concat('PT', '00000', @sttIDmoi)
	else  if(@sttIDmoi < 100)
		set @IDmoi = concat('PT', '0000', @sttIDmoi)
	else  if(@sttIDmoi < 1000)
		set @IDmoi = concat('PT', '000', @sttIDmoi)
	else  if(@sttIDmoi < 10000)
		set @IDmoi = concat('PT', '00', @sttIDmoi)
	else  if(@sttIDmoi < 100000)
		set @IDmoi = concat('PT', '0', @sttIDmoi)
	else
		set @IDmoi = concat('PT', @sttIDmoi)

	return @IDmoi
END

--------- THÊM STORE PROCEDURES TAB PHAN QUYEN ----------
-- Lấy mã vai trò tiếp theo
go
create proc sp_LayMaVaiTro
	@kq varchar(10) output
as
begin
	declare @ma int
	set @ma = 1

	declare cur Cursor
	for select MaVaiTro
	from VAITRO

	open cur
	declare @mavt varchar(10)
	fetch next from cur into @mavt
	while @@FETCH_STATUS = 0 
	begin
		if @ma != cast(@mavt as int)
			break

		set @ma += 1
		fetch next from cur into @mavt
	end
	close cur
	deallocate cur

	declare @len int, @j int--, @kq varchar(10)
	set @kq = ''
	set @len = 3 - len(cast(@ma as varchar(10)))

	set @j = 0
	while(@j < @len)
	begin
		set @kq += '0'

		set @j += 1
	end
	set @kq += CAST(@ma as varchar(3))

end
go

-- tự động set Id cho BANGKE_PHIEUTHUTIEN
go
create function SetAutoIdBANGKE_PHIEUCHITIEN()
returns nchar(10)
as
begin
	declare @sttIDmoi int
	declare @IDmoi nchar(10)
	set @sttIDmoi = 1

	while(@sttIDmoi in (select cast(right(MaPhieuBangKe, 6) as int)
						from BANGKE_PHIEUCHITIEN)		  
		 )
	begin
		set @sttIDmoi = @sttIDmoi + 1
	end
	if(@sttIDmoi < 10)
		set @IDmoi = concat('PC', '00000', @sttIDmoi)
	else  if(@sttIDmoi < 100)
		set @IDmoi = concat('PC', '0000', @sttIDmoi)
	else  if(@sttIDmoi < 1000)
		set @IDmoi = concat('PC', '000', @sttIDmoi)
	else  if(@sttIDmoi < 10000)
		set @IDmoi = concat('PC', '00', @sttIDmoi)
	else  if(@sttIDmoi < 100000)
		set @IDmoi = concat('PC', '0', @sttIDmoi)
	else
		set @IDmoi = concat('PC', @sttIDmoi)

	return @IDmoi
end
go
---------------------------------------


-- lay ma vai tro trong bang nguoi dung
create proc sp_GetMaVaiTroND
	@tendangnhap varchar(20),
	@mavt varchar(10) output
as
begin
	select @mavt = MaVaiTro
	from NGUOIDUNG
	where TenDangNhap = @tendangnhap
end
go


-- lấy password của user
create proc sp_GetPassword
	@username varchar(20),
	@pass varchar(20) output
as
begin
	select @pass = Password
	from NGUOIDUNG
	where TenDangNhap = @username
end
go

