CREATE DetroitBankDB
GO

USE DetroitBankDB

CREATE TABLE Account
(
	AccountNumber	int PRIMARY KEY,
	AccountHolderName	varchar(255),
	AccountType		int FOREIGN KEY REFERENCES AccountType(AccountTypeID),
	Balance			int
)

CREATE TABLE AccountType
(
	AccountTypeID	int PRIMARY KEY,
	AccountTypeName	varchar(50)
)

CREATE TABLE Transactions
(
	TransactionID	int PRIMARY KEY,
	DebitAccount	int,
	CreditAccount	int,
	Amount			int
)

--Trigger For new Transaction
--
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Chaitanya Bathia
-- Create date: 05-07-2022
-- Description:	Trigger to update account balance after new transaction
-- =============================================
CREATE TRIGGER trgNewTransaction
   ON  Transactions 
   FOR INSERT
AS 
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
	BEGIN TRY
	BEGIN TRANSACTION

		IF((SELECT Balance FROM Account WHERE AccountNumber = (SELECT DebitAccount from inserted))-(SELECT Amount FROM inserted)>500)
		BEGIN
			UPDATE Account SET Balance = Balance - (SELECT Amount FROM inserted)
			WHERE AccountNumber = (SELECT DebitAccount FROM inserted)

			UPDATE Account SET Balance = Balance + (SELECT Amount FROM inserted)
			WHERE AccountNumber = (SELECT CreditAccount FROM inserted)

			PRINT 'Accounts Updated. Transaction successful.'
			COMMIT TRANSACTION
		END
		
		ELSE
		BEGIN
			PRINT 'Sender Does not have Sufficient Balance. Transaction Cancelled.'
			ROLLBACK TRANSACTION
		END
	END TRY
	BEGIN CATCH
	ROLLBACK TRANSACTION
	PRINT 'TRANSACTION FAILED'
	END CATCH
    -- Insert statements for trigger here

END
GO


INSERT INTO Transactions
VALUES
(
	2,1,3000
)
