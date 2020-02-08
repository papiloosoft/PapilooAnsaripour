using System.IO.Directory;
using Microsoft.Office.Interop;

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
	public partial class Collection_Document : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Collection_Document));
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
			this.B_Recovery_Documents_Collecting_Bank = new System.Windows.Forms.Button();
			this.Recovery_Documents_Collecting_Bank = new System.Windows.Forms.TextBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label12 = new System.Windows.Forms.Label();
			this.Recovery_Documents_Assignment_Date = new Ansaripour.Rtl_Date();
			this.Label15 = new System.Windows.Forms.Label();
			this.Label13 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.Az_Ta = new System.Windows.Forms.Label();
			this.Label19 = new System.Windows.Forms.Label();
			this.Recovery_Documents_From_Date = new Ansaripour.Rtl_Date();
			this.Recovery_Documents_Until_Date = new Ansaripour.Rtl_Date();
			this.Label14 = new System.Windows.Forms.Label();
			this.B_Recovery_Documents_Subscription = new System.Windows.Forms.Button();
			this.Recovery_Documents_Operation = new System.Windows.Forms.ComboBox();
			this.Recovery_Documents_Refund_Date = new Ansaripour.Rtl_Date();
			this.Recovery_Documents_Returned_Date = new Ansaripour.Rtl_Date();
			this.Recovery_Documents_Pass_Date = new Ansaripour.Rtl_Date();
			this.L_Mab = new System.Windows.Forms.TextBox();
			this.Recovery_Documents_Description = new System.Windows.Forms.TextBox();
			this.Recovery_Documents_Due_Date = new Ansaripour.Rtl_Date();
			this.Recovery_Documents_Date_Received = new Ansaripour.Rtl_Date();
			this.Label10 = new System.Windows.Forms.Label();
			this.Recovery_Documents_Bank = new System.Windows.Forms.TextBox();
			this.Label11 = new System.Windows.Forms.Label();
			this.Label9 = new System.Windows.Forms.Label();
			this.Recovery_Documents_Amount = new System.Windows.Forms.TextBox();
			this.Recovery_Documents_Case = new System.Windows.Forms.ComboBox();
			this.Label8 = new System.Windows.Forms.Label();
			this.Label7 = new System.Windows.Forms.Label();
			this.Recovery_Documents_Account_Number = new System.Windows.Forms.TextBox();
			this.Label6 = new System.Windows.Forms.Label();
			this.Recovery_Documents_No_Check = new System.Windows.Forms.TextBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.Recovery_Documents_Branch = new System.Windows.Forms.TextBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.Recovery_Documents_Subscription = new System.Windows.Forms.TextBox();
			this.ToolStrip = new System.Windows.Forms.ToolStrip();
			this.B_Product = new System.Windows.Forms.ToolStripDropDownButton();
			this.B_New = new System.Windows.Forms.ToolStripMenuItem();
			this.B_Old = new System.Windows.Forms.ToolStripMenuItem();
			this.B_Assignment = new System.Windows.Forms.ToolStripMenuItem();
			this.B_Assignment_All = new System.Windows.Forms.ToolStripMenuItem();
			this.B_Collecting = new System.Windows.Forms.ToolStripMenuItem();
			this.B_Returned = new System.Windows.Forms.ToolStripMenuItem();
			this.B_Refund = new System.Windows.Forms.ToolStripMenuItem();
			this.Edit_B = new System.Windows.Forms.ToolStripButton();
			this.Delet_B = new System.Windows.Forms.ToolStripButton();
			this.Search_B = new System.Windows.Forms.ToolStripButton();
			this.Save_B = new System.Windows.Forms.ToolStripButton();
			this.B_Excel = new System.Windows.Forms.ToolStripButton();
			this.Chap = new System.Windows.Forms.ToolStripButton();
			this.Log_File = new System.Windows.Forms.ToolStripButton();
			this.B_Picture = new System.Windows.Forms.ToolStripButton();
			this.Abort_B = new System.Windows.Forms.ToolStripButton();
			this.Label17 = new System.Windows.Forms.Label();
			this.Label16 = new System.Windows.Forms.Label();
			this.DV = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)this.SplitContainer1).BeginInit();
			this.SplitContainer1.Panel1.SuspendLayout();
			this.SplitContainer1.Panel2.SuspendLayout();
			this.SplitContainer1.SuspendLayout();
			this.GroupBox1.SuspendLayout();
			this.ToolStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.DV).BeginInit();
			this.SuspendLayout();
			//
			//SplitContainer1
			//
			this.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SplitContainer1.Location = new System.Drawing.Point(0, 0);
			this.SplitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.SplitContainer1.Name = "SplitContainer1";
			this.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            //
            //SplitContainer1.Panel1
            //
            this.SplitContainer1.Panel1.Controls.Add(this.B_Recovery_Documents_Collecting_Bank);
            this.SplitContainer1.Panel1.Controls.Add(this.Recovery_Documents_Collecting_Bank);
            this.SplitContainer1.Panel1.Controls.Add(this.Label2);
            this.SplitContainer1.Panel1.Controls.Add(this.Label12);
            this.SplitContainer1.Panel1.Controls.Add(this.Recovery_Documents_Assignment_Date);
            this.SplitContainer1.Panel1.Controls.Add(this.Label15);
            this.SplitContainer1.Panel1.Controls.Add(this.Label13);
            this.SplitContainer1.Panel1.Controls.Add(this.Label3);
            this.SplitContainer1.Panel1.Controls.Add(this.GroupBox1);
            this.SplitContainer1.Panel1.Controls.Add(this.Label14);
            this.SplitContainer1.Panel1.Controls.Add(this.B_Recovery_Documents_Subscription);
            this.SplitContainer1.Panel1.Controls.Add(this.Recovery_Documents_Operation);
            this.SplitContainer1.Panel1.Controls.Add(this.Recovery_Documents_Refund_Date);
            this.SplitContainer1.Panel1.Controls.Add(this.Recovery_Documents_Returned_Date);
            this.SplitContainer1.Panel1.Controls.Add(this.Recovery_Documents_Pass_Date);
            this.SplitContainer1.Panel1.Controls.Add(this.L_Mab);
            this.SplitContainer1.Panel1.Controls.Add(this.Recovery_Documents_Description);
            this.SplitContainer1.Panel1.Controls.Add(this.Recovery_Documents_Due_Date);
            this.SplitContainer1.Panel1.Controls.Add(this.Recovery_Documents_Date_Received);
            this.SplitContainer1.Panel1.Controls.Add(this.Label10);
            this.SplitContainer1.Panel1.Controls.Add(this.Recovery_Documents_Bank);
            this.SplitContainer1.Panel1.Controls.Add(this.Label11);
            this.SplitContainer1.Panel1.Controls.Add(this.Label9);
            this.SplitContainer1.Panel1.Controls.Add(this.Recovery_Documents_Amount);
            this.SplitContainer1.Panel1.Controls.Add(this.Recovery_Documents_Case);
            this.SplitContainer1.Panel1.Controls.Add(this.Label8);
            this.SplitContainer1.Panel1.Controls.Add(this.Label7);
            this.SplitContainer1.Panel1.Controls.Add(this.Recovery_Documents_Account_Number);
            this.SplitContainer1.Panel1.Controls.Add(this.Label6);
            this.SplitContainer1.Panel1.Controls.Add(this.Recovery_Documents_No_Check);
            this.SplitContainer1.Panel1.Controls.Add(this.Label5);
            this.SplitContainer1.Panel1.Controls.Add(this.Recovery_Documents_Branch);
            this.SplitContainer1.Panel1.Controls.Add(this.Label4);
            this.SplitContainer1.Panel1.Controls.Add(this.Label1);
            this.SplitContainer1.Panel1.Controls.Add(this.Recovery_Documents_Subscription);
            this.SplitContainer1.Panel1.Controls.Add(this.ToolStrip);
            this.SplitContainer1.Panel1.Controls.Add(this.Label17);
            this.SplitContainer1.Panel1.Controls.Add(this.Label16);
            this.SplitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            //
            //SplitContainer1.Panel2
            //
            this.SplitContainer1.Panel2.Controls.Add(this.DV);
            this.SplitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SplitContainer1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SplitContainer1.Size = new System.Drawing.Size(1237, 534);
            this.SplitContainer1.SplitterDistance = 254;
            this.SplitContainer1.SplitterWidth = 5;
            this.SplitContainer1.TabIndex = 0;
            //
            //B_Recovery_Documents_Collecting_Bank
            //
            this.B_Recovery_Documents_Collecting_Bank.Image = (System.Drawing.Image)resources.GetObject("B_Recovery_Documents_Collecting_Bank.Image");
            this.B_Recovery_Documents_Collecting_Bank.Location = new System.Drawing.Point(15, 108);
            this.B_Recovery_Documents_Collecting_Bank.Name = "B_Recovery_Documents_Collecting_Bank";
            this.B_Recovery_Documents_Collecting_Bank.Size = new System.Drawing.Size(29, 27);
            this.B_Recovery_Documents_Collecting_Bank.TabIndex = 254;
            this.B_Recovery_Documents_Collecting_Bank.UseVisualStyleBackColor = true;
            //
            //Recovery_Documents_Collecting_Bank
            //
            this.Recovery_Documents_Collecting_Bank.Enabled = false;
            this.Recovery_Documents_Collecting_Bank.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Recovery_Documents_Collecting_Bank.Location = new System.Drawing.Point(45, 106);
            this.Recovery_Documents_Collecting_Bank.Name = "Recovery_Documents_Collecting_Bank";
            this.Recovery_Documents_Collecting_Bank.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Recovery_Documents_Collecting_Bank.Size = new System.Drawing.Size(270, 31);
            this.Recovery_Documents_Collecting_Bank.TabIndex = 253;
            //
            //Label2
            //
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label2.Location = new System.Drawing.Point(1100, 75);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label2.Size = new System.Drawing.Size(134, 25);
            this.Label2.TabIndex = 168;
            this.Label2.Text = " تاریخ دریــافــت:";
            //
            //Label12
            //
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label12.Location = new System.Drawing.Point(625, 75);
            this.Label12.Name = "Label12";
            this.Label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label12.Size = new System.Drawing.Size(123, 25);
            this.Label12.TabIndex = 184;
            this.Label12.Text = "تاریخ واگذاری :";
            //
            //Recovery_Documents_Assignment_Date
            //
            this.Recovery_Documents_Assignment_Date.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Recovery_Documents_Assignment_Date.AutoSize = true;
            this.Recovery_Documents_Assignment_Date.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Recovery_Documents_Assignment_Date.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Recovery_Documents_Assignment_Date.Location = new System.Drawing.Point(503, 73);
            this.Recovery_Documents_Assignment_Date.Name = "Recovery_Documents_Assignment_Date";
            this.Recovery_Documents_Assignment_Date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Recovery_Documents_Assignment_Date.Size = new System.Drawing.Size(135, 32);
            this.Recovery_Documents_Assignment_Date.T_D = "";
            this.Recovery_Documents_Assignment_Date.TabIndex = 3;
            //
            //Label15
            //
            this.Label15.AutoSize = true;
            this.Label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label15.Location = new System.Drawing.Point(374, 75);
            this.Label15.Name = "Label15";
            this.Label15.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label15.Size = new System.Drawing.Size(125, 25);
            this.Label15.TabIndex = 186;
            this.Label15.Text = "تاریخ وصولی  :";
            //
            //Label13
            //
            this.Label13.AutoSize = true;
            this.Label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label13.Location = new System.Drawing.Point(1101, 110);
            this.Label13.Name = "Label13";
            this.Label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label13.Size = new System.Drawing.Size(124, 25);
            this.Label13.TabIndex = 190;
            this.Label13.Text = "تاریخ استرداد  :";
            //
            //Label3
            //
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label3.Location = new System.Drawing.Point(871, 74);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label3.Size = new System.Drawing.Size(124, 25);
            this.Label3.TabIndex = 169;
            this.Label3.Text = "تاریخ سررسید :";
            //
            //GroupBox1
            //
            this.GroupBox1.Controls.Add(this.Az_Ta);
            this.GroupBox1.Controls.Add(this.Label19);
            this.GroupBox1.Controls.Add(this.Recovery_Documents_From_Date);
            this.GroupBox1.Controls.Add(this.Recovery_Documents_Until_Date);
            this.GroupBox1.Location = new System.Drawing.Point(256, 26);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(432, 46);
            this.GroupBox1.TabIndex = 252;
            this.GroupBox1.TabStop = false;
            //
            //Az_Ta
            //
            this.Az_Ta.AutoSize = true;
            this.Az_Ta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Az_Ta.Location = new System.Drawing.Point(263, 13);
            this.Az_Ta.Name = "Az_Ta";
            this.Az_Ta.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Az_Ta.Size = new System.Drawing.Size(135, 25);
            this.Az_Ta.TabIndex = 251;
            this.Az_Ta.Text = "از تاریخ دریافت :";
            //
            //Label19
            //
            this.Label19.AutoSize = true;
            this.Label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label19.Location = new System.Drawing.Point(117, 13);
            this.Label19.Name = "Label19";
            this.Label19.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label19.Size = new System.Drawing.Size(28, 25);
            this.Label19.TabIndex = 253;
            this.Label19.Text = "تا:";
            //
            //Recovery_Documents_From_Date
            //
            this.Recovery_Documents_From_Date.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Recovery_Documents_From_Date.AutoSize = true;
            this.Recovery_Documents_From_Date.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Recovery_Documents_From_Date.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Recovery_Documents_From_Date.Location = new System.Drawing.Point(156, 10);
            this.Recovery_Documents_From_Date.Name = "Recovery_Documents_From_Date";
            this.Recovery_Documents_From_Date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Recovery_Documents_From_Date.Size = new System.Drawing.Size(121, 32);
            this.Recovery_Documents_From_Date.T_D = "";
            this.Recovery_Documents_From_Date.TabIndex = 250;
            //
            //Recovery_Documents_Until_Date
            //
            this.Recovery_Documents_Until_Date.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Recovery_Documents_Until_Date.AutoSize = true;
            this.Recovery_Documents_Until_Date.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Recovery_Documents_Until_Date.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Recovery_Documents_Until_Date.Location = new System.Drawing.Point(6, 11);
            this.Recovery_Documents_Until_Date.Name = "Recovery_Documents_Until_Date";
            this.Recovery_Documents_Until_Date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Recovery_Documents_Until_Date.Size = new System.Drawing.Size(121, 32);
            this.Recovery_Documents_Until_Date.T_D = "";
            this.Recovery_Documents_Until_Date.TabIndex = 252;
            //
            //Label14
            //
            this.Label14.AutoSize = true;
            this.Label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label14.Location = new System.Drawing.Point(131, 74);
            this.Label14.Name = "Label14";
            this.Label14.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label14.Size = new System.Drawing.Size(119, 25);
            this.Label14.TabIndex = 189;
            this.Label14.Text = "تاریخ برگشتی :";
            //
            //B_Recovery_Documents_Subscription
            //
            this.B_Recovery_Documents_Subscription.Image = (System.Drawing.Image)resources.GetObject("B_Recovery_Documents_Subscription.Image");
            this.B_Recovery_Documents_Subscription.Location = new System.Drawing.Point(695, 36);
            this.B_Recovery_Documents_Subscription.Name = "B_Recovery_Documents_Subscription";
            this.B_Recovery_Documents_Subscription.Size = new System.Drawing.Size(29, 27);
            this.B_Recovery_Documents_Subscription.TabIndex = 247;
            this.B_Recovery_Documents_Subscription.UseVisualStyleBackColor = true;
            //
            //Recovery_Documents_Operation
            //
            this.Recovery_Documents_Operation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Recovery_Documents_Operation.FormattingEnabled = true;
            this.Recovery_Documents_Operation.Items.AddRange(new object[] { "ثبت چک", "واگذار به بانک", "اعلام وصولی", "اعلام برگشتی", "اعلام استردادی" });
            this.Recovery_Documents_Operation.Location = new System.Drawing.Point(13, 34);
            this.Recovery_Documents_Operation.Name = "Recovery_Documents_Operation";
            this.Recovery_Documents_Operation.Size = new System.Drawing.Size(175, 28);
            this.Recovery_Documents_Operation.TabIndex = 10;
            //
            //Recovery_Documents_Refund_Date
            //
            this.Recovery_Documents_Refund_Date.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Recovery_Documents_Refund_Date.AutoSize = true;
            this.Recovery_Documents_Refund_Date.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Recovery_Documents_Refund_Date.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Recovery_Documents_Refund_Date.Location = new System.Drawing.Point(995, 109);
            this.Recovery_Documents_Refund_Date.Name = "Recovery_Documents_Refund_Date";
            this.Recovery_Documents_Refund_Date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Recovery_Documents_Refund_Date.Size = new System.Drawing.Size(110, 32);
            this.Recovery_Documents_Refund_Date.T_D = "";
            this.Recovery_Documents_Refund_Date.TabIndex = 6;
            //
            //Recovery_Documents_Returned_Date
            //
            this.Recovery_Documents_Returned_Date.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Recovery_Documents_Returned_Date.AutoSize = true;
            this.Recovery_Documents_Returned_Date.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Recovery_Documents_Returned_Date.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Recovery_Documents_Returned_Date.Location = new System.Drawing.Point(13, 72);
            this.Recovery_Documents_Returned_Date.Name = "Recovery_Documents_Returned_Date";
            this.Recovery_Documents_Returned_Date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Recovery_Documents_Returned_Date.Size = new System.Drawing.Size(135, 32);
            this.Recovery_Documents_Returned_Date.T_D = "";
            this.Recovery_Documents_Returned_Date.TabIndex = 5;
            //
            //Recovery_Documents_Pass_Date
            //
            this.Recovery_Documents_Pass_Date.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Recovery_Documents_Pass_Date.AutoSize = true;
            this.Recovery_Documents_Pass_Date.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Recovery_Documents_Pass_Date.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Recovery_Documents_Pass_Date.Location = new System.Drawing.Point(256, 73);
            this.Recovery_Documents_Pass_Date.Name = "Recovery_Documents_Pass_Date";
            this.Recovery_Documents_Pass_Date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Recovery_Documents_Pass_Date.Size = new System.Drawing.Size(135, 32);
            this.Recovery_Documents_Pass_Date.T_D = "";
            this.Recovery_Documents_Pass_Date.TabIndex = 4;
            //
            //L_Mab
            //
            this.L_Mab.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.L_Mab.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.L_Mab.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.L_Mab.ForeColor = System.Drawing.Color.Red;
            this.L_Mab.Location = new System.Drawing.Point(15, 184);
            this.L_Mab.Name = "L_Mab";
            this.L_Mab.ReadOnly = true;
            this.L_Mab.Size = new System.Drawing.Size(833, 24);
            this.L_Mab.TabIndex = 182;
            //
            //Recovery_Documents_Description
            //
            this.Recovery_Documents_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Recovery_Documents_Description.Location = new System.Drawing.Point(15, 217);
            this.Recovery_Documents_Description.Name = "Recovery_Documents_Description";
            this.Recovery_Documents_Description.Size = new System.Drawing.Size(1120, 31);
            this.Recovery_Documents_Description.TabIndex = 15;
            //
            //Recovery_Documents_Due_Date
            //
            this.Recovery_Documents_Due_Date.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Recovery_Documents_Due_Date.AutoSize = true;
            this.Recovery_Documents_Due_Date.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Recovery_Documents_Due_Date.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Recovery_Documents_Due_Date.Location = new System.Drawing.Point(751, 72);
            this.Recovery_Documents_Due_Date.Name = "Recovery_Documents_Due_Date";
            this.Recovery_Documents_Due_Date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Recovery_Documents_Due_Date.Size = new System.Drawing.Size(135, 32);
            this.Recovery_Documents_Due_Date.T_D = "";
            this.Recovery_Documents_Due_Date.TabIndex = 2;
            //
            //Recovery_Documents_Date_Received
            //
            this.Recovery_Documents_Date_Received.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Recovery_Documents_Date_Received.AutoSize = true;
            this.Recovery_Documents_Date_Received.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Recovery_Documents_Date_Received.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Recovery_Documents_Date_Received.Location = new System.Drawing.Point(994, 72);
            this.Recovery_Documents_Date_Received.Name = "Recovery_Documents_Date_Received";
            this.Recovery_Documents_Date_Received.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Recovery_Documents_Date_Received.Size = new System.Drawing.Size(109, 32);
            this.Recovery_Documents_Date_Received.T_D = "";
            this.Recovery_Documents_Date_Received.TabIndex = 1;
            //
            //Label10
            //
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label10.Location = new System.Drawing.Point(1139, 217);
            this.Label10.Name = "Label10";
            this.Label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label10.Size = new System.Drawing.Size(92, 25);
            this.Label10.TabIndex = 179;
            this.Label10.Text = "توضیحات :";
            //
            //Recovery_Documents_Bank
            //
            this.Recovery_Documents_Bank.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Recovery_Documents_Bank.Location = new System.Drawing.Point(751, 106);
            this.Recovery_Documents_Bank.Name = "Recovery_Documents_Bank";
            this.Recovery_Documents_Bank.Size = new System.Drawing.Size(181, 31);
            this.Recovery_Documents_Bank.TabIndex = 7;
            //
            //Label11
            //
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label11.Location = new System.Drawing.Point(853, 185);
            this.Label11.Name = "Label11";
            this.Label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label11.Size = new System.Drawing.Size(112, 20);
            this.Label11.TabIndex = 176;
            this.Label11.Text = "مبلغ چک به حروف :";
            //
            //Label9
            //
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label9.Location = new System.Drawing.Point(1141, 184);
            this.Label9.Name = "Label9";
            this.Label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label9.Size = new System.Drawing.Size(81, 25);
            this.Label9.TabIndex = 175;
            this.Label9.Text = "مبلغ چک :";
            //
            //Recovery_Documents_Amount
            //
            this.Recovery_Documents_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Recovery_Documents_Amount.Location = new System.Drawing.Point(969, 180);
            this.Recovery_Documents_Amount.MaxLength = 15;
            this.Recovery_Documents_Amount.Name = "Recovery_Documents_Amount";
            this.Recovery_Documents_Amount.Size = new System.Drawing.Size(166, 31);
            this.Recovery_Documents_Amount.TabIndex = 14;
            //
            //Recovery_Documents_Case
            //
            this.Recovery_Documents_Case.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Recovery_Documents_Case.FormattingEnabled = true;
            this.Recovery_Documents_Case.Location = new System.Drawing.Point(15, 145);
            this.Recovery_Documents_Case.Name = "Recovery_Documents_Case";
            this.Recovery_Documents_Case.Size = new System.Drawing.Size(466, 28);
            this.Recovery_Documents_Case.TabIndex = 13;
            //
            //Label8
            //
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label8.Location = new System.Drawing.Point(487, 145);
            this.Label8.Name = "Label8";
            this.Label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label8.Size = new System.Drawing.Size(54, 25);
            this.Label8.TabIndex = 174;
            this.Label8.Text = "بابت :";
            //
            //Label7
            //
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label7.Location = new System.Drawing.Point(852, 148);
            this.Label7.Name = "Label7";
            this.Label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label7.Size = new System.Drawing.Size(111, 25);
            this.Label7.TabIndex = 173;
            this.Label7.Text = "شماره حساب:";
            //
            //Recovery_Documents_Account_Number
            //
            this.Recovery_Documents_Account_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Recovery_Documents_Account_Number.Location = new System.Drawing.Point(552, 144);
            this.Recovery_Documents_Account_Number.Name = "Recovery_Documents_Account_Number";
            this.Recovery_Documents_Account_Number.Size = new System.Drawing.Size(294, 31);
            this.Recovery_Documents_Account_Number.TabIndex = 12;
            //
            //Label6
            //
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label6.Location = new System.Drawing.Point(1141, 148);
            this.Label6.Name = "Label6";
            this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label6.Size = new System.Drawing.Size(90, 25);
            this.Label6.TabIndex = 172;
            this.Label6.Text = "شماره چک:";
            //
            //Recovery_Documents_No_Check
            //
            this.Recovery_Documents_No_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Recovery_Documents_No_Check.Location = new System.Drawing.Point(969, 145);
            this.Recovery_Documents_No_Check.Name = "Recovery_Documents_No_Check";
            this.Recovery_Documents_No_Check.Size = new System.Drawing.Size(166, 31);
            this.Recovery_Documents_No_Check.TabIndex = 11;
            //
            //Label5
            //
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label5.Location = new System.Drawing.Point(689, 109);
            this.Label5.Name = "Label5";
            this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label5.Size = new System.Drawing.Size(58, 25);
            this.Label5.TabIndex = 171;
            this.Label5.Text = "شعبه :";
            //
            //Recovery_Documents_Branch
            //
            this.Recovery_Documents_Branch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Recovery_Documents_Branch.Location = new System.Drawing.Point(459, 106);
            this.Recovery_Documents_Branch.Name = "Recovery_Documents_Branch";
            this.Recovery_Documents_Branch.Size = new System.Drawing.Size(225, 31);
            this.Recovery_Documents_Branch.TabIndex = 8;
            //
            //Label4
            //
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label4.Location = new System.Drawing.Point(938, 109);
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label4.Size = new System.Drawing.Size(51, 25);
            this.Label4.TabIndex = 170;
            this.Label4.Text = "بانک :";
            //
            //Label1
            //
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label1.Location = new System.Drawing.Point(1128, 35);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label1.Size = new System.Drawing.Size(103, 25);
            this.Label1.TabIndex = 166;
            this.Label1.Text = "کــد مشترک :";
            //
            //Recovery_Documents_Subscription
            //
            this.Recovery_Documents_Subscription.Enabled = false;
            this.Recovery_Documents_Subscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Recovery_Documents_Subscription.Location = new System.Drawing.Point(724, 33);
            this.Recovery_Documents_Subscription.Name = "Recovery_Documents_Subscription";
            this.Recovery_Documents_Subscription.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Recovery_Documents_Subscription.Size = new System.Drawing.Size(402, 31);
            this.Recovery_Documents_Subscription.TabIndex = 0;
            //
            //ToolStrip
            //
            this.ToolStrip.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.B_Product, this.Edit_B, this.Delet_B, this.Search_B, this.Save_B, this.B_Excel, this.Chap, this.Log_File, this.B_Picture, this.Abort_B });
            this.ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(1237, 26);
            this.ToolStrip.TabIndex = 0;
            this.ToolStrip.Text = "ToolStrip1";
            //
            //B_Product
            //
            this.B_Product.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.B_New, this.B_Old, this.B_Assignment, this.B_Assignment_All, this.B_Collecting, this.B_Returned, this.B_Refund });
            this.B_Product.Image = (System.Drawing.Image)resources.GetObject("B_Product.Image");
            this.B_Product.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.B_Product.Name = "B_Product";
            this.B_Product.Size = new System.Drawing.Size(87, 23);
            this.B_Product.Text = "عملیات";
            this.B_Product.Visible = false;
            //
            //B_New
            //
            this.B_New.Image = (System.Drawing.Image)resources.GetObject("B_New.Image");
            this.B_New.Name = "B_New";
            this.B_New.Size = new System.Drawing.Size(226, 24);
            this.B_New.Text = "ثبت اطلاعات جـــدیـــد";
            //
            //B_Old
            //
            this.B_Old.Image = (System.Drawing.Image)resources.GetObject("B_Old.Image");
            this.B_Old.Name = "B_Old";
            this.B_Old.Size = new System.Drawing.Size(226, 24);
            this.B_Old.Text = "ثبت اطلاعات قـــبــلی";
            //
            //B_Assignment
            //
            this.B_Assignment.Image = (System.Drawing.Image)resources.GetObject("B_Assignment.Image");
            this.B_Assignment.Name = "B_Assignment";
            this.B_Assignment.Size = new System.Drawing.Size(226, 24);
            this.B_Assignment.Text = "واگذاری اسناد به بانک";
            //
            //B_Assignment_All
            //
            this.B_Assignment_All.Image = (System.Drawing.Image)resources.GetObject("B_Assignment_All.Image");
            this.B_Assignment_All.Name = "B_Assignment_All";
            this.B_Assignment_All.Size = new System.Drawing.Size(226, 24);
            this.B_Assignment_All.Text = "واگذاری کــلی اسنــاد";
            //
            //B_Collecting
            //
            this.B_Collecting.Image = (System.Drawing.Image)resources.GetObject("B_Collecting.Image");
            this.B_Collecting.Name = "B_Collecting";
            this.B_Collecting.Size = new System.Drawing.Size(226, 24);
            this.B_Collecting.Text = "اعــلام وصـــولی اسناد";
            //
            //B_Returned
            //
            this.B_Returned.Image = (System.Drawing.Image)resources.GetObject("B_Returned.Image");
            this.B_Returned.Name = "B_Returned";
            this.B_Returned.Size = new System.Drawing.Size(226, 24);
            this.B_Returned.Text = "اعلام برگشتی اســناد";
            //
            //B_Refund
            //
            this.B_Refund.Image = (System.Drawing.Image)resources.GetObject("B_Refund.Image");
            this.B_Refund.Name = "B_Refund";
            this.B_Refund.Size = new System.Drawing.Size(226, 24);
            this.B_Refund.Text = "اعلام استردادی اسناد";
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
            //Search_B
            //
            this.Search_B.Image = (System.Drawing.Image)resources.GetObject("Search_B.Image");
            this.Search_B.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Search_B.Name = "Search_B";
            this.Search_B.Size = new System.Drawing.Size(81, 23);
            this.Search_B.Text = "جستجو";
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
            //B_Excel
            //
            this.B_Excel.Image = (System.Drawing.Image)resources.GetObject("B_Excel.Image");
            this.B_Excel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.B_Excel.Name = "B_Excel";
            this.B_Excel.Size = new System.Drawing.Size(70, 23);
            this.B_Excel.Text = "اکسل";
            //
            //Chap
            //
            this.Chap.Image = (System.Drawing.Image)resources.GetObject("Chap.Image");
            this.Chap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Chap.Name = "Chap";
            this.Chap.Size = new System.Drawing.Size(58, 23);
            this.Chap.Text = "چاپ";
            //
            //Log_File
            //
            this.Log_File.Image = (System.Drawing.Image)resources.GetObject("Log_File.Image");
            this.Log_File.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Log_File.Name = "Log_File";
            this.Log_File.Size = new System.Drawing.Size(109, 23);
            this.Log_File.Text = "کنترل اسناد";
            this.Log_File.Visible = false;
            //
            //B_Picture
            //
            this.B_Picture.Image = (System.Drawing.Image)resources.GetObject("B_Picture.Image");
            this.B_Picture.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.B_Picture.Name = "B_Picture";
            this.B_Picture.Size = new System.Drawing.Size(63, 23);
            this.B_Picture.Text = "تصویر";
            //
            //Abort_B
            //
            this.Abort_B.Image = (System.Drawing.Image)resources.GetObject("Abort_B.Image");
            this.Abort_B.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Abort_B.Name = "Abort_B";
            this.Abort_B.Size = new System.Drawing.Size(74, 23);
            this.Abort_B.Text = "انصراف";
            //
            //Label17
            //
            this.Label17.AutoSize = true;
            this.Label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label17.Location = new System.Drawing.Point(187, 35);
            this.Label17.Name = "Label17";
            this.Label17.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label17.Size = new System.Drawing.Size(73, 25);
            this.Label17.TabIndex = 194;
            this.Label17.Text = "عملیات :";
            //
            //Label16
            //
            this.Label16.AutoSize = true;
            this.Label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label16.Location = new System.Drawing.Point(312, 109);
            this.Label16.Name = "Label16";
            this.Label16.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label16.Size = new System.Drawing.Size(148, 25);
            this.Label16.TabIndex = 192;
            this.Label16.Text = " بانک وصول کننده :";
            //
            //DV
            //
            DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            DataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1;
            this.DV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            DataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DV.DefaultCellStyle = DataGridViewCellStyle2;
            this.DV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.DV.Location = new System.Drawing.Point(0, 0);
            this.DV.Name = "DV";
            this.DV.Size = new System.Drawing.Size(1237, 275);
            this.DV.TabIndex = 0;
            //
            //Collection_Document
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7.0F, 16.0F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1237, 534);
            this.Controls.Add(this.SplitContainer1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Collection_Document";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ch_Add_A";
            this.SplitContainer1.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel1.PerformLayout();
            this.SplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.SplitContainer1).EndInit();
            this.SplitContainer1.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.DV).EndInit();
            this.ResumeLayout(false);

        }
        internal System.Windows.Forms.SplitContainer SplitContainer1;
        internal System.Windows.Forms.ToolStrip ToolStrip;
        internal System.Windows.Forms.ToolStripButton Edit_B;
        internal System.Windows.Forms.ToolStripButton Delet_B;
        internal System.Windows.Forms.ToolStripButton Save_B;
        internal System.Windows.Forms.ToolStripButton Search_B;
        internal System.Windows.Forms.ToolStripButton Chap;
        internal System.Windows.Forms.ToolStripButton Abort_B;
        internal System.Windows.Forms.ToolStripButton B_Excel;
        internal System.Windows.Forms.DataGridView DV;
        internal Ansaripour.Rtl_Date Recovery_Documents_Due_Date;
        internal Ansaripour.Rtl_Date Recovery_Documents_Date_Received;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.TextBox Recovery_Documents_Bank;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.TextBox Recovery_Documents_Amount;
        internal System.Windows.Forms.ComboBox Recovery_Documents_Case;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox Recovery_Documents_Account_Number;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox Recovery_Documents_No_Check;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox Recovery_Documents_Branch;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox Recovery_Documents_Subscription;
        internal System.Windows.Forms.TextBox Recovery_Documents_Description;
        internal System.Windows.Forms.TextBox L_Mab;
        internal Ansaripour.Rtl_Date Recovery_Documents_Assignment_Date;
        internal System.Windows.Forms.Label Label12;
        internal Ansaripour.Rtl_Date Recovery_Documents_Pass_Date;
        internal System.Windows.Forms.Label Label15;
        internal Ansaripour.Rtl_Date Recovery_Documents_Refund_Date;
        internal Ansaripour.Rtl_Date Recovery_Documents_Returned_Date;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.ComboBox Recovery_Documents_Operation;
        internal System.Windows.Forms.Label Label17;
        internal System.Windows.Forms.Button B_Recovery_Documents_Subscription;
        internal System.Windows.Forms.ToolStripButton B_Picture;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal Ansaripour.Rtl_Date Recovery_Documents_Until_Date;
        internal System.Windows.Forms.Label Label19;
        internal Ansaripour.Rtl_Date Recovery_Documents_From_Date;
        internal System.Windows.Forms.Label Az_Ta;
        internal System.Windows.Forms.ToolStripDropDownButton B_Product;
        internal System.Windows.Forms.ToolStripMenuItem B_New;
        internal System.Windows.Forms.ToolStripMenuItem B_Assignment_All;
        internal System.Windows.Forms.ToolStripMenuItem B_Old;
        internal System.Windows.Forms.ToolStripMenuItem B_Assignment;
        internal System.Windows.Forms.ToolStripMenuItem B_Collecting;
        internal System.Windows.Forms.ToolStripMenuItem B_Returned;
        internal System.Windows.Forms.ToolStripMenuItem B_Refund;
        internal System.Windows.Forms.ToolStripButton Log_File;
        internal System.Windows.Forms.Button B_Recovery_Documents_Collecting_Bank;
        internal System.Windows.Forms.TextBox Recovery_Documents_Collecting_Bank;
    }
