//====================================================================================================
//The Free Edition of Instant C# limits conversion output to 100 lines per file.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-instant-csharp.html
//====================================================================================================

//INSTANT C# NOTE: Formerly VB project-level imports:
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Xml.Linq;

using System;
using System.IO;
using System.Net;
using System.Text;
using System.Web;
using System.Windows.Forms;
using Microsoft.Office.Interop;

namespace Ansaripour
{
	public partial class Warranty_Document
	{
		public Warranty_Document()
		{
			InitializeComponent();
		}

		private string Id_Subscription;
		public string Var_Clas;
		private bool Add; //جداسازی ذخیره جدید و ویرایش
		private string f_serch; //تابع متغیر فرمول جستجو
		private string f_select; //تابع متغیر فرمول جستجو
		private string Sms_Message;
		private string Sms_err;
		private string R_C;
		private int err;
		private string log;
		private string Log_Details;
		private Resizer rs = new Resizer();
		private void Log_Details_Get()
		{
			Log_Details = "";
			if (DV.SelectedCells.Count > 0)
			{
				Log_Details += DV.CurrentRow.Cells["Warranty_Document_Subscription"].Value.ToString() + "-" + DV.CurrentRow.Cells["Warranty_Document_No_Date"].Value.ToString() + "-";
				Log_Details += DV.CurrentRow.Cells["Warranty_Document_Operation"].Value.ToString() + "-" + DV.CurrentRow.Cells["Warranty_Document_Extended_Date"].Value.ToString() + "-";
				Log_Details += DV.CurrentRow.Cells["Warranty_Document_Refund_Date"].Value.ToString() + "-" + DV.CurrentRow.Cells["Warranty_Document_Due_Date"].Value.ToString() + "-";
				Log_Details += DV.CurrentRow.Cells["Warranty_Document_Date"].Value.ToString() + "-" + DV.CurrentRow.Cells["Warranty_Document_Number"].Value.ToString() + "-";
				Log_Details += DV.CurrentRow.Cells["Warranty_Document_Case"].Value.ToString() + "-" + DV.CurrentRow.Cells["Warranty_Document_Contract_Number"].Value.ToString() + "-";
				Log_Details += DV.CurrentRow.Cells["Warranty_Document_Contract_Number"].Value.ToString() + "-" + DV.CurrentRow.Cells["Warranty_Document_No_Check"].Value.ToString() + "-";
				Log_Details += DV.CurrentRow.Cells["Warranty_Document_Account_Number"].Value.ToString() + "-" + DV.CurrentRow.Cells["Warranty_Document_Contract_Date"].Value.ToString() + "-";
				Log_Details += DV.CurrentRow.Cells["Warranty_Document_No_Check"].Value.ToString() + "-" + DV.CurrentRow.Cells["Warranty_Document_Account_Number"].Value.ToString() + "-";
				Log_Details += DV.CurrentRow.Cells["Warranty_Document_Bank"].Value.ToString() + "-" + DV.CurrentRow.Cells["Warranty_Document_Branch"].Value.ToString() + "-";
				Log_Details += DV.CurrentRow.Cells["Warranty_Document_Amount"].Value.ToString() + "-" + DV.CurrentRow.Cells["Warranty_Document_Description"].Value.ToString() + "-";
				Log_Details += Convert.ToString(DV.CurrentRow.Cells["Warranty_Document_Subscription_Id"].Value);
			}
			else
			{
				Log_Details += Warranty_Document_Subscription.Text + "-" + Warranty_Document_Operation.Text + "-";
				Log_Details += Warranty_Document_Refund_Date.T_D + "-" + Warranty_Document_Extended_Date.T_D + "-";
				Log_Details += Warranty_Document_Due_Date.T_D + "-" + Warranty_Document_Date.T_D + "-";
				Log_Details += Warranty_Document_Number.Text + "-" + Warranty_Document_No_Date.T_D + "-";
				Log_Details += Warranty_Document_Case.Text + "-" + Warranty_Document_Contract_Date.T_D + "-";
				Log_Details += Warranty_Document_Contract_Number.Text + "-" + Warranty_Document_No_Check.Text + "-";
				Log_Details += Warranty_Document_Account_Number.Text + "-" + Warranty_Document_Bank.Text + "-";
				Log_Details += Warranty_Document_Branch.Text + "-" + Warranty_Document_Amount.Text + "-";
				Log_Details += Warranty_Document_Description.Text + "-" + Id_Subscription;
			}
		}
		private void SMS()
		{
			if (modMessage.Mod_Counterparty_Mobile.Length != 0)
			{
				DataSet SMS = data.PDataset("Select * From Sms_Panel");
				foreach (DataRow Dr in SMS.Tables[0].Rows)
				{
					if (Convert.IsDBNull(Dr[0]))
					{
						modMessage.Mod_txt_Signature = "";
						modMessage.Mod_txt_smsSender = "";
						modMessage.Mod_txt_Signature = "";
						modMessage.Mod_Warranty_Document_Add = "";
						modMessage.Mod_Warranty_Document_Extended = "";
						modMessage.Mod_Warranty_Document_Refund = "";
						modMessage.Mod_Sms_Text_Warranty_Document_Add = "";
						modMessage.Mod_Sms_Text_Warranty_Document_Extended = "";
						modMessage.Mod_Sms_Text_Warranty_Document_Refund = "";
					}
					else
					{
						modMessage.Mod_txt_Ulr_Sender = Convert.ToString(Dr["Sms_txt_Ulr_Sender"]);
						modMessage.Mod_txt_smsSender = Convert.ToString(Dr["Sms_txt_smsSender"]);
						modMessage.Mod_txt_Signature = Convert.ToString(Dr["Sms_txt_Signature"]);
						modMessage.Mod_Warranty_Document_Add = Convert.ToString(Dr["Sms_Warranty_Document_Add"]);
						modMessage.Mod_Warranty_Document_Extended = Convert.ToString(Dr["Sms_Warranty_Document_Extended"]);
						modMessage.Mod_Warranty_Document_Refund = Convert.ToString(Dr["Sms_Warranty_Document_Refund"]);
						modMessage.Mod_Sms_Text_Warranty_Document_Add = Convert.ToString(Dr["Sms_Text_Warranty_Document_Add"]);
						modMessage.Mod_Sms_Text_Warranty_Document_Extended = Convert.ToString(Dr["Sms_Text_Warranty_Document_Extended"]);
						modMessage.Mod_Sms_Text_Warranty_Document_Refund = Convert.ToString(Dr["Sms_Text_Warranty_Document_Refund"]);
					}
				}
				err = 0;
				switch (Convert.ToInt32(Var_Clas))
				{
					case 1:
						if (Convert.ToBoolean(modMessage.Mod_Warranty_Document_Add) == true)
						{
							err = 1;
						}
						break;
					case 2:
						if (Convert.ToBoolean(modMessage.Mod_Warranty_Document_Extended) == true)
						{
							err = 2;
						}
						break;
					case 3:
						if (Convert.ToBoolean(modMessage.Mod_Warranty_Document_Refund) == true)
						{
							err = 3;
						}
						break;
				}
				if (err != 0)
				{
					string[] Sms_Text = null;
					switch (Convert.ToInt32(Var_Clas))
					{
						case 1:
							Sms_Text = modMessage.Mod_Sms_Text_Warranty_Document_Add.Split("%%"[0]);
							Sms_Message = Sms_Text[0];
							Sms_Message += modMessage.Mod_Counterparty_Detailed.Replace(" ", ".");

//====================================================================================================
//End of the allowed output for the Free Edition of Instant C#.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-instant-csharp.html
//====================================================================================================
