CREATE TABLE NhanSu (
    manhansu nvarchar(25),
    hoten nvarchar(30),
    ngaysinh datetime,
    gioitinh nvarchar(25),
    diachi nvarchar(50),
    trinhdo nvarchar(25),
    loainhansu nvarchar(35),
	PRIMARY KEY (manhansu)
);
CREATE TABLE QuanLy (
    manhansu nvarchar(25),
    hoten nvarchar(30),
    ngaysinh datetime,
    gioitinh nvarchar(25),
    diachi nvarchar(50),
    trinhdo nvarchar(25),
    loainhansu nvarchar(35),
	PRIMARY KEY (manhansu)
);
CREATE TABLE KySu (
    manhansu nvarchar(25),
    hoten nvarchar(30),
    ngaysinh datetime,
    gioitinh nvarchar(25),
    diachi nvarchar(50),
    trinhdo nvarchar(25),
    loainhansu nvarchar(35),
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
    loainhansu nvarchar(35),
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
    loainhansu nvarchar(35),
	congviec nvarchar(35),
	phong nvarchar(35),
	PRIMARY KEY (manhansu)
);

GO
CREATE TRIGGER tr_NhanVien_Insert
ON NhanVien
AFTER INSERT
AS
BEGIN
    INSERT INTO NhanSu (manhansu, hoten, ngaysinh, gioitinh, diachi, trinhdo, loainhansu)
    SELECT manhansu, hoten, ngaysinh, gioitinh, diachi, trinhdo, loainhansu
    FROM inserted;
END;

GO
CREATE TRIGGER tr_CongNhan_Insert
ON CongNhan
AFTER INSERT
AS
BEGIN
    INSERT INTO NhanSu (manhansu, hoten, ngaysinh, gioitinh, diachi, trinhdo, loainhansu)
    SELECT manhansu, hoten, ngaysinh, gioitinh, diachi, trinhdo, loainhansu
    FROM inserted;
END;

GO
CREATE TRIGGER tr_KySu_Insert
ON KySu
AFTER INSERT
AS
BEGIN
    INSERT INTO NhanSu (manhansu, hoten, ngaysinh, gioitinh, diachi, trinhdo, loainhansu)
    SELECT manhansu, hoten, ngaysinh, gioitinh, diachi, trinhdo, loainhansu
    FROM inserted;
END;

GO
CREATE TRIGGER tr_QuanLy_Insert
ON QuanLy
AFTER INSERT
AS
BEGIN
    INSERT INTO NhanSu (manhansu, hoten, ngaysinh, gioitinh, diachi, trinhdo, loainhansu)
    SELECT manhansu, hoten, ngaysinh, gioitinh, diachi, trinhdo, loainhansu
    FROM inserted;
END;


INSERT INTO QuanLy (manhansu, hoten, ngaysinh, gioitinh, diachi, trinhdo, loainhansu) VALUES
('QL02', N'Nguyễn Văn Bình', '1971-02-02', N'Nam', N'456 Tran Hung Dao, Q5', N'Cao đẳng', N'Quản lý'),
('QL03', N'Nguyễn Văn Chính', '1971-02-02', N'Nam', N'456 Tran Hung Dao, Q5', N'Cao đẳng', N'Quản lý'),
('QL04', N'Nguyễn Minh Cường', '1971-02-02', N'Nam', N'456 Tran Hung Dao, Q5', N'Cao đẳng', N'Quản lý'),
('QL05', N'Võ Minh Bình', '1971-02-02', N'Nam', N'456 Tran Hung Dao, Q5', N'Cao đẳng', N'Quản lý'),
('QL06', N'Võ Chí Minh', '1971-02-02', N'Nam', N'456 Tran Hung Dao, Q5', N'Đại học', N'Quản lý'),
('QL07', N'Thiên Minh Vũ', '1971-02-02', N'Nam', N'456 Tran Hung Dao, Q5', N'Đại học', N'Quản lý'),
('QL08', N'Cao Chí Minh', '1971-02-02', N'Nam', N'456 Tran Hung Dao, Q5', N'Đại học', N'Quản lý'),
('QL09', N'Vũ Cường', '1971-02-02', N'Nam', N'456 Tran Hung Dao, Q5', N'Đại học', N'Quản lý'),
('QL10', N'Nguyễn Văn', '1979-10-10', N'Nam', N'789 Nguyen Trai, Q5', N'Đại học', N'Quản lý');


