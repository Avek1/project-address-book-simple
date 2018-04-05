USE [AddressBook]
GO
/****** Object:  StoredProcedure [dbo].[Person_Delete]    Script Date: 4/4/2018 10:41:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER  PROC [dbo].[Person_Delete]
			@Id INT

AS

/*		TEST CODE
		
		DECLARE @Id INT = 5

		SELECT	*
		FROM	dbo.Person
		WHERE	Id = @Id

		EXEC	dbo.Person_Delete @Id

		SELECT	*
		FROM	dbo.Person
		WHERE	Id = @Id;

*/

BEGIN
	
	DELETE FROM dbo.Person
	WHERE		Id = @id;
END