
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/07/2018 07:12:49
-- Generated from EDMX file: C:\!Files\!APF\!ProgrammingAndDevelopment\ASPdotNetWebApiTestTask\ASPdotNetWebApiTestTask\Models\MyDictionaryModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [mydictionary];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[WordsOdPhrases]', 'U') IS NOT NULL
    DROP TABLE [dbo].[WordsOdPhrases];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'WordsOrPhrases'
CREATE TABLE [dbo].[WordsOrPhrases] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Text] nvarchar(max)  NOT NULL,
    [MainTranslation] nvarchar(max)  NOT NULL,
    [PhTranscription] nvarchar(max)  NOT NULL,
    [IsIrregularVerb] bit  NOT NULL,
    [WhenAdded] datetime  NOT NULL,
    [LearningStage] tinyint  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'WordsOrPhrases'
ALTER TABLE [dbo].[WordsOrPhrases]
ADD CONSTRAINT [PK_WordsOrPhrases]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------