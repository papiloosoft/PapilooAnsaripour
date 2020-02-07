using System.Data.OleDb;
using System.Data.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;
using System.Windows;
using SystemColors = System.Drawing.SystemColors;

namespace Ansaripour
{
    public partial class MDIParent1 : System.Windows.Forms.Form
    {
        private System.ComponentModel.IContainer components = null;
        //Form overrides dispose to clean up the component list.
        [System.Diagnostics.DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components != null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }


        //Required by the Windows Form Designer

        //NOTE: The following procedure is required by the Windows Form Designer
        //It can be modified using the Windows Form Designer.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIParent1));
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.Services = new System.Windows.Forms.ToolStripMenuItem();
            this.Services_Sale_Managing = new System.Windows.Forms.ToolStripMenuItem();
            this.Services_Order_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.Services_Seasonal_Buy_Sales = new System.Windows.Forms.ToolStripMenuItem();
            this.Services_Seasonal_Buy = new System.Windows.Forms.ToolStripMenuItem();
            this.Services_Seasonal_Sale = new System.Windows.Forms.ToolStripMenuItem();
            this.Services_Seasonal_Contractor = new System.Windows.Forms.ToolStripMenuItem();
            this.Services_Seasonal_Employer = new System.Windows.Forms.ToolStripMenuItem();
            this.Services_Seasonal_Export = new System.Windows.Forms.ToolStripMenuItem();
            this.Services_Seasonal_Importation = new System.Windows.Forms.ToolStripMenuItem();
            this.Services_Seasonal_Contract_Work = new System.Windows.Forms.ToolStripMenuItem();
            this.Services_Seasonal_Rent = new System.Windows.Forms.ToolStripMenuItem();
            this.Services_Seasonal_Presell = new System.Windows.Forms.ToolStripMenuItem();
            this.Services_Access = new System.Windows.Forms.ToolStripMenuItem();
            this.Services_Edit_Access = new System.Windows.Forms.ToolStripMenuItem();
            this.Services_Delete_Access = new System.Windows.Forms.ToolStripMenuItem();
            this.Accounting = new System.Windows.Forms.ToolStripMenuItem();
            this.Accounting_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.Accounting_View = new System.Windows.Forms.ToolStripMenuItem();
            this.Accounting_Mechanized = new System.Windows.Forms.ToolStripMenuItem();
            this.Accounting_Access = new System.Windows.Forms.ToolStripMenuItem();
            this.Accounting_Edit_Access = new System.Windows.Forms.ToolStripMenuItem();
            this.Accounting_Delete_Access = new System.Windows.Forms.ToolStripMenuItem();
            this.Repair = new System.Windows.Forms.ToolStripMenuItem();
            this.Repair_Equipment = new System.Windows.Forms.ToolStripMenuItem();
            this.Repair_Cost = new System.Windows.Forms.ToolStripMenuItem();
            this.Repair_Access = new System.Windows.Forms.ToolStripMenuItem();
            this.Repair_Edit_Access = new System.Windows.Forms.ToolStripMenuItem();
            this.Repair_Delete_Access = new System.Windows.Forms.ToolStripMenuItem();
            this.PayRoll = new System.Windows.Forms.ToolStripMenuItem();
            this.PayRoll_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.PayRoll_Attendance_Mechanized = new System.Windows.Forms.ToolStripMenuItem();
            this.PayRoll_Attendance_Manual = new System.Windows.Forms.ToolStripMenuItem();
            this.PayRoll_Base_Information = new System.Windows.Forms.ToolStripMenuItem();
            this.PayRoll_Deductions = new System.Windows.Forms.ToolStripMenuItem();
            this.PayRoll_Cure = new System.Windows.Forms.ToolStripMenuItem();
            this.PayRoll_Computing = new System.Windows.Forms.ToolStripMenuItem();
            this.PayRoll_Computing_Difference = new System.Windows.Forms.ToolStripMenuItem();
            this.PayRoll_Access = new System.Windows.Forms.ToolStripMenuItem();
            this.PayRoll_Edit_Access = new System.Windows.Forms.ToolStripMenuItem();
            this.PayRoll_Delete_Access = new System.Windows.Forms.ToolStripMenuItem();
            this.Warehouse = new System.Windows.Forms.ToolStripMenuItem();
            this.Warehouse_Request_Buy_Goods = new System.Windows.Forms.ToolStripMenuItem();
            this.Warehouse_Request_Goods = new System.Windows.Forms.ToolStripMenuItem();
            this.Warehouse_Request_Buy = new System.Windows.Forms.ToolStripMenuItem();
            this.Warehouse_Request_Services = new System.Windows.Forms.ToolStripMenuItem();
            this.Warehouse_Receipt_Remittance = new System.Windows.Forms.ToolStripMenuItem();
            this.Warehouse_Receipt = new System.Windows.Forms.ToolStripMenuItem();
            this.Warehouse_Receipt_Buy = new System.Windows.Forms.ToolStripMenuItem();
            this.Warehouse_Receipt_Return = new System.Windows.Forms.ToolStripMenuItem();
            this.Warehouse_Receipt_Loan = new System.Windows.Forms.ToolStripMenuItem();
            this.Warehouse_Receipt_Production = new System.Windows.Forms.ToolStripMenuItem();
            this.Warehouse_Opening = new System.Windows.Forms.ToolStripMenuItem();
            this.Warehouse_Remittance = new System.Windows.Forms.ToolStripMenuItem();
            this.Warehouse_Remittance_Use = new System.Windows.Forms.ToolStripMenuItem();
            this.Warehouse_Remittance_Sell = new System.Windows.Forms.ToolStripMenuItem();
            this.Warehouse_Receipt_Remittance_Direct = new System.Windows.Forms.ToolStripMenuItem();
            this.Warehouse_Pricing = new System.Windows.Forms.ToolStripMenuItem();
            this.Warehouse_Handling = new System.Windows.Forms.ToolStripMenuItem();
            this.Warehouse_Handling_Tag = new System.Windows.Forms.ToolStripMenuItem();
            this.Warehouse_First_Count = new System.Windows.Forms.ToolStripMenuItem();
            this.Warehouse_Second_Count = new System.Windows.Forms.ToolStripMenuItem();
            this.Warehouse_Final_Count = new System.Windows.Forms.ToolStripMenuItem();
            this.Warehouse_Access = new System.Windows.Forms.ToolStripMenuItem();
            this.Warehouse_Edit_Access = new System.Windows.Forms.ToolStripMenuItem();
            this.Warehouse_Accounting_Access = new System.Windows.Forms.ToolStripMenuItem();
            this.Warehouse_Delete_Access = new System.Windows.Forms.ToolStripMenuItem();
            this.Assets = new System.Windows.Forms.ToolStripMenuItem();
            this.Assets_Fixed = new System.Windows.Forms.ToolStripMenuItem();
            this.Assets_Intangible = new System.Windows.Forms.ToolStripMenuItem();
            this.Assets_Consumable = new System.Windows.Forms.ToolStripMenuItem();
            this.Assets_Increase = new System.Windows.Forms.ToolStripMenuItem();
            this.Assets_Decrease = new System.Windows.Forms.ToolStripMenuItem();
            this.Assets_Movement = new System.Windows.Forms.ToolStripMenuItem();
            this.Assets_Dismiss = new System.Windows.Forms.ToolStripMenuItem();
            this.Assets_Revaluation = new System.Windows.Forms.ToolStripMenuItem();
            this.Assets_Calculate_Depreciation = new System.Windows.Forms.ToolStripMenuItem();
            this.Assets_Management = new System.Windows.Forms.ToolStripMenuItem();
            this.Assets_Access = new System.Windows.Forms.ToolStripMenuItem();
            this.Assets_Edit_Access = new System.Windows.Forms.ToolStripMenuItem();
            this.Assets_Delete_Access = new System.Windows.Forms.ToolStripMenuItem();
            this.Payable = new System.Windows.Forms.ToolStripMenuItem();
            this.Payable_Payment = new System.Windows.Forms.ToolStripMenuItem();
            this.Payable_Deposits = new System.Windows.Forms.ToolStripMenuItem();
            this.Payable_Wage = new System.Windows.Forms.ToolStripMenuItem();
            this.Payable_Access = new System.Windows.Forms.ToolStripMenuItem();
            this.Payable_Edit_Access = new System.Windows.Forms.ToolStripMenuItem();
            this.Payable_Delete_Access = new System.Windows.Forms.ToolStripMenuItem();
            this.Collection_Document = new System.Windows.Forms.ToolStripMenuItem();
            this.Collection_Document_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.Collection_Document_Assignment = new System.Windows.Forms.ToolStripMenuItem();
            this.Collection_Document_Notice = new System.Windows.Forms.ToolStripMenuItem();
            this.Collection_Document_Back = new System.Windows.Forms.ToolStripMenuItem();
            this.Collection_Document_Extradition = new System.Windows.Forms.ToolStripMenuItem();
            this.Collection_Document_Reform = new System.Windows.Forms.ToolStripMenuItem();
            this.Collection_Document_Access = new System.Windows.Forms.ToolStripMenuItem();
            this.Collection_Document_Edit_Access = new System.Windows.Forms.ToolStripMenuItem();
            this.Collection_Document_Delete_Access = new System.Windows.Forms.ToolStripMenuItem();
            this.Warranty_Document = new System.Windows.Forms.ToolStripMenuItem();
            this.Warranty_Document_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.Warranty_Document_Extended = new System.Windows.Forms.ToolStripMenuItem();
            this.Warranty_Document_Refund = new System.Windows.Forms.ToolStripMenuItem();
            this.Warranty_Document_Reform = new System.Windows.Forms.ToolStripMenuItem();
            this.Warranty_Document_Access = new System.Windows.Forms.ToolStripMenuItem();
            this.Warranty_Document_Edit_Access = new System.Windows.Forms.ToolStripMenuItem();
            this.Warranty_Document_Delete_Access = new System.Windows.Forms.ToolStripMenuItem();
            this.Base_Information = new System.Windows.Forms.ToolStripMenuItem();
            this.Base_Information_Services = new System.Windows.Forms.ToolStripMenuItem();
            this.Base_Information_Services_Seasonal_Buy_Sales = new System.Windows.Forms.ToolStripMenuItem();
            this.Base_Seasonal_Product_Type = new System.Windows.Forms.ToolStripMenuItem();
            this.Base_Information_Services_Order = new System.Windows.Forms.ToolStripMenuItem();
            this.Base_Information_Services_Order_Customer = new System.Windows.Forms.ToolStripMenuItem();
            this.Base_Information_Services_Order_In_Services = new System.Windows.Forms.ToolStripMenuItem();
            this.Base_Information_Services_Order_Out_Services = new System.Windows.Forms.ToolStripMenuItem();
            this.Base_Information_Services_Order_Opertor = new System.Windows.Forms.ToolStripMenuItem();
            this.Base_Information_Services_Order_Rate = new System.Windows.Forms.ToolStripMenuItem();
            this.Base_Information_Services_Access = new System.Windows.Forms.ToolStripMenuItem();
            this.Base_Information_Services_Edit_Access = new System.Windows.Forms.ToolStripMenuItem();
            this.Base_Information_Services_Delete_Access = new System.Windows.Forms.ToolStripMenuItem();
            this.Base_Information_Accounting = new System.Windows.Forms.ToolStripMenuItem();
            this.Base_Information_Accounting_Account_Tree = new System.Windows.Forms.ToolStripMenuItem();
            this.Base_Information_Accounting_Detailed_Tree = new System.Windows.Forms.ToolStripMenuItem();
            this.Base_Information_Accounting_Access = new System.Windows.Forms.ToolStripMenuItem();
            this.Base_Information_Accounting_Edit_Access = new System.Windows.Forms.ToolStripMenuItem();
            this.Base_Information_Accounting_Delete_Access = new System.Windows.Forms.ToolStripMenuItem();
            this.Base_Information_Repair = new System.Windows.Forms.ToolStripMenuItem();
            this.Base_Information_Repair_Seating = new System.Windows.Forms.ToolStripMenuItem();
            this.Base_Information_Repair_Energy = new System.Windows.Forms.ToolStripMenuItem();
            this.Base_Information_Repair_Phase = new System.Windows.Forms.ToolStripMenuItem();
            this.Base_Information_Repair_Kind_Stream = new System.Windows.Forms.ToolStripMenuItem();
            this.Base_Information_Repair_Kind_Fuse = new System.Windows.Forms.ToolStripMenuItem();
            this.Base_Information_Repair_Connector_Type = new System.Windows.Forms.ToolStripMenuItem();
            this.Base_Information_Repair_Stop_Defect = new System.Windows.Forms.ToolStripMenuItem();
            this.Base_Information_Repair_Access = new System.Windows.Forms.ToolStripMenuItem();
            this.Base_Information_Repair_Edit_Access = new System.Windows.Forms.ToolStripMenuItem();
            this.Base_Information_Repair_Delete_Access = new System.Windows.Forms.ToolStripMenuItem();
            this.Base_Information_PayRoll = new System.Windows.Forms.ToolStripMenuItem();
            this.Base_Information_PayRoll_Personal = new System.Windows.Forms.ToolStripMenuItem();
            this.Base_Information_PayRoll_Employment = new System.Windows.Forms.ToolStripMenuItem();
            this.Base_Information_PayRoll_Deductions_Legal = new System.Windows.Forms.ToolStripMenuItem();
            this.Base_Information_PayRoll_Deductions_Diffrent = new System.Windows.Forms.ToolStripMenuItem();
            this.Base_Information_PayRoll_Family = new System.Windows.Forms.ToolStripMenuItem();
            this.Base_Information_PayRoll_Calandar = new System.Windows.Forms.ToolStripMenuItem();
            this.Base_Information_PayRoll_Access = new System.Windows.Forms.ToolStripMenuItem();
            this.Base_Information_PayRoll_Edit_Access = new System.Windows.Forms.ToolStripMenuItem();
            this.Base_Information_PayRoll_Delete_Access = new System.Windows.Forms.ToolStripMenuItem();
            this.Base_Information_Warehouse = new System.Windows.Forms.ToolStripMenuItem();
            this.Base_Information_Warehouse_Units = new System.Windows.Forms.ToolStripMenuItem();
            this.Base_Information_Warehouse_Sources = new System.Windows.Forms.ToolStripMenuItem();
            this.Base_Information_Warehouse_Unit_Goods = new System.Windows.Forms.ToolStripMenuItem();
            this.Base_Information_Warehouse_Grouping_Goods = new System.Windows.Forms.ToolStripMenuItem();
            this.Base_Information_Warehouse_Collection_Goods = new System.Windows.Forms.ToolStripMenuItem();
            this.Base_Information_Warehouse_Access = new System.Windows.Forms.ToolStripMenuItem();
            this.Base_Information_Warehouse_Edit_Access = new System.Windows.Forms.ToolStripMenuItem();
            this.Base_Information_Warehouse_Delete_Access = new System.Windows.Forms.ToolStripMenuItem();
            this.Base_Information_Assets = new System.Windows.Forms.ToolStripMenuItem();
            this.Base_Information_Assets_Depreciation_Rate = new System.Windows.Forms.ToolStripMenuItem();
            this.Base_Information_Assets_Plan_project = new System.Windows.Forms.ToolStripMenuItem();
            this.Base_Information_Assets_City = new System.Windows.Forms.ToolStripMenuItem();
            this.Base_Information_Assets_Personnel = new System.Windows.Forms.ToolStripMenuItem();
            this.Base_Information_Assets_Cost_Code = new System.Windows.Forms.ToolStripMenuItem();
            this.Base_Information_Assets_Date = new System.Windows.Forms.ToolStripMenuItem();
            this.Base_Information_Assets_Access = new System.Windows.Forms.ToolStripMenuItem();
            this.Base_Information_Assets_Edit_Access = new System.Windows.Forms.ToolStripMenuItem();
            this.Base_Information_Assets_Delete_Access = new System.Windows.Forms.ToolStripMenuItem();
            this.Base_Information_Document = new System.Windows.Forms.ToolStripMenuItem();
            this.Base_Information_Document_Bank = new System.Windows.Forms.ToolStripMenuItem();
            this.Base_Information_Document_Recovery_Classification = new System.Windows.Forms.ToolStripMenuItem();
            this.Base_Information_Warranty_Document_Classification = new System.Windows.Forms.ToolStripMenuItem();
            this.Base_Information_Document_Customer = new System.Windows.Forms.ToolStripMenuItem();
            this.Base_Information_Document_Area = new System.Windows.Forms.ToolStripMenuItem();
            this.Base_Information_Document_Access = new System.Windows.Forms.ToolStripMenuItem();
            this.Base_Information_Document_Edit_Access = new System.Windows.Forms.ToolStripMenuItem();
            this.Base_Information_Document_Delete_Access = new System.Windows.Forms.ToolStripMenuItem();
            this.Reports = new System.Windows.Forms.ToolStripMenuItem();
            this.Report_Services = new System.Windows.Forms.ToolStripMenuItem();
            this.Report_Accounting = new System.Windows.Forms.ToolStripMenuItem();
            this.Report_Accounting_Note_Book = new System.Windows.Forms.ToolStripMenuItem();
            this.Report_Accounting_Account_Note_Book = new System.Windows.Forms.ToolStripMenuItem();
            this.Report_Accounting_Details_Note_One_Book = new System.Windows.Forms.ToolStripMenuItem();
            this.Report_Accounting_Details_Note_Two_Book = new System.Windows.Forms.ToolStripMenuItem();
            this.Report_Accounting_Details_Note_Three_Book = new System.Windows.Forms.ToolStripMenuItem();
            this.Report_Accounting_Details_Note_Four_Book = new System.Windows.Forms.ToolStripMenuItem();
            this.Report_Accounting_Details_Note_Five_Book = new System.Windows.Forms.ToolStripMenuItem();
            this.Report_Accounting_Align = new System.Windows.Forms.ToolStripMenuItem();
            this.Report_Accounting_Four_Column_Align = new System.Windows.Forms.ToolStripMenuItem();
            this.Report_Accounting_Details_Four_Column_Align = new System.Windows.Forms.ToolStripMenuItem();
            this.Report_Accounting_Eight_Column_Align = new System.Windows.Forms.ToolStripMenuItem();
            this.Report_Accounting_Details_Eight_Column_Align = new System.Windows.Forms.ToolStripMenuItem();
            this.Report_Accounting_Reports = new System.Windows.Forms.ToolStripMenuItem();
            this.Report_Accounting_Details = new System.Windows.Forms.ToolStripMenuItem();
            this.Report_Accounting_Analysis = new System.Windows.Forms.ToolStripMenuItem();
            this.Report_Repair = new System.Windows.Forms.ToolStripMenuItem();
            this.Report_PayRoll = new System.Windows.Forms.ToolStripMenuItem();
            this.Report_Warehouse = new System.Windows.Forms.ToolStripMenuItem();
            this.Report_Warehouse_Number = new System.Windows.Forms.ToolStripMenuItem();
            this.Report_Warehouse_Cardx = new System.Windows.Forms.ToolStripMenuItem();
            this.Report_Warehouse_Turnover = new System.Windows.Forms.ToolStripMenuItem();
            this.Report_Warehouse_Inventory = new System.Windows.Forms.ToolStripMenuItem();
            this.Report_Warehouse_Accounting = new System.Windows.Forms.ToolStripMenuItem();
            this.Report_Warehouse_Accounting_Cardx = new System.Windows.Forms.ToolStripMenuItem();
            this.Report_Warehouse_Accounting_Turnover = new System.Windows.Forms.ToolStripMenuItem();
            this.Report_Warehouse_Accounting_Inventory = new System.Windows.Forms.ToolStripMenuItem();
            this.Report_Warehouse_Handling = new System.Windows.Forms.ToolStripMenuItem();
            this.Report_Warehouse_Handling_One_Counts = new System.Windows.Forms.ToolStripMenuItem();
            this.Report_Warehouse_Handling_Two_Counts = new System.Windows.Forms.ToolStripMenuItem();
            this.Report_Warehouse_Handling_Third_Counts = new System.Windows.Forms.ToolStripMenuItem();
            this.Report_Estate = new System.Windows.Forms.ToolStripMenuItem();
            this.Report_Estate_Responsible = new System.Windows.Forms.ToolStripMenuItem();
            this.Report_Estate_Consumable_Delivering = new System.Windows.Forms.ToolStripMenuItem();
            this.Report_Estate_Delivering = new System.Windows.Forms.ToolStripMenuItem();
            this.Report_Consumable_Delivering = new System.Windows.Forms.ToolStripMenuItem();
            this.Report_Estate_Accountants = new System.Windows.Forms.ToolStripMenuItem();
            this.Report_Estate_Facial = new System.Windows.Forms.ToolStripMenuItem();
            this.Report_Estate_Original_Code = new System.Windows.Forms.ToolStripMenuItem();
            this.Report_Estate_Cost_Code = new System.Windows.Forms.ToolStripMenuItem();
            this.Report_Estate_Cost_Original = new System.Windows.Forms.ToolStripMenuItem();
            this.Report_Estate_Original_Cost = new System.Windows.Forms.ToolStripMenuItem();
            this.Report_Estate_Original_Cost_City = new System.Windows.Forms.ToolStripMenuItem();
            this.Report_Estate_Decrease = new System.Windows.Forms.ToolStripMenuItem();
            this.Report_Estate_Dismiss = new System.Windows.Forms.ToolStripMenuItem();
            this.Report_Estate_Document_Cost = new System.Windows.Forms.ToolStripMenuItem();
            this.Report_Estate_Document_Original = new System.Windows.Forms.ToolStripMenuItem();
            this.Report_Estate_Document_Dismiss = new System.Windows.Forms.ToolStripMenuItem();
            this.Report_Payable = new System.Windows.Forms.ToolStripMenuItem();
            this.Report_Payable_Turnover = new System.Windows.Forms.ToolStripMenuItem();
            this.Report_Payable_Checked_Out = new System.Windows.Forms.ToolStripMenuItem();
            this.Report_Payable_Deposits = new System.Windows.Forms.ToolStripMenuItem();
            this.Report_Payable_Wage = new System.Windows.Forms.ToolStripMenuItem();
            this.Report_Collection_Document = new System.Windows.Forms.ToolStripMenuItem();
            this.Report_Collection_Document_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.Report_Collection_Document_Due_Date = new System.Windows.Forms.ToolStripMenuItem();
            this.Report_Collection_Document_Assignment = new System.Windows.Forms.ToolStripMenuItem();
            this.Report_Collection_Document_Notice = new System.Windows.Forms.ToolStripMenuItem();
            this.Report_Collection_Document_Back = new System.Windows.Forms.ToolStripMenuItem();
            this.Report_Collection_Document_Refund_Date = new System.Windows.Forms.ToolStripMenuItem();
            this.Report_Collection_Document_Receipt = new System.Windows.Forms.ToolStripMenuItem();
            this.Report_Warranty_Document = new System.Windows.Forms.ToolStripMenuItem();
            this.Report_Warranty_Document_No_Date = new System.Windows.Forms.ToolStripMenuItem();
            this.Report_Warranty_Document_Extended_Date = new System.Windows.Forms.ToolStripMenuItem();
            this.Report_Warranty_Document_Refund_Date = new System.Windows.Forms.ToolStripMenuItem();
            this.Report_Warranty_Document_Due_Date = new System.Windows.Forms.ToolStripMenuItem();
            this.Report_Warranty_Document_Date = new System.Windows.Forms.ToolStripMenuItem();
            this.View = new System.Windows.Forms.ToolStripMenuItem();
            this.View_Menu_Toolbox = new System.Windows.Forms.ToolStripMenuItem();
            this.View_Menu_Subtitle = new System.Windows.Forms.ToolStripMenuItem();
            this.View_Menu_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.View_Menu_Log = new System.Windows.Forms.ToolStripMenuItem();
            this.Systems = new System.Windows.Forms.ToolStripMenuItem();
            this.Exits = new System.Windows.Forms.ToolStripMenuItem();
            this.System_User_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.System_Area_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.System_Activation_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.System_Chang_User_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.System_sms = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.Today_Date = new System.Windows.Forms.ToolStripStatusLabel();
            this.ID = new System.Windows.Forms.ToolStripStatusLabel();
            this.I_N = new System.Windows.Forms.ToolStripStatusLabel();
            this.Report = new System.Windows.Forms.ToolStripStatusLabel();
            this.N_Admin = new System.Windows.Forms.ToolStripStatusLabel();
            this.N_Id_Area = new System.Windows.Forms.ToolStripStatusLabel();
            this.N_Company_Area = new System.Windows.Forms.ToolStripStatusLabel();
            this.N_Department_Area = new System.Windows.Forms.ToolStripStatusLabel();
            this.N_Fiscal_Year_Area = new System.Windows.Forms.ToolStripStatusLabel();
            this.Description = new System.Windows.Forms.ToolStripStatusLabel();
            this.Information = new System.Windows.Forms.ToolStripStatusLabel();
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.PictureBox3 = new System.Windows.Forms.PictureBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label_Collection = new System.Windows.Forms.Label();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label_Warranty = new System.Windows.Forms.Label();
            this.tvData = new System.Windows.Forms.TreeView();
            this.MenuStrip.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).BeginInit();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = SystemColors.GradientActiveCaption;
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Services,
            this.Accounting,
            this.Repair,
            this.PayRoll,
            this.Warehouse,
            this.Assets,
            this.Payable,
            this.Collection_Document,
            this.Warranty_Document,
            this.Base_Information,
            this.Reports,
            this.View,
            this.Systems,
            this.Exits});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(762, 24);
            this.MenuStrip.TabIndex = 5;
            this.MenuStrip.Text = "MenuStrip";
            // 
            // Services
            // 
            this.Services.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Services_Sale_Managing,
            this.Services_Order_Add,
            this.Services_Seasonal_Buy_Sales,
            this.Services_Access});
            this.Services.Name = "Services";
            this.Services.Size = new System.Drawing.Size(53, 20);
            this.Services.Text = "خدمات";
            this.Services.Visible = false;
            // 
            // Services_Sale_Managing
            // 
            this.Services_Sale_Managing.Name = "Services_Sale_Managing";
            this.Services_Sale_Managing.Size = new System.Drawing.Size(174, 22);
            this.Services_Sale_Managing.Text = "مـــــدیـــریـــت فـــروش";
            this.Services_Sale_Managing.Visible = false;
            // 
            // Services_Order_Add
            // 
            this.Services_Order_Add.Name = "Services_Order_Add";
            this.Services_Order_Add.Size = new System.Drawing.Size(174, 22);
            this.Services_Order_Add.Text = "ثـــــبـــــــت ســـفـــــارش";
            this.Services_Order_Add.Visible = false;
            // 
            // Services_Seasonal_Buy_Sales
            // 
            this.Services_Seasonal_Buy_Sales.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Services_Seasonal_Buy,
            this.Services_Seasonal_Sale,
            this.Services_Seasonal_Contractor,
            this.Services_Seasonal_Employer,
            this.Services_Seasonal_Export,
            this.Services_Seasonal_Importation,
            this.Services_Seasonal_Contract_Work,
            this.Services_Seasonal_Rent,
            this.Services_Seasonal_Presell});
            this.Services_Seasonal_Buy_Sales.Name = "Services_Seasonal_Buy_Sales";
            this.Services_Seasonal_Buy_Sales.Size = new System.Drawing.Size(174, 22);
            this.Services_Seasonal_Buy_Sales.Text = "خرید و فروش فصلی";
            this.Services_Seasonal_Buy_Sales.Visible = false;
            // 
            // Services_Seasonal_Buy
            // 
            this.Services_Seasonal_Buy.Name = "Services_Seasonal_Buy";
            this.Services_Seasonal_Buy.Size = new System.Drawing.Size(282, 22);
            this.Services_Seasonal_Buy.Text = "ثبت اطلاعات خرید";
            this.Services_Seasonal_Buy.Visible = false;
            // 
            // Services_Seasonal_Sale
            // 
            this.Services_Seasonal_Sale.Name = "Services_Seasonal_Sale";
            this.Services_Seasonal_Sale.Size = new System.Drawing.Size(282, 22);
            this.Services_Seasonal_Sale.Text = "ثبت اطلاعات فروش";
            this.Services_Seasonal_Sale.Visible = false;
            // 
            // Services_Seasonal_Contractor
            // 
            this.Services_Seasonal_Contractor.Name = "Services_Seasonal_Contractor";
            this.Services_Seasonal_Contractor.Size = new System.Drawing.Size(282, 22);
            this.Services_Seasonal_Contractor.Text = "اطلاعات پیمانکار در پیمانهای بلند مدت";
            this.Services_Seasonal_Contractor.Visible = false;
            // 
            // Services_Seasonal_Employer
            // 
            this.Services_Seasonal_Employer.Name = "Services_Seasonal_Employer";
            this.Services_Seasonal_Employer.Size = new System.Drawing.Size(282, 22);
            this.Services_Seasonal_Employer.Text = "اطلاعات کارفـرما در پیمانهای بلند مدت";
            this.Services_Seasonal_Employer.Visible = false;
            // 
            // Services_Seasonal_Export
            // 
            this.Services_Seasonal_Export.Name = "Services_Seasonal_Export";
            this.Services_Seasonal_Export.Size = new System.Drawing.Size(282, 22);
            this.Services_Seasonal_Export.Text = "اطلاعات صادرات / فروش به شخص خارجی";
            this.Services_Seasonal_Export.Visible = false;
            // 
            // Services_Seasonal_Importation
            // 
            this.Services_Seasonal_Importation.Name = "Services_Seasonal_Importation";
            this.Services_Seasonal_Importation.Size = new System.Drawing.Size(282, 22);
            this.Services_Seasonal_Importation.Text = "اطلاعـات واردات / خــریــد از شخص خارجی";
            this.Services_Seasonal_Importation.Visible = false;
            // 
            // Services_Seasonal_Contract_Work
            // 
            this.Services_Seasonal_Contract_Work.Name = "Services_Seasonal_Contract_Work";
            this.Services_Seasonal_Contract_Work.Size = new System.Drawing.Size(282, 22);
            this.Services_Seasonal_Contract_Work.Text = "اطلاعات حق العملکاری";
            this.Services_Seasonal_Contract_Work.Visible = false;
            // 
            // Services_Seasonal_Rent
            // 
            this.Services_Seasonal_Rent.Name = "Services_Seasonal_Rent";
            this.Services_Seasonal_Rent.Size = new System.Drawing.Size(282, 22);
            this.Services_Seasonal_Rent.Text = "اطلاعات اجاره";
            this.Services_Seasonal_Rent.Visible = false;
            // 
            // Services_Seasonal_Presell
            // 
            this.Services_Seasonal_Presell.Name = "Services_Seasonal_Presell";
            this.Services_Seasonal_Presell.Size = new System.Drawing.Size(282, 22);
            this.Services_Seasonal_Presell.Text = "اطلاعات ساخت و پیش فروش املاک";
            this.Services_Seasonal_Presell.Visible = false;
            // 
            // Services_Access
            // 
            this.Services_Access.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Services_Edit_Access,
            this.Services_Delete_Access});
            this.Services_Access.Name = "Services_Access";
            this.Services_Access.Size = new System.Drawing.Size(174, 22);
            this.Services_Access.Text = "سطح دسترسی";
            this.Services_Access.Visible = false;
            // 
            // Services_Edit_Access
            // 
            this.Services_Edit_Access.Name = "Services_Edit_Access";
            this.Services_Edit_Access.Size = new System.Drawing.Size(233, 22);
            this.Services_Edit_Access.Text = "دسترسی به ویرایش اسناد خدمات";
            this.Services_Edit_Access.Visible = false;
            // 
            // Services_Delete_Access
            // 
            this.Services_Delete_Access.Name = "Services_Delete_Access";
            this.Services_Delete_Access.Size = new System.Drawing.Size(233, 22);
            this.Services_Delete_Access.Text = "دسترسی به حـــــذف اسناد خدمات";
            this.Services_Delete_Access.Visible = false;
            // 
            // Accounting
            // 
            this.Accounting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Accounting_Add,
            this.Accounting_View,
            this.Accounting_Mechanized,
            this.Accounting_Access});
            this.Accounting.Name = "Accounting";
            this.Accounting.Size = new System.Drawing.Size(65, 20);
            this.Accounting.Text = "حسابداری";
            this.Accounting.Visible = false;
            // 
            // Accounting_Add
            // 
            this.Accounting_Add.Name = "Accounting_Add";
            this.Accounting_Add.Size = new System.Drawing.Size(233, 22);
            this.Accounting_Add.Text = "ثــــبــــــــت اســــــنـــــــاد حـسابــداری";
            this.Accounting_Add.Visible = false;
            // 
            // Accounting_View
            // 
            this.Accounting_View.Name = "Accounting_View";
            this.Accounting_View.Size = new System.Drawing.Size(233, 22);
            this.Accounting_View.Text = "ملاحظه فهرست اسناد حسابداری";
            this.Accounting_View.Visible = false;
            // 
            // Accounting_Mechanized
            // 
            this.Accounting_Mechanized.Name = "Accounting_Mechanized";
            this.Accounting_Mechanized.Size = new System.Drawing.Size(233, 22);
            this.Accounting_Mechanized.Text = "سیستم مـکـانیـزه اسناد حسابداری ";
            this.Accounting_Mechanized.Visible = false;
            // 
            // Accounting_Access
            // 
            this.Accounting_Access.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Accounting_Edit_Access,
            this.Accounting_Delete_Access});
            this.Accounting_Access.Name = "Accounting_Access";
            this.Accounting_Access.Size = new System.Drawing.Size(233, 22);
            this.Accounting_Access.Text = "سطح دسترسی";
            this.Accounting_Access.Visible = false;
            // 
            // Accounting_Edit_Access
            // 
            this.Accounting_Edit_Access.Name = "Accounting_Edit_Access";
            this.Accounting_Edit_Access.Size = new System.Drawing.Size(246, 22);
            this.Accounting_Edit_Access.Text = "دسترسی به ویرایش اسناد حسابداری";
            this.Accounting_Edit_Access.Visible = false;
            // 
            // Accounting_Delete_Access
            // 
            this.Accounting_Delete_Access.Name = "Accounting_Delete_Access";
            this.Accounting_Delete_Access.Size = new System.Drawing.Size(246, 22);
            this.Accounting_Delete_Access.Text = "دسترسی به حــــــذف اسناد حسابداری";
            this.Accounting_Delete_Access.Visible = false;
            // 
            // Repair
            // 
            this.Repair.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Repair_Equipment,
            this.Repair_Cost,
            this.Repair_Access});
            this.Repair.Name = "Repair";
            this.Repair.Size = new System.Drawing.Size(96, 20);
            this.Repair.Text = "تعمیر و نگهداری";
            this.Repair.Visible = false;
            // 
            // Repair_Equipment
            // 
            this.Repair_Equipment.Name = "Repair_Equipment";
            this.Repair_Equipment.Size = new System.Drawing.Size(175, 22);
            this.Repair_Equipment.Text = "ثبت مشخصات فــنـی";
            this.Repair_Equipment.Visible = false;
            // 
            // Repair_Cost
            // 
            this.Repair_Cost.Name = "Repair_Cost";
            this.Repair_Cost.Size = new System.Drawing.Size(175, 22);
            this.Repair_Cost.Text = "ثبت هزینه تـعـمـیـرات";
            this.Repair_Cost.Visible = false;
            // 
            // Repair_Access
            // 
            this.Repair_Access.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Repair_Edit_Access,
            this.Repair_Delete_Access});
            this.Repair_Access.Name = "Repair_Access";
            this.Repair_Access.Size = new System.Drawing.Size(175, 22);
            this.Repair_Access.Text = "سطح دسترسی";
            this.Repair_Access.Visible = false;
            // 
            // Repair_Edit_Access
            // 
            this.Repair_Edit_Access.Name = "Repair_Edit_Access";
            this.Repair_Edit_Access.Size = new System.Drawing.Size(250, 22);
            this.Repair_Edit_Access.Text = "دسترسی به ویرایش  تعمیر و نگهداری";
            this.Repair_Edit_Access.Visible = false;
            // 
            // Repair_Delete_Access
            // 
            this.Repair_Delete_Access.Name = "Repair_Delete_Access";
            this.Repair_Delete_Access.Size = new System.Drawing.Size(250, 22);
            this.Repair_Delete_Access.Text = "دسترسی به حـــــذف  تعمیر و نگهداری";
            this.Repair_Delete_Access.Visible = false;
            // 
            // PayRoll
            // 
            this.PayRoll.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PayRoll_Add,
            this.PayRoll_Computing,
            this.PayRoll_Computing_Difference,
            this.PayRoll_Access});
            this.PayRoll.Name = "PayRoll";
            this.PayRoll.Size = new System.Drawing.Size(93, 20);
            this.PayRoll.Text = "حقوق ودستمزد";
            this.PayRoll.Visible = false;
            // 
            // PayRoll_Add
            // 
            this.PayRoll_Add.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PayRoll_Attendance_Mechanized,
            this.PayRoll_Attendance_Manual,
            this.PayRoll_Base_Information,
            this.PayRoll_Deductions,
            this.PayRoll_Cure});
            this.PayRoll_Add.Name = "PayRoll_Add";
            this.PayRoll_Add.Size = new System.Drawing.Size(184, 22);
            this.PayRoll_Add.Text = "ورود اطــــــــــــلاعــــــــــات";
            this.PayRoll_Add.Visible = false;
            // 
            // PayRoll_Attendance_Mechanized
            // 
            this.PayRoll_Attendance_Mechanized.Name = "PayRoll_Attendance_Mechanized";
            this.PayRoll_Attendance_Mechanized.Size = new System.Drawing.Size(234, 22);
            this.PayRoll_Attendance_Mechanized.Text = "ورود و خــروج ( ارتــباط با دستگاه )";
            this.PayRoll_Attendance_Mechanized.Visible = false;
            // 
            // PayRoll_Attendance_Manual
            // 
            this.PayRoll_Attendance_Manual.Name = "PayRoll_Attendance_Manual";
            this.PayRoll_Attendance_Manual.Size = new System.Drawing.Size(234, 22);
            this.PayRoll_Attendance_Manual.Text = "ورود و خــروج ( ثــــبــت دســـــتــی )";
            this.PayRoll_Attendance_Manual.Visible = false;
            // 
            // PayRoll_Base_Information
            // 
            this.PayRoll_Base_Information.Name = "PayRoll_Base_Information";
            this.PayRoll_Base_Information.Size = new System.Drawing.Size(234, 22);
            this.PayRoll_Base_Information.Text = "ثبت  اطلاعات پـایــه حقوق و مزایا";
            this.PayRoll_Base_Information.Visible = false;
            // 
            // PayRoll_Deductions
            // 
            this.PayRoll_Deductions.Name = "PayRoll_Deductions";
            this.PayRoll_Deductions.Size = new System.Drawing.Size(234, 22);
            this.PayRoll_Deductions.Text = "ثبت کــــــــســـــــورات حقوق و مزایا";
            this.PayRoll_Deductions.Visible = false;
            // 
            // PayRoll_Cure
            // 
            this.PayRoll_Cure.Name = "PayRoll_Cure";
            this.PayRoll_Cure.Size = new System.Drawing.Size(234, 22);
            this.PayRoll_Cure.Text = "ثبت اطلاعات درمـــــان  پــرسـنــلی";
            this.PayRoll_Cure.Visible = false;
            // 
            // PayRoll_Computing
            // 
            this.PayRoll_Computing.Name = "PayRoll_Computing";
            this.PayRoll_Computing.Size = new System.Drawing.Size(184, 22);
            this.PayRoll_Computing.Text = "محاسبه حـــــــــــقـــــــــوق";
            this.PayRoll_Computing.Visible = false;
            // 
            // PayRoll_Computing_Difference
            // 
            this.PayRoll_Computing_Difference.Name = "PayRoll_Computing_Difference";
            this.PayRoll_Computing_Difference.Size = new System.Drawing.Size(184, 22);
            this.PayRoll_Computing_Difference.Text = "محاسبه تفاوت حــقــوق";
            this.PayRoll_Computing_Difference.Visible = false;
            // 
            // PayRoll_Access
            // 
            this.PayRoll_Access.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PayRoll_Edit_Access,
            this.PayRoll_Delete_Access});
            this.PayRoll_Access.Name = "PayRoll_Access";
            this.PayRoll_Access.Size = new System.Drawing.Size(184, 22);
            this.PayRoll_Access.Text = "سطح دسترسی";
            this.PayRoll_Access.Visible = false;
            // 
            // PayRoll_Edit_Access
            // 
            this.PayRoll_Edit_Access.Name = "PayRoll_Edit_Access";
            this.PayRoll_Edit_Access.Size = new System.Drawing.Size(273, 22);
            this.PayRoll_Edit_Access.Text = "دسترسی به ویرایش اسناد حقوق ودستمزد";
            // 
            // PayRoll_Delete_Access
            // 
            this.PayRoll_Delete_Access.Name = "PayRoll_Delete_Access";
            this.PayRoll_Delete_Access.Size = new System.Drawing.Size(273, 22);
            this.PayRoll_Delete_Access.Text = "دسترسی به حـــــذف اسناد حقوق ودستمزد";
            // 
            // Warehouse
            // 
            this.Warehouse.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Warehouse_Request_Buy_Goods,
            this.Warehouse_Receipt_Remittance,
            this.Warehouse_Receipt_Remittance_Direct,
            this.Warehouse_Pricing,
            this.Warehouse_Handling,
            this.Warehouse_Access});
            this.Warehouse.Name = "Warehouse";
            this.Warehouse.Size = new System.Drawing.Size(64, 20);
            this.Warehouse.Text = "انـــــــبــــــار";
            this.Warehouse.Visible = false;
            // 
            // Warehouse_Request_Buy_Goods
            // 
            this.Warehouse_Request_Buy_Goods.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Warehouse_Request_Goods,
            this.Warehouse_Request_Buy,
            this.Warehouse_Request_Services});
            this.Warehouse_Request_Buy_Goods.Name = "Warehouse_Request_Buy_Goods";
            this.Warehouse_Request_Buy_Goods.Size = new System.Drawing.Size(212, 22);
            this.Warehouse_Request_Buy_Goods.Text = "صدور درخواست کــالا و خرید";
            this.Warehouse_Request_Buy_Goods.Visible = false;
            // 
            // Warehouse_Request_Goods
            // 
            this.Warehouse_Request_Goods.Name = "Warehouse_Request_Goods";
            this.Warehouse_Request_Goods.Size = new System.Drawing.Size(173, 22);
            this.Warehouse_Request_Goods.Text = "درخواست   کــــــــــالا ";
            this.Warehouse_Request_Goods.Visible = false;
            // 
            // Warehouse_Request_Buy
            // 
            this.Warehouse_Request_Buy.Name = "Warehouse_Request_Buy";
            this.Warehouse_Request_Buy.Size = new System.Drawing.Size(173, 22);
            this.Warehouse_Request_Buy.Text = "درخواست خــــــریـــــد";
            this.Warehouse_Request_Buy.Visible = false;
            // 
            // Warehouse_Request_Services
            // 
            this.Warehouse_Request_Services.Name = "Warehouse_Request_Services";
            this.Warehouse_Request_Services.Size = new System.Drawing.Size(173, 22);
            this.Warehouse_Request_Services.Text = "درخواست خــــدمـــات";
            this.Warehouse_Request_Services.Visible = false;
            // 
            // Warehouse_Receipt_Remittance
            // 
            this.Warehouse_Receipt_Remittance.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Warehouse_Receipt,
            this.Warehouse_Remittance});
            this.Warehouse_Receipt_Remittance.Name = "Warehouse_Receipt_Remittance";
            this.Warehouse_Receipt_Remittance.Size = new System.Drawing.Size(212, 22);
            this.Warehouse_Receipt_Remittance.Text = "صدور رسید و حــواله  انــــبــار";
            this.Warehouse_Receipt_Remittance.Visible = false;
            // 
            // Warehouse_Receipt
            // 
            this.Warehouse_Receipt.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Warehouse_Receipt_Buy,
            this.Warehouse_Receipt_Return,
            this.Warehouse_Receipt_Loan,
            this.Warehouse_Receipt_Production,
            this.Warehouse_Opening});
            this.Warehouse_Receipt.Name = "Warehouse_Receipt";
            this.Warehouse_Receipt.Size = new System.Drawing.Size(154, 22);
            this.Warehouse_Receipt.Text = "صدور رسید انبار";
            this.Warehouse_Receipt.Visible = false;
            // 
            // Warehouse_Receipt_Buy
            // 
            this.Warehouse_Receipt_Buy.Name = "Warehouse_Receipt_Buy";
            this.Warehouse_Receipt_Buy.Size = new System.Drawing.Size(157, 22);
            this.Warehouse_Receipt_Buy.Text = "رسید خــریــــد کالا";
            this.Warehouse_Receipt_Buy.Visible = false;
            // 
            // Warehouse_Receipt_Return
            // 
            this.Warehouse_Receipt_Return.Name = "Warehouse_Receipt_Return";
            this.Warehouse_Receipt_Return.Size = new System.Drawing.Size(157, 22);
            this.Warehouse_Receipt_Return.Text = "رسید برگشت کالا";
            this.Warehouse_Receipt_Return.Visible = false;
            // 
            // Warehouse_Receipt_Loan
            // 
            this.Warehouse_Receipt_Loan.Name = "Warehouse_Receipt_Loan";
            this.Warehouse_Receipt_Loan.Size = new System.Drawing.Size(157, 22);
            this.Warehouse_Receipt_Loan.Text = "رسید امــانــی کالا";
            this.Warehouse_Receipt_Loan.Visible = false;
            // 
            // Warehouse_Receipt_Production
            // 
            this.Warehouse_Receipt_Production.Name = "Warehouse_Receipt_Production";
            this.Warehouse_Receipt_Production.Size = new System.Drawing.Size(157, 22);
            this.Warehouse_Receipt_Production.Text = "رسید تـــولـیــد کالا";
            this.Warehouse_Receipt_Production.Visible = false;
            // 
            // Warehouse_Opening
            // 
            this.Warehouse_Opening.Name = "Warehouse_Opening";
            this.Warehouse_Opening.Size = new System.Drawing.Size(157, 22);
            this.Warehouse_Opening.Text = "افـتـتـاحـیـه انـــبــــار";
            this.Warehouse_Opening.Visible = false;
            // 
            // Warehouse_Remittance
            // 
            this.Warehouse_Remittance.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Warehouse_Remittance_Use,
            this.Warehouse_Remittance_Sell});
            this.Warehouse_Remittance.Name = "Warehouse_Remittance";
            this.Warehouse_Remittance.Size = new System.Drawing.Size(154, 22);
            this.Warehouse_Remittance.Text = "صدور حواله انبار";
            this.Warehouse_Remittance.Visible = false;
            // 
            // Warehouse_Remittance_Use
            // 
            this.Warehouse_Remittance_Use.Name = "Warehouse_Remittance_Use";
            this.Warehouse_Remittance_Use.Size = new System.Drawing.Size(156, 22);
            this.Warehouse_Remittance_Use.Text = "حواله مصرف کالا";
            this.Warehouse_Remittance_Use.Visible = false;
            // 
            // Warehouse_Remittance_Sell
            // 
            this.Warehouse_Remittance_Sell.Name = "Warehouse_Remittance_Sell";
            this.Warehouse_Remittance_Sell.Size = new System.Drawing.Size(156, 22);
            this.Warehouse_Remittance_Sell.Text = "حواله فــروش کالا";
            this.Warehouse_Remittance_Sell.Visible = false;
            // 
            // Warehouse_Receipt_Remittance_Direct
            // 
            this.Warehouse_Receipt_Remittance_Direct.Name = "Warehouse_Receipt_Remittance_Direct";
            this.Warehouse_Receipt_Remittance_Direct.Size = new System.Drawing.Size(212, 22);
            this.Warehouse_Receipt_Remittance_Direct.Text = "صدور رسید و حواله مستقیم";
            this.Warehouse_Receipt_Remittance_Direct.Visible = false;
            // 
            // Warehouse_Pricing
            // 
            this.Warehouse_Pricing.Name = "Warehouse_Pricing";
            this.Warehouse_Pricing.Size = new System.Drawing.Size(212, 22);
            this.Warehouse_Pricing.Text = "قــــیـــمــــت گـــــــذاری انـــــبـــــار";
            this.Warehouse_Pricing.Visible = false;
            // 
            // Warehouse_Handling
            // 
            this.Warehouse_Handling.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Warehouse_Handling_Tag,
            this.Warehouse_First_Count,
            this.Warehouse_Second_Count,
            this.Warehouse_Final_Count});
            this.Warehouse_Handling.Name = "Warehouse_Handling";
            this.Warehouse_Handling.Size = new System.Drawing.Size(212, 22);
            this.Warehouse_Handling.Text = "عـمــلــیـات انــــبـــــار گـــردانـــی";
            this.Warehouse_Handling.Visible = false;
            // 
            // Warehouse_Handling_Tag
            // 
            this.Warehouse_Handling_Tag.Name = "Warehouse_Handling_Tag";
            this.Warehouse_Handling_Tag.Size = new System.Drawing.Size(172, 22);
            this.Warehouse_Handling_Tag.Text = "ثبت تگ انبار گردانـی";
            this.Warehouse_Handling_Tag.Visible = false;
            // 
            // Warehouse_First_Count
            // 
            this.Warehouse_First_Count.Name = "Warehouse_First_Count";
            this.Warehouse_First_Count.Size = new System.Drawing.Size(172, 22);
            this.Warehouse_First_Count.Text = "شـمــارش  اول انـــبـار";
            this.Warehouse_First_Count.Visible = false;
            // 
            // Warehouse_Second_Count
            // 
            this.Warehouse_Second_Count.Name = "Warehouse_Second_Count";
            this.Warehouse_Second_Count.Size = new System.Drawing.Size(172, 22);
            this.Warehouse_Second_Count.Text = "شــمـارش دوم انــــبـار";
            this.Warehouse_Second_Count.Visible = false;
            // 
            // Warehouse_Final_Count
            // 
            this.Warehouse_Final_Count.Name = "Warehouse_Final_Count";
            this.Warehouse_Final_Count.Size = new System.Drawing.Size(172, 22);
            this.Warehouse_Final_Count.Text = "شمارش نهایی انـــبـار";
            this.Warehouse_Final_Count.Visible = false;
            // 
            // Warehouse_Access
            // 
            this.Warehouse_Access.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Warehouse_Edit_Access,
            this.Warehouse_Accounting_Access,
            this.Warehouse_Delete_Access});
            this.Warehouse_Access.Name = "Warehouse_Access";
            this.Warehouse_Access.Size = new System.Drawing.Size(212, 22);
            this.Warehouse_Access.Text = "سطح دسترسی";
            this.Warehouse_Access.Visible = false;
            // 
            // Warehouse_Edit_Access
            // 
            this.Warehouse_Edit_Access.Name = "Warehouse_Edit_Access";
            this.Warehouse_Edit_Access.Size = new System.Drawing.Size(235, 22);
            this.Warehouse_Edit_Access.Text = "دسترسی به ویرایش اطلاعات انبار";
            this.Warehouse_Edit_Access.Visible = false;
            // 
            // Warehouse_Accounting_Access
            // 
            this.Warehouse_Accounting_Access.Name = "Warehouse_Accounting_Access";
            this.Warehouse_Accounting_Access.Size = new System.Drawing.Size(235, 22);
            this.Warehouse_Accounting_Access.Text = "دسترسی به حســابـداری ریالی انبار";
            this.Warehouse_Accounting_Access.Visible = false;
            // 
            // Warehouse_Delete_Access
            // 
            this.Warehouse_Delete_Access.Name = "Warehouse_Delete_Access";
            this.Warehouse_Delete_Access.Size = new System.Drawing.Size(235, 22);
            this.Warehouse_Delete_Access.Text = "دسترسی به حــــــذف اطلاعات انبار";
            this.Warehouse_Delete_Access.Visible = false;
            // 
            // Assets
            // 
            this.Assets.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Assets_Fixed,
            this.Assets_Intangible,
            this.Assets_Consumable,
            this.Assets_Increase,
            this.Assets_Decrease,
            this.Assets_Movement,
            this.Assets_Dismiss,
            this.Assets_Revaluation,
            this.Assets_Calculate_Depreciation,
            this.Assets_Management,
            this.Assets_Access});
            this.Assets.Name = "Assets";
            this.Assets.Size = new System.Drawing.Size(56, 20);
            this.Assets.Text = "امـــــوال";
            this.Assets.Visible = false;
            // 
            // Assets_Fixed
            // 
            this.Assets_Fixed.Name = "Assets_Fixed";
            this.Assets_Fixed.Size = new System.Drawing.Size(194, 22);
            this.Assets_Fixed.Text = "ثـــبـــت  دارائــــی  ثـــابـــت";
            this.Assets_Fixed.Visible = false;
            // 
            // Assets_Intangible
            // 
            this.Assets_Intangible.Name = "Assets_Intangible";
            this.Assets_Intangible.Size = new System.Drawing.Size(194, 22);
            this.Assets_Intangible.Text = "ثبت دارائی نــامــشـــهــود";
            this.Assets_Intangible.Visible = false;
            // 
            // Assets_Consumable
            // 
            this.Assets_Consumable.Name = "Assets_Consumable";
            this.Assets_Consumable.Size = new System.Drawing.Size(194, 22);
            this.Assets_Consumable.Text = "ثبت امـــوال مـــصـــرفـــی";
            this.Assets_Consumable.Visible = false;
            // 
            // Assets_Increase
            // 
            this.Assets_Increase.Name = "Assets_Increase";
            this.Assets_Increase.Size = new System.Drawing.Size(194, 22);
            this.Assets_Increase.Text = "ثبت  افـــــزایـــش  دارائـــی";
            this.Assets_Increase.Visible = false;
            // 
            // Assets_Decrease
            // 
            this.Assets_Decrease.Name = "Assets_Decrease";
            this.Assets_Decrease.Size = new System.Drawing.Size(194, 22);
            this.Assets_Decrease.Text = "ثــبــت  کـــاهـــش  دارائـــی";
            this.Assets_Decrease.Visible = false;
            // 
            // Assets_Movement
            // 
            this.Assets_Movement.Name = "Assets_Movement";
            this.Assets_Movement.Size = new System.Drawing.Size(194, 22);
            this.Assets_Movement.Text = "نــــقـل  و  انــتــقـال دارائـی";
            this.Assets_Movement.Visible = false;
            // 
            // Assets_Dismiss
            // 
            this.Assets_Dismiss.Name = "Assets_Dismiss";
            this.Assets_Dismiss.Size = new System.Drawing.Size(194, 22);
            this.Assets_Dismiss.Text = "اسقاط  و  بـرکناری دارائی";
            this.Assets_Dismiss.Visible = false;
            // 
            // Assets_Revaluation
            // 
            this.Assets_Revaluation.Name = "Assets_Revaluation";
            this.Assets_Revaluation.Size = new System.Drawing.Size(194, 22);
            this.Assets_Revaluation.Text = "تـجـــدیــد ارزیـابـــی دارائـی";
            this.Assets_Revaluation.Visible = false;
            // 
            // Assets_Calculate_Depreciation
            // 
            this.Assets_Calculate_Depreciation.Name = "Assets_Calculate_Depreciation";
            this.Assets_Calculate_Depreciation.Size = new System.Drawing.Size(194, 22);
            this.Assets_Calculate_Depreciation.Text = "مـحاسبه استهلاک دارائــی";
            this.Assets_Calculate_Depreciation.Visible = false;
            // 
            // Assets_Management
            // 
            this.Assets_Management.Name = "Assets_Management";
            this.Assets_Management.Size = new System.Drawing.Size(194, 22);
            this.Assets_Management.Text = "مدیریت ســـیستم امــــوال";
            this.Assets_Management.Visible = false;
            // 
            // Assets_Access
            // 
            this.Assets_Access.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Assets_Edit_Access,
            this.Assets_Delete_Access});
            this.Assets_Access.Name = "Assets_Access";
            this.Assets_Access.Size = new System.Drawing.Size(194, 22);
            this.Assets_Access.Text = "سطح دسترسی";
            this.Assets_Access.Visible = false;
            // 
            // Assets_Edit_Access
            // 
            this.Assets_Edit_Access.Name = "Assets_Edit_Access";
            this.Assets_Edit_Access.Size = new System.Drawing.Size(244, 22);
            this.Assets_Edit_Access.Text = "دسترسی به ویرایش اطلاعات دارائی";
            this.Assets_Edit_Access.Visible = false;
            // 
            // Assets_Delete_Access
            // 
            this.Assets_Delete_Access.Name = "Assets_Delete_Access";
            this.Assets_Delete_Access.Size = new System.Drawing.Size(244, 22);
            this.Assets_Delete_Access.Text = "دسترسی به حـــــذف اطلاعات دارائی";
            this.Assets_Delete_Access.Visible = false;
            // 
            // Payable
            // 
            this.Payable.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Payable_Payment,
            this.Payable_Deposits,
            this.Payable_Wage,
            this.Payable_Access});
            this.Payable.Name = "Payable";
            this.Payable.Size = new System.Drawing.Size(62, 20);
            this.Payable.Text = "چک بانک";
            this.Payable.Visible = false;
            // 
            // Payable_Payment
            // 
            this.Payable_Payment.Name = "Payable_Payment";
            this.Payable_Payment.Size = new System.Drawing.Size(209, 22);
            this.Payable_Payment.Text = "صدور دستور پرداخت و چــک";
            this.Payable_Payment.Visible = false;
            // 
            // Payable_Deposits
            // 
            this.Payable_Deposits.Name = "Payable_Deposits";
            this.Payable_Deposits.Size = new System.Drawing.Size(209, 22);
            this.Payable_Deposits.Text = "ثــبــت واریزی بــــــه بــــانــکـهــا";
            this.Payable_Deposits.Visible = false;
            // 
            // Payable_Wage
            // 
            this.Payable_Wage.Name = "Payable_Wage";
            this.Payable_Wage.Size = new System.Drawing.Size(209, 22);
            this.Payable_Wage.Text = "ثبت هزینه و کارمــزد بانــکـی";
            this.Payable_Wage.Visible = false;
            // 
            // Payable_Access
            // 
            this.Payable_Access.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Payable_Edit_Access,
            this.Payable_Delete_Access});
            this.Payable_Access.Name = "Payable_Access";
            this.Payable_Access.Size = new System.Drawing.Size(209, 22);
            this.Payable_Access.Text = "سطح دسترسی";
            this.Payable_Access.Visible = false;
            // 
            // Payable_Edit_Access
            // 
            this.Payable_Edit_Access.Name = "Payable_Edit_Access";
            this.Payable_Edit_Access.Size = new System.Drawing.Size(258, 22);
            this.Payable_Edit_Access.Text = "دسترسی به ویرایش اطلاعات چک بانک";
            // 
            // Payable_Delete_Access
            // 
            this.Payable_Delete_Access.Name = "Payable_Delete_Access";
            this.Payable_Delete_Access.Size = new System.Drawing.Size(258, 22);
            this.Payable_Delete_Access.Text = "دسترسی به حــــــذف اطلاعات چک بانک";
            // 
            // Collection_Document
            // 
            this.Collection_Document.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Collection_Document_Add,
            this.Collection_Document_Assignment,
            this.Collection_Document_Notice,
            this.Collection_Document_Back,
            this.Collection_Document_Extradition,
            this.Collection_Document_Reform,
            this.Collection_Document_Access});
            this.Collection_Document.Name = "Collection_Document";
            this.Collection_Document.Size = new System.Drawing.Size(86, 20);
            this.Collection_Document.Text = "اسناد وصولی";
            this.Collection_Document.Visible = false;
            // 
            // Collection_Document_Add
            // 
            this.Collection_Document_Add.Name = "Collection_Document_Add";
            this.Collection_Document_Add.Size = new System.Drawing.Size(204, 22);
            this.Collection_Document_Add.Text = "ثبت چــــک های  مشتـرکـین";
            this.Collection_Document_Add.Visible = false;
            // 
            // Collection_Document_Assignment
            // 
            this.Collection_Document_Assignment.Name = "Collection_Document_Assignment";
            this.Collection_Document_Assignment.Size = new System.Drawing.Size(204, 22);
            this.Collection_Document_Assignment.Text = "واگـذاری  چــکـها بــه  بــانـک";
            this.Collection_Document_Assignment.Visible = false;
            // 
            // Collection_Document_Notice
            // 
            this.Collection_Document_Notice.Name = "Collection_Document_Notice";
            this.Collection_Document_Notice.Size = new System.Drawing.Size(204, 22);
            this.Collection_Document_Notice.Text = "اعـــلام   وصـولی  از  بـانــک ";
            this.Collection_Document_Notice.Visible = false;
            // 
            // Collection_Document_Back
            // 
            this.Collection_Document_Back.Name = "Collection_Document_Back";
            this.Collection_Document_Back.Size = new System.Drawing.Size(204, 22);
            this.Collection_Document_Back.Text = "اعـلام  برگشـتـی  از  بـــانــک";
            this.Collection_Document_Back.Visible = false;
            // 
            // Collection_Document_Extradition
            // 
            this.Collection_Document_Extradition.Name = "Collection_Document_Extradition";
            this.Collection_Document_Extradition.Size = new System.Drawing.Size(204, 22);
            this.Collection_Document_Extradition.Text = "استرداد  چـک  بــه  مشتـرک";
            this.Collection_Document_Extradition.Visible = false;
            // 
            // Collection_Document_Reform
            // 
            this.Collection_Document_Reform.Name = "Collection_Document_Reform";
            this.Collection_Document_Reform.Size = new System.Drawing.Size(204, 22);
            this.Collection_Document_Reform.Text = "اصلاحات اسناد وصــولــــی";
            this.Collection_Document_Reform.Visible = false;
            // 
            // Collection_Document_Access
            // 
            this.Collection_Document_Access.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Collection_Document_Edit_Access,
            this.Collection_Document_Delete_Access});
            this.Collection_Document_Access.Name = "Collection_Document_Access";
            this.Collection_Document_Access.Size = new System.Drawing.Size(204, 22);
            this.Collection_Document_Access.Text = "سطح دسترسی";
            this.Collection_Document_Access.Visible = false;
            // 
            // Collection_Document_Edit_Access
            // 
            this.Collection_Document_Edit_Access.Name = "Collection_Document_Edit_Access";
            this.Collection_Document_Edit_Access.Size = new System.Drawing.Size(281, 22);
            this.Collection_Document_Edit_Access.Text = "دسترسی به ویرایش اطلاعات اسناد وصولی";
            this.Collection_Document_Edit_Access.Visible = false;
            // 
            // Collection_Document_Delete_Access
            // 
            this.Collection_Document_Delete_Access.Name = "Collection_Document_Delete_Access";
            this.Collection_Document_Delete_Access.Size = new System.Drawing.Size(281, 22);
            this.Collection_Document_Delete_Access.Text = "دسترسی به حـــــذف اطلاعات اسناد وصولی";
            this.Collection_Document_Delete_Access.Visible = false;
            // 
            // Warranty_Document
            // 
            this.Warranty_Document.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Warranty_Document_Add,
            this.Warranty_Document_Extended,
            this.Warranty_Document_Refund,
            this.Warranty_Document_Reform,
            this.Warranty_Document_Access});
            this.Warranty_Document.Name = "Warranty_Document";
            this.Warranty_Document.Size = new System.Drawing.Size(89, 20);
            this.Warranty_Document.Text = "اسناد انتظامی";
            this.Warranty_Document.Visible = false;
            // 
            // Warranty_Document_Add
            // 
            this.Warranty_Document_Add.Name = "Warranty_Document_Add";
            this.Warranty_Document_Add.Size = new System.Drawing.Size(193, 22);
            this.Warranty_Document_Add.Text = "ثبت اسنــــــــــــاد انتظامی";
            this.Warranty_Document_Add.Visible = false;
            // 
            // Warranty_Document_Extended
            // 
            this.Warranty_Document_Extended.Name = "Warranty_Document_Extended";
            this.Warranty_Document_Extended.Size = new System.Drawing.Size(193, 22);
            this.Warranty_Document_Extended.Text = "تـمدیـــد اسنـــــاد انتظامی";
            this.Warranty_Document_Extended.Visible = false;
            // 
            // Warranty_Document_Refund
            // 
            this.Warranty_Document_Refund.Name = "Warranty_Document_Refund";
            this.Warranty_Document_Refund.Size = new System.Drawing.Size(193, 22);
            this.Warranty_Document_Refund.Text = "استرداد اسنـــــاد انتظامی";
            this.Warranty_Document_Refund.Visible = false;
            // 
            // Warranty_Document_Reform
            // 
            this.Warranty_Document_Reform.Name = "Warranty_Document_Reform";
            this.Warranty_Document_Reform.Size = new System.Drawing.Size(193, 22);
            this.Warranty_Document_Reform.Text = "اصلاحات اسنـاد انتظامی";
            this.Warranty_Document_Reform.Visible = false;
            // 
            // Warranty_Document_Access
            // 
            this.Warranty_Document_Access.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Warranty_Document_Edit_Access,
            this.Warranty_Document_Delete_Access});
            this.Warranty_Document_Access.Name = "Warranty_Document_Access";
            this.Warranty_Document_Access.Size = new System.Drawing.Size(193, 22);
            this.Warranty_Document_Access.Text = "سطح دسترسی";
            this.Warranty_Document_Access.Visible = false;
            // 
            // Warranty_Document_Edit_Access
            // 
            this.Warranty_Document_Edit_Access.Name = "Warranty_Document_Edit_Access";
            this.Warranty_Document_Edit_Access.Size = new System.Drawing.Size(288, 22);
            this.Warranty_Document_Edit_Access.Text = "دسترسی به ویرایش اطلاعات اسنــاد انتظامی";
            this.Warranty_Document_Edit_Access.Visible = false;
            // 
            // Warranty_Document_Delete_Access
            // 
            this.Warranty_Document_Delete_Access.Name = "Warranty_Document_Delete_Access";
            this.Warranty_Document_Delete_Access.Size = new System.Drawing.Size(288, 22);
            this.Warranty_Document_Delete_Access.Text = "دسترسی به حـــــذف اطلاعات اسنــاد انتظامی";
            this.Warranty_Document_Delete_Access.Visible = false;
            // 
            // Base_Information
            // 
            this.Base_Information.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Base_Information_Services,
            this.Base_Information_Accounting,
            this.Base_Information_Repair,
            this.Base_Information_PayRoll,
            this.Base_Information_Warehouse,
            this.Base_Information_Assets,
            this.Base_Information_Document});
            this.Base_Information.Name = "Base_Information";
            this.Base_Information.Size = new System.Drawing.Size(80, 20);
            this.Base_Information.Text = "اطلاعات پایه";
            this.Base_Information.Visible = false;
            // 
            // Base_Information_Services
            // 
            this.Base_Information_Services.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Base_Information_Services_Seasonal_Buy_Sales,
            this.Base_Information_Services_Order,
            this.Base_Information_Services_Access});
            this.Base_Information_Services.Name = "Base_Information_Services";
            this.Base_Information_Services.Size = new System.Drawing.Size(191, 22);
            this.Base_Information_Services.Text = "تعاریف خـــــــــــدمـــــــــات";
            this.Base_Information_Services.Visible = false;
            // 
            // Base_Information_Services_Seasonal_Buy_Sales
            // 
            this.Base_Information_Services_Seasonal_Buy_Sales.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Base_Seasonal_Product_Type});
            this.Base_Information_Services_Seasonal_Buy_Sales.Name = "Base_Information_Services_Seasonal_Buy_Sales";
            this.Base_Information_Services_Seasonal_Buy_Sales.Size = new System.Drawing.Size(213, 22);
            this.Base_Information_Services_Seasonal_Buy_Sales.Text = "تعاریف خرید و فروش فصلی";
            this.Base_Information_Services_Seasonal_Buy_Sales.Visible = false;
            // 
            // Base_Seasonal_Product_Type
            // 
            this.Base_Seasonal_Product_Type.Name = "Base_Seasonal_Product_Type";
            this.Base_Seasonal_Product_Type.Size = new System.Drawing.Size(156, 22);
            this.Base_Seasonal_Product_Type.Text = "نوع کالا و خدمات";
            this.Base_Seasonal_Product_Type.Visible = false;
            // 
            // Base_Information_Services_Order
            // 
            this.Base_Information_Services_Order.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Base_Information_Services_Order_Customer,
            this.Base_Information_Services_Order_In_Services,
            this.Base_Information_Services_Order_Out_Services,
            this.Base_Information_Services_Order_Opertor,
            this.Base_Information_Services_Order_Rate});
            this.Base_Information_Services_Order.Name = "Base_Information_Services_Order";
            this.Base_Information_Services_Order.Size = new System.Drawing.Size(213, 22);
            this.Base_Information_Services_Order.Text = "تعاریف ثــــــبـــــــت ســـــــفارش";
            this.Base_Information_Services_Order.Visible = false;
            // 
            // Base_Information_Services_Order_Customer
            // 
            this.Base_Information_Services_Order_Customer.Name = "Base_Information_Services_Order_Customer";
            this.Base_Information_Services_Order_Customer.Size = new System.Drawing.Size(180, 22);
            this.Base_Information_Services_Order_Customer.Text = "ثـــــبـــــت مـــــشـــتـــــری";
            this.Base_Information_Services_Order_Customer.Visible = false;
            // 
            // Base_Information_Services_Order_In_Services
            // 
            this.Base_Information_Services_Order_In_Services.Name = "Base_Information_Services_Order_In_Services";
            this.Base_Information_Services_Order_In_Services.Size = new System.Drawing.Size(180, 22);
            this.Base_Information_Services_Order_In_Services.Text = "ثبت خدمات کـــارگـــاه";
            this.Base_Information_Services_Order_In_Services.Visible = false;
            // 
            // Base_Information_Services_Order_Out_Services
            // 
            this.Base_Information_Services_Order_Out_Services.Name = "Base_Information_Services_Order_Out_Services";
            this.Base_Information_Services_Order_Out_Services.Size = new System.Drawing.Size(180, 22);
            this.Base_Information_Services_Order_Out_Services.Text = "خدمات خارج از کارگاه";
            this.Base_Information_Services_Order_Out_Services.Visible = false;
            // 
            // Base_Information_Services_Order_Opertor
            // 
            this.Base_Information_Services_Order_Opertor.Name = "Base_Information_Services_Order_Opertor";
            this.Base_Information_Services_Order_Opertor.Size = new System.Drawing.Size(180, 22);
            this.Base_Information_Services_Order_Opertor.Text = "ثـــبـــت کـــاربــر مــاشین";
            this.Base_Information_Services_Order_Opertor.Visible = false;
            // 
            // Base_Information_Services_Order_Rate
            // 
            this.Base_Information_Services_Order_Rate.Name = "Base_Information_Services_Order_Rate";
            this.Base_Information_Services_Order_Rate.Size = new System.Drawing.Size(180, 22);
            this.Base_Information_Services_Order_Rate.Text = "مــــیــــزان هــــمــــکــــاری";
            this.Base_Information_Services_Order_Rate.Visible = false;
            // 
            // Base_Information_Services_Access
            // 
            this.Base_Information_Services_Access.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Base_Information_Services_Edit_Access,
            this.Base_Information_Services_Delete_Access});
            this.Base_Information_Services_Access.Name = "Base_Information_Services_Access";
            this.Base_Information_Services_Access.Size = new System.Drawing.Size(213, 22);
            this.Base_Information_Services_Access.Text = "سطح دسترسی";
            this.Base_Information_Services_Access.Visible = false;
            // 
            // Base_Information_Services_Edit_Access
            // 
            this.Base_Information_Services_Edit_Access.Name = "Base_Information_Services_Edit_Access";
            this.Base_Information_Services_Edit_Access.Size = new System.Drawing.Size(307, 22);
            this.Base_Information_Services_Edit_Access.Text = "دسترسی به ویرایش اطلاعات پایه تعاریف خدمات";
            this.Base_Information_Services_Edit_Access.Visible = false;
            // 
            // Base_Information_Services_Delete_Access
            // 
            this.Base_Information_Services_Delete_Access.Name = "Base_Information_Services_Delete_Access";
            this.Base_Information_Services_Delete_Access.Size = new System.Drawing.Size(307, 22);
            this.Base_Information_Services_Delete_Access.Text = "دسترسی به حـــــذف اطلاعات پایه تعاریف خدمات";
            this.Base_Information_Services_Delete_Access.Visible = false;
            // 
            // Base_Information_Accounting
            // 
            this.Base_Information_Accounting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Base_Information_Accounting_Account_Tree,
            this.Base_Information_Accounting_Detailed_Tree,
            this.Base_Information_Accounting_Access});
            this.Base_Information_Accounting.Name = "Base_Information_Accounting";
            this.Base_Information_Accounting.Size = new System.Drawing.Size(191, 22);
            this.Base_Information_Accounting.Text = "تعاریف حـــــســــــابــــداری";
            this.Base_Information_Accounting.Visible = false;
            // 
            // Base_Information_Accounting_Account_Tree
            // 
            this.Base_Information_Accounting_Account_Tree.Name = "Base_Information_Accounting_Account_Tree";
            this.Base_Information_Accounting_Account_Tree.Size = new System.Drawing.Size(160, 22);
            this.Base_Information_Accounting_Account_Tree.Text = "درخت حــســاب ها";
            this.Base_Information_Accounting_Account_Tree.Visible = false;
            // 
            // Base_Information_Accounting_Detailed_Tree
            // 
            this.Base_Information_Accounting_Detailed_Tree.Name = "Base_Information_Accounting_Detailed_Tree";
            this.Base_Information_Accounting_Detailed_Tree.Size = new System.Drawing.Size(160, 22);
            this.Base_Information_Accounting_Detailed_Tree.Text = "درخت تفصیلی ها";
            this.Base_Information_Accounting_Detailed_Tree.Visible = false;
            // 
            // Base_Information_Accounting_Access
            // 
            this.Base_Information_Accounting_Access.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Base_Information_Accounting_Edit_Access,
            this.Base_Information_Accounting_Delete_Access});
            this.Base_Information_Accounting_Access.Name = "Base_Information_Accounting_Access";
            this.Base_Information_Accounting_Access.Size = new System.Drawing.Size(160, 22);
            this.Base_Information_Accounting_Access.Text = "سطح دسترسی";
            this.Base_Information_Accounting_Access.Visible = false;
            // 
            // Base_Information_Accounting_Edit_Access
            // 
            this.Base_Information_Accounting_Edit_Access.Name = "Base_Information_Accounting_Edit_Access";
            this.Base_Information_Accounting_Edit_Access.Size = new System.Drawing.Size(280, 22);
            this.Base_Information_Accounting_Edit_Access.Text = "دسترسی به ویرایش اطلاعات پایه حسابداری";
            this.Base_Information_Accounting_Edit_Access.Visible = false;
            // 
            // Base_Information_Accounting_Delete_Access
            // 
            this.Base_Information_Accounting_Delete_Access.Name = "Base_Information_Accounting_Delete_Access";
            this.Base_Information_Accounting_Delete_Access.Size = new System.Drawing.Size(280, 22);
            this.Base_Information_Accounting_Delete_Access.Text = "دسترسی به حـــــذف اطلاعات پایه حسابداری";
            this.Base_Information_Accounting_Delete_Access.Visible = false;
            // 
            // Base_Information_Repair
            // 
            this.Base_Information_Repair.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Base_Information_Repair_Seating,
            this.Base_Information_Repair_Energy,
            this.Base_Information_Repair_Phase,
            this.Base_Information_Repair_Kind_Stream,
            this.Base_Information_Repair_Kind_Fuse,
            this.Base_Information_Repair_Connector_Type,
            this.Base_Information_Repair_Stop_Defect,
            this.Base_Information_Repair_Access});
            this.Base_Information_Repair.Name = "Base_Information_Repair";
            this.Base_Information_Repair.Size = new System.Drawing.Size(191, 22);
            this.Base_Information_Repair.Text = "تعاریف تعمیر و نگهداری";
            this.Base_Information_Repair.Visible = false;
            // 
            // Base_Information_Repair_Seating
            // 
            this.Base_Information_Repair_Seating.Name = "Base_Information_Repair_Seating";
            this.Base_Information_Repair_Seating.Size = new System.Drawing.Size(145, 22);
            this.Base_Information_Repair_Seating.Text = "مــحـــل استقرار";
            this.Base_Information_Repair_Seating.Visible = false;
            // 
            // Base_Information_Repair_Energy
            // 
            this.Base_Information_Repair_Energy.Name = "Base_Information_Repair_Energy";
            this.Base_Information_Repair_Energy.Size = new System.Drawing.Size(145, 22);
            this.Base_Information_Repair_Energy.Text = "انرژی مورد نیاز";
            this.Base_Information_Repair_Energy.Visible = false;
            // 
            // Base_Information_Repair_Phase
            // 
            this.Base_Information_Repair_Phase.Name = "Base_Information_Repair_Phase";
            this.Base_Information_Repair_Phase.Size = new System.Drawing.Size(145, 22);
            this.Base_Information_Repair_Phase.Text = "تـــعـداد فـــــــــاز";
            this.Base_Information_Repair_Phase.Visible = false;
            // 
            // Base_Information_Repair_Kind_Stream
            // 
            this.Base_Information_Repair_Kind_Stream.Name = "Base_Information_Repair_Kind_Stream";
            this.Base_Information_Repair_Kind_Stream.Size = new System.Drawing.Size(145, 22);
            this.Base_Information_Repair_Kind_Stream.Text = "نــــــوع  جــریـان";
            this.Base_Information_Repair_Kind_Stream.Visible = false;
            // 
            // Base_Information_Repair_Kind_Fuse
            // 
            this.Base_Information_Repair_Kind_Fuse.Name = "Base_Information_Repair_Kind_Fuse";
            this.Base_Information_Repair_Kind_Fuse.Size = new System.Drawing.Size(145, 22);
            this.Base_Information_Repair_Kind_Fuse.Text = "نـــوع فــــــیــــوز";
            this.Base_Information_Repair_Kind_Fuse.Visible = false;
            // 
            // Base_Information_Repair_Connector_Type
            // 
            this.Base_Information_Repair_Connector_Type.Name = "Base_Information_Repair_Connector_Type";
            this.Base_Information_Repair_Connector_Type.Size = new System.Drawing.Size(145, 22);
            this.Base_Information_Repair_Connector_Type.Text = "نــوع اتـــــصـــال";
            this.Base_Information_Repair_Connector_Type.Visible = false;
            // 
            // Base_Information_Repair_Stop_Defect
            // 
            this.Base_Information_Repair_Stop_Defect.Name = "Base_Information_Repair_Stop_Defect";
            this.Base_Information_Repair_Stop_Defect.Size = new System.Drawing.Size(145, 22);
            this.Base_Information_Repair_Stop_Defect.Text = "علت توقف کار";
            this.Base_Information_Repair_Stop_Defect.Visible = false;
            // 
            // Base_Information_Repair_Access
            // 
            this.Base_Information_Repair_Access.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Base_Information_Repair_Edit_Access,
            this.Base_Information_Repair_Delete_Access});
            this.Base_Information_Repair_Access.Name = "Base_Information_Repair_Access";
            this.Base_Information_Repair_Access.Size = new System.Drawing.Size(145, 22);
            this.Base_Information_Repair_Access.Text = "سطح دسترسی";
            this.Base_Information_Repair_Access.Visible = false;
            // 
            // Base_Information_Repair_Edit_Access
            // 
            this.Base_Information_Repair_Edit_Access.Name = "Base_Information_Repair_Edit_Access";
            this.Base_Information_Repair_Edit_Access.Size = new System.Drawing.Size(311, 22);
            this.Base_Information_Repair_Edit_Access.Text = "دسترسی به ویرایش اطلاعات پایه تعمیر و نگهداری";
            this.Base_Information_Repair_Edit_Access.Visible = false;
            // 
            // Base_Information_Repair_Delete_Access
            // 
            this.Base_Information_Repair_Delete_Access.Name = "Base_Information_Repair_Delete_Access";
            this.Base_Information_Repair_Delete_Access.Size = new System.Drawing.Size(311, 22);
            this.Base_Information_Repair_Delete_Access.Text = "دسترسی به حـــــذف اطلاعات پایه تعمیر و نگهداری";
            this.Base_Information_Repair_Delete_Access.Visible = false;
            // 
            // Base_Information_PayRoll
            // 
            this.Base_Information_PayRoll.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Base_Information_PayRoll_Personal,
            this.Base_Information_PayRoll_Employment,
            this.Base_Information_PayRoll_Deductions_Legal,
            this.Base_Information_PayRoll_Deductions_Diffrent,
            this.Base_Information_PayRoll_Family,
            this.Base_Information_PayRoll_Calandar,
            this.Base_Information_PayRoll_Access});
            this.Base_Information_PayRoll.Name = "Base_Information_PayRoll";
            this.Base_Information_PayRoll.Size = new System.Drawing.Size(191, 22);
            this.Base_Information_PayRoll.Text = "تعاریف حقوق و دستمزد";
            this.Base_Information_PayRoll.Visible = false;
            // 
            // Base_Information_PayRoll_Personal
            // 
            this.Base_Information_PayRoll_Personal.Name = "Base_Information_PayRoll_Personal";
            this.Base_Information_PayRoll_Personal.Size = new System.Drawing.Size(190, 22);
            this.Base_Information_PayRoll_Personal.Text = "ثبت اطلاعات پــرسـنـــلی";
            this.Base_Information_PayRoll_Personal.Visible = false;
            // 
            // Base_Information_PayRoll_Employment
            // 
            this.Base_Information_PayRoll_Employment.Name = "Base_Information_PayRoll_Employment";
            this.Base_Information_PayRoll_Employment.Size = new System.Drawing.Size(190, 22);
            this.Base_Information_PayRoll_Employment.Text = "صدور احکام کـــارگــزینی";
            this.Base_Information_PayRoll_Employment.Visible = false;
            // 
            // Base_Information_PayRoll_Deductions_Legal
            // 
            this.Base_Information_PayRoll_Deductions_Legal.Name = "Base_Information_PayRoll_Deductions_Legal";
            this.Base_Information_PayRoll_Deductions_Legal.Size = new System.Drawing.Size(190, 22);
            this.Base_Information_PayRoll_Deductions_Legal.Text = "جدول کسـورات قـانــونی";
            this.Base_Information_PayRoll_Deductions_Legal.Visible = false;
            // 
            // Base_Information_PayRoll_Deductions_Diffrent
            // 
            this.Base_Information_PayRoll_Deductions_Diffrent.Name = "Base_Information_PayRoll_Deductions_Diffrent";
            this.Base_Information_PayRoll_Deductions_Diffrent.Size = new System.Drawing.Size(190, 22);
            this.Base_Information_PayRoll_Deductions_Diffrent.Text = "جدول کسـورات مــتـفرقـه";
            this.Base_Information_PayRoll_Deductions_Diffrent.Visible = false;
            // 
            // Base_Information_PayRoll_Family
            // 
            this.Base_Information_PayRoll_Family.Name = "Base_Information_PayRoll_Family";
            this.Base_Information_PayRoll_Family.Size = new System.Drawing.Size(190, 22);
            this.Base_Information_PayRoll_Family.Text = "ثبت اطـلاعـات خــانـــواده";
            this.Base_Information_PayRoll_Family.Visible = false;
            // 
            // Base_Information_PayRoll_Calandar
            // 
            this.Base_Information_PayRoll_Calandar.Name = "Base_Information_PayRoll_Calandar";
            this.Base_Information_PayRoll_Calandar.Size = new System.Drawing.Size(190, 22);
            this.Base_Information_PayRoll_Calandar.Text = "تعریف تـــقـــویـم کـــــاری";
            this.Base_Information_PayRoll_Calandar.Visible = false;
            // 
            // Base_Information_PayRoll_Access
            // 
            this.Base_Information_PayRoll_Access.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Base_Information_PayRoll_Edit_Access,
            this.Base_Information_PayRoll_Delete_Access});
            this.Base_Information_PayRoll_Access.Name = "Base_Information_PayRoll_Access";
            this.Base_Information_PayRoll_Access.Size = new System.Drawing.Size(190, 22);
            this.Base_Information_PayRoll_Access.Text = "سطح دسترسی";
            this.Base_Information_PayRoll_Access.Visible = false;
            // 
            // Base_Information_PayRoll_Edit_Access
            // 
            this.Base_Information_PayRoll_Edit_Access.Name = "Base_Information_PayRoll_Edit_Access";
            this.Base_Information_PayRoll_Edit_Access.Size = new System.Drawing.Size(311, 22);
            this.Base_Information_PayRoll_Edit_Access.Text = "دسترسی به ویرایش اطلاعات پایه حـقوق ودستمزد";
            this.Base_Information_PayRoll_Edit_Access.Visible = false;
            // 
            // Base_Information_PayRoll_Delete_Access
            // 
            this.Base_Information_PayRoll_Delete_Access.Name = "Base_Information_PayRoll_Delete_Access";
            this.Base_Information_PayRoll_Delete_Access.Size = new System.Drawing.Size(311, 22);
            this.Base_Information_PayRoll_Delete_Access.Text = "دسترسی به حــــــذف اطلاعات پایه حـقوق ودستمزد";
            this.Base_Information_PayRoll_Delete_Access.Visible = false;
            // 
            // Base_Information_Warehouse
            // 
            this.Base_Information_Warehouse.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Base_Information_Warehouse_Units,
            this.Base_Information_Warehouse_Sources,
            this.Base_Information_Warehouse_Unit_Goods,
            this.Base_Information_Warehouse_Grouping_Goods,
            this.Base_Information_Warehouse_Collection_Goods,
            this.Base_Information_Warehouse_Access});
            this.Base_Information_Warehouse.Name = "Base_Information_Warehouse";
            this.Base_Information_Warehouse.Size = new System.Drawing.Size(191, 22);
            this.Base_Information_Warehouse.Text = "تعاریف انــــــــــــــبـــــــــــــــار";
            this.Base_Information_Warehouse.Visible = false;
            // 
            // Base_Information_Warehouse_Units
            // 
            this.Base_Information_Warehouse_Units.Name = "Base_Information_Warehouse_Units";
            this.Base_Information_Warehouse_Units.Size = new System.Drawing.Size(232, 22);
            this.Base_Information_Warehouse_Units.Text = "تــــعـــریــف واحـــــــدهای  انـــــبـــــار";
            this.Base_Information_Warehouse_Units.Visible = false;
            // 
            // Base_Information_Warehouse_Sources
            // 
            this.Base_Information_Warehouse_Sources.Name = "Base_Information_Warehouse_Sources";
            this.Base_Information_Warehouse_Sources.Size = new System.Drawing.Size(232, 22);
            this.Base_Information_Warehouse_Sources.Text = "طرف حساب و منابع تهیه وتوزیع";
            this.Base_Information_Warehouse_Sources.Visible = false;
            // 
            // Base_Information_Warehouse_Unit_Goods
            // 
            this.Base_Information_Warehouse_Unit_Goods.Name = "Base_Information_Warehouse_Unit_Goods";
            this.Base_Information_Warehouse_Unit_Goods.Size = new System.Drawing.Size(232, 22);
            this.Base_Information_Warehouse_Unit_Goods.Text = "واحـد هــای سنجش کــالا در انــبـــار";
            this.Base_Information_Warehouse_Unit_Goods.Visible = false;
            // 
            // Base_Information_Warehouse_Grouping_Goods
            // 
            this.Base_Information_Warehouse_Grouping_Goods.Name = "Base_Information_Warehouse_Grouping_Goods";
            this.Base_Information_Warehouse_Grouping_Goods.Size = new System.Drawing.Size(232, 22);
            this.Base_Information_Warehouse_Grouping_Goods.Text = "گـــروه بــنــدی  کــالا هـــا  در انــبـــار";
            this.Base_Information_Warehouse_Grouping_Goods.Visible = false;
            // 
            // Base_Information_Warehouse_Collection_Goods
            // 
            this.Base_Information_Warehouse_Collection_Goods.Name = "Base_Information_Warehouse_Collection_Goods";
            this.Base_Information_Warehouse_Collection_Goods.Size = new System.Drawing.Size(232, 22);
            this.Base_Information_Warehouse_Collection_Goods.Text = "مــجــمــوعـــه   کــالا هـــا  در انــبـــار";
            this.Base_Information_Warehouse_Collection_Goods.Visible = false;
            // 
            // Base_Information_Warehouse_Access
            // 
            this.Base_Information_Warehouse_Access.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Base_Information_Warehouse_Edit_Access,
            this.Base_Information_Warehouse_Delete_Access});
            this.Base_Information_Warehouse_Access.Name = "Base_Information_Warehouse_Access";
            this.Base_Information_Warehouse_Access.Size = new System.Drawing.Size(232, 22);
            this.Base_Information_Warehouse_Access.Text = "سطح دسترسی";
            this.Base_Information_Warehouse_Access.Visible = false;
            // 
            // Base_Information_Warehouse_Edit_Access
            // 
            this.Base_Information_Warehouse_Edit_Access.Name = "Base_Information_Warehouse_Edit_Access";
            this.Base_Information_Warehouse_Edit_Access.Size = new System.Drawing.Size(253, 22);
            this.Base_Information_Warehouse_Edit_Access.Text = "دسترسی به ویرایش اطلاعات پایه انبار";
            this.Base_Information_Warehouse_Edit_Access.Visible = false;
            // 
            // Base_Information_Warehouse_Delete_Access
            // 
            this.Base_Information_Warehouse_Delete_Access.Name = "Base_Information_Warehouse_Delete_Access";
            this.Base_Information_Warehouse_Delete_Access.Size = new System.Drawing.Size(253, 22);
            this.Base_Information_Warehouse_Delete_Access.Text = "دسترسی به حـــــذف اطلاعات پایه انبار";
            this.Base_Information_Warehouse_Delete_Access.Visible = false;
            // 
            // Base_Information_Assets
            // 
            this.Base_Information_Assets.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Base_Information_Assets_Depreciation_Rate,
            this.Base_Information_Assets_Plan_project,
            this.Base_Information_Assets_City,
            this.Base_Information_Assets_Personnel,
            this.Base_Information_Assets_Cost_Code,
            this.Base_Information_Assets_Date,
            this.Base_Information_Assets_Access});
            this.Base_Information_Assets.Name = "Base_Information_Assets";
            this.Base_Information_Assets.Size = new System.Drawing.Size(191, 22);
            this.Base_Information_Assets.Text = "تعاریف دارائی های ثابت";
            this.Base_Information_Assets.Visible = false;
            // 
            // Base_Information_Assets_Depreciation_Rate
            // 
            this.Base_Information_Assets_Depreciation_Rate.Name = "Base_Information_Assets_Depreciation_Rate";
            this.Base_Information_Assets_Depreciation_Rate.Size = new System.Drawing.Size(201, 22);
            this.Base_Information_Assets_Depreciation_Rate.Text = "کد طبقات اصلی  و  فرعی";
            this.Base_Information_Assets_Depreciation_Rate.Visible = false;
            // 
            // Base_Information_Assets_Plan_project
            // 
            this.Base_Information_Assets_Plan_project.Name = "Base_Information_Assets_Plan_project";
            this.Base_Information_Assets_Plan_project.Size = new System.Drawing.Size(201, 22);
            this.Base_Information_Assets_Plan_project.Text = "کــــــــد طـــــــــرح و پـــــــــروژه";
            this.Base_Information_Assets_Plan_project.Visible = false;
            // 
            // Base_Information_Assets_City
            // 
            this.Base_Information_Assets_City.Name = "Base_Information_Assets_City";
            this.Base_Information_Assets_City.Size = new System.Drawing.Size(201, 22);
            this.Base_Information_Assets_City.Text = "شهر محل اسـتـقـرار دارائـی";
            this.Base_Information_Assets_City.Visible = false;
            // 
            // Base_Information_Assets_Personnel
            // 
            this.Base_Information_Assets_Personnel.Name = "Base_Information_Assets_Personnel";
            this.Base_Information_Assets_Personnel.Size = new System.Drawing.Size(201, 22);
            this.Base_Information_Assets_Personnel.Text = "کد پرسنل تحـویل  گــیــرنده ";
            this.Base_Information_Assets_Personnel.Visible = false;
            // 
            // Base_Information_Assets_Cost_Code
            // 
            this.Base_Information_Assets_Cost_Code.Name = "Base_Information_Assets_Cost_Code";
            this.Base_Information_Assets_Cost_Code.Size = new System.Drawing.Size(201, 22);
            this.Base_Information_Assets_Cost_Code.Text = "کد مــرکــز هـــزیـنــه دارائــی";
            this.Base_Information_Assets_Cost_Code.Visible = false;
            // 
            // Base_Information_Assets_Date
            // 
            this.Base_Information_Assets_Date.Name = "Base_Information_Assets_Date";
            this.Base_Information_Assets_Date.Size = new System.Drawing.Size(201, 22);
            this.Base_Information_Assets_Date.Text = "ایــــــجـــــاد دوره مـــــالــــــــی";
            this.Base_Information_Assets_Date.Visible = false;
            // 
            // Base_Information_Assets_Access
            // 
            this.Base_Information_Assets_Access.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Base_Information_Assets_Edit_Access,
            this.Base_Information_Assets_Delete_Access});
            this.Base_Information_Assets_Access.Name = "Base_Information_Assets_Access";
            this.Base_Information_Assets_Access.Size = new System.Drawing.Size(201, 22);
            this.Base_Information_Assets_Access.Text = "سطح دسترسی";
            this.Base_Information_Assets_Access.Visible = false;
            // 
            // Base_Information_Assets_Edit_Access
            // 
            this.Base_Information_Assets_Edit_Access.Name = "Base_Information_Assets_Edit_Access";
            this.Base_Information_Assets_Edit_Access.Size = new System.Drawing.Size(261, 22);
            this.Base_Information_Assets_Edit_Access.Text = "دسترسی به ویرایش اطلاعات پایه اموال";
            this.Base_Information_Assets_Edit_Access.Visible = false;
            // 
            // Base_Information_Assets_Delete_Access
            // 
            this.Base_Information_Assets_Delete_Access.Name = "Base_Information_Assets_Delete_Access";
            this.Base_Information_Assets_Delete_Access.Size = new System.Drawing.Size(261, 22);
            this.Base_Information_Assets_Delete_Access.Text = "دسترسی به حــــذف اطلاعات پایه اموال";
            this.Base_Information_Assets_Delete_Access.Visible = false;
            // 
            // Base_Information_Document
            // 
            this.Base_Information_Document.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Base_Information_Document_Bank,
            this.Base_Information_Document_Recovery_Classification,
            this.Base_Information_Warranty_Document_Classification,
            this.Base_Information_Document_Customer,
            this.Base_Information_Document_Area,
            this.Base_Information_Document_Access});
            this.Base_Information_Document.Name = "Base_Information_Document";
            this.Base_Information_Document.Size = new System.Drawing.Size(191, 22);
            this.Base_Information_Document.Text = "تعاریف اســنـــاد و بــانــک";
            this.Base_Information_Document.Visible = false;
            // 
            // Base_Information_Document_Bank
            // 
            this.Base_Information_Document_Bank.Name = "Base_Information_Document_Bank";
            this.Base_Information_Document_Bank.Size = new System.Drawing.Size(198, 22);
            this.Base_Information_Document_Bank.Text = "ثــبــت اطلاعــــــات بانــــکـها";
            this.Base_Information_Document_Bank.Visible = false;
            // 
            // Base_Information_Document_Recovery_Classification
            // 
            this.Base_Information_Document_Recovery_Classification.Name = "Base_Information_Document_Recovery_Classification";
            this.Base_Information_Document_Recovery_Classification.Size = new System.Drawing.Size(198, 22);
            this.Base_Information_Document_Recovery_Classification.Text = "طبقه بندی اسنـاد وصولی";
            this.Base_Information_Document_Recovery_Classification.Visible = false;
            // 
            // Base_Information_Warranty_Document_Classification
            // 
            this.Base_Information_Warranty_Document_Classification.Name = "Base_Information_Warranty_Document_Classification";
            this.Base_Information_Warranty_Document_Classification.Size = new System.Drawing.Size(198, 22);
            this.Base_Information_Warranty_Document_Classification.Text = "طبقه بندی اسناد ضمانتی";
            this.Base_Information_Warranty_Document_Classification.Visible = false;
            // 
            // Base_Information_Document_Customer
            // 
            this.Base_Information_Document_Customer.Name = "Base_Information_Document_Customer";
            this.Base_Information_Document_Customer.Size = new System.Drawing.Size(198, 22);
            this.Base_Information_Document_Customer.Text = "ثبت اطلاعـــــات مـــشتـــرک";
            this.Base_Information_Document_Customer.Visible = false;
            // 
            // Base_Information_Document_Area
            // 
            this.Base_Information_Document_Area.Name = "Base_Information_Document_Area";
            this.Base_Information_Document_Area.Size = new System.Drawing.Size(198, 22);
            this.Base_Information_Document_Area.Text = "ثبت مـــــحـــل جــغـرافــیایی";
            this.Base_Information_Document_Area.Visible = false;
            // 
            // Base_Information_Document_Access
            // 
            this.Base_Information_Document_Access.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Base_Information_Document_Edit_Access,
            this.Base_Information_Document_Delete_Access});
            this.Base_Information_Document_Access.Name = "Base_Information_Document_Access";
            this.Base_Information_Document_Access.Size = new System.Drawing.Size(198, 22);
            this.Base_Information_Document_Access.Text = "سطح دسترسی";
            this.Base_Information_Document_Access.Visible = false;
            // 
            // Base_Information_Document_Edit_Access
            // 
            this.Base_Information_Document_Edit_Access.Name = "Base_Information_Document_Edit_Access";
            this.Base_Information_Document_Edit_Access.Size = new System.Drawing.Size(270, 22);
            this.Base_Information_Document_Edit_Access.Text = "دسترسی به ویرایش اطلاعات اسناد و چک";
            this.Base_Information_Document_Edit_Access.Visible = false;
            // 
            // Base_Information_Document_Delete_Access
            // 
            this.Base_Information_Document_Delete_Access.Name = "Base_Information_Document_Delete_Access";
            this.Base_Information_Document_Delete_Access.Size = new System.Drawing.Size(270, 22);
            this.Base_Information_Document_Delete_Access.Text = "دسترسی به حـــــذف اطلاعات اسناد و چک";
            this.Base_Information_Document_Delete_Access.Visible = false;
            // 
            // Reports
            // 
            this.Reports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Report_Services,
            this.Report_Accounting,
            this.Report_Repair,
            this.Report_PayRoll,
            this.Report_Warehouse,
            this.Report_Estate,
            this.Report_Payable,
            this.Report_Collection_Document,
            this.Report_Warranty_Document});
            this.Reports.Name = "Reports";
            this.Reports.Size = new System.Drawing.Size(60, 20);
            this.Reports.Text = "گزارشات";
            this.Reports.Visible = false;
            // 
            // Report_Services
            // 
            this.Report_Services.Name = "Report_Services";
            this.Report_Services.Size = new System.Drawing.Size(235, 22);
            this.Report_Services.Text = "گزارشات خدمات";
            this.Report_Services.Visible = false;
            // 
            // Report_Accounting
            // 
            this.Report_Accounting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Report_Accounting_Note_Book,
            this.Report_Accounting_Align,
            this.Report_Accounting_Reports,
            this.Report_Accounting_Analysis});
            this.Report_Accounting.Name = "Report_Accounting";
            this.Report_Accounting.Size = new System.Drawing.Size(235, 22);
            this.Report_Accounting.Text = "گزارشات حسابداری";
            this.Report_Accounting.Visible = false;
            // 
            // Report_Accounting_Note_Book
            // 
            this.Report_Accounting_Note_Book.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Report_Accounting_Account_Note_Book,
            this.Report_Accounting_Details_Note_One_Book,
            this.Report_Accounting_Details_Note_Two_Book,
            this.Report_Accounting_Details_Note_Three_Book,
            this.Report_Accounting_Details_Note_Four_Book,
            this.Report_Accounting_Details_Note_Five_Book});
            this.Report_Accounting_Note_Book.Name = "Report_Accounting_Note_Book";
            this.Report_Accounting_Note_Book.Size = new System.Drawing.Size(143, 22);
            this.Report_Accounting_Note_Book.Text = "دفــتــر حــسـاب";
            this.Report_Accounting_Note_Book.Visible = false;
            // 
            // Report_Accounting_Account_Note_Book
            // 
            this.Report_Accounting_Account_Note_Book.Name = "Report_Accounting_Account_Note_Book";
            this.Report_Accounting_Account_Note_Book.Size = new System.Drawing.Size(153, 22);
            this.Report_Accounting_Account_Note_Book.Text = "دفتر یک حـساب";
            this.Report_Accounting_Account_Note_Book.Visible = false;
            // 
            // Report_Accounting_Details_Note_One_Book
            // 
            this.Report_Accounting_Details_Note_One_Book.Name = "Report_Accounting_Details_Note_One_Book";
            this.Report_Accounting_Details_Note_One_Book.Size = new System.Drawing.Size(153, 22);
            this.Report_Accounting_Details_Note_One_Book.Text = "دفتر تفصیلی   1";
            this.Report_Accounting_Details_Note_One_Book.Visible = false;
            // 
            // Report_Accounting_Details_Note_Two_Book
            // 
            this.Report_Accounting_Details_Note_Two_Book.Name = "Report_Accounting_Details_Note_Two_Book";
            this.Report_Accounting_Details_Note_Two_Book.Size = new System.Drawing.Size(153, 22);
            this.Report_Accounting_Details_Note_Two_Book.Text = "دفتر تفصیلی  2";
            this.Report_Accounting_Details_Note_Two_Book.Visible = false;
            // 
            // Report_Accounting_Details_Note_Three_Book
            // 
            this.Report_Accounting_Details_Note_Three_Book.Name = "Report_Accounting_Details_Note_Three_Book";
            this.Report_Accounting_Details_Note_Three_Book.Size = new System.Drawing.Size(153, 22);
            this.Report_Accounting_Details_Note_Three_Book.Text = "دفتر تفصیلی  3";
            this.Report_Accounting_Details_Note_Three_Book.Visible = false;
            // 
            // Report_Accounting_Details_Note_Four_Book
            // 
            this.Report_Accounting_Details_Note_Four_Book.Name = "Report_Accounting_Details_Note_Four_Book";
            this.Report_Accounting_Details_Note_Four_Book.Size = new System.Drawing.Size(153, 22);
            this.Report_Accounting_Details_Note_Four_Book.Text = "دفتر تفصیلی  4";
            this.Report_Accounting_Details_Note_Four_Book.Visible = false;
            // 
            // Report_Accounting_Details_Note_Five_Book
            // 
            this.Report_Accounting_Details_Note_Five_Book.Name = "Report_Accounting_Details_Note_Five_Book";
            this.Report_Accounting_Details_Note_Five_Book.Size = new System.Drawing.Size(153, 22);
            this.Report_Accounting_Details_Note_Five_Book.Text = "دفتر تفصیلی  5";
            this.Report_Accounting_Details_Note_Five_Book.Visible = false;
            // 
            // Report_Accounting_Align
            // 
            this.Report_Accounting_Align.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Report_Accounting_Four_Column_Align,
            this.Report_Accounting_Details_Four_Column_Align,
            this.Report_Accounting_Eight_Column_Align,
            this.Report_Accounting_Details_Eight_Column_Align});
            this.Report_Accounting_Align.Name = "Report_Accounting_Align";
            this.Report_Accounting_Align.Size = new System.Drawing.Size(143, 22);
            this.Report_Accounting_Align.Text = "تــراز حـــســــاب";
            this.Report_Accounting_Align.Visible = false;
            // 
            // Report_Accounting_Four_Column_Align
            // 
            this.Report_Accounting_Four_Column_Align.Name = "Report_Accounting_Four_Column_Align";
            this.Report_Accounting_Four_Column_Align.Size = new System.Drawing.Size(288, 22);
            this.Report_Accounting_Four_Column_Align.Text = "تراز و سایر گزارش های 4 ستونی حـــســـاب ها";
            this.Report_Accounting_Four_Column_Align.Visible = false;
            // 
            // Report_Accounting_Details_Four_Column_Align
            // 
            this.Report_Accounting_Details_Four_Column_Align.Name = "Report_Accounting_Details_Four_Column_Align";
            this.Report_Accounting_Details_Four_Column_Align.Size = new System.Drawing.Size(288, 22);
            this.Report_Accounting_Details_Four_Column_Align.Text = "تراز و سایر گزارش های 4 ستونی تــفصیلی ها";
            this.Report_Accounting_Details_Four_Column_Align.Visible = false;
            // 
            // Report_Accounting_Eight_Column_Align
            // 
            this.Report_Accounting_Eight_Column_Align.Name = "Report_Accounting_Eight_Column_Align";
            this.Report_Accounting_Eight_Column_Align.Size = new System.Drawing.Size(288, 22);
            this.Report_Accounting_Eight_Column_Align.Text = "تراز و سایر گزارش های 8 ستونی حـــســـاب ها";
            this.Report_Accounting_Eight_Column_Align.Visible = false;
            // 
            // Report_Accounting_Details_Eight_Column_Align
            // 
            this.Report_Accounting_Details_Eight_Column_Align.Name = "Report_Accounting_Details_Eight_Column_Align";
            this.Report_Accounting_Details_Eight_Column_Align.Size = new System.Drawing.Size(288, 22);
            this.Report_Accounting_Details_Eight_Column_Align.Text = "تراز و سایر گزارش های 8 ستونی تـفصیلی ها";
            this.Report_Accounting_Details_Eight_Column_Align.Visible = false;
            // 
            // Report_Accounting_Reports
            // 
            this.Report_Accounting_Reports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Report_Accounting_Details});
            this.Report_Accounting_Reports.Name = "Report_Accounting_Reports";
            this.Report_Accounting_Reports.Size = new System.Drawing.Size(143, 22);
            this.Report_Accounting_Reports.Text = "گزارش حســاب";
            this.Report_Accounting_Reports.Visible = false;
            // 
            // Report_Accounting_Details
            // 
            this.Report_Accounting_Details.Name = "Report_Accounting_Details";
            this.Report_Accounting_Details.Size = new System.Drawing.Size(204, 22);
            this.Report_Accounting_Details.Text = "صورت ریز حساب / تفصیل";
            // 
            // Report_Accounting_Analysis
            // 
            this.Report_Accounting_Analysis.Name = "Report_Accounting_Analysis";
            this.Report_Accounting_Analysis.Size = new System.Drawing.Size(143, 22);
            this.Report_Accounting_Analysis.Text = "تحــلـیل حسـاب";
            this.Report_Accounting_Analysis.Visible = false;
            // 
            // Report_Repair
            // 
            this.Report_Repair.Name = "Report_Repair";
            this.Report_Repair.Size = new System.Drawing.Size(235, 22);
            this.Report_Repair.Text = "گزارشات تعمیر و نگهداری";
            this.Report_Repair.Visible = false;
            // 
            // Report_PayRoll
            // 
            this.Report_PayRoll.Name = "Report_PayRoll";
            this.Report_PayRoll.Size = new System.Drawing.Size(235, 22);
            this.Report_PayRoll.Text = "گزارشات حقوق و دستمزد";
            this.Report_PayRoll.Visible = false;
            // 
            // Report_Warehouse
            // 
            this.Report_Warehouse.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Report_Warehouse_Number,
            this.Report_Warehouse_Cardx,
            this.Report_Warehouse_Turnover,
            this.Report_Warehouse_Inventory,
            this.Report_Warehouse_Accounting,
            this.Report_Warehouse_Accounting_Cardx,
            this.Report_Warehouse_Accounting_Turnover,
            this.Report_Warehouse_Accounting_Inventory,
            this.Report_Warehouse_Handling,
            this.Report_Warehouse_Handling_One_Counts,
            this.Report_Warehouse_Handling_Two_Counts,
            this.Report_Warehouse_Handling_Third_Counts});
            this.Report_Warehouse.Name = "Report_Warehouse";
            this.Report_Warehouse.Size = new System.Drawing.Size(235, 22);
            this.Report_Warehouse.Text = "گزارشات انبار";
            this.Report_Warehouse.Visible = false;
            // 
            // Report_Warehouse_Number
            // 
            this.Report_Warehouse_Number.Name = "Report_Warehouse_Number";
            this.Report_Warehouse_Number.Size = new System.Drawing.Size(323, 22);
            this.Report_Warehouse_Number.Text = "گزارشات تعدادی انبار";
            this.Report_Warehouse_Number.Visible = false;
            // 
            // Report_Warehouse_Cardx
            // 
            this.Report_Warehouse_Cardx.Name = "Report_Warehouse_Cardx";
            this.Report_Warehouse_Cardx.Size = new System.Drawing.Size(323, 22);
            this.Report_Warehouse_Cardx.Text = "گزارش کاردکس کالا در انبار";
            this.Report_Warehouse_Cardx.Visible = false;
            // 
            // Report_Warehouse_Turnover
            // 
            this.Report_Warehouse_Turnover.Name = "Report_Warehouse_Turnover";
            this.Report_Warehouse_Turnover.Size = new System.Drawing.Size(323, 22);
            this.Report_Warehouse_Turnover.Text = "گزارش گردش کالا در انبار";
            this.Report_Warehouse_Turnover.Visible = false;
            // 
            // Report_Warehouse_Inventory
            // 
            this.Report_Warehouse_Inventory.Name = "Report_Warehouse_Inventory";
            this.Report_Warehouse_Inventory.Size = new System.Drawing.Size(323, 22);
            this.Report_Warehouse_Inventory.Text = "گزارش موجودی کالا در انبار";
            this.Report_Warehouse_Inventory.Visible = false;
            // 
            // Report_Warehouse_Accounting
            // 
            this.Report_Warehouse_Accounting.Name = "Report_Warehouse_Accounting";
            this.Report_Warehouse_Accounting.Size = new System.Drawing.Size(323, 22);
            this.Report_Warehouse_Accounting.Text = "گزارشات ریالی انبار";
            this.Report_Warehouse_Accounting.Visible = false;
            // 
            // Report_Warehouse_Accounting_Cardx
            // 
            this.Report_Warehouse_Accounting_Cardx.Name = "Report_Warehouse_Accounting_Cardx";
            this.Report_Warehouse_Accounting_Cardx.Size = new System.Drawing.Size(323, 22);
            this.Report_Warehouse_Accounting_Cardx.Text = "گزارش کاردکس کالا در انبار";
            this.Report_Warehouse_Accounting_Cardx.Visible = false;
            // 
            // Report_Warehouse_Accounting_Turnover
            // 
            this.Report_Warehouse_Accounting_Turnover.Name = "Report_Warehouse_Accounting_Turnover";
            this.Report_Warehouse_Accounting_Turnover.Size = new System.Drawing.Size(323, 22);
            this.Report_Warehouse_Accounting_Turnover.Text = "گزارش گردش کالا در انبار";
            this.Report_Warehouse_Accounting_Turnover.Visible = false;
            // 
            // Report_Warehouse_Accounting_Inventory
            // 
            this.Report_Warehouse_Accounting_Inventory.Name = "Report_Warehouse_Accounting_Inventory";
            this.Report_Warehouse_Accounting_Inventory.Size = new System.Drawing.Size(323, 22);
            this.Report_Warehouse_Accounting_Inventory.Text = "گزارش موجودی کالا در انبار";
            this.Report_Warehouse_Accounting_Inventory.Visible = false;
            // 
            // Report_Warehouse_Handling
            // 
            this.Report_Warehouse_Handling.Name = "Report_Warehouse_Handling";
            this.Report_Warehouse_Handling.Size = new System.Drawing.Size(323, 22);
            this.Report_Warehouse_Handling.Text = "گزارشات انبار گردانی";
            this.Report_Warehouse_Handling.Visible = false;
            // 
            // Report_Warehouse_Handling_One_Counts
            // 
            this.Report_Warehouse_Handling_One_Counts.Name = "Report_Warehouse_Handling_One_Counts";
            this.Report_Warehouse_Handling_One_Counts.Size = new System.Drawing.Size(323, 22);
            this.Report_Warehouse_Handling_One_Counts.Text = "گزارش مقایسه شمارش اول و دوم";
            this.Report_Warehouse_Handling_One_Counts.Visible = false;
            // 
            // Report_Warehouse_Handling_Two_Counts
            // 
            this.Report_Warehouse_Handling_Two_Counts.Name = "Report_Warehouse_Handling_Two_Counts";
            this.Report_Warehouse_Handling_Two_Counts.Size = new System.Drawing.Size(323, 22);
            this.Report_Warehouse_Handling_Two_Counts.Text = "گزارش مقایسه شمارش اول - دوم - سوم با موجودی";
            this.Report_Warehouse_Handling_Two_Counts.Visible = false;
            // 
            // Report_Warehouse_Handling_Third_Counts
            // 
            this.Report_Warehouse_Handling_Third_Counts.Name = "Report_Warehouse_Handling_Third_Counts";
            this.Report_Warehouse_Handling_Third_Counts.Size = new System.Drawing.Size(323, 22);
            this.Report_Warehouse_Handling_Third_Counts.Text = "گزارش کسری و اضافات انبار";
            this.Report_Warehouse_Handling_Third_Counts.Visible = false;
            // 
            // Report_Estate
            // 
            this.Report_Estate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Report_Estate_Responsible,
            this.Report_Estate_Consumable_Delivering,
            this.Report_Estate_Delivering,
            this.Report_Consumable_Delivering,
            this.Report_Estate_Accountants,
            this.Report_Estate_Facial,
            this.Report_Estate_Original_Code,
            this.Report_Estate_Cost_Code,
            this.Report_Estate_Cost_Original,
            this.Report_Estate_Original_Cost,
            this.Report_Estate_Original_Cost_City,
            this.Report_Estate_Decrease,
            this.Report_Estate_Dismiss,
            this.Report_Estate_Document_Cost,
            this.Report_Estate_Document_Original,
            this.Report_Estate_Document_Dismiss});
            this.Report_Estate.Name = "Report_Estate";
            this.Report_Estate.Size = new System.Drawing.Size(235, 22);
            this.Report_Estate.Text = "گزارشات اموال و دارائی های ثابت";
            this.Report_Estate.Visible = false;
            // 
            // Report_Estate_Responsible
            // 
            this.Report_Estate_Responsible.Name = "Report_Estate_Responsible";
            this.Report_Estate_Responsible.Size = new System.Drawing.Size(340, 22);
            this.Report_Estate_Responsible.Text = "گزارشات امین اموال دار";
            this.Report_Estate_Responsible.Visible = false;
            // 
            // Report_Estate_Consumable_Delivering
            // 
            this.Report_Estate_Consumable_Delivering.Name = "Report_Estate_Consumable_Delivering";
            this.Report_Estate_Consumable_Delivering.Size = new System.Drawing.Size(340, 22);
            this.Report_Estate_Consumable_Delivering.Text = "گزارش اموال و اجناس مصرفی تحویلی";
            this.Report_Estate_Consumable_Delivering.Visible = false;
            // 
            // Report_Estate_Delivering
            // 
            this.Report_Estate_Delivering.Name = "Report_Estate_Delivering";
            this.Report_Estate_Delivering.Size = new System.Drawing.Size(340, 22);
            this.Report_Estate_Delivering.Text = "گزارش اموال تحویلی";
            this.Report_Estate_Delivering.Visible = false;
            // 
            // Report_Consumable_Delivering
            // 
            this.Report_Consumable_Delivering.Name = "Report_Consumable_Delivering";
            this.Report_Consumable_Delivering.Size = new System.Drawing.Size(340, 22);
            this.Report_Consumable_Delivering.Text = "گزارش اجناس مصرفی تحویلی";
            this.Report_Consumable_Delivering.Visible = false;
            // 
            // Report_Estate_Accountants
            // 
            this.Report_Estate_Accountants.Name = "Report_Estate_Accountants";
            this.Report_Estate_Accountants.Size = new System.Drawing.Size(340, 22);
            this.Report_Estate_Accountants.Text = "گزارشات حسابدار اموال";
            this.Report_Estate_Accountants.Visible = false;
            // 
            // Report_Estate_Facial
            // 
            this.Report_Estate_Facial.Name = "Report_Estate_Facial";
            this.Report_Estate_Facial.Size = new System.Drawing.Size(340, 22);
            this.Report_Estate_Facial.Text = "گزارش صورت ریز اموال";
            this.Report_Estate_Facial.Visible = false;
            // 
            // Report_Estate_Original_Code
            // 
            this.Report_Estate_Original_Code.Name = "Report_Estate_Original_Code";
            this.Report_Estate_Original_Code.Size = new System.Drawing.Size(340, 22);
            this.Report_Estate_Original_Code.Text = "گزارش صورت اموال تجمیع کد اصلی";
            this.Report_Estate_Original_Code.Visible = false;
            // 
            // Report_Estate_Cost_Code
            // 
            this.Report_Estate_Cost_Code.Name = "Report_Estate_Cost_Code";
            this.Report_Estate_Cost_Code.Size = new System.Drawing.Size(340, 22);
            this.Report_Estate_Cost_Code.Text = "گزارش صورت اموال تجمیع مرکز هزینه";
            this.Report_Estate_Cost_Code.Visible = false;
            // 
            // Report_Estate_Cost_Original
            // 
            this.Report_Estate_Cost_Original.Name = "Report_Estate_Cost_Original";
            this.Report_Estate_Cost_Original.Size = new System.Drawing.Size(340, 22);
            this.Report_Estate_Cost_Original.Text = "گزارش صورت اموال تجمیع مرکز هزینه به کد اصلی";
            this.Report_Estate_Cost_Original.Visible = false;
            // 
            // Report_Estate_Original_Cost
            // 
            this.Report_Estate_Original_Cost.Name = "Report_Estate_Original_Cost";
            this.Report_Estate_Original_Cost.Size = new System.Drawing.Size(340, 22);
            this.Report_Estate_Original_Cost.Text = "گزارش صورت اموال تجمیع کد اصلی به مرکز هزینه";
            this.Report_Estate_Original_Cost.Visible = false;
            // 
            // Report_Estate_Original_Cost_City
            // 
            this.Report_Estate_Original_Cost_City.Name = "Report_Estate_Original_Cost_City";
            this.Report_Estate_Original_Cost_City.Size = new System.Drawing.Size(340, 22);
            this.Report_Estate_Original_Cost_City.Text = "گزارش صورت اموال تجمیع مرکز هزینه به تفکیک شهرها";
            this.Report_Estate_Original_Cost_City.Visible = false;
            // 
            // Report_Estate_Decrease
            // 
            this.Report_Estate_Decrease.Name = "Report_Estate_Decrease";
            this.Report_Estate_Decrease.Size = new System.Drawing.Size(340, 22);
            this.Report_Estate_Decrease.Text = "گزارش بر اساس کاهش اموال";
            this.Report_Estate_Decrease.Visible = false;
            // 
            // Report_Estate_Dismiss
            // 
            this.Report_Estate_Dismiss.Name = "Report_Estate_Dismiss";
            this.Report_Estate_Dismiss.Size = new System.Drawing.Size(340, 22);
            this.Report_Estate_Dismiss.Text = "گزارش بر اساس  برکناری اموال";
            this.Report_Estate_Dismiss.Visible = false;
            // 
            // Report_Estate_Document_Cost
            // 
            this.Report_Estate_Document_Cost.Name = "Report_Estate_Document_Cost";
            this.Report_Estate_Document_Cost.Size = new System.Drawing.Size(340, 22);
            this.Report_Estate_Document_Cost.Text = "سند حسابداری محاسبه استهلاک - کد هزینه به اصلی";
            this.Report_Estate_Document_Cost.Visible = false;
            // 
            // Report_Estate_Document_Original
            // 
            this.Report_Estate_Document_Original.Name = "Report_Estate_Document_Original";
            this.Report_Estate_Document_Original.Size = new System.Drawing.Size(340, 22);
            this.Report_Estate_Document_Original.Text = "سند حسابداری محاسبه استهلاک - کد اصلی به هزینه";
            this.Report_Estate_Document_Original.Visible = false;
            // 
            // Report_Estate_Document_Dismiss
            // 
            this.Report_Estate_Document_Dismiss.Name = "Report_Estate_Document_Dismiss";
            this.Report_Estate_Document_Dismiss.Size = new System.Drawing.Size(340, 22);
            this.Report_Estate_Document_Dismiss.Text = "سند حسابداری برکناری اموال";
            this.Report_Estate_Document_Dismiss.Visible = false;
            // 
            // Report_Payable
            // 
            this.Report_Payable.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Report_Payable_Turnover,
            this.Report_Payable_Checked_Out,
            this.Report_Payable_Deposits,
            this.Report_Payable_Wage});
            this.Report_Payable.Name = "Report_Payable";
            this.Report_Payable.Size = new System.Drawing.Size(235, 22);
            this.Report_Payable.Text = "گزارشات ثبت چک بانک";
            this.Report_Payable.Visible = false;
            // 
            // Report_Payable_Turnover
            // 
            this.Report_Payable_Turnover.Name = "Report_Payable_Turnover";
            this.Report_Payable_Turnover.Size = new System.Drawing.Size(248, 22);
            this.Report_Payable_Turnover.Text = "گزارش گردش حساب";
            this.Report_Payable_Turnover.Visible = false;
            // 
            // Report_Payable_Checked_Out
            // 
            this.Report_Payable_Checked_Out.Name = "Report_Payable_Checked_Out";
            this.Report_Payable_Checked_Out.Size = new System.Drawing.Size(248, 22);
            this.Report_Payable_Checked_Out.Text = "گزارش بر اساس چک های صادر شده";
            this.Report_Payable_Checked_Out.Visible = false;
            // 
            // Report_Payable_Deposits
            // 
            this.Report_Payable_Deposits.Name = "Report_Payable_Deposits";
            this.Report_Payable_Deposits.Size = new System.Drawing.Size(248, 22);
            this.Report_Payable_Deposits.Text = "گزارش بر اساس مبالغ واریزی";
            this.Report_Payable_Deposits.Visible = false;
            // 
            // Report_Payable_Wage
            // 
            this.Report_Payable_Wage.Name = "Report_Payable_Wage";
            this.Report_Payable_Wage.Size = new System.Drawing.Size(248, 22);
            this.Report_Payable_Wage.Text = "گزارش بر اساس کارمزد و ثبت هزینه";
            this.Report_Payable_Wage.Visible = false;
            // 
            // Report_Collection_Document
            // 
            this.Report_Collection_Document.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Report_Collection_Document_Add,
            this.Report_Collection_Document_Due_Date,
            this.Report_Collection_Document_Assignment,
            this.Report_Collection_Document_Notice,
            this.Report_Collection_Document_Back,
            this.Report_Collection_Document_Refund_Date,
            this.Report_Collection_Document_Receipt});
            this.Report_Collection_Document.Name = "Report_Collection_Document";
            this.Report_Collection_Document.Size = new System.Drawing.Size(235, 22);
            this.Report_Collection_Document.Text = "گزارشات اسناد وصولی";
            this.Report_Collection_Document.Visible = false;
            // 
            // Report_Collection_Document_Add
            // 
            this.Report_Collection_Document_Add.Name = "Report_Collection_Document_Add";
            this.Report_Collection_Document_Add.Size = new System.Drawing.Size(221, 22);
            this.Report_Collection_Document_Add.Text = "گزارش بر اساس  تاریخ دریافت";
            this.Report_Collection_Document_Add.Visible = false;
            // 
            // Report_Collection_Document_Due_Date
            // 
            this.Report_Collection_Document_Due_Date.Name = "Report_Collection_Document_Due_Date";
            this.Report_Collection_Document_Due_Date.Size = new System.Drawing.Size(221, 22);
            this.Report_Collection_Document_Due_Date.Text = "گزارش بر اساس تاریخ سر رسید";
            this.Report_Collection_Document_Due_Date.Visible = false;
            // 
            // Report_Collection_Document_Assignment
            // 
            this.Report_Collection_Document_Assignment.Name = "Report_Collection_Document_Assignment";
            this.Report_Collection_Document_Assignment.Size = new System.Drawing.Size(221, 22);
            this.Report_Collection_Document_Assignment.Text = "گزارش بر اساس تاریخ واگــذاری";
            this.Report_Collection_Document_Assignment.Visible = false;
            // 
            // Report_Collection_Document_Notice
            // 
            this.Report_Collection_Document_Notice.Name = "Report_Collection_Document_Notice";
            this.Report_Collection_Document_Notice.Size = new System.Drawing.Size(221, 22);
            this.Report_Collection_Document_Notice.Text = "گزارش بر اساس تاریخ وصـــول";
            this.Report_Collection_Document_Notice.Visible = false;
            // 
            // Report_Collection_Document_Back
            // 
            this.Report_Collection_Document_Back.Name = "Report_Collection_Document_Back";
            this.Report_Collection_Document_Back.Size = new System.Drawing.Size(221, 22);
            this.Report_Collection_Document_Back.Text = "گزارش بر اساس تاریخ برگشـت";
            this.Report_Collection_Document_Back.Visible = false;
            // 
            // Report_Collection_Document_Refund_Date
            // 
            this.Report_Collection_Document_Refund_Date.Name = "Report_Collection_Document_Refund_Date";
            this.Report_Collection_Document_Refund_Date.Size = new System.Drawing.Size(221, 22);
            this.Report_Collection_Document_Refund_Date.Text = "گزارش بر اساس تاریخ اسـترداد";
            this.Report_Collection_Document_Refund_Date.Visible = false;
            // 
            // Report_Collection_Document_Receipt
            // 
            this.Report_Collection_Document_Receipt.Name = "Report_Collection_Document_Receipt";
            this.Report_Collection_Document_Receipt.Size = new System.Drawing.Size(221, 22);
            this.Report_Collection_Document_Receipt.Text = "گزارش رسید واگذار شده بـانـک";
            this.Report_Collection_Document_Receipt.Visible = false;
            // 
            // Report_Warranty_Document
            // 
            this.Report_Warranty_Document.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Report_Warranty_Document_No_Date,
            this.Report_Warranty_Document_Extended_Date,
            this.Report_Warranty_Document_Refund_Date,
            this.Report_Warranty_Document_Due_Date,
            this.Report_Warranty_Document_Date});
            this.Report_Warranty_Document.Name = "Report_Warranty_Document";
            this.Report_Warranty_Document.Size = new System.Drawing.Size(235, 22);
            this.Report_Warranty_Document.Text = "گزارشات اسناد ضمانتی";
            this.Report_Warranty_Document.Visible = false;
            // 
            // Report_Warranty_Document_No_Date
            // 
            this.Report_Warranty_Document_No_Date.Name = "Report_Warranty_Document_No_Date";
            this.Report_Warranty_Document_No_Date.Size = new System.Drawing.Size(256, 22);
            this.Report_Warranty_Document_No_Date.Text = "گزارش بر اساس تاریخ ثــــبـــــت";
            this.Report_Warranty_Document_No_Date.Visible = false;
            // 
            // Report_Warranty_Document_Extended_Date
            // 
            this.Report_Warranty_Document_Extended_Date.Name = "Report_Warranty_Document_Extended_Date";
            this.Report_Warranty_Document_Extended_Date.Size = new System.Drawing.Size(256, 22);
            this.Report_Warranty_Document_Extended_Date.Text = "گزارش بر اساس تاریخ تـــمـــدید";
            this.Report_Warranty_Document_Extended_Date.Visible = false;
            // 
            // Report_Warranty_Document_Refund_Date
            // 
            this.Report_Warranty_Document_Refund_Date.Name = "Report_Warranty_Document_Refund_Date";
            this.Report_Warranty_Document_Refund_Date.Size = new System.Drawing.Size(256, 22);
            this.Report_Warranty_Document_Refund_Date.Text = "گزارش بر اساس تاریخ اســترداد";
            this.Report_Warranty_Document_Refund_Date.Visible = false;
            // 
            // Report_Warranty_Document_Due_Date
            // 
            this.Report_Warranty_Document_Due_Date.Name = "Report_Warranty_Document_Due_Date";
            this.Report_Warranty_Document_Due_Date.Size = new System.Drawing.Size(256, 22);
            this.Report_Warranty_Document_Due_Date.Text = "گزارش بر اساس تاریخ سررسید و تمدید";
            this.Report_Warranty_Document_Due_Date.Visible = false;
            // 
            // Report_Warranty_Document_Date
            // 
            this.Report_Warranty_Document_Date.Name = "Report_Warranty_Document_Date";
            this.Report_Warranty_Document_Date.Size = new System.Drawing.Size(256, 22);
            this.Report_Warranty_Document_Date.Text = "گزارش مانده موجودی اســنـــاد";
            this.Report_Warranty_Document_Date.Visible = false;
            // 
            // View
            // 
            this.View.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.View_Menu_Toolbox,
            this.View_Menu_Subtitle,
            this.View_Menu_Help,
            this.View_Menu_Log});
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(51, 20);
            this.View.Text = "نمایش";
            this.View.Visible = false;
            // 
            // View_Menu_Toolbox
            // 
            this.View_Menu_Toolbox.CheckOnClick = true;
            this.View_Menu_Toolbox.Name = "View_Menu_Toolbox";
            this.View_Menu_Toolbox.Size = new System.Drawing.Size(151, 22);
            this.View_Menu_Toolbox.Text = "جعبه ابـــــــــــــزار";
            this.View_Menu_Toolbox.Visible = false;
            // 
            // View_Menu_Subtitle
            // 
            this.View_Menu_Subtitle.CheckOnClick = true;
            this.View_Menu_Subtitle.Name = "View_Menu_Subtitle";
            this.View_Menu_Subtitle.Size = new System.Drawing.Size(151, 22);
            this.View_Menu_Subtitle.Text = "جعبه زیر نویس";
            this.View_Menu_Subtitle.Visible = false;
            // 
            // View_Menu_Help
            // 
            this.View_Menu_Help.Name = "View_Menu_Help";
            this.View_Menu_Help.Size = new System.Drawing.Size(151, 22);
            this.View_Menu_Help.Text = "کمک یار سیستم";
            this.View_Menu_Help.Visible = false;
            // 
            // View_Menu_Log
            // 
            this.View_Menu_Log.Name = "View_Menu_Log";
            this.View_Menu_Log.Size = new System.Drawing.Size(151, 22);
            this.View_Menu_Log.Text = "کـــنــتـــرل اســناد";
            this.View_Menu_Log.Visible = false;
            // 
            // Systems
            // 
            this.Systems.Name = "Systems";
            this.Systems.Size = new System.Drawing.Size(54, 20);
            this.Systems.Text = "سیستم";
            this.Systems.Visible = false;
            // 
            // Exits
            // 
            this.Exits.Name = "Exits";
            this.Exits.Size = new System.Drawing.Size(44, 20);
            this.Exits.Text = "خروج";
            // 
            // System_User_Menu
            // 
            this.System_User_Menu.Name = "System_User_Menu";
            this.System_User_Menu.Size = new System.Drawing.Size(170, 22);
            this.System_User_Menu.Text = "مـــعــــرفـــی کـــاربــــر";
            // 
            // System_Area_Menu
            // 
            this.System_Area_Menu.Name = "System_Area_Menu";
            this.System_Area_Menu.Size = new System.Drawing.Size(170, 22);
            this.System_Area_Menu.Text = "انـــتــخـــاب بـــــخـــــش";
            // 
            // System_Activation_Menu
            // 
            this.System_Activation_Menu.Name = "System_Activation_Menu";
            this.System_Activation_Menu.Size = new System.Drawing.Size(170, 22);
            this.System_Activation_Menu.Text = "فعال سازی نرم افزار";
            // 
            // System_Chang_User_Menu
            // 
            this.System_Chang_User_Menu.Name = "System_Chang_User_Menu";
            this.System_Chang_User_Menu.Size = new System.Drawing.Size(170, 22);
            this.System_Chang_User_Menu.Text = "تــغــیــــیــــــر کــــــاربـــر";
            // 
            // System_sms
            // 
            this.System_sms.Name = "System_sms";
            this.System_sms.Size = new System.Drawing.Size(170, 22);
            this.System_sms.Text = "سامانه ارسال پیامک";
            this.System_sms.Visible = false;
            // 
            // StatusStrip
            // 
            this.StatusStrip.BackColor = SystemColors.GradientActiveCaption;
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Today_Date,
            this.ID,
            this.I_N,
            this.Report,
            this.N_Admin,
            this.N_Id_Area,
            this.N_Company_Area,
            this.N_Department_Area,
            this.N_Fiscal_Year_Area,
            this.Description,
            this.Information});
            this.StatusStrip.Location = new System.Drawing.Point(0, 440);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Padding = new System.Windows.Forms.Padding(14, 0, 2, 0);
            this.StatusStrip.Size = new System.Drawing.Size(762, 22);
            this.StatusStrip.TabIndex = 9;
            this.StatusStrip.Text = "StatusStrip";
            // 
            // Today_Date
            // 
            this.Today_Date.Name = "Today_Date";
            this.Today_Date.Size = new System.Drawing.Size(68, 17);
            this.Today_Date.Text = "Today_Date";
            // 
            // ID
            // 
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 17);
            this.ID.Text = "ID";
            this.ID.Visible = false;
            // 
            // I_N
            // 
            this.I_N.Name = "I_N";
            this.I_N.Size = new System.Drawing.Size(24, 17);
            this.I_N.Text = "I_N";
            this.I_N.Visible = false;
            // 
            // Report
            // 
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(42, 17);
            this.Report.Text = "Report";
            this.Report.Visible = false;
            // 
            // N_Admin
            // 
            this.N_Admin.Name = "N_Admin";
            this.N_Admin.Size = new System.Drawing.Size(68, 17);
            this.N_Admin.Text = "N_Area_Col";
            this.N_Admin.Visible = false;
            // 
            // N_Id_Area
            // 
            this.N_Id_Area.Name = "N_Id_Area";
            this.N_Id_Area.Size = new System.Drawing.Size(60, 17);
            this.N_Id_Area.Text = "N_Id_Area";
            this.N_Id_Area.Visible = false;
            // 
            // N_Company_Area
            // 
            this.N_Company_Area.Name = "N_Company_Area";
            this.N_Company_Area.Size = new System.Drawing.Size(102, 17);
            this.N_Company_Area.Text = "N_Company_Area";
            this.N_Company_Area.Visible = false;
            // 
            // N_Department_Area
            // 
            this.N_Department_Area.Name = "N_Department_Area";
            this.N_Department_Area.Size = new System.Drawing.Size(113, 17);
            this.N_Department_Area.Text = "N_Department_Area";
            // 
            // N_Fiscal_Year_Area
            // 
            this.N_Fiscal_Year_Area.Name = "N_Fiscal_Year_Area";
            this.N_Fiscal_Year_Area.Size = new System.Drawing.Size(106, 17);
            this.N_Fiscal_Year_Area.Text = "N_Fiscal_Year_Area";
            this.N_Fiscal_Year_Area.Visible = false;
            // 
            // Description
            // 
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(67, 17);
            this.Description.Text = "Description";
            this.Description.Visible = false;
            // 
            // Information
            // 
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(70, 17);
            this.Information.Text = "Information";
            // 
            // SplitContainer1
            // 
            this.SplitContainer1.AllowDrop = true;
            this.SplitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom) 
            | AnchorStyles.Left) 
            | AnchorStyles.Right)));
            this.SplitContainer1.FixedPanel = FixedPanel.Panel1;
            this.SplitContainer1.IsSplitterFixed = true;
            this.SplitContainer1.Location = new System.Drawing.Point(0, 24);
            this.SplitContainer1.Name = "SplitContainer1";
            // 
            // SplitContainer1.Panel1
            // 
            this.SplitContainer1.Panel1.Controls.Add(this.GroupBox1);
            this.SplitContainer1.Panel1.RightToLeft = RightToLeft.Yes;
            // 
            // SplitContainer1.Panel2
            // 
            this.SplitContainer1.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SplitContainer1.Panel2.BackgroundImage")));
            this.SplitContainer1.Panel2.BackgroundImageLayout =ImageLayout.Stretch;
            this.SplitContainer1.Panel2.Controls.Add(this.tvData);
            this.SplitContainer1.Panel2.RightToLeft =RightToLeft.Yes;
            this.SplitContainer1.Size = new System.Drawing.Size(762, 416);
            this.SplitContainer1.SplitterDistance = 49;
            this.SplitContainer1.TabIndex = 24;
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = SystemColors.GradientActiveCaption;
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.PictureBox3);
            this.GroupBox1.Controls.Add(this.PictureBox1);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label_Collection);
            this.GroupBox1.Controls.Add(this.PictureBox2);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.Label_Warranty);
            this.GroupBox1.Dock = DockStyle.Fill;
            this.GroupBox1.Location = new System.Drawing.Point(0, 0);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(49, 416);
            this.GroupBox1.TabIndex = 25;
            this.GroupBox1.TabStop = false;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = Color.Transparent;
            this.Label4.ForeColor = Color.Crimson;
            this.Label4.Location = new System.Drawing.Point(1, 301);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(38, 13);
            this.Label4.TabIndex = 37;
            this.Label4.Text = "پیام ها";
            this.Label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = Color.Transparent;
            this.Label5.Cursor = Cursors.Hand;
            this.Label5.ForeColor = Color.DarkCyan;
            this.Label5.Location = new System.Drawing.Point(12, 269);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(13, 13);
            this.Label5.TabIndex = 36;
            this.Label5.Text = "0";
            // 
            // PictureBox3
            // 
            this.PictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureBox3.BackgroundImage")));
            this.PictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            this.PictureBox3.Location = new System.Drawing.Point(0, 223);
            this.PictureBox3.Name = "PictureBox3";
            this.PictureBox3.Size = new System.Drawing.Size(49, 43);
            this.PictureBox3.TabIndex = 35;
            this.PictureBox3.TabStop = false;
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureBox1.BackgroundImage")));
            this.PictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            this.PictureBox1.Location = new System.Drawing.Point(0, 3);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(49, 43);
            this.PictureBox1.TabIndex = 34;
            this.PictureBox1.TabStop = false;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = Color.Transparent;
            this.Label3.ForeColor = Color.Crimson;
            this.Label3.Location = new System.Drawing.Point(1, 193);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(41, 13);
            this.Label3.TabIndex = 33;
            this.Label3.Text = "وصولی";
            this.Label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label_Collection
            // 
            this.Label_Collection.AutoSize = true;
            this.Label_Collection.BackColor = Color.Transparent;
            this.Label_Collection.Cursor = Cursors.Hand;
            this.Label_Collection.ForeColor = Color.DarkCyan;
            this.Label_Collection.Location = new System.Drawing.Point(12, 161);
            this.Label_Collection.Name = "Label_Collection";
            this.Label_Collection.Size = new System.Drawing.Size(13, 13);
            this.Label_Collection.TabIndex = 32;
            this.Label_Collection.Text = "0";
            // 
            // PictureBox2
            // 
            this.PictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureBox2.BackgroundImage")));
            this.PictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            this.PictureBox2.Location = new System.Drawing.Point(0, 115);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(49, 43);
            this.PictureBox2.TabIndex = 31;
            this.PictureBox2.TabStop = false;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = Color.Transparent;
            this.Label1.ForeColor = Color.Crimson;
            this.Label1.Location = new System.Drawing.Point(1, 82);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(44, 13);
            this.Label1.TabIndex = 30;
            this.Label1.Text = "انتظامی";
            // 
            // Label_Warranty
            // 
            this.Label_Warranty.AutoSize = true;
            this.Label_Warranty.BackColor = Color.Transparent;
            this.Label_Warranty.Cursor = Cursors.Hand;
            this.Label_Warranty.ForeColor = Color.DarkCyan;
            this.Label_Warranty.Location = new System.Drawing.Point(12, 50);
            this.Label_Warranty.Name = "Label_Warranty";
            this.Label_Warranty.Size = new System.Drawing.Size(13, 13);
            this.Label_Warranty.TabIndex = 29;
            this.Label_Warranty.Text = "0";
            // 
            // tvData
            // 
            this.tvData.Dock = DockStyle.Fill;
            this.tvData.Location = new System.Drawing.Point(0, 0);
            this.tvData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tvData.Name = "tvData";
            this.tvData.RightToLeftLayout = true;
            this.tvData.Size = new System.Drawing.Size(709, 416);
            this.tvData.TabIndex = 21;
            this.tvData.Visible = false;
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = SystemColors.GradientActiveCaption;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(762, 462);
            this.Controls.Add(this.SplitContainer1);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.MenuStrip);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MDIParent1";
            this.RightToLeft = RightToLeft.Yes;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.TransparencyKey = SystemColors.GradientActiveCaption;
            this.WindowState = FormWindowState.Maximized;
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.SplitContainer1.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).EndInit();
            this.SplitContainer1.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

         public System.Windows.Forms.MenuStrip MenuStrip;
         public System.Windows.Forms.ToolStripMenuItem Services;
         public System.Windows.Forms.ToolStripMenuItem System_Activation_Menu;
         public System.Windows.Forms.ToolStripMenuItem Collection_Document_Extradition;

         public System.Windows.Forms.ToolStripMenuItem Collection_Document_Back;
         public System.Windows.Forms.ToolStripMenuItem Collection_Document_Add;
         public System.Windows.Forms.ToolStripMenuItem Collection_Document;
         public System.Windows.Forms.ToolStripMenuItem Collection_Document_Assignment;
         public System.Windows.Forms.ToolStripMenuItem Collection_Document_Notice;
         public System.Windows.Forms.ToolStripMenuItem Base_Information;
         public System.Windows.Forms.ToolStripMenuItem View;
         public System.Windows.Forms.ToolStripMenuItem View_Menu_Toolbox;
         public System.Windows.Forms.ToolStripMenuItem View_Menu_Subtitle;
         public System.Windows.Forms.ToolStripMenuItem Reports;
         public System.Windows.Forms.StatusStrip StatusStrip;
         public System.Windows.Forms.ToolStripStatusLabel Today_Date;
         public System.Windows.Forms.ToolStripMenuItem Exits;
         public System.Windows.Forms.ToolStripMenuItem Collection_Document_Reform;
         public System.Windows.Forms.ToolStripMenuItem Warranty_Document;
         public System.Windows.Forms.ToolStripMenuItem Warranty_Document_Add;
         public System.Windows.Forms.ToolStripMenuItem Warranty_Document_Refund;
         public System.Windows.Forms.ToolStripMenuItem Warranty_Document_Reform;
         public System.Windows.Forms.ToolStripMenuItem Payable;
         public System.Windows.Forms.ToolStripMenuItem Payable_Payment;
         public System.Windows.Forms.ToolStripMenuItem Payable_Deposits;
         public System.Windows.Forms.ToolStripMenuItem Payable_Wage;
         public System.Windows.Forms.ToolStripMenuItem Base_Information_Assets;
         public System.Windows.Forms.ToolStripMenuItem Accounting;
         public System.Windows.Forms.ToolStripMenuItem Assets;
         public System.Windows.Forms.ToolStripMenuItem Assets_Fixed;
         public System.Windows.Forms.ToolStripMenuItem Assets_Increase;
         public System.Windows.Forms.ToolStripMenuItem Assets_Decrease;
         public System.Windows.Forms.ToolStripMenuItem Assets_Movement;
         public System.Windows.Forms.ToolStripMenuItem Assets_Dismiss;
         public System.Windows.Forms.ToolStripMenuItem Assets_Revaluation;
         public System.Windows.Forms.ToolStripMenuItem Base_Information_Assets_Depreciation_Rate;
         public System.Windows.Forms.ToolStripMenuItem Base_Information_Assets_City;
         public System.Windows.Forms.ToolStripMenuItem Base_Information_Assets_Personnel;
         public System.Windows.Forms.ToolStripMenuItem Base_Information_Assets_Cost_Code;
         public System.Windows.Forms.ToolStripMenuItem Base_Information_Document;
         public System.Windows.Forms.ToolStripMenuItem Base_Information_Document_Recovery_Classification;
         public System.Windows.Forms.ToolStripMenuItem Base_Information_Warranty_Document_Classification;
         public System.Windows.Forms.ToolStripMenuItem Base_Information_Document_Customer;
         public System.Windows.Forms.ToolStripMenuItem Accounting_Add;
         public System.Windows.Forms.ToolStripMenuItem Accounting_View;
         public System.Windows.Forms.ToolStripMenuItem Accounting_Mechanized;
         public System.Windows.Forms.ToolStripMenuItem Assets_Calculate_Depreciation;
         public System.Windows.Forms.ToolStripMenuItem Assets_Consumable;
         public System.Windows.Forms.ToolStripMenuItem Base_Information_Accounting;
         public System.Windows.Forms.ToolStripMenuItem Base_Information_Accounting_Account_Tree;
         public System.Windows.Forms.ToolStripMenuItem Base_Information_Accounting_Detailed_Tree;
         public System.Windows.Forms.ToolStripMenuItem Base_Information_Assets_Date;
         public System.Windows.Forms.ToolStripMenuItem Warranty_Document_Extended;
         public System.Windows.Forms.ToolStripMenuItem Base_Information_Warehouse;
         public System.Windows.Forms.ToolStripMenuItem Base_Information_Warehouse_Units;
         public System.Windows.Forms.ToolStripMenuItem Base_Information_Warehouse_Sources;
         public System.Windows.Forms.ToolStripMenuItem Base_Information_Warehouse_Unit_Goods;
         public System.Windows.Forms.ToolStripMenuItem Base_Information_Warehouse_Grouping_Goods;
         public System.Windows.Forms.ToolStripMenuItem Base_Information_Warehouse_Collection_Goods;
         public System.Windows.Forms.ToolStripMenuItem Repair;
         public System.Windows.Forms.ToolStripMenuItem Warehouse;
         public System.Windows.Forms.ToolStripMenuItem Warehouse_Request_Buy_Goods;
         public System.Windows.Forms.ToolStripMenuItem Warehouse_Receipt_Remittance;
         public System.Windows.Forms.ToolStripMenuItem Warehouse_Receipt_Remittance_Direct;
         public System.Windows.Forms.ToolStripMenuItem Warehouse_Pricing;
         public System.Windows.Forms.ToolStripMenuItem Warehouse_Handling;
         public System.Windows.Forms.ToolStripMenuItem Warehouse_Handling_Tag;
         public System.Windows.Forms.ToolStripMenuItem Warehouse_First_Count;
         public System.Windows.Forms.ToolStripMenuItem Warehouse_Second_Count;
         public System.Windows.Forms.ToolStripMenuItem Warehouse_Final_Count;
         public System.Windows.Forms.ToolStripMenuItem Warehouse_Request_Goods;
         public System.Windows.Forms.ToolStripMenuItem Warehouse_Request_Buy;
         public System.Windows.Forms.ToolStripMenuItem Warehouse_Request_Services;
         public System.Windows.Forms.ToolStripMenuItem Warehouse_Receipt;
         public System.Windows.Forms.ToolStripMenuItem Warehouse_Remittance;
         public System.Windows.Forms.ToolStripMenuItem Base_Information_PayRoll;
         public System.Windows.Forms.ToolStripMenuItem Base_Information_PayRoll_Personal;
         public System.Windows.Forms.ToolStripMenuItem Base_Information_PayRoll_Employment;
         public System.Windows.Forms.ToolStripMenuItem Base_Information_PayRoll_Deductions_Legal;
         public System.Windows.Forms.ToolStripMenuItem Base_Information_PayRoll_Deductions_Diffrent;
         public System.Windows.Forms.ToolStripMenuItem Base_Information_PayRoll_Family;
         public System.Windows.Forms.ToolStripMenuItem PayRoll;
         public System.Windows.Forms.ToolStripMenuItem PayRoll_Add;
         public System.Windows.Forms.ToolStripMenuItem PayRoll_Attendance_Mechanized;
         public System.Windows.Forms.ToolStripMenuItem PayRoll_Attendance_Manual;
         public System.Windows.Forms.ToolStripMenuItem PayRoll_Base_Information;
         public System.Windows.Forms.ToolStripMenuItem PayRoll_Deductions;
         public System.Windows.Forms.ToolStripMenuItem PayRoll_Computing;
         public System.Windows.Forms.ToolStripMenuItem PayRoll_Computing_Difference;
         public System.Windows.Forms.ToolStripMenuItem Base_Information_PayRoll_Calandar;
         public System.Windows.Forms.ToolStripMenuItem PayRoll_Cure;
         public System.Windows.Forms.ToolStripStatusLabel Report;
         public System.Windows.Forms.ToolStripMenuItem System_Area_Menu;
         public System.Windows.Forms.ToolStripMenuItem System_Chang_User_Menu;
         public System.Windows.Forms.ToolStripStatusLabel N_Admin;
         public System.Windows.Forms.ToolStripMenuItem Base_Information_Assets_Plan_project;
         public System.Windows.Forms.ToolStripMenuItem Repair_Equipment;
         public System.Windows.Forms.ToolStripMenuItem Repair_Cost;
         public System.Windows.Forms.ToolStripMenuItem Base_Information_Repair;
         public System.Windows.Forms.ToolStripMenuItem Base_Information_Repair_Seating;
         public System.Windows.Forms.ToolStripMenuItem Base_Information_Repair_Energy;
         public System.Windows.Forms.ToolStripMenuItem Base_Information_Repair_Phase;
         public System.Windows.Forms.ToolStripMenuItem Base_Information_Repair_Kind_Stream;
         public System.Windows.Forms.ToolStripMenuItem Base_Information_Repair_Kind_Fuse;
         public System.Windows.Forms.ToolStripMenuItem Base_Information_Repair_Connector_Type;
         public System.Windows.Forms.ToolStripMenuItem View_Menu_Help;
         public System.Windows.Forms.ToolStripMenuItem Base_Information_Repair_Stop_Defect;
         public System.Windows.Forms.ToolStripMenuItem Assets_Management;
         public System.Windows.Forms.ToolStripMenuItem Warehouse_Receipt_Buy;
         public System.Windows.Forms.ToolStripMenuItem Warehouse_Receipt_Return;
         public System.Windows.Forms.ToolStripMenuItem Warehouse_Receipt_Loan;
         public System.Windows.Forms.ToolStripMenuItem View_Menu_Log;
         public System.Windows.Forms.ToolStripMenuItem Assets_Intangible;
         public System.Windows.Forms.ToolStripStatusLabel N_Fiscal_Year_Area;
         public System.Windows.Forms.ToolStripStatusLabel N_Department_Area;
         public System.Windows.Forms.ToolStripStatusLabel Description;
         public System.Windows.Forms.ToolStripMenuItem Base_Information_Document_Area;
         public System.Windows.Forms.ToolStripMenuItem Base_Information_Services;
         public System.Windows.Forms.ToolStripMenuItem Services_Sale_Managing;
         public System.Windows.Forms.ToolStripMenuItem Services_Order_Add;
         public System.Windows.Forms.ToolStripMenuItem Services_Seasonal_Buy_Sales;
         public System.Windows.Forms.ToolStripMenuItem Services_Seasonal_Buy;
         public System.Windows.Forms.ToolStripMenuItem Services_Seasonal_Sale;
         public System.Windows.Forms.ToolStripMenuItem Services_Seasonal_Contractor;
         public System.Windows.Forms.ToolStripMenuItem Services_Seasonal_Employer;
         public System.Windows.Forms.ToolStripMenuItem Services_Seasonal_Export;
         public System.Windows.Forms.ToolStripMenuItem Services_Seasonal_Importation;
         public System.Windows.Forms.ToolStripMenuItem Services_Seasonal_Contract_Work;
         public System.Windows.Forms.ToolStripMenuItem Services_Seasonal_Rent;
         public System.Windows.Forms.ToolStripMenuItem Services_Seasonal_Presell;
         public System.Windows.Forms.ToolStripMenuItem Base_Information_Services_Seasonal_Buy_Sales;
         public System.Windows.Forms.ToolStripMenuItem Base_Seasonal_Product_Type;
         public System.Windows.Forms.ToolStripMenuItem Base_Information_Services_Order;
         public System.Windows.Forms.ToolStripMenuItem Base_Information_Services_Order_Customer;
         public System.Windows.Forms.ToolStripMenuItem Base_Information_Services_Order_In_Services;
         public System.Windows.Forms.ToolStripMenuItem Base_Information_Services_Order_Opertor;
         public System.Windows.Forms.ToolStripMenuItem Base_Information_Services_Order_Out_Services;
         public System.Windows.Forms.ToolStripMenuItem Base_Information_Services_Order_Rate;
         public System.Windows.Forms.ToolStripMenuItem Warehouse_Receipt_Production;
         public System.Windows.Forms.ToolStripMenuItem Warehouse_Remittance_Use;
         public System.Windows.Forms.ToolStripMenuItem Warehouse_Remittance_Sell;
         public System.Windows.Forms.ToolStripMenuItem Collection_Document_Access;
         public System.Windows.Forms.ToolStripMenuItem Collection_Document_Edit_Access;
         public System.Windows.Forms.ToolStripMenuItem Collection_Document_Delete_Access;
         public System.Windows.Forms.ToolStripMenuItem Warranty_Document_Access;
         public System.Windows.Forms.ToolStripMenuItem Warranty_Document_Edit_Access;
         public System.Windows.Forms.ToolStripMenuItem Warranty_Document_Delete_Access;
         public System.Windows.Forms.ToolStripMenuItem Payable_Access;
         public System.Windows.Forms.ToolStripMenuItem Payable_Edit_Access;
         public System.Windows.Forms.ToolStripMenuItem Payable_Delete_Access;
         public System.Windows.Forms.ToolStripMenuItem Assets_Access;
         public System.Windows.Forms.ToolStripMenuItem Assets_Edit_Access;
         public System.Windows.Forms.ToolStripMenuItem Assets_Delete_Access;
         public System.Windows.Forms.ToolStripMenuItem Warehouse_Access;
         public System.Windows.Forms.ToolStripMenuItem Warehouse_Edit_Access;
         public System.Windows.Forms.ToolStripMenuItem Warehouse_Accounting_Access;
         public System.Windows.Forms.ToolStripMenuItem Warehouse_Delete_Access;
         public System.Windows.Forms.ToolStripMenuItem Accounting_Access;
         public System.Windows.Forms.ToolStripMenuItem Accounting_Edit_Access;
         public System.Windows.Forms.ToolStripMenuItem Accounting_Delete_Access;
         public System.Windows.Forms.ToolStripMenuItem Services_Access;
         public System.Windows.Forms.ToolStripMenuItem Services_Edit_Access;
         public System.Windows.Forms.ToolStripMenuItem Services_Delete_Access;
         public System.Windows.Forms.ToolStripMenuItem Repair_Access;
         public System.Windows.Forms.ToolStripMenuItem Repair_Edit_Access;
         public System.Windows.Forms.ToolStripMenuItem Repair_Delete_Access;
         public System.Windows.Forms.ToolStripMenuItem PayRoll_Access;
         public System.Windows.Forms.ToolStripMenuItem PayRoll_Edit_Access;
         public System.Windows.Forms.ToolStripMenuItem PayRoll_Delete_Access;
         public System.Windows.Forms.ToolStripMenuItem Base_Information_Accounting_Access;
         public System.Windows.Forms.ToolStripMenuItem Base_Information_Accounting_Edit_Access;
         public System.Windows.Forms.ToolStripMenuItem Base_Information_Accounting_Delete_Access;
         public System.Windows.Forms.ToolStripMenuItem Base_Information_PayRoll_Access;
         public System.Windows.Forms.ToolStripMenuItem Base_Information_PayRoll_Edit_Access;
         public System.Windows.Forms.ToolStripMenuItem Base_Information_PayRoll_Delete_Access;
         public System.Windows.Forms.ToolStripMenuItem Base_Information_Document_Access;
         public System.Windows.Forms.ToolStripMenuItem Base_Information_Document_Edit_Access;
         public System.Windows.Forms.ToolStripMenuItem Base_Information_Document_Delete_Access;
         public System.Windows.Forms.ToolStripMenuItem Base_Information_Assets_Access;
         public System.Windows.Forms.ToolStripMenuItem Base_Information_Assets_Edit_Access;
         public System.Windows.Forms.ToolStripMenuItem Base_Information_Assets_Delete_Access;
         public System.Windows.Forms.ToolStripMenuItem Base_Information_Warehouse_Access;
         public System.Windows.Forms.ToolStripMenuItem Base_Information_Warehouse_Edit_Access;
         public System.Windows.Forms.ToolStripMenuItem Base_Information_Warehouse_Delete_Access;
         public System.Windows.Forms.ToolStripMenuItem Base_Information_Repair_Access;
         public System.Windows.Forms.ToolStripMenuItem Base_Information_Repair_Edit_Access;
         public System.Windows.Forms.ToolStripMenuItem Base_Information_Repair_Delete_Access;
         public System.Windows.Forms.ToolStripMenuItem Base_Information_Services_Access;
         public System.Windows.Forms.ToolStripMenuItem Base_Information_Services_Edit_Access;
         public System.Windows.Forms.ToolStripMenuItem Base_Information_Services_Delete_Access;
         public System.Windows.Forms.ToolStripMenuItem Report_Warehouse;
         public System.Windows.Forms.ToolStripMenuItem Report_Payable;
         public System.Windows.Forms.ToolStripMenuItem Report_Estate;
         public System.Windows.Forms.ToolStripMenuItem Report_Collection_Document;
         public System.Windows.Forms.ToolStripMenuItem Report_Warranty_Document;
         public System.Windows.Forms.ToolStripMenuItem Report_Warranty_Document_No_Date;
         public System.Windows.Forms.ToolStripMenuItem Report_Warranty_Document_Extended_Date;
         public System.Windows.Forms.ToolStripMenuItem Report_Warranty_Document_Refund_Date;
         public System.Windows.Forms.ToolStripMenuItem Report_Warranty_Document_Due_Date;
         public System.Windows.Forms.ToolStripMenuItem Report_Warranty_Document_Date;
         public System.Windows.Forms.ToolStripMenuItem Report_Collection_Document_Add;
         public System.Windows.Forms.ToolStripMenuItem Report_Collection_Document_Due_Date;
         public System.Windows.Forms.ToolStripMenuItem Report_Collection_Document_Assignment;
         public System.Windows.Forms.ToolStripMenuItem Report_Collection_Document_Notice;
         public System.Windows.Forms.ToolStripMenuItem Report_Collection_Document_Back;
         public System.Windows.Forms.ToolStripMenuItem Report_Collection_Document_Refund_Date;
         public System.Windows.Forms.ToolStripMenuItem Report_Collection_Document_Receipt;
         public System.Windows.Forms.ToolStripMenuItem Report_Estate_Responsible;
         public System.Windows.Forms.ToolStripMenuItem Report_Estate_Consumable_Delivering;
         public System.Windows.Forms.ToolStripMenuItem Report_Estate_Delivering;
         public System.Windows.Forms.ToolStripMenuItem Report_Consumable_Delivering;
         public System.Windows.Forms.ToolStripMenuItem Report_Estate_Accountants;
         public System.Windows.Forms.ToolStripMenuItem Report_Estate_Facial;
         public System.Windows.Forms.ToolStripMenuItem Report_Estate_Original_Code;
         public System.Windows.Forms.ToolStripMenuItem Report_Estate_Cost_Code;
         public System.Windows.Forms.ToolStripMenuItem Report_Estate_Cost_Original;
         public System.Windows.Forms.ToolStripMenuItem Report_Estate_Original_Cost;
         public System.Windows.Forms.ToolStripMenuItem Report_Estate_Original_Cost_City;
         public System.Windows.Forms.ToolStripMenuItem Report_Estate_Decrease;
         public System.Windows.Forms.ToolStripMenuItem Report_Estate_Dismiss;
         public System.Windows.Forms.ToolStripMenuItem Report_Estate_Document_Cost;
         public System.Windows.Forms.ToolStripMenuItem Report_Estate_Document_Original;
         public System.Windows.Forms.ToolStripMenuItem Report_Estate_Document_Dismiss;
         public System.Windows.Forms.ToolStripMenuItem Report_Payable_Turnover;
         public System.Windows.Forms.ToolStripMenuItem Report_Payable_Checked_Out;
         public System.Windows.Forms.ToolStripMenuItem Report_Payable_Deposits;
         public System.Windows.Forms.ToolStripMenuItem Report_Payable_Wage;
         public System.Windows.Forms.ToolStripMenuItem Report_Warehouse_Number;
         public System.Windows.Forms.ToolStripMenuItem Report_Warehouse_Cardx;
         public System.Windows.Forms.ToolStripMenuItem Report_Warehouse_Turnover;
         public System.Windows.Forms.ToolStripMenuItem Report_Warehouse_Inventory;
         public System.Windows.Forms.ToolStripMenuItem Report_Warehouse_Accounting;
         public System.Windows.Forms.ToolStripMenuItem Report_Warehouse_Accounting_Cardx;
         public System.Windows.Forms.ToolStripMenuItem Report_Warehouse_Accounting_Turnover;
         public System.Windows.Forms.ToolStripMenuItem Report_Warehouse_Accounting_Inventory;
         public System.Windows.Forms.ToolStripMenuItem Report_Warehouse_Handling;
         public System.Windows.Forms.ToolStripMenuItem Report_Warehouse_Handling_One_Counts;
         public System.Windows.Forms.ToolStripMenuItem Report_Warehouse_Handling_Two_Counts;
         public System.Windows.Forms.ToolStripMenuItem Report_Warehouse_Handling_Third_Counts;
         public System.Windows.Forms.ToolStripStatusLabel Information;
         public System.Windows.Forms.ToolStripMenuItem Report_Services;
         public System.Windows.Forms.ToolStripMenuItem Report_Accounting;
         public System.Windows.Forms.ToolStripMenuItem Report_Repair;
         public System.Windows.Forms.ToolStripMenuItem Report_PayRoll;
         public System.Windows.Forms.ToolStripMenuItem Warehouse_Opening;
         public System.Windows.Forms.ToolStripMenuItem Base_Information_Document_Bank;
         public System.Windows.Forms.ToolStripMenuItem System_sms;
         public System.Windows.Forms.ToolStripMenuItem Report_Accounting_Note_Book;
         public System.Windows.Forms.ToolStripMenuItem Report_Accounting_Align;
         public System.Windows.Forms.ToolStripMenuItem Report_Accounting_Four_Column_Align;
         public System.Windows.Forms.ToolStripMenuItem Report_Accounting_Reports;
         public System.Windows.Forms.ToolStripMenuItem Report_Accounting_Analysis;
         public System.Windows.Forms.ToolStripMenuItem Report_Accounting_Details_Four_Column_Align;
         public System.Windows.Forms.ToolStripMenuItem Report_Accounting_Eight_Column_Align;
         public System.Windows.Forms.ToolStripMenuItem Report_Accounting_Details_Eight_Column_Align;
         public System.Windows.Forms.ToolStripMenuItem Report_Accounting_Account_Note_Book;
         public System.Windows.Forms.ToolStripMenuItem Report_Accounting_Details_Note_One_Book;
         public System.Windows.Forms.ToolStripMenuItem Report_Accounting_Details_Note_Two_Book;
         public System.Windows.Forms.ToolStripMenuItem Report_Accounting_Details_Note_Three_Book;
         public System.Windows.Forms.ToolStripMenuItem Report_Accounting_Details_Note_Four_Book;
         public System.Windows.Forms.ToolStripMenuItem Report_Accounting_Details_Note_Five_Book;
         public System.Windows.Forms.ToolStripMenuItem System;

         public System.Windows.Forms.ToolStripMenuItem Report_Accounting_Details;
         public System.Windows.Forms.SplitContainer SplitContainer1;
         public System.Windows.Forms.TreeView tvData;
         public System.Windows.Forms.GroupBox GroupBox1;
         public System.Windows.Forms.Label Label_Warranty;
         public System.Windows.Forms.Label Label1;
         public System.Windows.Forms.PictureBox PictureBox2;
         public System.Windows.Forms.Label Label3;
         public System.Windows.Forms.Label Label_Collection;
         public System.Windows.Forms.PictureBox PictureBox1;
         public System.Windows.Forms.Label Label4;
         public System.Windows.Forms.Label Label5;
         public System.Windows.Forms.PictureBox PictureBox3;
         public System.Windows.Forms.ToolStripMenuItem System_User_Menu;
        public ToolStripStatusLabel ID;
         public ToolStripMenuItem Systems;
        public ToolStripStatusLabel I_N;
        public ToolStripStatusLabel N_Id_Area;
        public ToolStripStatusLabel N_Company_Area;
    }
}