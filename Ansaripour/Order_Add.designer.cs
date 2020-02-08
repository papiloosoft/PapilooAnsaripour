
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
    public partial class Order_Add : System.Windows.Forms.Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order_Add));
            System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.B_Order_Add = new System.Windows.Forms.ToolStripButton();
            this.Edit_B = new System.Windows.Forms.ToolStripButton();
            this.Delet_B = new System.Windows.Forms.ToolStripButton();
            this.Save_B = new System.Windows.Forms.ToolStripButton();
            this.Search_B = new System.Windows.Forms.ToolStripButton();
            this.B_Excel = new System.Windows.Forms.ToolStripButton();
            this.B_Picture = new System.Windows.Forms.ToolStripButton();
            this.ToolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.Report_Order_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CHEK = new System.Windows.Forms.ToolStripMenuItem();
            this.Report_Order_Factor = new System.Windows.Forms.ToolStripMenuItem();
            this.Abort_B = new System.Windows.Forms.ToolStripButton();
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.Order_Number = new System.Windows.Forms.TextBox();
            this.Order_Subscription = new System.Windows.Forms.TextBox();
            this.Order_Description = new System.Windows.Forms.RichTextBox();
            this.Label16 = new System.Windows.Forms.Label();
            this.Order_In_Description = new System.Windows.Forms.RichTextBox();
            this.Label15 = new System.Windows.Forms.Label();
            this.Order_Time = new System.Windows.Forms.MaskedTextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.B_Order_Subscription = new System.Windows.Forms.Button();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Order_Date = new Ansaripour.Rtl_Date();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.GroupBox5 = new System.Windows.Forms.GroupBox();
            this.Button_Order = new System.Windows.Forms.Button();
            this.Order_Service_Description = new System.Windows.Forms.RichTextBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Order_Service_End_Time = new Ansaripour.Rtl_Time();
            this.Order_Service_End_Date = new Ansaripour.Rtl_Date();
            this.Order_Service_Start_Date = new Ansaripour.Rtl_Date();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.Dv_Request = new System.Windows.Forms.DataGridView();
            this.TabPage3 = new System.Windows.Forms.TabPage();
            this.Order_Pay = new System.Windows.Forms.TextBox();
            this.Order_PrePayment = new System.Windows.Forms.TextBox();
            this.Order_Factor = new System.Windows.Forms.TextBox();
            this.Order_Tax = new System.Windows.Forms.TextBox();
            this.Order_Discount = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Types = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.Dv_Details = new System.Windows.Forms.DataGridView();
            this.SplitContainer2 = new System.Windows.Forms.SplitContainer();
            this.SplitContainer3 = new System.Windows.Forms.SplitContainer();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Dv1 = new System.Windows.Forms.DataGridView();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.Dv2 = new System.Windows.Forms.DataGridView();
            this.DV = new System.Windows.Forms.DataGridView();
            this.ToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.SplitContainer1).BeginInit();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.GroupBox5.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.Dv_Request).BeginInit();
            this.TabPage3.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.Dv_Details).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.SplitContainer2).BeginInit();
            this.SplitContainer2.Panel1.SuspendLayout();
            this.SplitContainer2.Panel2.SuspendLayout();
            this.SplitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.SplitContainer3).BeginInit();
            this.SplitContainer3.Panel1.SuspendLayout();
            this.SplitContainer3.Panel2.SuspendLayout();
            this.SplitContainer3.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.Dv1).BeginInit();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.Dv2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.DV).BeginInit();
            this.SuspendLayout();
            //
            //ToolStrip1
            //
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.B_Order_Add, this.Edit_B, this.Delet_B, this.Save_B, this.Search_B, this.B_Excel, this.B_Picture, this.ToolStripDropDownButton1, this.Abort_B });
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ToolStrip1.Size = new System.Drawing.Size(1097, 25);
            this.ToolStrip1.TabIndex = 197;
            this.ToolStrip1.Text = "ToolStrip1";
            //
            //B_Order_Add
            //
            this.B_Order_Add.Image = (System.Drawing.Image)resources.GetObject("B_Order_Add.Image");
            this.B_Order_Add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.B_Order_Add.Name = "B_Order_Add";
            this.B_Order_Add.Size = new System.Drawing.Size(86, 22);
            this.B_Order_Add.Text = "ثبت سفارش";
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
            //Search_B
            //
            this.Search_B.Image = (System.Drawing.Image)resources.GetObject("Search_B.Image");
            this.Search_B.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Search_B.Name = "Search_B";
            this.Search_B.Size = new System.Drawing.Size(61, 22);
            this.Search_B.Text = "جستجو";
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
            //ToolStripDropDownButton1
            //
            this.ToolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.Report_Order_Add, this.ToolStripSeparator1, this.CHEK, this.Report_Order_Factor });
            this.ToolStripDropDownButton1.Image = (System.Drawing.Image)resources.GetObject("ToolStripDropDownButton1.Image");
            this.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1";
            this.ToolStripDropDownButton1.Size = new System.Drawing.Size(57, 22);
            this.ToolStripDropDownButton1.Text = "چاپ";
            //
            //Report_Order_Add
            //
            this.Report_Order_Add.Name = "Report_Order_Add";
            this.Report_Order_Add.Size = new System.Drawing.Size(204, 22);
            this.Report_Order_Add.Text = "چاپ سـفـارش";
            //
            //ToolStripSeparator1
            //
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(201, 6);
            //
            //CHEK
            //
            this.CHEK.Name = "CHEK";
            this.CHEK.Size = new System.Drawing.Size(204, 22);
            this.CHEK.Text = "چـــــــــــاپ  برنامه ریزی تولید";
            //
            //Report_Order_Factor
            //
            this.Report_Order_Factor.Name = "Report_Order_Factor";
            this.Report_Order_Factor.Size = new System.Drawing.Size(204, 22);
            this.Report_Order_Factor.Text = "چـــــــــــاپ فاکتور";
            //
            //Abort_B
            //
            this.Abort_B.Image = (System.Drawing.Image)resources.GetObject("Abort_B.Image");
            this.Abort_B.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Abort_B.Name = "Abort_B";
            this.Abort_B.Size = new System.Drawing.Size(64, 22);
            this.Abort_B.Text = "انصراف";
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
            this.SplitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.SplitContainer1.Panel1.Controls.Add(this.ToolStrip1);
            this.SplitContainer1.Panel1.Controls.Add(this.TabControl1);
            this.SplitContainer1.Panel1.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.SplitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            //
            //SplitContainer1.Panel2
            //
            this.SplitContainer1.Panel2.Controls.Add(this.SplitContainer2);
            this.SplitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SplitContainer1.Size = new System.Drawing.Size(1097, 525);
            this.SplitContainer1.SplitterDistance = 227;
            this.SplitContainer1.TabIndex = 65;
            //
            //TabControl1
            //
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Controls.Add(this.TabPage3);
            this.TabControl1.Location = new System.Drawing.Point(0, 25);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.RightToLeftLayout = true;
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(1097, 261);
            this.TabControl1.TabIndex = 198;
            //
            //TabPage1
            //
            this.TabPage1.Controls.Add(this.Order_Number);
            this.TabPage1.Controls.Add(this.Order_Subscription);
            this.TabPage1.Controls.Add(this.Order_Description);
            this.TabPage1.Controls.Add(this.Label16);
            this.TabPage1.Controls.Add(this.Order_In_Description);
            this.TabPage1.Controls.Add(this.Label15);
            this.TabPage1.Controls.Add(this.Order_Time);
            this.TabPage1.Controls.Add(this.Label1);
            this.TabPage1.Controls.Add(this.Label9);
            this.TabPage1.Controls.Add(this.B_Order_Subscription);
            this.TabPage1.Controls.Add(this.Label5);
            this.TabPage1.Controls.Add(this.Label3);
            this.TabPage1.Controls.Add(this.Order_Date);
            this.TabPage1.Location = new System.Drawing.Point(4, 28);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(1089, 229);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "ثبت سفارش";
            this.TabPage1.UseVisualStyleBackColor = true;
            //
            //Order_Number
            //
            this.Order_Number.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Order_Number.Location = new System.Drawing.Point(889, 11);
            this.Order_Number.Name = "Order_Number";
            this.Order_Number.Size = new System.Drawing.Size(117, 27);
            this.Order_Number.TabIndex = 336;
            //
            //Order_Subscription
            //
            this.Order_Subscription.Enabled = false;
            this.Order_Subscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Order_Subscription.Location = new System.Drawing.Point(37, 8);
            this.Order_Subscription.Name = "Order_Subscription";
            this.Order_Subscription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Order_Subscription.Size = new System.Drawing.Size(417, 31);
            this.Order_Subscription.TabIndex = 335;
            //
            //Order_Description
            //
            this.Order_Description.Location = new System.Drawing.Point(6, 78);
            this.Order_Description.Name = "Order_Description";
            this.Order_Description.Size = new System.Drawing.Size(531, 93);
            this.Order_Description.TabIndex = 222;
            this.Order_Description.Text = "";
            //
            //Label16
            //
            this.Label16.AutoSize = true;
            this.Label16.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label16.Location = new System.Drawing.Point(400, 52);
            this.Label16.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label16.Name = "Label16";
            this.Label16.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label16.Size = new System.Drawing.Size(133, 23);
            this.Label16.TabIndex = 221;
            this.Label16.Text = "شرح سفارش :";
            //
            //Order_In_Description
            //
            this.Order_In_Description.Location = new System.Drawing.Point(544, 80);
            this.Order_In_Description.Name = "Order_In_Description";
            this.Order_In_Description.Size = new System.Drawing.Size(535, 91);
            this.Order_In_Description.TabIndex = 220;
            this.Order_In_Description.Text = "";
            //
            //Label15
            //
            this.Label15.AutoSize = true;
            this.Label15.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label15.Location = new System.Drawing.Point(1006, 11);
            this.Label15.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label15.Name = "Label15";
            this.Label15.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label15.Size = new System.Drawing.Size(76, 23);
            this.Label15.TabIndex = 219;
            this.Label15.Text = "شماره :";
            this.Label15.TextAlign = System.Drawing.ContentAlignment.TopRight;
            //
            //Order_Time
            //
            this.Order_Time.Enabled = false;
            this.Order_Time.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Order_Time.Location = new System.Drawing.Point(531, 11);
            this.Order_Time.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Order_Time.Name = "Order_Time";
            this.Order_Time.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Order_Time.Size = new System.Drawing.Size(129, 27);
            this.Order_Time.TabIndex = 217;
            //
            //Label1
            //
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label1.Location = new System.Drawing.Point(659, 12);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(59, 23);
            this.Label1.TabIndex = 216;
            this.Label1.Text = "زمان :";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            //Label9
            //
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label9.Location = new System.Drawing.Point(830, 11);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(59, 23);
            this.Label9.TabIndex = 215;
            this.Label9.Text = "تاریخ :";
            this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            //B_Order_Subscription
            //
            this.B_Order_Subscription.Image = (System.Drawing.Image)resources.GetObject("B_Order_Subscription.Image");
            this.B_Order_Subscription.Location = new System.Drawing.Point(7, 10);
            this.B_Order_Subscription.Name = "B_Order_Subscription";
            this.B_Order_Subscription.Size = new System.Drawing.Size(29, 27);
            this.B_Order_Subscription.TabIndex = 213;
            this.B_Order_Subscription.UseVisualStyleBackColor = true;
            //
            //Label5
            //
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label5.Location = new System.Drawing.Point(454, 12);
            this.Label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label5.Name = "Label5";
            this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label5.Size = new System.Drawing.Size(77, 23);
            this.Label5.TabIndex = 212;
            this.Label5.Text = "شرکت :";
            //
            //Label3
            //
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label3.Location = new System.Drawing.Point(889, 54);
            this.Label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label3.Size = new System.Drawing.Size(191, 23);
            this.Label3.TabIndex = 210;
            this.Label3.Text = "شرح کالای وارد شده :";
            //
            //Order_Date
            //
            this.Order_Date.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Order_Date.AutoSize = true;
            this.Order_Date.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Order_Date.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Order_Date.Location = new System.Drawing.Point(720, 8);
            this.Order_Date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Order_Date.Name = "Order_Date";
            this.Order_Date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Order_Date.Size = new System.Drawing.Size(136, 32);
            this.Order_Date.T_D = "";
            this.Order_Date.TabIndex = 214;
            //
            //TabPage2
            //
            this.TabPage2.Controls.Add(this.GroupBox5);
            this.TabPage2.Controls.Add(this.GroupBox4);
            this.TabPage2.Location = new System.Drawing.Point(4, 28);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(1089, 229);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "برگ درخواست و برنامه ریزی تولید";
            this.TabPage2.UseVisualStyleBackColor = true;
            //
            //GroupBox5
            //
            this.GroupBox5.Controls.Add(this.Button_Order);
            this.GroupBox5.Controls.Add(this.Order_Service_Description);
            this.GroupBox5.Controls.Add(this.Label12);
            this.GroupBox5.Controls.Add(this.Label8);
            this.GroupBox5.Controls.Add(this.Label10);
            this.GroupBox5.Controls.Add(this.Order_Service_End_Time);
            this.GroupBox5.Controls.Add(this.Order_Service_End_Date);
            this.GroupBox5.Controls.Add(this.Order_Service_Start_Date);
            this.GroupBox5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.GroupBox5.Location = new System.Drawing.Point(6, 6);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Size = new System.Drawing.Size(535, 166);
            this.GroupBox5.TabIndex = 1;
            this.GroupBox5.TabStop = false;
            this.GroupBox5.Text = "برنامه ریزی تولید";
            //
            //Button_Order
            //
            this.Button_Order.Image = (System.Drawing.Image)resources.GetObject("Button_Order.Image");
            this.Button_Order.Location = new System.Drawing.Point(409, 0);
            this.Button_Order.Name = "Button_Order";
            this.Button_Order.Size = new System.Drawing.Size(25, 17);
            this.Button_Order.TabIndex = 232;
            this.Button_Order.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Button_Order.UseVisualStyleBackColor = true;
            //
            //Order_Service_Description
            //
            this.Order_Service_Description.Location = new System.Drawing.Point(6, 55);
            this.Order_Service_Description.Name = "Order_Service_Description";
            this.Order_Service_Description.Size = new System.Drawing.Size(520, 105);
            this.Order_Service_Description.TabIndex = 231;
            this.Order_Service_Description.Text = "";
            //
            //Label12
            //
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label12.Location = new System.Drawing.Point(317, 22);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(44, 19);
            this.Label12.TabIndex = 223;
            this.Label12.Text = "پایان:";
            this.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            //Label8
            //
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label8.Location = new System.Drawing.Point(64, 22);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(142, 19);
            this.Label8.TabIndex = 220;
            this.Label8.Text = "مدت زمان انجام کار:";
            this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            //Label10
            //
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label10.Location = new System.Drawing.Point(475, 22);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(55, 19);
            this.Label10.TabIndex = 219;
            this.Label10.Text = "شروع:";
            this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            //Order_Service_End_Time
            //
            this.Order_Service_End_Time.Location = new System.Drawing.Point(5, 15);
            this.Order_Service_End_Time.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Order_Service_End_Time.Name = "Order_Service_End_Time";
            this.Order_Service_End_Time.Size = new System.Drawing.Size(59, 44);
            this.Order_Service_End_Time.T_Text = "  :";
            this.Order_Service_End_Time.TabIndex = 229;
            //
            //Order_Service_End_Date
            //
            this.Order_Service_End_Date.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Order_Service_End_Date.AutoSize = true;
            this.Order_Service_End_Date.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Order_Service_End_Date.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Order_Service_End_Date.Location = new System.Drawing.Point(214, 18);
            this.Order_Service_End_Date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Order_Service_End_Date.Name = "Order_Service_End_Date";
            this.Order_Service_End_Date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Order_Service_End_Date.Size = new System.Drawing.Size(136, 32);
            this.Order_Service_End_Date.T_D = "";
            this.Order_Service_End_Date.TabIndex = 222;
            //
            //Order_Service_Start_Date
            //
            this.Order_Service_Start_Date.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Order_Service_Start_Date.AutoSize = true;
            this.Order_Service_Start_Date.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Order_Service_Start_Date.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Order_Service_Start_Date.Location = new System.Drawing.Point(371, 18);
            this.Order_Service_Start_Date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Order_Service_Start_Date.Name = "Order_Service_Start_Date";
            this.Order_Service_Start_Date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Order_Service_Start_Date.Size = new System.Drawing.Size(136, 32);
            this.Order_Service_Start_Date.T_D = "";
            this.Order_Service_Start_Date.TabIndex = 218;
            //
            //GroupBox4
            //
            this.GroupBox4.Controls.Add(this.Dv_Request);
            this.GroupBox4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.GroupBox4.Location = new System.Drawing.Point(544, 6);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(537, 166);
            this.GroupBox4.TabIndex = 0;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "درخواست کالا از انبار :";
            //
            //Dv_Request
            //
            DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            DataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dv_Request.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1;
            this.Dv_Request.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            DataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dv_Request.DefaultCellStyle = DataGridViewCellStyle2;
            this.Dv_Request.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dv_Request.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.Dv_Request.Location = new System.Drawing.Point(3, 19);
            this.Dv_Request.Name = "Dv_Request";
            this.Dv_Request.Size = new System.Drawing.Size(531, 144);
            this.Dv_Request.TabIndex = 254;
            //
            //TabPage3
            //
            this.TabPage3.Controls.Add(this.Order_Pay);
            this.TabPage3.Controls.Add(this.Order_PrePayment);
            this.TabPage3.Controls.Add(this.Order_Factor);
            this.TabPage3.Controls.Add(this.Order_Tax);
            this.TabPage3.Controls.Add(this.Order_Discount);
            this.TabPage3.Controls.Add(this.Label7);
            this.TabPage3.Controls.Add(this.Label6);
            this.TabPage3.Controls.Add(this.Label4);
            this.TabPage3.Controls.Add(this.Label2);
            this.TabPage3.Controls.Add(this.Types);
            this.TabPage3.Controls.Add(this.Label13);
            this.TabPage3.Controls.Add(this.GroupBox3);
            this.TabPage3.Location = new System.Drawing.Point(4, 28);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Size = new System.Drawing.Size(1089, 229);
            this.TabPage3.TabIndex = 3;
            this.TabPage3.Text = "صورتحساب مالی";
            this.TabPage3.UseVisualStyleBackColor = true;
            //
            //Order_Pay
            //
            this.Order_Pay.BackColor = System.Drawing.Color.White;
            this.Order_Pay.Enabled = false;
            this.Order_Pay.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Order_Pay.Location = new System.Drawing.Point(13, 143);
            this.Order_Pay.MaxLength = 15;
            this.Order_Pay.Name = "Order_Pay";
            this.Order_Pay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Order_Pay.Size = new System.Drawing.Size(195, 30);
            this.Order_Pay.TabIndex = 252;
            this.Order_Pay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            //
            //Order_PrePayment
            //
            this.Order_PrePayment.BackColor = System.Drawing.Color.White;
            this.Order_PrePayment.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Order_PrePayment.Location = new System.Drawing.Point(13, 38);
            this.Order_PrePayment.MaxLength = 15;
            this.Order_PrePayment.Name = "Order_PrePayment";
            this.Order_PrePayment.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Order_PrePayment.Size = new System.Drawing.Size(195, 30);
            this.Order_PrePayment.TabIndex = 250;
            this.Order_PrePayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            //
            //Order_Factor
            //
            this.Order_Factor.BackColor = System.Drawing.Color.White;
            this.Order_Factor.Enabled = false;
            this.Order_Factor.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Order_Factor.Location = new System.Drawing.Point(13, 5);
            this.Order_Factor.MaxLength = 15;
            this.Order_Factor.Name = "Order_Factor";
            this.Order_Factor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Order_Factor.Size = new System.Drawing.Size(195, 30);
            this.Order_Factor.TabIndex = 248;
            this.Order_Factor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            //
            //Order_Tax
            //
            this.Order_Tax.BackColor = System.Drawing.Color.White;
            this.Order_Tax.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Order_Tax.Location = new System.Drawing.Point(13, 107);
            this.Order_Tax.MaxLength = 15;
            this.Order_Tax.Name = "Order_Tax";
            this.Order_Tax.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Order_Tax.Size = new System.Drawing.Size(195, 30);
            this.Order_Tax.TabIndex = 246;
            this.Order_Tax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            //
            //Order_Discount
            //
            this.Order_Discount.BackColor = System.Drawing.Color.White;
            this.Order_Discount.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Order_Discount.Location = new System.Drawing.Point(13, 72);
            this.Order_Discount.MaxLength = 15;
            this.Order_Discount.Name = "Order_Discount";
            this.Order_Discount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Order_Discount.Size = new System.Drawing.Size(195, 30);
            this.Order_Discount.TabIndex = 243;
            this.Order_Discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            //
            //Label7
            //
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label7.Location = new System.Drawing.Point(215, 149);
            this.Label7.Name = "Label7";
            this.Label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label7.Size = new System.Drawing.Size(101, 19);
            this.Label7.TabIndex = 253;
            this.Label7.Text = "قابل پرداخت :";
            //
            //Label6
            //
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label6.Location = new System.Drawing.Point(215, 44);
            this.Label6.Name = "Label6";
            this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label6.Size = new System.Drawing.Size(104, 19);
            this.Label6.TabIndex = 251;
            this.Label6.Text = "پیش پرداخت :";
            //
            //Label4
            //
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label4.Location = new System.Drawing.Point(215, 11);
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label4.Size = new System.Drawing.Size(94, 19);
            this.Label4.TabIndex = 249;
            this.Label4.Text = "جمع فاکتور :";
            //
            //Label2
            //
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label2.Location = new System.Drawing.Point(214, 113);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label2.Size = new System.Drawing.Size(100, 19);
            this.Label2.TabIndex = 247;
            this.Label2.Text = "ارزش افزوده :";
            //
            //Types
            //
            this.Types.AutoSize = true;
            this.Types.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Types.ForeColor = System.Drawing.Color.Red;
            this.Types.Location = new System.Drawing.Point(322, 154);
            this.Types.Name = "Types";
            this.Types.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Types.Size = new System.Drawing.Size(34, 19);
            this.Types.TabIndex = 245;
            this.Types.Text = "ریال";
            this.Types.TextAlign = System.Drawing.ContentAlignment.TopRight;
            //
            //Label13
            //
            this.Label13.AutoSize = true;
            this.Label13.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label13.Location = new System.Drawing.Point(214, 78);
            this.Label13.Name = "Label13";
            this.Label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label13.Size = new System.Drawing.Size(64, 19);
            this.Label13.TabIndex = 244;
            this.Label13.Text = "تخفیف :";
            //
            //GroupBox3
            //
            this.GroupBox3.Controls.Add(this.Dv_Details);
            this.GroupBox3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.GroupBox3.Location = new System.Drawing.Point(322, 3);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(759, 151);
            this.GroupBox3.TabIndex = 0;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "شزح فاکتور :";
            //
            //Dv_Details
            //
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            DataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dv_Details.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3;
            this.Dv_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            DataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dv_Details.DefaultCellStyle = DataGridViewCellStyle4;
            this.Dv_Details.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dv_Details.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.Dv_Details.Location = new System.Drawing.Point(3, 19);
            this.Dv_Details.Name = "Dv_Details";
            this.Dv_Details.Size = new System.Drawing.Size(753, 129);
            this.Dv_Details.TabIndex = 254;
            //
            //SplitContainer2
            //
            this.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer2.Location = new System.Drawing.Point(0, 0);
            this.SplitContainer2.Name = "SplitContainer2";
            this.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            //
            //SplitContainer2.Panel1
            //
            this.SplitContainer2.Panel1.Controls.Add(this.SplitContainer3);
            this.SplitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            //
            //SplitContainer2.Panel2
            //
            this.SplitContainer2.Panel2.Controls.Add(this.DV);
            this.SplitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SplitContainer2.Size = new System.Drawing.Size(1097, 294);
            this.SplitContainer2.SplitterDistance = 157;
            this.SplitContainer2.TabIndex = 0;
            //
            //SplitContainer3
            //
            this.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer3.Location = new System.Drawing.Point(0, 0);
            this.SplitContainer3.Name = "SplitContainer3";
            //
            //SplitContainer3.Panel1
            //
            this.SplitContainer3.Panel1.Controls.Add(this.GroupBox1);
            this.SplitContainer3.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            //
            //SplitContainer3.Panel2
            //
            this.SplitContainer3.Panel2.Controls.Add(this.GroupBox2);
            this.SplitContainer3.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SplitContainer3.Size = new System.Drawing.Size(1097, 157);
            this.SplitContainer3.SplitterDistance = 549;
            this.SplitContainer3.TabIndex = 0;
            //
            //GroupBox1
            //
            this.GroupBox1.Controls.Add(this.Dv1);
            this.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBox1.Location = new System.Drawing.Point(0, 0);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(549, 157);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "خدمات مورد نیاز :";
            //
            //Dv1
            //
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            DataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dv1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5;
            this.Dv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            DataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dv1.DefaultCellStyle = DataGridViewCellStyle6;
            this.Dv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dv1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.Dv1.Location = new System.Drawing.Point(3, 19);
            this.Dv1.Name = "Dv1";
            this.Dv1.Size = new System.Drawing.Size(543, 135);
            this.Dv1.TabIndex = 253;
            //
            //GroupBox2
            //
            this.GroupBox2.Controls.Add(this.Dv2);
            this.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBox2.Location = new System.Drawing.Point(0, 0);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(544, 157);
            this.GroupBox2.TabIndex = 0;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "خدمات خارج از کارگاه :";
            //
            //Dv2
            //
            DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            DataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dv2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7;
            this.Dv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            DataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dv2.DefaultCellStyle = DataGridViewCellStyle8;
            this.Dv2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dv2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.Dv2.Location = new System.Drawing.Point(3, 19);
            this.Dv2.Name = "Dv2";
            this.Dv2.Size = new System.Drawing.Size(538, 135);
            this.Dv2.TabIndex = 253;
            //
            //DV
            //
            DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            DataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9;
            this.DV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            DataGridViewCellStyle10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DV.DefaultCellStyle = DataGridViewCellStyle10;
            this.DV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.DV.Location = new System.Drawing.Point(0, 0);
            this.DV.Name = "DV";
            this.DV.Size = new System.Drawing.Size(1097, 133);
            this.DV.TabIndex = 253;
            //
            //Order_Add
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(12.0F, 25.0F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1097, 525);
            this.Controls.Add(this.SplitContainer1);
            this.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.Name = "Order_Add";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ثبت سفارش";
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.SplitContainer1.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel1.PerformLayout();
            this.SplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.SplitContainer1).EndInit();
            this.SplitContainer1.ResumeLayout(false);
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.TabPage2.ResumeLayout(false);
            this.GroupBox5.ResumeLayout(false);
            this.GroupBox5.PerformLayout();
            this.GroupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.Dv_Request).EndInit();
            this.TabPage3.ResumeLayout(false);
            this.TabPage3.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.Dv_Details).EndInit();
            this.SplitContainer2.Panel1.ResumeLayout(false);
            this.SplitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.SplitContainer2).EndInit();
            this.SplitContainer2.ResumeLayout(false);
            this.SplitContainer3.Panel1.ResumeLayout(false);
            this.SplitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.SplitContainer3).EndInit();
            this.SplitContainer3.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.Dv1).EndInit();
            this.GroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.Dv2).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.DV).EndInit();
            this.ResumeLayout(false);

        }
        internal System.Windows.Forms.SplitContainer SplitContainer1;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton Edit_B;
        internal System.Windows.Forms.ToolStripButton Delet_B;
        internal System.Windows.Forms.ToolStripButton Save_B;
        internal System.Windows.Forms.ToolStripButton Search_B;
        internal System.Windows.Forms.ToolStripButton Abort_B;
        internal System.Windows.Forms.TabControl TabControl1;
        internal System.Windows.Forms.TabPage TabPage1;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Button B_Order_Subscription;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label3;
        internal Ansaripour.Rtl_Date Order_Date;
        internal System.Windows.Forms.TabPage TabPage2;
        internal System.Windows.Forms.TabPage TabPage3;
        internal System.Windows.Forms.ToolStripButton B_Picture;
        internal System.Windows.Forms.ToolStripButton B_Excel;
        internal System.Windows.Forms.RichTextBox Order_Description;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.RichTextBox Order_In_Description;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.MaskedTextBox Order_Time;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.SplitContainer SplitContainer2;
        internal System.Windows.Forms.SplitContainer SplitContainer3;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.DataGridView Dv1;
        internal System.Windows.Forms.DataGridView Dv2;
        internal System.Windows.Forms.DataGridView DV;
        internal System.Windows.Forms.TextBox Order_Subscription;
        internal System.Windows.Forms.GroupBox GroupBox4;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.Label Types;
        internal System.Windows.Forms.TextBox Order_Discount;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.DataGridView Dv_Details;
        internal System.Windows.Forms.TextBox Order_Pay;
        internal System.Windows.Forms.TextBox Order_PrePayment;
        internal System.Windows.Forms.TextBox Order_Factor;
        internal System.Windows.Forms.TextBox Order_Tax;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.DataGridView Dv_Request;
        internal System.Windows.Forms.GroupBox GroupBox5;
        internal System.Windows.Forms.ToolStripDropDownButton ToolStripDropDownButton1;
        internal System.Windows.Forms.ToolStripMenuItem Report_Order_Add;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripMenuItem CHEK;
        internal System.Windows.Forms.ToolStripMenuItem Report_Order_Factor;
        internal System.Windows.Forms.Label Label12;
        internal Ansaripour.Rtl_Date Order_Service_End_Date;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label10;
        internal Ansaripour.Rtl_Date Order_Service_Start_Date;
        internal Ansaripour.Rtl_Time Order_Service_End_Time;
        internal System.Windows.Forms.RichTextBox Order_Service_Description;
        internal System.Windows.Forms.Button Button_Order;
        internal System.Windows.Forms.ToolStripButton B_Order_Add;
        internal System.Windows.Forms.TextBox Order_Number;
    }
}