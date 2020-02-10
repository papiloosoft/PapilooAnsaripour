
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
    public partial class Seasonal_Sales : System.Windows.Forms.Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Seasonal_Sales));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Seasonal_Year = new System.Windows.Forms.MaskedTextBox();
            this.Label18 = new System.Windows.Forms.Label();
            this.Seasonal_Valu_Price_check = new System.Windows.Forms.CheckBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.Seasonal_Complications = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.Seasonal_Complications_Price = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Seasonal_Valu_Price = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Seasonal_Pure_Price = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Seasonal_Discount_Price = new System.Windows.Forms.TextBox();
            this.Seasonal_Documents_Number = new System.Windows.Forms.TextBox();
            this.Label15 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.B_Seasonal_Company = new System.Windows.Forms.Button();
            this.Seasonal_Operation = new System.Windows.Forms.ComboBox();
            this.Seasonal_Description = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.Seasonal_Product_Name = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.Seasonal_Gross_Price = new System.Windows.Forms.TextBox();
            this.Seasonal_Product_Type = new System.Windows.Forms.ComboBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Seasonal_Bill_Number = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Seasonal_Product_Id = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Seasonal_Subscription = new System.Windows.Forms.TextBox();
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.B_New = new System.Windows.Forms.ToolStripButton();
            this.B_Edit = new System.Windows.Forms.ToolStripButton();
            this.B_Delet = new System.Windows.Forms.ToolStripButton();
            this.B_Save = new System.Windows.Forms.ToolStripButton();
            this.B_Search = new System.Windows.Forms.ToolStripButton();
            this.B_Excel = new System.Windows.Forms.ToolStripButton();
            this.B_Print = new System.Windows.Forms.ToolStripButton();
            this.B_Log_File = new System.Windows.Forms.ToolStripButton();
            this.B_Picture = new System.Windows.Forms.ToolStripButton();
            this.B_Abort = new System.Windows.Forms.ToolStripButton();
            this.Estate_Control = new System.Windows.Forms.ToolStripComboBox();
            this.Label17 = new System.Windows.Forms.Label();
            this.Label16 = new System.Windows.Forms.Label();
            this.DV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).BeginInit();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            this.ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DV)).BeginInit();
            this.SuspendLayout();
            // 
            // SplitContainer1
            // 
            this.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.SplitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SplitContainer1.Name = "SplitContainer1";
            this.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SplitContainer1.Panel1
            // 
            this.SplitContainer1.Panel1.Controls.Add(this.Seasonal_Year);
            this.SplitContainer1.Panel1.Controls.Add(this.Label18);
            this.SplitContainer1.Panel1.Controls.Add(this.Seasonal_Valu_Price_check);
            this.SplitContainer1.Panel1.Controls.Add(this.Label12);
            this.SplitContainer1.Panel1.Controls.Add(this.Seasonal_Complications);
            this.SplitContainer1.Panel1.Controls.Add(this.Label11);
            this.SplitContainer1.Panel1.Controls.Add(this.Seasonal_Complications_Price);
            this.SplitContainer1.Panel1.Controls.Add(this.Label6);
            this.SplitContainer1.Panel1.Controls.Add(this.Seasonal_Valu_Price);
            this.SplitContainer1.Panel1.Controls.Add(this.Label3);
            this.SplitContainer1.Panel1.Controls.Add(this.Seasonal_Pure_Price);
            this.SplitContainer1.Panel1.Controls.Add(this.Label2);
            this.SplitContainer1.Panel1.Controls.Add(this.Seasonal_Discount_Price);
            this.SplitContainer1.Panel1.Controls.Add(this.Seasonal_Documents_Number);
            this.SplitContainer1.Panel1.Controls.Add(this.Label15);
            this.SplitContainer1.Panel1.Controls.Add(this.Label13);
            this.SplitContainer1.Panel1.Controls.Add(this.Label14);
            this.SplitContainer1.Panel1.Controls.Add(this.B_Seasonal_Company);
            this.SplitContainer1.Panel1.Controls.Add(this.Seasonal_Operation);
            this.SplitContainer1.Panel1.Controls.Add(this.Seasonal_Description);
            this.SplitContainer1.Panel1.Controls.Add(this.Label10);
            this.SplitContainer1.Panel1.Controls.Add(this.Seasonal_Product_Name);
            this.SplitContainer1.Panel1.Controls.Add(this.Label9);
            this.SplitContainer1.Panel1.Controls.Add(this.Seasonal_Gross_Price);
            this.SplitContainer1.Panel1.Controls.Add(this.Seasonal_Product_Type);
            this.SplitContainer1.Panel1.Controls.Add(this.Label8);
            this.SplitContainer1.Panel1.Controls.Add(this.Label7);
            this.SplitContainer1.Panel1.Controls.Add(this.Seasonal_Bill_Number);
            this.SplitContainer1.Panel1.Controls.Add(this.Label5);
            this.SplitContainer1.Panel1.Controls.Add(this.Seasonal_Product_Id);
            this.SplitContainer1.Panel1.Controls.Add(this.Label4);
            this.SplitContainer1.Panel1.Controls.Add(this.Label1);
            this.SplitContainer1.Panel1.Controls.Add(this.Seasonal_Subscription);
            this.SplitContainer1.Panel1.Controls.Add(this.ToolStrip);
            this.SplitContainer1.Panel1.Controls.Add(this.Label17);
            this.SplitContainer1.Panel1.Controls.Add(this.Label16);
            this.SplitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // SplitContainer1.Panel2
            // 
            this.SplitContainer1.Panel2.Controls.Add(this.DV);
            this.SplitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SplitContainer1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SplitContainer1.Size = new System.Drawing.Size(1237, 534);
            this.SplitContainer1.SplitterDistance = 254;
            this.SplitContainer1.SplitterWidth = 5;
            this.SplitContainer1.TabIndex = 0;
            // 
            // Seasonal_Year
            // 
            this.Seasonal_Year.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Seasonal_Year.Location = new System.Drawing.Point(550, 35);
            this.Seasonal_Year.Mask = "####";
            this.Seasonal_Year.Name = "Seasonal_Year";
            this.Seasonal_Year.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Seasonal_Year.Size = new System.Drawing.Size(45, 22);
            this.Seasonal_Year.TabIndex = 303;
            // 
            // Label18
            // 
            this.Label18.AutoSize = true;
            this.Label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label18.Location = new System.Drawing.Point(595, 37);
            this.Label18.Name = "Label18";
            this.Label18.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label18.Size = new System.Drawing.Size(89, 25);
            this.Label18.TabIndex = 266;
            this.Label18.Text = "سال مالی :";
            // 
            // Seasonal_Valu_Price_check
            // 
            this.Seasonal_Valu_Price_check.AutoSize = true;
            this.Seasonal_Valu_Price_check.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Seasonal_Valu_Price_check.ForeColor = System.Drawing.Color.DimGray;
            this.Seasonal_Valu_Price_check.Location = new System.Drawing.Point(1098, 188);
            this.Seasonal_Valu_Price_check.Name = "Seasonal_Valu_Price_check";
            this.Seasonal_Valu_Price_check.Size = new System.Drawing.Size(131, 23);
            this.Seasonal_Valu_Price_check.TabIndex = 15;
            this.Seasonal_Valu_Price_check.Text = "محاسبه شود";
            this.Seasonal_Valu_Price_check.UseVisualStyleBackColor = true;
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label12.Location = new System.Drawing.Point(213, 185);
            this.Label12.Name = "Label12";
            this.Label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label12.Size = new System.Drawing.Size(121, 25);
            this.Label12.TabIndex = 263;
            this.Label12.Text = "سایر عوارض :";
            // 
            // Seasonal_Complications
            // 
            this.Seasonal_Complications.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Seasonal_Complications.Location = new System.Drawing.Point(13, 182);
            this.Seasonal_Complications.MaxLength = 15;
            this.Seasonal_Complications.Name = "Seasonal_Complications";
            this.Seasonal_Complications.Size = new System.Drawing.Size(196, 31);
            this.Seasonal_Complications.TabIndex = 18;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label11.Location = new System.Drawing.Point(500, 186);
            this.Label11.Name = "Label11";
            this.Label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label11.Size = new System.Drawing.Size(201, 25);
            this.Label11.TabIndex = 261;
            this.Label11.Text = "عوارض بر ارزش افزوده :";
            // 
            // Seasonal_Complications_Price
            // 
            this.Seasonal_Complications_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Seasonal_Complications_Price.Location = new System.Drawing.Point(335, 183);
            this.Seasonal_Complications_Price.MaxLength = 15;
            this.Seasonal_Complications_Price.Name = "Seasonal_Complications_Price";
            this.Seasonal_Complications_Price.Size = new System.Drawing.Size(161, 31);
            this.Seasonal_Complications_Price.TabIndex = 17;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label6.Location = new System.Drawing.Point(913, 186);
            this.Label6.Name = "Label6";
            this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label6.Size = new System.Drawing.Size(186, 25);
            this.Label6.TabIndex = 259;
            this.Label6.Text = "مالیات بر ارزش افزوده :";
            // 
            // Seasonal_Valu_Price
            // 
            this.Seasonal_Valu_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Seasonal_Valu_Price.Location = new System.Drawing.Point(707, 183);
            this.Seasonal_Valu_Price.MaxLength = 15;
            this.Seasonal_Valu_Price.Name = "Seasonal_Valu_Price";
            this.Seasonal_Valu_Price.Size = new System.Drawing.Size(203, 31);
            this.Seasonal_Valu_Price.TabIndex = 16;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label3.Location = new System.Drawing.Point(274, 147);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label3.Size = new System.Drawing.Size(191, 25);
            this.Label3.TabIndex = 257;
            this.Label3.Text = "مبلغ خالص کالا / خدمت :";
            // 
            // Seasonal_Pure_Price
            // 
            this.Seasonal_Pure_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Seasonal_Pure_Price.Location = new System.Drawing.Point(13, 144);
            this.Seasonal_Pure_Price.MaxLength = 15;
            this.Seasonal_Pure_Price.Name = "Seasonal_Pure_Price";
            this.Seasonal_Pure_Price.Size = new System.Drawing.Size(259, 31);
            this.Seasonal_Pure_Price.TabIndex = 14;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label2.Location = new System.Drawing.Point(644, 151);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label2.Size = new System.Drawing.Size(102, 25);
            this.Label2.TabIndex = 255;
            this.Label2.Text = "مبلغ تخفیف :";
            // 
            // Seasonal_Discount_Price
            // 
            this.Seasonal_Discount_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Seasonal_Discount_Price.Location = new System.Drawing.Point(471, 147);
            this.Seasonal_Discount_Price.MaxLength = 15;
            this.Seasonal_Discount_Price.Name = "Seasonal_Discount_Price";
            this.Seasonal_Discount_Price.Size = new System.Drawing.Size(167, 31);
            this.Seasonal_Discount_Price.TabIndex = 13;
            // 
            // Seasonal_Documents_Number
            // 
            this.Seasonal_Documents_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Seasonal_Documents_Number.Location = new System.Drawing.Point(915, 106);
            this.Seasonal_Documents_Number.Name = "Seasonal_Documents_Number";
            this.Seasonal_Documents_Number.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Seasonal_Documents_Number.Size = new System.Drawing.Size(144, 31);
            this.Seasonal_Documents_Number.TabIndex = 8;
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label15.Location = new System.Drawing.Point(1142, 35);
            this.Label15.Name = "Label15";
            this.Label15.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label15.Size = new System.Drawing.Size(91, 25);
            this.Label15.TabIndex = 186;
            this.Label15.Text = "تاریخ ثبت :";
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label13.Location = new System.Drawing.Point(119, 109);
            this.Label13.Name = "Label13";
            this.Label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label13.Size = new System.Drawing.Size(152, 25);
            this.Label13.TabIndex = 190;
            this.Label13.Text = "تاریخ صورتحساب :";
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label14.Location = new System.Drawing.Point(749, 110);
            this.Label14.Name = "Label14";
            this.Label14.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label14.Size = new System.Drawing.Size(166, 25);
            this.Label14.TabIndex = 189;
            this.Label14.Text = "تاریخ سند حسابداری :";
            // 
            // B_Seasonal_Company
            // 
            this.B_Seasonal_Company.Image = ((System.Drawing.Image)(resources.GetObject("B_Seasonal_Company.Image")));
            this.B_Seasonal_Company.Location = new System.Drawing.Point(12, 35);
            this.B_Seasonal_Company.Name = "B_Seasonal_Company";
            this.B_Seasonal_Company.Size = new System.Drawing.Size(29, 27);
            this.B_Seasonal_Company.TabIndex = 4;
            this.B_Seasonal_Company.UseVisualStyleBackColor = true;
            // 
            // Seasonal_Operation
            // 
            this.Seasonal_Operation.Enabled = false;
            this.Seasonal_Operation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Seasonal_Operation.FormattingEnabled = true;
            this.Seasonal_Operation.Items.AddRange(new object[] {
            "عادی",
            "مباغ کمتر از 5درصد حد نصاب معاملات کوچک",
            "انجام معامله از طریق حق العمل کاری"});
            this.Seasonal_Operation.Location = new System.Drawing.Point(687, 35);
            this.Seasonal_Operation.Name = "Seasonal_Operation";
            this.Seasonal_Operation.Size = new System.Drawing.Size(272, 28);
            this.Seasonal_Operation.TabIndex = 1;
            // 
            // Seasonal_Description
            // 
            this.Seasonal_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Seasonal_Description.Location = new System.Drawing.Point(12, 217);
            this.Seasonal_Description.Name = "Seasonal_Description";
            this.Seasonal_Description.Size = new System.Drawing.Size(1123, 31);
            this.Seasonal_Description.TabIndex = 19;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label10.Location = new System.Drawing.Point(1139, 217);
            this.Label10.Name = "Label10";
            this.Label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label10.Size = new System.Drawing.Size(92, 25);
            this.Label10.TabIndex = 179;
            this.Label10.Text = "توضیحات :";
            // 
            // Seasonal_Product_Name
            // 
            this.Seasonal_Product_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Seasonal_Product_Name.Location = new System.Drawing.Point(398, 69);
            this.Seasonal_Product_Name.Name = "Seasonal_Product_Name";
            this.Seasonal_Product_Name.Size = new System.Drawing.Size(292, 31);
            this.Seasonal_Product_Name.TabIndex = 6;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label9.Location = new System.Drawing.Point(1025, 149);
            this.Label9.Name = "Label9";
            this.Label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label9.Size = new System.Drawing.Size(207, 25);
            this.Label9.TabIndex = 175;
            this.Label9.Text = "مبلغ  ناخالص کالا / خدمت :";
            // 
            // Seasonal_Gross_Price
            // 
            this.Seasonal_Gross_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Seasonal_Gross_Price.Location = new System.Drawing.Point(747, 146);
            this.Seasonal_Gross_Price.MaxLength = 15;
            this.Seasonal_Gross_Price.Name = "Seasonal_Gross_Price";
            this.Seasonal_Gross_Price.Size = new System.Drawing.Size(277, 31);
            this.Seasonal_Gross_Price.TabIndex = 12;
            // 
            // Seasonal_Product_Type
            // 
            this.Seasonal_Product_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Seasonal_Product_Type.FormattingEnabled = true;
            this.Seasonal_Product_Type.Location = new System.Drawing.Point(816, 70);
            this.Seasonal_Product_Type.Name = "Seasonal_Product_Type";
            this.Seasonal_Product_Type.Size = new System.Drawing.Size(277, 28);
            this.Seasonal_Product_Type.TabIndex = 5;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label8.Location = new System.Drawing.Point(1090, 71);
            this.Label8.Name = "Label8";
            this.Label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label8.Size = new System.Drawing.Size(143, 25);
            this.Label8.TabIndex = 174;
            this.Label8.Text = "نوع کالا / خدمات :";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label7.Location = new System.Drawing.Point(479, 112);
            this.Label7.Name = "Label7";
            this.Label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label7.Size = new System.Drawing.Size(159, 25);
            this.Label7.TabIndex = 173;
            this.Label7.Text = "شماره صورتحساب :";
            // 
            // Seasonal_Bill_Number
            // 
            this.Seasonal_Bill_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Seasonal_Bill_Number.Location = new System.Drawing.Point(274, 108);
            this.Seasonal_Bill_Number.Name = "Seasonal_Bill_Number";
            this.Seasonal_Bill_Number.Size = new System.Drawing.Size(199, 31);
            this.Seasonal_Bill_Number.TabIndex = 10;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label5.Location = new System.Drawing.Point(301, 73);
            this.Label5.Name = "Label5";
            this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label5.Size = new System.Drawing.Size(98, 25);
            this.Label5.TabIndex = 171;
            this.Label5.Text = "شناسه کالا :";
            // 
            // Seasonal_Product_Id
            // 
            this.Seasonal_Product_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Seasonal_Product_Id.Location = new System.Drawing.Point(13, 70);
            this.Seasonal_Product_Id.Name = "Seasonal_Product_Id";
            this.Seasonal_Product_Id.Size = new System.Drawing.Size(283, 31);
            this.Seasonal_Product_Id.TabIndex = 7;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label4.Location = new System.Drawing.Point(687, 72);
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label4.Size = new System.Drawing.Size(129, 25);
            this.Label4.TabIndex = 170;
            this.Label4.Text = "نام کالا /خدمات :";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label1.Location = new System.Drawing.Point(425, 36);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label1.Size = new System.Drawing.Size(123, 25);
            this.Label1.TabIndex = 166;
            this.Label1.Text = "کــد مـشـتــرک :";
            // 
            // Seasonal_Subscription
            // 
            this.Seasonal_Subscription.Enabled = false;
            this.Seasonal_Subscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Seasonal_Subscription.Location = new System.Drawing.Point(42, 33);
            this.Seasonal_Subscription.Name = "Seasonal_Subscription";
            this.Seasonal_Subscription.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Seasonal_Subscription.Size = new System.Drawing.Size(381, 31);
            this.Seasonal_Subscription.TabIndex = 3;
            // 
            // ToolStrip
            // 
            this.ToolStrip.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.B_New,
            this.B_Edit,
            this.B_Delet,
            this.B_Save,
            this.B_Search,
            this.B_Excel,
            this.B_Print,
            this.B_Log_File,
            this.B_Picture,
            this.B_Abort,
            this.Estate_Control});
            this.ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(1237, 26);
            this.ToolStrip.TabIndex = 0;
            this.ToolStrip.Text = "ToolStrip1";
            // 
            // B_New
            // 
            this.B_New.Image = ((System.Drawing.Image)(resources.GetObject("B_New.Image")));
            this.B_New.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.B_New.Name = "B_New";
            this.B_New.Size = new System.Drawing.Size(62, 23);
            this.B_New.Text = "جدید";
            // 
            // B_Edit
            // 
            this.B_Edit.Image = ((System.Drawing.Image)(resources.GetObject("B_Edit.Image")));
            this.B_Edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.B_Edit.Name = "B_Edit";
            this.B_Edit.Size = new System.Drawing.Size(76, 23);
            this.B_Edit.Text = "ویرایش";
            // 
            // B_Delet
            // 
            this.B_Delet.Image = ((System.Drawing.Image)(resources.GetObject("B_Delet.Image")));
            this.B_Delet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.B_Delet.Name = "B_Delet";
            this.B_Delet.Size = new System.Drawing.Size(63, 23);
            this.B_Delet.Text = "حذف";
            this.B_Delet.ToolTipText = "حذف";
            // 
            // B_Save
            // 
            this.B_Save.Enabled = false;
            this.B_Save.Image = ((System.Drawing.Image)(resources.GetObject("B_Save.Image")));
            this.B_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.B_Save.Name = "B_Save";
            this.B_Save.Size = new System.Drawing.Size(68, 23);
            this.B_Save.Text = "ذخیره";
            // 
            // B_Search
            // 
            this.B_Search.Image = ((System.Drawing.Image)(resources.GetObject("B_Search.Image")));
            this.B_Search.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.B_Search.Name = "B_Search";
            this.B_Search.Size = new System.Drawing.Size(81, 23);
            this.B_Search.Text = "جستجو";
            // 
            // B_Excel
            // 
            this.B_Excel.Image = ((System.Drawing.Image)(resources.GetObject("B_Excel.Image")));
            this.B_Excel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.B_Excel.Name = "B_Excel";
            this.B_Excel.Size = new System.Drawing.Size(70, 23);
            this.B_Excel.Text = "اکسل";
            // 
            // B_Print
            // 
            this.B_Print.Image = ((System.Drawing.Image)(resources.GetObject("B_Print.Image")));
            this.B_Print.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.B_Print.Name = "B_Print";
            this.B_Print.Size = new System.Drawing.Size(58, 23);
            this.B_Print.Text = "چاپ";
            // 
            // B_Log_File
            // 
            this.B_Log_File.Image = ((System.Drawing.Image)(resources.GetObject("B_Log_File.Image")));
            this.B_Log_File.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.B_Log_File.Name = "B_Log_File";
            this.B_Log_File.Size = new System.Drawing.Size(109, 23);
            this.B_Log_File.Text = "کنترل اسناد";
            this.B_Log_File.Visible = false;
            // 
            // B_Picture
            // 
            this.B_Picture.Image = ((System.Drawing.Image)(resources.GetObject("B_Picture.Image")));
            this.B_Picture.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.B_Picture.Name = "B_Picture";
            this.B_Picture.Size = new System.Drawing.Size(63, 23);
            this.B_Picture.Text = "تصویر";
            // 
            // B_Abort
            // 
            this.B_Abort.Image = ((System.Drawing.Image)(resources.GetObject("B_Abort.Image")));
            this.B_Abort.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.B_Abort.Name = "B_Abort";
            this.B_Abort.Size = new System.Drawing.Size(74, 23);
            this.B_Abort.Text = "انصراف";
            // 
            // Estate_Control
            // 
            this.Estate_Control.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Estate_Control.Items.AddRange(new object[] {
            "بـــــهــــار",
            "تابستان",
            "پـــائـــیــز",
            "زمستان"});
            this.Estate_Control.Name = "Estate_Control";
            this.Estate_Control.Size = new System.Drawing.Size(180, 26);
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label17.Location = new System.Drawing.Point(958, 36);
            this.Label17.Name = "Label17";
            this.Label17.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label17.Size = new System.Drawing.Size(73, 25);
            this.Label17.TabIndex = 194;
            this.Label17.Text = "عملیات :";
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label16.Location = new System.Drawing.Point(1059, 109);
            this.Label16.Name = "Label16";
            this.Label16.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label16.Size = new System.Drawing.Size(173, 25);
            this.Label16.TabIndex = 192;
            this.Label16.Text = "شماره سند حسابداری :";
            // 
            // DV
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DV.DefaultCellStyle = dataGridViewCellStyle2;
            this.DV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.DV.Location = new System.Drawing.Point(0, 0);
            this.DV.Name = "DV";
            this.DV.Size = new System.Drawing.Size(1237, 275);
            this.DV.TabIndex = 0;
            // 
            // Seasonal_Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1237, 534);
            this.Controls.Add(this.SplitContainer1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Seasonal_Sales";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ch_Add_A";
            this.SplitContainer1.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel1.PerformLayout();
            this.SplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).EndInit();
            this.SplitContainer1.ResumeLayout(false);
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DV)).EndInit();
            this.ResumeLayout(false);

        }
        internal System.Windows.Forms.SplitContainer SplitContainer1;
        internal System.Windows.Forms.ToolStrip ToolStrip;
        internal System.Windows.Forms.ToolStripButton B_Edit;
        internal System.Windows.Forms.ToolStripButton B_Delet;
        internal System.Windows.Forms.ToolStripButton B_Save;
        internal System.Windows.Forms.ToolStripButton B_Search;
        internal System.Windows.Forms.ToolStripButton B_Print;
        internal System.Windows.Forms.ToolStripButton B_Abort;
        internal System.Windows.Forms.ToolStripButton B_Excel;
        internal System.Windows.Forms.DataGridView DV;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.TextBox Seasonal_Product_Name;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.TextBox Seasonal_Gross_Price;
        internal System.Windows.Forms.ComboBox Seasonal_Product_Type;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox Seasonal_Bill_Number;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox Seasonal_Product_Id;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox Seasonal_Subscription;
        internal System.Windows.Forms.TextBox Seasonal_Description;
 //       internal Ansaripour.Rtl_Date Seasonal_Date;
        internal System.Windows.Forms.Label Label15;
 //       internal Ansaripour.Rtl_Date Seasonal_Bill_Date;
//internal Ansaripour.Rtl_Date Seasonal_Documents_Date;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.ComboBox Seasonal_Operation;
        internal System.Windows.Forms.Label Label17;
        internal System.Windows.Forms.Button B_Seasonal_Company;
        internal System.Windows.Forms.ToolStripButton B_Picture;
        internal System.Windows.Forms.ToolStripButton B_Log_File;
        internal System.Windows.Forms.TextBox Seasonal_Documents_Number;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.TextBox Seasonal_Complications;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.TextBox Seasonal_Complications_Price;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox Seasonal_Valu_Price;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox Seasonal_Pure_Price;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox Seasonal_Discount_Price;
        internal System.Windows.Forms.CheckBox Seasonal_Valu_Price_check;
        internal System.Windows.Forms.ToolStripComboBox Estate_Control;
        internal System.Windows.Forms.Label Label18;
        private System.Windows.Forms.MaskedTextBox Seasonal_Year;
        internal System.Windows.Forms.ToolStripButton B_New;
    }
}