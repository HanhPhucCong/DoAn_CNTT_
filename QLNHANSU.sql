USE QLNHANSU
GO

CREATE TABLE NGUOIDUNG
(
	MaNguoiDung varchar (10) PRIMARY KEY,
	ChucVu varchar (20) NOT NULL
)
GO
CREATE TABLE TONV
(
	MaTo varchar (10) PRIMARY KEY,
	TenTo varchar (10) NOT NULL
)
GO
CREATE TABLE PHONGBAN
(
	MaPhong varchar (10) PRIMARY KEY,
	TenPhong varchar (10) NOT NULL
)
GO 
CREATE TABLE KYSU
(
	MaKySu varchar (10) PRIMARY KEY,
	HoTen nvarchar (50) NOT NULL,
	NgaySinh datetime NOT NULL,
	GioiTinh varchar (10) NOT NULL,
	DiaChi varchar (100) NOT NULL,
	SoDienThoai varchar (20),
	TrinhDo varchar (10) NOT NULL,
	ChucVu varchar (20) NOT NULL,
	CongViec varchar (100) NOT NULL,
	ThuocBoPhan varchar (100) NOT NULL
	check (SoDienThoai like '0[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
)
GO
CREATE TRIGGER THEMNGUOIDUNG_KYSU
ON KYSU
after insert
as
begin 
	declare @manguoidung varchar (10)
	declare @chucvu varchar (20)
	select @manguoidung = MaKySu from KYSU
	select @chucvu = ChucVu from KYSU
	insert into NGUOIDUNG values (@manguoidung, @chucvu)
end;
GO
CREATE TRIGGER SUANGUOIDUNG_KYSU
ON KYSU
after update
as
begin 
	declare @OLD_manguoidung varchar (10)
	declare @NEW_manguoidung varchar (10)
	declare @NEW_chucvu varchar (20)

	select @OLD_manguoidung = deleted.MaKySu from deleted
	select @NEW_manguoidung = inserted.MaKySu from inserted
	select @NEW_chucvu = inserted.ChucVu from inserted


	update NGUOIDUNG set MaNguoiDung = @NEW_manguoidung, ChucVu = @NEW_chucvu where MaNguoiDung = @OLD_manguoidung 
end;
GO
CREATE TRIGGER XOANGUOIDUNG_KYSU
ON KYSU
after delete
as
begin 
	declare @manguoidung varchar (10)
	select @manguoidung = deleted.MaKySu from deleted
	delete from NGUOIDUNG where MaNguoiDung = @manguoidung
end;


CREATE TABLE NHANVIEN
(
	MaNhanVien varchar (10) PRIMARY KEY,
	HoTen nvarchar (50) NOT NULL,
	NgaySinh datetime NOT NULL,
	GioiTinh varchar (10) NOT NULL,
	DiaChi varchar (100) NOT NULL,
	SoDienThoai varchar (20),
	TrinhDo varchar (10) NOT NULL,
	ChucVu varchar (20) NOT NULL,
	ThuocBac int NOT NULL,
	ThuocTo varchar NOT NULL,
	ThuocNhom varchar NOT NULL,
	check (SoDienThoai like '0[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
)

GO
CREATE TRIGGER THEMNGUOIDUNG_NV
ON NHANVIEN
after insert
as
begin 
	declare @manguoidung varchar (10)
	declare @chucvu varchar (20)
	select @manguoidung = MaNhanVien from NHANVIEN
	select @chucvu = ChucVu from NHANVIEN
	insert into NGUOIDUNG values (@manguoidung)
end;
GO
CREATE TRIGGER XOANGUOIDUNG_NV
ON NHANVIEN
after delete
as
begin 
	declare @manguoidung varchar (10)
	select @manguoidung = deleted.MaNhanVien from deleted
	delete from NGUOIDUNG where MaNguoiDung = @manguoidung
end;
GO
CREATE TRIGGER SUANGUOIDUNG_NV
ON NHANVIEN
after update
as
begin 
	declare @OLD_manguoidung varchar (10)
	declare @NEW_manguoidung varchar (10)
	declare @NEW_chucvu varchar (20)
	select @OLD_manguoidung = deleted.MaNhanVien from deleted
	select @NEW_manguoidung = inserted.MaNhanVien from inserted
	select @NEW_chucvu = inserted.ChucVu from inserted

	update NGUOIDUNG set MaNguoiDung = @NEW_manguoidung, ChucVu = @NEW_chucvu where MaNguoiDung = @OLD_manguoidung 
end;


CREATE TABLE QUANLY
(
	MaQuanLy varchar (10) PRIMARY KEY,
	HoTen nvarchar (50) NOT NULL,
	NgaySinh datetime NOT NULL,
	GioiTinh varchar (10) NOT NULL,
	DiaChi varchar (100) NOT NULL,
	SoDienThoai varchar (20),
	TrinhDo varchar (10) NOT NULL,
	ChucVu varchar (20) NOT NULL,
	CongViec varchar (100) NOT NULL,
	ThuocPhong varchar (100) NOT NULL,
	check (SoDienThoai like '0[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
)
GO
CREATE TRIGGER THEMNGUOIDUNG_QL
ON QUANLY
after insert
as
begin 
	declare @manguoidung varchar (10)
	declare @chucvu varchar (20)
	select @manguoidung = MaQuanLy from QUANLY
	select @chucvu = ChucVu from QUANLY
	insert into NGUOIDUNG values (@manguoidung)
end;
GO
CREATE TRIGGER XOANGUOIDUNG_QL
ON QUANLY
after delete
as
begin 
	declare @manguoidung varchar (10)
	select @manguoidung = deleted.MaQuanLy from deleted
	delete from NGUOIDUNG where MaNguoiDung = @manguoidung
end;
GO
CREATE TRIGGER SUANGUOIDUNG_QL
ON QUANLY
after update
as
begin 
	declare @OLD_manguoidung varchar (10)
	declare @NEW_manguoidung varchar (10)
	declare @NEW_chucvu varchar (20)
	select @OLD_manguoidung = deleted.MaQuanLy from deleted
	select @NEW_manguoidung = inserted.MaQuanLy from inserted
	select @NEW_chucvu = inserted.ChucVu from inserted
	update NGUOIDUNG set MaNguoiDung = @NEW_manguoidung, ChucVu = @NEW_chucvu where MaNguoiDung = @OLD_manguoidung 
end;


GO
CREATE TABLE DANGNHAP
(
	MaNguoiDangNhap varchar(10) NOT NULL,
	TenDangNhap varchar (50) NOT NULL,
	MatKhau varchar (50) NOT NULL,
	Email varchar(50),
	ChucVu varchar (50),
	CHECK (Email like '%@%.%'),
	CONSTRAINT FK_LOGI_IDUSER 	FOREIGN KEY (MaNguoiDangNhap) REFERENCES NGUOIDUNG(MaNguoiDung)
)

