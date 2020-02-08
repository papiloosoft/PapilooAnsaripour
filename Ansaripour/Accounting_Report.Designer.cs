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
	public partial class Accounting_Report : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accounting_Report));
			this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
			this.Print_B = new System.Windows.Forms.ToolStripButton();
			this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.Excel_B = new System.Windows.Forms.ToolStripButton();
			this.Abort_B = new System.Windows.Forms.ToolStripButton();
			this.TabControl1 = new System.Windows.Forms.TabControl();
			this.TabPage1 = new System.Windows.Forms.TabPage();
			this.GroupBox8 = new System.Windows.Forms.GroupBox();
			this.L_Accounting_Details_Acc_Main_Until = new System.Windows.Forms.Label();
			this.L_Accounting_Details_Acc_Main_From = new System.Windows.Forms.Label();
			this.GroupBox9 = new System.Windows.Forms.GroupBox();
			this.Accounting_Area_one = new System.Windows.Forms.RadioButton();
			this.Accounting_Area_All = new System.Windows.Forms.RadioButton();
			this.B_Accounting_Area_Main_one = new System.Windows.Forms.Button();
			this.Accounting_Area_Main_one = new System.Windows.Forms.TextBox();
			this.Accounting_Details_Number_Turning_Main_Until = new System.Windows.Forms.TextBox();
			this.Label25 = new System.Windows.Forms.Label();
			this.Accounting_Details_Number_Turning_Main_From = new System.Windows.Forms.TextBox();
			this.Label24 = new System.Windows.Forms.Label();
			this.Label23 = new System.Windows.Forms.Label();
			this.Accounting_Details_Date_Due_Main_Until = new Ansaripour.Rtl_Date();
			this.Label22 = new System.Windows.Forms.Label();
			this.Accounting_Details_Date_Due_Main_From = new Ansaripour.Rtl_Date();
			this.Accounting_Details_Number_Due_Main_Until = new System.Windows.Forms.TextBox();
			this.Label20 = new System.Windows.Forms.Label();
			this.Accounting_Details_Number_Due_Main_From = new System.Windows.Forms.TextBox();
			this.Estehlak_Label = new System.Windows.Forms.Label();
			this.Label19 = new System.Windows.Forms.Label();
			this.Accounting_Details_Date_Cost_Main_Until = new Ansaripour.Rtl_Date();
			this.Label18 = new System.Windows.Forms.Label();
			this.Accounting_Details_Date_Cost_Main_From = new Ansaripour.Rtl_Date();
			this.B_Accounting_Details_Acc_Main_From = new System.Windows.Forms.Button();
			this.Label13 = new System.Windows.Forms.Label();
			this.Accounting_Details_Description_Main = new System.Windows.Forms.TextBox();
			this.Accounting_Details_Acc_Main_From = new System.Windows.Forms.TextBox();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.Accounting_Details_Acc_Main_Until = new System.Windows.Forms.TextBox();
			this.B_Accounting_Details_Acc_Main_Until = new System.Windows.Forms.Button();
			this.GroupBox7 = new System.Windows.Forms.GroupBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Accounting_Header_Description = new System.Windows.Forms.TextBox();
			this.Header_Number_From = new System.Windows.Forms.TextBox();
			this.Label21 = new System.Windows.Forms.Label();
			this.Header_Number_Until = new System.Windows.Forms.TextBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.Accounting_Header_Date_Until = new Ansaripour.Rtl_Date();
			this.Accounting_Header_Date_From = new Ansaripour.Rtl_Date();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.Accounting_Header_Class_4 = new System.Windows.Forms.CheckBox();
			this.Accounting_Header_Class_3 = new System.Windows.Forms.CheckBox();
			this.Accounting_Header_Class_5 = new System.Windows.Forms.CheckBox();
			this.Accounting_Header_Class_2 = new System.Windows.Forms.CheckBox();
			this.Accounting_Header_Class_1 = new System.Windows.Forms.CheckBox();
			this.Accounting_Header_Class_0 = new System.Windows.Forms.CheckBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.TabPage2 = new System.Windows.Forms.TabPage();
			this.GroupBox6 = new System.Windows.Forms.GroupBox();
			this.L_Accounting_Details_Detailed_Five_Main_From = new System.Windows.Forms.Label();
			this.L_Accounting_Details_Detailed_Five_Main_Until = new System.Windows.Forms.Label();
			this.Accounting_Details_Detailed_Five_Main_Until = new System.Windows.Forms.TextBox();
			this.B_Accounting_Details_Detailed_Five_Main_Until = new System.Windows.Forms.Button();
			this.Label16 = new System.Windows.Forms.Label();
			this.Accounting_Details_Detailed_Five_Main_From = new System.Windows.Forms.TextBox();
			this.B_Accounting_Details_Detailed_Five_Main_From = new System.Windows.Forms.Button();
			this.Label17 = new System.Windows.Forms.Label();
			this.GroupBox5 = new System.Windows.Forms.GroupBox();
			this.L_Accounting_Details_Detailed_Four_Main_From = new System.Windows.Forms.Label();
			this.L_Accounting_Details_Detailed_Four_Main_Until = new System.Windows.Forms.Label();
			this.Accounting_Details_Detailed_Four_Main_Until = new System.Windows.Forms.TextBox();
			this.B_Accounting_Details_Detailed_Four_Main_Until = new System.Windows.Forms.Button();
			this.Label14 = new System.Windows.Forms.Label();
			this.Accounting_Details_Detailed_Four_Main_From = new System.Windows.Forms.TextBox();
			this.B_Accounting_Details_Detailed_Four_Main_From = new System.Windows.Forms.Button();
			this.Label15 = new System.Windows.Forms.Label();
			this.GroupBox4 = new System.Windows.Forms.GroupBox();
			this.L_Accounting_Details_Detailed_Three_Main_From = new System.Windows.Forms.Label();
            this.L_Accounting_Details_Detailed_Three_Main_Until = new System.Windows.Forms.Label();
            this.Accounting_Details_Detailed_Three_Main_Until = new System.Windows.Forms.TextBox();
            this.B_Accounting_Details_Detailed_Three_Main_Until = new System.Windows.Forms.Button();
            this.Label11 = new System.Windows.Forms.Label();
            this.Accounting_Details_Detailed_Three_Main_From = new System.Windows.Forms.TextBox();
            this.B_Accounting_Details_Detailed_Three_Main_From = new System.Windows.Forms.Button();
            this.Label12 = new System.Windows.Forms.Label();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.L_Accounting_Details_Detailed_Two_Main_From = new System.Windows.Forms.Label();
            this.L_Accounting_Details_Detailed_Two_Main_Until = new System.Windows.Forms.Label();
            this.Accounting_Details_Detailed_Two_Main_Until = new System.Windows.Forms.TextBox();
            this.B_Accounting_Details_Detailed_Two_Main_Until = new System.Windows.Forms.Button();
            this.Label9 = new System.Windows.Forms.Label();
            this.Accounting_Details_Detailed_Two_Main_From = new System.Windows.Forms.TextBox();
            this.B_Accounting_Details_Detailed_Two_Main_From = new System.Windows.Forms.Button();
            this.Label10 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.L_Accounting_Details_Detailed_One_Main_Until = new System.Windows.Forms.Label();
            this.L_Accounting_Details_Detailed_One_Main_From = new System.Windows.Forms.Label();
            this.Accounting_Details_Detailed_One_Main_Until = new System.Windows.Forms.TextBox();
            this.B_Accounting_Details_Detailed_One_Main_Until = new System.Windows.Forms.Button();
            this.Label8 = new System.Windows.Forms.Label();
            this.Accounting_Details_Detailed_One_Main_From = new System.Windows.Forms.TextBox();
            this.B_Accounting_Details_Detailed_One_Main_From = new System.Windows.Forms.Button();
            this.Label7 = new System.Windows.Forms.Label();
            this.ToolStrip1.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.GroupBox8.SuspendLayout();
            this.GroupBox9.SuspendLayout();
            this.GroupBox7.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.GroupBox6.SuspendLayout();
            this.GroupBox5.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            //
            //ToolStrip1
            //
            this.ToolStrip1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.Print_B, this.ToolStripSeparator3, this.Excel_B, this.Abort_B });
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ToolStrip1.ShowItemToolTips = false;
            this.ToolStrip1.Size = new System.Drawing.Size(764, 25);
            this.ToolStrip1.TabIndex = 7;
            this.ToolStrip1.Text = "ToolStrip1";
            //
            //Print_B
            //
            this.Print_B.Image = (System.Drawing.Image)resources.GetObject("Print_B.Image");
            this.Print_B.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Print_B.Name = "Print_B";
            this.Print_B.Size = new System.Drawing.Size(52, 22);
            this.Print_B.Text = "چاپ";
            //
            //ToolStripSeparator3
            //
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            this.ToolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            //
            //Excel_B
            //
            this.Excel_B.Image = (System.Drawing.Image)resources.GetObject("Excel_B.Image");
            this.Excel_B.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Excel_B.Name = "Excel_B";
            this.Excel_B.Size = new System.Drawing.Size(60, 22);
            this.Excel_B.Text = "اکسل";
            //
            //Abort_B
            //
            this.Abort_B.Image = (System.Drawing.Image)resources.GetObject("Abort_B.Image");
            this.Abort_B.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Abort_B.Name = "Abort_B";
            this.Abort_B.Size = new System.Drawing.Size(64, 22);
            this.Abort_B.Text = "انصراف";
            //
            //TabControl1
            //
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl1.Location = new System.Drawing.Point(0, 25);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TabControl1.RightToLeftLayout = true;
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(764, 460);
            this.TabControl1.TabIndex = 8;
            //
            //TabPage1
            //
            this.TabPage1.Controls.Add(this.GroupBox8);
            this.TabPage1.Controls.Add(this.GroupBox7);
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(756, 434);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "اصلی / کد حساب";
            this.TabPage1.UseVisualStyleBackColor = true;
            //
            //GroupBox8
            //
            this.GroupBox8.Controls.Add(this.L_Accounting_Details_Acc_Main_Until);
            this.GroupBox8.Controls.Add(this.L_Accounting_Details_Acc_Main_From);
            this.GroupBox8.Controls.Add(this.GroupBox9);
            this.GroupBox8.Controls.Add(this.Accounting_Details_Number_Turning_Main_Until);
            this.GroupBox8.Controls.Add(this.Label25);
            this.GroupBox8.Controls.Add(this.Accounting_Details_Number_Turning_Main_From);
            this.GroupBox8.Controls.Add(this.Label24);
            this.GroupBox8.Controls.Add(this.Label23);
