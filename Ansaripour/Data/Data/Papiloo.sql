USE [master]
GO
/****** Object:  Database [Amval]    Script Date: 26/09/1398 04:34:51 ب.ظ ******/
CREATE DATABASE [Amval]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Garmsar_Data', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\Amval.mdf' , SIZE = 2879616KB , MAXSIZE = UNLIMITED, FILEGROWTH = 10%)
 LOG ON 
( NAME = N'Garmsar_Log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\Amval_log.ldf' , SIZE = 1024KB , MAXSIZE = UNLIMITED, FILEGROWTH = 10%)
GO
ALTER DATABASE [Amval] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Amval].[dbo].[sp_fulltext_database] @action = 'disable'
end
GO
ALTER DATABASE [Amval] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Amval] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Amval] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Amval] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Amval] SET ARITHABORT OFF 
GO
ALTER DATABASE [Amval] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Amval] SET AUTO_SHRINK ON 
GO
ALTER DATABASE [Amval] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Amval] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Amval] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Amval] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Amval] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Amval] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Amval] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Amval] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Amval] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Amval] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Amval] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Amval] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Amval] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Amval] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Amval] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Amval] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Amval] SET  MULTI_USER 
GO
ALTER DATABASE [Amval] SET PAGE_VERIFY TORN_PAGE_DETECTION  
GO
ALTER DATABASE [Amval] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Amval] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Amval] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Amval] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Amval', N'ON'
GO
ALTER DATABASE [Amval] SET QUERY_STORE = OFF
GO
USE [Amval]
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [Amval]
GO
/****** Object:  User [ama]    Script Date: 26/09/1398 04:34:52 ب.ظ ******/
CREATE USER [ama] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[ama]
GO
/****** Object:  Schema [ama]    Script Date: 26/09/1398 04:34:52 ب.ظ ******/
CREATE SCHEMA [ama]
GO
/****** Object:  Table [dbo].[Accounting_Account]    Script Date: 26/09/1398 04:34:52 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accounting_Account](
	[Acc_Id] [int] IDENTITY(1,1) NOT NULL,
	[Acc_Num] [numeric](18, 0) NULL,
	[Acc_Code] [nvarchar](50) NOT NULL,
	[Acc_level] [nvarchar](50) NULL,
	[Acc_Name] [nvarchar](255) NOT NULL,
	[Acc_Operation] [nvarchar](50) NOT NULL,
	[Acc_Case] [nvarchar](50) NULL,
	[Acc_Class] [nvarchar](50) NULL,
	[Acc_Group] [int] NOT NULL,
	[User_id] [nvarchar](5) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Accounting_Details]    Script Date: 26/09/1398 04:34:53 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accounting_Details](
	[Accounting_Details_Id] [int] IDENTITY(1,1) NOT NULL,
	[Accounting_Details_Parent] [int] NOT NULL,
	[Accounting_Details_Row] [int] NOT NULL,
	[Accounting_Details_Acc] [nvarchar](50) NOT NULL,
	[Accounting_Details_Detailed_One] [nvarchar](50) NOT NULL,
	[Accounting_Details_Detailed_Two] [nvarchar](50) NOT NULL,
	[Accounting_Details_Detailed_Three] [nvarchar](50) NOT NULL,
	[Accounting_Details_Detailed_Four] [nvarchar](50) NOT NULL,
	[Accounting_Details_Detailed_Five] [nvarchar](50) NOT NULL,
	[Accounting_Details_Debtor] [numeric](18, 0) NOT NULL,
	[Accounting_Details_Creditor] [numeric](18, 0) NOT NULL,
	[Accounting_Details_Description] [nvarchar](50) NOT NULL,
	[Accounting_Details_Date_Cost] [nvarchar](8) NOT NULL,
	[Accounting_Details_Number_Due] [int] NOT NULL,
	[Accounting_Details_Date_Due] [nvarchar](8) NOT NULL,
	[Accounting_Details_Number_Turning] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Accounting_Header]    Script Date: 26/09/1398 04:34:53 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accounting_Header](
	[Accounting_Header_Id] [int] IDENTITY(1,1) NOT NULL,
	[Accounting_Header_Number] [int] NOT NULL,
	[Accounting_Header_Date] [nvarchar](8) NOT NULL,
	[Accounting_Header_Description] [nvarchar](50) NOT NULL,
	[Accounting_Header_Class] [int] NOT NULL,
	[Accounting_Header_Area] [int] NOT NULL,
	[User_Id] [nvarchar](5) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Accounting_Relation]    Script Date: 26/09/1398 04:34:53 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accounting_Relation](
	[Relation_Id] [int] IDENTITY(1,1) NOT NULL,
	[Relation_Account] [int] NOT NULL,
	[Relation_Detailed] [int] NOT NULL,
	[Relation_Num_Detailed] [int] NOT NULL,
	[User_Id] [nvarchar](5) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Area]    Script Date: 26/09/1398 04:34:54 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Area](
	[Id_Area] [int] IDENTITY(1,1) NOT NULL,
	[Code_Area] [nvarchar](5) NOT NULL,
	[Department_Area] [nvarchar](50) NOT NULL,
	[Company_Area] [nvarchar](50) NOT NULL,
	[Registration_Number_Area] [nvarchar](50) NOT NULL,
	[Economic_Number_Area] [nvarchar](50) NOT NULL,
	[National_Code_Area] [nvarchar](50) NOT NULL,
	[Postal_Code_Area] [nvarchar](14) NOT NULL,
	[Phone_Number_Area] [nvarchar](15) NOT NULL,
	[Fax_Number_Area] [nvarchar](15) NOT NULL,
	[Email_Area] [nvarchar](50) NOT NULL,
	[General_Manager_Area] [nvarchar](50) NOT NULL,
	[Mobile_Number_Area] [nvarchar](15) NOT NULL,
	[Address_Area] [nvarchar](50) NOT NULL,
	[Fiscal_Year_Area] [nvarchar](50) NOT NULL,
	[Id_User] [nvarchar](5) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Bank]    Script Date: 26/09/1398 04:34:54 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bank](
	[Bank_Id] [int] IDENTITY(1,1) NOT NULL,
	[Bank_Account] [nvarchar](50) NOT NULL,
	[Bank_Name] [nvarchar](50) NOT NULL,
	[Bank_Department] [nvarchar](50) NOT NULL,
	[Bank_Code] [nvarchar](50) NOT NULL,
	[Bank_Check] [nvarchar](50) NOT NULL,
	[Bank_Payment] [nvarchar](50) NOT NULL,
	[Bank_Check_number_Of] [int] NOT NULL,
	[Bank_Chech_Number] [int] NOT NULL,
	[Bank_Check_number_To] [int] NOT NULL,
	[Bank_Name_Case1] [nvarchar](50) NULL,
	[Bank_Post_Case1] [nvarchar](50) NULL,
	[Bank_Name_Case2] [nvarchar](50) NULL,
	[Bank_Post_Case2] [nvarchar](50) NULL,
	[Bank_Name_Case3] [nvarchar](50) NULL,
	[Bank_Post_Case3] [nvarchar](50) NULL,
	[Bank_Name_Case4] [nvarchar](50) NULL,
	[Bank_Post_Case4] [nvarchar](50) NULL,
	[Bank_Name_Case5] [nvarchar](50) NULL,
	[Bank_Post_Case5] [nvarchar](50) NULL,
	[Bank_Case] [int] NOT NULL,
	[Bank_Area] [nvarchar](5) NULL,
	[id_user] [nvarchar](5) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Base_Information]    Script Date: 26/09/1398 04:34:54 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Base_Information](
	[Base_Information_Id] [int] IDENTITY(1,1) NOT NULL,
	[Base_Information_Code] [nvarchar](50) NOT NULL,
	[Base_Information_Name] [nvarchar](255) NOT NULL,
	[Base_Information_Area] [nvarchar](5) NOT NULL,
	[Base_Information_Class] [nvarchar](50) NOT NULL,
	[Id_User] [nvarchar](5) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Counterparty]    Script Date: 26/09/1398 04:34:54 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Counterparty](
	[Counterparty_ID] [int] IDENTITY(1,1) NOT NULL,
	[Counterparty_Subscribe] [int] NOT NULL,
	[Counterparty_Personality_Type] [nvarchar](5) NOT NULL,
	[Counterparty_Buyer_Type] [nvarchar](5) NOT NULL,
	[Counterparty_Detailed] [nvarchar](255) NOT NULL,
	[Counterparty_Name] [nvarchar](255) NOT NULL,
	[Counterparty_Family] [nvarchar](255) NOT NULL,
	[Counterparty_Registration_Number] [nvarchar](5) NOT NULL,
	[Counterparty_Phone] [nvarchar](50) NOT NULL,
	[Counterparty_Fax] [nvarchar](50) NOT NULL,
	[Counterparty_Manager] [nvarchar](255) NOT NULL,
	[Counterparty_Mobile] [nvarchar](50) NOT NULL,
	[Counterparty_Postal_Code] [nvarchar](50) NOT NULL,
	[Counterparty_National_Code] [nvarchar](50) NOT NULL,
	[Counterparty_Economic_Code] [nvarchar](50) NOT NULL,
	[Counterparty_Email] [nvarchar](50) NOT NULL,
	[Counterparty_State] [nvarchar](5) NOT NULL,
	[Counterparty_City] [nvarchar](5) NOT NULL,
	[Counterparty_Address] [nvarchar](255) NOT NULL,
	[Counterparty_Bank_Number] [nvarchar](255) NOT NULL,
	[Counterparty_Area] [nvarchar](5) NOT NULL,
	[id_user] [nvarchar](5) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Estate]    Script Date: 26/09/1398 04:34:55 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estate](
	[Estate_Id] [int] IDENTITY(1,1) NOT NULL,
	[Estate_Id_Refrence] [int] NULL,
	[Estate_City] [nvarchar](50) NULL,
	[Estate_Original_Code] [nvarchar](50) NULL,
	[Estate_Sub_Code] [nvarchar](50) NULL,
	[Estate_Cost_Code] [nvarchar](50) NULL,
	[Estate_Plaque] [nvarchar](50) NULL,
	[Estate_Control] [nvarchar](8) NULL,
	[Estate_Name] [nvarchar](300) NULL,
	[Estate_Date_Price] [nvarchar](8) NULL,
	[Estate_Price] [numeric](18, 0) NULL,
	[Estate_Depreciation] [numeric](18, 0) NULL,
	[Estate_Price_Debtor] [numeric](18, 0) NULL,
	[Estate_Price_Creditor] [numeric](18, 0) NULL,
	[Estate_Depreciation_Debtor] [numeric](18, 0) NULL,
	[Estate_Depreciation_Creditor] [numeric](18, 0) NULL,
	[Estate_Date_Revaluation] [nvarchar](8) NULL,
	[Estate_No_Document] [nvarchar](10) NULL,
	[Estate_Date_Document] [nvarchar](8) NULL,
	[Estate_No_Remittance] [nvarchar](10) NULL,
	[Estate_Date_Remittance] [nvarchar](8) NULL,
	[Estate_No_Personnel] [nvarchar](10) NULL,
	[Estate_Description] [nvarchar](300) NULL,
	[Estate_Area] [nvarchar](5) NULL,
	[Estate_Plan] [nvarchar](5) NULL,
	[Estate_Project] [nvarchar](5) NULL,
	[Estate_Date_From] [nvarchar](8) NULL,
	[Estate_Date_Until] [nvarchar](8) NULL,
	[Id_User] [nvarchar](5) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Estate_Backup]    Script Date: 26/09/1398 04:34:55 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estate_Backup](
	[Estate_Id] [int] IDENTITY(1,1) NOT NULL,
	[Estate_Id_Refrence] [int] NULL,
	[Estate_City] [nvarchar](50) NULL,
	[Estate_Original_Code] [nvarchar](50) NULL,
	[Estate_Sub_Code] [nvarchar](50) NULL,
	[Estate_Cost_Code] [nvarchar](50) NULL,
	[Estate_Plaque] [nvarchar](50) NULL,
	[Estate_Control] [nvarchar](8) NULL,
	[Estate_Name] [nvarchar](300) NULL,
	[Estate_Date_Price] [nvarchar](8) NULL,
	[Estate_Price] [numeric](18, 0) NULL,
	[Estate_Depreciation] [numeric](18, 0) NULL,
	[Estate_Price_Debtor] [numeric](18, 0) NULL,
	[Estate_Price_Creditor] [numeric](18, 0) NULL,
	[Estate_Depreciation_Debtor] [numeric](18, 0) NULL,
	[Estate_Depreciation_Creditor] [numeric](18, 0) NULL,
	[Estate_Date_Revaluation] [nvarchar](8) NULL,
	[Estate_No_Document] [nvarchar](10) NULL,
	[Estate_Date_Document] [nvarchar](8) NULL,
	[Estate_No_Remittance] [nvarchar](10) NULL,
	[Estate_Date_Remittance] [nvarchar](8) NULL,
	[Estate_No_Personnel] [nvarchar](10) NULL,
	[Estate_Description] [nvarchar](300) NULL,
	[Estate_Area] [nvarchar](5) NULL,
	[Estate_Plan] [nvarchar](5) NULL,
	[Estate_Project] [nvarchar](5) NULL,
	[Estate_Date_From] [nvarchar](8) NULL,
	[Estate_Date_Until] [nvarchar](8) NULL,
	[Id_User] [nvarchar](5) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Log_File]    Script Date: 26/09/1398 04:34:56 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Log_File](
	[Log_Id] [int] IDENTITY(1,1) NOT NULL,
	[Log_Process] [int] NULL,
	[Log_Table] [nvarchar](20) NULL,
	[Log_Date] [nvarchar](8) NULL,
	[Log_Time] [nvarchar](12) NULL,
	[Log_Operation] [nvarchar](100) NULL,
	[Log_Details] [nvarchar](max) NULL,
	[Log_User_Id] [nvarchar](5) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Order_Add]    Script Date: 26/09/1398 04:34:56 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order_Add](
	[Order_Id] [int] IDENTITY(1,1) NOT NULL,
	[Order_Number] [int] NOT NULL,
	[Order_Date] [nvarchar](8) NOT NULL,
	[Order_Time] [nvarchar](50) NOT NULL,
	[Order_Subscription_Id] [int] NOT NULL,
	[Order_In_Description] [nvarchar](255) NOT NULL,
	[Order_Description] [nvarchar](255) NOT NULL,
	[Order_PrePayment] [numeric](18, 0) NOT NULL,
	[Order_Factor] [numeric](18, 0) NOT NULL,
	[Order_Discount] [numeric](18, 0) NOT NULL,
	[Order_Tax] [numeric](18, 0) NOT NULL,
	[id_user] [nvarchar](5) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Order_Add_Service]    Script Date: 26/09/1398 04:34:56 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order_Add_Service](
	[Order_Service_Id] [int] IDENTITY(1,1) NOT NULL,
	[Id_Order_Add] [int] NOT NULL,
	[Order_Service_Information] [int] NOT NULL,
	[Order_Service_Row] [int] NOT NULL,
	[Order_Service_Start_Date] [nvarchar](8) NOT NULL,
	[Order_Service_End_Date] [nvarchar](8) NOT NULL,
	[Order_Service_End_Time] [nvarchar](8) NOT NULL,
	[Order_Service_Description] [nvarchar](255) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Order_Payment]    Script Date: 26/09/1398 04:34:56 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order_Payment](
	[Order_Payment_Id] [int] IDENTITY(1,1) NOT NULL,
	[Order_Payment_Parent] [int] NOT NULL,
	[Order_Payment_Description] [nvarchar](300) NOT NULL,
	[Order_Payment_Number] [numeric](18, 0) NOT NULL,
	[Order_Payment_Debtor] [numeric](18, 0) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Order_Request]    Script Date: 26/09/1398 04:34:57 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order_Request](
	[Order_Request_Id] [int] IDENTITY(1,1) NOT NULL,
	[Order_Request_Parent] [int] NOT NULL,
	[Order_Request_Number] [int] NOT NULL,
	[Order_Request_Date] [nvarchar](8) NOT NULL,
	[Order_Request_Description] [nvarchar](300) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Pay_Personal]    Script Date: 26/09/1398 04:34:57 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pay_Personal](
	[Id_Pay_Personal] [int] IDENTITY(1,1) NOT NULL,
	[Code_Pay_Personal] [nvarchar](50) NOT NULL,
	[Name_Pay_Personal] [nvarchar](50) NOT NULL,
	[Family_Pay_Personal] [nvarchar](50) NOT NULL,
	[Father_Pay_Personal] [nvarchar](50) NOT NULL,
	[Date_Berthday_Pay_Personal] [nvarchar](8) NOT NULL,
	[Place_Berthday_Pay_Personal] [nvarchar](50) NOT NULL,
	[Cirtificate_Id_Pay_Personal] [nvarchar](50) NOT NULL,
	[National_Id_Pay_Personal] [nvarchar](50) NOT NULL,
	[Sex_Pay_Personal] [int] NOT NULL,
	[Soldier_Pay_Personal] [int] NOT NULL,
	[Marry_Pay_Personal] [int] NOT NULL,
	[Discipline_Pay_Personal] [nvarchar](50) NOT NULL,
	[Diploma_Pay_Personal] [int] NOT NULL,
	[Insurance_Pay_Personal] [nvarchar](50) NOT NULL,
	[Account_Pay_Personal] [nvarchar](50) NOT NULL,
	[Tell_Pay_Personal] [nvarchar](50) NOT NULL,
	[Address_Pay_Personal] [nvarchar](50) NOT NULL,
	[Area_Pay_Personal] [nvarchar](5) NOT NULL,
	[Id_User] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Pay_Sentence]    Script Date: 26/09/1398 04:34:57 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pay_Sentence](
	[Id_Pay_Sentence] [int] IDENTITY(1,1) NOT NULL,
	[Personal_Pay_Sentence] [int] NOT NULL,
	[Job_Pay_Sentence] [nvarchar](50) NULL,
	[Cod_Job_Pay_Sentence] [nvarchar](50) NULL,
	[Group_Pay_Sentence] [nvarchar](50) NULL,
	[Organization_Pay_Sentence] [nvarchar](5) NULL,
	[City_Pay_Sentence] [nvarchar](5) NULL,
	[Address_Pay_Sentence] [nvarchar](300) NULL,
	[Time_Of_Pay_Sentence] [nvarchar](8) NULL,
	[Time_Until_Pay_Sentence] [nvarchar](8) NULL,
	[Turn_Pay_Sentence] [int] NULL,
	[Date_Pay_Sentence] [nvarchar](8) NULL,
	[Date_Of_Pay_Sentence] [nvarchar](8) NULL,
	[Date_Until_Pay_Sentence] [nvarchar](8) NULL,
	[Num_Pay_Sentence1] [int] NULL,
	[Active_Pay_Sentence] [int] NULL,
	[Base_Pay_Sentence] [numeric](18, 0) NULL,
	[Attraction_Pay_Sentence] [numeric](18, 0) NULL,
	[Difficulty_Pay_Sentence] [numeric](18, 0) NULL,
	[Years_Pay_Sentence] [numeric](18, 0) NULL,
	[Guardianship_Pay_Sentence] [numeric](18, 0) NULL,
	[Amazing_Pay_Sentence] [numeric](18, 0) NULL,
	[laborer_Pay_Sentence] [numeric](18, 0) NULL,
	[Children_Pay_Sentence] [numeric](18, 0) NULL,
	[Others_1_Pay_Sentence] [numeric](18, 0) NULL,
	[Housing_Pay_Sentence] [numeric](18, 0) NULL,
	[Transportation_Pay_Sentence] [numeric](18, 0) NULL,
	[Others_2_Pay_Sentence] [numeric](18, 0) NULL,
	[Id_User] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Payable]    Script Date: 26/09/1398 04:34:58 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Payable](
	[Payable_Id] [int] IDENTITY(1,1) NOT NULL,
	[Payable_Date] [nvarchar](50) NOT NULL,
	[Payable_Account] [nvarchar](50) NOT NULL,
	[Payable_Number] [nvarchar](50) NOT NULL,
	[Payable_Description] [nvarchar](299) NOT NULL,
	[Payable_Creditor_Amount] [numeric](19, 4) NOT NULL,
	[Payable_Debtor_Amount] [numeric](19, 4) NOT NULL,
	[Payable_Case] [nvarchar](5) NOT NULL,
	[Payable_Area] [nvarchar](5) NULL,
	[Id_User] [nvarchar](5) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Payable_Details]    Script Date: 26/09/1398 04:34:58 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Payable_Details](
	[Payable_Details_Id] [int] IDENTITY(1,1) NOT NULL,
	[Payable_Details_Parent] [int] NULL,
	[Payable_Counterparty_Id] [int] NULL,
	[Payable_Details_Description] [nvarchar](300) NULL,
	[Payable_Details_Debtor] [numeric](18, 0) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Pictures]    Script Date: 26/09/1398 04:34:58 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pictures](
	[Id_Picture] [int] IDENTITY(1,1) NOT NULL,
	[Name_Data_Picture] [nvarchar](50) NULL,
	[Id_Data_Picture] [int] NULL,
	[Picture] [nvarchar](max) NULL,
	[Id_User] [int] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Pricing]    Script Date: 26/09/1398 04:34:58 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pricing](
	[Pricing_Id] [int] IDENTITY(1,1) NOT NULL,
	[Pricing_Code] [nvarchar](50) NOT NULL,
	[Pricing_Explained] [nvarchar](50) NOT NULL,
	[Pricing_Reference] [int] NOT NULL,
	[Pricing_Class] [nvarchar](50) NOT NULL,
	[Pricing_Fixed] [numeric](18, 0) NOT NULL,
	[Pricing_Sale] [numeric](18, 0) NOT NULL,
	[Pricing_Area] [nvarchar](5) NOT NULL,
	[user_id] [nvarchar](5) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[R_S]    Script Date: 26/09/1398 04:34:58 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[R_S](
	[S_Date] [varchar](50) NULL,
	[S_C_D] [varchar](50) NULL,
	[H_S] [varchar](50) NULL,
	[D_R] [varchar](50) NULL,
	[Number_APP] [nvarchar](10) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Recovery_Documents]    Script Date: 26/09/1398 04:34:59 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Recovery_Documents](
	[Recovery_Documents_Id] [int] IDENTITY(1,1) NOT NULL,
	[Recovery_Documents_Subscription] [int] NOT NULL,
	[Recovery_Documents_Operation] [numeric](18, 0) NOT NULL,
	[Recovery_Documents_Date_Received] [nvarchar](8) NOT NULL,
	[Recovery_Documents_Due_Date] [nvarchar](8) NOT NULL,
	[Recovery_Documents_Assignment_Date] [nvarchar](8) NOT NULL,
	[Recovery_Documents_Pass_Date] [nvarchar](8) NOT NULL,
	[Recovery_Documents_Returned_Date] [nvarchar](8) NOT NULL,
	[Recovery_Documents_Refund_Date] [nvarchar](8) NOT NULL,
	[Recovery_Documents_Bank] [nvarchar](255) NOT NULL,
	[Recovery_Documents_Branch] [nvarchar](255) NOT NULL,
	[Recovery_Documents_Collecting_Bank] [nvarchar](255) NOT NULL,
	[Recovery_Documents_No_Check] [varchar](255) NOT NULL,
	[Recovery_Documents_Account_Number] [varchar](255) NOT NULL,
	[Recovery_Documents_Case] [nvarchar](8) NOT NULL,
	[Recovery_Documents_Amount] [nvarchar](50) NOT NULL,
	[Recovery_Documents_Description] [nvarchar](500) NOT NULL,
	[Recovery_Documents_Area] [nvarchar](5) NOT NULL,
	[id_user] [nvarchar](5) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Repair_Attachment]    Script Date: 26/09/1398 04:34:59 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Repair_Attachment](
	[Id_Repair_Attachment] [int] IDENTITY(1,1) NOT NULL,
	[Number_Repair] [int] NOT NULL,
	[Goods_Repair] [nvarchar](10) NULL,
	[Technical_Specifications] [nvarchar](50) NULL,
	[Useful_life] [nvarchar](50) NULL,
	[order_point] [nvarchar](50) NULL,
	[Limit_Order] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Repair_Cost]    Script Date: 26/09/1398 04:34:59 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Repair_Cost](
	[Cost_Id] [int] IDENTITY(1,1) NOT NULL,
	[Cost_Id_Total] [nvarchar](50) NULL,
	[Cost_Id_Request] [nvarchar](50) NULL,
	[Cost_Num_Request] [nvarchar](50) NULL,
	[Cost_Date_Request] [nvarchar](8) NULL,
	[Cost_Time_Request] [nvarchar](8) NULL,
	[Cost_Date_Sabt] [nvarchar](8) NULL,
	[Cost_Repair_description] [nvarchar](255) NULL,
	[Cost_Work_description] [nvarchar](255) NULL,
	[Cost_Start_Date_Work] [nvarchar](8) NULL,
	[Cost_Start_Time_Work] [nvarchar](8) NULL,
	[Cost_End_Date_Work] [nvarchar](8) NULL,
	[Cost_End_Time_Work] [nvarchar](8) NULL,
	[Cost_Stop_Defect] [nvarchar](50) NULL,
	[Cost_Time_Stop_Repair] [nvarchar](8) NULL,
	[Cost_Time_Stop_Work] [nvarchar](50) NULL,
	[Cost_Time_Befor_Work] [nvarchar](50) NULL,
	[Cost_Area] [nvarchar](5) NULL,
	[Id_user] [nvarchar](5) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Repair_Cost_Attachment]    Script Date: 26/09/1398 04:34:59 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Repair_Cost_Attachment](
	[Id_Cost_Attachment] [int] IDENTITY(1,1) NOT NULL,
	[Number_Cost] [int] NOT NULL,
	[Goods_Cost] [nvarchar](10) NULL,
	[Goods_Number] [nvarchar](50) NULL,
	[Repairman_Name] [nvarchar](50) NULL,
	[Expertise] [nvarchar](50) NULL,
	[Time_Work] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Repair_Total]    Script Date: 26/09/1398 04:35:00 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Repair_Total](
	[Repair_Id] [int] IDENTITY(1,1) NOT NULL,
	[Repair_Name] [nvarchar](255) NULL,
	[Repair_Code] [nvarchar](50) NULL,
	[Repair_Serial] [nvarchar](50) NULL,
	[Repair_Seating] [nvarchar](50) NULL,
	[Repair_Manufacturing_Country] [nvarchar](255) NULL,
	[Repair_Manufacturer] [nvarchar](255) NULL,
	[Repair_Model_Making] [nvarchar](50) NULL,
	[Repair_Production_Date] [nvarchar](8) NULL,
	[Repair_Use_Date] [nvarchar](8) NULL,
	[Repair_Dimensions_Device] [nvarchar](50) NULL,
	[Repair_Working_Dimensions] [nvarchar](50) NULL,
	[Repair_Weight_Device] [nvarchar](50) NULL,
	[Repair_Production_Capacity] [nvarchar](50) NULL,
	[Repair_Ability_Work] [nvarchar](50) NULL,
	[Repair_Capacity] [nvarchar](50) NULL,
	[Repair_Energy] [nvarchar](50) NULL,
	[Repair_Name_Engine] [nvarchar](50) NULL,
	[Repair_Engine_Manufacturer] [nvarchar](50) NULL,
	[Repair_Power_Cable] [nvarchar](50) NULL,
	[Repair_Voltage] [nvarchar](50) NULL,
	[Repair_Power] [nvarchar](50) NULL,
	[Repair_Stream] [nvarchar](50) NULL,
	[Repair_Frequency] [nvarchar](50) NULL,
	[Repair_RPM] [nvarchar](50) NULL,
	[Repair_Phase] [nvarchar](50) NULL,
	[Repair_Kind_Stream] [nvarchar](50) NULL,
	[Repair_Kind_Fuse] [nvarchar](50) NULL,
	[Repair_Connector_Type] [nvarchar](50) NULL,
	[Repair_Power_Factor] [nvarchar](50) NULL,
	[Repair_Flow_Rate] [nvarchar](50) NULL,
	[Repair_Key_Issues] [nvarchar](50) NULL,
	[Repair_Cable_Size] [nvarchar](50) NULL,
	[Repair_Description] [nvarchar](255) NULL,
	[Repair_Area] [nvarchar](5) NULL,
	[Id_user] [nvarchar](5) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Seasonal_Sales]    Script Date: 26/09/1398 04:35:00 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Seasonal_Sales](
	[Seasonal_Id] [int] NOT NULL,
	[Seasonal_Date] [nvarchar](8) NOT NULL,
	[Seasonal_Year] [nvarchar](4) NOT NULL,
	[Seasonal_Operation] [int] NOT NULL,
	[Seasonal_Subscription] [int] NOT NULL,
	[Seasonal_Product_Type] [int] NOT NULL,
	[Seasonal_Product_Name] [nvarchar](255) NOT NULL,
	[Seasonal_Product_Id] [nvarchar](50) NOT NULL,
	[Seasonal_Documents_Number] [nvarchar](5) NOT NULL,
	[Seasonal_Documents_Date] [nvarchar](8) NOT NULL,
	[Seasonal_Bill_Number] [nvarchar](5) NOT NULL,
	[Seasonal_Bill_Date] [nvarchar](8) NOT NULL,
	[Seasonal_Gross_Price] [numeric](18, 0) NOT NULL,
	[Seasonal_Discount_Price] [numeric](18, 0) NOT NULL,
	[Seasonal_Valu_Price] [numeric](18, 0) NOT NULL,
	[Seasonal_Complications_Price] [numeric](18, 0) NOT NULL,
	[Seasonal_Complications] [numeric](18, 0) NOT NULL,
	[Seasonal_Description] [nvarchar](300) NOT NULL,
	[Seasonal_Area] [nvarchar](5) NOT NULL,
	[Id_user] [nvarchar](5) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Security_Access]    Script Date: 26/09/1398 04:35:01 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Security_Access](
	[Id_Access] [int] IDENTITY(1,1) NOT NULL,
	[Name_Access] [nvarchar](50) NULL,
	[Code_Access] [nvarchar](5) NULL,
	[User_Access] [nvarchar](5) NULL,
	[Id_User] [nvarchar](5) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Security_Users]    Script Date: 26/09/1398 04:35:01 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Security_Users](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[Description] [text] NULL,
	[Area] [nvarchar](5) NULL,
	[Admin] [bit] NULL,
	[Online] [bit] NULL,
	[Date_In] [nvarchar](8) NULL,
	[Time_In] [nchar](8) NULL,
	[Date_Exit] [nvarchar](8) NULL,
	[Time_Exit] [nvarchar](8) NULL,
	[Host_Name] [nvarchar](50) NULL,
	[Host_String] [nvarchar](50) NULL,
	[Id_User] [nvarchar](5) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Sms_Details]    Script Date: 26/09/1398 04:35:01 ب.ظ ******/
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
/****** Object:  Table [dbo].[Sms_Panel]    Script Date: 26/09/1398 04:35:01 ب.ظ ******/
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
/****** Object:  Table [dbo].[Sms_Sefid]    Script Date: 26/09/1398 04:35:02 ب.ظ ******/
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
/****** Object:  Table [dbo].[St_Goods]    Script Date: 26/09/1398 04:35:02 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[St_Goods](
	[Goods_Id] [int] IDENTITY(1,1) NOT NULL,
	[Goods_Code] [nvarchar](50) NULL,
	[Goods_name] [nvarchar](255) NULL,
	[Goods_Group] [int] NULL,
	[Goods_Module] [int] NULL,
	[Goods_Case] [int] NULL,
	[Goods_Technical_Code] [nvarchar](50) NULL,
	[Goods_Description] [nvarchar](255) NULL,
	[Id_User] [nvarchar](5) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ST_Stock]    Script Date: 26/09/1398 04:35:02 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ST_Stock](
	[ID_Stock] [int] IDENTITY(1,1) NOT NULL,
	[Code_Stock] [nvarchar](50) NOT NULL,
	[Name_Stock] [nvarchar](255) NOT NULL,
	[M_Stock] [int] NOT NULL,
	[C_Address] [nvarchar](255) NULL,
	[C_Receipt] [bit] NULL,
	[C_Request] [bit] NULL,
	[C_Direct] [bit] NOT NULL,
	[C_Negative] [bit] NULL,
	[Area_Stock] [nvarchar](5) NOT NULL,
	[Id_User] [nvarchar](5) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ST_Stock_Details]    Script Date: 26/09/1398 04:35:02 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ST_Stock_Details](
	[Id_Details] [int] IDENTITY(1,1) NOT NULL,
	[Number_St_Details] [int] NULL,
	[Goods_St_Details] [nvarchar](10) NULL,
	[First_Number_St_Details] [numeric](18, 0) NULL,
	[Second_Number_St_Details] [numeric](18, 0) NULL,
	[Third_Number_St_Details] [numeric](18, 0) NULL,
	[Price_St_Details] [numeric](18, 0) NULL,
	[Description_St_Details] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ST_Stock_Refrence]    Script Date: 26/09/1398 04:35:02 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ST_Stock_Refrence](
	[Id_St_Refrence] [int] IDENTITY(1,1) NOT NULL,
	[Number_St_Refrence] [int] NULL,
	[Parent_St_Refrence] [int] NULL,
	[Date_St_Refrence] [nvarchar](8) NULL,
	[Personal_St_Refrence] [int] NOT NULL,
	[Procurement_St_Refrence] [int] NULL,
	[Stock_St_Refrence] [int] NULL,
	[Description_St_Refrence] [nvarchar](255) NULL,
	[Class_St_Refrence] [int] NULL,
	[Area_St_Refrence] [nvarchar](5) NULL,
	[Id_User] [nvarchar](5) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tender_offer]    Script Date: 26/09/1398 04:35:03 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tender_offer](
	[Id] [int] NOT NULL,
	[Tender_offer_Title] [nvarchar](255) NOT NULL,
	[Tender_offer_Alias] [nvarchar](255) NOT NULL,
	[Tender_offer_Documents] [nvarchar](255) NOT NULL,
	[Tender_offer_Publish] [nvarchar](255) NOT NULL,
	[Tender_offer_State] [nvarchar](255) NOT NULL,
	[Tender_offer_City] [nvarchar](255) NOT NULL,
	[Tender_offer_Advertising_Kind_of] [nvarchar](50) NOT NULL,
	[Tender_offer_Advertising_Number] [nvarchar](50) NOT NULL,
	[Tender_offer_Advertising_Date] [nvarchar](8) NOT NULL,
	[Tender_offer_Newspaper] [nvarchar](255) NOT NULL,
	[Tender_offer_Description] [nvarchar](255) NOT NULL,
	[Tender_offer_DateReceive] [nvarchar](8) NOT NULL,
	[Tender_offer_DateSend] [nvarchar](8) NOT NULL,
	[Tender_offer_Price] [nvarchar](50) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Warranty_Document]    Script Date: 26/09/1398 04:35:03 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Warranty_Document](
	[Warranty_Document_Id] [int] IDENTITY(1,1) NOT NULL,
	[Warranty_Document_Subscription] [int] NOT NULL,
	[Warranty_Document_Operation] [numeric](18, 0) NOT NULL,
	[Warranty_Document_No_Date] [nvarchar](8) NOT NULL,
	[Warranty_Document_Number] [nvarchar](50) NOT NULL,
	[Warranty_Document_Date] [nvarchar](8) NOT NULL,
	[Warranty_Document_Due_Date] [nvarchar](8) NOT NULL,
	[Warranty_Document_Contract_Number] [nvarchar](50) NOT NULL,
	[Warranty_Document_Contract_Date] [nvarchar](8) NOT NULL,
	[Warranty_Document_Extended_Date] [nvarchar](8) NOT NULL,
	[Warranty_Document_Refund_Date] [nvarchar](8) NOT NULL,
	[Warranty_Document_Case] [nvarchar](8) NOT NULL,
	[Warranty_Document_No_Check] [varchar](255) NOT NULL,
	[Warranty_Document_Account_Number] [varchar](255) NOT NULL,
	[Warranty_Document_Bank] [nvarchar](255) NOT NULL,
	[Warranty_Document_Branch] [nvarchar](255) NOT NULL,
	[Warranty_Document_Amount] [nvarchar](50) NOT NULL,
	[Warranty_Document_Description] [nvarchar](255) NOT NULL,
	[Warranty_Document_Area] [nvarchar](5) NOT NULL,
	[id_user] [nvarchar](5) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Security_Users] ADD  CONSTRAINT [DF_SecurityUsers_Password_1]  DEFAULT ('') FOR [Password]
GO
USE [master]
GO
ALTER DATABASE [Amval] SET  READ_WRITE 
GO
