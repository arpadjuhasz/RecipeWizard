CREATE TABLE [dbo].[Recipes] (
    [Id]          UNIQUEIDENTIFIER NOT NULL,
    [Description] TEXT             NOT NULL,
    [Name]        NVARCHAR (50)    NULL,
    CONSTRAINT [PK_Recipes] PRIMARY KEY CLUSTERED ([Id] ASC)
);

