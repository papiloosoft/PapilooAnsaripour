using System.IO;
using Microsoft.Office.Interop;
using System.Net;
using System.Text;

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
	public partial class Payable : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payable));
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
			this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
			this.New_B = new System.Windows.Forms.ToolStripButton();
			this.Edit_B = new System.Windows.Forms.ToolStripButton();
			this.Delet_B = new System.Windows.Forms.ToolStripButton();
			this.Save_B = new System.Windows.Forms.ToolStripButton();
			this.Search_B = new System.Windows.Forms.ToolStripButton();
			this.B_Excel = new System.Windows.Forms.ToolStripButton();
			this.ToolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
			this.CHAP = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.CHEK = new System.Windows.Forms.ToolStripMenuItem();
			this.Letter = new System.Windows.Forms.ToolStripMenuItem();
			this.Report = new System.Windows.Forms.ToolStripMenuItem();
			this.Abort_B = new System.Windows.Forms.ToolStripButton();
			this.Clas = new System.Windows.Forms.ToolStripTextBox();
			this.DV = new System.Windows.Forms.DataGridView();
			this.Types = new System.Windows.Forms.Label();
			this.Amount = new System.Windows.Forms.TextBox();
			this.Label13 = new System.Windows.Forms.Label();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.M_Bank = new System.Windows.Forms.TextBox();
			this.Label12 = new System.Windows.Forms.Label();
			this.Branch_Code = new System.Windows.Forms.TextBox();
			this.Label11 = new System.Windows.Forms.Label();
			this.Branch_Name = new System.Windows.Forms.TextBox();
			this.Label10 = new System.Windows.Forms.Label();
			this.Bank_Name = new System.Windows.Forms.TextBox();
			this.Label9 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.Payable_Account = new System.Windows.Forms.ComboBox();
			this.Payable_Id = new System.Windows.Forms.TextBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.PictureBox1 = new System.Windows.Forms.PictureBox();
			this.B_Control = new Ansaripour.B_Control();
			this.Label14 = new System.Windows.Forms.Label();
			this.TabControl1 = new System.Windows.Forms.TabControl();
			this.TabPage1 = new System.Windows.Forms.TabPage();
			this.Payable_Description = new System.Windows.Forms.TextBox();
			this.TabPage2 = new System.Windows.Forms.TabPage();
			this.Dv_Details = new System.Windows.Forms.DataGridView();
			this.Payable_Number = new System.Windows.Forms.TextBox();
			this.B_Date = new Ansaripour.Rtl_Date();
			this.Payable_Date = new Ansaripour.Rtl_Date();
			((System.ComponentModel.ISupportInitialize)this.SplitContainer1).BeginInit();
			this.SplitContainer1.Panel1.SuspendLayout();
			this.SplitContainer1.Panel2.SuspendLayout();
			this.SplitContainer1.SuspendLayout();
			this.ToolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.DV).BeginInit();
			this.GroupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
			this.TabControl1.SuspendLayout();
			this.TabPage1.SuspendLayout();
			this.TabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.Dv_Details).BeginInit();
			this.SuspendLayout();
			//
			//SplitContainer1
			//
			this.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SplitContainer1.Location = new System.Drawing.Point(0, 0);
			this.SplitContainer1.Name = "SplitContainer1";
			this.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			//
			//SplitContainer1.Panel1
			//
			this.SplitContainer1.Panel1.Controls.Add(this.ToolStrip1);
			this.SplitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			//
			//SplitContainer1.Panel2
			//
			this.SplitContainer1.Panel2.Controls.Add(this.DV);
			this.SplitContainer1.Panel2.Controls.Add(this.Types);
			this.SplitContainer1.Panel2.Controls.Add(this.Amount);
			this.SplitContainer1.Panel2.Controls.Add(this.Label13);
			this.SplitContainer1.Panel2.Controls.Add(this.GroupBox1);
			this.SplitContainer1.Panel2.Controls.Add(this.Label6);
			this.SplitContainer1.Panel2.Controls.Add(this.Label5);

//====================================================================================================
//End of the allowed output for the Free Edition of Instant C#.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-instant-csharp.html
//====================================================================================================