//            this.GroupBox8.Controls.Add(this.Accounting_Details_Date_Due_Main_Until);
            this.GroupBox8.Controls.Add(this.Label22);
//            this.GroupBox8.Controls.Add(this.Accounting_Details_Date_Due_Main_From);
            this.GroupBox8.Controls.Add(this.Accounting_Details_Number_Due_Main_Until);
            this.GroupBox8.Controls.Add(this.Label20);
            this.GroupBox8.Controls.Add(this.Accounting_Details_Number_Due_Main_From);
            this.GroupBox8.Controls.Add(this.Estehlak_Label);
            this.GroupBox8.Controls.Add(this.Label19);
//            this.GroupBox8.Controls.Add(this.Accounting_Details_Date_Cost_Main_Until);
            this.GroupBox8.Controls.Add(this.Label18);
//            this.GroupBox8.Controls.Add(this.Accounting_Details_Date_Cost_Main_From);
            this.GroupBox8.Controls.Add(this.B_Accounting_Details_Acc_Main_From);
            this.GroupBox8.Controls.Add(this.Label13);
            this.GroupBox8.Controls.Add(this.Accounting_Details_Description_Main);
            this.GroupBox8.Controls.Add(this.Accounting_Details_Acc_Main_From);
            this.GroupBox8.Controls.Add(this.Label6);
            this.GroupBox8.Controls.Add(this.Label1);
            this.GroupBox8.Controls.Add(this.Accounting_Details_Acc_Main_Until);
            this.GroupBox8.Controls.Add(this.B_Accounting_Details_Acc_Main_Until);
            this.GroupBox8.Location = new System.Drawing.Point(6, 137);
            this.GroupBox8.Name = "GroupBox8";
            this.GroupBox8.Size = new System.Drawing.Size(747, 289);
            this.GroupBox8.TabIndex = 266;
            this.GroupBox8.TabStop = false;
            this.GroupBox8.Text = "اطلاعات سند :";
            //
            //L_Accounting_Details_Acc_Main_Until
            //
            this.L_Accounting_Details_Acc_Main_Until.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.L_Accounting_Details_Acc_Main_Until.ForeColor = System.Drawing.Color.FromArgb((int)((byte)0), (int)((byte)192), (int)((byte)0));
            this.L_Accounting_Details_Acc_Main_Until.Location = new System.Drawing.Point(5, 63);
            this.L_Accounting_Details_Acc_Main_Until.Name = "L_Accounting_Details_Acc_Main_Until";
            this.L_Accounting_Details_Acc_Main_Until.Size = new System.Drawing.Size(489, 19);
            this.L_Accounting_Details_Acc_Main_Until.TabIndex = 297;
            this.L_Accounting_Details_Acc_Main_Until.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            //L_Accounting_Details_Acc_Main_From
            //
            this.L_Accounting_Details_Acc_Main_From.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.L_Accounting_Details_Acc_Main_From.ForeColor = System.Drawing.Color.FromArgb((int)((byte)0), (int)((byte)192), (int)((byte)0));
            this.L_Accounting_Details_Acc_Main_From.Location = new System.Drawing.Point(7, 19);
            this.L_Accounting_Details_Acc_Main_From.Name = "L_Accounting_Details_Acc_Main_From";
            this.L_Accounting_Details_Acc_Main_From.Size = new System.Drawing.Size(489, 19);
            this.L_Accounting_Details_Acc_Main_From.TabIndex = 296;
            this.L_Accounting_Details_Acc_Main_From.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            //GroupBox9
            //
            this.GroupBox9.Controls.Add(this.Accounting_Area_one);
            this.GroupBox9.Controls.Add(this.Accounting_Area_All);
            this.GroupBox9.Controls.Add(this.B_Accounting_Area_Main_one);
            this.GroupBox9.Controls.Add(this.Accounting_Area_Main_one);
            this.GroupBox9.Location = new System.Drawing.Point(7, 208);
            this.GroupBox9.Name = "GroupBox9";
            this.GroupBox9.Size = new System.Drawing.Size(490, 78);
            this.GroupBox9.TabIndex = 284;
            this.GroupBox9.TabStop = false;
            this.GroupBox9.Text = "گزارش حاوی اسناد :";
            //
            //Accounting_Area_one
            //
            this.Accounting_Area_one.AutoSize = true;
            this.Accounting_Area_one.Location = new System.Drawing.Point(388, 49);
            this.Accounting_Area_one.Name = "Accounting_Area_one";
            this.Accounting_Area_one.Size = new System.Drawing.Size(90, 17);
            this.Accounting_Area_one.TabIndex = 289;
            this.Accounting_Area_one.TabStop = true;
            this.Accounting_Area_one.Text = "یک بخش خاص :";
            this.Accounting_Area_one.UseVisualStyleBackColor = true;
            //
            //Accounting_Area_All
            //
            this.Accounting_Area_All.AutoSize = true;
            this.Accounting_Area_All.Location = new System.Drawing.Point(386, 19);
            this.Accounting_Area_All.Name = "Accounting_Area_All";
            this.Accounting_Area_All.Size = new System.Drawing.Size(92, 17);
            this.Accounting_Area_All.TabIndex = 288;
            this.Accounting_Area_All.TabStop = true;
            this.Accounting_Area_All.Text = "تمام بخــش ها :";
            this.Accounting_Area_All.UseVisualStyleBackColor = true;
            //
            //B_Accounting_Area_Main_one
            //
            this.B_Accounting_Area_Main_one.Image = (System.Drawing.Image)resources.GetObject("B_Accounting_Area_Main_one.Image");
            this.B_Accounting_Area_Main_one.Location = new System.Drawing.Point(8, 43);
            this.B_Accounting_Area_Main_one.Name = "B_Accounting_Area_Main_one";
            this.B_Accounting_Area_Main_one.Size = new System.Drawing.Size(29, 27);
            this.B_Accounting_Area_Main_one.TabIndex = 285;
            this.B_Accounting_Area_Main_one.UseVisualStyleBackColor = true;
            //
            //Accounting_Area_Main_one
            //
            this.Accounting_Area_Main_one.Enabled = false;
            this.Accounting_Area_Main_one.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Accounting_Area_Main_one.Location = new System.Drawing.Point(38, 42);
            this.Accounting_Area_Main_one.Name = "Accounting_Area_Main_one";
            this.Accounting_Area_Main_one.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Accounting_Area_Main_one.Size = new System.Drawing.Size(345, 31);
            this.Accounting_Area_Main_one.TabIndex = 284;
            //
            //Accounting_Details_Number_Turning_Main_Until
            //
            this.Accounting_Details_Number_Turning_Main_Until.BackColor = System.Drawing.Color.White;
            this.Accounting_Details_Number_Turning_Main_Until.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Accounting_Details_Number_Turning_Main_Until.Location = new System.Drawing.Point(503, 253);
            this.Accounting_Details_Number_Turning_Main_Until.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Accounting_Details_Number_Turning_Main_Until.MaxLength = 15;
            this.Accounting_Details_Number_Turning_Main_Until.Name = "Accounting_Details_Number_Turning_Main_Until";
            this.Accounting_Details_Number_Turning_Main_Until.Size = new System.Drawing.Size(97, 30);
            this.Accounting_Details_Number_Turning_Main_Until.TabIndex = 279;
            //
            //Label25
            //
            this.Label25.AutoSize = true;
            this.Label25.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label25.Location = new System.Drawing.Point(604, 259);
            this.Label25.Name = "Label25";
            this.Label25.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label25.Size = new System.Drawing.Size(141, 19);
            this.Label25.TabIndex = 280;
            this.Label25.Text = "شماره عطف سند :";
            //
            //Accounting_Details_Number_Turning_Main_From
            //
            this.Accounting_Details_Number_Turning_Main_From.BackColor = System.Drawing.Color.White;
            this.Accounting_Details_Number_Turning_Main_From.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Accounting_Details_Number_Turning_Main_From.Location = new System.Drawing.Point(503, 218);
            this.Accounting_Details_Number_Turning_Main_From.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Accounting_Details_Number_Turning_Main_From.MaxLength = 15;
            this.Accounting_Details_Number_Turning_Main_From.Name = "Accounting_Details_Number_Turning_Main_From";
            this.Accounting_Details_Number_Turning_Main_From.Size = new System.Drawing.Size(97, 30);
            this.Accounting_Details_Number_Turning_Main_From.TabIndex = 277;
            //
            //Label24
            //
            this.Label24.AutoSize = true;
            this.Label24.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label24.Location = new System.Drawing.Point(604, 224);
            this.Label24.Name = "Label24";
            this.Label24.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label24.Size = new System.Drawing.Size(141, 19);
            this.Label24.TabIndex = 278;
            this.Label24.Text = "شماره عطف سند :";
            //
            //Label23
            //
            this.Label23.AutoSize = true;
            this.Label23.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label23.Location = new System.Drawing.Point(110, 179);
            this.Label23.Name = "Label23";
            this.Label23.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label23.Size = new System.Drawing.Size(115, 19);
            this.Label23.TabIndex = 276;
            this.Label23.Text = "تاریخ سررسید :";
            //
            //Accounting_Details_Date_Due_Main_Until
            //
            this.Accounting_Details_Date_Due_Main_Until.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Accounting_Details_Date_Due_Main_Until.AutoSize = true;
            this.Accounting_Details_Date_Due_Main_Until.BackColor = System.Drawing.Color.White;
            this.Accounting_Details_Date_Due_Main_Until.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Accounting_Details_Date_Due_Main_Until.Location = new System.Drawing.Point(6, 173);
            this.Accounting_Details_Date_Due_Main_Until.Name = "Accounting_Details_Date_Due_Main_Until";
            this.Accounting_Details_Date_Due_Main_Until.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Accounting_Details_Date_Due_Main_Until.Size = new System.Drawing.Size(135, 36);
            this.Accounting_Details_Date_Due_Main_Until.T_D = "";
            this.Accounting_Details_Date_Due_Main_Until.TabIndex = 275;
            //
            //Label22
            //
            this.Label22.AutoSize = true;
            this.Label22.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label22.Location = new System.Drawing.Point(110, 144);
            this.Label22.Name = "Label22";
            this.Label22.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label22.Size = new System.Drawing.Size(115, 19);
            this.Label22.TabIndex = 274;
            this.Label22.Text = "تاریخ سررسید :";
            //
            //Accounting_Details_Date_Due_Main_From
            //
            this.Accounting_Details_Date_Due_Main_From.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Accounting_Details_Date_Due_Main_From.AutoSize = true;
            this.Accounting_Details_Date_Due_Main_From.BackColor = System.Drawing.Color.White;
            this.Accounting_Details_Date_Due_Main_From.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Accounting_Details_Date_Due_Main_From.Location = new System.Drawing.Point(6, 138);
            this.Accounting_Details_Date_Due_Main_From.Name = "Accounting_Details_Date_Due_Main_From";
            this.Accounting_Details_Date_Due_Main_From.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Accounting_Details_Date_Due_Main_From.Size = new System.Drawing.Size(135, 36);
            this.Accounting_Details_Date_Due_Main_From.T_D = "";
            this.Accounting_Details_Date_Due_Main_From.TabIndex = 273;
            //
            //Accounting_Details_Number_Due_Main_Until
            //
            this.Accounting_Details_Number_Due_Main_Until.BackColor = System.Drawing.Color.White;
            this.Accounting_Details_Number_Due_Main_Until.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Accounting_Details_Number_Due_Main_Until.Location = new System.Drawing.Point(226, 178);
            this.Accounting_Details_Number_Due_Main_Until.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Accounting_Details_Number_Due_Main_Until.MaxLength = 15;
            this.Accounting_Details_Number_Due_Main_Until.Name = "Accounting_Details_Number_Due_Main_Until";
            this.Accounting_Details_Number_Due_Main_Until.Size = new System.Drawing.Size(126, 30);
            this.Accounting_Details_Number_Due_Main_Until.TabIndex = 271;
            //
            //Label20
            //
            this.Label20.AutoSize = true;
            this.Label20.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label20.Location = new System.Drawing.Point(356, 184);
            this.Label20.Name = "Label20";
            this.Label20.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label20.Size = new System.Drawing.Size(144, 19);
            this.Label20.TabIndex = 272;
            this.Label20.Text = "تا شماره سررسید :";
            //
            //Accounting_Details_Number_Due_Main_From
            //
            this.Accounting_Details_Number_Due_Main_From.BackColor = System.Drawing.Color.White;
            this.Accounting_Details_Number_Due_Main_From.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Accounting_Details_Number_Due_Main_From.Location = new System.Drawing.Point(226, 138);
            this.Accounting_Details_Number_Due_Main_From.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Accounting_Details_Number_Due_Main_From.MaxLength = 15;
            this.Accounting_Details_Number_Due_Main_From.Name = "Accounting_Details_Number_Due_Main_From";
            this.Accounting_Details_Number_Due_Main_From.Size = new System.Drawing.Size(126, 30);
            this.Accounting_Details_Number_Due_Main_From.TabIndex = 269;
            //
            //Estehlak_Label
            //
            this.Estehlak_Label.AutoSize = true;
            this.Estehlak_Label.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Estehlak_Label.Location = new System.Drawing.Point(356, 145);
            this.Estehlak_Label.Name = "Estehlak_Label";
            this.Estehlak_Label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Estehlak_Label.Size = new System.Drawing.Size(140, 19);
            this.Estehlak_Label.TabIndex = 270;
            this.Estehlak_Label.Text = "از شماره سررسید:";
            //
            //Label19
            //
            this.Label19.AutoSize = true;
            this.Label19.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label19.Location = new System.Drawing.Point(606, 185);
            this.Label19.Name = "Label19";
            this.Label19.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label19.Size = new System.Drawing.Size(136, 19);
            this.Label19.TabIndex = 268;
            this.Label19.Text = "تا تاریخ ثبت هزینه :" + "\r" + "\n";
            this.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            //Accounting_Details_Date_Cost_Main_Until
            //
            this.Accounting_Details_Date_Cost_Main_Until.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Accounting_Details_Date_Cost_Main_Until.AutoSize = true;
            this.Accounting_Details_Date_Cost_Main_Until.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Accounting_Details_Date_Cost_Main_Until.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Accounting_Details_Date_Cost_Main_Until.Location = new System.Drawing.Point(503, 180);
            this.Accounting_Details_Date_Cost_Main_Until.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Accounting_Details_Date_Cost_Main_Until.Name = "Accounting_Details_Date_Cost_Main_Until";
            this.Accounting_Details_Date_Cost_Main_Until.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Accounting_Details_Date_Cost_Main_Until.Size = new System.Drawing.Size(136, 32);
            this.Accounting_Details_Date_Cost_Main_Until.T_D = "";
            this.Accounting_Details_Date_Cost_Main_Until.TabIndex = 267;
            //
            //Label18
            //
            this.Label18.AutoSize = true;
            this.Label18.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label18.Location = new System.Drawing.Point(607, 149);
            this.Label18.Name = "Label18";
            this.Label18.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label18.Size = new System.Drawing.Size(137, 19);
            this.Label18.TabIndex = 266;
            this.Label18.Text = "از تاریخ ثبت هزینه :" + "\r" + "\n";
            this.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            //Accounting_Details_Date_Cost_Main_From
            //
            this.Accounting_Details_Date_Cost_Main_From.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Accounting_Details_Date_Cost_Main_From.AutoSize = true;
            this.Accounting_Details_Date_Cost_Main_From.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Accounting_Details_Date_Cost_Main_From.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Accounting_Details_Date_Cost_Main_From.Location = new System.Drawing.Point(504, 144);
            this.Accounting_Details_Date_Cost_Main_From.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Accounting_Details_Date_Cost_Main_From.Name = "Accounting_Details_Date_Cost_Main_From";
            this.Accounting_Details_Date_Cost_Main_From.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Accounting_Details_Date_Cost_Main_From.Size = new System.Drawing.Size(136, 32);
            this.Accounting_Details_Date_Cost_Main_From.T_D = "";
            this.Accounting_Details_Date_Cost_Main_From.TabIndex = 265;
            //
            //B_Accounting_Details_Acc_Main_From
            //
            this.B_Accounting_Details_Acc_Main_From.Image = (System.Drawing.Image)resources.GetObject("B_Accounting_Details_Acc_Main_From.Image");
            this.B_Accounting_Details_Acc_Main_From.Location = new System.Drawing.Point(500, 15);
            this.B_Accounting_Details_Acc_Main_From.Name = "B_Accounting_Details_Acc_Main_From";
            this.B_Accounting_Details_Acc_Main_From.Size = new System.Drawing.Size(29, 27);
            this.B_Accounting_Details_Acc_Main_From.TabIndex = 258;
            this.B_Accounting_Details_Acc_Main_From.UseVisualStyleBackColor = true;
            //
            //Label13
            //
            this.Label13.AutoSize = true;
            this.Label13.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label13.Location = new System.Drawing.Point(641, 18);
            this.Label13.Name = "Label13";
            this.Label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label13.Size = new System.Drawing.Size(103, 19);
            this.Label13.TabIndex = 259;
            this.Label13.Text = "از کد حساب :";
            //
            //Accounting_Details_Description_Main
            //
            this.Accounting_Details_Description_Main.BackColor = System.Drawing.Color.White;
            this.Accounting_Details_Description_Main.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Accounting_Details_Description_Main.Location = new System.Drawing.Point(5, 101);
            this.Accounting_Details_Description_Main.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Accounting_Details_Description_Main.Name = "Accounting_Details_Description_Main";
            this.Accounting_Details_Description_Main.Size = new System.Drawing.Size(634, 27);
            this.Accounting_Details_Description_Main.TabIndex = 264;
            //
            //Accounting_Details_Acc_Main_From
            //
            this.Accounting_Details_Acc_Main_From.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Accounting_Details_Acc_Main_From.Location = new System.Drawing.Point(531, 13);
            this.Accounting_Details_Acc_Main_From.Name = "Accounting_Details_Acc_Main_From";
            this.Accounting_Details_Acc_Main_From.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Accounting_Details_Acc_Main_From.Size = new System.Drawing.Size(108, 31);
            this.Accounting_Details_Acc_Main_From.TabIndex = 257;
            //
            //Label6
            //
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label6.Location = new System.Drawing.Point(640, 104);
            this.Label6.Name = "Label6";
            this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label6.Size = new System.Drawing.Size(107, 19);
            this.Label6.TabIndex = 263;
            this.Label6.Text = "شرح عملیات :";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            //Label1
            //
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label1.Location = new System.Drawing.Point(642, 62);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label1.Size = new System.Drawing.Size(102, 19);
            this.Label1.TabIndex = 262;
            this.Label1.Text = "تا کد حساب :";
            //
            //Accounting_Details_Acc_Main_Until
            //
            this.Accounting_Details_Acc_Main_Until.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Accounting_Details_Acc_Main_Until.Location = new System.Drawing.Point(531, 57);
            this.Accounting_Details_Acc_Main_Until.Name = "Accounting_Details_Acc_Main_Until";
            this.Accounting_Details_Acc_Main_Until.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Accounting_Details_Acc_Main_Until.Size = new System.Drawing.Size(108, 31);
            this.Accounting_Details_Acc_Main_Until.TabIndex = 260;
            //
            //B_Accounting_Details_Acc_Main_Until
            //
            this.B_Accounting_Details_Acc_Main_Until.Image = (System.Drawing.Image)resources.GetObject("B_Accounting_Details_Acc_Main_Until.Image");
            this.B_Accounting_Details_Acc_Main_Until.Location = new System.Drawing.Point(500, 59);
            this.B_Accounting_Details_Acc_Main_Until.Name = "B_Accounting_Details_Acc_Main_Until";
            this.B_Accounting_Details_Acc_Main_Until.Size = new System.Drawing.Size(29, 27);
            this.B_Accounting_Details_Acc_Main_Until.TabIndex = 261;
            this.B_Accounting_Details_Acc_Main_Until.UseVisualStyleBackColor = true;
            //
            //GroupBox7
            //
            this.GroupBox7.Controls.Add(this.Label3);
            this.GroupBox7.Controls.Add(this.Label4);
            this.GroupBox7.Controls.Add(this.Accounting_Header_Description);
            this.GroupBox7.Controls.Add(this.Header_Number_From);
            this.GroupBox7.Controls.Add(this.Label21);
            this.GroupBox7.Controls.Add(this.Header_Number_Until);
            this.GroupBox7.Controls.Add(this.Label2);
