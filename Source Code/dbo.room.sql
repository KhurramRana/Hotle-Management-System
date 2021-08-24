CREATE TABLE [dbo].[room] (
    [roomId]   INT           NOT NULL,
    [roomno]   NVARCHAR (50) NOT NULL,
    [roomtype] NVARCHAR (50) NOT NULL,
    [bed]      NVARCHAR (50) NOT NULL,
    [price]    NVARCHAR (50) NOT NULL,
    [booked]   NVARCHAR (50) NOT NULL DEFAULT _no ,
     
    PRIMARY KEY CLUSTERED ([roomId] ASC)
);

