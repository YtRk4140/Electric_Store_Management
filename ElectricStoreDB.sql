USE [master]
GO
CREATE DATABASE [ElectricStore]
use database ElectricStore
/****** Object:  Database [ElectricStore]    Script Date: 3/9/2023 6:48:40 PM ******/
CREATE DATABASE [ElectricStore]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ElectricStore', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ElectricStore.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ElectricStore_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ElectricStore_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ElectricStore] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ElectricStore].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ElectricStore] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ElectricStore] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ElectricStore] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ElectricStore] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ElectricStore] SET ARITHABORT OFF 
GO
ALTER DATABASE [ElectricStore] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ElectricStore] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ElectricStore] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ElectricStore] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ElectricStore] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ElectricStore] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ElectricStore] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ElectricStore] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ElectricStore] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ElectricStore] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ElectricStore] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ElectricStore] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ElectricStore] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ElectricStore] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ElectricStore] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ElectricStore] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ElectricStore] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ElectricStore] SET RECOVERY FULL 
GO
ALTER DATABASE [ElectricStore] SET  MULTI_USER 
GO
ALTER DATABASE [ElectricStore] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ElectricStore] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ElectricStore] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ElectricStore] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ElectricStore] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ElectricStore] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'ElectricStore', N'ON'
GO
ALTER DATABASE [ElectricStore] SET QUERY_STORE = OFF
GO
USE [ElectricStore]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 3/9/2023 6:48:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](500) NULL,
	[CategoryCode] [nchar](10) NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 3/9/2023 6:48:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](500) NULL,
	[ProductCode] [nchar](10) NULL,
	[Price] [money] NULL,
	[DateCreate] [datetime] NULL,
	[CategoryId] [int] NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 3/9/2023 6:48:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserId] [nvarchar](450) NOT NULL,
	[Password] [nvarchar](max) NULL,
	[UserName] [nvarchar](max) NULL,
	[UserRole] [int] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Category] ON 
GO
INSERT [dbo].[Category] ([Id], [CategoryName], [CategoryCode]) VALUES (1, N'Laptop', N'LT        ')
GO
INSERT [dbo].[Category] ([Id], [CategoryName], [CategoryCode]) VALUES (2, N'Printer', N'PT        ')
GO
INSERT [dbo].[Category] ([Id], [CategoryName], [CategoryCode]) VALUES (3, N'Scanner', N'SC        ')
GO
INSERT [dbo].[Category] ([Id], [CategoryName], [CategoryCode]) VALUES (4, N'PC', N'PC        ')
GO
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 
GO
INSERT [dbo].[Products] ([Id], [ProductName], [ProductCode], [Price], [DateCreate], [CategoryId]) VALUES (1, N'Laptop Asus', N'LTAS      ', 30000000.0000, CAST(N'2023-09-03T00:00:00.000' AS DateTime), 1)
GO
INSERT [dbo].[Products] ([Id], [ProductName], [ProductCode], [Price], [DateCreate], [CategoryId]) VALUES (2, N'Laptop Acer', N'LTAC      ', 40000000.0000, CAST(N'2023-08-03T00:00:00.000' AS DateTime), 1)
GO
INSERT [dbo].[Products] ([Id], [ProductName], [ProductCode], [Price], [DateCreate], [CategoryId]) VALUES (3, N'Printer Cannon', N'PTCA      ', 4000000.0000, CAST(N'2023-05-03T00:00:00.000' AS DateTime), 2)
GO
INSERT [dbo].[Products] ([Id], [ProductName], [ProductCode], [Price], [DateCreate], [CategoryId]) VALUES (4, N'Scanner Brother', N'SCBR      ', 6000000.0000, CAST(N'2023-12-03T00:00:00.000' AS DateTime), 3)
GO
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
INSERT [dbo].[Users] ([UserId], [Password], [UserName], [UserRole]) VALUES (N'10001', N'123456', N'administrator', 1)
GO
INSERT [dbo].[Users] ([UserId], [Password], [UserName], [UserRole]) VALUES (N'10002', N'123456', N'manager', 2)
GO
INSERT [dbo].[Users] ([UserId], [Password], [UserName], [UserRole]) VALUES (N'10003', N'123456', N'staff', 3)
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Category] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Category] ([Id])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Category]
GO
USE [master]
GO
ALTER DATABASE [ElectricStore] SET  READ_WRITE 
GO
