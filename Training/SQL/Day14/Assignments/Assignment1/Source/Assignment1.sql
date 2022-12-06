--Assignment 14

CREATE TABLE Student
(
	StudentID		int PRIMARY KEY,
	StudentName		varchar(50),
	TotalFees		int,
	RemainingAmt	int
)

CREATE TABLE Course
(
	CourseID	int PRIMARY KEY,
	CourseName	varchar(50),
	TotalFees	int
)

CREATE TABLE CourseEnrolled
(
	StudentID	int,
	CourseID	int
)

CREATE TABLE FeePayment
(
	StudentID		int,
	AmountPaid		int,
	DateOfPayment	date
)

--Creating Insert Trigger
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Chaitanya Bathia
-- Create date: 04-07-2022
-- Description:	Trigger to Update Total Fees of student as their enrollment is done in new course
-- =============================================
CREATE TRIGGER [dbo].[trgUpdateTotalFeesOnCourseEnrollment] 
   ON  [dbo].[CourseEnrolled] 
   AFTER INSERT 
AS 
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	UPDATE Student
	SET TotalFees = TotalFees + (SELECT TotalFees FROM Course WHERE CourseID = (SELECT CourseID FROM inserted)),
	RemainingAmt = RemainingAmt + (SELECT TotalFees FROM Course WHERE CourseID = (SELECT CourseID FROM inserted))
	WHERE StudentID = 
	(SELECT StudentID FROM inserted)
	PRINT 'FEES ADDED'
    -- Insert statements for trigger here

END
GO


INSERT INTO CourseEnrolled
VALUES
(
	1,1
)

SELECT * FROM Student

--Trigger Create for INSERT on FeesPayment

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Chaitanya Bathia
-- Create date: 04-07-2022
-- Description:	Trigger to insert fee amount into remaining fees for student
-- =============================================
CREATE TRIGGER [dbo].[trgInsertRemainingFees] 
   ON  [dbo].[FeePayment]
   AFTER INSERT
AS 
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	UPDATE Student
	SET RemainingAmt = RemainingAmt - (SELECT AmountPaid FROM inserted)
	WHERE StudentID = (SELECT StudentID FROM inserted)
	PRINT 'Fees Updated'
    -- Insert statements for trigger here

END
GO

INSERT INTO FeePayment
VALUES
(
	1,15000,'2022-07-04'
)
