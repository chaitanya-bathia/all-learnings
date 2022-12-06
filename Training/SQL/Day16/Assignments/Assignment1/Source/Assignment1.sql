CREATE DATABASE UdemyProject

USE UdemyProject

CREATE TABLE Customer
(
	CustomerID		INT PRIMARY KEY,
	CustomerName	VARCHAR(255),
	ContactNo		VARCHAR(10),
	Email			VARCHAR(255)
)

CREATE TABLE Course
(
	CourseID		INT PRIMARY KEY,
	CourseName		VARCHAR(255),
	Subject			VARCHAR(255),
	Price			INT
)

CREATE TABLE Tutor
(
	TutorID		INT PRIMARY KEY,
	TutorName	VARCHAR(255),
	ContactNo	VARCHAR(10),
	Email		VARCHAR(255)
)

CREATE TABLE CourseWiseTutor
(
	ListingID	INT PRIMARY KEY,
	CourseID	INT FOREIGN KEY REFERENCES Course(CourseID),
	TutorID		INT FOREIGN KEY REFERENCES Tutor(TutorID)
)

CREATE TABLE CustomerSubscriptions
(
	SubscriptionID		INT PRIMARY KEY,
	CustomerID			INT FOREIGN KEY REFERENCES Customer(CustomerID),
	CourseID			INT FOREIGN KEY REFERENCES Course(CourseID),
	SubscriptionDate	DATE
)

---------------------------------------------------------------------------------

--Creating Stored Procedures


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Chaitanya Bathia
-- Create date: 06-07-2022
-- Description:	Stored Procedure to Get which Courses are subscribed by a particular Customer based on CustomerID
-- =============================================
CREATE PROCEDURE spGetCoursesByCustomerID
	-- Add the parameters for the stored procedure here
	@CustomerID INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SELECT C.CustomerName FROM CustomerSubscriptions CS
	JOIN Customer C ON CS.CustomerID = C.CustomerID
	JOIN Course ON CS.CourseID = Course.CourseID
    -- Insert statements for procedure here
	
END
GO
