CREATE TABLE NhanSu (
    manhansu NVARCHAR(25),
    hoten NVARCHAR(30),
    ngaysinh DATE,
    gioitinh NVARCHAR(25),
    diachi NVARCHAR(50),
    trinhdo NVARCHAR(25),
    chucvu NVARCHAR(35),
	PRIMARY KEY (manhansu)
);
CREATE TABLE QuanLy (
    manhansu NVARCHAR(25),
    hoten NVARCHAR(30),
    ngaysinh DATE,
    gioitinh NVARCHAR(25),
    diachi NVARCHAR(50),
    trinhdo NVARCHAR(25),
    chucvu NVARCHAR(35),
	PRIMARY KEY (manhansu)
);
CREATE TABLE KySu (
    manhansu NVARCHAR(25),
    hoten NVARCHAR(30),
    ngaysinh DATE,
    gioitinh NVARCHAR(25),
    diachi NVARCHAR(50),
    trinhdo NVARCHAR(25),
    chucvu NVARCHAR(35),
	nganhdaotao NVARCHAR(35),
	bophan NVARCHAR(35),
	PRIMARY KEY (manhansu)
);
CREATE TABLE CongNhan (
    manhansu NVARCHAR(25),
    hoten NVARCHAR(30),
    ngaysinh DATE,
    gioitinh NVARCHAR(25),
    diachi NVARCHAR(50),
    trinhdo NVARCHAR(25),
    chucvu NVARCHAR(35),
	bac NVARCHAR(15),
	loaito NVARCHAR(15),
	nhom NVARCHAR(15),
	PRIMARY KEY (manhansu)
);
CREATE TABLE NhanVien (
    manhansu NVARCHAR(25),
    hoten NVARCHAR(30),
    ngaysinh DATE,
    gioitinh NVARCHAR(25),
    diachi NVARCHAR(50),
    trinhdo NVARCHAR(25),
    chucvu NVARCHAR(35),
	congviec NVARCHAR(35),
	phong NVARCHAR(35),
	PRIMARY KEY (manhansu)
);
INSERT INTO NhanSu (manhansu, hoten, ngaysinh, gioitinh, diachi, trinhdo, chucvu) VALUES
('NS01', 'Nguy?n V?n A', '1980-01-01', 'Nam', '123 ???ng 1, Qu?n 1', '??i h?c', 'Giám ??c'),
('NS02', 'Tr?n Th? B', '1985-02-02', 'N?', '456 ???ng 2, Qu?n 2', 'Cao ??ng', 'Phó giám ??c'),
('NS03', 'Lê V?n C', '1990-03-03', 'Nam', '789 ???ng 3, Qu?n 3', 'Trung h?c ph? thông', 'Nhân viên'),
('NS04', 'Ph?m Th? D', '1995-04-04', 'N?', '321 ???ng 4, Qu?n 4', '??i h?c', 'Nhân viên'),
('NS05', 'V? V?n E', '2000-05-05', 'Nam', '654 ???ng 5, Qu?n 5', 'Cao ??ng', 'Nhân viên');
SELECT *FROM NhanSu
delete NhanSu where manhansu ='NS01';
delete NhanSu where manhansu ='NS02';
delete NhanSu where manhansu ='NS03';
delete NhanSu where manhansu ='NS04';
delete NhanSu where manhansu ='NS05';