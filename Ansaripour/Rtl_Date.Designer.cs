//INSTANT C# NOTE: Formerly VB project-level imports:
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;

using System;
using System.Globalization;

namespace Ansaripour
{
	public partial class Rtl_Date : System.Windows.Forms.UserControl
	{
		//UserControl overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]
		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;

		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.  
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rtl_Date));
			this.T_Date = new System.Windows.Forms.Button();
			this.S_Date = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			//
			//T_Date
			//
			this.T_Date.Cursor = System.Windows.Forms.Cursors.Default;
			this.T_Date.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
			this.T_Date.Image = (System.Drawing.Image)resources.GetObject("T_Date.Image");
			this.T_Date.Location = new System.Drawing.Point(86, 4);
			this.T_Date.Name = "T_Date";
			this.T_Date.Size = new System.Drawing.Size(19, 20);
			this.T_Date.TabIndex = 303;
			this.T_Date.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.T_Date.UseVisualStyleBackColor = true;
			//
			//S_Date
			//
			this.S_Date.BackColor = System.Drawing.Color.White;
			this.S_Date.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
			this.S_Date.Location = new System.Drawing.Point(1, 2);
			this.S_Date.Name = "S_Date";
			this.S_Date.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.S_Date.Size = new System.Drawing.Size(85, 23);
			this.S_Date.TabIndex = 310;
			this.S_Date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			//
			//Rtl_Date
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6.0F, 13.0F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.Controls.Add(this.S_Date);
			this.Controls.Add(this.T_Date);
			this.Name = "Rtl_Date";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Size = new System.Drawing.Size(108, 28);
			this.ResumeLayout(false);
			this.PerformLayout();

//INSTANT C# NOTE: Converted design-time event handler wireups:
			T_Date.Click += new System.EventHandler(T_Date_Click);
			S_Date.TextChanged += new System.EventHandler(S_Date_TextChanged);
		}




		internal System.Windows.Forms.Button T_Date;
		internal System.Windows.Forms.TextBox S_Date;

	}

}