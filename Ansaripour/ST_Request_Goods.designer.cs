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
	public partial class ST_Request_Goods : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ST_Request_Goods));
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
			this.B_Product = new System.Windows.Forms.ToolStripDropDownButton();
			this.B_Ask_goods = new System.Windows.Forms.ToolStripMenuItem();
			this.B_purchase_request = new System.Windows.Forms.ToolStripMenuItem();
			this.B_warehouse_receipt = new System.Windows.Forms.ToolStripMenuItem();
			this.B_Anbar_order = new System.Windows.Forms.ToolStripMenuItem();
			this.B_Opening = new System.Windows.Forms.ToolStripMenuItem();
			this.Edit_B = new System.Windows.Forms.ToolStripButton();
			this.Delet_B = new System.Windows.Forms.ToolStripButton();
			this.Save_B = new System.Windows.Forms.ToolStripButton();
			this.Search_B = new System.Windows.Forms.ToolStripButton();
			this.Chap = new System.Windows.Forms.ToolStripButton();
			this.B_Excel = new System.Windows.Forms.ToolStripButton();
			this.B_Picture = new System.Windows.Forms.ToolStripButton();
			this.Abort_B = new System.Windows.Forms.ToolStripButton();
			this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
			this.TabControl1 = new System.Windows.Forms.TabControl();
			this.TabPage1 = new System.Windows.Forms.TabPage();
			this.Personal_Ask_Refrence = new System.Windows.Forms.TextBox();
			this.Number_Ask_Refrence = new System.Windows.Forms.TextBox();
			this.Description_Ask_Refrence = new System.Windows.Forms.TextBox();
			this.Label9 = new System.Windows.Forms.Label();
			this.B_Personal_Ask_Refrence = new System.Windows.Forms.Button();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.Date_Ask_Refrence = new Ansaripour.Rtl_Date();
			this.TabPage2 = new System.Windows.Forms.TabPage();
			this.Description_Buy_Refrence = new System.Windows.Forms.TextBox();
			this.Number_Buy_Refrence = new System.Windows.Forms.TextBox();
			this.Label19 = new System.Windows.Forms.Label();
			this.Label_Date_S_Refrence = new System.Windows.Forms.Label();
			this.Label_Number_S_Refrence = new System.Windows.Forms.Label();
			this.Date_Buy_Refrence = new Ansaripour.Rtl_Date();
			this.TabPage3 = new System.Windows.Forms.TabPage();
			this.Description_Receipt_Refrence = new System.Windows.Forms.TextBox();
			this.Stock_Receipt_Refrence = new System.Windows.Forms.TextBox();
			this.Procurement_Receipt_Refrence = new System.Windows.Forms.TextBox();
			this.Number_Receipt_Refrence = new System.Windows.Forms.TextBox();
			this.Label8 = new System.Windows.Forms.Label();
			this.Label14 = new System.Windows.Forms.Label();
			this.B_Stock_Receipt_Refrence = new System.Windows.Forms.Button();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label11 = new System.Windows.Forms.Label();
			this.B_Procurement_Receipt_Refrence = new System.Windows.Forms.Button();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label_Number_Receipt_Refrence = new System.Windows.Forms.Label();
			this.Date_Receipt_Refrence = new Ansaripour.Rtl_Date();
			this.TabPage4 = new System.Windows.Forms.TabPage();
			this.Description_Remittance_Refrence = new System.Windows.Forms.TextBox();
			this.Stock_Remittance_Refrence = new System.Windows.Forms.TextBox();
			this.Personal_Remittance_Refrence = new System.Windows.Forms.TextBox();
			this.Number_Remittance_Refrence = new System.Windows.Forms.TextBox();
			this.B_Stock_Remittance_Refrence = new System.Windows.Forms.Button();
			this.Label12 = new System.Windows.Forms.Label();
			this.Label13 = new System.Windows.Forms.Label();
			this.B_Personal_Remittance_Refrence = new System.Windows.Forms.Button();
			this.Label10 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label7 = new System.Windows.Forms.Label();
			this.Date_Remittance_Refrence = new Ansaripour.Rtl_Date();
			this.TabPage5 = new System.Windows.Forms.TabPage();
			this.Stock_Ta_Refrence = new System.Windows.Forms.TextBox();
			this.Stock_Az_Refrence = new System.Windows.Forms.TextBox();
			this.Label18 = new System.Windows.Forms.Label();
			this.Label17 = new System.Windows.Forms.Label();
			this.Button2 = new System.Windows.Forms.Button();
			this.Label16 = new System.Windows.Forms.Label();
			this.Button1 = new System.Windows.Forms.Button();
			this.Label15 = new System.Windows.Forms.Label();
			this.Date_Ta_Refrence = new Ansaripour.Rtl_Date();
			this.Date_Az_Refrence = new Ansaripour.Rtl_Date();
			this.SplitContainer2 = new System.Windows.Forms.SplitContainer();

//====================================================================================================
//End of the allowed output for the Free Edition of Instant C#.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-instant-csharp.html
//====================================================================================================
