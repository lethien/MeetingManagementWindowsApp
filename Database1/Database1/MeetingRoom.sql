CREATE TABLE [dbo].[MeetingRoom]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [RoomName] NVARCHAR(50) NOT NULL, 
    [Location] NVARCHAR(50) NOT NULL, 
    [NumberOfSeats] NVARCHAR(50) NOT NULL, 
    [HasPhone] BIT NOT NULL, 
    [HasProjector] BIT NOT NULL, 
    [Disabled] BIT NOT NULL, 
    
)
