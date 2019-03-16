use master
go
create database QUANLYHOMESTAY1
go
use QUANLYHOMESTAY1
go

create table tb1_KhachHang
(
MaKhachHang varchar (5) primary key,
TenKhachHang nvarchar (30),
DiaChi nvarchar (50),
GioiTinh nvarchar(5),
SDT char(13),
QuocTich nvarchar (20),
)

create table tb1_Phong
(
MaPhong varchar (6) primary key,
TenPhong nvarchar (30),
GiaPhong int,
TinhTrangPhong nvarchar(15),
)

create table tb1_PhieuDK
(
MaPDK varchar (5) primary key,
MaKhachHang varchar(5),
NgayDat smalldatetime,
NgayDi smalldatetime,
MaPhong varchar (6),
TienTraTruoc int,
constraint fk_tb1_PhieuDK_tb1_KhachHang foreign key(MaKhachHang) references tb1_KhachHang(MaKhachHang),
constraint fk_tb1_PhieuDK_tb1_MaPhong foreign key(MaPhong) references tb1_Phong(MaPhong)
)

insert into tb1_KhachHang values ('KH001', N'Trần Phú', N'01 Lê Duẩn phường 5 Quận 1', N'Nam', '0909007689', N'Việt Nam')
insert into tb1_KhachHang values ('KH002', N'Vector', N'15/2 Phan Xích Long phường 2 Quận Phú Nhuận', N'Nam', '0764540812', N'Anh')
insert into tb1_KhachHang values ('KH003', N'Nguyễn Mai Hoa', N'189/3 Lê Lợi phường 8 Quận 1', N'Nam', '0337783322', N'Việt Nam')

insert into tb1_Phong values ('PD001', N'Phòng Đơn', '100000', 'Trống')
insert into tb1_Phong values ('PC003', N'Phòng Đôi', '200000', 'Trống')
insert into tb1_Phong values ('PTT001', N'Phòng Tập Thể', '500000', 'Trống')

insert into tb1_PhieuDK values ('DK01', 'KH002', '03/04/2019', '06/04/2019', 'PD001', '50000')
insert into tb1_PhieuDK values ('DK02', 'KH003', '20/04/2019', '30/04/2019', 'PC003', '100000')
insert into tb1_PhieuDK values ('DK03', 'KH001', '01/02/2019', '15/02/2019', 'PTT001', '200000')


select * from tb1_PhieuDK