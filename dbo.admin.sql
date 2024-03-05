CREATE TABLE [dbo].[admin] (
    [id]       INT           IDENTITY (1, 1) NOT NULL,
    [username] VARCHAR (MAX) NULL,
    [passowrd] VARCHAR (MAX) NULL,
    [bet] INT NULL, 
    [BackGround] VARCHAR(MAX) NULL, 
    PRIMARY KEY CLUSTERED ([id] ASC)
);

