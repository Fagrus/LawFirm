CREATE TABLE [dbo].[Pro_tbl] (
    [Id]      INT  IDENTITY (1, 1) NOT NULL,
    [Name]    TEXT NULL,
    [Surname] TEXT NULL,
    [IV] NTEXT NOT NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

