CREATE TABLE [dbo].[Student]
(
	[StudentID] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [Password] VARCHAR(50) NOT NULL, 
    [Surname] VARCHAR(50) NULL, 
    [GivenName] VARCHAR(50) NULL, 
    [EmailAddress] VARCHAR(50) NULL, 
    [Role] VARCHAR(10) NULL, 
    CONSTRAINT [FK_Student_Librarian] FOREIGN KEY ([StudentID]) REFERENCES [Librarian]([StudentID]),
	
)
