--PRACTICE 12

CREATE PROCEDURE SP_CountCustomersByBranchCity @Branch varchar(100)
AS
BEGIN
	SELECT COUNT(*) FROM CUSTOMER C
	JOIN BRANCH B
	ON C.CITY = B.CITY
	WHERE B.BNAME = @Branch
END

EXEC SP_CountCustomersByBranchCity 'ANDHERI'