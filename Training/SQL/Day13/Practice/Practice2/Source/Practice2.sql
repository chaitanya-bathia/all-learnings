--Practice 2
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Chaitanya Bathia
-- Create date: 01-07-2022
-- Description:	Function To Get Year to date sales of a product to a customer(Store)
-- =============================================
CREATE FUNCTION udf_SalesByStore 
(	
	-- Add the parameters for the function here
	@StoreID INT
)
RETURNS TABLE 
AS
RETURN 
(
	SELECT P.ProductID,P.Name, SUM(SD.LineTotal) AS 'Total'
	FROM Production.Product AS P
	JOIN Sales.SalesOrderDetail AS SD ON SD.ProductID = P.ProductID
	JOIN Sales.SalesOrderHeader AS SH ON SH.SalesOrderID = SD.SalesOrderID
	JOIN sales.Customer AS C ON SH.CustomerID = C.CustomerID
	WHERE C.StoreID = @StoreID
	GROUP BY P.ProductID, P.Name
)
GO


SELECT * FROM udf_SalesByStore(602)