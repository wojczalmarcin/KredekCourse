USE [master]
GO
/****** Object:  Database [UniversityFaculty]    Script Date: 14.12.2020 02:38:30 ******/
CREATE DATABASE [UniversityFaculty]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'UniversityFaculty', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MWOJCZALSQL\MSSQL\DATA\UniversityFaculty.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'UniversityFaculty_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MWOJCZALSQL\MSSQL\DATA\UniversityFaculty_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [UniversityFaculty] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [UniversityFaculty].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [UniversityFaculty] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [UniversityFaculty] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [UniversityFaculty] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [UniversityFaculty] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [UniversityFaculty] SET ARITHABORT OFF 
GO
ALTER DATABASE [UniversityFaculty] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [UniversityFaculty] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [UniversityFaculty] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [UniversityFaculty] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [UniversityFaculty] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [UniversityFaculty] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [UniversityFaculty] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [UniversityFaculty] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [UniversityFaculty] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [UniversityFaculty] SET  DISABLE_BROKER 
GO
ALTER DATABASE [UniversityFaculty] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [UniversityFaculty] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [UniversityFaculty] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [UniversityFaculty] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [UniversityFaculty] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [UniversityFaculty] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [UniversityFaculty] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [UniversityFaculty] SET RECOVERY FULL 
GO
ALTER DATABASE [UniversityFaculty] SET  MULTI_USER 
GO
ALTER DATABASE [UniversityFaculty] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [UniversityFaculty] SET DB_CHAINING OFF 
GO
ALTER DATABASE [UniversityFaculty] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [UniversityFaculty] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [UniversityFaculty] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [UniversityFaculty] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'UniversityFaculty', N'ON'
GO
ALTER DATABASE [UniversityFaculty] SET QUERY_STORE = OFF
GO
USE [UniversityFaculty]
GO
/****** Object:  Table [dbo].[FieldsOfStudy]    Script Date: 14.12.2020 02:38:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FieldsOfStudy](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PatronWorkerId] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_FieldOfStudy] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ResidencePlaces]    Script Date: 14.12.2020 02:38:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ResidencePlaces](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Country] [nvarchar](50) NOT NULL,
	[City] [nvarchar](50) NOT NULL,
	[PostCode] [varchar](15) NULL,
	[Street] [nvarchar](50) NULL,
	[Number] [int] NOT NULL,
 CONSTRAINT [PK_ResidencePlace] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 14.12.2020 02:38:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[SIndex] [int] NOT NULL,
	[FieldOfStudyId] [int] NOT NULL,
	[StudyVintageIdex] [int] NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[BirthDate] [date] NOT NULL,
	[Pesel] [nvarchar](50) NOT NULL,
	[ResidencePlaceId] [int] NULL,
	[ECTSDeficit] [tinyint] NOT NULL,
	[PhoneNumber] [int] NOT NULL,
	[EMail] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[SIndex] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StudyVintages]    Script Date: 14.12.2020 02:38:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudyVintages](
	[VIndex] [int] NOT NULL,
	[YearPatronSIndex] [int] NULL,
	[Year] [int] NOT NULL,
 CONSTRAINT [PK_StudyVintage] PRIMARY KEY CLUSTERED 
(
	[VIndex] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SubjectGroups]    Script Date: 14.12.2020 02:38:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SubjectGroups](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SubjectId] [int] NOT NULL,
	[WorkerId] [int] NOT NULL,
	[DayOfWeek] [nvarchar](20) NOT NULL,
	[Hour] [nvarchar](10) NOT NULL,
	[StudentsNumber] [int] NOT NULL,
	[MaxStudentsNumber] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_SubjectGroup] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subjects]    Script Date: 14.12.2020 02:38:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subjects](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FieldOfStudyId] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Term] [tinyint] NOT NULL,
	[ECTS] [tinyint] NOT NULL,
 CONSTRAINT [PK_Subject] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 14.12.2020 02:38:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Login] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Workers]    Script Date: 14.12.2020 02:38:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Workers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[BirthDate] [date] NOT NULL,
	[WorkplaceId] [int] NOT NULL,
	[Degree] [nvarchar](50) NULL,
	[Salary] [int] NOT NULL,
	[PhoneNumber] [int] NOT NULL,
	[EMail] [nvarchar](50) NULL,
	[ResidencePlaceId] [int] NULL,
 CONSTRAINT [PK_Worker] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Workplaces]    Script Date: 14.12.2020 02:38:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Workplaces](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[BaseSalary] [int] NOT NULL,
 CONSTRAINT [PK_Workplace] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[FieldsOfStudy] ON 

INSERT [dbo].[FieldsOfStudy] ([Id], [PatronWorkerId], [Name]) VALUES (1, 1, N'Informatyka')
INSERT [dbo].[FieldsOfStudy] ([Id], [PatronWorkerId], [Name]) VALUES (2, 2, N'Automatyka i Robotyka')
INSERT [dbo].[FieldsOfStudy] ([Id], [PatronWorkerId], [Name]) VALUES (3, 3, N'Elektronika')
INSERT [dbo].[FieldsOfStudy] ([Id], [PatronWorkerId], [Name]) VALUES (4, 4, N'Sieci komputerowe')
SET IDENTITY_INSERT [dbo].[FieldsOfStudy] OFF
GO
SET IDENTITY_INSERT [dbo].[ResidencePlaces] ON 

INSERT [dbo].[ResidencePlaces] ([Id], [Country], [City], [PostCode], [Street], [Number]) VALUES (1, N'Polska', N'Wrocław', N'56-213', N'Hallera', 5)
INSERT [dbo].[ResidencePlaces] ([Id], [Country], [City], [PostCode], [Street], [Number]) VALUES (2, N'Polska', N'Konin', N'10-432', N'Koninowa', 8)
INSERT [dbo].[ResidencePlaces] ([Id], [Country], [City], [PostCode], [Street], [Number]) VALUES (3, N'Polska', N'Lublin', N'65-212', N'Jakaśtam', 10)
INSERT [dbo].[ResidencePlaces] ([Id], [Country], [City], [PostCode], [Street], [Number]) VALUES (4, N'Ukraina', N'Kijów', N'12-123', N'Starovokzalna', 15)
INSERT [dbo].[ResidencePlaces] ([Id], [Country], [City], [PostCode], [Street], [Number]) VALUES (5, N'Polska', N'Gdańsk', N'23-212', N'Fajna', 12)
INSERT [dbo].[ResidencePlaces] ([Id], [Country], [City], [PostCode], [Street], [Number]) VALUES (6, N'Polska', N'Zielona Góra', N'67-456', N'Wrocławska', 5)
INSERT [dbo].[ResidencePlaces] ([Id], [Country], [City], [PostCode], [Street], [Number]) VALUES (7, N'Polska', N'Wrocław', N'23-572', N'Trzebnicka', 46)
INSERT [dbo].[ResidencePlaces] ([Id], [Country], [City], [PostCode], [Street], [Number]) VALUES (8, N'Polska', N'Wrocław', N'65-001', N'Grunwaldzka', 82)
INSERT [dbo].[ResidencePlaces] ([Id], [Country], [City], [PostCode], [Street], [Number]) VALUES (9, N'Polska', N'Wrocław', N'82-421', N'Długa', 93)
INSERT [dbo].[ResidencePlaces] ([Id], [Country], [City], [PostCode], [Street], [Number]) VALUES (10, N'Polska', N'Poznań', N'56-231', N'Wrocławska', 21)
INSERT [dbo].[ResidencePlaces] ([Id], [Country], [City], [PostCode], [Street], [Number]) VALUES (11, N'Polska', N'Wrocław', N'82-100', N'Legnicka', 102)
INSERT [dbo].[ResidencePlaces] ([Id], [Country], [City], [PostCode], [Street], [Number]) VALUES (12, N'Polska', N'Wrocław', N'23-241', N'Pomorska', 73)
INSERT [dbo].[ResidencePlaces] ([Id], [Country], [City], [PostCode], [Street], [Number]) VALUES (13, N'Polska', N'Łódź', N'69-123', N'Łódzka', 25)
INSERT [dbo].[ResidencePlaces] ([Id], [Country], [City], [PostCode], [Street], [Number]) VALUES (14, N'Polska', N'Wrocław', N'12-102', N'Stawowa', 7)
INSERT [dbo].[ResidencePlaces] ([Id], [Country], [City], [PostCode], [Street], [Number]) VALUES (15, N'Polska', N'Legnica', N'53-002', N'Legnicka', 83)
INSERT [dbo].[ResidencePlaces] ([Id], [Country], [City], [PostCode], [Street], [Number]) VALUES (16, N'Polska', N'Wrocław', N'27-821', N'Sienkiewicza', 65)
INSERT [dbo].[ResidencePlaces] ([Id], [Country], [City], [PostCode], [Street], [Number]) VALUES (17, N'Polska', N'Wrocław', N'87-921', N'Powstańców Śląskich', 24)
INSERT [dbo].[ResidencePlaces] ([Id], [Country], [City], [PostCode], [Street], [Number]) VALUES (18, N'Polska', N'Wrocław', N'82-001', N'Gajowa', 76)
INSERT [dbo].[ResidencePlaces] ([Id], [Country], [City], [PostCode], [Street], [Number]) VALUES (19, N'Polska', N'Kraków', N'66-871', N'Krakowska', 65)
INSERT [dbo].[ResidencePlaces] ([Id], [Country], [City], [PostCode], [Street], [Number]) VALUES (20, N'Polska', N'Wrocław', N'87-215', N'Piotra Czajkowskiego', 24)
INSERT [dbo].[ResidencePlaces] ([Id], [Country], [City], [PostCode], [Street], [Number]) VALUES (21, N'Polska', N'Zielona Góra', N'85-235', N'Bema', 78)
INSERT [dbo].[ResidencePlaces] ([Id], [Country], [City], [PostCode], [Street], [Number]) VALUES (22, N'Polska', N'Lublin', N'53-280', N'Warszawska', 5)
SET IDENTITY_INSERT [dbo].[ResidencePlaces] OFF
GO
INSERT [dbo].[Students] ([SIndex], [FieldOfStudyId], [StudyVintageIdex], [FirstName], [LastName], [BirthDate], [Pesel], [ResidencePlaceId], [ECTSDeficit], [PhoneNumber], [EMail]) VALUES (181434, 1, 18, N'Dagmara', N'Czarnecka', CAST(N'1999-11-12' AS Date), N'99111228345', 3, 2, 823237389, N'dagmara@czarnecka.pl')
INSERT [dbo].[Students] ([SIndex], [FieldOfStudyId], [StudyVintageIdex], [FirstName], [LastName], [BirthDate], [Pesel], [ResidencePlaceId], [ECTSDeficit], [PhoneNumber], [EMail]) VALUES (182591, 1, 18, N'Michał', N'Lewandowski', CAST(N'1999-05-05' AS Date), N'99050528352', 2, 0, 823947389, N'michal@lewandowski.pl')
INSERT [dbo].[Students] ([SIndex], [FieldOfStudyId], [StudyVintageIdex], [FirstName], [LastName], [BirthDate], [Pesel], [ResidencePlaceId], [ECTSDeficit], [PhoneNumber], [EMail]) VALUES (184202, 3, 18, N'Fabian', N'Szymański', CAST(N'1999-07-17' AS Date), N'99071723445', 5, 2, 823942334, N'fabian@szymanski.pl')
INSERT [dbo].[Students] ([SIndex], [FieldOfStudyId], [StudyVintageIdex], [FirstName], [LastName], [BirthDate], [Pesel], [ResidencePlaceId], [ECTSDeficit], [PhoneNumber], [EMail]) VALUES (184320, 2, 18, N'Joanna', N'Przybylska', CAST(N'1999-12-03' AS Date), N'99031262833', 4, 6, 823947367, N'joanna@przybylska.pl')
INSERT [dbo].[Students] ([SIndex], [FieldOfStudyId], [StudyVintageIdex], [FirstName], [LastName], [BirthDate], [Pesel], [ResidencePlaceId], [ECTSDeficit], [PhoneNumber], [EMail]) VALUES (193742, 1, 19, N'Julia', N'Zieliński', CAST(N'2000-06-28' AS Date), N'00062846345', 12, 0, 834503825, N'julian@zielinski.pl')
INSERT [dbo].[Students] ([SIndex], [FieldOfStudyId], [StudyVintageIdex], [FirstName], [LastName], [BirthDate], [Pesel], [ResidencePlaceId], [ECTSDeficit], [PhoneNumber], [EMail]) VALUES (194230, 4, 19, N'Justyna', N'Baran', CAST(N'2000-06-18' AS Date), N'00061825367', 10, 0, 837439284, N'justyna@baran.pl')
INSERT [dbo].[Students] ([SIndex], [FieldOfStudyId], [StudyVintageIdex], [FirstName], [LastName], [BirthDate], [Pesel], [ResidencePlaceId], [ECTSDeficit], [PhoneNumber], [EMail]) VALUES (197520, 3, 19, N'Ariel', N'Ostrowski', CAST(N'2000-12-12' AS Date), N'00121228345', 6, 10, 293502843, N'ariel@ostrowski.pl')
INSERT [dbo].[Students] ([SIndex], [FieldOfStudyId], [StudyVintageIdex], [FirstName], [LastName], [BirthDate], [Pesel], [ResidencePlaceId], [ECTSDeficit], [PhoneNumber], [EMail]) VALUES (197523, 2, 19, N'Sylwia', N'Ziółkowska', CAST(N'2000-09-15' AS Date), N'00091524964', 17, 6, 827364957, N'sylwia@ziolkowska.pl')
INSERT [dbo].[Students] ([SIndex], [FieldOfStudyId], [StudyVintageIdex], [FirstName], [LastName], [BirthDate], [Pesel], [ResidencePlaceId], [ECTSDeficit], [PhoneNumber], [EMail]) VALUES (203549, 1, 20, N'Marlena', N'Duda', CAST(N'2001-11-17' AS Date), N'01111734694', 18, 0, 834329347, N'marlena@duda.pl')
INSERT [dbo].[Students] ([SIndex], [FieldOfStudyId], [StudyVintageIdex], [FirstName], [LastName], [BirthDate], [Pesel], [ResidencePlaceId], [ECTSDeficit], [PhoneNumber], [EMail]) VALUES (208345, 2, 20, N'Mateusz', N'Król', CAST(N'2001-04-15' AS Date), N'01041582314', 21, 0, 742348239, N'mateusz@krol.pl')
INSERT [dbo].[Students] ([SIndex], [FieldOfStudyId], [StudyVintageIdex], [FirstName], [LastName], [BirthDate], [Pesel], [ResidencePlaceId], [ECTSDeficit], [PhoneNumber], [EMail]) VALUES (208534, 4, 20, N'Kajetan', N'Pawlak', CAST(N'2001-12-05' AS Date), N'01120584754', 19, 0, 452347605, N'kajetan@pawlak.pl')
INSERT [dbo].[Students] ([SIndex], [FieldOfStudyId], [StudyVintageIdex], [FirstName], [LastName], [BirthDate], [Pesel], [ResidencePlaceId], [ECTSDeficit], [PhoneNumber], [EMail]) VALUES (209346, 1, 20, N'Alek', N'Dąbrowski', CAST(N'2001-02-01' AS Date), N'01020184564', 19, 0, 235693496, N'alek@dabrowski.pl')
INSERT [dbo].[Students] ([SIndex], [FieldOfStudyId], [StudyVintageIdex], [FirstName], [LastName], [BirthDate], [Pesel], [ResidencePlaceId], [ECTSDeficit], [PhoneNumber], [EMail]) VALUES (209355, 1, 20, N'Maciej', N'Dąbrowski', CAST(N'2001-01-02' AS Date), N'01020184555', 19, 0, 834349230, N'maciej@dabrowski.pl')
GO
INSERT [dbo].[StudyVintages] ([VIndex], [YearPatronSIndex], [Year]) VALUES (18, 181434, 2018)
INSERT [dbo].[StudyVintages] ([VIndex], [YearPatronSIndex], [Year]) VALUES (19, 182591, 2019)
INSERT [dbo].[StudyVintages] ([VIndex], [YearPatronSIndex], [Year]) VALUES (20, 209346, 2020)
GO
SET IDENTITY_INSERT [dbo].[SubjectGroups] ON 

INSERT [dbo].[SubjectGroups] ([Id], [SubjectId], [WorkerId], [DayOfWeek], [Hour], [StudentsNumber], [MaxStudentsNumber], [Name]) VALUES (1, 1, 1, N'Środa', N'15:10', 2, 15, N'Podstawy Programowania L')
INSERT [dbo].[SubjectGroups] ([Id], [SubjectId], [WorkerId], [DayOfWeek], [Hour], [StudentsNumber], [MaxStudentsNumber], [Name]) VALUES (2, 1, 2, N'Wtorek', N'9:15', 2, 15, N'Podstawy Programowania W')
INSERT [dbo].[SubjectGroups] ([Id], [SubjectId], [WorkerId], [DayOfWeek], [Hour], [StudentsNumber], [MaxStudentsNumber], [Name]) VALUES (3, 2, 4, N'Poniedziałek', N'13:15', 2, 15, N'Analiza Matematyczna L')
INSERT [dbo].[SubjectGroups] ([Id], [SubjectId], [WorkerId], [DayOfWeek], [Hour], [StudentsNumber], [MaxStudentsNumber], [Name]) VALUES (4, 2, 3, N'Piątek', N'7:30', 2, 15, N'Analiza Matematyczna W')
INSERT [dbo].[SubjectGroups] ([Id], [SubjectId], [WorkerId], [DayOfWeek], [Hour], [StudentsNumber], [MaxStudentsNumber], [Name]) VALUES (5, 3, 4, N'Poniedziałek', N'9:15', 2, 15, N'Arytmetyka L')
INSERT [dbo].[SubjectGroups] ([Id], [SubjectId], [WorkerId], [DayOfWeek], [Hour], [StudentsNumber], [MaxStudentsNumber], [Name]) VALUES (6, 3, 3, N'Środa', N'12:15', 2, 15, N'Arytmetyka W')
INSERT [dbo].[SubjectGroups] ([Id], [SubjectId], [WorkerId], [DayOfWeek], [Hour], [StudentsNumber], [MaxStudentsNumber], [Name]) VALUES (7, 4, 5, N'Wtorek', N'11:15', 2, 15, N'Bazy Danych W')
SET IDENTITY_INSERT [dbo].[SubjectGroups] OFF
GO
SET IDENTITY_INSERT [dbo].[Subjects] ON 

INSERT [dbo].[Subjects] ([Id], [FieldOfStudyId], [Name], [Term], [ECTS]) VALUES (1, 1, N'Podstawy Programowania', 1, 5)
INSERT [dbo].[Subjects] ([Id], [FieldOfStudyId], [Name], [Term], [ECTS]) VALUES (2, 1, N'Analiza Matematyczna1', 1, 10)
INSERT [dbo].[Subjects] ([Id], [FieldOfStudyId], [Name], [Term], [ECTS]) VALUES (3, 1, N'Arytmetyka1', 1, 5)
INSERT [dbo].[Subjects] ([Id], [FieldOfStudyId], [Name], [Term], [ECTS]) VALUES (4, 1, N'BazyDanych1', 1, 10)
INSERT [dbo].[Subjects] ([Id], [FieldOfStudyId], [Name], [Term], [ECTS]) VALUES (5, 2, N'Podstawy Programowania', 1, 5)
INSERT [dbo].[Subjects] ([Id], [FieldOfStudyId], [Name], [Term], [ECTS]) VALUES (6, 2, N'Podstawy automatyki', 1, 10)
INSERT [dbo].[Subjects] ([Id], [FieldOfStudyId], [Name], [Term], [ECTS]) VALUES (7, 2, N'Analiza Matematyczna1', 1, 10)
INSERT [dbo].[Subjects] ([Id], [FieldOfStudyId], [Name], [Term], [ECTS]) VALUES (8, 2, N'Arytmetyka1', 1, 5)
INSERT [dbo].[Subjects] ([Id], [FieldOfStudyId], [Name], [Term], [ECTS]) VALUES (9, 3, N'Podstawy Elektroniki', 1, 10)
INSERT [dbo].[Subjects] ([Id], [FieldOfStudyId], [Name], [Term], [ECTS]) VALUES (10, 3, N'Analiza Matematyczna1', 1, 10)
INSERT [dbo].[Subjects] ([Id], [FieldOfStudyId], [Name], [Term], [ECTS]) VALUES (11, 3, N'Arytmetyka1', 1, 5)
INSERT [dbo].[Subjects] ([Id], [FieldOfStudyId], [Name], [Term], [ECTS]) VALUES (12, 3, N'Miernictwo1', 1, 5)
INSERT [dbo].[Subjects] ([Id], [FieldOfStudyId], [Name], [Term], [ECTS]) VALUES (13, 4, N'Podstawy Sieci Komputerowych', 1, 10)
INSERT [dbo].[Subjects] ([Id], [FieldOfStudyId], [Name], [Term], [ECTS]) VALUES (14, 4, N'Analiza Matematyczna1', 1, 10)
INSERT [dbo].[Subjects] ([Id], [FieldOfStudyId], [Name], [Term], [ECTS]) VALUES (15, 4, N'Arytmetyka1', 1, 5)
INSERT [dbo].[Subjects] ([Id], [FieldOfStudyId], [Name], [Term], [ECTS]) VALUES (16, 4, N'Podstawy elektroniki', 1, 5)
INSERT [dbo].[Subjects] ([Id], [FieldOfStudyId], [Name], [Term], [ECTS]) VALUES (17, 1, N'Programowanie Obiektowe', 2, 10)
INSERT [dbo].[Subjects] ([Id], [FieldOfStudyId], [Name], [Term], [ECTS]) VALUES (18, 2, N'Automatyka i Robotyka', 2, 10)
INSERT [dbo].[Subjects] ([Id], [FieldOfStudyId], [Name], [Term], [ECTS]) VALUES (19, 3, N'Elektronika', 2, 10)
INSERT [dbo].[Subjects] ([Id], [FieldOfStudyId], [Name], [Term], [ECTS]) VALUES (20, 4, N'Sieci Komputerowe', 2, 10)
INSERT [dbo].[Subjects] ([Id], [FieldOfStudyId], [Name], [Term], [ECTS]) VALUES (21, 1, N'Języki Programowania', 3, 10)
INSERT [dbo].[Subjects] ([Id], [FieldOfStudyId], [Name], [Term], [ECTS]) VALUES (22, 2, N'Mechanika', 3, 10)
INSERT [dbo].[Subjects] ([Id], [FieldOfStudyId], [Name], [Term], [ECTS]) VALUES (23, 3, N'Miernictwo2', 3, 10)
INSERT [dbo].[Subjects] ([Id], [FieldOfStudyId], [Name], [Term], [ECTS]) VALUES (24, 4, N'Zarządzanie Siecią', 3, 10)
SET IDENTITY_INSERT [dbo].[Subjects] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [Login], [Password]) VALUES (1, N'admin', N'admin')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
SET IDENTITY_INSERT [dbo].[Workers] ON 

INSERT [dbo].[Workers] ([Id], [FirstName], [LastName], [BirthDate], [WorkplaceId], [Degree], [Salary], [PhoneNumber], [EMail], [ResidencePlaceId]) VALUES (1, N'Józef', N'Fajnygość', CAST(N'1969-07-11' AS Date), 1, N'prof. dr hab. inż.', 7200, 923849582, N'jozef@fajnygosc.pl', 12)
INSERT [dbo].[Workers] ([Id], [FirstName], [LastName], [BirthDate], [WorkplaceId], [Degree], [Salary], [PhoneNumber], [EMail], [ResidencePlaceId]) VALUES (2, N'Marek', N'Kowalski', CAST(N'1972-05-12' AS Date), 1, N'Prof. dr hab. inż.', 5000, 786392791, N'marek@kowalski.pl', 1)
INSERT [dbo].[Workers] ([Id], [FirstName], [LastName], [BirthDate], [WorkplaceId], [Degree], [Salary], [PhoneNumber], [EMail], [ResidencePlaceId]) VALUES (3, N'Andrzej', N'Nowak', CAST(N'1977-08-23' AS Date), 1, N'Prof. dr inż.', 4500, 872395728, N'andrzej@nowak.pl', 7)
INSERT [dbo].[Workers] ([Id], [FirstName], [LastName], [BirthDate], [WorkplaceId], [Degree], [Salary], [PhoneNumber], [EMail], [ResidencePlaceId]) VALUES (4, N'Mateusz', N'Różalski', CAST(N'1980-03-19' AS Date), 1, N'dr inż', 3900, 872983758, N'mateusz@rozalski.pl', 8)
INSERT [dbo].[Workers] ([Id], [FirstName], [LastName], [BirthDate], [WorkplaceId], [Degree], [Salary], [PhoneNumber], [EMail], [ResidencePlaceId]) VALUES (5, N'Marek', N'Nowak', CAST(N'1979-02-02' AS Date), 1, N'dr inż', 4000, 823947289, N'marek@nowak.pl', 9)
INSERT [dbo].[Workers] ([Id], [FirstName], [LastName], [BirthDate], [WorkplaceId], [Degree], [Salary], [PhoneNumber], [EMail], [ResidencePlaceId]) VALUES (6, N'Marcin', N'Najman', CAST(N'1977-11-09' AS Date), 1, N'dr inż', 4100, 293405192, N'marcin@najman.pl', 11)
INSERT [dbo].[Workers] ([Id], [FirstName], [LastName], [BirthDate], [WorkplaceId], [Degree], [Salary], [PhoneNumber], [EMail], [ResidencePlaceId]) VALUES (8, N'Juliusz', N'Cezar', CAST(N'1982-10-10' AS Date), 2, NULL, 4300, 823948192, N'juliusz@cezar.pl', 14)
INSERT [dbo].[Workers] ([Id], [FirstName], [LastName], [BirthDate], [WorkplaceId], [Degree], [Salary], [PhoneNumber], [EMail], [ResidencePlaceId]) VALUES (9, N'Dorian', N'Nikodem', CAST(N'1970-12-12' AS Date), 3, NULL, 2000, 823748291, NULL, 13)
INSERT [dbo].[Workers] ([Id], [FirstName], [LastName], [BirthDate], [WorkplaceId], [Degree], [Salary], [PhoneNumber], [EMail], [ResidencePlaceId]) VALUES (10, N'Kacper', N'Mróz', CAST(N'1992-11-03' AS Date), 3, NULL, 1800, 872394728, NULL, 15)
INSERT [dbo].[Workers] ([Id], [FirstName], [LastName], [BirthDate], [WorkplaceId], [Degree], [Salary], [PhoneNumber], [EMail], [ResidencePlaceId]) VALUES (11, N'Andrzej', N'Kołowrotek', CAST(N'1987-01-12' AS Date), 4, NULL, 3200, 823948291, N'andrzej@kolowrotek.pl', 16)
SET IDENTITY_INSERT [dbo].[Workers] OFF
GO
SET IDENTITY_INSERT [dbo].[Workplaces] ON 

INSERT [dbo].[Workplaces] ([Id], [Name], [BaseSalary]) VALUES (1, N'Wykładowca', 3500)
INSERT [dbo].[Workplaces] ([Id], [Name], [BaseSalary]) VALUES (2, N'Administrator sieci', 4200)
INSERT [dbo].[Workplaces] ([Id], [Name], [BaseSalary]) VALUES (3, N'Pracownik usług czystościowych', 1800)
INSERT [dbo].[Workplaces] ([Id], [Name], [BaseSalary]) VALUES (4, N'Nadzorca budynku', 2500)
SET IDENTITY_INSERT [dbo].[Workplaces] OFF
GO
ALTER TABLE [dbo].[FieldsOfStudy]  WITH CHECK ADD  CONSTRAINT [FK_FieldOfStudy_Worker] FOREIGN KEY([PatronWorkerId])
REFERENCES [dbo].[Workers] ([Id])
GO
ALTER TABLE [dbo].[FieldsOfStudy] CHECK CONSTRAINT [FK_FieldOfStudy_Worker]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Student_FieldOfStudy] FOREIGN KEY([FieldOfStudyId])
REFERENCES [dbo].[FieldsOfStudy] ([Id])
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Student_FieldOfStudy]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Student_ResidencePlace] FOREIGN KEY([ResidencePlaceId])
REFERENCES [dbo].[ResidencePlaces] ([Id])
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Student_ResidencePlace]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Student_StudyVintage] FOREIGN KEY([StudyVintageIdex])
REFERENCES [dbo].[StudyVintages] ([VIndex])
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Student_StudyVintage]
GO
ALTER TABLE [dbo].[StudyVintages]  WITH CHECK ADD  CONSTRAINT [FK_StudyVintage_Student] FOREIGN KEY([YearPatronSIndex])
REFERENCES [dbo].[Students] ([SIndex])
GO
ALTER TABLE [dbo].[StudyVintages] CHECK CONSTRAINT [FK_StudyVintage_Student]
GO
ALTER TABLE [dbo].[SubjectGroups]  WITH CHECK ADD  CONSTRAINT [FK_SubjectGroup_Subject] FOREIGN KEY([SubjectId])
REFERENCES [dbo].[Subjects] ([Id])
GO
ALTER TABLE [dbo].[SubjectGroups] CHECK CONSTRAINT [FK_SubjectGroup_Subject]
GO
ALTER TABLE [dbo].[SubjectGroups]  WITH CHECK ADD  CONSTRAINT [FK_SubjectGroup_Worker] FOREIGN KEY([WorkerId])
REFERENCES [dbo].[Workers] ([Id])
GO
ALTER TABLE [dbo].[SubjectGroups] CHECK CONSTRAINT [FK_SubjectGroup_Worker]
GO
ALTER TABLE [dbo].[Subjects]  WITH CHECK ADD  CONSTRAINT [FK_Subject_FieldOfStudy] FOREIGN KEY([FieldOfStudyId])
REFERENCES [dbo].[FieldsOfStudy] ([Id])
GO
ALTER TABLE [dbo].[Subjects] CHECK CONSTRAINT [FK_Subject_FieldOfStudy]
GO
ALTER TABLE [dbo].[Workers]  WITH CHECK ADD  CONSTRAINT [FK_Worker_ResidencePlace] FOREIGN KEY([ResidencePlaceId])
REFERENCES [dbo].[ResidencePlaces] ([Id])
GO
ALTER TABLE [dbo].[Workers] CHECK CONSTRAINT [FK_Worker_ResidencePlace]
GO
ALTER TABLE [dbo].[Workers]  WITH CHECK ADD  CONSTRAINT [FK_Worker_Workplace] FOREIGN KEY([WorkplaceId])
REFERENCES [dbo].[Workplaces] ([Id])
GO
ALTER TABLE [dbo].[Workers] CHECK CONSTRAINT [FK_Worker_Workplace]
GO
USE [master]
GO
ALTER DATABASE [UniversityFaculty] SET  READ_WRITE 
GO
