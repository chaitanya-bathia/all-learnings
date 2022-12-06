DECLARE @Data varchar(MAX)
SET @Data = '[
  {
    "name": "John",
    "skills": ["SQL", "C#", "Azure"]
  },
  {
    "name": "Jane",
    "surname": "Doe"
  }
]'

SELECT ISJSON(@Data)

DECLARE @JSONObject varchar(max)
SET @JSONObject = '{
   "info": {
      "type": 1,
      "address": {
         "town": "Cheltenham",
         "county": "Gloucestershire",
         "country": "England"
      },
      "tags": ["Sport", "Water polo"]
   },
   "type": "Basic"
} '
DECLARE @Skills varchar(MAX)

SET @Skills = JSON_QUERY(@JSONObject, '$.info.tags' )

SELECT @Skills

SELECT JSON_VALUE(@JSONObject,'$.info.address.town')

SET @JSONObject = JSON_MODIFY(@JSONObject, '$.info.address.county','Worcestershire')

SELECT JSON_VALUE(@JSONObject,'$.info.address.county')


DECLARE @NewData varchar(MAX)
SET @NewData = '[
  {
    "name": "John",
    "skills": ["SQL", "C#", "Azure"]
  },
  {
    "name": "Jane",
    "surname": "Doe"
  }
]'

SELECT * FROM OPENJSON(@NewData)
WITH (name nvarchar(max) '$.name',
		surname nvarchar(max) '$.surname',
	skills nvarchar(max) '$.skills' AS JSON)




SELECT * FROM HumanResources.Employee FOR JSON AUTO

SELECT * FROM HumanResources.Employee FOR JSON PATH


SELECT * FROM HumanResources.Employee FOR JSON AUTO, WITHOUT_ARRAY_WRAPPER