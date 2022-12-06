--ASSIGNMENT 6.1

SELECT * FROM EMPLOYEE
WHERE EXISTS
(SELECT Employee_Ref_ID FROM INCENTIVE)

SELECT Salary FROM EMPLOYEE
WHERE Salary > (SELECT Salary FROM EMPLOYEE
WHERE First_Name = 'Roy')

CREATE VIEW vwEmployeeIncentive
AS
SELECT First_Name, Last_Name, Salary, Joining_Date, INCENTIVE_DATE, INCENTIVE_AMOUNT FROM EMPLOYEE
JOIN INCENTIVE
ON EMPLOYEE.Employee_ID = INCENTIVE.Employee_Ref_ID

SELECT * FROM vwEmployeeIncentive

CREATE VIEW vwIncentiveMoreThan3000
AS
SELECT First_Name, INCENTIVE_AMOUNT FROM EMPLOYEE
JOIN INCENTIVE
ON EMPLOYEE.Employee_ID = INCENTIVE.Employee_Ref_ID
WHERE EXISTS(SELECT INCENTIVE_AMOUNT FROM INCENTIVE) AND INCENTIVE_AMOUNT>3000

SELECT * FROM vwIncentiveMoreThan3000