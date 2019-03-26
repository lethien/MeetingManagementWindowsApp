CREATE TABLE [dbo].[User]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [UserName] NVARCHAR(50) NOT NULL, 
    [Role] NVARCHAR(50) NOT NULL, 
    [Disabled] BIT NOT NULL
)
