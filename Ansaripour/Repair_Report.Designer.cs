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
	public partial class Repair_Report : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Repair_Report));
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.ToolStrip = new System.Windows.Forms.ToolStrip();
			this.Search_B = new System.Windows.Forms.ToolStripButton();
			this.B_Excel = new System.Windows.Forms.ToolStripButton();
			this.Chap = new System.Windows.Forms.ToolStripButton();
			this.Abort_B = new System.Windows.Forms.ToolStripButton();
			this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
			this.TabControl1 = new System.Windows.Forms.TabControl();
			this.TabPage1 = new System.Windows.Forms.TabPage();
			this.Cost_Time_Befor_Work = new System.Windows.Forms.MaskedTextBox();
			this.Label14 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.Az_Cost_Date_Sabt = new Ansaripour.Rtl_Date();
			this.Label2 = new System.Windows.Forms.Label();
			this.Ta_Cost_Date_Request = new Ansaripour.Rtl_Date();
			this.Cost_Stop_Defect = new System.Windows.Forms.TextBox();
			this.B_Cost_Stop_Defect = new System.Windows.Forms.Button();
			this.Label3 = new System.Windows.Forms.Label();
			this.Cost_Work_description = new System.Windows.Forms.TextBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.Ta_Cost_Date_Sabt = new Ansaripour.Rtl_Date();
			this.Label17 = new System.Windows.Forms.Label();
			this.Cost_Id_Request = new System.Windows.Forms.TextBox();
			this.B_Cost_Id_Request = new System.Windows.Forms.Button();
			this.Label8 = new System.Windows.Forms.Label();
			this.Az_Cost_Date_Request = new Ansaripour.Rtl_Date();
			this.Label7 = new System.Windows.Forms.Label();
			this.Cost_Repair_description = new System.Windows.Forms.TextBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.Cost_Num_Request = new System.Windows.Forms.TextBox();
			this.B_Cost_Id_Total = new System.Windows.Forms.Button();
			this.Label5 = new System.Windows.Forms.Label();
			this.Cost_Id_Total = new System.Windows.Forms.TextBox();
			this.Label26 = new System.Windows.Forms.Label();
			this.Check = new System.Windows.Forms.CheckBox();
			this.DV = new System.Windows.Forms.DataGridView();
			this.ToolStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.SplitContainer1).BeginInit();
			this.SplitContainer1.Panel1.SuspendLayout();
			this.SplitContainer1.Panel2.SuspendLayout();
			this.SplitContainer1.SuspendLayout();
			this.TabControl1.SuspendLayout();
			this.TabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.DV).BeginInit();
			this.SuspendLayout();
			//
			//ToolStrip
			//
			this.ToolStrip.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
			this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.Search_B, this.B_Excel, this.Chap, this.Abort_B});
			this.ToolStrip.Location = new System.Drawing.Point(0, 0);
			this.ToolStrip.Name = "ToolStrip";
			this.ToolStrip.Size = new System.Drawing.Size(1011, 26);
			this.ToolStrip.TabIndex = 1;
			this.ToolStrip.Text = "ToolStrip1";
			//
			//Search_B
			//
			this.Search_B.Image = (System.Drawing.Image)resources.GetObject("Search_B.Image");
			this.Search_B.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Search_B.Name = "Search_B";
			this.Search_B.Size = new System.Drawing.Size(81, 23);
			this.Search_B.Text = "جستجو";
			//
			//B_Excel
			//
			this.B_Excel.Image = (System.Drawing.Image)resources.GetObject("B_Excel.Image");
			this.B_Excel.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.B_Excel.Name = "B_Excel";
			this.B_Excel.Size = new System.Drawing.Size(70, 23);
			this.B_Excel.Text = "اکسل";
			//
			//Chap
			//
			this.Chap.Image = (System.Drawing.Image)resources.GetObject("Chap.Image");
			this.Chap.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Chap.Name = "Chap";
			this.Chap.Size = new System.Drawing.Size(58, 23);
			this.Chap.Text = "چاپ";
			//
			//Abort_B
			//
			this.Abort_B.Image = (System.Drawing.Image)resources.GetObject("Abort_B.Image");
			this.Abort_B.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Abort_B.Name = "Abort_B";
			this.Abort_B.Size = new System.Drawing.Size(74, 23);
			this.Abort_B.Text = "انصراف";
			//
			//SplitContainer1
			//
			this.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SplitContainer1.Location = new System.Drawing.Point(0, 26);
			this.SplitContainer1.Name = "SplitContainer1";
			this.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			//
			//SplitContainer1.Panel1
			//
			this.SplitContainer1.Panel1.Controls.Add(this.TabControl1);

//====================================================================================================
//End of the allowed output for the Free Edition of Instant C#.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-instant-csharp.html
//====================================================================================================
