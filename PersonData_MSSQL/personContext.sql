USE [master]
GO
/****** Object:  Database [PersonContext]    Script Date: 9.3.2017 г. 14:07:46 ******/
CREATE DATABASE [PersonContext]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PersonContext', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\PersonContext.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PersonContext_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\PersonContext_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [PersonContext] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PersonContext].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PersonContext] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PersonContext] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PersonContext] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PersonContext] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PersonContext] SET ARITHABORT OFF 
GO
ALTER DATABASE [PersonContext] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [PersonContext] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PersonContext] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PersonContext] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PersonContext] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PersonContext] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PersonContext] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PersonContext] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PersonContext] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PersonContext] SET  ENABLE_BROKER 
GO
ALTER DATABASE [PersonContext] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PersonContext] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PersonContext] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PersonContext] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PersonContext] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PersonContext] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [PersonContext] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PersonContext] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [PersonContext] SET  MULTI_USER 
GO
ALTER DATABASE [PersonContext] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PersonContext] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PersonContext] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PersonContext] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PersonContext] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PersonContext] SET QUERY_STORE = OFF
GO
USE [PersonContext]
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [PersonContext]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 9.3.2017 г. 14:07:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC,
	[ContextKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[People]    Script Date: 9.3.2017 г. 14:07:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[People](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](max) NULL,
	[BirthDate] [datetime] NOT NULL,
	[Email] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.People] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
USE [master]
GO
ALTER DATABASE [PersonContext] SET  READ_WRITE 
GO
