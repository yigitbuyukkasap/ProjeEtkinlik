
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/05/2022 00:32:40
-- Generated from EDMX file: C:\Users\BBQ\source\okul\ProjeEtkinlik\Proje.Etkinlik.Data\Veritabani.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [db.ProjeEtkinlik];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_AltKategori_Kategori]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AltKategori] DROP CONSTRAINT [FK_AltKategori_Kategori];
GO
IF OBJECT_ID(N'[dbo].[FK_Etkinlik_AltKategori]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Etkinlik] DROP CONSTRAINT [FK_Etkinlik_AltKategori];
GO
IF OBJECT_ID(N'[dbo].[FK_Etkinlik_Mekan]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Etkinlik] DROP CONSTRAINT [FK_Etkinlik_Mekan];
GO
IF OBJECT_ID(N'[dbo].[FK_Etkinlik_Sanatci]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Etkinlik] DROP CONSTRAINT [FK_Etkinlik_Sanatci];
GO
IF OBJECT_ID(N'[dbo].[FK_Mekan_Sehir]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Mekan] DROP CONSTRAINT [FK_Mekan_Sehir];
GO
IF OBJECT_ID(N'[dbo].[FK_Sahne_Mekan]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Sahne] DROP CONSTRAINT [FK_Sahne_Mekan];
GO
IF OBJECT_ID(N'[dbo].[FK_Uye_Sehir]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Uye] DROP CONSTRAINT [FK_Uye_Sehir];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[AltKategori]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AltKategori];
GO
IF OBJECT_ID(N'[dbo].[Etkinlik]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Etkinlik];
GO
IF OBJECT_ID(N'[dbo].[Kategori]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Kategori];
GO
IF OBJECT_ID(N'[dbo].[Mekan]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Mekan];
GO
IF OBJECT_ID(N'[dbo].[Menu]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Menu];
GO
IF OBJECT_ID(N'[dbo].[Sahne]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Sahne];
GO
IF OBJECT_ID(N'[dbo].[Sanatci]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Sanatci];
GO
IF OBJECT_ID(N'[dbo].[Sehir]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Sehir];
GO
IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO
IF OBJECT_ID(N'[dbo].[Uye]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Uye];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'AltKategori'
CREATE TABLE [dbo].[AltKategori] (
    [id] int  NOT NULL,
    [KategoriId] int  NULL,
    [AltKategoriAd] nvarchar(100)  NULL
);
GO

-- Creating table 'Etkinlik'
CREATE TABLE [dbo].[Etkinlik] (
    [id] int  NOT NULL,
    [EtkinlikAd] nvarchar(50)  NULL,
    [MekanId] int  NULL,
    [AltKategoriId] int  NULL,
    [Tarih] datetime  NULL,
    [Aciklama] nvarchar(max)  NULL,
    [SanatciId] int  NULL
);
GO

-- Creating table 'Kategori'
CREATE TABLE [dbo].[Kategori] (
    [id] int  NOT NULL,
    [KategoriAd] nchar(30)  NULL
);
GO

-- Creating table 'Mekan'
CREATE TABLE [dbo].[Mekan] (
    [id] int  NOT NULL,
    [MekanAd] nvarchar(200)  NOT NULL,
    [MekanKonum] nvarchar(max)  NULL,
    [MekanFoto] nvarchar(max)  NULL,
    [MekanSehir] int  NULL
);
GO

-- Creating table 'Sahne'
CREATE TABLE [dbo].[Sahne] (
    [id] int  NOT NULL,
    [MekanId] int  NULL,
    [KisiSayısı] int  NULL
);
GO

-- Creating table 'Sanatci'
CREATE TABLE [dbo].[Sanatci] (
    [id] int  NOT NULL,
    [AdSoyad] nvarchar(50)  NULL,
    [Foto] nvarchar(50)  NULL,
    [Aciklama] nvarchar(50)  NULL
);
GO

-- Creating table 'Sehir'
CREATE TABLE [dbo].[Sehir] (
    [id] int  NOT NULL,
    [SehirAd] nchar(50)  NULL
);
GO

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- Creating table 'Uye'
CREATE TABLE [dbo].[Uye] (
    [id] int  NOT NULL,
    [AdSoyad] nvarchar(50)  NULL,
    [SehirId] int  NULL,
    [Telefon] nchar(10)  NULL,
    [Yas] int  NULL,
    [Email] nchar(50)  NULL,
    [Sifre] nchar(40)  NULL,
    [Yetki] nchar(10)  NULL
);
GO

-- Creating table 'Menu'
CREATE TABLE [dbo].[Menu] (
    [id] int IDENTITY(1,1) NOT NULL,
    [MenuAd] nchar(30)  NULL,
    [MenuAdres] nchar(50)  NULL,
    [Yetki] nchar(15)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [id] in table 'AltKategori'
ALTER TABLE [dbo].[AltKategori]
ADD CONSTRAINT [PK_AltKategori]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Etkinlik'
ALTER TABLE [dbo].[Etkinlik]
ADD CONSTRAINT [PK_Etkinlik]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Kategori'
ALTER TABLE [dbo].[Kategori]
ADD CONSTRAINT [PK_Kategori]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Mekan'
ALTER TABLE [dbo].[Mekan]
ADD CONSTRAINT [PK_Mekan]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Sahne'
ALTER TABLE [dbo].[Sahne]
ADD CONSTRAINT [PK_Sahne]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Sanatci'
ALTER TABLE [dbo].[Sanatci]
ADD CONSTRAINT [PK_Sanatci]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Sehir'
ALTER TABLE [dbo].[Sehir]
ADD CONSTRAINT [PK_Sehir]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- Creating primary key on [id] in table 'Uye'
ALTER TABLE [dbo].[Uye]
ADD CONSTRAINT [PK_Uye]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Menu'
ALTER TABLE [dbo].[Menu]
ADD CONSTRAINT [PK_Menu]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [KategoriId] in table 'AltKategori'
ALTER TABLE [dbo].[AltKategori]
ADD CONSTRAINT [FK_AltKategori_Kategori]
    FOREIGN KEY ([KategoriId])
    REFERENCES [dbo].[Kategori]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AltKategori_Kategori'
CREATE INDEX [IX_FK_AltKategori_Kategori]
ON [dbo].[AltKategori]
    ([KategoriId]);
GO

-- Creating foreign key on [AltKategoriId] in table 'Etkinlik'
ALTER TABLE [dbo].[Etkinlik]
ADD CONSTRAINT [FK_Etkinlik_AltKategori]
    FOREIGN KEY ([AltKategoriId])
    REFERENCES [dbo].[AltKategori]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Etkinlik_AltKategori'
CREATE INDEX [IX_FK_Etkinlik_AltKategori]
ON [dbo].[Etkinlik]
    ([AltKategoriId]);
GO

-- Creating foreign key on [MekanId] in table 'Etkinlik'
ALTER TABLE [dbo].[Etkinlik]
ADD CONSTRAINT [FK_Etkinlik_Mekan]
    FOREIGN KEY ([MekanId])
    REFERENCES [dbo].[Mekan]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Etkinlik_Mekan'
CREATE INDEX [IX_FK_Etkinlik_Mekan]
ON [dbo].[Etkinlik]
    ([MekanId]);
GO

-- Creating foreign key on [SanatciId] in table 'Etkinlik'
ALTER TABLE [dbo].[Etkinlik]
ADD CONSTRAINT [FK_Etkinlik_Sanatci]
    FOREIGN KEY ([SanatciId])
    REFERENCES [dbo].[Sanatci]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Etkinlik_Sanatci'
CREATE INDEX [IX_FK_Etkinlik_Sanatci]
ON [dbo].[Etkinlik]
    ([SanatciId]);
GO

-- Creating foreign key on [MekanSehir] in table 'Mekan'
ALTER TABLE [dbo].[Mekan]
ADD CONSTRAINT [FK_Mekan_Sehir]
    FOREIGN KEY ([MekanSehir])
    REFERENCES [dbo].[Sehir]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Mekan_Sehir'
CREATE INDEX [IX_FK_Mekan_Sehir]
ON [dbo].[Mekan]
    ([MekanSehir]);
GO

-- Creating foreign key on [MekanId] in table 'Sahne'
ALTER TABLE [dbo].[Sahne]
ADD CONSTRAINT [FK_Sahne_Mekan]
    FOREIGN KEY ([MekanId])
    REFERENCES [dbo].[Mekan]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Sahne_Mekan'
CREATE INDEX [IX_FK_Sahne_Mekan]
ON [dbo].[Sahne]
    ([MekanId]);
GO

-- Creating foreign key on [SehirId] in table 'Uye'
ALTER TABLE [dbo].[Uye]
ADD CONSTRAINT [FK_Uye_Sehir]
    FOREIGN KEY ([SehirId])
    REFERENCES [dbo].[Sehir]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Uye_Sehir'
CREATE INDEX [IX_FK_Uye_Sehir]
ON [dbo].[Uye]
    ([SehirId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------