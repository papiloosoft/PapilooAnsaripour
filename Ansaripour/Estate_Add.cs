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
using System.Linq;
using System.Xml.Linq;

using static System.IO.Directory;
using System.Windows.Forms;
using Microsoft.Office.Interop;

namespace Ansaripour
{
	public partial class Estate_Add
	{
		public Estate_Add()
		{
			InitializeComponent();
		}

		private string City_Id;
		private string Acc_Original_Id;
		private string Acc_Sub_Id;
		private string Cost_Id;
		private string Personal_Id;
		private string Plan_Id;
		private string Project_Id;
		public string Var_Clas;
		private bool Add; //جداسازی ذخیره جدید و ویرایش
		private string f_serch; //تابع متغیر فرمول جستجو
		private string f_Select; //تابع متغیر فرمول جستجو
		private string F_Report;
		private string Str_label;
		private string Str_Id_Refrence;
		private string Str_Data;
		private string Str_Date;
		private string Log_Details;
		private string log;
		private int err;
		private int cunt;
		private Resizer rs = new Resizer();
		private void Dv_Get()
		{
			DV.Rows.Clear();
			DV.Columns.Clear();
			DV.Columns.Add("row", "ردیف");
			DV.Columns.Add("Acc_Code", "کد دارائی");
			DV.Columns.Add("Estate_Name", "شرح دارائی");
			DV.Columns.Add("Estate_Control", "کنترل");
			DV.Columns.Add("Estate_Date_Price", "تاریخ ثبت");
			DV.Columns.Add("Estate_Date_Revaluation", "تجدیدارزیابی");
			switch (Convert.ToInt32(Var_Clas))
			{
				case 9:
					DV.Columns.Add("Estate_Count", "عمر باقیمانده");
					DV.Columns.Add("Day_Count", "تعداد روز");
					DV.Columns.Add("Book_Value_Count", "مانده ارزش دفتری");
					DV.Columns["Estate_Count"].Width = 120;
					DV.Columns["Day_Count"].Width = 120;
					DV.Columns["Book_Value_Count"].Width = 140;
					break;
				default:
				break;
			}
			DV.Columns.Add("Estate_Price", "قیمت تمام شده");
			DV.Columns.Add("Estate_Price_Debtor", "افزایش طی دوره");
			DV.Columns.Add("Estate_Price_Creditor", "کــاهش قیمت");
			DV.Columns.Add("Estate_Depreciation_To", "ذخیره طی دوره");
			DV.Columns.Add("Estate_Depreciation", "ذخیره استهلاک");
			DV.Columns.Add("Estate_Depreciation_Debtor", "استهلاک طی دوره");
			DV.Columns.Add("Estate_Depreciation_Creditor", "کاهش استهلاک");
			DV.Columns.Add("Book_Value", "ارزش دفتری");
			DV.Columns.Add("Acc_Operation", "روش محاسبه");
			DV.Columns.Add("Acc_Ctrl", "");
			DV.Columns.Add("Acc_Case", "");
			DV.Columns.Add("Estate_No_Personnel", "تحویل گیرنده");
			DV.Columns.Add("Estate_City", "");
			DV.Columns.Add("Estate_Original_Code", "");
			DV.Columns.Add("Estate_Sub_Code", "");
			DV.Columns.Add("Estate_Cost_Code", "");
			DV.Columns.Add("Estate_No_Remittance", "");
			DV.Columns.Add("Estate_Date_Remittance", "");
			DV.Columns.Add("Estate_Plaque", "");
			DV.Columns.Add("Estate_Description", "");
			DV.Columns.Add("Estate_Date_From", "");
			DV.Columns.Add("Estate_No_Document", "");
			DV.Columns.Add("Estate_Date_Document", "");
			DV.Columns.Add("Estate_Id", "");
			DV.Columns.Add("Dismissal_Date_Price", "");
			DV.Columns.Add("Dismissal_No_Document", "");
			DV.Columns.Add("Dismissal_Date_Document", "");
			DV.Columns.Add("Dismissal_Description", "");
			DV.Columns.Add("Estate_Id_Refrence", "");
			DV.Columns.Add("City_Id", "");
			DV.Columns.Add("Acc_Original_Id", "");
			DV.Columns.Add("Acc_Sub_Id", "");
			DV.Columns.Add("Cost_Id", "");
			DV.Columns.Add("Personal_Id", "");
			DV.Columns.Add("Plan_Id", "");
			DV.Columns.Add("Project_Id", "");
			DV.Columns.Add("Estate_Plan", "");
			DV.Columns.Add("Estate_Project", "");
			DV.Columns["Estate_City"].Visible = false;
			DV.Columns["Estate_Original_Code"].Visible = false;
			DV.Columns["Estate_Sub_Code"].Visible = false;
			DV.Columns["Estate_Cost_Code"].Visible = false;
			DV.Columns["Estate_No_Remittance"].Visible = false;

//====================================================================================================
//End of the allowed output for the Free Edition of Instant C#.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-instant-csharp.html
//====================================================================================================
