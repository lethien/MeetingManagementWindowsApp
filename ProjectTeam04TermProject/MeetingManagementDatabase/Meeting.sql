CREATE TABLE [dbo].[Meeting]
(
	[Id] INT IDENTITY(1,1) NOT NULL, 
    [Title] NVARCHAR(100) NOT NULL, 
    [Description] NVARCHAR(255) NOT NULL, 
    [From] DATETIME NOT NULL,
    [To] DATETIME NOT NULL, 
    [MeetingRoomId] INT NOT NULL, 
    [Notes] TEXT NOT NULL, 
    [CreatedBy] INT NOT NULL, 
    [Canceled] BIT NOT NULL DEFAULT 0,
	PRIMARY KEY (Id),
	FOREIGN KEY ([MeetingRoomId]) REFERENCES [MeetingRoom] ([Id]),
	FOREIGN KEY ([CreatedBy]) REFERENCES [User] ([Id])
)
