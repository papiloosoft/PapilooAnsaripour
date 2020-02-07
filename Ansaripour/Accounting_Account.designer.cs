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
	public partial class Accounting_Account : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accounting_Account));
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
			this.Acc_Case = new System.Windows.Forms.TextBox();
			this.Acc_Code = new System.Windows.Forms.TextBox();
			this.Acc_Num = new System.Windows.Forms.TextBox();
			this.Acc_Level = new System.Windows.Forms.TextBox();
			this.Acc_Name = new System.Windows.Forms.TextBox();
			this.Delet_Level = new System.Windows.Forms.Button();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.Acc_Operation = new System.Windows.Forms.ComboBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label8 = new System.Windows.Forms.Label();
			this.B_Level = new System.Windows.Forms.Button();
			this.Label3 = new System.Windows.Forms.Label();
			this.Acc_Group = new System.Windows.Forms.ComboBox();
			this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
			this.New_B = new System.Windows.Forms.ToolStripButton();
			this.Edit_B = new System.Windows.Forms.ToolStripButton();
			this.Save_B = new System.Windows.Forms.ToolStripButton();
			this.Delet_B = new System.Windows.Forms.ToolStripButton();
			this.Search_B = new System.Windows.Forms.ToolStripButton();
			this.Relation_B = new System.Windows.Forms.ToolStripButton();
			this.Excel_B = new System.Windows.Forms.ToolStripButton();
			this.Picture_B = new System.Windows.Forms.ToolStripButton();
			this.Chap = new System.Windows.Forms.ToolStripButton();
			this.Abort_B = new System.Windows.Forms.ToolStripButton();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.SplitContainer2 = new System.Windows.Forms.SplitContainer();
			this.tvData = new System.Windows.Forms.TreeView();
			this.DV = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)this.SplitContainer1).BeginInit();
			this.SplitContainer1.Panel1.SuspendLayout();
			this.SplitContainer1.Panel2.SuspendLayout();
			this.SplitContainer1.SuspendLayout();
			this.ToolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.SplitContainer2).BeginInit();
			this.SplitContainer2.Panel1.SuspendLayout();
			this.SplitContainer2.Panel2.SuspendLayout();
			this.SplitContainer2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.DV).BeginInit();
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
			this.SplitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.SplitContainer1.Panel1.Controls.Add(this.Acc_Case);
			this.SplitContainer1.Panel1.Controls.Add(this.Acc_Code);
			this.SplitContainer1.Panel1.Controls.Add(this.Acc_Num);
			this.SplitContainer1.Panel1.Controls.Add(this.Acc_Level);
			this.SplitContainer1.Panel1.Controls.Add(this.Acc_Name);
			this.SplitContainer1.Panel1.Controls.Add(this.Delet_Level);
			this.SplitContainer1.Panel1.Controls.Add(this.Label6);
			this.SplitContainer1.Panel1.Controls.Add(this.Label5);
			this.SplitContainer1.Panel1.Controls.Add(this.Acc_Operation);
			this.SplitContainer1.Panel1.Controls.Add(this.Label4);
			this.SplitContainer1.Panel1.Controls.Add(this.Label8);
			this.SplitContainer1.Panel1.Controls.Add(this.B_Level);
			this.SplitContainer1.Panel1.Controls.Add(this.Label3);
			this.SplitContainer1.Panel1.Controls.Add(this.Acc_Group);
			this.SplitContainer1.Panel1.Controls.Add(this.ToolStrip1);
			this.SplitContainer1.Panel1.Controls.Add(this.Label2);
			this.SplitContainer1.Panel1.Controls.Add(this.Label1);
			this.SplitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			//
			//SplitContainer1.Panel2
			//
			this.SplitContainer1.Panel2.Controls.Add(this.SplitContainer2);
			this.SplitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.SplitContainer1.Size = new System.Drawing.Size(1032, 526);
			this.SplitContainer1.SplitterDistance = 132;
			this.SplitContainer1.TabIndex = 65;
			//
			//Acc_Case
			//
			this.Acc_Case.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
			this.Acc_Case.Location = new System.Drawing.Point(10, 95);
			this.Acc_Case.Name = "Acc_Case";
			this.Acc_Case.Size = new System.Drawing.Size(56, 31);
			this.Acc_Case.TabIndex = 193;
			//
			//Acc_Code
			//
			this.Acc_Code.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);

//====================================================================================================
//End of the allowed output for the Free Edition of Instant C#.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-instant-csharp.html
//====================================================================================================
