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
	public partial class Accounting_Report : System.Windows.Forms.Form
	{
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && components != null)
				{
					components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;

		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.  
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accounting_Report));
			this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
			this.Print_B = new System.Windows.Forms.ToolStripButton();
			this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.Excel_B = new System.Windows.Forms.ToolStripButton();
			this.Abort_B = new System.Windows.Forms.ToolStripButton();
			this.TabControl1 = new System.Windows.Forms.TabControl();
			this.TabPage1 = new System.Windows.Forms.TabPage();
			this.GroupBox8 = new System.Windows.Forms.GroupBox();
			this.L_Accounting_Details_Acc_Main_Until = new System.Windows.Forms.Label();
			this.L_Accounting_Details_Acc_Main_From = new System.Windows.Forms.Label();
			this.GroupBox9 = new System.Windows.Forms.GroupBox();
			this.Accounting_Area_one = new System.Windows.Forms.RadioButton();
			this.Accounting_Area_All = new System.Windows.Forms.RadioButton();
			this.B_Accounting_Area_Main_one = new System.Windows.Forms.Button();
			this.Accounting_Area_Main_one = new System.Windows.Forms.TextBox();
			this.Accounting_Details_Number_Turning_Main_Until = new System.Windows.Forms.TextBox();
			this.Label25 = new System.Windows.Forms.Label();
			this.Accounting_Details_Number_Turning_Main_From = new System.Windows.Forms.TextBox();
			this.Label24 = new System.Windows.Forms.Label();
			this.Label23 = new System.Windows.Forms.Label();
			this.Accounting_Details_Date_Due_Main_Until = new Ansaripour.Rtl_Date();
			this.Label22 = new System.Windows.Forms.Label();
			this.Accounting_Details_Date_Due_Main_From = new Ansaripour.Rtl_Date();
			this.Accounting_Details_Number_Due_Main_Until = new System.Windows.Forms.TextBox();
			this.Label20 = new System.Windows.Forms.Label();
			this.Accounting_Details_Number_Due_Main_From = new System.Windows.Forms.TextBox();
			this.Estehlak_Label = new System.Windows.Forms.Label();
			this.Label19 = new System.Windows.Forms.Label();
			this.Accounting_Details_Date_Cost_Main_Until = new Ansaripour.Rtl_Date();
			this.Label18 = new System.Windows.Forms.Label();
			this.Accounting_Details_Date_Cost_Main_From = new Ansaripour.Rtl_Date();
			this.B_Accounting_Details_Acc_Main_From = new System.Windows.Forms.Button();
			this.Label13 = new System.Windows.Forms.Label();
			this.Accounting_Details_Description_Main = new System.Windows.Forms.TextBox();
			this.Accounting_Details_Acc_Main_From = new System.Windows.Forms.TextBox();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.Accounting_Details_Acc_Main_Until = new System.Windows.Forms.TextBox();
			this.B_Accounting_Details_Acc_Main_Until = new System.Windows.Forms.Button();
			this.GroupBox7 = new System.Windows.Forms.GroupBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Accounting_Header_Description = new System.Windows.Forms.TextBox();
			this.Header_Number_From = new System.Windows.Forms.TextBox();
			this.Label21 = new System.Windows.Forms.Label();
			this.Header_Number_Until = new System.Windows.Forms.TextBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.Accounting_Header_Date_Until = new Ansaripour.Rtl_Date();
			this.Accounting_Header_Date_From = new Ansaripour.Rtl_Date();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.Accounting_Header_Class_4 = new System.Windows.Forms.CheckBox();
			this.Accounting_Header_Class_3 = new System.Windows.Forms.CheckBox();
			this.Accounting_Header_Class_5 = new System.Windows.Forms.CheckBox();
			this.Accounting_Header_Class_2 = new System.Windows.Forms.CheckBox();
			this.Accounting_Header_Class_1 = new System.Windows.Forms.CheckBox();
			this.Accounting_Header_Class_0 = new System.Windows.Forms.CheckBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.TabPage2 = new System.Windows.Forms.TabPage();
			this.GroupBox6 = new System.Windows.Forms.GroupBox();
			this.L_Accounting_Details_Detailed_Five_Main_From = new System.Windows.Forms.Label();
			this.L_Accounting_Details_Detailed_Five_Main_Until = new System.Windows.Forms.Label();
			this.Accounting_Details_Detailed_Five_Main_Until = new System.Windows.Forms.TextBox();
			this.B_Accounting_Details_Detailed_Five_Main_Until = new System.Windows.Forms.Button();
			this.Label16 = new System.Windows.Forms.Label();
			this.Accounting_Details_Detailed_Five_Main_From = new System.Windows.Forms.TextBox();
			this.B_Accounting_Details_Detailed_Five_Main_From = new System.Windows.Forms.Button();
			this.Label17 = new System.Windows.Forms.Label();
			this.GroupBox5 = new System.Windows.Forms.GroupBox();
			this.L_Accounting_Details_Detailed_Four_Main_From = new System.Windows.Forms.Label();
			this.L_Accounting_Details_Detailed_Four_Main_Until = new System.Windows.Forms.Label();
			this.Accounting_Details_Detailed_Four_Main_Until = new System.Windows.Forms.TextBox();
			this.B_Accounting_Details_Detailed_Four_Main_Until = new System.Windows.Forms.Button();
			this.Label14 = new System.Windows.Forms.Label();
			this.Accounting_Details_Detailed_Four_Main_From = new System.Windows.Forms.TextBox();
			this.B_Accounting_Details_Detailed_Four_Main_From = new System.Windows.Forms.Button();
			this.Label15 = new System.Windows.Forms.Label();
			this.GroupBox4 = new System.Windows.Forms.GroupBox();
			this.L_Accounting_Details_Detailed_Three_Main_From = new System.Windows.Forms.Label();

//====================================================================================================
//End of the allowed output for the Free Edition of Instant C#.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-instant-csharp.html
//====================================================================================================
