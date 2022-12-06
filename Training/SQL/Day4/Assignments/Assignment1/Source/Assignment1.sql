--Assignment 4

SELECT Salary ,RANK() OVER(ORDER BY Salary DESC)Rank
FROM employees

SELECT * FROM(SELECT FirstName, Salary, dense_rank()
OVER(ORDER BY salary DESC)rank FROM employees) AS TBL
WHERE rank = 4

SELECT DepartmentId,SUM(Salary) TOTAL_SALARY FROM employees GROUP BY DepartmentId

SELECT DepartmentId, SUM (Salary) TOTAL_SALARY FROM employees GROUP BY DepartmentId
ORDER BY TOTAL_SALARY DESC

SELECT DepartmentId, MAX(Salary)MAXSALARY FROM employees GROUP BY DepartmentId
ORDER BY MAXSALARY ASC

SELECT DepartmentId, MIN(Salary)MINSALARY FROM employees GROUP BY DepartmentId
ORDER BY MINSALARY ASC

SELECT DepartmentId,SUM(Salary) TOTAL_SALARY FROM employees GROUP BY DepartmentId
HAVING SUM(Salary) >50000 ORDER BY TOTAL_SALARY DESC