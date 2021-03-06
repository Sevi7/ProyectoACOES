USE [master]
GO
/****** Object:  Database [ACOES]    Script Date: 24-Jan-19 23:57:43 ******/
DROP DATABASE [ACOES]
GO
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
/****** Object:  Table [dbo].[Apadrinamiento]    Script Date: 24-Jan-19 23:57:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Apadrinamiento](
	[socio] [int] NOT NULL,
	[ninio] [int] NOT NULL,
	[agente] [varchar](50) NOT NULL,
	[dinero] [int] NOT NULL,
	[eliminado] [bit] NOT NULL,
 CONSTRAINT [PK_Apadrinamiento] PRIMARY KEY CLUSTERED 
(
	[socio] ASC,
	[ninio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Beneficiario]    Script Date: 24-Jan-19 23:57:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Beneficiario](
	[NIF] [varchar](10) NOT NULL,
	[nombre] [varchar](100) NOT NULL,
	[apellidos] [varchar](50) NULL,
	[observaciones] [varchar](250) NULL,
	[responsable] [varchar](50) NOT NULL,
	[numCuenta] [varchar](50) NULL,
	[eliminado] [bit] NOT NULL,
 CONSTRAINT [PK_Beneficiario_1] PRIMARY KEY CLUSTERED 
(
	[NIF] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Calificacion]    Script Date: 24-Jan-19 23:57:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Calificacion](
	[ninio] [int] NOT NULL,
	[nota] [int] NOT NULL,
	[asignatura] [varchar](50) NOT NULL,
	[fecha] [date] NOT NULL,
 CONSTRAINT [PK_Calificacion] PRIMARY KEY CLUSTERED 
(
	[ninio] ASC,
	[asignatura] ASC,
	[fecha] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Comunidad]    Script Date: 24-Jan-19 23:57:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Comunidad](
	[nombre] [varchar](50) NOT NULL,
	[descripcion] [varchar](250) NULL,
 CONSTRAINT [PK_Comunidad] PRIMARY KEY CLUSTERED 
(
	[nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Cuenta]    Script Date: 24-Jan-19 23:57:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cuenta](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[tipo] [varchar](50) NULL,
	[nombre] [varchar](50) NULL,
	[categoria] [varchar](50) NULL,
	[cantidad] [numeric](18, 0) NULL,
	[fecha] [date] NULL,
	[descripcion] [varchar](200) NULL,
	[validado] [bit] NULL,
 CONSTRAINT [PK_Cuenta] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CuentaProyecto]    Script Date: 24-Jan-19 23:57:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CuentaProyecto](
	[id] [int] NOT NULL,
	[cuenta] [int] NOT NULL,
 CONSTRAINT [PK_CuentaProyecto] PRIMARY KEY CLUSTERED 
(
	[id] ASC,
	[cuenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CuentaTipoProyecto]    Script Date: 24-Jan-19 23:57:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CuentaTipoProyecto](
	[cuenta] [int] NOT NULL,
	[tipoProyecto] [varchar](50) NOT NULL,
 CONSTRAINT [PK_CuentaTipoProyecto] PRIMARY KEY CLUSTERED 
(
	[cuenta] ASC,
	[tipoProyecto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Envio]    Script Date: 24-Jan-19 23:57:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Envio](
	[remitente] [varchar](50) NOT NULL,
	[socio] [int] NOT NULL,
	[niño] [int] NOT NULL,
	[etiqueta] [varchar](50) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Ninio]    Script Date: 24-Jan-19 23:57:43 ******/
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
	[eliminado] [bit] NOT NULL,
 CONSTRAINT [PK_Beneficiario] PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Proyecto]    Script Date: 24-Jan-19 23:57:43 ******/
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
/****** Object:  Table [dbo].[Socio]    Script Date: 24-Jan-19 23:57:43 ******/
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
	[codigoPostal] [int] NULL,
	[provincia] [varchar](50) NULL,
	[tlf] [int] NOT NULL,
	[tlfSecundario] [int] NULL,
	[email] [varchar](50) NULL,
	[agente] [varchar](50) NOT NULL,
	[relacion] [varchar](50) NULL,
	[certificado] [bit] NULL,
	[sector] [varchar](50) NULL,
	[fechaAlta] [date] NULL,
	[fechaBaja] [date] NULL,
	[observaciones] [varchar](250) NULL,
	[numCuenta] [varchar](50) NULL,
	[eliminado] [bit] NOT NULL,
 CONSTRAINT [PK_Socio] PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Socio_Proyecto]    Script Date: 24-Jan-19 23:57:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Socio_Proyecto](
	[socio] [int] NOT NULL,
	[proyecto] [int] NOT NULL,
 CONSTRAINT [PK_Socio_Proyecto] PRIMARY KEY CLUSTERED 
(
	[socio] ASC,
	[proyecto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Socio_TipoProyecto]    Script Date: 24-Jan-19 23:57:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Socio_TipoProyecto](
	[socio] [int] NOT NULL,
	[tipoProyecto] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Socio_TipoProyecto] PRIMARY KEY CLUSTERED 
(
	[socio] ASC,
	[tipoProyecto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TipoProyecto]    Script Date: 24-Jan-19 23:57:43 ******/
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
/****** Object:  Table [dbo].[Usuario]    Script Date: 24-Jan-19 23:57:43 ******/
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
ALTER TABLE [dbo].[Apadrinamiento]  WITH CHECK ADD  CONSTRAINT [FK_Apadrinamiento_Ninio] FOREIGN KEY([ninio])
REFERENCES [dbo].[Ninio] ([codigo])
GO
ALTER TABLE [dbo].[Apadrinamiento] CHECK CONSTRAINT [FK_Apadrinamiento_Ninio]
GO
ALTER TABLE [dbo].[Apadrinamiento]  WITH CHECK ADD  CONSTRAINT [FK_Apadrinamiento_Socio] FOREIGN KEY([socio])
REFERENCES [dbo].[Socio] ([codigo])
GO
ALTER TABLE [dbo].[Apadrinamiento] CHECK CONSTRAINT [FK_Apadrinamiento_Socio]
GO
ALTER TABLE [dbo].[Apadrinamiento]  WITH CHECK ADD  CONSTRAINT [FK_Apadrinamiento_Usuario] FOREIGN KEY([agente])
REFERENCES [dbo].[Usuario] ([nif])
GO
ALTER TABLE [dbo].[Apadrinamiento] CHECK CONSTRAINT [FK_Apadrinamiento_Usuario]
GO
ALTER TABLE [dbo].[Beneficiario]  WITH CHECK ADD  CONSTRAINT [FK_Beneficiario_Usuario1] FOREIGN KEY([responsable])
REFERENCES [dbo].[Usuario] ([nif])
GO
ALTER TABLE [dbo].[Beneficiario] CHECK CONSTRAINT [FK_Beneficiario_Usuario1]
GO
ALTER TABLE [dbo].[Calificacion]  WITH CHECK ADD  CONSTRAINT [FK_Calificacion_Beneficiario] FOREIGN KEY([ninio])
REFERENCES [dbo].[Ninio] ([codigo])
GO
ALTER TABLE [dbo].[Calificacion] CHECK CONSTRAINT [FK_Calificacion_Beneficiario]
GO
ALTER TABLE [dbo].[CuentaProyecto]  WITH CHECK ADD  CONSTRAINT [FK_CuentaProyecto_Cuenta] FOREIGN KEY([cuenta])
REFERENCES [dbo].[Cuenta] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CuentaProyecto] CHECK CONSTRAINT [FK_CuentaProyecto_Cuenta]
GO
ALTER TABLE [dbo].[CuentaProyecto]  WITH CHECK ADD  CONSTRAINT [FK_CuentaProyecto_Proyecto] FOREIGN KEY([id])
REFERENCES [dbo].[Proyecto] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CuentaProyecto] CHECK CONSTRAINT [FK_CuentaProyecto_Proyecto]
GO
ALTER TABLE [dbo].[CuentaTipoProyecto]  WITH CHECK ADD  CONSTRAINT [FK_CuentaTipoProyecto_Cuenta] FOREIGN KEY([cuenta])
REFERENCES [dbo].[Cuenta] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CuentaTipoProyecto] CHECK CONSTRAINT [FK_CuentaTipoProyecto_Cuenta]
GO
ALTER TABLE [dbo].[CuentaTipoProyecto]  WITH CHECK ADD  CONSTRAINT [FK_CuentaTipoProyecto_TipoProyecto] FOREIGN KEY([tipoProyecto])
REFERENCES [dbo].[TipoProyecto] ([nombre])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CuentaTipoProyecto] CHECK CONSTRAINT [FK_CuentaTipoProyecto_TipoProyecto]
GO
ALTER TABLE [dbo].[Envio]  WITH CHECK ADD  CONSTRAINT [FK_Envio_Ninio] FOREIGN KEY([niño])
REFERENCES [dbo].[Ninio] ([codigo])
GO
ALTER TABLE [dbo].[Envio] CHECK CONSTRAINT [FK_Envio_Ninio]
GO
ALTER TABLE [dbo].[Envio]  WITH CHECK ADD  CONSTRAINT [FK_Envio_Socio] FOREIGN KEY([socio])
REFERENCES [dbo].[Socio] ([codigo])
GO
ALTER TABLE [dbo].[Envio] CHECK CONSTRAINT [FK_Envio_Socio]
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
ALTER TABLE [dbo].[Socio_Proyecto]  WITH CHECK ADD  CONSTRAINT [FK_Socio_Proyecto_Proyecto] FOREIGN KEY([proyecto])
REFERENCES [dbo].[Proyecto] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Socio_Proyecto] CHECK CONSTRAINT [FK_Socio_Proyecto_Proyecto]
GO
ALTER TABLE [dbo].[Socio_Proyecto]  WITH CHECK ADD  CONSTRAINT [FK_Socio_Proyecto_Socio] FOREIGN KEY([socio])
REFERENCES [dbo].[Socio] ([codigo])
GO
ALTER TABLE [dbo].[Socio_Proyecto] CHECK CONSTRAINT [FK_Socio_Proyecto_Socio]
GO
ALTER TABLE [dbo].[Socio_TipoProyecto]  WITH CHECK ADD  CONSTRAINT [FK_Socio_TipoProyecto_Socio] FOREIGN KEY([socio])
REFERENCES [dbo].[Socio] ([codigo])
GO
ALTER TABLE [dbo].[Socio_TipoProyecto] CHECK CONSTRAINT [FK_Socio_TipoProyecto_Socio]
GO
ALTER TABLE [dbo].[Socio_TipoProyecto]  WITH CHECK ADD  CONSTRAINT [FK_Socio_TipoProyecto_TipoProyecto] FOREIGN KEY([tipoProyecto])
REFERENCES [dbo].[TipoProyecto] ([nombre])
GO
ALTER TABLE [dbo].[Socio_TipoProyecto] CHECK CONSTRAINT [FK_Socio_TipoProyecto_TipoProyecto]
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
