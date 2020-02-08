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
    public partial class Accounting : System.Windows.Forms.Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accounting));
            System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.New_B = new System.Windows.Forms.ToolStripButton();
            this.Edit_B = new System.Windows.Forms.ToolStripButton();
            this.Delet_B = new System.Windows.Forms.ToolStripButton();
            this.Save_B = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.First_B = new System.Windows.Forms.ToolStripButton();
            this.Next_B = new System.Windows.Forms.ToolStripButton();
            this.Accounting_Header_Number = new System.Windows.Forms.ToolStripTextBox();
            this.Preview_B = new System.Windows.Forms.ToolStripButton();
            this.Lt_B = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Print_B = new System.Windows.Forms.ToolStripButton();
            this.Accounting_Header_Cls = new System.Windows.Forms.ToolStripComboBox();
            this.Picture_B = new System.Windows.Forms.ToolStripButton();
            this.Excel_B = new System.Windows.Forms.ToolStripButton();
            this.Log_File = new System.Windows.Forms.ToolStripButton();
            this.Abort_B = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.HelpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.B_Header_Number = new System.Windows.Forms.Button();
            this.Label21 = new System.Windows.Forms.Label();
            this.Header_Number = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Accounting_Header_Description = new System.Windows.Forms.TextBox();
            this.Accounting_Header_Date = new Ansaripour.Rtl_Date();
            this.Label1 = new System.Windows.Forms.Label();
            this.SplitContainer2 = new System.Windows.Forms.SplitContainer();
            this.Dv_Accounting = new Ansaripour.MyDataGridView();
            this.SplitContainer3 = new System.Windows.Forms.SplitContainer();
            this.Types = new System.Windows.Forms.Label();
            this.Label20 = new System.Windows.Forms.Label();
            this.Label19 = new System.Windows.Forms.Label();
            this.Label17 = new System.Windows.Forms.Label();
            this.Total_Debtor = new System.Windows.Forms.TextBox();
            this.Total_Creditor = new System.Windows.Forms.TextBox();
            this.Amount = new System.Windows.Forms.TextBox();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.Accounting_Details_Detailed_Five_Main = new System.Windows.Forms.TextBox();
            this.B_Accounting_Details_Detailed_Five_Main = new System.Windows.Forms.Button();
            this.Label7 = new System.Windows.Forms.Label();
            this.Accounting_Details_Detailed_Four_Main = new System.Windows.Forms.TextBox();
            this.B_Accounting_Details_Detailed_Four_Main = new System.Windows.Forms.Button();
            this.Label8 = new System.Windows.Forms.Label();
            this.Accounting_Details_Detailed_Three_Main = new System.Windows.Forms.TextBox();
            this.B_Accounting_Details_Detailed_Three_Main = new System.Windows.Forms.Button();
            this.Label5 = new System.Windows.Forms.Label();
            this.Accounting_Details_Detailed_Two_Main = new System.Windows.Forms.TextBox();
            this.B_Accounting_Details_Detailed_Two_Main = new System.Windows.Forms.Button();
            this.Label6 = new System.Windows.Forms.Label();
            this.Accounting_Details_Detailed_One_Main = new System.Windows.Forms.TextBox();
            this.B_Accounting_Details_Detailed_One_Main = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.Accounting_Details_Acc_Main = new System.Windows.Forms.TextBox();
            this.B_Accounting_Details_Acc_Main = new System.Windows.Forms.Button();
            this.Label13 = new System.Windows.Forms.Label();
            this.Accounting_Details_Description_Main = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.Accounting_Details_Number_Turning_Main = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.Accounting_Details_Number_Due_Main = new System.Windows.Forms.TextBox();
            this.Estehlak_Label = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Accounting_Details_Date_Due_Main = new Ansaripour.Rtl_Date();
            this.Accounting_Details_Date_Cost_Main = new Ansaripour.Rtl_Date();
            this.TabPage3 = new System.Windows.Forms.TabPage();
            this.TextBox12 = new System.Windows.Forms.TextBox();
            this.Label18 = new System.Windows.Forms.Label();
            this.TextBox9 = new System.Windows.Forms.TextBox();
            this.Label15 = new System.Windows.Forms.Label();
            this.TextBox10 = new System.Windows.Forms.TextBox();
            this.Label16 = new System.Windows.Forms.Label();
            this.TextBox8 = new System.Windows.Forms.TextBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.Estate_Name = new System.Windows.Forms.TextBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.ToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.SplitContainer1).BeginInit();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.SplitContainer2).BeginInit();
            this.SplitContainer2.Panel1.SuspendLayout();
            this.SplitContainer2.Panel2.SuspendLayout();
            this.SplitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.Dv_Accounting).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.SplitContainer3).BeginInit();
            this.SplitContainer3.Panel1.SuspendLayout();
            this.SplitContainer3.Panel2.SuspendLayout();
            this.SplitContainer3.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.TabPage3.SuspendLayout();
            this.SuspendLayout();


            //
            //ToolStripSeparator2
            //
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            this.ToolStripSeparator2.Visible = false;
            //
            //New_B
            //
            this.New_B.Image = (System.Drawing.Image)resources.GetObject("New_B.Image");
            this.New_B.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.New_B.Name = "New_B";
            this.New_B.Size = new System.Drawing.Size(55, 22);
            this.New_B.Text = "جدید";
            //
            //Edit_B
            //
            this.Edit_B.Image = (System.Drawing.Image)resources.GetObject("Edit_B.Image");
            this.Edit_B.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Edit_B.Name = "Edit_B";
            this.Edit_B.Size = new System.Drawing.Size(66, 22);
            this.Edit_B.Text = "ویرایش";
            //
            //Delet_B
            //
            this.Delet_B.Image = (System.Drawing.Image)resources.GetObject("Delet_B.Image");
            this.Delet_B.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Delet_B.Name = "Delet_B";
            this.Delet_B.Size = new System.Drawing.Size(55, 22);
            this.Delet_B.Text = "حذف";
            this.Delet_B.ToolTipText = "حذف";
            //
            //Save_B
            //
            this.Save_B.Enabled = false;
            this.Save_B.Image = (System.Drawing.Image)resources.GetObject("Save_B.Image");
            this.Save_B.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Save_B.Name = "Save_B";
            this.Save_B.Size = new System.Drawing.Size(59, 22);
            this.Save_B.Text = "ذخیره";
            //
            //ToolStripSeparator1
            //
            this.ToolStripSeparator1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            //
            //First_B
            //
            this.First_B.Image = (System.Drawing.Image)resources.GetObject("First_B.Image");
            this.First_B.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.First_B.Name = "First_B";
            this.First_B.Size = new System.Drawing.Size(50, 22);
            this.First_B.Text = "ابتدا";
            //
            //Next_B
            //
            this.Next_B.Image = (System.Drawing.Image)resources.GetObject("Next_B.Image");
            this.Next_B.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Next_B.Name = "Next_B";
            this.Next_B.Size = new System.Drawing.Size(56, 22);
            this.Next_B.Text = "بعدی";
            //
            //Accounting_Header_Number
            //
            this.Accounting_Header_Number.BackColor = System.Drawing.SystemColors.Window;
            this.Accounting_Header_Number.Name = "Accounting_Header_Number";
            this.Accounting_Header_Number.Size = new System.Drawing.Size(50, 25);
            //
            //Preview_B
            //
            this.Preview_B.Image = (System.Drawing.Image)resources.GetObject("Preview_B.Image");
            this.Preview_B.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Preview_B.Name = "Preview_B";
            this.Preview_B.Size = new System.Drawing.Size(56, 22);
            this.Preview_B.Text = "قبلی";
            ////
            ////Last_B
            ////
            //this.Last_B.Image = (System.Drawing.Image)resources.GetObject("Last_B.Image");
            //this.Last_B.ImageTransparentColor = System.Drawing.Color.Magenta;
            //this.Last_B.Name = "Last_B";
            //this.Last_B.Size = new System.Drawing.Size(51, 22);
            //this.Last_B.Text = "انتها";
            ////
            //ToolStripSeparator3
            //
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            this.ToolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            //
            //Print_B
            //
            this.Print_B.Image = (System.Drawing.Image)resources.GetObject("Print_B.Image");
            this.Print_B.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Print_B.Name = "Print_B";
            this.Print_B.Size = new System.Drawing.Size(52, 22);
            this.Print_B.Text = "چاپ";
            //
            //Accounting_Header_Class
            //
