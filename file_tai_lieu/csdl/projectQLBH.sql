create database QLBH
use QLBH
go
create table tb_User(
UserName char(30) primary key,
PassWord char(30) not null,
PhanQuyen nvarchar(30) not null,
)
go
create table tb_NhanVien(
MaNV int identity(1,1),
CharID as 'MaNV' + right ('00' + cast(MaNV as varchar(5)),2) PERSISTED,
constraint k1 primary key (CharID),
HoVaTen nvarchar(50) not null,
NgaySinh date not null,
GioiTinh nvarchar(10) not null,
SDT int not null,
DiaChi nvarchar(50) not null,
Email char(50) not null,
UserName char(30) not null,
constraint k2 foreign key (UserName) references tb_User(UserName)
)
go
create table tb_NhaCungCap(
MaNhaCC char(7) primary key,
TenNhaCC nvarchar(30) not null,
)
go
create table tb_HangHoa(
Bardcode char(13) primary key,
TenHangHoa nvarchar(30) not null,
DonGiaSP float not null,
MaNhaCC char(7) not null,
NgaySX date not null,
NgayHetHan date not null,
constraint k3 foreign key (MaNhaCC) references tb_NhaCungCap(MaNhaCC)
)
go
create table tb_NhapXuat(
SoNhapXuat int not null,
MaNhaCC char(7) not null,
NgayTao datetime not null,
SoLuong int not null,
ThanhTien float not null,
Loai nvarchar(30) not null,
constraint k5 foreign key (MaNhaCC) references tb_NhaCungCap(MaNhaCC)
)
go
create table tb_CTNX(
SoNhapXuat int not null,
Bardcode char(13) not null,
SoLuong int not null,
DonGiaSP float not null,
NgayTao datetime not null,
CharID varchar(6) not null,
constraint k4 foreign key (Bardcode) references tb_HangHoa(Bardcode)
)
--insert into tb_CTNX values(1,'8936036023633',70,35500,'2022-03-05','MaNV02')
---select* from tb_CTNX
go
create table tb_CTHD(
MaHoaDon int identity(1,1),
CharHD as 'MaHD' + right ('00' + cast(MaHoaDon as varchar(5)),2) PERSISTED,
constraint k10 primary key (CharHD),
Bardcode char(13) not null,
DonGiaSP float not null,
SoLuong int not null,
NgayTao datetime not null,
CharID varchar(6) not null,
constraint k11 foreign key (Bardcode) references tb_HangHoa(Bardcode),
constraint k12 foreign key (CharID) references tb_NhanVien(CharID)
)
go
create table tb_HoaDon(
SoHoaDon int not null,
UserName char(30) not null,
TenHangHoa nvarchar(30),
SoLuong int not null,
NgayTao datetime not null,
ThanhTien float not null,
HoVaTen nvarchar(50) not null,
constraint k13 foreign key (UserName) references tb_User(UserName)
)
go
create table tb_ChamCong(
UserName char(30) not null,
Ngay datetime not null,
TongTien float not null,
constraint k14 foreign key (UserName) references tb_User(UserName)
)
insert into tb_User
values ('user1','123',N'Nhân viên bán hàng')
insert into tb_User
values ('user2','123',N'Thủ kho')
insert into tb_User
values ('user3','123',N'Người quản lý')
insert into tb_User
values ('user4','123',N'Nhân viên bán hàng')
---------------------------------------------------------------------------------------
insert into tb_NhanVien
values (N'Phạm Hùng','2002-08-03','Nam',1245,N'Thái Nguyên','phmhung@gmail.com','user1')
insert into tb_NhanVien
values (N'Ngọc Tuấn','2002-11-03','Nam',12456,N'Thái Nguyên','ngoctuang@gmail.com','user2')
insert into tb_NhanVien
values (N'Bá Tuyên','2002-05-03','Nam',124577,N'Thái Nguyên','batuyen@gmail.com','user3')
insert into tb_NhanVien
values (N'Tuyên Mõm','2000-07-03','Nam',1577,N'Thái Nguyên','batuyen@gmail.com','user4')
--Mã nhà cung cấp chia làm 2 phần, phần 1: 3 số từ trái qua phải là mã vùng lãnh thổ, phần 2: 4 số còn lại mã nhà sản xuất
insert into tb_NhaCungCap
values ('8935049',N'Công ty Coca Cola Việt Nam')
insert into tb_NhaCungCap
values ('8934841',N'FrieslandCampina Việt Nam')
insert into tb_NhaCungCap
values ('8934680',N'Kinh Đô')
insert into tb_NhaCungCap
values ('8935311',N'VIFON')
insert into tb_NhaCungCap
values ('8936036',N'Orion')
-- Mã hàng hóa chia ra là 3 phần, phần 1: gồm 3 số đầu tiên từ trái qua phải là mã vùng, phần 2: 4 số tiếp theo là mã nhà sảm xuất, phần 3: 5 số tiếp theo là mã hàng hóa , số còn lại là số kiểm tra
insert into tb_HangHoa
values ('0835049510864',N'Nước uống đóng chai Dasani',5000,'8935049','2023-03-11','2023-12-20')
insert into tb_HangHoa
values ('8934841901641',N'Sửa hộp YoMost',21000,'8934841','2023-02-10','2023-10-20')
insert into tb_HangHoa
values ('8936036023633',N'Bánh Chocopie',35500,'8936036','2023-03-11','2024-02-11')
insert into tb_HangHoa
values ('8934680040136',N'Bánh mỳ Ổ Sữa',8000,'8934680','2023-01-05','2024-05-20')
insert into tb_HangHoa
values ('8935311110600',N'Cháo Sườn',3500,'8935311','2023-03-05','2024-04-20')
------------------------------------------------------------------------------------------
--DBCC CHECKIDENT ('[tb_CTHD]', RESEED, 8); --rest tự động tăng :V 
go
-----------------------------------------------------------------------------------------
/* create view view01
as
select SUM(ThanhTien) as Tong
from tb_HoaDon
where NgayTao = '2023-03-02'
*/ 
--scan bardcode
create proc scanBardcode
@Bardcode char(13)
as
select Bardcode, TenHangHoa, NgaySX, NgayHetHan , DonGiaSP
from tb_HangHoa
where Bardcode = @Bardcode

