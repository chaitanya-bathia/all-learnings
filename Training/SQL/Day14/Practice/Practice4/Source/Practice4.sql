--DDL TRIGGER
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE TRIGGER SAFETY
   ON DATABASE
   FOR DROP_TABLE,ALTER_TABLE
AS 
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	PRINT 'TABLE SCHEMA MODIFICATION OR TABLE DELETION IS NOT ALLOWED. DISABLE THE SAFETY TRIGGER TO DO SO.'
	ROLLBACK
    -- Insert statements for trigger here

END
GO


CREATE TABLE TestTable
(
	TestID int,
	TestName varchar(50)
)
GO

DISABLE TRIGGER SAFETY
ON DATABASE
GO

DROP TABLE TestTable