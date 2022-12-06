--Practice 7.3

WITH Sales_CTE(SalesPersonID,TotalSales,SalesYear)
AS
(
	SELECT SalesPersonID, SUM(TotalDue) AS TotalSales,YEAR(OrderDate) AS SalesYear FROM Sales.SalesOrderHeader
	WHERE SalesPersonID IS NOT NULL
	GROUP BY SalesPersonID, YEAR(OrderDate)
)
,

Sales_Quota_CTE(BusinessEntityID,SalesQuota,SalesQuotaYear)
AS
(
	SELECT BusinessEntityID, SUM(SalesQuota) AS SalesQuota,YEAR(QuotaDate) AS SalesQuotaYear FROM Sales.SalesPersonQuotaHistory
	GROUP BY BusinessEntityID,YEAR(QuotaDate)
)

SELECT 
SalesPersonID, 
SalesYear,
FORMAT(TotalSales,'C','en-us') AS TotalSales, 
SalesQuotaYear, 
FORMAT (SalesQuota,'C','en-us') AS SalesQuota,
FORMAT (TotalSales -SalesQuota, 'C','en-us') AS Amt_Above_or_Below_Quota
FROM Sales_CTE JOIN Sales_Quota_CTE
ON Sales_Quota_CTE.BusinessEntityID = Sales_CTE.SalesPersonID
AND Sales_CTE.SalesYear = Sales_Quota_CTE.SalesQuotaYear 

ORDER BY SalesPersonID,SalesYear