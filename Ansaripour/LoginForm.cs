//====================================================================================================
//The Free Edition of Instant C# limits conversion output to 100 lines per file.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-instant-csharp.html
//====================================================================================================

//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;

using static System.IO.Directory;

namespace Ansaripour
{
    public partial class LoginForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private string Id;
        private string Host;
        private string f_serch;
        private string f_select; //تابع متغیر فرمول جستجو
        private void Test_Conection()
        {
            try
            {
                DataSet HostName = data.PDataset("select * from Security_Users where Host_Name=N'" + System.Net.Dns.GetHostName() + "'");
                foreach (DataRow Dr in HostName.Tables[0].Rows)
                {
                    if (!Convert.IsDBNull(Dr[0]))
                    {
                        string[] dtVal = Dr["Host_String"].ToString().Split('/');
                        Check_Pass.Checked = dtVal[2];
                        if (dtVal[2] == "True")
                        {
                            UsernameTextBox.Text = Convert.ToString(Dr["username"]);
                            Host = Convert.ToString(Dr["username"]);
                            DataSet serch = data.PDataset("select * from Pictures where Name_Data_Picture=N'" + dtVal[0] + "' and Id_Data_Picture=N'" + dtVal[1] + "'");
                            foreach (DataRow Drr in serch.Tables[0].Rows)
                            {
                                if (!Convert.IsDBNull(Drr[0]))
                                {
                                    P_Pic.Image = (System.Drawing.Image)data.ImageFromBase64String(Convert.ToString(Drr["Picture"]));
                                }
                            }
                        }
                    }
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                modMessage.ShowMessage("اشکال در اتصال با بانک اطلاعاتی", ex.Message + "\r\n", frmMessage.mIcon.mTools, frmMessage.mButtons.mAccept);
                this.Close();
            }
            catch (Exception ex)
            {
                modMessage.ShowMessage("مشکل در اجرای برنامه", "مدیر سیستم را مطلع سازید", frmMessage.mIcon.mTools, frmMessage.mButtons.mAccept);
            }
            finally
            {
            }
        }
        private void AutocomplateCustomSource()
        {
            DataSet test = data.PDataset("Select username From Security_Users ");
            foreach (DataRow Dr in test.Tables[0].Rows)
            {
                UsernameTextBox.AutoCompleteCustomSource.Add(Convert.ToString(Dr["USERNAME"]));
            }
        }
        private void Cancel_Click(System.Object sender, System.EventArgs e)
        {
            this.Close();
        }
        private void LoginForm1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
        private void LoginForm1_Load(System.Object sender, System.EventArgs e)
        {
            //تغییر زبان صفحه کلید به فارسی
            System.Globalization.CultureInfo locInputType = new System.Globalization.CultureInfo("FA-IR");
            Application.CurrentInputLanguage = InputLanguage.FromCulture(locInputType);
            Test_Conection();
            UsernameTextBox.TextAlign = HorizontalAlignment.Left;
            UsernameTextBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            UsernameTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutocomplateCustomSource();
            //Dim test As DataSet = PDataset("Select username From Security_Users ")
            //For Each Dr As DataRow In test.Tables(0).Rows
            //    TextBox1.AutoCompleteCustomSource.Add(Dr("USERNAME"))
            //Next
            //TextBox1.AutoCompleteMode = AutoCompleteMode.Suggest
            //TextBox1.AutoCompleteSource = AutoCompleteSource.CustomSource
        }
        private void OK_Click(System.Object sender, System.EventArgs e)
        {
            if (UsernameTextBox.Text.Length == 0)
            {
                UsernameTextBox.Focus();
                return;
            }
            if (PasswordTextBox.Text.Length == 0)
            {
                PasswordTextBox.Focus();
                return;
            }
            if (UsernameTextBox.Text == "Admin" && PasswordTextBox.Text == "1311")
            {
                this.Hide();
                MDIParent1 mdiparent = new MDIParent1();
                mdiparent.Id.Text = "1311";
                MDIParent1.DefaultInstance.I_N.Text = "مدیر سیستم";
                MDIParent1.DefaultInstance.N_Id_Area.Text = "مرکزی";
                MDIParent1.DefaultInstance.N_Company_Area.Text = "بدون تمرکز";
                MDIParent1.DefaultInstance.N_Admin.Text = "True";
                MDIParent1.DefaultInstance.Description.Text = "";
                //------(خدمات)----------------------------------------------------------------------------------------------------------------
                MDIParent1.DefaultInstance.Services.Visible = true;
                MDIParent1.DefaultInstance.Services_Sale_Managing.Visible = true;
                MDIParent1.DefaultInstance.Services_Order_Add.Visible = true;
                MDIParent1.DefaultInstance.Services_Seasonal_Buy_Sales.Visible = true;
                MDIParent1.DefaultInstance.Services_Seasonal_Buy.Visible = true;
                MDIParent1.DefaultInstance.Services_Seasonal_Sale.Visible = true;
                MDIParent1.DefaultInstance.Services_Seasonal_Contractor.Visible = true;
                MDIParent1.DefaultInstance.Services_Seasonal_Employer.Visible = true;
                MDIParent1.DefaultInstance.Services_Seasonal_Export.Visible = true;
                MDIParent1.DefaultInstance.Services_Seasonal_Importation.Visible = true;
                MDIParent1.DefaultInstance.Services_Seasonal_Contract_Work.Visible = true;
                MDIParent1.DefaultInstance.Services_Seasonal_Rent.Visible = true;
                MDIParent1.DefaultInstance.Services_Seasonal_Presell.Visible = true;
                MDIParent1.DefaultInstance.Services_Edit_Access.Tag = 1;
                MDIParent1.DefaultInstance.Services_Delete_Access.Tag = 1;
                //------(حسابداری)----------------------------------------------------------------------------------------------------------------
                MDIParent1.DefaultInstance.Accounting.Visible = true;
                MDIParent1.DefaultInstance.Accounting_Add.Visible = true;
                MDIParent1.DefaultInstance.Accounting_View.Visible = true;
                MDIParent1.DefaultInstance.Accounting_Mechanized.Visible = true;
                MDIParent1.DefaultInstance.Accounting_Edit_Access.Tag = 1;
                MDIParent1.DefaultInstance.Accounting_Delete_Access.Tag = 1;
                //------(تعمیر و نگهداری)----------------------------------------------------------------------------------------------------------------
                MDIParent1.DefaultInstance.Repair.Visible = true;
                MDIParent1.DefaultInstance.Repair_Equipment.Visible = true;
                MDIParent1.DefaultInstance.Repair_Cost.Visible = true;
                MDIParent1.DefaultInstance.Repair_Edit_Access.Tag = 1;
                MDIParent1.DefaultInstance.Repair_Delete_Access.Tag = 1;
                //------(حقوق و دستمزد)----------------------------------------------------------------------------------------------------------------
                MDIParent1.PayRoll.Visible = true;
                MDIParent1.PayRoll_Add.Visible = true;
                MDIParent1.PayRoll_Attendance_Mechanized.Visible = true;
                MDIParent1.PayRoll_Attendance_Manual.Visible = true;
                MDIParent1.PayRoll_Base_Information.Visible = true;
                MDIParent1.PayRoll_Deductions.Visible = true;
                MDIParent1.PayRoll_Cure.Visible = true;
                MDIParent1.PayRoll_Computing.Visible = true;
                MDIParent1.PayRoll_Computing_Difference.Visible = true;
                MDIParent1.PayRoll_Edit_Access.Tag = 1;
                MDIParent1.PayRoll_Delete_Access.Tag = 1;
                //------(انبار)----------------------------------------------------------------------------------------------------------------
                MDIParent1.Warehouse.Visible = true;
                MDIParent1.Warehouse_Request_Buy_Goods.Visible = true;
                MDIParent1.Warehouse_Request_Goods.Visible = true;
                MDIParent1.Warehouse_Request_Buy.Visible = true;
                MDIParent1.Warehouse_Request_Services.Visible = true;
                MDIParent1.Warehouse_Receipt_Remittance.Visible = true;
                MDIParent1.Warehouse_Receipt.Visible = true;
                MDIParent1.Warehouse_Receipt_Buy.Visible = true;
                MDIParent1.Warehouse_Receipt_Return.Visible = true;
                MDIParent1.Warehouse_Receipt_Loan.Visible = true;
                MDIParent1.Warehouse_Receipt_Production.Visible = true;
                MDIParent1.Warehouse_Opening.Visible = true;
                MDIParent1.Warehouse_Remittance.Visible = true;
                MDIParent1.Warehouse_Remittance_Use.Visible = true;
                MDIParent1.Warehouse_Remittance_Sell.Visible = true;
                MDIParent1.Warehouse_Receipt_Remittance_Direct.Visible = true;
                MDIParent1.Warehouse_Pricing.Visible = true;
                MDIParent1.Warehouse_Handling.Visible = true;
                MDIParent1.Warehouse_Handling_Tag.Visible = true;
                MDIParent1.Warehouse_First_Count.Visible = true;
                MDIParent1.Warehouse_Second_Count.Visible = true;
                MDIParent1.Warehouse_Final_Count.Visible = true;
                MDIParent1.Warehouse_Edit_Access.Tag = 1;
                MDIParent1.Warehouse_Accounting_Access.Tag = 1;
                MDIParent1.Warehouse_Delete_Access.Tag = 1;
                //------(اموال)----------------------------------------------------------------------------------------------------------------
                MDIParent1.Assets.Visible = true;
                MDIParent1.Assets_Fixed.Visible = true;
                MDIParent1.Assets_Intangible.Visible = true;
                MDIParent1.Assets_Consumable.Visible = true;
                MDIParent1.Assets_Increase.Visible = true;
                MDIParent1.Assets_Decrease.Visible = true;
                MDIParent1.Assets_Movement.Visible = true;
                MDIParent1.Assets_Dismiss.Visible = true;
                MDIParent1.Assets_Revaluation.Visible = true;
                MDIParent1.Assets_Calculate_Depreciation.Visible = true;
                MDIParent1.Assets_Management.Visible = true;
                MDIParent1.Assets_Edit_Access.Tag = 1;
                MDIParent1.Assets_Delete_Access.Tag = 1;
                //------(چک بانک)----------------------------------------------------------------------------------------------------------------
                MDIParent1.Payable.Visible = true;
                MDIParent1.Payable_Payment.Visible = true;
                MDIParent1.Payable_Deposits.Visible = true;
                MDIParent1.Payable_Wage.Visible = true;
                MDIParent1.PayRoll_Edit_Access.Tag = 1;
                MDIParent1.PayRoll_Delete_Access.Tag = 1;
                //------(اسناد وصولی)----------------------------------------------------------------------------------------------------------------
                MDIParent1.Collection_Document.Visible = true;
                MDIParent1.Collection_Document_Add.Visible = true;
                MDIParent1.Collection_Document_Assignment.Visible = true;
                MDIParent1.Collection_Document_Notice.Visible = true;
                MDIParent1.Collection_Document_Back.Visible = true;
                MDIParent1.Collection_Document_Extradition.Visible = true;
                MDIParent1.Collection_Document_Reform.Visible = true;
                MDIParent1.Collection_Document_Edit_Access.Tag = 1;
                MDIParent1.Collection_Document_Delete_Access.Tag = 1;
                //====================================================================================================
                //The Free Edition of Instant C# limits conversion output to 100 lines per snippet.

                //To purchase the Premium Edition, visit our website:
                //https://www.tangiblesoftwaresolutions.com/order/order-instant-csharp.html
                //====================================================================================================

                //------(اسناد ضمانتی)----------------------------------------------------------------------------------------------------------------
                MDIParent1.Warranty_Document.Visible = true;
                MDIParent1.Warranty_Document_Add.Visible = true;
                MDIParent1.Warranty_Document_Extended.Visible = true;
                MDIParent1.Warranty_Document_Refund.Visible = true;
                MDIParent1.Warranty_Document_Reform.Visible = true;
                MDIParent1.Warranty_Document_Edit_Access.Tag = 1;
                MDIParent1.Warranty_Document_Delete_Access.Tag = 1;
                //------(اطلاعات پایه)----------------------------------------------------------------------------------------------------------------
                MDIParent1.Base_Information.Visible = true;
                //------(اطلاعات پایه خدمات)----------------------------------------------------------------------------------------------------------------
                MDIParent1.Base_Information_Services.Visible = true;
                MDIParent1.Base_Information_Services_Seasonal_Buy_Sales.Visible = true;
                MDIParent1.Base_Seasonal_Product_Type.Visible = true;
                MDIParent1.Base_Information_Services_Order.Visible = true;
                MDIParent1.Base_Information_Services_Order_Customer.Visible = true;
                MDIParent1.Base_Information_Services_Order_In_Services.Visible = true;
                MDIParent1.Base_Information_Services_Order_Out_Services.Visible = true;
                MDIParent1.Base_Information_Services_Order_Opertor.Visible = true;
                MDIParent1.Base_Information_Services_Order_Rate.Visible = true;
                MDIParent1.Base_Information_Services_Edit_Access.Tag = 1;
                MDIParent1.Base_Information_Services_Delete_Access.Tag = 1;
                //------(اطلاعات حسابداری)----------------------------------------------------------------------------------------------------------------
                MDIParent1.Base_Information_Accounting.Visible = true;
                MDIParent1.Base_Information_Accounting_Account_Tree.Visible = true;
                MDIParent1.Base_Information_Accounting_Detailed_Tree.Visible = true;
                MDIParent1.Base_Information_Services_Edit_Access.Tag = 1;
                MDIParent1.Base_Information_Services_Delete_Access.Tag = 1;
                //------(اطلاعات پایه تعمیرو نگهداری)----------------------------------------------------------------------------------------------------------------
                MDIParent1.Base_Information_Repair.Visible = true;
                MDIParent1.Base_Information_Repair_Seating.Visible = true;
                MDIParent1.Base_Information_Repair_Energy.Visible = true;
                MDIParent1.Base_Information_Repair_Phase.Visible = true;
                MDIParent1.Base_Information_Repair_Kind_Stream.Visible = true;
                MDIParent1.Base_Information_Repair_Kind_Fuse.Visible = true;
                MDIParent1.Base_Information_Repair_Connector_Type.Visible = true;
                MDIParent1.Base_Information_Repair_Stop_Defect.Visible = true;
                MDIParent1.Base_Information_Repair_Edit_Access.Tag = 1;
                MDIParent1.Base_Information_Repair_Delete_Access.Tag = 1;
                //------(اطلاعات پایه حقوق)----------------------------------------------------------------------------------------------------------------
                MDIParent1.Base_Information_PayRoll.Visible = true;
                MDIParent1.Base_Information_PayRoll_Personal.Visible = true;
                MDIParent1.Base_Information_PayRoll_Employment.Visible = true;
                MDIParent1.Base_Information_PayRoll_Deductions_Legal.Visible = true;
                MDIParent1.Base_Information_PayRoll_Deductions_Diffrent.Visible = true;
                MDIParent1.Base_Information_PayRoll_Family.Visible = true;
                MDIParent1.Base_Information_PayRoll_Calandar.Visible = true;
                MDIParent1.Base_Information_Accounting_Edit_Access.Tag = 1;
                MDIParent1.Base_Information_Accounting_Delete_Access.Tag = 1;
                //------(اطلاعات پایه اسناد)----------------------------------------------------------------------------------------------------------------
                MDIParent1.Base_Information_Document.Visible = true;
                MDIParent1.Base_Information_Document_Bank.Visible = true;
                MDIParent1.Base_Information_Document_Recovery_Classification.Visible = true;
                MDIParent1.Base_Information_Warranty_Document_Classification.Visible = true;
                MDIParent1.Base_Information_Document_Customer.Visible = true;
                MDIParent1.Base_Information_Document_Area.Visible = true;
                MDIParent1.Base_Information_Document_Edit_Access.Tag = 1;
                MDIParent1.Base_Information_Document_Delete_Access.Tag = 1;
                //------(اطلاعات پایه اموال)----------------------------------------------------------------------------------------------------------------
                MDIParent1.Base_Information_Assets.Visible = true;
                MDIParent1.Base_Information_Assets_Depreciation_Rate.Visible = true;
                MDIParent1.Base_Information_Assets_Plan_project.Visible = true;
                MDIParent1.Base_Information_Assets_City.Visible = true;
                MDIParent1.Base_Information_Assets_Personnel.Visible = true;
                MDIParent1.Base_Information_Assets_Cost_Code.Visible = true;
                MDIParent1.Base_Information_Assets_Date.Visible = true;
                MDIParent1.Base_Information_Assets_Edit_Access.Tag = 1;
                MDIParent1.Base_Information_Assets_Delete_Access.Tag = 1;
                //------(اطلاعات پایه انبار)----------------------------------------------------------------------------------------------------------------
                MDIParent1.Base_Information_Warehouse.Visible = true;
                MDIParent1.Base_Information_Warehouse_Units.Visible = true;
                MDIParent1.Base_Information_Warehouse_Sources.Visible = true;
                MDIParent1.Base_Information_Warehouse_Unit_Goods.Visible = true;
                MDIParent1.Base_Information_Warehouse_Grouping_Goods.Visible = true;
                MDIParent1.Base_Information_Warehouse_Collection_Goods.Visible = true;
                MDIParent1.Base_Information_Warehouse_Edit_Access.Tag = 1;
                MDIParent1.Base_Information_Warehouse_Delete_Access.Tag = 1;
                //------(نمایش)----------------------------------------------------------------------------------------------------------------
                MDIParent1.View.Visible = true;
                MDIParent1.View_Menu_Toolbox.Visible = true;
                MDIParent1.View_Menu_Subtitle.Visible = true;
                MDIParent1.View_Menu_Help.Visible = true;
                MDIParent1.View_Menu_Log.Visible = true;
                //------(گزارشات)----------------------------------------------------------------------------------------------------------------
                MDIParent1.Reports.Visible = true;
                MDIParent1.Reports.Tag = 1;
                //------(گزارشات حسابداری)----------------------------------------------------------------------------------------------------------------
                MDIParent1.Report_Accounting.Tag = 1;
                MDIParent1.Report_Accounting_Note_Book.Tag = 1;
                MDIParent1.Report_Accounting_Account_Note_Book.Tag = 1;
                MDIParent1.Report_Accounting_Details_Note_One_Book.Tag = 1;
                MDIParent1.Report_Accounting_Details_Note_Two_Book.Tag = 1;
                MDIParent1.Report_Accounting_Details_Note_Three_Book.Tag = 1;
                MDIParent1.Report_Accounting_Details_Note_Four_Book.Tag = 1;
                MDIParent1.Report_Accounting_Details_Note_Five_Book.Tag = 1;
                MDIParent1.Report_Accounting_Align.Tag = 1;
                MDIParent1.Report_Accounting_Four_Column_Align.Tag = 1;
                MDIParent1.Report_Accounting_Details_Four_Column_Align.Tag = 1;
                MDIParent1.Report_Accounting_Eight_Column_Align.Tag = 1;
                MDIParent1.Report_Accounting_Details_Eight_Column_Align.Tag = 1;
                MDIParent1.Report_Accounting_Reports.Tag = 1;
                MDIParent1.Report_Accounting_Details.Tag = 1;
                MDIParent1.Report_Accounting_Analysis.Tag = 1;
                //------(گزارشات انبار)----------------------------------------------------------------------------------------------------------------
                MDIParent1.Report_Warehouse.Tag = 1;
                MDIParent1.Report_Warehouse_Number.Tag = 1;
                MDIParent1.Report_Warehouse_Cardx.Tag = 1;
                MDIParent1.Report_Warehouse_Turnover.Tag = 1;
                MDIParent1.Report_Warehouse_Inventory.Tag = 1;
                MDIParent1.Report_Warehouse_Accounting.Tag = 1;
                MDIParent1.Report_Warehouse_Accounting_Cardx.Tag = 1;
                MDIParent1.Report_Warehouse_Accounting_Turnover.Tag = 1;
                MDIParent1.Report_Warehouse_Accounting_Inventory.Tag = 1;
                MDIParent1.Report_Warehouse.Tag = 1;
                MDIParent1.Report_Warehouse_Number.Tag = 1;
                MDIParent1.Report_Warehouse_Cardx.Tag = 1;
                MDIParent1.Report_Warehouse_Turnover.Tag = 1;
                MDIParent1.Report_Warehouse_Inventory.Tag = 1;
                MDIParent1.Report_Warehouse_Accounting.Tag = 1;
                MDIParent1.Report_Warehouse_Accounting_Cardx.Tag = 1;
                MDIParent1.Report_Warehouse_Accounting_Turnover.Tag = 1;
                MDIParent1.Report_Warehouse_Accounting_Inventory.Tag = 1;
                MDIParent1.Report_Warehouse_Handling.Tag = 1;
                MDIParent1.Report_Warehouse_Handling_One_Counts.Tag = 1;
                MDIParent1.Report_Warehouse_Handling_Two_Counts.Tag = 1;
                MDIParent1.Report_Warehouse_Handling_Third_Counts.Tag = 1;
                //------(گزارشات ثبت چک بانک)----------------------------------------------------------------------------------------------------------------
                MDIParent1.Report_Payable.Tag = 1;
                MDIParent1.Report_Payable_Turnover.Tag = 1;
                MDIParent1.Report_Payable_Checked_Out.Tag = 1;
                MDIParent1.Report_Payable_Deposits.Tag = 1;
                MDIParent1.Report_Payable_Wage.Tag = 1;
                //------(گزارشات اموال و دارائی های ثابت)----------------------------------------------------------------------------------------------------------------
                MDIParent1.Report_Estate.Tag = 1;
                MDIParent1.Report_Estate_Responsible.Tag = 1;
                MDIParent1.Report_Estate_Consumable_Delivering.Tag = 1;
                MDIParent1.Report_Estate_Delivering.Tag = 1;
                MDIParent1.Report_Consumable_Delivering.Tag = 1;
                MDIParent1.Report_Estate_Accountants.Tag = 1;
                MDIParent1.Report_Estate_Facial.Tag = 1;
                MDIParent1.Report_Estate_Original_Code.Tag = 1;
                MDIParent1.Report_Estate_Cost_Code.Tag = 1;
                MDIParent1.Report_Estate_Cost_Original.Tag = 1;
                MDIParent1.Report_Estate_Original_Cost.Tag = 1;
                MDIParent1.Report_Estate_Original_Cost_City.Tag = 1;
                MDIParent1.Report_Estate_Decrease.Tag = 1;
                MDIParent1.Report_Estate_Dismiss.Tag = 1;
                MDIParent1.Report_Estate_Document_Cost.Tag = 1;
                MDIParent1.Report_Estate_Document_Original.Tag = 1;
                MDIParent1.Report_Estate_Document_Dismiss.Tag = 1;
                //------(گزارشات اسناد وصولی)----------------------------------------------------------------------------------------------------------------
                MDIParent1.Report_Collection_Document.Tag = 1;
                MDIParent1.Report_Collection_Document_Add.Tag = 1;
                MDIParent1.Report_Collection_Document_Due_Date.Tag = 1;
                MDIParent1.Report_Collection_Document_Assignment.Tag = 1;
                MDIParent1.Report_Collection_Document_Notice.Tag = 1;
                MDIParent1.Report_Collection_Document_Back.Tag = 1;
                MDIParent1.Report_Collection_Document_Refund_Date.Tag = 1;
                MDIParent1.Report_Collection_Document_Receipt.Tag = 1;
                //------(گزارشات اسناد ضمانتی)----------------------------------------------------------------------------------------------------------------
                MDIParent1.Report_Warranty_Document.Tag = 1;
                MDIParent1.Report_Warranty_Document_No_Date.Tag = 1;
                MDIParent1.Report_Warranty_Document_Extended_Date.Tag = 1;
                MDIParent1.Report_Warranty_Document_Refund_Date.Tag = 1;
                MDIParent1.Report_Warranty_Document_Due_Date.Tag = 1;
                MDIParent1.Report_Warranty_Document_Date.Tag = 1;
                //------(سیستم)----------------------------------------------------------------------------------------------------------------
                MDIParent1.Systems.Visible = true;
                MDIParent1.System_User_Menu.Visible = true;
                MDIParent1.System_Area_Menu.Visible = true;
                MDIParent1.System_Activation_Menu.Visible = true;
                MDIParent1.System_Chang_User_Menu.Visible = true;
                MDIParent1.System_sms.Visible = true;
                //--------------------------------------------------------------------------------------------------------------------------------
                //====================================================================================================
                //The Free Edition of Instant C# limits conversion output to 100 lines per snippet.

                //To purchase the Premium Edition, visit our website:
                //https://www.tangiblesoftwaresolutions.com/order/order-instant-csharp.html
                //====================================================================================================

                using System;

                string strReportPath = GetCurrentDirectory();
                if (strReportPath.Substring(strReportPath.Length - 9) == "bin\\Debug")
                {
                    MDIParent1.Report.Text = strReportPath.Substring(0, strReportPath.Length - 10);
                }
                MDIParent1.Text = " سیستم مکانیزه الماس" + " " + this.Text;
                MDIParent1.Show();
            }
            else
            {
                DataSet Security = PDataset("select A.*, B.* , C.* from Security_Users AS A LEFT OUTER JOIN Area AS C ON A.Area = C.Id_Area LEFT OUTER JOIN Security_Access AS B ON A.Id = B.User_Access where username=N'" + UsernameTextBox.Text + "' and password = N'" + PasswordTextBox.Text + "' ");
                if (Security.Tables(0).Rows.Count == 0)
                {
                    ShowMessage("ورود غیر مجاز", "در وارد کردن کلمه عبور و کاربری خود دقت نمائید ", frmMessage.mIcon.mStop, frmMessage.mButtons.mAccept);
                    PasswordTextBox.Text = "";
                    PasswordTextBox.Focus();
                }
                else
                {
                    foreach (DataRow Dr in Security.Tables(0).Rows)
                    {
                        if (Convert.IsDBNull(Dr["Company_Area"]))
                        {
                            ShowMessage("اخطار", "  تعاریف بخش کاربر در بانک اطلاعاتی نمی باشد", frmMessage.mIcon.mStop, frmMessage.mButtons.mAccept);
                            return;
                        }
                        else
                        {
                            this.Hide();
                            MDIParent1.ID.Text = Convert.ToString(Dr["ID"]);
                            Id = Dr["ID"];
                            MDIParent1.I_N.Text = Convert.ToString(Dr["username"]);
                            MDIParent1.N_Id_Area.Text = Convert.ToString(Dr["Area"]);
                            MDIParent1.N_Company_Area.Text = Convert.ToString(Dr["Company_Area"]);
                            MDIParent1.N_Department_Area.Text = Convert.ToString(Dr["Department_Area"]);
                            MDIParent1.N_Fiscal_Year_Area.Text = Convert.ToString(Dr["Fiscal_Year_Area"]);
                            MDIParent1.Description.Text = Convert.ToString(Dr["Description"]);
                            MDIParent1.N_Admin.Text = Convert.ToString(Dr["Admin"]);
                            if (!Convert.IsDBNull(Dr["Name_Access"]))
                            {
                                //------(خدمات)----------------------------------------------------------------------------------------------------------------
                                if (Convert.ToString(Dr["Name_Access"]) == MDIParent1.Services.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    MDIParent1.Services.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == MDIParent1.Services_Sale_Managing.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    MDIParent1.Services_Sale_Managing.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == MDIParent1.Services_Order_Add.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    MDIParent1.Services_Order_Add.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == MDIParent1.Services_Seasonal_Buy_Sales.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    MDIParent1.Services_Seasonal_Buy_Sales.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == MDIParent1.Services_Seasonal_Buy.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    MDIParent1.Services_Seasonal_Buy.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == MDIParent1.Services_Seasonal_Sale.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    MDIParent1.Services_Seasonal_Sale.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == MDIParent1.Services_Seasonal_Contractor.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    MDIParent1.Services_Seasonal_Contractor.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == MDIParent1.Services_Seasonal_Employer.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    MDIParent1.Services_Seasonal_Employer.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == MDIParent1.Services_Seasonal_Export.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    MDIParent1.Services_Seasonal_Export.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == MDIParent1.Services_Seasonal_Importation.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    MDIParent1.Services_Seasonal_Importation.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == MDIParent1.Services_Seasonal_Contract_Work.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    MDIParent1.Services_Seasonal_Contract_Work.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == MDIParent1.Services_Seasonal_Rent.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    MDIParent1.Services_Seasonal_Rent.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == MDIParent1.Services_Seasonal_Presell.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    MDIParent1.Services_Seasonal_Presell.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == MDIParent1.Services_Edit_Access.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    MDIParent1.Services_Edit_Access.Tag = Dr["Code_Access"];
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == MDIParent1.Services_Delete_Access.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    MDIParent1.Services_Delete_Access.Tag = Dr["Code_Access"];
                                }
                                //------(حسابداری)----------------------------------------------------------------------------------------------------------------
                                if (Convert.ToString(Dr["Name_Access"]) == MDIParent1.Accounting.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    MDIParent1.Accounting.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == MDIParent1.Accounting_Add.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    MDIParent1.Accounting_Add.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == MDIParent1.Accounting_View.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    MDIParent1.Accounting_View.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == MDIParent1.Accounting_Mechanized.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    MDIParent1.Accounting_Mechanized.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == MDIParent1.Accounting_Edit_Access.Text)
                                {
                                    MDIParent1.Accounting_Edit_Access.Tag = Dr["Code_Access"];
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == MDIParent1.Accounting_Delete_Access.Text)
                                {
                                    MDIParent1.Accounting_Delete_Access.Tag = Dr["Code_Access"];
                                }
                                //------(تعمیر و نگهداری)----------------------------------------------------------------------------------------------------------------
                                if (Convert.ToString(Dr["Name_Access"]) == MDIParent1.Repair.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    MDIParent1.Repair.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == MDIParent1.Repair_Equipment.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    MDIParent1.Repair_Equipment.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == MDIParent1.Repair_Cost.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    MDIParent1.Repair_Cost.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == MDIParent1.Repair_Edit_Access.Text)
                                {
                                    MDIParent1.Repair_Edit_Access.Tag = Dr["Code_Access"];
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == MDIParent1.Repair_Delete_Access.Text)
                                {
                                    MDIParent1.Repair_Delete_Access.Tag = Dr["Code_Access"];
                                }
                                //------(حقوق و دستمزد)----------------------------------------------------------------------------------------------------------------

                                if (Dr("Name_Access") == MDIParent1.PayRoll.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.PayRoll.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.PayRoll_Add.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.PayRoll_Add.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.PayRoll_Attendance_Mechanized.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.PayRoll_Attendance_Mechanized.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.PayRoll_Attendance_Manual.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.PayRoll_Attendance_Manual.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.PayRoll_Base_Information.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.PayRoll_Base_Information.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.PayRoll_Deductions.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.PayRoll_Deductions.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.PayRoll_Cure.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.PayRoll_Cure.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.PayRoll_Computing.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.PayRoll_Computing.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.PayRoll_Computing_Difference.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.PayRoll_Computing_Difference.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.PayRoll_Edit_Access.Text)
                                {
                                    MDIParent1.PayRoll_Edit_Access.Tag = Dr("Code_Access");
                                }
                                if (Dr("Name_Access") == MDIParent1.PayRoll_Delete_Access.Text)
                                {
                                    MDIParent1.PayRoll_Delete_Access.Tag = Dr("Code_Access");
                                }
                                //------(انبار)----------------------------------------------------------------------------------------------------------------
                                if (Dr("Name_Access") == MDIParent1.Warehouse.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Warehouse.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Warehouse_Request_Buy_Goods.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Warehouse_Request_Buy_Goods.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Warehouse_Request_Goods.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Warehouse_Request_Goods.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Warehouse_Request_Buy.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Warehouse_Request_Buy.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Warehouse_Request_Services.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Warehouse_Request_Services.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Warehouse_Receipt_Remittance.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Warehouse_Receipt_Remittance.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Warehouse_Receipt.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Warehouse_Receipt.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Warehouse_Receipt_Buy.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Warehouse_Receipt_Buy.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Warehouse_Receipt_Return.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Warehouse_Receipt_Return.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Warehouse_Receipt_Loan.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Warehouse_Receipt_Loan.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Warehouse_Receipt_Production.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Warehouse_Receipt_Production.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Warehouse_Opening.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Warehouse_Opening.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Warehouse_Remittance.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Warehouse_Remittance.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Warehouse_Remittance.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Warehouse_Remittance.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Warehouse_Remittance.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Warehouse_Remittance.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Warehouse_Receipt_Remittance_Direct.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Warehouse_Receipt_Remittance_Direct.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Warehouse_Pricing.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Warehouse_Pricing.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Warehouse_Handling.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Warehouse_Handling.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Warehouse_Handling_Tag.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Warehouse_Handling_Tag.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Warehouse_First_Count.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Warehouse_First_Count.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Warehouse_Second_Count.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Warehouse_Second_Count.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Warehouse_Final_Count.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Warehouse_Final_Count.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Warehouse_Edit_Access.Text)
                                {
                                    MDIParent1.Warehouse_Edit_Access.Tag = Dr("Code_Access");
                                }
                                if (Dr("Name_Access") == MDIParent1.Warehouse_Accounting_Access.Text)
                                {
                                    MDIParent1.Warehouse_Accounting_Access.Tag = Dr("Code_Access");
                                }
                                if (Dr("Name_Access") == MDIParent1.Warehouse_Delete_Access.Text)
                                {
                                    MDIParent1.Warehouse_Delete_Access.Tag = Dr("Code_Access");
                                }
                                //------(اموال)----------------------------------------------------------------------------------------------------------------
                                if (Dr("Name_Access") == MDIParent1.Assets.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Assets.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Assets_Fixed.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Assets_Fixed.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Assets_Intangible.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Assets_Intangible.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Assets_Consumable.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Assets_Consumable.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Assets_Increase.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Assets_Increase.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Assets_Decrease.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Assets_Decrease.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Assets_Movement.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Assets_Movement.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Assets_Dismiss.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Assets_Dismiss.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Assets_Revaluation.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Assets_Revaluation.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Assets_Calculate_Depreciation.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Assets_Calculate_Depreciation.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Assets_Management.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Assets_Management.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Assets_Edit_Access.Text)
                                {
                                    MDIParent1.Assets_Edit_Access.Tag = Dr("Code_Access");
                                }
                                if (Dr("Name_Access") == MDIParent1.Assets_Edit_Access.Text)
                                {
                                    MDIParent1.Assets_Delete_Access.Tag = Dr("Code_Access");
                                }
                                //------(چک بانک)----------------------------------------------------------------------------------------------------------------
                                if (Dr("Name_Access") == MDIParent1.Payable.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Payable.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Payable_Payment.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Payable_Payment.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Payable_Deposits.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Payable_Deposits.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Payable_Wage.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Payable_Wage.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Payable_Edit_Access.Text)
                                {
                                    MDIParent1.Payable_Edit_Access.Tag = Dr("Code_Access");
                                }
                                if (Dr("Name_Access") == MDIParent1.Payable_Delete_Access.Text)
                                {
                                    MDIParent1.Payable_Delete_Access.Tag = Dr("Code_Access");
                                }
                                //------(اسناد وصولی)----------------------------------------------------------------------------------------------------------------
                                if (Dr("Name_Access") == MDIParent1.Collection_Document.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Collection_Document.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Collection_Document_Add.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Collection_Document_Add.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Collection_Document_Assignment.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Collection_Document_Assignment.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Collection_Document_Notice.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Collection_Document_Notice.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Collection_Document_Back.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Collection_Document_Back.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Collection_Document_Extradition.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Collection_Document_Extradition.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Collection_Document_Reform.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Collection_Document_Reform.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Collection_Document_Edit_Access.Text)
                                {
                                    MDIParent1.Collection_Document_Edit_Access.Tag = Dr("Code_Access");
                                }
                                if (Dr("Name_Access") == MDIParent1.Collection_Document_Delete_Access.Text)
                                {
                                    MDIParent1.Collection_Document_Delete_Access.Tag = Dr("Code_Access");
                                }
                                //------(اسناد ضمانتی)----------------------------------------------------------------------------------------------------------------
                                if (Dr("Name_Access") == MDIParent1.Warranty_Document.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Warranty_Document.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Warranty_Document_Add.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Warranty_Document_Add.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Warranty_Document_Extended.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Warranty_Document_Extended.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Warranty_Document_Refund.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Warranty_Document_Refund.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Warranty_Document_Reform.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Warranty_Document_Reform.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Warranty_Document_Edit_Access.Text)
                                {
                                    MDIParent1.Warranty_Document_Edit_Access.Tag = Dr("Code_Access");
                                }
                                if (Dr("Name_Access") == MDIParent1.Warranty_Document_Delete_Access.Text)
                                {
                                    MDIParent1.Warranty_Document_Delete_Access.Tag = Dr("Code_Access");
                                }
                                //------(اطلاعات پایه)----------------------------------------------------------------------------------------------------------------
                                if (Dr("Name_Access") == MDIParent1.Base_Information.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Base_Information.Visible = true;
                                }
                                //------(اطلاعات پایه خدمات)----------------------------------------------------------------------------------------------------------------
                                if (Dr("Name_Access") == MDIParent1.Base_Information_Services.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Base_Information_Services.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Base_Information_Services_Seasonal_Buy_Sales.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Base_Information_Services_Seasonal_Buy_Sales.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Base_Seasonal_Product_Type.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Base_Seasonal_Product_Type.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Base_Information_Services_Order.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Base_Information_Services_Order.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Base_Information_Services_Order_Customer.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Base_Information_Services_Order_Customer.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Base_Information_Services_Order_In_Services.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Base_Information_Services_Order_In_Services.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Base_Information_Services_Order_Out_Services.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Base_Information_Services_Order_Out_Services.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Base_Information_Services_Order_Opertor.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Base_Information_Services_Order_Opertor.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Base_Information_Services_Order_Rate.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Base_Information_Services_Order_Rate.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Base_Information_Services_Edit_Access.Text)
                                {
                                    MDIParent1.Base_Information_Services_Edit_Access.Tag = Dr("Code_Access");
                                }
                                if (Dr("Name_Access") == MDIParent1.Base_Information_Services_Delete_Access.Text)
                                {
                                    MDIParent1.Base_Information_Services_Delete_Access.Tag = Dr("Code_Access");
                                }
                                //------(اطلاعات پایه حسابداری)----------------------------------------------------------------------------------------------------------------
                                if (Dr("Name_Access") == MDIParent1.Base_Information_Accounting.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Base_Information_Accounting.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Base_Information_Accounting_Account_Tree.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Base_Information_Accounting_Account_Tree.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Base_Information_Accounting_Detailed_Tree.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Base_Information_Accounting_Detailed_Tree.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Base_Information_Accounting_Edit_Access.Text)
                                {
                                    MDIParent1.Base_Information_Accounting_Edit_Access.Tag = Dr("Code_Access");
                                }
                                if (Dr("Name_Access") == MDIParent1.Base_Information_Accounting_Delete_Access.Text)
                                {
                                    MDIParent1.Base_Information_Accounting_Delete_Access.Tag = Dr("Code_Access");
                                }
                                //------(اطلاعات پایه تعمیرو نگهداری)----------------------------------------------------------------------------------------------------------------
                                if (Dr("Name_Access") == MDIParent1.Base_Information_Repair.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Base_Information_Repair.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Base_Information_Repair_Seating.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Base_Information_Repair_Seating.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Base_Information_Repair_Energy.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Base_Information_Repair_Energy.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Base_Information_Repair_Phase.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Base_Information_Repair_Phase.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Base_Information_Repair_Kind_Stream.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Base_Information_Repair_Kind_Stream.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Base_Information_Repair_Kind_Fuse.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Base_Information_Repair_Kind_Fuse.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Base_Information_Repair_Connector_Type.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Base_Information_Repair_Connector_Type.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Base_Information_Repair_Stop_Defect.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Base_Information_Repair_Stop_Defect.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Base_Information_Repair_Edit_Access.Text)
                                {
                                    MDIParent1.Base_Information_Repair_Edit_Access.Tag = Dr("Code_Access");
                                }
                                if (Dr("Name_Access") == MDIParent1.Base_Information_Repair_Delete_Access.Text)
                                {
                                    MDIParent1.Base_Information_Repair_Delete_Access.Tag = Dr("Code_Access");
                                }
                                //------(اطلاعات پایه حقوق)----------------------------------------------------------------------------------------------------------------
                                if (Dr("Name_Access") == MDIParent1.Base_Information_PayRoll.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Base_Information_PayRoll.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Base_Information_PayRoll_Personal.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Base_Information_PayRoll_Personal.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Base_Information_PayRoll_Employment.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Base_Information_PayRoll_Employment.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Base_Information_PayRoll_Deductions_Legal.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Base_Information_PayRoll_Deductions_Legal.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Base_Information_PayRoll_Deductions_Diffrent.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Base_Information_PayRoll_Deductions_Diffrent.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Base_Information_PayRoll_Family.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Base_Information_PayRoll_Family.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Base_Information_PayRoll_Calandar.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Base_Information_PayRoll_Calandar.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Base_Information_PayRoll_Edit_Access.Text)
                                {
                                    MDIParent1.Base_Information_PayRoll_Edit_Access.Text = Dr("Code_Access");
                                }
                                if (Dr("Name_Access") == MDIParent1.Base_Information_PayRoll_Delete_Access.Text)
                                {
                                    MDIParent1.Base_Information_PayRoll_Delete_Access.Text = Dr("Code_Access");
                                }
                                //------(اطلاعات پایه انبار)----------------------------------------------------------------------------------------------------------------
                                if (Dr("Name_Access") == MDIParent1.Base_Information_Warehouse.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Base_Information_Warehouse.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Base_Information_Warehouse_Units.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Base_Information_Warehouse_Units.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Base_Information_Warehouse_Sources.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Base_Information_Warehouse_Sources.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Base_Information_Warehouse_Unit_Goods.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Base_Information_Warehouse_Unit_Goods.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Base_Information_Warehouse_Grouping_Goods.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Base_Information_Warehouse_Grouping_Goods.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Base_Information_Warehouse_Collection_Goods.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Base_Information_Warehouse_Collection_Goods.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Base_Information_Warehouse_Edit_Access.Text)
                                {
                                    MDIParent1.Base_Information_Warehouse_Edit_Access.Tag = Dr("Code_Access");
                                }
                                if (Dr("Name_Access") == MDIParent1.Base_Information_Warehouse_Delete_Access.Text)
                                {
                                    MDIParent1.Base_Information_Warehouse_Delete_Access.Tag = Dr("Code_Access");
                                }
                                //------(اطلاعات پایه اموال)----------------------------------------------------------------------------------------------------------------
                                if (Dr("Name_Access") == MDIParent1.Base_Information_Assets.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Base_Information_Assets.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Base_Information_Assets_Depreciation_Rate.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Base_Information_Assets_Depreciation_Rate.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Base_Information_Assets_Plan_project.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Base_Information_Assets_Plan_project.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Base_Information_Assets_City.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Base_Information_Assets_City.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Base_Information_Assets_Personnel.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Base_Information_Assets_Personnel.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Base_Information_Assets_Cost_Code.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Base_Information_Assets_Cost_Code.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Base_Information_Assets_Date.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Base_Information_Assets_Date.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Base_Information_Assets_Edit_Access.Text)
                                {
                                    MDIParent1.Base_Information_Assets_Edit_Access.Tag = Dr("Code_Access");
                                }
                                if (Dr("Name_Access") == MDIParent1.Base_Information_Assets_Delete_Access.Text)
                                {
                                    MDIParent1.Base_Information_Assets_Delete_Access.Tag = Dr("Code_Access");
                                }
                                //------(اطلاعات پایه اسناد)----------------------------------------------------------------------------------------------------------------
                                if (Dr("Name_Access") == MDIParent1.Base_Information_Document.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Base_Information_Document.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Base_Information_Document_Customer.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Base_Information_Document_Customer.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Base_Information_Document_Area.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Base_Information_Document_Area.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Base_Information_Document_Bank.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Base_Information_Document_Bank.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Base_Information_Document_Recovery_Classification.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Base_Information_Document_Recovery_Classification.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Base_Information_Warranty_Document_Classification.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Base_Information_Warranty_Document_Classification.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Base_Information_Document_Edit_Access.Text)
                                {
                                    MDIParent1.Base_Information_Document_Edit_Access.Tag = Dr("Code_Access");
                                }
                                if (Dr("Name_Access") == MDIParent1.Base_Information_Document_Delete_Access.Text)
                                {
                                    MDIParent1.Base_Information_Document_Delete_Access.Tag = Dr("Code_Access");
                                }
                                //------(گزارشات)----------------------------------------------------------------------------------------------------------------
                                if (Dr("Name_Access") == MDIParent1.Reports.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Reports.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.Reports.Text)
                                {
                                    MDIParent1.Reports.Tag = Dr("Code_Access");
                                }
                                //------(گزارشات خدمات)----------------------------------------------------------------------------------------------------------------
                                if (Dr("Name_Access") == MDIParent1.Report_Services.Text)
                                {
                                    MDIParent1.Report_Services.Tag = Dr("Code_Access");
                                }
                                //------(گزارشات حسابداری)----------------------------------------------------------------------------------------------------------------
                                if (Dr("Name_Access") == MDIParent1.Report_Accounting.Text)
                                {
                                    MDIParent1.Report_Accounting.Tag = Dr("Code_Access");
                                }
                                if (Dr("Name_Access") == MDIParent1.Report_Accounting_Note_Book.Text)
                                {
                                    MDIParent1.Report_Accounting_Note_Book.Tag = Dr("Code_Access");
                                }
                                if (Dr("Name_Access") == MDIParent1.Report_Accounting_Account_Note_Book.Text)
                                {
                                    MDIParent1.Report_Accounting_Account_Note_Book.Tag = Dr("Code_Access");
                                }
                                if (Dr("Name_Access") == MDIParent1.Report_Accounting_Details_Note_One_Book.Text)
                                {
                                    MDIParent1.Report_Accounting_Details_Note_One_Book.Tag = Dr("Code_Access");
                                }
                                if (Dr("Name_Access") == MDIParent1.Report_Accounting_Details_Note_Two_Book.Text)
                                {
                                    MDIParent1.Report_Accounting_Details_Note_Two_Book.Tag = Dr("Code_Access");
                                }
                                if (Dr("Name_Access") == MDIParent1.Report_Accounting_Details_Note_Three_Book.Text)
                                {
                                    MDIParent1.Report_Accounting_Details_Note_Three_Book.Tag = Dr("Code_Access");
                                }
                                if (Dr("Name_Access") == MDIParent1.Report_Accounting_Details_Note_Four_Book.Text)
                                {
                                    MDIParent1.Report_Accounting_Details_Note_Four_Book.Tag = Dr("Code_Access");
                                }
                                if (Dr("Name_Access") == MDIParent1.Report_Accounting_Details_Note_Five_Book.Text)
                                {
                                    MDIParent1.Report_Accounting_Details_Note_Five_Book.Tag = Dr("Code_Access");
                                }
                                if (Dr("Name_Access") == MDIParent1.Report_Accounting_Align.Text)
                                {
                                    MDIParent1.Report_Accounting_Align.Tag = Dr("Code_Access");
                                }
                                if (Dr("Name_Access") == MDIParent1.Report_Accounting_Four_Column_Align.Text)
                                {
                                    MDIParent1.Report_Accounting_Four_Column_Align.Tag = Dr("Code_Access");
                                }
                                if (Dr("Name_Access") == MDIParent1.Report_Accounting_Details_Four_Column_Align.Text)
                                {
                                    MDIParent1.Report_Accounting_Details_Four_Column_Align.Tag = Dr("Code_Access");
                                }
                                if (Dr("Name_Access") == MDIParent1.Report_Accounting_Eight_Column_Align.Text)
                                {
                                    MDIParent1.Report_Accounting_Eight_Column_Align.Tag = Dr("Code_Access");
                                }
                                if (Dr("Name_Access") == MDIParent1.Report_Accounting_Details_Eight_Column_Align.Text)
                                {
                                    MDIParent1.Report_Accounting_Details_Eight_Column_Align.Tag = Dr("Code_Access");
                                }
                                if (Dr("Name_Access") == MDIParent1.Report_Accounting_Reports.Text)
                                {
                                    MDIParent1.Report_Accounting_Reports.Tag = Dr("Code_Access");
                                }
                                if (Dr("Name_Access") == MDIParent1.Report_Accounting_Details.Text)
                                {
                                    MDIParent1.Report_Accounting_Details.Tag = Dr("Code_Access");
                                }
                                if (Dr("Name_Access") == MDIParent1.Report_Accounting_Analysis.Text)
                                {
                                    MDIParent1.Report_Accounting_Analysis.Tag = Dr("Code_Access");
                                }
                                //------(گزارشات تعمیر و نگهداری)----------------------------------------------------------------------------------------------------------------
                                if (Dr("Name_Access") == MDIParent1.Report_Repair.Text)
                                {
                                    MDIParent1.Report_Repair.Tag = Dr("Code_Access");
                                }
                                //------(گزارشات حقوق و دستمزد)----------------------------------------------------------------------------------------------------------------
                                if (Dr("Name_Access") == MDIParent1.Report_PayRoll.Text)
                                {
                                    MDIParent1.Report_PayRoll.Tag = Dr("Code_Access");
                                }
                                //------(گزارشات انبار)----------------------------------------------------------------------------------------------------------------
                                if (Dr("Name_Access") == MDIParent1.Report_Warehouse.Text)
                                {
                                    MDIParent1.Report_Warehouse.Tag = Dr("Code_Access");
                                }
                                if (Dr("Name_Access") == MDIParent1.Report_Warehouse_Number.Text)
                                {
                                    MDIParent1.Report_Warehouse_Number.Tag = Dr("Code_Access");
                                }
                                if (Dr("Name_Access") == MDIParent1.Report_Warehouse_Cardx.Text)
                                {
                                    MDIParent1.Report_Warehouse_Cardx.Tag = Dr("Code_Access");
                                }
                                if (Dr("Name_Access") == MDIParent1.Report_Warehouse_Turnover.Text)
                                {
                                    MDIParent1.Report_Warehouse_Turnover.Tag = Dr("Code_Access");
                                }
                                if (Dr("Name_Access") == MDIParent1.Report_Warehouse_Inventory.Text)
                                {
                                    MDIParent1.Report_Warehouse_Inventory.Tag = Dr("Code_Access");
                                }
                                if (Dr("Name_Access") == MDIParent1.Report_Warehouse_Accounting.Text)
                                {
                                    MDIParent1.Report_Warehouse_Accounting.Tag = Dr("Code_Access");
                                }
                                if (Dr("Name_Access") == MDIParent1.Report_Warehouse_Accounting_Cardx.Text)
                                {
                                    MDIParent1.Report_Warehouse_Accounting_Cardx.Tag = Dr("Code_Access");
                                }
                                if (Dr("Name_Access") == MDIParent1.Report_Warehouse_Accounting_Turnover.Text)
                                {
                                    MDIParent1.Report_Warehouse_Accounting_Turnover.Tag = Dr("Code_Access");
                                }
                                if (Dr("Name_Access") == MDIParent1.Report_Warehouse_Accounting_Inventory.Text)
                                {
                                    MDIParent1.Report_Warehouse_Accounting_Inventory.Tag = Dr("Code_Access");
                                }
                                if (Dr("Name_Access") == MDIParent1.Report_Warehouse_Handling.Text)
                                {
                                    MDIParent1.Report_Warehouse_Handling.Tag = Dr("Code_Access");
                                }
                                if (Dr("Name_Access") == MDIParent1.Report_Warehouse_Handling_One_Counts.Text)
                                {
                                    MDIParent1.Report_Warehouse_Handling_One_Counts.Tag = Dr("Code_Access");
                                }
                                if (Dr("Name_Access") == MDIParent1.Report_Warehouse_Handling_Two_Counts.Text)
                                {
                                    MDIParent1.Report_Warehouse_Handling_Two_Counts.Tag = Dr("Code_Access");
                                }
                                if (Dr("Name_Access") == MDIParent1.Report_Warehouse_Handling_Third_Counts.Text)
                                {
                                    MDIParent1.Report_Warehouse_Handling_Third_Counts.Tag = Dr("Code_Access");
                                }
                                //------(گزارشات اموال و دارائی های ثابت)----------------------------------------------------------------------------------------------------------------
                                if (Dr("Name_Access") == MDIParent1.Report_Estate.Text)
                                {
                                    MDIParent1.Report_Estate.Tag = Dr("Code_Access");
                                }
                                if (Dr("Name_Access") == MDIParent1.Report_Estate_Responsible.Text)
                                {
                                    MDIParent1.Report_Estate_Responsible.Tag = Dr("Code_Access");
                                }
                                if (Dr("Name_Access") == MDIParent1.Report_Estate_Consumable_Delivering.Text)
                                {
                                    MDIParent1.Report_Estate_Consumable_Delivering.Tag = Dr("Code_Access");
                                }
                                if (Dr("Name_Access") == MDIParent1.Report_Estate_Delivering.Text)
                                {
                                    MDIParent1.Report_Estate_Delivering.Tag = Dr("Code_Access");
                                }
                                if (Dr("Name_Access") == MDIParent1.Report_Consumable_Delivering.Text)
                                {
                                    MDIParent1.Report_Consumable_Delivering.Tag = Dr("Code_Access");
                                }
                                if (Dr("Name_Access") == MDIParent1.Report_Estate_Accountants.Text)
                                {
                                    MDIParent1.Report_Estate_Accountants.Tag = Dr("Code_Access");
                                }
                                if (Dr("Name_Access") == MDIParent1.Report_Estate_Facial.Text)
                                {
                                    MDIParent1.Report_Estate_Facial.Tag = Dr("Code_Access");
                                }
                                if (Dr("Name_Access") == MDIParent1.Report_Estate_Original_Code.Text)
                                {
                                    MDIParent1.Report_Estate_Original_Code.Tag = Dr("Code_Access");
                                }
                                if (Dr("Name_Access") == MDIParent1.Report_Estate_Cost_Code.Text)
                                {
                                    MDIParent1.Report_Estate_Cost_Code.Tag = Dr("Code_Access");
                                }
                                if (Dr("Name_Access") == MDIParent1.Report_Estate_Cost_Original.Text)
                                {
                                    MDIParent1.Report_Estate_Cost_Original.Tag = Dr("Code_Access");
                                }
                                if (Dr("Name_Access") == MDIParent1.Report_Estate_Original_Cost.Text)
                                {
                                    MDIParent1.Report_Estate_Original_Cost.Tag = Dr("Code_Access");
                                }
                                if (Dr("Name_Access") == MDIParent1.Report_Estate_Original_Cost_City.Text)
                                {
                                    MDIParent1.Report_Estate_Original_Cost_City.Tag = Dr("Code_Access");
                                }
                                if (Dr("Name_Access") == MDIParent1.Report_Estate_Decrease.Text)
                                {
                                    MDIParent1.Report_Estate_Decrease.Tag = Dr("Code_Access");
                                }
                                if (Dr("Name_Access") == MDIParent1.Report_Estate_Dismiss.Text)
                                {
                                    MDIParent1.Report_Estate_Dismiss.Tag = Dr("Code_Access");
                                }
                                if (Dr("Name_Access") == MDIParent1.Report_Estate_Document_Cost.Text)
                                {
                                    MDIParent1.Report_Estate_Document_Cost.Tag = Dr("Code_Access");
                                }
                                if (Dr("Name_Access") == MDIParent1.Report_Estate_Document_Original.Text)
                                {
                                    MDIParent1.Report_Estate_Document_Original.Tag = Dr("Code_Access");
                                }
                                if (Dr("Name_Access") == MDIParent1.Report_Estate_Document_Dismiss.Text)
                                {
                                    MDIParent1.Report_Estate_Document_Dismiss.Tag = Dr("Code_Access");
                                }
                                //------(گزارشات ثبت چک بانک)----------------------------------------------------------------------------------------------------------------
                                if (Dr("Name_Access") == MDIParent1.Report_Payable.Text)
                                {
                                    MDIParent1.Report_Payable.Tag = Dr("Code_Access");
                                }
                                if (Dr("Name_Access") == MDIParent1.Report_Payable_Turnover.Text)
                                {
                                    MDIParent1.Report_Payable_Turnover.Tag = Dr("Code_Access");
                                }
                                if (Dr("Name_Access") == MDIParent1.Report_Payable_Checked_Out.Text)
                                {
                                    MDIParent1.Report_Payable_Checked_Out.Tag = Dr("Code_Access");
                                }
                                if (Dr("Name_Access") == MDIParent1.Report_Payable_Deposits.Text)
                                {
                                    MDIParent1.Report_Payable_Deposits.Tag = Dr("Code_Access");
                                }
                                if (Dr("Name_Access") == MDIParent1.Report_Payable_Wage.Text)
                                {
                                    MDIParent1.Report_Payable_Wage.Tag = Dr("Code_Access");
                                }
                                //------(گزارشات اسناد وصولی)----------------------------------------------------------------------------------------------------------------
                                if (Dr("Name_Access") == MDIParent1.Report_Collection_Document.Text)
                                {
                                    MDIParent1.Report_Collection_Document.Tag = Dr("Code_Access");
                                }
                                if (Dr("Name_Access") == MDIParent1.Report_Collection_Document_Add.Text)
                                {
                                    MDIParent1.Report_Collection_Document_Add.Tag = Dr("Code_Access");
                                }
                                if (Dr("Name_Access") == MDIParent1.Report_Collection_Document_Due_Date.Text)
                                {
                                    MDIParent1.Report_Collection_Document_Due_Date.Tag = Dr("Code_Access");
                                }
                                if (Dr("Name_Access") == MDIParent1.Report_Collection_Document_Assignment.Text)
                                {
                                    MDIParent1.Report_Collection_Document_Assignment.Tag = Dr("Code_Access");
                                }
                                if (Dr("Name_Access") == MDIParent1.Report_Collection_Document_Notice.Text)
                                {
                                    MDIParent1.Report_Collection_Document_Notice.Tag = Dr("Code_Access");
                                }
                                if (Dr("Name_Access") == MDIParent1.Report_Collection_Document_Back.Text)
                                {
                                    MDIParent1.Report_Collection_Document_Back.Tag = Dr("Code_Access");
                                }
                                if (Dr("Name_Access") == MDIParent1.Report_Collection_Document_Refund_Date.Text)
                                {
                                    MDIParent1.Report_Collection_Document_Refund_Date.Tag = Dr("Code_Access");
                                }
                                if (Dr("Name_Access") == MDIParent1.Report_Collection_Document_Receipt.Text)
                                {
                                    MDIParent1.Report_Collection_Document_Receipt.Tag = Dr("Code_Access");
                                }
                                //------(گزارشات اسناد ضمانتی)----------------------------------------------------------------------------------------------------------------
                                if (Dr("Name_Access") == MDIParent1.Report_Warranty_Document.Text)
                                {
                                    MDIParent1.Report_Warranty_Document.Tag = Dr("Code_Access");
                                }
                                if (Dr("Name_Access") == MDIParent1.Report_Warranty_Document_No_Date.Text)
                                {
                                    MDIParent1.Report_Warranty_Document_No_Date.Tag = Dr("Code_Access");
                                }
                                if (Dr("Name_Access") == MDIParent1.Report_Warranty_Document_Extended_Date.Text)
                                {
                                    MDIParent1.Report_Warranty_Document_Extended_Date.Tag = Dr("Code_Access");
                                }
                                if (Dr("Name_Access") == MDIParent1.Report_Warranty_Document_Refund_Date.Text)
                                {
                                    MDIParent1.Report_Warranty_Document_Refund_Date.Tag = Dr("Code_Access");
                                }
                                if (Dr("Name_Access") == MDIParent1.Report_Warranty_Document_Due_Date.Text)
                                {
                                    MDIParent1.Report_Warranty_Document_Due_Date.Tag = Dr("Code_Access");
                                }
                                if (Dr("Name_Access") == MDIParent1.Report_Warranty_Document_Date.Text)
                                {
                                    MDIParent1.Report_Warranty_Document_Date.Tag = Dr("Code_Access");
                                }
                                //------(نمایش)----------------------------------------------------------------------------------------------------------------
                                if (Dr("Name_Access") == MDIParent1.View.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.View.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.View_Menu_Toolbox.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.View_Menu_Toolbox.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.View_Menu_Subtitle.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.View_Menu_Subtitle.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.View_Menu_Help.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.View_Menu_Help.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.View_Menu_Log.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.View_Menu_Log.Visible = true;
                                }
                                //------(سیستم)----------------------------------------------------------------------------------------------------------------
                                if (Dr("Name_Access") == MDIParent1.Systems.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.Systems.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.System_User_Menu.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.System_User_Menu.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.System_Area_Menu.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.System_Area_Menu.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.System_Activation_Menu.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.System_Activation_Menu.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.System_Chang_User_Menu.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.System_Chang_User_Menu.Visible = true;
                                }
                                if (Dr("Name_Access") == MDIParent1.System_sms.Text && Dr("Code_Access") == "1")
                                {
                                    MDIParent1.System_sms.Visible = true;
                                }
                                //-------------------------------------------------------------

                            }
                            string strReportPath = GetCurrentDirectory();
                            if (strReportPath.Substring(strReportPath.Length - 9) == "bin\\Debug")
                            {
                                MDIParent1.Report.Text = strReportPath.Substring(0, strReportPath.Length - 10);
                            }

                        }
                    }
                    f_serch = "";
                    f_serch += "UPDATE  Security_Users  SET ";
                    if (Check_Pass.Checked == true)
                    {
                        f_serch += "Host_String=N'" + "Security_Users" + "/" + Id + "/" + "True" + "',";
                    }
                    else
                    {
                        f_serch += "Host_String=N'" + "Security_Users" + "/" + Id + "/" + "False" + "',";
                    }
                    if (UsernameTextBox.Text == Host)
                    {
                        f_serch += "Host_Name=N'" + System.Net.Dns.GetHostName() + "',";
                    }
                    else
                    {
                        if (Host.Length == 0)
                        {
                            ShowMessage("اخطار", "آدرس این سیستم برای کاربر مورد نظر ذخیره شد", frmMessage.mIcon.mStop, frmMessage.mButtons.mAccept);
                            f_serch += "Host_Name=N'" + System.Net.Dns.GetHostName() + "',";
                        }
                        else
                        {
                            ShowMessage("اخطار", "با این آدرس کاربر ذخیره شده در سیستم وجود دارد", frmMessage.mIcon.mStop, frmMessage.mButtons.mAccept);
                        }
                    }
                    f_serch += "Time_In=N'" + DateTime.Now.ToString("HH:mm:ss") + "',";
                    f_serch += "Date_In=N'" + (DateTime.Today).ToString().Replace("/", "") + "',";
                    f_serch += "Online=N'" + true + "'";
                    f_serch += "where Id LIKE N'" + Id + "'";
                    DataSet update = PDataset("" + f_serch + "");
                    f_select = "";
                    f_select = "select A.*,B.*,C.* from Warranty_Document A left join Base_Information B on A.Warranty_Document_Case=B.Base_Information_Id left join Counterparty C on A.Warranty_Document_Subscription=C.Counterparty_ID where ";
                    f_select += "Warranty_Document_Operation not in (2) ";
                    f_select += "and Warranty_Document_Extended_Date >= '" + NumericHelper.Val(DateTime.Today.ToString().Replace("/", "")) + "'";
                    f_select += "and Warranty_Document_Extended_Date <= '" + NumericHelper.Val(Next_Month.Replace("/", "")) + "'";
                    if (MDIParent1.N_Admin.Text == "False")
                    {
                        f_select += "and Warranty_Document_Area = " + MDIParent1.N_Id_Area.Text + "";
                    }
                    f_select += "UNION select A.*,B.*,C.* from Warranty_Document A left join Base_Information B on A.Warranty_Document_Case=B.Base_Information_Id left join Counterparty C on A.Warranty_Document_Subscription=C.Counterparty_ID where ";
                    f_select += "Warranty_Document_Operation not in (1,2) ";
                    f_select += "and Warranty_Document_Due_Date >= '" + NumericHelper.Val(DateTime.Today.ToString().Replace("/", "")) + "'";
                    f_select += "and Warranty_Document_Due_Date <= '" + NumericHelper.Val(Next_Month.Replace("/", "")) + "'";
                    if (MDIParent1.N_Admin.Text == "False")
                    {
                        f_select += "and Warranty_Document_Area = " + MDIParent1.N_Id_Area.Text + "";
                    }
                    DataSet Warranty = PDataset("" + f_select + "");
                    MDIParent1.Label_Warranty.Text = (Warranty.Tables[0].Rows.Count).ToString();
                    f_select = "";
                    f_select += "select A.*,B.*,C.*,D.* from Recovery_Documents A ";
                    f_select += "left join Base_Information B on Recovery_Documents_Case=Base_Information_Id ";
                    f_select += "left join Counterparty C on Recovery_Documents_Subscription=Counterparty_ID ";
                    f_select += "left join Bank D on Recovery_Documents_Collecting_Bank=Bank_ID ";
                    f_select += "where Recovery_Documents_Operation not in (2,3,4) ";
                    f_select += "and Recovery_Documents_Due_Date >= '" + NumericHelper.Val(DateTime.Today.ToString().Replace("/", "")) + "'";
                    f_select += "and Recovery_Documents_Due_Date <= '" + NumericHelper.Val(Next_Month.Replace("/", "")) + "'";
                    if (MDIParent1.N_Admin.Text == "False")
                    {
                        f_select += "and Recovery_Documents_Area = " + MDIParent1.N_Id_Area.Text + "";
                    }
                    DataSet Collection = PDataset("" + f_select + "");
                    MDIParent1.Label_Collection.Text = (Collection.Tables[0].Rows.Count).ToString();
                    MDIParent1.Show();
                }
            }
        }
    }
}
