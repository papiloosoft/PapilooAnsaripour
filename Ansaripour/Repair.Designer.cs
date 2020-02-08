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
    public partial class Repair : System.Windows.Forms.Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Repair));
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
            this.Repair_Seating = new System.Windows.Forms.TextBox();
            this.Label17 = new System.Windows.Forms.Label();
            this.Repair_Energy = new System.Windows.Forms.TextBox();
            this.B_Repair_Energy = new System.Windows.Forms.Button();
            this.Repair_Ability_Work = new System.Windows.Forms.TextBox();
            this.Label15 = new System.Windows.Forms.Label();
            this.Repair_Capacity = new System.Windows.Forms.TextBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.Repair_Production_Capacity = new System.Windows.Forms.TextBox();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.Repair_Weight_Device = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.Repair_Working_Dimensions = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.Repair_Dimensions_Device = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.Repair_Use_Date = new Ansaripour.Rtl_Date();
            this.Label8 = new System.Windows.Forms.Label();
            this.Repair_Production_Date = new Ansaripour.Rtl_Date();
            this.Label7 = new System.Windows.Forms.Label();
            this.Repair_Model_Making = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Repair_Manufacturer = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Repair_Manufacturing_Country = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.B_Repair_Seating = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.Repair_Serial = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Repair_Code = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Repair_Name = new System.Windows.Forms.TextBox();
            this.Label16 = new System.Windows.Forms.Label();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.Label34 = new System.Windows.Forms.Label();
            this.Repair_Description = new System.Windows.Forms.TextBox();
            this.Repair_Power_Factor = new System.Windows.Forms.TextBox();
            this.Label33 = new System.Windows.Forms.Label();
            this.Repair_Cable_Size = new System.Windows.Forms.TextBox();
            this.Label32 = new System.Windows.Forms.Label();
            this.Repair_Key_Issues = new System.Windows.Forms.TextBox();
            this.Label31 = new System.Windows.Forms.Label();
            this.Repair_Flow_Rate = new System.Windows.Forms.TextBox();
            this.Label30 = new System.Windows.Forms.Label();
            this.Label29 = new System.Windows.Forms.Label();
            this.Repair_Connector_Type = new System.Windows.Forms.TextBox();
            this.B_Repair_Connector_Type = new System.Windows.Forms.Button();
            this.Label28 = new System.Windows.Forms.Label();
            this.Repair_Kind_Fuse = new System.Windows.Forms.TextBox();
            this.B_Repair_Kind_Fuse = new System.Windows.Forms.Button();
            this.Label27 = new System.Windows.Forms.Label();
            this.Repair_Kind_Stream = new System.Windows.Forms.TextBox();
            this.B_Repair_Kind_Stream = new System.Windows.Forms.Button();
            this.Label26 = new System.Windows.Forms.Label();
            this.Repair_Phase = new System.Windows.Forms.TextBox();
            this.B_Repair_Phase = new System.Windows.Forms.Button();
            this.Label25 = new System.Windows.Forms.Label();
            this.Repair_RPM = new System.Windows.Forms.TextBox();
            this.Label24 = new System.Windows.Forms.Label();
            this.Repair_Frequency = new System.Windows.Forms.TextBox();
            this.Label23 = new System.Windows.Forms.Label();
            this.Repair_Stream = new System.Windows.Forms.TextBox();
            this.Label22 = new System.Windows.Forms.Label();
            this.Repair_Power = new System.Windows.Forms.TextBox();
            this.Label21 = new System.Windows.Forms.Label();
            this.Repair_Voltage = new System.Windows.Forms.TextBox();
            this.Repair_Power_Cable = new System.Windows.Forms.ComboBox();
            this.Label20 = new System.Windows.Forms.Label();
            this.Repair_Engine_Manufacturer = new System.Windows.Forms.TextBox();
            this.Label18 = new System.Windows.Forms.Label();
            this.Repair_Name_Engine = new System.Windows.Forms.TextBox();
            this.Label19 = new System.Windows.Forms.Label();
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
            this.TabPage2.SuspendLayout();
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
            this.ToolStrip.Size = new System.Drawing.Size(1011, 26);
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
            this.SplitContainer1.Size = new System.Drawing.Size(1011, 430);
            this.SplitContainer1.SplitterDistance = 213;
            this.SplitContainer1.TabIndex = 2;
            //
            //TabControl1
            //
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Controls.Add(this.TabPage3);
            this.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl1.Location = new System.Drawing.Point(0, 0);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.RightToLeftLayout = true;
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(1011, 213);
            this.TabControl1.TabIndex = 0;
            //
            //TabPage1
            //
            this.TabPage1.Controls.Add(this.Repair_Seating);
            this.TabPage1.Controls.Add(this.Label17);
            this.TabPage1.Controls.Add(this.Repair_Energy);
            this.TabPage1.Controls.Add(this.B_Repair_Energy);
            this.TabPage1.Controls.Add(this.Repair_Ability_Work);
            this.TabPage1.Controls.Add(this.Label15);
            this.TabPage1.Controls.Add(this.Repair_Capacity);
            this.TabPage1.Controls.Add(this.Label14);
            this.TabPage1.Controls.Add(this.Repair_Production_Capacity);
            this.TabPage1.Controls.Add(this.Label13);
            this.TabPage1.Controls.Add(this.Label12);
            this.TabPage1.Controls.Add(this.Repair_Weight_Device);
            this.TabPage1.Controls.Add(this.Label11);
            this.TabPage1.Controls.Add(this.Repair_Working_Dimensions);
            this.TabPage1.Controls.Add(this.Label10);
            this.TabPage1.Controls.Add(this.Repair_Dimensions_Device);
            this.TabPage1.Controls.Add(this.Label9);
            this.TabPage1.Controls.Add(this.Repair_Use_Date);
            this.TabPage1.Controls.Add(this.Label8);
            this.TabPage1.Controls.Add(this.Repair_Production_Date);
            this.TabPage1.Controls.Add(this.Label7);
            this.TabPage1.Controls.Add(this.Repair_Model_Making);
            this.TabPage1.Controls.Add(this.Label6);
            this.TabPage1.Controls.Add(this.Repair_Manufacturer);
            this.TabPage1.Controls.Add(this.Label4);
            this.TabPage1.Controls.Add(this.Repair_Manufacturing_Country);
            this.TabPage1.Controls.Add(this.Label3);
            this.TabPage1.Controls.Add(this.B_Repair_Seating);
            this.TabPage1.Controls.Add(this.Label2);
            this.TabPage1.Controls.Add(this.Repair_Serial);
            this.TabPage1.Controls.Add(this.Label1);
            this.TabPage1.Controls.Add(this.Repair_Code);
            this.TabPage1.Controls.Add(this.Label5);
            this.TabPage1.Controls.Add(this.Repair_Name);
            this.TabPage1.Controls.Add(this.Label16);
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(1003, 187);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "مشخصات عمومی";
            this.TabPage1.UseVisualStyleBackColor = true;
            //
            //Repair_Seating
            //
            this.Repair_Seating.BackColor = System.Drawing.Color.White;
            this.Repair_Seating.Enabled = false;
            this.Repair_Seating.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Repair_Seating.Location = new System.Drawing.Point(687, 45);
            this.Repair_Seating.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Repair_Seating.Name = "Repair_Seating";
            this.Repair_Seating.Size = new System.Drawing.Size(208, 30);
            this.Repair_Seating.TabIndex = 3;
            //
            //Label17
            //
            this.Label17.AutoSize = true;
            this.Label17.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label17.Location = new System.Drawing.Point(217, 158);
            this.Label17.Name = "Label17";
            this.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label17.Size = new System.Drawing.Size(114, 19);
            this.Label17.TabIndex = 222;
            this.Label17.Text = ": انرژی مورد نیاز";
            //
            //Repair_Energy
            //
            this.Repair_Energy.BackColor = System.Drawing.Color.White;
            this.Repair_Energy.Enabled = false;
            this.Repair_Energy.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Repair_Energy.Location = new System.Drawing.Point(36, 152);
            this.Repair_Energy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Repair_Energy.Name = "Repair_Energy";
            this.Repair_Energy.Size = new System.Drawing.Size(177, 30);
            this.Repair_Energy.TabIndex = 15;
            //
            //B_Repair_Energy
            //
            this.B_Repair_Energy.Image = (System.Drawing.Image)resources.GetObject("B_Repair_Energy.Image");
            this.B_Repair_Energy.Location = new System.Drawing.Point(5, 153);
            this.B_Repair_Energy.Name = "B_Repair_Energy";
            this.B_Repair_Energy.Size = new System.Drawing.Size(29, 27);
            this.B_Repair_Energy.TabIndex = 220;
            this.B_Repair_Energy.UseVisualStyleBackColor = true;
            //
            //Repair_Ability_Work
            //
            this.Repair_Ability_Work.BackColor = System.Drawing.Color.White;
            this.Repair_Ability_Work.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Repair_Ability_Work.Location = new System.Drawing.Point(547, 152);
            this.Repair_Ability_Work.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Repair_Ability_Work.Name = "Repair_Ability_Work";
            this.Repair_Ability_Work.Size = new System.Drawing.Size(121, 30);
            this.Repair_Ability_Work.TabIndex = 13;
            //
            //Label15
            //
            this.Label15.AutoSize = true;
            this.Label15.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label15.Location = new System.Drawing.Point(450, 158);
            this.Label15.Name = "Label15";
            this.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label15.Size = new System.Drawing.Size(95, 19);
            this.Label15.TabIndex = 217;
            this.Label15.Text = ": حجم مخزن";
            //
            //Repair_Capacity
            //
            this.Repair_Capacity.BackColor = System.Drawing.Color.White;
            this.Repair_Capacity.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Repair_Capacity.Location = new System.Drawing.Point(340, 152);
            this.Repair_Capacity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Repair_Capacity.Name = "Repair_Capacity";
            this.Repair_Capacity.Size = new System.Drawing.Size(107, 30);
            this.Repair_Capacity.TabIndex = 14;
            //
            //Label14
            //
            this.Label14.AutoSize = true;
            this.Label14.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label14.Location = new System.Drawing.Point(897, 158);
            this.Label14.Name = "Label14";
            this.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label14.Size = new System.Drawing.Size(107, 19);
            this.Label14.TabIndex = 215;
            this.Label14.Text = ": ظرفیت تولید ";
            //
            //Repair_Production_Capacity
            //
            this.Repair_Production_Capacity.BackColor = System.Drawing.Color.White;
            this.Repair_Production_Capacity.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Repair_Production_Capacity.Location = new System.Drawing.Point(778, 152);
            this.Repair_Production_Capacity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Repair_Production_Capacity.Name = "Repair_Production_Capacity";
            this.Repair_Production_Capacity.Size = new System.Drawing.Size(117, 30);
            this.Repair_Production_Capacity.TabIndex = 12;
            //
            //Label13
            //
            this.Label13.AutoSize = true;
            this.Label13.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label13.Location = new System.Drawing.Point(7, 117);
            this.Label13.Name = "Label13";
            this.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label13.Size = new System.Drawing.Size(65, 19);
            this.Label13.TabIndex = 213;
            this.Label13.Text = "کیلو گرم";
            //
            //Label12
            //
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label12.Location = new System.Drawing.Point(218, 117);
            this.Label12.Name = "Label12";
            this.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label12.Size = new System.Drawing.Size(95, 19);
            this.Label12.TabIndex = 212;
            this.Label12.Text = ":وزن دستگاه";
            //
            //Repair_Weight_Device
            //
            this.Repair_Weight_Device.BackColor = System.Drawing.Color.White;
            this.Repair_Weight_Device.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Repair_Weight_Device.Location = new System.Drawing.Point(78, 111);
            this.Repair_Weight_Device.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Repair_Weight_Device.Name = "Repair_Weight_Device";
            this.Repair_Weight_Device.Size = new System.Drawing.Size(137, 30);
            this.Repair_Weight_Device.TabIndex = 11;
            //
            //Label11
            //
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label11.Location = new System.Drawing.Point(539, 121);
            this.Label11.Name = "Label11";
            this.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label11.Size = new System.Drawing.Size(86, 19);
            this.Label11.TabIndex = 210;
            this.Label11.Text = ": ابعاد کاری";
            //
            //Repair_Working_Dimensions
            //
            this.Repair_Working_Dimensions.BackColor = System.Drawing.Color.White;
            this.Repair_Working_Dimensions.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Repair_Working_Dimensions.Location = new System.Drawing.Point(335, 115);
            this.Repair_Working_Dimensions.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Repair_Working_Dimensions.Name = "Repair_Working_Dimensions";
            this.Repair_Working_Dimensions.Size = new System.Drawing.Size(203, 30);
            this.Repair_Working_Dimensions.TabIndex = 10;
            //
            //Label10
            //
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label10.Location = new System.Drawing.Point(898, 122);
            this.Label10.Name = "Label10";
            this.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label10.Size = new System.Drawing.Size(104, 19);
            this.Label10.TabIndex = 208;
            this.Label10.Text = ": ابعاد دستگاه";
            //
            //Repair_Dimensions_Device
            //
            this.Repair_Dimensions_Device.BackColor = System.Drawing.Color.White;
            this.Repair_Dimensions_Device.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Repair_Dimensions_Device.Location = new System.Drawing.Point(655, 116);
            this.Repair_Dimensions_Device.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Repair_Dimensions_Device.Name = "Repair_Dimensions_Device";
            this.Repair_Dimensions_Device.Size = new System.Drawing.Size(240, 30);
            this.Repair_Dimensions_Device.TabIndex = 9;
            //
            //Label9
            //
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label9.Location = new System.Drawing.Point(216, 82);
            this.Label9.Name = "Label9";
            this.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label9.Size = new System.Drawing.Size(135, 19);
            this.Label9.TabIndex = 205;
            this.Label9.Text = ": تاریخ بهره برداری ";
            //
            //Repair_Use_Date
            //
            this.Repair_Use_Date.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Repair_Use_Date.AutoSize = true;
            this.Repair_Use_Date.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Repair_Use_Date.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Repair_Use_Date.Location = new System.Drawing.Point(98, 76);
            this.Repair_Use_Date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Repair_Use_Date.Name = "Repair_Use_Date";
            this.Repair_Use_Date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Repair_Use_Date.Size = new System.Drawing.Size(136, 32);
            this.Repair_Use_Date.T_D = "";
            this.Repair_Use_Date.TabIndex = 8;
            //
            //Label8
            //
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label8.Location = new System.Drawing.Point(539, 86);
            this.Label8.Name = "Label8";
            this.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label8.Size = new System.Drawing.Size(102, 19);
            this.Label8.TabIndex = 203;
            this.Label8.Text = ": تاریخ ساخت";
            //
            //Repair_Production_Date
            //
            this.Repair_Production_Date.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Repair_Production_Date.AutoSize = true;
            this.Repair_Production_Date.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Repair_Production_Date.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Repair_Production_Date.Location = new System.Drawing.Point(421, 80);
            this.Repair_Production_Date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Repair_Production_Date.Name = "Repair_Production_Date";
            this.Repair_Production_Date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Repair_Production_Date.Size = new System.Drawing.Size(136, 32);
            this.Repair_Production_Date.T_D = "";
            this.Repair_Production_Date.TabIndex = 7;
            //
            //Label7
            //
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label7.Location = new System.Drawing.Point(901, 86);
            this.Label7.Name = "Label7";
            this.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label7.Size = new System.Drawing.Size(99, 19);
            this.Label7.TabIndex = 202;
            this.Label7.Text = ": مدل ساخت";
            //
            //Repair_Model_Making
            //
            this.Repair_Model_Making.BackColor = System.Drawing.Color.White;
            this.Repair_Model_Making.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Repair_Model_Making.Location = new System.Drawing.Point(655, 80);
            this.Repair_Model_Making.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Repair_Model_Making.Name = "Repair_Model_Making";
            this.Repair_Model_Making.Size = new System.Drawing.Size(240, 30);
            this.Repair_Model_Making.TabIndex = 6;
            //
            //Label6
            //
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label6.Location = new System.Drawing.Point(215, 48);
            this.Label6.Name = "Label6";
            this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label6.Size = new System.Drawing.Size(119, 19);
            this.Label6.TabIndex = 200;
            this.Label6.Text = ": شرکت سازنده";
            //
            //Repair_Manufacturer
            //
            this.Repair_Manufacturer.BackColor = System.Drawing.Color.White;
            this.Repair_Manufacturer.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Repair_Manufacturer.Location = new System.Drawing.Point(3, 42);
            this.Repair_Manufacturer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Repair_Manufacturer.Name = "Repair_Manufacturer";
            this.Repair_Manufacturer.Size = new System.Drawing.Size(211, 30);
            this.Repair_Manufacturer.TabIndex = 5;
            //
            //Label4
            //
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label4.Location = new System.Drawing.Point(538, 50);
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label4.Size = new System.Drawing.Size(111, 19);
            this.Label4.TabIndex = 198;
            this.Label4.Text = ": کشور سازنده";
            //
            //Repair_Manufacturing_Country
            //
            this.Repair_Manufacturing_Country.BackColor = System.Drawing.Color.White;
            this.Repair_Manufacturing_Country.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Repair_Manufacturing_Country.Location = new System.Drawing.Point(335, 44);
            this.Repair_Manufacturing_Country.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Repair_Manufacturing_Country.Name = "Repair_Manufacturing_Country";
            this.Repair_Manufacturing_Country.Size = new System.Drawing.Size(202, 30);
            this.Repair_Manufacturing_Country.TabIndex = 4;
            //
            //Label3
            //
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label3.Location = new System.Drawing.Point(896, 51);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label3.Size = new System.Drawing.Size(107, 19);
            this.Label3.TabIndex = 196;
            this.Label3.Text = ": محل استقرار";
            //
            //B_Repair_Seating
            //
            this.B_Repair_Seating.Image = (System.Drawing.Image)resources.GetObject("B_Repair_Seating.Image");
            this.B_Repair_Seating.Location = new System.Drawing.Point(654, 47);
            this.B_Repair_Seating.Name = "B_Repair_Seating";
            this.B_Repair_Seating.Size = new System.Drawing.Size(29, 27);
            this.B_Repair_Seating.TabIndex = 195;
            this.B_Repair_Seating.UseVisualStyleBackColor = true;
            //
            //Label2
            //
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label2.Location = new System.Drawing.Point(218, 13);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(107, 19);
            this.Label2.TabIndex = 193;
            this.Label2.Text = ":شماره سریال";
            //
            //Repair_Serial
            //
            this.Repair_Serial.BackColor = System.Drawing.Color.White;
            this.Repair_Serial.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Repair_Serial.Location = new System.Drawing.Point(4, 7);
            this.Repair_Serial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Repair_Serial.Name = "Repair_Serial";
            this.Repair_Serial.Size = new System.Drawing.Size(211, 30);
            this.Repair_Serial.TabIndex = 2;
            //
            //Label1
            //
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label1.Location = new System.Drawing.Point(543, 13);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(93, 19);
            this.Label1.TabIndex = 191;
            this.Label1.Text = ": کد دستگاه";
            //
            //Repair_Code
            //
            this.Repair_Code.BackColor = System.Drawing.Color.White;
            this.Repair_Code.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Repair_Code.Location = new System.Drawing.Point(335, 7);
            this.Repair_Code.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Repair_Code.Name = "Repair_Code";
            this.Repair_Code.Size = new System.Drawing.Size(202, 30);
            this.Repair_Code.TabIndex = 1;
            //
            //Label5
            //
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label5.Location = new System.Drawing.Point(901, 13);
            this.Label5.Name = "Label5";
            this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label5.Size = new System.Drawing.Size(89, 19);
            this.Label5.TabIndex = 189;
            this.Label5.Text = ":نام دستگاه";
            //
            //Repair_Name
            //
            this.Repair_Name.BackColor = System.Drawing.Color.White;
            this.Repair_Name.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Repair_Name.Location = new System.Drawing.Point(655, 7);
            this.Repair_Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Repair_Name.Name = "Repair_Name";
            this.Repair_Name.Size = new System.Drawing.Size(240, 30);
            this.Repair_Name.TabIndex = 0;
            //
            //Label16
            //
            this.Label16.AutoSize = true;
            this.Label16.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label16.Location = new System.Drawing.Point(676, 158);
            this.Label16.Name = "Label16";
            this.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label16.Size = new System.Drawing.Size(87, 19);
            this.Label16.TabIndex = 219;
            this.Label16.Text = ": قابلیت کار";
            //
            //TabPage2
            //
            this.TabPage2.Controls.Add(this.Label34);
            this.TabPage2.Controls.Add(this.Repair_Description);
            this.TabPage2.Controls.Add(this.Repair_Power_Factor);
            this.TabPage2.Controls.Add(this.Label33);
            this.TabPage2.Controls.Add(this.Repair_Cable_Size);
            this.TabPage2.Controls.Add(this.Label32);
            this.TabPage2.Controls.Add(this.Repair_Key_Issues);
            this.TabPage2.Controls.Add(this.Label31);
            this.TabPage2.Controls.Add(this.Repair_Flow_Rate);
            this.TabPage2.Controls.Add(this.Label30);
            this.TabPage2.Controls.Add(this.Label29);
            this.TabPage2.Controls.Add(this.Repair_Connector_Type);
            this.TabPage2.Controls.Add(this.B_Repair_Connector_Type);
            this.TabPage2.Controls.Add(this.Label28);
            this.TabPage2.Controls.Add(this.Repair_Kind_Fuse);
            this.TabPage2.Controls.Add(this.B_Repair_Kind_Fuse);
            this.TabPage2.Controls.Add(this.Label27);
            this.TabPage2.Controls.Add(this.Repair_Kind_Stream);
            this.TabPage2.Controls.Add(this.B_Repair_Kind_Stream);
            this.TabPage2.Controls.Add(this.Label26);
            this.TabPage2.Controls.Add(this.Repair_Phase);
            this.TabPage2.Controls.Add(this.B_Repair_Phase);
            this.TabPage2.Controls.Add(this.Label25);
            this.TabPage2.Controls.Add(this.Repair_RPM);
            this.TabPage2.Controls.Add(this.Label24);
            this.TabPage2.Controls.Add(this.Repair_Frequency);
            this.TabPage2.Controls.Add(this.Label23);
            this.TabPage2.Controls.Add(this.Repair_Stream);
            this.TabPage2.Controls.Add(this.Label22);
            this.TabPage2.Controls.Add(this.Repair_Power);
            this.TabPage2.Controls.Add(this.Label21);
            this.TabPage2.Controls.Add(this.Repair_Voltage);
            this.TabPage2.Controls.Add(this.Repair_Power_Cable);
            this.TabPage2.Controls.Add(this.Label20);
            this.TabPage2.Controls.Add(this.Repair_Engine_Manufacturer);
            this.TabPage2.Controls.Add(this.Label18);
            this.TabPage2.Controls.Add(this.Repair_Name_Engine);
            this.TabPage2.Controls.Add(this.Label19);
            this.TabPage2.Location = new System.Drawing.Point(4, 22);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(1003, 187);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "مشخصات فنی";
            this.TabPage2.UseVisualStyleBackColor = true;
            //
            //Label34
            //
            this.Label34.AutoSize = true;
            this.Label34.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label34.Location = new System.Drawing.Point(898, 161);
            this.Label34.Name = "Label34";
            this.Label34.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label34.Size = new System.Drawing.Size(95, 19);
            this.Label34.TabIndex = 244;
            this.Label34.Text = ": مــلاحــظات";
            //
            //Repair_Description
            //
            this.Repair_Description.BackColor = System.Drawing.Color.White;
            this.Repair_Description.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Repair_Description.Location = new System.Drawing.Point(6, 155);
            this.Repair_Description.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Repair_Description.Name = "Repair_Description";
            this.Repair_Description.Size = new System.Drawing.Size(886, 30);
            this.Repair_Description.TabIndex = 16;
            //
            //Repair_Power_Factor
            //
            this.Repair_Power_Factor.BackColor = System.Drawing.Color.White;
            this.Repair_Power_Factor.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Repair_Power_Factor.Location = new System.Drawing.Point(515, 119);
            this.Repair_Power_Factor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Repair_Power_Factor.Name = "Repair_Power_Factor";
            this.Repair_Power_Factor.Size = new System.Drawing.Size(99, 30);
            this.Repair_Power_Factor.TabIndex = 12;
            //
            //Label33
            //
            this.Label33.AutoSize = true;
            this.Label33.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label33.Location = new System.Drawing.Point(84, 125);
            this.Label33.Name = "Label33";
            this.Label33.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label33.Size = new System.Drawing.Size(86, 19);
            this.Label33.TabIndex = 242;
            this.Label33.Text = ": سایز کابل";
            //
            //Repair_Cable_Size
            //
            this.Repair_Cable_Size.BackColor = System.Drawing.Color.White;
            this.Repair_Cable_Size.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Repair_Cable_Size.Location = new System.Drawing.Point(6, 119);
            this.Repair_Cable_Size.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Repair_Cable_Size.Name = "Repair_Cable_Size";
            this.Repair_Cable_Size.Size = new System.Drawing.Size(76, 30);
            this.Repair_Cable_Size.TabIndex = 15;
            //
            //Label32
            //
            this.Label32.AutoSize = true;
            this.Label32.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label32.Location = new System.Drawing.Point(253, 126);
            this.Label32.Name = "Label32";
            this.Label32.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label32.Size = new System.Drawing.Size(94, 19);
            this.Label32.TabIndex = 240;
            this.Label32.Text = ":شماره کلید";
            //
            //Repair_Key_Issues
            //
            this.Repair_Key_Issues.BackColor = System.Drawing.Color.White;
            this.Repair_Key_Issues.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Repair_Key_Issues.Location = new System.Drawing.Point(176, 120);
            this.Repair_Key_Issues.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Repair_Key_Issues.Name = "Repair_Key_Issues";
            this.Repair_Key_Issues.Size = new System.Drawing.Size(71, 30);
            this.Repair_Key_Issues.TabIndex = 14;
            //
            //Label31
            //
            this.Label31.AutoSize = true;
            this.Label31.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label31.Location = new System.Drawing.Point(420, 123);
            this.Label31.Name = "Label31";
            this.Label31.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label31.Size = new System.Drawing.Size(94, 19);
            this.Label31.TabIndex = 238;
            this.Label31.Text = ": جریان فیوز ";
            //
            //Repair_Flow_Rate
            //
            this.Repair_Flow_Rate.BackColor = System.Drawing.Color.White;
            this.Repair_Flow_Rate.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Repair_Flow_Rate.Location = new System.Drawing.Point(350, 117);
            this.Repair_Flow_Rate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Repair_Flow_Rate.Name = "Repair_Flow_Rate";
            this.Repair_Flow_Rate.Size = new System.Drawing.Size(66, 30);
            this.Repair_Flow_Rate.TabIndex = 13;
            //
            //Label30
            //
            this.Label30.AutoSize = true;
            this.Label30.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label30.Location = new System.Drawing.Point(617, 126);
            this.Label30.Name = "Label30";
            this.Label30.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label30.Size = new System.Drawing.Size(98, 19);
            this.Label30.TabIndex = 236;
            this.Label30.Text = ": ضریب قدرت";
            //
            //Label29
            //
            this.Label29.AutoSize = true;
            this.Label29.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label29.Location = new System.Drawing.Point(897, 126);
            this.Label29.Name = "Label29";
            this.Label29.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label29.Size = new System.Drawing.Size(101, 19);
            this.Label29.TabIndex = 234;
            this.Label29.Text = ": نــوع اتـصــال";
            //
            //Repair_Connector_Type
            //
            this.Repair_Connector_Type.BackColor = System.Drawing.Color.White;
            this.Repair_Connector_Type.Enabled = false;
            this.Repair_Connector_Type.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Repair_Connector_Type.Location = new System.Drawing.Point(748, 120);
            this.Repair_Connector_Type.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Repair_Connector_Type.Name = "Repair_Connector_Type";
            this.Repair_Connector_Type.Size = new System.Drawing.Size(143, 30);
            this.Repair_Connector_Type.TabIndex = 11;
            //
            //B_Repair_Connector_Type
            //
            this.B_Repair_Connector_Type.Image = (System.Drawing.Image)resources.GetObject("B_Repair_Connector_Type.Image");
            this.B_Repair_Connector_Type.Location = new System.Drawing.Point(717, 122);
            this.B_Repair_Connector_Type.Name = "B_Repair_Connector_Type";
            this.B_Repair_Connector_Type.Size = new System.Drawing.Size(29, 27);
            this.B_Repair_Connector_Type.TabIndex = 232;
            this.B_Repair_Connector_Type.UseVisualStyleBackColor = true;
            //
            //Label28
            //
            this.Label28.AutoSize = true;
            this.Label28.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label28.Location = new System.Drawing.Point(175, 87);
            this.Label28.Name = "Label28";
            this.Label28.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label28.Size = new System.Drawing.Size(72, 19);
            this.Label28.TabIndex = 231;
            this.Label28.Text = ": نوع فیوز";
            //
            //Repair_Kind_Fuse
            //
            this.Repair_Kind_Fuse.BackColor = System.Drawing.Color.White;
            this.Repair_Kind_Fuse.Enabled = false;
            this.Repair_Kind_Fuse.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Repair_Kind_Fuse.Location = new System.Drawing.Point(39, 83);
            this.Repair_Kind_Fuse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Repair_Kind_Fuse.Name = "Repair_Kind_Fuse";
            this.Repair_Kind_Fuse.Size = new System.Drawing.Size(131, 30);
            this.Repair_Kind_Fuse.TabIndex = 10;
            //
            //B_Repair_Kind_Fuse
            //
            this.B_Repair_Kind_Fuse.Image = (System.Drawing.Image)resources.GetObject("B_Repair_Kind_Fuse.Image");
            this.B_Repair_Kind_Fuse.Location = new System.Drawing.Point(8, 83);
            this.B_Repair_Kind_Fuse.Name = "B_Repair_Kind_Fuse";
            this.B_Repair_Kind_Fuse.Size = new System.Drawing.Size(29, 27);
            this.B_Repair_Kind_Fuse.TabIndex = 229;
            this.B_Repair_Kind_Fuse.UseVisualStyleBackColor = true;
            //
            //Label27
            //
            this.Label27.AutoSize = true;
            this.Label27.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label27.Location = new System.Drawing.Point(418, 85);
            this.Label27.Name = "Label27";
            this.Label27.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label27.Size = new System.Drawing.Size(84, 19);
            this.Label27.TabIndex = 228;
            this.Label27.Text = ": نوع جریان";
            //
            //Repair_Kind_Stream
            //
            this.Repair_Kind_Stream.BackColor = System.Drawing.Color.White;
            this.Repair_Kind_Stream.Enabled = false;
            this.Repair_Kind_Stream.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Repair_Kind_Stream.Location = new System.Drawing.Point(292, 79);
            this.Repair_Kind_Stream.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Repair_Kind_Stream.Name = "Repair_Kind_Stream";
            this.Repair_Kind_Stream.Size = new System.Drawing.Size(120, 30);
            this.Repair_Kind_Stream.TabIndex = 9;
            //
            //B_Repair_Kind_Stream
            //
            this.B_Repair_Kind_Stream.Image = (System.Drawing.Image)resources.GetObject("B_Repair_Kind_Stream.Image");
            this.B_Repair_Kind_Stream.Location = new System.Drawing.Point(261, 79);
            this.B_Repair_Kind_Stream.Name = "B_Repair_Kind_Stream";
            this.B_Repair_Kind_Stream.Size = new System.Drawing.Size(29, 27);
            this.B_Repair_Kind_Stream.TabIndex = 226;
            this.B_Repair_Kind_Stream.UseVisualStyleBackColor = true;
            //
            //Label26
            //
            this.Label26.AutoSize = true;
            this.Label26.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label26.Location = new System.Drawing.Point(672, 85);
            this.Label26.Name = "Label26";
            this.Label26.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label26.Size = new System.Drawing.Size(70, 19);
            this.Label26.TabIndex = 225;
            this.Label26.Text = ":تعداد فاز";
            //
            //Repair_Phase
            //
            this.Repair_Phase.BackColor = System.Drawing.Color.White;
            this.Repair_Phase.Enabled = false;
            this.Repair_Phase.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Repair_Phase.Location = new System.Drawing.Point(547, 80);
            this.Repair_Phase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Repair_Phase.Name = "Repair_Phase";
            this.Repair_Phase.Size = new System.Drawing.Size(123, 30);
            this.Repair_Phase.TabIndex = 8;
            //
            //B_Repair_Phase
            //
            this.B_Repair_Phase.Image = (System.Drawing.Image)resources.GetObject("B_Repair_Phase.Image");
            this.B_Repair_Phase.Location = new System.Drawing.Point(515, 81);
            this.B_Repair_Phase.Name = "B_Repair_Phase";
            this.B_Repair_Phase.Size = new System.Drawing.Size(29, 27);
            this.B_Repair_Phase.TabIndex = 223;
            this.B_Repair_Phase.UseVisualStyleBackColor = true;
            //
            //Label25
            //
            this.Label25.AutoSize = true;
            this.Label25.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label25.Location = new System.Drawing.Point(848, 85);
            this.Label25.Name = "Label25";
            this.Label25.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label25.Size = new System.Drawing.Size(143, 19);
            this.Label25.TabIndex = 205;
            this.Label25.Text = ": دور در دقیقه(RPM)";
            //
            //Repair_RPM
            //
            this.Repair_RPM.BackColor = System.Drawing.Color.White;
            this.Repair_RPM.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Repair_RPM.Location = new System.Drawing.Point(748, 79);
            this.Repair_RPM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Repair_RPM.Name = "Repair_RPM";
            this.Repair_RPM.Size = new System.Drawing.Size(99, 30);
            this.Repair_RPM.TabIndex = 7;
            //
            //Label24
            //
            this.Label24.AutoSize = true;
            this.Label24.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label24.Location = new System.Drawing.Point(175, 49);
            this.Label24.Name = "Label24";
            this.Label24.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label24.Size = new System.Drawing.Size(72, 19);
            this.Label24.TabIndex = 203;
            this.Label24.Text = ": فرکانس";
            //
            //Repair_Frequency
            //
            this.Repair_Frequency.BackColor = System.Drawing.Color.White;
            this.Repair_Frequency.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Repair_Frequency.Location = new System.Drawing.Point(8, 43);
            this.Repair_Frequency.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Repair_Frequency.Name = "Repair_Frequency";
            this.Repair_Frequency.Size = new System.Drawing.Size(162, 30);
            this.Repair_Frequency.TabIndex = 6;
            //
            //Label23
            //
            this.Label23.AutoSize = true;
            this.Label23.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label23.Location = new System.Drawing.Point(507, 49);
            this.Label23.Name = "Label23";
            this.Label23.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label23.Size = new System.Drawing.Size(58, 19);
            this.Label23.TabIndex = 201;
            this.Label23.Text = ": جریان";
            //
            //Repair_Stream
            //
            this.Repair_Stream.BackColor = System.Drawing.Color.White;
            this.Repair_Stream.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Repair_Stream.Location = new System.Drawing.Point(265, 43);
            this.Repair_Stream.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Repair_Stream.Name = "Repair_Stream";
            this.Repair_Stream.Size = new System.Drawing.Size(236, 30);
            this.Repair_Stream.TabIndex = 5;
            //
            //Label22
            //
            this.Label22.AutoSize = true;
            this.Label22.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label22.Location = new System.Drawing.Point(672, 49);
            this.Label22.Name = "Label22";
            this.Label22.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label22.Size = new System.Drawing.Size(55, 19);
            this.Label22.TabIndex = 199;
            this.Label22.Text = ": قدرت";
            //
            //Repair_Power
            //
            this.Repair_Power.BackColor = System.Drawing.Color.White;
            this.Repair_Power.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Repair_Power.Location = new System.Drawing.Point(571, 45);
            this.Repair_Power.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Repair_Power.Name = "Repair_Power";
            this.Repair_Power.Size = new System.Drawing.Size(99, 30);
            this.Repair_Power.TabIndex = 4;
            //
            //Label21
            //
            this.Label21.AutoSize = true;
            this.Label21.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label21.Location = new System.Drawing.Point(926, 49);
            this.Label21.Name = "Label21";
            this.Label21.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label21.Size = new System.Drawing.Size(73, 19);
            this.Label21.TabIndex = 197;
            this.Label21.Text = ": ولـــتـــاژ";
            //
            //Repair_Voltage
            //
            this.Repair_Voltage.BackColor = System.Drawing.Color.White;
            this.Repair_Voltage.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Repair_Voltage.Location = new System.Drawing.Point(748, 43);
            this.Repair_Voltage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Repair_Voltage.Name = "Repair_Voltage";
            this.Repair_Voltage.Size = new System.Drawing.Size(175, 30);
            this.Repair_Voltage.TabIndex = 3;
            //
            //Repair_Power_Cable
            //
            this.Repair_Power_Cable.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Repair_Power_Cable.FormattingEnabled = true;
            this.Repair_Power_Cable.Items.AddRange(new object[] { "دارد", "ندارد" });
            this.Repair_Power_Cable.Location = new System.Drawing.Point(7, 11);
            this.Repair_Power_Cable.Name = "Repair_Power_Cable";
            this.Repair_Power_Cable.Size = new System.Drawing.Size(163, 24);
            this.Repair_Power_Cable.TabIndex = 2;
            //
            //Label20
            //
            this.Label20.AutoSize = true;
            this.Label20.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label20.Location = new System.Drawing.Point(176, 13);
            this.Label20.Name = "Label20";
            this.Label20.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label20.Size = new System.Drawing.Size(88, 19);
            this.Label20.TabIndex = 194;
            this.Label20.Text = ": کابل تغذیه";
            //
            //Repair_Engine_Manufacturer
            //
            this.Repair_Engine_Manufacturer.BackColor = System.Drawing.Color.White;
            this.Repair_Engine_Manufacturer.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Repair_Engine_Manufacturer.Location = new System.Drawing.Point(265, 7);
            this.Repair_Engine_Manufacturer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Repair_Engine_Manufacturer.Name = "Repair_Engine_Manufacturer";
            this.Repair_Engine_Manufacturer.Size = new System.Drawing.Size(303, 30);
            this.Repair_Engine_Manufacturer.TabIndex = 1;
            //
            //Label18
            //
            this.Label18.AutoSize = true;
            this.Label18.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label18.Location = new System.Drawing.Point(924, 13);
            this.Label18.Name = "Label18";
            this.Label18.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label18.Size = new System.Drawing.Size(70, 19);
            this.Label18.TabIndex = 191;
            this.Label18.Text = ":نام موتور";
            //
            //Repair_Name_Engine
            //
            this.Repair_Name_Engine.BackColor = System.Drawing.Color.White;
            this.Repair_Name_Engine.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Repair_Name_Engine.Location = new System.Drawing.Point(704, 7);
            this.Repair_Name_Engine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Repair_Name_Engine.Name = "Repair_Name_Engine";
            this.Repair_Name_Engine.Size = new System.Drawing.Size(218, 30);
            this.Repair_Name_Engine.TabIndex = 0;
            //
            //Label19
            //
            this.Label19.AutoSize = true;
            this.Label19.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label19.Location = new System.Drawing.Point(574, 11);
            this.Label19.Name = "Label19";
            this.Label19.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label19.Size = new System.Drawing.Size(100, 19);
            this.Label19.TabIndex = 193;
            this.Label19.Text = ":سازنده موتور";
            //
            //TabPage3
            //
            this.TabPage3.Controls.Add(this.Dv_Stock);
            this.TabPage3.Location = new System.Drawing.Point(4, 22);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage3.Size = new System.Drawing.Size(1003, 187);
            this.TabPage3.TabIndex = 2;
            this.TabPage3.Text = "مشخصات کلیدی";
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
            this.Dv_Stock.Size = new System.Drawing.Size(997, 181);
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
            this.DV.Size = new System.Drawing.Size(1011, 213);
            this.DV.TabIndex = 0;
            //
            //Repair
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6.0F, 13.0F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1011, 456);
            this.Controls.Add(this.SplitContainer1);
            this.Controls.Add(this.ToolStrip);
            this.Name = "Repair";
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
            this.TabPage2.ResumeLayout(false);
            this.TabPage2.PerformLayout();
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
        internal System.Windows.Forms.TextBox Repair_Serial;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox Repair_Code;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox Repair_Name;
        internal System.Windows.Forms.TabPage TabPage2;
        internal System.Windows.Forms.TabPage TabPage3;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox Repair_Model_Making;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox Repair_Manufacturer;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox Repair_Manufacturing_Country;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Button B_Repair_Seating;
        internal System.Windows.Forms.Label Label17;
        internal System.Windows.Forms.TextBox Repair_Energy;
        internal System.Windows.Forms.Button B_Repair_Energy;
        internal System.Windows.Forms.TextBox Repair_Ability_Work;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.TextBox Repair_Capacity;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.TextBox Repair_Production_Capacity;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.TextBox Repair_Weight_Device;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.TextBox Repair_Working_Dimensions;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.TextBox Repair_Dimensions_Device;
        internal System.Windows.Forms.Label Label9;
        internal Ansaripour.Rtl_Date Repair_Use_Date;
        internal Ansaripour.Rtl_Date Repair_Production_Date;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.Label Label20;
        internal System.Windows.Forms.TextBox Repair_Engine_Manufacturer;
        internal System.Windows.Forms.Label Label18;
        internal System.Windows.Forms.TextBox Repair_Name_Engine;
        internal System.Windows.Forms.Label Label19;
        internal System.Windows.Forms.Label Label34;
        internal System.Windows.Forms.TextBox Repair_Description;
        internal System.Windows.Forms.TextBox Repair_Power_Factor;
        internal System.Windows.Forms.Label Label33;
        internal System.Windows.Forms.TextBox Repair_Cable_Size;
        internal System.Windows.Forms.Label Label32;
        internal System.Windows.Forms.TextBox Repair_Key_Issues;
        internal System.Windows.Forms.Label Label31;
        internal System.Windows.Forms.TextBox Repair_Flow_Rate;
        internal System.Windows.Forms.Label Label30;
        internal System.Windows.Forms.Label Label29;
        internal System.Windows.Forms.TextBox Repair_Connector_Type;
        internal System.Windows.Forms.Button B_Repair_Connector_Type;
        internal System.Windows.Forms.Label Label28;
        internal System.Windows.Forms.TextBox Repair_Kind_Fuse;
        internal System.Windows.Forms.Button B_Repair_Kind_Fuse;
        internal System.Windows.Forms.Label Label27;
        internal System.Windows.Forms.TextBox Repair_Kind_Stream;
        internal System.Windows.Forms.Button B_Repair_Kind_Stream;
        internal System.Windows.Forms.Label Label26;
        internal System.Windows.Forms.TextBox Repair_Phase;
        internal System.Windows.Forms.Button B_Repair_Phase;
        internal System.Windows.Forms.Label Label25;
        internal System.Windows.Forms.TextBox Repair_RPM;
        internal System.Windows.Forms.Label Label24;
        internal System.Windows.Forms.TextBox Repair_Frequency;
        internal System.Windows.Forms.Label Label23;
        internal System.Windows.Forms.TextBox Repair_Stream;
        internal System.Windows.Forms.Label Label22;
        internal System.Windows.Forms.TextBox Repair_Power;
        internal System.Windows.Forms.Label Label21;
        internal System.Windows.Forms.TextBox Repair_Voltage;
        internal System.Windows.Forms.ComboBox Repair_Power_Cable;
        internal System.Windows.Forms.DataGridView Dv_Stock;
        internal System.Windows.Forms.TextBox Repair_Seating;
    }
}
