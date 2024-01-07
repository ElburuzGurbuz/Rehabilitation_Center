USE [REHABILITATION_CENTER]
GO
/****** Object:  Trigger [dbo].[TrgUpdateToMinSalary]    Script Date: 26.12.2020 22:56:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:  <Ahmet Elburuz Gürbüz>
-- Create date: <26.12.2020>
-- Description: <Determine minimum salary>
-- =============================================
ALTER TRIGGER [dbo].[TrgUpdateToMinSalary]
   ON  [dbo].[EMPLOYEE]
   AFTER INSERT,UPDATE
AS 
BEGIN
IF TRIGGER_NESTLEVEL() > 1

RETURN
	SET NOCOUNT ON;

    update e
	set e.salary = 2300
	from EMPLOYEE e
	Where e.salary<2300
END

