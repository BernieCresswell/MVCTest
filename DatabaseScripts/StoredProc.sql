
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Bernie Cressswell
-- Create date: 24/05/2015
-- Description:	For ARM IV test
-- =============================================
CREATE PROCEDURE uspCustomerPricingQueryInsert 
			@FirstName nvarchar(50),
			@LastName nvarchar(50),
			@Email nvarchar(250),
			@Address1 nvarchar(100),
			@City nvarchar(100),
			@PostCode nvarchar(25),
			@Country nvarchar(100),
			@ProductId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
declare @insertedId int

BEGIN TRAN
INSERT INTO [dbo].[CustomerPricingQuery]
           ([FirstName]
           ,[LastName]
           ,[Email]
           ,[Address1]
           ,[City]
           ,[PostCode]
           ,[Country])
     VALUES
           (@FirstName
           ,@LastName
           ,@Email
           ,@Address1
           ,@City
           ,@PostCode
           ,@Country)

set @insertedId = @@IDENTITY


INSERT INTO [dbo].[Products]
           ([CustomerPricingQueryId]
           ,[ProductCode])
     VALUES
           (@insertedId
           ,@ProductId)

COMMIT TRAN


END