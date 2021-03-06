USE [QLCuaHangCamera]
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 11/17/2018 9:36:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[Id] [int] NOT NULL,
	[HoaDonId] [int] NOT NULL,
	[SanPhamId] [int] NOT NULL,
	[SoLuong] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietHoaDonMua]    Script Date: 11/17/2018 9:36:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDonMua](
	[Id] [int] NOT NULL,
	[HoaDonMuaId] [int] NOT NULL,
	[SanPhamId] [int] NOT NULL,
	[SoLuong] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietKho]    Script Date: 11/17/2018 9:36:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietKho](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[HangHoaId] [int] NOT NULL,
	[KhoId] [int] NOT NULL,
	[ThoiGianNhapKho] [datetime] NOT NULL,
	[SoLuong] [int] NOT NULL,
	[UserIdNhap] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 11/17/2018 9:36:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NhanVienId] [int] NOT NULL,
	[KhachHangId] [int] NOT NULL,
	[ThoiGian] [datetime] NOT NULL,
	[TongTien] [money] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDonMua]    Script Date: 11/17/2018 9:36:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDonMua](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NhanVienId] [int] NOT NULL,
	[NhaCungCapId] [int] NOT NULL,
	[ThoiGian] [datetime] NOT NULL,
	[TongTien] [money] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 11/17/2018 9:36:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[HoTenKH] [nvarchar](100) NOT NULL,
	[DiaChi] [nvarchar](100) NULL,
	[Sdt] [nchar](20) NULL,
	[Email] [nchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kho]    Script Date: 11/17/2018 9:36:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kho](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MaKho] [nchar](10) NOT NULL,
	[TenKho] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 11/17/2018 9:36:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MaNCC] [nchar](10) NOT NULL,
	[TenNCC] [nvarchar](100) NOT NULL,
	[DiaChi] [nvarchar](100) NOT NULL,
	[Sdt] [nchar](20) NOT NULL,
	[Email] [nchar](50) NULL,
	[Website] [nchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 11/17/2018 9:36:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MaNV] [nchar](10) NOT NULL,
	[HoTenNV] [nvarchar](100) NOT NULL,
	[DiaChi] [nvarchar](100) NOT NULL,
	[Sdt] [nchar](20) NOT NULL,
	[Email] [nchar](50) NULL,
	[Cmnd] [nchar](20) NOT NULL,
	[CapBac] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Quyen]    Script Date: 11/17/2018 9:36:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Quyen](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TenQuyen] [nchar](20) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 11/17/2018 9:36:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MaSP] [nchar](10) NOT NULL,
	[TenSP] [nvarchar](100) NOT NULL,
	[BaoHanh] [datetimeoffset](7) NULL,
	[Gia] [money] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 11/17/2018 9:36:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nchar](20) NOT NULL,
	[Password] [nchar](50) NOT NULL,
	[UserId] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThongTinBaoHanh]    Script Date: 11/17/2018 9:36:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThongTinBaoHanh](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[KhachHangId] [int] NOT NULL,
	[SanPhamId] [int] NOT NULL,
	[NhanVienId] [int] NOT NULL,
	[ThoiGian] [datetime] NOT NULL,
	[LanThu] [int] NOT NULL
) ON [PRIMARY]
GO
