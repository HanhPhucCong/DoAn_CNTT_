CREATE TABLE NhanSu (
    manhansu nvarchar(25),
    hoten nvarchar(30),
    ngaysinh datetime,
    gioitinh nvarchar(25),
    diachi nvarchar(50),
    trinhdo nvarchar(25),
    chucvu nvarchar(35),
	PRIMARY KEY (manhansu)
);
CREATE TABLE QuanLy (
    manhansu nvarchar(25),
    hoten nvarchar(30),
    ngaysinh datetime,
    gioitinh nvarchar(25),
    diachi nvarchar(50),
    trinhdo nvarchar(25),
    chucvu nvarchar(35),
	PRIMARY KEY (manhansu)
);
CREATE TABLE KySu (
    manhansu nvarchar(25),
    hoten nvarchar(30),
    ngaysinh datetime,
    gioitinh nvarchar(25),
    diachi nvarchar(50),
    trinhdo nvarchar(25),
    chucvu nvarchar(35),
	nganhdaotao nvarchar(35),
	bophan nvarchar(35),
	PRIMARY KEY (manhansu)
);
CREATE TABLE CongNhan (
    manhansu nvarchar(25),
    hoten nvarchar(30),
    ngaysinh datetime,
    gioitinh nvarchar(25),
    diachi nvarchar(50),
    trinhdo nvarchar(25),
    chucvu nvarchar(35),
	bac nvarchar(15),
	loaito nvarchar(15),
	nhom nvarchar(15),
	PRIMARY KEY (manhansu)
);
CREATE TABLE NhanVien (
    manhansu nvarchar(25),
    hoten nvarchar(30),
    ngaysinh datetime,
    gioitinh nvarchar(25),
    diachi nvarchar(50),
    trinhdo nvarchar(25),
    chucvu nvarchar(35),
	congviec nvarchar(35),
	phong nvarchar(35),
	PRIMARY KEY (manhansu)
);
drop Table NhanSu;
drop table NhanVien;
drop table QuanLy;
drop table KySu;
drop table CongNhan;
SELECT *FROM NhanSu
select *from NhanVien
select *from QuanLy
select *from KySu
select *from CongNhan
