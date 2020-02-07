
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
	public partial class LoginForm : System.Windows.Forms.Form
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
		internal System.Windows.Forms.TextBox UsernameTextBox;
		internal System.Windows.Forms.TextBox PasswordTextBox;
		internal System.Windows.Forms.Button OK;
		internal System.Windows.Forms.Button Cancel;

		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;

		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.  
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
			this.UsernameTextBox = new System.Windows.Forms.TextBox();
			this.PasswordTextBox = new System.Windows.Forms.TextBox();
			this.OK = new System.Windows.Forms.Button();
			this.Cancel = new System.Windows.Forms.Button();
			this.Check_Pass = new System.Windows.Forms.CheckBox();
			this.P_Pic = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)this.P_Pic).BeginInit();
			this.SuspendLayout();
			//
			//UsernameTextBox
			//
			this.UsernameTextBox.Location = new System.Drawing.Point(43, 143);
			this.UsernameTextBox.Name = "UsernameTextBox";
			this.UsernameTextBox.Size = new System.Drawing.Size(146, 20);
			this.UsernameTextBox.TabIndex = 1;
			//
			//PasswordTextBox
			//
			this.PasswordTextBox.Location = new System.Drawing.Point(43, 181);
			this.PasswordTextBox.Name = "PasswordTextBox";
			this.PasswordTextBox.PasswordChar = (char)42;
			this.PasswordTextBox.Size = new System.Drawing.Size(146, 20);
			this.PasswordTextBox.TabIndex = 3;
			//
			//OK
			//
			this.OK.Location = new System.Drawing.Point(131, 256);
			this.OK.Name = "OK";
			this.OK.Size = new System.Drawing.Size(76, 23);
			this.OK.TabIndex = 4;
			this.OK.Text = "تائید";
			//
			//Cancel
			//
			this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Cancel.Location = new System.Drawing.Point(59, 256);
			this.Cancel.Name = "Cancel";
			this.Cancel.Size = new System.Drawing.Size(73, 23);
			this.Cancel.TabIndex = 5;
			this.Cancel.Text = "انصراف";
			//
			//Check_Pass
			//
			this.Check_Pass.AutoSize = true;
			this.Check_Pass.BackColor = System.Drawing.SystemColors.ControlLight;
			this.Check_Pass.Location = new System.Drawing.Point(71, 223);
			this.Check_Pass.Name = "Check_Pass";
			this.Check_Pass.Size = new System.Drawing.Size(15, 14);
			this.Check_Pass.TabIndex = 6;
			this.Check_Pass.UseVisualStyleBackColor = false;
			//
			//P_Pic
			//
			this.P_Pic.BackColor = System.Drawing.SystemColors.ControlDark;
			this.P_Pic.Location = new System.Drawing.Point(73, 30);
			this.P_Pic.Name = "P_Pic";
			this.P_Pic.Size = new System.Drawing.Size(110, 83);
			this.P_Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.P_Pic.TabIndex = 232;
			this.P_Pic.TabStop = false;
			//
			//LoginForm
			//
			this.AcceptButton = this.OK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6.0F, 13.0F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.CancelButton = this.Cancel;
			this.ClientSize = new System.Drawing.Size(472, 292);
			this.Controls.Add(this.P_Pic);
			this.Controls.Add(this.Check_Pass);
			this.Controls.Add(this.Cancel);
			this.Controls.Add(this.OK);
			this.Controls.Add(this.PasswordTextBox);
			this.Controls.Add(this.UsernameTextBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "LoginForm";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LoginForm";
			this.TransparencyKey = System.Drawing.Color.Navy;
			((System.ComponentModel.ISupportInitialize)this.P_Pic).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

//INSTANT C# NOTE: Converted design-time event handler wireups:
			Cancel.Click += new System.EventHandler(Cancel_Click);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(LoginForm1_KeyDown);
			base.Load += new System.EventHandler(LoginForm1_Load);
			OK.Click += new System.EventHandler(OK_Click);
		}
		internal System.Windows.Forms.CheckBox Check_Pass;
		internal System.Windows.Forms.PictureBox P_Pic;

	}

}