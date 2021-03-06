USE [master]
GO
/****** Object:  Database [TorneoCSGO]    Script Date: 18/11/2021 17:06:06 ******/
CREATE DATABASE [TorneoCSGO]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TorneoCSGO', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\TorneoCSGO.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TorneoCSGO_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\TorneoCSGO_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [TorneoCSGO] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TorneoCSGO].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TorneoCSGO] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TorneoCSGO] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TorneoCSGO] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TorneoCSGO] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TorneoCSGO] SET ARITHABORT OFF 
GO
ALTER DATABASE [TorneoCSGO] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TorneoCSGO] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TorneoCSGO] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TorneoCSGO] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TorneoCSGO] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TorneoCSGO] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TorneoCSGO] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TorneoCSGO] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TorneoCSGO] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TorneoCSGO] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TorneoCSGO] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TorneoCSGO] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TorneoCSGO] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TorneoCSGO] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TorneoCSGO] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TorneoCSGO] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TorneoCSGO] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TorneoCSGO] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TorneoCSGO] SET  MULTI_USER 
GO
ALTER DATABASE [TorneoCSGO] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TorneoCSGO] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TorneoCSGO] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TorneoCSGO] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TorneoCSGO] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TorneoCSGO] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [TorneoCSGO] SET QUERY_STORE = OFF
GO
USE [TorneoCSGO]
GO
/****** Object:  Table [dbo].[Jugadores]    Script Date: 18/11/2021 17:06:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Jugadores](
	[Id] [int] NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Edad] [int] NOT NULL,
	[Genero] [nchar](10) NOT NULL,
	[Nacionalidad] [nvarchar](50) NOT NULL,
	[Especialidad] [nchar](10) NOT NULL,
	[PrimerTorneo] [bit] NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (1, N'Fan', 57, N'Male      ', N'China', N'XL        ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (2, N'Rafi', 27, N'Male      ', N'France', N'M         ', 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (3, N'Aubrey', 41, N'Female    ', N'China', N'L         ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (4, N'Hernando', 57, N'Female    ', N'China', N'XL        ', 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (5, N'Etheline', 16, N'Male      ', N'United States', N'XXL       ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (6, N'Natal', 41, N'Male      ', N'China', N'XL        ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (7, N'Leonerd', 53, N'Female    ', N'Denmark', N'S         ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (8, N'Sukey', 60, N'Female    ', N'France', N'XXL       ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (9, N'Barb', 50, N'Female    ', N'China', N'S         ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (10, N'Ivett', 21, N'Female    ', N'China', N'L         ', 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (11, N'Buddy', 23, N'Male      ', N'China', N'XS        ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (12, N'Berti', 41, N'Male      ', N'Canada', N'XXL       ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (13, N'Herve', 40, N'Male      ', N'Russia', N'XL        ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (14, N'Chrystal', 20, N'Female    ', N'Canada', N'XXL       ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (15, N'Vi', 42, N'Female    ', N'China', N'XXL       ', 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (16, N'Fergus', 27, N'Male      ', N'Colombia', N'XXL       ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (17, N'Berkeley', 51, N'Male      ', N'China', N'XL        ', 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (18, N'Thoma', 55, N'Male      ', N'China', N'XL        ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (19, N'Gabrila', 51, N'Male      ', N'China', N'XL        ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (20, N'Alwyn', 36, N'Female    ', N'Australia', N'S         ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (21, N'Lisette', 46, N'Female    ', N'Russia', N'XS        ', 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (22, N'Fanya', 59, N'Male      ', N'Uruguay', N'S         ', 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (23, N'Constantine', 14, N'Female    ', N'China', N'S         ', 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (24, N'Paloma', 12, N'Female    ', N'Netherlands', N'XL        ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (25, N'Phedra', 54, N'Female    ', N'China', N'XL        ', 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (26, N'Pieter', 46, N'Male      ', N'United States', N'S         ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (27, N'Cosetta', 40, N'Female    ', N'Peru', N'XL        ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (28, N'Vinni', 30, N'Male      ', N'Brazil', N'XS        ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (29, N'Lyell', 35, N'Male      ', N'China', N'XL        ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (30, N'Loralie', 46, N'Male      ', N'Mexico', N'XXL       ', 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (31, N'Jania', 55, N'Female    ', N'Canada', N'XS        ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (32, N'Brew', 35, N'Female    ', N'China', N'M         ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (33, N'Carlyle', 46, N'Female    ', N'China', N'S         ', 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (34, N'Cecil', 36, N'Male      ', N'Mexico', N'XS        ', 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (35, N'Adham', 20, N'Male      ', N'China', N'XL        ', 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (36, N'Bryana', 32, N'Male      ', N'France', N'XL        ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (37, N'Wood', 36, N'Male      ', N'China', N'XL        ', 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (38, N'Ashely', 16, N'Male      ', N'China', N'XXL       ', 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (39, N'Sella', 22, N'Male      ', N'China', N'XL        ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (40, N'Keven', 57, N'Male      ', N'Russia', N'XL        ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (41, N'Ricky', 51, N'Female    ', N'United States', N'XXL       ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (42, N'Lalo', 40, N'Male      ', N'Japan', N'S         ', 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (43, N'Jedediah', 12, N'Male      ', N'Argentina', N'XL        ', 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (44, N'Farrell', 50, N'Female    ', N'China', N'XL        ', 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (45, N'Danette', 57, N'Male      ', N'Canada', N'XS        ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (46, N'Juli', 39, N'Male      ', N'Brazil', N'L         ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (47, N'Wolfie', 23, N'Female    ', N'France', N'XL        ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (48, N'Gianna', 60, N'Male      ', N'Finland', N'M         ', 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (49, N'Elle', 28, N'Female    ', N'China', N'XL        ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (50, N'Davon', 20, N'Female    ', N'Argentina', N'XL        ', 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (51, N'April', 37, N'Male      ', N'Japan', N'S         ', 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (52, N'Marcel', 56, N'Male      ', N'Russia', N'L         ', 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (53, N'Jacquelyn', 58, N'Male      ', N'Brazil', N'XS        ', 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (54, N'Damian', 13, N'Female    ', N'Mexico', N'S         ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (55, N'Shurlock', 33, N'Female    ', N'South Korea', N'M         ', 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (56, N'Price', 43, N'Female    ', N'United States', N'XS        ', 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (57, N'Kayne', 41, N'Female    ', N'China', N'L         ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (58, N'Julita', 32, N'Male      ', N'China', N'S         ', 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (59, N'Roselin', 27, N'Male      ', N'China', N'XL        ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (60, N'Gerrard', 39, N'Female    ', N'China', N'XL        ', 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (61, N'Reynolds', 19, N'Male      ', N'France', N'M         ', 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (62, N'Emmalyn', 46, N'Female    ', N'China', N'M         ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (63, N'Roanna', 34, N'Male      ', N'France', N'XXL       ', 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (64, N'Heath', 55, N'Female    ', N'Peru', N'M         ', 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (65, N'Helga', 44, N'Male      ', N'China', N'XL        ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (66, N'Lindie', 31, N'Male      ', N'China', N'XL        ', 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (67, N'Ilene', 55, N'Male      ', N'China', N'XXL       ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (68, N'Kevina', 16, N'Female    ', N'China', N'XS        ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (69, N'Idalina', 50, N'Male      ', N'Mexico', N'XXL       ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (70, N'Inge', 18, N'Male      ', N'China', N'XS        ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (71, N'Dyanna', 30, N'Male      ', N'Brazil', N'XL        ', 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (72, N'Erl', 16, N'Male      ', N'United States', N'XL        ', 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (73, N'Tybie', 51, N'Male      ', N'Russia', N'M         ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (74, N'Ula', 41, N'Female    ', N'Spain', N'XS        ', 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (75, N'Cassandre', 54, N'Female    ', N'United States', N'XS        ', 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (76, N'Georgeanne', 40, N'Female    ', N'China', N'XS        ', 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (77, N'Iormina', 22, N'Female    ', N'France', N'S         ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (78, N'Manon', 16, N'Female    ', N'China', N'L         ', 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (79, N'Melodie', 57, N'Female    ', N'China', N'L         ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (80, N'Jeannine', 26, N'Male      ', N'China', N'XS        ', 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (81, N'Antonino', 56, N'Male      ', N'China', N'XL        ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (82, N'Jerrie', 15, N'Female    ', N'United Kingdom', N'S         ', 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (83, N'Burke', 52, N'Male      ', N'France', N'S         ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (84, N'Jillayne', 16, N'Female    ', N'China', N'XS        ', 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (85, N'Paula', 53, N'Female    ', N'Canada', N'XL        ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (86, N'Klaus', 53, N'Male      ', N'Russia', N'XL        ', 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (87, N'Peadar', 50, N'Female    ', N'Brazil', N'XL        ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (88, N'Reena', 30, N'Male      ', N'China', N'S         ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (89, N'Mignon', 51, N'Male      ', N'China', N'XXL       ', 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (90, N'Filmore', 55, N'Male      ', N'Peru', N'L         ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (91, N'Dolph', 18, N'Male      ', N'Brazil', N'S         ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (92, N'Merrel', 17, N'Male      ', N'China', N'M         ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (93, N'Binny', 53, N'Female    ', N'China', N'M         ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (94, N'Cassey', 40, N'Female    ', N'China', N'S         ', 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (95, N'Aldin', 41, N'Female    ', N'United States', N'XS        ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (96, N'Phillipe', 38, N'Female    ', N'Japan', N'L         ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (97, N'Xylia', 18, N'Female    ', N'China', N'XL        ', 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (98, N'Chrotoem', 60, N'Male      ', N'Chile', N'XL        ', 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (99, N'Ailee', 35, N'Female    ', N'China', N'XL        ', 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (100, N'Karlene', 47, N'Male      ', N'United States', N'XS        ', 0)
GO
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (101, N'Addie', 58, N'Female    ', N'China', N'XL        ', 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (102, N'Alexia', 43, N'Male      ', N'Russia', N'M         ', 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (103, N'Noami', 33, N'Female    ', N'Japan', N'L         ', 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (104, N'Mallorie', 43, N'Male      ', N'South Korea', N'XXL       ', 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (105, N'Gilda', 23, N'Female    ', N'China', N'XL        ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (106, N'Arny', 23, N'Female    ', N'China', N'XL        ', 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (107, N'Say', 22, N'Female    ', N'China', N'S         ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (108, N'Samantha', 14, N'Female    ', N'Russia', N'L         ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (109, N'Sherill', 24, N'Male      ', N'China', N'M         ', 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (110, N'Inger', 29, N'Male      ', N'China', N'XL        ', 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (111, N'Kristofer', 19, N'Female    ', N'China', N'XS        ', 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (112, N'Corey', 39, N'Male      ', N'China', N'L         ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (113, N'Katherina', 45, N'Female    ', N'Japan', N'S         ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (114, N'Raviv', 50, N'Male      ', N'Russia', N'XL        ', 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (115, N'Van', 53, N'Female    ', N'China', N'XS        ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (116, N'Geri', 27, N'Female    ', N'China', N'XL        ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (117, N'Kelci', 20, N'Female    ', N'China', N'L         ', 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (118, N'Abeu', 35, N'Male      ', N'China', N'L         ', 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (119, N'Lynn', 34, N'Male      ', N'Brazil', N'XXL       ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (120, N'Sydel', 31, N'Female    ', N'France', N'S         ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (121, N'Benedikta', 25, N'Female    ', N'Italy', N'L         ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (122, N'Jeremiah', 18, N'Male      ', N'Canada', N'XL        ', 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (123, N'Avery', 30, N'Male      ', N'Brazil', N'XL        ', 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (124, N'Dolli', 53, N'Female    ', N'China', N'L         ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (125, N'Shaylynn', 35, N'Male      ', N'New Zealand', N'S         ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (126, N'Sabra', 45, N'Female    ', N'Brazil', N'XL        ', 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (127, N'Eddie', 50, N'Female    ', N'China', N'XL        ', 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (128, N'Fleur', 23, N'Male      ', N'Russia', N'S         ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (129, N'Aline', 47, N'Male      ', N'China', N'XXL       ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (130, N'Karlene', 60, N'Female    ', N'United States', N'XL        ', 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (131, N'Ludovico', 38, N'Female    ', N'China', N'L         ', 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (132, N'Tadd', 18, N'Male      ', N'Norway', N'XL        ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (133, N'Ingrid', 38, N'Female    ', N'China', N'L         ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (134, N'Tressa', 50, N'Male      ', N'China', N'XS        ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (135, N'Kennedy', 40, N'Male      ', N'United States', N'S         ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (136, N'Cecil', 47, N'Female    ', N'Russia', N'S         ', 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (137, N'Nicolis', 33, N'Female    ', N'China', N'XL        ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (138, N'Thorsten', 51, N'Female    ', N'China', N'XXL       ', 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (139, N'Gaspard', 37, N'Female    ', N'Netherlands', N'L         ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (140, N'Nicolai', 54, N'Male      ', N'China', N'M         ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (141, N'Patten', 29, N'Male      ', N'Spain', N'L         ', 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (142, N'Aylmar', 42, N'Female    ', N'China', N'XXL       ', 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (143, N'Margaret', 38, N'Female    ', N'Colombia', N'XL        ', 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (144, N'Julie', 56, N'Female    ', N'China', N'M         ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (145, N'Drud', 26, N'Male      ', N'Russia', N'S         ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (146, N'Laird', 49, N'Male      ', N'Finland', N'L         ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (147, N'Gussy', 39, N'Male      ', N'Uruguay', N'XL        ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (148, N'Brandon', 58, N'Male      ', N'China', N'XL        ', 0)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (149, N'Velma', 46, N'Female    ', N'China', N'M         ', 1)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [Edad], [Genero], [Nacionalidad], [Especialidad], [PrimerTorneo]) VALUES (150, N'Saw', 44, N'Female    ', N'China', N'XXL       ', 1)
GO
USE [master]
GO
ALTER DATABASE [TorneoCSGO] SET  READ_WRITE 
GO
