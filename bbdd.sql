USE [master]
GO
DROP DATABASE [ACOES]
/****** Object:  Database [ACOES]    Script Date: 03/01/2019 13:43:16 ******/
CREATE DATABASE [ACOES]
GO
ALTER DATABASE [ACOES] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ACOES] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ACOES] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ACOES] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ACOES] SET ARITHABORT OFF 
GO
ALTER DATABASE [ACOES] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ACOES] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ACOES] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ACOES] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ACOES] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ACOES] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ACOES] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ACOES] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ACOES] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ACOES] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ACOES] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ACOES] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ACOES] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ACOES] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ACOES] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ACOES] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ACOES] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ACOES] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ACOES] SET  MULTI_USER 
GO
ALTER DATABASE [ACOES] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ACOES] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ACOES] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ACOES] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [ACOES] SET DELAYED_DURABILITY = DISABLED 
GO
USE [ACOES]
GO
/****** Object:  Table [dbo].[Beneficiario]    Script Date: 03/01/2019 13:43:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Beneficiario](
	[codigo] [varchar](10) NOT NULL,
	[nombre] [varchar](100) NOT NULL,
	[apellidos] [varchar](50) NULL,
	[observaciones] [varchar](250) NULL,
	[responsable] [varchar](50) NOT NULL,
	[tipo] [varchar](50) NULL,
	[numCuenta] [varchar](50) NULL,
 CONSTRAINT [PK_Beneficiario_1] PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Calificacion]    Script Date: 03/01/2019 13:43:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Calificacion](
	[beneficiario] [int] NOT NULL,
	[nota] [int] NOT NULL,
	[asignatura] [varchar](50) NOT NULL,
	[fecha] [date] NOT NULL,
 CONSTRAINT [PK_Calificacion] PRIMARY KEY CLUSTERED 
(
	[beneficiario] ASC,
	[asignatura] ASC,
	[fecha] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Ninio]    Script Date: 03/01/2019 13:43:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ninio](
	[codigo] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellidos] [varchar](100) NULL,
	[estado] [varchar](50) NULL,
	[beca] [varchar](100) NULL,
	[sexo] [varchar](50) NOT NULL,
	[agente] [varchar](50) NULL,
	[fechaNacimiento] [date] NULL,
	[fechaEntradaAcoes] [date] NULL,
	[proyecto] [int] NULL,
	[fechaEntradaProyecto] [date] NULL,
	[fechaSalidaProyecto] [date] NULL,
	[fechaAlta] [date] NULL,
	[fechaSalidaAcoes] [date] NULL,
	[curso] [varchar](50) NULL,
	[comunidadProc] [varchar](50) NULL,
	[comunidadAct] [varchar](50) NULL,
	[observaciones] [varchar](100) NULL,
 CONSTRAINT [PK_Beneficiario] PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Proyecto]    Script Date: 03/01/2019 13:43:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Proyecto](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[tipo_proyecto] [varchar](50) NOT NULL,
	[coordinador] [varchar](50) NOT NULL,
	[responsable] [varchar](50) NOT NULL,
	[localidad] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Proyecto] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Socio]    Script Date: 03/01/2019 13:43:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Socio](
	[codigo] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellidos] [varchar](50) NULL,
	[estado] [varchar](50) NULL,
	[nif] [varchar](50) NULL,
	[direccion] [varchar](50) NULL,
	[poblacion] [varchar](50) NULL,
	[codigoPostal] [nchar](10) NULL,
	[provincia] [varchar](50) NULL,
	[tlf] [nchar](10) NOT NULL,
	[tlfSecundario] [nchar](10) NULL,
	[email] [varchar](50) NULL,
	[agente] [varchar](50) NOT NULL,
	[relacion] [varchar](50) NULL,
	[certificado] [bit] NULL,
	[sector] [varchar](50) NULL,
	[fechaAlta] [datetime] NULL,
	[fechaBaja] [datetime] NULL,
	[observaciones] [varchar](250) NULL,
	[numCuenta] [varchar](50) NULL,
 CONSTRAINT [PK_Socio] PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TipoProyecto]    Script Date: 03/01/2019 13:43:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipoProyecto](
	[nombre] [varchar](50) NOT NULL,
	[descripcion] [varchar](300) NOT NULL,
	[coordinador] [varchar](50) NOT NULL,
	[responsable] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TipoProyecto] PRIMARY KEY CLUSTERED 
(
	[nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 03/01/2019 13:43:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuario](
	[nif] [varchar](50) NOT NULL,
	[alias] [varchar](50) NULL,
	[contraseña] [varchar](50) NULL,
	[correo] [varchar](50) NULL,
	[rol] [varchar](50) NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[nif] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Beneficiario]  WITH CHECK ADD  CONSTRAINT [FK_Beneficiario_Usuario1] FOREIGN KEY([responsable])
REFERENCES [dbo].[Usuario] ([nif])
GO
ALTER TABLE [dbo].[Beneficiario] CHECK CONSTRAINT [FK_Beneficiario_Usuario1]
GO
ALTER TABLE [dbo].[Calificacion]  WITH CHECK ADD  CONSTRAINT [FK_Calificacion_Beneficiario] FOREIGN KEY([beneficiario])
REFERENCES [dbo].[Ninio] ([codigo])
GO
ALTER TABLE [dbo].[Calificacion] CHECK CONSTRAINT [FK_Calificacion_Beneficiario]
GO
ALTER TABLE [dbo].[Ninio]  WITH CHECK ADD  CONSTRAINT [FK_Beneficiario_Proyecto] FOREIGN KEY([proyecto])
REFERENCES [dbo].[Proyecto] ([id])
GO
ALTER TABLE [dbo].[Ninio] CHECK CONSTRAINT [FK_Beneficiario_Proyecto]
GO
ALTER TABLE [dbo].[Ninio]  WITH CHECK ADD  CONSTRAINT [FK_Beneficiario_Usuario] FOREIGN KEY([agente])
REFERENCES [dbo].[Usuario] ([nif])
GO
ALTER TABLE [dbo].[Ninio] CHECK CONSTRAINT [FK_Beneficiario_Usuario]
GO
ALTER TABLE [dbo].[Proyecto]  WITH CHECK ADD  CONSTRAINT [FK_Proyecto_Coordinador] FOREIGN KEY([coordinador])
REFERENCES [dbo].[Usuario] ([nif])
GO
ALTER TABLE [dbo].[Proyecto] CHECK CONSTRAINT [FK_Proyecto_Coordinador]
GO
ALTER TABLE [dbo].[Proyecto]  WITH CHECK ADD  CONSTRAINT [FK_Proyecto_Responsable] FOREIGN KEY([responsable])
REFERENCES [dbo].[Usuario] ([nif])
GO
ALTER TABLE [dbo].[Proyecto] CHECK CONSTRAINT [FK_Proyecto_Responsable]
GO
ALTER TABLE [dbo].[Proyecto]  WITH CHECK ADD  CONSTRAINT [FK_Proyecto_TipoProyecto] FOREIGN KEY([tipo_proyecto])
REFERENCES [dbo].[TipoProyecto] ([nombre])
GO
ALTER TABLE [dbo].[Proyecto] CHECK CONSTRAINT [FK_Proyecto_TipoProyecto]
GO
ALTER TABLE [dbo].[Socio]  WITH CHECK ADD  CONSTRAINT [FK_Socio_Usuario] FOREIGN KEY([agente])
REFERENCES [dbo].[Usuario] ([nif])
GO
ALTER TABLE [dbo].[Socio] CHECK CONSTRAINT [FK_Socio_Usuario]
GO
ALTER TABLE [dbo].[TipoProyecto]  WITH CHECK ADD  CONSTRAINT [FK_TipoProyecto_Coordinador] FOREIGN KEY([coordinador])
REFERENCES [dbo].[Usuario] ([nif])
GO
ALTER TABLE [dbo].[TipoProyecto] CHECK CONSTRAINT [FK_TipoProyecto_Coordinador]
GO
ALTER TABLE [dbo].[TipoProyecto]  WITH CHECK ADD  CONSTRAINT [FK_TipoProyecto_Responsable] FOREIGN KEY([responsable])
REFERENCES [dbo].[Usuario] ([nif])
GO
ALTER TABLE [dbo].[TipoProyecto] CHECK CONSTRAINT [FK_TipoProyecto_Responsable]
GO
USE [master]
GO
ALTER DATABASE [ACOES] SET  READ_WRITE 
GO
