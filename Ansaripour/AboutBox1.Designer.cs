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
	public partial class AboutBox1 : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBox1));
			this.PictureBox1 = new System.Windows.Forms.PictureBox();
			this.TextBox1 = new System.Windows.Forms.TextBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.Button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
			this.SuspendLayout();
			//
			//PictureBox1
			//
			this.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PictureBox1.Image = (System.Drawing.Image)resources.GetObject("PictureBox1.Image");
			this.PictureBox1.Location = new System.Drawing.Point(9, 9);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new System.Drawing.Size(414, 321);
			this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PictureBox1.TabIndex = 0;
			this.PictureBox1.TabStop = false;
			//
			//TextBox1
			//
			this.TextBox1.Location = new System.Drawing.Point(22, 287);
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.Size = new System.Drawing.Size(297, 20);
			this.TextBox1.TabIndex = 1;
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.BackColor = System.Drawing.Color.Transparent;
			this.Label2.ForeColor = System.Drawing.Color.Red;
			this.Label2.Location = new System.Drawing.Point(19, 311);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(131, 13);
			this.Label2.TabIndex = 3;
			this.Label2.Text = "کلید فعال سازی نرم افزار :";
			//
			//Button1
			//
			this.Button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Button1.Font = new System.Drawing.Font("B Yekan", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
			this.Button1.ForeColor = System.Drawing.Color.Red;
			this.Button1.Location = new System.Drawing.Point(321, 287);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(39, 21);
			this.Button1.TabIndex = 4;
			this.Button1.Text = "تایید";
			this.Button1.UseVisualStyleBackColor = true;
			//
			//AboutBox1
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6.0F, 13.0F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(432, 339);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.TextBox1);
			this.Controls.Add(this.PictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AboutBox1";
			this.Padding = new System.Windows.Forms.Padding(9);
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.RightToLeftLayout = true;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = " فرم فعال سازی  برنامه مکانیزه";
			((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

//INSTANT C# NOTE: Converted design-time event handler wireups:
			this.Load += new System.EventHandler(AboutBox1_Load);
			Button1.Click += new System.EventHandler(Button1_Click);
		}
		internal System.Windows.Forms.PictureBox PictureBox1;
		internal System.Windows.Forms.TextBox TextBox1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Button Button1;

	}

}