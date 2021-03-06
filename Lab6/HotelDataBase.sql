USE [master]
GO
/****** Object:  Database [HotelDataBase]    Script Date: 17.01.2021 22:36:40 ******/
CREATE DATABASE [HotelDataBase]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HotelDataBase', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MWOJCZALSQL\MSSQL\DATA\HotelDataBase.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'HotelDataBase_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MWOJCZALSQL\MSSQL\DATA\HotelDataBase_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [HotelDataBase] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HotelDataBase].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HotelDataBase] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HotelDataBase] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HotelDataBase] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HotelDataBase] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HotelDataBase] SET ARITHABORT OFF 
GO
ALTER DATABASE [HotelDataBase] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HotelDataBase] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HotelDataBase] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HotelDataBase] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HotelDataBase] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HotelDataBase] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HotelDataBase] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HotelDataBase] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HotelDataBase] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HotelDataBase] SET  ENABLE_BROKER 
GO
ALTER DATABASE [HotelDataBase] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HotelDataBase] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HotelDataBase] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HotelDataBase] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HotelDataBase] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HotelDataBase] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [HotelDataBase] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HotelDataBase] SET RECOVERY FULL 
GO
ALTER DATABASE [HotelDataBase] SET  MULTI_USER 
GO
ALTER DATABASE [HotelDataBase] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HotelDataBase] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HotelDataBase] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HotelDataBase] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [HotelDataBase] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [HotelDataBase] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'HotelDataBase', N'ON'
GO
ALTER DATABASE [HotelDataBase] SET QUERY_STORE = OFF
GO
USE [HotelDataBase]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 17.01.2021 22:36:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Addresses]    Script Date: 17.01.2021 22:36:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Addresses](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Country] [nvarchar](50) NOT NULL,
	[City] [nvarchar](50) NOT NULL,
	[PostCode] [nvarchar](15) NULL,
	[Street] [nvarchar](50) NULL,
	[Number] [int] NOT NULL,
 CONSTRAINT [PK_Addresses] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reservations]    Script Date: 17.01.2021 22:36:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reservations](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[StartDate] [datetime2](7) NOT NULL,
	[EndDate] [datetime2](7) NOT NULL,
	[Price] [int] NOT NULL,
	[RoomNumber] [int] NOT NULL,
	[CustomerId] [int] NOT NULL,
	[Status] [int] NOT NULL,
 CONSTRAINT [PK_Reservations] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rooms]    Script Date: 17.01.2021 22:36:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rooms](
	[Number] [int] NOT NULL,
	[RoomTypeId] [smallint] NOT NULL,
	[Size] [smallint] NOT NULL,
	[Balcony] [bit] NOT NULL,
	[Price] [int] NOT NULL,
 CONSTRAINT [PK_Rooms] PRIMARY KEY CLUSTERED 
(
	[Number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RoomTypes]    Script Date: 17.01.2021 22:36:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoomTypes](
	[Id] [smallint] IDENTITY(1,1) NOT NULL,
	[Type] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_RoomTypes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 17.01.2021 22:36:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[AddressId] [int] NULL,
	[PhoneNumber] [nvarchar](15) NOT NULL,
	[EMail] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[Role] [int] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210116210117_InitialCreate', N'3.1.11')
GO
SET IDENTITY_INSERT [dbo].[Addresses] ON 

INSERT [dbo].[Addresses] ([Id], [Country], [City], [PostCode], [Street], [Number]) VALUES (1, N'Polska', N'Wrocław', N'56-213', N'Hallera', 5)
INSERT [dbo].[Addresses] ([Id], [Country], [City], [PostCode], [Street], [Number]) VALUES (2, N'Polska', N'Konin', N'10-432', N'Koninowa', 8)
INSERT [dbo].[Addresses] ([Id], [Country], [City], [PostCode], [Street], [Number]) VALUES (3, N'Polska', N'Lublin', N'65-212', N'Jakaśtam', 10)
INSERT [dbo].[Addresses] ([Id], [Country], [City], [PostCode], [Street], [Number]) VALUES (4, N'Ukraina', N'Kijów', N'12-123', N'Starovokzalna', 15)
INSERT [dbo].[Addresses] ([Id], [Country], [City], [PostCode], [Street], [Number]) VALUES (5, N'Polska', N'Gdańsk', N'23-212', N'Fajna', 12)
SET IDENTITY_INSERT [dbo].[Addresses] OFF
GO
SET IDENTITY_INSERT [dbo].[Reservations] ON 

INSERT [dbo].[Reservations] ([Id], [StartDate], [EndDate], [Price], [RoomNumber], [CustomerId], [Status]) VALUES (1, CAST(N'2021-01-03T00:00:00.0000000' AS DateTime2), CAST(N'2021-01-10T00:00:00.0000000' AS DateTime2), 650, 101, 2, 0)
INSERT [dbo].[Reservations] ([Id], [StartDate], [EndDate], [Price], [RoomNumber], [CustomerId], [Status]) VALUES (2, CAST(N'2021-01-08T12:25:00.0000000' AS DateTime2), CAST(N'2021-01-23T12:25:00.0000000' AS DateTime2), 140, 102, 5, 1)
SET IDENTITY_INSERT [dbo].[Reservations] OFF
GO
INSERT [dbo].[Rooms] ([Number], [RoomTypeId], [Size], [Balcony], [Price]) VALUES (101, 1, 2, 1, 600)
INSERT [dbo].[Rooms] ([Number], [RoomTypeId], [Size], [Balcony], [Price]) VALUES (102, 2, 2, 0, 120)
INSERT [dbo].[Rooms] ([Number], [RoomTypeId], [Size], [Balcony], [Price]) VALUES (103, 2, 3, 1, 200)
INSERT [dbo].[Rooms] ([Number], [RoomTypeId], [Size], [Balcony], [Price]) VALUES (201, 2, 2, 1, 140)
INSERT [dbo].[Rooms] ([Number], [RoomTypeId], [Size], [Balcony], [Price]) VALUES (202, 3, 2, 1, 1200)
GO
SET IDENTITY_INSERT [dbo].[RoomTypes] ON 

INSERT [dbo].[RoomTypes] ([Id], [Type], [Description]) VALUES (1, N'Apartament', N'Luksusowy pokój dla osób wymagających')
INSERT [dbo].[RoomTypes] ([Id], [Type], [Description]) VALUES (2, N'Standard', N'Pokój spełniający wymogi przeciętnej rodziny')
INSERT [dbo].[RoomTypes] ([Id], [Type], [Description]) VALUES (3, N'Apartament prezydencki', N'Pokój dla osób nie godzących się na  na kompromisy')
SET IDENTITY_INSERT [dbo].[RoomTypes] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [FirstName], [LastName], [AddressId], [PhoneNumber], [EMail], [Password], [Role]) VALUES (1, N'Mariusz', N'Kowalski', 1, N'82919201', N'mariusz@kowalski.pl', N'123', 0)
INSERT [dbo].[Users] ([Id], [FirstName], [LastName], [AddressId], [PhoneNumber], [EMail], [Password], [Role]) VALUES (2, N'Magdalena', N'Nowak', 2, N'192839482', N'magdalena@nowak.pl', N'123', 1)
INSERT [dbo].[Users] ([Id], [FirstName], [LastName], [AddressId], [PhoneNumber], [EMail], [Password], [Role]) VALUES (3, N'Mateusz', N'Dorociński', 3, N'82092101', N'mateusz@dorocinski.pl', N'123', 1)
INSERT [dbo].[Users] ([Id], [FirstName], [LastName], [AddressId], [PhoneNumber], [EMail], [Password], [Role]) VALUES (4, N'Arkadiusz', N'Pudzianowski', 4, N'82021201', N'arkadiusz@pudzianowski.pl', N'123', 1)
INSERT [dbo].[Users] ([Id], [FirstName], [LastName], [AddressId], [PhoneNumber], [EMail], [Password], [Role]) VALUES (5, N'Tomasz', N'Najman', 5, N'82919911', N'tomasz@najman.pl', N'123', 1)
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
/****** Object:  Index [IX_Reservations_CustomerId]    Script Date: 17.01.2021 22:36:41 ******/
CREATE NONCLUSTERED INDEX [IX_Reservations_CustomerId] ON [dbo].[Reservations]
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Reservations_RoomNumber]    Script Date: 17.01.2021 22:36:41 ******/
CREATE NONCLUSTERED INDEX [IX_Reservations_RoomNumber] ON [dbo].[Reservations]
(
	[RoomNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Rooms_RoomTypeId]    Script Date: 17.01.2021 22:36:41 ******/
CREATE NONCLUSTERED INDEX [IX_Rooms_RoomTypeId] ON [dbo].[Rooms]
(
	[RoomTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Users_AddressId]    Script Date: 17.01.2021 22:36:41 ******/
CREATE NONCLUSTERED INDEX [IX_Users_AddressId] ON [dbo].[Users]
(
	[AddressId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Reservations]  WITH CHECK ADD  CONSTRAINT [FK_Reservations_Rooms_RoomNumber] FOREIGN KEY([RoomNumber])
REFERENCES [dbo].[Rooms] ([Number])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Reservations] CHECK CONSTRAINT [FK_Reservations_Rooms_RoomNumber]
GO
ALTER TABLE [dbo].[Reservations]  WITH CHECK ADD  CONSTRAINT [FK_Reservations_Users_CustomerId] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Users] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Reservations] CHECK CONSTRAINT [FK_Reservations_Users_CustomerId]
GO
ALTER TABLE [dbo].[Rooms]  WITH CHECK ADD  CONSTRAINT [FK_Rooms_RoomTypes_RoomTypeId] FOREIGN KEY([RoomTypeId])
REFERENCES [dbo].[RoomTypes] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Rooms] CHECK CONSTRAINT [FK_Rooms_RoomTypes_RoomTypeId]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Addresses_AddressId] FOREIGN KEY([AddressId])
REFERENCES [dbo].[Addresses] ([Id])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Addresses_AddressId]
GO
USE [master]
GO
ALTER DATABASE [HotelDataBase] SET  READ_WRITE 
GO
