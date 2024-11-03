﻿-- Tạo database
CREATE DATABASE QLSV;
GO

-- Sử dụng database
USE QLSV;
GO

-- Tạo bảng Khoa
CREATE TABLE Khoa (
    KhoaID VARCHAR(10) PRIMARY KEY,
    TenKhoa NVARCHAR(100) NOT NULL
);

-- Tạo bảng Lop
CREATE TABLE Lop (
    LopID VARCHAR(10) PRIMARY KEY,
    TenLop NVARCHAR(100) NOT NULL,
    SoSinhVien INT CHECK (SoSinhVien >= 0),
    KhoaID VARCHAR(10) NOT NULL,
    FOREIGN KEY (KhoaID) REFERENCES Khoa(KhoaID)
);

-- Tạo bảng MonHoc
CREATE TABLE MonHoc (
    MonHocID VARCHAR(10) PRIMARY KEY,
    TenMonHoc NVARCHAR(100) NOT NULL,
    SoTinChi INT CHECK (SoTinChi > 0),
    KhoaID VARCHAR(10) NOT NULL,
    FOREIGN KEY (KhoaID) REFERENCES Khoa(KhoaID)
);

-- Tạo bảng SinhVien
CREATE TABLE SinhVien (
    SinhVienID VARCHAR(10) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    NgaySinh DATETIME NOT NULL,
    GioiTinh NVARCHAR(10) CHECK (GioiTinh IN (N'Nam', N'Nữ')),
    SoDienThoai VARCHAR(10) UNIQUE NOT NULL,
    LopID VARCHAR(10) NOT NULL,
    KhoaID VARCHAR(10) NOT NULL,
    FOREIGN KEY (LopID) REFERENCES Lop(LopID),
    FOREIGN KEY (KhoaID) REFERENCES Khoa(KhoaID)
);

-- Tạo bảng GiangVien
CREATE TABLE GiangVien (
    GiangVienID VARCHAR(10) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    NgaySinh DATETIME NOT NULL,
    GioiTinh NVARCHAR(10) CHECK (GioiTinh IN (N'Nam', N'Nữ')),
    SoDienThoai VARCHAR(10) UNIQUE NOT NULL,
    Email NVARCHAR(100) UNIQUE NOT NULL
);

-- Tạo bảng Diem
CREATE TABLE Diem (
    DiemID INT IDENTITY(1,1) PRIMARY KEY,
    SinhVienID VARCHAR(10) NOT NULL,
    MonHocID VARCHAR(10) NOT NULL,
    DiemSoHe4 FLOAT CHECK (DiemSoHe4 BETWEEN 0 AND 4),
    DiemSoHe10 FLOAT CHECK (DiemSoHe10 BETWEEN 0 AND 10),
    DiemChu CHAR(2) CHECK (DiemChu IN ('A', 'B', 'C', 'D', 'F')),
    FOREIGN KEY (SinhVienID) REFERENCES SinhVien(SinhVienID),
    FOREIGN KEY (MonHocID) REFERENCES MonHoc(MonHocID)
);

-- Tạo bảng TaiKhoan
CREATE TABLE TaiKhoan (
    TaiKhoanID VARCHAR(10) PRIMARY KEY,
    Username VARCHAR(100) UNIQUE NOT NULL,
    Password VARCHAR(100) NOT NULL,
    Role NVARCHAR(50) CHECK (Role IN (N'Admin', N'Giảng Viên')),
    GiangVienID VARCHAR(10) NOT NULL,
    FOREIGN KEY (GiangVienID) REFERENCES GiangVien(GiangVienID)
);

-- Chèn dữ liệu vào bảng Khoa
INSERT INTO Khoa (KhoaID, TenKhoa)
VALUES
('K01', N'Khoa Công nghệ thông tin'),
('K02', N'Khoa Kinh tế'),
('K03', N'Khoa Quản trị kinh doanh'),
('K04', N'Khoa Ngôn ngữ Anh'),
('K05', N'Khoa Kỹ thuật điện tử');

-- Chèn dữ liệu vào bảng Lop
INSERT INTO Lop (LopID, TenLop, SoSinhVien, KhoaID)
VALUES
('L01', N'CNTT1', 1, 'K01'),
('L02', N'CNTT2', 1, 'K01'),
('L03', N'KT1', 1, 'K02'),
('L04', N'QTKD1', 1, 'K03'),
('L05', N'NN1', 1, 'K04');

-- Chèn dữ liệu vào bảng GiangVien
INSERT INTO GiangVien (GiangVienID, HoTen, NgaySinh, GioiTinh, SoDienThoai, Email)
VALUES
('GV01', N'Nguyen Van A', '1980-01-01', N'Nam', '0901234567', N'nguyenvana@example.com'),
('GV02', N'Tran Thi B', '1985-05-05', N'Nữ', '0902345678', N'tranthib@example.com'),
('GV03', N'Le Van C', '1979-07-15', N'Nam', '0903456789', N'levanc@example.com'),
('GV04', N'Pham Thi D', '1988-09-20', N'Nữ', '0904567890', N'phamthid@example.com'),
('GV05', N'Hoang Van E', '1982-03-10', N'Nam', '0905678901', N'hoangvane@example.com');

-- Chèn dữ liệu vào bảng MonHoc
INSERT INTO MonHoc (MonHocID, TenMonHoc, SoTinChi, KhoaID)
VALUES
('MH01', N'Lập trình C#', 3, 'K01'),
('MH02', N'Kinh tế vi mô', 2, 'K02'),
('MH03', N'Quản trị doanh nghiệp', 3, 'K03'),
('MH04', N'Tiếng Anh giao tiếp', 2, 'K04'),
('MH05', N'Mạch điện tử', 3, 'K05');

-- Chèn dữ liệu vào bảng SinhVien
INSERT INTO SinhVien (SinhVienID, HoTen, NgaySinh, GioiTinh, SoDienThoai, LopID, KhoaID)
VALUES
('SV01', N'Nguyen Van C', '2000-02-20', N'Nam', '0903456789', 'L01', 'K01'),
('SV02', N'Le Thi D', '1999-03-15', N'Nữ', '0904567890', 'L02', 'K01'),
('SV03', N'Tran Van E', '2001-05-10', N'Nam', '0905678901', 'L03', 'K02'),
('SV04', N'Pham Thi F', '2000-08-25', N'Nữ', '0906789012', 'L04', 'K03'),
('SV05', N'Hoang Van G', '1999-12-30', N'Nam', '0907890123', 'L05', 'K04');

-- Chèn dữ liệu vào bảng TaiKhoan
INSERT INTO TaiKhoan (TaiKhoanID, Username, Password, Role, GiangVienID)
VALUES
('TK01', 'GV01', '12345', N'Admin', 'GV01'),
('TK02', 'GV02', '123321', N'Giảng Viên', 'GV02'),
('TK03', 'GV03', '123321', N'Giảng Viên', 'GV03'),
('TK04', 'GV04', '123321', N'Giảng Viên', 'GV04'),
('TK05', 'GV05', '123321', N'Giảng Viên', 'GV05');

select * from Diem