USE [AddressBook]
GO
/****** Object:  StoredProcedure [dbo].[Person_SelectAll]    Script Date: 4/4/2018 10:45:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROC [dbo].[Person_SelectAll]
		

AS 

/*		TEST CODE

EXEC	dbo.Person_SelectAll 

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
	 
END

