CREATE TABLE [dbo].[Reservations]
(
	[ReservationsID] VARCHAR(MAX) NOT NULL,
    [ApprovalStatus] VARCHAR(7) NOT NULL, 
    [Comments] TEXT NOT NULL, 
    [RoomID] INT NOT NULL, 
    [Pax] INT NOT NULL, 
    [ID] INT NULL, 
    CONSTRAINT [PK_Reservations] PRIMARY KEY ([ReservationsID]),

)
