CREATE TABLE [dbo].[Students] (
    [Id]    INT           IDENTITY (1, 1) NOT NULL,
    [Name]  NVARCHAR (30) NOT NULL,
    [Phone] NVARCHAR (30) NOT NULL,
    CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED ([Id] ASC)
);
