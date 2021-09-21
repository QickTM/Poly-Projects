CREATE TABLE [dbo].[UserTable] (
    [UserID]      INT          IDENTITY (100, 1) NOT NULL,
    [Username]    VARCHAR (50) NULL,
    [Password]    VARCHAR (50) NULL,
    [WinRate]     FLOAT NULL,
    [Points]      INT          NULL,
    PRIMARY KEY CLUSTERED ([UserID] ASC)
);

