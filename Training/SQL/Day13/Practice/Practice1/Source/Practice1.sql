--Practice 1
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Chaitanya Bathia
-- Create date: 01-07-2022
-- Description:	Function To Get Stock of a product based on product ID
-- =============================================
CREATE FUNCTION udfGetStock 
(
	-- Add the parameters for the function here
	@ProductID INT
)
RETURNS INT
AS
BEGIN
	-- Declare the return variable here
	DECLARE @Stock INT

	-- Add the T-SQL statements to compute the return value here
	SELECT @Stock = SUM(Quantity) FROM Production.ProductInventory WHERE ProductID = @ProductID

	-- Return the result of the function
	RETURN @Stock

END
GO

SELECT * FROM Production.ProductInventory

DECLARE @StockCount INT
SET @StockCount = dbo.udfGetStock(2)
PRINT @StockCount

SELECT ProductModelID, Name, dbo.udfGetStock(ProductID)AS CurrentSupply
FROM Production.Product
WHERE ProductModelID BETWEEN 75 and 80;
