CREATE TABLE dbo.MyEmployees  
(  
EmployeeID SMALLINT NOT NULL,  
FirstName NVARCHAR(30)  NOT NULL,  
LastName  NVARCHAR(40) NOT NULL,  
Title NVARCHAR(50) NOT NULL,  
DeptID SMALLINT NOT NULL,  
ManagerID SMALLINT NULL,  
 CONSTRAINT PK_EmployeeID PRIMARY KEY CLUSTERED (EmployeeID ASC),
 CONSTRAINT FK_MyEmployees_ManagerID_EmployeeID FOREIGN KEY (ManagerID) REFERENCES dbo.MyEmployees (EmployeeID)
);  
-- Populate the table with values.  
INSERT INTO dbo.MyEmployees VALUES   
 (1, N'Ken', N'Sánchez', N'Chief Executive Officer',16,NULL)  
,(273, N'Brian', N'Welcker', N'Vice President of Sales',3,1)  
,(274, N'Stephen', N'Jiang', N'North American Sales Manager',3,273)  
,(275, N'Michael', N'Blythe', N'Sales Representative',3,274)  
,(276, N'Linda', N'Mitchell', N'Sales Representative',3,274)  
,(285, N'Syed', N'Abbas', N'Pacific Sales Manager',3,273)  
,(286, N'Lynn', N'Tsoflias', N'Sales Representative',3,285)  
,(16,  N'David',N'Bradley', N'Marketing Manager', 4, 273)  
,(23,  N'Mary', N'Gibson', N'Marketing Specialist', 4, 16);  


WITH DirectReports(ManagerID, EmployeeID, Title, EmployeeLevel) AS   
(  
    SELECT ManagerID, EmployeeID, Title, 0 AS EmployeeLevel  
    FROM dbo.MyEmployees   
    WHERE ManagerID IS NULL  
    UNION ALL  
    SELECT e.ManagerID, e.EmployeeID, e.Title, EmployeeLevel + 1  
    FROM dbo.MyEmployees AS e  
        INNER JOIN DirectReports AS d  
        ON e.ManagerID = d.EmployeeID   
)  
SELECT ManagerID, EmployeeID, Title, EmployeeLevel   
FROM DirectReports  
ORDER BY ManagerID;

--Using Recursive CTE

WITH DirectReports(Name, Title, EmployeeID, EmployeeLevel, Sort)  
AS (SELECT CONVERT(VARCHAR(255), e.FirstName + ' ' + e.LastName),  
        e.Title,  
        e.EmployeeID,  
        1,  
        CONVERT(VARCHAR(255), e.FirstName + ' ' + e.LastName)  
    FROM dbo.MyEmployees AS e  
    WHERE e.ManagerID IS NULL  
    UNION ALL  
    SELECT CONVERT(VARCHAR(255), REPLICATE ('|    ' , EmployeeLevel) +  
        e.FirstName + ' ' + e.LastName),  
        e.Title,  
        e.EmployeeID,  
        EmployeeLevel + 1,  
        CONVERT (VARCHAR(255), RTRIM(Sort) + '|    ' + FirstName + ' ' +   
                 LastName)  
    FROM dbo.MyEmployees AS e  
    JOIN DirectReports AS d ON e.ManagerID = d.EmployeeID  
    )  
SELECT EmployeeID, Name, Title, EmployeeLevel  
FROM DirectReports   
ORDER BY Sort;

WITH AllEmployees_CTE(EmployeeID, FirstName, Title, ManagerID)
AS 
(
	SELECT EmployeeID, FirstName, Title, ManagerID FROM MyEmployees
)

SELECT EmployeeID,FirstName,Title,ManagerID FROM AllEmployees_CTE

--Using MaxRecursion

WITH cte(EmployeeID, ManagerID, Title)
AS
(
	SELECT EmployeeID, ManagerID, Title
	FROM MyEmployees
	WHERE ManagerID IS NOT NULL

	UNION ALL

	SELECT cte.EmployeeID,cte.ManagerID,cte.Title FROM cte
	JOIN dbo.MyEmployees AS e
	ON cte.ManagerID = e.EmployeeID
)

SELECT EmployeeID,ManagerID, Title FROM cte
OPTION(MAXRECURSION 2)

--Fixing Recursion

WITH cte(EmployeeID, ManagerID, Title)
AS
(
	SELECT EmployeeID, ManagerID, Title
	FROM MyEmployees
	WHERE ManagerID IS NOT NULL

	UNION ALL

	SELECT e.EmployeeID,e.ManagerID,e.Title FROM cte
	JOIN dbo.MyEmployees AS e
	ON cte.ManagerID = e.EmployeeID
)

SELECT EmployeeID,ManagerID, Title FROM cte

