CREATE TABLE [dbo].[Group]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [GroupName] NVARCHAR(50) NOT NULL, 
    [Disabled] BIT NOT NULL
)
