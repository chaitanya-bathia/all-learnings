SELECT LoginID FROM HumanResources.Employee
WHERE BirthDate>(SELECT BirthDate FROM HumanResources.Employee
WHERE BirthDate = '1984-07-31')

SELECT LoginID FROM HumanResources.Employee
WHERE BusinessEntityID IN (SELECT BusinessEntityID FROM HumanResources.EmployeeDepartmentHistory
WHERE DepartmentID = (SELECT DepartmentID FROM HumanResources.Department
WHERE Name = 'Purchasing'))