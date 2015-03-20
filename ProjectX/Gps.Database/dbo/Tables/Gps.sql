CREATE TABLE [dbo].[Gps] (
    [ID]            UNIQUEIDENTIFIER NOT NULL,
    [Code]          VARCHAR (50)     NULL,
    [Description]   NVARCHAR (500)   NULL,
    [LastChanged]   DATETIME         NULL,
    [LastChangedBy] UNIQUEIDENTIFIER NULL,
    CONSTRAINT [PK_Gps] PRIMARY KEY CLUSTERED ([ID] ASC)
);

