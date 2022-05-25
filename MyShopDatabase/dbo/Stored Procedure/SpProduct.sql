CREATE PROCEDURE [dbo].[SpProduct]
AS
BEGIN

    set nocount on;
	SELECT Id, ProductName, ProductDescription, Quantity, SalePrice
	FROM Products
	ORDER BY ProductName

END
