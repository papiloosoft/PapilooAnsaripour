
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
    public partial class Repair_Report : System.Windows.Forms.Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Repair_Report));
            System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.Search_B = new System.Windows.Forms.ToolStripButton();
            this.B_Excel = new System.Windows.Forms.ToolStripButton();
            this.Chap = new System.Windows.Forms.ToolStripButton();
            this.Abort_B = new System.Windows.Forms.ToolStripButton();
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.Cost_Time_Befor_Work = new System.Windows.Forms.MaskedTextBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Az_Cost_Date_Sabt = new Ansaripour.Rtl_Date();
            this.Label2 = new System.Windows.Forms.Label();
            this.Ta_Cost_Date_Request = new Ansaripour.Rtl_Date();
            this.Cost_Stop_Defect = new System.Windows.Forms.TextBox();
            this.B_Cost_Stop_Defect = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.Cost_Work_description = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Ta_Cost_Date_Sabt = new Ansaripour.Rtl_Date();
            this.Label17 = new System.Windows.Forms.Label();
            this.Cost_Id_Request = new System.Windows.Forms.TextBox();
            this.B_Cost_Id_Request = new System.Windows.Forms.Button();
            this.Label8 = new System.Windows.Forms.Label();
            this.Az_Cost_Date_Request = new Ansaripour.Rtl_Date();
            this.Label7 = new System.Windows.Forms.Label();
            this.Cost_Repair_description = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Cost_Num_Request = new System.Windows.Forms.TextBox();
            this.B_Cost_Id_Total = new System.Windows.Forms.Button();
            this.Label5 = new System.Windows.Forms.Label();
            this.Cost_Id_Total = new System.Windows.Forms.TextBox();
            this.Label26 = new System.Windows.Forms.Label();
            this.Check = new System.Windows.Forms.CheckBox();
            this.DV = new System.Windows.Forms.DataGridView();
            this.ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.SplitContainer1).BeginInit();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.DV).BeginInit();
            this.SuspendLayout();
            //
            //ToolStrip
            //
            this.ToolStrip.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.Search_B, this.B_Excel, this.Chap, this.Abort_B });
            this.ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(1011, 26);
            this.ToolStrip.TabIndex = 1;
            this.ToolStrip.Text = "ToolStrip1";
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
            this.SplitContainer1.Size = new System.Drawing.Size(1011, 430);
            this.SplitContainer1.SplitterDistance = 226;
            this.SplitContainer1.TabIndex = 2;
            //
            //TabControl1
            //
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl1.Location = new System.Drawing.Point(0, 0);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.RightToLeftLayout = true;
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(1011, 226);
            this.TabControl1.TabIndex = 0;
            //
            //TabPage1
            //
            this.TabPage1.Controls.Add(this.Cost_Time_Befor_Work);
            this.TabPage1.Controls.Add(this.Label14);
            this.TabPage1.Controls.Add(this.Label6);
            this.TabPage1.Controls.Add(this.Az_Cost_Date_Sabt);
            this.TabPage1.Controls.Add(this.Label2);
            this.TabPage1.Controls.Add(this.Ta_Cost_Date_Request);
            this.TabPage1.Controls.Add(this.Cost_Stop_Defect);
            this.TabPage1.Controls.Add(this.B_Cost_Stop_Defect);
            this.TabPage1.Controls.Add(this.Label3);
            this.TabPage1.Controls.Add(this.Cost_Work_description);
            this.TabPage1.Controls.Add(this.Label1);
            this.TabPage1.Controls.Add(this.Ta_Cost_Date_Sabt);
            this.TabPage1.Controls.Add(this.Label17);
            this.TabPage1.Controls.Add(this.Cost_Id_Request);
            this.TabPage1.Controls.Add(this.B_Cost_Id_Request);
            this.TabPage1.Controls.Add(this.Label8);
            this.TabPage1.Controls.Add(this.Az_Cost_Date_Request);
            this.TabPage1.Controls.Add(this.Label7);
            this.TabPage1.Controls.Add(this.Cost_Repair_description);
            this.TabPage1.Controls.Add(this.Label4);
            this.TabPage1.Controls.Add(this.Cost_Num_Request);
            this.TabPage1.Controls.Add(this.B_Cost_Id_Total);
            this.TabPage1.Controls.Add(this.Label5);
            this.TabPage1.Controls.Add(this.Cost_Id_Total);
            this.TabPage1.Controls.Add(this.Label26);
            this.TabPage1.Controls.Add(this.Check);
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(1003, 200);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "درخواست خدمات فنی";
            this.TabPage1.UseVisualStyleBackColor = true;
            //
            //Cost_Time_Befor_Work
            //
            this.Cost_Time_Befor_Work.Enabled = false;
            this.Cost_Time_Befor_Work.Font = new System.Drawing.Font("B Traffic", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Cost_Time_Befor_Work.Location = new System.Drawing.Point(8, 160);
            this.Cost_Time_Befor_Work.Mask = "##:##";
            this.Cost_Time_Befor_Work.Name = "Cost_Time_Befor_Work";
            this.Cost_Time_Befor_Work.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Cost_Time_Befor_Work.Size = new System.Drawing.Size(48, 34);
            this.Cost_Time_Befor_Work.TabIndex = 245;
            //
            //Label14
            //
            this.Label14.AutoSize = true;
            this.Label14.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label14.Location = new System.Drawing.Point(58, 169);
            this.Label14.Name = "Label14";
            this.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label14.Size = new System.Drawing.Size(300, 19);
            this.Label14.TabIndex = 246;
            this.Label14.Text = ":مجموع ساعت کارکرد دستگاه قبل تعمیرات";
            //
            //Label6
            //
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label6.Location = new System.Drawing.Point(373, 97);
            this.Label6.Name = "Label6";
            this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label6.Size = new System.Drawing.Size(95, 19);
            this.Label6.TabIndex = 241;
            this.Label6.Text = ": از تاریخ ثبت";
            //
            //Az_Cost_Date_Sabt
            //
            this.Az_Cost_Date_Sabt.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Az_Cost_Date_Sabt.AutoSize = true;
            this.Az_Cost_Date_Sabt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Az_Cost_Date_Sabt.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Az_Cost_Date_Sabt.Location = new System.Drawing.Point(255, 91);
            this.Az_Cost_Date_Sabt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Az_Cost_Date_Sabt.Name = "Az_Cost_Date_Sabt";
            this.Az_Cost_Date_Sabt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Az_Cost_Date_Sabt.Size = new System.Drawing.Size(136, 29);
            this.Az_Cost_Date_Sabt.T_D = "";
            this.Az_Cost_Date_Sabt.TabIndex = 6;
            //
            //Label2
            //
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label2.Location = new System.Drawing.Point(602, 96);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(135, 19);
            this.Label2.TabIndex = 239;
            this.Label2.Text = ": تا تاریخ درخواست";
            //
            //Ta_Cost_Date_Request
            //
            this.Ta_Cost_Date_Request.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Ta_Cost_Date_Request.AutoSize = true;
            this.Ta_Cost_Date_Request.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Ta_Cost_Date_Request.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Ta_Cost_Date_Request.Location = new System.Drawing.Point(480, 91);
            this.Ta_Cost_Date_Request.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ta_Cost_Date_Request.Name = "Ta_Cost_Date_Request";
            this.Ta_Cost_Date_Request.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Ta_Cost_Date_Request.Size = new System.Drawing.Size(136, 29);
            this.Ta_Cost_Date_Request.T_D = "";
            this.Ta_Cost_Date_Request.TabIndex = 5;
            //
            //Cost_Stop_Defect
            //
            this.Cost_Stop_Defect.BackColor = System.Drawing.Color.White;
            this.Cost_Stop_Defect.Enabled = false;
            this.Cost_Stop_Defect.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Cost_Stop_Defect.Location = new System.Drawing.Point(505, 47);
            this.Cost_Stop_Defect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cost_Stop_Defect.Name = "Cost_Stop_Defect";
            this.Cost_Stop_Defect.Size = new System.Drawing.Size(379, 30);
            this.Cost_Stop_Defect.TabIndex = 2;
            //
            //B_Cost_Stop_Defect
            //
            this.B_Cost_Stop_Defect.Image = (System.Drawing.Image)resources.GetObject("B_Cost_Stop_Defect.Image");
            this.B_Cost_Stop_Defect.Location = new System.Drawing.Point(474, 48);
            this.B_Cost_Stop_Defect.Name = "B_Cost_Stop_Defect";
            this.B_Cost_Stop_Defect.Size = new System.Drawing.Size(29, 27);
            this.B_Cost_Stop_Defect.TabIndex = 236;
            this.B_Cost_Stop_Defect.UseVisualStyleBackColor = true;
            //
            //Label3
            //
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label3.Location = new System.Drawing.Point(799, 170);
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
            this.Cost_Work_description.Location = new System.Drawing.Point(394, 164);
            this.Cost_Work_description.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cost_Work_description.Name = "Cost_Work_description";
            this.Cost_Work_description.Size = new System.Drawing.Size(403, 30);
            this.Cost_Work_description.TabIndex = 9;
            //
            //Label1
            //
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label1.Location = new System.Drawing.Point(124, 96);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(99, 19);
            this.Label1.TabIndex = 224;
            this.Label1.Text = ": تا تاریخ ثبت ";
            //
            //Ta_Cost_Date_Sabt
            //
            this.Ta_Cost_Date_Sabt.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Ta_Cost_Date_Sabt.AutoSize = true;
            this.Ta_Cost_Date_Sabt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Ta_Cost_Date_Sabt.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Ta_Cost_Date_Sabt.Location = new System.Drawing.Point(6, 90);
            this.Ta_Cost_Date_Sabt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ta_Cost_Date_Sabt.Name = "Ta_Cost_Date_Sabt";
            this.Ta_Cost_Date_Sabt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Ta_Cost_Date_Sabt.Size = new System.Drawing.Size(136, 29);
            this.Ta_Cost_Date_Sabt.T_D = "";
            this.Ta_Cost_Date_Sabt.TabIndex = 7;
            //
            //Label17
            //
            this.Label17.AutoSize = true;
            this.Label17.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label17.Location = new System.Drawing.Point(305, 13);
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
            this.Cost_Id_Request.Location = new System.Drawing.Point(39, 7);
            this.Cost_Id_Request.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cost_Id_Request.Name = "Cost_Id_Request";
            this.Cost_Id_Request.Size = new System.Drawing.Size(264, 30);
            this.Cost_Id_Request.TabIndex = 1;
            //
            //B_Cost_Id_Request
            //
            this.B_Cost_Id_Request.Image = (System.Drawing.Image)resources.GetObject("B_Cost_Id_Request.Image");
            this.B_Cost_Id_Request.Location = new System.Drawing.Point(8, 8);
            this.B_Cost_Id_Request.Name = "B_Cost_Id_Request";
            this.B_Cost_Id_Request.Size = new System.Drawing.Size(29, 27);
            this.B_Cost_Id_Request.TabIndex = 220;
            this.B_Cost_Id_Request.UseVisualStyleBackColor = true;
            //
            //Label8
            //
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label8.Location = new System.Drawing.Point(858, 96);
            this.Label8.Name = "Label8";
            this.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label8.Size = new System.Drawing.Size(131, 19);
            this.Label8.TabIndex = 203;
            this.Label8.Text = ":از تاریخ درخواست";
            //
            //Az_Cost_Date_Request
            //
            this.Az_Cost_Date_Request.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Az_Cost_Date_Request.AutoSize = true;
            this.Az_Cost_Date_Request.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Az_Cost_Date_Request.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Az_Cost_Date_Request.Location = new System.Drawing.Point(742, 90);
            this.Az_Cost_Date_Request.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Az_Cost_Date_Request.Name = "Az_Cost_Date_Request";
            this.Az_Cost_Date_Request.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Az_Cost_Date_Request.Size = new System.Drawing.Size(136, 29);
            this.Az_Cost_Date_Request.T_D = "";
            this.Az_Cost_Date_Request.TabIndex = 4;
            //
            //Label7
            //
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label7.Location = new System.Drawing.Point(901, 132);
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
            this.Cost_Repair_description.Location = new System.Drawing.Point(8, 126);
            this.Cost_Repair_description.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cost_Repair_description.Name = "Cost_Repair_description";
            this.Cost_Repair_description.Size = new System.Drawing.Size(892, 30);
            this.Cost_Repair_description.TabIndex = 8;
            //
            //Label4
            //
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label4.Location = new System.Drawing.Point(307, 54);
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
            this.Cost_Num_Request.Location = new System.Drawing.Point(8, 48);
            this.Cost_Num_Request.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cost_Num_Request.Name = "Cost_Num_Request";
            this.Cost_Num_Request.Size = new System.Drawing.Size(294, 30);
            this.Cost_Num_Request.TabIndex = 3;
            //
            //B_Cost_Id_Total
            //
            this.B_Cost_Id_Total.Image = (System.Drawing.Image)resources.GetObject("B_Cost_Id_Total.Image");
            this.B_Cost_Id_Total.Location = new System.Drawing.Point(474, 10);
            this.B_Cost_Id_Total.Name = "B_Cost_Id_Total";
            this.B_Cost_Id_Total.Size = new System.Drawing.Size(29, 27);
            this.B_Cost_Id_Total.TabIndex = 195;
            this.B_Cost_Id_Total.UseVisualStyleBackColor = true;
            //
            //Label5
            //
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label5.Location = new System.Drawing.Point(838, 14);
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
            this.Cost_Id_Total.Location = new System.Drawing.Point(505, 8);
            this.Cost_Id_Total.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cost_Id_Total.Name = "Cost_Id_Total";
            this.Cost_Id_Total.Size = new System.Drawing.Size(329, 30);
            this.Cost_Id_Total.TabIndex = 0;
            //
            //Label26
            //
            this.Label26.AutoSize = true;
            this.Label26.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label26.Location = new System.Drawing.Point(883, 53);
            this.Label26.Name = "Label26";
            this.Label26.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label26.Size = new System.Drawing.Size(112, 19);
            this.Label26.TabIndex = 237;
            this.Label26.Text = ": علت توقف کار";
            //
            //Check
            //
            this.Check.AutoSize = true;
            this.Check.Location = new System.Drawing.Point(347, 173);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(26, 17);
            this.Check.TabIndex = 247;
            this.Check.Text = "" + "\r" + "\n";
            this.Check.UseVisualStyleBackColor = true;
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
            this.DV.Size = new System.Drawing.Size(1011, 200);
            this.DV.TabIndex = 0;
            //
            //Repair_Report
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6.0F, 13.0F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 456);
            this.Controls.Add(this.SplitContainer1);
            this.Controls.Add(this.ToolStrip);
            this.Name = "Repair_Report";
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
            ((System.ComponentModel.ISupportInitialize)this.DV).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal System.Windows.Forms.ToolStrip ToolStrip;
        internal System.Windows.Forms.ToolStripButton Search_B;
        internal System.Windows.Forms.ToolStripButton B_Excel;
        internal System.Windows.Forms.ToolStripButton Chap;
        internal System.Windows.Forms.ToolStripButton Abort_B;
        internal System.Windows.Forms.SplitContainer SplitContainer1;
        internal System.Windows.Forms.DataGridView DV;
        internal System.Windows.Forms.TabControl TabControl1;
        internal System.Windows.Forms.TabPage TabPage1;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox Cost_Id_Total;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox Cost_Repair_description;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox Cost_Num_Request;
        internal System.Windows.Forms.Button B_Cost_Id_Total;
        internal System.Windows.Forms.Label Label17;
        internal System.Windows.Forms.TextBox Cost_Id_Request;
        internal System.Windows.Forms.Button B_Cost_Id_Request;
        internal Ansaripour.Rtl_Date Az_Cost_Date_Request;
        internal System.Windows.Forms.TextBox Cost_Stop_Defect;
        internal System.Windows.Forms.Button B_Cost_Stop_Defect;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox Cost_Work_description;
        internal System.Windows.Forms.Label Label1;
        internal Ansaripour.Rtl_Date Ta_Cost_Date_Sabt;
        internal System.Windows.Forms.Label Label26;
        internal System.Windows.Forms.Label Label6;
        internal Ansaripour.Rtl_Date Az_Cost_Date_Sabt;
        internal System.Windows.Forms.Label Label2;
        internal Ansaripour.Rtl_Date Ta_Cost_Date_Request;
        private System.Windows.Forms.MaskedTextBox Cost_Time_Befor_Work;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.CheckBox Check;
    }
}
