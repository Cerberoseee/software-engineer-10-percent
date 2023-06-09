USE [master]
GO
/****** Object:  Database [TicketVendorMachine]    Script Date: 18/03/2023 11:41:48 CH ******/
CREATE DATABASE [TicketVendorMachine]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TicketVendorMachine', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\TicketVendorMachine.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TicketVendorMachine_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\TicketVendorMachine_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [TicketVendorMachine] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TicketVendorMachine].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TicketVendorMachine] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TicketVendorMachine] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TicketVendorMachine] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TicketVendorMachine] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TicketVendorMachine] SET ARITHABORT OFF 
GO
ALTER DATABASE [TicketVendorMachine] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TicketVendorMachine] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TicketVendorMachine] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TicketVendorMachine] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TicketVendorMachine] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TicketVendorMachine] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TicketVendorMachine] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TicketVendorMachine] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TicketVendorMachine] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TicketVendorMachine] SET  ENABLE_BROKER 
GO
ALTER DATABASE [TicketVendorMachine] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TicketVendorMachine] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TicketVendorMachine] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TicketVendorMachine] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TicketVendorMachine] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TicketVendorMachine] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TicketVendorMachine] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TicketVendorMachine] SET RECOVERY FULL 
GO
ALTER DATABASE [TicketVendorMachine] SET  MULTI_USER 
GO
ALTER DATABASE [TicketVendorMachine] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TicketVendorMachine] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TicketVendorMachine] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TicketVendorMachine] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TicketVendorMachine] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TicketVendorMachine] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'TicketVendorMachine', N'ON'
GO
ALTER DATABASE [TicketVendorMachine] SET QUERY_STORE = OFF
GO
USE [TicketVendorMachine]
GO
/****** Object:  Table [dbo].[Seat]    Script Date: 18/03/2023 11:41:48 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Seat](
	[ID] [varchar](255) NOT NULL,
	[TripID] [varchar](255) NULL,
	[SeatNumber] [varchar](8) NULL,
	[isOccupied] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ticket]    Script Date: 18/03/2023 11:41:48 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ticket](
	[ID] [varchar](255) NOT NULL,
	[TripID] [varchar](255) NULL,
	[SeatNumber] [varchar](8) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Trip]    Script Date: 18/03/2023 11:41:48 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Trip](
	[ID] [varchar](255) NOT NULL,
	[FromLoc] [varchar](255) NULL,
	[DestLoc] [varchar](255) NULL,
	[DepartTime] [time](7) NULL,
	[AvailableSeat] [int] NULL,
	[TotalSeat] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [TicketVendorMachine] SET  READ_WRITE 
GO