INSERT INTO KySu (manhansu, hoten, ngaysinh, gioitinh, diachi, trinhdo, loainhansu, nganhdaotao, bophan) VALUES
('KS01', N'Trần Thị Lệ', '1980-01-01', N'Nữ', N'123 Le Loi, Q1', N'Đại học', N'Kỹ sư', N'Ngành thiết kế', N'Bộ phận xây dựng'),
('KS02', N'Nguyễn Thị Thúy', '1981-02-02', N'Nữ', N'456 Tran Hung Dao, Q5', N'Đại học', N'Kỹ sư', N'Ngành thiết kế', N'Bộ phận xây dựng'),
('KS03', N'Vũ Thị Bích', '1981-02-02', N'Nữ', N'456 Tran Hung Dao, Q5', N'Đại học', N'Kỹ sư', N'Ngành thiết kế', N'Bộ phận xây dựng'),
('KS04', N'Trần Thị Thi', '1981-02-02', N'Nữ', N'456 Tran Hung Dao, Q5', N'Đại học', N'Kỹ sư', N'Ngành thiết kế', N'Bộ phận thiết kế'),
('KS05', N'Nguyễn Thị Thúy', '1981-02-02', N'Nữ', N'456 Tran Hung Dao, Q5', N'Đại học', N'Kỹ sư', N'Ngành công nghệ thông tin', N'Bộ phận thiết kế'),
('KS06', N'Nguyễn thị Minh Tuyết', '1981-02-02', N'Nữ', N'456 Tran Hung Dao, Q5', N'Đại học', N'Kỹ sư', N'Ngành công nghệ thông tin', N'Bộ phận thiết kế'),
('KS07', N'Trần Thị Nhi', '1981-02-02', N'Nữ', N'456 Tran Hung Dao, Q5', N'Đại học', N'Kỹ sư', N'Ngành xây dựng', N'Bộ phận quản lý'),
('KS08', N'Võ Minh Nguyệt', '1981-02-02', N'Nữ', N'456 Tran Hung Dao, Q5', N'Đại học', N'Kỹ sư', N'Ngành xây dựng', N'Bộ phận quản lý'),
('KS09', N'Xuân My', '1981-02-02', N'Nữ', N'456 Tran Hung Dao, Q5', N'Đại học', N'Kỹ sư', N'Ngành xây dựng', N'Bộ phận công nghệ thông tin'),
('KS10', N'Nguyễn Thị Minh Thúy', '1989-10-10', N'Nữ', N'789 Nguyen Trai, Q5', N'Đại học', N'Kỹ sư', N'Ngành xây dựng', N'Bộ phận công nghệ thông tin');


