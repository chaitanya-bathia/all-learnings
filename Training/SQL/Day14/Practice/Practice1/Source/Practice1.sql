CREATE TRIGGER trgInsertShift
ON HumanResources.Shift
FOR INSERT
AS
DECLARE @ModifiedDate datetime
SELECT @ModifiedDate = ModifiedDate from inserted
IF(@ModifiedDate != CONVERT(date,GETDATE()))
BEGIN
PRINT 'THE MODIFIED DATE MUST BE CURRENT DATE. CANNOT INSERT.'
ROLLBACK TRANSACTION
END


INSERT INTO HumanResources.Shift
VALUES
(
	'AfterLunch' ,'12:00','18:00','2022-07-04'
)

