USE [master]
GO
--DROP DATABASE
DROP DATABASE QL_CAFE_BALCONY
GO
/****** Object:  Database [QL_CAFE_BALCONY]    Script Date: 12/10/2018 3:39:32 AM ******/
CREATE DATABASE [QL_CAFE_BALCONY]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QL_CAFE_BALCONY', FILENAME = N'D:\SQL Server Data\MSSQL14.MSSQLSERVER\MSSQL\DATA\QL_CAFE_BALCONY.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QL_CAFE_BALCONY_log', FILENAME = N'D:\SQL Server Data\MSSQL14.MSSQLSERVER\MSSQL\DATA\QL_CAFE_BALCONY_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [QL_CAFE_BALCONY] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QL_CAFE_BALCONY].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QL_CAFE_BALCONY] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QL_CAFE_BALCONY] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QL_CAFE_BALCONY] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QL_CAFE_BALCONY] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QL_CAFE_BALCONY] SET ARITHABORT OFF 
GO
ALTER DATABASE [QL_CAFE_BALCONY] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QL_CAFE_BALCONY] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QL_CAFE_BALCONY] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QL_CAFE_BALCONY] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QL_CAFE_BALCONY] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QL_CAFE_BALCONY] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QL_CAFE_BALCONY] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QL_CAFE_BALCONY] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QL_CAFE_BALCONY] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QL_CAFE_BALCONY] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QL_CAFE_BALCONY] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QL_CAFE_BALCONY] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QL_CAFE_BALCONY] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QL_CAFE_BALCONY] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QL_CAFE_BALCONY] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QL_CAFE_BALCONY] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QL_CAFE_BALCONY] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QL_CAFE_BALCONY] SET RECOVERY FULL 
GO
ALTER DATABASE [QL_CAFE_BALCONY] SET  MULTI_USER 
GO
ALTER DATABASE [QL_CAFE_BALCONY] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QL_CAFE_BALCONY] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QL_CAFE_BALCONY] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QL_CAFE_BALCONY] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QL_CAFE_BALCONY] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QL_CAFE_BALCONY', N'ON'
GO
ALTER DATABASE [QL_CAFE_BALCONY] SET QUERY_STORE = OFF
GO
USE [QL_CAFE_BALCONY]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [QL_CAFE_BALCONY]
GO
/****** Object:  UserDefinedFunction [dbo].[NextHoaDonIndentity]    Script Date: 12/10/2018 3:39:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[NextHoaDonIndentity]()--Thiết lập thuộc tính tự tăng của mã hóa đơn
RETURNS VARCHAR(10)
AS
BEGIN
	DECLARE @lastvalue VARCHAR(10)
	SET @lastvalue = (SELECT MAX(MaphieuBH) FROM dbo.PHIEUBH)
	IF (@lastvalue IS NULL) SET @lastvalue = 'HD0000000'
	DECLARE @i INT
	SET @i = RIGHT(@lastvalue,7) + 1
	RETURN 'HD' + RIGHT('000000' + CONVERT(VARCHAR(10),@i),7);
END
GO
/****** Object:  Table [dbo].[CHITIETCOMBO]    Script Date: 12/10/2018 3:39:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETCOMBO](
	[Macombo] [varchar](10) NOT NULL,
	[ListDoUong] [varchar](10) NOT NULL,
	[SoLuong] [int] NOT NULL,
 CONSTRAINT [PK_CHITIETCOMBO] PRIMARY KEY CLUSTERED 
(
	[Macombo] ASC,
	[ListDoUong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CHITIETPHIEUBH]    Script Date: 12/10/2018 3:39:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETPHIEUBH](
	[MaphieuBH] [varchar](10) NOT NULL,
	[MaThanhPhan] [varchar](10) NOT NULL,
	[TenThanhphan] [nvarchar](50) NULL,
	[Soluong] [int] NULL,
	[Dongia] [money] NULL,
	[Ghichu] [nvarchar](50) NULL,
 CONSTRAINT [PK_CHITIETPHIEUBH_1] PRIMARY KEY CLUSTERED 
(
	[MaphieuBH] ASC,
	[MaThanhPhan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[COMBO]    Script Date: 12/10/2018 3:39:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[COMBO](
	[MaCombo] [varchar](10) NOT NULL,
	[TenCombo] [nvarchar](50) NOT NULL,
	[DongiaCombo] [money] NULL,
 CONSTRAINT [PK_COMBO] PRIMARY KEY CLUSTERED 
(
	[MaCombo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DOTANGKEM]    Script Date: 12/10/2018 3:39:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DOTANGKEM](
	[MaDoTangKem] [varchar](10) NOT NULL,
	[TenDoTangKem] [nvarchar](50) NULL,
 CONSTRAINT [PK_DoTangKem] PRIMARY KEY CLUSTERED 
(
	[MaDoTangKem] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DOUONG]    Script Date: 12/10/2018 3:39:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DOUONG](
	[MaDoUong] [varchar](10) NOT NULL,
	[TenDoUong] [nvarchar](50) NOT NULL,
	[LoaiDoUong] [varchar](10) NOT NULL,
	[DoTangKem] [varchar](10) NULL,
	[DonGiaDoUong] [money] NOT NULL,
 CONSTRAINT [PK_DOUONG] PRIMARY KEY CLUSTERED 
(
	[MaDoUong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOAIBH]    Script Date: 12/10/2018 3:39:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAIBH](
	[MaLoaiBH] [varchar](10) NOT NULL,
	[TenLoaiBH] [nvarchar](50) NOT NULL,
	[Sodouongtoida] [int] NULL,
 CONSTRAINT [PK_LOAIBH] PRIMARY KEY CLUSTERED 
(
	[MaLoaiBH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOAIDOUONG]    Script Date: 12/10/2018 3:39:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAIDOUONG](
	[MaLoai] [varchar](10) NOT NULL,
	[TenLoai] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_LoaiDoUong] PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIEUBH]    Script Date: 12/10/2018 3:39:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUBH](
	[MaphieuBH] [varchar](10) NOT NULL,
	[NgayBH] [datetime] NOT NULL,
	[LoaiBH] [varchar](10) NOT NULL,
	[TenKH] [nvarchar](50) NULL,
	[SoDienthoai] [varchar](20) NULL,
	[TongTien] [money] NULL,
	[TrangThai] [bit] NULL,
 CONSTRAINT [PK_PHIEUBH] PRIMARY KEY CLUSTERED 
(
	[MaphieuBH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TAIKHOAN]    Script Date: 12/10/2018 3:39:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TAIKHOAN](
	[Username] [varchar](50) NULL,
	[Password] [varchar](50) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[CHITIETCOMBO] ([Macombo], [ListDoUong], [SoLuong]) VALUES (N'CB1', N'COCA', 1)
INSERT [dbo].[CHITIETCOMBO] ([Macombo], [ListDoUong], [SoLuong]) VALUES (N'CB1', N'EPTAO', 2)
INSERT [dbo].[CHITIETCOMBO] ([Macombo], [ListDoUong], [SoLuong]) VALUES (N'CB1', N'NHO', 2)
INSERT [dbo].[CHITIETCOMBO] ([Macombo], [ListDoUong], [SoLuong]) VALUES (N'CB2', N'COCA', 1)
INSERT [dbo].[CHITIETCOMBO] ([Macombo], [ListDoUong], [SoLuong]) VALUES (N'CB2', N'EPTAO', 1)
INSERT [dbo].[CHITIETCOMBO] ([Macombo], [ListDoUong], [SoLuong]) VALUES (N'CB2', N'NHO', 4)
INSERT [dbo].[CHITIETCOMBO] ([Macombo], [ListDoUong], [SoLuong]) VALUES (N'GAS1', N'COCA', 1)
INSERT [dbo].[CHITIETPHIEUBH] ([MaphieuBH], [MaThanhPhan], [TenThanhphan], [Soluong], [Dongia], [Ghichu]) VALUES (N'HD0000001', N'CB2', N'COMBO 2', 2, 200000.0000, N'')
INSERT [dbo].[CHITIETPHIEUBH] ([MaphieuBH], [MaThanhPhan], [TenThanhphan], [Soluong], [Dongia], [Ghichu]) VALUES (N'HD0000001', N'COCA', N'COCA COLA', 3, 210000.0000, N'')
INSERT [dbo].[CHITIETPHIEUBH] ([MaphieuBH], [MaThanhPhan], [TenThanhphan], [Soluong], [Dongia], [Ghichu]) VALUES (N'HD0000002', N'CB2', N'COMBO 2', 3, 300000.0000, N'')
INSERT [dbo].[CHITIETPHIEUBH] ([MaphieuBH], [MaThanhPhan], [TenThanhphan], [Soluong], [Dongia], [Ghichu]) VALUES (N'HD0000002', N'COCA', N'COCA COLA', 1, 70000.0000, N'')
INSERT [dbo].[CHITIETPHIEUBH] ([MaphieuBH], [MaThanhPhan], [TenThanhphan], [Soluong], [Dongia], [Ghichu]) VALUES (N'HD0000002', N'HEINEKEN', N'BIA HEINEKEN', 1, 250000.0000, N'')
INSERT [dbo].[COMBO] ([MaCombo], [TenCombo], [DongiaCombo]) VALUES (N'CB1', N'COMBO 1', 30000.0000)
INSERT [dbo].[COMBO] ([MaCombo], [TenCombo], [DongiaCombo]) VALUES (N'CB2', N'COMBO 2', 100000.0000)
INSERT [dbo].[COMBO] ([MaCombo], [TenCombo], [DongiaCombo]) VALUES (N'GAS1', N'NƯỚC CÓ GAS', 100000.0000)
INSERT [dbo].[DOTANGKEM] ([MaDoTangKem], [TenDoTangKem]) VALUES (N'0', NULL)
INSERT [dbo].[DOTANGKEM] ([MaDoTangKem], [TenDoTangKem]) VALUES (N'KEM', N'KEM')
INSERT [dbo].[DOTANGKEM] ([MaDoTangKem], [TenDoTangKem]) VALUES (N'KEO', N'KẸO')
INSERT [dbo].[DOTANGKEM] ([MaDoTangKem], [TenDoTangKem]) VALUES (N'KTC', N'KHOAI TÂY CHIÊN')
INSERT [dbo].[DOTANGKEM] ([MaDoTangKem], [TenDoTangKem]) VALUES (N'SCL', N'BÁNH CHOCOLATE')
INSERT [dbo].[DOUONG] ([MaDoUong], [TenDoUong], [LoaiDoUong], [DoTangKem], [DonGiaDoUong]) VALUES (N'    ', N'asdf', N'COKE', N'KEO', 231.0000)
INSERT [dbo].[DOUONG] ([MaDoUong], [TenDoUong], [LoaiDoUong], [DoTangKem], [DonGiaDoUong]) VALUES (N'CAM', N'NƯỚC CAM', N'COKE', N'SCL', 30000.0000)
INSERT [dbo].[DOUONG] ([MaDoUong], [TenDoUong], [LoaiDoUong], [DoTangKem], [DonGiaDoUong]) VALUES (N'COCA', N'COCA COLA', N'COKE', N'KEO', 70000.0000)
INSERT [dbo].[DOUONG] ([MaDoUong], [TenDoUong], [LoaiDoUong], [DoTangKem], [DonGiaDoUong]) VALUES (N'EPTAO', N'NƯỚC ÉP TÁO', N'JUICE', N'SCL', 100000.0000)
INSERT [dbo].[DOUONG] ([MaDoUong], [TenDoUong], [LoaiDoUong], [DoTangKem], [DonGiaDoUong]) VALUES (N'HEINEKEN', N'BIA HEINEKEN', N'BEER', N'0', 250000.0000)
INSERT [dbo].[DOUONG] ([MaDoUong], [TenDoUong], [LoaiDoUong], [DoTangKem], [DonGiaDoUong]) VALUES (N'NHO', N'NƯỚC ÉP NHO', N'JUICE', N'KEO', 50000.0000)
INSERT [dbo].[LOAIBH] ([MaLoaiBH], [TenLoaiBH], [Sodouongtoida]) VALUES (N'MANG', N'MANG VỀ', NULL)
INSERT [dbo].[LOAIBH] ([MaLoaiBH], [TenLoaiBH], [Sodouongtoida]) VALUES (N'SHIP', N'SHIP VỀ', 6)
INSERT [dbo].[LOAIBH] ([MaLoaiBH], [TenLoaiBH], [Sodouongtoida]) VALUES (N'TAIQ', N'TẠI QUÁN', NULL)
INSERT [dbo].[LOAIDOUONG] ([MaLoai], [TenLoai]) VALUES (N'BEER', N'RƯỢU BIA')
INSERT [dbo].[LOAIDOUONG] ([MaLoai], [TenLoai]) VALUES (N'COKE', N'GIẢI KHÁT CÓ GAS')
INSERT [dbo].[LOAIDOUONG] ([MaLoai], [TenLoai]) VALUES (N'JUICE', N'HOA QUẢ')
INSERT [dbo].[PHIEUBH] ([MaphieuBH], [NgayBH], [LoaiBH], [TenKH], [SoDienthoai], [TongTien], [TrangThai]) VALUES (N'HD0000001', CAST(N'2017-11-19T18:24:25.000' AS DateTime), N'MANG', N'Nguyễn Minh Thiện', N'01248334333', 410000.0000, 1)
INSERT [dbo].[PHIEUBH] ([MaphieuBH], [NgayBH], [LoaiBH], [TenKH], [SoDienthoai], [TongTien], [TrangThai]) VALUES (N'HD0000002', CAST(N'2017-11-20T00:22:38.000' AS DateTime), N'TAIQ', N'Nguyễn Hoàng Duy', N'0123456789', 620000.0000, 1)
INSERT [dbo].[PHIEUBH] ([MaphieuBH], [NgayBH], [LoaiBH], [TenKH], [SoDienthoai], [TongTien], [TrangThai]) VALUES (N'HD0000003', CAST(N'2017-11-20T10:09:58.000' AS DateTime), N'MANG', N'DASD', N'123', 0.0000, 1)
INSERT [dbo].[TAIKHOAN] ([Username], [Password]) VALUES (N'admin', N'admin')
ALTER TABLE [dbo].[CHITIETCOMBO]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETCOMBO_COMBO] FOREIGN KEY([Macombo])
REFERENCES [dbo].[COMBO] ([MaCombo])
GO
ALTER TABLE [dbo].[CHITIETCOMBO] CHECK CONSTRAINT [FK_CHITIETCOMBO_COMBO]
GO
ALTER TABLE [dbo].[CHITIETCOMBO]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETCOMBO_DOUONG] FOREIGN KEY([ListDoUong])
REFERENCES [dbo].[DOUONG] ([MaDoUong])
GO
ALTER TABLE [dbo].[CHITIETCOMBO] CHECK CONSTRAINT [FK_CHITIETCOMBO_DOUONG]
GO
ALTER TABLE [dbo].[CHITIETPHIEUBH]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETPHIEUBH_PHIEUBH] FOREIGN KEY([MaphieuBH])
REFERENCES [dbo].[PHIEUBH] ([MaphieuBH])
GO
ALTER TABLE [dbo].[CHITIETPHIEUBH] CHECK CONSTRAINT [FK_CHITIETPHIEUBH_PHIEUBH]
GO
ALTER TABLE [dbo].[DOUONG]  WITH CHECK ADD  CONSTRAINT [FK_DOUONG_DOTANGKEM] FOREIGN KEY([DoTangKem])
REFERENCES [dbo].[DOTANGKEM] ([MaDoTangKem])
GO
ALTER TABLE [dbo].[DOUONG] CHECK CONSTRAINT [FK_DOUONG_DOTANGKEM]
GO
ALTER TABLE [dbo].[DOUONG]  WITH CHECK ADD  CONSTRAINT [FK_DOUONG_LOAIDOUONG] FOREIGN KEY([LoaiDoUong])
REFERENCES [dbo].[LOAIDOUONG] ([MaLoai])
GO
ALTER TABLE [dbo].[DOUONG] CHECK CONSTRAINT [FK_DOUONG_LOAIDOUONG]
GO
ALTER TABLE [dbo].[PHIEUBH]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUBH_LOAIBH] FOREIGN KEY([LoaiBH])
REFERENCES [dbo].[LOAIBH] ([MaLoaiBH])
GO
ALTER TABLE [dbo].[PHIEUBH] CHECK CONSTRAINT [FK_PHIEUBH_LOAIBH]
GO
/****** Object:  StoredProcedure [dbo].[DataChitietComboTheoID]    Script Date: 12/10/2018 3:39:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DataChitietComboTheoID](@macombo VARCHAR(10))
AS
BEGIN
    SELECT * FROM dbo.CHITIETCOMBO WHERE Macombo=@macombo
END
GO
/****** Object:  StoredProcedure [dbo].[deleteChitietCombo]    Script Date: 12/10/2018 3:39:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[deleteChitietCombo](@macombo VARCHAR(10), @madouong VARCHAR(10))
AS
BEGIN
    DELETE FROM dbo.CHITIETCOMBO WHERE Macombo=@macombo AND ListDoUong=@madouong
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteChitietcomboByIDCombo]    Script Date: 12/10/2018 3:39:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DeleteChitietcomboByIDCombo](@macombo VARCHAR(10))
AS
BEGIN
    DELETE FROM dbo.CHITIETCOMBO WHERE Macombo=@macombo
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteChitietcomboByIDdouong]    Script Date: 12/10/2018 3:39:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DeleteChitietcomboByIDdouong](@madouong VARCHAR(10))
AS
BEGIN
    DELETE FROM dbo.CHITIETCOMBO WHERE ListDoUong=@madouong
END
GO
/****** Object:  StoredProcedure [dbo].[deleteComboByID]    Script Date: 12/10/2018 3:39:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[deleteComboByID](@macombo VARCHAR(10))
AS
BEGIN
    DELETE FROM dbo.COMBO WHERE MaCombo=@macombo
END
GO
/****** Object:  StoredProcedure [dbo].[deleteCTPhieuBHByID]    Script Date: 12/10/2018 3:39:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[deleteCTPhieuBHByID](@maphieu VARCHAR(10), @mathanhphan VARCHAR(10))
AS
BEGIN
	DECLARE @dongia MONEY
	SELECT @dongia= Dongia FROM dbo.CHITIETPHIEUBH WHERE MaphieuBH=@maphieu AND MaThanhPhan=@mathanhphan
	UPDATE dbo.PHIEUBH
	SET TongTien=TongTien-@dongia
	WHERE MaphieuBH=@maphieu
    DELETE FROM	dbo.CHITIETPHIEUBH WHERE MaphieuBH=@maphieu AND MaThanhPhan=@mathanhphan
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteDoUong]    Script Date: 12/10/2018 3:39:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DeleteDoUong](@madouong VARCHAR(10))
AS
BEGIN
    DELETE FROM dbo.DOUONG WHERE MaDoUong=@madouong
END
GO
/****** Object:  StoredProcedure [dbo].[deletePhieuBH]    Script Date: 12/10/2018 3:39:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[deletePhieuBH](@maphieu VARCHAR(10))
AS
BEGIN
    DELETE FROM dbo.PHIEUBH WHERE MaphieuBH=@maphieu
	DELETE FROM dbo.CHITIETPHIEUBH WHERE MaphieuBH=@maphieu
END
GO
/****** Object:  StoredProcedure [dbo].[HienthiCombo]    Script Date: 12/10/2018 3:39:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[HienthiCombo]
AS
BEGIN
    SELECT * FROM dbo.COMBO
END
GO
/****** Object:  StoredProcedure [dbo].[HienthiDouong]    Script Date: 12/10/2018 3:39:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[HienthiDouong]
AS
BEGIN
    SELECT * FROM dbo.DOUONG
END
GO
/****** Object:  StoredProcedure [dbo].[HienthiDouongkhongbia]    Script Date: 12/10/2018 3:39:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[HienthiDouongkhongbia]
AS
BEGIN
    SELECT * FROM dbo.DOUONG WHERE LoaiDoUong!='BEER'
END

GO
/****** Object:  StoredProcedure [dbo].[HienthiMenuCombo]    Script Date: 12/10/2018 3:39:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[HienthiMenuCombo]
AS
BEGIN
    SELECT TenCombo 'Tên Combo', ListDoUong 'Đồ uống', DongiaCombo 'Đơn giá'
	FROM dbo.COMBO, dbo.CHITIETCOMBO
	WHERE CHITIETCOMBO.Macombo=COMBO.MaCombo
END

GO
/****** Object:  StoredProcedure [dbo].[HienthiMenuDouong]    Script Date: 12/10/2018 3:39:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[HienthiMenuDouong]
AS
BEGIN
    SELECT TenDoUong 'Tên đồ uống', DonGiaDoUong 'Đơn giá', TenDoTangKem 'Đồ tặng kèm', TenLoai 'Loại đồ uống'
	FROM dbo.DOUONG, dbo.LOAIDOUONG, dbo.DOTANGKEM
	WHERE LoaiDoUong=MaLoai AND	DoTangKem=MaDoTangKem
END
GO
/****** Object:  StoredProcedure [dbo].[HienthiMenuListDouongByIDCombo]    Script Date: 12/10/2018 3:39:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[HienthiMenuListDouongByIDCombo](@idcombo VARCHAR(10))
AS
BEGIN
    SELECT ListDoUong 'Tên đồ uống', SoLuong 'Số lượng'
	FROM dbo.CHITIETCOMBO
	WHERE Macombo=@idcombo
END
GO
/****** Object:  StoredProcedure [dbo].[insertChitietCombo]    Script Date: 12/10/2018 3:39:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[insertChitietCombo](@macombo VARCHAR(10), @listdouong VARCHAR(10), @soluong INT)
AS
BEGIN
    INSERT INTO dbo.CHITIETCOMBO
    (
        Macombo,
        ListDoUong,
		SoLuong
    )
    VALUES
    (   @macombo, -- Macombo - varchar(10)
        @listdouong,  -- ListDoUong - varchar(10)
		@soluong
        )
END
GO
/****** Object:  StoredProcedure [dbo].[InsertChitietPhieuBH]    Script Date: 12/10/2018 3:39:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[InsertChitietPhieuBH](@maphieu VARCHAR(10), @mathanhphan VARCHAR(10), @tenthanhphan NVARCHAR(50), @soluong INT, @dongia MONEY, @ghichu NVARCHAR(50))
AS
BEGIN
    INSERT INTO dbo.CHITIETPHIEUBH
    (
        MaphieuBH,
        MaThanhPhan,
		TenThanhphan,
        Soluong,
		Dongia,
        Ghichu
    )
    VALUES
    (   @maphieu,   -- MaphieuBH - varchar(10)
        @mathanhphan,
		@tenthanhphan,
        @soluong,    -- Soluong - int
		@dongia,
        @ghichu   -- Ghichu - nvarchar(50)
        )
	UPDATE dbo.PHIEUBH
	SET TongTien=TongTien+@dongia
	WHERE MaphieuBH=@maphieu
END
GO
/****** Object:  StoredProcedure [dbo].[InsertCombo]    Script Date: 12/10/2018 3:39:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[InsertCombo](@macombo VARCHAR(10), @tencombo NVARCHAR(50), @dongia MONEY)
AS
BEGIN
    INSERT INTO dbo.COMBO
    (
        MaCombo,
        TenCombo,
        DongiaCombo
    )
    VALUES
    (   @macombo,  -- MaCombo - varchar(10)
        @tencombo, -- TenCombo - nvarchar(50)
        @dongia -- DongiaCombo - money
        )
END
GO
/****** Object:  StoredProcedure [dbo].[InsertDoUong]    Script Date: 12/10/2018 3:39:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[InsertDoUong](@madouong VARCHAR(10), @tendouong NVARCHAR(50), @loaidouong VARCHAR(10), @dotangkem VARCHAR(10), @dongia MONEY)
AS
BEGIN
	INSERT INTO dbo.DOUONG
	(
	    MaDoUong,
	    TenDoUong,
	    LoaiDoUong,
	    DoTangKem,
	    DonGiaDoUong
	)
	VALUES
	(   @madouong,  -- MaDoUong - varchar(10)
	    @tendouong, -- TenDoUong - nvarchar(50)
	    @loaidouong,  -- LoaiDoUong - varchar(10)
	    @dotangkem,  -- DoTangKem - varchar(10)
	    @dongia -- DonGiaDoUong - money
	    )
END
GO
/****** Object:  StoredProcedure [dbo].[insertPhieuBanHang]    Script Date: 12/10/2018 3:39:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[insertPhieuBanHang](@ngaybh DATETIME, @loaibh VARCHAR(10), @tenkh NVARCHAR(50), @sdt VARCHAR(20))
AS
BEGIN
    INSERT INTO dbo.PHIEUBH
    (
        MaphieuBH,
        NgayBH,
        LoaiBH,
        TenKH,
        SoDienthoai,
		TongTien,
		TrangThai
    )
    VALUES
    (   dbo.NextHoaDonIndentity(),        -- MaphieuBH - varchar(10)
        @ngaybh, -- NgayBH - datetime
        @loaibh,        -- LoaiBH - varchar(10)
        @tenkh,       -- TenKH - nvarchar(50)
        @sdt,         -- SoDienthoai - varchar(20)
		0,
		0
        )
END
GO
/****** Object:  StoredProcedure [dbo].[LayDongiaComboByID]    Script Date: 12/10/2018 3:39:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LayDongiaComboByID](@macombo VARCHAR(10))
AS
BEGIN
    SELECT DongiaCombo FROM dbo.COMBO WHERE MaCombo=@macombo
END
GO
/****** Object:  StoredProcedure [dbo].[LayDongiaDoUongByID]    Script Date: 12/10/2018 3:39:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LayDongiaDoUongByID](@madouong VARCHAR(10))
AS
BEGIN
    SELECT DonGiaDoUong FROM dbo.DOUONG WHERE MaDoUong=@madouong
END
GO
/****** Object:  StoredProcedure [dbo].[LayMaPhieuByNgayBH]    Script Date: 12/10/2018 3:39:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LayMaPhieuByNgayBH](@ngaybh DATETIME)
AS
BEGIN
    SELECT MaphieuBH FROM dbo.PHIEUBH WHERE NgayBH=@ngaybh
END
GO
/****** Object:  StoredProcedure [dbo].[LayTrangThaiPhieuBH]    Script Date: 12/10/2018 3:39:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LayTrangThaiPhieuBH](@maphieu VARCHAR(10))
AS
BEGIN
    SELECT TrangThai FROM dbo.PHIEUBH WHERE MaphieuBH=@maphieu
END
--
EXEC dbo.LayTrangThaiPhieuBH @maphieu = 'HD0000001' -- char(10)

---update phieubh
GO
/****** Object:  StoredProcedure [dbo].[updateComboByID]    Script Date: 12/10/2018 3:39:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[updateComboByID](@macombo VARCHAR(10), @tencombo NVARCHAR(50))
AS
BEGIN
    UPDATE dbo.COMBO SET TenCombo=@tencombo WHERE MaCombo=@macombo
END
GO
/****** Object:  StoredProcedure [dbo].[updateDongiaCombobyID]    Script Date: 12/10/2018 3:39:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[updateDongiaCombobyID](@macombo VARCHAR(10), @dongia MONEY)
AS
BEGIN
    UPDATE dbo.COMBO SET DongiaCombo=@dongia WHERE MaCombo=@macombo
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateDoUong]    Script Date: 12/10/2018 3:39:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UpdateDoUong](@madouong VARCHAR(10), @tendouong NVARCHAR(50), @loaidouong VARCHAR(10), @dotangkem VARCHAR(10), @dongia MONEY)
AS
BEGIN
    UPDATE dbo.DOUONG
	SET TenDoUong=@tendouong, LoaiDoUong=@loaidouong, DoTangKem=@dotangkem, DonGiaDoUong=@dongia
	WHERE MaDoUong=@madouong
END
GO
/****** Object:  StoredProcedure [dbo].[UpdatePhieuBH]    Script Date: 12/10/2018 3:39:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UpdatePhieuBH](@maphieu CHAR(10), @ngaybh DATETIME, @loaibh VARCHAR(10), @tenkh NVARCHAR(50), @sdt VARCHAR(20))
AS
BEGIN
    UPDATE dbo.PHIEUBH SET NgayBH=@ngaybh, LoaiBH=@loaibh, TenKH=@tenkh, SoDienthoai=@sdt
	WHERE MaphieuBH=@maphieu
END
--
GO
USE [master]
GO
ALTER DATABASE [QL_CAFE_BALCONY] SET  READ_WRITE 
GO
