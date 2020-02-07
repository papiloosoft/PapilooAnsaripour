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
	public partial class Rtl_Search : System.Windows.Forms.UserControl
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rtl_Search));
			this.S_Date = new System.Windows.Forms.TextBox();
			this.T_Date = new System.Windows.Forms.Button();
			this.SuspendLayout();
			//
			//S_Date
			//
			this.S_Date.BackColor = System.Drawing.Color.White;
			this.S_Date.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
			this.S_Date.Location = new System.Drawing.Point(24, 1);
			this.S_Date.Name = "S_Date";
			this.S_Date.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.S_Date.Size = new System.Drawing.Size(274, 27);
			this.S_Date.TabIndex = 312;
			this.S_Date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			//
			//T_Date
			//
			this.T_Date.BackgroundImage = (System.Drawing.Image)resources.GetObject("T_Date.BackgroundImage");
			this.T_Date.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.T_Date.Cursor = System.Windows.Forms.Cursors.Default;
			this.T_Date.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
			this.T_Date.Location = new System.Drawing.Point(-1, 0);
			this.T_Date.Name = "T_Date";
			this.T_Date.Size = new System.Drawing.Size(26, 28);
			this.T_Date.TabIndex = 311;
			this.T_Date.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.T_Date.UseVisualStyleBackColor = true;
			//
			//Rtl_Search
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6.0F, 13.0F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.Controls.Add(this.S_Date);
			this.Controls.Add(this.T_Date);
			this.Name = "Rtl_Search";
			this.Size = new System.Drawing.Size(314, 32);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		internal System.Windows.Forms.TextBox S_Date;
		internal System.Windows.Forms.Button T_Date;

	}

}