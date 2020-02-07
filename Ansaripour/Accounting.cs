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

namespace Ansaripour
{
    public partial class Accounting
    {
        public Accounting()
        {
            InitializeComponent();
        }

        private bool Add; //جداسازی ذخیره جدید و ویرایش
        private bool Edit; //جداسازی ذخیره جدید و ویرایش
        private bool CopyAccounting;
        private string f_serch; //تابع متغیر فرمول جستجو
        private string Id_Refrence;
        private string Bed;
        private string Bes;
        private int err;
        private string log;
        private string Log_Details;
        private int PasteRowIndex;
        private int CopyRowIndex;
        private Resizer rs = new Resizer();
        private void Log_Details_Get()
        {
            Log_Details = "";
            Log_Details += Accounting_Header_Number.Text + "-" + Accounting_Header_Date.T_D + "-";
            Log_Details += Accounting_Header_Description.Text + "-" + Accounting_Header_Class.SelectedIndex + "صورت ریز سند";
            foreach (DataGridViewRow row in Dv_Accounting.Rows)
            {
                Log_Details += row.Cells["Accounting_Details_Row"].Value.ToString() + "-";
                Log_Details += row.Cells["Accounting_Details_Acc"].Value.ToString() + "-";
                Log_Details += row.Cells["Accounting_Details_Acc_Id"].Value.ToString() + "-";
                Log_Details += row.Cells["Accounting_Details_Acc_Name"].Value.ToString() + "-";
                Log_Details += row.Cells["Accounting_Details_Detailed_One"].Value.ToString() + "-";
                Log_Details += row.Cells["Accounting_Details_Detailed_One_Id"].Value.ToString() + "-";
                Log_Details += row.Cells["Accounting_Details_Detailed_One_Name"].Value.ToString() + "-";
                Log_Details += row.Cells["Accounting_Details_Detailed_Two"].Value.ToString() + "-";
                Log_Details += row.Cells["Accounting_Details_Detailed_Two_Id"].Value.ToString() + "-";
                Log_Details += row.Cells["Accounting_Details_Detailed_Two_Name"].Value.ToString() + "-";
                Log_Details += row.Cells["Accounting_Details_Detailed_Three"].Value.ToString() + "-";
                Log_Details += row.Cells["Accounting_Details_Detailed_Three_Id"].Value.ToString() + "-";
                Log_Details += row.Cells["Accounting_Details_Detailed_Three_Name"].Value.ToString() + "-";
                Log_Details += row.Cells["Accounting_Details_Detailed_Four"].Value.ToString() + "-";
                Log_Details += row.Cells["Accounting_Details_Detailed_Four_Id"].Value.ToString() + "-";
                Log_Details += row.Cells["Accounting_Details_Detailed_Four_Name"].Value.ToString() + "-";
                Log_Details += row.Cells["Accounting_Details_Detailed_Five"].Value.ToString() + "-";
                Log_Details += row.Cells["Accounting_Details_Detailed_Five_Id"].Value.ToString() + "-";
                Log_Details += row.Cells["Accounting_Details_Detailed_Five_Name"].Value.ToString() + "-";
                Log_Details += row.Cells["Accounting_Details_Debtor"].Value.ToString() + "-";
                Log_Details += row.Cells["Accounting_Details_Creditor"].Value.ToString() + "-";
                Log_Details += row.Cells["Accounting_Details_Description"].Value.ToString() + "-";
                Log_Details += row.Cells["Accounting_Details_Date_Cost"].Value.ToString() + "-";
                Log_Details += row.Cells["Accounting_Details_Number_Due"].Value.ToString() + "-";
                Log_Details += row.Cells["Accounting_Details_Date_Due"].Value.ToString() + "-";
                Log_Details += Convert.ToString(row.Cells["Accounting_Details_Number_Turning"].Value);
            }
        }
        private void Log_Save()
        {
            f_serch = "";
            f_serch += "INSERT INTO Log_File (Log_Process,Log_Table,Log_Date, Log_Time, Log_Operation,Log_Details,Log_User_Id)";
            f_serch += "VALUES  (N'" + Id_Refrence + "',";
            f_serch += "'Accounting',";
            f_serch += "N'" + data.today().Replace("/", "") + "',";
            f_serch += "N'" + DateTime.Now.ToString("hh:mm:ss tt") + "',";
            f_serch += "N'" + log + "',";
            f_serch += "N'" + Log_Details + "',";
            f_serch += "N'" + MDIParent1.DefaultInstance.ID.Text + "')";
            DataSet Save_log = data.PDataset("" + f_serch + "");
        }
        private void Accounting_Load(object sender, System.EventArgs e)
        {
            rs.FindAllControls(this);
            Accounting_Header_Class.SelectedIndex = 0;
            this.KeyPreview = true;
        }
        private void Dv_Details_Get()
        {
            Dv_Accounting.Rows.Clear();
            Dv_Accounting.Columns.Clear();
            Dv_Accounting.Controls.Clear();
            Dv_Accounting.Columns.Add("Accounting_Details_Row", "رديف");
            Dv_Accounting.Columns.Add("Accounting_Details_Acc", "کد حساب");
            Dv_Accounting.Columns.Add("Accounting_Details_Acc_Id", "");
            Dv_Accounting.Columns.Add("Accounting_Details_Acc_Name", "شرح حساب");
            Dv_Accounting.Columns.Add("Accounting_Details_Detailed_One", "کد تفصیل 1");
            Dv_Accounting.Columns.Add("Accounting_Details_Detailed_One_Id", "");
            Dv_Accounting.Columns.Add("Accounting_Details_Detailed_One_Name", "");
            Dv_Accounting.Columns.Add("Accounting_Details_Detailed_Two", "کد تفصیل 2");
            Dv_Accounting.Columns.Add("Accounting_Details_Detailed_Two_Id", "");
            Dv_Accounting.Columns.Add("Accounting_Details_Detailed_Two_Name", "");
            Dv_Accounting.Columns.Add("Accounting_Details_Detailed_Three", "کد تفصیل 3");
            Dv_Accounting.Columns.Add("Accounting_Details_Detailed_Three_Id", "");
            Dv_Accounting.Columns.Add("Accounting_Details_Detailed_Three_Name", "");
            Dv_Accounting.Columns.Add("Accounting_Details_Detailed_Four", "کد تفصیل 4");
            Dv_Accounting.Columns.Add("Accounting_Details_Detailed_Four_Id", "");
            Dv_Accounting.Columns.Add("Accounting_Details_Detailed_Four_Name", "");
            Dv_Accounting.Columns.Add("Accounting_Details_Detailed_Five", "کد تفصیل 5");
            Dv_Accounting.Columns.Add("Accounting_Details_Detailed_Five_Id", "");
            Dv_Accounting.Columns.Add("Accounting_Details_Detailed_Five_Name", "");
            Dv_Accounting.Columns.Add("Accounting_Details_Debtor", "بدهکار");
            Dv_Accounting.Columns.Add("Accounting_Details_Creditor", "بستانکار");
            Dv_Accounting.Columns.Add("Accounting_Details_Description", "شرح عملیات");
            Dv_Accounting.Columns.Add("Accounting_Details_Date_Cost", "");

        }
    }
}
