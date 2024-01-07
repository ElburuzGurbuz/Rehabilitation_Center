SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:  <Kürşat Açıkgöz>
-- Create date: <26.12.2020>
-- Description: <Delete Address>
-- =============================================
CREATE PROCEDURE sp_DeleteAddress
	@addressID int
AS
BEGIN
 -- SET NOCOUNT ON added to prevent extra result sets from
 -- interfering with SELECT statements.
 SET NOCOUNT ON;

	DELETE
	FROM ADDRESS
	WHERE addressID=@addressID
END
GO

sp_DeleteAddress 202