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
	public partial class View : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View));
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
			this.ToolStrip = new System.Windows.Forms.ToolStrip();
			this.B_Excel = new System.Windows.Forms.ToolStripButton();
			this.Print_B = new System.Windows.Forms.ToolStripButton();
			this.DV = new System.Windows.Forms.DataGridView();
			this.Sms_B = new System.Windows.Forms.ToolStripButton();
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
			this.SplitContainer1.Name = "SplitContainer1";
			this.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			//
			//SplitContainer1.Panel1
			//
			this.SplitContainer1.Panel1.Controls.Add(this.ToolStrip);
			this.SplitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			//
			//SplitContainer1.Panel2
			//
			this.SplitContainer1.Panel2.Controls.Add(this.DV);
			this.SplitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.SplitContainer1.Size = new System.Drawing.Size(1150, 509);
			this.SplitContainer1.SplitterDistance = 25;
			this.SplitContainer1.TabIndex = 3;
			//
			//ToolStrip
			//
			this.ToolStrip.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
			this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.B_Excel, this.Sms_B, this.Print_B});
			this.ToolStrip.Location = new System.Drawing.Point(0, 0);
			this.ToolStrip.Name = "ToolStrip";
			this.ToolStrip.Size = new System.Drawing.Size(1150, 26);
			this.ToolStrip.TabIndex = 3;
			this.ToolStrip.Text = "ToolStrip1";
			//
			//B_Excel
			//
			this.B_Excel.Image = (System.Drawing.Image)resources.GetObject("B_Excel.Image");
			this.B_Excel.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.B_Excel.Name = "B_Excel";
			this.B_Excel.Size = new System.Drawing.Size(70, 23);
			this.B_Excel.Text = "اکسل";
			//
			//Print_B
			//
			this.Print_B.Image = (System.Drawing.Image)resources.GetObject("Print_B.Image");
			this.Print_B.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Print_B.Name = "Print_B";
			this.Print_B.Size = new System.Drawing.Size(58, 23);
			this.Print_B.Text = "چاپ";
			//
			//DV
			//
			DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			DataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
			DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.DV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1;
			this.DV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			DataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
			DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.DV.DefaultCellStyle = DataGridViewCellStyle2;
			this.DV.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
			this.DV.Location = new System.Drawing.Point(0, 0);
			this.DV.Name = "DV";
			this.DV.Size = new System.Drawing.Size(1150, 480);
			this.DV.TabIndex = 1;
			//
			//Sms_B
			//
			this.Sms_B.Image = (System.Drawing.Image)resources.GetObject("Sms_B.Image");
			this.Sms_B.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Sms_B.Name = "Sms_B";
			this.Sms_B.Size = new System.Drawing.Size(67, 23);
			this.Sms_B.Text = "پیامک";
			//
			//View
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6.0F, 13.0F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1150, 509);
			this.Controls.Add(this.SplitContainer1);
			this.Name = "View";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

//====================================================================================================
//End of the allowed output for the Free Edition of Instant C#.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-instant-csharp.html
//====================================================================================================
