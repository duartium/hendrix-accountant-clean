USE [master]
GO
/****** Object:  Database [HENDRIX]    Script Date: 15/01/2021 0:35:46 ******/
CREATE DATABASE [HENDRIX]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HENDRIX', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\HENDRIX.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'HENDRIX_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\HENDRIX_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [HENDRIX] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HENDRIX].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HENDRIX] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HENDRIX] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HENDRIX] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HENDRIX] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HENDRIX] SET ARITHABORT OFF 
GO
ALTER DATABASE [HENDRIX] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HENDRIX] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HENDRIX] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HENDRIX] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HENDRIX] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HENDRIX] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HENDRIX] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HENDRIX] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HENDRIX] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HENDRIX] SET  DISABLE_BROKER 
GO
ALTER DATABASE [HENDRIX] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HENDRIX] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HENDRIX] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HENDRIX] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HENDRIX] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HENDRIX] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HENDRIX] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HENDRIX] SET RECOVERY FULL 
GO
ALTER DATABASE [HENDRIX] SET  MULTI_USER 
GO
ALTER DATABASE [HENDRIX] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HENDRIX] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HENDRIX] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HENDRIX] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [HENDRIX] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'HENDRIX', N'ON'
GO
ALTER DATABASE [HENDRIX] SET QUERY_STORE = OFF
GO
USE [HENDRIX]
GO
/****** Object:  Schema [accounting]    Script Date: 15/01/2021 0:35:46 ******/
CREATE SCHEMA [accounting]
GO
/****** Object:  Schema [auth]    Script Date: 15/01/2021 0:35:46 ******/
CREATE SCHEMA [auth]
GO
/****** Object:  Schema [inventory]    Script Date: 15/01/2021 0:35:46 ******/
CREATE SCHEMA [inventory]
GO
/****** Object:  Schema [management]    Script Date: 15/01/2021 0:35:46 ******/
CREATE SCHEMA [management]
GO
/****** Object:  Table [auth].[ACCIONES]    Script Date: 15/01/2021 0:35:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [auth].[ACCIONES](
	[id_accion] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NOT NULL,
	[modulo_id] [int] NOT NULL,
 CONSTRAINT [PK_ACCIONES] PRIMARY KEY CLUSTERED 
(
	[id_accion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [auth].[MODULOS]    Script Date: 15/01/2021 0:35:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [auth].[MODULOS](
	[id_modulo] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NOT NULL,
 CONSTRAINT [PK_MODULOS] PRIMARY KEY CLUSTERED 
(
	[id_modulo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [auth].[ROLES]    Script Date: 15/01/2021 0:35:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [auth].[ROLES](
	[id_rol] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[descripcion] [varchar](150) NOT NULL,
	[creado_en] [datetime] NULL,
	[usuario_crea] [varchar](20) NULL,
	[modificado_en] [datetime] NULL,
	[usuario_mod] [varchar](20) NULL,
	[eliminado_en] [datetime] NULL,
	[usuario_elim] [varchar](20) NULL,
 CONSTRAINT [PK_ROLES] PRIMARY KEY CLUSTERED 
(
	[id_rol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [auth].[USUARIOS]    Script Date: 15/01/2021 0:35:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [auth].[USUARIOS](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[usuario] [varchar](20) NOT NULL,
	[clave] [varchar](300) NOT NULL,
	[estado] [bit] NOT NULL,
	[rol_id] [int] NOT NULL,
	[creado_en] [datetime] NOT NULL,
	[usuario_crea] [varchar](20) NOT NULL,
	[modificado_en] [datetime] NULL,
	[usuario_mod] [varchar](20) NULL,
	[eliminado_en] [datetime] NULL,
	[usuario_elim] [varchar](20) NULL,
 CONSTRAINT [PK_USUARIOS] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CAJA]    Script Date: 15/01/2021 0:35:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CAJA](
	[id_caja] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NULL,
	[tema] [varchar](50) NULL,
	[serial_pc] [varchar](50) NULL,
	[impresora_ticket] [varchar](max) NULL,
	[impresora_a4] [varchar](max) NULL,
	[usuario_crea] [varchar](20) NOT NULL,
	[creado_en] [datetime] NOT NULL,
	[modificado_en] [datetime] NULL,
	[usuario_mod] [varchar](20) NULL,
	[eliminado_en] [datetime] NULL,
	[usuario_elim] [varchar](20) NULL,
 CONSTRAINT [PK_CAJA] PRIMARY KEY CLUSTERED 
(
	[id_caja] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FACTURA]    Script Date: 15/01/2021 0:35:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FACTURA](
	[id_factura] [int] IDENTITY(1,1) NOT NULL,
	[cliente_id] [int] NOT NULL,
	[usuario_id] [int] NOT NULL,
	[fecha_emision] [datetime] NOT NULL,
	[base_imponible] [decimal](10, 2) NOT NULL,
	[iva] [decimal](10, 2) NOT NULL,
	[total] [decimal](10, 2) NOT NULL,
	[estado] [bit] NOT NULL,
	[usuario_crea] [varchar](20) NOT NULL,
	[creado_en] [datetime] NOT NULL,
	[usuario_mod] [varchar](20) NULL,
	[modificado_en] [datetime] NULL,
	[usuario_elim] [varchar](20) NULL,
	[eliminado_en] [datetime] NULL,
 CONSTRAINT [PK_FACTURA] PRIMARY KEY CLUSTERED 
(
	[id_factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FACTURA_DETALLE]    Script Date: 15/01/2021 0:35:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FACTURA_DETALLE](
	[id_factura_detalle] [int] IDENTITY(1,1) NOT NULL,
	[factura_id] [int] NOT NULL,
	[producto_id] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
	[precio_unitario] [decimal](10, 2) NOT NULL,
	[descuento] [decimal](10, 2) NOT NULL,
	[estado] [bit] NOT NULL,
 CONSTRAINT [PK_FACTURA_DETALLE] PRIMARY KEY CLUSTERED 
(
	[id_factura_detalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MOVIMIENTOS_CAJA]    Script Date: 15/01/2021 0:35:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MOVIMIENTOS_CAJA](
	[id_movimiento] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [datetime] NOT NULL,
	[tipo_movimiento] [smallint] NULL,
	[ingresos] [decimal](10, 2) NULL,
	[egresos] [decimal](10, 2) NULL,
	[saldo] [decimal](10, 2) NULL,
	[usuario_id] [int] NOT NULL,
	[caja_id] [int] NOT NULL,
 CONSTRAINT [PK_MOVIMIENTOS_CAJA] PRIMARY KEY CLUSTERED 
(
	[id_movimiento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ROL_ACCION]    Script Date: 15/01/2021 0:35:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ROL_ACCION](
	[id_rol_accion] [int] IDENTITY(1,1) NOT NULL,
	[rol_id] [int] NOT NULL,
	[accion_id] [int] NOT NULL,
 CONSTRAINT [PK_ROL_ACCION] PRIMARY KEY CLUSTERED 
(
	[id_rol_accion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VENTAS]    Script Date: 15/01/2021 0:35:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VENTAS](
	[id_venta] [int] NOT NULL,
	[cliente_id] [int] NOT NULL,
	[usuario_id] [int] NOT NULL,
	[factura_id] [int] NOT NULL,
	[fecha] [datetime] NOT NULL,
	[usuario_crea] [varchar](20) NOT NULL,
	[creado_en] [datetime] NOT NULL,
	[usuario_mod] [varchar](20) NULL,
	[modificado_en] [datetime] NULL,
	[usuario_elim] [varchar](20) NULL,
	[elminado_en] [datetime] NULL,
 CONSTRAINT [PK_VENTAS] PRIMARY KEY CLUSTERED 
(
	[id_venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [inventory].[PRODUCTOS]    Script Date: 15/01/2021 0:35:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [inventory].[PRODUCTOS](
	[id_producto] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NOT NULL,
	[descripcion] [varchar](150) NULL,
	[costo] [decimal](10, 2) NOT NULL,
	[precio_venta] [nchar](10) NOT NULL,
	[stock] [int] NOT NULL,
	[descuento] [decimal](10, 2) NULL,
	[talla] [int] NULL,
	[marca] [int] NULL,
	[color] [int] NULL,
	[estado] [bit] NOT NULL,
	[categoria_id] [int] NULL,
	[proveedor_id] [int] NOT NULL,
	[creado_en] [datetime] NOT NULL,
	[usuario_crea] [varchar](20) NOT NULL,
	[modificado_en] [datetime] NULL,
	[usuario_mod] [varchar](20) NULL,
	[eliminado_en] [datetime] NULL,
	[usuario_elim] [varchar](20) NULL,
 CONSTRAINT [PK_PRODUCTOS] PRIMARY KEY CLUSTERED 
(
	[id_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [management].[CATALOGOS]    Script Date: 15/01/2021 0:35:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [management].[CATALOGOS](
	[id_catalogo] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[descripcion] [varchar](100) NOT NULL,
	[tipo] [int] NOT NULL,
	[estado] [bit] NOT NULL,
	[creado_en] [datetime] NOT NULL,
	[usuario_crea] [varchar](20) NOT NULL,
	[modificado_en] [datetime] NULL,
	[usuario_mod] [varchar](20) NULL,
	[eliminado_en] [datetime] NULL,
	[usuario_elim] [varchar](20) NULL,
 CONSTRAINT [PK_CATALOGOS] PRIMARY KEY CLUSTERED 
(
	[id_catalogo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [management].[CLIENTES]    Script Date: 15/01/2021 0:35:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [management].[CLIENTES](
	[id_cliente] [int] IDENTITY(1,1) NOT NULL,
	[identificacion] [varchar](13) NOT NULL,
	[tipo_identificacion] [char](1) NOT NULL,
	[tipo_cliente] [char](1) NOT NULL,
	[nombres] [varchar](100) NOT NULL,
	[apellidos] [varchar](100) NOT NULL,
	[telefono] [varchar](10) NULL,
	[celular] [varchar](10) NULL,
	[direccion] [varchar](100) NULL,
	[email] [varchar](100) NULL,
	[estado] [bit] NOT NULL,
	[usuario_crea] [varchar](30) NOT NULL,
	[creado_en] [datetime] NOT NULL,
	[usuario_mod] [varchar](30) NULL,
	[modificado_en] [datetime] NULL,
	[usuario_elim] [varchar](30) NULL,
	[eliminado_en] [datetime] NULL,
 CONSTRAINT [PK_CLIENTES] PRIMARY KEY CLUSTERED 
(
	[id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [management].[ITEM_CATALOGO]    Script Date: 15/01/2021 0:35:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [management].[ITEM_CATALOGO](
	[id_item_catalogo] [int] IDENTITY(1,1) NOT NULL,
	[codigo] [varchar](8) NOT NULL,
	[descripcion] [varchar](100) NOT NULL,
	[estado] [bit] NOT NULL,
	[creado_en] [datetime] NOT NULL,
	[usuario_crea] [varchar](20) NOT NULL,
	[modificado_en] [datetime] NULL,
	[usuario_mod] [varchar](20) NULL,
	[eliminado_en] [datetime] NULL,
	[usuario_elim] [varchar](20) NULL,
	[catalogo_id] [int] NULL,
 CONSTRAINT [PK_ITEM_CATALOGO] PRIMARY KEY CLUSTERED 
(
	[id_item_catalogo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [auth].[MODULOS] ON 

INSERT [auth].[MODULOS] ([id_modulo], [nombre]) VALUES (1, N'USUARIOS')
INSERT [auth].[MODULOS] ([id_modulo], [nombre]) VALUES (2, N'INVENTARIO')
INSERT [auth].[MODULOS] ([id_modulo], [nombre]) VALUES (3, N'VENTA')
INSERT [auth].[MODULOS] ([id_modulo], [nombre]) VALUES (4, N'CAJA')
INSERT [auth].[MODULOS] ([id_modulo], [nombre]) VALUES (5, N'ROLES')
SET IDENTITY_INSERT [auth].[MODULOS] OFF
SET IDENTITY_INSERT [auth].[ROLES] ON 

INSERT [auth].[ROLES] ([id_rol], [nombre], [descripcion], [creado_en], [usuario_crea], [modificado_en], [usuario_mod], [eliminado_en], [usuario_elim]) VALUES (1, N'administrador', N'Nivel de permiso más alto de la jerarquía del sistema', CAST(N'2021-01-06T00:00:00.000' AS DateTime), N'bduarte', NULL, NULL, NULL, NULL)
INSERT [auth].[ROLES] ([id_rol], [nombre], [descripcion], [creado_en], [usuario_crea], [modificado_en], [usuario_mod], [eliminado_en], [usuario_elim]) VALUES (3, N'cajero', N'Operador de caja', CAST(N'2021-01-06T00:00:00.000' AS DateTime), N'bduarte', NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [auth].[ROLES] OFF
SET IDENTITY_INSERT [auth].[USUARIOS] ON 

INSERT [auth].[USUARIOS] ([id_usuario], [usuario], [clave], [estado], [rol_id], [creado_en], [usuario_crea], [modificado_en], [usuario_mod], [eliminado_en], [usuario_elim]) VALUES (1, N'bduarte', N'ef797c8118f02dfb649607dd5d3f8c7623048c9c063d532cc95c5ed7a898a64f', 1, 1, CAST(N'2020-01-06T00:00:00.000' AS DateTime), N'bduarte', NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [auth].[USUARIOS] OFF
SET IDENTITY_INSERT [dbo].[CAJA] ON 

INSERT [dbo].[CAJA] ([id_caja], [descripcion], [tema], [serial_pc], [impresora_ticket], [impresora_a4], [usuario_crea], [creado_en], [modificado_en], [usuario_mod], [eliminado_en], [usuario_elim]) VALUES (2, N'caja principal', NULL, N'PHUFHE21WC8VRP', NULL, NULL, N'bduarte', CAST(N'2021-01-09T21:17:00.000' AS DateTime), NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[CAJA] OFF
SET IDENTITY_INSERT [dbo].[MOVIMIENTOS_CAJA] ON 

INSERT [dbo].[MOVIMIENTOS_CAJA] ([id_movimiento], [fecha], [tipo_movimiento], [ingresos], [egresos], [saldo], [usuario_id], [caja_id]) VALUES (1, CAST(N'2021-01-10T14:54:46.750' AS DateTime), 1, NULL, NULL, CAST(0.00 AS Decimal(10, 2)), 1, 2)
INSERT [dbo].[MOVIMIENTOS_CAJA] ([id_movimiento], [fecha], [tipo_movimiento], [ingresos], [egresos], [saldo], [usuario_id], [caja_id]) VALUES (2, CAST(N'2021-01-10T15:53:30.460' AS DateTime), 1, NULL, NULL, CAST(9155.00 AS Decimal(10, 2)), 1, 2)
INSERT [dbo].[MOVIMIENTOS_CAJA] ([id_movimiento], [fecha], [tipo_movimiento], [ingresos], [egresos], [saldo], [usuario_id], [caja_id]) VALUES (3, CAST(N'2021-01-10T16:10:27.500' AS DateTime), 1, NULL, NULL, CAST(5300.00 AS Decimal(10, 2)), 1, 2)
SET IDENTITY_INSERT [dbo].[MOVIMIENTOS_CAJA] OFF
SET IDENTITY_INSERT [inventory].[PRODUCTOS] ON 

INSERT [inventory].[PRODUCTOS] ([id_producto], [nombre], [descripcion], [costo], [precio_venta], [stock], [descuento], [talla], [marca], [color], [estado], [categoria_id], [proveedor_id], [creado_en], [usuario_crea], [modificado_en], [usuario_mod], [eliminado_en], [usuario_elim]) VALUES (1, N'Camiseta polo hombre de algodón', N'colección caballeros', CAST(25.00 AS Decimal(10, 2)), N'40,00     ', 36, NULL, 1, NULL, 2, 1, 1, 1, CAST(N'2020-12-14T21:14:00.000' AS DateTime), N'bduarte', NULL, NULL, NULL, NULL)
INSERT [inventory].[PRODUCTOS] ([id_producto], [nombre], [descripcion], [costo], [precio_venta], [stock], [descuento], [talla], [marca], [color], [estado], [categoria_id], [proveedor_id], [creado_en], [usuario_crea], [modificado_en], [usuario_mod], [eliminado_en], [usuario_elim]) VALUES (3, N'Pantalón jean skynny ', N'pull n bear', CAST(30.40 AS Decimal(10, 2)), N'47,92     ', 40, NULL, 2, NULL, 3, 1, 2, 2, CAST(N'2020-12-14T21:16:00.000' AS DateTime), N'bduarte', NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [inventory].[PRODUCTOS] OFF
SET IDENTITY_INSERT [management].[CLIENTES] ON 

INSERT [management].[CLIENTES] ([id_cliente], [identificacion], [tipo_identificacion], [tipo_cliente], [nombres], [apellidos], [telefono], [celular], [direccion], [email], [estado], [usuario_crea], [creado_en], [usuario_mod], [modificado_en], [usuario_elim], [eliminado_en]) VALUES (1, N'1206384651', N'1', N'1', N'Byron Andrés', N'Duarte Morejon', NULL, N'0981603421', N'Cdla Atarazana - Av plaza dañin', N'byronduarte95@gmail.com', 1, N'bduarte', CAST(N'2020-12-13T12:02:00.000' AS DateTime), NULL, NULL, NULL, NULL)
INSERT [management].[CLIENTES] ([id_cliente], [identificacion], [tipo_identificacion], [tipo_cliente], [nombres], [apellidos], [telefono], [celular], [direccion], [email], [estado], [usuario_crea], [creado_en], [usuario_mod], [modificado_en], [usuario_elim], [eliminado_en]) VALUES (3, N'1203953474', N'1', N'1', N'Mayensi Yunin', N'Kuffo Gonzales', N'2734470', N'0987877265', N'Av. Las Americas 128EF', N'mkuffo1993@outlook.es', 1, N'bduarte', CAST(N'2020-01-11T23:45:00.000' AS DateTime), NULL, NULL, NULL, NULL)
INSERT [management].[CLIENTES] ([id_cliente], [identificacion], [tipo_identificacion], [tipo_cliente], [nombres], [apellidos], [telefono], [celular], [direccion], [email], [estado], [usuario_crea], [creado_en], [usuario_mod], [modificado_en], [usuario_elim], [eliminado_en]) VALUES (4, N'0927894785', N'1', N'1', N'Maylin Lorena', N'Rodriguez Vera', N'', N'0989209812', N'Cdla. Urdesa Central', N'maylinkuffo91.me@outlook.com', 1, N'bduarte', CAST(N'2021-01-11T23:49:00.000' AS DateTime), NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [management].[CLIENTES] OFF
ALTER TABLE [auth].[ACCIONES]  WITH CHECK ADD  CONSTRAINT [FK_ACCIONES_MODULOS] FOREIGN KEY([modulo_id])
REFERENCES [auth].[MODULOS] ([id_modulo])
GO
ALTER TABLE [auth].[ACCIONES] CHECK CONSTRAINT [FK_ACCIONES_MODULOS]
GO
ALTER TABLE [auth].[USUARIOS]  WITH CHECK ADD  CONSTRAINT [FK_USUARIOS_ROLES] FOREIGN KEY([rol_id])
REFERENCES [auth].[ROLES] ([id_rol])
GO
ALTER TABLE [auth].[USUARIOS] CHECK CONSTRAINT [FK_USUARIOS_ROLES]
GO
ALTER TABLE [dbo].[FACTURA_DETALLE]  WITH CHECK ADD  CONSTRAINT [FK_FACTURA_DETALLE_FACTURA] FOREIGN KEY([factura_id])
REFERENCES [dbo].[FACTURA] ([id_factura])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[FACTURA_DETALLE] CHECK CONSTRAINT [FK_FACTURA_DETALLE_FACTURA]
GO
ALTER TABLE [dbo].[MOVIMIENTOS_CAJA]  WITH CHECK ADD  CONSTRAINT [FK_MOVIMIENTOS_CAJA_CAJA] FOREIGN KEY([caja_id])
REFERENCES [dbo].[CAJA] ([id_caja])
GO
ALTER TABLE [dbo].[MOVIMIENTOS_CAJA] CHECK CONSTRAINT [FK_MOVIMIENTOS_CAJA_CAJA]
GO
ALTER TABLE [dbo].[MOVIMIENTOS_CAJA]  WITH CHECK ADD  CONSTRAINT [FK_MOVIMIENTOS_CAJA_USUARIOS] FOREIGN KEY([usuario_id])
REFERENCES [auth].[USUARIOS] ([id_usuario])
GO
ALTER TABLE [dbo].[MOVIMIENTOS_CAJA] CHECK CONSTRAINT [FK_MOVIMIENTOS_CAJA_USUARIOS]
GO
ALTER TABLE [dbo].[ROL_ACCION]  WITH CHECK ADD  CONSTRAINT [FK_ROL_ACCION_ACCIONES] FOREIGN KEY([accion_id])
REFERENCES [auth].[ACCIONES] ([id_accion])
GO
ALTER TABLE [dbo].[ROL_ACCION] CHECK CONSTRAINT [FK_ROL_ACCION_ACCIONES]
GO
ALTER TABLE [management].[ITEM_CATALOGO]  WITH CHECK ADD  CONSTRAINT [FK_CATALOGO_ITEM_CATALOGO] FOREIGN KEY([catalogo_id])
REFERENCES [management].[CATALOGOS] ([id_catalogo])
GO
ALTER TABLE [management].[ITEM_CATALOGO] CHECK CONSTRAINT [FK_CATALOGO_ITEM_CATALOGO]
GO
/****** Object:  StoredProcedure [dbo].[SP_CASH_FLOW]    Script Date: 15/01/2021 0:35:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/************************************************************************
 *    Archivo Físico:      SP_CASH_FLOW.sql                     *
 *    Stored procedure:    SP_CASH_FLOW                         *
 *    Base de datos:       HENDRIX        			                	*
 *    Elaborado por:       Byron Duarte                                 *
 *----------------------------------------------------------------------*
 *                   DESCRIPCION DEL PROCEDIMIENTO                      *
 *    Implementa el mantenimiento de clientes del sistema               *
 *----------------------------------------------------------------------*
 *                     BITACORA DE MODIFICACIONES                       *
 *      FECHA        AUTOR            RAZON                             *
 *----------------------------------------------------------------------*/