INSERT INTO CongNhan (manhansu, hoten, ngaysinh, gioitinh, diachi, trinhdo, loainhansu, bac, loaito, nhom) VALUES
('CN01', N'Lê Minh Dũng', '1990-01-01', N'Nam', N'123 Le Loi, Q1', N'Cao đẳng', N'Công nhân', N'Bậc 1', N'Tổ xây dựng', N'Nhóm 1'),
('CN02', N'Vũ Minh', '1991-02-02', N'Nam', N'456 Tran Hung Dao, Q5', N'Cao đẳng', N'Công nhân', N'Bậc 2', N'Tổ xây dựng', N'Nhóm 2'),
('CN03', N'Văn Cường', '1991-02-02', N'Nam', N'456 Tran Hung Dao, Q5', N'Cao đẳng', N'Công nhân', N'Bậc 2', N'Tổ thiết kế', N'Nhóm 3'),
('CN04', N'Chí Huy', '1991-02-02', N'Nam', N'456 Tran Hung Dao, Q5', N'Cao đẳng', N'Công nhân', N'Bậc 1', N'Tổ thiết kế', N'Nhóm 2'),
('CN05', N'Trần Minh Duy', '1991-02-02', N'Nam', N'456 Tran Hung Dao, Q5', N'Cao đẳng', N'Công nhân', N'Bậc 3', N'Tổ thiết kế', N'Nhóm 3'),
('CN06', N'Lê Cường', '1991-02-02', N'Nam', N'456 Tran Hung Dao, Q5', N'Cao đẳng', N'Công nhân', N'Bậc 3', N'Tổ công nghệ', N'Nhóm 2'),
('CN07', N'Minh CƯờng', '1991-02-02', N'Nam', N'456 Tran Hung Dao, Q5', N'Đại học', N'Công nhân', N'Bậc 4', N'Tổ công nghệ', N'Nhóm 7'),
('CN08', N'Võ Chí Dũng', '1991-02-02', N'Nam', N'456 Tran Hung Dao, Q5', N'Đại học', N'Công nhân', N'Bậc 4', N'Tổ Kế toán', N'Nhóm 7'),
('CN09', N'Nguyễn Minh Chí', '1991-02-02', N'Nam', N'456 Tran Hung Dao, Q5', N'Đại học', N'Công nhân', N'Bậc 5', N'Tổ Kế toán', N'Nhóm 1'),
('CN10', N'Lê Văn', '1999-10-10', N'Nam', N'789 Nguyen Trai, Q5', N'Đại học', N'Công nhân', N'Bậc 5', N'Tổ kinh doanh', N'Nhóm 5');




INSERT INTO NhanVien (manhansu, hoten, ngaysinh, gioitinh, diachi, trinhdo, loainhansu, congviec, phong) VALUES
('NV01', N'Phạm Minh', '2000-01-01', N'Nữ', N'123 Le Loi, Q1', N'Cao đẳng', N'Nhân viên', N'Kế toán', N'Phòng nhân sự'),
('NV02', N'Phạm Thị Minh', '2001-02-02', N'Nữ', N'456 Tran Hung Dao, Q5', N'Cao đẳng', N'Nhân viên', N'Kế toán', N'Phòng thiết kế'),
('NV03', N'Phạm Thị Bích', '2001-02-02', N'Nữ', N'456 Tran Hung Dao, Q5', N'Cao đẳng', N'Nhân viên', N'Kế toán', N'Phòng nhân sự'),
('NV04', N'Vũ Lệ', '2001-02-02', N'Nữ', N'456 Tran Hung Dao, Q5', N'Cao đẳng', N'Nhân viên', N'Kế toán', N'Phòng xây dựng'),
('NV05', N'Lệ Tuyết', '2001-02-02', N'Nữ', N'456 Tran Hung Dao, Q5', N'Đại học', N'Nhân viên', N'Thiết kế', N'Phòng kế toán'),
('NV06', N'Tuyết Nhi', '2001-02-02', N'Nữ', N'456 Tran Hung Dao, Q5', N'Đại học', N'Nhân viên', N'Thiết kế', N'Phòng kế toán'),
('NV07', N'Minh Nhi', '2001-02-02', N'Nữ', N'456 Tran Hung Dao, Q5', N'Đại học', N'Nhân viên', N'Thiết kế', N'Phòng công nghệ'),
('NV08', N'Thị Thi', '2001-02-02', N'Nữ', N'456 Tran Hung Dao, Q5', N'Đại học', N'Nhân viên', N'Công nhân', N'Phòng công nghệ'),
('NV09', N'Lệ Nhi', '2001-02-02', N'Nữ', N'456 Tran Hung Dao, Q5', N'Đại học', N'Nhân viên', N'Công nhân', N'Phòng nhân sự'),
('NV10', N'Thiên Vũ', '2009-10-10', N'Nữ', N'789 Nguyen Trai, Q5', N'Đại học', N'Nhân viên', N'Công nhân', N'Phòng nhân sự');

DROP TRIGGER tr_NhanVien_Insert;
DROP TRIGGER tr_CongNhan_Insert;
DROP TRIGGER tr_KySu_Insert;
DROP TRIGGER tr_QuanLy_Insert;

