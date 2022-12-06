
WITH Rank_CTE(Salary,SalaryRank)
AS
(
	SELECT Salary ,RANK() OVER(ORDER BY Salary DESC)Rank
	FROM employees
)

SELECT * FROM Rank_CTE

WITH SalaryRank_CTE (FirstName, Salary, SalaryRank)
AS
(
	SELECT * FROM(SELECT FirstName, Salary, dense_rank()
	OVER(ORDER BY salary DESC)rank FROM employees) AS DTC
)

SELECT * FROM SalaryRank_CTE
WHERE SalaryRank = 4