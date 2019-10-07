USE Master
GO
If Exists(select* From SysDatabases Where Name='QuanLyDeThi')
Drop Database QuanLyDeThi
GO
Create Database QuanLyDeThi
GO
Use QuanLyDeThi
GO

-- Tạo bảng
CREATE TABLE [Khoa]
(
	MaKhoa nvarchar(30),
	PRIMARY KEY (MaKhoa)
)

CREATE TABLE [Lop]
(
	MaLop nvarchar(30),
	ChuyenNganh nvarchar(30),
	PRIMARY KEY (MaLop)
)

CREATE TABLE [BoMon]
(
	MaBoMon nvarchar(30),
	TenBoMon nvarchar(30),
	PRIMARY KEY (MaBoMon)
)

CREATE TABLE [Mon]
(
	MaMon nvarchar(30),
	TenMon nvarchar(30),
	MaBoMon nvarchar(30),
	PRIMARY KEY (MaMon)
)

CREATE TABLE [GiaoVien]
(
	MaGiaoVien nvarchar(30),
	HoTen nvarchar(30),
	MaBoMon nvarchar(30),
	ChucVu nvarchar(30),
	GioiTinh nvarchar(30),
	SDT nvarchar(30),
	PRIMARY KEY (MaGiaoVien)
)

CREATE TABLE [DeThi]
(
	MaDe nvarchar(30),
	MaLop nvarchar(30),
	MaKhoa nvarchar(30),
	MaMon nvarchar(30),
	MaGiaoVien nvarchar(30),
	SoLanBoc int,
	PRIMARY KEY (MaDe)
)

CREATE TABLE [Users]
(
	ID int,
	Ten nvarchar(30),
	MatKhau nvarchar(30),
	Kieu nvarchar(30),
	PRIMARY KEY (ID)
)

-- Điền dữ liệu
-- Khoá
INSERT INTO Khoa VALUES (N'D2')
INSERT INTO Khoa VALUES (N'D3')
INSERT INTO Khoa VALUES (N'D4')
INSERT INTO Khoa VALUES (N'D5')

-- Lớp
INSERT INTO Lop VALUES (N'B1',N'Công Nghệ Thông Tin')
INSERT INTO Lop VALUES (N'B2',N'Công Nghệ Thông Tin')
INSERT INTO Lop VALUES (N'B3',N'Công Nghệ Thông Tin')
INSERT INTO Lop VALUES (N'B4',N'Công Nghệ Thông Tin')
INSERT INTO Lop VALUES (N'B5',N'Điện Tử Truyền Thông')
INSERT INTO Lop VALUES (N'B6',N'Điện Tử Truyền Thông')
INSERT INTO Lop VALUES (N'B7',N'Điện Tử Truyền Thông')
INSERT INTO Lop VALUES (N'B8',N'Điện Tử Truyền Thông')

-- Bộ Môn
INSERT INTO BoMon VALUES (N'B2',N'Pháp Luật Nghiệp Vụ')
INSERT INTO BoMon VALUES (N'B3',N'Khoa Học Cơ Bản')
INSERT INTO BoMon VALUES (N'B4',N'Ngoại Ngữ')

-- Môn
INSERT INTO Mon VALUES (N'M21',N'Lịch Sử Truyền Thống CAND',N'B2')
INSERT INTO Mon VALUES (N'M22',N'Luật Hình Sự',N'B2')
INSERT INTO Mon VALUES (N'M23',N'Luật Tố Tụng Hình Sự',N'B2')
INSERT INTO Mon VALUES (N'M31',N'Giải Tích',N'B3')
INSERT INTO Mon VALUES (N'M32',N'Đại Số',N'B3')
INSERT INTO Mon VALUES (N'M33',N'Vật Lý Đại Cương',N'B3')
INSERT INTO Mon VALUES (N'M41',N'Tiếng Anh Cơ Sở 1',N'B4')
INSERT INTO Mon VALUES (N'M42',N'Tiếng Anh Cơ Sở 2',N'B4')
INSERT INTO Mon VALUES (N'M43',N'Tiếng Anh Cơ Sở 3',N'B4')

