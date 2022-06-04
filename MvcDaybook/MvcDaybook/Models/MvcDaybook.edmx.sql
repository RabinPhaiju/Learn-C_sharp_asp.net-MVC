
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/01/2022 10:37:11
-- Generated from EDMX file: C:\Users\rabin\source\repos\MvcDaybook\MvcDaybook\Models\MvcDaybook.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MvcDaybook];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Daybook_orderDaybook_line]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Daybook_order] DROP CONSTRAINT [FK_Daybook_orderDaybook_line];
GO
IF OBJECT_ID(N'[dbo].[FK_DaybookDaybook_line]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Daybook_line] DROP CONSTRAINT [FK_DaybookDaybook_line];
GO
IF OBJECT_ID(N'[dbo].[FK_CategoryProduct]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Product] DROP CONSTRAINT [FK_CategoryProduct];
GO
IF OBJECT_ID(N'[dbo].[FK_ProductDaybook_order]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Product] DROP CONSTRAINT [FK_ProductDaybook_order];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Daybook_line]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Daybook_line];
GO
IF OBJECT_ID(N'[dbo].[Daybook_order]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Daybook_order];
GO
IF OBJECT_ID(N'[dbo].[Category]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Category];
GO
IF OBJECT_ID(N'[dbo].[Product]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Product];
GO
IF OBJECT_ID(N'[dbo].[Daybook]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Daybook];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Daybook_line'
CREATE TABLE [dbo].[Daybook_line] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [total] float  NOT NULL,
    [date] datetime  NOT NULL,
    [DaybookId] int  NOT NULL
);
GO

-- Creating table 'Daybook_order'
CREATE TABLE [dbo].[Daybook_order] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [s_price] float  NOT NULL,
    [quantity] bigint  NOT NULL,
    [name] nvarchar(max)  NOT NULL,
    [ProductId] int  NOT NULL,
    [Daybook_lineId] int  NOT NULL
);
GO

-- Creating table 'Category'
CREATE TABLE [dbo].[Category] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(max)  NOT NULL,
    [code] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Product'
CREATE TABLE [dbo].[Product] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(max)  NOT NULL,
    [photo] nvarchar(max)  NOT NULL,
    [quantity] bigint  NOT NULL,
    [min_quantity] bigint  NULL,
    [price] float  NOT NULL,
    [code] bigint  NOT NULL,
    [purchase_price] float  NOT NULL,
    [warranty] nvarchar(max)  NOT NULL,
    [description] nvarchar(max)  NOT NULL,
    [CategoryId] int  NOT NULL
);
GO

-- Creating table 'Daybook'
CREATE TABLE [dbo].[Daybook] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(max)  NOT NULL,
    [user] nvarchar(max)  NOT NULL,
    [month] nvarchar(max)  NOT NULL,
    [date] datetime  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Daybook_line'
ALTER TABLE [dbo].[Daybook_line]
ADD CONSTRAINT [PK_Daybook_line]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Daybook_order'
ALTER TABLE [dbo].[Daybook_order]
ADD CONSTRAINT [PK_Daybook_order]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Category'
ALTER TABLE [dbo].[Category]
ADD CONSTRAINT [PK_Category]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Product'
ALTER TABLE [dbo].[Product]
ADD CONSTRAINT [PK_Product]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Daybook'
ALTER TABLE [dbo].[Daybook]
ADD CONSTRAINT [PK_Daybook]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [DaybookId] in table 'Daybook_line'
ALTER TABLE [dbo].[Daybook_line]
ADD CONSTRAINT [FK_DaybookDaybook_line]
    FOREIGN KEY ([DaybookId])
    REFERENCES [dbo].[Daybook]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DaybookDaybook_line'
CREATE INDEX [IX_FK_DaybookDaybook_line]
ON [dbo].[Daybook_line]
    ([DaybookId]);
GO

-- Creating foreign key on [CategoryId] in table 'Product'
ALTER TABLE [dbo].[Product]
ADD CONSTRAINT [FK_CategoryProduct]
    FOREIGN KEY ([CategoryId])
    REFERENCES [dbo].[Category]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CategoryProduct'
CREATE INDEX [IX_FK_CategoryProduct]
ON [dbo].[Product]
    ([CategoryId]);
GO

-- Creating foreign key on [ProductId] in table 'Daybook_order'
ALTER TABLE [dbo].[Daybook_order]
ADD CONSTRAINT [FK_ProductDaybook_order]
    FOREIGN KEY ([ProductId])
    REFERENCES [dbo].[Product]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductDaybook_order'
CREATE INDEX [IX_FK_ProductDaybook_order]
ON [dbo].[Daybook_order]
    ([ProductId]);
GO

-- Creating foreign key on [Daybook_lineId] in table 'Daybook_order'
ALTER TABLE [dbo].[Daybook_order]
ADD CONSTRAINT [FK_Daybook_lineDaybook_order]
    FOREIGN KEY ([Daybook_lineId])
    REFERENCES [dbo].[Daybook_line]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Daybook_lineDaybook_order'
CREATE INDEX [IX_FK_Daybook_lineDaybook_order]
ON [dbo].[Daybook_order]
    ([Daybook_lineId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------