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
	public partial class Base_Information : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Base_Information));
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
			this.New_B = new System.Windows.Forms.ToolStripButton();
			this.Edit_B = new System.Windows.Forms.ToolStripButton();
			this.Delet_B = new System.Windows.Forms.ToolStripButton();
			this.Save_B = new System.Windows.Forms.ToolStripButton();
			this.Search_B = new System.Windows.Forms.ToolStripButton();
			this.B_Excel = new System.Windows.Forms.ToolStripButton();
			this.ToolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.Abort_B = new System.Windows.Forms.ToolStripButton();
			this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
			this.Base_Information_Name = new System.Windows.Forms.TextBox();
			this.Base_Information_Code = new System.Windows.Forms.TextBox();
			this.DV = new System.Windows.Forms.DataGridView();
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
			this.Label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.Label1.Location = new System.Drawing.Point(905, 39);
			this.Label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
			this.Label1.Name = "Label1";
			this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Label1.Size = new System.Drawing.Size(57, 23);
			this.Label1.TabIndex = 56;
			this.Label1.Text = "کـــد :";
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.Label3.Location = new System.Drawing.Point(701, 38);
			this.Label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
			this.Label3.Name = "Label3";
			this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Label3.Size = new System.Drawing.Size(87, 23);
			this.Label3.TabIndex = 66;
			this.Label3.Text = "شرح کد :";
			//
			//ToolStrip1
			//
			this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.New_B, this.Edit_B, this.Delet_B, this.Save_B, this.Search_B, this.B_Excel, this.ToolStripButton1, this.Abort_B});
			this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
			this.ToolStrip1.Name = "ToolStrip1";
			this.ToolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.ToolStrip1.Size = new System.Drawing.Size(968, 25);
			this.ToolStrip1.TabIndex = 2;
			this.ToolStrip1.Text = "ToolStrip1";
			//
			//New_B
			//
			this.New_B.Image = (System.Drawing.Image)resources.GetObject("New_B.Image");
			this.New_B.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.New_B.Name = "New_B";
			this.New_B.Size = new System.Drawing.Size(50, 22);
			this.New_B.Text = "جدید";
			//
			//Edit_B
			//
			this.Edit_B.Image = (System.Drawing.Image)resources.GetObject("Edit_B.Image");
			this.Edit_B.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Edit_B.Name = "Edit_B";
			this.Edit_B.Size = new System.Drawing.Size(63, 22);
			this.Edit_B.Text = "ویرایش";
			//
			//Delet_B
			//
			this.Delet_B.Image = (System.Drawing.Image)resources.GetObject("Delet_B.Image");
			this.Delet_B.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Delet_B.Name = "Delet_B";
			this.Delet_B.Size = new System.Drawing.Size(52, 22);
			this.Delet_B.Text = "حذف";
			this.Delet_B.ToolTipText = "حذف";
			//
			//Save_B
			//
			this.Save_B.Enabled = false;
			this.Save_B.Image = (System.Drawing.Image)resources.GetObject("Save_B.Image");
			this.Save_B.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Save_B.Name = "Save_B";
			this.Save_B.Size = new System.Drawing.Size(54, 22);
			this.Save_B.Text = "ذخیره";
			//
			//Search_B
			//
			this.Search_B.Image = (System.Drawing.Image)resources.GetObject("Search_B.Image");
			this.Search_B.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Search_B.Name = "Search_B";
			this.Search_B.Size = new System.Drawing.Size(61, 22);
			this.Search_B.Text = "جستجو";
			//
			//B_Excel
			//
			this.B_Excel.Image = (System.Drawing.Image)resources.GetObject("B_Excel.Image");
			this.B_Excel.ImageTransparentColor = System.Drawing.Color.Magenta;

//====================================================================================================
//End of the allowed output for the Free Edition of Instant C#.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-instant-csharp.html
//====================================================================================================
