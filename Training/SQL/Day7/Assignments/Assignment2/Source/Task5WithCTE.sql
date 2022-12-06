WITH DateDiff_CTE(First_Name,Last_Name,DateDifference)
AS
(
	SELECT First_Name,Last_Name,DATEDIFF(DAY,EMPLOYEE.Joining_Date,INCENTIVE.INCENTIVE_DATE) FROM EMPLOYEE
	RIGHT JOIN INCENTIVE
	ON EMPLOYEE.Employee_ID = INCENTIVE.Employee_Ref_ID
)
SELECT First_name,Last_name,DateDifference from DateDiff_CTE


WITH EmployeesIncentive_CTE(First_Name,Incentive)
AS
(
	SELECT First_Name, INCENTIVE_AMOUNT FROM EMPLOYEE
	RIGHT JOIN INCENTIVE
	ON EMPLOYEE.Employee_ID = INCENTIVE.Employee_Ref_ID
)
SELECT First_name,Incentive FROM EmployeesIncentive_CTE WHERE INCENTIVE> 3000


WITH AllIncentive_CTE 
AS
(
	SELECT First_Name,INCENTIVE_AMOUNT FROM EMPLOYEE
	LEFT JOIN INCENTIVE
	ON EMPLOYEE.Employee_ID = INCENTIVE.Employee_Ref_ID
)
SELECT * FROM AllIncentive_CTE


WITH EmployeeManager_CTE 
AS
(
	SELECT emp.First_name,emp.Manager_Id from employee as emp
)
SELECT * FROM EmployeeManager_CTE


WITH ReplaceNullWithZero_CTE 
AS
(
	SELECT * FROM employee as emp full OUTER JOIN incentive as inc 
	on emp.Employee_ID = inc.Employee_Ref_ID
)

SELECT Employee_ID,First_name,isnull(Incentive_amount,0) as incentive_amount from ReplaceNullWithZero_CTE where Incentive_amount is NULL