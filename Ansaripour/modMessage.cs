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
	internal static class modMessage
	{
		public static int MessageValue;
		//.......................................................
		public static string Order_Request_Number = "";
		public static string Order_Request_Date = "";
		public static string Order_Request_Description = "";
		//.......................................................
		public static string Mod_Counterparty_ID = "";
		public static string Mod_Counterparty_Subscribe = "";
		public static string Mod_Counterparty_Detailed = "";
		public static string Mod_Counterparty_Bank_Number = "";
		public static string Mod_Counterparty_Mobile = "";
		//........................................................
		public static string Mod_txt_Ulr_Sender = "";
		public static string Mod_txt_smsSender = "";
		public static string Mod_txt_Signature = "";
		public static string Mod_Warranty_Document_Add = "";
		public static string Mod_Warranty_Document_Extended = "";
		public static string Mod_Warranty_Document_Refund = "";
		public static string Mod_Payable_Payment = "";
		public static string Mod_Sms_Text_Warranty_Document_Add = "";
		public static string Mod_Sms_Text_Warranty_Document_Extended = "";
		public static string Mod_Sms_Text_Warranty_Document_Refund = "";
		public static string Mod_Sms_Text_Collection_Document_Add = "";
		public static string Mod_Sms_Text_Collection_Document_Assignment = "";
		public static string Mod_Sms_Text_Collection_Document_Notice = "";
		public static string Mod_Sms_Text_Collection_Document_Back = "";
		public static string Mod_Sms_Text_Collection_Document_Extradition = "";
		public static string Mod_Sms_Text_Payable_Payment = "";
		//.......................................................
		public static string Mod_Pay_Personal_Id = "";
		public static string Mod_Pay_Personal_Code = "";
		public static string Mod_Pay_Personal_Detailed = "";
		//........................................................
		public static string Mod_Base_Information_Id = "";
		public static string Mod_Base_Information_Code = "";
		public static string Mod_Base_Information_Name = "";
		//........................................................
		public static string Mod_Accounting_Acc_Id = "";
		public static string Mod_Accounting_Acc_Code = "";
		public static string Mod_Accounting_Acc_Name = "";
		//........................................................
		public static string C_C_code;
		public static string C_G_code;
		public static string C_Sh_code;
		public static string C_V_code;
		public static string C_F_code;
		public static string C_H_code;
		public static string C_I_code;
		public static string C_M_code;
		public static string C_N_code;
		//-----------------------------
		public static string Acc_Code;
		public static string Acc_Name;
		public static string Acc_Id;
		public static string Acc_Num;
		public static string Acc_level;
		public static string Acc_Operation;
		public static string Acc_Case;
		public static string Acc_Class;
		public static string Acc_Group;
		public static int ShowMessage(string vTitle, string vText, frmMessage.mIcon vIcon, frmMessage.mButtons vButtons)
		{
			frmMessage mFrm = new frmMessage();
			mFrm.ConfigForm(vTitle, vText, vIcon, vButtons);
			mFrm.ShowDialog();
			return MessageValue;
		}
		public static int AccountingSerch(string ATitle, string BTitle, string CTitle, string AText, string BText, string A_serch)
		{
			Accounting_Serch mFrm = new Accounting_Serch();
			mFrm.ConfigForm(ATitle, BTitle, CTitle, AText, BText, A_serch);
			mFrm.ShowDialog();
			return MessageValue;
		}
		public static int ShowSerch(string ATitle, string BTitle, string CTitle, string AText, string BText, string CText, string DText, string EText, string FText, string GText, string HText, string IText, string MText, string NText, string OText, string PText, string LText, string SText)
		{
			H_Serch mFrm = new H_Serch();
			mFrm.ConfigForm(ATitle, BTitle, CTitle, AText, BText, CText, DText, EText, FText, GText, HText, IText, MText, NText, OText, PText, LText, SText);
			mFrm.ShowDialog();
			return MessageValue;
		}
		public static int ShowRelation(string ATitle, string AText, string BText)
		{
			Accounting_Relation mFrm = new Accounting_Relation();
			mFrm.ConfigForm(ATitle, AText, BText);
			mFrm.ShowDialog();
			return MessageValue;
		}
		public static int ShowPicture(string ATitle, string AText, string BText)
		{
			Pictures mFrm = new Pictures();
			mFrm.ConfigForm(ATitle, AText, BText);
			mFrm.ShowDialog();
			return MessageValue;
		}
		public static int ShowLog(string ATitle, string AText, string BText, string CText)
		{
			Log_File mFrm = new Log_File();
			mFrm.ConfigForm(ATitle, AText, BText, CText);
			mFrm.ShowDialog();
			return MessageValue;
		}
	}

}