CREATE PROCEDURE [dbo].[SP_CASH_FLOW]
	@accion char(1),
    @usuario varchar(20),
	@tipo_movimiento int,
	@saldo decimal,
	@serial varchar(50)
AS
BEGIN
	DECLARE @fecha_actual datetime = GETDATE(),
			@usuario_id int,
			@caja_id int

	IF @accion='I'
	BEGIN
		SELECT @usuario_id=id_usuario FROM auth.USUARIOS WHERE usuario=@usuario

		SELECT @caja_id=id_caja FROM CAJA WHERE serial_pc=@serial

		INSERT INTO MOVIMIENTOS_CAJA(
				fecha,			tipo_movimiento,		ingresos, 
				egresos,		saldo,					usuario_id,			caja_id)
		 VALUES(@fecha_actual, @tipo_movimiento,		NULL,
				NULL,			@saldo,					@usuario_id,		@caja_id)
    END
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTA_CLIENTES]    Script Date: 15/01/2021 0:35:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/************************************************************************
 *    Archivo Físico:      SP_CONSULTA_CLIENTES.sql                     *
 *    Stored procedure:    SP_CONSULTA_CLIENTES                         *
 *    Base de datos:       HENDRIX        			                	*
 *    Elaborado por:       Byron Duarte                                 *
 *----------------------------------------------------------------------*
 *                   DESCRIPCION DEL PROCEDIMIENTO                      *
 *    Implementa el mantenimiento de clientes del sistema               *
 *----------------------------------------------------------------------*
 *                     BITACORA DE MODIFICACIONES                       *
 *      FECHA        AUTOR            RAZON                             *
 *----------------------------------------------------------------------*/
