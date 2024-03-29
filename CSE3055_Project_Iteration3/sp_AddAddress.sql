USE [REHABILITATION_CENTER]
GO
/****** Object:  StoredProcedure [dbo].[sp_AddAddress]    Script Date: 26.12.2020 14:53:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:  <Kürşat Açıkgöz>
-- Create date: <26.12.2020>
-- Description: <Add Address>
-- =============================================
ALTER PROCEDURE [dbo].[sp_AddAddress]
	@city nvarchar(25),
	@street nvarchar(25),
	@apartmentName nvarchar(25),
	@apartmentNumber smallint,
	@zipCode int
AS
BEGIN
 -- SET NOCOUNT ON added to prevent extra result sets from
 -- interfering with SELECT statements.
 SET NOCOUNT ON;

	INSERT INTO ADDRESS(city, street,apartmentName,apartmentNumber,zipCode)
	VALUES (@city, @street,@apartmentName,@apartmentNumber,@zipCode);
END
