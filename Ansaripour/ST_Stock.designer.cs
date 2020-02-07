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
	public partial class ST_Stock : System.Windows.Forms.Form
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ST_Stock));
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
			this.ToolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.Abort_B = new System.Windows.Forms.ToolStripButton();
			this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
			this.Label8 = new System.Windows.Forms.Label();
			this.C_Receipt = new System.Windows.Forms.CheckBox();
			this.C_Direct = new System.Windows.Forms.CheckBox();
			this.Label7 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.C_Request = new System.Windows.Forms.CheckBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.C_Negative = new System.Windows.Forms.CheckBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.M_Stock = new System.Windows.Forms.ComboBox();
			this.DV = new System.Windows.Forms.DataGridView();
			this.C_Hesab = new System.Windows.Forms.TextBox();
			this.C_name = new System.Windows.Forms.TextBox();
			this.C_Address = new System.Windows.Forms.TextBox();
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
			this.Label1.Location = new System.Drawing.Point(869, 35);
			this.Label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
			this.Label1.Name = "Label1";
			this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Label1.Size = new System.Drawing.Size(93, 23);
			this.Label1.TabIndex = 56;
			this.Label1.Text = "کـــد انبار :";
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.Label3.Location = new System.Drawing.Point(574, 36);
			this.Label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
			this.Label3.Name = "Label3";
			this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Label3.Size = new System.Drawing.Size(81, 23);
			this.Label3.TabIndex = 66;
			this.Label3.Text = "نام انبار :";
			//
			//ToolStrip1
			//
			this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.New_B, this.Edit_B, this.Delet_B, this.Save_B, this.Search_B, this.ToolStripButton1, this.Abort_B});
			this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
			this.ToolStrip1.Name = "ToolStrip1";
			this.ToolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.ToolStrip1.Size = new System.Drawing.Size(968, 25);
			this.ToolStrip1.TabIndex = 8;
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

//====================================================================================================
//End of the allowed output for the Free Edition of Instant C#.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-instant-csharp.html
//====================================================================================================
