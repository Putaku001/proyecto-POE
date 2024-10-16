USE [master]
GO
/****** Object:  Database [CRM_Proyectos]    Script Date: 11/10/2024 12:08:28 ******/
CREATE DATABASE [CRM_Proyectos]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CRM_Proyectos', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\CRM_Proyectos.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CRM_Proyectos_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\CRM_Proyectos_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [CRM_Proyectos] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CRM_Proyectos].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CRM_Proyectos] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CRM_Proyectos] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CRM_Proyectos] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CRM_Proyectos] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CRM_Proyectos] SET ARITHABORT OFF 
GO
ALTER DATABASE [CRM_Proyectos] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [CRM_Proyectos] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CRM_Proyectos] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CRM_Proyectos] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CRM_Proyectos] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CRM_Proyectos] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CRM_Proyectos] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CRM_Proyectos] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CRM_Proyectos] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CRM_Proyectos] SET  ENABLE_BROKER 
GO
ALTER DATABASE [CRM_Proyectos] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CRM_Proyectos] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CRM_Proyectos] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CRM_Proyectos] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CRM_Proyectos] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CRM_Proyectos] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CRM_Proyectos] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CRM_Proyectos] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [CRM_Proyectos] SET  MULTI_USER 
GO
ALTER DATABASE [CRM_Proyectos] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CRM_Proyectos] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CRM_Proyectos] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CRM_Proyectos] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CRM_Proyectos] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CRM_Proyectos] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [CRM_Proyectos] SET QUERY_STORE = ON
GO
ALTER DATABASE [CRM_Proyectos] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [CRM_Proyectos]
GO
/****** Object:  Table [dbo].[CategoriasProyecto]    Script Date: 11/10/2024 12:08:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CategoriasProyecto](
	[IdCategoria] [int] IDENTITY(1,1) NOT NULL,
	[NombreCategoria] [varchar](255) NULL,
	[DescripcionCategoria] [varchar](500) NULL,
	[FechaRegistro] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdCategoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ListaProyectos]    Script Date: 11/10/2024 12:08:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ListaProyectos](
	[IdProyecto] [int] IDENTITY(1,1) NOT NULL,
	[NombreProyecto] [varchar](255) NOT NULL,
	[DescripcionProyecto] [varchar](255) NOT NULL,
	[IdCategoriaProyecto] [int] NOT NULL,
	[FechaRegistro] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdProyecto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Permiso]    Script Date: 11/10/2024 12:08:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permiso](
	[IdPermiso] [int] IDENTITY(1,1) NOT NULL,
	[IdRol] [int] NULL,
	[NombreMenu] [varchar](255) NULL,
	[FechaRegistro] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdPermiso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proyecto_Tareas]    Script Date: 11/10/2024 12:08:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proyecto_Tareas](
	[IdProyecto] [int] NULL,
	[IdTareas] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ROL]    Script Date: 11/10/2024 12:08:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ROL](
	[IdRol] [int] IDENTITY(1,1) NOT NULL,
	[Rol] [varchar](255) NULL,
	[FechaRegistro] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdRol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tareas]    Script Date: 11/10/2024 12:08:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tareas](
	[IdTarea] [int] IDENTITY(1,1) NOT NULL,
	[NombreTarea] [varchar](255) NULL,
	[DescripcionTarea] [varchar](500) NULL,
	[FecharRegistro] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdTarea] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 11/10/2024 12:08:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[IdRol] [int] NULL,
	[Nombre] [varchar](255) NOT NULL,
	[Usuario] [varchar](255) NOT NULL,
	[Edad] [varchar](255) NOT NULL,
	[Correo] [varchar](255) NOT NULL,
	[Clave] [varchar](100) NOT NULL,
	[Pais] [varchar](255) NOT NULL,
	[Departamento] [varchar](255) NOT NULL,
	[Ciudad] [varchar](255) NOT NULL,
	[Estado] [varchar](255) NOT NULL,
	[FechaRegistro] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CategoriasProyecto] ON 

INSERT [dbo].[CategoriasProyecto] ([IdCategoria], [NombreCategoria], [DescripcionCategoria], [FechaRegistro]) VALUES (1, N'Desarrollo de software', N'Creación y mantenimiento de aplicaciones, sitios web o sistemas que satisfacen necesidades específicas de los usuarios.', CAST(N'2024-10-11T10:47:37.810' AS DateTime))
INSERT [dbo].[CategoriasProyecto] ([IdCategoria], [NombreCategoria], [DescripcionCategoria], [FechaRegistro]) VALUES (2, N'Desarrollo de software', N'Creación y mantenimiento de aplicaciones, sitios web o sistemas que satisfacen necesidades específicas de los usuarios.', CAST(N'2024-10-11T10:53:15.913' AS DateTime))
INSERT [dbo].[CategoriasProyecto] ([IdCategoria], [NombreCategoria], [DescripcionCategoria], [FechaRegistro]) VALUES (3, N'Marketing', N'Estrategia de marketing digital para aumentar la visibilidad de la marca y captar nuevos clientes.', CAST(N'2024-10-11T10:54:05.530' AS DateTime))
SET IDENTITY_INSERT [dbo].[CategoriasProyecto] OFF
GO
SET IDENTITY_INSERT [dbo].[ListaProyectos] ON 

INSERT [dbo].[ListaProyectos] ([IdProyecto], [NombreProyecto], [DescripcionProyecto], [IdCategoriaProyecto], [FechaRegistro]) VALUES (1, N'Desarrollo de aplicacion', N'Descripcion', 1, CAST(N'2024-10-11T11:13:53.653' AS DateTime))
INSERT [dbo].[ListaProyectos] ([IdProyecto], [NombreProyecto], [DescripcionProyecto], [IdCategoriaProyecto], [FechaRegistro]) VALUES (2, N'Campaña de Marketing Digital', N'Descripcion', 3, CAST(N'2024-10-11T11:13:53.653' AS DateTime))
SET IDENTITY_INSERT [dbo].[ListaProyectos] OFF
GO
INSERT [dbo].[Proyecto_Tareas] ([IdProyecto], [IdTareas]) VALUES (1, 1)
INSERT [dbo].[Proyecto_Tareas] ([IdProyecto], [IdTareas]) VALUES (1, 2)
INSERT [dbo].[Proyecto_Tareas] ([IdProyecto], [IdTareas]) VALUES (1, 3)
INSERT [dbo].[Proyecto_Tareas] ([IdProyecto], [IdTareas]) VALUES (1, 4)
INSERT [dbo].[Proyecto_Tareas] ([IdProyecto], [IdTareas]) VALUES (1, 5)
INSERT [dbo].[Proyecto_Tareas] ([IdProyecto], [IdTareas]) VALUES (2, 6)
INSERT [dbo].[Proyecto_Tareas] ([IdProyecto], [IdTareas]) VALUES (2, 7)
INSERT [dbo].[Proyecto_Tareas] ([IdProyecto], [IdTareas]) VALUES (2, 8)
INSERT [dbo].[Proyecto_Tareas] ([IdProyecto], [IdTareas]) VALUES (2, 9)
INSERT [dbo].[Proyecto_Tareas] ([IdProyecto], [IdTareas]) VALUES (2, 10)
GO
SET IDENTITY_INSERT [dbo].[ROL] ON 

INSERT [dbo].[ROL] ([IdRol], [Rol], [FechaRegistro]) VALUES (1, N'ADMINISTRADOR', CAST(N'2024-10-06T19:49:25.110' AS DateTime))
INSERT [dbo].[ROL] ([IdRol], [Rol], [FechaRegistro]) VALUES (2, N'EMPLEADO', CAST(N'2024-10-06T19:49:25.113' AS DateTime))
INSERT [dbo].[ROL] ([IdRol], [Rol], [FechaRegistro]) VALUES (3, N'CLIENTE', CAST(N'2024-10-06T19:49:25.113' AS DateTime))
SET IDENTITY_INSERT [dbo].[ROL] OFF
GO
SET IDENTITY_INSERT [dbo].[Tareas] ON 

INSERT [dbo].[Tareas] ([IdTarea], [NombreTarea], [DescripcionTarea], [FecharRegistro]) VALUES (1, N'Diseño de la Interfaz de Usuario (Frontend)', N'Crear la parte visual de la aplicación con la que interactúan los usuarios.', CAST(N'2024-10-11T11:09:03.423' AS DateTime))
INSERT [dbo].[Tareas] ([IdTarea], [NombreTarea], [DescripcionTarea], [FecharRegistro]) VALUES (2, N'Desarrollo de la Lógica de Negocio (Backend)', N'Programar la funcionalidad principal que se ejecuta en el servidor o el sistema.', CAST(N'2024-10-11T11:09:03.423' AS DateTime))
INSERT [dbo].[Tareas] ([IdTarea], [NombreTarea], [DescripcionTarea], [FecharRegistro]) VALUES (3, N'Implementación de la Base de Datos', N'Configurar y estructurar las bases de datos para almacenar y gestionar la información.', CAST(N'2024-10-11T11:09:03.423' AS DateTime))
INSERT [dbo].[Tareas] ([IdTarea], [NombreTarea], [DescripcionTarea], [FecharRegistro]) VALUES (4, N'Pruebas y Control de Calidad', N'Verificar que el sistema funcione correctamente mediante pruebas de funcionamiento y detección de errores.', CAST(N'2024-10-11T11:09:03.423' AS DateTime))
INSERT [dbo].[Tareas] ([IdTarea], [NombreTarea], [DescripcionTarea], [FecharRegistro]) VALUES (5, N'Despliegue en Tienda de Aplicaciones', N'Publicar la aplicación en plataformas como Google Play o App Store para que los usuarios puedan descargarla.', CAST(N'2024-10-11T11:09:03.423' AS DateTime))
INSERT [dbo].[Tareas] ([IdTarea], [NombreTarea], [DescripcionTarea], [FecharRegistro]) VALUES (6, N'Creación de Contenido Publicitario', N'Diseñar material visual o escrito para promocionar productos o servicios.', CAST(N'2024-10-11T11:09:03.423' AS DateTime))
INSERT [dbo].[Tareas] ([IdTarea], [NombreTarea], [DescripcionTarea], [FecharRegistro]) VALUES (7, N'Gestión de Redes Sociales', N'Monitorear y actualizar las cuentas de redes sociales con contenido relevante para la audiencia.', CAST(N'2024-10-11T11:09:03.423' AS DateTime))
INSERT [dbo].[Tareas] ([IdTarea], [NombreTarea], [DescripcionTarea], [FecharRegistro]) VALUES (8, N'Análisis de Métricas y Resultados', N'Evaluar el desempeño de las campañas utilizando herramientas de análisis para ajustar estrategias.', CAST(N'2024-10-11T11:09:03.423' AS DateTime))
INSERT [dbo].[Tareas] ([IdTarea], [NombreTarea], [DescripcionTarea], [FecharRegistro]) VALUES (9, N'Optimización de SEO', N'Mejorar la estructura del sitio web para aumentar su visibilidad en motores de búsqueda como Google.', CAST(N'2024-10-11T11:09:03.423' AS DateTime))
INSERT [dbo].[Tareas] ([IdTarea], [NombreTarea], [DescripcionTarea], [FecharRegistro]) VALUES (10, N'Planificación y Ejecución de Email Marketing', N'Diseñar y enviar campañas de correo electrónico personalizadas a los clientes para mejorar las conversiones.', CAST(N'2024-10-11T11:09:03.423' AS DateTime))
SET IDENTITY_INSERT [dbo].[Tareas] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([IdUsuario], [IdRol], [Nombre], [Usuario], [Edad], [Correo], [Clave], [Pais], [Departamento], [Ciudad], [Estado], [FechaRegistro]) VALUES (1, 1, N'Aristides Alfonso Fuentes Cañas', N'ElMaje75', N'18', N'xxpussidestroyer69@gmail.com', N'123', N'El Salvador', N'San Miguel', N'San Miguel', N'Activo', CAST(N'2024-10-06T20:38:38.063' AS DateTime))
INSERT [dbo].[Usuarios] ([IdUsuario], [IdRol], [Nombre], [Usuario], [Edad], [Correo], [Clave], [Pais], [Departamento], [Ciudad], [Estado], [FechaRegistro]) VALUES (2, NULL, N'Leonel Ronaldo Suarez Neymar Junior', N'empotrador77', N'0', N'manueldelasrecargas98@gmail.com', N'123', N'El Salvador', N'La Libertad', N'La Libertad', N'Activo', CAST(N'2024-10-07T12:28:12.217' AS DateTime))
INSERT [dbo].[Usuarios] ([IdUsuario], [IdRol], [Nombre], [Usuario], [Edad], [Correo], [Clave], [Pais], [Departamento], [Ciudad], [Estado], [FechaRegistro]) VALUES (4, 2, N'Empleado 1', N'empleado', N'24', N'empleado1@gmail.com', N'123', N'El Salvador', N'Santa Ana', N'Santa Ana', N'Activo', CAST(N'2024-10-08T19:10:19.930' AS DateTime))
INSERT [dbo].[Usuarios] ([IdUsuario], [IdRol], [Nombre], [Usuario], [Edad], [Correo], [Clave], [Pais], [Departamento], [Ciudad], [Estado], [FechaRegistro]) VALUES (6, 1, N'prueba Inyeccion', N'inyeccion', N'18', N'@gmail.com', N'123', N'El Salvador', N'San Salvador', N'San Salvador', N'Activo', CAST(N'2024-10-11T09:48:29.370' AS DateTime))
INSERT [dbo].[Usuarios] ([IdUsuario], [IdRol], [Nombre], [Usuario], [Edad], [Correo], [Clave], [Pais], [Departamento], [Ciudad], [Estado], [FechaRegistro]) VALUES (7, 2, N'Inyeccion Rol', N'rol', N'18', N'@gmail.com', N'123', N'Argentina', N'Buenos Aires', N'La Plata', N'Activo', CAST(N'2024-10-11T10:07:15.387' AS DateTime))
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
GO
ALTER TABLE [dbo].[CategoriasProyecto] ADD  DEFAULT (getdate()) FOR [FechaRegistro]
GO
ALTER TABLE [dbo].[ListaProyectos] ADD  DEFAULT (getdate()) FOR [FechaRegistro]
GO
ALTER TABLE [dbo].[Permiso] ADD  DEFAULT (getdate()) FOR [FechaRegistro]
GO
ALTER TABLE [dbo].[ROL] ADD  DEFAULT (getdate()) FOR [FechaRegistro]
GO
ALTER TABLE [dbo].[Tareas] ADD  DEFAULT (getdate()) FOR [FecharRegistro]
GO
ALTER TABLE [dbo].[Usuarios] ADD  DEFAULT (getdate()) FOR [FechaRegistro]
GO
ALTER TABLE [dbo].[ListaProyectos]  WITH CHECK ADD  CONSTRAINT [fk_categoria] FOREIGN KEY([IdCategoriaProyecto])
REFERENCES [dbo].[CategoriasProyecto] ([IdCategoria])
GO
ALTER TABLE [dbo].[ListaProyectos] CHECK CONSTRAINT [fk_categoria]
GO
ALTER TABLE [dbo].[Permiso]  WITH CHECK ADD  CONSTRAINT [fk_idrol] FOREIGN KEY([IdRol])
REFERENCES [dbo].[ROL] ([IdRol])
GO
ALTER TABLE [dbo].[Permiso] CHECK CONSTRAINT [fk_idrol]
GO
ALTER TABLE [dbo].[Proyecto_Tareas]  WITH CHECK ADD  CONSTRAINT [fk_idproyecto] FOREIGN KEY([IdProyecto])
REFERENCES [dbo].[ListaProyectos] ([IdProyecto])
GO
ALTER TABLE [dbo].[Proyecto_Tareas] CHECK CONSTRAINT [fk_idproyecto]
GO
ALTER TABLE [dbo].[Proyecto_Tareas]  WITH CHECK ADD  CONSTRAINT [fk_idtareas] FOREIGN KEY([IdTareas])
REFERENCES [dbo].[Tareas] ([IdTarea])
GO
ALTER TABLE [dbo].[Proyecto_Tareas] CHECK CONSTRAINT [fk_idtareas]
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [fk_rol] FOREIGN KEY([IdRol])
REFERENCES [dbo].[ROL] ([IdRol])
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [fk_rol]
GO
USE [master]
GO
ALTER DATABASE [CRM_Proyectos] SET  READ_WRITE 
GO
