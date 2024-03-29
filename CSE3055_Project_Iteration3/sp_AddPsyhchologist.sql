USE [REHABILITATION_CENTER]
GO
/****** Object:  StoredProcedure [dbo].[sp_AddPsyhchologist]    Script Date: 26.12.2020 22:06:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:  <Ahmet Elburuz Gürbüz>
-- Create date: <26.12.2020>
-- Description: <Add Psyhchologist>
-- =============================================
ALTER PROCEDURE [dbo].[sp_AddPsyhchologist]
	@city nvarchar(25),
	@street nvarchar(25),
	@apartmentName nvarchar(25),
	@apartmentNumber smallint,
	@zipCode int,
	@identityNumber char(11),
	@firstName nvarchar(50),
	@lastName nvarchar(50),
	@gender nvarchar(1),
	@gsm nvarchar(11),
	@salary smallint
AS
BEGIN
 -- SET NOCOUNT ON added to prevent extra result sets from
 -- interfering with SELECT statements.
 SET NOCOUNT ON;

	exec sp_AddAddress @city=@city,@street=@street,
						   @apartmentName=@apartmentName,
						   @apartmentNumber=@apartmentNumber, @zipCode=@zipCode

	INSERT INTO EMPLOYEE(identityNumber,firstName,lastName,gender,gsm,salary,addressID)
	VALUES(@identityNumber,@firstName,@lastName,@gender,@gsm,@salary,IDENT_CURRENT('ADDRESS'))
	
	INSERT INTO PSYCHOLOGIST(employeeID)
	VALUES (IDENT_CURRENT('EMPLOYEE'))
END