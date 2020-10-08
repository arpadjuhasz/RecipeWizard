CREATE TABLE [dbo].[MeasurementUnits] (
    [Id]   UNIQUEIDENTIFIER NOT NULL,
    [Name] NVARCHAR (30)    NULL,
    CONSTRAINT [PK_MeasurementUnits] PRIMARY KEY CLUSTERED ([Id] ASC)
);

