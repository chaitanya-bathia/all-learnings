CREATE PROCEDURE PRC_EmployeeDepartment @EmpID int = NULL
AS
BEGIN
IF(@EmpID IS NULL)
BEGIN
SELECT DISTINCT Name FROM HumanResources.Department D JOIN HumanResources.EmployeeDepartmentHistory ED
ON D.DepartmentID = ED.DepartmentID
END
ELSE
BEGIN
SELECT Name FROM HumanResources.Department D JOIN HumanResources.EmployeeDepartmentHistory ED
ON D.DepartmentID = ED.DepartmentID
WHERE ED.BusinessEntityID = @EmpID
END
END


EXEC PRC_EmployeeDepartment 32
