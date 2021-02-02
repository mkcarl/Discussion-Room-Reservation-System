CREATE TABLE [dbo].[Students]
(
    [StudentID] INT NOT NULL IDENTITY(1,1) , 
    [Password] VARCHAR(50) NOT NULL, 
    [Surname] VARCHAR(50) NULL, 
    [GivenName] VARCHAR(50) NULL, 
    [EmailAddress] VARCHAR(50) NULL, 
    [Role] VARCHAR(10) NULL, 
    CONSTRAINT [PK_Students] PRIMARY KEY ([StudentID]),

)
