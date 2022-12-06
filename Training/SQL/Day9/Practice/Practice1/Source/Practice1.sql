--While, If-else, Case, variables

SELECT * FROM MyEmployees

SELECT * FROM HumanResources.Employee

SELECT * FROM HumanResources.EmployeeDepartmentHistory

GO

DECLARE @NewNumber int

SET @NewNumber = 4

IF @NewNumber%2=0
PRINT CAST(@NewNumber AS varchar(10)) + ' is even'
ELSE

PRINT CAST(@NewNumber AS varchar(10)) + ' is odd'


DECLARE @NewNumber int
SET @NewNumber = 4
WHILE @NewNumber>0
BEGIN
PRINT @NewNumber
SET @NewNumber -=1
END


SELECT ProductLine FROM Production.Product
Where ProductLine IS NOT NULL

SELECT   ProductNumber, Category =  
      CASE ProductLine  
         WHEN 'R' THEN 'Road'  
         WHEN 'M' THEN 'Mountain'  
         WHEN 'T' THEN 'Touring'  
         WHEN 'S' THEN 'Other sale items'  
         ELSE 'Not for sale'  
      END,  
   Name  
FROM Production.Product  
ORDER BY ProductNumber;