CREATE PROCEDURE [dbo].[SP_CONSULTA_CLIENTES]
	@accion char(1),
    @usuario varchar(20) = NULL,
    @tipo_consulta int = 0,
    @id_cliente int = 0,
	@identificacion int = 0,
	@nombres varchar(100) = NULL,
	@apellidos varchar(100) = NULL
AS
    DECLARE @fecha_actual datetime = GETDATE()
    
    --consulta de clientes por grupo
	IF(@accion = 'G')
    BEGIN
        SELECT TOP 25
			c.id_cliente,				c.identificacion,				c.tipo_identificacion,
			c.tipo_cliente,				c.nombres,						c.apellidos,
			c.telefono,					c.celular,
			c.direccion,				c.email
		FROM management.CLIENTES c
        WHERE estado = 1
    END
    --consulta individual de cliente
    ELSE IF(@accion = 'C')
    BEGIN 
		--consulta por número de identificación
		IF(@tipo_consulta = 1) 
			SELECT
				c.id_cliente,				c.identificacion,				c.tipo_identificacion,
				c.tipo_cliente,				c.nombres,						c.apellidos,
				c.telefono,					c.celular,
				c.direccion,				c.email
			FROM management.CLIENTES c
			WHERE estado = 1 AND identificacion = @identificacion
		--consulta por nombres
		--HERE
		--consulta por apellidos
		--HERE
    END
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTA_PRODUCTOS]    Script Date: 15/01/2021 0:35:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/************************************************************************
 *    Archivo Físico:      SP_CONSULTA_PRODUCTOS.sql                    *
 *    Stored procedure:    SP_CONSULTA_PRODUCTOS                        *
 *    Base de datos:       HENDRIX        			                	*
 *    Elaborado por:       Byron Duarte                                 *
 *----------------------------------------------------------------------*
 *                   DESCRIPCION DEL PROCEDIMIENTO                      *
 *    Implementa el mantenimiento de clientes del sistema               *
 *----------------------------------------------------------------------*
 *                     BITACORA DE MODIFICACIONES                       *
 *      FECHA        AUTOR            RAZON                             *
 *----------------------------------------------------------------------*/

