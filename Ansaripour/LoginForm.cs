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
                MDIParent1.DefaultInstance.Id.Text = "1311";
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
                MDIParent1.DefaultInstance.PayRoll.Visible = true;
                MDIParent1.DefaultInstance.PayRoll_Add.Visible = true;
                MDIParent1.DefaultInstance.PayRoll_Attendance_Mechanized.Visible = true;

            }
        }
    }
}