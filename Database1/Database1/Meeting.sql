CREATE TABLE [dbo].[Meeting]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Title] NVARCHAR(50) NOT NULL, 
    [Description ] NVARCHAR(50) NOT NULL, 
    [Date] DATETIME NOT NULL, 
    [From] NVARCHAR(50) NOT NULL, 
    [To] NVARCHAR(50) NOT NULL, 
    [MeetingRoomID] INT NOT NULL, 
    [Notes] NVARCHAR(50) NOT NULL, 
    [CreatedBy] NVARCHAR(50) NOT NULL, 
    [Canceled ] BIT NOT NULL, 
    CONSTRAINT [MeetingRoomID] FOREIGN KEY (MeetingRoomID) REFERENCES [MeetingRoom]([ID]),
)
