/*Assignment 3*/

SELECT FirstName, LEN(FirstName) FROM Employees
WHERE FirstName like 'A%' OR FirstName like 'J%' OR FirstName like 'M%'

SELECT FirstName, '$'+FORMAT(Salary,'0000000000') FROM Employees

SELECT EmployeeID, FirstName, LastName, HireDate FROM Employees
WHERE Month(HireDate)=7 OR Day(HireDate)=7

SELECT LastName FROM Employees

SELECT FirstName FROM Employees
WHERE LastName LIKE '%c%'

SELECT RIGHT(PhoneNumber,4) FROM Employees

SELECT REPLACE(PhoneNumber, '124','999')FROM Employees

ALTER TABLE Employees
ADD DateOfBirth varchar(50)

UPDATE Employees SET DateOfBirth = '1989/12/13' WHERE EmployeeID=1

UPDATE Employees SET DateOfBirth = '1960/10/10' WHERE EmployeeID=2

UPDATE Employees SET DateOfBirth = '1990/12/04' WHERE EmployeeID=3

UPDATE Employees SET DateOfBirth = '1960/10/26' WHERE EmployeeID=4

UPDATE Employees SET DateOfBirth = '1995/12/30' WHERE EmployeeID=5

UPDATE Employees SET DateOfBirth = '1960/12/08' WHERE EmployeeID=35

UPDATE Employees SET DateOfBirth = '1997/2/14' WHERE EmployeeID=105

UPDATE Employees SET DateOfBirth = '1990/12/04' WHERE EmployeeID=150

UPDATE Employees SET DateOfBirth = '1960/10/26' WHERE EmployeeID=251

ALTER TABLE Employees
ADD Age int

UPDATE Employees
SET Age = DATEDIFF(YEAR,DateOfBirth,GETDATE()) FROM Employees


UPDATE Employees SET HireDate = '2004/3/15' WHERE EmployeeID=1

UPDATE Employees SET HireDate = '1990/4/10' WHERE EmployeeID=2

UPDATE Employees SET HireDate = '2018/12/12' WHERE EmployeeID=3

UPDATE Employees SET HireDate = '1994/5/26' WHERE EmployeeID=4

UPDATE Employees SET HireDate = '2015/12/30' WHERE EmployeeID=5

UPDATE Employees SET HireDate = '2000/12/08' WHERE EmployeeID=35

UPDATE Employees SET HireDate = '2019/2/11' WHERE EmployeeID=105

UPDATE Employees SET HireDate = '2020/12/04' WHERE EmployeeID=150

UPDATE Employees SET HireDate = '1986/10/22' WHERE EmployeeID=251

SELECT HireDate FROM Employees
WHERE DATENAME(dw, HireDate) = 'Monday'

SELECT FirstName, HireDate FROM Employees
WHERE HireDate BETWEEN '1987-06-01' AND '1987-07-30'

SELECT FirstName, LastName FROM Employees
WHERE DATENAME(MM,HireDate) = 'June'

SELECT FirstName, HireDate, DATEDIFF(YEAR,HireDate,GETDATE()) AS Experience FROM Employees

SELECT FirstName FROM Employees
WHERE DATEPART(YEAR,HireDate) = 1987