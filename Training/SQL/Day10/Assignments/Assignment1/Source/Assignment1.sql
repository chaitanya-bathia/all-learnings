--SELECT * FROM Employees


SET NOCOUNT ON
DECLARE @EmployeeID int, @FirstName varchar(MAX),@LastName varchar(MAX),@Salary int
DECLARE CUR_SalaryIncrease CURSOR STATIC
FOR SELECT EmployeeID,FirstName,LastName,Salary FROM Employees
OPEN CUR_SalaryIncrease
IF @@CURSOR_ROWS > 0
BEGIN
WHILE @@FETCH_STATUS=0
BEGIN
PRINT 'Running'
FETCH NEXT FROM CUR_SalaryIncrease into @EmployeeID, @FirstName,@LastName, @Salary
PRINT 'CURSOR RUNNING'
PRINT @Salary
-------------
IF @Salary BETWEEN 30000 AND 40000
BEGIN
UPDATE Employees
SET Salary = @Salary + 5000
WHERE EmployeeID = @EmployeeID
END
-------------
ELSE IF @Salary BETWEEN 40000 AND 55000
BEGIN
UPDATE Employees
SET Salary = @Salary + 7000
WHERE EmployeeID = @EmployeeID
END
-------------
ELSE IF @Salary BETWEEN 55000 AND 65000
BEGIN
UPDATE Employees
SET Salary = @Salary + 9000
WHERE EmployeeID = @EmployeeID
END
-------------
PRINT @Salary
--FETCH NEXT FROM CUR_SalaryIncrease into @EmployeeID, @FirstName,@LastName, @Salary
END
END

CLOSE CUR_SalaryIncrease
DEALLOCATE CUR_SalaryIncrease
SET NOCOUNT OFF