//            this.Accounting_Header_Class.Items.AddRange(new object[] { "عـــــــــــــــــــادی", "پــــیش نویس", "افتتاحیــــــــــــه ", "بستن حساب", "سود و زیـــان", "اختتامیــــــــــــه" });
  //          this.Accounting_Header_Class.Name = "Accounting_Header_Class";
    //        this.Accounting_Header_Class.Size = new System.Drawing.Size(120, 25);
            //
            //Picture_B
            //
            this.Picture_B.Image = (System.Drawing.Image)resources.GetObject("Picture_B.Image");
            this.Picture_B.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Picture_B.Name = "Picture_B";
            this.Picture_B.Size = new System.Drawing.Size(57, 22);
            this.Picture_B.Text = "تصویر";
            //
            //Excel_B
            //
            this.Excel_B.Image = (System.Drawing.Image)resources.GetObject("Excel_B.Image");
            this.Excel_B.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Excel_B.Name = "Excel_B";
            this.Excel_B.Size = new System.Drawing.Size(60, 22);
            this.Excel_B.Text = "اکسل";
            //
            //Log_File
            //
            this.Log_File.Image = (System.Drawing.Image)resources.GetObject("Log_File.Image");
            this.Log_File.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Log_File.Name = "Log_File";
            this.Log_File.Size = new System.Drawing.Size(92, 22);
            this.Log_File.Text = "کنترل اسناد";
            //
            //Abort_B
            //
            this.Abort_B.Image = (System.Drawing.Image)resources.GetObject("Abort_B.Image");
            this.Abort_B.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Abort_B.Name = "Abort_B";
            this.Abort_B.Size = new System.Drawing.Size(64, 22);
            this.Abort_B.Text = "انصراف";
            //
            //toolStripSeparator
            //
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            //
            //HelpToolStripButton
            //
            this.HelpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HelpToolStripButton.Image = (System.Drawing.Image)resources.GetObject("HelpToolStripButton.Image");
            this.HelpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HelpToolStripButton.Name = "HelpToolStripButton";
            this.HelpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.HelpToolStripButton.Text = "He&lp";
            //
            //SplitContainer1
            //
            this.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer1.Location = new System.Drawing.Point(0, 25);
            this.SplitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SplitContainer1.Name = "SplitContainer1";
            this.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            //
            //SplitContainer1.Panel1
            //
            this.SplitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SplitContainer1.Panel1.Controls.Add(this.B_Header_Number);
            this.SplitContainer1.Panel1.Controls.Add(this.Label21);
            this.SplitContainer1.Panel1.Controls.Add(this.Header_Number);
            this.SplitContainer1.Panel1.Controls.Add(this.Label2);
            this.SplitContainer1.Panel1.Controls.Add(this.Accounting_Header_Description);
