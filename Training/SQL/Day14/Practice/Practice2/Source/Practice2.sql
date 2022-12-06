SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Chaitanya Bathia
-- Create date: 04-07-2022
-- Description:	Trigger to stop delete From shift table
-- =============================================
CREATE TRIGGER trgShiftDelete 
   ON HumanResources.Shift
   FOR DELETE
AS 
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	PRINT 'The Record has been Deleted.'
    -- Insert statements for trigger here

END
GO

DISABLE TRIGGER trgShiftDelete ON HumanResources.Shift
GO

ENABLE TRIGGER trgShiftDelete ON HumanResources.Shift
GO

DELETE FROM HumanResources.Shift
WHERE Name = 'Midday'