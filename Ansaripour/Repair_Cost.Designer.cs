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
	public partial class Repair_Cost : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Repair_Cost));
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
			this.Cost_Time_Stop_Work = new System.Windows.Forms.MaskedTextBox();
			this.Cost_Time_Befor_Work = new System.Windows.Forms.MaskedTextBox();
			this.Cost_Time_Stop_Repair = new System.Windows.Forms.MaskedTextBox();
			this.Label14 = new System.Windows.Forms.Label();
			this.Cost_Time_Request = new Ansaripour.Rtl_Time();
			this.Cost_End_Time_Work = new Ansaripour.Rtl_Time();
			this.Cost_Start_Time_Work = new Ansaripour.Rtl_Time();
			this.Label12 = new System.Windows.Forms.Label();
			this.Label13 = new System.Windows.Forms.Label();
			this.Cost_Stop_Defect = new System.Windows.Forms.TextBox();
			this.B_Repair_Phase = new System.Windows.Forms.Button();
			this.Label11 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.Cost_End_Date_Work = new Ansaripour.Rtl_Date();
			this.Label9 = new System.Windows.Forms.Label();
			this.Cost_Start_Date_Work = new Ansaripour.Rtl_Date();
			this.Label10 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Cost_Work_description = new System.Windows.Forms.TextBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.Cost_Date_Sabt = new Ansaripour.Rtl_Date();
			this.Label17 = new System.Windows.Forms.Label();
			this.Cost_Id_Request = new System.Windows.Forms.TextBox();
			this.B_Repair_Energy = new System.Windows.Forms.Button();
			this.Label8 = new System.Windows.Forms.Label();
			this.Cost_Date_Request = new Ansaripour.Rtl_Date();
			this.Label7 = new System.Windows.Forms.Label();
			this.Cost_Repair_description = new System.Windows.Forms.TextBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.Cost_Num_Request = new System.Windows.Forms.TextBox();
			this.B_Repair_Seating = new System.Windows.Forms.Button();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.Cost_Id_Total = new System.Windows.Forms.TextBox();
			this.Label26 = new System.Windows.Forms.Label();
			this.TabPage3 = new System.Windows.Forms.TabPage();
			this.Dv_Stock = new System.Windows.Forms.DataGridView();
			this.DV = new System.Windows.Forms.DataGridView();
			this.ToolStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.SplitContainer1).BeginInit();
			this.SplitContainer1.Panel1.SuspendLayout();
			this.SplitContainer1.Panel2.SuspendLayout();
			this.SplitContainer1.SuspendLayout();
			this.TabControl1.SuspendLayout();
			this.TabPage1.SuspendLayout();
			this.TabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.Dv_Stock).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.DV).BeginInit();
			this.SuspendLayout();
			//
			//ToolStrip
			//
			this.ToolStrip.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
			this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.New_B, this.Edit_B, this.Delet_B, this.Save_B, this.Search_B, this.B_Excel, this.Chap, this.Abort_B});
			this.ToolStrip.Location = new System.Drawing.Point(0, 0);
			this.ToolStrip.Name = "ToolStrip";
			this.ToolStrip.Size = new System.Drawing.Size(1070, 26);
			this.ToolStrip.TabIndex = 1;
			this.ToolStrip.Text = "ToolStrip1";
			//
			//New_B
			//
			this.New_B.Image = (System.Drawing.Image)resources.GetObject("New_B.Image");
			this.New_B.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.New_B.Name = "New_B";
			this.New_B.Size = new System.Drawing.Size(62, 23);
			this.New_B.Text = "جدید";
			//
			//Edit_B
			//
			this.Edit_B.Image = (System.Drawing.Image)resources.GetObject("Edit_B.Image");

//====================================================================================================
//End of the allowed output for the Free Edition of Instant C#.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-instant-csharp.html
//====================================================================================================
