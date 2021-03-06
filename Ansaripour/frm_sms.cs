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
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;

using System;
using System.IO;
using System.Net;
using System.Text;
using System.Web;

namespace Ansaripour
{
	public partial class frm_sms
	{
		public frm_sms()
		{
			InitializeComponent();
		}

		private bool Add; //جداسازی ذخیره جدید و ویرایش
		private string Sms_err;
		private string f_serch; //تابع متغیر فرمول جستجو
		private Resizer rs = new Resizer();
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
					}
					else
					{
						modMessage.Mod_txt_Ulr_Sender = Convert.ToString(Dr["Sms_txt_Ulr_Sender"]);
						modMessage.Mod_txt_smsSender = Convert.ToString(Dr["Sms_txt_smsSender"]);
						modMessage.Mod_txt_Signature = Convert.ToString(Dr["Sms_txt_Signature"]);
					}
				}
				string pattern = modMessage.Mod_txt_Ulr_Sender + modMessage.Mod_txt_smsSender + "&to=" + txt_mobile.Text + "&text=" + txt_Message.Text + "&signature=" + modMessage.Mod_txt_Signature;
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
					switch (Convert.ToInt32(dtVal[1]))
					{
						case 0:
							modMessage.ShowMessage("کاربر محترم" + " :" + MDIParent1.DefaultInstance.I_N.Text, "ارسال پیام با موفقیت انجام شد", frmMessage.mIcon.mwarning, frmMessage.mButtons.mAccept);
							break;
						case 1:
							modMessage.ShowMessage("کاربر محترم" + " :" + MDIParent1.DefaultInstance.I_N.Text, "ارسال پیام با موفقیت انجام نشد", frmMessage.mIcon.mwarning, frmMessage.mButtons.mAccept);
							break;
						case 2:
							modMessage.ShowMessage("کاربر محترم" + " :" + MDIParent1.DefaultInstance.I_N.Text, "ارسال پیام با خطا مواجه شد", frmMessage.mIcon.mwarning, frmMessage.mButtons.mAccept);
							break;
						case 3:
							modMessage.ShowMessage("کاربر محترم" + " :" + MDIParent1.DefaultInstance.I_N.Text, "ارسال پیام بعلت لیست سیاه با موفقیت انجام نشد", frmMessage.mIcon.mwarning, frmMessage.mButtons.mAccept);
							break;
						default:
							modMessage.ShowMessage("کاربر محترم" + " :" + MDIParent1.DefaultInstance.I_N.Text, "ارسال پیام بعلت در لیست انتظار قرار گرفتن با موفقیت انجام نشد", frmMessage.mIcon.mwarning, frmMessage.mButtons.mAccept);
							break;
					}
					Sms_err = dtVal[1];
					sr.Close();
					resp.Close();
				}
				catch (Exception ex)
				{
					modMessage.ShowMessage("کاربر محترم" + " :" + MDIParent1.DefaultInstance.I_N.Text, "اینترنت وصل نیست", frmMessage.mIcon.mzoom, frmMessage.mButtons.mAccept);
					Sms_err = sr.ReadToEnd();
				}
				f_serch = "";
				f_serch += "INSERT INTO Sms_Details   (Sms_Details_Date, Sms_Details_Time, Sms_Details_Mobile,";
				f_serch += "Sms_Details_Message, Sms_Details_Description, Sms_Id_User)  VALUES  ";
				f_serch += "(N'" + data.today().Replace("/", "") + "',";
				f_serch += "N'" + DateTime.Now.ToString("hh:mm:ss tt") + "',";
				f_serch += "N'" + txt_mobile.Text + "',";
				f_serch += "N'" + txt_Message.Text + "',";
				f_serch += "N'" + Sms_err + "',";
				f_serch += "N'" + MDIParent1.DefaultInstance.ID.Text + "')";
				DataSet insert = data.PDataset("" + f_serch + "");
			}
		}
		private void cmdSendMsg_Click(System.Object sender, System.EventArgs e)
		{
			SMS();
		}
		private void View_sms_SetUp_CheckedChanged(System.Object sender, System.EventArgs e)
		{
			if (View_sms_SetUp.Checked)
			{
				Sms_txt_Ulr_Sender.PasswordChar = '\0';
				Sms_txt_smsSender.PasswordChar = '\0';
				Sms_txt_Signature.PasswordChar = '\0';
			}
			else
			{
				Sms_txt_Ulr_Sender.PasswordChar = '*';
				Sms_txt_smsSender.PasswordChar = '*';
				Sms_txt_Signature.PasswordChar = '*';
			}
		}
		private void SAVE_Setting_Click(System.Object sender, System.EventArgs e)
		{
			DataSet PrSet = data.PDataset("select max(Sms_Id) From  Sms_Panel ");
			foreach (DataRow Dr in PrSet.Tables[0].Rows)
			{
				if (Convert.IsDBNull(Dr[0]))
				{
					f_serch = "";
					f_serch += "INSERT INTO Sms_Panel   (Sms_txt_Ulr_Sender,Sms_txt_smsSender,Sms_txt_Signature,";
					f_serch += "Sms_Warranty_Document_Add,Sms_Text_Warranty_Document_Add,";
					f_serch += "Sms_Warranty_Document_Extended,Sms_Text_Warranty_Document_Extended,";
					f_serch += "Sms_Warranty_Document_Refund,Sms_Text_Warranty_Document_Refund,";
					f_serch += "Sms_Collection_Document_Add,Sms_Text_Collection_Document_Add,";
					f_serch += "Sms_Collection_Document_Assignment,Sms_Text_Collection_Document_Assignment,";
					f_serch += "Sms_Collection_Document_Notice,Sms_Text_Collection_Document_Notice,";

//====================================================================================================
//End of the allowed output for the Free Edition of Instant C#.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-instant-csharp.html
//====================================================================================================
