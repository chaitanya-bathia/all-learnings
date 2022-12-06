--Assignment 6.2

CREATE VIEW vwEmployeesInLondon
AS 
SELECT FIRST_NAME,LAST_NAME, JOB_TITLE, employees.DEPARTMENT_ID, departments.DEPARTMENT_NAME FROM employees
JOIN jobs
ON employees.JOB_ID = jobs.JOB_ID
JOIN departments
ON employees.DEPARTMENT_ID = departments.DEPARTMENT_ID
JOIN locations
ON departments.LOCATION_ID = locations.LOCATION_ID
WHERE locations.CITY = 'London'

SELECT FIRST_NAME, LAST_NAME, JOB_ID, DEPARTMENT_ID FROM employees
WHERE DEPARTMENT_ID = (SELECT DEPARTMENT_ID FROM departments
WHERE LOCATION_ID = (SELECT LOCATION_ID FROM locations
WHERE CITY = 'London'))

select * from vwEmployeesInLondon

CREATE VIEW vwDepartmentWiseCount
AS
SELECT d.DEPARTMENT_NAME, e.DEPARTMENT_ID, COUNT(EMPLOYEE_ID) AS EmployeeCount FROM employees e
JOIN departments d ON e.DEPARTMENT_ID = d.DEPARTMENT_ID
GROUP BY e.DEPARTMENT_ID,d.DEPARTMENT_NAME

CREATE VIEW vwEmployeesDaysWorked
AS
SELECT jh.EMPLOYEE_ID,j.JOB_TITLE, DATEDIFF(DAY,jh.START_DATE,jh.END_DATE) AS DaysWorked from job_history jh 
JOIN jobs j ON jh.JOB_ID = j.JOB_ID
WHERE jh.DEPARTMENT_ID= 90

SELECT * FROM vwEmployeesDaysWorked

