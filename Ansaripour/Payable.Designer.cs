using System.IO;
using System.Net;
using System.Text;
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
    public partial class Payable : System.Windows.Forms.Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payable));
            System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.New_B = new System.Windows.Forms.ToolStripButton();
            this.Edit_B = new System.Windows.Forms.ToolStripButton();
            this.Delet_B = new System.Windows.Forms.ToolStripButton();
            this.Save_B = new System.Windows.Forms.ToolStripButton();
            this.Search_B = new System.Windows.Forms.ToolStripButton();
            this.B_Excel = new System.Windows.Forms.ToolStripButton();
            this.ToolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.CHAP = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CHEK = new System.Windows.Forms.ToolStripMenuItem();
            this.Letter = new System.Windows.Forms.ToolStripMenuItem();
            this.Report = new System.Windows.Forms.ToolStripMenuItem();
            this.Abort_B = new System.Windows.Forms.ToolStripButton();
            this.Clas = new System.Windows.Forms.ToolStripTextBox();
            this.DV = new System.Windows.Forms.DataGridView();
            this.Types = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.TextBox();
            this.Label13 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.M_Bank = new System.Windows.Forms.TextBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.Branch_Code = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.Branch_Name = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.Bank_Name = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Payable_Account = new System.Windows.Forms.ComboBox();
            this.Payable_Id = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.B_Control = new Ansaripour.B_Control();
            this.Label14 = new System.Windows.Forms.Label();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.Payable_Description = new System.Windows.Forms.TextBox();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.Dv_Details = new System.Windows.Forms.DataGridView();
            this.Payable_Number = new System.Windows.Forms.TextBox();
            this.B_Date = new Ansaripour.Rtl_Date();
            this.Payable_Date = new Ansaripour.Rtl_Date();
            ((System.ComponentModel.ISupportInitialize)this.SplitContainer1).BeginInit();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            this.ToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.DV).BeginInit();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.TabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.Dv_Details).BeginInit();
            this.SuspendLayout();
            //
            //SplitContainer1
            //
            this.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.SplitContainer1.Name = "SplitContainer1";
            this.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            //
            //SplitContainer1.Panel1
            //
            this.SplitContainer1.Panel1.Controls.Add(this.ToolStrip1);
            this.SplitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            //
            //SplitContainer1.Panel2
            //
            this.SplitContainer1.Panel2.Controls.Add(this.DV);
            this.SplitContainer1.Panel2.Controls.Add(this.Types);
            this.SplitContainer1.Panel2.Controls.Add(this.Amount);
            this.SplitContainer1.Panel2.Controls.Add(this.Label13);
            this.SplitContainer1.Panel2.Controls.Add(this.GroupBox1);
            this.SplitContainer1.Panel2.Controls.Add(this.Label6);
            this.SplitContainer1.Panel2.Controls.Add(this.Label5);
            this.SplitContainer1.Panel2.Controls.Add(this.Payable_Account);
            this.SplitContainer1.Panel2.Controls.Add(this.Payable_Id);
            this.SplitContainer1.Panel2.Controls.Add(this.Label4);
            this.SplitContainer1.Panel2.Controls.Add(this.Label3);
            this.SplitContainer1.Panel2.Controls.Add(this.Label2);
            this.SplitContainer1.Panel2.Controls.Add(this.Label1);
            this.SplitContainer1.Panel2.Controls.Add(this.PictureBox1);
            this.SplitContainer1.Panel2.Controls.Add(this.B_Control);
            this.SplitContainer1.Panel2.Controls.Add(this.Label14);
            this.SplitContainer1.Panel2.Controls.Add(this.TabControl1);
            this.SplitContainer1.Panel2.Controls.Add(this.Payable_Number);
            this.SplitContainer1.Panel2.Controls.Add(this.B_Date);
            this.SplitContainer1.Panel2.Controls.Add(this.Payable_Date);
            this.SplitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SplitContainer1.Size = new System.Drawing.Size(795, 550);
            this.SplitContainer1.SplitterDistance = 27;
            this.SplitContainer1.TabIndex = 203;
            //
            //ToolStrip1
            //
            this.ToolStrip1.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.New_B, this.Edit_B, this.Delet_B, this.Save_B, this.Search_B, this.B_Excel, this.ToolStripDropDownButton1, this.Abort_B, this.Clas });
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ToolStrip1.Size = new System.Drawing.Size(795, 26);
            this.ToolStrip1.TabIndex = 203;
            this.ToolStrip1.Text = "ToolStrip1";
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
            //ToolStripDropDownButton1
            //
            this.ToolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.CHAP, this.ToolStripSeparator1, this.CHEK, this.Letter, this.Report });
            this.ToolStripDropDownButton1.Image = (System.Drawing.Image)resources.GetObject("ToolStripDropDownButton1.Image");
            this.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1";
            this.ToolStripDropDownButton1.Size = new System.Drawing.Size(67, 23);
            this.ToolStripDropDownButton1.Text = "چاپ";
            //
            //CHAP
            //
            this.CHAP.Name = "CHAP";
            this.CHAP.Size = new System.Drawing.Size(207, 24);
            this.CHAP.Text = "چاپ دستور پرداخت";
            //
            //ToolStripSeparator1
            //
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(204, 6);
            //
            //CHEK
            //
            this.CHEK.Name = "CHEK";
            this.CHEK.Size = new System.Drawing.Size(207, 24);
            this.CHEK.Text = "چـــــــــــاپ چــــــک";
            //
            //Letter
            //
            this.Letter.Name = "Letter";
            this.Letter.Size = new System.Drawing.Size(207, 24);
            this.Letter.Text = "چاپ نامه بــــانـــــک";
            //
            //Report
            //
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(207, 24);
            this.Report.Text = "چـــــــــــاپ گـزارش";
            //
            //Abort_B
            //
            this.Abort_B.Image = (System.Drawing.Image)resources.GetObject("Abort_B.Image");
            this.Abort_B.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Abort_B.Name = "Abort_B";
            this.Abort_B.Size = new System.Drawing.Size(74, 23);
            this.Abort_B.Text = "انصراف";
            //
            //Clas
            //
            this.Clas.Name = "Clas";
            this.Clas.Size = new System.Drawing.Size(10, 26);
            this.Clas.Visible = false;
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
            this.DV.Size = new System.Drawing.Size(795, 519);
            this.DV.TabIndex = 252;
            this.DV.Visible = false;
            //
            //Types
            //
            this.Types.AutoSize = true;
            this.Types.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Types.ForeColor = System.Drawing.Color.Red;
            this.Types.Location = new System.Drawing.Point(12, 485);
            this.Types.Name = "Types";
            this.Types.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Types.Size = new System.Drawing.Size(34, 19);
            this.Types.TabIndex = 242;
            this.Types.Text = "ریال";
            this.Types.TextAlign = System.Drawing.ContentAlignment.TopRight;
            //
            //Amount
            //
            this.Amount.BackColor = System.Drawing.Color.White;
            this.Amount.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Amount.Location = new System.Drawing.Point(12, 452);
            this.Amount.MaxLength = 15;
            this.Amount.Name = "Amount";
            this.Amount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Amount.Size = new System.Drawing.Size(210, 30);
            this.Amount.TabIndex = 230;
            this.Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            //
            //Label13
            //
            this.Label13.AutoSize = true;
            this.Label13.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label13.Location = new System.Drawing.Point(228, 458);
            this.Label13.Name = "Label13";
            this.Label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label13.Size = new System.Drawing.Size(80, 19);
            this.Label13.TabIndex = 241;
            this.Label13.Text = "مبلغ چک :";
            //
            //GroupBox1
            //
            this.GroupBox1.Controls.Add(this.M_Bank);
            this.GroupBox1.Controls.Add(this.Label12);
            this.GroupBox1.Controls.Add(this.Branch_Code);
            this.GroupBox1.Controls.Add(this.Label11);
            this.GroupBox1.Controls.Add(this.Branch_Name);
            this.GroupBox1.Controls.Add(this.Label10);
            this.GroupBox1.Controls.Add(this.Bank_Name);
            this.GroupBox1.Controls.Add(this.Label9);
            this.GroupBox1.Location = new System.Drawing.Point(4, 17);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(311, 190);
            this.GroupBox1.TabIndex = 238;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "اطلاعات حساب :";
            //
            //M_Bank
            //
            this.M_Bank.BackColor = System.Drawing.Color.White;
            this.M_Bank.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.M_Bank.Location = new System.Drawing.Point(10, 154);
            this.M_Bank.Name = "M_Bank";
            this.M_Bank.ReadOnly = true;
            this.M_Bank.Size = new System.Drawing.Size(289, 30);
            this.M_Bank.TabIndex = 187;
            this.M_Bank.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            //
            //Label12
            //
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label12.Location = new System.Drawing.Point(109, 125);
            this.Label12.Name = "Label12";
            this.Label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label12.Size = new System.Drawing.Size(189, 19);
            this.Label12.TabIndex = 186;
            this.Label12.Text = "موجودی قبل از صدور چک :";
            //
            //Branch_Code
            //
            this.Branch_Code.BackColor = System.Drawing.Color.White;
            this.Branch_Code.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Branch_Code.Location = new System.Drawing.Point(8, 89);
            this.Branch_Code.Name = "Branch_Code";
            this.Branch_Code.ReadOnly = true;
            this.Branch_Code.Size = new System.Drawing.Size(204, 30);
            this.Branch_Code.TabIndex = 185;
            //
            //Label11
            //
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label11.Location = new System.Drawing.Point(216, 93);
            this.Label11.Name = "Label11";
            this.Label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label11.Size = new System.Drawing.Size(86, 19);
            this.Label11.TabIndex = 184;
            this.Label11.Text = "کد  شعبه :";
            //
            //Branch_Name
            //
            this.Branch_Name.BackColor = System.Drawing.Color.White;
            this.Branch_Name.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Branch_Name.Location = new System.Drawing.Point(8, 53);
            this.Branch_Name.Name = "Branch_Name";
            this.Branch_Name.ReadOnly = true;
            this.Branch_Name.Size = new System.Drawing.Size(204, 30);
            this.Branch_Name.TabIndex = 183;
            //
            //Label10
            //
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label10.Location = new System.Drawing.Point(216, 56);
            this.Label10.Name = "Label10";
            this.Label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label10.Size = new System.Drawing.Size(87, 19);
            this.Label10.TabIndex = 182;
            this.Label10.Text = "نام  شعبه :";
            //
            //Bank_Name
            //
            this.Bank_Name.BackColor = System.Drawing.Color.White;
            this.Bank_Name.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Bank_Name.Location = new System.Drawing.Point(8, 17);
            this.Bank_Name.Name = "Bank_Name";
            this.Bank_Name.ReadOnly = true;
            this.Bank_Name.Size = new System.Drawing.Size(204, 30);
            this.Bank_Name.TabIndex = 181;
            //
            //Label9
            //
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label9.Location = new System.Drawing.Point(216, 21);
            this.Label9.Name = "Label9";
            this.Label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label9.Size = new System.Drawing.Size(87, 19);
            this.Label9.TabIndex = 180;
            this.Label9.Text = "نام بــــانک :";
            //
            //Label6
            //
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label6.Location = new System.Drawing.Point(241, 222);
            this.Label6.Name = "Label6";
            this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label6.Size = new System.Drawing.Size(91, 19);
            this.Label6.TabIndex = 237;
            this.Label6.Text = "شماره چک:";
            //
            //Label5
            //
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label5.Location = new System.Drawing.Point(671, 222);
            this.Label5.Name = "Label5";
            this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label5.Size = new System.Drawing.Size(111, 19);
            this.Label5.TabIndex = 236;
            this.Label5.Text = "شماره حساب:";
            //
            //Payable_Account
            //
            this.Payable_Account.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Payable_Account.FormattingEnabled = true;
            this.Payable_Account.Location = new System.Drawing.Point(340, 217);
            this.Payable_Account.Name = "Payable_Account";
            this.Payable_Account.Size = new System.Drawing.Size(322, 31);
            this.Payable_Account.TabIndex = 226;
            //
            //Payable_Id
            //
            this.Payable_Id.BackColor = System.Drawing.Color.White;
            this.Payable_Id.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Payable_Id.Location = new System.Drawing.Point(561, 140);
            this.Payable_Id.Name = "Payable_Id";
            this.Payable_Id.Size = new System.Drawing.Size(65, 27);
            this.Payable_Id.TabIndex = 224;
            //
            //Label4
            //
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label4.Location = new System.Drawing.Point(627, 141);
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label4.Size = new System.Drawing.Size(160, 19);
            this.Label4.TabIndex = 235;
            this.Label4.Text = "شماره دستور پرداخت:";
            //
            //Label3
            //
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label3.Location = new System.Drawing.Point(667, 182);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label3.Size = new System.Drawing.Size(120, 19);
            this.Label3.TabIndex = 234;
            this.Label3.Text = "تاریخ  صدور چک:";
            //
            //Label2
            //
            this.Label2.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Label2.Location = new System.Drawing.Point(321, 17);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label2.Size = new System.Drawing.Size(53, 23);
            this.Label2.TabIndex = 233;
            this.Label2.Text = "تست";
            //
            //Label1
            //
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label1.Location = new System.Drawing.Point(673, 108);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label1.Size = new System.Drawing.Size(115, 25);
            this.Label1.TabIndex = 232;
            this.Label1.Text = "دستور پرداخت";
            //
            //PictureBox1
            //
            this.PictureBox1.Image = (System.Drawing.Image)resources.GetObject("PictureBox1.Image");
            this.PictureBox1.Location = new System.Drawing.Point(673, 3);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(117, 97);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 223;
            this.PictureBox1.TabStop = false;
            //
            //B_Control
            //
            this.B_Control.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.B_Control.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.B_Control.ForeColor = System.Drawing.Color.White;
            this.B_Control.Location = new System.Drawing.Point(320, 111);
            this.B_Control.Name = "B_Control";
            this.B_Control.Size = new System.Drawing.Size(240, 61);
            this.B_Control.TabIndex = 243;
            //
            //Label14
            //
            this.Label14.AutoSize = true;
            this.Label14.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label14.Location = new System.Drawing.Point(458, 182);
            this.Label14.Name = "Label14";
            this.Label14.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label14.Size = new System.Drawing.Size(65, 19);
            this.Label14.TabIndex = 245;
            this.Label14.Text = "از تاریخ :";
            this.Label14.Visible = false;
            //
            //TabControl1
            //
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Location = new System.Drawing.Point(4, 254);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.RightToLeftLayout = true;
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(779, 186);
            this.TabControl1.TabIndex = 251;
            //
            //TabPage1
            //
            this.TabPage1.Controls.Add(this.Payable_Description);
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(771, 160);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "شرح چک :";
            this.TabPage1.UseVisualStyleBackColor = true;
            //
            //Payable_Description
            //
            this.Payable_Description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Payable_Description.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.Payable_Description.Location = new System.Drawing.Point(6, 6);
            this.Payable_Description.Multiline = true;
            this.Payable_Description.Name = "Payable_Description";
            this.Payable_Description.Size = new System.Drawing.Size(759, 148);
            this.Payable_Description.TabIndex = 250;
            //
            //TabPage2
            //
            this.TabPage2.Controls.Add(this.Dv_Details);
            this.TabPage2.Location = new System.Drawing.Point(4, 22);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(771, 160);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "لیست چک :";
            this.TabPage2.UseVisualStyleBackColor = true;
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
            this.Dv_Details.Location = new System.Drawing.Point(3, 3);
            this.Dv_Details.Name = "Dv_Details";
            this.Dv_Details.Size = new System.Drawing.Size(765, 154);
            this.Dv_Details.TabIndex = 3;
            //
            //Payable_Number
            //
            this.Payable_Number.BackColor = System.Drawing.Color.White;
            this.Payable_Number.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Payable_Number.Location = new System.Drawing.Point(7, 216);
            this.Payable_Number.MaxLength = 12;
            this.Payable_Number.Name = "Payable_Number";
            this.Payable_Number.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Payable_Number.Size = new System.Drawing.Size(228, 30);
            this.Payable_Number.TabIndex = 227;
            this.Payable_Number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            //
            //B_Date
            //
            this.B_Date.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.B_Date.AutoSize = true;
            this.B_Date.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.B_Date.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.B_Date.Location = new System.Drawing.Point(340, 178);
            this.B_Date.Name = "B_Date";
            this.B_Date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.B_Date.Size = new System.Drawing.Size(108, 32);
            this.B_Date.T_D = "";
            this.B_Date.TabIndex = 308;
            this.B_Date.Visible = false;
            //
            //Payable_Date
            //
            this.Payable_Date.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Payable_Date.AutoSize = true;
            this.Payable_Date.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Payable_Date.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Payable_Date.Location = new System.Drawing.Point(559, 178);
            this.Payable_Date.Name = "Payable_Date";
            this.Payable_Date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Payable_Date.Size = new System.Drawing.Size(108, 32);
            this.Payable_Date.T_D = "";
            this.Payable_Date.TabIndex = 307;
            //
            //Payable
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6.0F, 13.0F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(795, 550);
            this.Controls.Add(this.SplitContainer1);
            this.KeyPreview = true;
            this.Name = "Payable";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.SplitContainer1.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel1.PerformLayout();
            this.SplitContainer1.Panel2.ResumeLayout(false);
            this.SplitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.SplitContainer1).EndInit();
            this.SplitContainer1.ResumeLayout(false);
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.DV).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.TabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.Dv_Details).EndInit();
            this.ResumeLayout(false);

        }
        internal System.Windows.Forms.SplitContainer SplitContainer1;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton New_B;
        internal System.Windows.Forms.ToolStripButton Edit_B;
        internal System.Windows.Forms.ToolStripButton Delet_B;
        internal System.Windows.Forms.ToolStripButton Save_B;
        internal System.Windows.Forms.ToolStripButton Search_B;
        internal System.Windows.Forms.ToolStripButton B_Excel;
        internal System.Windows.Forms.ToolStripDropDownButton ToolStripDropDownButton1;
        internal System.Windows.Forms.ToolStripMenuItem CHAP;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripMenuItem CHEK;
        internal System.Windows.Forms.ToolStripButton Abort_B;
        internal System.Windows.Forms.Label Types;
        internal System.Windows.Forms.TextBox Amount;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox M_Bank;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.TextBox Branch_Code;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.TextBox Branch_Name;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.TextBox Bank_Name;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.TextBox Payable_Number;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.ComboBox Payable_Account;
        internal System.Windows.Forms.TextBox Payable_Id;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal Ansaripour.B_Control B_Control;
        internal System.Windows.Forms.ToolStripTextBox Clas;
        internal System.Windows.Forms.ToolStripMenuItem Report;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.TabControl TabControl1;
        internal System.Windows.Forms.TabPage TabPage1;
        internal System.Windows.Forms.TextBox Payable_Description;
        internal System.Windows.Forms.TabPage TabPage2;
        internal System.Windows.Forms.DataGridView Dv_Details;
        internal System.Windows.Forms.DataGridView DV;
        internal System.Windows.Forms.ToolStripMenuItem Letter;
        internal Ansaripour.Rtl_Date B_Date;
        internal Ansaripour.Rtl_Date Payable_Date;
    }
}