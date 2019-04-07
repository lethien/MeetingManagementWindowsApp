CREATE TABLE [dbo].[MeetingRoom]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [RoomName] NVARCHAR(50) NOT NULL UNIQUE, 
    [Location] NVARCHAR(100) NOT NULL, 
    [NumberOfSeats] INT NOT NULL DEFAULT 0, 
    [HasPhone] BIT NOT NULL DEFAULT 0, 
    [HasProjector] BIT NOT NULL DEFAULT 0, 
    [Disabled] BIT NOT NULL DEFAULT 0
)
