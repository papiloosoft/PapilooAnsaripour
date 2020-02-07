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
	public partial class user : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(user));
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
			this.SplitContainer2 = new System.Windows.Forms.SplitContainer();
			this.password = new System.Windows.Forms.TextBox();
			this.username = new System.Windows.Forms.TextBox();
			this.Label6 = new System.Windows.Forms.Label();
			this.Admin = new System.Windows.Forms.CheckBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.Pass_View = new System.Windows.Forms.CheckBox();
			this.Description = new System.Windows.Forms.RichTextBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.B_Area = new System.Windows.Forms.Button();
			this.Area = new System.Windows.Forms.TextBox();
			this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
			this.B_New = new System.Windows.Forms.ToolStripButton();
			this.B_Edit = new System.Windows.Forms.ToolStripButton();
			this.B_Delet = new System.Windows.Forms.ToolStripButton();
			this.B_Save = new System.Windows.Forms.ToolStripButton();
			this.B_Picture = new System.Windows.Forms.ToolStripButton();
			this.B_Search = new System.Windows.Forms.ToolStripButton();
			this.B_Online = new System.Windows.Forms.ToolStripButton();
			this.B_Abort = new System.Windows.Forms.ToolStripButton();
			this.Dv = new System.Windows.Forms.DataGridView();
			this.tvData = new System.Windows.Forms.TreeView();
			((System.ComponentModel.ISupportInitialize)this.SplitContainer1).BeginInit();
			this.SplitContainer1.Panel1.SuspendLayout();
			this.SplitContainer1.Panel2.SuspendLayout();
			this.SplitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.SplitContainer2).BeginInit();
			this.SplitContainer2.Panel1.SuspendLayout();
			this.SplitContainer2.Panel2.SuspendLayout();
			this.SplitContainer2.SuspendLayout();
			this.ToolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.Dv).BeginInit();
			this.SuspendLayout();
			//
			//SplitContainer1
			//
			this.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SplitContainer1.Location = new System.Drawing.Point(0, 0);
			this.SplitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.SplitContainer1.Name = "SplitContainer1";
			//
			//SplitContainer1.Panel1
			//
			this.SplitContainer1.Panel1.Controls.Add(this.SplitContainer2);
			this.SplitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			//
			//SplitContainer1.Panel2
			//
			this.SplitContainer1.Panel2.Controls.Add(this.tvData);
			this.SplitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.SplitContainer1.Size = new System.Drawing.Size(1131, 504);
			this.SplitContainer1.SplitterDistance = 577;
			this.SplitContainer1.TabIndex = 264;
			//
			//SplitContainer2
			//
			this.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SplitContainer2.Location = new System.Drawing.Point(0, 0);
			this.SplitContainer2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.SplitContainer2.Name = "SplitContainer2";
			this.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
			//
			//SplitContainer2.Panel1
			//
			this.SplitContainer2.Panel1.Controls.Add(this.password);
			this.SplitContainer2.Panel1.Controls.Add(this.username);
			this.SplitContainer2.Panel1.Controls.Add(this.Label6);
			this.SplitContainer2.Panel1.Controls.Add(this.Admin);
			this.SplitContainer2.Panel1.Controls.Add(this.Label5);
			this.SplitContainer2.Panel1.Controls.Add(this.Pass_View);
			this.SplitContainer2.Panel1.Controls.Add(this.Description);
			this.SplitContainer2.Panel1.Controls.Add(this.Label4);
			this.SplitContainer2.Panel1.Controls.Add(this.Label3);
			this.SplitContainer2.Panel1.Controls.Add(this.Label2);
			this.SplitContainer2.Panel1.Controls.Add(this.Label1);
			this.SplitContainer2.Panel1.Controls.Add(this.B_Area);
			this.SplitContainer2.Panel1.Controls.Add(this.Area);
			this.SplitContainer2.Panel1.Controls.Add(this.ToolStrip1);
			this.SplitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			//
			//SplitContainer2.Panel2
			//
			this.SplitContainer2.Panel2.Controls.Add(this.Dv);
			this.SplitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.SplitContainer2.Size = new System.Drawing.Size(577, 504);
			this.SplitContainer2.SplitterDistance = 246;
			this.SplitContainer2.TabIndex = 264;
			//
			//password
			//
			this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
			this.password.Location = new System.Drawing.Point(152, 75);
			this.password.Name = "password";

//====================================================================================================
//End of the allowed output for the Free Edition of Instant C#.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-instant-csharp.html
//====================================================================================================
