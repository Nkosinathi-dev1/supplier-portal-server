/* Creates database supplier and its Suppliers table and seed Suppliers table */

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



----------------------------------------


INSERT INTO supplier.dbo.Suppliers (CompanyName, Telephone, CreatedAt, UpdatedAt) VALUES ('Eskom Holdings Limited', '086 0037566', GETDATE(), GETDATE());
INSERT INTO supplier.dbo.Suppliers (CompanyName, Telephone, CreatedAt, UpdatedAt) VALUES ('Focus Rooms (Pty) Ltd', '0820776910', GETDATE(), GETDATE());
INSERT INTO supplier.dbo.Suppliers (CompanyName, Telephone, CreatedAt, UpdatedAt) VALUES ('GSM Electro', '0128110069', GETDATE(), GETDATE());
INSERT INTO supplier.dbo.Suppliers (CompanyName, Telephone, CreatedAt, UpdatedAt) VALUES ('Jody and Herman Investments CC', '0118864227', GETDATE(), GETDATE());
INSERT INTO supplier.dbo.Suppliers (CompanyName, Telephone, CreatedAt, UpdatedAt) VALUES ('Johan Le Roux Ingenieurswerke', '0233423390', GETDATE(), GETDATE());
INSERT INTO supplier.dbo.Suppliers (CompanyName, Telephone, CreatedAt, UpdatedAt) VALUES ('L. J. Ross t/a Petite Cafe''', '0117868101', GETDATE(), GETDATE());
INSERT INTO supplier.dbo.Suppliers (CompanyName, Telephone, CreatedAt, UpdatedAt) VALUES ('L.A Auto Center  CC t/a LA Body Works', '0219488412', GETDATE(), GETDATE());
INSERT INTO supplier.dbo.Suppliers (CompanyName, Telephone, CreatedAt, UpdatedAt) VALUES ('LG Tow-In CC', '0828044026', GETDATE(), GETDATE());
INSERT INTO supplier.dbo.Suppliers (CompanyName, Telephone, CreatedAt, UpdatedAt) VALUES ('LM Greyling t/aThe Electric Advertiser', '0119545972', GETDATE(), GETDATE());
INSERT INTO supplier.dbo.Suppliers (CompanyName, Telephone, CreatedAt, UpdatedAt) VALUES ('M.H Cloete Enterprises (Pty) Ltd  t/a  Rola Motors', '0218418300', GETDATE(), GETDATE());
INSERT INTO supplier.dbo.Suppliers (CompanyName, Telephone, CreatedAt, UpdatedAt) VALUES ('M.M Hydraulics CC', '011425 6578', GETDATE(), GETDATE());
INSERT INTO supplier.dbo.Suppliers (CompanyName, Telephone, CreatedAt, UpdatedAt) VALUES ('Phulo Human Capital (Pty) Ltd', '0114755934', GETDATE(), GETDATE());
INSERT INTO supplier.dbo.Suppliers (CompanyName, Telephone, CreatedAt, UpdatedAt) VALUES ('Picaro 115 CC t/a H2O CT Services', '0216745710', GETDATE(), GETDATE());
INSERT INTO supplier.dbo.Suppliers (CompanyName, Telephone, CreatedAt, UpdatedAt) VALUES ('Safetygrip CC', '0117086660', GETDATE(), GETDATE());
INSERT INTO supplier.dbo.Suppliers (CompanyName, Telephone, CreatedAt, UpdatedAt) VALUES ('Safic (Pty) Ltd', '0114064000', GETDATE(), GETDATE());
INSERT INTO supplier.dbo.Suppliers (CompanyName, Telephone, CreatedAt, UpdatedAt) VALUES ('The Financial Planning Institute Of Southern Africa', '0861000374', GETDATE(), GETDATE());
INSERT INTO supplier.dbo.Suppliers (CompanyName, Telephone, CreatedAt, UpdatedAt) VALUES ('The Fitment Zone  CC', '0118234181', GETDATE(), GETDATE());
INSERT INTO supplier.dbo.Suppliers (CompanyName, Telephone, CreatedAt, UpdatedAt) VALUES ('Turnweld Engineering CC', '0115468790', GETDATE(), GETDATE());
INSERT INTO supplier.dbo.Suppliers (CompanyName, Telephone, CreatedAt, UpdatedAt) VALUES ('Tutuka Motor Holdings Pty Ltd t/a Tutuka Motor Lab', '0117044324', GETDATE(), GETDATE());
INSERT INTO supplier.dbo.Suppliers (CompanyName, Telephone, CreatedAt, UpdatedAt) VALUES ('WP Exhaust Brake & Clutch t/a In Focus Fleet Services', '0219055028', GETDATE(), GETDATE());
INSERT INTO supplier.dbo.Suppliers (CompanyName, Telephone, CreatedAt, UpdatedAt) VALUES ('WP Sekuriteit', '0233421732', GETDATE(), GETDATE());
INSERT INTO supplier.dbo.Suppliers (CompanyName, Telephone, CreatedAt, UpdatedAt) VALUES ('Brietta Trading (Pty) Ltd', '0115526000', GETDATE(), GETDATE());
INSERT INTO supplier.dbo.Suppliers (CompanyName, Telephone, CreatedAt, UpdatedAt) VALUES ('C.N. Braam t/a CNB Electrical Services', '0832835399', GETDATE(), GETDATE());
INSERT INTO supplier.dbo.Suppliers (CompanyName, Telephone, CreatedAt, UpdatedAt) VALUES ('Creative Crew (Pty) Ltd', '0120040218', GETDATE(), GETDATE());