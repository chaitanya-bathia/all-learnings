--Practice 3
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Chaitanya Bathia
-- Create date: 01-07-2022
-- Description:	Function To Get employees who directly or indirectly report to the employee whose ID is passed as input.
-- =============================================
CREATE FUNCTION udf_FindReports 
(
	-- Add the parameters for the function here
	@InEmpID INT
)
RETURNS 
@retFindReports TABLE 
(
	-- Add the column definitions for the TABLE variable here
	EmployeeID int primary key NOT NULL,
	FirstName nvarchar(255) NOT NULL,
	LastName nvarchar(255) NOT NULL,
	JobTitle nvarchar(50) NOT NULL,
	RecursionLevel int NOT NULL
)
AS
BEGIN
	-- Fill the table variable with the rows for your result set
	WITH EMP_cte(EmployeeID, OrganizationNode, FirstName, LastName, JobTitle, RecursionLevel)
	AS
	(
		SELECT e.BusinessEntityID, e.OrganizationNode, p.FirstName, p.LastName, e.JobTitle, 0
		FROM HumanResources.Employee e
		INNER JOIN Person.Person p
		ON P.BusinessEntityID = e.BusinessEntityID
		WHERE e.BusinessEntityID = @InEmpID

		UNION ALL
		SELECT e.BusinessEntityID, e.OrganizationNode, p.FirstName, p.LastName, e.JobTitle, RecursionLevel + 1
		FROM HumanResources.Employee e
		INNER JOIN EMP_cte
		ON e.OrganizationNode.GetAncestor(1) = EMP_cte.OrganizationNode
		INNER JOIN Person.Person p 
		ON e.BusinessEntityID = p.BusinessEntityID
	)
	INSERT @retFindReports
	SELECT EmployeeID, FirstName, LastName, JobTitle, RecursionLevel
	FROM EMP_cte
	RETURN 
END
GO

SELECT EmployeeID, FirstName, LastName, JobTitle, RecursionLevel
FROM dbo.udf_FindReports(2);