//            this.GroupBox7.Controls.Add(this.Accounting_Header_Date_Until);
//            this.GroupBox7.Controls.Add(this.Accounting_Header_Date_From);
            this.GroupBox7.Controls.Add(this.GroupBox1);
            this.GroupBox7.Controls.Add(this.Label5);
            this.GroupBox7.Location = new System.Drawing.Point(6, 6);
            this.GroupBox7.Name = "GroupBox7";
            this.GroupBox7.Size = new System.Drawing.Size(747, 125);
            this.GroupBox7.TabIndex = 265;
            this.GroupBox7.TabStop = false;
            this.GroupBox7.Text = "مشخصات سند :";
            //
            //Label3
            //
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label3.Location = new System.Drawing.Point(427, 51);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label3.Size = new System.Drawing.Size(100, 19);
            this.Label3.TabIndex = 251;
            this.Label3.Text = "تا تاریخ سند :";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            //Label4
            //
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label4.Location = new System.Drawing.Point(427, 19);
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label4.Size = new System.Drawing.Size(101, 19);
            this.Label4.TabIndex = 253;
            this.Label4.Text = "از تاریخ سند :";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            //Accounting_Header_Description
            //
            this.Accounting_Header_Description.BackColor = System.Drawing.Color.White;
            this.Accounting_Header_Description.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Accounting_Header_Description.Location = new System.Drawing.Point(6, 89);
            this.Accounting_Header_Description.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Accounting_Header_Description.Name = "Accounting_Header_Description";
            this.Accounting_Header_Description.Size = new System.Drawing.Size(634, 27);
            this.Accounting_Header_Description.TabIndex = 255;
            //
            //Header_Number_From
            //
            this.Header_Number_From.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Header_Number_From.Location = new System.Drawing.Point(531, 17);
            this.Header_Number_From.Name = "Header_Number_From";
            this.Header_Number_From.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Header_Number_From.Size = new System.Drawing.Size(92, 26);
            this.Header_Number_From.TabIndex = 246;
            this.Header_Number_From.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            //
            //Label21
            //
            this.Label21.AutoSize = true;
            this.Label21.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label21.Location = new System.Drawing.Point(624, 20);
            this.Label21.Name = "Label21";
            this.Label21.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label21.Size = new System.Drawing.Size(116, 19);
            this.Label21.TabIndex = 247;
            this.Label21.Text = "از شماره سند :";
            this.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            //Header_Number_Until
            //
            this.Header_Number_Until.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Header_Number_Until.Location = new System.Drawing.Point(531, 49);
            this.Header_Number_Until.Name = "Header_Number_Until";
            this.Header_Number_Until.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Header_Number_Until.Size = new System.Drawing.Size(92, 26);
            this.Header_Number_Until.TabIndex = 248;
            this.Header_Number_Until.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            //
            //Label2
            //
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label2.Location = new System.Drawing.Point(624, 52);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label2.Size = new System.Drawing.Size(115, 19);
            this.Label2.TabIndex = 249;
            this.Label2.Text = "تا شماره سند :";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            //Accounting_Header_Date_Until
            //
            this.Accounting_Header_Date_Until.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Accounting_Header_Date_Until.AutoSize = true;
            this.Accounting_Header_Date_Until.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Accounting_Header_Date_Until.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Accounting_Header_Date_Until.Location = new System.Drawing.Point(322, 49);
            this.Accounting_Header_Date_Until.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Accounting_Header_Date_Until.Name = "Accounting_Header_Date_Until";
            this.Accounting_Header_Date_Until.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Accounting_Header_Date_Until.Size = new System.Drawing.Size(136, 32);
            this.Accounting_Header_Date_Until.T_D = "";
            this.Accounting_Header_Date_Until.TabIndex = 250;
            //
            //Accounting_Header_Date_From
            //
            this.Accounting_Header_Date_From.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Accounting_Header_Date_From.AutoSize = true;
            this.Accounting_Header_Date_From.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Accounting_Header_Date_From.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Accounting_Header_Date_From.Location = new System.Drawing.Point(322, 17);
            this.Accounting_Header_Date_From.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Accounting_Header_Date_From.Name = "Accounting_Header_Date_From";
            this.Accounting_Header_Date_From.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Accounting_Header_Date_From.Size = new System.Drawing.Size(136, 32);
            this.Accounting_Header_Date_From.T_D = "";
            this.Accounting_Header_Date_From.TabIndex = 252;
            //
            //GroupBox1
            //
            this.GroupBox1.Controls.Add(this.Accounting_Header_Class_4);
            this.GroupBox1.Controls.Add(this.Accounting_Header_Class_3);
            this.GroupBox1.Controls.Add(this.Accounting_Header_Class_5);
            this.GroupBox1.Controls.Add(this.Accounting_Header_Class_2);
            this.GroupBox1.Controls.Add(this.Accounting_Header_Class_1);
            this.GroupBox1.Controls.Add(this.Accounting_Header_Class_0);
            this.GroupBox1.Location = new System.Drawing.Point(5, 7);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(314, 74);
            this.GroupBox1.TabIndex = 256;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "نوع سند :";
            //
            //Accounting_Header_Class_4
            //
            this.Accounting_Header_Class_4.AutoSize = true;
            this.Accounting_Header_Class_4.Location = new System.Drawing.Point(112, 45);
            this.Accounting_Header_Class_4.Name = "Accounting_Header_Class_4";
            this.Accounting_Header_Class_4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Accounting_Header_Class_4.Size = new System.Drawing.Size(84, 17);
            this.Accounting_Header_Class_4.TabIndex = 5;
            this.Accounting_Header_Class_4.Text = "ســود و زیان";
            this.Accounting_Header_Class_4.UseVisualStyleBackColor = true;
            //
            //Accounting_Header_Class_3
            //
            this.Accounting_Header_Class_3.AutoSize = true;
            this.Accounting_Header_Class_3.Location = new System.Drawing.Point(220, 47);
            this.Accounting_Header_Class_3.Name = "Accounting_Header_Class_3";
            this.Accounting_Header_Class_3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Accounting_Header_Class_3.Size = new System.Drawing.Size(81, 17);
            this.Accounting_Header_Class_3.TabIndex = 4;
            this.Accounting_Header_Class_3.Text = "بستن حساب";
            this.Accounting_Header_Class_3.UseVisualStyleBackColor = true;
            //
            //Accounting_Header_Class_5
            //
            this.Accounting_Header_Class_5.AutoSize = true;
            this.Accounting_Header_Class_5.Location = new System.Drawing.Point(18, 47);
            this.Accounting_Header_Class_5.Name = "Accounting_Header_Class_5";
            this.Accounting_Header_Class_5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Accounting_Header_Class_5.Size = new System.Drawing.Size(62, 17);
            this.Accounting_Header_Class_5.TabIndex = 3;
            this.Accounting_Header_Class_5.Text = "اختتامیه";
            this.Accounting_Header_Class_5.UseVisualStyleBackColor = true;
            //
            //Accounting_Header_Class_2
            //
            this.Accounting_Header_Class_2.AutoSize = true;
            this.Accounting_Header_Class_2.Location = new System.Drawing.Point(17, 19);
            this.Accounting_Header_Class_2.Name = "Accounting_Header_Class_2";
            this.Accounting_Header_Class_2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Accounting_Header_Class_2.Size = new System.Drawing.Size(63, 17);
            this.Accounting_Header_Class_2.TabIndex = 2;
            this.Accounting_Header_Class_2.Text = "افتتاحیه";
            this.Accounting_Header_Class_2.UseVisualStyleBackColor = true;
            //
            //Accounting_Header_Class_1
            //
            this.Accounting_Header_Class_1.AutoSize = true;
            this.Accounting_Header_Class_1.Location = new System.Drawing.Point(115, 19);
            this.Accounting_Header_Class_1.Name = "Accounting_Header_Class_1";
            this.Accounting_Header_Class_1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Accounting_Header_Class_1.Size = new System.Drawing.Size(81, 17);
            this.Accounting_Header_Class_1.TabIndex = 1;
            this.Accounting_Header_Class_1.Text = "پــیــش نویس";
            this.Accounting_Header_Class_1.UseVisualStyleBackColor = true;
            //
            //Accounting_Header_Class_0
            //
            this.Accounting_Header_Class_0.AutoSize = true;
            this.Accounting_Header_Class_0.Location = new System.Drawing.Point(221, 19);
            this.Accounting_Header_Class_0.Name = "Accounting_Header_Class_0";
            this.Accounting_Header_Class_0.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Accounting_Header_Class_0.Size = new System.Drawing.Size(79, 17);
            this.Accounting_Header_Class_0.TabIndex = 0;
            this.Accounting_Header_Class_0.Text = "عـــــــــادی";
            this.Accounting_Header_Class_0.UseVisualStyleBackColor = true;
            //
            //Label5
            //
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label5.Location = new System.Drawing.Point(643, 92);
            this.Label5.Name = "Label5";
            this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label5.Size = new System.Drawing.Size(89, 19);
            this.Label5.TabIndex = 254;
            this.Label5.Text = "شرح سند :";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            //TabPage2
            //
            this.TabPage2.Controls.Add(this.GroupBox6);
            this.TabPage2.Controls.Add(this.GroupBox5);
            this.TabPage2.Controls.Add(this.GroupBox4);
            this.TabPage2.Controls.Add(this.GroupBox3);
            this.TabPage2.Controls.Add(this.GroupBox2);
            this.TabPage2.Location = new System.Drawing.Point(4, 22);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(756, 434);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "کد تفصیلی";
            this.TabPage2.UseVisualStyleBackColor = true;
            //
            //GroupBox6
            //
            this.GroupBox6.Controls.Add(this.L_Accounting_Details_Detailed_Five_Main_From);
            this.GroupBox6.Controls.Add(this.L_Accounting_Details_Detailed_Five_Main_Until);
            this.GroupBox6.Controls.Add(this.Accounting_Details_Detailed_Five_Main_Until);
            this.GroupBox6.Controls.Add(this.B_Accounting_Details_Detailed_Five_Main_Until);
            this.GroupBox6.Controls.Add(this.Label16);
            this.GroupBox6.Controls.Add(this.Accounting_Details_Detailed_Five_Main_From);
            this.GroupBox6.Controls.Add(this.B_Accounting_Details_Detailed_Five_Main_From);
            this.GroupBox6.Controls.Add(this.Label17);
            this.GroupBox6.Location = new System.Drawing.Point(8, 342);
            this.GroupBox6.Name = "GroupBox6";
            this.GroupBox6.Size = new System.Drawing.Size(742, 85);
            this.GroupBox6.TabIndex = 269;
            this.GroupBox6.TabStop = false;
            this.GroupBox6.Text = "تفصیلی 5 :";
            //
            //L_Accounting_Details_Detailed_Five_Main_From
            //
            this.L_Accounting_Details_Detailed_Five_Main_From.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.L_Accounting_Details_Detailed_Five_Main_From.ForeColor = System.Drawing.Color.FromArgb((int)((byte)0), (int)((byte)192), (int)((byte)0));
            this.L_Accounting_Details_Detailed_Five_Main_From.Location = new System.Drawing.Point(6, 19);
            this.L_Accounting_Details_Detailed_Five_Main_From.Name = "L_Accounting_Details_Detailed_Five_Main_From";
            this.L_Accounting_Details_Detailed_Five_Main_From.Size = new System.Drawing.Size(464, 19);
            this.L_Accounting_Details_Detailed_Five_Main_From.TabIndex = 301;
            this.L_Accounting_Details_Detailed_Five_Main_From.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            //L_Accounting_Details_Detailed_Five_Main_Until
            //
            this.L_Accounting_Details_Detailed_Five_Main_Until.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.L_Accounting_Details_Detailed_Five_Main_Until.ForeColor = System.Drawing.Color.FromArgb((int)((byte)0), (int)((byte)192), (int)((byte)0));
            this.L_Accounting_Details_Detailed_Five_Main_Until.Location = new System.Drawing.Point(5, 54);
            this.L_Accounting_Details_Detailed_Five_Main_Until.Name = "L_Accounting_Details_Detailed_Five_Main_Until";
            this.L_Accounting_Details_Detailed_Five_Main_Until.Size = new System.Drawing.Size(464, 19);
            this.L_Accounting_Details_Detailed_Five_Main_Until.TabIndex = 300;
            this.L_Accounting_Details_Detailed_Five_Main_Until.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            //Accounting_Details_Detailed_Five_Main_Until
            //
            this.Accounting_Details_Detailed_Five_Main_Until.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Accounting_Details_Detailed_Five_Main_Until.Location = new System.Drawing.Point(506, 48);
            this.Accounting_Details_Detailed_Five_Main_Until.Name = "Accounting_Details_Detailed_Five_Main_Until";
            this.Accounting_Details_Detailed_Five_Main_Until.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Accounting_Details_Detailed_Five_Main_Until.Size = new System.Drawing.Size(123, 31);
            this.Accounting_Details_Detailed_Five_Main_Until.TabIndex = 263;
            //
            //B_Accounting_Details_Detailed_Five_Main_Until
            //
            this.B_Accounting_Details_Detailed_Five_Main_Until.Image = (System.Drawing.Image)resources.GetObject("B_Accounting_Details_Detailed_Five_Main_Until.Image");
            this.B_Accounting_Details_Detailed_Five_Main_Until.Location = new System.Drawing.Point(476, 50);
            this.B_Accounting_Details_Detailed_Five_Main_Until.Name = "B_Accounting_Details_Detailed_Five_Main_Until";
            this.B_Accounting_Details_Detailed_Five_Main_Until.Size = new System.Drawing.Size(29, 27);
            this.B_Accounting_Details_Detailed_Five_Main_Until.TabIndex = 264;
            this.B_Accounting_Details_Detailed_Five_Main_Until.UseVisualStyleBackColor = true;
            //
            //Label16
            //
            this.Label16.AutoSize = true;
            this.Label16.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label16.Location = new System.Drawing.Point(630, 53);
            this.Label16.Name = "Label16";
            this.Label16.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label16.Size = new System.Drawing.Size(108, 19);
            this.Label16.TabIndex = 265;
            this.Label16.Text = "تا کد تفصیلی :";
            //
            //Accounting_Details_Detailed_Five_Main_From
            //
            this.Accounting_Details_Detailed_Five_Main_From.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Accounting_Details_Detailed_Five_Main_From.Location = new System.Drawing.Point(506, 13);
            this.Accounting_Details_Detailed_Five_Main_From.Name = "Accounting_Details_Detailed_Five_Main_From";
            this.Accounting_Details_Detailed_Five_Main_From.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Accounting_Details_Detailed_Five_Main_From.Size = new System.Drawing.Size(122, 31);
            this.Accounting_Details_Detailed_Five_Main_From.TabIndex = 260;
            //
            //B_Accounting_Details_Detailed_Five_Main_From
            //
            this.B_Accounting_Details_Detailed_Five_Main_From.Image = (System.Drawing.Image)resources.GetObject("B_Accounting_Details_Detailed_Five_Main_From.Image");
            this.B_Accounting_Details_Detailed_Five_Main_From.Location = new System.Drawing.Point(476, 15);
            this.B_Accounting_Details_Detailed_Five_Main_From.Name = "B_Accounting_Details_Detailed_Five_Main_From";
            this.B_Accounting_Details_Detailed_Five_Main_From.Size = new System.Drawing.Size(29, 27);
            this.B_Accounting_Details_Detailed_Five_Main_From.TabIndex = 261;
            this.B_Accounting_Details_Detailed_Five_Main_From.UseVisualStyleBackColor = true;
            //
            //Label17
            //
            this.Label17.AutoSize = true;
            this.Label17.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label17.Location = new System.Drawing.Point(629, 18);
            this.Label17.Name = "Label17";
            this.Label17.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label17.Size = new System.Drawing.Size(109, 19);
            this.Label17.TabIndex = 262;
            this.Label17.Text = "از کد تفصیلی :";
            //
            //GroupBox5
            //
            this.GroupBox5.Controls.Add(this.L_Accounting_Details_Detailed_Four_Main_From);
            this.GroupBox5.Controls.Add(this.L_Accounting_Details_Detailed_Four_Main_Until);
            this.GroupBox5.Controls.Add(this.Accounting_Details_Detailed_Four_Main_Until);
            this.GroupBox5.Controls.Add(this.B_Accounting_Details_Detailed_Four_Main_Until);
            this.GroupBox5.Controls.Add(this.Label14);
            this.GroupBox5.Controls.Add(this.Accounting_Details_Detailed_Four_Main_From);
            this.GroupBox5.Controls.Add(this.B_Accounting_Details_Detailed_Four_Main_From);
            this.GroupBox5.Controls.Add(this.Label15);
            this.GroupBox5.Location = new System.Drawing.Point(8, 258);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Size = new System.Drawing.Size(742, 85);
            this.GroupBox5.TabIndex = 268;
            this.GroupBox5.TabStop = false;
            this.GroupBox5.Text = "تفصیلی 4 :";
            //
            //L_Accounting_Details_Detailed_Four_Main_From
            //
            this.L_Accounting_Details_Detailed_Four_Main_From.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.L_Accounting_Details_Detailed_Four_Main_From.ForeColor = System.Drawing.Color.FromArgb((int)((byte)0), (int)((byte)192), (int)((byte)0));
            this.L_Accounting_Details_Detailed_Four_Main_From.Location = new System.Drawing.Point(5, 19);
            this.L_Accounting_Details_Detailed_Four_Main_From.Name = "L_Accounting_Details_Detailed_Four_Main_From";
            this.L_Accounting_Details_Detailed_Four_Main_From.Size = new System.Drawing.Size(464, 19);
            this.L_Accounting_Details_Detailed_Four_Main_From.TabIndex = 301;
            this.L_Accounting_Details_Detailed_Four_Main_From.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            //L_Accounting_Details_Detailed_Four_Main_Until
            //
            this.L_Accounting_Details_Detailed_Four_Main_Until.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.L_Accounting_Details_Detailed_Four_Main_Until.ForeColor = System.Drawing.Color.FromArgb((int)((byte)0), (int)((byte)192), (int)((byte)0));
            this.L_Accounting_Details_Detailed_Four_Main_Until.Location = new System.Drawing.Point(6, 54);
            this.L_Accounting_Details_Detailed_Four_Main_Until.Name = "L_Accounting_Details_Detailed_Four_Main_Until";
            this.L_Accounting_Details_Detailed_Four_Main_Until.Size = new System.Drawing.Size(464, 19);
            this.L_Accounting_Details_Detailed_Four_Main_Until.TabIndex = 300;
            this.L_Accounting_Details_Detailed_Four_Main_Until.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            //Accounting_Details_Detailed_Four_Main_Until
            //
            this.Accounting_Details_Detailed_Four_Main_Until.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Accounting_Details_Detailed_Four_Main_Until.Location = new System.Drawing.Point(506, 48);
            this.Accounting_Details_Detailed_Four_Main_Until.Name = "Accounting_Details_Detailed_Four_Main_Until";
            this.Accounting_Details_Detailed_Four_Main_Until.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Accounting_Details_Detailed_Four_Main_Until.Size = new System.Drawing.Size(123, 31);
            this.Accounting_Details_Detailed_Four_Main_Until.TabIndex = 263;
            //
            //B_Accounting_Details_Detailed_Four_Main_Until
            //
            this.B_Accounting_Details_Detailed_Four_Main_Until.Image = (System.Drawing.Image)resources.GetObject("B_Accounting_Details_Detailed_Four_Main_Until.Image");
            this.B_Accounting_Details_Detailed_Four_Main_Until.Location = new System.Drawing.Point(476, 50);
            this.B_Accounting_Details_Detailed_Four_Main_Until.Name = "B_Accounting_Details_Detailed_Four_Main_Until";
            this.B_Accounting_Details_Detailed_Four_Main_Until.Size = new System.Drawing.Size(29, 27);
            this.B_Accounting_Details_Detailed_Four_Main_Until.TabIndex = 264;
            this.B_Accounting_Details_Detailed_Four_Main_Until.UseVisualStyleBackColor = true;
            //
            //Label14
            //
            this.Label14.AutoSize = true;
            this.Label14.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label14.Location = new System.Drawing.Point(630, 53);
            this.Label14.Name = "Label14";
            this.Label14.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label14.Size = new System.Drawing.Size(108, 19);
            this.Label14.TabIndex = 265;
            this.Label14.Text = "تا کد تفصیلی :";
            //
            //Accounting_Details_Detailed_Four_Main_From
            //
            this.Accounting_Details_Detailed_Four_Main_From.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Accounting_Details_Detailed_Four_Main_From.Location = new System.Drawing.Point(506, 13);
            this.Accounting_Details_Detailed_Four_Main_From.Name = "Accounting_Details_Detailed_Four_Main_From";
            this.Accounting_Details_Detailed_Four_Main_From.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Accounting_Details_Detailed_Four_Main_From.Size = new System.Drawing.Size(122, 31);
            this.Accounting_Details_Detailed_Four_Main_From.TabIndex = 260;
            //
            //B_Accounting_Details_Detailed_Four_Main_From
            //
            this.B_Accounting_Details_Detailed_Four_Main_From.Image = (System.Drawing.Image)resources.GetObject("B_Accounting_Details_Detailed_Four_Main_From.Image");
            this.B_Accounting_Details_Detailed_Four_Main_From.Location = new System.Drawing.Point(476, 15);
            this.B_Accounting_Details_Detailed_Four_Main_From.Name = "B_Accounting_Details_Detailed_Four_Main_From";
            this.B_Accounting_Details_Detailed_Four_Main_From.Size = new System.Drawing.Size(29, 27);
            this.B_Accounting_Details_Detailed_Four_Main_From.TabIndex = 261;
            this.B_Accounting_Details_Detailed_Four_Main_From.UseVisualStyleBackColor = true;
            //
            //Label15
            //
            this.Label15.AutoSize = true;
            this.Label15.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label15.Location = new System.Drawing.Point(629, 18);
            this.Label15.Name = "Label15";
            this.Label15.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label15.Size = new System.Drawing.Size(109, 19);
            this.Label15.TabIndex = 262;
            this.Label15.Text = "از کد تفصیلی :";
            //
            //GroupBox4
            //
            this.GroupBox4.Controls.Add(this.L_Accounting_Details_Detailed_Three_Main_From);
            this.GroupBox4.Controls.Add(this.L_Accounting_Details_Detailed_Three_Main_Until);
            this.GroupBox4.Controls.Add(this.Accounting_Details_Detailed_Three_Main_Until);
            this.GroupBox4.Controls.Add(this.B_Accounting_Details_Detailed_Three_Main_Until);
            this.GroupBox4.Controls.Add(this.Label11);
            this.GroupBox4.Controls.Add(this.Accounting_Details_Detailed_Three_Main_From);
            this.GroupBox4.Controls.Add(this.B_Accounting_Details_Detailed_Three_Main_From);
            this.GroupBox4.Controls.Add(this.Label12);
            this.GroupBox4.Location = new System.Drawing.Point(8, 174);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(742, 85);
            this.GroupBox4.TabIndex = 267;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "تفصیلی 3 :";
            //
            //L_Accounting_Details_Detailed_Three_Main_From
            //
            this.L_Accounting_Details_Detailed_Three_Main_From.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.L_Accounting_Details_Detailed_Three_Main_From.ForeColor = System.Drawing.Color.FromArgb((int)((byte)0), (int)((byte)192), (int)((byte)0));
            this.L_Accounting_Details_Detailed_Three_Main_From.Location = new System.Drawing.Point(6, 20);
            this.L_Accounting_Details_Detailed_Three_Main_From.Name = "L_Accounting_Details_Detailed_Three_Main_From";
            this.L_Accounting_Details_Detailed_Three_Main_From.Size = new System.Drawing.Size(464, 19);
            this.L_Accounting_Details_Detailed_Three_Main_From.TabIndex = 301;
            this.L_Accounting_Details_Detailed_Three_Main_From.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            //L_Accounting_Details_Detailed_Three_Main_Until
            //
            this.L_Accounting_Details_Detailed_Three_Main_Until.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.L_Accounting_Details_Detailed_Three_Main_Until.ForeColor = System.Drawing.Color.FromArgb((int)((byte)0), (int)((byte)192), (int)((byte)0));
            this.L_Accounting_Details_Detailed_Three_Main_Until.Location = new System.Drawing.Point(6, 55);
            this.L_Accounting_Details_Detailed_Three_Main_Until.Name = "L_Accounting_Details_Detailed_Three_Main_Until";
            this.L_Accounting_Details_Detailed_Three_Main_Until.Size = new System.Drawing.Size(464, 19);
            this.L_Accounting_Details_Detailed_Three_Main_Until.TabIndex = 300;
            this.L_Accounting_Details_Detailed_Three_Main_Until.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            //Accounting_Details_Detailed_Three_Main_Until
            //
            this.Accounting_Details_Detailed_Three_Main_Until.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Accounting_Details_Detailed_Three_Main_Until.Location = new System.Drawing.Point(506, 48);
            this.Accounting_Details_Detailed_Three_Main_Until.Name = "Accounting_Details_Detailed_Three_Main_Until";
            this.Accounting_Details_Detailed_Three_Main_Until.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Accounting_Details_Detailed_Three_Main_Until.Size = new System.Drawing.Size(123, 31);
            this.Accounting_Details_Detailed_Three_Main_Until.TabIndex = 263;
            //
            //B_Accounting_Details_Detailed_Three_Main_Until
            //
            this.B_Accounting_Details_Detailed_Three_Main_Until.Image = (System.Drawing.Image)resources.GetObject("B_Accounting_Details_Detailed_Three_Main_Until.Image");
            this.B_Accounting_Details_Detailed_Three_Main_Until.Location = new System.Drawing.Point(476, 50);
            this.B_Accounting_Details_Detailed_Three_Main_Until.Name = "B_Accounting_Details_Detailed_Three_Main_Until";
            this.B_Accounting_Details_Detailed_Three_Main_Until.Size = new System.Drawing.Size(29, 27);
            this.B_Accounting_Details_Detailed_Three_Main_Until.TabIndex = 264;
            this.B_Accounting_Details_Detailed_Three_Main_Until.UseVisualStyleBackColor = true;
            //
            //Label11
            //
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label11.Location = new System.Drawing.Point(630, 53);
            this.Label11.Name = "Label11";
            this.Label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label11.Size = new System.Drawing.Size(108, 19);
            this.Label11.TabIndex = 265;
            this.Label11.Text = "تا کد تفصیلی :";
            //
            //Accounting_Details_Detailed_Three_Main_From
            //
            this.Accounting_Details_Detailed_Three_Main_From.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Accounting_Details_Detailed_Three_Main_From.Location = new System.Drawing.Point(506, 13);
            this.Accounting_Details_Detailed_Three_Main_From.Name = "Accounting_Details_Detailed_Three_Main_From";
            this.Accounting_Details_Detailed_Three_Main_From.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Accounting_Details_Detailed_Three_Main_From.Size = new System.Drawing.Size(122, 31);
            this.Accounting_Details_Detailed_Three_Main_From.TabIndex = 260;
            //
            //B_Accounting_Details_Detailed_Three_Main_From
            //
            this.B_Accounting_Details_Detailed_Three_Main_From.Image = (System.Drawing.Image)resources.GetObject("B_Accounting_Details_Detailed_Three_Main_From.Image");
            this.B_Accounting_Details_Detailed_Three_Main_From.Location = new System.Drawing.Point(476, 15);
            this.B_Accounting_Details_Detailed_Three_Main_From.Name = "B_Accounting_Details_Detailed_Three_Main_From";
            this.B_Accounting_Details_Detailed_Three_Main_From.Size = new System.Drawing.Size(29, 27);
            this.B_Accounting_Details_Detailed_Three_Main_From.TabIndex = 261;
            this.B_Accounting_Details_Detailed_Three_Main_From.UseVisualStyleBackColor = true;
            //
            //Label12
            //
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label12.Location = new System.Drawing.Point(629, 18);
            this.Label12.Name = "Label12";
            this.Label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label12.Size = new System.Drawing.Size(109, 19);
            this.Label12.TabIndex = 262;
            this.Label12.Text = "از کد تفصیلی :";
            //
            //GroupBox3
            //
            this.GroupBox3.Controls.Add(this.L_Accounting_Details_Detailed_Two_Main_From);
            this.GroupBox3.Controls.Add(this.L_Accounting_Details_Detailed_Two_Main_Until);
            this.GroupBox3.Controls.Add(this.Accounting_Details_Detailed_Two_Main_Until);
            this.GroupBox3.Controls.Add(this.B_Accounting_Details_Detailed_Two_Main_Until);
            this.GroupBox3.Controls.Add(this.Label9);
            this.GroupBox3.Controls.Add(this.Accounting_Details_Detailed_Two_Main_From);
            this.GroupBox3.Controls.Add(this.B_Accounting_Details_Detailed_Two_Main_From);
            this.GroupBox3.Controls.Add(this.Label10);
            this.GroupBox3.Location = new System.Drawing.Point(8, 90);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(742, 85);
            this.GroupBox3.TabIndex = 266;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "تفصیلی 2 :";
            //
            //L_Accounting_Details_Detailed_Two_Main_From
            //
            this.L_Accounting_Details_Detailed_Two_Main_From.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.L_Accounting_Details_Detailed_Two_Main_From.ForeColor = System.Drawing.Color.FromArgb((int)((byte)0), (int)((byte)192), (int)((byte)0));
            this.L_Accounting_Details_Detailed_Two_Main_From.Location = new System.Drawing.Point(6, 20);
            this.L_Accounting_Details_Detailed_Two_Main_From.Name = "L_Accounting_Details_Detailed_Two_Main_From";
            this.L_Accounting_Details_Detailed_Two_Main_From.Size = new System.Drawing.Size(464, 19);
            this.L_Accounting_Details_Detailed_Two_Main_From.TabIndex = 301;
            this.L_Accounting_Details_Detailed_Two_Main_From.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            //L_Accounting_Details_Detailed_Two_Main_Until
            //
            this.L_Accounting_Details_Detailed_Two_Main_Until.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.L_Accounting_Details_Detailed_Two_Main_Until.ForeColor = System.Drawing.Color.FromArgb((int)((byte)0), (int)((byte)192), (int)((byte)0));
            this.L_Accounting_Details_Detailed_Two_Main_Until.Location = new System.Drawing.Point(6, 54);
            this.L_Accounting_Details_Detailed_Two_Main_Until.Name = "L_Accounting_Details_Detailed_Two_Main_Until";
            this.L_Accounting_Details_Detailed_Two_Main_Until.Size = new System.Drawing.Size(464, 19);
            this.L_Accounting_Details_Detailed_Two_Main_Until.TabIndex = 300;
            this.L_Accounting_Details_Detailed_Two_Main_Until.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            //Accounting_Details_Detailed_Two_Main_Until
            //
            this.Accounting_Details_Detailed_Two_Main_Until.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Accounting_Details_Detailed_Two_Main_Until.Location = new System.Drawing.Point(506, 48);
            this.Accounting_Details_Detailed_Two_Main_Until.Name = "Accounting_Details_Detailed_Two_Main_Until";
            this.Accounting_Details_Detailed_Two_Main_Until.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Accounting_Details_Detailed_Two_Main_Until.Size = new System.Drawing.Size(123, 31);
            this.Accounting_Details_Detailed_Two_Main_Until.TabIndex = 263;
            //
            //B_Accounting_Details_Detailed_Two_Main_Until
            //
            this.B_Accounting_Details_Detailed_Two_Main_Until.Image = (System.Drawing.Image)resources.GetObject("B_Accounting_Details_Detailed_Two_Main_Until.Image");
            this.B_Accounting_Details_Detailed_Two_Main_Until.Location = new System.Drawing.Point(476, 50);
            this.B_Accounting_Details_Detailed_Two_Main_Until.Name = "B_Accounting_Details_Detailed_Two_Main_Until";
            this.B_Accounting_Details_Detailed_Two_Main_Until.Size = new System.Drawing.Size(29, 27);
            this.B_Accounting_Details_Detailed_Two_Main_Until.TabIndex = 264;
            this.B_Accounting_Details_Detailed_Two_Main_Until.UseVisualStyleBackColor = true;
            //
            //Label9
            //
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label9.Location = new System.Drawing.Point(630, 53);
            this.Label9.Name = "Label9";
            this.Label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label9.Size = new System.Drawing.Size(108, 19);
            this.Label9.TabIndex = 265;
            this.Label9.Text = "تا کد تفصیلی :";
            //
            //Accounting_Details_Detailed_Two_Main_From
            //
            this.Accounting_Details_Detailed_Two_Main_From.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Accounting_Details_Detailed_Two_Main_From.Location = new System.Drawing.Point(506, 13);
            this.Accounting_Details_Detailed_Two_Main_From.Name = "Accounting_Details_Detailed_Two_Main_From";
            this.Accounting_Details_Detailed_Two_Main_From.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Accounting_Details_Detailed_Two_Main_From.Size = new System.Drawing.Size(122, 31);
            this.Accounting_Details_Detailed_Two_Main_From.TabIndex = 260;
            //
            //B_Accounting_Details_Detailed_Two_Main_From
            //
            this.B_Accounting_Details_Detailed_Two_Main_From.Image = (System.Drawing.Image)resources.GetObject("B_Accounting_Details_Detailed_Two_Main_From.Image");
            this.B_Accounting_Details_Detailed_Two_Main_From.Location = new System.Drawing.Point(476, 15);
            this.B_Accounting_Details_Detailed_Two_Main_From.Name = "B_Accounting_Details_Detailed_Two_Main_From";
            this.B_Accounting_Details_Detailed_Two_Main_From.Size = new System.Drawing.Size(29, 27);
            this.B_Accounting_Details_Detailed_Two_Main_From.TabIndex = 261;
            this.B_Accounting_Details_Detailed_Two_Main_From.UseVisualStyleBackColor = true;
            //
            //Label10
            //
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label10.Location = new System.Drawing.Point(629, 18);
            this.Label10.Name = "Label10";
            this.Label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label10.Size = new System.Drawing.Size(109, 19);
            this.Label10.TabIndex = 262;
            this.Label10.Text = "از کد تفصیلی :";
            //
            //GroupBox2
            //
            this.GroupBox2.Controls.Add(this.L_Accounting_Details_Detailed_One_Main_Until);
            this.GroupBox2.Controls.Add(this.L_Accounting_Details_Detailed_One_Main_From);
            this.GroupBox2.Controls.Add(this.Accounting_Details_Detailed_One_Main_Until);
            this.GroupBox2.Controls.Add(this.B_Accounting_Details_Detailed_One_Main_Until);
            this.GroupBox2.Controls.Add(this.Label8);
            this.GroupBox2.Controls.Add(this.Accounting_Details_Detailed_One_Main_From);
            this.GroupBox2.Controls.Add(this.B_Accounting_Details_Detailed_One_Main_From);
            this.GroupBox2.Controls.Add(this.Label7);
            this.GroupBox2.Location = new System.Drawing.Point(8, 6);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(742, 85);
            this.GroupBox2.TabIndex = 0;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "تفصیلی 1 :";
            //
            //L_Accounting_Details_Detailed_One_Main_Until
            //
            this.L_Accounting_Details_Detailed_One_Main_Until.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.L_Accounting_Details_Detailed_One_Main_Until.ForeColor = System.Drawing.Color.FromArgb((int)((byte)0), (int)((byte)192), (int)((byte)0));
            this.L_Accounting_Details_Detailed_One_Main_Until.Location = new System.Drawing.Point(6, 53);
            this.L_Accounting_Details_Detailed_One_Main_Until.Name = "L_Accounting_Details_Detailed_One_Main_Until";
            this.L_Accounting_Details_Detailed_One_Main_Until.Size = new System.Drawing.Size(464, 19);
            this.L_Accounting_Details_Detailed_One_Main_Until.TabIndex = 299;
            this.L_Accounting_Details_Detailed_One_Main_Until.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            //L_Accounting_Details_Detailed_One_Main_From
            //
            this.L_Accounting_Details_Detailed_One_Main_From.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.L_Accounting_Details_Detailed_One_Main_From.ForeColor = System.Drawing.Color.FromArgb((int)((byte)0), (int)((byte)192), (int)((byte)0));
            this.L_Accounting_Details_Detailed_One_Main_From.Location = new System.Drawing.Point(6, 20);
            this.L_Accounting_Details_Detailed_One_Main_From.Name = "L_Accounting_Details_Detailed_One_Main_From";
            this.L_Accounting_Details_Detailed_One_Main_From.Size = new System.Drawing.Size(464, 19);
            this.L_Accounting_Details_Detailed_One_Main_From.TabIndex = 298;
            this.L_Accounting_Details_Detailed_One_Main_From.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            //Accounting_Details_Detailed_One_Main_Until
            //
            this.Accounting_Details_Detailed_One_Main_Until.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Accounting_Details_Detailed_One_Main_Until.Location = new System.Drawing.Point(506, 48);
            this.Accounting_Details_Detailed_One_Main_Until.Name = "Accounting_Details_Detailed_One_Main_Until";
            this.Accounting_Details_Detailed_One_Main_Until.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Accounting_Details_Detailed_One_Main_Until.Size = new System.Drawing.Size(123, 31);
            this.Accounting_Details_Detailed_One_Main_Until.TabIndex = 263;
            //
            //B_Accounting_Details_Detailed_One_Main_Until
            //
            this.B_Accounting_Details_Detailed_One_Main_Until.Image = (System.Drawing.Image)resources.GetObject("B_Accounting_Details_Detailed_One_Main_Until.Image");
            this.B_Accounting_Details_Detailed_One_Main_Until.Location = new System.Drawing.Point(476, 50);
            this.B_Accounting_Details_Detailed_One_Main_Until.Name = "B_Accounting_Details_Detailed_One_Main_Until";
            this.B_Accounting_Details_Detailed_One_Main_Until.Size = new System.Drawing.Size(29, 27);
            this.B_Accounting_Details_Detailed_One_Main_Until.TabIndex = 264;
            this.B_Accounting_Details_Detailed_One_Main_Until.UseVisualStyleBackColor = true;
            //
            //Label8
            //
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label8.Location = new System.Drawing.Point(630, 53);
            this.Label8.Name = "Label8";
            this.Label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label8.Size = new System.Drawing.Size(108, 19);
            this.Label8.TabIndex = 265;
            this.Label8.Text = "تا کد تفصیلی :";
            //
            //Accounting_Details_Detailed_One_Main_From
            //
            this.Accounting_Details_Detailed_One_Main_From.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Accounting_Details_Detailed_One_Main_From.Location = new System.Drawing.Point(506, 13);
            this.Accounting_Details_Detailed_One_Main_From.Name = "Accounting_Details_Detailed_One_Main_From";
            this.Accounting_Details_Detailed_One_Main_From.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Accounting_Details_Detailed_One_Main_From.Size = new System.Drawing.Size(122, 31);
            this.Accounting_Details_Detailed_One_Main_From.TabIndex = 260;
            //
            //B_Accounting_Details_Detailed_One_Main_From
            //
            this.B_Accounting_Details_Detailed_One_Main_From.Image = (System.Drawing.Image)resources.GetObject("B_Accounting_Details_Detailed_One_Main_From.Image");
            this.B_Accounting_Details_Detailed_One_Main_From.Location = new System.Drawing.Point(476, 16);
            this.B_Accounting_Details_Detailed_One_Main_From.Name = "B_Accounting_Details_Detailed_One_Main_From";
            this.B_Accounting_Details_Detailed_One_Main_From.Size = new System.Drawing.Size(29, 27);
            this.B_Accounting_Details_Detailed_One_Main_From.TabIndex = 261;
            this.B_Accounting_Details_Detailed_One_Main_From.UseVisualStyleBackColor = true;
            //
            //Label7
            //
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label7.Location = new System.Drawing.Point(629, 18);
            this.Label7.Name = "Label7";
            this.Label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label7.Size = new System.Drawing.Size(109, 19);
            this.Label7.TabIndex = 262;
            this.Label7.Text = "از کد تفصیلی :";
            //
            //Accounting_Report
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6.0F, 13.0F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 485);
            this.Controls.Add(this.TabControl1);
            this.Controls.Add(this.ToolStrip1);
            this.Name = "Accounting_Report";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.GroupBox8.ResumeLayout(false);
            this.GroupBox8.PerformLayout();
            this.GroupBox9.ResumeLayout(false);
            this.GroupBox9.PerformLayout();
            this.GroupBox7.ResumeLayout(false);
            this.GroupBox7.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.TabPage2.ResumeLayout(false);
            this.GroupBox6.ResumeLayout(false);
            this.GroupBox6.PerformLayout();
            this.GroupBox5.ResumeLayout(false);
            this.GroupBox5.PerformLayout();
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator3;
        internal System.Windows.Forms.ToolStripButton Print_B;
        internal System.Windows.Forms.ToolStripButton Excel_B;
        internal System.Windows.Forms.ToolStripButton Abort_B;
        internal System.Windows.Forms.TabControl TabControl1;
        internal System.Windows.Forms.TabPage TabPage1;
        internal System.Windows.Forms.TabPage TabPage2;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox Header_Number_Until;
        internal System.Windows.Forms.Label Label21;
        internal System.Windows.Forms.TextBox Header_Number_From;
        internal System.Windows.Forms.Label Label4;
        internal Ansaripour.Rtl_Date Accounting_Header_Date_From;
        internal System.Windows.Forms.Label Label3;
        internal Ansaripour.Rtl_Date Accounting_Header_Date_Until;
        internal System.Windows.Forms.TextBox Accounting_Header_Description;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.CheckBox Accounting_Header_Class_2;
        internal System.Windows.Forms.CheckBox Accounting_Header_Class_1;
        internal System.Windows.Forms.CheckBox Accounting_Header_Class_0;
        internal System.Windows.Forms.CheckBox Accounting_Header_Class_4;
        internal System.Windows.Forms.CheckBox Accounting_Header_Class_3;
        internal System.Windows.Forms.CheckBox Accounting_Header_Class_5;
        internal System.Windows.Forms.TextBox Accounting_Details_Acc_Main_Until;
        internal System.Windows.Forms.Button B_Accounting_Details_Acc_Main_Until;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox Accounting_Details_Acc_Main_From;
        internal System.Windows.Forms.Button B_Accounting_Details_Acc_Main_From;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.GroupBox GroupBox8;
        internal System.Windows.Forms.TextBox Accounting_Details_Description_Main;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.GroupBox GroupBox7;
        internal System.Windows.Forms.GroupBox GroupBox6;
        internal System.Windows.Forms.TextBox Accounting_Details_Detailed_Five_Main_Until;
        internal System.Windows.Forms.Button B_Accounting_Details_Detailed_Five_Main_Until;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.TextBox Accounting_Details_Detailed_Five_Main_From;
        internal System.Windows.Forms.Button B_Accounting_Details_Detailed_Five_Main_From;
        internal System.Windows.Forms.Label Label17;
        internal System.Windows.Forms.GroupBox GroupBox5;
        internal System.Windows.Forms.TextBox Accounting_Details_Detailed_Four_Main_Until;
        internal System.Windows.Forms.Button B_Accounting_Details_Detailed_Four_Main_Until;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.TextBox Accounting_Details_Detailed_Four_Main_From;
        internal System.Windows.Forms.Button B_Accounting_Details_Detailed_Four_Main_From;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.GroupBox GroupBox4;
        internal System.Windows.Forms.TextBox Accounting_Details_Detailed_Three_Main_Until;
        internal System.Windows.Forms.Button B_Accounting_Details_Detailed_Three_Main_Until;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.TextBox Accounting_Details_Detailed_Three_Main_From;
        internal System.Windows.Forms.Button B_Accounting_Details_Detailed_Three_Main_From;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.TextBox Accounting_Details_Detailed_Two_Main_Until;
        internal System.Windows.Forms.Button B_Accounting_Details_Detailed_Two_Main_Until;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.TextBox Accounting_Details_Detailed_Two_Main_From;
        internal System.Windows.Forms.Button B_Accounting_Details_Detailed_Two_Main_From;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.TextBox Accounting_Details_Detailed_One_Main_Until;
        internal System.Windows.Forms.Button B_Accounting_Details_Detailed_One_Main_Until;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox Accounting_Details_Detailed_One_Main_From;
        internal System.Windows.Forms.Button B_Accounting_Details_Detailed_One_Main_From;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label19;
        internal Ansaripour.Rtl_Date Accounting_Details_Date_Cost_Main_Until;
        internal System.Windows.Forms.Label Label18;
        internal Ansaripour.Rtl_Date Accounting_Details_Date_Cost_Main_From;
        internal System.Windows.Forms.TextBox Accounting_Details_Number_Due_Main_Until;
        internal System.Windows.Forms.Label Label20;
        internal System.Windows.Forms.TextBox Accounting_Details_Number_Due_Main_From;
        internal System.Windows.Forms.Label Estehlak_Label;
        internal System.Windows.Forms.Label Label23;
        internal Ansaripour.Rtl_Date Accounting_Details_Date_Due_Main_Until;
        internal System.Windows.Forms.Label Label22;
        internal Ansaripour.Rtl_Date Accounting_Details_Date_Due_Main_From;
        internal System.Windows.Forms.TextBox Accounting_Details_Number_Turning_Main_Until;
        internal System.Windows.Forms.Label Label25;
        internal System.Windows.Forms.TextBox Accounting_Details_Number_Turning_Main_From;
        internal System.Windows.Forms.Label Label24;
        internal System.Windows.Forms.GroupBox GroupBox9;
        internal System.Windows.Forms.Button B_Accounting_Area_Main_one;
        internal System.Windows.Forms.TextBox Accounting_Area_Main_one;
        internal System.Windows.Forms.RadioButton Accounting_Area_one;
        internal System.Windows.Forms.RadioButton Accounting_Area_All;
        internal System.Windows.Forms.Label L_Accounting_Details_Acc_Main_From;
        internal System.Windows.Forms.Label L_Accounting_Details_Acc_Main_Until;
        internal System.Windows.Forms.Label L_Accounting_Details_Detailed_Five_Main_From;
        internal System.Windows.Forms.Label L_Accounting_Details_Detailed_Five_Main_Until;
        internal System.Windows.Forms.Label L_Accounting_Details_Detailed_Four_Main_From;
        internal System.Windows.Forms.Label L_Accounting_Details_Detailed_Four_Main_Until;
        internal System.Windows.Forms.Label L_Accounting_Details_Detailed_Three_Main_From;
        internal System.Windows.Forms.Label L_Accounting_Details_Detailed_Three_Main_Until;
        internal System.Windows.Forms.Label L_Accounting_Details_Detailed_Two_Main_From;
        internal System.Windows.Forms.Label L_Accounting_Details_Detailed_Two_Main_Until;
        internal System.Windows.Forms.Label L_Accounting_Details_Detailed_One_Main_Until;
        internal System.Windows.Forms.Label L_Accounting_Details_Detailed_One_Main_From;
    }
