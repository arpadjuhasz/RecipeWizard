CREATE TABLE [dbo].[RecipeIngredients] (
    [Id]                UNIQUEIDENTIFIER NOT NULL,
    [RecipeId]          UNIQUEIDENTIFIER NOT NULL,
    [IngredientId]      UNIQUEIDENTIFIER NOT NULL,
    [Quantity]          FLOAT (53)       NOT NULL,
    [MeasurementUnitId] UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_RecipeIngredients] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_RecipeIngredient_IngredientId] FOREIGN KEY ([IngredientId]) REFERENCES [dbo].[Ingredients] ([Id]),
    CONSTRAINT [Fk_RecipeIngredients_IngredientId] FOREIGN KEY ([IngredientId]) REFERENCES [dbo].[Ingredients] ([Id]),
    CONSTRAINT [Fk_RecipeIngredients_MeasurementUnitId] FOREIGN KEY ([MeasurementUnitId]) REFERENCES [dbo].[MeasurementUnits] ([Id])
);

