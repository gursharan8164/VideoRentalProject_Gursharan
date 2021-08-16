USE [master]
GO
/****** Object:  Database [MovieRentalDB]    Script Date: 16-09-2019 10:57:26 PM ******/
CREATE DATABASE [MovieRentalDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MovieRentalDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\MovieRentalDB.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'MovieRentalDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\MovieRentalDB_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [MovieRentalDB] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MovieRentalDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MovieRentalDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MovieRentalDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MovieRentalDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MovieRentalDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MovieRentalDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [MovieRentalDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MovieRentalDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MovieRentalDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MovieRentalDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MovieRentalDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MovieRentalDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MovieRentalDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MovieRentalDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MovieRentalDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MovieRentalDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MovieRentalDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MovieRentalDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MovieRentalDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MovieRentalDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MovieRentalDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MovieRentalDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MovieRentalDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MovieRentalDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [MovieRentalDB] SET  MULTI_USER 
GO
ALTER DATABASE [MovieRentalDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MovieRentalDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MovieRentalDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MovieRentalDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [MovieRentalDB] SET DELAYED_DURABILITY = DISABLED 
GO
USE [MovieRentalDB]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 16-09-2019 10:57:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](255) NULL,
	[Address] [nvarchar](255) NULL,
	[Phone] [nvarchar](255) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Movies]    Script Date: 16-09-2019 10:57:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movies](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Rating] [nvarchar](50) NULL,
	[Title] [nvarchar](255) NULL,
	[Year] [nvarchar](255) NULL,
	[Rental_Cost] [money] NULL,
	[Copies] [nvarchar](50) NULL,
	[Plot] [ntext] NULL,
	[Genre] [nvarchar](50) NULL,
 CONSTRAINT [PK_Movies] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[RentedMovie]    Script Date: 16-09-2019 10:57:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RentedMovie](
	[RMID] [int] IDENTITY(1,1) NOT NULL,
	[MovieIDFK] [int] NULL,
	[CustIDFK] [int] NULL,
	[DateRented] [datetime] NULL,
	[DateReturned] [datetime] NULL,
 CONSTRAINT [PK_RentedMovie] PRIMARY KEY CLUSTERED 
(
	[RMID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Customer] ON 

GO
INSERT [dbo].[Customer] ([ID], [Name], [Address], [Phone]) VALUES (1, N'Nirmal Singh', N'qwerty', N'9815276871')
GO
SET IDENTITY_INSERT [dbo].[Customer] OFF
GO
SET IDENTITY_INSERT [dbo].[Movies] ON 

GO
INSERT [dbo].[Movies] ([ID], [Rating], [Title], [Year], [Rental_Cost], [Copies], [Plot], [Genre]) VALUES (1, N'5', N'Titanic1', N'2018', 5.0000, N'5', N'5', N'5')
GO
INSERT [dbo].[Movies] ([ID], [Rating], [Title], [Year], [Rental_Cost], [Copies], [Plot], [Genre]) VALUES (2, N'5', N'Hum Tum', N'2005', 2.0000, N'5', N'5', N'5')
GO
SET IDENTITY_INSERT [dbo].[Movies] OFF
GO
SET IDENTITY_INSERT [dbo].[RentedMovie] ON 

GO
INSERT [dbo].[RentedMovie] ([RMID], [MovieIDFK], [CustIDFK], [DateRented], [DateReturned]) VALUES (1, 1, 1, CAST(N'2019-09-16 00:00:00.000' AS DateTime), CAST(N'2019-09-16 22:32:58.000' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[RentedMovie] OFF
GO
USE [master]
GO
ALTER DATABASE [MovieRentalDB] SET  READ_WRITE 
GO
