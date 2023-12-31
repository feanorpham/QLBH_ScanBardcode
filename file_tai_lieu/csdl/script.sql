USE [master]
GO
/****** Object:  Database [QLBH]    Script Date: 10/17/2023 7:37:20 PM ******/
CREATE DATABASE [QLBH]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLBH', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\QLBH.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLBH_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\QLBH_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [QLBH] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLBH].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLBH] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLBH] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLBH] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLBH] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLBH] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLBH] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLBH] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLBH] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLBH] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLBH] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLBH] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLBH] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLBH] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLBH] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLBH] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QLBH] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLBH] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLBH] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLBH] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLBH] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLBH] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLBH] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLBH] SET RECOVERY FULL 
GO
ALTER DATABASE [QLBH] SET  MULTI_USER 
GO
ALTER DATABASE [QLBH] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLBH] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLBH] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLBH] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLBH] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLBH] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLBH', N'ON'
GO
ALTER DATABASE [QLBH] SET QUERY_STORE = ON
GO
ALTER DATABASE [QLBH] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [QLBH]
GO
/****** Object:  Table [dbo].[tb_HoaDon]    Script Date: 10/17/2023 7:37:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_HoaDon](
	[SoHoaDon] [int] NOT NULL,
	[UserName] [char](30) NOT NULL,
	[TenHangHoa] [nvarchar](30) NULL,
	[SoLuong] [int] NOT NULL,
	[NgayTao] [datetime] NOT NULL,
	[ThanhTien] [float] NOT NULL,
	[HoVaTen] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[countSoHoaDon]    Script Date: 10/17/2023 7:37:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[countSoHoaDon]
as
select Count(DISTINCT SoHoaDon) as SoHoaDon
from tb_HoaDon
GO
/****** Object:  Table [dbo].[tb_CTHD]    Script Date: 10/17/2023 7:37:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_CTHD](
	[MaHoaDon] [int] IDENTITY(1,1) NOT NULL,
	[CharHD]  AS ('MaHD'+right('00'+CONVERT([varchar](5),[MaHoaDon]),(2))) PERSISTED NOT NULL,
	[Bardcode] [char](13) NOT NULL,
	[DonGiaSP] [float] NOT NULL,
	[SoLuong] [int] NOT NULL,
	[NgayTao] [datetime] NOT NULL,
	[CharID] [varchar](6) NOT NULL,
 CONSTRAINT [k10] PRIMARY KEY CLUSTERED 
(
	[CharHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[countMaHoaDon]    Script Date: 10/17/2023 7:37:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[countMaHoaDon]
as
select Count(DISTINCT MaHoaDon) as MaHoaDon
from tb_CTHD
GO
/****** Object:  Table [dbo].[tb_HangHoa]    Script Date: 10/17/2023 7:37:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_HangHoa](
	[Bardcode] [char](13) NOT NULL,
	[TenHangHoa] [nvarchar](30) NOT NULL,
	[DonGiaSP] [float] NOT NULL,
	[MaNhaCC] [char](7) NOT NULL,
	[NgaySX] [date] NOT NULL,
	[NgayHetHan] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Bardcode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[countHangHoa]    Script Date: 10/17/2023 7:37:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[countHangHoa]
as
select count(Bardcode) as TongSo
from tb_HangHoa
GO
/****** Object:  Table [dbo].[tb_NhaCungCap]    Script Date: 10/17/2023 7:37:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_NhaCungCap](
	[MaNhaCC] [char](7) NOT NULL,
	[TenNhaCC] [nvarchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhaCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[countNhaCC]    Script Date: 10/17/2023 7:37:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[countNhaCC]
as
select count(MaNhaCC) as TongSo
from tb_NhaCungCap
GO
/****** Object:  Table [dbo].[tb_NhapXuat]    Script Date: 10/17/2023 7:37:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_NhapXuat](
	[SoNhapXuat] [int] NOT NULL,
	[MaNhaCC] [char](7) NOT NULL,
	[NgayTao] [datetime] NOT NULL,
	[SoLuong] [int] NOT NULL,
	[ThanhTien] [float] NOT NULL,
	[Loai] [nvarchar](30) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[countNhapXuat]    Script Date: 10/17/2023 7:37:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[countNhapXuat]
as
select Count(DISTINCT SoNhapXuat) as SoNhapXuat
from tb_NhapXuat
GO
/****** Object:  Table [dbo].[tb_ChamCong]    Script Date: 10/17/2023 7:37:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_ChamCong](
	[UserName] [char](30) NOT NULL,
	[Ngay] [datetime] NOT NULL,
	[TongTien] [float] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_CTNX]    Script Date: 10/17/2023 7:37:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_CTNX](
	[SoNhapXuat] [int] NOT NULL,
	[Bardcode] [char](13) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[DonGiaSP] [float] NOT NULL,
	[NgayTao] [datetime] NOT NULL,
	[CharID] [varchar](6) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_NhanVien]    Script Date: 10/17/2023 7:37:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_NhanVien](
	[MaNV] [int] IDENTITY(1,1) NOT NULL,
	[CharID]  AS ('MaNV'+right('00'+CONVERT([varchar](5),[MaNV]),(2))) PERSISTED NOT NULL,
	[HoVaTen] [nvarchar](50) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[GioiTinh] [nvarchar](10) NOT NULL,
	[SDT] [int] NOT NULL,
	[DiaChi] [nvarchar](50) NOT NULL,
	[Email] [char](50) NOT NULL,
	[UserName] [char](30) NOT NULL,
 CONSTRAINT [k1] PRIMARY KEY CLUSTERED 
(
	[CharID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_User]    Script Date: 10/17/2023 7:37:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_User](
	[UserName] [char](30) NOT NULL,
	[PassWord] [char](30) NOT NULL,
	[PhanQuyen] [nvarchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tb_HangHoa] ([Bardcode], [TenHangHoa], [DonGiaSP], [MaNhaCC], [NgaySX], [NgayHetHan]) VALUES (N'0835049510864', N'Nước uống đóng chai Dasani', 5000, N'8935049', CAST(N'2023-03-11' AS Date), CAST(N'2023-12-20' AS Date))
INSERT [dbo].[tb_HangHoa] ([Bardcode], [TenHangHoa], [DonGiaSP], [MaNhaCC], [NgaySX], [NgayHetHan]) VALUES (N'8934680040136', N'Bánh mỳ Ổ Sữa', 8000, N'8934680', CAST(N'2023-01-05' AS Date), CAST(N'2024-05-20' AS Date))
INSERT [dbo].[tb_HangHoa] ([Bardcode], [TenHangHoa], [DonGiaSP], [MaNhaCC], [NgaySX], [NgayHetHan]) VALUES (N'8934841901641', N'Sửa hộp YoMost', 21000, N'8934841', CAST(N'2023-02-10' AS Date), CAST(N'2023-10-20' AS Date))
INSERT [dbo].[tb_HangHoa] ([Bardcode], [TenHangHoa], [DonGiaSP], [MaNhaCC], [NgaySX], [NgayHetHan]) VALUES (N'8935311110600', N'Cháo Sườn', 3500, N'8935311', CAST(N'2023-03-05' AS Date), CAST(N'2024-04-20' AS Date))
INSERT [dbo].[tb_HangHoa] ([Bardcode], [TenHangHoa], [DonGiaSP], [MaNhaCC], [NgaySX], [NgayHetHan]) VALUES (N'8936036023633', N'Bánh Chocopie', 35500, N'8936036', CAST(N'2023-03-11' AS Date), CAST(N'2024-02-11' AS Date))
GO
INSERT [dbo].[tb_NhaCungCap] ([MaNhaCC], [TenNhaCC]) VALUES (N'8934680', N'Kinh Đô')
INSERT [dbo].[tb_NhaCungCap] ([MaNhaCC], [TenNhaCC]) VALUES (N'8934841', N'FrieslandCampina Việt Nam')
INSERT [dbo].[tb_NhaCungCap] ([MaNhaCC], [TenNhaCC]) VALUES (N'8935049', N'Công ty Coca Cola Việt Nam')
INSERT [dbo].[tb_NhaCungCap] ([MaNhaCC], [TenNhaCC]) VALUES (N'8935311', N'VIFON')
INSERT [dbo].[tb_NhaCungCap] ([MaNhaCC], [TenNhaCC]) VALUES (N'8936036', N'Orion')
GO
SET IDENTITY_INSERT [dbo].[tb_NhanVien] ON 

INSERT [dbo].[tb_NhanVien] ([MaNV], [HoVaTen], [NgaySinh], [GioiTinh], [SDT], [DiaChi], [Email], [UserName]) VALUES (1, N'Phạm Hùng', CAST(N'2002-08-03' AS Date), N'Nam', 1245, N'Thái Nguyên', N'phmhung@gmail.com                                 ', N'user1                         ')
INSERT [dbo].[tb_NhanVien] ([MaNV], [HoVaTen], [NgaySinh], [GioiTinh], [SDT], [DiaChi], [Email], [UserName]) VALUES (2, N'Ngọc Tuấn', CAST(N'2002-11-03' AS Date), N'Nam', 12456, N'Thái Nguyên', N'ngoctuang@gmail.com                               ', N'user2                         ')
INSERT [dbo].[tb_NhanVien] ([MaNV], [HoVaTen], [NgaySinh], [GioiTinh], [SDT], [DiaChi], [Email], [UserName]) VALUES (3, N'Bá Tuyên', CAST(N'2002-05-03' AS Date), N'Nam', 124577, N'Thái Nguyên', N'batuyen@gmail.com                                 ', N'user3                         ')
INSERT [dbo].[tb_NhanVien] ([MaNV], [HoVaTen], [NgaySinh], [GioiTinh], [SDT], [DiaChi], [Email], [UserName]) VALUES (4, N'Tuyên Mõm', CAST(N'2000-07-03' AS Date), N'Nam', 1577, N'Thái Nguyên', N'batuyen@gmail.com                                 ', N'user4                         ')
SET IDENTITY_INSERT [dbo].[tb_NhanVien] OFF
GO
INSERT [dbo].[tb_User] ([UserName], [PassWord], [PhanQuyen]) VALUES (N'user1                         ', N'123                           ', N'Nhân viên bán hàng')
INSERT [dbo].[tb_User] ([UserName], [PassWord], [PhanQuyen]) VALUES (N'user2                         ', N'123                           ', N'Thủ kho')
INSERT [dbo].[tb_User] ([UserName], [PassWord], [PhanQuyen]) VALUES (N'user3                         ', N'123                           ', N'Người quản lý')
INSERT [dbo].[tb_User] ([UserName], [PassWord], [PhanQuyen]) VALUES (N'user4                         ', N'123                           ', N'Nhân viên bán hàng')
GO
ALTER TABLE [dbo].[tb_ChamCong]  WITH CHECK ADD  CONSTRAINT [k14] FOREIGN KEY([UserName])
REFERENCES [dbo].[tb_User] ([UserName])
GO
ALTER TABLE [dbo].[tb_ChamCong] CHECK CONSTRAINT [k14]
GO
ALTER TABLE [dbo].[tb_CTHD]  WITH CHECK ADD  CONSTRAINT [k11] FOREIGN KEY([Bardcode])
REFERENCES [dbo].[tb_HangHoa] ([Bardcode])
GO
ALTER TABLE [dbo].[tb_CTHD] CHECK CONSTRAINT [k11]
GO
ALTER TABLE [dbo].[tb_CTHD]  WITH CHECK ADD  CONSTRAINT [k12] FOREIGN KEY([CharID])
REFERENCES [dbo].[tb_NhanVien] ([CharID])
GO
ALTER TABLE [dbo].[tb_CTHD] CHECK CONSTRAINT [k12]
GO
ALTER TABLE [dbo].[tb_CTNX]  WITH CHECK ADD  CONSTRAINT [k4] FOREIGN KEY([Bardcode])
REFERENCES [dbo].[tb_HangHoa] ([Bardcode])
GO
ALTER TABLE [dbo].[tb_CTNX] CHECK CONSTRAINT [k4]
GO
ALTER TABLE [dbo].[tb_HangHoa]  WITH CHECK ADD  CONSTRAINT [k3] FOREIGN KEY([MaNhaCC])
REFERENCES [dbo].[tb_NhaCungCap] ([MaNhaCC])
GO
ALTER TABLE [dbo].[tb_HangHoa] CHECK CONSTRAINT [k3]
GO
ALTER TABLE [dbo].[tb_HoaDon]  WITH CHECK ADD  CONSTRAINT [k13] FOREIGN KEY([UserName])
REFERENCES [dbo].[tb_User] ([UserName])
GO
ALTER TABLE [dbo].[tb_HoaDon] CHECK CONSTRAINT [k13]
GO
ALTER TABLE [dbo].[tb_NhanVien]  WITH CHECK ADD  CONSTRAINT [k2] FOREIGN KEY([UserName])
REFERENCES [dbo].[tb_User] ([UserName])
GO
ALTER TABLE [dbo].[tb_NhanVien] CHECK CONSTRAINT [k2]
GO
ALTER TABLE [dbo].[tb_NhapXuat]  WITH CHECK ADD  CONSTRAINT [k5] FOREIGN KEY([MaNhaCC])
REFERENCES [dbo].[tb_NhaCungCap] ([MaNhaCC])
GO
ALTER TABLE [dbo].[tb_NhapXuat] CHECK CONSTRAINT [k5]
GO
/****** Object:  StoredProcedure [dbo].[CheckBardcode]    Script Date: 10/17/2023 7:37:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[CheckBardcode]
@Bardcode char(13)
as
select Bardcode
from tb_HangHoa
where Bardcode = @Bardcode
GO
/****** Object:  StoredProcedure [dbo].[CheckMaNhaCC]    Script Date: 10/17/2023 7:37:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[CheckMaNhaCC]
@MaNhaCC char(7)
as
select MaNhaCC
from tb_NhaCungCap
where MaNhaCC = @MaNhaCC
GO
/****** Object:  StoredProcedure [dbo].[CheckNhaCC]    Script Date: 10/17/2023 7:37:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[CheckNhaCC]
@MaNhaCC char(7),
@TenNhaCC nvarchar(30)
as
select*
from tb_NhaCungCap
where MaNhaCC = @MaNhaCC and TenNhaCC = @TenNhaCC
GO
/****** Object:  StoredProcedure [dbo].[getBardcodefrom_CTHD]    Script Date: 10/17/2023 7:37:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getBardcodefrom_CTHD]
@NgayTao datetime
as
select BardCode, DonGiaSP
from tb_CTHD
where NgayTao = @NgayTao
GO
/****** Object:  StoredProcedure [dbo].[getdataCTNX]    Script Date: 10/17/2023 7:37:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getdataCTNX]
@SoNhapXuat int
as
select SoNhapXuat, Bardcode, SoLuong, DonGiaSP, NgayTao
from tb_CTNX
where SoNhapXuat = @SoNhapXuat 
GO
/****** Object:  StoredProcedure [dbo].[getName]    Script Date: 10/17/2023 7:37:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getName]
@UserName char(30)
as
select CharID, HoVaTen, NgaySinh, GioiTinh, SDT, DiaChi, Email, UserName
from tb_NhanVien
where UserName in (select UserName from tb_User where UserName = @UserName)
GO
/****** Object:  StoredProcedure [dbo].[getSoHoaDon]    Script Date: 10/17/2023 7:37:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getSoHoaDon]
@UserName char(30)
as
select DISTINCT SoHoaDon
from tb_HoaDon
where UserName = @UserName
GO
/****** Object:  StoredProcedure [dbo].[LoginUsers]    Script Date: 10/17/2023 7:37:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[LoginUsers]
@UserName char(30),
@PassWord char(30)
as
select*
from tb_User
where UserName = @UserName and PassWord = @PassWord

GO
/****** Object:  StoredProcedure [dbo].[printBill]    Script Date: 10/17/2023 7:37:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[printBill]
@UserName char(30),
@SoHoaDon int 
as
select TenHangHoa, SoLuong, NgayTao, ThanhTien, HoVaTen
from tb_HoaDon
where SoHoaDon = @SoHoaDon and UserName = @UserName
GO
/****** Object:  StoredProcedure [dbo].[restMaHoaDon]    Script Date: 10/17/2023 7:37:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[restMaHoaDon]
@MaHoaDon int
as
DBCC CHECKIDENT ('[tb_CTHD]', RESEED, @MaHoaDon);
GO
/****** Object:  StoredProcedure [dbo].[scanBardcode]    Script Date: 10/17/2023 7:37:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[scanBardcode]
@Bardcode char(13)
as
select Bardcode, TenHangHoa, NgaySX, NgayHetHan , DonGiaSP
from tb_HangHoa
where Bardcode = @Bardcode
GO
/****** Object:  StoredProcedure [dbo].[sumBill]    Script Date: 10/17/2023 7:37:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sumBill]
@SoHoaDon int
as
select SUM(ThanhTien) as TongTien
from tb_HoaDon
where SoHoaDon = @SoHoaDon
GO
/****** Object:  StoredProcedure [dbo].[ThongKeNam]    Script Date: 10/17/2023 7:37:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ThongKeNam]
@NgayTao char(30)
as
select TenHangHoa, SUM(SoLuong) as TongSoBan, SUM(ThanhTien) as TongTien
from tb_HoaDon
where TenHangHoa = TenHangHoa and YEAR(NgayTao) = @NgayTao
group by TenHangHoa, SoLuong, ThanhTien
GO
/****** Object:  StoredProcedure [dbo].[ThongKeThang]    Script Date: 10/17/2023 7:37:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ThongKeThang]
@NgayTao char(30)
as
select TenHangHoa, SUM(SoLuong) as TongSoBan, SUM(ThanhTien) as TongTien
from tb_HoaDon
where TenHangHoa = TenHangHoa and MONTH(NgayTao) = @NgayTao
group by TenHangHoa, SoLuong, ThanhTien
GO
/****** Object:  StoredProcedure [dbo].[TongTienNV]    Script Date: 10/17/2023 7:37:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[TongTienNV]
@HoVaTen nvarchar(50)
as
select HoVaTen, SUM(TongTien) as TongTien
from tb_NhanVien, tb_ChamCong
where tb_ChamCong.UserName in (select UserName from tb_NhanVien where HoVaTen = @HoVaTen) and tb_NhanVien.UserName = tb_ChamCong.UserName
group by HoVaTen, TongTien
GO
USE [master]
GO
ALTER DATABASE [QLBH] SET  READ_WRITE 
GO
