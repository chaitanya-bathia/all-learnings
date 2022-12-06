CREATE TABLE Student
(
	StudentID	INT PRIMARY KEY,
	Name		VARCHAR(50),
	Address		VARCHAR(50),
	Board		VARCHAR(50)
)

INSERT INTO STUDENT
VALUES
(1,'A','Ahmedabad','CBSE'),
(2,'B','Calcutta','State'),
(3,'C','Delhi','State'),
(4,'D','Ahmedabad','CBSE')

CREATE TABLE Marks
(
	StudentID	INT,
	Science		INT,
	Math		INT,
	English		INT,
	Average		DECIMAL(5,2),
	GRADE		VARCHAR(3)
)
GO


CREATE PROCEDURE SP_UpdateGrade
AS
BEGIN
	UPDATE M
	SET Average = 
	 IIF(S.Board = 'State',(M.Science*0.4)+(M.Math*0.4)+(M.English*0.2),(M.Science*0.5)+(M.Math*0.4)+(M.English*0.1))

	FROM MARKS M 
	JOIN STUDENT S
	ON M.StudentID = S.StudentID

	UPDATE M
	SET GRADE = 
	IIF(S.Board = 'State',
	CASE 
        WHEN M.Average >= 80 THEN 'A+'
        WHEN M.Average >= 60 THEN 'A'
        WHEN M.Average >= 50 THEN 'B'
        WHEN M.Average >= 35 THEN 'C'
        WHEN M.Average < 35 THEN 'D'
        ELSE 'AVERAGE IS UNDER 30'
    END, 
    CASE 
        WHEN M.Average >= 95 THEN 'A+'
        WHEN M.Average >= 85 THEN 'A'
        WHEN M.Average >= 75 THEN 'B'
        WHEN M.Average > 50 THEN 'C'
        WHEN M.Average < 50 THEN 'D'
        ELSE 'AVERAGE IS UNDER 40'
    END
	)
	FROM MARKS M
	JOIN STUDENT S
	ON M.StudentID = S.StudentID
END


EXEC SP_UpdateGrade

SELECT * FROM Marks