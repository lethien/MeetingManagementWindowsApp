CREATE TABLE [dbo].[Meeting_User]
(
	[MeetingID] INT NOT NULL, 
    [UserID] INT NOT NULL, 
    CONSTRAINT [MeetingID2] FOREIGN KEY ([MeetingID]) REFERENCES [Meeting]([ID]), 
    CONSTRAINT [UserID2] FOREIGN KEY ([UserID]) REFERENCES [User]([ID]), 
	PRIMARY KEY([MeetingID],[UserID])
)
