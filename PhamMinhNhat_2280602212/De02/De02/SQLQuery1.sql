CREATE DATABASE QLSanpham;
GO

-- Use the QLSanpham database
USE QLSanpham;
GO

CREATE TABLE LoaiSP (
    MaLoai CHAR(2) PRIMARY KEY,
    TenLoai NVARCHAR(30)
);
GO
CREATE TABLE SanPham (
    MaSP CHAR(6) PRIMARY KEY,
    TenSP NVARCHAR(30),
    NgayNhap DATETIME,
    MaLoai CHAR(2),
    FOREIGN KEY (MaLoai) REFERENCES LoaiSP(MaLoai)
);
GO

INSERT INTO LoaiSP (MaLoai, TenLoai)
VALUES
    ('L1', N'Điện tử'),
    ('L2', N'Thực phẩm');
GO


INSERT INTO SanPham (MaSP, TenSP, NgayNhap, MaLoai)
VALUES
    ('SP001', 'Laptop Gaming', '2024-12-16', 'L1'),
    ('SP002', 'Điện thoại IP', '2024-12-15', 'L1'),
    ('SP003', 'Thịt bò', '2024-12-14', 'L2');
GO