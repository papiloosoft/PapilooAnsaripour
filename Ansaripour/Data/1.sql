USE [Papiloo]
GO

/****** Object:  Table [dbo].[Sms_Panel]    Script Date: 23/09/1398 10:09:26 ق.ظ ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Sms_Panel](
	[Sms_Id] [int] IDENTITY(1,1) NOT NULL,
	[Sms_txt_Ulr_Sender] [nvarchar](200) NOT NULL,
	[Sms_txt_smsSender] [nvarchar](50) NOT NULL,
	[Sms_txt_Signature] [nvarchar](50) NOT NULL,
	[Sms_Warranty_Document_Add] [bit] NOT NULL,
	[Sms_Text_Warranty_Document_Add] [nvarchar](300) NOT NULL,
	[Sms_Warranty_Document_Extended] [bit] NOT NULL,
	[Sms_Text_Warranty_Document_Extended] [nvarchar](300) NOT NULL,
	[Sms_Warranty_Document_Refund] [bit] NOT NULL,
	[Sms_Text_Warranty_Document_Refund] [nvarchar](300) NOT NULL,
	[Sms_Collection_Document_Add] [bit] NOT NULL,
	[Sms_Text_Collection_Document_Add] [nvarchar](300) NOT NULL,
	[Sms_Collection_Document_Assignment] [bit] NOT NULL,
	[Sms_Text_Collection_Document_Assignment] [nvarchar](300) NOT NULL,
	[Sms_Collection_Document_Notice] [bit] NOT NULL,
	[Sms_Text_Collection_Document_Notice] [nvarchar](300) NOT NULL,
	[Sms_Collection_Document_Back] [bit] NOT NULL,
	[Sms_Text_Collection_Document_Back] [nvarchar](300) NOT NULL,
	[Sms_Collection_Document_Extradition] [bit] NOT NULL,
	[Sms_Text_Collection_Document_Extradition] [nvarchar](300) NOT NULL,
	[Sms_Payable_Payment] [bit] NOT NULL,
	[Sms_Text_Payable_Payment] [nvarchar](300) NOT NULL,
	[id_user] [nvarchar](5) NOT NULL
) ON [PRIMARY]

GO

