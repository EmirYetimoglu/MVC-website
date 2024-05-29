USE [MIS462]
GO

/****** Object: Table [dbo].[Department] Script Date: 5/22/2024 5:22:15 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
IF EXISTS(SELECT 1 FROM sys.tables WHERE name = 'Department') DROP TABLE Department
BEGIN
CREATE TABLE [dbo].[Department] (
    [Id]             INT          IDENTITY (1, 1) NOT NULL,
    [DepartmentName] VARCHAR (50) NULL,
    [ManagerName]    VARCHAR (50) NULL
);

End