using System.IO;
using System.Net;
using System.Text;
using System.Web;

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
	public partial class frm_sms : System.Windows.Forms.Form
	{
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]
		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;

		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.  
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_sms));
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			this.TabMassage = new System.Windows.Forms.TabControl();
			this.sms_1 = new System.Windows.Forms.TabPage();
			this.GroupBox6 = new System.Windows.Forms.GroupBox();
			this.Sms_Sefid_5 = new System.Windows.Forms.TextBox();
			this.Label20 = new System.Windows.Forms.Label();
			this.Sms_Sefid_4 = new System.Windows.Forms.TextBox();
			this.Label21 = new System.Windows.Forms.Label();
			this.Sms_Sefid_3 = new System.Windows.Forms.TextBox();
			this.Label6 = new System.Windows.Forms.Label();
			this.Sms_Sefid_2 = new System.Windows.Forms.TextBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.B_Sefid_Abort = new System.Windows.Forms.Button();
			this.B_Sefid_Delete = new System.Windows.Forms.Button();
			this.B_Sefid_Add = new System.Windows.Forms.Button();
			this.B_Sefid_Save = new System.Windows.Forms.Button();
			this.DV_Sefid = new System.Windows.Forms.DataGridView();
			this.Sms_txt_Sefid = new System.Windows.Forms.TextBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.CheckBox_Sefid = new System.Windows.Forms.CheckBox();
			this.Label_Sms = new System.Windows.Forms.Label();
			this.B_Txt_mobile = new System.Windows.Forms.Button();
			this.cmdSendMsg = new System.Windows.Forms.Button();
			this.Label24 = new System.Windows.Forms.Label();
			this.txt_Message = new System.Windows.Forms.TextBox();
			this.txt_mobile = new System.Windows.Forms.TextBox();
			this.Label23 = new System.Windows.Forms.Label();
			this.sms_2 = new System.Windows.Forms.TabPage();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.Dv_Mobile_Group = new System.Windows.Forms.DataGridView();
			this.TextBox_5_Sefid_Group = new System.Windows.Forms.TextBox();
			this.Label10 = new System.Windows.Forms.Label();
			this.TextBox_4_Sefid_Group = new System.Windows.Forms.TextBox();
			this.Label11 = new System.Windows.Forms.Label();
			this.TextBox_3_Sefid_Group = new System.Windows.Forms.TextBox();
			this.Label22 = new System.Windows.Forms.Label();
			this.TextBox_2_Sefid_Group = new System.Windows.Forms.TextBox();
			this.Label25 = new System.Windows.Forms.Label();
			this.Dv_Sefid_Group = new System.Windows.Forms.DataGridView();
			this.TextBox_Sefid_Group = new System.Windows.Forms.TextBox();
			this.Label27 = new System.Windows.Forms.Label();
			this.CheckBox_Sefid_Group = new System.Windows.Forms.CheckBox();
			this.Button_Group = new System.Windows.Forms.Button();
			this.Label31 = new System.Windows.Forms.Label();
			this.Sms_Sefid_Group = new System.Windows.Forms.TextBox();
			this.TextBox_Group = new System.Windows.Forms.TextBox();
			this.Label33 = new System.Windows.Forms.Label();
			this.B_Send_Sms_Sefid_Group = new System.Windows.Forms.Button();
			this.sms_3 = new System.Windows.Forms.TabPage();
			this.GroupBox7 = new System.Windows.Forms.GroupBox();
			this.lblMsgCount = new System.Windows.Forms.Label();
			this.cmdMsgDelete = new System.Windows.Forms.Button();
			this.cmdInboxRefresh = new System.Windows.Forms.Button();
			this.Label29 = new System.Windows.Forms.Label();
			this.txtInterval = new System.Windows.Forms.TextBox();
			this.chkInboxRefresh = new System.Windows.Forms.CheckBox();
			this.chkInConcatenate = new System.Windows.Forms.CheckBox();
			this.cboMsgMemory = new System.Windows.Forms.ComboBox();
			this.Label28 = new System.Windows.Forms.Label();
			this.lstInbox = new System.Windows.Forms.ListView();
			this.clmTime = (System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader());
			this.clmMessage = (System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader());
			this.clmFrom = (System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader());
			this.sms_4 = new System.Windows.Forms.TabPage();
			this.GroupBox13 = new System.Windows.Forms.GroupBox();
			this.Button3 = new System.Windows.Forms.Button();
			this.Button4 = new System.Windows.Forms.Button();
			this.ListView1 = new System.Windows.Forms.ListView();
			this.ColumnHeader1 = (System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader());
			this.ColumnHeader2 = (System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader());
			this.ColumnHeader3 = (System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader());
			this.GroupBox12 = new System.Windows.Forms.GroupBox();

//====================================================================================================
//End of the allowed output for the Free Edition of Instant C#.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-instant-csharp.html
//====================================================================================================
