SELECT EmployeeID,FirstName,Employees.DepartmentID,Department.DepartmentID,DepartmentName FROM Employees 
INNER JOIN Department
ON Department.DepartmentID = Employees.DepartmentID