
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Chaitanya Bathia
-- Create date: 04-07-2022
-- Description:	Trigger to stop delete From shift table
-- =============================================
CREATE TRIGGER trgUpdateShift 
   ON  HumanResources.Shift
   FOR UPDATE
AS 
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SELECT * FROM inserted
	SELECT * FROM deleted
    -- Insert statements for trigger here

END
GO

UPDATE HumanResources.Shift
SET Name= 'LunchShift'
WHERE Name = 'AfterLunch'