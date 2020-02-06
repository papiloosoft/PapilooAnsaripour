USE [Papiloo]
GO

/****** Object:  Table [dbo].[Sms_Details]    Script Date: 23/09/1398 10:09:34 ق.ظ ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Sms_Details](
	[Sms_Details_Id] [int] IDENTITY(1,1) NOT NULL,
	[Sms_Details_Date] [nvarchar](8) NOT NULL,
	[Sms_Details_Time] [nvarchar](12) NOT NULL,
	[Sms_Details_Mobile] [nvarchar](12) NOT NULL,
	[Sms_Details_Message] [nvarchar](200) NOT NULL,
	[Sms_Details_Description] [nvarchar](50) NOT NULL,
	[Sms_Id_User] [nvarchar](5) NOT NULL
) ON [PRIMARY]

GO

