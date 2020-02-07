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

using System.IO;
using Microsoft.Office.Interop;
using System.Net;
using System.Text;

namespace Ansaripour
{
	public partial class Payable
	{
		public Payable()
		{
			InitializeComponent();
		}

		private bool Add; //جداسازی ذخیره جدید و ویرایش
		private string f_serch; //تابع متغیر فرمول جستجو
		private string Id_Refrence;
		private string Check_Option;
		private string Sms_Message;
		private string Sms_err;
		private string ch;
		private string R_C;
		private bool b;
		private int jam;
		private int err;
		private string log;
		private string Log_Details;
		private Resizer rs = new Resizer();
		private void Dv_Get()
		{
			Dv_Details.Rows.Clear();
			Dv_Details.Columns.Clear();
			Dv_Details.Controls.Clear();
			Dv_Details.Columns.Add("row", "رديف");
			Dv_Details.Columns.Add("Payable_Details_Description", "شرح");
			Dv_Details.Columns.Add("Payable_Details_Debtor", "مبلغ");
			Dv_Details.Columns.Add("Payable_Details_Id", "");
			Dv_Details.Columns.Add("Payable_Counterparty_Id", "");
			Dv_Details.Columns.Add("Payable_Counterparty_Mobile", "");
			Dv_Details.Columns.Add("Payable_Counterparty_Detailed", "");
			Dv_Details.Columns["Payable_Details_Id"].Visible = false;
			Dv_Details.Columns["Payable_Counterparty_Id"].Visible = false;
			Dv_Details.Columns["Payable_Counterparty_Mobile"].Visible = false;
			Dv_Details.Columns["Payable_Counterparty_Detailed"].Visible = false;
			Dv_Details.Columns["row"].Width = 50;
			Dv_Details.Columns["Payable_Details_Description"].Width = 480;
			Dv_Details.Columns["Payable_Details_Debtor"].Width = 180;
			Dv_Details.Columns["Payable_Details_Debtor"].DefaultCellStyle.Format = "c";
			Dv_Details.AllowUserToAddRows = false;
			Dv_Details.EditMode = DataGridViewEditMode.EditProgrammatically;
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
					}
					else
					{
						modMessage.Mod_txt_Ulr_Sender = Convert.ToString(Dr["Sms_txt_Ulr_Sender"]);
						modMessage.Mod_txt_smsSender = Convert.ToString(Dr["Sms_txt_smsSender"]);
						modMessage.Mod_txt_Signature = Convert.ToString(Dr["Sms_txt_Signature"]);
						modMessage.Mod_Payable_Payment = Convert.ToString(Dr["Sms_Payable_Payment"]);
						modMessage.Mod_Sms_Text_Payable_Payment = Convert.ToString(Dr["Sms_Text_Payable_Payment"]);
					}
				}
				if (Convert.ToBoolean(modMessage.Mod_Payable_Payment) == true)
				{
					foreach (DataGridViewRow row in Dv_Details.Rows)
					{
						if (!(row.Cells["Payable_Details_Description"].Value == null))
						{
							if (!(row.Cells["Payable_Counterparty_Mobile"].Value == null))
							{
								string[] Sms_Text = modMessage.Mod_Sms_Text_Payable_Payment.Split("%%"[0]);
								Sms_Message = Sms_Text[0];
								Sms_Message += row.Cells["Payable_Counterparty_Detailed"].Value.ToString().Replace(" ", ".");
								Sms_Message += Sms_Text[2];
								double d = double.Parse(row.Cells["Payable_Details_Debtor"].Value.ToString());
								Sms_Message += d.ToString("#,##0.##");
								Sms_Message += Sms_Text[4];
								string pattern = modMessage.Mod_txt_Ulr_Sender + modMessage.Mod_txt_smsSender + "&to=" + row.Cells["Payable_Counterparty_Mobile"].Value.ToString() + "&text=" + Sms_Message + "&signature=" + modMessage.Mod_txt_Signature;
								Stream st = null;
								StreamReader sr = null;
								HttpWebRequest req = (HttpWebRequest)WebRequest.Create(pattern);
								var encode = Encoding.UTF8;
								try
								{
									System.Net.WebResponse resp = req.GetResponse();
									st = resp.GetResponseStream();
									sr = new StreamReader(st, Encoding.UTF8);
									string ch = sr.ReadToEnd();
									string[] dtVal = ch.Split(';');
									Sms_err = dtVal[1];
									sr.Close();
									resp.Close();
								}
								catch (Exception ex)
								{
									Sms_err = "-1";
								}
								f_serch = "";
								f_serch += "INSERT INTO Sms_Details   (Sms_Details_Date, Sms_Details_Time, Sms_Details_Mobile,";
								f_serch += "Sms_Details_Message, Sms_Details_Description, Sms_Id_User)  VALUES  ";

//====================================================================================================
//End of the allowed output for the Free Edition of Instant C#.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-instant-csharp.html
//====================================================================================================
