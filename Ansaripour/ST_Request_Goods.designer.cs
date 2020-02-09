
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
    public partial class ST_Request_Goods : System.Windows.Forms.Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ST_Request_Goods));
            System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.B_Product = new System.Windows.Forms.ToolStripDropDownButton();
            this.B_Ask_goods = new System.Windows.Forms.ToolStripMenuItem();
            this.B_purchase_request = new System.Windows.Forms.ToolStripMenuItem();
            this.B_warehouse_receipt = new System.Windows.Forms.ToolStripMenuItem();
            this.B_Anbar_order = new System.Windows.Forms.ToolStripMenuItem();
            this.B_Opening = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit_B = new System.Windows.Forms.ToolStripButton();
            this.Delet_B = new System.Windows.Forms.ToolStripButton();
            this.Save_B = new System.Windows.Forms.ToolStripButton();
            this.Search_B = new System.Windows.Forms.ToolStripButton();
            this.Chap = new System.Windows.Forms.ToolStripButton();
            this.B_Excel = new System.Windows.Forms.ToolStripButton();
            this.B_Picture = new System.Windows.Forms.ToolStripButton();
            this.Abort_B = new System.Windows.Forms.ToolStripButton();
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.Personal_Ask_Refrence = new System.Windows.Forms.TextBox();
            this.Number_Ask_Refrence = new System.Windows.Forms.TextBox();
            this.Description_Ask_Refrence = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.B_Personal_Ask_Refrence = new System.Windows.Forms.Button();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
      //      this.Date_Ask_Refrence = new Ansaripour.Rtl_Date();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.Description_Buy_Refrence = new System.Windows.Forms.TextBox();
            this.Number_Buy_Refrence = new System.Windows.Forms.TextBox();
            this.Label19 = new System.Windows.Forms.Label();
            this.Label_Date_S_Refrence = new System.Windows.Forms.Label();
            this.Label_Number_S_Refrence = new System.Windows.Forms.Label();
   //         this.Date_Buy_Refrence = new Ansaripour.Rtl_Date();
            this.TabPage3 = new System.Windows.Forms.TabPage();
            this.Description_Receipt_Refrence = new System.Windows.Forms.TextBox();
            this.Stock_Receipt_Refrence = new System.Windows.Forms.TextBox();
            this.Procurement_Receipt_Refrence = new System.Windows.Forms.TextBox();
            this.Number_Receipt_Refrence = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.B_Stock_Receipt_Refrence = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.B_Procurement_Receipt_Refrence = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label_Number_Receipt_Refrence = new System.Windows.Forms.Label();
    //        this.Date_Receipt_Refrence = new Ansaripour.Rtl_Date();
            this.TabPage4 = new System.Windows.Forms.TabPage();
            this.Description_Remittance_Refrence = new System.Windows.Forms.TextBox();
            this.Stock_Remittance_Refrence = new System.Windows.Forms.TextBox();
            this.Personal_Remittance_Refrence = new System.Windows.Forms.TextBox();
            this.Number_Remittance_Refrence = new System.Windows.Forms.TextBox();
            this.B_Stock_Remittance_Refrence = new System.Windows.Forms.Button();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.B_Personal_Remittance_Refrence = new System.Windows.Forms.Button();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
  //          this.Date_Remittance_Refrence = new Ansaripour.Rtl_Date();
            this.TabPage5 = new System.Windows.Forms.TabPage();
            this.Stock_Ta_Refrence = new System.Windows.Forms.TextBox();
            this.Stock_Az_Refrence = new System.Windows.Forms.TextBox();
            this.Label18 = new System.Windows.Forms.Label();
            this.Label17 = new System.Windows.Forms.Label();
            this.Button2 = new System.Windows.Forms.Button();
            this.Label16 = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.Label15 = new System.Windows.Forms.Label();
            //        this.Date_Ta_Refrence = new Ansaripour.Rtl_Date();
            //          this.Date_Az_Refrence = new Ansaripour.Rtl_Date();
            this.SplitContainer2 = new System.Windows.Forms.SplitContainer();

                      this.DV = new System.Windows.Forms.DataGridView();
           this.Dv_Goods = new Ansaripour.MyDataGridView();
            this.ToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.SplitContainer1).BeginInit();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.TabPage3.SuspendLayout();
            this.TabPage4.SuspendLayout();
            this.TabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.SplitContainer2).BeginInit();
            this.SplitContainer2.Panel1.SuspendLayout();
            this.SplitContainer2.Panel2.SuspendLayout();
            this.SplitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.DV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.Dv_Goods).BeginInit();
            this.SuspendLayout();
            //
            //ToolStrip1
            //
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.B_Product, this.Edit_B, this.Delet_B, this.Save_B, this.Search_B, this.Chap, this.B_Excel, this.B_Picture, this.Abort_B });
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ToolStrip1.Size = new System.Drawing.Size(1071, 25);
            this.ToolStrip1.TabIndex = 197;
            this.ToolStrip1.Text = "ToolStrip1";
            //
            //B_Product
            //
            this.B_Product.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.B_Ask_goods, this.B_purchase_request, this.B_warehouse_receipt, this.B_Anbar_order, this.B_Opening });
            this.B_Product.Image = (System.Drawing.Image)resources.GetObject("B_Product.Image");
            this.B_Product.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.B_Product.Name = "B_Product";
            this.B_Product.Size = new System.Drawing.Size(72, 22);
            this.B_Product.Text = "عملیات";
            //
            //B_Ask_goods
            //
            this.B_Ask_goods.Image = (System.Drawing.Image)resources.GetObject("B_Ask_goods.Image");
            this.B_Ask_goods.Name = "B_Ask_goods";
            this.B_Ask_goods.Size = new System.Drawing.Size(180, 22);
            this.B_Ask_goods.Text = "صدور درخواسـت کــالا";
            //
            //B_purchase_request
            //
            this.B_purchase_request.Image = (System.Drawing.Image)resources.GetObject("B_purchase_request.Image");
            this.B_purchase_request.Name = "B_purchase_request";
            this.B_purchase_request.Size = new System.Drawing.Size(180, 22);
            this.B_purchase_request.Text = "صدور درخواست خرید";
            //
            //B_warehouse_receipt
            //
            this.B_warehouse_receipt.Image = (System.Drawing.Image)resources.GetObject("B_warehouse_receipt.Image");
            this.B_warehouse_receipt.Name = "B_warehouse_receipt";
            this.B_warehouse_receipt.Size = new System.Drawing.Size(180, 22);
            this.B_warehouse_receipt.Text = "صدور رســیــد انــــبـــــار";
            //
            //B_Anbar_order
            //
            this.B_Anbar_order.Image = (System.Drawing.Image)resources.GetObject("B_Anbar_order.Image");
            this.B_Anbar_order.Name = "B_Anbar_order";
            this.B_Anbar_order.Size = new System.Drawing.Size(180, 22);
            this.B_Anbar_order.Text = "صدور حـــوالــــه انــبــار";
            //
            //B_Opening
            //
            this.B_Opening.Image = (System.Drawing.Image)resources.GetObject("B_Opening.Image");
            this.B_Opening.Name = "B_Opening";
            this.B_Opening.Size = new System.Drawing.Size(180, 22);
            this.B_Opening.Text = "ثبت افتــتــاحـیه انـــبـــار";
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
            //Chap
            //
            this.Chap.Image = (System.Drawing.Image)resources.GetObject("Chap.Image");
            this.Chap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Chap.Name = "Chap";
            this.Chap.Size = new System.Drawing.Size(48, 22);
            this.Chap.Text = "چاپ";
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
            this.SplitContainer1.Size = new System.Drawing.Size(1071, 532);
            this.SplitContainer1.SplitterDistance = 137;
            this.SplitContainer1.TabIndex = 65;
            //
            //TabControl1
            //
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Controls.Add(this.TabPage3);
            this.TabControl1.Controls.Add(this.TabPage4);
            this.TabControl1.Controls.Add(this.TabPage5);
            this.TabControl1.Location = new System.Drawing.Point(0, 25);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.RightToLeftLayout = true;
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(1068, 109);
            this.TabControl1.TabIndex = 198;
            //
            //TabPage1
            //
            this.TabPage1.Controls.Add(this.Personal_Ask_Refrence);
            this.TabPage1.Controls.Add(this.Number_Ask_Refrence);
            this.TabPage1.Controls.Add(this.Description_Ask_Refrence);
            this.TabPage1.Controls.Add(this.Label9);
            this.TabPage1.Controls.Add(this.B_Personal_Ask_Refrence);
            this.TabPage1.Controls.Add(this.Label5);
            this.TabPage1.Controls.Add(this.Label3);
            this.TabPage1.Controls.Add(this.Label1);
