USE [master]
GO
/****** Object:  Database [HOTELKARPAS]    Script Date: 15/4/2024 23:42:23 ******/
CREATE DATABASE [HOTELKARPAS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HOTELKARPAS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\HOTELKARPAS.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'HOTELKARPAS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\HOTELKARPAS_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [HOTELKARPAS] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HOTELKARPAS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HOTELKARPAS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HOTELKARPAS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HOTELKARPAS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HOTELKARPAS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HOTELKARPAS] SET ARITHABORT OFF 
GO
ALTER DATABASE [HOTELKARPAS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HOTELKARPAS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HOTELKARPAS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HOTELKARPAS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HOTELKARPAS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HOTELKARPAS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HOTELKARPAS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HOTELKARPAS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HOTELKARPAS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HOTELKARPAS] SET  ENABLE_BROKER 
GO
ALTER DATABASE [HOTELKARPAS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HOTELKARPAS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HOTELKARPAS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HOTELKARPAS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HOTELKARPAS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HOTELKARPAS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HOTELKARPAS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HOTELKARPAS] SET RECOVERY FULL 
GO
ALTER DATABASE [HOTELKARPAS] SET  MULTI_USER 
GO
ALTER DATABASE [HOTELKARPAS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HOTELKARPAS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HOTELKARPAS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HOTELKARPAS] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [HOTELKARPAS] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [HOTELKARPAS] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'HOTELKARPAS', N'ON'
GO
ALTER DATABASE [HOTELKARPAS] SET QUERY_STORE = ON
GO
ALTER DATABASE [HOTELKARPAS] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [HOTELKARPAS]
GO
/****** Object:  Table [dbo].[BitacoraLogin]    Script Date: 15/4/2024 23:42:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BitacoraLogin](
	[fechaLogin] [datetime] NULL,
	[idCuenta] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 15/4/2024 23:42:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[idCliente] [int] NOT NULL,
	[paisProcedencia] [varchar](200) NOT NULL,
	[telefono] [int] NOT NULL,
	[correoElectronico] [varchar](200) NOT NULL,
	[nombre] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cuenta]    Script Date: 15/4/2024 23:42:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cuenta](
	[idUsuario] [int] NOT NULL,
	[idCuenta] [int] NOT NULL,
	[pasword] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idCuenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Habitacion]    Script Date: 15/4/2024 23:42:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Habitacion](
	[idHabitacion] [int] NOT NULL,
	[tipo] [varchar](50) NOT NULL,
	[precio] [decimal](32, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idHabitacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reserva]    Script Date: 15/4/2024 23:42:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reserva](
	[idReserva] [int] NOT NULL,
	[idCliente] [int] NOT NULL,
	[estadoReserva] [varchar](50) NOT NULL,
	[fechaEntrada] [date] NOT NULL,
	[fechaSalida] [date] NOT NULL,
	[idHabitacion] [int] NOT NULL,
	[descuentoAplicado] [bit] NOT NULL,
	[precioTotal] [decimal](33, 2) NOT NULL,
	[idUsuario] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idReserva] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rol]    Script Date: 15/4/2024 23:42:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rol](
	[idRol] [int] NOT NULL,
	[nombreRol] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idRol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 15/4/2024 23:42:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[idUsuario] [int] NOT NULL,
	[nombreCompleto] [varchar](150) NOT NULL,
	[fechaNacimiento] [date] NOT NULL,
	[direccionVivienda] [varchar](200) NOT NULL,
	[email] [varchar](100) NOT NULL,
	[numTell] [int] NOT NULL,
	[genero] [varchar](2) NOT NULL,
	[idRol] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[BitacoraLogin] ([fechaLogin], [idCuenta]) VALUES (CAST(N'2024-04-15T23:28:24.843' AS DateTime), 703100722)
INSERT [dbo].[BitacoraLogin] ([fechaLogin], [idCuenta]) VALUES (CAST(N'2024-04-15T23:30:54.153' AS DateTime), 703100722)
INSERT [dbo].[BitacoraLogin] ([fechaLogin], [idCuenta]) VALUES (CAST(N'2024-04-15T23:31:50.777' AS DateTime), 703100722)
INSERT [dbo].[BitacoraLogin] ([fechaLogin], [idCuenta]) VALUES (CAST(N'2024-04-15T23:38:55.940' AS DateTime), 703100722)
GO
INSERT [dbo].[Cliente] ([idCliente], [paisProcedencia], [telefono], [correoElectronico], [nombre]) VALUES (123456789, N'Costa Rica', 87654321, N'cliente1@example.com', N'Juan Pérez')
INSERT [dbo].[Cliente] ([idCliente], [paisProcedencia], [telefono], [correoElectronico], [nombre]) VALUES (321654987, N'Perú', 34567890, N'cliente5@example.com', N'Pablo Gómez')
INSERT [dbo].[Cliente] ([idCliente], [paisProcedencia], [telefono], [correoElectronico], [nombre]) VALUES (369258147, N'Estados Unidos', 67890123, N'cliente9@example.com', N'Pedro García')
INSERT [dbo].[Cliente] ([idCliente], [paisProcedencia], [telefono], [correoElectronico], [nombre]) VALUES (456789123, N'Colombia', 76543210, N'cliente3@example.com', N'Carlos González')
INSERT [dbo].[Cliente] ([idCliente], [paisProcedencia], [telefono], [correoElectronico], [nombre]) VALUES (654987321, N'Chile', 56789012, N'cliente6@example.com', N'Ana López')
INSERT [dbo].[Cliente] ([idCliente], [paisProcedencia], [telefono], [correoElectronico], [nombre]) VALUES (703100722, N'Costa Rica', 84035342, N'esu@estudiantec.cr', N'Eyden Su')
INSERT [dbo].[Cliente] ([idCliente], [paisProcedencia], [telefono], [correoElectronico], [nombre]) VALUES (741852963, N'España', 90123456, N'cliente8@example.com', N'Marta Sánchez')
INSERT [dbo].[Cliente] ([idCliente], [paisProcedencia], [telefono], [correoElectronico], [nombre]) VALUES (789123456, N'Argentina', 12345678, N'cliente4@example.com', N'Laura Martínez')
INSERT [dbo].[Cliente] ([idCliente], [paisProcedencia], [telefono], [correoElectronico], [nombre]) VALUES (852963741, N'Canadá', 45678901, N'cliente10@example.com', N'Sofia Fernández')
GO
INSERT [dbo].[Cuenta] ([idUsuario], [idCuenta], [pasword]) VALUES (703100722, 1, N'admin')
INSERT [dbo].[Cuenta] ([idUsuario], [idCuenta], [pasword]) VALUES (123456789, 2, N'1234')
INSERT [dbo].[Cuenta] ([idUsuario], [idCuenta], [pasword]) VALUES (234567890, 3, N'a')
INSERT [dbo].[Cuenta] ([idUsuario], [idCuenta], [pasword]) VALUES (345678901, 4, N'a')
INSERT [dbo].[Cuenta] ([idUsuario], [idCuenta], [pasword]) VALUES (456789012, 5, N'b')
INSERT [dbo].[Cuenta] ([idUsuario], [idCuenta], [pasword]) VALUES (567890123, 6, N'b')
INSERT [dbo].[Cuenta] ([idUsuario], [idCuenta], [pasword]) VALUES (678901234, 7, N'c')
INSERT [dbo].[Cuenta] ([idUsuario], [idCuenta], [pasword]) VALUES (789012345, 8, N'c')
INSERT [dbo].[Cuenta] ([idUsuario], [idCuenta], [pasword]) VALUES (890123456, 9, N'd')
INSERT [dbo].[Cuenta] ([idUsuario], [idCuenta], [pasword]) VALUES (901234567, 10, N'd')
GO
INSERT [dbo].[Habitacion] ([idHabitacion], [tipo], [precio]) VALUES (1, N'Premium', CAST(60000.00 AS Decimal(32, 2)))
INSERT [dbo].[Habitacion] ([idHabitacion], [tipo], [precio]) VALUES (2, N'Familiar', CAST(53000.00 AS Decimal(32, 2)))
INSERT [dbo].[Habitacion] ([idHabitacion], [tipo], [precio]) VALUES (3, N'Pareja', CAST(40000.00 AS Decimal(32, 2)))
INSERT [dbo].[Habitacion] ([idHabitacion], [tipo], [precio]) VALUES (4, N'Villa', CAST(20000.00 AS Decimal(32, 2)))
GO
INSERT [dbo].[Rol] ([idRol], [nombreRol]) VALUES (1, N'Administrador')
INSERT [dbo].[Rol] ([idRol], [nombreRol]) VALUES (2, N'Recepcionista')
INSERT [dbo].[Rol] ([idRol], [nombreRol]) VALUES (3, N'Limpieza')
INSERT [dbo].[Rol] ([idRol], [nombreRol]) VALUES (4, N'Cocinero')
INSERT [dbo].[Rol] ([idRol], [nombreRol]) VALUES (5, N'Mesero')
INSERT [dbo].[Rol] ([idRol], [nombreRol]) VALUES (6, N'Técnico de Mantenimiento')
INSERT [dbo].[Rol] ([idRol], [nombreRol]) VALUES (7, N'Seguridad')
INSERT [dbo].[Rol] ([idRol], [nombreRol]) VALUES (8, N'Contabilidad')
INSERT [dbo].[Rol] ([idRol], [nombreRol]) VALUES (9, N'Supervisor de Recepción')
INSERT [dbo].[Rol] ([idRol], [nombreRol]) VALUES (10, N'Bartender')
GO
INSERT [dbo].[Usuario] ([idUsuario], [nombreCompleto], [fechaNacimiento], [direccionVivienda], [email], [numTell], [genero], [idRol]) VALUES (123456789, N'Ana García', CAST(N'1990-05-15' AS Date), N'San José', N'ana@example.com', 87654321, N'F', 2)
INSERT [dbo].[Usuario] ([idUsuario], [nombreCompleto], [fechaNacimiento], [direccionVivienda], [email], [numTell], [genero], [idRol]) VALUES (234567890, N'Juan Pérez', CAST(N'1987-08-20' AS Date), N'Heredia', N'juan@example.com', 98765432, N'M', 2)
INSERT [dbo].[Usuario] ([idUsuario], [nombreCompleto], [fechaNacimiento], [direccionVivienda], [email], [numTell], [genero], [idRol]) VALUES (345678901, N'María Fernández', CAST(N'1995-03-10' AS Date), N'Alajuela', N'maria@example.com', 76543210, N'F', 3)
INSERT [dbo].[Usuario] ([idUsuario], [nombreCompleto], [fechaNacimiento], [direccionVivienda], [email], [numTell], [genero], [idRol]) VALUES (456789012, N'Carlos Rodríguez', CAST(N'1983-11-25' AS Date), N'Cartago', N'carlos@example.com', 65432109, N'M', 4)
INSERT [dbo].[Usuario] ([idUsuario], [nombreCompleto], [fechaNacimiento], [direccionVivienda], [email], [numTell], [genero], [idRol]) VALUES (567890123, N'Laura Chacón', CAST(N'1998-06-03' AS Date), N'Puntarenas', N'laura@example.com', 54321098, N'F', 5)
INSERT [dbo].[Usuario] ([idUsuario], [nombreCompleto], [fechaNacimiento], [direccionVivienda], [email], [numTell], [genero], [idRol]) VALUES (678901234, N'José González', CAST(N'1975-09-12' AS Date), N'Guanacaste', N'jose@example.com', 43210987, N'M', 6)
INSERT [dbo].[Usuario] ([idUsuario], [nombreCompleto], [fechaNacimiento], [direccionVivienda], [email], [numTell], [genero], [idRol]) VALUES (703100722, N'Eyden Su Díaz', CAST(N'2004-09-17' AS Date), N'Pacuare Nuevo, Bajando Adoquines', N'esu@estudiantec.cr', 12345678, N'M', 1)
INSERT [dbo].[Usuario] ([idUsuario], [nombreCompleto], [fechaNacimiento], [direccionVivienda], [email], [numTell], [genero], [idRol]) VALUES (789012345, N'Karla Sánchez', CAST(N'1989-02-28' AS Date), N'Limón', N'karla@example.com', 32109876, N'F', 7)
INSERT [dbo].[Usuario] ([idUsuario], [nombreCompleto], [fechaNacimiento], [direccionVivienda], [email], [numTell], [genero], [idRol]) VALUES (890123456, N'David Jiménez', CAST(N'1992-07-17' AS Date), N'San José', N'david@example.com', 21098765, N'M', 8)
INSERT [dbo].[Usuario] ([idUsuario], [nombreCompleto], [fechaNacimiento], [direccionVivienda], [email], [numTell], [genero], [idRol]) VALUES (901234567, N'Ana Martínez', CAST(N'1986-12-09' AS Date), N'Heredia', N'ana.m@example.com', 10987654, N'F', 9)
GO
ALTER TABLE [dbo].[BitacoraLogin]  WITH CHECK ADD FOREIGN KEY([idCuenta])
REFERENCES [dbo].[Usuario] ([idUsuario])
GO
ALTER TABLE [dbo].[Cuenta]  WITH CHECK ADD FOREIGN KEY([idUsuario])
REFERENCES [dbo].[Usuario] ([idUsuario])
GO
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD FOREIGN KEY([idCliente])
REFERENCES [dbo].[Cliente] ([idCliente])
GO
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD FOREIGN KEY([idHabitacion])
REFERENCES [dbo].[Habitacion] ([idHabitacion])
GO
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD FOREIGN KEY([idUsuario])
REFERENCES [dbo].[Usuario] ([idUsuario])
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD FOREIGN KEY([idRol])
REFERENCES [dbo].[Rol] ([idRol])
GO
/****** Object:  StoredProcedure [dbo].[ClientStat]    Script Date: 15/4/2024 23:42:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ClientStat]
AS
SELECT H.tipo as Habitacion,  COUNT(idCliente) as Clientes
FROM Reserva R
INNER JOIN Habitacion H
ON	H.idHabitacion = R.idHabitacion
GROUP BY H.tipo
GO
/****** Object:  StoredProcedure [dbo].[maxReservas]    Script Date: 15/4/2024 23:42:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[maxReservas] AS
(SELECT U.nombreCompleto AS Recepcionista, COUNT(idReserva) AS Reservas
FROM Reserva R
FULL OUTER JOIN Usuario U 
ON U.idUsuario = R.idUsuario
GROUP BY U.nombreCompleto)
GO
/****** Object:  StoredProcedure [dbo].[TopFechas]    Script Date: 15/4/2024 23:42:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[TopFechas] AS 
SELECT TOP 5 fechaEntrada AS Dia, COUNT(idReserva) AS Reservas
    FROM Reserva 
    GROUP BY fechaEntrada
    ORDER BY Reservas DESC;
GO
USE [master]
GO
ALTER DATABASE [HOTELKARPAS] SET  READ_WRITE 
GO
