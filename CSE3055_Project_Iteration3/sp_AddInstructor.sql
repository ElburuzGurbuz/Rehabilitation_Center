USE [REHABILITATION_CENTER]
GO
/****** Object:  StoredProcedure [dbo].[sp_AddInstructor]    Script Date: 26.12.2020 22:07:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:  <Ahmet Elburuz Gürbüz>
-- Create date: <26.12.2020>
-- Description: <Add Instructor>
-- =============================================
ALTER PROCEDURE [dbo].[sp_AddInstructor]
	@city nvarchar(25),
	@street nvarchar(25),
	@apartmentName nvarchar(25),
	@apartmentNumber smallint,
	@zipCode int,
	@fieldOfTeaching nvarchar(50),
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
	SET IDENTITY_INSERT INSTRUCTOR ON
	SET NOCOUNT ON;

	exec sp_AddAddress @city=@city,@street=@street,
						   @apartmentName=@apartmentName,
						   @apartmentNumber=@apartmentNumber, @zipCode=@zipCode

	INSERT INTO EMPLOYEE(identityNumber,firstName,lastName,gender,gsm,salary,addressID)
	VALUES(@identityNumber,@firstName,@lastName,@gender,@gsm,@salary,IDENT_CURRENT('ADDRESS'))
	
	INSERT INTO INSTRUCTOR(employeeID,fieldOfTeaching)
	VALUES (IDENT_CURRENT('EMPLOYEE'),@fieldOfTeaching)

	SET IDENTITY_INSERT INSTRUCTOR OFF
END

--sp_AddInstructor 'Eskişehir','Şair','Göker',16,26000,'ZİHİNNNN',15145,'Veli','Çakı','M','156',1528