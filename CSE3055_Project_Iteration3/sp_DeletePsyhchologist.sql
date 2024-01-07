USE [REHABILITATION_CENTER]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:  <Ahmet Elburuz Gürbüz>
-- Create date: <26.12.2020>
-- Description: <Delete Psyhchologist>
-- =============================================
CREATE PROCEDURE sp_DeletePsyhchologist
	@employeeID int
AS
BEGIN
 -- SET NOCOUNT ON added to prevent extra result sets from
 -- interfering with SELECT statements.
 SET NOCOUNT ON;
	DELETE
	FROM PSYCHOLOGIST
	WHERE PSYCHOLOGIST.employeeID = @employeeID

	DELETE
	FROM EMPLOYEE
	WHERE EMPLOYEE.employeeID = @employeeID
END

--sp_DeletePsyhchologist 219