-- Giáo Viên
INSERT INTO GiaoVien VALUES (N'GV21',N'Vũ Hoàng Thanh Thuỷ',N'B2',N'',N'Nữ','01666992512')
INSERT INTO GiaoVien VALUES (N'GV22',N'Bùi Hồng Đại',N'B2',N'',N'Nam','01678452665')
INSERT INTO GiaoVien VALUES (N'GV23',N'Dương Phú Thuần',N'B2',N'',N'Nam','0982561249')
INSERT INTO GiaoVien VALUES (N'GV31',N'Phạm Thị Liễu 1',N'B3',N'',N'Nữ','01662435149')
INSERT INTO GiaoVien VALUES (N'GV32',N'Phạm Thị Liễu 2',N'B3',N'',N'Nữ','01688021658')
INSERT INTO GiaoVien VALUES (N'GV41',N'Nguyễn Đức Bình',N'B4',N'',N'Nam','0985236145')
INSERT INTO GiaoVien VALUES (N'GV42',N'Nguyễn Văn Hữu',N'B4',N'',N'Nam','0984265896')

-- Đề Thi
INSERT INTO DeThi VALUES (N'D2101',N'B1',N'D2',N'M21',N'GV21',0)
INSERT INTO DeThi VALUES (N'D2102',N'B2',N'D3',N'M21',N'GV21',0)
INSERT INTO DeThi VALUES (N'D2201',N'B3',N'D4',N'M22',N'GV22',0)
INSERT INTO DeThi VALUES (N'D2202',N'B4',N'D5',N'M22',N'GV22',0)
INSERT INTO DeThi VALUES (N'D2301',N'B5',N'D2',N'M23',N'GV23',0)
INSERT INTO DeThi VALUES (N'D2302',N'B6',N'D3',N'M23',N'GV23',0)

INSERT INTO DeThi VALUES (N'D3101',N'B7',N'D4',N'M31',N'GV31',0)
INSERT INTO DeThi VALUES (N'D3102',N'B8',N'D5',N'M31',N'GV31',0)
INSERT INTO DeThi VALUES (N'D3201',N'B1',N'D2',N'M32',N'GV32',0)
INSERT INTO DeThi VALUES (N'D3202',N'B2',N'D3',N'M32',N'GV32',0)
INSERT INTO DeThi VALUES (N'D3301',N'B3',N'D4',N'M33',N'GV32',0)
INSERT INTO DeThi VALUES (N'D3302',N'B4',N'D5',N'M33',N'GV32',0)

INSERT INTO DeThi VALUES (N'D4101',N'B5',N'D2',N'M41',N'GV41',0)
INSERT INTO DeThi VALUES (N'D4102',N'B6',N'D3',N'M41',N'GV41',0)
INSERT INTO DeThi VALUES (N'D4201',N'B7',N'D4',N'M42',N'GV41',0)
INSERT INTO DeThi VALUES (N'D4202',N'B8',N'D5',N'M42',N'GV41',0)
INSERT INTO DeThi VALUES (N'D4301',N'B1',N'D2',N'M43',N'GV42',0)
INSERT INTO DeThi VALUES (N'D4302',N'B2',N'D3',N'M43',N'GV42',0)

-- User
INSERT INTO Users VALUES (0,N'QL',N'QL',N'QL')
INSERT INTO Users VALUES (1,N'GV',N'GV',N'GV')

-- Tạo khoá ngoài
ALTER TABLE [DeThi] 
ADD CONSTRAINT [FK_DeThi_Lop] 
FOREIGN KEY 			
( MaLop )									
REFERENCES [Lop] 						
( MaLop )									
GO

ALTER TABLE [DeThi] 
ADD CONSTRAINT [FK_DeThi_Khoa] 
FOREIGN KEY 			
( MaKhoa )									
REFERENCES [Khoa] 						
( MaKhoa )									
GO

