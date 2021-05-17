CREATE TABLE [dbo].[Category]
(
	[CategoryId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NCHAR(25) NULL, 
    [SKURange] NCHAR(10) NULL
)
CREATE TABLE [dbo].[Product]
(
	[ProductId] INT NOT NULL PRIMARY KEY IDENTITY , 
    [Name] NCHAR(50) NULL, 
    [Description] NCHAR(250) NULL, 
    [Price] DECIMAL NULL, 
    [CategoryId] INT NOT NULL ,
    [SKU] NCHAR(10) NULL, 
    FOREIGN KEY(CategoryId) REFERENCES Category(CategoryId)
)
