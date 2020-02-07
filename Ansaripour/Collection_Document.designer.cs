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
	public partial class Collection_Document : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Collection_Document));
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
			this.B_Recovery_Documents_Collecting_Bank = new System.Windows.Forms.Button();
			this.Recovery_Documents_Collecting_Bank = new System.Windows.Forms.TextBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label12 = new System.Windows.Forms.Label();
			this.Recovery_Documents_Assignment_Date = new Ansaripour.Rtl_Date();
			this.Label15 = new System.Windows.Forms.Label();
			this.Label13 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.Az_Ta = new System.Windows.Forms.Label();
			this.Label19 = new System.Windows.Forms.Label();
			this.Recovery_Documents_From_Date = new Ansaripour.Rtl_Date();
			this.Recovery_Documents_Until_Date = new Ansaripour.Rtl_Date();
			this.Label14 = new System.Windows.Forms.Label();
			this.B_Recovery_Documents_Subscription = new System.Windows.Forms.Button();
			this.Recovery_Documents_Operation = new System.Windows.Forms.ComboBox();
			this.Recovery_Documents_Refund_Date = new Ansaripour.Rtl_Date();
			this.Recovery_Documents_Returned_Date = new Ansaripour.Rtl_Date();
			this.Recovery_Documents_Pass_Date = new Ansaripour.Rtl_Date();
			this.L_Mab = new System.Windows.Forms.TextBox();
			this.Recovery_Documents_Description = new System.Windows.Forms.TextBox();
			this.Recovery_Documents_Due_Date = new Ansaripour.Rtl_Date();
			this.Recovery_Documents_Date_Received = new Ansaripour.Rtl_Date();
			this.Label10 = new System.Windows.Forms.Label();
			this.Recovery_Documents_Bank = new System.Windows.Forms.TextBox();
			this.Label11 = new System.Windows.Forms.Label();
			this.Label9 = new System.Windows.Forms.Label();
			this.Recovery_Documents_Amount = new System.Windows.Forms.TextBox();
			this.Recovery_Documents_Case = new System.Windows.Forms.ComboBox();
			this.Label8 = new System.Windows.Forms.Label();
			this.Label7 = new System.Windows.Forms.Label();
			this.Recovery_Documents_Account_Number = new System.Windows.Forms.TextBox();
			this.Label6 = new System.Windows.Forms.Label();
			this.Recovery_Documents_No_Check = new System.Windows.Forms.TextBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.Recovery_Documents_Branch = new System.Windows.Forms.TextBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.Recovery_Documents_Subscription = new System.Windows.Forms.TextBox();
			this.ToolStrip = new System.Windows.Forms.ToolStrip();
			this.B_Product = new System.Windows.Forms.ToolStripDropDownButton();
			this.B_New = new System.Windows.Forms.ToolStripMenuItem();
			this.B_Old = new System.Windows.Forms.ToolStripMenuItem();
			this.B_Assignment = new System.Windows.Forms.ToolStripMenuItem();
			this.B_Assignment_All = new System.Windows.Forms.ToolStripMenuItem();
			this.B_Collecting = new System.Windows.Forms.ToolStripMenuItem();
			this.B_Returned = new System.Windows.Forms.ToolStripMenuItem();
			this.B_Refund = new System.Windows.Forms.ToolStripMenuItem();
			this.Edit_B = new System.Windows.Forms.ToolStripButton();
			this.Delet_B = new System.Windows.Forms.ToolStripButton();
			this.Search_B = new System.Windows.Forms.ToolStripButton();
			this.Save_B = new System.Windows.Forms.ToolStripButton();
			this.B_Excel = new System.Windows.Forms.ToolStripButton();
			this.Chap = new System.Windows.Forms.ToolStripButton();
			this.Log_File = new System.Windows.Forms.ToolStripButton();
			this.B_Picture = new System.Windows.Forms.ToolStripButton();
			this.Abort_B = new System.Windows.Forms.ToolStripButton();
			this.Label17 = new System.Windows.Forms.Label();
			this.Label16 = new System.Windows.Forms.Label();
			this.DV = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)this.SplitContainer1).BeginInit();
			this.SplitContainer1.Panel1.SuspendLayout();
			this.SplitContainer1.Panel2.SuspendLayout();
			this.SplitContainer1.SuspendLayout();
			this.GroupBox1.SuspendLayout();
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
			this.SplitContainer1.Panel1.Controls.Add(this.B_Recovery_Documents_Collecting_Bank);
			this.SplitContainer1.Panel1.Controls.Add(this.Recovery_Documents_Collecting_Bank);

//====================================================================================================
//End of the allowed output for the Free Edition of Instant C#.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-instant-csharp.html
//====================================================================================================
