CREATE TABLE [dbo].[MeetingUser]
(
	[MeetingId] INT NOT NULL,
	[UserId] INT NOT NULL,
	PRIMARY KEY ([MeetingId], [UserId]),
	FOREIGN KEY ([MeetingId]) REFERENCES [Meeting] ([Id]),
	FOREIGN KEY ([UserId]) REFERENCES [User] ([Id])
)
