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
	public partial class Order_Add : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order_Add));
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
			this.B_Order_Add = new System.Windows.Forms.ToolStripButton();
			this.Edit_B = new System.Windows.Forms.ToolStripButton();
			this.Delet_B = new System.Windows.Forms.ToolStripButton();
			this.Save_B = new System.Windows.Forms.ToolStripButton();
			this.Search_B = new System.Windows.Forms.ToolStripButton();
			this.B_Excel = new System.Windows.Forms.ToolStripButton();
			this.B_Picture = new System.Windows.Forms.ToolStripButton();
			this.ToolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
			this.Report_Order_Add = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.CHEK = new System.Windows.Forms.ToolStripMenuItem();
			this.Report_Order_Factor = new System.Windows.Forms.ToolStripMenuItem();
			this.Abort_B = new System.Windows.Forms.ToolStripButton();
			this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
			this.TabControl1 = new System.Windows.Forms.TabControl();
			this.TabPage1 = new System.Windows.Forms.TabPage();
			this.Order_Number = new System.Windows.Forms.TextBox();
			this.Order_Subscription = new System.Windows.Forms.TextBox();
			this.Order_Description = new System.Windows.Forms.RichTextBox();
			this.Label16 = new System.Windows.Forms.Label();
			this.Order_In_Description = new System.Windows.Forms.RichTextBox();
			this.Label15 = new System.Windows.Forms.Label();
			this.Order_Time = new System.Windows.Forms.MaskedTextBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label9 = new System.Windows.Forms.Label();
			this.B_Order_Subscription = new System.Windows.Forms.Button();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Order_Date = new Ansaripour.Rtl_Date();
			this.TabPage2 = new System.Windows.Forms.TabPage();
			this.GroupBox5 = new System.Windows.Forms.GroupBox();
			this.Button_Order = new System.Windows.Forms.Button();
			this.Order_Service_Description = new System.Windows.Forms.RichTextBox();
			this.Label12 = new System.Windows.Forms.Label();
			this.Label8 = new System.Windows.Forms.Label();
			this.Label10 = new System.Windows.Forms.Label();
			this.Order_Service_End_Time = new Ansaripour.Rtl_Time();
			this.Order_Service_End_Date = new Ansaripour.Rtl_Date();
			this.Order_Service_Start_Date = new Ansaripour.Rtl_Date();
			this.GroupBox4 = new System.Windows.Forms.GroupBox();
			this.Dv_Request = new System.Windows.Forms.DataGridView();
			this.TabPage3 = new System.Windows.Forms.TabPage();
			this.Order_Pay = new System.Windows.Forms.TextBox();
			this.Order_PrePayment = new System.Windows.Forms.TextBox();
			this.Order_Factor = new System.Windows.Forms.TextBox();
			this.Order_Tax = new System.Windows.Forms.TextBox();
			this.Order_Discount = new System.Windows.Forms.TextBox();
			this.Label7 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Types = new System.Windows.Forms.Label();
			this.Label13 = new System.Windows.Forms.Label();
			this.GroupBox3 = new System.Windows.Forms.GroupBox();
			this.Dv_Details = new System.Windows.Forms.DataGridView();
			this.SplitContainer2 = new System.Windows.Forms.SplitContainer();
			this.SplitContainer3 = new System.Windows.Forms.SplitContainer();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.Dv1 = new System.Windows.Forms.DataGridView();
			this.GroupBox2 = new System.Windows.Forms.GroupBox();
			this.Dv2 = new System.Windows.Forms.DataGridView();
			this.DV = new System.Windows.Forms.DataGridView();
			this.ToolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.SplitContainer1).BeginInit();
			this.SplitContainer1.Panel1.SuspendLayout();
			this.SplitContainer1.Panel2.SuspendLayout();
			this.SplitContainer1.SuspendLayout();

//====================================================================================================
//End of the allowed output for the Free Edition of Instant C#.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-instant-csharp.html
//====================================================================================================