exec scanBardcode '8936036023633'
----Đăng nhập 
create proc LoginUsers
@UserName char(30),
@PassWord char(30)
as
select*
from tb_User
where UserName = @UserName and PassWord = @PassWord

exec LoginUsers 'user1','123'
----add bill
create proc getName
@UserName char(30)
as
select CharID, HoVaTen, NgaySinh, GioiTinh, SDT, DiaChi, Email, UserName
from tb_NhanVien
where UserName in (select UserName from tb_User where UserName = @UserName)

exec getName 'user1'
------------------------------------
create view countSoHoaDon
as
select Count(DISTINCT SoHoaDon) as SoHoaDon
from tb_HoaDon
------------------------------
create proc printBill
@UserName char(30),
@SoHoaDon int 
as
select TenHangHoa, SoLuong, NgayTao, ThanhTien, HoVaTen
from tb_HoaDon
where SoHoaDon = @SoHoaDon and UserName = @UserName
------------------------------
create proc sumBill
@SoHoaDon int
as
select SUM(ThanhTien) as TongTien
from tb_HoaDon
where SoHoaDon = @SoHoaDon
----------------------------------
create proc getSoHoaDon
@UserName char(30)
as
select DISTINCT SoHoaDon
from tb_HoaDon
where UserName = @UserName
---------------------------------
create proc getBardcodefrom_CTHD
@NgayTao datetime
as
select BardCode, DonGiaSP
from tb_CTHD
where NgayTao = @NgayTao
--------------------------------------------------
create view countMaHoaDon
as
select Count(DISTINCT MaHoaDon) as MaHoaDon
from tb_CTHD
--------------------------
create proc restMaHoaDon
@MaHoaDon int
as
DBCC CHECKIDENT ('[tb_CTHD]', RESEED, @MaHoaDon);
----------------------Hàng hóa
create proc CheckNhaCC
@MaNhaCC char(7),
@TenNhaCC nvarchar(30)
as
select*
from tb_NhaCungCap
where MaNhaCC = @MaNhaCC and TenNhaCC = @TenNhaCC
----------------------------
create proc CheckBardcode
@Bardcode char(13)
as
select Bardcode
from tb_HangHoa
where Bardcode = @Bardcode
----------------------------
create proc CheckMaNhaCC
@MaNhaCC char(7)
as
select MaNhaCC
from tb_NhaCungCap
where MaNhaCC = @MaNhaCC
-------------------------
create view countHangHoa
as
select count(Bardcode) as TongSo
from tb_HangHoa
create view countNhaCC
as
select count(MaNhaCC) as TongSo
from tb_NhaCungCap
---------------------------Nhập xuất
create view countNhapXuat
as
select Count(DISTINCT SoNhapXuat) as SoNhapXuat
from tb_NhapXuat
select* from countNhapXuat
---------------------------
create proc getdataCTNX
@SoNhapXuat int
as
select SoNhapXuat, Bardcode, SoLuong, DonGiaSP, NgayTao
from tb_CTNX
where SoNhapXuat = @SoNhapXuat 

drop proc getdataCTNX
----------------------------
create proc ThongKeThang
@NgayTao char(30)
as
select TenHangHoa, SUM(SoLuong) as TongSoBan, SUM(ThanhTien) as TongTien
from tb_HoaDon
where TenHangHoa = TenHangHoa and MONTH(NgayTao) = @NgayTao
group by TenHangHoa, SoLuong, ThanhTien

create proc ThongKeNam
@NgayTao char(30)
as
select TenHangHoa, SUM(SoLuong) as TongSoBan, SUM(ThanhTien) as TongTien
from tb_HoaDon
where TenHangHoa = TenHangHoa and YEAR(NgayTao) = @NgayTao
group by TenHangHoa, SoLuong, ThanhTien

exec ThongKeThang '4'

select*
from tb_HoaDon

create proc ThongKeNam
@NgayTao char(30)
as
select HoVaTen, SUM(ThanhTien) as TongTien
from tb_HoaDon
where HoVaTen = N'Phạm Hùng'
group by HoVaTen, ThanhTien

select* from tb_ChamCong

create proc TongTienNV
@HoVaTen nvarchar(50)
as
select HoVaTen, SUM(TongTien) as TongTien
from tb_NhanVien, tb_ChamCong
where tb_ChamCong.UserName in (select UserName from tb_NhanVien where HoVaTen = @HoVaTen) and tb_NhanVien.UserName = tb_ChamCong.UserName
group by HoVaTen, TongTien

exec TongTienNV N'Phạm Hùng'