CREATE TABLE [dbo].[customer] (
    [cId]         INT           IDENTITY (100, 1) NOT NULL,
    [roomid]      INT NOT NULL,
    [cname]       NVARCHAR (50) NOT NULL,
    [mobile]      NVARCHAR (50) NOT NULL,
    [nationality] NVARCHAR (50) NOT NULL,
    [gender]      NVARCHAR (50) NOT NULL,
    [idproof]     NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([cId] ASC), 
    CONSTRAINT [FK_customer_ToTable] FOREIGN KEY ([roomid]) REFERENCES [room]([roomId])
);

