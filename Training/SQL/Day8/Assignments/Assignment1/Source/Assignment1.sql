CREATE CLUSTERED INDEX IX_EmployeeID
ON MyEmployees(EmployeeID)

CREATE NONCLUSTERED INDEX IX_ManagerID
ON MyEmployees(ManagerID)

SELECT * FROM MyEmployees
WITH(INDEX(IX_ManagerID))
WHERE ManagerID = 273

SELECT * FROM MyEmployees
WHERE ManagerID = 273