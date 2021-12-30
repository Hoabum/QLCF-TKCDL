CREATE DATABASE QLCF1

USE QLCF1
GO

CREATE TABLE login(
	gmail nvarchar(200) NOT NULL,
	username nvarchar (200) NOT NULL,
	pass nvarchar(50),
	quyen nvarchar(50) NOT NULL,

CONSTRAINT PK_login PRIMARY KEY(username)
)
GO
ALTER TABLE NhanVien ADD CONSTRAINT fk_login FOREIGN KEY (username) REFERENCES login (username);
CREATE TABLE NhanVien(
	IDNhanVien int IDENTITY (1, 1) NOT NULL,
	HoTenNV nvarchar(50) NOT NULL,
	DiaChi nvarchar(50) NOT NULL,
	Sdt nvarchar(10) NOT NULL,
	GioiTinh nvarchar(10) NOT NULL,
	Luong nvarchar(50) NOT NULL,
	NgSinh datetime NOT NULL,
	NgVaoLam datetime NOT NULL,
	ChucVu nvarchar(50) NOT NULL,
	username nvarchar(200) NOT NULL,
CONSTRAINT PK_NhanVien PRIMARY KEY(IDNhanVien)
)
GO

CREATE TABLE kho(
	idMon int IDENTITY (1, 1) NOT NULL,
	idloai nchar(10) NOT NULL,
	ten nvarchar(200) NOT NULL,
	giamon float NOT NULL,
	anh image ,

CONSTRAINT PK_kho PRIMARY KEY(idMon)
)
GO
ALTER TABLE kho ADD CONSTRAINT fk_kho FOREIGN KEY (idloai) REFERENCES loai (idloai);
CREATE TABLE loai(
	idloai nchar(10) NOT NULL,
	loai nvarchar(200) NOT NULL,
CONSTRAINT PK_loai PRIMARY KEY(idloai)
)
GO

CREATE TABLE HOADON(
	MaHD varchar (1000) NOT NULL,
	IDNhanVien int NOT NULL,
	NgayHD datetime NOT NULL,
	TongTien float NOT NULL,
	Discount nvarchar(50) NOT NULL,
CONSTRAINT PK_HOADON PRIMARY KEY(MaHD)
)
GO
ALTER TABLE HOADON ADD CONSTRAINT Tk_NhanVien FOREIGN KEY (IDNhanVien) REFERENCES NhanVien (IDNhanVien);
ALTER TABLE CTHD ADD CONSTRAINT fk_HOADON FOREIGN KEY (MaHD) REFERENCES HOADON (MaHD);
ALTER TABLE CTHD ADD CONSTRAINT Tk_kho FOREIGN KEY (idMon) REFERENCES kho (idMon);
CREATE TABLE CTHD(
	MaHD varchar (1000) NOT NULL,
	idMon int NOT NULL,
	ten nvarchar(200) NOT NULL,
	giamon nvarchar(200) NOT NULL,
	Soluong int NOT NULL,
	ThanhTien float NOT NULL,
CONSTRAINT PK_CTHD PRIMARY KEY(MaHD, idMon)
)
GO

----


/* Insert  login*/
select *from login
INSERT INTO login(gmail, username, pass, quyen)
VALUES('hoabum2@gmail.com',N'ad', '123', 'admin')
delete from login
INSERT INTO login(gmail, username, pass, quyen)
VALUES('hoabum234@gmail.com',N'nv1', '123', 'nhanvien')
INSERT INTO login(gmail, username, pass, quyen)
VALUES('nguyen@gmail.com',N'nv23', '123', 'nhanvien')



INSERT INTO HOADON VALUES('HD11','4','2020-12-22 00:00:00.000' ,900000,'10')
INSERT INTO HOADON VALUES('HD12','4','2020-1-22 00:00:00.000' ,800000,'10')
INSERT INTO HOADON VALUES('HD13','4','2021-8-22 00:00:00.000' ,950000,'10')
INSERT INTO HOADON VALUES('HD14','4','2020-4-22 00:00:00.000' ,1400000,'10')
INSERT INTO HOADON VALUES('HD15','4','2021-4-1 00:00:00.000' ,700000,'10')
INSERT INTO HOADON VALUES('HD16','4','2021-1-30 00:00:00.000' ,500000,'10')

