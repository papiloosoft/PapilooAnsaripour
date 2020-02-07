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
	public partial class Accounting_Relation : System.Windows.Forms.Form
	{
		//Form reemplaza a Dispose para limpiar la lista de componentes.
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

		//Requerido por el Diseñador de Windows Forms
		private System.ComponentModel.IContainer components;

		//NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
		//Se puede modificar usando el Diseñador de Windows Forms.  
		//No lo modifique con el editor de código.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accounting_Relation));
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			this.ToolStrip = new System.Windows.Forms.ToolStrip();
			this.New_B = new System.Windows.Forms.ToolStripButton();
			this.Edit_B = new System.Windows.Forms.ToolStripButton();
			this.Delet_B = new System.Windows.Forms.ToolStripButton();
			this.Save_B = new System.Windows.Forms.ToolStripButton();
			this.Abort_B = new System.Windows.Forms.ToolStripButton();
			this.B_Exit = new System.Windows.Forms.ToolStripButton();
			this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
			this.tvData = new System.Windows.Forms.TreeView();
			this.TabControl1 = new System.Windows.Forms.TabControl();
			this.TabPage1 = new System.Windows.Forms.TabPage();
			this.Dv1 = new System.Windows.Forms.DataGridView();
			this.TabPage2 = new System.Windows.Forms.TabPage();
			this.Dv2 = new System.Windows.Forms.DataGridView();
			this.TabPage3 = new System.Windows.Forms.TabPage();
			this.Dv3 = new System.Windows.Forms.DataGridView();
			this.TabPage4 = new System.Windows.Forms.TabPage();
			this.Dv4 = new System.Windows.Forms.DataGridView();
			this.TabPage5 = new System.Windows.Forms.TabPage();
			this.Dv5 = new System.Windows.Forms.DataGridView();
			this.ToolStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.SplitContainer1).BeginInit();
			this.SplitContainer1.Panel1.SuspendLayout();
			this.SplitContainer1.Panel2.SuspendLayout();
			this.SplitContainer1.SuspendLayout();
			this.TabControl1.SuspendLayout();
			this.TabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.Dv1).BeginInit();
			this.TabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.Dv2).BeginInit();
			this.TabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.Dv3).BeginInit();
			this.TabPage4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.Dv4).BeginInit();
			this.TabPage5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.Dv5).BeginInit();
			this.SuspendLayout();
			//
			//ToolStrip
			//
			this.ToolStrip.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
			this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.New_B, this.Edit_B, this.Delet_B, this.Save_B, this.Abort_B, this.B_Exit});
			this.ToolStrip.Location = new System.Drawing.Point(0, 0);
			this.ToolStrip.Name = "ToolStrip";
			this.ToolStrip.Size = new System.Drawing.Size(730, 26);
			this.ToolStrip.TabIndex = 79;
			this.ToolStrip.Text = "ToolStrip1";
			//
			//New_B
			//
			this.New_B.Image = (System.Drawing.Image)resources.GetObject("New_B.Image");
			this.New_B.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.New_B.Name = "New_B";
			this.New_B.Size = new System.Drawing.Size(66, 23);
			this.New_B.Text = "اضافه";
			//
			//Edit_B
			//
			this.Edit_B.Image = (System.Drawing.Image)resources.GetObject("Edit_B.Image");
			this.Edit_B.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Edit_B.Name = "Edit_B";
			this.Edit_B.Size = new System.Drawing.Size(76, 23);
			this.Edit_B.Text = "ویرایش";
			//
			//Delet_B
			//
			this.Delet_B.Image = (System.Drawing.Image)resources.GetObject("Delet_B.Image");
			this.Delet_B.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Delet_B.Name = "Delet_B";
			this.Delet_B.Size = new System.Drawing.Size(63, 23);
			this.Delet_B.Text = "حذف";
			this.Delet_B.ToolTipText = "حذف";
			//
			//Save_B
			//
			this.Save_B.Enabled = false;
			this.Save_B.Image = (System.Drawing.Image)resources.GetObject("Save_B.Image");
			this.Save_B.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Save_B.Name = "Save_B";
			this.Save_B.Size = new System.Drawing.Size(68, 23);
			this.Save_B.Text = "ذخیره";
			//
			//Abort_B
			//
			this.Abort_B.Image = (System.Drawing.Image)resources.GetObject("Abort_B.Image");
			this.Abort_B.ImageTransparentColor = System.Drawing.Color.Magenta;

//====================================================================================================
//End of the allowed output for the Free Edition of Instant C#.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-instant-csharp.html
//====================================================================================================
