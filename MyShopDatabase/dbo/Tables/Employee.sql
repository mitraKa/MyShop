CREATE TABLE [dbo].[Employee]
(
	[Id] NVARCHAR(128) NOT NULL PRIMARY KEY,
	[FirstName] NVARCHAR(50) NOT NULL,
	[LastName] NVARCHAR(50) NOT NULL,
	[EmailAddress] NVARCHAR(100) NOT NULL,
	[PhoneNumber] NVARCHAR(11),
	[CreatedDate] DateTime NOT NULL DEFAULT getutcdate()
)
