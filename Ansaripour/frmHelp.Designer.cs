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
	public partial class frmHelp : System.Windows.Forms.Form
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
			System.Windows.Forms.TreeNode TreeNode1 = new System.Windows.Forms.TreeNode("تست");
			System.Windows.Forms.TreeNode TreeNode2 = new System.Windows.Forms.TreeNode("حسابداری", new System.Windows.Forms.TreeNode[] {TreeNode1});
			System.Windows.Forms.TreeNode TreeNode3 = new System.Windows.Forms.TreeNode("تعمیر و نگهداری");
			System.Windows.Forms.TreeNode TreeNode4 = new System.Windows.Forms.TreeNode("حقوق و دستمزد");
			System.Windows.Forms.TreeNode TreeNode5 = new System.Windows.Forms.TreeNode("انبار");
			System.Windows.Forms.TreeNode TreeNode6 = new System.Windows.Forms.TreeNode("ثبت اموال جدید");
			System.Windows.Forms.TreeNode TreeNode7 = new System.Windows.Forms.TreeNode("اموال", new System.Windows.Forms.TreeNode[] {TreeNode6});
			System.Windows.Forms.TreeNode TreeNode8 = new System.Windows.Forms.TreeNode("چک بانک");
			System.Windows.Forms.TreeNode TreeNode9 = new System.Windows.Forms.TreeNode("اسناد وصولی");
			System.Windows.Forms.TreeNode TreeNode10 = new System.Windows.Forms.TreeNode("اسناد انتظامی");
			System.Windows.Forms.TreeNode TreeNode11 = new System.Windows.Forms.TreeNode("اسناد مناقصه");
			System.Windows.Forms.TreeNode TreeNode12 = new System.Windows.Forms.TreeNode("اطلاعات پایه");
			this.RichTextBox1 = new System.Windows.Forms.RichTextBox();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.TreeView1 = new System.Windows.Forms.TreeView();
			this.GroupBox1.SuspendLayout();
			this.SuspendLayout();
			//
			//RichTextBox1
			//
			this.RichTextBox1.BackColor = System.Drawing.SystemColors.Info;
			this.RichTextBox1.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
			this.RichTextBox1.Location = new System.Drawing.Point(169, 5);
			this.RichTextBox1.Name = "RichTextBox1";
			this.RichTextBox1.Size = new System.Drawing.Size(340, 388);
			this.RichTextBox1.TabIndex = 1;
			this.RichTextBox1.Text = "";
			//
			//GroupBox1
			//
			this.GroupBox1.BackColor = System.Drawing.Color.White;
			this.GroupBox1.Controls.Add(this.TreeView1);
			this.GroupBox1.Location = new System.Drawing.Point(2, -1);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(164, 394);
			this.GroupBox1.TabIndex = 2;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "راهنما :";
			//
			//TreeView1
			//
			this.TreeView1.BackColor = System.Drawing.SystemColors.Info;
			this.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TreeView1.Font = new System.Drawing.Font("B Nazanin", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
			this.TreeView1.Location = new System.Drawing.Point(3, 16);
			this.TreeView1.Name = "TreeView1";
			TreeNode1.Name = "Node01";
			TreeNode1.Text = "تست";
			TreeNode2.Name = "Node0";
			TreeNode2.Text = "حسابداری";
			TreeNode3.Name = "Node1";
			TreeNode3.Text = "تعمیر و نگهداری";
			TreeNode4.Name = "Node2";
			TreeNode4.Text = "حقوق و دستمزد";
			TreeNode5.Name = "Node3";
			TreeNode5.Text = "انبار";
			TreeNode6.Name = "Node0";
			TreeNode6.Text = "ثبت اموال جدید";
			TreeNode7.Name = "Node4";
			TreeNode7.Text = "اموال";
			TreeNode8.Name = "Node5";
			TreeNode8.Text = "چک بانک";
			TreeNode9.Name = "Node6";
			TreeNode9.Text = "اسناد وصولی";
			TreeNode10.Name = "Node7";
			TreeNode10.Text = "اسناد انتظامی";
			TreeNode11.Name = "Node8";
			TreeNode11.Text = "اسناد مناقصه";
			TreeNode12.Name = "Node9";
			TreeNode12.Text = "اطلاعات پایه";
			this.TreeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {TreeNode2, TreeNode3, TreeNode4, TreeNode5, TreeNode7, TreeNode8, TreeNode9, TreeNode10, TreeNode11, TreeNode12});
			this.TreeView1.RightToLeftLayout = true;
			this.TreeView1.Size = new System.Drawing.Size(158, 375);
			this.TreeView1.TabIndex = 1;
			//
			//frmHelp
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6.0F, 13.0F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(516, 403);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.RichTextBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmHelp";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.RightToLeftLayout = true;
			this.Text = " ";
			this.GroupBox1.ResumeLayout(false);

//====================================================================================================
//End of the allowed output for the Free Edition of Instant C#.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-instant-csharp.html
//====================================================================================================