--IF exists (select * from sysobjects where name = 'SP_CONSULTA_PRODUCTOS')
--   drop proc dbo.SP_CONSULTA_PRODUCTOS
CREATE PROCEDURE [dbo].[SP_CONSULTA_PRODUCTOS]
	@accion char(1),
    @usuario int = 0
AS
    DECLARE @fecha_actual datetime = GETDATE()
    
    --consulta de clientes por grupo
	IF(@accion = 'G')
    BEGIN
        SELECT TOP 25
			p.id_producto,				p.nombre,				p.descripcion,
			p.stock,					p.precio_venta precio,			ISNULL(p.marca, 0) marca, 
			p.categoria_id categoria		
		FROM inventory.PRODUCTOS p
        WHERE estado = 1
    END
GO
/****** Object:  StoredProcedure [dbo].[SP_REGISTER_SALE]    Script Date: 15/01/2021 0:35:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/************************************************************************
 *    Archivo Físico:      SP_REGISTER_SALE.sql                         *
 *    Stored procedure:    SP_REGISTER_SALE                             *
 *    Base de datos:       HENDRIX        			                	*
 *    Elaborado por:       Byron Duarte                                 *
 *----------------------------------------------------------------------*
 *                   DESCRIPCION DEL PROCEDIMIENTO                      *
 *    Implementa el mantenimiento de clientes del sistema               *
 *----------------------------------------------------------------------*
 *                     BITACORA DE MODIFICACIONES                       *
 *      FECHA        AUTOR            RAZON                             *
 *----------------------------------------------------------------------*/
