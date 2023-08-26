CREATE DATABASE QLNS
USE QLNS
DROP DATABASE QLNS
--xoa
drop table HOADON
drop table CTHD
drop table THONGTINSACH
drop table CT_TACGIA
drop table TACGIA
drop table THONGTINSACH
drop table BAOCAOTONKHO
drop table NGUOIDUNG
drop table PHIEUNHAPSACH
drop table THAMSO
drop table BAOCAOTHUNO
drop table KHACHHANG
drop table PHIEUTHUNO
-- TAO BANG
CREATE TABLE TAIKHOAN
( 
    MaTK CHAR(5) PRIMARY KEY,
	TenTK VARCHAR(30) NOT NULL,
	MatKhau VARCHAR(30)NOT NULL,
	MaNguoiDung CHAR(5)NOT NULL,
	VaiTro VARCHAR(20)NOT NULL,
)

CREATE TABLE NGUOIDUNG
(
    MaNguoiDung CHAR(5) PRIMARY KEY,
	HoTen NVARCHAR(30)NOT NULL,
	SDT VARCHAR(20)NOT NULL,
	Email VARCHAR(20)NOT NULL,
	DiaChi NVARCHAR(40)NOT NULL,
	GioiTinh CHAR(4)NOT NULL,
)

 CREATE TABLE HOADON
(
    MaHD CHAR(5) PRIMARY KEY,
    MaKH CHAR(5) NOT NULL,
	NgayHD SMALLDATETIME NOT NULL,
	GiamGia MONEY DEFAULT 0,
	TongHoaDon MONEY DEFAULT 0,
	SoTienDaThanhToan MONEY DEFAULT 0,
	MaNguoiDung CHAR(5) NOT NULL,
)

CREATE TABLE CTHD
(
    MaHD CHAR(5),
	MaSach CHAR(5),
	SL_HD INT DEFAULT 0,
	PRIMARY KEY(MaHD, MaSach)
)

CREATE TABLE THONGTINSACH
(
    MaSach CHAR(5) PRIMARY KEY,
	TheLoai NVARCHAR(20)NOT NULL,
	TenSach NVARCHAR(50)NOT NULL,
	SoLuong INT DEFAULT 0,
	GiaBan int NOT NULL,
	NgayPhatHanh SMALLDATETIME NOT NULL,
	TenAnh NVARCHAR(50) NOT NULL,
)

CREATE TABLE CT_TACGIA
( 
    MaSach CHAR(5),
	MaTacGia CHAR(5),
	PRIMARY KEY(MaSach, MaTacGia)
    
)

CREATE TABLE TACGIA
(
    MaTacGia CHAR(5) PRIMARY KEY,
	TenTacGia NVARCHAR(30) NOT NULL,
	NgaySinh DATETIME NOT NULL,
)

CREATE TABLE PHIEUNHAPSACH
(
    NgayNhap SMALLDATETIME,
	MaSach CHAR(5) NOT NULL,
	SoLuongNhap INT NOT NULL,
	GiaNhap MONEY NOT NULL,
	PRIMARY KEY(NgayNhap, MaSach),
)

CREATE TABLE BAOCAOTONKHO
(
    MaBCTK CHAR(10) PRIMARY KEY,
	MaSach CHAR(5) NOT NULL,
	TonDau INT DEFAULT 0,
	SachDaNhap INT DEFAULT 0,
	SachDaBan INT DEFAULT 0,
	TonCuoi INT DEFAULT 0,
	Thang CHAR(4) NOT NULL,
)

CREATE TABLE KHACHHANG
(
    MaKH CHAR(5) PRIMARY KEY,
	HoTen NVARCHAR(30)NOT NULL,
	SDT_KH VARCHAR(20)NOT NULL,
	Email_KH VARCHAR(30)NOT NULL,
	DiaChi_KH NVARCHAR(40)NOT NULL,
	GioiTinh_KH CHAR(4)NOT NULL,	
	NgayDKTV SMALLDATETIME NOT NULL,
	SoTienNo int DEFAULT 0,
)

CREATE TABLE PHIEUTHUNO
(
    MaPTN Int PRIMARY KEY,
	MaKH CHAR(5) NOT NULL,
	NgayThuTien SMALLDATETIME NOT NULL,
	SoTienThanhToan MONEY NOT NULL,
	GhiChu NVARCHAR(30),
)

CREATE TABLE BAOCAOTHUNO
(
    MaBCTN CHAR(10) PRIMARY KEY,
	MaKH CHAR(5) NOT NULL,
	Thang CHAR(4) NOT NULL,
	NoDau MONEY DEFAULT 0,
	NoCuoi MONEY DEFAULT 0,
	SoTienNo MONEY DEFAULT 0,
	SoTienThanhToan MONEY DEFAULT 0,
)

CREATE TABLE THAMSO
(
	MaThamSo CHAR(10) PRIMARY KEY,
	TenThamSo CHAR(30) NOT NULL,
	GiaTri FLOAT NOT NULL, 
)


--SET FOREIGN KEY

--TAIKHOAN : NGUOIDUNG
ALTER TABLE TAIKHOAN ADD CONSTRAINT FK_TK_ND FOREIGN KEY(MaNguoiDung) REFERENCES NGUOIDUNG(MaNguoiDung)
ALTER TABLE TAIKHOAN drop constraint FK_TK_ND

--HOADON : NGUOIDUNG
ALTER TABLE HOADON ADD CONSTRAINT FK_HD_ND FOREIGN KEY(MaNguoiDung) REFERENCES NGUOIDUNG(MaNguoiDung)
ALTER TABLE HOADON drop constraint FK_HD_ND

--CTHD : HOADON
ALTER TABLE CTHD ADD CONSTRAINT FK_CTHD_HD FOREIGN KEY(MaHD) REFERENCES HOADON(MaHD)
ALTER TABLE CTHD drop constraint FK_CTHD_HD

--HOADON : KHACHHANG
ALTER TABLE HOADON ADD CONSTRAINT FK_HD_KH FOREIGN KEY(MaKH) REFERENCES KHACHHANG(MaKH)
ALTER TABLE HOADON drop constraint FK_HD_KH

--CTHD : THONGTINSACH
ALTER TABLE CTHD ADD CONSTRAINT FK_CTHD_TTS FOREIGN KEY(MaSach) REFERENCES THONGTINSACH(MaSach)
ALTER TABLE CTHD drop constraint FK_CTHD_TTS

--CT_TACGIA : THONGTINSACH
ALTER TABLE CT_TACGIA ADD CONSTRAINT FK_CTTG_TTS FOREIGN KEY(MaSach) REFERENCES THONGTINSACH(MaSach)
ALTER TABLE CT_TACGIA drop constraint FK_CTTG_TG

