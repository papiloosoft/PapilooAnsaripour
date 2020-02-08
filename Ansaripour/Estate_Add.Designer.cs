
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
    public partial class Estate_Add : System.Windows.Forms.Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estate_Add));
            System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Estate_No_Document = new System.Windows.Forms.TextBox();
            this.Check_Depreciated = new System.Windows.Forms.CheckBox();
            this.B_Project = new System.Windows.Forms.Button();
            this.Label16 = new System.Windows.Forms.Label();
            this.Estate_Project = new System.Windows.Forms.TextBox();
            this.Label17 = new System.Windows.Forms.Label();
            this.B_Plan = new System.Windows.Forms.Button();
            this.Estate_Plan = new System.Windows.Forms.TextBox();
            this.Label23 = new System.Windows.Forms.Label();
            this.Day = new System.Windows.Forms.Label();
            this.Progress = new System.Windows.Forms.ProgressBar();
            this.Label15 = new System.Windows.Forms.Label();
            this.Check_B_Date = new System.Windows.Forms.CheckBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label29 = new System.Windows.Forms.Label();
            this.Label24 = new System.Windows.Forms.Label();
            this.Estate_Date_Until = new Ansaripour.Rtl_Date();
            this.Estate_Date_From = new Ansaripour.Rtl_Date();
            this.Check_Date = new System.Windows.Forms.CheckBox();
            this.Estate_No_Personnel = new System.Windows.Forms.TextBox();
            this.B_Personal_Chek = new System.Windows.Forms.Button();
            this.Estate_Description = new System.Windows.Forms.TextBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.Estate_Depreciation = new System.Windows.Forms.TextBox();
            this.Estehlak_Label = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.Estate_No_Remittance = new System.Windows.Forms.TextBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Price_Label = new System.Windows.Forms.Label();
            this.Estate_Price = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Estate_Name = new System.Windows.Forms.TextBox();
            this.Estate_Plaque = new System.Windows.Forms.ComboBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Estate_Cost_Code = new System.Windows.Forms.ComboBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Estate_Sub_Code = new System.Windows.Forms.ComboBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Estate_Original_Code = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Estate_City = new System.Windows.Forms.ComboBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.Estate_Date_Remittance = new Ansaripour.Rtl_Date();
            this.Estate_Date_Document = new Ansaripour.Rtl_Date();
            this.Estate_Date_Price = new Ansaripour.Rtl_Date();
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.B_Product = new System.Windows.Forms.ToolStripDropDownButton();
            this.B_Single_Dismiss = new System.Windows.Forms.ToolStripMenuItem();
            this.B_Total_Dismiss = new System.Windows.Forms.ToolStripMenuItem();
            this.B_Increase = new System.Windows.Forms.ToolStripMenuItem();
            this.B_Decrease = new System.Windows.Forms.ToolStripMenuItem();
            this.B_Movement = new System.Windows.Forms.ToolStripMenuItem();
            this.B_Movement_All = new System.Windows.Forms.ToolStripMenuItem();
            this.B_Period = new System.Windows.Forms.ToolStripMenuItem();
            this.B_Depreciation = new System.Windows.Forms.ToolStripMenuItem();
            this.B_New_Depreciation = new System.Windows.Forms.ToolStripMenuItem();
            this.B_Chek_Revaluation = new System.Windows.Forms.ToolStripMenuItem();
            this.New_B = new System.Windows.Forms.ToolStripButton();
            this.Edit_B = new System.Windows.Forms.ToolStripButton();
            this.Save_B = new System.Windows.Forms.ToolStripButton();
            this.Delet_B = new System.Windows.Forms.ToolStripButton();
            this.N_Search = new System.Windows.Forms.ToolStripComboBox();
            this.Search_B = new System.Windows.Forms.ToolStripButton();
            this.Chap_B = new System.Windows.Forms.ToolStripButton();
            this.Picture_B = new System.Windows.Forms.ToolStripButton();
            this.Excel_B = new System.Windows.Forms.ToolStripButton();
            this.Log_File = new System.Windows.Forms.ToolStripButton();
            this.Abort_B = new System.Windows.Forms.ToolStripButton();
            this.Estate_Control = new System.Windows.Forms.ToolStripComboBox();
            this.Label18 = new System.Windows.Forms.Label();
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
            this.SplitContainer1.Panel1.Controls.Add(this.Estate_No_Document);
            this.SplitContainer1.Panel1.Controls.Add(this.Check_Depreciated);
            this.SplitContainer1.Panel1.Controls.Add(this.B_Project);
            this.SplitContainer1.Panel1.Controls.Add(this.Label16);
            this.SplitContainer1.Panel1.Controls.Add(this.Estate_Project);
            this.SplitContainer1.Panel1.Controls.Add(this.Label17);
            this.SplitContainer1.Panel1.Controls.Add(this.B_Plan);
            this.SplitContainer1.Panel1.Controls.Add(this.Estate_Plan);
            this.SplitContainer1.Panel1.Controls.Add(this.Label23);
            this.SplitContainer1.Panel1.Controls.Add(this.Day);
            this.SplitContainer1.Panel1.Controls.Add(this.Progress);
            this.SplitContainer1.Panel1.Controls.Add(this.Label15);
            this.SplitContainer1.Panel1.Controls.Add(this.Check_B_Date);
            this.SplitContainer1.Panel1.Controls.Add(this.Label7);
            this.SplitContainer1.Panel1.Controls.Add(this.GroupBox1);
            this.SplitContainer1.Panel1.Controls.Add(this.Check_Date);
            this.SplitContainer1.Panel1.Controls.Add(this.Estate_No_Personnel);
            this.SplitContainer1.Panel1.Controls.Add(this.B_Personal_Chek);
            this.SplitContainer1.Panel1.Controls.Add(this.Estate_Description);
            this.SplitContainer1.Panel1.Controls.Add(this.Label14);
            this.SplitContainer1.Panel1.Controls.Add(this.Estate_Depreciation);
            this.SplitContainer1.Panel1.Controls.Add(this.Estehlak_Label);
            this.SplitContainer1.Panel1.Controls.Add(this.Label13);
            this.SplitContainer1.Panel1.Controls.Add(this.Label11);
            this.SplitContainer1.Panel1.Controls.Add(this.Estate_No_Remittance);
            this.SplitContainer1.Panel1.Controls.Add(this.Label12);
            this.SplitContainer1.Panel1.Controls.Add(this.Label9);
            this.SplitContainer1.Panel1.Controls.Add(this.Label10);
            this.SplitContainer1.Panel1.Controls.Add(this.Price_Label);
            this.SplitContainer1.Panel1.Controls.Add(this.Estate_Price);
            this.SplitContainer1.Panel1.Controls.Add(this.Label6);
            this.SplitContainer1.Panel1.Controls.Add(this.Label5);
            this.SplitContainer1.Panel1.Controls.Add(this.Estate_Name);
            this.SplitContainer1.Panel1.Controls.Add(this.Estate_Plaque);
            this.SplitContainer1.Panel1.Controls.Add(this.Label4);
            this.SplitContainer1.Panel1.Controls.Add(this.Estate_Cost_Code);
            this.SplitContainer1.Panel1.Controls.Add(this.Label3);
            this.SplitContainer1.Panel1.Controls.Add(this.Estate_Sub_Code);
            this.SplitContainer1.Panel1.Controls.Add(this.Label2);
            this.SplitContainer1.Panel1.Controls.Add(this.Estate_Original_Code);
            this.SplitContainer1.Panel1.Controls.Add(this.Label1);
            this.SplitContainer1.Panel1.Controls.Add(this.Estate_City);
            this.SplitContainer1.Panel1.Controls.Add(this.Label8);
            this.SplitContainer1.Panel1.Controls.Add(this.Estate_Date_Remittance);
            this.SplitContainer1.Panel1.Controls.Add(this.Estate_Date_Document);
            this.SplitContainer1.Panel1.Controls.Add(this.Estate_Date_Price);
            this.SplitContainer1.Panel1.Controls.Add(this.ToolStrip);
            this.SplitContainer1.Panel1.Controls.Add(this.Label18);
            this.SplitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            //
            //SplitContainer1.Panel2
            //
            this.SplitContainer1.Panel2.Controls.Add(this.DV);
            this.SplitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SplitContainer1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SplitContainer1.Size = new System.Drawing.Size(1228, 534);
            this.SplitContainer1.SplitterDistance = 297;
            this.SplitContainer1.SplitterWidth = 5;
            this.SplitContainer1.TabIndex = 0;
            //
            //Estate_No_Document
            //
            this.Estate_No_Document.BackColor = System.Drawing.Color.White;
            this.Estate_No_Document.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Estate_No_Document.Location = new System.Drawing.Point(1042, 136);
            this.Estate_No_Document.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Estate_No_Document.Name = "Estate_No_Document";
            this.Estate_No_Document.Size = new System.Drawing.Size(64, 30);
            this.Estate_No_Document.TabIndex = 10;
            //
            //Check_Depreciated
            //
            this.Check_Depreciated.AutoSize = true;
            this.Check_Depreciated.Location = new System.Drawing.Point(304, 272);
            this.Check_Depreciated.Name = "Check_Depreciated";
            this.Check_Depreciated.Size = new System.Drawing.Size(15, 14);
            this.Check_Depreciated.TabIndex = 339;
            this.Check_Depreciated.UseVisualStyleBackColor = true;
            //
            //B_Project
            //
            this.B_Project.Image = (System.Drawing.Image)resources.GetObject("B_Project.Image");
            this.B_Project.Location = new System.Drawing.Point(12, 212);
            this.B_Project.Name = "B_Project";
            this.B_Project.Size = new System.Drawing.Size(29, 27);
            this.B_Project.TabIndex = 338;
            this.B_Project.UseVisualStyleBackColor = true;
            //
            //Label16
            //
            this.Label16.AutoSize = true;
            this.Label16.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label16.Location = new System.Drawing.Point(523, 218);
            this.Label16.Name = "Label16";
            this.Label16.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label16.Size = new System.Drawing.Size(137, 19);
            this.Label16.TabIndex = 337;
            this.Label16.Text = "نام و شماره پروژه :";
            //
            //Estate_Project
            //
            this.Estate_Project.Enabled = false;
            this.Estate_Project.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Estate_Project.Location = new System.Drawing.Point(43, 211);
            this.Estate_Project.Name = "Estate_Project";
            this.Estate_Project.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Estate_Project.Size = new System.Drawing.Size(475, 31);
            this.Estate_Project.TabIndex = 334;
            //
            //Label17
            //
            this.Label17.AutoSize = true;
            this.Label17.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label17.Location = new System.Drawing.Point(1091, 218);
            this.Label17.Name = "Label17";
            this.Label17.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label17.Size = new System.Drawing.Size(133, 19);
            this.Label17.TabIndex = 336;
            this.Label17.Text = "نام و شماره طرح :";
            //
            //B_Plan
            //
            this.B_Plan.Image = (System.Drawing.Image)resources.GetObject("B_Plan.Image");
            this.B_Plan.Location = new System.Drawing.Point(662, 215);
            this.B_Plan.Name = "B_Plan";
            this.B_Plan.Size = new System.Drawing.Size(29, 27);
            this.B_Plan.TabIndex = 335;
            this.B_Plan.UseVisualStyleBackColor = true;
            //
            //Estate_Plan
            //
            this.Estate_Plan.Enabled = false;
            this.Estate_Plan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Estate_Plan.Location = new System.Drawing.Point(693, 213);
            this.Estate_Plan.Name = "Estate_Plan";
            this.Estate_Plan.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Estate_Plan.Size = new System.Drawing.Size(391, 31);
            this.Estate_Plan.TabIndex = 333;
            //
            //Label23
            //
            this.Label23.AutoSize = true;
            this.Label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label23.Location = new System.Drawing.Point(135, 264);
            this.Label23.Name = "Label23";
            this.Label23.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label23.Size = new System.Drawing.Size(163, 25);
            this.Label23.TabIndex = 332;
            this.Label23.Text = " بر حسب تعداد روز :";
            //
            //Day
            //
            this.Day.AutoSize = true;
            this.Day.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Day.ForeColor = System.Drawing.Color.Red;
            this.Day.Location = new System.Drawing.Point(71, 266);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(23, 25);
            this.Day.TabIndex = 331;
            this.Day.Text = "0";
            //
            //Progress
            //
            this.Progress.Location = new System.Drawing.Point(12, 248);
            this.Progress.Name = "Progress";
            this.Progress.Size = new System.Drawing.Size(631, 10);
            this.Progress.TabIndex = 330;
            this.Progress.Visible = false;
            //
            //Label15
            //
            this.Label15.AutoSize = true;
            this.Label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label15.Location = new System.Drawing.Point(480, 264);
            this.Label15.Name = "Label15";
            this.Label15.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label15.Size = new System.Drawing.Size(163, 25);
            this.Label15.TabIndex = 329;
            this.Label15.Text = " اموال برکناری شده :";
            //
            //Check_B_Date
            //
            this.Check_B_Date.AutoSize = true;
            this.Check_B_Date.Location = new System.Drawing.Point(466, 271);
            this.Check_B_Date.Name = "Check_B_Date";
            this.Check_B_Date.Size = new System.Drawing.Size(15, 14);
            this.Check_B_Date.TabIndex = 18;
            this.Check_B_Date.UseVisualStyleBackColor = true;
            //
            //Label7
            //
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label7.Location = new System.Drawing.Point(1077, 261);
            this.Label7.Name = "Label7";
            this.Label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label7.Size = new System.Drawing.Size(146, 19);
            this.Label7.TabIndex = 327;
            this.Label7.Text = "دوره محاسبه اموال :";
            //
            //GroupBox1
            //
            this.GroupBox1.Controls.Add(this.Label29);
            this.GroupBox1.Controls.Add(this.Label24);
            this.GroupBox1.Controls.Add(this.Estate_Date_Until);
            this.GroupBox1.Controls.Add(this.Estate_Date_From);
            this.GroupBox1.Location = new System.Drawing.Point(662, 245);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(399, 46);
            this.GroupBox1.TabIndex = 326;
            this.GroupBox1.TabStop = false;
            //
            //Label29
            //
            this.Label29.AutoSize = true;
            this.Label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label29.Location = new System.Drawing.Point(125, 14);
            this.Label29.Name = "Label29";
            this.Label29.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label29.Size = new System.Drawing.Size(76, 25);
            this.Label29.TabIndex = 314;
            this.Label29.Text = "تا تاریخ :";
            //
            //Label24
            //
            this.Label24.AutoSize = true;
            this.Label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label24.Location = new System.Drawing.Point(317, 13);
            this.Label24.Name = "Label24";
            this.Label24.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label24.Size = new System.Drawing.Size(81, 25);
            this.Label24.TabIndex = 312;
            this.Label24.Text = "از تاریخ :";
            //
            //Estate_Date_Until
            //
            this.Estate_Date_Until.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Estate_Date_Until.AutoSize = true;
            this.Estate_Date_Until.BackColor = System.Drawing.Color.White;
            this.Estate_Date_Until.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Estate_Date_Until.Location = new System.Drawing.Point(8, 11);
            this.Estate_Date_Until.Name = "Estate_Date_Until";
            this.Estate_Date_Until.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Estate_Date_Until.Size = new System.Drawing.Size(135, 32);
            this.Estate_Date_Until.T_D = "";
            this.Estate_Date_Until.TabIndex = 1;
            //
            //Estate_Date_From
            //
            this.Estate_Date_From.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Estate_Date_From.AutoSize = true;
            this.Estate_Date_From.BackColor = System.Drawing.Color.White;
            this.Estate_Date_From.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Estate_Date_From.Location = new System.Drawing.Point(201, 11);
            this.Estate_Date_From.Name = "Estate_Date_From";
            this.Estate_Date_From.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Estate_Date_From.Size = new System.Drawing.Size(135, 32);
            this.Estate_Date_From.T_D = "";
            this.Estate_Date_From.TabIndex = 0;
            //
            //Check_Date
            //
            this.Check_Date.AutoSize = true;
            this.Check_Date.Location = new System.Drawing.Point(1062, 266);
            this.Check_Date.Name = "Check_Date";
            this.Check_Date.Size = new System.Drawing.Size(15, 14);
            this.Check_Date.TabIndex = 17;
            this.Check_Date.UseVisualStyleBackColor = true;
            //
            //Estate_No_Personnel
            //
            this.Estate_No_Personnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Estate_No_Personnel.Location = new System.Drawing.Point(41, 135);
            this.Estate_No_Personnel.Name = "Estate_No_Personnel";
            this.Estate_No_Personnel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Estate_No_Personnel.Size = new System.Drawing.Size(364, 31);
            this.Estate_No_Personnel.TabIndex = 14;
            //
            //B_Personal_Chek
            //
            this.B_Personal_Chek.Image = (System.Drawing.Image)resources.GetObject("B_Personal_Chek.Image");
            this.B_Personal_Chek.Location = new System.Drawing.Point(11, 137);
            this.B_Personal_Chek.Name = "B_Personal_Chek";
            this.B_Personal_Chek.Size = new System.Drawing.Size(29, 27);
            this.B_Personal_Chek.TabIndex = 15;
            this.B_Personal_Chek.UseVisualStyleBackColor = true;
            //
            //Estate_Description
            //
            this.Estate_Description.BackColor = System.Drawing.Color.White;
            this.Estate_Description.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Estate_Description.Location = new System.Drawing.Point(12, 174);
            this.Estate_Description.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Estate_Description.Name = "Estate_Description";
            this.Estate_Description.Size = new System.Drawing.Size(1129, 30);
            this.Estate_Description.TabIndex = 16;
            //
            //Label14
            //
            this.Label14.AutoSize = true;
            this.Label14.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label14.Location = new System.Drawing.Point(1147, 180);
            this.Label14.Name = "Label14";
            this.Label14.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label14.Size = new System.Drawing.Size(73, 19);
            this.Label14.TabIndex = 240;
            this.Label14.Text = "توضیحات:";
            //
            //Estate_Depreciation
            //
            this.Estate_Depreciation.BackColor = System.Drawing.Color.White;
            this.Estate_Depreciation.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Estate_Depreciation.Location = new System.Drawing.Point(219, 98);
            this.Estate_Depreciation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Estate_Depreciation.MaxLength = 15;
            this.Estate_Depreciation.Name = "Estate_Depreciation";
            this.Estate_Depreciation.Size = new System.Drawing.Size(186, 30);
            this.Estate_Depreciation.TabIndex = 8;
            //
            //Estehlak_Label
            //
            this.Estehlak_Label.AutoSize = true;
            this.Estehlak_Label.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Estehlak_Label.Location = new System.Drawing.Point(405, 104);
            this.Estehlak_Label.Name = "Estehlak_Label";
            this.Estehlak_Label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Estehlak_Label.Size = new System.Drawing.Size(130, 19);
            this.Estehlak_Label.TabIndex = 238;
            this.Estehlak_Label.Text = "ذخیره استهلاک  :";
            //
            //Label13
            //
            this.Label13.AutoSize = true;
            this.Label13.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label13.Location = new System.Drawing.Point(407, 141);
            this.Label13.Name = "Label13";
            this.Label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label13.Size = new System.Drawing.Size(177, 19);
            this.Label13.TabIndex = 231;
            this.Label13.Text = "کد پرسنل تحویل گیرنده :";
            //
            //Label11
            //
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label11.Location = new System.Drawing.Point(652, 142);
            this.Label11.Name = "Label11";
            this.Label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label11.Size = new System.Drawing.Size(144, 19);
            this.Label11.TabIndex = 229;
            this.Label11.Text = "شماره حواله اموال :";
            //
            //Estate_No_Remittance
            //
            this.Estate_No_Remittance.BackColor = System.Drawing.Color.White;
            this.Estate_No_Remittance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Estate_No_Remittance.Location = new System.Drawing.Point(590, 136);
            this.Estate_No_Remittance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Estate_No_Remittance.Name = "Estate_No_Remittance";
            this.Estate_No_Remittance.Size = new System.Drawing.Size(61, 30);
            this.Estate_No_Remittance.TabIndex = 12;
            //
            //Label12
            //
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label12.Location = new System.Drawing.Point(914, 142);
            this.Label12.Name = "Label12";
            this.Label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label12.Size = new System.Drawing.Size(129, 19);
            this.Label12.TabIndex = 227;
            this.Label12.Text = "تاریخ حواله اموال :";
            //
            //Label9
            //
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label9.Location = new System.Drawing.Point(1110, 142);
            this.Label9.Name = "Label9";
            this.Label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label9.Size = new System.Drawing.Size(106, 19);
            this.Label9.TabIndex = 225;
            this.Label9.Text = "شماره سند  :";
            //
            //Label10
            //
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label10.Location = new System.Drawing.Point(127, 104);
            this.Label10.Name = "Label10";
            this.Label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label10.Size = new System.Drawing.Size(91, 19);
            this.Label10.TabIndex = 222;
            this.Label10.Text = "تاریخ سند  :";
            //
            //Price_Label
            //
            this.Price_Label.AutoSize = true;
            this.Price_Label.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Price_Label.Location = new System.Drawing.Point(781, 102);
            this.Price_Label.Name = "Price_Label";
            this.Price_Label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Price_Label.Size = new System.Drawing.Size(129, 19);
            this.Price_Label.TabIndex = 220;
            this.Price_Label.Text = "قیمت تمام شده :";
            //
            //Estate_Price
            //
            this.Estate_Price.BackColor = System.Drawing.Color.White;
            this.Estate_Price.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Estate_Price.Location = new System.Drawing.Point(590, 97);
            this.Estate_Price.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Estate_Price.MaxLength = 15;
            this.Estate_Price.Name = "Estate_Price";
            this.Estate_Price.Size = new System.Drawing.Size(188, 30);
            this.Estate_Price.TabIndex = 7;
            //
            //Label6
            //
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label6.Location = new System.Drawing.Point(1086, 105);
            this.Label6.Name = "Label6";
            this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label6.Size = new System.Drawing.Size(134, 19);
            this.Label6.TabIndex = 217;
            this.Label6.Text = "تاریخ  خرید اموال  :";
            //
            //Label5
            //
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label5.Location = new System.Drawing.Point(484, 68);
            this.Label5.Name = "Label5";
            this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label5.Size = new System.Drawing.Size(86, 19);
            this.Label5.TabIndex = 185;
            this.Label5.Text = "شرح اموال:";
            //
            //Estate_Name
            //
            this.Estate_Name.BackColor = System.Drawing.Color.White;
            this.Estate_Name.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Estate_Name.Location = new System.Drawing.Point(10, 60);
            this.Estate_Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Estate_Name.Name = "Estate_Name";
            this.Estate_Name.Size = new System.Drawing.Size(471, 30);
            this.Estate_Name.TabIndex = 5;
            //
            //Estate_Plaque
            //
            this.Estate_Plaque.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Estate_Plaque.FormattingEnabled = true;
            this.Estate_Plaque.Location = new System.Drawing.Point(590, 63);
            this.Estate_Plaque.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Estate_Plaque.Name = "Estate_Plaque";
            this.Estate_Plaque.Size = new System.Drawing.Size(165, 27);
            this.Estate_Plaque.TabIndex = 4;
            //
            //Label4
            //
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label4.Location = new System.Drawing.Point(753, 68);
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label4.Size = new System.Drawing.Size(100, 19);
            this.Label4.TabIndex = 141;
            this.Label4.Text = "شماره پلاک :";
            //
            //Estate_Cost_Code
            //
            this.Estate_Cost_Code.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Estate_Cost_Code.FormattingEnabled = true;
            this.Estate_Cost_Code.Location = new System.Drawing.Point(868, 66);
            this.Estate_Cost_Code.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Estate_Cost_Code.Name = "Estate_Cost_Code";
            this.Estate_Cost_Code.Size = new System.Drawing.Size(262, 24);
            this.Estate_Cost_Code.TabIndex = 3;
            //
            //Label3
            //
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label3.Location = new System.Drawing.Point(1127, 69);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label3.Size = new System.Drawing.Size(92, 19);
            this.Label3.TabIndex = 139;
            this.Label3.Text = "مرکز هزینه :";
            //
            //Estate_Sub_Code
            //
            this.Estate_Sub_Code.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Estate_Sub_Code.FormattingEnabled = true;
            this.Estate_Sub_Code.Location = new System.Drawing.Point(10, 30);
            this.Estate_Sub_Code.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Estate_Sub_Code.Name = "Estate_Sub_Code";
            this.Estate_Sub_Code.Size = new System.Drawing.Size(460, 24);
            this.Estate_Sub_Code.TabIndex = 2;
            //
            //Label2
            //
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label2.Location = new System.Drawing.Point(474, 32);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label2.Size = new System.Drawing.Size(81, 19);
            this.Label2.TabIndex = 137;
            this.Label2.Text = "کد فرعی :";
            //
            //Estate_Original_Code
            //
            this.Estate_Original_Code.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Estate_Original_Code.FormattingEnabled = true;
            this.Estate_Original_Code.Location = new System.Drawing.Point(590, 32);
            this.Estate_Original_Code.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Estate_Original_Code.Name = "Estate_Original_Code";
            this.Estate_Original_Code.Size = new System.Drawing.Size(282, 24);
            this.Estate_Original_Code.TabIndex = 1;
            //
            //Label1
            //
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label1.Location = new System.Drawing.Point(875, 35);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label1.Size = new System.Drawing.Size(80, 19);
            this.Label1.TabIndex = 135;
            this.Label1.Text = "کد اصلی :";
            //
            //Estate_City
            //
            this.Estate_City.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Estate_City.FormattingEnabled = true;
            this.Estate_City.Location = new System.Drawing.Point(969, 30);
            this.Estate_City.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Estate_City.Name = "Estate_City";
            this.Estate_City.Size = new System.Drawing.Size(189, 24);
            this.Estate_City.TabIndex = 0;
            //
            //Label8
            //
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label8.Location = new System.Drawing.Point(1165, 32);
            this.Label8.Name = "Label8";
            this.Label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label8.Size = new System.Drawing.Size(47, 19);
            this.Label8.TabIndex = 133;
            this.Label8.Text = "شهر:";
            //
            //Estate_Date_Remittance
            //
            this.Estate_Date_Remittance.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Estate_Date_Remittance.AutoSize = true;
            this.Estate_Date_Remittance.BackColor = System.Drawing.Color.White;
            this.Estate_Date_Remittance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Estate_Date_Remittance.Location = new System.Drawing.Point(799, 136);
            this.Estate_Date_Remittance.Name = "Estate_Date_Remittance";
            this.Estate_Date_Remittance.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Estate_Date_Remittance.Size = new System.Drawing.Size(135, 36);
            this.Estate_Date_Remittance.T_D = "";
            this.Estate_Date_Remittance.TabIndex = 11;
            //
            //Estate_Date_Document
            //
            this.Estate_Date_Document.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Estate_Date_Document.AutoSize = true;
            this.Estate_Date_Document.BackColor = System.Drawing.Color.White;
            this.Estate_Date_Document.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Estate_Date_Document.Location = new System.Drawing.Point(12, 98);
            this.Estate_Date_Document.Name = "Estate_Date_Document";
            this.Estate_Date_Document.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Estate_Date_Document.Size = new System.Drawing.Size(135, 36);
            this.Estate_Date_Document.T_D = "";
            this.Estate_Date_Document.TabIndex = 9;
            //
            //Estate_Date_Price
            //
            this.Estate_Date_Price.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Estate_Date_Price.AutoSize = true;
            this.Estate_Date_Price.BackColor = System.Drawing.Color.White;
            this.Estate_Date_Price.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Estate_Date_Price.Location = new System.Drawing.Point(971, 99);
            this.Estate_Date_Price.Name = "Estate_Date_Price";
            this.Estate_Date_Price.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Estate_Date_Price.Size = new System.Drawing.Size(135, 36);
            this.Estate_Date_Price.T_D = "";
            this.Estate_Date_Price.TabIndex = 6;
            //
            //ToolStrip
            //
            this.ToolStrip.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.B_Product, this.New_B, this.Edit_B, this.Save_B, this.Delet_B, this.N_Search, this.Search_B, this.Chap_B, this.Picture_B, this.Excel_B, this.Log_File, this.Abort_B, this.Estate_Control });
            this.ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(1228, 26);
            this.ToolStrip.TabIndex = 0;
            this.ToolStrip.Text = "ToolStrip1";
            //
            //B_Product
            //
            this.B_Product.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.B_Single_Dismiss, this.B_Total_Dismiss, this.B_Increase, this.B_Decrease, this.B_Movement, this.B_Movement_All, this.B_Period, this.B_Depreciation, this.B_New_Depreciation, this.B_Chek_Revaluation });
            this.B_Product.Image = (System.Drawing.Image)resources.GetObject("B_Product.Image");
            this.B_Product.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.B_Product.Name = "B_Product";
            this.B_Product.Size = new System.Drawing.Size(87, 23);
            this.B_Product.Text = "عملیات";
            this.B_Product.Visible = false;
            //
            //B_Single_Dismiss
            //
            this.B_Single_Dismiss.Image = (System.Drawing.Image)resources.GetObject("B_Single_Dismiss.Image");
            this.B_Single_Dismiss.Name = "B_Single_Dismiss";
            this.B_Single_Dismiss.Size = new System.Drawing.Size(247, 24);
            this.B_Single_Dismiss.Text = "برکـــنــاری امـــوال";
            //
            //B_Total_Dismiss
            //
            this.B_Total_Dismiss.Image = (System.Drawing.Image)resources.GetObject("B_Total_Dismiss.Image");
            this.B_Total_Dismiss.Name = "B_Total_Dismiss";
            this.B_Total_Dismiss.Size = new System.Drawing.Size(247, 24);
            this.B_Total_Dismiss.Text = "برکناری اموال کلی";
            //
            //B_Increase
            //
            this.B_Increase.Image = (System.Drawing.Image)resources.GetObject("B_Increase.Image");
            this.B_Increase.Name = "B_Increase";
            this.B_Increase.Size = new System.Drawing.Size(247, 24);
            this.B_Increase.Text = "افزایــش در امـــوال";
            //
            //B_Decrease
            //
            this.B_Decrease.Image = (System.Drawing.Image)resources.GetObject("B_Decrease.Image");
            this.B_Decrease.Name = "B_Decrease";
            this.B_Decrease.Size = new System.Drawing.Size(247, 24);
            this.B_Decrease.Text = "کاهـــش در امــوال";
            //
            //B_Movement
            //
            this.B_Movement.Image = (System.Drawing.Image)resources.GetObject("B_Movement.Image");
            this.B_Movement.Name = "B_Movement";
            this.B_Movement.Size = new System.Drawing.Size(247, 24);
            this.B_Movement.Text = "جابــجــایی امـــوال";
            //
            //B_Movement_All
            //
            this.B_Movement_All.Image = (System.Drawing.Image)resources.GetObject("B_Movement_All.Image");
            this.B_Movement_All.Name = "B_Movement_All";
            this.B_Movement_All.Size = new System.Drawing.Size(247, 24);
            this.B_Movement_All.Text = "جابــجــایی امـــوال کلی";
            //
            //B_Period
            //
            this.B_Period.Image = (System.Drawing.Image)resources.GetObject("B_Period.Image");
            this.B_Period.Name = "B_Period";
            this.B_Period.Size = new System.Drawing.Size(247, 24);
            this.B_Period.Text = "ایجـاد دوره مالـــی";
            //
            //B_Depreciation
            //
            this.B_Depreciation.Image = (System.Drawing.Image)resources.GetObject("B_Depreciation.Image");
            this.B_Depreciation.Name = "B_Depreciation";
            this.B_Depreciation.Size = new System.Drawing.Size(247, 24);
            this.B_Depreciation.Text = "محاسبه استهلاک";
            //
            //B_New_Depreciation
            //
            this.B_New_Depreciation.Image = (System.Drawing.Image)resources.GetObject("B_New_Depreciation.Image");
            this.B_New_Depreciation.Name = "B_New_Depreciation";
            this.B_New_Depreciation.Size = new System.Drawing.Size(247, 24);
            this.B_New_Depreciation.Text = "حذف محاسبات استهلاک";
            //
            //B_Chek_Revaluation
            //
            this.B_Chek_Revaluation.Image = (System.Drawing.Image)resources.GetObject("B_Chek_Revaluation.Image");
            this.B_Chek_Revaluation.Name = "B_Chek_Revaluation";
            this.B_Chek_Revaluation.Size = new System.Drawing.Size(247, 24);
            this.B_Chek_Revaluation.Text = "کنترل تجدید ارزیابی";
            //
            //New_B
            //
            this.New_B.Image = (System.Drawing.Image)resources.GetObject("New_B.Image");
            this.New_B.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.New_B.Name = "New_B";
            this.New_B.Size = new System.Drawing.Size(62, 23);
            this.New_B.Text = "جدید";
            this.New_B.Visible = false;
            //
            //Edit_B
            //
            this.Edit_B.Image = (System.Drawing.Image)resources.GetObject("Edit_B.Image");
            this.Edit_B.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Edit_B.Name = "Edit_B";
            this.Edit_B.Size = new System.Drawing.Size(76, 23);
            this.Edit_B.Text = "ویرایش";
            this.Edit_B.Visible = false;
            //
            //Save_B
            //
            this.Save_B.Enabled = false;
            this.Save_B.Image = (System.Drawing.Image)resources.GetObject("Save_B.Image");
            this.Save_B.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Save_B.Name = "Save_B";
            this.Save_B.Size = new System.Drawing.Size(68, 23);
            this.Save_B.Text = "ذخیره";
            this.Save_B.Visible = false;
            //
            //Delet_B
            //
            this.Delet_B.Image = (System.Drawing.Image)resources.GetObject("Delet_B.Image");
            this.Delet_B.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Delet_B.Name = "Delet_B";
            this.Delet_B.Size = new System.Drawing.Size(63, 23);
            this.Delet_B.Text = "حذف";
            this.Delet_B.ToolTipText = "حذف";
            this.Delet_B.Visible = false;
            //
            //N_Search
            //
            this.N_Search.Name = "N_Search";
            this.N_Search.Size = new System.Drawing.Size(180, 26);
            //
            //Search_B
            //
            this.Search_B.Image = (System.Drawing.Image)resources.GetObject("Search_B.Image");
            this.Search_B.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Search_B.Name = "Search_B";
            this.Search_B.Size = new System.Drawing.Size(81, 23);
            this.Search_B.Text = "جستجو";
            //
            //Chap_B
            //
            this.Chap_B.Image = (System.Drawing.Image)resources.GetObject("Chap_B.Image");
            this.Chap_B.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Chap_B.Name = "Chap_B";
            this.Chap_B.Size = new System.Drawing.Size(58, 23);
            this.Chap_B.Text = "چاپ";
            //
            //Picture_B
            //
            this.Picture_B.Image = (System.Drawing.Image)resources.GetObject("Picture_B.Image");
            this.Picture_B.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Picture_B.Name = "Picture_B";
            this.Picture_B.Size = new System.Drawing.Size(63, 23);
            this.Picture_B.Text = "تصویر";
            //
            //Excel_B
            //
            this.Excel_B.Image = (System.Drawing.Image)resources.GetObject("Excel_B.Image");
            this.Excel_B.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Excel_B.Name = "Excel_B";
            this.Excel_B.Size = new System.Drawing.Size(70, 23);
            this.Excel_B.Text = "اکسل";
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
            //Abort_B
            //
            this.Abort_B.Image = (System.Drawing.Image)resources.GetObject("Abort_B.Image");
            this.Abort_B.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Abort_B.Name = "Abort_B";
            this.Abort_B.Size = new System.Drawing.Size(74, 23);
            this.Abort_B.Text = "انصراف";
            //
            //Estate_Control
            //
            this.Estate_Control.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Estate_Control.Enabled = false;
            this.Estate_Control.Items.AddRange(new object[] { "امــــــوال جــدید", "افــزایــش جــدید", "امـــــــوال قـدیـم", "افــزایـــش قـدیـم", "امــــوال عمرانی", "اموال تجدید شده", "تـجـدیـد ارزیابی", "امــــوال مصرفی", "دارائی نـامشهود", "کــاهـــــش اموال", "بــرکناری اموال" });
            this.Estate_Control.Name = "Estate_Control";
            this.Estate_Control.Size = new System.Drawing.Size(180, 26);
            //
            //Label18
            //
            this.Label18.AutoSize = true;
            this.Label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label18.Location = new System.Drawing.Point(318, 264);
            this.Label18.Name = "Label18";
            this.Label18.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label18.Size = new System.Drawing.Size(152, 25);
            this.Label18.TabIndex = 340;
            this.Label18.Text = "اموال مستهلک شده :";
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
            this.DV.Size = new System.Drawing.Size(1228, 232);
            this.DV.TabIndex = 2;
            //
            //Estate_Add
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7.0F, 16.0F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1228, 534);
            this.Controls.Add(this.SplitContainer1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Estate_Add";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ch_Add";
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
        internal System.Windows.Forms.ComboBox Estate_Cost_Code;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.ComboBox Estate_Sub_Code;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.ComboBox Estate_Original_Code;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ComboBox Estate_City;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.ComboBox Estate_Plaque;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox Estate_Name;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.TextBox Estate_No_Document;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Price_Label;
        internal System.Windows.Forms.TextBox Estate_Price;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.TextBox Estate_No_Remittance;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.TextBox Estate_Description;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.TextBox Estate_Depreciation;
        internal System.Windows.Forms.Label Estehlak_Label;
        internal Rtl_Date Estate_Date_Remittance;
        internal Rtl_Date Estate_Date_Document;
        internal Rtl_Date Estate_Date_Price;
        internal System.Windows.Forms.DataGridView DV;
        internal System.Windows.Forms.Button B_Personal_Chek;
        internal System.Windows.Forms.TextBox Estate_No_Personnel;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.CheckBox Check_Date;
        internal Ansaripour.Rtl_Date Estate_Date_Until;
        internal Ansaripour.Rtl_Date Estate_Date_From;
        internal System.Windows.Forms.Label Label29;
        internal System.Windows.Forms.Label Label24;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.CheckBox Check_B_Date;
        internal System.Windows.Forms.ProgressBar Progress;
        internal System.Windows.Forms.Label Label23;
        internal System.Windows.Forms.Label Day;
        internal System.Windows.Forms.ToolStrip ToolStrip;
        internal System.Windows.Forms.ToolStripDropDownButton B_Product;
        internal System.Windows.Forms.ToolStripMenuItem B_Single_Dismiss;
        internal System.Windows.Forms.ToolStripMenuItem B_Total_Dismiss;
        internal System.Windows.Forms.ToolStripMenuItem B_Increase;
        internal System.Windows.Forms.ToolStripMenuItem B_Decrease;
        internal System.Windows.Forms.ToolStripMenuItem B_Movement;
        internal System.Windows.Forms.ToolStripButton New_B;
        internal System.Windows.Forms.ToolStripButton Edit_B;
        internal System.Windows.Forms.ToolStripButton Delet_B;
        internal System.Windows.Forms.ToolStripButton Save_B;
        internal System.Windows.Forms.ToolStripButton Search_B;
        internal System.Windows.Forms.ToolStripComboBox N_Search;
        internal System.Windows.Forms.ToolStripButton Excel_B;
        internal System.Windows.Forms.ToolStripButton Picture_B;
        internal System.Windows.Forms.ToolStripButton Chap_B;
        internal System.Windows.Forms.ToolStripButton Abort_B;
        internal System.Windows.Forms.ToolStripComboBox Estate_Control;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.TextBox Estate_Project;
        internal System.Windows.Forms.Label Label17;
        internal System.Windows.Forms.Button B_Plan;
        internal System.Windows.Forms.TextBox Estate_Plan;
        internal System.Windows.Forms.Button B_Project;
        internal System.Windows.Forms.ToolStripMenuItem B_Period;
        internal System.Windows.Forms.ToolStripMenuItem B_Depreciation;
        internal System.Windows.Forms.ToolStripMenuItem B_Chek_Revaluation;
        internal System.Windows.Forms.ToolStripMenuItem B_New_Depreciation;
        internal System.Windows.Forms.Label Label18;
        internal System.Windows.Forms.CheckBox Check_Depreciated;
        internal System.Windows.Forms.ToolStripButton Log_File;
        internal System.Windows.Forms.ToolStripMenuItem B_Movement_All;
    }
}
