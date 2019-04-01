CREATE TABLE [dbo].[MeetingGroup]
(
	[MeetingId] INT NOT NULL,
	[GroupId] INT NOT NULL,
	PRIMARY KEY ([MeetingId], [GroupId]),
	FOREIGN KEY ([MeetingId]) REFERENCES [Meeting] ([Id]),
	FOREIGN KEY ([GroupId]) REFERENCES [Group] ([Id])
)
