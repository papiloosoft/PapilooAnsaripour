using System.IO.Directory;
using Microsoft.Office.Interop;

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
	public partial class Repair : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Repair));
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.ToolStrip = new System.Windows.Forms.ToolStrip();
			this.New_B = new System.Windows.Forms.ToolStripButton();
			this.Edit_B = new System.Windows.Forms.ToolStripButton();
			this.Delet_B = new System.Windows.Forms.ToolStripButton();
			this.Save_B = new System.Windows.Forms.ToolStripButton();
			this.Search_B = new System.Windows.Forms.ToolStripButton();
			this.B_Excel = new System.Windows.Forms.ToolStripButton();
			this.Chap = new System.Windows.Forms.ToolStripButton();
			this.Abort_B = new System.Windows.Forms.ToolStripButton();
			this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
			this.TabControl1 = new System.Windows.Forms.TabControl();
			this.TabPage1 = new System.Windows.Forms.TabPage();
			this.Repair_Seating = new System.Windows.Forms.TextBox();
			this.Label17 = new System.Windows.Forms.Label();
			this.Repair_Energy = new System.Windows.Forms.TextBox();
			this.B_Repair_Energy = new System.Windows.Forms.Button();
			this.Repair_Ability_Work = new System.Windows.Forms.TextBox();
			this.Label15 = new System.Windows.Forms.Label();
			this.Repair_Capacity = new System.Windows.Forms.TextBox();
			this.Label14 = new System.Windows.Forms.Label();
			this.Repair_Production_Capacity = new System.Windows.Forms.TextBox();
			this.Label13 = new System.Windows.Forms.Label();
			this.Label12 = new System.Windows.Forms.Label();
			this.Repair_Weight_Device = new System.Windows.Forms.TextBox();
			this.Label11 = new System.Windows.Forms.Label();
			this.Repair_Working_Dimensions = new System.Windows.Forms.TextBox();
			this.Label10 = new System.Windows.Forms.Label();
			this.Repair_Dimensions_Device = new System.Windows.Forms.TextBox();
			this.Label9 = new System.Windows.Forms.Label();
			this.Repair_Use_Date = new Ansaripour.Rtl_Date();
			this.Label8 = new System.Windows.Forms.Label();
			this.Repair_Production_Date = new Ansaripour.Rtl_Date();
			this.Label7 = new System.Windows.Forms.Label();
			this.Repair_Model_Making = new System.Windows.Forms.TextBox();
			this.Label6 = new System.Windows.Forms.Label();
			this.Repair_Manufacturer = new System.Windows.Forms.TextBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.Repair_Manufacturing_Country = new System.Windows.Forms.TextBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.B_Repair_Seating = new System.Windows.Forms.Button();
			this.Label2 = new System.Windows.Forms.Label();
			this.Repair_Serial = new System.Windows.Forms.TextBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.Repair_Code = new System.Windows.Forms.TextBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.Repair_Name = new System.Windows.Forms.TextBox();
			this.Label16 = new System.Windows.Forms.Label();
			this.TabPage2 = new System.Windows.Forms.TabPage();
			this.Label34 = new System.Windows.Forms.Label();
			this.Repair_Description = new System.Windows.Forms.TextBox();
			this.Repair_Power_Factor = new System.Windows.Forms.TextBox();
			this.Label33 = new System.Windows.Forms.Label();
			this.Repair_Cable_Size = new System.Windows.Forms.TextBox();
			this.Label32 = new System.Windows.Forms.Label();
			this.Repair_Key_Issues = new System.Windows.Forms.TextBox();
			this.Label31 = new System.Windows.Forms.Label();
			this.Repair_Flow_Rate = new System.Windows.Forms.TextBox();
			this.Label30 = new System.Windows.Forms.Label();
			this.Label29 = new System.Windows.Forms.Label();
			this.Repair_Connector_Type = new System.Windows.Forms.TextBox();
			this.B_Repair_Connector_Type = new System.Windows.Forms.Button();
			this.Label28 = new System.Windows.Forms.Label();
			this.Repair_Kind_Fuse = new System.Windows.Forms.TextBox();
			this.B_Repair_Kind_Fuse = new System.Windows.Forms.Button();
			this.Label27 = new System.Windows.Forms.Label();
			this.Repair_Kind_Stream = new System.Windows.Forms.TextBox();
			this.B_Repair_Kind_Stream = new System.Windows.Forms.Button();
			this.Label26 = new System.Windows.Forms.Label();
			this.Repair_Phase = new System.Windows.Forms.TextBox();
			this.B_Repair_Phase = new System.Windows.Forms.Button();
			this.Label25 = new System.Windows.Forms.Label();
			this.Repair_RPM = new System.Windows.Forms.TextBox();
			this.Label24 = new System.Windows.Forms.Label();
			this.Repair_Frequency = new System.Windows.Forms.TextBox();

//====================================================================================================
//End of the allowed output for the Free Edition of Instant C#.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-instant-csharp.html
//====================================================================================================
