USE [AddressBook]
GO
/****** Object:  StoredProcedure [dbo].[Person_SelectById]    Script Date: 4/4/2018 10:45:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROC [dbo].[Person_SelectById]
			@Id INT

AS 

/*		TEST CODE

DECLARE	@Id INT = 1;

EXEC	dbo.Person_SelectById @Id

*/

BEGIN

	SELECT Id
		  ,FirstName
		  ,LastName
		  ,Email
		  ,Phone
		  ,Address1
		  ,Address2
		  ,City
		  ,State
		  ,PostalCode
		  ,Country
	  FROM dbo.Person
	WHERE Id = @Id
	 
END

