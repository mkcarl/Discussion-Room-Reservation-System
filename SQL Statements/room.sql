CREATE TABLE [dbo].[Room]
(
	[RoomID] AS ISNULL('RM' + CAST(ID AS VARCHAR(MAX)), 'X') PERSISTED,
    [Capacity] INT NOT NULL, 
    [TimeSlot] TIMESTAMP NOT NULL, 
    [Booked] VARCHAR(3) NOT NULL, 
    [RoomName] VARCHAR(15) NOT NULL, 
    [ID] INT NULL, 
    CONSTRAINT [PK_Room] PRIMARY KEY ([RoomID]), 
    
)
