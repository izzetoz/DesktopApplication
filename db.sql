USE [master]
GO
/****** Object:  Database [dbAraf]    Script Date: 7.02.2019 22:48:55 ******/
CREATE DATABASE [dbAraf]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'dbAraf', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\dbAraf.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'dbAraf_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\dbAraf_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [dbAraf] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dbAraf].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dbAraf] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [dbAraf] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [dbAraf] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [dbAraf] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [dbAraf] SET ARITHABORT OFF 
GO
ALTER DATABASE [dbAraf] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [dbAraf] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [dbAraf] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [dbAraf] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [dbAraf] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [dbAraf] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [dbAraf] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [dbAraf] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [dbAraf] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [dbAraf] SET  DISABLE_BROKER 
GO
ALTER DATABASE [dbAraf] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [dbAraf] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [dbAraf] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [dbAraf] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [dbAraf] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [dbAraf] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [dbAraf] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [dbAraf] SET RECOVERY FULL 
GO
ALTER DATABASE [dbAraf] SET  MULTI_USER 
GO
ALTER DATABASE [dbAraf] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [dbAraf] SET DB_CHAINING OFF 
GO
ALTER DATABASE [dbAraf] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [dbAraf] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [dbAraf] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'dbAraf', N'ON'
GO
ALTER DATABASE [dbAraf] SET QUERY_STORE = OFF
GO
USE [dbAraf]
GO
/****** Object:  Table [dbo].[Kullanici]    Script Date: 7.02.2019 22:48:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kullanici](
	[kullaniciID] [int] IDENTITY(1,1) NOT NULL,
	[kullaniciad] [nvarchar](50) NOT NULL,
	[kullanicisoyad] [nvarchar](50) NOT NULL,
	[kullanicimail] [nvarchar](50) NOT NULL,
	[kullanicisifre] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Kullanici] PRIMARY KEY CLUSTERED 
(
	[kullaniciID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Kullanici] ON 

INSERT [dbo].[Kullanici] ([kullaniciID], [kullaniciad], [kullanicisoyad], [kullanicimail], [kullanicisifre]) VALUES (1, N'İzzet', N'Öz', N'izzetoz42@gmail.com', N'123')
INSERT [dbo].[Kullanici] ([kullaniciID], [kullaniciad], [kullanicisoyad], [kullanicimail], [kullanicisifre]) VALUES (2, N'Burak', N'Bayram', N'burakbayram@gmail.com', N'1234')
INSERT [dbo].[Kullanici] ([kullaniciID], [kullaniciad], [kullanicisoyad], [kullanicimail], [kullanicisifre]) VALUES (5, N'Kerem', N'Korkmaz', N'keremkorkmaz@gmail.com', N'1907')
INSERT [dbo].[Kullanici] ([kullaniciID], [kullaniciad], [kullanicisoyad], [kullanicimail], [kullanicisifre]) VALUES (9, N'Ahmet', N'Yıldız', N'ahmetyildiz@gmail.com', N'1903')
SET IDENTITY_INSERT [dbo].[Kullanici] OFF
USE [master]
GO
ALTER DATABASE [dbAraf] SET  READ_WRITE 
GO
