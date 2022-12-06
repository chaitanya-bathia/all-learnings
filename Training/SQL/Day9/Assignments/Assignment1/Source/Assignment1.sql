CREATE TABLE Employee_Test(
Banking varchar(50),
Insurance varchar(50),
Services varchar(50)
)
SELECT Banking AS 'Bank_DEPT' FROM Employee_Test
SELECT Insurance AS 'Insurance_Dept'FROM Employee_Test
SELECT Services AS 'Services_Dept' FROM Employee_Test
GO

DECLARE @StudentData NVARCHAR(MAX)
SET @StudentData = N'[
{"Student_name":"Chaitanya","Address":"Jamnagar","City":"Ahmedabad","DOB":"2000-15-09","Standard":"8th"},
{"Student_name":"Parth","Address":"Anand","City":"Anand","DOB":"2000-01-09","Standard":"8th"},
{"Student_name":"Krutik","Address":"Anand","City":"Anand","DOB":"2000-04-06","Standard":"8th"},
{"Student_name":"Stuti","Address":"Ahmedabad","City":"Ahmedabad","DOB":"2000-19-04","Standard":"8th"},
{"Student_name":"Keyuri","Address":"Porbandar","City":"Ahmedabad","DOB":"1999-27-12","Standard":"8th"}
]';
SELECT Student_Name,Address,City,DOB,Standard FROM OPENJSON(@StudentData)
WITH (
Student_name VARCHAR(50) '$.Student_name',
Address VARCHAR(50) '$.Address',
City VARCHAR(50) '$.City',
DOB VARCHAR(50) '$.DOB',
Standard VARCHAR(50) '$.Standard'
) ;