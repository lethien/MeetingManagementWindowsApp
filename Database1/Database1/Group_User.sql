CREATE TABLE [dbo].[Group_User]
(	
	[GroupID] INT NOT NULL , 
    [UserID] INT NOT NULL, 
    CONSTRAINT [GroupID] FOREIGN KEY ([GroupID]) REFERENCES [Group]([Id]), 
    CONSTRAINT [UserId] FOREIGN KEY ([UserID]) REFERENCES [User]([Id]),
	Primary Key ([GroupID],[UserID])
)
