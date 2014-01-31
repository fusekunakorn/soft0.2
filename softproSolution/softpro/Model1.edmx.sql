
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 01/31/2014 23:59:10
-- Generated from EDMX file: C:\Users\FuseKunakorn\Desktop\soft0.2\softproSolution\softpro\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MyDatabase];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_CustomerRentalOrder]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RentalOrderSet] DROP CONSTRAINT [FK_CustomerRentalOrder];
GO
IF OBJECT_ID(N'[dbo].[FK_RoomRentalOrder]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RentalOrderSet] DROP CONSTRAINT [FK_RoomRentalOrder];
GO
IF OBJECT_ID(N'[dbo].[FK_RoomDeposit]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DepositSet] DROP CONSTRAINT [FK_RoomDeposit];
GO
IF OBJECT_ID(N'[dbo].[FK_CustomerDeposit]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DepositSet] DROP CONSTRAINT [FK_CustomerDeposit];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[CustomerSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CustomerSet];
GO
IF OBJECT_ID(N'[dbo].[RoomSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RoomSet];
GO
IF OBJECT_ID(N'[dbo].[RentalOrderSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RentalOrderSet];
GO
IF OBJECT_ID(N'[dbo].[DepositSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DepositSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'CustomerSet'
CREATE TABLE [dbo].[CustomerSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [SSN] nvarchar(max)  NOT NULL,
    [Sex] bit  NOT NULL,
    [Tel] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'RoomSet'
CREATE TABLE [dbo].[RoomSet] (
    [RoomId] int  NOT NULL,
    [Rent] float  NOT NULL
);
GO

-- Creating table 'RentalOrderSet'
CREATE TABLE [dbo].[RentalOrderSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [RetalDate] datetime  NOT NULL,
    [Unit] int  NOT NULL,
    [Person] int  NOT NULL,
    [WaterPrice] float  NOT NULL,
    [Total] float  NOT NULL,
    [Customer_Id] int  NOT NULL,
    [Room_RoomId] int  NOT NULL
);
GO

-- Creating table 'DepositSet'
CREATE TABLE [dbo].[DepositSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CashDeposit] float  NOT NULL,
    [Room_RoomId] int  NOT NULL,
    [Customer_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'CustomerSet'
ALTER TABLE [dbo].[CustomerSet]
ADD CONSTRAINT [PK_CustomerSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [RoomId] in table 'RoomSet'
ALTER TABLE [dbo].[RoomSet]
ADD CONSTRAINT [PK_RoomSet]
    PRIMARY KEY CLUSTERED ([RoomId] ASC);
GO

-- Creating primary key on [Id] in table 'RentalOrderSet'
ALTER TABLE [dbo].[RentalOrderSet]
ADD CONSTRAINT [PK_RentalOrderSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DepositSet'
ALTER TABLE [dbo].[DepositSet]
ADD CONSTRAINT [PK_DepositSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Customer_Id] in table 'RentalOrderSet'
ALTER TABLE [dbo].[RentalOrderSet]
ADD CONSTRAINT [FK_CustomerRentalOrder]
    FOREIGN KEY ([Customer_Id])
    REFERENCES [dbo].[CustomerSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CustomerRentalOrder'
CREATE INDEX [IX_FK_CustomerRentalOrder]
ON [dbo].[RentalOrderSet]
    ([Customer_Id]);
GO

-- Creating foreign key on [Room_RoomId] in table 'RentalOrderSet'
ALTER TABLE [dbo].[RentalOrderSet]
ADD CONSTRAINT [FK_RoomRentalOrder]
    FOREIGN KEY ([Room_RoomId])
    REFERENCES [dbo].[RoomSet]
        ([RoomId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_RoomRentalOrder'
CREATE INDEX [IX_FK_RoomRentalOrder]
ON [dbo].[RentalOrderSet]
    ([Room_RoomId]);
GO

-- Creating foreign key on [Room_RoomId] in table 'DepositSet'
ALTER TABLE [dbo].[DepositSet]
ADD CONSTRAINT [FK_RoomDeposit]
    FOREIGN KEY ([Room_RoomId])
    REFERENCES [dbo].[RoomSet]
        ([RoomId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_RoomDeposit'
CREATE INDEX [IX_FK_RoomDeposit]
ON [dbo].[DepositSet]
    ([Room_RoomId]);
GO

-- Creating foreign key on [Customer_Id] in table 'DepositSet'
ALTER TABLE [dbo].[DepositSet]
ADD CONSTRAINT [FK_CustomerDeposit]
    FOREIGN KEY ([Customer_Id])
    REFERENCES [dbo].[CustomerSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CustomerDeposit'
CREATE INDEX [IX_FK_CustomerDeposit]
ON [dbo].[DepositSet]
    ([Customer_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------