CREATE TABLE [dbo].[Meeting_Group]
(
	[MeetingID] INT NOT NULL , 
    [GroupID] INT NOT NULL, 
    CONSTRAINT [MeetingID] FOREIGN KEY ([MeetingID]) REFERENCES [Meeting]([ID]), 
    CONSTRAINT [GroupID2] FOREIGN KEY ([GroupID]) REFERENCES [Group]([ID]), 
	Primary Key ([MeetingID],[GroupID])
)
