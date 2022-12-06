SELECT DENSE_RANK() OVER (ORDER BY FirstName), FirstName FROM Employees

SELECT RANK() OVER (ORDER BY FirstName), FirstName FROM Employees

SELECT ROW_NUMBER() OVER (ORDER BY FirstName) FROM Employees