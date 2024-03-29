USE [REHABILITATION_CENTER]
GO
/****** Object:  StoredProcedure [dbo].[sp_AddStaff]    Script Date: 26.12.2020 21:45:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:  <Ahmet Elburuz Gürbüz>
-- Create date: <26.12.2020>
-- Description: <Add Staff>
-- =============================================
ALTER PROCEDURE [dbo].[sp_AddStaff]
	@city nvarchar(25),
	@street nvarchar(25),
	@apartmentName nvarchar(25),
	@apartmentNumber smallint,
	@zipCode int,
	@jobField nvarchar(50),
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
	VALUES(@identityNumber,@firstName,@lastName,@gender,@gsm,@salary,IDENT_CURRENT('ADDRESS'));
	
	INSERT INTO STAFF(employeeID,jobField)
	VALUES (IDENT_CURRENT('EMPLOYEE'),@jobField)

END

--sp_AddStaff 'Eskişehir','Şair','Göker',16,26000,'Doktor',15145,'Veli','Çakı','M','156',1528