CREATE TABLE Jobs
(
	JobID int PRIMARY KEY,
	JobTitle varchar(50) DEFAULT '',
	MinSalary int DEFAULT 8000,
	MaxSalary int
)