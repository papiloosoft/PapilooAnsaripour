using System.Drawing.Imaging;
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
    public partial class Pay_Personal : System.Windows.Forms.Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pay_Personal));
            System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.B_New = new System.Windows.Forms.ToolStripButton();
            this.B_Edit = new System.Windows.Forms.ToolStripButton();
            this.B_Delet = new System.Windows.Forms.ToolStripButton();
            this.B_Save = new System.Windows.Forms.ToolStripButton();
            this.B_Search = new System.Windows.Forms.ToolStripButton();
            this.B_Excel = new System.Windows.Forms.ToolStripButton();
            this.B_Picture = new System.Windows.Forms.ToolStripButton();
            this.B_Print = new System.Windows.Forms.ToolStripButton();
            this.B_Abort = new System.Windows.Forms.ToolStripButton();
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Pay_Personal_Address = new System.Windows.Forms.TextBox();
            this.Pay_Personal_Tell = new System.Windows.Forms.TextBox();
            this.Pay_Personal_Account = new System.Windows.Forms.TextBox();
            this.Pay_Personal_Insurance = new System.Windows.Forms.TextBox();
            this.Pay_Personal_Discipline = new System.Windows.Forms.TextBox();
            this.Pay_Personal_National_Id = new System.Windows.Forms.TextBox();
            this.Pay_Personal_Cirtificate_Id = new System.Windows.Forms.TextBox();
            this.Pay_Personal_Place_Berthday = new System.Windows.Forms.TextBox();
            this.Pay_Personal_Father = new System.Windows.Forms.TextBox();
            this.Pay_Personal_Family = new System.Windows.Forms.TextBox();
            this.Pay_Personal_Name = new System.Windows.Forms.TextBox();
            this.Pay_Personal_Code = new System.Windows.Forms.TextBox();
            this.Pay_Personal_Date_Berthday = new Ansaripour.Rtl_Date();
            this.Pay_Personal_Soldier = new System.Windows.Forms.ComboBox();
            this.Label17 = new System.Windows.Forms.Label();
            this.Pay_Personal_Diploma = new System.Windows.Forms.ComboBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.Pay_Personal_Marry = new System.Windows.Forms.ComboBox();
            this.Pay_Personal_Sex = new System.Windows.Forms.ComboBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label16 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.DV = new System.Windows.Forms.DataGridView();
            this.P_Date = new Ansaripour.Rtl_Date();
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
            this.Label1.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label1.Location = new System.Drawing.Point(864, 36);
            this.Label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label1.Size = new System.Drawing.Size(125, 19);
            this.Label1.TabIndex = 56;
            this.Label1.Text = "شماره پرسنلی :";
            //
            //Label3
            //
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label3.Location = new System.Drawing.Point(743, 35);
            this.Label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label3.Size = new System.Drawing.Size(38, 19);
            this.Label3.TabIndex = 66;
            this.Label3.Text = "نام :";
            //
            //ToolStrip1
            //
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.B_New, this.B_Edit, this.B_Delet, this.B_Save, this.B_Search, this.B_Excel, this.B_Picture, this.B_Print, this.B_Abort });
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            //
            //ToolStrip1
            //
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.B_New, this.B_Edit, this.B_Delet, this.B_Save, this.B_Search, this.B_Excel, this.B_Picture, this.B_Print, this.B_Abort });
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ToolStrip1.Size = new System.Drawing.Size(994, 25);
            this.ToolStrip1.TabIndex = 17;
            this.ToolStrip1.Text = "ToolStrip1";
            //
            //B_New
            //
            this.B_New.Image = (System.Drawing.Image)resources.GetObject("B_New.Image");
            this.B_New.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.B_New.Name = "B_New";
            this.B_New.Size = new System.Drawing.Size(50, 22);
            this.B_New.Text = "جدید";
            //
            //B_Edit
            //
            this.B_Edit.Image = (System.Drawing.Image)resources.GetObject("B_Edit.Image");
            this.B_Edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.B_Edit.Name = "B_Edit";
            this.B_Edit.Size = new System.Drawing.Size(63, 22);
            this.B_Edit.Text = "ویرایش";
            //
            //B_Delet
            //
            this.B_Delet.Image = (System.Drawing.Image)resources.GetObject("B_Delet.Image");
            this.B_Delet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.B_Delet.Name = "B_Delet";
            this.B_Delet.Size = new System.Drawing.Size(52, 22);
            this.B_Delet.Text = "حذف";
            this.B_Delet.ToolTipText = "حذف";
            //
            //B_Save
            //
            this.B_Save.Enabled = false;
            this.B_Save.Image = (System.Drawing.Image)resources.GetObject("B_Save.Image");
            this.B_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.B_Save.Name = "B_Save";
            this.B_Save.Size = new System.Drawing.Size(54, 22);
            this.B_Save.Text = "ذخیره";
            //
            //B_Search
            //
            this.B_Search.Image = (System.Drawing.Image)resources.GetObject("B_Search.Image");
            this.B_Search.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.B_Search.Name = "B_Search";
            this.B_Search.Size = new System.Drawing.Size(61, 22);
            this.B_Search.Text = "جستجو";
            //
            //B_Excel
            //
            this.B_Excel.Image = (System.Drawing.Image)resources.GetObject("B_Excel.Image");
            this.B_Excel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.B_Excel.Name = "B_Excel";
            this.B_Excel.Size = new System.Drawing.Size(54, 22);
            this.B_Excel.Text = "اکسل";
            //
            //B_Picture
            //
            this.B_Picture.Image = (System.Drawing.Image)resources.GetObject("B_Picture.Image");
            this.B_Picture.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.B_Picture.Name = "B_Picture";
            this.B_Picture.Size = new System.Drawing.Size(59, 22);
            this.B_Picture.Text = "تصویر";
            //
            //B_Print
            //
            this.B_Print.Image = (System.Drawing.Image)resources.GetObject("B_Print.Image");
            this.B_Print.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.B_Print.Name = "B_Print";
            this.B_Print.Size = new System.Drawing.Size(48, 22);
            this.B_Print.Text = "چاپ";
            //
            //B_Abort
            //
            this.B_Abort.Image = (System.Drawing.Image)resources.GetObject("B_Abort.Image");
            this.B_Abort.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.B_Abort.Name = "B_Abort";
            this.B_Abort.Size = new System.Drawing.Size(64, 22);
            this.B_Abort.Text = "انصراف";
            //
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
            this.SplitContainer1.Panel1.Controls.Add(this.Pay_Personal_Address);
            this.SplitContainer1.Panel1.Controls.Add(this.Pay_Personal_Tell);
            this.SplitContainer1.Panel1.Controls.Add(this.Pay_Personal_Account);
            this.SplitContainer1.Panel1.Controls.Add(this.Pay_Personal_Insurance);
            this.SplitContainer1.Panel1.Controls.Add(this.Pay_Personal_Discipline);
            this.SplitContainer1.Panel1.Controls.Add(this.Pay_Personal_National_Id);
            this.SplitContainer1.Panel1.Controls.Add(this.Pay_Personal_Cirtificate_Id);
            this.SplitContainer1.Panel1.Controls.Add(this.Pay_Personal_Place_Berthday);
            this.SplitContainer1.Panel1.Controls.Add(this.Pay_Personal_Father);
            this.SplitContainer1.Panel1.Controls.Add(this.Pay_Personal_Family);
            this.SplitContainer1.Panel1.Controls.Add(this.Pay_Personal_Name);
            this.SplitContainer1.Panel1.Controls.Add(this.Pay_Personal_Code);
            this.SplitContainer1.Panel1.Controls.Add(this.Pay_Personal_Date_Berthday);
            this.SplitContainer1.Panel1.Controls.Add(this.Pay_Personal_Soldier);
            this.SplitContainer1.Panel1.Controls.Add(this.Label17);
            this.SplitContainer1.Panel1.Controls.Add(this.Pay_Personal_Diploma);
            this.SplitContainer1.Panel1.Controls.Add(this.Label14);
            this.SplitContainer1.Panel1.Controls.Add(this.Pay_Personal_Marry);
            this.SplitContainer1.Panel1.Controls.Add(this.Pay_Personal_Sex);
            this.SplitContainer1.Panel1.Controls.Add(this.Label11);
            this.SplitContainer1.Panel1.Controls.Add(this.Label9);
            this.SplitContainer1.Panel1.Controls.Add(this.Label7);
            this.SplitContainer1.Panel1.Controls.Add(this.Label6);
            this.SplitContainer1.Panel1.Controls.Add(this.Label4);
            this.SplitContainer1.Panel1.Controls.Add(this.ToolStrip1);
            this.SplitContainer1.Panel1.Controls.Add(this.Label3);
            this.SplitContainer1.Panel1.Controls.Add(this.Label1);
            this.SplitContainer1.Panel1.Controls.Add(this.Label10);
            this.SplitContainer1.Panel1.Controls.Add(this.Label2);
            this.SplitContainer1.Panel1.Controls.Add(this.Label12);
            this.SplitContainer1.Panel1.Controls.Add(this.Label8);
            this.SplitContainer1.Panel1.Controls.Add(this.Label16);
            this.SplitContainer1.Panel1.Controls.Add(this.Label15);
            this.SplitContainer1.Panel1.Controls.Add(this.Label13);
            this.SplitContainer1.Panel1.Controls.Add(this.Label5);
            this.SplitContainer1.Panel1.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.SplitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            //
            //SplitContainer1.Panel2
            //
            this.SplitContainer1.Panel2.Controls.Add(this.DV);
            this.SplitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SplitContainer1.Size = new System.Drawing.Size(994, 526);
            this.SplitContainer1.SplitterDistance = 239;
            this.SplitContainer1.TabIndex = 65;
            //
            //Pay_Personal_Address
            //
            this.Pay_Personal_Address.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Pay_Personal_Address.Location = new System.Drawing.Point(8, 189);
            this.Pay_Personal_Address.Name = "Pay_Personal_Address";
            this.Pay_Personal_Address.Size = new System.Drawing.Size(922, 27);
            this.Pay_Personal_Address.TabIndex = 16;
            //
            //Pay_Personal_Tell
            //
            this.Pay_Personal_Tell.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Pay_Personal_Tell.Location = new System.Drawing.Point(8, 148);
            this.Pay_Personal_Tell.Name = "Pay_Personal_Tell";
            this.Pay_Personal_Tell.Size = new System.Drawing.Size(175, 27);
            this.Pay_Personal_Tell.TabIndex = 15;
            //
            //Pay_Personal_Account
            //
            this.Pay_Personal_Account.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Pay_Personal_Account.Location = new System.Drawing.Point(244, 150);
            this.Pay_Personal_Account.Name = "Pay_Personal_Account";
            this.Pay_Personal_Account.Size = new System.Drawing.Size(205, 27);
            this.Pay_Personal_Account.TabIndex = 14;
            //
            //Pay_Personal_Insurance
            //
            this.Pay_Personal_Insurance.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Pay_Personal_Insurance.Location = new System.Drawing.Point(517, 150);
            this.Pay_Personal_Insurance.Name = "Pay_Personal_Insurance";
            this.Pay_Personal_Insurance.Size = new System.Drawing.Size(177, 27);
            this.Pay_Personal_Insurance.TabIndex = 13;
            //
            //Pay_Personal_Discipline
            //
            this.Pay_Personal_Discipline.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Pay_Personal_Discipline.Location = new System.Drawing.Point(8, 111);
            this.Pay_Personal_Discipline.Name = "Pay_Personal_Discipline";
            this.Pay_Personal_Discipline.Size = new System.Drawing.Size(235, 27);
            this.Pay_Personal_Discipline.TabIndex = 11;
            //
            //Pay_Personal_National_Id
            //
            this.Pay_Personal_National_Id.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Pay_Personal_National_Id.Location = new System.Drawing.Point(8, 71);
            this.Pay_Personal_National_Id.Name = "Pay_Personal_National_Id";
            this.Pay_Personal_National_Id.Size = new System.Drawing.Size(189, 27);
            this.Pay_Personal_National_Id.TabIndex = 7;
            //
            //Pay_Personal_Cirtificate_Id
            //
            this.Pay_Personal_Cirtificate_Id.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Pay_Personal_Cirtificate_Id.Location = new System.Drawing.Point(267, 69);
            this.Pay_Personal_Cirtificate_Id.Name = "Pay_Personal_Cirtificate_Id";
            this.Pay_Personal_Cirtificate_Id.Size = new System.Drawing.Size(159, 27);
            this.Pay_Personal_Cirtificate_Id.TabIndex = 6;
            //
            //Pay_Personal_Place_Berthday
            //
            this.Pay_Personal_Place_Berthday.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Pay_Personal_Place_Berthday.Location = new System.Drawing.Point(575, 68);
            this.Pay_Personal_Place_Berthday.Name = "Pay_Personal_Place_Berthday";
            this.Pay_Personal_Place_Berthday.Size = new System.Drawing.Size(147, 27);
            this.Pay_Personal_Place_Berthday.TabIndex = 5;
            //
            //Pay_Personal_Father
            //
            this.Pay_Personal_Father.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Pay_Personal_Father.Location = new System.Drawing.Point(8, 33);
            this.Pay_Personal_Father.Name = "Pay_Personal_Father";
            this.Pay_Personal_Father.Size = new System.Drawing.Size(189, 27);
            this.Pay_Personal_Father.TabIndex = 3;
            //
            //Pay_Personal_Family
            //
            this.Pay_Personal_Family.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Pay_Personal_Family.Location = new System.Drawing.Point(267, 33);
            this.Pay_Personal_Family.Name = "Pay_Personal_Family";
            this.Pay_Personal_Family.Size = new System.Drawing.Size(235, 27);
            this.Pay_Personal_Family.TabIndex = 2;
            //
            //Pay_Personal_Name
            //
            this.Pay_Personal_Name.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Pay_Personal_Name.Location = new System.Drawing.Point(605, 33);
            this.Pay_Personal_Name.Name = "Pay_Personal_Name";
            this.Pay_Personal_Name.Size = new System.Drawing.Size(140, 27);
            this.Pay_Personal_Name.TabIndex = 1;
            //
            //Pay_Personal_Code
            //
            this.Pay_Personal_Code.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Pay_Personal_Code.Location = new System.Drawing.Point(782, 32);
            this.Pay_Personal_Code.Name = "Pay_Personal_Code";
            this.Pay_Personal_Code.Size = new System.Drawing.Size(84, 27);
            this.Pay_Personal_Code.TabIndex = 0;
            //
            //Pay_Personal_Date_Berthday
            //
            this.Pay_Personal_Date_Berthday.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Pay_Personal_Date_Berthday.AutoSize = true;
            this.Pay_Personal_Date_Berthday.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Pay_Personal_Date_Berthday.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Pay_Personal_Date_Berthday.Location = new System.Drawing.Point(800, 70);
            this.Pay_Personal_Date_Berthday.Name = "Pay_Personal_Date_Berthday";
            this.Pay_Personal_Date_Berthday.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Pay_Personal_Date_Berthday.Size = new System.Drawing.Size(115, 32);
            this.Pay_Personal_Date_Berthday.T_D = "";
            this.Pay_Personal_Date_Berthday.TabIndex = 4;
            //
            //Pay_Personal_Soldier
            //
            this.Pay_Personal_Soldier.FormattingEnabled = true;
            this.Pay_Personal_Soldier.Items.AddRange(new object[] { "معاف", "پایان خدمت" });
            this.Pay_Personal_Soldier.Location = new System.Drawing.Point(575, 110);
            this.Pay_Personal_Soldier.Name = "Pay_Personal_Soldier";
            this.Pay_Personal_Soldier.Size = new System.Drawing.Size(155, 27);
            this.Pay_Personal_Soldier.TabIndex = 9;
            //
            //Label17
            //
            this.Label17.AutoSize = true;
            this.Label17.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label17.Location = new System.Drawing.Point(733, 114);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(63, 19);
            this.Label17.TabIndex = 229;
            this.Label17.Text = "خدمت :";
            //
            //Pay_Personal_Diploma
            //
            this.Pay_Personal_Diploma.FormattingEnabled = true;
            this.Pay_Personal_Diploma.Items.AddRange(new object[] { "ابتدایی", "سیکل", "دیپلم", "فوق دیپلم", "لیسانس", "فوق لیسانس", "دکتری" });
            this.Pay_Personal_Diploma.Location = new System.Drawing.Point(743, 148);
            this.Pay_Personal_Diploma.Name = "Pay_Personal_Diploma";
            this.Pay_Personal_Diploma.Size = new System.Drawing.Size(135, 27);
            this.Pay_Personal_Diploma.TabIndex = 12;
            //
            //Label14
            //
            this.Label14.AutoSize = true;
            this.Label14.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label14.Location = new System.Drawing.Point(874, 151);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(118, 19);
            this.Label14.TabIndex = 219;
            this.Label14.Text = " مدرک تحصیلی:";
            //
            //Pay_Personal_Marry
            //
            this.Pay_Personal_Marry.FormattingEnabled = true;
            this.Pay_Personal_Marry.Items.AddRange(new object[] { "مجرد", "متاهل" });
            this.Pay_Personal_Marry.Location = new System.Drawing.Point(363, 111);
            this.Pay_Personal_Marry.Name = "Pay_Personal_Marry";
            this.Pay_Personal_Marry.Size = new System.Drawing.Size(143, 27);
            this.Pay_Personal_Marry.TabIndex = 10;
            //
            //Pay_Personal_Sex
            //
            this.Pay_Personal_Sex.FormattingEnabled = true;
            this.Pay_Personal_Sex.Items.AddRange(new object[] { "مرد", "زن" });
            this.Pay_Personal_Sex.Location = new System.Drawing.Point(800, 108);
            this.Pay_Personal_Sex.Name = "Pay_Personal_Sex";
            this.Pay_Personal_Sex.Size = new System.Drawing.Size(116, 27);
            this.Pay_Personal_Sex.TabIndex = 8;
            //
            //Label11
            //
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label11.Location = new System.Drawing.Point(921, 111);
            this.Label11.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label11.Name = "Label11";
            this.Label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label11.Size = new System.Drawing.Size(70, 19);
            this.Label11.TabIndex = 212;
            this.Label11.Text = "جنسیت:";
            //
            //Label9
            //
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label9.Location = new System.Drawing.Point(188, 35);
            this.Label9.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label9.Name = "Label9";
            this.Label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label9.Size = new System.Drawing.Size(62, 19);
            this.Label9.TabIndex = 189;
            this.Label9.Text = "نام پدر :";
            //
            //Label7
            //
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label7.Location = new System.Drawing.Point(929, 192);
            this.Label7.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label7.Name = "Label7";
            this.Label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label7.Size = new System.Drawing.Size(56, 19);
            this.Label7.TabIndex = 185;
            this.Label7.Text = "آدرس :";
            //
            //Label6
            //
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label6.Location = new System.Drawing.Point(912, 74);
            this.Label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label6.Name = "Label6";
            this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label6.Size = new System.Drawing.Size(80, 19);
            this.Label6.TabIndex = 184;
            this.Label6.Text = "تاریخ تولد :";
            //
            //Label4
            //
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label4.Location = new System.Drawing.Point(426, 71);
            this.Label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label4.Size = new System.Drawing.Size(146, 19);
            this.Label4.TabIndex = 180;
            this.Label4.Text = "شماره شناسنامه  :";
            //
            //Label10
            //
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label10.Location = new System.Drawing.Point(719, 72);
            this.Label10.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label10.Name = "Label10";
            this.Label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label10.Size = new System.Drawing.Size(81, 19);
            this.Label10.TabIndex = 193;
            this.Label10.Text = "محل تولد :";
            //
            //Label2
            //
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label2.Location = new System.Drawing.Point(499, 36);
            this.Label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label2.Size = new System.Drawing.Size(105, 19);
            this.Label2.TabIndex = 179;
            this.Label2.Text = "نام خانوادگی :";
            //
            //Label12
            //
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label12.Location = new System.Drawing.Point(451, 153);
            this.Label12.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label12.Name = "Label12";
            this.Label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label12.Size = new System.Drawing.Size(66, 19);
            this.Label12.TabIndex = 225;
            this.Label12.Text = "حساب :";
            //
            //Label8
            //
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label8.Location = new System.Drawing.Point(184, 153);
            this.Label8.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label8.Name = "Label8";
            this.Label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label8.Size = new System.Drawing.Size(63, 19);
            this.Label8.TabIndex = 188;
            this.Label8.Text = " تماس :";
            //
            //Label16
            //
            this.Label16.AutoSize = true;
            this.Label16.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label16.Location = new System.Drawing.Point(693, 155);
            this.Label16.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label16.Name = "Label16";
            this.Label16.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label16.Size = new System.Drawing.Size(49, 19);
            this.Label16.TabIndex = 227;
            this.Label16.Text = "بیمه :";
            //
            //Label15
            //
            this.Label15.AutoSize = true;
            this.Label15.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label15.Location = new System.Drawing.Point(504, 115);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(68, 19);
            this.Label15.TabIndex = 215;
            this.Label15.Text = "وضعیت :";
            //
            //Label13
            //
            this.Label13.AutoSize = true;
            this.Label13.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label13.Location = new System.Drawing.Point(244, 115);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(117, 19);
            this.Label13.TabIndex = 222;
            this.Label13.Text = "رشته تحصیلی :";
            //
            //Label5
            //
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label5.Location = new System.Drawing.Point(196, 72);
            this.Label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label5.Name = "Label5";
            this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label5.Size = new System.Drawing.Size(72, 19);
            this.Label5.TabIndex = 181;
            this.Label5.Text = "کد ملی :";
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
            this.DV.Size = new System.Drawing.Size(994, 283);
            this.DV.TabIndex = 0;
            //
            //P_Date
            //
            this.P_Date.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.P_Date.AutoSize = true;
            this.P_Date.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.P_Date.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.P_Date.Location = new System.Drawing.Point(509, 73);
            this.P_Date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.P_Date.Name = "P_Date";
            this.P_Date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.P_Date.Size = new System.Drawing.Size(136, 29);
            this.P_Date.T_D = "    /  /";
            this.P_Date.TabIndex = 191;
            //
            //Pay_Personal
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(12.0F, 25.0F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(994, 526);
            this.Controls.Add(this.SplitContainer1);
            this.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.Name = "Pay_Personal";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اطلاعات پرسنلی";
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
        internal System.Windows.Forms.ToolStripButton B_New;
        internal System.Windows.Forms.ToolStripButton B_Edit;
        internal System.Windows.Forms.ToolStripButton B_Delet;
        internal System.Windows.Forms.ToolStripButton B_Save;
        internal System.Windows.Forms.ToolStripButton B_Search;
        internal System.Windows.Forms.ToolStripButton B_Print;
        internal System.Windows.Forms.ToolStripButton B_Abort;
        internal System.Windows.Forms.SplitContainer SplitContainer1;
        internal System.Windows.Forms.DataGridView DV;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label9;
        internal Ansaripour.Rtl_Date P_Date;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.ComboBox Pay_Personal_Diploma;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.Label Label15;
        private System.Windows.Forms.ComboBox Pay_Personal_Marry;
        private System.Windows.Forms.ComboBox Pay_Personal_Sex;
        internal System.Windows.Forms.Label Label11;
        private System.Windows.Forms.ComboBox Pay_Personal_Soldier;
        internal System.Windows.Forms.Label Label17;
        internal Ansaripour.Rtl_Date Pay_Personal_Date_Berthday;
        internal System.Windows.Forms.ToolStripButton B_Excel;
        internal System.Windows.Forms.ToolStripButton B_Picture;
        internal System.Windows.Forms.TextBox Pay_Personal_Address;
        internal System.Windows.Forms.TextBox Pay_Personal_Tell;
        internal System.Windows.Forms.TextBox Pay_Personal_Account;
        internal System.Windows.Forms.TextBox Pay_Personal_Insurance;
        internal System.Windows.Forms.TextBox Pay_Personal_Discipline;
        internal System.Windows.Forms.TextBox Pay_Personal_National_Id;
        internal System.Windows.Forms.TextBox Pay_Personal_Cirtificate_Id;
        internal System.Windows.Forms.TextBox Pay_Personal_Place_Berthday;
        internal System.Windows.Forms.TextBox Pay_Personal_Father;
        internal System.Windows.Forms.TextBox Pay_Personal_Family;
        internal System.Windows.Forms.TextBox Pay_Personal_Name;
        internal System.Windows.Forms.TextBox Pay_Personal_Code;
    }
}