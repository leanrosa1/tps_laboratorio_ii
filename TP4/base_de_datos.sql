USE [master]
GO
/****** Object:  Database [Leandro_Rosa_TP4]    Script Date: 18/6/2022 3:02:50 p. m. ******/
CREATE DATABASE [Leandro_Rosa_TP4]

ALTER DATABASE [Leandro_Rosa_TP4] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Leandro_Rosa_TP4].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Leandro_Rosa_TP4] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Leandro_Rosa_TP4] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Leandro_Rosa_TP4] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Leandro_Rosa_TP4] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Leandro_Rosa_TP4] SET ARITHABORT OFF 
GO
ALTER DATABASE [Leandro_Rosa_TP4] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Leandro_Rosa_TP4] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Leandro_Rosa_TP4] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Leandro_Rosa_TP4] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Leandro_Rosa_TP4] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Leandro_Rosa_TP4] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Leandro_Rosa_TP4] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Leandro_Rosa_TP4] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Leandro_Rosa_TP4] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Leandro_Rosa_TP4] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Leandro_Rosa_TP4] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Leandro_Rosa_TP4] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Leandro_Rosa_TP4] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Leandro_Rosa_TP4] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Leandro_Rosa_TP4] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Leandro_Rosa_TP4] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Leandro_Rosa_TP4] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Leandro_Rosa_TP4] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Leandro_Rosa_TP4] SET  MULTI_USER 
GO
ALTER DATABASE [Leandro_Rosa_TP4] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Leandro_Rosa_TP4] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Leandro_Rosa_TP4] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Leandro_Rosa_TP4] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Leandro_Rosa_TP4] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Leandro_Rosa_TP4] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Leandro_Rosa_TP4] SET QUERY_STORE = OFF
GO
USE [Leandro_Rosa_TP4]
GO
/****** Object:  Table [dbo].[Reclamos]    Script Date: 18/6/2022 3:02:51 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reclamos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[EmpleadoNombre] [varchar](150) NOT NULL,
	[EmpleadoDni] [int] NULL,
	[Identificador] [uniqueidentifier] NOT NULL,
	[Observacion] [varchar](500) NOT NULL,
	[Tipo] [int] NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Reclamos] ON 

INSERT [dbo].[Reclamos] ([Id], [Fecha], [EmpleadoNombre], [EmpleadoDni], [Identificador], [Observacion], [Tipo]) VALUES (4, CAST(N'2022-06-18T00:00:00.000' AS DateTime), N'Leandro Rosa', 41737160, N'59f92f10-0dac-4d11-9299-a88069513a5c', N'Se necesita podar arbol', 0)
INSERT [dbo].[Reclamos] ([Id], [Fecha], [EmpleadoNombre], [EmpleadoDni], [Identificador], [Observacion], [Tipo]) VALUES (5, CAST(N'2022-06-18T00:00:00.000' AS DateTime), N'Leandro Rosa', 41737160, N'59f92f10-0dac-4d11-9299-a88069513a5d', N'Se cayo el palo de luz', 1)
INSERT [dbo].[Reclamos] ([Id], [Fecha], [EmpleadoNombre], [EmpleadoDni], [Identificador], [Observacion], [Tipo]) VALUES (6, CAST(N'2022-06-18T00:00:00.000' AS DateTime), N'Leandro Rosa', 41737160, N'59f92f10-0dac-4d11-9299-a88069513a5e', N'Hay fiestas clandestinas', 2)
INSERT [dbo].[Reclamos] ([Id], [Fecha], [EmpleadoNombre], [EmpleadoDni], [Identificador], [Observacion], [Tipo]) VALUES (7, CAST(N'2022-06-18T00:00:00.000' AS DateTime), N'Leandro Rosa', 41737160, N'59f92f10-0dac-4d11-9299-a88069513a5f', N'Tienen un perro con rabia', 3)
SET IDENTITY_INSERT [dbo].[Reclamos] OFF
GO
USE [master]
GO
ALTER DATABASE [Leandro_Rosa_TP4] SET  READ_WRITE 
GO