//            this.SplitContainer1.Panel1.Controls.Add(this.Accounting_Header_Date);
            this.SplitContainer1.Panel1.Controls.Add(this.Label1);
            this.SplitContainer1.Panel1.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            //
            //SplitContainer1.Panel2
            //
            this.SplitContainer1.Panel2.Controls.Add(this.SplitContainer2);
            this.SplitContainer1.Size = new System.Drawing.Size(1198, 568);
            this.SplitContainer1.SplitterDistance = 45;
            this.SplitContainer1.SplitterWidth = 5;
            this.SplitContainer1.TabIndex = 218;
            //
            //B_Header_Number
            //
            this.B_Header_Number.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.B_Header_Number.BackgroundImage = (System.Drawing.Image)resources.GetObject("B_Header_Number.BackgroundImage");
            this.B_Header_Number.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.B_Header_Number.Location = new System.Drawing.Point(1013, 7);
            this.B_Header_Number.Name = "B_Header_Number";
            this.B_Header_Number.Size = new System.Drawing.Size(27, 27);
            this.B_Header_Number.TabIndex = 246;
            this.B_Header_Number.Text = "" + "\r" + "\n";
            this.B_Header_Number.UseVisualStyleBackColor = false;
            //
            //Label21
            //
            this.Label21.AutoSize = true;
            this.Label21.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label21.Location = new System.Drawing.Point(1134, 10);
            this.Label21.Name = "Label21";
            this.Label21.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label21.Size = new System.Drawing.Size(51, 19);
            this.Label21.TabIndex = 245;
            this.Label21.Text = "سند :";
            this.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            //Header_Number
            //
            this.Header_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Header_Number.Location = new System.Drawing.Point(1041, 7);
            this.Header_Number.Name = "Header_Number";
            this.Header_Number.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Header_Number.Size = new System.Drawing.Size(92, 26);
            this.Header_Number.TabIndex = 244;
            this.Header_Number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            //
            //Label2
            //
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label2.Location = new System.Drawing.Point(955, 10);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label2.Size = new System.Drawing.Size(50, 19);
            this.Label2.TabIndex = 21;
            this.Label2.Text = "تاریخ :";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            //Accounting_Header_Description
            //
            this.Accounting_Header_Description.BackColor = System.Drawing.Color.White;
            this.Accounting_Header_Description.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Accounting_Header_Description.Location = new System.Drawing.Point(4, 8);
            this.Accounting_Header_Description.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Accounting_Header_Description.Name = "Accounting_Header_Description";
            this.Accounting_Header_Description.Size = new System.Drawing.Size(792, 27);
            this.Accounting_Header_Description.TabIndex = 22;
            //
            //Accounting_Header_Date
            //
            this.Accounting_Header_Date.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Accounting_Header_Date.AutoSize = true;
            this.Accounting_Header_Date.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Accounting_Header_Date.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Accounting_Header_Date.Location = new System.Drawing.Point(850, 8);
            this.Accounting_Header_Date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Accounting_Header_Date.Name = "Accounting_Header_Date";
            this.Accounting_Header_Date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Accounting_Header_Date.Size = new System.Drawing.Size(136, 32);
            this.Accounting_Header_Date.T_D = "";
            this.Accounting_Header_Date.TabIndex = 19;
            //
            //Label1
            //
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label1.Location = new System.Drawing.Point(795, 11);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label1.Size = new System.Drawing.Size(48, 19);
            this.Label1.TabIndex = 20;
            this.Label1.Text = "شرح:";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            //SplitContainer2
            //
            this.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.SplitContainer2.Location = new System.Drawing.Point(0, 0);
            this.SplitContainer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SplitContainer2.Name = "SplitContainer2";
            this.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            //
            //SplitContainer2.Panel1
            //
