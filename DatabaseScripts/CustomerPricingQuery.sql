/*
   24 May 201508:50:05
   User: 
   Server: BERNIE-PC\MAIN
   Database: ARM_IV_Test
   Application: 
*/

/* To prevent any potential data loss issues, you should review this script in detail before running it outside the context of the database designer.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.CustomerPricingQuery
	(
	Id int NOT NULL IDENTITY (1, 1),
	FirstName nvarchar(50) NULL,
	LastName nvarchar(50) NULL,
	Email nvarchar(250) NULL,
	Address1 nvarchar(100) NULL,
	City nvarchar(100) NULL,
	PostCode nvarchar(25) NULL,
	Country nvarchar(100) NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.CustomerPricingQuery ADD CONSTRAINT
	PK_CustomerPricingQuery PRIMARY KEY CLUSTERED 
	(
	Id
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.CustomerPricingQuery SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.CustomerPricingQuery', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.CustomerPricingQuery', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.CustomerPricingQuery', 'Object', 'CONTROL') as Contr_Per 