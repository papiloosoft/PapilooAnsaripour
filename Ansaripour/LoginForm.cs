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
            MDIParent1 mdiparent = new MDIParent1();

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
                mdiparent.ID.Text = "1311";
                mdiparent.I_N.Text = "مدیر سیستم";
                mdiparent.N_Id_Area.Text = "مرکزی";
                mdiparent.N_Company_Area.Text = "بدون تمرکز";
                mdiparent.N_Admin.Text = "True";
                mdiparent.Description.Text = "";
                //------(خدمات)----------------------------------------------------------------------------------------------------------------
                mdiparent.Services.Visible = true;
                mdiparent.Services_Sale_Managing.Visible = true;
                mdiparent.Services_Order_Add.Visible = true;
                mdiparent.Services_Seasonal_Buy_Sales.Visible = true;
               mdiparent.Services_Seasonal_Buy.Visible = true;
               mdiparent.Services_Seasonal_Sale.Visible = true;
               mdiparent.Services_Seasonal_Contractor.Visible = true;
               mdiparent.Services_Seasonal_Employer.Visible = true;
               mdiparent.Services_Seasonal_Export.Visible = true;
               mdiparent.Services_Seasonal_Importation.Visible = true;
               mdiparent.Services_Seasonal_Contract_Work.Visible = true;
               mdiparent.Services_Seasonal_Rent.Visible = true;
               mdiparent.Services_Seasonal_Presell.Visible = true;
               mdiparent.Services_Edit_Access.Tag = 1;
               mdiparent.Services_Delete_Access.Tag = 1;
                //------(حسابداری)----------------------------------------------------------------------------------------------------------------
               mdiparent.Accounting.Visible = true;
               mdiparent.Accounting_Add.Visible = true;
               mdiparent.Accounting_View.Visible = true;
               mdiparent.Accounting_Mechanized.Visible = true;
               mdiparent.Accounting_Edit_Access.Tag = 1;
               mdiparent.Accounting_Delete_Access.Tag = 1;
                //------(تعمیر و نگهداری)----------------------------------------------------------------------------------------------------------------
               mdiparent.Repair.Visible = true;
               mdiparent.Repair_Equipment.Visible = true;
               mdiparent.Repair_Cost.Visible = true;
               mdiparent.Repair_Edit_Access.Tag = 1;
               mdiparent.Repair_Delete_Access.Tag = 1;
                //------(حقوق و دستمزد)----------------------------------------------------------------------------------------------------------------
                mdiparent.PayRoll.Visible = true;
                mdiparent.PayRoll_Add.Visible = true;
                mdiparent.PayRoll_Attendance_Mechanized.Visible = true;
                mdiparent.PayRoll_Attendance_Manual.Visible = true;
                mdiparent.PayRoll_Base_Information.Visible = true;
                mdiparent.PayRoll_Deductions.Visible = true;
                mdiparent.PayRoll_Cure.Visible = true;
                mdiparent.PayRoll_Computing.Visible = true;
                mdiparent.PayRoll_Computing_Difference.Visible = true;
                mdiparent.PayRoll_Edit_Access.Tag = 1;
                mdiparent.PayRoll_Delete_Access.Tag = 1;
                //------(انبار)----------------------------------------------------------------------------------------------------------------
                mdiparent.Warehouse.Visible = true;
                mdiparent.Warehouse_Request_Buy_Goods.Visible = true;
                mdiparent.Warehouse_Request_Goods.Visible = true;
                mdiparent.Warehouse_Request_Buy.Visible = true;
                mdiparent.Warehouse_Request_Services.Visible = true;
                mdiparent.Warehouse_Receipt_Remittance.Visible = true;
                mdiparent.Warehouse_Receipt.Visible = true;
                mdiparent.Warehouse_Receipt_Buy.Visible = true;
                mdiparent.Warehouse_Receipt_Return.Visible = true;
                mdiparent.Warehouse_Receipt_Loan.Visible = true;
                mdiparent.Warehouse_Receipt_Production.Visible = true;
                mdiparent.Warehouse_Opening.Visible = true;
                mdiparent.Warehouse_Remittance.Visible = true;
                mdiparent.Warehouse_Remittance_Use.Visible = true;
                mdiparent.Warehouse_Remittance_Sell.Visible = true;
                mdiparent.Warehouse_Receipt_Remittance_Direct.Visible = true;
                mdiparent.Warehouse_Pricing.Visible = true;
                mdiparent.Warehouse_Handling.Visible = true;
                mdiparent.Warehouse_Handling_Tag.Visible = true;
                mdiparent.Warehouse_First_Count.Visible = true;
                mdiparent.Warehouse_Second_Count.Visible = true;
                mdiparent.Warehouse_Final_Count.Visible = true;
                mdiparent.Warehouse_Edit_Access.Tag = 1;
                mdiparent.Warehouse_Accounting_Access.Tag = 1;
                mdiparent.Warehouse_Delete_Access.Tag = 1;
                //------(اموال)----------------------------------------------------------------------------------------------------------------
                mdiparent.Assets.Visible = true;
                mdiparent.Assets_Fixed.Visible = true;
                mdiparent.Assets_Intangible.Visible = true;
                mdiparent.Assets_Consumable.Visible = true;
                mdiparent.Assets_Increase.Visible = true;
                mdiparent.Assets_Decrease.Visible = true;
                mdiparent.Assets_Movement.Visible = true;
                mdiparent.Assets_Dismiss.Visible = true;
                mdiparent.Assets_Revaluation.Visible = true;
                mdiparent.Assets_Calculate_Depreciation.Visible = true;
                mdiparent.Assets_Management.Visible = true;
                mdiparent.Assets_Edit_Access.Tag = 1;
                mdiparent.Assets_Delete_Access.Tag = 1;
                //------(چک بانک)----------------------------------------------------------------------------------------------------------------
                mdiparent.Payable.Visible = true;
                mdiparent.Payable_Payment.Visible = true;
                mdiparent.Payable_Deposits.Visible = true;
                mdiparent.Payable_Wage.Visible = true;
                mdiparent.PayRoll_Edit_Access.Tag = 1;
                mdiparent.PayRoll_Delete_Access.Tag = 1;
                //------(اسناد وصولی)----------------------------------------------------------------------------------------------------------------
                mdiparent.Collection_Document.Visible = true;
                mdiparent.Collection_Document_Add.Visible = true;
                mdiparent.Collection_Document_Assignment.Visible = true;
                mdiparent.Collection_Document_Notice.Visible = true;
                mdiparent.Collection_Document_Back.Visible = true;
                mdiparent.Collection_Document_Extradition.Visible = true;
                mdiparent.Collection_Document_Reform.Visible = true;
                mdiparent.Collection_Document_Edit_Access.Tag = 1;
                mdiparent.Collection_Document_Delete_Access.Tag = 1;
                //------(اسناد ضمانتی)----------------------------------------------------------------------------------------------------------------
                mdiparent.Warranty_Document.Visible = true;
                mdiparent.Warranty_Document_Add.Visible = true;
                mdiparent.Warranty_Document_Extended.Visible = true;
                mdiparent.Warranty_Document_Refund.Visible = true;
                mdiparent.Warranty_Document_Reform.Visible = true;
                mdiparent.Warranty_Document_Edit_Access.Tag = 1;
                mdiparent.Warranty_Document_Delete_Access.Tag = 1;
                //------(اطلاعات پایه)----------------------------------------------------------------------------------------------------------------
                mdiparent.Base_Information.Visible = true;
                //------(اطلاعات پایه خدمات)----------------------------------------------------------------------------------------------------------------
                mdiparent.Base_Information_Services.Visible = true;
                mdiparent.Base_Information_Services_Seasonal_Buy_Sales.Visible = true;
                mdiparent.Base_Seasonal_Product_Type.Visible = true;
                mdiparent.Base_Information_Services_Order.Visible = true;
                mdiparent.Base_Information_Services_Order_Customer.Visible = true;
                mdiparent.Base_Information_Services_Order_In_Services.Visible = true;
                mdiparent.Base_Information_Services_Order_Out_Services.Visible = true;
                mdiparent.Base_Information_Services_Order_Opertor.Visible = true;
                mdiparent.Base_Information_Services_Order_Rate.Visible = true;
                mdiparent.Base_Information_Services_Edit_Access.Tag = 1;
                mdiparent.Base_Information_Services_Delete_Access.Tag = 1;
                //------(اطلاعات حسابداری)----------------------------------------------------------------------------------------------------------------
                mdiparent.Base_Information_Accounting.Visible = true;
                mdiparent.Base_Information_Accounting_Account_Tree.Visible = true;
                mdiparent.Base_Information_Accounting_Detailed_Tree.Visible = true;
                mdiparent.Base_Information_Services_Edit_Access.Tag = 1;
                mdiparent.Base_Information_Services_Delete_Access.Tag = 1;
                //------(اطلاعات پایه تعمیرو نگهداری)----------------------------------------------------------------------------------------------------------------
                mdiparent.Base_Information_Repair.Visible = true;
                mdiparent.Base_Information_Repair_Seating.Visible = true;
                mdiparent.Base_Information_Repair_Energy.Visible = true;
                mdiparent.Base_Information_Repair_Phase.Visible = true;
                mdiparent.Base_Information_Repair_Kind_Stream.Visible = true;
                mdiparent.Base_Information_Repair_Kind_Fuse.Visible = true;
                mdiparent.Base_Information_Repair_Connector_Type.Visible = true;
                mdiparent.Base_Information_Repair_Stop_Defect.Visible = true;
                mdiparent.Base_Information_Repair_Edit_Access.Tag = 1;
                mdiparent.Base_Information_Repair_Delete_Access.Tag = 1;
                //------(اطلاعات پایه حقوق)----------------------------------------------------------------------------------------------------------------
                mdiparent.Base_Information_PayRoll.Visible = true;
                mdiparent.Base_Information_PayRoll_Personal.Visible = true;
                mdiparent.Base_Information_PayRoll_Employment.Visible = true;
                mdiparent.Base_Information_PayRoll_Deductions_Legal.Visible = true;
                mdiparent.Base_Information_PayRoll_Deductions_Diffrent.Visible = true;
                mdiparent.Base_Information_PayRoll_Family.Visible = true;
                mdiparent.Base_Information_PayRoll_Calandar.Visible = true;
                mdiparent.Base_Information_Accounting_Edit_Access.Tag = 1;
                mdiparent.Base_Information_Accounting_Delete_Access.Tag = 1;
                //------(اطلاعات پایه اسناد)----------------------------------------------------------------------------------------------------------------
                mdiparent.Base_Information_Document.Visible = true;
                mdiparent.Base_Information_Document_Bank.Visible = true;
                mdiparent.Base_Information_Document_Recovery_Classification.Visible = true;
                mdiparent.Base_Information_Warranty_Document_Classification.Visible = true;
                mdiparent.Base_Information_Document_Customer.Visible = true;
                mdiparent.Base_Information_Document_Area.Visible = true;
                mdiparent.Base_Information_Document_Edit_Access.Tag = 1;
                mdiparent.Base_Information_Document_Delete_Access.Tag = 1;
                //------(اطلاعات پایه اموال)----------------------------------------------------------------------------------------------------------------
                mdiparent.Base_Information_Assets.Visible = true;
                mdiparent.Base_Information_Assets_Depreciation_Rate.Visible = true;
                mdiparent.Base_Information_Assets_Plan_project.Visible = true;
                mdiparent.Base_Information_Assets_City.Visible = true;
                mdiparent.Base_Information_Assets_Personnel.Visible = true;
                mdiparent.Base_Information_Assets_Cost_Code.Visible = true;
                mdiparent.Base_Information_Assets_Date.Visible = true;
                mdiparent.Base_Information_Assets_Edit_Access.Tag = 1;
                mdiparent.Base_Information_Assets_Delete_Access.Tag = 1;
                //------(اطلاعات پایه انبار)----------------------------------------------------------------------------------------------------------------
                mdiparent.Base_Information_Warehouse.Visible = true;
                mdiparent.Base_Information_Warehouse_Units.Visible = true;
                mdiparent.Base_Information_Warehouse_Sources.Visible = true;
                mdiparent.Base_Information_Warehouse_Unit_Goods.Visible = true;
                mdiparent.Base_Information_Warehouse_Grouping_Goods.Visible = true;
                mdiparent.Base_Information_Warehouse_Collection_Goods.Visible = true;
                mdiparent.Base_Information_Warehouse_Edit_Access.Tag = 1;
                mdiparent.Base_Information_Warehouse_Delete_Access.Tag = 1;
                //------(نمایش)----------------------------------------------------------------------------------------------------------------
                mdiparent.View.Visible = true;
                mdiparent.View_Menu_Toolbox.Visible = true;
                mdiparent.View_Menu_Subtitle.Visible = true;
                mdiparent.View_Menu_Help.Visible = true;
                mdiparent.View_Menu_Log.Visible = true;
                //------(گزارشات)----------------------------------------------------------------------------------------------------------------
                mdiparent.Reports.Visible = true;
                mdiparent.Reports.Tag = 1;
                //------(گزارشات حسابداری)----------------------------------------------------------------------------------------------------------------
                mdiparent.Report_Accounting.Tag = 1;
                mdiparent.Report_Accounting_Note_Book.Tag = 1;
                mdiparent.Report_Accounting_Account_Note_Book.Tag = 1;
                mdiparent.Report_Accounting_Details_Note_One_Book.Tag = 1;
                mdiparent.Report_Accounting_Details_Note_Two_Book.Tag = 1;
                mdiparent.Report_Accounting_Details_Note_Three_Book.Tag = 1;
                mdiparent.Report_Accounting_Details_Note_Four_Book.Tag = 1;
                mdiparent.Report_Accounting_Details_Note_Five_Book.Tag = 1;
                mdiparent.Report_Accounting_Align.Tag = 1;
                mdiparent.Report_Accounting_Four_Column_Align.Tag = 1;
                mdiparent.Report_Accounting_Details_Four_Column_Align.Tag = 1;
                mdiparent.Report_Accounting_Eight_Column_Align.Tag = 1;
                mdiparent.Report_Accounting_Details_Eight_Column_Align.Tag = 1;
                mdiparent.Report_Accounting_Reports.Tag = 1;
                mdiparent.Report_Accounting_Details.Tag = 1;
                mdiparent.Report_Accounting_Analysis.Tag = 1;
                //------(گزارشات انبار)----------------------------------------------------------------------------------------------------------------
                mdiparent.Report_Warehouse.Tag = 1;
                mdiparent.Report_Warehouse_Number.Tag = 1;
                mdiparent.Report_Warehouse_Cardx.Tag = 1;
                mdiparent.Report_Warehouse_Turnover.Tag = 1;
                mdiparent.Report_Warehouse_Inventory.Tag = 1;
                mdiparent.Report_Warehouse_Accounting.Tag = 1;
                mdiparent.Report_Warehouse_Accounting_Cardx.Tag = 1;
                mdiparent.Report_Warehouse_Accounting_Turnover.Tag = 1;
                mdiparent.Report_Warehouse_Accounting_Inventory.Tag = 1;
                mdiparent.Report_Warehouse.Tag = 1;
                mdiparent.Report_Warehouse_Number.Tag = 1;
                mdiparent.Report_Warehouse_Cardx.Tag = 1;
                mdiparent.Report_Warehouse_Turnover.Tag = 1;
                mdiparent.Report_Warehouse_Inventory.Tag = 1;
                mdiparent.Report_Warehouse_Accounting.Tag = 1;
                mdiparent.Report_Warehouse_Accounting_Cardx.Tag = 1;
                mdiparent.Report_Warehouse_Accounting_Turnover.Tag = 1;
                mdiparent.Report_Warehouse_Accounting_Inventory.Tag = 1;
                mdiparent.Report_Warehouse_Handling.Tag = 1;
                mdiparent.Report_Warehouse_Handling_One_Counts.Tag = 1;
                mdiparent.Report_Warehouse_Handling_Two_Counts.Tag = 1;
                mdiparent.Report_Warehouse_Handling_Third_Counts.Tag = 1;
                //------(گزارشات ثبت چک بانک)----------------------------------------------------------------------------------------------------------------
                mdiparent.Report_Payable.Tag = 1;
                mdiparent.Report_Payable_Turnover.Tag = 1;
                mdiparent.Report_Payable_Checked_Out.Tag = 1;
                mdiparent.Report_Payable_Deposits.Tag = 1;
                mdiparent.Report_Payable_Wage.Tag = 1;
                //------(گزارشات اموال و دارائی های ثابت)----------------------------------------------------------------------------------------------------------------
                mdiparent.Report_Estate.Tag = 1;
                mdiparent.Report_Estate_Responsible.Tag = 1;
                mdiparent.Report_Estate_Consumable_Delivering.Tag = 1;
                mdiparent.Report_Estate_Delivering.Tag = 1;
                mdiparent.Report_Consumable_Delivering.Tag = 1;
                mdiparent.Report_Estate_Accountants.Tag = 1;
                mdiparent.Report_Estate_Facial.Tag = 1;
                mdiparent.Report_Estate_Original_Code.Tag = 1;
                mdiparent.Report_Estate_Cost_Code.Tag = 1;
                mdiparent.Report_Estate_Cost_Original.Tag = 1;
                mdiparent.Report_Estate_Original_Cost.Tag = 1;
                mdiparent.Report_Estate_Original_Cost_City.Tag = 1;
                mdiparent.Report_Estate_Decrease.Tag = 1;
                mdiparent.Report_Estate_Dismiss.Tag = 1;
                mdiparent.Report_Estate_Document_Cost.Tag = 1;
                mdiparent.Report_Estate_Document_Original.Tag = 1;
                mdiparent.Report_Estate_Document_Dismiss.Tag = 1;
                //------(گزارشات اسناد وصولی)----------------------------------------------------------------------------------------------------------------
                mdiparent.Report_Collection_Document.Tag = 1;
                mdiparent.Report_Collection_Document_Add.Tag = 1;
                mdiparent.Report_Collection_Document_Due_Date.Tag = 1;
                mdiparent.Report_Collection_Document_Assignment.Tag = 1;
                mdiparent.Report_Collection_Document_Notice.Tag = 1;
                mdiparent.Report_Collection_Document_Back.Tag = 1;
                mdiparent.Report_Collection_Document_Refund_Date.Tag = 1;
                mdiparent.Report_Collection_Document_Receipt.Tag = 1;
                //------(گزارشات اسناد ضمانتی)----------------------------------------------------------------------------------------------------------------
                mdiparent.Report_Warranty_Document.Tag = 1;
                mdiparent.Report_Warranty_Document_No_Date.Tag = 1;
                mdiparent.Report_Warranty_Document_Extended_Date.Tag = 1;
                mdiparent.Report_Warranty_Document_Refund_Date.Tag = 1;
                mdiparent.Report_Warranty_Document_Due_Date.Tag = 1;
                mdiparent.Report_Warranty_Document_Date.Tag = 1;
                //------(سیستم)----------------------------------------------------------------------------------------------------------------
                mdiparent.Systems.Visible = true;
                mdiparent.System_User_Menu.Visible = true;
                mdiparent.System_Area_Menu.Visible = true;
                mdiparent.System_Activation_Menu.Visible = true;
                mdiparent.System_Chang_User_Menu.Visible = true;
                mdiparent.System_sms.Visible = true;
                //--------------------------------------------------------------------------------------------------------------------------------

                string strReportPath = GetCurrentDirectory();
                if (strReportPath.Substring(strReportPath.Length - 9) == "bin\\Debug")
                {
                    mdiparent.Report.Text = strReportPath.Substring(0, strReportPath.Length - 10);
                }
                mdiparent.Text = " سیستم مکانیزه الماس" + " " + this.Text;
                mdiparent.Show();
            }
            else
            {
                DataSet Security = PDataset("select A.*, B.* , C.* from Security_Users AS A LEFT OUTER JOIN Area AS C ON A.Area = C.Id_Area LEFT OUTER JOIN Security_Access AS B ON A.Id = B.User_Access where username=N'" + UsernameTextBox.Text + "' and password = N'" + PasswordTextBox.Text + "' ");
                if (Security.Tables[0].Rows.Count == 0)
                {
                    ShowMessage("ورود غیر مجاز", "در وارد کردن کلمه عبور و کاربری خود دقت نمائید ", frmMessage.mIcon.mStop, frmMessage.mButtons.mAccept);
                    PasswordTextBox.Text = "";
                    PasswordTextBox.Focus();
                }
                else
                {
                    foreach (DataRow Dr in Security.Tables[0].Rows)
                    {
                        if (Convert.IsDBNull(Dr["Company_Area"]))
                        {
                            ShowMessage("اخطار", "  تعاریف بخش کاربر در بانک اطلاعاتی نمی باشد", frmMessage.mIcon.mStop, frmMessage.mButtons.mAccept);
                            return;
                        }
                        else
                        {
                            this.Hide();
                            mdiparent.ID.Text = Convert.ToString(Dr["ID"]);
                            Id = Dr["ID"].ToString();
                            mdiparent.I_N.Text = Convert.ToString(Dr["username"]);
                            mdiparent.N_Id_Area.Text = Convert.ToString(Dr["Area"]);
                            mdiparent.N_Company_Area.Text = Convert.ToString(Dr["Company_Area"]);
                            mdiparent.N_Department_Area.Text = Convert.ToString(Dr["Department_Area"]);
                            mdiparent.N_Fiscal_Year_Area.Text = Convert.ToString(Dr["Fiscal_Year_Area"]);
                            mdiparent.Description.Text = Convert.ToString(Dr["Description"]);
                            mdiparent.N_Admin.Text = Convert.ToString(Dr["Admin"]);
                            if (!Convert.IsDBNull(Dr["Name_Access"]))
                            {
                                //------(خدمات)----------------------------------------------------------------------------------------------------------------
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Services.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Services.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Services_Sale_Managing.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Services_Sale_Managing.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Services_Order_Add.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Services_Order_Add.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Services_Seasonal_Buy_Sales.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Services_Seasonal_Buy_Sales.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Services_Seasonal_Buy.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Services_Seasonal_Buy.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Services_Seasonal_Sale.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Services_Seasonal_Sale.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Services_Seasonal_Contractor.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Services_Seasonal_Contractor.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Services_Seasonal_Employer.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Services_Seasonal_Employer.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Services_Seasonal_Export.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Services_Seasonal_Export.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Services_Seasonal_Importation.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Services_Seasonal_Importation.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Services_Seasonal_Contract_Work.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Services_Seasonal_Contract_Work.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Services_Seasonal_Rent.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Services_Seasonal_Rent.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Services_Seasonal_Presell.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Services_Seasonal_Presell.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Services_Edit_Access.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Services_Edit_Access.Tag = Dr["Code_Access"];
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Services_Delete_Access.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Services_Delete_Access.Tag = Dr["Code_Access"];
                                }
                                //------(حسابداری)----------------------------------------------------------------------------------------------------------------
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Accounting.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Accounting.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Accounting_Add.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Accounting_Add.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Accounting_View.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Accounting_View.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Accounting_Mechanized.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Accounting_Mechanized.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Accounting_Edit_Access.Text)
                                {
                                    mdiparent.Accounting_Edit_Access.Tag = Dr["Code_Access"];
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Accounting_Delete_Access.Text)
                                {
                                    mdiparent.Accounting_Delete_Access.Tag = Dr["Code_Access"];
                                }
                                //------(تعمیر و نگهداری)----------------------------------------------------------------------------------------------------------------
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Repair.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Repair.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Repair_Equipment.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Repair_Equipment.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Repair_Cost.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Repair_Cost.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Repair_Edit_Access.Text)
                                {
                                    mdiparent.Repair_Edit_Access.Tag = Dr["Code_Access"];
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Repair_Delete_Access.Text)
                                {
                                    mdiparent.Repair_Delete_Access.Tag = Dr["Code_Access"];
                                }
                                //------(حقوق و دستمزد)----------------------------------------------------------------------------------------------------------------

                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.PayRoll.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.PayRoll.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.PayRoll_Add.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.PayRoll_Add.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.PayRoll_Attendance_Mechanized.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.PayRoll_Attendance_Mechanized.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.PayRoll_Attendance_Manual.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.PayRoll_Attendance_Manual.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.PayRoll_Base_Information.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.PayRoll_Base_Information.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.PayRoll_Deductions.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.PayRoll_Deductions.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.PayRoll_Cure.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.PayRoll_Cure.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.PayRoll_Computing.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.PayRoll_Computing.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.PayRoll_Computing_Difference.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.PayRoll_Computing_Difference.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.PayRoll_Edit_Access.Text)
                                {
                                    mdiparent.PayRoll_Edit_Access.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.PayRoll_Delete_Access.Text)
                                {
                                    mdiparent.PayRoll_Delete_Access.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                //------(انبار)----------------------------------------------------------------------------------------------------------------
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Warehouse.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Warehouse.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Warehouse_Request_Buy_Goods.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Warehouse_Request_Buy_Goods.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Warehouse_Request_Goods.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Warehouse_Request_Goods.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Warehouse_Request_Buy.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Warehouse_Request_Buy.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Warehouse_Request_Services.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Warehouse_Request_Services.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Warehouse_Receipt_Remittance.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Warehouse_Receipt_Remittance.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Warehouse_Receipt.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Warehouse_Receipt.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Warehouse_Receipt_Buy.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Warehouse_Receipt_Buy.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Warehouse_Receipt_Return.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Warehouse_Receipt_Return.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Warehouse_Receipt_Loan.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Warehouse_Receipt_Loan.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Warehouse_Receipt_Production.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Warehouse_Receipt_Production.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Warehouse_Opening.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Warehouse_Opening.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Warehouse_Remittance.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Warehouse_Remittance.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Warehouse_Remittance.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Warehouse_Remittance.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Warehouse_Remittance.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Warehouse_Remittance.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Warehouse_Receipt_Remittance_Direct.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Warehouse_Receipt_Remittance_Direct.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Warehouse_Pricing.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Warehouse_Pricing.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Warehouse_Handling.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Warehouse_Handling.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Warehouse_Handling_Tag.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Warehouse_Handling_Tag.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Warehouse_First_Count.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Warehouse_First_Count.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Warehouse_Second_Count.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Warehouse_Second_Count.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Warehouse_Final_Count.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Warehouse_Final_Count.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Warehouse_Edit_Access.Text)
                                {
                                    mdiparent.Warehouse_Edit_Access.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Warehouse_Accounting_Access.Text)
                                {
                                    mdiparent.Warehouse_Accounting_Access.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Warehouse_Delete_Access.Text)
                                {
                                    mdiparent.Warehouse_Delete_Access.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                //------(اموال)----------------------------------------------------------------------------------------------------------------
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Assets.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Assets.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Assets_Fixed.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Assets_Fixed.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Assets_Intangible.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Assets_Intangible.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Assets_Consumable.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Assets_Consumable.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Assets_Increase.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Assets_Increase.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Assets_Decrease.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Assets_Decrease.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Assets_Movement.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Assets_Movement.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Assets_Dismiss.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Assets_Dismiss.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Assets_Revaluation.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Assets_Revaluation.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Assets_Calculate_Depreciation.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Assets_Calculate_Depreciation.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Assets_Management.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Assets_Management.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Assets_Edit_Access.Text)
                                {
                                    mdiparent.Assets_Edit_Access.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Assets_Edit_Access.Text)
                                {
                                    mdiparent.Assets_Delete_Access.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                //------(چک بانک)----------------------------------------------------------------------------------------------------------------
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Payable.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Payable.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Payable_Payment.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Payable_Payment.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Payable_Deposits.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Payable_Deposits.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Payable_Wage.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Payable_Wage.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Payable_Edit_Access.Text)
                                {
                                    mdiparent.Payable_Edit_Access.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Payable_Delete_Access.Text)
                                {
                                    mdiparent.Payable_Delete_Access.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                //------(اسناد وصولی)----------------------------------------------------------------------------------------------------------------
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Collection_Document.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Collection_Document.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Collection_Document_Add.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Collection_Document_Add.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Collection_Document_Assignment.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Collection_Document_Assignment.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Collection_Document_Notice.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Collection_Document_Notice.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Collection_Document_Back.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Collection_Document_Back.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Collection_Document_Extradition.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Collection_Document_Extradition.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Collection_Document_Reform.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Collection_Document_Reform.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Collection_Document_Edit_Access.Text)
                                {
                                    mdiparent.Collection_Document_Edit_Access.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Collection_Document_Delete_Access.Text)
                                {
                                    mdiparent.Collection_Document_Delete_Access.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                //------(اسناد ضمانتی)----------------------------------------------------------------------------------------------------------------
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Warranty_Document.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Warranty_Document.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Warranty_Document_Add.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Warranty_Document_Add.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Warranty_Document_Extended.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Warranty_Document_Extended.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Warranty_Document_Refund.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Warranty_Document_Refund.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Warranty_Document_Reform.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Warranty_Document_Reform.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Warranty_Document_Edit_Access.Text)
                                {
                                    mdiparent.Warranty_Document_Edit_Access.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Warranty_Document_Delete_Access.Text)
                                {
                                    mdiparent.Warranty_Document_Delete_Access.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                //------(اطلاعات پایه)----------------------------------------------------------------------------------------------------------------
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Base_Information.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Base_Information.Visible = true;
                                }
                                //------(اطلاعات پایه خدمات)----------------------------------------------------------------------------------------------------------------
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Base_Information_Services.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Base_Information_Services.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Base_Information_Services_Seasonal_Buy_Sales.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Base_Information_Services_Seasonal_Buy_Sales.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Base_Seasonal_Product_Type.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Base_Seasonal_Product_Type.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Base_Information_Services_Order.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Base_Information_Services_Order.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Base_Information_Services_Order_Customer.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Base_Information_Services_Order_Customer.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Base_Information_Services_Order_In_Services.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Base_Information_Services_Order_In_Services.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Base_Information_Services_Order_Out_Services.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Base_Information_Services_Order_Out_Services.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Base_Information_Services_Order_Opertor.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Base_Information_Services_Order_Opertor.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Base_Information_Services_Order_Rate.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Base_Information_Services_Order_Rate.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Base_Information_Services_Edit_Access.Text)
                                {
                                    mdiparent.Base_Information_Services_Edit_Access.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Base_Information_Services_Delete_Access.Text)
                                {
                                    mdiparent.Base_Information_Services_Delete_Access.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                //------(اطلاعات پایه حسابداری)----------------------------------------------------------------------------------------------------------------
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Base_Information_Accounting.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Base_Information_Accounting.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Base_Information_Accounting_Account_Tree.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Base_Information_Accounting_Account_Tree.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Base_Information_Accounting_Detailed_Tree.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Base_Information_Accounting_Detailed_Tree.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Base_Information_Accounting_Edit_Access.Text)
                                {
                                    mdiparent.Base_Information_Accounting_Edit_Access.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Base_Information_Accounting_Delete_Access.Text)
                                {
                                    mdiparent.Base_Information_Accounting_Delete_Access.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                //------(اطلاعات پایه تعمیرو نگهداری)----------------------------------------------------------------------------------------------------------------
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Base_Information_Repair.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Base_Information_Repair.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Base_Information_Repair_Seating.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Base_Information_Repair_Seating.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Base_Information_Repair_Energy.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Base_Information_Repair_Energy.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Base_Information_Repair_Phase.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Base_Information_Repair_Phase.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Base_Information_Repair_Kind_Stream.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Base_Information_Repair_Kind_Stream.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Base_Information_Repair_Kind_Fuse.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Base_Information_Repair_Kind_Fuse.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Base_Information_Repair_Connector_Type.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Base_Information_Repair_Connector_Type.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Base_Information_Repair_Stop_Defect.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Base_Information_Repair_Stop_Defect.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Base_Information_Repair_Edit_Access.Text)
                                {
                                    mdiparent.Base_Information_Repair_Edit_Access.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Base_Information_Repair_Delete_Access.Text)
                                {
                                    mdiparent.Base_Information_Repair_Delete_Access.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                //------(اطلاعات پایه حقوق)----------------------------------------------------------------------------------------------------------------
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Base_Information_PayRoll.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Base_Information_PayRoll.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Base_Information_PayRoll_Personal.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Base_Information_PayRoll_Personal.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Base_Information_PayRoll_Employment.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Base_Information_PayRoll_Employment.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Base_Information_PayRoll_Deductions_Legal.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Base_Information_PayRoll_Deductions_Legal.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Base_Information_PayRoll_Deductions_Diffrent.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Base_Information_PayRoll_Deductions_Diffrent.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Base_Information_PayRoll_Family.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Base_Information_PayRoll_Family.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Base_Information_PayRoll_Calandar.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Base_Information_PayRoll_Calandar.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Base_Information_PayRoll_Edit_Access.Text)
                                {
                                    mdiparent.Base_Information_PayRoll_Edit_Access.Text = Convert.ToString(Dr["Code_Access"]);
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Base_Information_PayRoll_Delete_Access.Text)
                                {
                                    mdiparent.Base_Information_PayRoll_Delete_Access.Text = Convert.ToString(Dr["Code_Access"]);
                                }
                                //------(اطلاعات پایه انبار)----------------------------------------------------------------------------------------------------------------
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Base_Information_Warehouse.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Base_Information_Warehouse.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Base_Information_Warehouse_Units.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Base_Information_Warehouse_Units.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Base_Information_Warehouse_Sources.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Base_Information_Warehouse_Sources.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Base_Information_Warehouse_Unit_Goods.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Base_Information_Warehouse_Unit_Goods.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Base_Information_Warehouse_Grouping_Goods.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Base_Information_Warehouse_Grouping_Goods.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Base_Information_Warehouse_Collection_Goods.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Base_Information_Warehouse_Collection_Goods.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Base_Information_Warehouse_Edit_Access.Text)
                                {
                                    mdiparent.Base_Information_Warehouse_Edit_Access.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Base_Information_Warehouse_Delete_Access.Text)
                                {
                                    mdiparent.Base_Information_Warehouse_Delete_Access.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                //------(اطلاعات پایه اموال)----------------------------------------------------------------------------------------------------------------
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Base_Information_Assets.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Base_Information_Assets.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Base_Information_Assets_Depreciation_Rate.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Base_Information_Assets_Depreciation_Rate.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Base_Information_Assets_Plan_project.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Base_Information_Assets_Plan_project.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Base_Information_Assets_City.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Base_Information_Assets_City.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Base_Information_Assets_Personnel.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Base_Information_Assets_Personnel.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Base_Information_Assets_Cost_Code.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Base_Information_Assets_Cost_Code.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Base_Information_Assets_Date.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Base_Information_Assets_Date.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Base_Information_Assets_Edit_Access.Text)
                                {
                                    mdiparent.Base_Information_Assets_Edit_Access.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Base_Information_Assets_Delete_Access.Text)
                                {
                                    mdiparent.Base_Information_Assets_Delete_Access.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                //------(اطلاعات پایه اسناد)----------------------------------------------------------------------------------------------------------------
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Base_Information_Document.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Base_Information_Document.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Base_Information_Document_Customer.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Base_Information_Document_Customer.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Base_Information_Document_Area.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Base_Information_Document_Area.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Base_Information_Document_Bank.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Base_Information_Document_Bank.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Base_Information_Document_Recovery_Classification.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Base_Information_Document_Recovery_Classification.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Base_Information_Warranty_Document_Classification.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Base_Information_Warranty_Document_Classification.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Base_Information_Document_Edit_Access.Text)
                                {
                                    mdiparent.Base_Information_Document_Edit_Access.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Base_Information_Document_Delete_Access.Text)
                                {
                                    mdiparent.Base_Information_Document_Delete_Access.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                //------(گزارشات)----------------------------------------------------------------------------------------------------------------
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Reports.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Reports.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Reports.Text)
                                {
                                    mdiparent.Reports.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                //------(گزارشات خدمات)----------------------------------------------------------------------------------------------------------------
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Report_Services.Text)
                                {
                                    mdiparent.Report_Services.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                //------(گزارشات حسابداری)----------------------------------------------------------------------------------------------------------------
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Report_Accounting.Text)
                                {
                                    mdiparent.Report_Accounting.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Report_Accounting_Note_Book.Text)
                                {
                                    mdiparent.Report_Accounting_Note_Book.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Report_Accounting_Account_Note_Book.Text)
                                {
                                    mdiparent.Report_Accounting_Account_Note_Book.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Report_Accounting_Details_Note_One_Book.Text)
                                {
                                    mdiparent.Report_Accounting_Details_Note_One_Book.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Report_Accounting_Details_Note_Two_Book.Text)
                                {
                                    mdiparent.Report_Accounting_Details_Note_Two_Book.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Report_Accounting_Details_Note_Three_Book.Text)
                                {
                                    mdiparent.Report_Accounting_Details_Note_Three_Book.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Report_Accounting_Details_Note_Four_Book.Text)
                                {
                                    mdiparent.Report_Accounting_Details_Note_Four_Book.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Report_Accounting_Details_Note_Five_Book.Text)
                                {
                                    mdiparent.Report_Accounting_Details_Note_Five_Book.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Report_Accounting_Align.Text)
                                {
                                    mdiparent.Report_Accounting_Align.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Report_Accounting_Four_Column_Align.Text)
                                {
                                    mdiparent.Report_Accounting_Four_Column_Align.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Report_Accounting_Details_Four_Column_Align.Text)
                                {
                                    mdiparent.Report_Accounting_Details_Four_Column_Align.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Report_Accounting_Eight_Column_Align.Text)
                                {
                                    mdiparent.Report_Accounting_Eight_Column_Align.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Report_Accounting_Details_Eight_Column_Align.Text)
                                {
                                    mdiparent.Report_Accounting_Details_Eight_Column_Align.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Report_Accounting_Reports.Text)
                                {
                                    mdiparent.Report_Accounting_Reports.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Report_Accounting_Details.Text)
                                {
                                    mdiparent.Report_Accounting_Details.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Report_Accounting_Analysis.Text)
                                {
                                    mdiparent.Report_Accounting_Analysis.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                //------(گزارشات تعمیر و نگهداری)----------------------------------------------------------------------------------------------------------------
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Report_Repair.Text)
                                {
                                    mdiparent.Report_Repair.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                //------(گزارشات حقوق و دستمزد)----------------------------------------------------------------------------------------------------------------
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Report_PayRoll.Text)
                                {
                                    mdiparent.Report_PayRoll.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                //------(گزارشات انبار)----------------------------------------------------------------------------------------------------------------
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Report_Warehouse.Text)
                                {
                                    mdiparent.Report_Warehouse.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Report_Warehouse_Number.Text)
                                {
                                    mdiparent.Report_Warehouse_Number.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Report_Warehouse_Cardx.Text)
                                {
                                    mdiparent.Report_Warehouse_Cardx.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Report_Warehouse_Turnover.Text)
                                {
                                    mdiparent.Report_Warehouse_Turnover.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Report_Warehouse_Inventory.Text)
                                {
                                    mdiparent.Report_Warehouse_Inventory.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Report_Warehouse_Accounting.Text)
                                {
                                    mdiparent.Report_Warehouse_Accounting.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Report_Warehouse_Accounting_Cardx.Text)
                                {
                                    mdiparent.Report_Warehouse_Accounting_Cardx.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Report_Warehouse_Accounting_Turnover.Text)
                                {
                                    mdiparent.Report_Warehouse_Accounting_Turnover.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Report_Warehouse_Accounting_Inventory.Text)
                                {
                                    mdiparent.Report_Warehouse_Accounting_Inventory.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Report_Warehouse_Handling.Text)
                                {
                                    mdiparent.Report_Warehouse_Handling.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Report_Warehouse_Handling_One_Counts.Text)
                                {
                                    mdiparent.Report_Warehouse_Handling_One_Counts.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Report_Warehouse_Handling_Two_Counts.Text)
                                {
                                    mdiparent.Report_Warehouse_Handling_Two_Counts.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Report_Warehouse_Handling_Third_Counts.Text)
                                {
                                    mdiparent.Report_Warehouse_Handling_Third_Counts.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                //------(گزارشات اموال و دارائی های ثابت)----------------------------------------------------------------------------------------------------------------
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Report_Estate.Text)
                                {
                                    mdiparent.Report_Estate.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Report_Estate_Responsible.Text)
                                {
                                    mdiparent.Report_Estate_Responsible.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Report_Estate_Consumable_Delivering.Text)
                                {
                                    mdiparent.Report_Estate_Consumable_Delivering.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Report_Estate_Delivering.Text)
                                {
                                    mdiparent.Report_Estate_Delivering.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Report_Consumable_Delivering.Text)
                                {
                                    mdiparent.Report_Consumable_Delivering.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Report_Estate_Accountants.Text)
                                {
                                    mdiparent.Report_Estate_Accountants.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Report_Estate_Facial.Text)
                                {
                                    mdiparent.Report_Estate_Facial.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Report_Estate_Original_Code.Text)
                                {
                                    mdiparent.Report_Estate_Original_Code.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Report_Estate_Cost_Code.Text)
                                {
                                    mdiparent.Report_Estate_Cost_Code.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Report_Estate_Cost_Original.Text)
                                {
                                    mdiparent.Report_Estate_Cost_Original.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Report_Estate_Original_Cost.Text)
                                {
                                    mdiparent.Report_Estate_Original_Cost.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Report_Estate_Original_Cost_City.Text)
                                {
                                    mdiparent.Report_Estate_Original_Cost_City.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Report_Estate_Decrease.Text)
                                {
                                    mdiparent.Report_Estate_Decrease.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Report_Estate_Dismiss.Text)
                                {
                                    mdiparent.Report_Estate_Dismiss.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Report_Estate_Document_Cost.Text)
                                {
                                    mdiparent.Report_Estate_Document_Cost.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Report_Estate_Document_Original.Text)
                                {
                                    mdiparent.Report_Estate_Document_Original.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Report_Estate_Document_Dismiss.Text)
                                {
                                    mdiparent.Report_Estate_Document_Dismiss.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                //------(گزارشات ثبت چک بانک)----------------------------------------------------------------------------------------------------------------
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Report_Payable.Text)
                                {
                                    mdiparent.Report_Payable.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Report_Payable_Turnover.Text)
                                {
                                    mdiparent.Report_Payable_Turnover.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Report_Payable_Checked_Out.Text)
                                {
                                    mdiparent.Report_Payable_Checked_Out.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Report_Payable_Deposits.Text)
                                {
                                    mdiparent.Report_Payable_Deposits.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Report_Payable_Wage.Text)
                                {
                                    mdiparent.Report_Payable_Wage.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                //------(گزارشات اسناد وصولی)----------------------------------------------------------------------------------------------------------------
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Report_Collection_Document.Text)
                                {
                                    mdiparent.Report_Collection_Document.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Report_Collection_Document_Add.Text)
                                {
                                    mdiparent.Report_Collection_Document_Add.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Report_Collection_Document_Due_Date.Text)
                                {
                                    mdiparent.Report_Collection_Document_Due_Date.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Report_Collection_Document_Assignment.Text)
                                {
                                    mdiparent.Report_Collection_Document_Assignment.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Report_Collection_Document_Notice.Text)
                                {
                                    mdiparent.Report_Collection_Document_Notice.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Report_Collection_Document_Back.Text)
                                {
                                    mdiparent.Report_Collection_Document_Back.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Report_Collection_Document_Refund_Date.Text)
                                {
                                    mdiparent.Report_Collection_Document_Refund_Date.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Report_Collection_Document_Receipt.Text)
                                {
                                    mdiparent.Report_Collection_Document_Receipt.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                //------(گزارشات اسناد ضمانتی)----------------------------------------------------------------------------------------------------------------
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Report_Warranty_Document.Text)
                                {
                                    mdiparent.Report_Warranty_Document.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Report_Warranty_Document_No_Date.Text)
                                {
                                    mdiparent.Report_Warranty_Document_No_Date.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Report_Warranty_Document_Extended_Date.Text)
                                {
                                    mdiparent.Report_Warranty_Document_Extended_Date.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Report_Warranty_Document_Refund_Date.Text)
                                {
                                    mdiparent.Report_Warranty_Document_Refund_Date.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Report_Warranty_Document_Due_Date.Text)
                                {
                                    mdiparent.Report_Warranty_Document_Due_Date.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Report_Warranty_Document_Date.Text)
                                {
                                    mdiparent.Report_Warranty_Document_Date.Tag = Convert.ToString(Dr["Code_Access"]);
                                }
                                //------(نمایش)----------------------------------------------------------------------------------------------------------------
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.View.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.View.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.View_Menu_Toolbox.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.View_Menu_Toolbox.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.View_Menu_Subtitle.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.View_Menu_Subtitle.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.View_Menu_Help.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.View_Menu_Help.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.View_Menu_Log.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.View_Menu_Log.Visible = true;
                                }
                                //------(سیستم)----------------------------------------------------------------------------------------------------------------
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.Systems.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.Systems.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.System_User_Menu.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.System_User_Menu.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.System_Area_Menu.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.System_Area_Menu.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.System_Activation_Menu.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.System_Activation_Menu.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.System_Chang_User_Menu.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.System_Chang_User_Menu.Visible = true;
                                }
                                if (Convert.ToString(Dr["Name_Access"]) == mdiparent.System_sms.Text && Convert.ToString(Dr["Code_Access"]) == "1")
                                {
                                    mdiparent.System_sms.Visible = true;
                                }
                                //-------------------------------------------------------------

                            }
                            string strReportPath = GetCurrentDirectory();
                            if (strReportPath.Substring(strReportPath.Length - 9) == "bin\\Debug")
                            {
                                mdiparent.Report.Text = strReportPath.Substring(0, strReportPath.Length - 10);
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
                    if (mdiparent.N_Admin.Text == "False")
                    {
                        f_select += "and Warranty_Document_Area = " + mdiparent.N_Id_Area.Text + "";
                    }
                    f_select += "UNION select A.*,B.*,C.* from Warranty_Document A left join Base_Information B on A.Warranty_Document_Case=B.Base_Information_Id left join Counterparty C on A.Warranty_Document_Subscription=C.Counterparty_ID where ";
                    f_select += "Warranty_Document_Operation not in (1,2) ";
                    f_select += "and Warranty_Document_Due_Date >= '" + NumericHelper.Val(DateTime.Today.ToString().Replace("/", "")) + "'";
                    f_select += "and Warranty_Document_Due_Date <= '" + NumericHelper.Val(Next_Month.Replace("/", "")) + "'";
                    if (mdiparent.N_Admin.Text == "False")
                    {
                        f_select += "and Warranty_Document_Area = " + mdiparent.N_Id_Area.Text + "";
                    }
                    DataSet Warranty = PDataset("" + f_select + "");
                    mdiparent.Label_Warranty.Text = (Warranty.Tables[0].Rows.Count).ToString();
                    f_select = "";
                    f_select += "select A.*,B.*,C.*,D.* from Recovery_Documents A ";
                    f_select += "left join Base_Information B on Recovery_Documents_Case=Base_Information_Id ";
                    f_select += "left join Counterparty C on Recovery_Documents_Subscription=Counterparty_ID ";
                    f_select += "left join Bank D on Recovery_Documents_Collecting_Bank=Bank_ID ";
                    f_select += "where Recovery_Documents_Operation not in (2,3,4) ";
                    f_select += "and Recovery_Documents_Due_Date >= '" + NumericHelper.Val(DateTime.Today.ToString().Replace("/", "")) + "'";
                    f_select += "and Recovery_Documents_Due_Date <= '" + NumericHelper.Val(Next_Month.Replace("/", "")) + "'";
                    if (mdiparent.N_Admin.Text == "False")
                    {
                        f_select += "and Recovery_Documents_Area = " + mdiparent.N_Id_Area.Text + "";
                    }
                    DataSet Collection = PDataset("" + f_select + "");
                    mdiparent.Label_Collection.Text = (Collection.Tables[0].Rows.Count).ToString();
                    mdiparent.Show();
                }
            }
        }
    }
}
