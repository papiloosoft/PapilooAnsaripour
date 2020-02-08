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
            this.Abort_B.Name = "Abort_B";
            this.Abort_B.Size = new System.Drawing.Size(74, 23);
            this.Abort_B.Text = "انصراف";
            //
            //B_Exit
            //
            this.B_Exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.B_Exit.Name = "B_Exit";
            this.B_Exit.Size = new System.Drawing.Size(48, 23);
            this.B_Exit.Text = "خروج";
            //
            //SplitContainer1
            //
            this.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer1.Location = new System.Drawing.Point(0, 26);
            this.SplitContainer1.Name = "SplitContainer1";
            //
            //SplitContainer1.Panel1
            //
            this.SplitContainer1.Panel1.Controls.Add(this.tvData);
            this.SplitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            //
            //SplitContainer1.Panel2
            //
            this.SplitContainer1.Panel2.Controls.Add(this.TabControl1);
            this.SplitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SplitContainer1.Size = new System.Drawing.Size(730, 302);
            this.SplitContainer1.SplitterDistance = 288;
            this.SplitContainer1.TabIndex = 80;
            //
            //tvData
            //
            this.tvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvData.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.tvData.Location = new System.Drawing.Point(0, 0);
            this.tvData.Name = "tvData";
            this.tvData.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tvData.RightToLeftLayout = true;
            this.tvData.Size = new System.Drawing.Size(288, 302);
            this.tvData.TabIndex = 1;
            //
            //TabControl1
            //
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Controls.Add(this.TabPage3);
            this.TabControl1.Controls.Add(this.TabPage4);
            this.TabControl1.Controls.Add(this.TabPage5);
            this.TabControl1.Location = new System.Drawing.Point(0, 3);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.RightToLeftLayout = true;
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(436, 296);
            this.TabControl1.TabIndex = 79;
            //
            //TabPage1
            //
            this.TabPage1.Controls.Add(this.Dv1);
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Size = new System.Drawing.Size(428, 270);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "تفصیلی 1";
            this.TabPage1.UseVisualStyleBackColor = true;
            //
            //Dv1
            //
            DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            DataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dv1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1;
            this.Dv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            DataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dv1.DefaultCellStyle = DataGridViewCellStyle2;
            this.Dv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dv1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.Dv1.Location = new System.Drawing.Point(0, 0);
            this.Dv1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dv1.Name = "Dv1";
            this.Dv1.Size = new System.Drawing.Size(428, 270);
            this.Dv1.TabIndex = 75;
            //
            //TabPage2
            //
            this.TabPage2.Controls.Add(this.Dv2);
            this.TabPage2.Location = new System.Drawing.Point(4, 22);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Size = new System.Drawing.Size(428, 270);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "تفصیلی 2";
            this.TabPage2.UseVisualStyleBackColor = true;
            //
            //Dv2
            //
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            DataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dv2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3;
            this.Dv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            DataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dv2.DefaultCellStyle = DataGridViewCellStyle4;
            this.Dv2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dv2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.Dv2.Location = new System.Drawing.Point(0, 0);
            this.Dv2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dv2.Name = "Dv2";
            this.Dv2.Size = new System.Drawing.Size(428, 270);
            this.Dv2.TabIndex = 76;
            //
            //TabPage3
            //
            this.TabPage3.Controls.Add(this.Dv3);
            this.TabPage3.Location = new System.Drawing.Point(4, 22);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Size = new System.Drawing.Size(428, 270);
            this.TabPage3.TabIndex = 2;
            this.TabPage3.Text = "تفصیلی 3";
            this.TabPage3.UseVisualStyleBackColor = true;
            //
            //Dv3
            //
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            DataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dv3.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5;
            this.Dv3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            DataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dv3.DefaultCellStyle = DataGridViewCellStyle6;
            this.Dv3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dv3.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.Dv3.Location = new System.Drawing.Point(0, 0);
            this.Dv3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dv3.Name = "Dv3";
            this.Dv3.Size = new System.Drawing.Size(428, 270);
            this.Dv3.TabIndex = 76;
            //
            //TabPage4
            //
            this.TabPage4.Controls.Add(this.Dv4);
            this.TabPage4.Location = new System.Drawing.Point(4, 22);
            this.TabPage4.Name = "TabPage4";
            this.TabPage4.Size = new System.Drawing.Size(428, 270);
            this.TabPage4.TabIndex = 3;
            this.TabPage4.Text = "تفصیلی 4";
            this.TabPage4.UseVisualStyleBackColor = true;
            //
            //Dv4
            //
            DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            DataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dv4.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7;
            this.Dv4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            DataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dv4.DefaultCellStyle = DataGridViewCellStyle8;
            this.Dv4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dv4.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.Dv4.Location = new System.Drawing.Point(0, 0);
            this.Dv4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dv4.Name = "Dv4";
            this.Dv4.Size = new System.Drawing.Size(428, 270);
            this.Dv4.TabIndex = 76;
            //
            //TabPage5
            //
            this.TabPage5.Controls.Add(this.Dv5);
            this.TabPage5.Location = new System.Drawing.Point(4, 22);
            this.TabPage5.Name = "TabPage5";
            this.TabPage5.Size = new System.Drawing.Size(428, 270);
            this.TabPage5.TabIndex = 4;
            this.TabPage5.Text = "تفصیلی 5";
            this.TabPage5.UseVisualStyleBackColor = true;
            //
            //Dv5
            //
            DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            DataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dv5.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9;
            this.Dv5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            DataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dv5.DefaultCellStyle = DataGridViewCellStyle10;
            this.Dv5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dv5.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.Dv5.Location = new System.Drawing.Point(0, 0);
            this.Dv5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dv5.Name = "Dv5";
            this.Dv5.Size = new System.Drawing.Size(428, 270);
            this.Dv5.TabIndex = 76;
            //
            //Relation_Serch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6.0F, 13.0F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(730, 328);
            this.ControlBox = false;
            this.Controls.Add(this.SplitContainer1);
            this.Controls.Add(this.ToolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Relation_Serch";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMessage";
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.SplitContainer1.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.SplitContainer1).EndInit();
            this.SplitContainer1.ResumeLayout(false);
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.Dv1).EndInit();
            this.TabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.Dv2).EndInit();
            this.TabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.Dv3).EndInit();
            this.TabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.Dv4).EndInit();
            this.TabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.Dv5).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal System.Windows.Forms.ToolStrip ToolStrip;
        internal System.Windows.Forms.ToolStripButton New_B;
        internal System.Windows.Forms.ToolStripButton Edit_B;
        internal System.Windows.Forms.ToolStripButton Delet_B;
        internal System.Windows.Forms.ToolStripButton Save_B;
        internal System.Windows.Forms.ToolStripButton Abort_B;
        internal System.Windows.Forms.ToolStripButton B_Exit;
        internal System.Windows.Forms.SplitContainer SplitContainer1;
        internal System.Windows.Forms.TabControl TabControl1;
        internal System.Windows.Forms.TabPage TabPage1;
        internal System.Windows.Forms.DataGridView Dv1;
        internal System.Windows.Forms.TabPage TabPage2;
        internal System.Windows.Forms.TabPage TabPage3;
        internal System.Windows.Forms.TabPage TabPage4;
        internal System.Windows.Forms.TabPage TabPage5;
        internal System.Windows.Forms.TreeView tvData;
        internal System.Windows.Forms.DataGridView Dv2;
        internal System.Windows.Forms.DataGridView Dv3;
        internal System.Windows.Forms.DataGridView Dv4;
        internal System.Windows.Forms.DataGridView Dv5;
    }
