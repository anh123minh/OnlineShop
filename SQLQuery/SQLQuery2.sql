USE [OnlineShop1]
GO
/****** Object:  StoredProcedure [dbo].[Sp_Account_Login]    Script Date: 2018-11-11 19:18:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[Sp_Account_Login]
(
@UserName varchar(20),
@Password varchar(50)
)
AS
BEGIN
	declare @count int
	declare @res bit
	select @count = count(*) from Account where UserName = @UserName and Password = @Password
	if @count > 0
		set @res = 1
	else
		set @res = 0
	select @res
END
