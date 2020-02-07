using System.IO;
using System.Text;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;

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
	public partial class Pictures : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pictures));
			this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
			this.New_B = new System.Windows.Forms.ToolStripButton();
			this.Edit_B = new System.Windows.Forms.ToolStripButton();
			this.Delet_B = new System.Windows.Forms.ToolStripButton();
			this.Save_B = new System.Windows.Forms.ToolStripButton();
			this.Product_B = new System.Windows.Forms.ToolStripDropDownButton();
			this.B_Save_File = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.Add_Size = new System.Windows.Forms.ToolStripButton();
			this.CurrentSize = new System.Windows.Forms.ToolStripTextBox();
			this.Reduce_Size = new System.Windows.Forms.ToolStripButton();
			this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.B_First = new System.Windows.Forms.ToolStripButton();
			this.B_Perview = new System.Windows.Forms.ToolStripButton();
			this.Number_Text = new System.Windows.Forms.ToolStripTextBox();
			this.B_Next = new System.Windows.Forms.ToolStripButton();
			this.B_Last = new System.Windows.Forms.ToolStripButton();
			this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.B_Rotate = new System.Windows.Forms.ToolStripButton();
			this.PrintPage = new System.Windows.Forms.ToolStripButton();
			this.Abort_B = new System.Windows.Forms.ToolStripButton();
			this.P_Pic = new System.Windows.Forms.PictureBox();
			this.PrintGraphicControl = new System.Drawing.Printing.PrintDocument();
			this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
			this.lblCurrentSize = new System.Windows.Forms.ToolStripStatusLabel();
			this.ToolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.P_Pic).BeginInit();
			this.StatusStrip1.SuspendLayout();
			this.SuspendLayout();
			//
			//ToolStrip1
			//
			this.ToolStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.New_B, this.Edit_B, this.Save_B, this.Delet_B, this.Product_B, this.ToolStripSeparator1, this.Add_Size, this.CurrentSize, this.Reduce_Size, this.ToolStripSeparator2, this.B_First, this.B_Perview, this.Number_Text, this.B_Next, this.B_Last, this.ToolStripSeparator3, this.B_Rotate, this.PrintPage, this.Abort_B});
			this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
			this.ToolStrip1.Name = "ToolStrip1";
			this.ToolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.ToolStrip1.Size = new System.Drawing.Size(752, 27);
			this.ToolStrip1.TabIndex = 177;
			this.ToolStrip1.Text = "ToolStrip1";
			//
			//New_B
			//
			this.New_B.Image = (System.Drawing.Image)resources.GetObject("New_B.Image");
			this.New_B.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.New_B.Name = "New_B";
			this.New_B.Size = new System.Drawing.Size(59, 24);
			this.New_B.Text = "جدید";
			//
			//Edit_B
			//
			this.Edit_B.Image = (System.Drawing.Image)resources.GetObject("Edit_B.Image");
			this.Edit_B.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Edit_B.Name = "Edit_B";
			this.Edit_B.Size = new System.Drawing.Size(75, 24);
			this.Edit_B.Text = "ویرایش";
			//
			//Delet_B
			//
			this.Delet_B.Image = (System.Drawing.Image)resources.GetObject("Delet_B.Image");
			this.Delet_B.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Delet_B.Name = "Delet_B";
			this.Delet_B.Size = new System.Drawing.Size(61, 24);
			this.Delet_B.Text = "حذف";
			this.Delet_B.ToolTipText = "حذف";
			//
			//Save_B
			//
			this.Save_B.Enabled = false;
			this.Save_B.Image = (System.Drawing.Image)resources.GetObject("Save_B.Image");
			this.Save_B.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Save_B.Name = "Save_B";
			this.Save_B.Size = new System.Drawing.Size(64, 24);
			this.Save_B.Text = "ذخیره";
			//
			//Product_B
			//
			this.Product_B.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.B_Save_File});
			this.Product_B.Image = (System.Drawing.Image)resources.GetObject("Product_B.Image");
			this.Product_B.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Product_B.Name = "Product_B";
			this.Product_B.Size = new System.Drawing.Size(84, 24);
			this.Product_B.Text = "عملیات";
			//
			//B_Save_File
			//
			this.B_Save_File.Image = (System.Drawing.Image)resources.GetObject("B_Save_File.Image");
			this.B_Save_File.Name = "B_Save_File";
			this.B_Save_File.Size = new System.Drawing.Size(234, 24);
			this.B_Save_File.Text = "ذخیره عکس بصورت فایل";
			//
			//ToolStripSeparator1
			//
			this.ToolStripSeparator1.Name = "ToolStripSeparator1";
			this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 27);
			//
			//Add_Size
			//
			this.Add_Size.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.Add_Size.Image = (System.Drawing.Image)resources.GetObject("Add_Size.Image");
			this.Add_Size.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Add_Size.Name = "Add_Size";
			this.Add_Size.Size = new System.Drawing.Size(23, 24);
			this.Add_Size.Text = "افزایش سایز عکس";
			//
			//CurrentSize
			//
			this.CurrentSize.Enabled = false;

//====================================================================================================
//End of the allowed output for the Free Edition of Instant C#.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-instant-csharp.html
//====================================================================================================
