USE [master]
GO
/****** Object:  Database [CPE]    Script Date: 08/09/2013 12:36:58 ******/
CREATE DATABASE [CPE] ON  PRIMARY 
( NAME = N'CPE', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\CPE.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'CPE_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\CPE_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [CPE] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CPE].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CPE] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [CPE] SET ANSI_NULLS OFF
GO
ALTER DATABASE [CPE] SET ANSI_PADDING OFF
GO
ALTER DATABASE [CPE] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [CPE] SET ARITHABORT OFF
GO
ALTER DATABASE [CPE] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [CPE] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [CPE] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [CPE] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [CPE] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [CPE] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [CPE] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [CPE] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [CPE] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [CPE] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [CPE] SET  DISABLE_BROKER
GO
ALTER DATABASE [CPE] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [CPE] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [CPE] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [CPE] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [CPE] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [CPE] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [CPE] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [CPE] SET  READ_WRITE
GO
ALTER DATABASE [CPE] SET RECOVERY FULL
GO
ALTER DATABASE [CPE] SET  MULTI_USER
GO
ALTER DATABASE [CPE] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [CPE] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'CPE', N'ON'
GO
USE [CPE]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 08/09/2013 12:37:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuario](
	[Usuario_Codigo] [char](18) NOT NULL,
	[Usuario_Descripcion] [varchar](30) NOT NULL,
	[Usuario_Clave] [varchar](50) NOT NULL,
	[Usuario_Activo] [bit] NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[Usuario_Codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ParametroDet]    Script Date: 08/09/2013 12:37:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ParametroDet](
	[Parame_Codigo] [int] NOT NULL,
	[Pardet_Secuencia] [int] NOT NULL,
	[Pardet_Descripcion] [nvarchar](150) NOT NULL,
	[Pardet_Modificable] [bit] NOT NULL,
	[Parame_Padre] [int] NULL,
	[Pardet_Padre] [int] NULL,
	[Pardet_Visible] [bit] NULL,
 CONSTRAINT [PK_ParametroDet] PRIMARY KEY CLUSTERED 
(
	[Parame_Codigo] ASC,
	[Pardet_Secuencia] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Parametro]    Script Date: 08/09/2013 12:37:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Parametro](
	[Parame_Codigo] [int] NOT NULL,
	[Parame_Descripcion] [nvarchar](100) NOT NULL,
	[Parame_Modificable] [bit] NOT NULL,
	[Parame_Padre] [int] NULL,
 CONSTRAINT [PK_Parametro] PRIMARY KEY CLUSTERED 
(
	[Parame_Codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Entidad]    Script Date: 08/09/2013 12:37:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Entidad](
	[Entidad_Codigo] [int] IDENTITY(1,1) NOT NULL,
	[Entidad_Ruc] [varchar](15) NULL,
	[Entidad_RazonSocial] [varchar](50) NULL,
	[Entidad_NombreComercial] [varchar](50) NOT NULL,
	[Entidad_Telefono] [varchar](20) NULL,
	[Entidad_NombreContacto] [varchar](80) NULL,
	[Parame_Ciudad] [int] NULL,
	[Pardet_Ciudad] [int] NULL,
	[Parame_TipoEnt] [int] NOT NULL,
	[Pardet_TipoEnt] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Entidad_Codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Vehiculo]    Script Date: 08/09/2013 12:37:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Vehiculo](
	[Vehiculo_Codigo] [int] IDENTITY(1,1) NOT NULL,
	[Vehiculo_Descripcion] [varchar](25) NOT NULL,
	[Vehiculo_Placa] [varchar](10) NOT NULL,
	[Parame_Marca] [int] NOT NULL,
	[Pardet_Marca] [int] NOT NULL,
	[Parame_Modelo] [int] NOT NULL,
	[Pardet_Modelo] [int] NOT NULL,
	[Parame_SubModelo] [int] NOT NULL,
	[Pardet_SubModelo] [int] NOT NULL,
	[Vehiculo_Anio] [int] NOT NULL,
	[Vehiculo_NoMotor] [varchar](25) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Vehiculo_Codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Reclamo]    Script Date: 08/09/2013 12:37:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Reclamo](
	[Reclamo_Codigo] [int] IDENTITY(1,1) NOT NULL,
	[Reclamo_Numero] [varchar](25) NOT NULL,
	[CiaSeguros_Codigo] [int] NULL,
	[Parame_Ramo] [int] NOT NULL,
	[Pardet_Ramo] [int] NOT NULL,
	[Parame_Cobertura] [int] NOT NULL,
	[Pardet_Cobertura] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Reclamo_Codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Salvamento]    Script Date: 08/09/2013 12:37:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Salvamento](
	[Salvam_Codigo] [int] IDENTITY(1,1) NOT NULL,
	[Salvam_Descripcion] [varchar](150) NULL,
	[Salvam_Observacion] [varchar](250) NULL,
	[Vehiculo_Codigo] [int] NULL,
	[Parame_Marca] [int] NOT NULL,
	[Pardet_Marca] [int] NOT NULL,
	[Salvam_Modelo] [varchar](50) NULL,
	[Salvam_Serie] [varchar](80) NULL,
	[Reclamo_Codigo] [int] NOT NULL,
	[Taller_Codigo] [int] NULL,
	[Usuario_Codigo] [char](18) NOT NULL,
	[Salvam_FechaIngreso] [smalldatetime] NOT NULL,
	[Salvam_Imagen] [image] NULL,
 CONSTRAINT [PK__Salvamen__E426ECC032E0915F] PRIMARY KEY CLUSTERED 
(
	[Salvam_Codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  ForeignKey [FK_Entidad_ParametroDetCiudad]    Script Date: 08/09/2013 12:37:02 ******/
ALTER TABLE [dbo].[Entidad]  WITH CHECK ADD  CONSTRAINT [FK_Entidad_ParametroDetCiudad] FOREIGN KEY([Parame_Ciudad], [Pardet_Ciudad])
REFERENCES [dbo].[ParametroDet] ([Parame_Codigo], [Pardet_Secuencia])
GO
ALTER TABLE [dbo].[Entidad] CHECK CONSTRAINT [FK_Entidad_ParametroDetCiudad]
GO
/****** Object:  ForeignKey [FK_Entidad_ParametroDetTipoEnt]    Script Date: 08/09/2013 12:37:02 ******/
ALTER TABLE [dbo].[Entidad]  WITH CHECK ADD  CONSTRAINT [FK_Entidad_ParametroDetTipoEnt] FOREIGN KEY([Parame_TipoEnt], [Pardet_TipoEnt])
REFERENCES [dbo].[ParametroDet] ([Parame_Codigo], [Pardet_Secuencia])
GO
ALTER TABLE [dbo].[Entidad] CHECK CONSTRAINT [FK_Entidad_ParametroDetTipoEnt]
GO
/****** Object:  ForeignKey [FK_Vehiculo_ParametroDetMarca]    Script Date: 08/09/2013 12:37:02 ******/
ALTER TABLE [dbo].[Vehiculo]  WITH CHECK ADD  CONSTRAINT [FK_Vehiculo_ParametroDetMarca] FOREIGN KEY([Parame_Marca], [Pardet_Marca])
REFERENCES [dbo].[ParametroDet] ([Parame_Codigo], [Pardet_Secuencia])
GO
ALTER TABLE [dbo].[Vehiculo] CHECK CONSTRAINT [FK_Vehiculo_ParametroDetMarca]
GO
/****** Object:  ForeignKey [FK_Vehiculo_ParametroDetModelo]    Script Date: 08/09/2013 12:37:02 ******/
ALTER TABLE [dbo].[Vehiculo]  WITH CHECK ADD  CONSTRAINT [FK_Vehiculo_ParametroDetModelo] FOREIGN KEY([Parame_Modelo], [Pardet_Modelo])
REFERENCES [dbo].[ParametroDet] ([Parame_Codigo], [Pardet_Secuencia])
GO
ALTER TABLE [dbo].[Vehiculo] CHECK CONSTRAINT [FK_Vehiculo_ParametroDetModelo]
GO
/****** Object:  ForeignKey [FK_Vehiculo_ParametroDetSubMod]    Script Date: 08/09/2013 12:37:02 ******/
ALTER TABLE [dbo].[Vehiculo]  WITH CHECK ADD  CONSTRAINT [FK_Vehiculo_ParametroDetSubMod] FOREIGN KEY([Parame_SubModelo], [Pardet_SubModelo])
REFERENCES [dbo].[ParametroDet] ([Parame_Codigo], [Pardet_Secuencia])
GO
ALTER TABLE [dbo].[Vehiculo] CHECK CONSTRAINT [FK_Vehiculo_ParametroDetSubMod]
GO
/****** Object:  ForeignKey [FK_Reclamo_Entidad]    Script Date: 08/09/2013 12:37:02 ******/
ALTER TABLE [dbo].[Reclamo]  WITH CHECK ADD  CONSTRAINT [FK_Reclamo_Entidad] FOREIGN KEY([CiaSeguros_Codigo])
REFERENCES [dbo].[Entidad] ([Entidad_Codigo])
GO
ALTER TABLE [dbo].[Reclamo] CHECK CONSTRAINT [FK_Reclamo_Entidad]
GO
/****** Object:  ForeignKey [FK_Reclamo_ParametroDetCobert]    Script Date: 08/09/2013 12:37:02 ******/
ALTER TABLE [dbo].[Reclamo]  WITH CHECK ADD  CONSTRAINT [FK_Reclamo_ParametroDetCobert] FOREIGN KEY([Parame_Cobertura], [Pardet_Cobertura])
REFERENCES [dbo].[ParametroDet] ([Parame_Codigo], [Pardet_Secuencia])
GO
ALTER TABLE [dbo].[Reclamo] CHECK CONSTRAINT [FK_Reclamo_ParametroDetCobert]
GO
/****** Object:  ForeignKey [FK_Reclamo_ParametroDetRamo]    Script Date: 08/09/2013 12:37:02 ******/
ALTER TABLE [dbo].[Reclamo]  WITH CHECK ADD  CONSTRAINT [FK_Reclamo_ParametroDetRamo] FOREIGN KEY([Parame_Ramo], [Pardet_Ramo])
REFERENCES [dbo].[ParametroDet] ([Parame_Codigo], [Pardet_Secuencia])
GO
ALTER TABLE [dbo].[Reclamo] CHECK CONSTRAINT [FK_Reclamo_ParametroDetRamo]
GO
/****** Object:  ForeignKey [FK_Salvamento_Entidad]    Script Date: 08/09/2013 12:37:02 ******/
ALTER TABLE [dbo].[Salvamento]  WITH CHECK ADD  CONSTRAINT [FK_Salvamento_Entidad] FOREIGN KEY([Taller_Codigo])
REFERENCES [dbo].[Entidad] ([Entidad_Codigo])
GO
ALTER TABLE [dbo].[Salvamento] CHECK CONSTRAINT [FK_Salvamento_Entidad]
GO
/****** Object:  ForeignKey [FK_Salvamento_ParametroDetMarca]    Script Date: 08/09/2013 12:37:02 ******/
ALTER TABLE [dbo].[Salvamento]  WITH CHECK ADD  CONSTRAINT [FK_Salvamento_ParametroDetMarca] FOREIGN KEY([Parame_Marca], [Pardet_Marca])
REFERENCES [dbo].[ParametroDet] ([Parame_Codigo], [Pardet_Secuencia])
GO
ALTER TABLE [dbo].[Salvamento] CHECK CONSTRAINT [FK_Salvamento_ParametroDetMarca]
GO
/****** Object:  ForeignKey [FK_Salvamento_Reclamo]    Script Date: 08/09/2013 12:37:02 ******/
ALTER TABLE [dbo].[Salvamento]  WITH CHECK ADD  CONSTRAINT [FK_Salvamento_Reclamo] FOREIGN KEY([Reclamo_Codigo])
REFERENCES [dbo].[Reclamo] ([Reclamo_Codigo])
GO
ALTER TABLE [dbo].[Salvamento] CHECK CONSTRAINT [FK_Salvamento_Reclamo]
GO
/****** Object:  ForeignKey [FK_Salvamento_Usuario]    Script Date: 08/09/2013 12:37:02 ******/
ALTER TABLE [dbo].[Salvamento]  WITH CHECK ADD  CONSTRAINT [FK_Salvamento_Usuario] FOREIGN KEY([Usuario_Codigo])
REFERENCES [dbo].[Usuario] ([Usuario_Codigo])
GO
ALTER TABLE [dbo].[Salvamento] CHECK CONSTRAINT [FK_Salvamento_Usuario]
GO
