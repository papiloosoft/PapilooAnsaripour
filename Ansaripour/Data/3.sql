USE [Papiloo]
GO

/****** Object:  Table [dbo].[Sms_Sefid]    Script Date: 24/09/1398 12:18:25 ب.ظ ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Sms_Sefid](
	[Sms_Id_Sefid] [int] IDENTITY(1,1) NOT NULL,
	[Sms_txt_Sefid] [nvarchar](300) NOT NULL,
	[id_user] [nvarchar](5) NOT NULL
) ON [PRIMARY]

GO

