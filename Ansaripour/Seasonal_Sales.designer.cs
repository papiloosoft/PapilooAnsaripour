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
	public partial class Seasonal_Sales : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Seasonal_Sales));
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
			this.Seasonal_Year = new System.Windows.Forms.MaskedTextBox();
			this.Label18 = new System.Windows.Forms.Label();
			this.Seasonal_Valu_Price_check = new System.Windows.Forms.CheckBox();
			this.Label12 = new System.Windows.Forms.Label();
			this.Seasonal_Complications = new System.Windows.Forms.TextBox();
			this.Label11 = new System.Windows.Forms.Label();
			this.Seasonal_Complications_Price = new System.Windows.Forms.TextBox();
			this.Label6 = new System.Windows.Forms.Label();
			this.Seasonal_Valu_Price = new System.Windows.Forms.TextBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.Seasonal_Pure_Price = new System.Windows.Forms.TextBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.Seasonal_Discount_Price = new System.Windows.Forms.TextBox();
			this.Seasonal_Documents_Number = new System.Windows.Forms.TextBox();
			this.Label15 = new System.Windows.Forms.Label();
			this.Label13 = new System.Windows.Forms.Label();
			this.Label14 = new System.Windows.Forms.Label();
			this.B_Seasonal_Company = new System.Windows.Forms.Button();
			this.Seasonal_Operation = new System.Windows.Forms.ComboBox();
			this.Seasonal_Bill_Date = new Ansaripour.Rtl_Date();
			this.Seasonal_Documents_Date = new Ansaripour.Rtl_Date();
			this.Seasonal_Date = new Ansaripour.Rtl_Date();
			this.Seasonal_Description = new System.Windows.Forms.TextBox();
			this.Label10 = new System.Windows.Forms.Label();
			this.Seasonal_Product_Name = new System.Windows.Forms.TextBox();
			this.Label9 = new System.Windows.Forms.Label();
			this.Seasonal_Gross_Price = new System.Windows.Forms.TextBox();
			this.Seasonal_Product_Type = new System.Windows.Forms.ComboBox();
			this.Label8 = new System.Windows.Forms.Label();
			this.Label7 = new System.Windows.Forms.Label();
			this.Seasonal_Bill_Number = new System.Windows.Forms.TextBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.Seasonal_Product_Id = new System.Windows.Forms.TextBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.Seasonal_Subscription = new System.Windows.Forms.TextBox();
			this.ToolStrip = new System.Windows.Forms.ToolStrip();
			this.B_New = new System.Windows.Forms.ToolStripButton();
			this.B_Edit = new System.Windows.Forms.ToolStripButton();
			this.B_Delet = new System.Windows.Forms.ToolStripButton();
			this.B_Save = new System.Windows.Forms.ToolStripButton();
			this.B_Search = new System.Windows.Forms.ToolStripButton();
			this.B_Excel = new System.Windows.Forms.ToolStripButton();
			this.B_Print = new System.Windows.Forms.ToolStripButton();
			this.B_Log_File = new System.Windows.Forms.ToolStripButton();
			this.B_Picture = new System.Windows.Forms.ToolStripButton();
			this.B_Abort = new System.Windows.Forms.ToolStripButton();
			this.Estate_Control = new System.Windows.Forms.ToolStripComboBox();
			this.Label17 = new System.Windows.Forms.Label();
			this.Label16 = new System.Windows.Forms.Label();
			this.DV = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)this.SplitContainer1).BeginInit();
			this.SplitContainer1.Panel1.SuspendLayout();
			this.SplitContainer1.Panel2.SuspendLayout();
			this.SplitContainer1.SuspendLayout();
			this.ToolStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.DV).BeginInit();
			this.SuspendLayout();
			//
			//SplitContainer1
			//
			this.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SplitContainer1.Location = new System.Drawing.Point(0, 0);
			this.SplitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.SplitContainer1.Name = "SplitContainer1";
			this.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			//
			//SplitContainer1.Panel1
			//
			this.SplitContainer1.Panel1.Controls.Add(this.Seasonal_Year);
			this.SplitContainer1.Panel1.Controls.Add(this.Label18);
			this.SplitContainer1.Panel1.Controls.Add(this.Seasonal_Valu_Price_check);
			this.SplitContainer1.Panel1.Controls.Add(this.Label12);
			this.SplitContainer1.Panel1.Controls.Add(this.Seasonal_Complications);
			this.SplitContainer1.Panel1.Controls.Add(this.Label11);
			this.SplitContainer1.Panel1.Controls.Add(this.Seasonal_Complications_Price);
			this.SplitContainer1.Panel1.Controls.Add(this.Label6);
			this.SplitContainer1.Panel1.Controls.Add(this.Seasonal_Valu_Price);
			this.SplitContainer1.Panel1.Controls.Add(this.Label3);
			this.SplitContainer1.Panel1.Controls.Add(this.Seasonal_Pure_Price);
			this.SplitContainer1.Panel1.Controls.Add(this.Label2);

//====================================================================================================
//End of the allowed output for the Free Edition of Instant C#.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-instant-csharp.html
//====================================================================================================
