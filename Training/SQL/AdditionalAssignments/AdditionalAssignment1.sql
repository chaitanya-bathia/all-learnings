-- ADDITIONAL ASSIGNMENT

---   Please create following tables:
    
--    -   Student_Details		
--        -   Name
--        -   Standard
--        -   Sex
--        -   Monthly Present
--        -   Daily Hours
    
--    -   PRODUCTS      
--        -   Name
--        -   Price
    
--    -   Materials        
--        -   Name
--        -   Price (allow to insert value like "Rs. 100")

CREATE TABLE Student_Details
(
	StudentID		INT	PRIMARY KEY,
	Name			VARCHAR(50),
	Standard		INT,
	Sex				VARCHAR(10) CHECK ( Sex IN ('MALE', 'FEMALE')),
	MonthlyPresent	INT CHECK ( MonthlyPresent BETWEEN 0 AND 30),
	DailyHours		INT CHECK (DailyHours BETWEEN 0 AND 6)
)

CREATE TABLE Products
(
	ProductID	INT IDENTITY(1,1),
	Name		VARCHAR(50),
	Price		MONEY
)

CREATE TABLE Materials
(
	MaterialID		INT IDENTITY(1,1),
	Name			VARCHAR(50),
	Price			VARCHAR(10)
)



--- Insert appropriate records in each tables.

INSERT INTO Student_Details
VALUES
(1, 'Jay', '7', 'MALE',25, 6),
(2, 'Ria', '9', 'FEMALE',28, 5),
(3, 'Yash', '10', 'MALE',29, 6)

INSERT INTO Products
VALUES
('Mobile', 15000),
('Headphones',1300),
('Charger',500)

INSERT INTO Materials
VALUES
('CEMENT', 'Rs. 1000'),
('BRICKS', 'Rs. 15000')

--- Display all the records for each tables separately.

SELECT * FROM Student_Details
SELECT * FROM Products
SELECT * FROM Materials

--- Remove all the records from each tables (with and without using DELETE statement).

DELETE FROM Student_Details
TRUNCATE TABLE Student_Details

DELETE FROM Products
TRUNCATE TABLE Products

DELETE FROM Materials
TRUNCATE TABLE Materials

--- Delete all the above tables.

DROP TABLE Student_Details
DROP TABLE Products
DROP TABLE Materials