ALTER TABLE [DeThi] 
ADD CONSTRAINT [FK_DeThi_Mon] 
FOREIGN KEY 			
( MaMon )									
REFERENCES [Mon] 						
( MaMon )									
GO

ALTER TABLE [DeThi] 
ADD CONSTRAINT [FK_DeThi_GiaoVien] 
FOREIGN KEY 			
( MaGiaoVien )									
REFERENCES [GiaoVien] 						
( MaGiaoVien )									
GO

ALTER TABLE [Mon] 
ADD CONSTRAINT [FK_Mon_BoMon] 
FOREIGN KEY 			
( MaBoMon )									
REFERENCES [BoMon] 						
( MaBoMon )									
GO

ALTER TABLE [GiaoVien] 
ADD CONSTRAINT [FK_GiaoVien_BoMon] 
FOREIGN KEY 			
( MaBoMon )									
REFERENCES [BoMon] 						
( MaBoMon )									
GO

-- View
GO
CREATE VIEW View_MonHoc
AS
SELECT	MaMon as N'Mã Môn',
		TenMon as N'Tên Môn',
		MaBoMon as N'Mã Bộ Môn'
FROM	Mon
GO

GO
CREATE VIEW View_BoMon
AS
SELECT	MaBoMon as N'Mã Bộ Môn',
		TenBoMon as N'Tên Bộ Môn'
FROM	BoMon
GO

GO
CREATE VIEW View_ThongTin
AS
SELECT	DeThi.MaDe as N'Đề Thi', 
		DeThi.MaKhoa as N'Mã Khoá', 
		DeThi.MaLop as N'Mã Lớp', 
		Mon.TenMon as N'Tên Môn',
		GiaoVien.HoTen as N'Giáo Viên Ra Đề',
		DeThi.SoLanBoc as N'Số Lần Bốc'
FROM	DeThi,GiaoVien,Mon
WHERE	DeThi.MaGiaoVien = GiaoVien.MaGiaoVien
		AND DeThi.MaMon = Mon.MaMon
GO

GO
CREATE VIEW View_CapNhatDeThi
AS
SELECT	MaDe as N'Mã Đề',
		MaLop as N'Mã Lớp',
		MaKhoa as N'Mã Khoa',
		MaMon as N'Mã Môn',
		MaGiaoVien as 'Mã Giáo Viên'
FROM DeThi
GO

GO
CREATE VIEW View_ThongKe
AS
SELECT	Mon.TenMon as N'Tên Môn', 
		BoMon.TenBoMon as N'Tên Bộ Môn', 
		COUNT(Mon.TenMon) as 'Số Lượng Đề Khác Nhau'
FROM DeThi,Mon,BoMon
WHERE	DeThi.MaMon = Mon.MaMon
		AND Mon.MaBoMon = BoMon.MaBoMon
GROUP BY Mon.TenMon, BoMon.TenBoMon
GO

GO
CREATE VIEW View_BocDe
AS
SELECT	DeThi.MaDe as N'Mã Đề', 
		Mon.TenMon as N'Tên Môn', 
		BoMon.TenBoMon as N'Tên Bộ Môn', 
		DeThi.SoLanBoc as N'Số Lần Bốc'
FROM DeThi, Mon, BoMon
WHERE	DeThi.MaMon = Mon.MaMon
		AND Mon.MaBoMon = BoMon.MaBoMon
GO

GO
CREATE VIEW View_GiaoVien
AS
SELECT	MaGiaoVien as N'Mã Giáo Viên',
		HoTen as N'Họ Tên',
		BoMon.MaBoMon as N'Mã Bộ Môn',
		BoMon.TenBoMon as N'Tên Bộ Môn',
		GiaoVien.ChucVu as N'Chức Vụ',
		GiaoVien.GioiTinh as N'Giới Tính',
		GiaoVien.SDT as N'SĐT'
FROM GiaoVien,BoMon
WHERE GiaoVien.MaBoMon = BoMon.MaBoMon
GO