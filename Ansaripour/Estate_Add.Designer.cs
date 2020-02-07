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
	public partial class Estate_Add : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estate_Add));
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
			this.Estate_No_Document = new System.Windows.Forms.TextBox();
			this.Check_Depreciated = new System.Windows.Forms.CheckBox();
			this.B_Project = new System.Windows.Forms.Button();
			this.Label16 = new System.Windows.Forms.Label();
			this.Estate_Project = new System.Windows.Forms.TextBox();
			this.Label17 = new System.Windows.Forms.Label();
			this.B_Plan = new System.Windows.Forms.Button();
			this.Estate_Plan = new System.Windows.Forms.TextBox();
			this.Label23 = new System.Windows.Forms.Label();
			this.Day = new System.Windows.Forms.Label();
			this.Progress = new System.Windows.Forms.ProgressBar();
			this.Label15 = new System.Windows.Forms.Label();
			this.Check_B_Date = new System.Windows.Forms.CheckBox();
			this.Label7 = new System.Windows.Forms.Label();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.Label29 = new System.Windows.Forms.Label();
			this.Label24 = new System.Windows.Forms.Label();
			this.Estate_Date_Until = new Ansaripour.Rtl_Date();
			this.Estate_Date_From = new Ansaripour.Rtl_Date();
			this.Check_Date = new System.Windows.Forms.CheckBox();
			this.Estate_No_Personnel = new System.Windows.Forms.TextBox();
			this.B_Personal_Chek = new System.Windows.Forms.Button();
			this.Estate_Description = new System.Windows.Forms.TextBox();
			this.Label14 = new System.Windows.Forms.Label();
			this.Estate_Depreciation = new System.Windows.Forms.TextBox();
			this.Estehlak_Label = new System.Windows.Forms.Label();
			this.Label13 = new System.Windows.Forms.Label();
			this.Label11 = new System.Windows.Forms.Label();
			this.Estate_No_Remittance = new System.Windows.Forms.TextBox();
			this.Label12 = new System.Windows.Forms.Label();
			this.Label9 = new System.Windows.Forms.Label();
			this.Label10 = new System.Windows.Forms.Label();
			this.Price_Label = new System.Windows.Forms.Label();
			this.Estate_Price = new System.Windows.Forms.TextBox();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.Estate_Name = new System.Windows.Forms.TextBox();
			this.Estate_Plaque = new System.Windows.Forms.ComboBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.Estate_Cost_Code = new System.Windows.Forms.ComboBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.Estate_Sub_Code = new System.Windows.Forms.ComboBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.Estate_Original_Code = new System.Windows.Forms.ComboBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.Estate_City = new System.Windows.Forms.ComboBox();
			this.Label8 = new System.Windows.Forms.Label();
			this.Estate_Date_Remittance = new Ansaripour.Rtl_Date();
			this.Estate_Date_Document = new Ansaripour.Rtl_Date();
			this.Estate_Date_Price = new Ansaripour.Rtl_Date();
			this.ToolStrip = new System.Windows.Forms.ToolStrip();
			this.B_Product = new System.Windows.Forms.ToolStripDropDownButton();
			this.B_Single_Dismiss = new System.Windows.Forms.ToolStripMenuItem();
			this.B_Total_Dismiss = new System.Windows.Forms.ToolStripMenuItem();
			this.B_Increase = new System.Windows.Forms.ToolStripMenuItem();
			this.B_Decrease = new System.Windows.Forms.ToolStripMenuItem();
			this.B_Movement = new System.Windows.Forms.ToolStripMenuItem();
			this.B_Movement_All = new System.Windows.Forms.ToolStripMenuItem();
			this.B_Period = new System.Windows.Forms.ToolStripMenuItem();
			this.B_Depreciation = new System.Windows.Forms.ToolStripMenuItem();
			this.B_New_Depreciation = new System.Windows.Forms.ToolStripMenuItem();
			this.B_Chek_Revaluation = new System.Windows.Forms.ToolStripMenuItem();
			this.New_B = new System.Windows.Forms.ToolStripButton();
			this.Edit_B = new System.Windows.Forms.ToolStripButton();
			this.Save_B = new System.Windows.Forms.ToolStripButton();
			this.Delet_B = new System.Windows.Forms.ToolStripButton();
			this.N_Search = new System.Windows.Forms.ToolStripComboBox();
			this.Search_B = new System.Windows.Forms.ToolStripButton();
			this.Chap_B = new System.Windows.Forms.ToolStripButton();
			this.Picture_B = new System.Windows.Forms.ToolStripButton();
			this.Excel_B = new System.Windows.Forms.ToolStripButton();
			this.Log_File = new System.Windows.Forms.ToolStripButton();
			this.Abort_B = new System.Windows.Forms.ToolStripButton();
			this.Estate_Control = new System.Windows.Forms.ToolStripComboBox();
			this.Label18 = new System.Windows.Forms.Label();

//====================================================================================================
//End of the allowed output for the Free Edition of Instant C#.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-instant-csharp.html
//====================================================================================================
