CREATE PROCEDURE [dbo].[SpEmployeeFind]
	@Id nvarchar(128)
AS
BEGIN

    set nocount on;
	SELECT Id, FirstName, LastName, EmailAddress, PhoneNumber, CreatedDate
	FROM Employee
	WHERE @Id = Id;
END
