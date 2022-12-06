---   Tables Used
--    -   student  (studentid, name)
--    -   studentdetail (studentdetailid, studentid, standard, gender)
--    -   studentpresent (studentpresentid, studentid, month, present)
--    -   studenthours (studenthoursid, studentid, datex, hours)

--- Create above mentioned tables.

--- Insert appropriate records in the above tables.

CREATE TABLE STUDENTS
(
STUDENTID INT PRIMARY KEY,
NAME VARCHAR(30)
)
CREATE TABLE STUDENT_DETAIL
(
STUDENT_DETAIL_ID INT PRIMARY KEY,
STUDENT_ID INT FOREIGN KEY REFERENCES STUDENTS(STUDENTID),
STANDARD INT,
GENDER VARCHAR(30)
)
CREATE TABLE STUDENT_PRESENT
(
    STUDENT_PRESENT_ID INT PRIMARY KEY,
    STUDENT_ID INT FOREIGN KEY REFERENCES STUDENTS(STUDENTID),
    MONTH INT,
    PRESENT BIT
)
ALTER TABLE STUDENT_PRESENT
ALTER COLUMN PRESENT INT
CREATE TABLE STUDENT_HOURS
(
STUDENT_HOURS_ID INT PRIMARY KEY ,
STUDENT_ID INT FOREIGN KEY REFERENCES STUDENTS(STUDENTID),
DATEX DATE,
HOURS TIME
)
ALTER TABLE STUDENT_HOURS
ALTER COLUMN DATEX VARCHAR(30)
INSERT INTO STUDENTS
VALUES (1, 'Chaitanya'),
(2, 'Neha'),
(3, 'Tarmi'),
(4, 'Yesha'),
(5, 'Akshay')
INSERT INTO STUDENT_DETAIL
VALUES (101, 1, 12, 'M'),
(102, 2, 11, 'F'),
(103, 3, 10, 'F'),
(105, 4, 12, 'F'),
(104, 5, 12, 'M')


INSERT INTO STUDENT_PRESENT 
VALUES
(110, 1, 1, 20),
(111, 1, 3, 28),
(112, 1, 2, 25),
(113, 1, 4, 26),
(114, 1, 5, 24),
(115, 2, 1, 20),
(116, 2, 2, 19),
(117, 2, 3, 10),
(118, 2, 4, 25),
(119, 2, 5, 11),
(120, 3, 1, 21),
(121, 3, 2, 10),
(122, 3, 3, 15),
(123, 3, 4, 25),
(124, 3, 5, 21),
(125, 3, 6, 22),
(126, 4, 1, 10),
(127, 4, 2, 20),
(128, 4, 3, 30),
(129, 4, 4, 20),
(130, 4, 5, 5)

INSERT INTO STUDENT_HOURS
VALUES 
(1, 1, '2020-01-01', '08:00'),
(2, 1, '2022-02-01', '07:30'),
(3, 1, '2019-05-02', '08:30'),
(4, 2, '2020-01-01', '08:00'),
(5, 2, '2022-02-01', '07:30'),
(6, 2, '2019-05-02', '08:30'),
(7, 3, '2020-01-01', '08:00'),
(8, 3, '2022-02-01', '07:30'),
(9, 3, '2019-05-02', '08:30'),
(10, 4, '2020-01-01', '08:00'),
(11, 4, '2022-02-01', '07:30'),
(12, 4, '2019-05-02', '08:30')


--- Write queries for the following requirements.
    
--    -  Display following details for each student:
        
--        -   Name

--        -   Standard

--        -   Sex

--   NOTE : The same above headers should be displayed in the query & apply sorting on Name.
    
	SELECT S.NAME AS Name, SD.STANDARD AS Standard, SD.GENDER AS SEX FROM STUDENTS S JOIN STUDENT_DETAIL SD
	ON S.STUDENTID = SD.STUDENT_ID
	


--    -   Find SUM of student hours.

SELECT SUM(HOURS) FROM STUDENT_HOURS

--    -   Find Average Present of each student.

SELECT STUDENT_ID,AVG(PRESENT) FROM STUDENT_PRESENT
GROUP BY STUDENT_ID

--    -   Find Minimum present among all students.

SELECT MIN(PRESENT) FROM STUDENT_PRESENT

--    -   Find Maximum present among all students.
SELECT MAX(PRESENT) FROM STUDENT_PRESENT
--    -   Display fields like Name, Date, Hours from "studenthours" table where Date should be in following format :
        
--        -   DD/MM/YY

--        -   MM/DD/YY

--        -   YYYY-MM-DD

--        -   MM/DD Day   
   SELECT NAME, HOURS, FORMAT(DATEX, 'dd/MM/yy','en-US') AS 'Date(DD/MM/YY)', FORMAT(DATEX, 'MM/dd/yy', 'en-US') AS 'Date(MM/DD/YY)', DATEX AS 'Date(YYYY/MM/DD)' , FORMAT(DATEX,'MM/dd' , 'en-US') + ' ' + DATENAME(DW, DATEX) AS 'Date MM/DD Day' 
FROM STUDENT_HOURS SH JOIN STUDENT S
ON SH.STUDENT_ID = S.STUDENTID