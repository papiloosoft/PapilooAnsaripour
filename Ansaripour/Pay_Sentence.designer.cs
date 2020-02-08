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
    public partial class Pay_Sentence : System.Windows.Forms.Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pay_Sentence));
            System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.B_Pay_Personal = new System.Windows.Forms.Button();
            this.Num_Pay_Sentence = new System.Windows.Forms.TextBox();
            this.Pay_Personal_Detailed = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.GroupBox6 = new System.Windows.Forms.GroupBox();
            this.Label41 = new System.Windows.Forms.Label();
            this.Label40 = new System.Windows.Forms.Label();
            this.Date_Of_Pay_Sentence = new Ansaripour.Rtl_Date();
            this.Date_Until_Pay_Sentence = new Ansaripour.Rtl_Date();
            this.Label39 = new System.Windows.Forms.Label();
            this.Active_Pay_Sentence = new System.Windows.Forms.ComboBox();
            this.Label37 = new System.Windows.Forms.Label();
            this.GroupBox5 = new System.Windows.Forms.GroupBox();
            this.Turn_4_Pay_Sentence = new System.Windows.Forms.RadioButton();
            this.Turn_3_Pay_Sentence = new System.Windows.Forms.RadioButton();
            this.Turn_2_Pay_Sentence = new System.Windows.Forms.RadioButton();
            this.Turn_1_Pay_Sentence = new System.Windows.Forms.RadioButton();
            this.Label36 = new System.Windows.Forms.Label();
            this.Label38 = new System.Windows.Forms.Label();
            this.Time_Until_Pay_Sentence = new Ansaripour.Rtl_Time();
            this.Time_Of_Pay_Sentence = new Ansaripour.Rtl_Time();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.Address_Pay_Sentence = new System.Windows.Forms.TextBox();
            this.B_City_Pay_Sentence = new System.Windows.Forms.Button();
            this.City_Pay_Sentence = new System.Windows.Forms.TextBox();
            this.B_Organization_Pay_Sentence = new System.Windows.Forms.Button();
            this.Organization_Pay_Sentence = new System.Windows.Forms.TextBox();
            this.Label24 = new System.Windows.Forms.Label();
            this.Label25 = new System.Windows.Forms.Label();
            this.Label26 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Group_Pay_Sentence = new System.Windows.Forms.TextBox();
            this.Cod_Job_Pay_Sentence = new System.Windows.Forms.TextBox();
            this.Job_Pay_Sentence = new System.Windows.Forms.TextBox();
            this.Label20 = new System.Windows.Forms.Label();
            this.Label19 = new System.Windows.Forms.Label();
            this.Label18 = new System.Windows.Forms.Label();
            this.Date_Pay_Sentence = new Ansaripour.Rtl_Date();
            this.TabPage3 = new System.Windows.Forms.TabPage();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.Others_2_Pay_Sentence = new System.Windows.Forms.MaskedTextBox();
            this.Label33 = new System.Windows.Forms.Label();
            this.Others_1_Pay_Sentence = new System.Windows.Forms.MaskedTextBox();
            this.Label30 = new System.Windows.Forms.Label();
            this.Transportation_Pay_Sentence = new System.Windows.Forms.MaskedTextBox();
            this.Label31 = new System.Windows.Forms.Label();
            this.Housing_Pay_Sentence = new System.Windows.Forms.MaskedTextBox();
            this.Label32 = new System.Windows.Forms.Label();
            this.Children_Pay_Sentence = new System.Windows.Forms.MaskedTextBox();
            this.Label34 = new System.Windows.Forms.Label();
            this.laborer_Pay_Sentence = new System.Windows.Forms.MaskedTextBox();
            this.Label35 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.Base_Pay_Sentence = new System.Windows.Forms.TextBox();
            this.Amazing_Pay_Sentence = new System.Windows.Forms.MaskedTextBox();
            this.Label29 = new System.Windows.Forms.Label();
            this.Guardianship_Pay_Sentence = new System.Windows.Forms.MaskedTextBox();
            this.Label28 = new System.Windows.Forms.Label();
            this.Years_Pay_Sentence = new System.Windows.Forms.MaskedTextBox();
            this.Label27 = new System.Windows.Forms.Label();
            this.Difficulty_Pay_Sentence = new System.Windows.Forms.MaskedTextBox();
            this.Label21 = new System.Windows.Forms.Label();
            this.Attraction_Pay_Sentence = new System.Windows.Forms.MaskedTextBox();
            this.Label22 = new System.Windows.Forms.Label();
            this.Label23 = new System.Windows.Forms.Label();
            this.DV = new System.Windows.Forms.DataGridView();
            this.P_Date = new Ansaripour.Rtl_Date();
            this.ToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.SplitContainer1).BeginInit();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.GroupBox6.SuspendLayout();
            this.GroupBox5.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.TabPage3.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.DV).BeginInit();
            this.SuspendLayout();
            //
            //ToolStrip1
            //
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.B_New, this.B_Edit, this.B_Delet, this.B_Save, this.B_Search, this.B_Excel, this.B_Picture, this.B_Print, this.B_Abort });
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ToolStrip1.Size = new System.Drawing.Size(994, 25);
            this.ToolStrip1.TabIndex = 176;
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
            this.SplitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.SplitContainer1.Panel1.Controls.Add(this.TabControl1);
            this.SplitContainer1.Panel1.Controls.Add(this.ToolStrip1);
            this.SplitContainer1.Panel1.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.SplitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            //
            //SplitContainer1.Panel2
            //
            this.SplitContainer1.Panel2.Controls.Add(this.DV);
            this.SplitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SplitContainer1.Size = new System.Drawing.Size(994, 526);
            this.SplitContainer1.SplitterDistance = 272;
            this.SplitContainer1.TabIndex = 65;
            //
            //TabControl1
            //
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Controls.Add(this.TabPage3);
            this.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl1.Location = new System.Drawing.Point(0, 25);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TabControl1.RightToLeftLayout = true;
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(994, 247);
            this.TabControl1.TabIndex = 177;
            //
            //TabPage2
            //
            this.TabPage2.Controls.Add(this.B_Pay_Personal);
            this.TabPage2.Controls.Add(this.Num_Pay_Sentence);
            this.TabPage2.Controls.Add(this.Pay_Personal_Detailed);
            this.TabPage2.Controls.Add(this.Label1);
            this.TabPage2.Controls.Add(this.GroupBox6);
            this.TabPage2.Controls.Add(this.Label39);
            this.TabPage2.Controls.Add(this.Active_Pay_Sentence);
            this.TabPage2.Controls.Add(this.Label37);
            this.TabPage2.Controls.Add(this.GroupBox5);
            this.TabPage2.Controls.Add(this.GroupBox3);
            this.TabPage2.Controls.Add(this.GroupBox1);
            this.TabPage2.Controls.Add(this.Date_Pay_Sentence);
            this.TabPage2.Location = new System.Drawing.Point(4, 28);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(986, 215);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "مشخصات شغلی و محل کار";
            this.TabPage2.UseVisualStyleBackColor = true;
            //
            //B_Pay_Personal
            //
            this.B_Pay_Personal.Image = (System.Drawing.Image)resources.GetObject("B_Pay_Personal.Image");
            this.B_Pay_Personal.Location = new System.Drawing.Point(433, 6);
            this.B_Pay_Personal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.B_Pay_Personal.Name = "B_Pay_Personal";
            this.B_Pay_Personal.Size = new System.Drawing.Size(29, 27);
            this.B_Pay_Personal.TabIndex = 289;
            this.B_Pay_Personal.UseVisualStyleBackColor = true;
            //
            //Num_Pay_Sentence
            //
            this.Num_Pay_Sentence.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Num_Pay_Sentence.Location = new System.Drawing.Point(124, 178);
            this.Num_Pay_Sentence.Name = "Num_Pay_Sentence";
            this.Num_Pay_Sentence.Size = new System.Drawing.Size(60, 27);
            this.Num_Pay_Sentence.TabIndex = 272;
            //
            //Pay_Personal_Detailed
            //
            this.Pay_Personal_Detailed.Enabled = false;
            this.Pay_Personal_Detailed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Pay_Personal_Detailed.Location = new System.Drawing.Point(462, 7);
            this.Pay_Personal_Detailed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Pay_Personal_Detailed.Name = "Pay_Personal_Detailed";
            this.Pay_Personal_Detailed.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Pay_Personal_Detailed.Size = new System.Drawing.Size(374, 26);
            this.Pay_Personal_Detailed.TabIndex = 288;
            //
            //Label1
            //
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label1.Location = new System.Drawing.Point(834, 10);
            this.Label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label1.Size = new System.Drawing.Size(146, 19);
            this.Label1.TabIndex = 287;
            this.Label1.Text = "مشخصات پرسنلی :";
            //
            //GroupBox6
            //
            this.GroupBox6.Controls.Add(this.Label41);
            this.GroupBox6.Controls.Add(this.Label40);
            this.GroupBox6.Controls.Add(this.Date_Of_Pay_Sentence);
            this.GroupBox6.Controls.Add(this.Date_Until_Pay_Sentence);
            this.GroupBox6.Location = new System.Drawing.Point(304, 165);
            this.GroupBox6.Name = "GroupBox6";
            this.GroupBox6.Size = new System.Drawing.Size(431, 45);
            this.GroupBox6.TabIndex = 268;
            this.GroupBox6.TabStop = false;
            this.GroupBox6.Text = "تاریخ اجرای حکم :";
            //
            //Label41
            //
            this.Label41.AutoSize = true;
            this.Label41.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label41.Location = new System.Drawing.Point(121, 19);
            this.Label41.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label41.Name = "Label41";
            this.Label41.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label41.Size = new System.Drawing.Size(59, 19);
            this.Label41.TabIndex = 271;
            this.Label41.Text = "تا تاریخ:";
            //
            //Label40
            //
            this.Label40.AutoSize = true;
            this.Label40.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label40.Location = new System.Drawing.Point(295, 19);
            this.Label40.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label40.Name = "Label40";
            this.Label40.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label40.Size = new System.Drawing.Size(60, 19);
            this.Label40.TabIndex = 270;
            this.Label40.Text = "از تاریخ:";
            //
            //Date_Of_Pay_Sentence
            //
            this.Date_Of_Pay_Sentence.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Date_Of_Pay_Sentence.AutoSize = true;
            this.Date_Of_Pay_Sentence.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Date_Of_Pay_Sentence.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Date_Of_Pay_Sentence.Location = new System.Drawing.Point(180, 13);
            this.Date_Of_Pay_Sentence.Name = "Date_Of_Pay_Sentence";
            this.Date_Of_Pay_Sentence.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Date_Of_Pay_Sentence.Size = new System.Drawing.Size(115, 28);
            this.Date_Of_Pay_Sentence.T_D = "";
            this.Date_Of_Pay_Sentence.TabIndex = 269;
            //
            //Date_Until_Pay_Sentence
            //
            this.Date_Until_Pay_Sentence.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Date_Until_Pay_Sentence.AutoSize = true;
            this.Date_Until_Pay_Sentence.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Date_Until_Pay_Sentence.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Date_Until_Pay_Sentence.Location = new System.Drawing.Point(4, 13);
            this.Date_Until_Pay_Sentence.Name = "Date_Until_Pay_Sentence";
            this.Date_Until_Pay_Sentence.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Date_Until_Pay_Sentence.Size = new System.Drawing.Size(115, 28);
            this.Date_Until_Pay_Sentence.T_D = "";
            this.Date_Until_Pay_Sentence.TabIndex = 268;
            //
            //Label39
            //
            this.Label39.AutoSize = true;
            this.Label39.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label39.Location = new System.Drawing.Point(858, 187);
            this.Label39.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label39.Name = "Label39";
            this.Label39.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label39.Size = new System.Drawing.Size(125, 19);
            this.Label39.TabIndex = 266;
            this.Label39.Text = "تاریخ صدور حکم :";
            //
            //Active_Pay_Sentence
            //
            this.Active_Pay_Sentence.FormattingEnabled = true;
            this.Active_Pay_Sentence.Items.AddRange(new object[] { "فعال", "غیرفعال" });
            this.Active_Pay_Sentence.Location = new System.Drawing.Point(7, 178);
            this.Active_Pay_Sentence.Name = "Active_Pay_Sentence";
            this.Active_Pay_Sentence.Size = new System.Drawing.Size(116, 27);
            this.Active_Pay_Sentence.TabIndex = 253;
            //
            //Label37
            //
            this.Label37.AutoSize = true;
            this.Label37.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label37.Location = new System.Drawing.Point(189, 181);
            this.Label37.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label37.Name = "Label37";
            this.Label37.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label37.Size = new System.Drawing.Size(111, 19);
            this.Label37.TabIndex = 254;
            this.Label37.Text = "حکم کارگزینی:";
            //
            //GroupBox5
            //
            this.GroupBox5.Controls.Add(this.Turn_4_Pay_Sentence);
            this.GroupBox5.Controls.Add(this.Turn_3_Pay_Sentence);
            this.GroupBox5.Controls.Add(this.Turn_2_Pay_Sentence);
            this.GroupBox5.Controls.Add(this.Turn_1_Pay_Sentence);
            this.GroupBox5.Controls.Add(this.Label36);
            this.GroupBox5.Controls.Add(this.Label38);
            this.GroupBox5.Controls.Add(this.Time_Until_Pay_Sentence);
            this.GroupBox5.Controls.Add(this.Time_Of_Pay_Sentence);
            this.GroupBox5.Location = new System.Drawing.Point(6, 39);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Size = new System.Drawing.Size(330, 127);
            this.GroupBox5.TabIndex = 244;
            this.GroupBox5.TabStop = false;
            this.GroupBox5.Text = "ساعت کار :";
            //
            //Turn_4_Pay_Sentence
            //
            this.Turn_4_Pay_Sentence.AutoSize = true;
            this.Turn_4_Pay_Sentence.Location = new System.Drawing.Point(14, 96);
            this.Turn_4_Pay_Sentence.Name = "Turn_4_Pay_Sentence";
            this.Turn_4_Pay_Sentence.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Turn_4_Pay_Sentence.Size = new System.Drawing.Size(103, 23);
            this.Turn_4_Pay_Sentence.TabIndex = 249;
            this.Turn_4_Pay_Sentence.TabStop = true;
            this.Turn_4_Pay_Sentence.Text = "عصر و شب";
            this.Turn_4_Pay_Sentence.UseVisualStyleBackColor = true;
            //
            //Turn_3_Pay_Sentence
            //
            this.Turn_3_Pay_Sentence.AutoSize = true;
            this.Turn_3_Pay_Sentence.Location = new System.Drawing.Point(223, 98);
            this.Turn_3_Pay_Sentence.Name = "Turn_3_Pay_Sentence";
            this.Turn_3_Pay_Sentence.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Turn_3_Pay_Sentence.Size = new System.Drawing.Size(104, 23);
            this.Turn_3_Pay_Sentence.TabIndex = 248;
            this.Turn_3_Pay_Sentence.TabStop = true;
            this.Turn_3_Pay_Sentence.Text = "صبح و شب";
            this.Turn_3_Pay_Sentence.UseVisualStyleBackColor = true;
            //
            //Turn_2_Pay_Sentence
            //
            this.Turn_2_Pay_Sentence.AutoSize = true;
            this.Turn_2_Pay_Sentence.Location = new System.Drawing.Point(14, 70);
            this.Turn_2_Pay_Sentence.Name = "Turn_2_Pay_Sentence";
            this.Turn_2_Pay_Sentence.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Turn_2_Pay_Sentence.Size = new System.Drawing.Size(149, 23);
            this.Turn_2_Pay_Sentence.TabIndex = 247;
            this.Turn_2_Pay_Sentence.TabStop = true;
            this.Turn_2_Pay_Sentence.Text = "صبح و عصر و شب";
            this.Turn_2_Pay_Sentence.UseVisualStyleBackColor = true;
            //
            //Turn_1_Pay_Sentence
            //
            this.Turn_1_Pay_Sentence.AutoSize = true;
            this.Turn_1_Pay_Sentence.Location = new System.Drawing.Point(224, 71);
            this.Turn_1_Pay_Sentence.Name = "Turn_1_Pay_Sentence";
            this.Turn_1_Pay_Sentence.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Turn_1_Pay_Sentence.Size = new System.Drawing.Size(101, 23);
            this.Turn_1_Pay_Sentence.TabIndex = 246;
            this.Turn_1_Pay_Sentence.TabStop = true;
            this.Turn_1_Pay_Sentence.Text = "صبح و عصر";
            this.Turn_1_Pay_Sentence.UseVisualStyleBackColor = true;
            //
            //Label36
            //
            this.Label36.AutoSize = true;
            this.Label36.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label36.Location = new System.Drawing.Point(86, 36);
            this.Label36.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label36.Name = "Label36";
            this.Label36.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label36.Size = new System.Drawing.Size(79, 19);
            this.Label36.TabIndex = 243;
            this.Label36.Text = "تا ساعت :";
            //
            //Label38
            //
            this.Label38.AutoSize = true;
            this.Label38.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label38.Location = new System.Drawing.Point(243, 36);
            this.Label38.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label38.Name = "Label38";
            this.Label38.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label38.Size = new System.Drawing.Size(80, 19);
            this.Label38.TabIndex = 237;
            this.Label38.Text = "از ساعت :";
            //
            //Time_Until_Pay_Sentence
            //
            this.Time_Until_Pay_Sentence.Location = new System.Drawing.Point(9, 27);
            this.Time_Until_Pay_Sentence.Margin = new System.Windows.Forms.Padding(6);
            this.Time_Until_Pay_Sentence.Name = "Time_Until_Pay_Sentence";
            this.Time_Until_Pay_Sentence.Size = new System.Drawing.Size(78, 37);
            this.Time_Until_Pay_Sentence.T_Text = "  :";
            this.Time_Until_Pay_Sentence.TabIndex = 244;
            //
            //Time_Of_Pay_Sentence
            //
            this.Time_Of_Pay_Sentence.Location = new System.Drawing.Point(167, 28);
            this.Time_Of_Pay_Sentence.Margin = new System.Windows.Forms.Padding(4);
            this.Time_Of_Pay_Sentence.Name = "Time_Of_Pay_Sentence";
            this.Time_Of_Pay_Sentence.Size = new System.Drawing.Size(75, 36);
            this.Time_Of_Pay_Sentence.T_Text = "  :";
            this.Time_Of_Pay_Sentence.TabIndex = 242;
            //
            //GroupBox3
            //
            this.GroupBox3.Controls.Add(this.Address_Pay_Sentence);
            this.GroupBox3.Controls.Add(this.B_City_Pay_Sentence);
            this.GroupBox3.Controls.Add(this.City_Pay_Sentence);
            this.GroupBox3.Controls.Add(this.B_Organization_Pay_Sentence);
            this.GroupBox3.Controls.Add(this.Organization_Pay_Sentence);
            this.GroupBox3.Controls.Add(this.Label24);
            this.GroupBox3.Controls.Add(this.Label25);
            this.GroupBox3.Controls.Add(this.Label26);
            this.GroupBox3.Location = new System.Drawing.Point(340, 40);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(406, 126);
            this.GroupBox3.TabIndex = 243;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "مشخصات محل کار :";
            //
            //Address_Pay_Sentence
            //
            this.Address_Pay_Sentence.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Address_Pay_Sentence.Location = new System.Drawing.Point(6, 89);
            this.Address_Pay_Sentence.Name = "Address_Pay_Sentence";
            this.Address_Pay_Sentence.Size = new System.Drawing.Size(340, 27);
            this.Address_Pay_Sentence.TabIndex = 272;
            //
            //B_City_Pay_Sentence
            //
            this.B_City_Pay_Sentence.Image = (System.Drawing.Image)resources.GetObject("B_City_Pay_Sentence.Image");
            this.B_City_Pay_Sentence.Location = new System.Drawing.Point(6, 56);
            this.B_City_Pay_Sentence.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.B_City_Pay_Sentence.Name = "B_City_Pay_Sentence";
            this.B_City_Pay_Sentence.Size = new System.Drawing.Size(29, 27);
            this.B_City_Pay_Sentence.TabIndex = 286;
            this.B_City_Pay_Sentence.UseVisualStyleBackColor = true;
            //
            //City_Pay_Sentence
            //
            this.City_Pay_Sentence.Enabled = false;
            this.City_Pay_Sentence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.City_Pay_Sentence.Location = new System.Drawing.Point(38, 58);
            this.City_Pay_Sentence.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.City_Pay_Sentence.Name = "City_Pay_Sentence";
            this.City_Pay_Sentence.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.City_Pay_Sentence.Size = new System.Drawing.Size(221, 26);
            this.City_Pay_Sentence.TabIndex = 285;
            //
            //B_Organization_Pay_Sentence
            //
            this.B_Organization_Pay_Sentence.Image = (System.Drawing.Image)resources.GetObject("B_Organization_Pay_Sentence.Image");
            this.B_Organization_Pay_Sentence.Location = new System.Drawing.Point(6, 24);
            this.B_Organization_Pay_Sentence.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.B_Organization_Pay_Sentence.Name = "B_Organization_Pay_Sentence";
            this.B_Organization_Pay_Sentence.Size = new System.Drawing.Size(29, 27);
            this.B_Organization_Pay_Sentence.TabIndex = 284;
            this.B_Organization_Pay_Sentence.UseVisualStyleBackColor = true;
            //
            //Organization_Pay_Sentence
            //
            this.Organization_Pay_Sentence.Enabled = false;
            this.Organization_Pay_Sentence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Organization_Pay_Sentence.Location = new System.Drawing.Point(38, 26);
            this.Organization_Pay_Sentence.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Organization_Pay_Sentence.Name = "Organization_Pay_Sentence";
            this.Organization_Pay_Sentence.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Organization_Pay_Sentence.Size = new System.Drawing.Size(254, 26);
            this.Organization_Pay_Sentence.TabIndex = 283;
            //
            //Label24
            //
            this.Label24.AutoSize = true;
            this.Label24.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label24.Location = new System.Drawing.Point(345, 94);
            this.Label24.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label24.Name = "Label24";
            this.Label24.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label24.Size = new System.Drawing.Size(56, 19);
            this.Label24.TabIndex = 241;
            this.Label24.Text = "آدرس :";
            //
            //Label25
            //
            this.Label25.AutoSize = true;
            this.Label25.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label25.Location = new System.Drawing.Point(259, 61);
            this.Label25.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label25.Name = "Label25";
            this.Label25.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label25.Size = new System.Drawing.Size(141, 19);
            this.Label25.TabIndex = 239;
            this.Label25.Text = "شهر محل خدمت  :";
            //
            //Label26
            //
            this.Label26.AutoSize = true;
            this.Label26.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label26.Location = new System.Drawing.Point(289, 31);
            this.Label26.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label26.Name = "Label26";
            this.Label26.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label26.Size = new System.Drawing.Size(113, 19);
            this.Label26.TabIndex = 237;
            this.Label26.Text = "بخش /شرکت :";
            //
            //GroupBox1
            //
            this.GroupBox1.Controls.Add(this.Group_Pay_Sentence);
            this.GroupBox1.Controls.Add(this.Cod_Job_Pay_Sentence);
            this.GroupBox1.Controls.Add(this.Job_Pay_Sentence);
            this.GroupBox1.Controls.Add(this.Label20);
            this.GroupBox1.Controls.Add(this.Label19);
            this.GroupBox1.Controls.Add(this.Label18);
            this.GroupBox1.Location = new System.Drawing.Point(750, 39);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(229, 127);
            this.GroupBox1.TabIndex = 236;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "مشخصات شغلی :";
            //
            //Group_Pay_Sentence
            //
            this.Group_Pay_Sentence.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Group_Pay_Sentence.Location = new System.Drawing.Point(5, 90);
            this.Group_Pay_Sentence.Name = "Group_Pay_Sentence";
            this.Group_Pay_Sentence.Size = new System.Drawing.Size(121, 27);
            this.Group_Pay_Sentence.TabIndex = 271;
            //
            //Cod_Job_Pay_Sentence
            //
            this.Cod_Job_Pay_Sentence.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Cod_Job_Pay_Sentence.Location = new System.Drawing.Point(5, 57);
            this.Cod_Job_Pay_Sentence.Name = "Cod_Job_Pay_Sentence";
            this.Cod_Job_Pay_Sentence.Size = new System.Drawing.Size(121, 27);
            this.Cod_Job_Pay_Sentence.TabIndex = 270;
            //
            //Job_Pay_Sentence
            //
            this.Job_Pay_Sentence.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Job_Pay_Sentence.Location = new System.Drawing.Point(5, 25);
            this.Job_Pay_Sentence.Name = "Job_Pay_Sentence";
            this.Job_Pay_Sentence.Size = new System.Drawing.Size(121, 27);
            this.Job_Pay_Sentence.TabIndex = 269;
            //
            //Label20
            //
            this.Label20.AutoSize = true;
            this.Label20.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label20.Location = new System.Drawing.Point(126, 93);
            this.Label20.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label20.Name = "Label20";
            this.Label20.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label20.Size = new System.Drawing.Size(99, 19);
            this.Label20.TabIndex = 241;
            this.Label20.Text = "گــروه شغل :";
            //
            //Label19
            //
            this.Label19.AutoSize = true;
            this.Label19.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label19.Location = new System.Drawing.Point(126, 61);
            this.Label19.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label19.Name = "Label19";
            this.Label19.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label19.Size = new System.Drawing.Size(98, 19);
            this.Label19.TabIndex = 239;
            this.Label19.Text = "کـــــد شغل :";
            //
            //Label18
            //
            this.Label18.AutoSize = true;
            this.Label18.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label18.Location = new System.Drawing.Point(127, 30);
            this.Label18.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label18.Name = "Label18";
            this.Label18.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label18.Size = new System.Drawing.Size(98, 19);
            this.Label18.TabIndex = 237;
            this.Label18.Text = "عنوان شغل :";
            //
            //Date_Pay_Sentence
            //
            this.Date_Pay_Sentence.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Date_Pay_Sentence.AutoSize = true;
            this.Date_Pay_Sentence.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Date_Pay_Sentence.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Date_Pay_Sentence.Location = new System.Drawing.Point(741, 182);
            this.Date_Pay_Sentence.Name = "Date_Pay_Sentence";
            this.Date_Pay_Sentence.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Date_Pay_Sentence.Size = new System.Drawing.Size(115, 32);
            this.Date_Pay_Sentence.T_D = "";
            this.Date_Pay_Sentence.TabIndex = 267;
            //
            //TabPage3
            //
            this.TabPage3.Controls.Add(this.GroupBox4);
            this.TabPage3.Controls.Add(this.GroupBox2);
            this.TabPage3.Location = new System.Drawing.Point(4, 28);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Size = new System.Drawing.Size(986, 215);
            this.TabPage3.TabIndex = 2;
            this.TabPage3.Text = "حقوق و مزایا";
            this.TabPage3.UseVisualStyleBackColor = true;
            //
            //GroupBox4
            //
            this.GroupBox4.Controls.Add(this.Others_2_Pay_Sentence);
            this.GroupBox4.Controls.Add(this.Label33);
            this.GroupBox4.Controls.Add(this.Others_1_Pay_Sentence);
            this.GroupBox4.Controls.Add(this.Label30);
            this.GroupBox4.Controls.Add(this.Transportation_Pay_Sentence);
            this.GroupBox4.Controls.Add(this.Label31);
            this.GroupBox4.Controls.Add(this.Housing_Pay_Sentence);
            this.GroupBox4.Controls.Add(this.Label32);
            this.GroupBox4.Controls.Add(this.Children_Pay_Sentence);
            this.GroupBox4.Controls.Add(this.Label34);
            this.GroupBox4.Controls.Add(this.laborer_Pay_Sentence);
            this.GroupBox4.Controls.Add(this.Label35);
            this.GroupBox4.Location = new System.Drawing.Point(8, 2);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(481, 126);
            this.GroupBox4.TabIndex = 251;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = " مزایا:";
            //
            //Others_2_Pay_Sentence
            //
            this.Others_2_Pay_Sentence.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Others_2_Pay_Sentence.Location = new System.Drawing.Point(6, 85);
            this.Others_2_Pay_Sentence.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Others_2_Pay_Sentence.Name = "Others_2_Pay_Sentence";
            this.Others_2_Pay_Sentence.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Others_2_Pay_Sentence.Size = new System.Drawing.Size(119, 27);
            this.Others_2_Pay_Sentence.TabIndex = 248;
            //
            //Label33
            //
            this.Label33.AutoSize = true;
            this.Label33.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label33.Location = new System.Drawing.Point(126, 89);
            this.Label33.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label33.Name = "Label33";
            this.Label33.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label33.Size = new System.Drawing.Size(61, 19);
            this.Label33.TabIndex = 249;
            this.Label33.Text = "سایر 2:";
            //
            //Others_1_Pay_Sentence
            //
            this.Others_1_Pay_Sentence.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Others_1_Pay_Sentence.Location = new System.Drawing.Point(252, 86);
            this.Others_1_Pay_Sentence.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Others_1_Pay_Sentence.Name = "Others_1_Pay_Sentence";
            this.Others_1_Pay_Sentence.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Others_1_Pay_Sentence.Size = new System.Drawing.Size(119, 27);
            this.Others_1_Pay_Sentence.TabIndex = 246;
            //
            //Label30
            //
            this.Label30.AutoSize = true;
            this.Label30.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label30.Location = new System.Drawing.Point(372, 90);
            this.Label30.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label30.Name = "Label30";
            this.Label30.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label30.Size = new System.Drawing.Size(61, 19);
            this.Label30.TabIndex = 247;
            this.Label30.Text = "سایر 1:";
            //
            //Transportation_Pay_Sentence
            //
            this.Transportation_Pay_Sentence.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Transportation_Pay_Sentence.Location = new System.Drawing.Point(6, 52);
            this.Transportation_Pay_Sentence.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Transportation_Pay_Sentence.Name = "Transportation_Pay_Sentence";
            this.Transportation_Pay_Sentence.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Transportation_Pay_Sentence.Size = new System.Drawing.Size(119, 27);
            this.Transportation_Pay_Sentence.TabIndex = 244;
            //
            //Label31
            //
            this.Label31.AutoSize = true;
            this.Label31.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label31.Location = new System.Drawing.Point(125, 56);
            this.Label31.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label31.Name = "Label31";
            this.Label31.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label31.Size = new System.Drawing.Size(94, 19);
            this.Label31.TabIndex = 245;
            this.Label31.Text = " ایاب وذهاب:";
            //
            //Housing_Pay_Sentence
            //
            this.Housing_Pay_Sentence.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Housing_Pay_Sentence.Location = new System.Drawing.Point(6, 21);
            this.Housing_Pay_Sentence.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Housing_Pay_Sentence.Name = "Housing_Pay_Sentence";
            this.Housing_Pay_Sentence.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Housing_Pay_Sentence.Size = new System.Drawing.Size(119, 27);
            this.Housing_Pay_Sentence.TabIndex = 242;
            //
            //Label32
            //
            this.Label32.AutoSize = true;
            this.Label32.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label32.Location = new System.Drawing.Point(124, 25);
            this.Label32.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label32.Name = "Label32";
            this.Label32.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label32.Size = new System.Drawing.Size(96, 19);
            this.Label32.TabIndex = 243;
            this.Label32.Text = "حق مسکن :";
            //
            //Children_Pay_Sentence
            //
            this.Children_Pay_Sentence.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Children_Pay_Sentence.Location = new System.Drawing.Point(252, 52);
            this.Children_Pay_Sentence.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Children_Pay_Sentence.Name = "Children_Pay_Sentence";
            this.Children_Pay_Sentence.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Children_Pay_Sentence.Size = new System.Drawing.Size(119, 27);
            this.Children_Pay_Sentence.TabIndex = 238;
            //
            //Label34
            //
            this.Label34.AutoSize = true;
            this.Label34.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label34.Location = new System.Drawing.Point(372, 56);
            this.Label34.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label34.Name = "Label34";
            this.Label34.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label34.Size = new System.Drawing.Size(88, 19);
            this.Label34.TabIndex = 239;
            this.Label34.Text = " حق اولاد  :";
            //
            //laborer_Pay_Sentence
            //
            this.laborer_Pay_Sentence.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.laborer_Pay_Sentence.Location = new System.Drawing.Point(252, 21);
            this.laborer_Pay_Sentence.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.laborer_Pay_Sentence.Name = "laborer_Pay_Sentence";
            this.laborer_Pay_Sentence.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.laborer_Pay_Sentence.Size = new System.Drawing.Size(119, 27);
            this.laborer_Pay_Sentence.TabIndex = 236;
            //
            //Label35
            //
            this.Label35.AutoSize = true;
            this.Label35.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label35.Location = new System.Drawing.Point(369, 25);
            this.Label35.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label35.Name = "Label35";
            this.Label35.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label35.Size = new System.Drawing.Size(89, 19);
            this.Label35.TabIndex = 237;
            this.Label35.Text = "بن کارگری :";
            //
            //GroupBox2
            //
            this.GroupBox2.Controls.Add(this.Base_Pay_Sentence);
            this.GroupBox2.Controls.Add(this.Amazing_Pay_Sentence);
            this.GroupBox2.Controls.Add(this.Label29);
            this.GroupBox2.Controls.Add(this.Guardianship_Pay_Sentence);
            this.GroupBox2.Controls.Add(this.Label28);
            this.GroupBox2.Controls.Add(this.Years_Pay_Sentence);
            this.GroupBox2.Controls.Add(this.Label27);
            this.GroupBox2.Controls.Add(this.Difficulty_Pay_Sentence);
            this.GroupBox2.Controls.Add(this.Label21);
            this.GroupBox2.Controls.Add(this.Attraction_Pay_Sentence);
            this.GroupBox2.Controls.Add(this.Label22);
            this.GroupBox2.Controls.Add(this.Label23);
            this.GroupBox2.Location = new System.Drawing.Point(493, 1);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(486, 127);
            this.GroupBox2.TabIndex = 245;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "حقوق :";
            //
            //Base_Pay_Sentence
            //
            this.Base_Pay_Sentence.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Base_Pay_Sentence.Location = new System.Drawing.Point(246, 23);
            this.Base_Pay_Sentence.Name = "Base_Pay_Sentence";
            this.Base_Pay_Sentence.Size = new System.Drawing.Size(118, 27);
            this.Base_Pay_Sentence.TabIndex = 252;
            //
            //Amazing_Pay_Sentence
            //
            this.Amazing_Pay_Sentence.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Amazing_Pay_Sentence.Location = new System.Drawing.Point(7, 89);
            this.Amazing_Pay_Sentence.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Amazing_Pay_Sentence.Name = "Amazing_Pay_Sentence";
            this.Amazing_Pay_Sentence.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Amazing_Pay_Sentence.Size = new System.Drawing.Size(145, 27);
            this.Amazing_Pay_Sentence.TabIndex = 246;
            //
            //Label29
            //
            this.Label29.AutoSize = true;
            this.Label29.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label29.Location = new System.Drawing.Point(150, 93);
            this.Label29.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label29.Name = "Label29";
            this.Label29.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label29.Size = new System.Drawing.Size(90, 19);
            this.Label29.TabIndex = 247;
            this.Label29.Text = "فوق العاده :";
            //
            //Guardianship_Pay_Sentence
            //
            this.Guardianship_Pay_Sentence.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Guardianship_Pay_Sentence.Location = new System.Drawing.Point(7, 56);
            this.Guardianship_Pay_Sentence.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Guardianship_Pay_Sentence.Name = "Guardianship_Pay_Sentence";
            this.Guardianship_Pay_Sentence.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Guardianship_Pay_Sentence.Size = new System.Drawing.Size(145, 27);
            this.Guardianship_Pay_Sentence.TabIndex = 244;
            //
            //Label28
            //
            this.Label28.AutoSize = true;
            this.Label28.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label28.Location = new System.Drawing.Point(150, 60);
            this.Label28.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label28.Name = "Label28";
            this.Label28.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label28.Size = new System.Drawing.Size(92, 19);
            this.Label28.TabIndex = 245;
            this.Label28.Text = " سرپرستی:";
            //
            //Years_Pay_Sentence
            //
            this.Years_Pay_Sentence.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Years_Pay_Sentence.Location = new System.Drawing.Point(7, 25);
            this.Years_Pay_Sentence.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Years_Pay_Sentence.Name = "Years_Pay_Sentence";
            this.Years_Pay_Sentence.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Years_Pay_Sentence.Size = new System.Drawing.Size(145, 27);
            this.Years_Pay_Sentence.TabIndex = 242;
            //
            //Label27
            //
            this.Label27.AutoSize = true;
            this.Label27.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label27.Location = new System.Drawing.Point(151, 29);
            this.Label27.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label27.Name = "Label27";
            this.Label27.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label27.Size = new System.Drawing.Size(93, 19);
            this.Label27.TabIndex = 243;
            this.Label27.Text = "پایه سنوات :";
            //
            //Difficulty_Pay_Sentence
            //
            this.Difficulty_Pay_Sentence.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Difficulty_Pay_Sentence.Location = new System.Drawing.Point(246, 89);
            this.Difficulty_Pay_Sentence.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Difficulty_Pay_Sentence.Name = "Difficulty_Pay_Sentence";
            this.Difficulty_Pay_Sentence.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Difficulty_Pay_Sentence.Size = new System.Drawing.Size(118, 27);
            this.Difficulty_Pay_Sentence.TabIndex = 240;
            //
            //Label21
            //
            this.Label21.AutoSize = true;
            this.Label21.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label21.Location = new System.Drawing.Point(363, 93);
            this.Label21.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label21.Name = "Label21";
            this.Label21.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label21.Size = new System.Drawing.Size(110, 19);
            this.Label21.TabIndex = 241;
            this.Label21.Text = "سختی شغل :";
            //
            //Attraction_Pay_Sentence
            //
            this.Attraction_Pay_Sentence.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Attraction_Pay_Sentence.Location = new System.Drawing.Point(246, 57);
            this.Attraction_Pay_Sentence.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Attraction_Pay_Sentence.Name = "Attraction_Pay_Sentence";
            this.Attraction_Pay_Sentence.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Attraction_Pay_Sentence.Size = new System.Drawing.Size(118, 27);
            this.Attraction_Pay_Sentence.TabIndex = 238;
            //
            //Label22
            //
            this.Label22.AutoSize = true;
            this.Label22.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label22.Location = new System.Drawing.Point(363, 61);
            this.Label22.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label22.Name = "Label22";
            this.Label22.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label22.Size = new System.Drawing.Size(120, 19);
            this.Label22.TabIndex = 239;
            this.Label22.Text = " حــــق جــــذب :";
            //
            //Label23
            //
            this.Label23.AutoSize = true;
            this.Label23.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label23.Location = new System.Drawing.Point(366, 30);
            this.Label23.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label23.Name = "Label23";
            this.Label23.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label23.Size = new System.Drawing.Size(108, 19);
            this.Label23.TabIndex = 237;
            this.Label23.Text = "مـــزد مـــبـنــا :";
            //
            //DV
            //
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            DataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3;
            this.DV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            DataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DV.DefaultCellStyle = DataGridViewCellStyle4;
            this.DV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.DV.Location = new System.Drawing.Point(0, 0);
            this.DV.Name = "DV";
            this.DV.Size = new System.Drawing.Size(994, 250);
            this.DV.TabIndex = 3;
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
            //Pay_Sentence
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(12.0F, 25.0F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(994, 526);
            this.Controls.Add(this.SplitContainer1);
            this.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.Name = "Pay_Sentence";
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
            this.TabControl1.ResumeLayout(false);
            this.TabPage2.ResumeLayout(false);
            this.TabPage2.PerformLayout();
            this.GroupBox6.ResumeLayout(false);
            this.GroupBox6.PerformLayout();
            this.GroupBox5.ResumeLayout(false);
            this.GroupBox5.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.TabPage3.ResumeLayout(false);
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.DV).EndInit();
            this.ResumeLayout(false);

        }
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
        internal Ansaripour.Rtl_Date P_Date;
        internal System.Windows.Forms.ToolStripButton B_Excel;
        internal System.Windows.Forms.ToolStripButton B_Picture;
        internal System.Windows.Forms.TabControl TabControl1;
        internal System.Windows.Forms.TabPage TabPage2;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label18;
        internal System.Windows.Forms.Label Label20;
        internal System.Windows.Forms.Label Label19;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.Label Label24;
        internal System.Windows.Forms.Label Label25;
        internal System.Windows.Forms.Label Label26;
        internal System.Windows.Forms.TabPage TabPage3;
        internal System.Windows.Forms.GroupBox GroupBox4;
        internal System.Windows.Forms.MaskedTextBox Others_2_Pay_Sentence;
        internal System.Windows.Forms.Label Label33;
        internal System.Windows.Forms.MaskedTextBox Others_1_Pay_Sentence;
        internal System.Windows.Forms.Label Label30;
        internal System.Windows.Forms.MaskedTextBox Transportation_Pay_Sentence;
        internal System.Windows.Forms.Label Label31;
        internal System.Windows.Forms.MaskedTextBox Housing_Pay_Sentence;
        internal System.Windows.Forms.Label Label32;
        internal System.Windows.Forms.MaskedTextBox Children_Pay_Sentence;
        internal System.Windows.Forms.Label Label34;
        internal System.Windows.Forms.MaskedTextBox laborer_Pay_Sentence;
        internal System.Windows.Forms.Label Label35;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.MaskedTextBox Amazing_Pay_Sentence;
        internal System.Windows.Forms.Label Label29;
        internal System.Windows.Forms.MaskedTextBox Guardianship_Pay_Sentence;
        internal System.Windows.Forms.Label Label28;
        internal System.Windows.Forms.MaskedTextBox Years_Pay_Sentence;
        internal System.Windows.Forms.Label Label27;
        internal System.Windows.Forms.MaskedTextBox Difficulty_Pay_Sentence;
        internal System.Windows.Forms.Label Label21;
        internal System.Windows.Forms.MaskedTextBox Attraction_Pay_Sentence;
        internal System.Windows.Forms.Label Label22;
        internal System.Windows.Forms.Label Label23;
        internal System.Windows.Forms.GroupBox GroupBox5;
        internal System.Windows.Forms.Label Label38;
        internal Ansaripour.Rtl_Time Time_Until_Pay_Sentence;
        internal System.Windows.Forms.Label Label36;
        internal Ansaripour.Rtl_Time Time_Of_Pay_Sentence;
        internal System.Windows.Forms.RadioButton Turn_4_Pay_Sentence;
        internal System.Windows.Forms.RadioButton Turn_3_Pay_Sentence;
        internal System.Windows.Forms.RadioButton Turn_2_Pay_Sentence;
        internal System.Windows.Forms.RadioButton Turn_1_Pay_Sentence;
        private System.Windows.Forms.ComboBox Active_Pay_Sentence;
        internal System.Windows.Forms.Label Label37;
        internal System.Windows.Forms.GroupBox GroupBox6;
        internal System.Windows.Forms.Label Label41;
        internal System.Windows.Forms.Label Label40;
        internal Ansaripour.Rtl_Date Date_Of_Pay_Sentence;
        internal Ansaripour.Rtl_Date Date_Until_Pay_Sentence;
        internal Ansaripour.Rtl_Date Date_Pay_Sentence;
        internal System.Windows.Forms.Label Label39;
        internal System.Windows.Forms.Button B_Organization_Pay_Sentence;
        internal System.Windows.Forms.TextBox Organization_Pay_Sentence;
        internal System.Windows.Forms.Button B_City_Pay_Sentence;
        internal System.Windows.Forms.TextBox City_Pay_Sentence;
        internal System.Windows.Forms.TextBox Num_Pay_Sentence;
        internal System.Windows.Forms.TextBox Address_Pay_Sentence;
        internal System.Windows.Forms.TextBox Group_Pay_Sentence;
        internal System.Windows.Forms.TextBox Cod_Job_Pay_Sentence;
        internal System.Windows.Forms.TextBox Job_Pay_Sentence;
        internal System.Windows.Forms.TextBox Base_Pay_Sentence;
        internal System.Windows.Forms.Button B_Pay_Personal;
        internal System.Windows.Forms.TextBox Pay_Personal_Detailed;
        internal System.Windows.Forms.Label Label1;
    }
}