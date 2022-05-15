CREATE TABLE [dbo].[Products]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY (10000 , 1),
	[ProductName] nvarchar(100) NOT NULL,
	[ProductDescription] nvarchar(MAX) NOT NULL,
	[EnteredDate] DateTime  DEFAULT getutcdate(),
	[Quantity] INT NOT NULL
)