//            this.SplitContainer2.Panel1.Controls.Add(this.Dv_Accounting);
            //
            //SplitContainer2.Panel2
            //
            this.SplitContainer2.Panel2.Controls.Add(this.SplitContainer3);
            this.SplitContainer2.Size = new System.Drawing.Size(1198, 518);
            this.SplitContainer2.SplitterDistance = 297;
            this.SplitContainer2.SplitterWidth = 5;
            this.SplitContainer2.TabIndex = 0;
            //
            //Dv_Accounting
            //
            DataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Dv_Accounting.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1;
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            DataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dv_Accounting.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2;
            this.Dv_Accounting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            DataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dv_Accounting.DefaultCellStyle = DataGridViewCellStyle3;
            this.Dv_Accounting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dv_Accounting.Location = new System.Drawing.Point(0, 0);
            this.Dv_Accounting.Name = "Dv_Accounting";
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            DataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dv_Accounting.RowHeadersDefaultCellStyle = DataGridViewCellStyle4;
            this.Dv_Accounting.Size = new System.Drawing.Size(1198, 297);
            this.Dv_Accounting.TabIndex = 1;
            //
            //SplitContainer3
            //
            this.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer3.Location = new System.Drawing.Point(0, 0);
            this.SplitContainer3.Name = "SplitContainer3";
            this.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            //
            //SplitContainer3.Panel1
            //
            this.SplitContainer3.Panel1.Controls.Add(this.Types);
            this.SplitContainer3.Panel1.Controls.Add(this.Label20);
            this.SplitContainer3.Panel1.Controls.Add(this.Label19);
            this.SplitContainer3.Panel1.Controls.Add(this.Label17);
            this.SplitContainer3.Panel1.Controls.Add(this.Total_Debtor);
            this.SplitContainer3.Panel1.Controls.Add(this.Total_Creditor);
            this.SplitContainer3.Panel1.Controls.Add(this.Amount);
            //
            //SplitContainer3.Panel2
            //
            this.SplitContainer3.Panel2.Controls.Add(this.TabControl1);
            this.SplitContainer3.Size = new System.Drawing.Size(1198, 216);
            this.SplitContainer3.SplitterDistance = 37;
            this.SplitContainer3.TabIndex = 0;
            //
            //Types
            //
            this.Types.AutoSize = true;
            this.Types.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Types.ForeColor = System.Drawing.Color.Red;
            this.Types.Location = new System.Drawing.Point(3, 8);
            this.Types.Name = "Types";
            this.Types.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Types.Size = new System.Drawing.Size(0, 19);
            this.Types.TabIndex = 243;
            this.Types.TextAlign = System.Drawing.ContentAlignment.TopRight;
            //
            //Label20
            //
            this.Label20.AutoSize = true;
            this.Label20.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label20.Location = new System.Drawing.Point(346, 7);
            this.Label20.Name = "Label20";
            this.Label20.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label20.Size = new System.Drawing.Size(102, 19);
            this.Label20.TabIndex = 238;
            this.Label20.Text = "اختلاف سند :";
            //
            //Label19
            //
            this.Label19.AutoSize = true;
            this.Label19.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label19.Location = new System.Drawing.Point(667, 7);
            this.Label19.Name = "Label19";
            this.Label19.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label19.Size = new System.Drawing.Size(157, 19);
            this.Label19.TabIndex = 237;
            this.Label19.Text = "جمع گردش بستانکار :";
            //
            //Label17
            //
            this.Label17.AutoSize = true;
            this.Label17.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label17.Location = new System.Drawing.Point(1048, 8);
            this.Label17.Name = "Label17";
            this.Label17.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label17.Size = new System.Drawing.Size(145, 19);
            this.Label17.TabIndex = 236;
            this.Label17.Text = "جمع گردش بدهکار :";
            //
            //Total_Debtor
            //
            this.Total_Debtor.Enabled = false;
            this.Total_Debtor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Total_Debtor.Location = new System.Drawing.Point(831, 3);
            this.Total_Debtor.Name = "Total_Debtor";
            this.Total_Debtor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Total_Debtor.Size = new System.Drawing.Size(216, 31);
            this.Total_Debtor.TabIndex = 235;
            //
            //Total_Creditor
            //
            this.Total_Creditor.Enabled = false;
            this.Total_Creditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Total_Creditor.Location = new System.Drawing.Point(451, 4);
            this.Total_Creditor.Name = "Total_Creditor";
            this.Total_Creditor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Total_Creditor.Size = new System.Drawing.Size(216, 31);
            this.Total_Creditor.TabIndex = 234;
            //
            //Amount
            //
            this.Amount.Enabled = false;
            this.Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Amount.Location = new System.Drawing.Point(130, 3);
            this.Amount.Name = "Amount";
            this.Amount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Amount.Size = new System.Drawing.Size(216, 31);
            this.Amount.TabIndex = 233;
            //
            //TabControl1
            //
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Controls.Add(this.TabPage3);
            this.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl1.Location = new System.Drawing.Point(0, 0);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TabControl1.RightToLeftLayout = true;
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(1198, 175);
            this.TabControl1.TabIndex = 1;
            //
            //TabPage1
            //
            this.TabPage1.Controls.Add(this.Accounting_Details_Detailed_Five_Main);
            this.TabPage1.Controls.Add(this.B_Accounting_Details_Detailed_Five_Main);
            this.TabPage1.Controls.Add(this.Label7);
            this.TabPage1.Controls.Add(this.Accounting_Details_Detailed_Four_Main);
            this.TabPage1.Controls.Add(this.B_Accounting_Details_Detailed_Four_Main);
            this.TabPage1.Controls.Add(this.Label8);
            this.TabPage1.Controls.Add(this.Accounting_Details_Detailed_Three_Main);
            this.TabPage1.Controls.Add(this.B_Accounting_Details_Detailed_Three_Main);
            this.TabPage1.Controls.Add(this.Label5);
            this.TabPage1.Controls.Add(this.Accounting_Details_Detailed_Two_Main);
            this.TabPage1.Controls.Add(this.B_Accounting_Details_Detailed_Two_Main);
            this.TabPage1.Controls.Add(this.Label6);
            this.TabPage1.Controls.Add(this.Accounting_Details_Detailed_One_Main);
            this.TabPage1.Controls.Add(this.B_Accounting_Details_Detailed_One_Main);
            this.TabPage1.Controls.Add(this.Label4);
            this.TabPage1.Controls.Add(this.Accounting_Details_Acc_Main);
            this.TabPage1.Controls.Add(this.B_Accounting_Details_Acc_Main);
            this.TabPage1.Controls.Add(this.Label13);
            this.TabPage1.Controls.Add(this.Accounting_Details_Description_Main);
            this.TabPage1.Controls.Add(this.Label3);
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(1190, 149);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "اصلی";
            this.TabPage1.UseVisualStyleBackColor = true;
            //
            //Accounting_Details_Detailed_Five_Main
            //
            this.Accounting_Details_Detailed_Five_Main.Enabled = false;
            this.Accounting_Details_Detailed_Five_Main.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Accounting_Details_Detailed_Five_Main.Location = new System.Drawing.Point(41, 115);
            this.Accounting_Details_Detailed_Five_Main.Name = "Accounting_Details_Detailed_Five_Main";
            this.Accounting_Details_Detailed_Five_Main.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Accounting_Details_Detailed_Five_Main.Size = new System.Drawing.Size(448, 31);
            this.Accounting_Details_Detailed_Five_Main.TabIndex = 247;
            //
            //B_Accounting_Details_Detailed_Five_Main
            //
            this.B_Accounting_Details_Detailed_Five_Main.Enabled = false;
            this.B_Accounting_Details_Detailed_Five_Main.Image = (System.Drawing.Image)resources.GetObject("B_Accounting_Details_Detailed_Five_Main.Image");
            this.B_Accounting_Details_Detailed_Five_Main.Location = new System.Drawing.Point(11, 116);
            this.B_Accounting_Details_Detailed_Five_Main.Name = "B_Accounting_Details_Detailed_Five_Main";
            this.B_Accounting_Details_Detailed_Five_Main.Size = new System.Drawing.Size(29, 27);
            this.B_Accounting_Details_Detailed_Five_Main.TabIndex = 248;
            this.B_Accounting_Details_Detailed_Five_Main.UseVisualStyleBackColor = true;
            //
            //Label7
            //
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label7.Location = new System.Drawing.Point(495, 119);
            this.Label7.Name = "Label7";
            this.Label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label7.Size = new System.Drawing.Size(81, 19);
            this.Label7.TabIndex = 249;
            this.Label7.Text = "تفصیلی 5:";
            //
            //Accounting_Details_Detailed_Four_Main
            //
            this.Accounting_Details_Detailed_Four_Main.Enabled = false;
            this.Accounting_Details_Detailed_Four_Main.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Accounting_Details_Detailed_Four_Main.Location = new System.Drawing.Point(630, 115);
            this.Accounting_Details_Detailed_Four_Main.Name = "Accounting_Details_Detailed_Four_Main";
            this.Accounting_Details_Detailed_Four_Main.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Accounting_Details_Detailed_Four_Main.Size = new System.Drawing.Size(448, 31);
            this.Accounting_Details_Detailed_Four_Main.TabIndex = 244;
            //
            //B_Accounting_Details_Detailed_Four_Main
            //
            this.B_Accounting_Details_Detailed_Four_Main.Enabled = false;
            this.B_Accounting_Details_Detailed_Four_Main.Image = (System.Drawing.Image)resources.GetObject("B_Accounting_Details_Detailed_Four_Main.Image");
            this.B_Accounting_Details_Detailed_Four_Main.Location = new System.Drawing.Point(600, 117);
            this.B_Accounting_Details_Detailed_Four_Main.Name = "B_Accounting_Details_Detailed_Four_Main";
            this.B_Accounting_Details_Detailed_Four_Main.Size = new System.Drawing.Size(29, 27);
            this.B_Accounting_Details_Detailed_Four_Main.TabIndex = 245;
            this.B_Accounting_Details_Detailed_Four_Main.UseVisualStyleBackColor = true;
            //
            //Label8
            //
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label8.Location = new System.Drawing.Point(1084, 122);
            this.Label8.Name = "Label8";
            this.Label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label8.Size = new System.Drawing.Size(86, 19);
            this.Label8.TabIndex = 246;
            this.Label8.Text = " تفصیلی 4:";
            //
            //Accounting_Details_Detailed_Three_Main
            //
            this.Accounting_Details_Detailed_Three_Main.Enabled = false;
            this.Accounting_Details_Detailed_Three_Main.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Accounting_Details_Detailed_Three_Main.Location = new System.Drawing.Point(41, 78);
            this.Accounting_Details_Detailed_Three_Main.Name = "Accounting_Details_Detailed_Three_Main";
            this.Accounting_Details_Detailed_Three_Main.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Accounting_Details_Detailed_Three_Main.Size = new System.Drawing.Size(448, 31);
            this.Accounting_Details_Detailed_Three_Main.TabIndex = 241;
            //
            //B_Accounting_Details_Detailed_Three_Main
            //
            this.B_Accounting_Details_Detailed_Three_Main.Enabled = false;
            this.B_Accounting_Details_Detailed_Three_Main.Image = (System.Drawing.Image)resources.GetObject("B_Accounting_Details_Detailed_Three_Main.Image");
            this.B_Accounting_Details_Detailed_Three_Main.Location = new System.Drawing.Point(11, 79);
            this.B_Accounting_Details_Detailed_Three_Main.Name = "B_Accounting_Details_Detailed_Three_Main";
            this.B_Accounting_Details_Detailed_Three_Main.Size = new System.Drawing.Size(29, 27);
            this.B_Accounting_Details_Detailed_Three_Main.TabIndex = 242;
            this.B_Accounting_Details_Detailed_Three_Main.UseVisualStyleBackColor = true;
            //
            //Label5
            //
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label5.Location = new System.Drawing.Point(495, 82);
            this.Label5.Name = "Label5";
            this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label5.Size = new System.Drawing.Size(81, 19);
            this.Label5.TabIndex = 243;
            this.Label5.Text = "تفصیلی 3:";
            //
            //Accounting_Details_Detailed_Two_Main
            //
            this.Accounting_Details_Detailed_Two_Main.Enabled = false;
            this.Accounting_Details_Detailed_Two_Main.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Accounting_Details_Detailed_Two_Main.Location = new System.Drawing.Point(630, 78);
            this.Accounting_Details_Detailed_Two_Main.Name = "Accounting_Details_Detailed_Two_Main";
            this.Accounting_Details_Detailed_Two_Main.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Accounting_Details_Detailed_Two_Main.Size = new System.Drawing.Size(448, 31);
            this.Accounting_Details_Detailed_Two_Main.TabIndex = 238;
            //
            //B_Accounting_Details_Detailed_Two_Main
            //
            this.B_Accounting_Details_Detailed_Two_Main.Enabled = false;
            this.B_Accounting_Details_Detailed_Two_Main.Image = (System.Drawing.Image)resources.GetObject("B_Accounting_Details_Detailed_Two_Main.Image");
            this.B_Accounting_Details_Detailed_Two_Main.Location = new System.Drawing.Point(600, 80);
            this.B_Accounting_Details_Detailed_Two_Main.Name = "B_Accounting_Details_Detailed_Two_Main";
            this.B_Accounting_Details_Detailed_Two_Main.Size = new System.Drawing.Size(29, 27);
            this.B_Accounting_Details_Detailed_Two_Main.TabIndex = 239;
            this.B_Accounting_Details_Detailed_Two_Main.UseVisualStyleBackColor = true;
            //
            //Label6
            //
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label6.Location = new System.Drawing.Point(1084, 85);
            this.Label6.Name = "Label6";
            this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label6.Size = new System.Drawing.Size(81, 19);
            this.Label6.TabIndex = 240;
            this.Label6.Text = "تفصیلی 2:";
            //
            //Accounting_Details_Detailed_One_Main
            //
            this.Accounting_Details_Detailed_One_Main.Enabled = false;
            this.Accounting_Details_Detailed_One_Main.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Accounting_Details_Detailed_One_Main.Location = new System.Drawing.Point(41, 41);
            this.Accounting_Details_Detailed_One_Main.Name = "Accounting_Details_Detailed_One_Main";
            this.Accounting_Details_Detailed_One_Main.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Accounting_Details_Detailed_One_Main.Size = new System.Drawing.Size(448, 31);
            this.Accounting_Details_Detailed_One_Main.TabIndex = 235;
            //
            //B_Accounting_Details_Detailed_One_Main
            //
            this.B_Accounting_Details_Detailed_One_Main.Enabled = false;
            this.B_Accounting_Details_Detailed_One_Main.Image = (System.Drawing.Image)resources.GetObject("B_Accounting_Details_Detailed_One_Main.Image");
            this.B_Accounting_Details_Detailed_One_Main.Location = new System.Drawing.Point(11, 42);
            this.B_Accounting_Details_Detailed_One_Main.Name = "B_Accounting_Details_Detailed_One_Main";
            this.B_Accounting_Details_Detailed_One_Main.Size = new System.Drawing.Size(29, 27);
            this.B_Accounting_Details_Detailed_One_Main.TabIndex = 236;
            this.B_Accounting_Details_Detailed_One_Main.UseVisualStyleBackColor = true;
            //
            //Label4
            //
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label4.Location = new System.Drawing.Point(495, 45);
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label4.Size = new System.Drawing.Size(81, 19);
            this.Label4.TabIndex = 237;
            this.Label4.Text = "تفصیلی 1:";
            //
            //Accounting_Details_Acc_Main
            //
            this.Accounting_Details_Acc_Main.Enabled = false;
            this.Accounting_Details_Acc_Main.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Accounting_Details_Acc_Main.Location = new System.Drawing.Point(630, 41);
            this.Accounting_Details_Acc_Main.Name = "Accounting_Details_Acc_Main";
            this.Accounting_Details_Acc_Main.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Accounting_Details_Acc_Main.Size = new System.Drawing.Size(448, 31);
            this.Accounting_Details_Acc_Main.TabIndex = 232;
            //
            //B_Accounting_Details_Acc_Main
            //
            this.B_Accounting_Details_Acc_Main.Image = (System.Drawing.Image)resources.GetObject("B_Accounting_Details_Acc_Main.Image");
            this.B_Accounting_Details_Acc_Main.Location = new System.Drawing.Point(600, 43);
            this.B_Accounting_Details_Acc_Main.Name = "B_Accounting_Details_Acc_Main";
            this.B_Accounting_Details_Acc_Main.Size = new System.Drawing.Size(29, 27);
            this.B_Accounting_Details_Acc_Main.TabIndex = 233;
            this.B_Accounting_Details_Acc_Main.UseVisualStyleBackColor = true;
            //
            //Label13
            //
            this.Label13.AutoSize = true;
            this.Label13.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label13.Location = new System.Drawing.Point(1082, 48);
            this.Label13.Name = "Label13";
            this.Label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label13.Size = new System.Drawing.Size(88, 19);
            this.Label13.TabIndex = 234;
            this.Label13.Text = "کد حساب :";
            //
            //Accounting_Details_Description_Main
            //
            this.Accounting_Details_Description_Main.BackColor = System.Drawing.Color.White;
            this.Accounting_Details_Description_Main.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Accounting_Details_Description_Main.Location = new System.Drawing.Point(6, 6);
            this.Accounting_Details_Description_Main.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Accounting_Details_Description_Main.Name = "Accounting_Details_Description_Main";
            this.Accounting_Details_Description_Main.Size = new System.Drawing.Size(1072, 27);
            this.Accounting_Details_Description_Main.TabIndex = 24;
            //
            //Label3
            //
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label3.Location = new System.Drawing.Point(1079, 10);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label3.Size = new System.Drawing.Size(107, 19);
            this.Label3.TabIndex = 23;
            this.Label3.Text = "شرح عملیات :";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            //TabPage2
            //
            this.TabPage2.Controls.Add(this.Accounting_Details_Number_Turning_Main);
            this.TabPage2.Controls.Add(this.Label11);
            this.TabPage2.Controls.Add(this.Accounting_Details_Number_Due_Main);
            this.TabPage2.Controls.Add(this.Estehlak_Label);
            this.TabPage2.Controls.Add(this.Label10);
            this.TabPage2.Controls.Add(this.Label9);
