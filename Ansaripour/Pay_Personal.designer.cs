using System.Drawing.Imaging;

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
	public partial class Pay_Personal : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pay_Personal));
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
			this.B_New = new System.Windows.Forms.ToolStripButton();
			this.B_Edit = new System.Windows.Forms.ToolStripButton();
			this.B_Delet = new System.Windows.Forms.ToolStripButton();
			this.B_Save = new System.Windows.Forms.ToolStripButton();
			this.B_Search = new System.Windows.Forms.ToolStripButton();
			this.B_Excel = new System.Windows.Forms.ToolStripButton();
			this.B_Picture = new System.Windows.Forms.ToolStripButton();
			this.B_Print = new System.Windows.Forms.ToolStripButton();
			this.B_Abort = new System.Windows.Forms.ToolStripButton();
			this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
			this.Pay_Personal_Address = new System.Windows.Forms.TextBox();
			this.Pay_Personal_Tell = new System.Windows.Forms.TextBox();
			this.Pay_Personal_Account = new System.Windows.Forms.TextBox();
			this.Pay_Personal_Insurance = new System.Windows.Forms.TextBox();
			this.Pay_Personal_Discipline = new System.Windows.Forms.TextBox();
			this.Pay_Personal_National_Id = new System.Windows.Forms.TextBox();
			this.Pay_Personal_Cirtificate_Id = new System.Windows.Forms.TextBox();
			this.Pay_Personal_Place_Berthday = new System.Windows.Forms.TextBox();
			this.Pay_Personal_Father = new System.Windows.Forms.TextBox();
			this.Pay_Personal_Family = new System.Windows.Forms.TextBox();
			this.Pay_Personal_Name = new System.Windows.Forms.TextBox();
			this.Pay_Personal_Code = new System.Windows.Forms.TextBox();
			this.Pay_Personal_Date_Berthday = new Ansaripour.Rtl_Date();
			this.Pay_Personal_Soldier = new System.Windows.Forms.ComboBox();
			this.Label17 = new System.Windows.Forms.Label();
			this.Pay_Personal_Diploma = new System.Windows.Forms.ComboBox();
			this.Label14 = new System.Windows.Forms.Label();
			this.Pay_Personal_Marry = new System.Windows.Forms.ComboBox();
			this.Pay_Personal_Sex = new System.Windows.Forms.ComboBox();
			this.Label11 = new System.Windows.Forms.Label();
			this.Label9 = new System.Windows.Forms.Label();
			this.Label7 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label10 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label12 = new System.Windows.Forms.Label();
			this.Label8 = new System.Windows.Forms.Label();
			this.Label16 = new System.Windows.Forms.Label();
			this.Label15 = new System.Windows.Forms.Label();
			this.Label13 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.DV = new System.Windows.Forms.DataGridView();
			this.P_Date = new Ansaripour.Rtl_Date();
			this.ToolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.SplitContainer1).BeginInit();
			this.SplitContainer1.Panel1.SuspendLayout();
			this.SplitContainer1.Panel2.SuspendLayout();
			this.SplitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.DV).BeginInit();
			this.SuspendLayout();
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.Label1.Location = new System.Drawing.Point(864, 36);
			this.Label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
			this.Label1.Name = "Label1";
			this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Label1.Size = new System.Drawing.Size(125, 19);
			this.Label1.TabIndex = 56;
			this.Label1.Text = "شماره پرسنلی :";
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.Label3.Location = new System.Drawing.Point(743, 35);
			this.Label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
			this.Label3.Name = "Label3";
			this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Label3.Size = new System.Drawing.Size(38, 19);
			this.Label3.TabIndex = 66;
			this.Label3.Text = "نام :";
			//
			//ToolStrip1
			//
			this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.B_New, this.B_Edit, this.B_Delet, this.B_Save, this.B_Search, this.B_Excel, this.B_Picture, this.B_Print, this.B_Abort});
			this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
			this.ToolStrip1.Name = "ToolStrip1";
			this.ToolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;

//====================================================================================================
//End of the allowed output for the Free Edition of Instant C#.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-instant-csharp.html
//====================================================================================================
