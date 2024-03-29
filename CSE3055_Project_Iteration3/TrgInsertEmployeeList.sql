USE [REHABILITATION_CENTER]
GO
/****** Object:  Trigger [dbo].[TrgInsertEmployeeList]    Script Date: 26.12.2020 22:56:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Kürşat Açıkgöz>
-- Create date: <26.12.2020>
-- Description: <Add Employees to Employee List Table>
-- =============================================
ALTER TRIGGER [dbo].[TrgInsertEmployeeList]
   ON  [dbo].[EMPLOYEE]
   AFTER insert
AS 
BEGIN
IF TRIGGER_NESTLEVEL() > 1

RETURN
	SET NOCOUNT ON;
	ALTER TABLE EMPLOYEE_LIST NOCHECK CONSTRAINT ALL
	
	 INSERT INTO  EMPLOYEE_LIST(employeeID,centerID)
     VALUES (IDENT_CURRENT('EMPLOYEE'),101)

END