INSERT INTO HOADON VALUES('HD17','4','2021-12-26 00:00:00.000' ,1300000,'10')
INSERT INTO HOADON VALUES('HD18','4','2021-12-25 00:00:00.000' ,400000,'10')
INSERT INTO HOADON VALUES('HD19','4','2021-12-29 00:00:00.000' ,800000,'0')
INSERT INTO HOADON VALUES('HD20','4','2021-12-27 00:00:00.000' ,250000,'0')
INSERT INTO HOADON VALUES('HD21','4','2021-12-28 00:00:00.000' ,700000,'0')
INSERT INTO HOADON VALUES('HD22','4','2021-12-28 00:00:00.000' ,120000,'0')
--
INSERT INTO HOADON VALUES('HD23','4','2021-12-12 00:00:00.000' ,950000,'0')
INSERT INTO HOADON VALUES('HD24','4','2021-12-13 00:00:00.000' ,850000,'10')
INSERT INTO HOADON VALUES('HD25','4','2021-12-15 00:00:00.000' ,3900000,'0')
INSERT INTO HOADON VALUES('HD26','4','2021-12-16 00:00:00.000' ,1000000,'0')
INSERT INTO HOADON VALUES('HD27','4','2021-12-14 00:00:00.000' ,700000,'0')
INSERT INTO HOADON VALUES('HD28','4','2021-12-17 00:00:00.000' ,600000,'10')
INSERT INTO HOADON VALUES('HD29','4','2021-12-18 00:00:00.000' ,2000000,'0')
INSERT INTO HOADON VALUES('HD30','4','2021-12-20 00:00:00.000' ,1000000,'0')

INSERT INTO HOADON VALUES('HD31','4','2021-2-26 00:00:00.000' ,1100000,'10')

INSERT INTO HOADON VALUES('HD32','4','2021-5-26 00:00:00.000' ,1300000,'10')

INSERT INTO HOADON VALUES('HD33','4','2021-7-26 00:00:00.000' ,1600000,'10')
INSERT INTO HOADON VALUES('HD34','4','2021-10-26 00:00:00.000' ,1500000,'10')
INSERT INTO HOADON VALUES('HD35','4','2021-7-26 00:00:00.000' ,2000000,'10')

/* Insert loai */
INSERT INTO loai VALUES(1, N'Trà sữa' )
INSERT INTO loai VALUES(2, N'Nước ngọt' )
INSERT INTO loai VALUES(3, N'Cafe' )
INSERT INTO loai VALUES(4, N'Đồ ăn' )

------ SQL PHẦN THỐNG KÊ --------
----- thong ke doanh thu
CREATE PROCEDURE [dbo].[USP_ThongKeTheoNgayQLCF]
@ngaydau date, @ngaycuoi date
AS
BEGIN
	select DAY(NgayHD) AS 'Ngay', sum(HOADON.TongTien) AS 'TongTien'
	from HOADON
	where @ngaydau <= HOADON.NgayHD and @ngaycuoi >= HoaDon.NgayHD
	group by NgayHD 
END
GO
-- theo năm

SELECT SUM(HOADON.TongTien) AS 'TONGTIEN', year (HOADON.NgayHD) AS 'NAM'
FROM HOADON
GROUP BY year(HOADON.NgayHD)
 -- theo quý
 CREATE PROCEDURE [dbo].[USP_ThongKeTheoQuyQLCF]
 @nam int
 AS
 BEGIN
 SELECT SUM(a.TongTien) AS 'TONGTIEN', N'Quý ' + DATENAME(Quarter, CAST(CONVERT(VARCHAR(8), a.NgayHD) AS DATETIME)) AS 'QUY' 
 FROM HOADON as a
 WHERE  YEAR(a.NgayHD) = @nam
GROUP BY DATENAME(Quarter, CAST(CONVERT(VARCHAR(8),a.NgayHD) AS DATETIME))
END
GO

--theo tháng
 CREATE PROCEDURE [dbo].[USP_ThongKeTheoThangQLCF]
 @nam int
 AS
 BEGIN
SELECT SUM(b.TongTien) AS 'TONGTIEN', month (b.NgayHD) AS 'THANG' 
FROM HOADON as b
GROUP BY  b.NgayHD
HAVING YEAR(b.NgayHD) = @nam
END
GO

	-- thống kê sản phẩm bán dc
SELECT SUM(o.Quantity * o.Price) AS  'TONGTIEN', o.ProductName
FROM HOADON as a, KHO as b
 WHERE o.InvoiceNo = i.InvoiceNo AND YEAR(i.OrderDate) = 2021
 GROUP BY o.ProductName

 ----- thống kê hóa dơn
CREATE PROCEDURE [dbo].[USP_TKHDQLCF]
@ngaybd date, @ngaykt date
AS
BEGIN
	select HOADON.MaHD AS 'Mã HĐ', HOADON.NgayHD AS 'Ngày Tạo', HOADON.TongTien AS 'Tổng Tiền', NhanVien.HoTenNV AS 'Người Tạo'
from HOADON, NhanVien
where HOADON.IDNhanVien = NhanVien.IDNhanVien and @ngaybd <= HOADON.NgayHD and @ngaykt >= HOADON.NgayHD
order by HOADON.TongTien desc
END
GO


