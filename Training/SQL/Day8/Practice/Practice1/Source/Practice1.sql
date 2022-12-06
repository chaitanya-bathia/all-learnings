SELECT * FROM HumanResources.Employee
WHERE JobTitle = 'Production Supervisor - WC50'

CREATE INDEX IX_Job_Title
ON HumanResources.Employee (JobTitle)

SELECT * FROM HumanResources.Employee
WITH (INDEX(IX_Job_Title))
WHERE JobTitle = 'Production Supervisor - WC50' 

DROP INDEX IX_Job_Title
ON HumanResources.Employee