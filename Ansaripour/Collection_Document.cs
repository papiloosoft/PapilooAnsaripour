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
	public partial class Collection_Document
	{
		public Collection_Document()
		{
			InitializeComponent();
		}

		private string Id_Subscription;
		private string Id_Collecting_Bank;
		public string Var_Clas;
		private bool Add; //جداسازی ذخیره جدید و ویرایش
		private int T_id; //پیش فرض شماره ثبت
		private string f_serch; //تابع متغیر فرمول جستجو
		private string f_Select; //تابع متغیر فرمول جستجو
		private string R_C;
		private string ch;
		private string log;
		private string Log_Details;
		private Resizer rs = new Resizer();
		private void B_Recovery_Documents_Subscription_Click(System.Object sender, System.EventArgs e)
		{
			Counterparty OBJCHILD = new Counterparty();
			OBJCHILD.Text = "فرم جستجو بر اساس اشخاص و طرف حساب ها ";
			OBJCHILD.Result = true;
			OBJCHILD.ShowDialog();
			if (!string.IsNullOrEmpty(modMessage.Mod_Counterparty_ID.ToString()))
			{
				Recovery_Documents_Subscription.Text = modMessage.Mod_Counterparty_Subscribe.ToString() + " - " + modMessage.Mod_Counterparty_Detailed.ToString();
				Id_Subscription = modMessage.Mod_Counterparty_ID.ToString();
			}
			//ShowSerch("فرم جستجو بر اساس اشخاص و طرف حساب ها", "شرح", "کد", "Counterparty", "Counterparty_Detailed", "Counterparty_Subscribe", "", "", "", "Counterparty_Area", "Counterparty_ID", "", "", "", "", "", "", "")
			//If String.IsNullOrEmpty(modMessage.C_H_code.ToString()) = False Then Recovery_Documents_Subscription.Text = modMessage.C_C_code.ToString() + " - " + modMessage.C_Sh_code.ToString()
			//Id_Subscription = modMessage.C_H_code.ToString()
		}
		private void B_Recovery_Documents_Collecting_Bank_Click(System.Object sender, System.EventArgs e)
		{
			modMessage.ShowSerch("فرم جستجو بر اساس شماره حساب و نام بانک", "نام بانک", "شماره حساب", "Bank", "Bank_Name", "Bank_Account", "", "Bank_Case", "0", "Bank_Area", "Bank_Id", "", "", "", "", "", "", "");
			if (string.IsNullOrEmpty(modMessage.C_H_code.ToString()) == false)
			{
				Recovery_Documents_Collecting_Bank.Text = modMessage.C_C_code.ToString() + " - " + modMessage.C_Sh_code.ToString();
			}
			Id_Collecting_Bank = modMessage.C_H_code.ToString();
		}
		private void Recovery_Documents_Load(object sender, System.EventArgs e)
		{
			rs.FindAllControls(this);
			reset();
		}
		private void Log_Details_Get()
		{
			Log_Details = "";
			if (DV.SelectedCells.Count > 0)
			{
				Log_Details += DV.CurrentRow.Cells["Recovery_Documents_Id"].Value.ToString() + "-" + DV.CurrentRow.Cells["Recovery_Documents_Subscription"].Value.ToString() + "-";
				Log_Details += DV.CurrentRow.Cells["Recovery_Document_Subscription_Id"].Value.ToString() + "-" + DV.CurrentRow.Cells["Recovery_Documents_Operation"].Value.ToString() + "-";
				Log_Details += DV.CurrentRow.Cells["Recovery_Documents_Date_Received"].Value.ToString() + "-" + DV.CurrentRow.Cells["Recovery_Documents_Due_Date"].Value.ToString() + "-";
				Log_Details += DV.CurrentRow.Cells["Recovery_Documents_Assignment_Date"].Value.ToString() + "-" + DV.CurrentRow.Cells["Recovery_Documents_Pass_Date"].Value.ToString() + "-";
				Log_Details += DV.CurrentRow.Cells["Recovery_Documents_Returned_Date"].Value.ToString() + "-" + DV.CurrentRow.Cells["Recovery_Documents_Refund_Date"].Value.ToString() + "-";
				Log_Details += DV.CurrentRow.Cells["Recovery_Documents_Bank"].Value.ToString() + "-" + DV.CurrentRow.Cells["Recovery_Documents_Branch"].Value.ToString() + "-";
				Log_Details += DV.CurrentRow.Cells["Recovery_Documents_Collecting_Bank"].Value.ToString() + "-" + DV.CurrentRow.Cells["Recovery_Documents_No_Check"].Value.ToString() + "-";
				Log_Details += DV.CurrentRow.Cells["Recovery_Documents_Account_Number"].Value.ToString() + "-" + DV.CurrentRow.Cells["Recovery_Documents_Case"].Value.ToString() + "-";
				Log_Details += DV.CurrentRow.Cells["Recovery_Documents_Amount"].Value.ToString() + "-" + DV.CurrentRow.Cells["Recovery_Documents_Description"].Value.ToString() + "-";
				Log_Details += Convert.ToString(DV.CurrentRow.Cells["Id_Collecting_Bank"].Value);
			}
			else
			{
				Log_Details += Recovery_Documents_Subscription.Text + "-" + Recovery_Documents_Operation.Text + "-";
				Log_Details += Recovery_Documents_Date_Received.T_D + "-" + Recovery_Documents_Due_Date.T_D + "-";
				Log_Details += Recovery_Documents_Assignment_Date.T_D + "-" + Recovery_Documents_Pass_Date.T_D + "-";
				Log_Details += Recovery_Documents_Returned_Date.T_D + "-" + Recovery_Documents_Refund_Date.T_D + "-";
				Log_Details += Recovery_Documents_Bank.Text + "-" + Recovery_Documents_Branch.Text + "-";
				Log_Details += Recovery_Documents_Collecting_Bank.Text + "-" + Recovery_Documents_No_Check.Text + "-";
				Log_Details += Recovery_Documents_Account_Number.Text + "-" + Recovery_Documents_Case.Text + "-";
				Log_Details += Recovery_Documents_Amount.Text + "-" + Recovery_Documents_Description.Text + "-";
				Log_Details += Id_Subscription + "-" + Id_Collecting_Bank;
			}
		}
		private void I_Serch()
		{
			f_serch = "";
			if (!string.IsNullOrEmpty(data.Is_Number(Recovery_Documents_Subscription.Text)))
			{
				f_serch = "and Recovery_Documents_Subscription LIKE N'" + Id_Subscription + "'";
			}
			switch (Convert.ToInt32(Var_Clas))
			{
				case 1:
					if (data.Is_date(Recovery_Documents_From_Date.T_D))
					{
						f_serch += "and Recovery_Documents_Date_Received >= '" + NumericHelper.Val(Recovery_Documents_From_Date.T_D.Replace("/", "")) + "'";
					}
					if (data.Is_date(Recovery_Documents_Until_Date.T_D))
					{
						f_serch += "and Recovery_Documents_Date_Received <= '" + NumericHelper.Val(Recovery_Documents_Until_Date.T_D.Replace("/", "")) + "'";
					}
					f_serch += "and Recovery_Documents_Operation=0";
					break;
				case 2:
					if (data.Is_date(Recovery_Documents_From_Date.T_D))
					{
						f_serch += "and Recovery_Documents_Date_Received >= '" + NumericHelper.Val(Recovery_Documents_From_Date.T_D.Replace("/", "")) + "'";
					}
					if (data.Is_date(Recovery_Documents_Until_Date.T_D))
					{
						f_serch += "and Recovery_Documents_Date_Received <= '" + NumericHelper.Val(Recovery_Documents_Until_Date.T_D.Replace("/", "")) + "'";
					}
					f_serch += "and Recovery_Documents_Operation <=1";
					break;
				case 3:
					if (data.Is_date(Recovery_Documents_From_Date.T_D))
					{
						f_serch += "and Recovery_Documents_Pass_Date >= '" + NumericHelper.Val(Recovery_Documents_From_Date.T_D.Replace("/", "")) + "'";
					}
					if (data.Is_date(Recovery_Documents_Until_Date.T_D))
					{
						f_serch += "and Recovery_Documents_Pass_Date <= '" + NumericHelper.Val(Recovery_Documents_Until_Date.T_D.Replace("/", "")) + "'";
					}
					f_serch += "and Recovery_Documents_Operation=1";
					break;
				case 4:
					if (data.Is_date(Recovery_Documents_From_Date.T_D))
					{
						f_serch += "and Recovery_Documents_Returned_Date >= '" + NumericHelper.Val(Recovery_Documents_From_Date.T_D.Replace("/", "")) + "'";
					}
					if (data.Is_date(Recovery_Documents_Until_Date.T_D))
					{
						f_serch += "and Recovery_Documents_Returned_Date <= '" + NumericHelper.Val(Recovery_Documents_Until_Date.T_D.Replace("/", "")) + "'";
					}
					f_serch += "and Recovery_Documents_Operation=1";
					break;

//====================================================================================================
//End of the allowed output for the Free Edition of Instant C#.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-instant-csharp.html
//====================================================================================================
