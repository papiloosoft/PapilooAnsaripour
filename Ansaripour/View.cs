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

using Microsoft.Office.Interop;

namespace Ansaripour
{
	public partial class View
	{
		public View()
		{
			InitializeComponent();
		}

		private string f_serch; //تابع متغیر فرمول جستجو
		private string f_select; //تابع متغیر فرمول جستجو
		public string Var_Clas;
		private string R_C;
		private Resizer rs = new Resizer();
		private void Warranty_Search()
		{
			f_select = "";
			f_select = "select A.*,B.*,C.* from Warranty_Document A left join Base_Information B on A.Warranty_Document_Case=B.Base_Information_Id left join Counterparty C on A.Warranty_Document_Subscription=C.Counterparty_ID where ";
			f_select += "Warranty_Document_Operation not in (2) ";
			f_select += "and Warranty_Document_Extended_Date >= '" + NumericHelper.Val(data.today().Replace("/", "")) + "'";
			f_select += "and Warranty_Document_Extended_Date <= '" + NumericHelper.Val(data.Next_Month().Replace("/", "")) + "'";
			if (MDIParent1.DefaultInstance.N_Admin.Text == "False")
			{
				f_select += "and Warranty_Document_Area = " + MDIParent1.DefaultInstance.N_Id_Area.Text + "";
			}
			f_select += f_serch;
			f_select += " UNION select A.*,B.*,C.* from Warranty_Document A left join Base_Information B on A.Warranty_Document_Case=B.Base_Information_Id left join Counterparty C on A.Warranty_Document_Subscription=C.Counterparty_ID where ";
			f_select += "Warranty_Document_Operation not in (1,2) ";
			f_select += "and Warranty_Document_Due_Date >= '" + NumericHelper.Val(data.today().Replace("/", "")) + "'";
			f_select += "and Warranty_Document_Due_Date <= '" + NumericHelper.Val(data.Next_Month().Replace("/", "")) + "'";
			if (MDIParent1.DefaultInstance.N_Admin.Text == "False")
			{
				f_select += "and Warranty_Document_Area = " + MDIParent1.DefaultInstance.N_Id_Area.Text + "";
			}
			f_select += f_serch;
		}
		private void Warranty()
		{
			DV.Rows.Clear();
			DV.Columns.Clear();
			DV.Columns.Add("row", "ردیف");
			DV.Columns.Add("Warranty_Document_Id", "ثبت");
			DV.Columns.Add("Warranty_Document_Subscription", "اشتراک");
			DV.Columns["Warranty_Document_Subscription"].Visible = true;
			DV.Columns.Add("Warranty_Document_Due_Date", "تاریخ سررسید");
			DV.Columns["Warranty_Document_Due_Date"].Visible = true;
			DV.Columns.Add("Warranty_Document_Extended_Date", "تاریخ تمدید");
			DV.Columns["Warranty_Document_Extended_Date"].Visible = true;
			DV.Columns.Add("Warranty_Document_Number", "شماره ضمانت نامه");
			DV.Columns["Warranty_Document_Number"].Visible = true;
			DV.Columns.Add("Warranty_Document_No_Check", "شماره چک");
			DV.Columns["Warranty_Document_No_Check"].Visible = true;
			DV.Columns.Add("Warranty_Document_Subscription_Id", "آی دی");
			DV.Columns["Warranty_Document_Subscription_Id"].Visible = false;
			DV.Columns.Add("Warranty_Document_No_Date", "تاریخ ثبت");
			DV.Columns["Warranty_Document_No_Date"].Visible = false;
			DV.Columns.Add("Warranty_Document_Bank", "نام بانک");
			DV.Columns["Warranty_Document_Bank"].Visible = true;
			DV.Columns.Add("Warranty_Document_Amount", "مبلغ ضمانت نامه");
			DV.Columns["Warranty_Document_Amount"].Visible = true;
			DV.Columns.Add("Warranty_Document_Account_Number", "شماره حساب");
			DV.Columns["Warranty_Document_Account_Number"].Visible = false;
			DV.Columns.Add("Warranty_Document_Case", "بابت");
			DV.Columns["Warranty_Document_Case"].Visible = true;
			DV.Columns.Add("Warranty_Document_Refund_Date", "تاریخ استرداد");
			DV.Columns["Warranty_Document_Refund_Date"].Visible = false;
			DV.Columns.Add("Warranty_Document_Date", "تاریخ ضمانت نامه");
			DV.Columns["Warranty_Document_Date"].Visible = false;
			DV.Columns.Add("Warranty_Document_Operation", "عملیات");
			DV.Columns["Warranty_Document_Operation"].Visible = false;
			DV.Columns.Add("Warranty_Document_Contract_Number", "شماره قرارداد");
			DV.Columns["Warranty_Document_Contract_Number"].Visible = false;
			DV.Columns.Add("Warranty_Document_Contract_Date", "تاریخ قرارداد");
			DV.Columns["Warranty_Document_Contract_Date"].Visible = false;
			DV.Columns.Add("Warranty_Document_Branch", "شعبه بانک");
			DV.Columns["Warranty_Document_Branch"].Visible = false;
			DV.Columns.Add("Warranty_Document_Description", "توضیحات");
			DV.Columns["Warranty_Document_Description"].Visible = false;
			DV.Columns["row"].Width = 50;
			DV.Columns["Warranty_Document_Id"].Width = 50;
			DV.Columns["Warranty_Document_Subscription"].Width = 200;
			DV.Columns["Warranty_Document_Due_Date"].Width = 100;
			DV.Columns["Warranty_Document_Extended_Date"].Width = 100;
			DV.Columns["Warranty_Document_Number"].Width = 120;
			DV.Columns["Warranty_Document_No_Check"].Width = 120;
			DV.Columns["Warranty_Document_Bank"].Width = 100;
			DV.Columns["Warranty_Document_Amount"].Width = 200;
			DV.Columns["Warranty_Document_Case"].Width = 150;
			DV.AllowUserToAddRows = false;
			DV.EditMode = DataGridViewEditMode.EditProgrammatically;
			Warranty_Search();
			DataSet Warranty = data.PDataset("" + f_select + "");
			if (Warranty.Tables[0].Rows.Count == 0)
			{
				modMessage.ShowMessage("کاربر محترم" + " :" + MDIParent1.DefaultInstance.I_N.Text, " اطلاعات مورد نظر شما در سیستم وجود ندارد", frmMessage.mIcon.mserch, frmMessage.mButtons.mAccept);
			}
			else
			{
				foreach (DataRow Dr in Warranty.Tables[0].Rows)
				{
					DV.Rows.Add();
					System.Windows.Forms.DataGridViewRow tempVar = DV.Rows[DV.Rows.Count - 1];
					tempVar.Cells["row"].Value = DV.Rows.Count;
					tempVar.Cells["Warranty_Document_Id"].Value = Dr["Warranty_Document_Id"];
					tempVar.Cells["Warranty_Document_Subscription"].Value = Dr["Counterparty_Subscribe"].ToString() + " - " + Dr["Counterparty_Name"].ToString() + " - " + Dr["Counterparty_Family"].ToString();

//====================================================================================================
//End of the allowed output for the Free Edition of Instant C#.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-instant-csharp.html
//====================================================================================================
