USE [REHABILITATION_CENTER]
GO
/****** Object:  Trigger [dbo].[TrgInsertEmployeeList]    Script Date: 26.12.2020 19:10:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Ahmet Elburuz Gürbüz>
-- Create date: <26.12.2020>
-- Description: <Determining the minimum salary>
-- =============================================
CREATE TRIGGER TrgMinSalary
   ON  EMPLOYEE
   AFTER insert
AS 
BEGIN
	SET NOCOUNT ON;
	--ALTER TABLE EMPLOYEE_LIST NOCHECK CONSTRAINT ALL
	
	 INSERT INTO  EMPLOYEE(employeeID,identityNumber,firstName,lastName,gender,gsm)
     VALUES (IDENT_CURRENT('EMPLOYEE'),101)

END
