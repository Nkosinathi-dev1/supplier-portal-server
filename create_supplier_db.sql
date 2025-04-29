/* Creates database supplier and its Suppliers table */

IF DB_ID('supplier') IS NULL
BEGIN
    CREATE DATABASE [supplier];
    ALTER DATABASE [supplier] SET READ_COMMITTED_SNAPSHOT ON;
END
GO

USE [supplier];
GO

IF OBJECT_ID('[dbo].[Suppliers]', 'U') IS NULL
BEGIN
    CREATE TABLE [dbo].[Suppliers] (
        [Id]          INT            IDENTITY PRIMARY KEY,
        [CompanyName] NVARCHAR(200)  NOT NULL,
        [Telephone]   NVARCHAR(50)   NOT NULL,
        [CreatedAt]   DATETIME2      NOT NULL,
        [UpdatedAt]   DATETIME2      NOT NULL
    );
END
GO



