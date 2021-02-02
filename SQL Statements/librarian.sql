CREATE TABLE [dbo].[Librarian]
(
    [LibrarianID] AS ISNULL('LB' + CAST(ID AS NVARCHAR(6)), 'X') PERSISTED,
    [StudentID] INT NOT NULL, 
    [ID] INT IDENTITY (1,1) NOT NULL, 
    CONSTRAINT [PK_Librarian] PRIMARY KEY ([LibrarianID])
)