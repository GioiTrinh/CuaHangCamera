USE [master]
GO

/****** Object:  Database [QLCuaHangCamera]    Script Date: 11/21/2018 8:18:34 PM ******/
CREATE DATABASE [QLCuaHangCamera]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLCuaHangCamera', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.GIOITRINH\MSSQL\DATA\QLCuaHangCamera.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLCuaHangCamera_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.GIOITRINH\MSSQL\DATA\QLCuaHangCamera_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO

ALTER DATABASE [QLCuaHangCamera] SET COMPATIBILITY_LEVEL = 140
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLCuaHangCamera].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [QLCuaHangCamera] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [QLCuaHangCamera] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [QLCuaHangCamera] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [QLCuaHangCamera] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [QLCuaHangCamera] SET ARITHABORT OFF 
GO

ALTER DATABASE [QLCuaHangCamera] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [QLCuaHangCamera] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [QLCuaHangCamera] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [QLCuaHangCamera] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [QLCuaHangCamera] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [QLCuaHangCamera] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [QLCuaHangCamera] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [QLCuaHangCamera] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [QLCuaHangCamera] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [QLCuaHangCamera] SET  DISABLE_BROKER 
GO

ALTER DATABASE [QLCuaHangCamera] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [QLCuaHangCamera] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [QLCuaHangCamera] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [QLCuaHangCamera] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [QLCuaHangCamera] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [QLCuaHangCamera] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [QLCuaHangCamera] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [QLCuaHangCamera] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [QLCuaHangCamera] SET  MULTI_USER 
GO

ALTER DATABASE [QLCuaHangCamera] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [QLCuaHangCamera] SET DB_CHAINING OFF 
GO

ALTER DATABASE [QLCuaHangCamera] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [QLCuaHangCamera] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [QLCuaHangCamera] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [QLCuaHangCamera] SET QUERY_STORE = OFF
GO

ALTER DATABASE [QLCuaHangCamera] SET  READ_WRITE 
GO


