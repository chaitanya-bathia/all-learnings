--Assignment 13.2
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Chaitanya Bathia
-- Create date: 01-07-2022
-- Description:	Function To Calculate PT on basis of MonthlySalary
-- =============================================
CREATE FUNCTION udf_CalculatePT
(
	-- Add the parameters for the function here
	@MonthlySalary int
)
RETURNS int
AS
BEGIN
	-- Declare the return variable here
	DECLARE @PT int

	-- Add the T-SQL statements to compute the return value here
	SET @PT = CASE
	WHEN @MonthlySalary < 6000 THEN 0
	WHEN @MonthlySalary >= 6000 AND @MonthlySalary < 9000 THEN 80
	WHEN @MonthlySalary >= 9000 AND @MonthlySalary < 12000 THEN 150
	ELSE 200
	END

	-- Return the result of the function
	RETURN @PT

END
GO

PRINT dbo.udf_CalculatePT(6500)