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
	public partial class Rtl_Time : System.Windows.Forms.UserControl
	{
		//UserControl overrides dispose to clean up the component list.
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
			this.S_Time = new System.Windows.Forms.MaskedTextBox();
			this.SuspendLayout();
			//
			//S_Time
			//
			this.S_Time.Font = new System.Drawing.Font("B Traffic", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
			this.S_Time.Location = new System.Drawing.Point(2, 1);
			this.S_Time.Mask = "##:##";
			this.S_Time.Name = "S_Time";
			this.S_Time.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.S_Time.Size = new System.Drawing.Size(48, 34);
			this.S_Time.TabIndex = 300;
			//
			//Rtl_Time
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6.0F, 13.0F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.S_Time);
			this.Name = "Rtl_Time";
			this.Size = new System.Drawing.Size(50, 36);
			this.ResumeLayout(false);
			this.PerformLayout();

//INSTANT C# NOTE: Converted design-time event handler wireups:
			S_Time.Leave += new System.EventHandler(S_Time_Leave);
			S_Time.TextChanged += new System.EventHandler(S_Time_TextChanged);
		}
		private System.Windows.Forms.MaskedTextBox S_Time;

	}

}