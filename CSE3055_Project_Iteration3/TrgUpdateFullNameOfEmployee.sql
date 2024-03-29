USE [REHABILITATION_CENTER]
GO
/****** Object:  Trigger [dbo].[TrgUpdateFullNameOfEmployee]    Script Date: 26.12.2020 22:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:  <Kursat Acikgoz>
-- Create date: <26.12.2020>
-- Description: <Update FullName with capital letters>
-- =============================================
ALTER TRIGGER [dbo].[TrgUpdateFullNameOfEmployee]
   ON  [dbo].[EMPLOYEE]
   AFTER INSERT,UPDATE
AS 
BEGIN
IF TRIGGER_NESTLEVEL() > 1

RETURN
	SET NOCOUNT ON;
    update e
	set e.lastName=UPPER(e.lastName), e.firstName=UPPER(LEFT(e.firstName,1))+LOWER(SUBSTRING(e.firstName,2,LEN(e.firstName)))
	from EMPLOYEE e

END

