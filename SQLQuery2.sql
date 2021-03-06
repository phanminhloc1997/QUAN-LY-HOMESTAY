use master
go
create database DemoQLDL
go
use DemoQLDL
go

create table tbl_KhachHang
(
MaKhachHang varchar (5) primary key,
TenKhachHang nvarchar (30),
DiaChi nvarchar (50),
GioiTinh nvarchar(5),
SDT char(13),
QuocTich nvarchar (20),
)

create table tbl_Phong
(
MaPhong varchar (6) primary key,
TenPhong nvarchar (30),
GiaPhong int,
TinhTrangPhong nvarchar(15),
)

create table tbl_PhieuDK
(
MaPDK varchar (5) primary key,
MaKhachHang varchar(5),
NgayDat smalldatetime,
NgayDi smalldatetime,
MaPhong varchar (6),
TienTraTruoc int,
constraint fk_tbl_PhieuDK_tb1_KhachHang foreign key(MaKhachHang) references tbl_KhachHang(MaKhachHang),
constraint fk_tbl_PhieuDK_tb1_MaPhong foreign key(MaPhong) references tbl_Phong(MaPhong)
)
insert into tbl_KhachHang(MaKhachHang,TenKhachHang,DiaChi,GioiTinh,SDT ,QuocTich) values ('KH001', N'Trần Phú', N'01 Lê Duẩn phường 5 Quận 1', N'Nam', '0909007689', N'Việt Nam')
insert into tbl_KhachHang (MaKhachHang,TenKhachHang,DiaChi,GioiTinh,SDT ,QuocTich) values ('KH002', N'Vector', N'15/2 Phan Xích Long phường 2 Quận Phú Nhuận', N'Nam', '0764540812', N'Anh')
insert into tbl_KhachHang (MaKhachHang,TenKhachHang,DiaChi,GioiTinh,SDT ,QuocTich) values ('KH003', N'Nguyễn Mai Hoa', N'189/3 Lê Lợi phường 8 Quận 1', N'Nam', '0337783322', N'Việt Nam')

insert into tbl_Phong (MaPhong,TenPhong,GiaPhong,TinhTrangPhong) values ('PD001', N'Phòng Đơn', '100000', 'Trống')
insert into tbl_Phong (MaPhong,TenPhong,GiaPhong,TinhTrangPhong) values ('PC003', N'Phòng Đôi', '200000', 'Trống')
insert into tbl_Phong (MaPhong,TenPhong,GiaPhong,TinhTrangPhong) values ('PTT001', N'Phòng Tập Thể', '500000', 'Trống')

insert into tbl_PhieuDK (MaPDK,MaKhachHang,NgayDat,NgayDi,MaPhong,TienTraTruoc) values ('DK01', 'KH002', '03/04/2019', '06/04/2019', 'PD001', '50000')
insert into tbl_PhieuDK (MaPDK,MaKhachHang,NgayDat,NgayDi,MaPhong,TienTraTruoc) values ('DK02', 'KH003', '02/04/2019', '02/08/2019', 'PC003', '100000')
insert into tbl_PhieuDK (MaPDK,MaKhachHang,NgayDat,NgayDi,MaPhong,TienTraTruoc) values ('DK03', 'KH001', '11/10/2019', '11/15/2019', 'PTT001', '200000')


select * from tbl_PhieuDK
