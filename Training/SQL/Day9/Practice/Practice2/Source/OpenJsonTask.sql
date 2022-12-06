create table #information
(
id int,
 firstName varchar(100), 
 lastName varchar(100), 
 age int,
dateOfBirth date, 
skill varchar(100)
)

DECLARE @json NVARCHAR(MAX);
SET @json = N'[  
  {"id": 2, "info": {"name": "John", "surname": "Smith"}, "age": 25},
  {"id": 5, "info": {"name": "Jane", "surname": "Smith", "skills": ["SQL", "C#", "Azure"]}, "dob": "2005-11-04T12:00:00"}  
]';
insert into #information 
SELECT  id, firstName, lastName, age, dateOfBirth, skills
FROM OPENJSON(@json)  
  WITH (
    id INT 'strict $.id',
    firstName NVARCHAR(50) '$.info.name',
    lastName NVARCHAR(50) '$.info.surname',  
    age INT,
    dateOfBirth DATETIME2 '$.dob',
    skills NVARCHAR(MAX) '$.info.skills' AS JSON
  )
  select * from #information

  create table #personal (
    id INT ,
    firstName NVARCHAR(50) ,
    lastName NVARCHAR(50) ,
    age INT,
    dateofBirth DATETIME2 ,
)

create table #skills (
    id INT ,
    skills nvarchar(max)
)

  insert into #personal 
  select id, firstName, lastName, age, dateOfBirth  from #information
  group by id,firstName,lastName,age,dateOfBirth

  insert into #skills
  select id,skill  from #information where skill is not null

  delete from #information
    delete from #skills
    delete from #personal

  select * from #information
  select * from #skills
  select * from #personal

DECLARE @SkillArray varchar(MAX);

CREATE TABLE #newtab
(
	Skills VARCHAR(MAX)
)

INSERT INTO #newtab(Skills)
SELECT * FROM STRING_SPLIT( '["SQL","C#","Azure"]', ',')


UPDATE #newtab 
SET Skills = 
TRIM('[]"' FROM Skills) FROM #newtab

select COUNT(*) from #newtab

DECLARE @NumberOfSkills int
SET @NumberOfSkills = SELECT COUNT(*) from #newtab

WHILE 

select * from #skills