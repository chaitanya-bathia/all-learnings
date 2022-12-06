CREATE TABLE Employees(
Employee_Id int PRIMARY KEY,
FirstName varchar(50),
LastName varchar(50),
Email varchar(100),
PhoneNumber int,
HireDate date,
JobID int FOREIGN KEY REFERENCES Jobs(JobID),
Salary int,
Comission int,
ManagerID int,
DepartmentID int FOREIGN KEY REFERENCES Department(DepartmentID)
)