--CT_TACGIA : TACGIA
ALTER TABLE CT_TACGIA ADD CONSTRAINT FK_CTTG_TG FOREIGN KEY(MaTacGia) REFERENCES TACGIA(MaTacGia)
ALTER TABLE CT_TACGIA drop constraint FK_CTTG_TG
--BAOCAOTHUNO : KHACHHANG
ALTER TABLE BAOCAOTHUNO ADD CONSTRAINT FK_BCTN_KH FOREIGN KEY(MaKH) REFERENCES KHACHHANG(MaKH)
ALTER TABLE BAOCAOTHUNO drop constraint FK_BCTN_KH
--BAOCAOTONKHO : THONGTINSACH
ALTER TABLE BAOCAOTONKHO ADD CONSTRAINT FK_BCTK_TTS FOREIGN KEY(MaSach) REFERENCES THONGTINSACH(MaSach)
ALTER TABLE BAOCAOTONKHO drop constraint FK_BCTK_TTS
--PHIEUNHAPSACH : THONGTINSACH
ALTER TABLE PHIEUNHAPSACH ADD CONSTRAINT FK_PNS_TTS FOREIGN KEY(MaSach) REFERENCES THONGTINSACH(MaSach)
ALTER TABLE PHIEUNHAPSACH drop constraint FK_PNS_TTS
--PHIEUTHUNO : KHACHHANG
ALTER TABLE PHIEUTHUNO ADD CONSTRAINT FK_PTN_KH FOREIGN KEY(MaKH) REFERENCES KHACHHANG(MaKH)
ALTER TABLE PHIEUTHUNO drop constraint FK_PTN_KH
alter table PHIEUTHUNO ADD constraint Check_TienNo check (SoTienThanhToan <= SoTienNo(KHACHHANG)
--Insert user information\

INSERT INTO NGUOIDUNG(MaNguoiDung, HoTen, SDT, Email, DiaChi, GioiTinh) values ('ND01' ,N'Phạm Tiến Đạt', '0909227812', 'tndat12@gmail.com', '23/5 Nguyen Trai, Q5, TpHCM', 'Nam')
INSERT INTO NGUOIDUNG(MaNguoiDung, HoTen, SDT, Email, DiaChi, GioiTinh) values ('ND02', 'Tran Ngoc Han', '280000' ,'Tran@gmail.com', '23/5 Nguyen Trai, Q5, TpHCM', 'Nu')
INSERT INTO NGUOIDUNG(MaNguoiDung, HoTen, SDT, Email, DiaChi, GioiTinh) values ('ND03', 'Tran Minh Long', '0917325476', 'TranLong@gmail.com', '50/34 Le Dai Hanh, Q10, TpHCM', 'Nam')
INSERT INTO NGUOIDUNG(MaNguoiDung, HoTen, SDT, Email, DiaChi, GioiTinh) values ('ND04', 'Tran Ngoc Linh', '0938776266', 'TranLinh@gmail.com', '45 Nguyen Canh Chan, Q1, TpHCM', 'Nu')
INSERT INTO NGUOIDUNG(MaNguoiDung, HoTen, SDT, Email, DiaChi, GioiTinh) values ('ND06', 'Le Nhat Minh', '08246108', 'LeMinh@gmail.com', '34 Truong Dinh, Q3, TpHCM', 'Nam')
INSERT INTO NGUOIDUNG(MaNguoiDung, HoTen, SDT, Email, DiaChi, GioiTinh) values ('ND07', 'Le Hoai Thuong', '08631738',  'LeThuong@gmail.com', '227 Nguyen Van Cu, Q5, TpHCM', 'Nu')
INSERT INTO NGUOIDUNG(MaNguoiDung, HoTen, SDT, Email, DiaChi, GioiTinh) values ('ND08', 'Phan Thi Thanh', '0938435756',  'PhanThi@gmail.com', '45/2 An Duong Vuong, Q5, TpHCM', 'Nu')
INSERT INTO NGUOIDUNG(MaNguoiDung, HoTen, SDT, Email, DiaChi, GioiTinh) values ('ND10', N'Trần Lý Thanh Duy', '0764116923', '20521249@gmail.com', 'UIT', 'Nam')
INSERT INTO NGUOIDUNG(MaNguoiDung, HoTen, SDT, Email, DiaChi, GioiTinh) values ('ND11', N'Lâm Bảo Duy', '0938435756', '20521231@gmail.com', 'UIT', 'Nam')
INSERT INTO NGUOIDUNG(MaNguoiDung, HoTen, SDT, Email, DiaChi, GioiTinh) values ('ND12', N'Nguyễn Châu Thắng', '0938435756',  '20521897@gmail.com', 'UIT', 'Nam')
INSERT INTO NGUOIDUNG(MaNguoiDung, HoTen, SDT, Email, DiaChi, GioiTinh) values ('ND13', N'Võ Tấn Tiến', '0938435756', '20522013@gmail.com', 'UIT', 'Nam')
Select *from NGUOIDUNG
delete  from TAIKHOAN
SELECT HoTen FROM NGUOIDUNG WHERE MaNguoiDung = 'ND13'
--INSERT account
INSERT INTO TAIKHOAN(MaTK, TenTK, MatKhau, MaNguoiDung, VaiTro) values ('TK01', 'ThanhDuy', 'ThanhDuy', 'ND10', 'USER')
INSERT INTO TAIKHOAN(MaTK, TenTK, MatKhau, MaNguoiDung, VaiTro) values ('TK02', 'BaoDuy', 'BaoDuy', 'ND11', 'USER')
INSERT INTO TAIKHOAN(MaTK, TenTK, MatKhau, MaNguoiDung, VaiTro) values ('TK03', 'ChauThang', 'ChauThang', 'ND12', 'USER')
INSERT INTO TAIKHOAN(MaTK, TenTK, MatKhau, MaNguoiDung, VaiTro) values ('TK04', 'TanTien', 'TanTien', 'ND13', 'USER')
SELECT MaNguoiDung FROM TAIKHOAN


Insert into TAIKHOAN values('TK00', 'admin', 'admin', 'ND10', 'ADMIN')


--Insert tac gia
INSERT INTO TACGIA(MaTacGia, TenTacGia, NgaySinh) values('TG01', 'Kim Dung', '12-09-1948')
INSERT INTO TACGIA(MaTacGia, TenTacGia, NgaySinh) values('TG02', 'Nishi Katsuzo', '11-01-1988')
INSERT INTO TACGIA(MaTacGia, TenTacGia, NgaySinh) values('TG03', 'Thich Nhat Hanh', '09-10-1973')
INSERT INTO TACGIA(MaTacGia, TenTacGia, NgaySinh) values('TG04', 'Albert Rutherford', '01-09-1999')
INSERT INTO TACGIA(MaTacGia, TenTacGia, NgaySinh) values('TG05', 'Ly The Cuong', '01-09-1998')
INSERT INTO TACGIA(MaTacGia, TenTacGia, NgaySinh) values('TG06', 'Ngo Quang Thien', '11-01-1989')
INSERT INTO TACGIA(MaTacGia, TenTacGia, NgaySinh) values('TG07', 'Le Duc Thieu', '08-18-1978')

INSERT INTO TACGIA(MaTacGia, TenTacGia, NgaySinh) values('TG010', 'Le Duc Thieu', '08-18-1978')
select TenTacGia from TACGIA where MaTacGia = Select MaTacGia From CT_TACGIA Where MaSach = 'KH01'
delete from TACGIA

--Insert book info 
INSERT INTO THONGTINSACH(MaSach, TheLoai, TenSach, SoLuong, GiaBan, NgayPhatHanh, TenAnh) values ('KH01', 'Kiem hiep', 'Than Dieu Dai Hiep', '200', '75000', '1955-09-20','Than dieu dai hiep')
INSERT INTO THONGTINSACH(MaSach, TheLoai, TenSach, SoLuong, GiaBan, NgayPhatHanh, TenAnh) values ('KH02', 'Kiem hiep', 'Anh Hung Xa Dieu', '200', '63000', '1957-05-23','Anh hung xa dieu')
INSERT INTO THONGTINSACH(MaSach, TheLoai, TenSach, SoLuong, GiaBan, NgayPhatHanh, TenAnh) values ('KH03', 'Kiem hiep', 'Y Thien Do Long Ky', '200', '68250', '1961-09-23','Y thien do long ky')
INSERT INTO THONGTINSACH(MaSach, TheLoai, TenSach, SoLuong, GiaBan, NgayPhatHanh, TenAnh) values ('KH04', 'Kiem hiep', 'Thu Kiem An THu Luc', '150', '36750', '1955-09-23','Thu kiem an cuu luc')
INSERT INTO THONGTINSACH(MaSach, TheLoai, TenSach, SoLuong, GiaBan, NgayPhatHanh, TenAnh) values ('KH05', 'Kiem hiep', 'Bich Huyet Kiem', '250', '36759', '1956-01-29','Bich huyet kiem')
INSERT INTO THONGTINSACH(MaSach, TheLoai, TenSach, SoLuong, GiaBan, NgayPhatHanh, TenAnh) values ('KH06', 'Kiem hiep', 'Tuyet Son Phi Ho', '100', '31500', '1959-05-03','Tuyet son phi ho')
INSERT INTO THONGTINSACH(MaSach, TheLoai, TenSach, SoLuong, GiaBan, NgayPhatHanh, TenAnh) values ('KH07', 'Kiem hiep', 'Phi Ho Ngoai Truyen', '100', '42000', '1962-04-09','Phi ho ngoai truyen')
INSERT INTO THONGTINSACH(MaSach, TheLoai, TenSach, SoLuong, GiaBan, NgayPhatHanh, TenAnh) values ('KH08', 'Kiem hiep', 'Bach Ma Khieu Tay Phong', '120', '36750', '1964-06-17','Bach ma khieu tay phong')
INSERT INTO THONGTINSACH(MaSach, TheLoai, TenSach, SoLuong, GiaBan, NgayPhatHanh, TenAnh) values ('KH09', 'Kiem hiep', 'Uyen Uong Dao', '170', '21000', '1962-01-20','Uyen uong dao')
INSERT INTO THONGTINSACH(MaSach, TheLoai, TenSach, SoLuong, GiaBan, NgayPhatHanh, TenAnh) values ('KH11', 'Kiem hiep', 'Lien Thanh Quyet', '200', '42000', '1964-04-08','Lien thanh quyet')
INSERT INTO THONGTINSACH(MaSach, TheLoai, TenSach, SoLuong, GiaBan, NgayPhatHanh, TenAnh) values ('KH12', 'Kiem hiep', 'Thien Long Bat Bo', '210', '57750', '1963-07-17','Thien long bat bo')
INSERT INTO THONGTINSACH(MaSach, TheLoai, TenSach, SoLuong, GiaBan, NgayPhatHanh, TenAnh) values ('KH13', 'Kiem hiep', 'Hiep Khach Hanh', '230', '31500', '1965-03-12','Hiep khach hanh')
INSERT INTO THONGTINSACH(MaSach, TheLoai, TenSach, SoLuong, GiaBan, NgayPhatHanh, TenAnh) values ('KH14', 'Kiem hiep', 'Tieu Ngao Giang Ho', '110', '42000', '1967-07-15','Tieu ngao giang ho')
INSERT INTO THONGTINSACH(MaSach, TheLoai, TenSach, SoLuong, GiaBan, NgayPhatHanh, TenAnh) values ('HT01', 'Cuoc Song', 'Lam sach tam hon',  '90', '36750', '2015-09-9', 'Lam sach tam hon')
INSERT INTO THONGTINSACH(MaSach, TheLoai, TenSach, SoLuong, GiaBan, NgayPhatHanh, TenAnh) values ('HT02', 'Cuoc Song', 'Gian', '20', '94500', '2020-02-18', 'Gian')
INSERT INTO THONGTINSACH(MaSach, TheLoai, TenSach, SoLuong, GiaBan, NgayPhatHanh, TenAnh) values ('HT03', 'Cuoc Song', 'Ren luyen tu duy phan bien', '80', '47250', '2015-03-14', 'Ren luyen tu duy phan bien')
INSERT INTO THONGTINSACH(MaSach, TheLoai, TenSach, SoLuong, GiaBan, NgayPhatHanh, TenAnh) values ('HT04', 'Cuoc Song', 'Am anh so xa hoi',   '100', '52500', '2016-10-19', 'Am anh so xa hoi')
INSERT INTO THONGTINSACH(MaSach, TheLoai, TenSach, SoLuong, GiaBan, NgayPhatHanh, TenAnh) values ('HT06', 'Cuoc Song', 'Hai huoc mot chut the gioi se khac di',  '180', '46200', '2016-08-9', 'Hai huoc mot chut ')
INSERT INTO THONGTINSACH(MaSach, TheLoai, TenSach, SoLuong, GiaBan, NgayPhatHanh, TenAnh) values ('HT07', 'Cuoc Song', 'Hay khien tuong lai biet on', '220', '23452', '2016-05-11', 'Hay khien tuong lai biet on')
INSERT INTO THONGTINSACH(MaSach, TheLoai, TenSach, SoLuong, GiaBan, NgayPhatHanh, TenAnh) values ('HT08', 'Cuoc Song', 'Nhung Dieu tot dep se den dung han', '190', '60000', '2016-11-08', 'Nhung dieu tot dep se den dung han')
INSERT INTO THONGTINSACH(MaSach, TheLoai, TenSach, SoLuong, GiaBan, NgayPhatHanh, TenAnh) values ('HT09', 'Cuoc Song', 'Cuoc song rat giong cuoc doi', '210', '42000', '2016-02-03', 'Cuoc song rat giong cuoc doi')
INSERT INTO THONGTINSACH(MaSach, TheLoai, TenSach, SoLuong, GiaBan, NgayPhatHanh, TenAnh) values ('HT11', 'Cuoc Song', 'Mong me hay yeu lay minh', '110', '52500', '2014-07-22', 'Mong me hay yeu lay minh')
INSERT INTO THONGTINSACH(MaSach, TheLoai, TenSach, SoLuong, GiaBan, NgayPhatHanh, TenAnh) values ('HT13', 'Cuoc Song', 'Ai roi cung se binh yen', '110', '42000', '2014-07-22', 'Ai roi cung se binh yen')
INSERT INTO THONGTINSACH(MaSach, TheLoai, TenSach, SoLuong, GiaBan, NgayPhatHanh, TenAnh) values ('HT12', 'Cuoc Song', 'Phuong phap ghi nho dinh cao',  '200', '225750', '2017-07-22', 'Phuong phap ghi nho dinh cao')
INSERT INTO THONGTINSACH(MaSach, TheLoai, TenSach, SoLuong, GiaBan, NgayPhatHanh, TenAnh) values ('TO01', 'On Thi THPT', 'Toan 789+',  '120', '18900', '2017-02-01', 'Phuong phap ghi nho dinh cao')
INSERT INTO THONGTINSACH(MaSach, TheLoai, TenSach, SoLuong, GiaBan, NgayPhatHanh, TenAnh) values ('TO21', 'On Thi THPT', 'On luyen van 2019', '120', '73500', '2017-04-03', 'On luyen van 2019')
INSERT INTO THONGTINSACH(MaSach, TheLoai, TenSach, SoLuong, GiaBan, NgayPhatHanh, TenAnh) values ('TO31', 'On Thi THPT', 'Toan 789+', '120', '18900', '2017-02-01', 'Phuong phap ghi nho dinh cao')
INSERT INTO THONGTINSACH(MaSach, TheLoai, TenSach, SoLuong, GiaBan, NgayPhatHanh, TenAnh) values ('TO41', 'On Thi THPT','On thi khoa hoc tu nhien', '220', '52500', '2020-05-07', 'On thi tu nhien 2022')
INSERT INTO THONGTINSACH(MaSach, TheLoai, TenSach, SoLuong, GiaBan, NgayPhatHanh, TenAnh) values ('TO51', 'On Thi THPT', 'On thi khoa hoc xa hoi', '150', '73500', '2018-05-07', 'On thi xa hoi 2022')
INSERT INTO THONGTINSACH(MaSach, TheLoai, TenSach, SoLuong, GiaBan, NgayPhatHanh, TenAnh) values ('TO61', 'On Thi THPT', 'Chinh phuc lich su', '150', '13650', '2018-08-22', 'Chinh phuc lich su')
INSERT INTO THONGTINSACH(MaSach, TheLoai, TenSach, SoLuong, GiaBan, NgayPhatHanh, TenAnh) values ('TO71', 'On Thi THPT', 'Giai ma de thi DGNL', '150', '12600', '2019-07-29', 'Giai ma de thi DGNL')

SELECT *FROM ThongTinSach

UPDATE THONGTINSACH SET SoLuong = 200,GiaBan = 1 WHERE MaSach = 'TO71'
--delete from ThongTinSach

INSERT INTO CT_TACGIA(MaSach, MaTacGia) values('KH01', 'TG01')
INSERT INTO CT_TACGIA(MaSach, MaTacGia) values('KH02', 'TG01')
INSERT INTO CT_TACGIA(MaSach, MaTacGia) values('KH03', 'TG01')
INSERT INTO CT_TACGIA(MaSach, MaTacGia) values('KH04', 'TG01')
INSERT INTO CT_TACGIA(MaSach, MaTacGia) values('KH05', 'TG01')
INSERT INTO CT_TACGIA(MaSach, MaTacGia) values('KH06', 'TG01')
INSERT INTO CT_TACGIA(MaSach, MaTacGia) values('KH07', 'TG01')
INSERT INTO CT_TACGIA(MaSach, MaTacGia) values('KH08', 'TG01')
INSERT INTO CT_TACGIA(MaSach, MaTacGia) values('KH09', 'TG01')
INSERT INTO CT_TACGIA(MaSach, MaTacGia) values('KH11', 'TG01')
INSERT INTO CT_TACGIA(MaSach, MaTacGia) values('KH12', 'TG01')
INSERT INTO CT_TACGIA(MaSach, MaTacGia) values('KH13', 'TG01')
INSERT INTO CT_TACGIA(MaSach, MaTacGia) values('KH14', 'TG01')

INSERT INTO CT_TACGIA(MaSach, MaTacGia) values('HT01', 'TG02')
INSERT INTO CT_TACGIA(MaSach, MaTacGia) values('HT02', 'TG03')
INSERT INTO CT_TACGIA(MaSach, MaTacGia) values('HT03', 'TG04')
INSERT INTO CT_TACGIA(MaSach, MaTacGia) values('HT04', 'TG05')

INSERT INTO CT_TACGIA(MaSach, MaTacGia) values('TO21', 'TG06')
INSERT INTO CT_TACGIA(MaSach, MaTacGia) values('TO31', 'TG07')
INSERT INTO CT_TACGIA(MaSach, MaTacGia) values('TO41', 'TG07')
INSERT INTO CT_TACGIA(MaSach, MaTacGia) values('TO51', 'TG07')
INSERT INTO CT_TACGIA(MaSach, MaTacGia) values('TO61', 'TG07')
select *from CT_TACGIA
select MaTacGia from CT_TACGIA where MaSach = 'KH01'
--delete from CT_TACGIA

--insert customer
INSERT INTO KHACHHANG(MaKH, HoTen, SDT_KH, Email_KH, DiaChi_KH, GioiTinh_KH, NgayDKTV) VALUES ('KHH01', 'Nguyen Van A', '08823451', 'NguyenVanA@gmail.com', '731 Tran Hung Dao, Q5, TpHCM', 'Nam', '2022-10-12')
INSERT INTO KHACHHANG(MaKH, HoTen, SDT_KH, Email_KH, DiaChi_KH, GioiTinh_KH, NgayDKTV) VALUES ('KHH02', 'Tran Ngoc Han', '280000', 'TranNgocHan@gmail.com', '23/5 Nguyen Trai, Q5, TpHCM', 'Nu', '2022-10-12')
INSERT INTO KHACHHANG(MaKH, HoTen, SDT_KH, Email_KH, DiaChi_KH, GioiTinh_KH, NgayDKTV) VALUES ('KHH03', 'Tran Ngoc Linh', '0938776266', 'TranNgocLinh@gmail.com', '45 Nguyen Canh Chan, Q1, TpHCM', 'Nu', '2022-10-12')
INSERT INTO KHACHHANG(MaKH, HoTen, SDT_KH, Email_KH, DiaChi_KH, GioiTinh_KH, NgayDKTV) VALUES ('KHH04', 'Tran Minh Long', '0917325476', 'TranMinhLong@gmail.com', '50/34 Le Dai Hanh, Q10, TpHCM', 'Nam', '2022-10-12')
INSERT INTO KHACHHANG(MaKH, HoTen, SDT_KH, Email_KH, DiaChi_KH, GioiTinh_KH, NgayDKTV) VALUES ('KHH06', 'Le Nhat Minh', '08246108', 'LeNhatMinh@gmail.com', '34 Truong Dinh, Q3, TpHCM', 'Nam',  '2022-10-12')
INSERT INTO KHACHHANG(MaKH, HoTen, SDT_KH, Email_KH, DiaChi_KH, GioiTinh_KH, NgayDKTV) VALUES ('KHH07', 'Le Hoai Thuong', '08631738', 'LeHoaiThuong@gmail.com', '227 Nguyen Van Cu, Q5, TpHCM', 'Nu',  '2022-10-12')
INSERT INTO KHACHHANG(MaKH, HoTen, SDT_KH, Email_KH, DiaChi_KH, GioiTinh_KH, NgayDKTV) VALUES ('KHH08', 'Phan Thi Thanh', '0938435756', 'PhanThiThanh@gmail.com', '45/2 An Duong Vuong, Q5, TpHCM', 'Nu',  '2022-10-12')
INSERT INTO KHACHHANG(MaKH, HoTen, SDT_KH, Email_KH, DiaChi_KH, GioiTinh_KH, NgayDKTV) VALUES ('KVIP1', 'Nguyen Van Thien', '20521952', 'Thien@gmail.com', 'UIT', 'Nam',  '2002-10-12')
INSERT INTO KHACHHANG(MaKH, HoTen, SDT_KH, Email_KH, DiaChi_KH, GioiTinh_KH, NgayDKTV) VALUES ('KVIP2', 'Nguyen Van Kien', '20521953', 'Kien@gmail.com', 'UIT', 'Nam',  '2022-11-12')
INSERT INTO KHACHHANG(MaKH, HoTen, SDT_KH, Email_KH, DiaChi_KH, GioiTinh_KH, NgayDKTV) VALUES ('KVIP3', 'Nguyen Nhu Tu', '20522098', 'Tu@gmail.com', 'UIT', 'Nam',  '2022-09-19')
SELECT *FROM KHACHHANG
Select HoTen,SDT_KH FROM KHACHHANG WHERE MaKH = @MaKH
--insert bao cao thu no
INSERT INTO BAOCAOTHUNO(MaBCTN, MaKH, Thang, NoDau, NoCuoi, SoTienNo, SoTienThanhToan) values ('BCN01', 'KHH01', '11', '58000', '58000', '58000', '58000') 
INSERT INTO BAOCAOTHUNO(MaBCTN, MaKH, Thang, NoDau, NoCuoi, SoTienNo, SoTienThanhToan) values ('BCN02', 'KHH02', '12', '400000', '400000', '400000', '400000') 
INSERT INTO BAOCAOTHUNO(MaBCTN, MaKH, Thang, NoDau, NoCuoi, SoTienNo, SoTienThanhToan) values ('BCN03', 'KHH03', '11', '100000', '100000', '100000', '100000') 
INSERT INTO BAOCAOTHUNO(MaBCTN, MaKH, Thang, NoDau, NoCuoi, SoTienNo, SoTienThanhToan) values ('BCN04', 'KHH04', '11', '125000', '400000', '525000', '525000') 
INSERT INTO BAOCAOTHUNO(MaBCTN, MaKH, Thang, NoDau, NoCuoi, SoTienNo, SoTienThanhToan) values ('BCN06', 'KHH06', '10', '300000', '300000', '300000', '300000') 
INSERT INTO BAOCAOTHUNO(MaBCTN, MaKH, Thang, NoDau, NoCuoi, SoTienNo, SoTienThanhToan) values ('BCN07', 'KHH07', '12', '212000', '212000', '212000', '212000') 
INSERT INTO BAOCAOTHUNO(MaBCTN, MaKH, Thang, NoDau, NoCuoi, SoTienNo, SoTienThanhToan) values ('BCN08', 'KHH08', '10', '200000', '200000', '200000', '200000') 
INSERT INTO BAOCAOTHUNO(MaBCTN, MaKH, Thang, NoDau, NoCuoi, SoTienNo, SoTienThanhToan) values ('BCN09', 'KVIP1', '11', '450000', '450000', '450000', '100000') 
INSERT INTO BAOCAOTHUNO(MaBCTN, MaKH, Thang, NoDau, NoCuoi, SoTienNo, SoTienThanhToan) values ('BCN10', 'KVIP1', '11', '450000', '450000', '450000', '350000') 
INSERT INTO BAOCAOTHUNO(MaBCTN, MaKH, Thang, NoDau, NoCuoi, SoTienNo, SoTienThanhToan) values ('BCN11', 'KVIP2', '12', '100000', '100000', '100000', '100000') 
select *from BAOCAOTHUNO

--insert phieuthuno
INSERT INTO PHIEUTHUNO(MaPTN, MaKH, NgayThuTien, SoTienThanhToan, GhiChu) values (1, 'KHH01', '2022-11-25', '58000', 'Khach hang than thien')
INSERT INTO PHIEUTHUNO(MaPTN, MaKH, NgayThuTien, SoTienThanhToan, GhiChu) values (2, 'KHH02', '2022-12-30', '400000', 'Ok')
INSERT INTO PHIEUTHUNO(MaPTN, MaKH, NgayThuTien, SoTienThanhToan, GhiChu) values (3, 'KHH03', '2022-11-25', '100000', 'OK')
INSERT INTO PHIEUTHUNO(MaPTN, MaKH, NgayThuTien, SoTienThanhToan, GhiChu) values (4, 'KHH04', '2022-11-25', '125000', 'Khach hang kho tinh')
INSERT INTO PHIEUTHUNO(MaPTN, MaKH, NgayThuTien, SoTienThanhToan, GhiChu) values (6, 'KHH04', '2022-11-30', '400000', 'Khach hang kho tinh')
INSERT INTO PHIEUTHUNO(MaPTN, MaKH, NgayThuTien, SoTienThanhToan, GhiChu) values (7, 'KHH06', '2022-10-20', '300000', 'Khach hang than thien')
INSERT INTO PHIEUTHUNO(MaPTN, MaKH, NgayThuTien, SoTienThanhToan, GhiChu) values (8, 'KHH08', '2022-10-22', '200000', 'Khach hang than thien')
INSERT INTO PHIEUTHUNO(MaPTN, MaKH, NgayThuTien, SoTienThanhToan, GhiChu) values (9, 'KHH07', '2022-12-28', '44500', 'Khach hang than thien')
INSERT INTO PHIEUTHUNO(MaPTN, MaKH, NgayThuTien, SoTienThanhToan, GhiChu) values (10, 'KHH07', '2022-12-30', '168000', 'Khach hang than thien')
INSERT INTO PHIEUTHUNO(MaPTN, MaKH, NgayThuTien, SoTienThanhToan, GhiChu) values (11, 'KVIP1', '2022-11-20', '100000', 'Khach hang than thien')
INSERT INTO PHIEUTHUNO(MaPTN, MaKH, NgayThuTien, SoTienThanhToan, GhiChu) values (12, 'KVIP1', '2022-11-21', '350000', 'Khach hang than thien')
INSERT INTO PHIEUTHUNO(MaPTN, MaKH, NgayThuTien, SoTienThanhToan, GhiChu) values (13, 'KVIP2', '2022-12-30', '100000', 'Khach hang than thien')
SELECT MAX(MaPTN) FROM PHIEUTHUNO
select *from PHIEUTHUNO

--insert hoa don

INSERT INTO HOADON(MaHD, MaKH, NgayHD, TongHoaDon, SoTienDaThanhToan, MaNguoiDung) values('HD01','KVIP1' ,'2022-11-16', '220500', '220500', 'ND10') --0
INSERT INTO HOADON(MaHD, MaKH, NgayHD, TongHoaDon, SoTienDaThanhToan, MaNguoiDung) values('HD02','KVIP1', '2022-11-16',  '850000', '500000', 'ND10') --350000
INSERT INTO HOADON(MaHD, MaKH, NgayHD, TongHoaDon, SoTienDaThanhToan, MaNguoiDung) values('HD03','KVIP1', '2022-11-16', '236000', '136000', 'ND10') --100000
INSERT INTO HOADON(MaHD, MaKH, NgayHD, TongHoaDon, SoTienDaThanhToan, MaNguoiDung) values('HD04','KVIP2', '2022-11-17', '105000', '105000','ND11') --0
INSERT INTO HOADON(MaHD, MaKH, NgayHD, TongHoaDon, SoTienDaThanhToan, MaNguoiDung) values('HD06','KVIP2', '2022-12-16', '231000', '131000','ND11') --100000
INSERT INTO HOADON(MaHD, MaKH, NgayHD, TongHoaDon, SoTienDaThanhToan, MaNguoiDung) values('HD09','KVIP3', '2022-12-16', '42000', '42000','ND12') --0
INSERT INTO HOADON(MaHD, MaKH, NgayHD, TongHoaDon, SoTienDaThanhToan, MaNguoiDung) values('HD11','KHH01', '2022-11-18', '42000', '42000','ND01') --0
INSERT INTO HOADON(MaHD, MaKH, NgayHD, TongHoaDon, SoTienDaThanhToan, MaNguoiDung) values('HD12','KHH01', '2022-11-18', '173000', '73000','ND01') --0
INSERT INTO HOADON(MaHD, MaKH, NgayHD, TongHoaDon, SoTienDaThanhToan, MaNguoiDung) values('HD13','KHH01', '2022-11-18', '158000', '100000','ND01') --58000
INSERT INTO HOADON(MaHD, MaKH, NgayHD, TongHoaDon, SoTienDaThanhToan, MaNguoiDung) values('HD14','KHH07', '2022-12-25', '94500', '50000','ND07') --44500
INSERT INTO HOADON(MaHD, MaKH, NgayHD, TongHoaDon, SoTienDaThanhToan, MaNguoiDung) values('HD15','KHH07', '2022-12-25', '368000', '200000','ND07') --168000
INSERT INTO HOADON(MaHD, MaKH, NgayHD, TongHoaDon, SoTienDaThanhToan, MaNguoiDung) values('HD16','KHH02', '2022-12-25', '95000', '95000','ND02') --0
INSERT INTO HOADON(MaHD, MaKH, NgayHD, TongHoaDon, SoTienDaThanhToan, MaNguoiDung) values('HD17','KHH02', '2022-12-23', '265000', '165000','ND02') --100000
INSERT INTO HOADON(MaHD, MaKH, NgayHD, TongHoaDon, SoTienDaThanhToan, MaNguoiDung) values('HD18','KHH02', '2022-12-23', '370000', '70000','ND02') --300000
INSERT INTO HOADON(MaHD, MaKH, NgayHD, TongHoaDon, SoTienDaThanhToan, MaNguoiDung) values('HD19','KHH04', '2022-12-23', '70000', '70000','ND04') --0
INSERT INTO HOADON(MaHD, MaKH, NgayHD, TongHoaDon, SoTienDaThanhToan, MaNguoiDung) values('HD20','KHH04', '2022-11-20', '225000', '100000','ND04') --125000
INSERT INTO HOADON(MaHD, MaKH, NgayHD, TongHoaDon, SoTienDaThanhToan, MaNguoiDung) values('HD21','KHH04', '2022-11-20', '850000', '450000','ND04') --400000
INSERT INTO HOADON(MaHD, MaKH, NgayHD, TongHoaDon, SoTienDaThanhToan, MaNguoiDung) values('HD22','KHH03', '2022-11-20', '236000', '136000','ND03') --100000
INSERT INTO HOADON(MaHD, MaKH, NgayHD, TongHoaDon, SoTienDaThanhToan, MaNguoiDung) values('HD23','KHH03', '2022-11-20', '105000', '105000','ND03') --0
INSERT INTO HOADON(MaHD, MaKH, NgayHD, TongHoaDon, SoTienDaThanhToan, MaNguoiDung) values('HD24','KHH08', '2022-12-21', '231000', '231000','ND08') --0
INSERT INTO HOADON(MaHD, MaKH, NgayHD, TongHoaDon, SoTienDaThanhToan, MaNguoiDung) values('HD25','KHH08', '2022-12-21', '47000', '47000','ND08') --0
INSERT INTO HOADON(MaHD, MaKH, NgayHD, TongHoaDon, SoTienDaThanhToan, MaNguoiDung) values('HD26','KHH08', '2022-10-17', '450000', '250000','ND08') --200000
INSERT INTO HOADON(MaHD, MaKH, NgayHD, TongHoaDon, SoTienDaThanhToan, MaNguoiDung) values('HD27','KHH06', '2022-10-17', '567000', '267000','ND06') --300000
INSERT INTO HOADON(MaHD, MaKH, NgayHD, TongHoaDon, SoTienDaThanhToan, MaNguoiDung) values('HD28','KHH06', '2022-10-17', '340000', '340000','ND06') --0
INSERT INTO HOADON(MaHD, MaKH, NgayHD, TongHoaDon, SoTienDaThanhToan, MaNguoiDung) values('HD29','KHH06', '2022-10-17', '72000', '72000','ND06') --0
select *from HOADON

--insert baocaotonkho
INSERT INTO BAOCAOTONKHO(MaBCTK, MaSach, TonDau, SachDaNhap, SachDaBan, TonCuoi, Thang) VALUES('BCT02', 'KH02', '200', '150', '120', '180', '12')
INSERT INTO BAOCAOTONKHO(MaBCTK, MaSach, TonDau, SachDaNhap, SachDaBan, TonCuoi, Thang) VALUES('BCT03', 'KH03', '200', '150', '100', '250', '12')
INSERT INTO BAOCAOTONKHO(MaBCTK, MaSach, TonDau, SachDaNhap, SachDaBan, TonCuoi, Thang) VALUES('BCT07', 'KH03', '200', '150', '75', '275', '12')
INSERT INTO BAOCAOTONKHO(MaBCTK, MaSach, TonDau, SachDaNhap, SachDaBan, TonCuoi, Thang) VALUES('BCT04', 'KH04', '150', '150', '120', '180', '12')
INSERT INTO BAOCAOTONKHO(MaBCTK, MaSach, TonDau, SachDaNhap, SachDaBan, TonCuoi, Thang) VALUES('BCT05', 'KH05', '250', '150', '300', '100', '12')
INSERT INTO BAOCAOTONKHO(MaBCTK, MaSach, TonDau, SachDaNhap, SachDaBan, TonCuoi, Thang) VALUES('BCT06', 'KH06', '100', '180', '100', '80', '12')
INSERT INTO BAOCAOTONKHO(MaBCTK, MaSach, TonDau, SachDaNhap, SachDaBan, TonCuoi, Thang) VALUES('BCT15', 'KH07', '100', '240', '80', '160', '12')
INSERT INTO BAOCAOTONKHO(MaBCTK, MaSach, TonDau, SachDaNhap, SachDaBan, TonCuoi, Thang) VALUES('BCT08', 'KH08', '120', '150', '100', '170', '12')
INSERT INTO BAOCAOTONKHO(MaBCTK, MaSach, TonDau, SachDaNhap, SachDaBan, TonCuoi, Thang) VALUES('BCT09', 'KH08', '170', '150', '120', '200', '12')
INSERT INTO BAOCAOTONKHO(MaBCTK, MaSach, TonDau, SachDaNhap, SachDaBan, TonCuoi, Thang) VALUES('BCT10', 'KH08', '170', '150', '140', '180', '12')
INSERT INTO BAOCAOTONKHO(MaBCTK, MaSach, TonDau, SachDaNhap, SachDaBan, TonCuoi, Thang) VALUES('BCT11', 'KH09', '170', '180', '150', '200', '12')
INSERT INTO BAOCAOTONKHO(MaBCTK, MaSach, TonDau, SachDaNhap, SachDaBan, TonCuoi, Thang) VALUES('BCT12', 'HT01', '90', '150', '80', '160', '12')
INSERT INTO BAOCAOTONKHO(MaBCTK, MaSach, TonDau, SachDaNhap, SachDaBan, TonCuoi, Thang) VALUES('BCT13', 'HT02', '20', '200', '120', '100', '12')
INSERT INTO BAOCAOTONKHO(MaBCTK, MaSach, TonDau, SachDaNhap, SachDaBan, TonCuoi, Thang) VALUES('BCT14', 'HT03', '80', '150', '120', '110', '12')
INSERT INTO BAOCAOTONKHO(MaBCTK, MaSach, TonDau, SachDaNhap, SachDaBan, TonCuoi, Thang) VALUES('BCT16', 'HT04', '100', '240', '170', '170', '12')
INSERT INTO BAOCAOTONKHO(MaBCTK, MaSach, TonDau, SachDaNhap, SachDaBan, TonCuoi, Thang) VALUES('BCT17', 'HT06', '180', '400', '230', '250', '12')
INSERT INTO BAOCAOTONKHO(MaBCTK, MaSach, TonDau, SachDaNhap, SachDaBan, TonCuoi, Thang) VALUES('BCT18', 'HT07', '220', '300', '240', '280', '12')
INSERT INTO BAOCAOTONKHO(MaBCTK, MaSach, TonDau, SachDaNhap, SachDaBan, TonCuoi, Thang) VALUES('BCT19', 'HT09', '210', '230', '300', '140', '12')
INSERT INTO BAOCAOTONKHO(MaBCTK, MaSach, TonDau, SachDaNhap, SachDaBan, TonCuoi, Thang) VALUES('BCT20', 'HT11', '110', '190', '200', '100', '12')
INSERT INTO BAOCAOTONKHO(MaBCTK, MaSach, TonDau, SachDaNhap, SachDaBan, TonCuoi, Thang) VALUES('BCT21', 'HT12', '200', '259', '159', '300', '12')
select *from BAOCAOTONKHO
SELECT SUM(SachDaNhap) FROM BAOCAOTONKHO
--insert phieunhapsach
INSERT INTO PHIEUNHAPSACH(NgayNhap, MaSach, SoLuongNhap, GiaNhap) values ('2022-10-15', 'KH01', '150', '60000')
INSERT INTO PHIEUNHAPSACH(NgayNhap, MaSach, SoLuongNhap, GiaNhap) values ('2022-10-15', 'KH02', '150', '60000')
INSERT INTO PHIEUNHAPSACH(NgayNhap, MaSach, SoLuongNhap, GiaNhap) values ('2022-10-15', 'KH03', '150', '65000')
INSERT INTO PHIEUNHAPSACH(NgayNhap, MaSach, SoLuongNhap, GiaNhap) values ('2022-10-15', 'KH04', '150', '35000')
INSERT INTO PHIEUNHAPSACH(NgayNhap, MaSach, SoLuongNhap, GiaNhap) values ('2022-10-15', 'KH05', '150', '35000')
INSERT INTO PHIEUNHAPSACH(NgayNhap, MaSach, SoLuongNhap, GiaNhap) values ('2022-10-15', 'KH06', '180', '30000')
INSERT INTO PHIEUNHAPSACH(NgayNhap, MaSach, SoLuongNhap, GiaNhap) values ('2022-10-15', 'KH07', '240', '40000')
INSERT INTO PHIEUNHAPSACH(NgayNhap, MaSach, SoLuongNhap, GiaNhap) values ('2022-10-15', 'KH08', '150', '35000')
INSERT INTO PHIEUNHAPSACH(NgayNhap, MaSach, SoLuongNhap, GiaNhap) values ('2022-11-13', 'KH09', '180', '20000')
INSERT INTO PHIEUNHAPSACH(NgayNhap, MaSach, SoLuongNhap, GiaNhap) values ('2022-11-13', 'KH11', '170', '40000')
INSERT INTO PHIEUNHAPSACH(NgayNhap, MaSach, SoLuongNhap, GiaNhap) values ('2022-11-13', 'KH12', '300', '55000')
INSERT INTO PHIEUNHAPSACH(NgayNhap, MaSach, SoLuongNhap, GiaNhap) values ('2022-11-13', 'KH13', '200', '30000')
INSERT INTO PHIEUNHAPSACH(NgayNhap, MaSach, SoLuongNhap, GiaNhap) values ('2022-11-13', 'KH14', '200', '40000')
INSERT INTO PHIEUNHAPSACH(NgayNhap, MaSach, SoLuongNhap, GiaNhap) values ('2022-11-15', 'HT01', '150', '35000')
INSERT INTO PHIEUNHAPSACH(NgayNhap, MaSach, SoLuongNhap, GiaNhap) values ('2022-11-15', 'HT02', '200', '90000')
INSERT INTO PHIEUNHAPSACH(NgayNhap, MaSach, SoLuongNhap, GiaNhap) values ('2022-11-15', 'HT03', '150', '45000')
INSERT INTO PHIEUNHAPSACH(NgayNhap, MaSach, SoLuongNhap, GiaNhap) values ('2022-11-15', 'HT04', '240', '50000')
INSERT INTO PHIEUNHAPSACH(NgayNhap, MaSach, SoLuongNhap, GiaNhap) values ('2022-12-15', 'HT06', '400', '44000')
INSERT INTO PHIEUNHAPSACH(NgayNhap, MaSach, SoLuongNhap, GiaNhap) values ('2022-12-15', 'HT07', '400', '44000')
INSERT INTO PHIEUNHAPSACH(NgayNhap, MaSach, SoLuongNhap, GiaNhap) values ('2022-12-15', 'HT08', '240', '40000')
INSERT INTO PHIEUNHAPSACH(NgayNhap, MaSach, SoLuongNhap, GiaNhap) values ('2022-12-15', 'HT09', '230', '40000')
INSERT INTO PHIEUNHAPSACH(NgayNhap, MaSach, SoLuongNhap, GiaNhap) values ('2022-12-15', 'HT11', '190', '50000')
INSERT INTO PHIEUNHAPSACH(NgayNhap, MaSach, SoLuongNhap, GiaNhap) values ('2022-12-15', 'HT12', '250', '215000')
INSERT INTO PHIEUNHAPSACH(NgayNhap, MaSach, SoLuongNhap, GiaNhap) values ('2022-12-15', 'HT13', '150', '40000')
INSERT INTO PHIEUNHAPSACH(NgayNhap, MaSach, SoLuongNhap, GiaNhap) values ('2022-12-20', 'TO01', '150', '18000') 
INSERT INTO PHIEUNHAPSACH(NgayNhap, MaSach, SoLuongNhap, GiaNhap) values ('2022-12-20', 'TO21', '150', '70000') 
INSERT INTO PHIEUNHAPSACH(NgayNhap, MaSach, SoLuongNhap, GiaNhap) values ('2022-12-20', 'TO31', '200', '18000') 
INSERT INTO PHIEUNHAPSACH(NgayNhap, MaSach, SoLuongNhap, GiaNhap) values ('2022-12-20', 'TO41', '200', '50000') 
INSERT INTO PHIEUNHAPSACH(NgayNhap, MaSach, SoLuongNhap, GiaNhap) values ('2022-12-20', 'TO51', '200', '70000') 
INSERT INTO PHIEUNHAPSACH(NgayNhap, MaSach, SoLuongNhap, GiaNhap) values ('2022-12-20', 'TO61', '200', '13000') 
INSERT INTO PHIEUNHAPSACH(NgayNhap, MaSach, SoLuongNhap, GiaNhap) values ('2022-12-20', 'TO71', '200', '12000') 
INSERT INTO PHIEUNHAPSACH(NgayNhap, MaSach, SoLuongNhap, GiaNhap) values ('2022-12-20', 'TO71', '200', '12000') 

 select * from PHIEUNHAPSACH
 UPDATE PHIEUNHAPSACH SET SoLuongNhap = '300',GiaNhap = 100 WHERE NgayNhap = '2023-06-19' and MaSach = 'TO01'
 --insert cthd
 INSERT INTO CTHD(MaHD, MaSach, SL_HD) values ('HD01', 'HT01', '6')--220500
INSERT INTO CTHD(MaHD, MaSach, SL_HD) values ('HD02', 'HT02', '9')--850500
INSERT INTO CTHD(MaHD, MaSach, SL_HD) values ('HD03', 'HT03', '5')--236250
INSERT INTO CTHD(MaHD, MaSach, SL_HD) values ('HD04', 'HT04', '2')--105000
INSERT INTO CTHD(MaHD, MaSach, SL_HD) values ('HD06', 'HT06', '5')--231000
INSERT INTO CTHD(MaHD, MaSach, SL_HD) values ('HD07', 'HT07', '2')--47000
INSERT INTO CTHD(MaHD, MaSach, SL_HD) values ('HD09', 'KH09', '2')--42000
INSERT INTO CTHD(MaHD, MaSach, SL_HD) values ('HD11', 'KH11', '1')--42000
INSERT INTO CTHD(MaHD, MaSach, SL_HD) values ('HD12', 'KH12', '3')--173000
INSERT INTO CTHD(MaHD, MaSach, SL_HD) values ('HD13', 'KH13', '5')--158000
INSERT INTO CTHD(MaHD, MaSach, SL_HD) values ('HD14', 'TO01', '5')--94500
INSERT INTO CTHD(MaHD, MaSach, SL_HD) values ('HD15', 'TO21', '5')--368000
INSERT INTO CTHD(MaHD, MaSach, SL_HD) values ('HD16', 'TO31', '5')--95000
INSERT INTO CTHD(MaHD, MaSach, SL_HD) values ('HD17', 'TO41', '5')--265000
INSERT INTO CTHD(MaHD, MaSach, SL_HD) values ('HD18', 'T051', '5')--370000
INSERT INTO CTHD(MaHD, MaSach, SL_HD) values ('HD19', 'TO61', '5')--70000
INSERT INTO CTHD(MaHD, MaSach, SL_HD) values ('HD20', 'HT01', '6')--220500
INSERT INTO CTHD(MaHD, MaSach, SL_HD) values ('HD21', 'HT02', '9')--850500
INSERT INTO CTHD(MaHD, MaSach, SL_HD) values ('HD22', 'HT03', '5')--236250
INSERT INTO CTHD(MaHD, MaSach, SL_HD) values ('HD23', 'HT04', '2')--105000
INSERT INTO CTHD(MaHD, MaSach, SL_HD) values ('HD24', 'HT06', '5')--231000
INSERT INTO CTHD(MaHD, MaSach, SL_HD) values ('HD25', 'HT07', '2')--47000
INSERT INTO CTHD(MaHD, MaSach, SL_HD) values ('HD26', 'KH01', '6')--450000
INSERT INTO CTHD(MaHD, MaSach, SL_HD) values ('HD27', 'KH02', '9')--567000
INSERT INTO CTHD(MaHD, MaSach, SL_HD) values ('HD28', 'KH03', '5')--340000
INSERT INTO CTHD(MaHD, MaSach, SL_HD) values ('HD29', 'KH04', '2')--72000
INSERT INTO CTHD(MaHD, MaSach, SL_HD) values ('HD30', 'HT07', '2')--47000
Select *from CTHD


--insert tham so
Insert into THAMSO values ('ST01', 'So luong nhap toi thieu', 150)
Insert into THAMSO values ('ST02', 'Luong ton toi thieu', 20)
Insert into THAMSO values ('ST03', 'So tien thu', 1) --1: true, 0: false, Tien thu ko vuot qua tien no
Insert into THAMSO values ('ST04', 'Tien no toi da', 1000000)