CREATE PROCEDURE [dbo].[SP_REGISTER_SALE]
	@accion char(1),
    @id_usuario int = 0,
	@usuario varchar(20),
	@factura xml
AS
BEGIN
	DECLARE @fecha_actual datetime = GETDATE()

	IF @accion='I'
	BEGIN
		SELECT * FROM FACTURA
		--REGISTRO DE VENTA
    END
END
GO
/****** Object:  StoredProcedure [dbo].[SP_USER_ATHENTICATION]    Script Date: 15/01/2021 0:35:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/************************************************************************
 *    Archivo Físico:      SP_CONSULTA_CLIENTES.sql                     *
 *    Stored procedure:    SP_CONSULTA_CLIENTES                         *
 *    Base de datos:       HENDRIX        			                	*
 *    Elaborado por:       Byron Duarte                                 *
 *----------------------------------------------------------------------*
 *                   DESCRIPCION DEL PROCEDIMIENTO                      *
 *    Implementa el mantenimiento de clientes del sistema               *
 *----------------------------------------------------------------------*
 *                     BITACORA DE MODIFICACIONES                       *
 *      FECHA        AUTOR            RAZON                             *
 *----------------------------------------------------------------------*/
CREATE PROCEDURE [dbo].[SP_USER_ATHENTICATION]
	@accion char(1),
    @usuario int = 0,
    @username varchar(20) = 0,
    @password varchar(150) = 0
AS
	IF(@accion = 'C')
    BEGIN
        SELECT COUNT(1) AS RESP
		FROM auth.USUARIOS u
		WHERE usuario = ISNULL(@username, '') AND  clave = ISNULL(@password, '')
    END
GO
USE [master]
GO
ALTER DATABASE [HENDRIX] SET  READ_WRITE 
GO
