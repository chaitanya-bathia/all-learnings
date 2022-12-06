CREATE TABLE JobHistory
(
	EmployeeID int PRIMARY KEY,
	StartDate varchar(10),
	EndDate varchar(10) CHECK (EndDate like '[0-9][0-9]/[0-9][0-9]/[0-9][0-9][0-9][0-9]'),
	JobID int,
	DepartmentID int
)