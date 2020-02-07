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
	public partial class ST_Goods : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ST_Goods));
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
			this.Goods_Description = new System.Windows.Forms.TextBox();
			this.Goods_Technical_Code = new System.Windows.Forms.TextBox();
			this.Goods_Module = new System.Windows.Forms.TextBox();
			this.Goods_Group = new System.Windows.Forms.TextBox();
			this.Goods_name = new System.Windows.Forms.TextBox();
			this.Goods_Code = new System.Windows.Forms.TextBox();
			this.Good_Case = new System.Windows.Forms.ComboBox();
			this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
			this.New_B = new System.Windows.Forms.ToolStripButton();
			this.Edit_B = new System.Windows.Forms.ToolStripButton();
			this.Delet_B = new System.Windows.Forms.ToolStripButton();
			this.Save_B = new System.Windows.Forms.ToolStripButton();
			this.Search_B = new System.Windows.Forms.ToolStripButton();
			this.ToolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.Abort_B = new System.Windows.Forms.ToolStripButton();
			this.Label8 = new System.Windows.Forms.Label();
			this.Label7 = new System.Windows.Forms.Label();
			this.B_Goods_Module = new System.Windows.Forms.Button();
			this.Label5 = new System.Windows.Forms.Label();
			this.B_Goods_Group = new System.Windows.Forms.Button();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.DV = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)this.SplitContainer1).BeginInit();
			this.SplitContainer1.Panel1.SuspendLayout();
			this.SplitContainer1.Panel2.SuspendLayout();
			this.SplitContainer1.SuspendLayout();
			this.ToolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.DV).BeginInit();
			this.SuspendLayout();
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.Label1.Location = new System.Drawing.Point(833, 80);
			this.Label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
			this.Label1.Name = "Label1";
			this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Label1.Size = new System.Drawing.Size(130, 23);
			this.Label1.TabIndex = 56;
			this.Label1.Text = "کـــــد کــــــالا :";
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.Label3.Location = new System.Drawing.Point(499, 79);
			this.Label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
			this.Label3.Name = "Label3";
			this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Label3.Size = new System.Drawing.Size(95, 23);
			this.Label3.TabIndex = 66;
			this.Label3.Text = "شرح کالا :";
			//
			//SplitContainer1
			//
			this.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SplitContainer1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
			this.SplitContainer1.Location = new System.Drawing.Point(0, 0);
			this.SplitContainer1.Name = "SplitContainer1";
			this.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			//
			//SplitContainer1.Panel1
			//
			this.SplitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.SplitContainer1.Panel1.Controls.Add(this.Goods_Description);
			this.SplitContainer1.Panel1.Controls.Add(this.Goods_Technical_Code);
			this.SplitContainer1.Panel1.Controls.Add(this.Goods_Module);
			this.SplitContainer1.Panel1.Controls.Add(this.Goods_Group);
			this.SplitContainer1.Panel1.Controls.Add(this.Goods_name);
			this.SplitContainer1.Panel1.Controls.Add(this.Goods_Code);
			this.SplitContainer1.Panel1.Controls.Add(this.Good_Case);
			this.SplitContainer1.Panel1.Controls.Add(this.ToolStrip1);
			this.SplitContainer1.Panel1.Controls.Add(this.Label8);
			this.SplitContainer1.Panel1.Controls.Add(this.Label7);
			this.SplitContainer1.Panel1.Controls.Add(this.B_Goods_Module);
			this.SplitContainer1.Panel1.Controls.Add(this.Label5);
			this.SplitContainer1.Panel1.Controls.Add(this.B_Goods_Group);
			this.SplitContainer1.Panel1.Controls.Add(this.Label6);
			this.SplitContainer1.Panel1.Controls.Add(this.Label2);
			this.SplitContainer1.Panel1.Controls.Add(this.Label3);
			this.SplitContainer1.Panel1.Controls.Add(this.Label1);
			this.SplitContainer1.Panel1.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
			this.SplitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			//
			//SplitContainer1.Panel2
			//

//====================================================================================================
//End of the allowed output for the Free Edition of Instant C#.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-instant-csharp.html
//====================================================================================================
