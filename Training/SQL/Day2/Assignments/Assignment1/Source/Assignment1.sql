UPDATE Employees
SET email = 'Not Available'

UPDATE Employees
SET email = 'Not Available', Commission = 0.10

INSERT INTO Department
VALUES
(
	110,
	'HouseKeeping'
)

INSERT INTO Department
VALUES
(
	80,
	'Accounting'
)

UPDATE Employees
SET Email = 'Not Available', Commission = 0.10
WHERE DepartmentID = 110

UPDATE Employees
SET Email = 'Not Available', Commission = 0.10
WHERE DepartmentID = 80 AND Commission<20

UPDATE Employees
SET Email = 'Not Available'
WHERE DepartmentID = 80

UPDATE Employees
SET Salary = 8000
WHERE EmployeeID = 105 AND Salary<5000


UPDATE Employees 
SET Salary= Salary+ Salary*0.25 
WHERE DepartmentID=40

UPDATE Employees 
SET Salary= Salary+ Salary*0.15 
WHERE DepartmentID=90

UPDATE Employees 
SET Salary= Salary+ Salary*0.10 
WHERE DepartmentID=110


/*Last Assignment*/

SELECT * FROM Employees /*Select all details*/

SELECT FirstName, LastName from Employees /*Select first and last name*/

SELECT FirstName AS 'Employee Name' from Employees /*Get first name as alias*/

SELECT * FROM Employees
WHERE FirstName = 'Steven' /*Get all details of employees whose first name is Steven */


SELECT * FROM Employees
WHERE FirstName = 'Neena' OR FirstName = 'Lex' /*Get all details of employees whose first name is Neena or Lex */

SELECT * FROM Employees
WHERE FirstName != 'Neena' AND FirstName != 'Lex' /*Get all details of employees whose first name is Not Neena And Lex */

SELECT * FROM Employees
WHERE Salary>=5000 AND Salary<=8000 /*Get all details of employees whose Salary is between 5000 and 8000  */

SELECT CONCAT(FirstName, LastName) AS EmployeeName, Salary, Salary*0.12 AS PF FROM Employees 

SELECT * FROM Employees
WHERE FirstName like 'N%' /*Get all details of employees whose name starts with N */

SELECT DISTINCT DepartmentID FROM Employees /*Get all unique department ID from employees*/


SELECT * FROM Employees
ORDER BY FirstName desc/*Write a query to get all employee details from the employee table order by FirstName, descending*/

SELECT * FROM Employees
ORDER BY Salary/*Write a query to get the EmployeeID, names (FirstName, LastName), salary in ascending order of salary*/

SELECT TOP 2 Salary FROM Employees