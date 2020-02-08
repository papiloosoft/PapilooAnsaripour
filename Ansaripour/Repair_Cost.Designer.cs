
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
    public partial class Repair_Cost : System.Windows.Forms.Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Repair_Cost));
            System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.New_B = new System.Windows.Forms.ToolStripButton();
            this.Edit_B = new System.Windows.Forms.ToolStripButton();
            this.Delet_B = new System.Windows.Forms.ToolStripButton();
            this.Save_B = new System.Windows.Forms.ToolStripButton();
            this.Search_B = new System.Windows.Forms.ToolStripButton();
            this.B_Excel = new System.Windows.Forms.ToolStripButton();
            this.Chap = new System.Windows.Forms.ToolStripButton();
            this.Abort_B = new System.Windows.Forms.ToolStripButton();
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.Cost_Time_Stop_Work = new System.Windows.Forms.MaskedTextBox();
            this.Cost_Time_Befor_Work = new System.Windows.Forms.MaskedTextBox();
            this.Cost_Time_Stop_Repair = new System.Windows.Forms.MaskedTextBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.Cost_Time_Request = new Ansaripour.Rtl_Time();
            this.Cost_End_Time_Work = new Ansaripour.Rtl_Time();
            this.Cost_Start_Time_Work = new Ansaripour.Rtl_Time();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.Cost_Stop_Defect = new System.Windows.Forms.TextBox();
            this.B_Repair_Phase = new System.Windows.Forms.Button();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Cost_End_Date_Work = new Ansaripour.Rtl_Date();
            this.Label9 = new System.Windows.Forms.Label();
            this.Cost_Start_Date_Work = new Ansaripour.Rtl_Date();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Cost_Work_description = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Cost_Date_Sabt = new Ansaripour.Rtl_Date();
            this.Label17 = new System.Windows.Forms.Label();
            this.Cost_Id_Request = new System.Windows.Forms.TextBox();
            this.B_Repair_Energy = new System.Windows.Forms.Button();
            this.Label8 = new System.Windows.Forms.Label();
            this.Cost_Date_Request = new Ansaripour.Rtl_Date();
            this.Label7 = new System.Windows.Forms.Label();
            this.Cost_Repair_description = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Cost_Num_Request = new System.Windows.Forms.TextBox();
            this.B_Repair_Seating = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Cost_Id_Total = new System.Windows.Forms.TextBox();
            this.Label26 = new System.Windows.Forms.Label();
            this.TabPage3 = new System.Windows.Forms.TabPage();
            this.Dv_Stock = new System.Windows.Forms.DataGridView();
            this.DV = new System.Windows.Forms.DataGridView();
            this.ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.SplitContainer1).BeginInit();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.TabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.Dv_Stock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.DV).BeginInit();
            this.SuspendLayout();
            //
            //ToolStrip
            //
            this.ToolStrip.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.New_B, this.Edit_B, this.Delet_B, this.Save_B, this.Search_B, this.B_Excel, this.Chap, this.Abort_B });
            this.ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(1070, 26);
            this.ToolStrip.TabIndex = 1;
            this.ToolStrip.Text = "ToolStrip1";
            //
            //New_B
            //
            this.New_B.Image = (System.Drawing.Image)resources.GetObject("New_B.Image");
            this.New_B.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.New_B.Name = "New_B";
            this.New_B.Size = new System.Drawing.Size(62, 23);
            this.New_B.Text = "جدید";
            //
            //Edit_B
            //
            this.Edit_B.Image = (System.Drawing.Image)resources.GetObject("Edit_B.Image");
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
            //Save_B
            //
            this.Save_B.Enabled = false;
            this.Save_B.Image = (System.Drawing.Image)resources.GetObject("Save_B.Image");
            this.Save_B.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Save_B.Name = "Save_B";
            this.Save_B.Size = new System.Drawing.Size(68, 23);
            this.Save_B.Text = "ذخیره";
            //
            //Search_B
            //
            this.Search_B.Image = (System.Drawing.Image)resources.GetObject("Search_B.Image");
            this.Search_B.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Search_B.Name = "Search_B";
            this.Search_B.Size = new System.Drawing.Size(81, 23);
            this.Search_B.Text = "جستجو";
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
            //Abort_B
            //
            this.Abort_B.Image = (System.Drawing.Image)resources.GetObject("Abort_B.Image");
            this.Abort_B.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Abort_B.Name = "Abort_B";
            this.Abort_B.Size = new System.Drawing.Size(74, 23);
            this.Abort_B.Text = "انصراف";
            //
            //SplitContainer1
            //
            this.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer1.Location = new System.Drawing.Point(0, 26);
            this.SplitContainer1.Name = "SplitContainer1";
            this.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            //
            //SplitContainer1.Panel1
            //
            this.SplitContainer1.Panel1.Controls.Add(this.TabControl1);
            this.SplitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            //
            //SplitContainer1.Panel2
            //
            this.SplitContainer1.Panel2.Controls.Add(this.DV);
            this.SplitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SplitContainer1.Size = new System.Drawing.Size(1070, 430);
            this.SplitContainer1.SplitterDistance = 263;
            this.SplitContainer1.TabIndex = 2;
            //
            //TabControl1
            //
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage3);
            this.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl1.Location = new System.Drawing.Point(0, 0);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.RightToLeftLayout = true;
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(1070, 263);
            this.TabControl1.TabIndex = 0;
            //
            //TabPage1
            //
            this.TabPage1.Controls.Add(this.Cost_Time_Stop_Work);
            this.TabPage1.Controls.Add(this.Cost_Time_Befor_Work);
            this.TabPage1.Controls.Add(this.Cost_Time_Stop_Repair);
            this.TabPage1.Controls.Add(this.Label14);
            this.TabPage1.Controls.Add(this.Cost_Time_Request);
            this.TabPage1.Controls.Add(this.Cost_End_Time_Work);
            this.TabPage1.Controls.Add(this.Cost_Start_Time_Work);
            this.TabPage1.Controls.Add(this.Label12);
            this.TabPage1.Controls.Add(this.Label13);
            this.TabPage1.Controls.Add(this.Cost_Stop_Defect);
            this.TabPage1.Controls.Add(this.B_Repair_Phase);
            this.TabPage1.Controls.Add(this.Label11);
            this.TabPage1.Controls.Add(this.Label6);
            this.TabPage1.Controls.Add(this.Cost_End_Date_Work);
            this.TabPage1.Controls.Add(this.Label9);
            this.TabPage1.Controls.Add(this.Cost_Start_Date_Work);
            this.TabPage1.Controls.Add(this.Label10);
            this.TabPage1.Controls.Add(this.Label3);
            this.TabPage1.Controls.Add(this.Cost_Work_description);
            this.TabPage1.Controls.Add(this.Label1);
            this.TabPage1.Controls.Add(this.Cost_Date_Sabt);
            this.TabPage1.Controls.Add(this.Label17);
            this.TabPage1.Controls.Add(this.Cost_Id_Request);
            this.TabPage1.Controls.Add(this.B_Repair_Energy);
            this.TabPage1.Controls.Add(this.Label8);
            this.TabPage1.Controls.Add(this.Cost_Date_Request);
            this.TabPage1.Controls.Add(this.Label7);
            this.TabPage1.Controls.Add(this.Cost_Repair_description);
            this.TabPage1.Controls.Add(this.Label4);
            this.TabPage1.Controls.Add(this.Cost_Num_Request);
            this.TabPage1.Controls.Add(this.B_Repair_Seating);
            this.TabPage1.Controls.Add(this.Label2);
            this.TabPage1.Controls.Add(this.Label5);
            this.TabPage1.Controls.Add(this.Cost_Id_Total);
            this.TabPage1.Controls.Add(this.Label26);
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(1062, 237);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "درخواست خدمات فنی";
            this.TabPage1.UseVisualStyleBackColor = true;
            //
            //Cost_Time_Stop_Work
            //
            this.Cost_Time_Stop_Work.Font = new System.Drawing.Font("B Traffic", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Cost_Time_Stop_Work.Location = new System.Drawing.Point(389, 200);
            this.Cost_Time_Stop_Work.Mask = "##:##";
            this.Cost_Time_Stop_Work.Name = "Cost_Time_Stop_Work";
            this.Cost_Time_Stop_Work.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Cost_Time_Stop_Work.Size = new System.Drawing.Size(48, 34);
            this.Cost_Time_Stop_Work.TabIndex = 16;
            //
            //Cost_Time_Befor_Work
            //
            this.Cost_Time_Befor_Work.Font = new System.Drawing.Font("B Traffic", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Cost_Time_Befor_Work.Location = new System.Drawing.Point(6, 197);
            this.Cost_Time_Befor_Work.Mask = "##:##";
            this.Cost_Time_Befor_Work.Name = "Cost_Time_Befor_Work";
            this.Cost_Time_Befor_Work.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Cost_Time_Befor_Work.Size = new System.Drawing.Size(48, 34);
            this.Cost_Time_Befor_Work.TabIndex = 17;
            //
            //Cost_Time_Stop_Repair
            //
            this.Cost_Time_Stop_Repair.Font = new System.Drawing.Font("B Traffic", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Cost_Time_Stop_Repair.Location = new System.Drawing.Point(6, 159);
            this.Cost_Time_Stop_Repair.Mask = "##:##";
            this.Cost_Time_Stop_Repair.Name = "Cost_Time_Stop_Repair";
            this.Cost_Time_Stop_Repair.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Cost_Time_Stop_Repair.Size = new System.Drawing.Size(48, 34);
            this.Cost_Time_Stop_Repair.TabIndex = 13;
            //
            //Label14
            //
            this.Label14.AutoSize = true;
            this.Label14.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label14.Location = new System.Drawing.Point(56, 206);
            this.Label14.Name = "Label14";
            this.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label14.Size = new System.Drawing.Size(300, 19);
            this.Label14.TabIndex = 244;
            this.Label14.Text = ":مجموع ساعت کارکرد دستگاه قبل تعمیرات";
            //
            //Cost_Time_Request
            //
            this.Cost_Time_Request.Location = new System.Drawing.Point(223, 44);
            this.Cost_Time_Request.Name = "Cost_Time_Request";
            this.Cost_Time_Request.Size = new System.Drawing.Size(50, 36);
            this.Cost_Time_Request.T_Text = "  :";
            this.Cost_Time_Request.TabIndex = 5;
            //
            //Cost_End_Time_Work
            //
            this.Cost_End_Time_Work.Location = new System.Drawing.Point(216, 159);
            this.Cost_End_Time_Work.Name = "Cost_End_Time_Work";
            this.Cost_End_Time_Work.Size = new System.Drawing.Size(50, 36);
            this.Cost_End_Time_Work.T_Text = "  :";
            this.Cost_End_Time_Work.TabIndex = 12;
            //
            //Cost_Start_Time_Work
            //
            this.Cost_Start_Time_Work.Location = new System.Drawing.Point(609, 159);
            this.Cost_Start_Time_Work.Name = "Cost_Start_Time_Work";
            this.Cost_Start_Time_Work.Size = new System.Drawing.Size(50, 36);
            this.Cost_Start_Time_Work.T_Text = "  :";
            this.Cost_Start_Time_Work.TabIndex = 10;
            //
            //Label12
            //
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label12.Location = new System.Drawing.Point(439, 204);
            this.Label12.Name = "Label12";
            this.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label12.Size = new System.Drawing.Size(219, 19);
            this.Label12.TabIndex = 241;
            this.Label12.Text = ": مدت زمان توقف حین انجام کار";
            //
            //Label13
            //
            this.Label13.AutoSize = true;
            this.Label13.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label13.Location = new System.Drawing.Point(51, 166);
            this.Label13.Name = "Label13";
            this.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label13.Size = new System.Drawing.Size(168, 19);
            this.Label13.TabIndex = 239;
            this.Label13.Text = ":مجموع ساعت تعمیرات";
            //
            //Cost_Stop_Defect
            //
            this.Cost_Stop_Defect.BackColor = System.Drawing.Color.White;
            this.Cost_Stop_Defect.Enabled = false;
            this.Cost_Stop_Defect.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Cost_Stop_Defect.Location = new System.Drawing.Point(721, 200);
            this.Cost_Stop_Defect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cost_Stop_Defect.Name = "Cost_Stop_Defect";
            this.Cost_Stop_Defect.Size = new System.Drawing.Size(227, 30);
            this.Cost_Stop_Defect.TabIndex = 14;
            //
            //B_Repair_Phase
            //
            this.B_Repair_Phase.Image = (System.Drawing.Image)resources.GetObject("B_Repair_Phase.Image");
            this.B_Repair_Phase.Location = new System.Drawing.Point(689, 203);
            this.B_Repair_Phase.Name = "B_Repair_Phase";
            this.B_Repair_Phase.Size = new System.Drawing.Size(29, 27);
            this.B_Repair_Phase.TabIndex = 15;
            this.B_Repair_Phase.UseVisualStyleBackColor = true;
            //
            //Label11
            //
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label11.Location = new System.Drawing.Point(273, 168);
            this.Label11.Name = "Label11";
            this.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label11.Size = new System.Drawing.Size(106, 19);
            this.Label11.TabIndex = 234;
            this.Label11.Text = ":زمان اتمام کار";
            //
            //Label6
            //
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label6.Location = new System.Drawing.Point(499, 166);
            this.Label6.Name = "Label6";
            this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label6.Size = new System.Drawing.Size(111, 19);
            this.Label6.TabIndex = 232;
            this.Label6.Text = ":تاریخ اتمام  کار";
            //
            //Cost_End_Date_Work
            //
            this.Cost_End_Date_Work.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Cost_End_Date_Work.AutoSize = true;
            this.Cost_End_Date_Work.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Cost_End_Date_Work.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Cost_End_Date_Work.Location = new System.Drawing.Point(381, 160);
            this.Cost_End_Date_Work.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cost_End_Date_Work.Name = "Cost_End_Date_Work";
            this.Cost_End_Date_Work.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Cost_End_Date_Work.Size = new System.Drawing.Size(136, 32);
            this.Cost_End_Date_Work.T_D = "";
            this.Cost_End_Date_Work.TabIndex = 11;
            //
            //Label9
            //
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label9.Location = new System.Drawing.Point(916, 167);
            this.Label9.Name = "Label9";
            this.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label9.Size = new System.Drawing.Size(137, 19);
            this.Label9.TabIndex = 230;
            this.Label9.Text = ": تاریخ شروع به کار";
            //
            //Cost_Start_Date_Work
            //
            this.Cost_Start_Date_Work.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Cost_Start_Date_Work.AutoSize = true;
            this.Cost_Start_Date_Work.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Cost_Start_Date_Work.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Cost_Start_Date_Work.Location = new System.Drawing.Point(800, 161);
            this.Cost_Start_Date_Work.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cost_Start_Date_Work.Name = "Cost_Start_Date_Work";
            this.Cost_Start_Date_Work.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Cost_Start_Date_Work.Size = new System.Drawing.Size(136, 32);
            this.Cost_Start_Date_Work.T_D = "";
            this.Cost_Start_Date_Work.TabIndex = 9;
            //
            //Label10
            //
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label10.Location = new System.Drawing.Point(665, 166);
            this.Label10.Name = "Label10";
            this.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label10.Size = new System.Drawing.Size(132, 19);
            this.Label10.TabIndex = 229;
            this.Label10.Text = ":زمان شروع به کار";
            //
            //Label3
            //
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label3.Location = new System.Drawing.Point(854, 128);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label3.Size = new System.Drawing.Size(199, 19);
            this.Label3.TabIndex = 226;
            this.Label3.Text = ": شرح فعالیتهای انجام شده";
            //
            //Cost_Work_description
            //
            this.Cost_Work_description.BackColor = System.Drawing.Color.White;
            this.Cost_Work_description.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Cost_Work_description.Location = new System.Drawing.Point(6, 122);
            this.Cost_Work_description.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cost_Work_description.Name = "Cost_Work_description";
            this.Cost_Work_description.Size = new System.Drawing.Size(840, 30);
            this.Cost_Work_description.TabIndex = 8;
            //
            //Label1
            //
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label1.Location = new System.Drawing.Point(129, 53);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(80, 19);
            this.Label1.TabIndex = 224;
            this.Label1.Text = ": تاریخ ثبت";
            //
            //Cost_Date_Sabt
            //
            this.Cost_Date_Sabt.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Cost_Date_Sabt.AutoSize = true;
            this.Cost_Date_Sabt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Cost_Date_Sabt.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Cost_Date_Sabt.Location = new System.Drawing.Point(8, 47);
            this.Cost_Date_Sabt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cost_Date_Sabt.Name = "Cost_Date_Sabt";
            this.Cost_Date_Sabt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Cost_Date_Sabt.Size = new System.Drawing.Size(136, 32);
            this.Cost_Date_Sabt.T_D = "";
            this.Cost_Date_Sabt.TabIndex = 6;
            //
            //Label17
            //
            this.Label17.AutoSize = true;
            this.Label17.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label17.Location = new System.Drawing.Point(357, 13);
            this.Label17.Name = "Label17";
            this.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label17.Size = new System.Drawing.Size(164, 19);
            this.Label17.TabIndex = 222;
            this.Label17.Text = ": واحد درخواست کننده";
            //
            //Cost_Id_Request
            //
            this.Cost_Id_Request.BackColor = System.Drawing.Color.White;
            this.Cost_Id_Request.Enabled = false;
            this.Cost_Id_Request.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Cost_Id_Request.Location = new System.Drawing.Point(40, 8);
            this.Cost_Id_Request.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cost_Id_Request.Name = "Cost_Id_Request";
            this.Cost_Id_Request.Size = new System.Drawing.Size(314, 30);
            this.Cost_Id_Request.TabIndex = 1;
            //
            //B_Repair_Energy
            //
            this.B_Repair_Energy.Image = (System.Drawing.Image)resources.GetObject("B_Repair_Energy.Image");
            this.B_Repair_Energy.Location = new System.Drawing.Point(9, 9);
            this.B_Repair_Energy.Name = "B_Repair_Energy";
            this.B_Repair_Energy.Size = new System.Drawing.Size(29, 27);
            this.B_Repair_Energy.TabIndex = 2;
            this.B_Repair_Energy.UseVisualStyleBackColor = true;
            //
            //Label8
            //
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label8.Location = new System.Drawing.Point(557, 54);
            this.Label8.Name = "Label8";
            this.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label8.Size = new System.Drawing.Size(121, 19);
            this.Label8.TabIndex = 203;
            this.Label8.Text = ": تاریخ درخواست";
            //
            //Cost_Date_Request
            //
            this.Cost_Date_Request.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Cost_Date_Request.AutoSize = true;
            this.Cost_Date_Request.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Cost_Date_Request.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Cost_Date_Request.Location = new System.Drawing.Point(441, 48);
            this.Cost_Date_Request.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cost_Date_Request.Name = "Cost_Date_Request";
            this.Cost_Date_Request.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Cost_Date_Request.Size = new System.Drawing.Size(136, 32);
            this.Cost_Date_Request.T_D = "";
            this.Cost_Date_Request.TabIndex = 4;
            //
            //Label7
            //
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label7.Location = new System.Drawing.Point(956, 90);
            this.Label7.Name = "Label7";
            this.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label7.Size = new System.Drawing.Size(100, 19);
            this.Label7.TabIndex = 202;
            this.Label7.Text = ": شرح خرابی";
            //
            //Cost_Repair_description
            //
            this.Cost_Repair_description.BackColor = System.Drawing.Color.White;
            this.Cost_Repair_description.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Cost_Repair_description.Location = new System.Drawing.Point(6, 84);
            this.Cost_Repair_description.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cost_Repair_description.Name = "Cost_Repair_description";
            this.Cost_Repair_description.Size = new System.Drawing.Size(942, 30);
            this.Cost_Repair_description.TabIndex = 7;
            //
            //Label4
            //
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label4.Location = new System.Drawing.Point(894, 54);
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label4.Size = new System.Drawing.Size(156, 19);
            this.Label4.TabIndex = 198;
            this.Label4.Text = ": شماره درخـــواســت";
            //
            //Cost_Num_Request
            //
            this.Cost_Num_Request.BackColor = System.Drawing.Color.White;
            this.Cost_Num_Request.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Cost_Num_Request.Location = new System.Drawing.Point(684, 48);
            this.Cost_Num_Request.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cost_Num_Request.Name = "Cost_Num_Request";
            this.Cost_Num_Request.Size = new System.Drawing.Size(205, 30);
            this.Cost_Num_Request.TabIndex = 3;
            //
            //B_Repair_Seating
            //
            this.B_Repair_Seating.Image = (System.Drawing.Image)resources.GetObject("B_Repair_Seating.Image");
            this.B_Repair_Seating.Location = new System.Drawing.Point(530, 9);
            this.B_Repair_Seating.Name = "B_Repair_Seating";
            this.B_Repair_Seating.Size = new System.Drawing.Size(29, 27);
            this.B_Repair_Seating.TabIndex = 195;
            this.B_Repair_Seating.UseVisualStyleBackColor = true;
            //
            //Label2
            //
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label2.Location = new System.Drawing.Point(276, 53);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(153, 19);
            this.Label2.TabIndex = 193;
            this.Label2.Text = ": زمــان درخــواســــت";
            //
            //Label5
            //
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label5.Location = new System.Drawing.Point(895, 14);
            this.Label5.Name = "Label5";
            this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label5.Size = new System.Drawing.Size(159, 19);
            this.Label5.TabIndex = 189;
            this.Label5.Text = ":نام و کـــــد دسـتـــگاه";
            //
            //Cost_Id_Total
            //
            this.Cost_Id_Total.BackColor = System.Drawing.Color.White;
            this.Cost_Id_Total.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Cost_Id_Total.Location = new System.Drawing.Point(560, 8);
            this.Cost_Id_Total.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cost_Id_Total.Name = "Cost_Id_Total";
            this.Cost_Id_Total.Size = new System.Drawing.Size(329, 30);
            this.Cost_Id_Total.TabIndex = 0;
            //
            //Label26
            //
            this.Label26.AutoSize = true;
            this.Label26.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label26.Location = new System.Drawing.Point(947, 206);
            this.Label26.Name = "Label26";
            this.Label26.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label26.Size = new System.Drawing.Size(112, 19);
            this.Label26.TabIndex = 237;
            this.Label26.Text = ": علت توقف کار";
            //
            //TabPage3
            //
            this.TabPage3.Controls.Add(this.Dv_Stock);
            this.TabPage3.Location = new System.Drawing.Point(4, 22);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage3.Size = new System.Drawing.Size(1062, 237);
            this.TabPage3.TabIndex = 2;
            this.TabPage3.Text = "نگهداری و تعمیرات";
            this.TabPage3.UseVisualStyleBackColor = true;
            //
            //Dv_Stock
            //
            DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            DataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dv_Stock.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1;
            this.Dv_Stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            DataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dv_Stock.DefaultCellStyle = DataGridViewCellStyle2;
            this.Dv_Stock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dv_Stock.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.Dv_Stock.Location = new System.Drawing.Point(3, 3);
            this.Dv_Stock.Name = "Dv_Stock";
            this.Dv_Stock.Size = new System.Drawing.Size(1056, 231);
            this.Dv_Stock.TabIndex = 2;
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
            this.DV.Size = new System.Drawing.Size(1070, 163);
            this.DV.TabIndex = 0;
            //
            //Repair_Cost
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6.0F, 13.0F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1070, 456);
            this.Controls.Add(this.SplitContainer1);
            this.Controls.Add(this.ToolStrip);
            this.Name = "Repair_Cost";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "÷";
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.SplitContainer1.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.SplitContainer1).EndInit();
            this.SplitContainer1.ResumeLayout(false);
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.TabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.Dv_Stock).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.DV).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal System.Windows.Forms.ToolStrip ToolStrip;
        internal System.Windows.Forms.ToolStripButton New_B;
        internal System.Windows.Forms.ToolStripButton Edit_B;
        internal System.Windows.Forms.ToolStripButton Delet_B;
        internal System.Windows.Forms.ToolStripButton Save_B;
        internal System.Windows.Forms.ToolStripButton Search_B;
        internal System.Windows.Forms.ToolStripButton B_Excel;
        internal System.Windows.Forms.ToolStripButton Chap;
        internal System.Windows.Forms.ToolStripButton Abort_B;
        internal System.Windows.Forms.SplitContainer SplitContainer1;
        internal System.Windows.Forms.DataGridView DV;
        internal System.Windows.Forms.TabControl TabControl1;
        internal System.Windows.Forms.TabPage TabPage1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox Cost_Id_Total;
        internal System.Windows.Forms.TabPage TabPage3;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox Cost_Repair_description;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox Cost_Num_Request;
        internal System.Windows.Forms.Button B_Repair_Seating;
        internal System.Windows.Forms.Label Label17;
        internal System.Windows.Forms.TextBox Cost_Id_Request;
        internal System.Windows.Forms.Button B_Repair_Energy;
        internal Ansaripour.Rtl_Date Cost_Date_Request;
        internal System.Windows.Forms.DataGridView Dv_Stock;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.TextBox Cost_Stop_Defect;
        internal System.Windows.Forms.Button B_Repair_Phase;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label6;
        internal Ansaripour.Rtl_Date Cost_End_Date_Work;
        internal System.Windows.Forms.Label Label9;
        internal Ansaripour.Rtl_Date Cost_Start_Date_Work;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox Cost_Work_description;
        internal System.Windows.Forms.Label Label1;
        internal Ansaripour.Rtl_Date Cost_Date_Sabt;
        internal System.Windows.Forms.Label Label26;
        internal Ansaripour.Rtl_Time Cost_Start_Time_Work;
        internal Ansaripour.Rtl_Time Cost_Time_Request;
        internal Ansaripour.Rtl_Time Cost_End_Time_Work;
        internal System.Windows.Forms.Label Label14;
        private System.Windows.Forms.MaskedTextBox Cost_Time_Stop_Repair;
        private System.Windows.Forms.MaskedTextBox Cost_Time_Befor_Work;
        private System.Windows.Forms.MaskedTextBox Cost_Time_Stop_Work;
    }
}