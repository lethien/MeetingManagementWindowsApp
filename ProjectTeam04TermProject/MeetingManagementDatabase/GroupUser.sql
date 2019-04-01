CREATE TABLE [dbo].[GroupUser]
(
	[GroupId] INT NOT NULL,
	[UserId] INT NOT NULL,
	PRIMARY KEY ([GroupId], [UserId]),
	FOREIGN KEY ([GroupId]) REFERENCES [Group] ([Id]),
	FOREIGN KEY ([UserId]) REFERENCES [User] ([Id])
)
