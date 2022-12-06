--Assignment 13.1
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Chaitanya Bathia
-- Create date: 01-07-2022
-- Description:	Function To Compute PF
-- =============================================
CREATE FUNCTION udf_ComputePF 
(
	-- Add the parameters for the function here
	@BasicSalary int
)
RETURNS int
AS
BEGIN
	-- Declare the return variable here
	DECLARE @PF int

	-- Add the T-SQL statements to compute the return value here
	SET @PF = @BasicSalary *0.12

	-- Return the result of the function
	RETURN @PF

END
GO


PRINT dbo.udf_ComputePF(10000)