//            this.TabPage2.Controls.Add(this.Accounting_Details_Date_Due_Main);
 //           this.TabPage2.Controls.Add(this.Accounting_Details_Date_Cost_Main);
            this.TabPage2.Location = new System.Drawing.Point(4, 22);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(1190, 149);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "جانبی";
            this.TabPage2.UseVisualStyleBackColor = true;
            //
            //Accounting_Details_Number_Turning_Main
            //
            this.Accounting_Details_Number_Turning_Main.BackColor = System.Drawing.Color.White;
            this.Accounting_Details_Number_Turning_Main.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Accounting_Details_Number_Turning_Main.Location = new System.Drawing.Point(121, 9);
            this.Accounting_Details_Number_Turning_Main.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Accounting_Details_Number_Turning_Main.MaxLength = 15;
            this.Accounting_Details_Number_Turning_Main.Name = "Accounting_Details_Number_Turning_Main";
            this.Accounting_Details_Number_Turning_Main.Size = new System.Drawing.Size(173, 30);
            this.Accounting_Details_Number_Turning_Main.TabIndex = 243;
            //
            //Label11
            //
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label11.Location = new System.Drawing.Point(298, 15);
            this.Label11.Name = "Label11";
            this.Label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label11.Size = new System.Drawing.Size(141, 19);
            this.Label11.TabIndex = 244;
            this.Label11.Text = "شماره عطف سند :";
            //
            //Accounting_Details_Number_Due_Main
            //
            this.Accounting_Details_Number_Due_Main.BackColor = System.Drawing.Color.White;
            this.Accounting_Details_Number_Due_Main.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Accounting_Details_Number_Due_Main.Location = new System.Drawing.Point(663, 10);
            this.Accounting_Details_Number_Due_Main.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Accounting_Details_Number_Due_Main.MaxLength = 15;
            this.Accounting_Details_Number_Due_Main.Name = "Accounting_Details_Number_Due_Main";
            this.Accounting_Details_Number_Due_Main.Size = new System.Drawing.Size(159, 30);
            this.Accounting_Details_Number_Due_Main.TabIndex = 239;
            //
            //Estehlak_Label
            //
            this.Estehlak_Label.AutoSize = true;
            this.Estehlak_Label.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Estehlak_Label.Location = new System.Drawing.Point(826, 16);
            this.Estehlak_Label.Name = "Estehlak_Label";
            this.Estehlak_Label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Estehlak_Label.Size = new System.Drawing.Size(130, 19);
            this.Estehlak_Label.TabIndex = 242;
            this.Estehlak_Label.Text = "شماره سررسید :";
            //
            //Label10
            //
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label10.Location = new System.Drawing.Point(548, 16);
            this.Label10.Name = "Label10";
            this.Label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label10.Size = new System.Drawing.Size(115, 19);
            this.Label10.TabIndex = 241;
            this.Label10.Text = "تاریخ سررسید :";
            //
            //Label9
            //
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label9.Location = new System.Drawing.Point(1061, 15);
            this.Label9.Name = "Label9";
            this.Label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label9.Size = new System.Drawing.Size(122, 19);
            this.Label9.TabIndex = 23;
            this.Label9.Text = "تاریخ ثبت هزینه :";
            this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            //Accounting_Details_Date_Due_Main
            //
            this.Accounting_Details_Date_Due_Main.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Accounting_Details_Date_Due_Main.AutoSize = true;
            this.Accounting_Details_Date_Due_Main.BackColor = System.Drawing.Color.White;
            this.Accounting_Details_Date_Due_Main.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Accounting_Details_Date_Due_Main.Location = new System.Drawing.Point(444, 10);
            this.Accounting_Details_Date_Due_Main.Name = "Accounting_Details_Date_Due_Main";
            this.Accounting_Details_Date_Due_Main.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Accounting_Details_Date_Due_Main.Size = new System.Drawing.Size(135, 36);
            this.Accounting_Details_Date_Due_Main.T_D = "";
            this.Accounting_Details_Date_Due_Main.TabIndex = 240;
            //
            //Accounting_Details_Date_Cost_Main
            //
            this.Accounting_Details_Date_Cost_Main.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Accounting_Details_Date_Cost_Main.AutoSize = true;
            this.Accounting_Details_Date_Cost_Main.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Accounting_Details_Date_Cost_Main.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Accounting_Details_Date_Cost_Main.Location = new System.Drawing.Point(958, 10);
            this.Accounting_Details_Date_Cost_Main.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Accounting_Details_Date_Cost_Main.Name = "Accounting_Details_Date_Cost_Main";
            this.Accounting_Details_Date_Cost_Main.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Accounting_Details_Date_Cost_Main.Size = new System.Drawing.Size(136, 32);
            this.Accounting_Details_Date_Cost_Main.T_D = "";
            this.Accounting_Details_Date_Cost_Main.TabIndex = 22;
            //
            //TabPage3
            //
            this.TabPage3.Controls.Add(this.TextBox12);
            this.TabPage3.Controls.Add(this.Label18);
            this.TabPage3.Controls.Add(this.TextBox9);
            this.TabPage3.Controls.Add(this.Label15);
            this.TabPage3.Controls.Add(this.TextBox10);
            this.TabPage3.Controls.Add(this.Label16);
            this.TabPage3.Controls.Add(this.TextBox8);
            this.TabPage3.Controls.Add(this.Label14);
            this.TabPage3.Controls.Add(this.Estate_Name);
            this.TabPage3.Controls.Add(this.Label12);
            this.TabPage3.Location = new System.Drawing.Point(4, 22);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage3.Size = new System.Drawing.Size(1190, 149);
            this.TabPage3.TabIndex = 2;
            this.TabPage3.Text = "اشخاص";
            this.TabPage3.UseVisualStyleBackColor = true;
            //
            //TextBox12
            //
            this.TextBox12.BackColor = System.Drawing.Color.White;
            this.TextBox12.Enabled = false;
            this.TextBox12.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.TextBox12.Location = new System.Drawing.Point(604, 113);
            this.TextBox12.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBox12.Name = "TextBox12";
            this.TextBox12.Size = new System.Drawing.Size(433, 27);
            this.TextBox12.TabIndex = 194;
            //
            //Label18
            //
            this.Label18.AutoSize = true;
            this.Label18.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label18.Location = new System.Drawing.Point(1035, 115);
            this.Label18.Name = "Label18";
            this.Label18.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label18.Size = new System.Drawing.Size(142, 19);
            this.Label18.TabIndex = 195;
            this.Label18.Text = "آخرین اصلاح کننده :";
            //
            //TextBox9
            //
            this.TextBox9.BackColor = System.Drawing.Color.White;
            this.TextBox9.Enabled = false;
            this.TextBox9.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.TextBox9.Location = new System.Drawing.Point(5, 62);
            this.TextBox9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBox9.Name = "TextBox9";
            this.TextBox9.Size = new System.Drawing.Size(482, 27);
            this.TextBox9.TabIndex = 192;
            //
            //Label15
            //
            this.Label15.AutoSize = true;
            this.Label15.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label15.Location = new System.Drawing.Point(486, 65);
            this.Label15.Name = "Label15";
            this.Label15.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label15.Size = new System.Drawing.Size(112, 19);
            this.Label15.TabIndex = 193;
            this.Label15.Text = "نــهـایی کننده :";
            //
            //TextBox10
            //
            this.TextBox10.BackColor = System.Drawing.Color.White;
            this.TextBox10.Enabled = false;
            this.TextBox10.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.TextBox10.Location = new System.Drawing.Point(604, 62);
            this.TextBox10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBox10.Name = "TextBox10";
            this.TextBox10.Size = new System.Drawing.Size(482, 27);
            this.TextBox10.TabIndex = 190;
            //
            //Label16
            //
            this.Label16.AutoSize = true;
            this.Label16.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label16.Location = new System.Drawing.Point(1085, 65);
            this.Label16.Name = "Label16";
            this.Label16.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label16.Size = new System.Drawing.Size(98, 19);
            this.Label16.TabIndex = 191;
            this.Label16.Text = "تائـیـد کننده :";
            //
            //TextBox8
            //
            this.TextBox8.BackColor = System.Drawing.Color.White;
            this.TextBox8.Enabled = false;
            this.TextBox8.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.TextBox8.Location = new System.Drawing.Point(6, 11);
            this.TextBox8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBox8.Name = "TextBox8";
            this.TextBox8.Size = new System.Drawing.Size(482, 27);
            this.TextBox8.TabIndex = 188;
            //
            //Label14
            //
            this.Label14.AutoSize = true;
            this.Label14.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label14.Location = new System.Drawing.Point(487, 15);
            this.Label14.Name = "Label14";
            this.Label14.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label14.Size = new System.Drawing.Size(111, 19);
            this.Label14.TabIndex = 189;
            this.Label14.Text = "بررسی کننده :";
            //
            //Estate_Name
            //
            this.Estate_Name.BackColor = System.Drawing.Color.White;
            this.Estate_Name.Enabled = false;
            this.Estate_Name.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Estate_Name.Location = new System.Drawing.Point(604, 11);
            this.Estate_Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Estate_Name.Name = "Estate_Name";
            this.Estate_Name.Size = new System.Drawing.Size(482, 27);
            this.Estate_Name.TabIndex = 186;
            //
            //Label12
            //
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label12.Location = new System.Drawing.Point(1088, 16);
            this.Label12.Name = "Label12";
            this.Label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label12.Size = new System.Drawing.Size(100, 19);
            this.Label12.TabIndex = 187;
            this.Label12.Text = "تنظیم کننده :";
            //
            //ToolStrip1
            //
            this.ToolStrip1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            //this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.ToolStripSeparator2, this.New_B, this.Edit_B, this.Delet_B, this.Save_B, this.ToolStripSeparator1, this.First_B, this.Next_B, this.Accounting_Header_Number, this.Preview_B, this.Last_B, this.ToolStripSeparator3, this.Print_B, this.Accounting_Header_Class, this.Picture_B, this.Excel_B, this.Log_File, this.Abort_B, this.toolStripSeparator, this.HelpToolStripButton });
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ToolStrip1.ShowItemToolTips = false;
            this.ToolStrip1.Size = new System.Drawing.Size(1198, 25);
            this.ToolStrip1.TabIndex = 6;
            this.ToolStrip1.Text = "ToolStrip1";
            //
            //Accounting
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(9.0F, 20.0F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1198, 593);
            this.Controls.Add(this.SplitContainer1);
            this.Controls.Add(this.ToolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Accounting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.SplitContainer1.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel1.PerformLayout();
            this.SplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.SplitContainer1).EndInit();
            this.SplitContainer1.ResumeLayout(false);
            this.SplitContainer2.Panel1.ResumeLayout(false);
            this.SplitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.SplitContainer2).EndInit();
            this.SplitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.Dv_Accounting).EndInit();
            this.SplitContainer3.Panel1.ResumeLayout(false);
            this.SplitContainer3.Panel1.PerformLayout();
            this.SplitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.SplitContainer3).EndInit();
            this.SplitContainer3.ResumeLayout(false);
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.TabPage2.ResumeLayout(false);
            this.TabPage2.PerformLayout();
            this.TabPage3.ResumeLayout(false);
            this.TabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();



        }
        private System.Windows.Forms.ToolStrip ToolStrip1;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;

        private System.Windows.Forms.ToolStripButton Edit_B;
        private System.Windows.Forms.ToolStripButton Save_B;
        private System.Windows.Forms.ToolStripButton Print_B;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        private System.Windows.Forms.ToolStripButton First_B;
        private System.Windows.Forms.ToolStripButton Next_B;
        private System.Windows.Forms.ToolStripButton Preview_B;
        private System.Windows.Forms.ToolStripButton Lt_B;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator3;
        private System.Windows.Forms.ToolStripTextBox Accounting_Header_Number;
        private System.Windows.Forms.SplitContainer SplitContainer1;
        private System.Windows.Forms.SplitContainer SplitContainer2;
        private System.Windows.Forms.TextBox Accounting_Header_Description;
        private Ansaripour.Rtl_Date Accounting_Header_Date;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.ToolStripComboBox Accounting_Header_Cls;
        private System.Windows.Forms.ToolStripButton New_B;
        private System.Windows.Forms.ToolStripButton Picture_B;
        private System.Windows.Forms.ToolStripButton Excel_B;
        private System.Windows.Forms.ToolStripButton Log_File;
        private System.Windows.Forms.ToolStripButton Abort_B;
        private Ansaripour.MyDataGridView Dv_Accounting;
        private System.Windows.Forms.SplitContainer SplitContainer3;
        private System.Windows.Forms.Label Label20;
        private System.Windows.Forms.Label Label19;
        private System.Windows.Forms.Label Label17;
        private System.Windows.Forms.TextBox Total_Debtor;
        private System.Windows.Forms.TextBox Total_Creditor;
        private System.Windows.Forms.TextBox Amount;
        private System.Windows.Forms.TabControl TabControl1;
        private System.Windows.Forms.TabPage TabPage1;
        private System.Windows.Forms.TextBox Accounting_Details_Detailed_Five_Main;
        private System.Windows.Forms.Button B_Accounting_Details_Detailed_Five_Main;
        private System.Windows.Forms.Label Label7;
        private System.Windows.Forms.TextBox Accounting_Details_Detailed_Four_Main;
        private System.Windows.Forms.Button B_Accounting_Details_Detailed_Four_Mainl;
        private System.Windows.Forms.Button B_Accounting_Details_Detailed_Four_Main;

        private System.Windows.Forms.Label Label8;
        private System.Windows.Forms.TextBox Accounting_Details_Detailed_Three_Main;
        private System.Windows.Forms.Button B_Accounting_Details_Detailed_Three_Main;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.TextBox Accounting_Details_Detailed_Two_Main;
        private System.Windows.Forms.Button B_Accounting_Details_Detailed_Two_Main;
        private System.Windows.Forms.Label Label6;
        private System.Windows.Forms.TextBox Accounting_Details_Detailed_One_Main;
        private System.Windows.Forms.Button B_Accounting_Details_Detailed_One_Main;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.TextBox Accounting_Details_Acc_Main;
        private System.Windows.Forms.Button B_Accounting_Details_Acc_Main;
        private System.Windows.Forms.Label Label13;
        private System.Windows.Forms.TextBox Accounting_Details_Description_Main;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.TabPage TabPage2;
        private System.Windows.Forms.TextBox Accounting_Details_Number_Turning_Main;
        private System.Windows.Forms.Label Label11;
        private System.Windows.Forms.TextBox Accounting_Details_Number_Due_Main;
        private System.Windows.Forms.Label Estehlak_Label;
        private System.Windows.Forms.Label Label10;
        private System.Windows.Forms.Label Label9;
        private Ansaripour.Rtl_Date Accounting_Details_Date_Due_Main;
        private Ansaripour.Rtl_Date Accounting_Details_Date_Cost_Main;
        private System.Windows.Forms.TabPage TabPage3;
        private System.Windows.Forms.TextBox TextBox12;
        private System.Windows.Forms.Label Label18;
        private System.Windows.Forms.TextBox TextBox9;
        private System.Windows.Forms.Label Label15;
        private System.Windows.Forms.TextBox TextBox10;
        private System.Windows.Forms.Label Label16;
        private System.Windows.Forms.TextBox TextBox8;
        private System.Windows.Forms.Label Label14;
        private System.Windows.Forms.TextBox Estate_Name;
        private System.Windows.Forms.Label Label12;
        private System.Windows.Forms.Button B_Header_Number;
        private System.Windows.Forms.Label Label21;
        private System.Windows.Forms.TextBox Header_Number;
        private System.Windows.Forms.Label Types;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton HelpToolStripButton;
        private System.Windows.Forms.ToolStripButton Delet_B;
        private System.Windows.Forms.ToolStripButton Last_B;
        private System.Windows.Forms.ToolStripComboBox Accounting_Header_Class;

    }

}