CREATE TABLE [dbo].[Product]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NCHAR(10) NULL, 
    [Description] NCHAR(10) NULL, 
    [Price] DECIMAL NULL, 
    [CategoryId] INT NOT NULL ,
    [SKU] NCHAR(10) NULL, 
    CONSTRAINT [FK_Product_Category] FOREIGN KEY ([CategoryId]) REFERENCES [Category]([Id])
)

