-- {EntityNamePlural}Database.sql
-- IMPORTANT: Replace {EntityNamePlural} with the plural name of your entity (e.g., Cars, Cats, Persons)
-- IMPORTANT: Replace {Property1Name}, {Property2Name}, {Property3Name} with your actual column names.
-- IMPORTANT: Replace {Property1Type}, {Property2Type}, {Property3Type} with your actual SQL data types (e.g., NVARCHAR(255), FLOAT, INT).

IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'EntityNamePluralDatabase')
BEGIN
    CREATE DATABASE EntityNamePluralDatabase;
END
GO

USE EntityNamePluralDatabase;
GO

IF NOT EXISTS (SELECT * FROM SYSOBJECTS WHERE NAME='EntityNamePlural' AND XTYPE='U')
BEGIN
    CREATE TABLE EntityNamePlural (
        Id INT PRIMARY KEY IDENTITY(1,1),
        Property1Name Property1Type NOT NULL, -- e.g., Model NVARCHAR(255)
        Property2Name Property2Type NOT NULL, -- e.g., Weight FLOAT
        Property3Name Property3Type NOT NULL  -- e.g., Speed INT
    );
END
GO
