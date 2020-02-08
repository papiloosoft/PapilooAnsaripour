
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
	public partial class Area : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Area));
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
			this.New_B = new System.Windows.Forms.ToolStripButton();
			this.Edit_B = new System.Windows.Forms.ToolStripButton();
			this.Delet_B = new System.Windows.Forms.ToolStripButton();
			this.Save_B = new System.Windows.Forms.ToolStripButton();
			this.Picture_B = new System.Windows.Forms.ToolStripButton();
			this.Search_B = new System.Windows.Forms.ToolStripButton();
			this.ToolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.Abort_B = new System.Windows.Forms.ToolStripButton();
			this.B_Period = new System.Windows.Forms.ToolStripMenuItem();
			this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
			this.Address_Area = new System.Windows.Forms.TextBox();
			this.Mobile_Number_Area = new System.Windows.Forms.TextBox();
			this.General_Manager_Area = new System.Windows.Forms.TextBox();
			this.Email_Area = new System.Windows.Forms.TextBox();
			this.Fax_Number_Area = new System.Windows.Forms.TextBox();
			this.Phone_Number_Area = new System.Windows.Forms.TextBox();
			this.Postal_Code_Area = new System.Windows.Forms.TextBox();
			this.National_Code_Area = new System.Windows.Forms.TextBox();
			this.Economic_Number_Area = new System.Windows.Forms.TextBox();
			this.Registration_Number_Area = new System.Windows.Forms.TextBox();
			this.Company_Area = new System.Windows.Forms.TextBox();
			this.Department_Area = new System.Windows.Forms.TextBox();
			this.Code_Area = new System.Windows.Forms.TextBox();
			this.Label13 = new System.Windows.Forms.Label();
			this.Label12 = new System.Windows.Forms.Label();
			this.Label11 = new System.Windows.Forms.Label();
			this.Label10 = new System.Windows.Forms.Label();
			this.Label9 = new System.Windows.Forms.Label();
			this.Label8 = new System.Windows.Forms.Label();
			this.Label7 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.DV = new System.Windows.Forms.DataGridView();
			this.ToolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.SplitContainer1).BeginInit();
			this.SplitContainer1.Panel1.SuspendLayout();
			this.SplitContainer1.Panel2.SuspendLayout();
			this.SplitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.DV).BeginInit();
			this.SuspendLayout();
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.Label1.Location = new System.Drawing.Point(881, 35);
			this.Label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
			this.Label1.Name = "Label1";
			this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Label1.Size = new System.Drawing.Size(116, 23);
			this.Label1.TabIndex = 56;
			this.Label1.Text = "کـــد بخــش :";
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.Label3.Location = new System.Drawing.Point(610, 36);
			this.Label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
			this.Label3.Name = "Label3";
			this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Label3.Size = new System.Drawing.Size(94, 23);
			this.Label3.TabIndex = 66;
			this.Label3.Text = "نام بخش :";
			//
			//ToolStrip1
			//
			this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.New_B, this.Edit_B, this.Delet_B, this.Save_B, this.Picture_B, this.Search_B, this.ToolStripButton1, this.Abort_B, this.B_Period});
			this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
			this.ToolStrip1.Name = "ToolStrip1";
			this.ToolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.ToolStrip1.Size = new System.Drawing.Size(1005, 25);
			this.ToolStrip1.TabIndex = 13;
			this.ToolStrip1.Text = "ToolStrip1";
			//
			//New_B
			//
			this.New_B.Image = (System.Drawing.Image)resources.GetObject("New_B.Image");
			this.New_B.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.New_B.Name = "New_B";
			this.New_B.Size = new System.Drawing.Size(50, 22);
			this.New_B.Text = "جدید";
            //
            //Edit_B
            //
            this.Edit_B.Image = (System.Drawing.Image)resources.GetObject("Edit_B.Image");
            this.Edit_B.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Edit_B.Name = "Edit_B";
            this.Edit_B.Size = new System.Drawing.Size(63, 22);
            this.Edit_B.Text = "ویرایش";
            //
            //Delet_B
            //
            this.Delet_B.Image = (System.Drawing.Image)resources.GetObject("Delet_B.Image");
            this.Delet_B.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Delet_B.Name = "Delet_B";
            this.Delet_B.Size = new System.Drawing.Size(52, 22);
            this.Delet_B.Text = "حذف";
            this.Delet_B.ToolTipText = "حذف";
            //
            //Save_B
            //
            this.Save_B.Enabled = false;
            this.Save_B.Image = (System.Drawing.Image)resources.GetObject("Save_B.Image");
            this.Save_B.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Save_B.Name = "Save_B";
            this.Save_B.Size = new System.Drawing.Size(54, 22);
            this.Save_B.Text = "ذخیره";
            //
            //Picture_B
            //
            this.Picture_B.Image = (System.Drawing.Image)resources.GetObject("Picture_B.Image");
            this.Picture_B.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Picture_B.Name = "Picture_B";
            this.Picture_B.Size = new System.Drawing.Size(59, 22);
            this.Picture_B.Text = "تصویر";
            //
            //Search_B
            //
            this.Search_B.Image = (System.Drawing.Image)resources.GetObject("Search_B.Image");
            this.Search_B.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Search_B.Name = "Search_B";
            this.Search_B.Size = new System.Drawing.Size(61, 22);
            this.Search_B.Text = "جستجو";
            //
            //ToolStripButton1
            //
            this.ToolStripButton1.Image = (System.Drawing.Image)resources.GetObject("ToolStripButton1.Image");
            this.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton1.Name = "ToolStripButton1";
            this.ToolStripButton1.Size = new System.Drawing.Size(48, 22);
            this.ToolStripButton1.Text = "چاپ";
            //
            //Abort_B
            //
            this.Abort_B.Image = (System.Drawing.Image)resources.GetObject("Abort_B.Image");
            this.Abort_B.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Abort_B.Name = "Abort_B";
            this.Abort_B.Size = new System.Drawing.Size(64, 22);
            this.Abort_B.Text = "انصراف";
            //
            //B_Period
            //
            this.B_Period.Image = (System.Drawing.Image)resources.GetObject("B_Period.Image");
            this.B_Period.Name = "B_Period";
            this.B_Period.Size = new System.Drawing.Size(118, 25);
            this.B_Period.Text = "ایجـاد دوره مالـــی";
            //SplitContainer1
            //
            this.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.SplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.SplitContainer1.Name = "SplitContainer1";
            this.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            //
            //SplitContainer1.Panel1
            //
            this.SplitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SplitContainer1.Panel1.Controls.Add(this.Address_Area);
            this.SplitContainer1.Panel1.Controls.Add(this.Mobile_Number_Area);
            this.SplitContainer1.Panel1.Controls.Add(this.General_Manager_Area);
            this.SplitContainer1.Panel1.Controls.Add(this.Email_Area);
            this.SplitContainer1.Panel1.Controls.Add(this.Fax_Number_Area);
            this.SplitContainer1.Panel1.Controls.Add(this.Phone_Number_Area);
            this.SplitContainer1.Panel1.Controls.Add(this.Postal_Code_Area);
            this.SplitContainer1.Panel1.Controls.Add(this.National_Code_Area);
            this.SplitContainer1.Panel1.Controls.Add(this.Economic_Number_Area);
            this.SplitContainer1.Panel1.Controls.Add(this.Registration_Number_Area);
            this.SplitContainer1.Panel1.Controls.Add(this.Company_Area);
            this.SplitContainer1.Panel1.Controls.Add(this.Department_Area);
            this.SplitContainer1.Panel1.Controls.Add(this.Code_Area);
            this.SplitContainer1.Panel1.Controls.Add(this.Label13);
            this.SplitContainer1.Panel1.Controls.Add(this.Label12);
            this.SplitContainer1.Panel1.Controls.Add(this.Label11);
            this.SplitContainer1.Panel1.Controls.Add(this.Label10);
            this.SplitContainer1.Panel1.Controls.Add(this.Label9);
            this.SplitContainer1.Panel1.Controls.Add(this.Label8);
            this.SplitContainer1.Panel1.Controls.Add(this.Label7);
            this.SplitContainer1.Panel1.Controls.Add(this.Label6);
            this.SplitContainer1.Panel1.Controls.Add(this.Label5);
            this.SplitContainer1.Panel1.Controls.Add(this.Label4);
            this.SplitContainer1.Panel1.Controls.Add(this.Label2);
            this.SplitContainer1.Panel1.Controls.Add(this.ToolStrip1);
            this.SplitContainer1.Panel1.Controls.Add(this.Label3);
            this.SplitContainer1.Panel1.Controls.Add(this.Label1);
            this.SplitContainer1.Panel1.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.SplitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            //
            //SplitContainer1.Panel2
            //
            this.SplitContainer1.Panel2.Controls.Add(this.DV);
            this.SplitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SplitContainer1.Size = new System.Drawing.Size(1005, 526);
            this.SplitContainer1.SplitterDistance = 257;
            this.SplitContainer1.TabIndex = 65;
            //
            //Address_Area
            //
            this.Address_Area.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Address_Area.Location = new System.Drawing.Point(8, 218);
            this.Address_Area.Name = "Address_Area";
            this.Address_Area.Size = new System.Drawing.Size(931, 31);
            this.Address_Area.TabIndex = 12;
            //
            //Mobile_Number_Area
            //
            this.Mobile_Number_Area.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Mobile_Number_Area.Location = new System.Drawing.Point(8, 181);
            this.Mobile_Number_Area.Name = "Mobile_Number_Area";
            this.Mobile_Number_Area.Size = new System.Drawing.Size(277, 31);
            this.Mobile_Number_Area.TabIndex = 11;
            //
            //General_Manager_Area
            //
            this.General_Manager_Area.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.General_Manager_Area.Location = new System.Drawing.Point(423, 181);
            this.General_Manager_Area.Name = "General_Manager_Area";
            this.General_Manager_Area.Size = new System.Drawing.Size(329, 31);
            this.General_Manager_Area.TabIndex = 10;
            //
            //Email_Area
            //
            this.Email_Area.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Email_Area.Location = new System.Drawing.Point(8, 144);
            this.Email_Area.Name = "Email_Area";
            this.Email_Area.Size = new System.Drawing.Size(277, 31);
            this.Email_Area.TabIndex = 9;
            //
            //Fax_Number_Area
            //
            this.Fax_Number_Area.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Fax_Number_Area.Location = new System.Drawing.Point(423, 143);
            this.Fax_Number_Area.Name = "Fax_Number_Area";
            this.Fax_Number_Area.Size = new System.Drawing.Size(150, 31);
            this.Fax_Number_Area.TabIndex = 8;
            //
            //Phone_Number_Area
            //
            this.Phone_Number_Area.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Phone_Number_Area.Location = new System.Drawing.Point(709, 144);
            this.Phone_Number_Area.Name = "Phone_Number_Area";
            this.Phone_Number_Area.Size = new System.Drawing.Size(168, 31);
            this.Phone_Number_Area.TabIndex = 7;
            //
            //Postal_Code_Area
            //
            this.Postal_Code_Area.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Postal_Code_Area.Location = new System.Drawing.Point(8, 108);
            this.Postal_Code_Area.Name = "Postal_Code_Area";
            this.Postal_Code_Area.Size = new System.Drawing.Size(277, 31);
            this.Postal_Code_Area.TabIndex = 6;
            //
            //National_Code_Area
            //
            this.National_Code_Area.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.National_Code_Area.Location = new System.Drawing.Point(385, 107);
            this.National_Code_Area.Name = "National_Code_Area";
            this.National_Code_Area.Size = new System.Drawing.Size(159, 31);
            this.National_Code_Area.TabIndex = 5;
            //
            //Economic_Number_Area
            //
            this.Economic_Number_Area.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Economic_Number_Area.Location = new System.Drawing.Point(709, 108);
            this.Economic_Number_Area.Name = "Economic_Number_Area";
            this.Economic_Number_Area.Size = new System.Drawing.Size(168, 31);
            this.Economic_Number_Area.TabIndex = 4;
            //
            //Registration_Number_Area
            //
            this.Registration_Number_Area.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Registration_Number_Area.Location = new System.Drawing.Point(8, 70);
            this.Registration_Number_Area.Name = "Registration_Number_Area";
            this.Registration_Number_Area.Size = new System.Drawing.Size(239, 31);
            this.Registration_Number_Area.TabIndex = 3;
            //
            //Company_Area
            //
            this.Company_Area.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Company_Area.Location = new System.Drawing.Point(355, 70);
            this.Company_Area.Name = "Company_Area";
            this.Company_Area.Size = new System.Drawing.Size(524, 31);
            this.Company_Area.TabIndex = 2;
            //
            //Department_Area
            //
            this.Department_Area.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Department_Area.Location = new System.Drawing.Point(8, 33);
            this.Department_Area.Name = "Department_Area";
            this.Department_Area.Size = new System.Drawing.Size(604, 31);
            this.Department_Area.TabIndex = 1;
            //
            //Code_Area
            //
            this.Code_Area.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Code_Area.Location = new System.Drawing.Point(711, 33);
            this.Code_Area.Name = "Code_Area";
            this.Code_Area.Size = new System.Drawing.Size(168, 31);
            this.Code_Area.TabIndex = 0;
            //
            //Label13
            //
            this.Label13.AutoSize = true;
            this.Label13.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label13.Location = new System.Drawing.Point(283, 185);
            this.Label13.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label13.Name = "Label13";
            this.Label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label13.Size = new System.Drawing.Size(129, 23);
            this.Label13.TabIndex = 204;
            this.Label13.Text = "شماره همراه :";
            //
            //Label12
            //
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label12.Location = new System.Drawing.Point(283, 147);
            this.Label12.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label12.Name = "Label12";
            this.Label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label12.Size = new System.Drawing.Size(139, 23);
            this.Label12.TabIndex = 202;
            this.Label12.Text = "پست الکترونیک:";
            //
            //Label11
            //
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label11.Location = new System.Drawing.Point(574, 147);
            this.Label11.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label11.Name = "Label11";
            this.Label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label11.Size = new System.Drawing.Size(130, 23);
            this.Label11.TabIndex = 200;
            this.Label11.Text = "شماره فاکس :";
            //
            //Label10
            //
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label10.Location = new System.Drawing.Point(751, 185);
            this.Label10.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label10.Name = "Label10";
            this.Label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label10.Size = new System.Drawing.Size(253, 23);
            this.Label10.TabIndex = 198;
            this.Label10.Text = "نام و نام خانوادگی مدیر عامل :";
            //
            //Label9
            //
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label9.Location = new System.Drawing.Point(935, 222);
            this.Label9.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label9.Name = "Label9";
            this.Label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label9.Size = new System.Drawing.Size(67, 23);
            this.Label9.TabIndex = 196;
            this.Label9.Text = "آدرس :";
            //
            //Label8
            //
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label8.Location = new System.Drawing.Point(284, 111);
            this.Label8.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label8.Name = "Label8";
            this.Label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label8.Size = new System.Drawing.Size(99, 23);
            this.Label8.TabIndex = 194;
            this.Label8.Text = "کد پستی :";
            //
            //Label7
            //
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label7.Location = new System.Drawing.Point(876, 148);
            this.Label7.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label7.Name = "Label7";
            this.Label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label7.Size = new System.Drawing.Size(128, 23);
            this.Label7.TabIndex = 193;
            this.Label7.Text = "شماره تماس :";
            //
            //Label6
            //
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label6.Location = new System.Drawing.Point(247, 74);
            this.Label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label6.Name = "Label6";
            this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label6.Size = new System.Drawing.Size(112, 23);
            this.Label6.TabIndex = 184;
            this.Label6.Text = "شماره ثبت :";
            //
            //Label5
            //
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label5.Location = new System.Drawing.Point(542, 112);
            this.Label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label5.Name = "Label5";
            this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label5.Size = new System.Drawing.Size(165, 23);
            this.Label5.TabIndex = 182;
            this.Label5.Text = "کد / شناسه ملی :";
            //
            //Label4
            //
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label4.Location = new System.Drawing.Point(878, 111);
            this.Label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label4.Size = new System.Drawing.Size(115, 23);
            this.Label4.TabIndex = 180;
            this.Label4.Text = "کد اقتصادی :";
            //
            //Label2
            //
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label2.Location = new System.Drawing.Point(882, 73);
            this.Label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label2.Size = new System.Drawing.Size(120, 23);
            this.Label2.TabIndex = 178;
            this.Label2.Text = "نــام شـرکت :";
            //
            //DV
            //
            this.DV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
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
            this.DV.Size = new System.Drawing.Size(1005, 265);
            this.DV.TabIndex = 0;
            //
            //Area
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(12.0F, 25.0F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1005, 526);
            this.Controls.Add(this.SplitContainer1);
            this.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.Name = "Area";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "درخت حسابها";
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.SplitContainer1.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel1.PerformLayout();
            this.SplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.SplitContainer1).EndInit();
            this.SplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.DV).EndInit();
            this.ResumeLayout(false);

        }
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton New_B;
        internal System.Windows.Forms.ToolStripButton Edit_B;
        internal System.Windows.Forms.ToolStripButton Delet_B;
        internal System.Windows.Forms.ToolStripButton Save_B;
        internal System.Windows.Forms.ToolStripButton Search_B;
        internal System.Windows.Forms.ToolStripButton ToolStripButton1;
        internal System.Windows.Forms.ToolStripButton Abort_B;
        internal System.Windows.Forms.SplitContainer SplitContainer1;
        internal System.Windows.Forms.DataGridView DV;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.ToolStripButton Picture_B;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.ToolStripMenuItem B_Period;
        internal System.Windows.Forms.TextBox Address_Area;
        internal System.Windows.Forms.TextBox Mobile_Number_Area;
        internal System.Windows.Forms.TextBox General_Manager_Area;
        internal System.Windows.Forms.TextBox Email_Area;
        internal System.Windows.Forms.TextBox Fax_Number_Area;
        internal System.Windows.Forms.TextBox Phone_Number_Area;
        internal System.Windows.Forms.TextBox Postal_Code_Area;
        internal System.Windows.Forms.TextBox National_Code_Area;
        internal System.Windows.Forms.TextBox Economic_Number_Area;
        internal System.Windows.Forms.TextBox Registration_Number_Area;
        internal System.Windows.Forms.TextBox Company_Area;
        internal System.Windows.Forms.TextBox Department_Area;
        internal System.Windows.Forms.TextBox Code_Area;
    }