//this.TabPage1.Controls.Add(this.Date_Ask_Refrence);
            this.TabPage1.Location = new System.Drawing.Point(4, 28);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(1060, 77);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "درخواست کالا";
            this.TabPage1.UseVisualStyleBackColor = true;
            //
            //Personal_Ask_Refrence
            //
            this.Personal_Ask_Refrence.Enabled = false;
            this.Personal_Ask_Refrence.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Personal_Ask_Refrence.Location = new System.Drawing.Point(32, 4);
            this.Personal_Ask_Refrence.Name = "Personal_Ask_Refrence";
            this.Personal_Ask_Refrence.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Personal_Ask_Refrence.Size = new System.Drawing.Size(313, 31);
            this.Personal_Ask_Refrence.TabIndex = 2;
            //
            //Number_Ask_Refrence
            //
            this.Number_Ask_Refrence.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Number_Ask_Refrence.Location = new System.Drawing.Point(795, 3);
            this.Number_Ask_Refrence.Name = "Number_Ask_Refrence";
            this.Number_Ask_Refrence.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Number_Ask_Refrence.Size = new System.Drawing.Size(116, 31);
            this.Number_Ask_Refrence.TabIndex = 0;
            //
            //Description_Ask_Refrence
            //
            this.Description_Ask_Refrence.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Description_Ask_Refrence.Location = new System.Drawing.Point(3, 41);
            this.Description_Ask_Refrence.Name = "Description_Ask_Refrence";
            this.Description_Ask_Refrence.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Description_Ask_Refrence.Size = new System.Drawing.Size(850, 31);
            this.Description_Ask_Refrence.TabIndex = 4;
            //
            //Label9
            //
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label9.Location = new System.Drawing.Point(651, 8);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(138, 23);
            this.Label9.TabIndex = 215;
            this.Label9.Text = "تاریخ درخواست:";
            this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            //B_Personal_Ask_Refrence
            //
            this.B_Personal_Ask_Refrence.Image = (System.Drawing.Image)resources.GetObject("B_Personal_Ask_Refrence.Image");
            this.B_Personal_Ask_Refrence.Location = new System.Drawing.Point(3, 6);
            this.B_Personal_Ask_Refrence.Name = "B_Personal_Ask_Refrence";
            this.B_Personal_Ask_Refrence.Size = new System.Drawing.Size(29, 27);
            this.B_Personal_Ask_Refrence.TabIndex = 3;
            this.B_Personal_Ask_Refrence.UseVisualStyleBackColor = true;
            //
            //Label5
            //
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label5.Location = new System.Drawing.Point(349, 8);
            this.Label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label5.Name = "Label5";
            this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label5.Size = new System.Drawing.Size(183, 23);
            this.Label5.TabIndex = 212;
            this.Label5.Text = "درخواست کننده کالا :";
            //
            //Label3
            //
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label3.Location = new System.Drawing.Point(850, 45);
            this.Label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label3.Size = new System.Drawing.Size(204, 23);
            this.Label3.TabIndex = 210;
            this.Label3.Text = "محل مصرف و توضیحات :";
            //
            //Label1
            //
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label1.Location = new System.Drawing.Point(910, 7);
            this.Label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label1.Size = new System.Drawing.Size(145, 23);
            this.Label1.TabIndex = 209;
            this.Label1.Text = "درخواست کــالا :";
            //
            //Date_Ask_Refrence
            //
            //this.Date_Ask_Refrence.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            //this.Date_Ask_Refrence.AutoSize = true;
            //this.Date_Ask_Refrence.BackColor = System.Drawing.SystemColors.ControlLightLight;
            //this.Date_Ask_Refrence.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            //this.Date_Ask_Refrence.Location = new System.Drawing.Point(533, 4);
            //this.Date_Ask_Refrence.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            //this.Date_Ask_Refrence.Name = "Date_Ask_Refrence";
            //this.Date_Ask_Refrence.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            //this.Date_Ask_Refrence.Size = new System.Drawing.Size(136, 32);
            //this.Date_Ask_Refrence.T_D = "";
            //this.Date_Ask_Refrence.TabIndex = 1;
            //
            //TabPage2
            //
            this.TabPage2.Controls.Add(this.Description_Buy_Refrence);
            this.TabPage2.Controls.Add(this.Number_Buy_Refrence);
            this.TabPage2.Controls.Add(this.Label19);
            this.TabPage2.Controls.Add(this.Label_Date_S_Refrence);
            this.TabPage2.Controls.Add(this.Label_Number_S_Refrence);
  //          this.TabPage2.Controls.Add(this.Date_Buy_Refrence);
            this.TabPage2.Location = new System.Drawing.Point(4, 28);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(1060, 77);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "درخواست خرید";
            this.TabPage2.UseVisualStyleBackColor = true;
            //
            //Description_Buy_Refrence
            //
            this.Description_Buy_Refrence.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Description_Buy_Refrence.Location = new System.Drawing.Point(6, 41);
            this.Description_Buy_Refrence.Name = "Description_Buy_Refrence";
            this.Description_Buy_Refrence.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Description_Buy_Refrence.Size = new System.Drawing.Size(897, 31);
            this.Description_Buy_Refrence.TabIndex = 2;
            //
            //Number_Buy_Refrence
            //
            this.Number_Buy_Refrence.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Number_Buy_Refrence.Location = new System.Drawing.Point(787, 8);
            this.Number_Buy_Refrence.Name = "Number_Buy_Refrence";
            this.Number_Buy_Refrence.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Number_Buy_Refrence.Size = new System.Drawing.Size(116, 31);
            this.Number_Buy_Refrence.TabIndex = 0;
            //
            //Label19
            //
            this.Label19.AutoSize = true;
            this.Label19.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label19.Location = new System.Drawing.Point(907, 45);
            this.Label19.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label19.Name = "Label19";
            this.Label19.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label19.Size = new System.Drawing.Size(133, 23);
            this.Label19.TabIndex = 228;
            this.Label19.Text = "توضیحات خرید :";
            //
            //Label_Date_S_Refrence
            //
            this.Label_Date_S_Refrence.AutoSize = true;
            this.Label_Date_S_Refrence.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label_Date_S_Refrence.Location = new System.Drawing.Point(688, 8);
            this.Label_Date_S_Refrence.Name = "Label_Date_S_Refrence";
            this.Label_Date_S_Refrence.Size = new System.Drawing.Size(95, 23);
            this.Label_Date_S_Refrence.TabIndex = 226;
            this.Label_Date_S_Refrence.Text = "تاریخ خرید:";
            this.Label_Date_S_Refrence.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            //Label_Number_S_Refrence
            //
            this.Label_Number_S_Refrence.AutoSize = true;
            this.Label_Number_S_Refrence.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label_Number_S_Refrence.Location = new System.Drawing.Point(906, 8);
            this.Label_Number_S_Refrence.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label_Number_S_Refrence.Name = "Label_Number_S_Refrence";
            this.Label_Number_S_Refrence.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label_Number_S_Refrence.Size = new System.Drawing.Size(150, 23);
            this.Label_Number_S_Refrence.TabIndex = 224;
            this.Label_Number_S_Refrence.Text = " درخواست خرید :";
            //
            //Date_Buy_Refrence
            //
            //this.Date_Buy_Refrence.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            //this.Date_Buy_Refrence.AutoSize = true;
            //this.Date_Buy_Refrence.BackColor = System.Drawing.SystemColors.ControlLightLight;
            //this.Date_Buy_Refrence.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            //this.Date_Buy_Refrence.Location = new System.Drawing.Point(568, 7);
            //this.Date_Buy_Refrence.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            //this.Date_Buy_Refrence.Name = "Date_Buy_Refrence";
            //this.Date_Buy_Refrence.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            //this.Date_Buy_Refrence.Size = new System.Drawing.Size(136, 32);
            //this.Date_Buy_Refrence.T_D = "";
            //this.Date_Buy_Refrence.TabIndex = 1;
            //
            //TabPage3
            //
            this.TabPage3.Controls.Add(this.Description_Receipt_Refrence);
            this.TabPage3.Controls.Add(this.Stock_Receipt_Refrence);
            this.TabPage3.Controls.Add(this.Procurement_Receipt_Refrence);
            this.TabPage3.Controls.Add(this.Number_Receipt_Refrence);
            this.TabPage3.Controls.Add(this.Label8);
            this.TabPage3.Controls.Add(this.Label14);
            this.TabPage3.Controls.Add(this.B_Stock_Receipt_Refrence);
            this.TabPage3.Controls.Add(this.Label2);
            this.TabPage3.Controls.Add(this.Label11);
            this.TabPage3.Controls.Add(this.B_Procurement_Receipt_Refrence);
            this.TabPage3.Controls.Add(this.Label4);
            this.TabPage3.Controls.Add(this.Label_Number_Receipt_Refrence);
           // this.TabPage3.Controls.Add(this.Date_Receipt_Refrence);
            this.TabPage3.Location = new System.Drawing.Point(4, 28);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Size = new System.Drawing.Size(1060, 77);
            this.TabPage3.TabIndex = 2;
            this.TabPage3.Text = "رسید انبار";
            this.TabPage3.UseVisualStyleBackColor = true;
            //
            //Description_Receipt_Refrence
            //
            this.Description_Receipt_Refrence.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Description_Receipt_Refrence.Location = new System.Drawing.Point(4, 40);
            this.Description_Receipt_Refrence.Name = "Description_Receipt_Refrence";
            this.Description_Receipt_Refrence.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Description_Receipt_Refrence.Size = new System.Drawing.Size(535, 31);
            this.Description_Receipt_Refrence.TabIndex = 6;
            //
            //Stock_Receipt_Refrence
            //
            this.Stock_Receipt_Refrence.Enabled = false;
            this.Stock_Receipt_Refrence.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Stock_Receipt_Refrence.Location = new System.Drawing.Point(670, 42);
            this.Stock_Receipt_Refrence.Name = "Stock_Receipt_Refrence";
            this.Stock_Receipt_Refrence.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Stock_Receipt_Refrence.Size = new System.Drawing.Size(320, 31);
            this.Stock_Receipt_Refrence.TabIndex = 4;
            //
            //Procurement_Receipt_Refrence
            //
            this.Procurement_Receipt_Refrence.Enabled = false;
            this.Procurement_Receipt_Refrence.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Procurement_Receipt_Refrence.Location = new System.Drawing.Point(38, 3);
            this.Procurement_Receipt_Refrence.Name = "Procurement_Receipt_Refrence";
            this.Procurement_Receipt_Refrence.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Procurement_Receipt_Refrence.Size = new System.Drawing.Size(375, 31);
            this.Procurement_Receipt_Refrence.TabIndex = 2;
            //
            //Number_Receipt_Refrence
            //
            this.Number_Receipt_Refrence.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Number_Receipt_Refrence.Location = new System.Drawing.Point(845, 5);
            this.Number_Receipt_Refrence.Name = "Number_Receipt_Refrence";
            this.Number_Receipt_Refrence.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Number_Receipt_Refrence.Size = new System.Drawing.Size(108, 31);
            this.Number_Receipt_Refrence.TabIndex = 0;
            //
            //Label8
            //
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label8.Location = new System.Drawing.Point(426, 7);
            this.Label8.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label8.Name = "Label8";
            this.Label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label8.Size = new System.Drawing.Size(117, 23);
            this.Label8.TabIndex = 232;
            this.Label8.Text = "منبع تهیه کالا";
            //
            //Label14
            //
            this.Label14.AutoSize = true;
            this.Label14.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label14.Location = new System.Drawing.Point(411, 7);
            this.Label14.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label14.Name = "Label14";
            this.Label14.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label14.Size = new System.Drawing.Size(23, 23);
            this.Label14.TabIndex = 242;
            this.Label14.Text = " :";
            //
            //B_Stock_Receipt_Refrence
            //
            this.B_Stock_Receipt_Refrence.Image = (System.Drawing.Image)resources.GetObject("B_Stock_Receipt_Refrence.Image");
            this.B_Stock_Receipt_Refrence.Location = new System.Drawing.Point(636, 42);
            this.B_Stock_Receipt_Refrence.Name = "B_Stock_Receipt_Refrence";
            this.B_Stock_Receipt_Refrence.Size = new System.Drawing.Size(34, 31);
            this.B_Stock_Receipt_Refrence.TabIndex = 5;
            this.B_Stock_Receipt_Refrence.UseVisualStyleBackColor = true;
            //
            //Label2
            //
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label2.Location = new System.Drawing.Point(996, 42);
            this.Label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label2.Size = new System.Drawing.Size(53, 23);
            this.Label2.TabIndex = 240;
            this.Label2.Text = "انبار :";
            //
            //Label11
            //
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label11.Location = new System.Drawing.Point(541, 45);
            this.Label11.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label11.Name = "Label11";
            this.Label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label11.Size = new System.Drawing.Size(91, 23);
            this.Label11.TabIndex = 238;
            this.Label11.Text = "توضیحات :";
            //
            //B_Procurement_Receipt_Refrence
            //
            this.B_Procurement_Receipt_Refrence.Image = (System.Drawing.Image)resources.GetObject("B_Procurement_Receipt_Refrence.Image");
            this.B_Procurement_Receipt_Refrence.Location = new System.Drawing.Point(4, 3);
            this.B_Procurement_Receipt_Refrence.Name = "B_Procurement_Receipt_Refrence";
            this.B_Procurement_Receipt_Refrence.Size = new System.Drawing.Size(34, 31);
            this.B_Procurement_Receipt_Refrence.TabIndex = 3;
            this.B_Procurement_Receipt_Refrence.UseVisualStyleBackColor = true;
            //
            //Label4
            //
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label4.Location = new System.Drawing.Point(708, 7);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(138, 23);
            this.Label4.TabIndex = 230;
            this.Label4.Text = "تاریخ رسید انبار:";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            //Label_Number_Receipt_Refrence
            //
            this.Label_Number_Receipt_Refrence.AutoSize = true;
            this.Label_Number_Receipt_Refrence.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label_Number_Receipt_Refrence.Location = new System.Drawing.Point(949, 7);
            this.Label_Number_Receipt_Refrence.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label_Number_Receipt_Refrence.Name = "Label_Number_Receipt_Refrence";
            this.Label_Number_Receipt_Refrence.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label_Number_Receipt_Refrence.Size = new System.Drawing.Size(108, 23);
            this.Label_Number_Receipt_Refrence.TabIndex = 228;
            this.Label_Number_Receipt_Refrence.Text = " رسید انبار :";
            //
            //Date_Receipt_Refrence
            //
            //this.Date_Receipt_Refrence.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            //this.Date_Receipt_Refrence.AutoSize = true;
            //this.Date_Receipt_Refrence.BackColor = System.Drawing.SystemColors.ControlLightLight;
            //this.Date_Receipt_Refrence.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            //this.Date_Receipt_Refrence.Location = new System.Drawing.Point(593, 4);
            //this.Date_Receipt_Refrence.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            //this.Date_Receipt_Refrence.Name = "Date_Receipt_Refrence";
            //this.Date_Receipt_Refrence.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            //this.Date_Receipt_Refrence.Size = new System.Drawing.Size(136, 32);
            //this.Date_Receipt_Refrence.T_D = "";
            //this.Date_Receipt_Refrence.TabIndex = 1;
            //
            //TabPage4
            //
            this.TabPage4.Controls.Add(this.Description_Remittance_Refrence);
            this.TabPage4.Controls.Add(this.Stock_Remittance_Refrence);
            this.TabPage4.Controls.Add(this.Personal_Remittance_Refrence);
            this.TabPage4.Controls.Add(this.Number_Remittance_Refrence);
            this.TabPage4.Controls.Add(this.B_Stock_Remittance_Refrence);
            this.TabPage4.Controls.Add(this.Label12);
            this.TabPage4.Controls.Add(this.Label13);
            this.TabPage4.Controls.Add(this.B_Personal_Remittance_Refrence);
            this.TabPage4.Controls.Add(this.Label10);
            this.TabPage4.Controls.Add(this.Label6);
            this.TabPage4.Controls.Add(this.Label7);
            //this.TabPage4.Controls.Add(this.Date_Remittance_Refrence);
            this.TabPage4.Location = new System.Drawing.Point(4, 28);
            this.TabPage4.Name = "TabPage4";
            this.TabPage4.Size = new System.Drawing.Size(1060, 77);
            this.TabPage4.TabIndex = 3;
            this.TabPage4.Text = "حواله انبار";
            this.TabPage4.UseVisualStyleBackColor = true;
            //
            //Description_Remittance_Refrence
            //
            this.Description_Remittance_Refrence.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Description_Remittance_Refrence.Location = new System.Drawing.Point(5, 41);
            this.Description_Remittance_Refrence.Name = "Description_Remittance_Refrence";
            this.Description_Remittance_Refrence.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Description_Remittance_Refrence.Size = new System.Drawing.Size(537, 31);
            this.Description_Remittance_Refrence.TabIndex = 6;
            //
            //Stock_Remittance_Refrence
            //
            this.Stock_Remittance_Refrence.Enabled = false;
            this.Stock_Remittance_Refrence.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Stock_Remittance_Refrence.Location = new System.Drawing.Point(668, 41);
            this.Stock_Remittance_Refrence.Name = "Stock_Remittance_Refrence";
            this.Stock_Remittance_Refrence.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Stock_Remittance_Refrence.Size = new System.Drawing.Size(328, 31);
            this.Stock_Remittance_Refrence.TabIndex = 4;
            //
            //Personal_Remittance_Refrence
            //
            this.Personal_Remittance_Refrence.Enabled = false;
            this.Personal_Remittance_Refrence.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Personal_Remittance_Refrence.Location = new System.Drawing.Point(37, 4);
            this.Personal_Remittance_Refrence.Name = "Personal_Remittance_Refrence";
            this.Personal_Remittance_Refrence.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Personal_Remittance_Refrence.Size = new System.Drawing.Size(382, 31);
            this.Personal_Remittance_Refrence.TabIndex = 2;
            //
            //Number_Remittance_Refrence
            //
            this.Number_Remittance_Refrence.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Number_Remittance_Refrence.Location = new System.Drawing.Point(824, 4);
            this.Number_Remittance_Refrence.Name = "Number_Remittance_Refrence";
            this.Number_Remittance_Refrence.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Number_Remittance_Refrence.Size = new System.Drawing.Size(131, 31);
            this.Number_Remittance_Refrence.TabIndex = 0;
            //
            //B_Stock_Remittance_Refrence
            //
            this.B_Stock_Remittance_Refrence.Image = (System.Drawing.Image)resources.GetObject("B_Stock_Remittance_Refrence.Image");
            this.B_Stock_Remittance_Refrence.Location = new System.Drawing.Point(634, 42);
            this.B_Stock_Remittance_Refrence.Name = "B_Stock_Remittance_Refrence";
            this.B_Stock_Remittance_Refrence.Size = new System.Drawing.Size(34, 31);
            this.B_Stock_Remittance_Refrence.TabIndex = 5;
            this.B_Stock_Remittance_Refrence.UseVisualStyleBackColor = true;
            //
            //Label12
            //
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label12.Location = new System.Drawing.Point(994, 42);
            this.Label12.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label12.Name = "Label12";
            this.Label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label12.Size = new System.Drawing.Size(53, 23);
            this.Label12.TabIndex = 245;
            this.Label12.Text = "انبار :";
            //
            //Label13
            //
            this.Label13.AutoSize = true;
            this.Label13.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label13.Location = new System.Drawing.Point(542, 45);
            this.Label13.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label13.Name = "Label13";
            this.Label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label13.Size = new System.Drawing.Size(91, 23);
            this.Label13.TabIndex = 243;
            this.Label13.Text = "توضیحات :";
            //
            //B_Personal_Remittance_Refrence
            //
            this.B_Personal_Remittance_Refrence.Image = (System.Drawing.Image)resources.GetObject("B_Personal_Remittance_Refrence.Image");
            this.B_Personal_Remittance_Refrence.Location = new System.Drawing.Point(3, 3);
            this.B_Personal_Remittance_Refrence.Name = "B_Personal_Remittance_Refrence";
            this.B_Personal_Remittance_Refrence.Size = new System.Drawing.Size(34, 31);
            this.B_Personal_Remittance_Refrence.TabIndex = 3;
            this.B_Personal_Remittance_Refrence.UseVisualStyleBackColor = true;
            //
            //Label10
            //
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label10.Location = new System.Drawing.Point(420, 7);
            this.Label10.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label10.Name = "Label10";
            this.Label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label10.Size = new System.Drawing.Size(155, 23);
            this.Label10.TabIndex = 236;
            this.Label10.Text = "تحویل گیرنده کالا :";
            //
            //Label6
            //
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label6.Location = new System.Drawing.Point(687, 6);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(137, 23);
            this.Label6.TabIndex = 234;
            this.Label6.Text = "تاریخ حواله انبار:";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            //Label7
            //
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label7.Location = new System.Drawing.Point(954, 6);
            this.Label7.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label7.Name = "Label7";
            this.Label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label7.Size = new System.Drawing.Size(107, 23);
            this.Label7.TabIndex = 232;
            this.Label7.Text = " حواله انبار :";
            //
            //Date_Remittance_Refrence
            //
            //this.Date_Remittance_Refrence.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            //this.Date_Remittance_Refrence.AutoSize = true;
            //this.Date_Remittance_Refrence.BackColor = System.Drawing.SystemColors.ControlLightLight;
            //this.Date_Remittance_Refrence.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            //this.Date_Remittance_Refrence.Location = new System.Drawing.Point(577, 6);
            //this.Date_Remittance_Refrence.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            //this.Date_Remittance_Refrence.Name = "Date_Remittance_Refrence";
            //this.Date_Remittance_Refrence.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            //this.Date_Remittance_Refrence.Size = new System.Drawing.Size(136, 32);
            //this.Date_Remittance_Refrence.T_D = "";
            //this.Date_Remittance_Refrence.TabIndex = 1;
            //
            //TabPage5
            //
            this.TabPage5.Controls.Add(this.Stock_Ta_Refrence);
            this.TabPage5.Controls.Add(this.Stock_Az_Refrence);
            this.TabPage5.Controls.Add(this.Label18);
            this.TabPage5.Controls.Add(this.Label17);
            this.TabPage5.Controls.Add(this.Button2);
            this.TabPage5.Controls.Add(this.Label16);
            this.TabPage5.Controls.Add(this.Button1);
            this.TabPage5.Controls.Add(this.Label15);
            //this.TabPage5.Controls.Add(this.Date_Ta_Refrence);
            //this.TabPage5.Controls.Add(this.Date_Az_Refrence);
            this.TabPage5.Location = new System.Drawing.Point(4, 28);
            this.TabPage5.Name = "TabPage5";
            this.TabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage5.Size = new System.Drawing.Size(1060, 77);
            this.TabPage5.TabIndex = 4;
            this.TabPage5.Text = "گزارش";
            this.TabPage5.UseVisualStyleBackColor = true;
            //
            //Stock_Ta_Refrence
            //
            this.Stock_Ta_Refrence.Enabled = false;
            this.Stock_Ta_Refrence.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Stock_Ta_Refrence.Location = new System.Drawing.Point(463, 42);
            this.Stock_Ta_Refrence.Name = "Stock_Ta_Refrence";
            this.Stock_Ta_Refrence.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Stock_Ta_Refrence.Size = new System.Drawing.Size(328, 31);
            this.Stock_Ta_Refrence.TabIndex = 4;
            //
            //Stock_Az_Refrence
            //
            this.Stock_Az_Refrence.Enabled = false;
            this.Stock_Az_Refrence.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Stock_Az_Refrence.Location = new System.Drawing.Point(462, 8);
            this.Stock_Az_Refrence.Name = "Stock_Az_Refrence";
            this.Stock_Az_Refrence.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Stock_Az_Refrence.Size = new System.Drawing.Size(328, 31);
            this.Stock_Az_Refrence.TabIndex = 1;
            //
            //Label18
            //
            this.Label18.AutoSize = true;
            this.Label18.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label18.Location = new System.Drawing.Point(980, 46);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(76, 23);
            this.Label18.TabIndex = 251;
            this.Label18.Text = "تا تاریخ :";
            this.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            //Label17
            //
            this.Label17.AutoSize = true;
            this.Label17.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label17.Location = new System.Drawing.Point(980, 11);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(77, 23);
            this.Label17.TabIndex = 249;
            this.Label17.Text = "از تاریخ :";
            this.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            //Button2
            //
            this.Button2.Image = (System.Drawing.Image)resources.GetObject("Button2.Image");
            this.Button2.Location = new System.Drawing.Point(429, 42);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(34, 31);
            this.Button2.TabIndex = 5;
            this.Button2.UseVisualStyleBackColor = true;
            //
            //Label16
            //
            this.Label16.AutoSize = true;
            this.Label16.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label16.Location = new System.Drawing.Point(789, 44);
            this.Label16.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label16.Name = "Label16";
            this.Label16.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label16.Size = new System.Drawing.Size(70, 23);
            this.Label16.TabIndex = 246;
            this.Label16.Text = "تا انبار :";
            //
            //Button1
            //
            this.Button1.Image = (System.Drawing.Image)resources.GetObject("Button1.Image");
            this.Button1.Location = new System.Drawing.Point(428, 8);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(34, 31);
            this.Button1.TabIndex = 2;
            this.Button1.UseVisualStyleBackColor = true;
            //
            //Label15
            //
            this.Label15.AutoSize = true;
            this.Label15.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label15.Location = new System.Drawing.Point(788, 10);
            this.Label15.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label15.Name = "Label15";
            this.Label15.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label15.Size = new System.Drawing.Size(71, 23);
            this.Label15.TabIndex = 243;
            this.Label15.Text = "از انبار :";
            //
            //Date_Ta_Refrence
            //
            //this.Date_Ta_Refrence.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            //this.Date_Ta_Refrence.AutoSize = true;
            //this.Date_Ta_Refrence.BackColor = System.Drawing.SystemColors.ControlLightLight;
            //this.Date_Ta_Refrence.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            //this.Date_Ta_Refrence.Location = new System.Drawing.Point(865, 43);
            //this.Date_Ta_Refrence.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            //this.Date_Ta_Refrence.Name = "Date_Ta_Refrence";
            //this.Date_Ta_Refrence.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            //this.Date_Ta_Refrence.Size = new System.Drawing.Size(136, 32);
            //this.Date_Ta_Refrence.T_D = "";
            //this.Date_Ta_Refrence.TabIndex = 3;
            //
            //Date_Az_Refrence
            //
            //this.Date_Az_Refrence.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            //this.Date_Az_Refrence.AutoSize = true;
            //this.Date_Az_Refrence.BackColor = System.Drawing.SystemColors.ControlLightLight;
            //this.Date_Az_Refrence.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            //this.Date_Az_Refrence.Location = new System.Drawing.Point(865, 8);
            //this.Date_Az_Refrence.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            //this.Date_Az_Refrence.Name = "Date_Az_Refrence";
            //this.Date_Az_Refrence.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            //this.Date_Az_Refrence.Size = new System.Drawing.Size(136, 32);
            //this.Date_Az_Refrence.T_D = "";
            //this.Date_Az_Refrence.TabIndex = 0;
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
            this.SplitContainer2.Panel1.Controls.Add(this.DV);
            this.SplitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            //
            //SplitContainer2.Panel2
            //
            this.SplitContainer2.Panel2.Controls.Add(this.Dv_Goods);
            this.SplitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SplitContainer2.Size = new System.Drawing.Size(1071, 391);
            this.SplitContainer2.SplitterDistance = 98;
            this.SplitContainer2.TabIndex = 4;
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
            this.DV.Size = new System.Drawing.Size(1071, 98);
            this.DV.TabIndex = 0;
            //
            //Dv_Goods
            //
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            DataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dv_Goods.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3;
            this.Dv_Goods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            DataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dv_Goods.DefaultCellStyle = DataGridViewCellStyle4;
            this.Dv_Goods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dv_Goods.Location = new System.Drawing.Point(0, 0);
            this.Dv_Goods.Name = "Dv_Goods";
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            DataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dv_Goods.RowHeadersDefaultCellStyle = DataGridViewCellStyle5;
            this.Dv_Goods.Size = new System.Drawing.Size(1071, 289);
            this.Dv_Goods.TabIndex = 0;
            //
            //ST_Request_Goods
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(12.0F, 25.0F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1071, 532);
            this.Controls.Add(this.SplitContainer1);
            this.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.Name = "ST_Request_Goods";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "درخواست کالا از انبار";
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
            this.TabPage2.PerformLayout();
            this.TabPage3.ResumeLayout(false);
            this.TabPage3.PerformLayout();
            this.TabPage4.ResumeLayout(false);
            this.TabPage4.PerformLayout();
            this.TabPage5.ResumeLayout(false);
            this.TabPage5.PerformLayout();
            this.SplitContainer2.Panel1.ResumeLayout(false);
            this.SplitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.SplitContainer2).EndInit();
            this.SplitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.DV).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.Dv_Goods).EndInit();
            this.ResumeLayout(false);

        }
        internal System.Windows.Forms.SplitContainer SplitContainer1;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton Edit_B;
        internal System.Windows.Forms.ToolStripButton Delet_B;
        internal System.Windows.Forms.ToolStripButton Save_B;
        internal System.Windows.Forms.ToolStripButton Search_B;
        internal System.Windows.Forms.ToolStripButton Chap;
        internal System.Windows.Forms.ToolStripButton Abort_B;
        internal System.Windows.Forms.SplitContainer SplitContainer2;
        internal System.Windows.Forms.DataGridView DV;
        internal System.Windows.Forms.TabControl TabControl1;
        internal System.Windows.Forms.TabPage TabPage1;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Button B_Personal_Ask_Refrence;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label1;
        //internal Ansaripour.Rtl_Date Date_Ask_Refrence;
        internal System.Windows.Forms.TabPage TabPage2;
        internal System.Windows.Forms.Label Label_Date_S_Refrence;
        internal System.Windows.Forms.Label Label_Number_S_Refrence;
        //internal Ansaripour.Rtl_Date Date_Buy_Refrence;
        internal System.Windows.Forms.TabPage TabPage3;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label_Number_Receipt_Refrence;
        //internal Ansaripour.Rtl_Date Date_Receipt_Refrence;
        internal System.Windows.Forms.TabPage TabPage4;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label7;
        //internal Ansaripour.Rtl_Date Date_Remittance_Refrence;
        internal System.Windows.Forms.ToolStripDropDownButton B_Product;
        internal System.Windows.Forms.ToolStripMenuItem B_Ask_goods;
        internal System.Windows.Forms.ToolStripMenuItem B_purchase_request;
        internal System.Windows.Forms.ToolStripMenuItem B_warehouse_receipt;
        internal System.Windows.Forms.ToolStripMenuItem B_Anbar_order;
        internal System.Windows.Forms.ToolStripMenuItem B_Opening;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Button B_Procurement_Receipt_Refrence;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Button B_Stock_Receipt_Refrence;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.ToolStripButton B_Picture;
        internal System.Windows.Forms.ToolStripButton B_Excel;
        internal System.Windows.Forms.Button B_Stock_Remittance_Refrence;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Button B_Personal_Remittance_Refrence;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label14;
        internal Ansaripour.MyDataGridView Dv_Goods;
        internal System.Windows.Forms.TabPage TabPage5;
        internal System.Windows.Forms.Label Label18;
        //internal Ansaripour.Rtl_Date Date_Ta_Refrence;
        internal System.Windows.Forms.Label Label17;
        //internal Ansaripour.Rtl_Date Date_Az_Refrence;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.Label Label19;
        internal System.Windows.Forms.TextBox Personal_Ask_Refrence;
        internal System.Windows.Forms.TextBox Number_Ask_Refrence;
        internal System.Windows.Forms.TextBox Description_Ask_Refrence;
        internal System.Windows.Forms.TextBox Description_Buy_Refrence;
        internal System.Windows.Forms.TextBox Number_Buy_Refrence;
        internal System.Windows.Forms.TextBox Description_Receipt_Refrence;
        internal System.Windows.Forms.TextBox Stock_Receipt_Refrence;
        internal System.Windows.Forms.TextBox Procurement_Receipt_Refrence;
        internal System.Windows.Forms.TextBox Number_Receipt_Refrence;
        internal System.Windows.Forms.TextBox Description_Remittance_Refrence;
        internal System.Windows.Forms.TextBox Stock_Remittance_Refrence;
        internal System.Windows.Forms.TextBox Personal_Remittance_Refrence;
        internal System.Windows.Forms.TextBox Number_Remittance_Refrence;
        internal System.Windows.Forms.TextBox Stock_Ta_Refrence;
        internal System.Windows.Forms.TextBox Stock_Az_Refrence;
    }
}

