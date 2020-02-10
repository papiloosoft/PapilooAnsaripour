using System.IO;
using System.Net;
using System.Text;
using System.Web;
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
    public partial class Warranty_Document : System.Windows.Forms.Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Warranty_Document));
            System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Label18 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label16 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            //this.Warranty_Document_Date = new Ansaripour.Rtl_Date();
            //this.Warranty_Document_Extended_Date = new Ansaripour.Rtl_Date();
            //this.Warranty_Document_Due_Date = new Ansaripour.Rtl_Date();
            //this.Warranty_Document_Refund_Date = new Ansaripour.Rtl_Date();
            //this.Warranty_Document_Contract_Date = new Ansaripour.Rtl_Date();
            this.Label20 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.B_Warranty_Document_Subscription = new System.Windows.Forms.Button();
            this.Warranty_Document_Operation = new System.Windows.Forms.ComboBox();
            this.Label17 = new System.Windows.Forms.Label();
            this.L_Mab = new System.Windows.Forms.TextBox();
            this.Warranty_Document_Subscription = new System.Windows.Forms.TextBox();
            this.Warranty_Document_Description = new System.Windows.Forms.TextBox();
            this.Warranty_Document_Case = new System.Windows.Forms.ComboBox();
            this.Warranty_Document_Bank = new System.Windows.Forms.TextBox();
            this.Label13 = new System.Windows.Forms.Label();
            this.Warranty_Document_Amount = new System.Windows.Forms.TextBox();
            this.Warranty_Document_Account_Number = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.Warranty_Document_No_Check = new System.Windows.Forms.TextBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.Warranty_Document_Branch = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Warranty_Document_Contract_Number = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Warranty_Document_Number = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.B_Product = new System.Windows.Forms.ToolStripDropDownButton();
            this.B_New = new System.Windows.Forms.ToolStripMenuItem();
            this.B_Old = new System.Windows.Forms.ToolStripMenuItem();
            this.B_Extension = new System.Windows.Forms.ToolStripMenuItem();
            this.B_Refund = new System.Windows.Forms.ToolStripMenuItem();
            this.Delet_B = new System.Windows.Forms.ToolStripButton();
            this.Edit_B = new System.Windows.Forms.ToolStripButton();
            this.Search_B = new System.Windows.Forms.ToolStripButton();
            this.Save_B = new System.Windows.Forms.ToolStripButton();
            this.B_Excel = new System.Windows.Forms.ToolStripButton();
            this.Print = new System.Windows.Forms.ToolStripDropDownButton();
            this.Details_Print = new System.Windows.Forms.ToolStripMenuItem();
            this.Short_Print = new System.Windows.Forms.ToolStripMenuItem();
            this.Log_File = new System.Windows.Forms.ToolStripButton();
            this.B_Picture = new System.Windows.Forms.ToolStripButton();
            this.Abort_B = new System.Windows.Forms.ToolStripButton();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Az_Ta = new System.Windows.Forms.Label();
            this.Label19 = new System.Windows.Forms.Label();
            //this.Warranty_Document_From_Date = new Ansaripour.Rtl_Date();
            //this.Warranty_Document_Until_Date = new Ansaripour.Rtl_Date();
            //this.Warranty_Document_No_Date = new Ansaripour.Rtl_Date();
            this.DV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)this.SplitContainer1).BeginInit();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            this.ToolStrip.SuspendLayout();
            this.GroupBox1.SuspendLayout();
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
            this.SplitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SplitContainer1.Panel1.Controls.Add(this.Label18);
            this.SplitContainer1.Panel1.Controls.Add(this.Label7);
            this.SplitContainer1.Panel1.Controls.Add(this.Label16);
            this.SplitContainer1.Panel1.Controls.Add(this.Label3);
            this.SplitContainer1.Panel1.Controls.Add(this.Label6);
//            this.SplitContainer1.Panel1.Controls.Add(this.Warranty_Document_Date);
//            this.SplitContainer1.Panel1.Controls.Add(this.Warranty_Document_Extended_Date);
  //          this.SplitContainer1.Panel1.Controls.Add(this.Warranty_Document_Due_Date);
    //        this.SplitContainer1.Panel1.Controls.Add(this.Warranty_Document_Refund_Date);
      //      this.SplitContainer1.Panel1.Controls.Add(this.Warranty_Document_Contract_Date);
            this.SplitContainer1.Panel1.Controls.Add(this.Label20);
            this.SplitContainer1.Panel1.Controls.Add(this.Label2);
            this.SplitContainer1.Panel1.Controls.Add(this.B_Warranty_Document_Subscription);
            this.SplitContainer1.Panel1.Controls.Add(this.Warranty_Document_Operation);
            this.SplitContainer1.Panel1.Controls.Add(this.Label17);
            this.SplitContainer1.Panel1.Controls.Add(this.L_Mab);
            this.SplitContainer1.Panel1.Controls.Add(this.Warranty_Document_Subscription);
            this.SplitContainer1.Panel1.Controls.Add(this.Warranty_Document_Description);
            this.SplitContainer1.Panel1.Controls.Add(this.Warranty_Document_Case);
            this.SplitContainer1.Panel1.Controls.Add(this.Warranty_Document_Bank);
            this.SplitContainer1.Panel1.Controls.Add(this.Label13);
            this.SplitContainer1.Panel1.Controls.Add(this.Warranty_Document_Amount);
            this.SplitContainer1.Panel1.Controls.Add(this.Warranty_Document_Account_Number);
            this.SplitContainer1.Panel1.Controls.Add(this.Label10);
            this.SplitContainer1.Panel1.Controls.Add(this.Warranty_Document_No_Check);
            this.SplitContainer1.Panel1.Controls.Add(this.Label12);
            this.SplitContainer1.Panel1.Controls.Add(this.Warranty_Document_Branch);
            this.SplitContainer1.Panel1.Controls.Add(this.Label5);
            this.SplitContainer1.Panel1.Controls.Add(this.Warranty_Document_Contract_Number);
            this.SplitContainer1.Panel1.Controls.Add(this.Label4);
            this.SplitContainer1.Panel1.Controls.Add(this.Warranty_Document_Number);
            this.SplitContainer1.Panel1.Controls.Add(this.Label1);
            this.SplitContainer1.Panel1.Controls.Add(this.Label14);
            this.SplitContainer1.Panel1.Controls.Add(this.ToolStrip);
            this.SplitContainer1.Panel1.Controls.Add(this.Label9);
            this.SplitContainer1.Panel1.Controls.Add(this.Label15);
            this.SplitContainer1.Panel1.Controls.Add(this.Label11);
            this.SplitContainer1.Panel1.Controls.Add(this.Label8);
            this.SplitContainer1.Panel1.Controls.Add(this.GroupBox1);
//            this.SplitContainer1.Panel1.Controls.Add(this.Warranty_Document_No_Date);
            this.SplitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            //
            //SplitContainer1.Panel2
            //
            this.SplitContainer1.Panel2.Controls.Add(this.DV);
            this.SplitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SplitContainer1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SplitContainer1.Size = new System.Drawing.Size(1252, 534);
            this.SplitContainer1.SplitterDistance = 285;
            this.SplitContainer1.SplitterWidth = 5;
            this.SplitContainer1.TabIndex = 0;
            //
            //Label18
            //
            this.Label18.AutoSize = true;
            this.Label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label18.Location = new System.Drawing.Point(359, 112);
            this.Label18.Name = "Label18";
            this.Label18.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label18.Size = new System.Drawing.Size(113, 25);
            this.Label18.TabIndex = 244;
            this.Label18.Text = "تاریخ تـمـدیـد :";
            //
            //Label7
            //
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label7.Location = new System.Drawing.Point(359, 75);
            this.Label7.Name = "Label7";
            this.Label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label7.Size = new System.Drawing.Size(133, 25);
            this.Label7.TabIndex = 198;
            this.Label7.Text = "تاریخ ضمانتنامه :";
            //
            //Label16
            //
            this.Label16.AutoSize = true;
            this.Label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label16.Location = new System.Drawing.Point(121, 112);
            this.Label16.Name = "Label16";
            this.Label16.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label16.Size = new System.Drawing.Size(112, 25);
            this.Label16.TabIndex = 241;
            this.Label16.Text = "تاریخ استرداد:";
            //
            //Label3
            //
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label3.Location = new System.Drawing.Point(121, 75);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label3.Size = new System.Drawing.Size(123, 25);
            this.Label3.TabIndex = 195;
            this.Label3.Text = "تاریـخ سررسید:";
            //
            //Label6
            //
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label6.Location = new System.Drawing.Point(601, 112);
            this.Label6.Name = "Label6";
            this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label6.Size = new System.Drawing.Size(116, 25);
            this.Label6.TabIndex = 199;
            this.Label6.Text = "تاریخ قرارداد :";
            //
            //Warranty_Document_Date
            //
//            this.Warranty_Document_Date.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
//            this.Warranty_Document_Date.AutoSize = true;
//            this.Warranty_Document_Date.BackColor = System.Drawing.SystemColors.ControlLightLight;
            //this.Warranty_Document_Date.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            //this.Warranty_Document_Date.Location = new System.Drawing.Point(253, 75);
            //this.Warranty_Document_Date.Name = "Warranty_Document_Date";
            //this.Warranty_Document_Date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            //this.Warranty_Document_Date.Size = new System.Drawing.Size(121, 32);
            //this.Warranty_Document_Date.T_D = "";
            //this.Warranty_Document_Date.TabIndex = 5;
            //
            //Warranty_Document_Extended_Date
            //
            //this.Warranty_Document_Extended_Date.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            //this.Warranty_Document_Extended_Date.AutoSize = true;
            //this.Warranty_Document_Extended_Date.BackColor = System.Drawing.SystemColors.ControlLightLight;
            //this.Warranty_Document_Extended_Date.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            //this.Warranty_Document_Extended_Date.Location = new System.Drawing.Point(252, 110);
            //this.Warranty_Document_Extended_Date.Name = "Warranty_Document_Extended_Date";
            //this.Warranty_Document_Extended_Date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            //this.Warranty_Document_Extended_Date.Size = new System.Drawing.Size(121, 32);
            //this.Warranty_Document_Extended_Date.T_D = "";
            //this.Warranty_Document_Extended_Date.TabIndex = 9;
            //
            //Warranty_Document_Due_Date
            //
            //this.Warranty_Document_Due_Date.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            //this.Warranty_Document_Due_Date.AutoSize = true;
            //this.Warranty_Document_Due_Date.BackColor = System.Drawing.SystemColors.ControlLightLight;
            //this.Warranty_Document_Due_Date.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            //this.Warranty_Document_Due_Date.Location = new System.Drawing.Point(14, 75);
            //this.Warranty_Document_Due_Date.Name = "Warranty_Document_Due_Date";
            //this.Warranty_Document_Due_Date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            //this.Warranty_Document_Due_Date.Size = new System.Drawing.Size(121, 32);
            //this.Warranty_Document_Due_Date.T_D = "";
            //this.Warranty_Document_Due_Date.TabIndex = 6;
            //
            //Warranty_Document_Refund_Date
            //
            //this.Warranty_Document_Refund_Date.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            //this.Warranty_Document_Refund_Date.AutoSize = true;
            //this.Warranty_Document_Refund_Date.BackColor = System.Drawing.SystemColors.ControlLightLight;
            //this.Warranty_Document_Refund_Date.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            //this.Warranty_Document_Refund_Date.Location = new System.Drawing.Point(14, 110);
            //this.Warranty_Document_Refund_Date.Name = "Warranty_Document_Refund_Date";
            //this.Warranty_Document_Refund_Date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            //this.Warranty_Document_Refund_Date.Size = new System.Drawing.Size(121, 32);
            //this.Warranty_Document_Refund_Date.T_D = "";
            //this.Warranty_Document_Refund_Date.TabIndex = 10;
            //
            //Warranty_Document_Contract_Date
            //
            //this.Warranty_Document_Contract_Date.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            //this.Warranty_Document_Contract_Date.AutoSize = true;
            //this.Warranty_Document_Contract_Date.BackColor = System.Drawing.SystemColors.ControlLightLight;
            //this.Warranty_Document_Contract_Date.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            //this.Warranty_Document_Contract_Date.Location = new System.Drawing.Point(497, 110);
            //this.Warranty_Document_Contract_Date.Name = "Warranty_Document_Contract_Date";
            //this.Warranty_Document_Contract_Date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            //this.Warranty_Document_Contract_Date.Size = new System.Drawing.Size(121, 32);
            //this.Warranty_Document_Contract_Date.T_D = "";
            //this.Warranty_Document_Contract_Date.TabIndex = 8;
            //
            //Label20
            //
            this.Label20.AutoSize = true;
            this.Label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label20.ForeColor = System.Drawing.Color.Red;
            this.Label20.Location = new System.Drawing.Point(12, 185);
            this.Label20.Name = "Label20";
            this.Label20.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label20.Size = new System.Drawing.Size(43, 25);
            this.Label20.TabIndex = 256;
            this.Label20.Text = "ریال";
            //
            //Label2
            //
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label2.Location = new System.Drawing.Point(1118, 76);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label2.Size = new System.Drawing.Size(111, 25);
            this.Label2.TabIndex = 255;
            this.Label2.Text = "تاریخ ثــبــت :";
            //
            //B_Warranty_Document_Subscription
            //
            this.B_Warranty_Document_Subscription.Image = (System.Drawing.Image)resources.GetObject("B_Warranty_Document_Subscription.Image");
            this.B_Warranty_Document_Subscription.Location = new System.Drawing.Point(731, 36);
            this.B_Warranty_Document_Subscription.Name = "B_Warranty_Document_Subscription";
            this.B_Warranty_Document_Subscription.Size = new System.Drawing.Size(29, 27);
            this.B_Warranty_Document_Subscription.TabIndex = 1;
            this.B_Warranty_Document_Subscription.UseVisualStyleBackColor = true;
            //
            //Warranty_Document_Operation
            //
            this.Warranty_Document_Operation.Enabled = false;
            this.Warranty_Document_Operation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Warranty_Document_Operation.FormattingEnabled = true;
            this.Warranty_Document_Operation.Items.AddRange(new object[] { "ثــــبــــت انتظامی", "تــــمـدیـد انتظامی", "اســتـرداد انتظامی" });
            this.Warranty_Document_Operation.Location = new System.Drawing.Point(14, 35);
            this.Warranty_Document_Operation.Name = "Warranty_Document_Operation";
            this.Warranty_Document_Operation.Size = new System.Drawing.Size(209, 28);
            this.Warranty_Document_Operation.TabIndex = 2;
            //
            //Label17
            //
            this.Label17.AutoSize = true;
            this.Label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label17.Location = new System.Drawing.Point(223, 35);
            this.Label17.Name = "Label17";
            this.Label17.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label17.Size = new System.Drawing.Size(73, 25);
            this.Label17.TabIndex = 242;
            this.Label17.Text = "عملیات :";
            //
            //L_Mab
            //
            this.L_Mab.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.L_Mab.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.L_Mab.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.L_Mab.ForeColor = System.Drawing.Color.Red;
            this.L_Mab.Location = new System.Drawing.Point(14, 219);
            this.L_Mab.Name = "L_Mab";
            this.L_Mab.ReadOnly = true;
            this.L_Mab.Size = new System.Drawing.Size(1116, 24);
            this.L_Mab.TabIndex = 211;
            //
            //Warranty_Document_Subscription
            //
            this.Warranty_Document_Subscription.Enabled = false;
            this.Warranty_Document_Subscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Warranty_Document_Subscription.Location = new System.Drawing.Point(763, 33);
            this.Warranty_Document_Subscription.Name = "Warranty_Document_Subscription";
            this.Warranty_Document_Subscription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Warranty_Document_Subscription.Size = new System.Drawing.Size(346, 31);
            this.Warranty_Document_Subscription.TabIndex = 0;
            //
            //Warranty_Document_Description
            //
            this.Warranty_Document_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Warranty_Document_Description.Location = new System.Drawing.Point(12, 252);
            this.Warranty_Document_Description.Name = "Warranty_Document_Description";
            this.Warranty_Document_Description.Size = new System.Drawing.Size(1133, 31);
            this.Warranty_Document_Description.TabIndex = 18;
            //
            //Warranty_Document_Case
            //
            this.Warranty_Document_Case.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Warranty_Document_Case.FormattingEnabled = true;
            this.Warranty_Document_Case.Location = new System.Drawing.Point(771, 144);
            this.Warranty_Document_Case.Name = "Warranty_Document_Case";
            this.Warranty_Document_Case.Size = new System.Drawing.Size(338, 28);
            this.Warranty_Document_Case.TabIndex = 11;
            //
            //Warranty_Document_Bank
            //
            this.Warranty_Document_Bank.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Warranty_Document_Bank.Location = new System.Drawing.Point(918, 179);
            this.Warranty_Document_Bank.Name = "Warranty_Document_Bank";
            this.Warranty_Document_Bank.Size = new System.Drawing.Size(268, 31);
            this.Warranty_Document_Bank.TabIndex = 15;
            //
            //Label13
            //
            this.Label13.AutoSize = true;
            this.Label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label13.Location = new System.Drawing.Point(1184, 181);
            this.Label13.Name = "Label13";
            this.Label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label13.Size = new System.Drawing.Size(51, 25);
            this.Label13.TabIndex = 206;
            this.Label13.Text = "بانک :";
            //
            //Warranty_Document_Amount
            //
            this.Warranty_Document_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Warranty_Document_Amount.Location = new System.Drawing.Point(61, 182);
            this.Warranty_Document_Amount.Name = "Warranty_Document_Amount";
            this.Warranty_Document_Amount.Size = new System.Drawing.Size(371, 31);
            this.Warranty_Document_Amount.TabIndex = 17;
            //
            //Warranty_Document_Account_Number
            //
            this.Warranty_Document_Account_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Warranty_Document_Account_Number.Location = new System.Drawing.Point(14, 145);
            this.Warranty_Document_Account_Number.Name = "Warranty_Document_Account_Number";
            this.Warranty_Document_Account_Number.Size = new System.Drawing.Size(240, 31);
            this.Warranty_Document_Account_Number.TabIndex = 14;
            //
            //Label10
            //
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label10.Location = new System.Drawing.Point(639, 145);
            this.Label10.Name = "Label10";
            this.Label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label10.Size = new System.Drawing.Size(131, 25);
            this.Label10.TabIndex = 201;
            this.Label10.Text = "شـمــاره چــــک :";
            //
            //Warranty_Document_No_Check
            //
            this.Warranty_Document_No_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Warranty_Document_No_Check.Location = new System.Drawing.Point(374, 144);
            this.Warranty_Document_No_Check.Name = "Warranty_Document_No_Check";
            this.Warranty_Document_No_Check.Size = new System.Drawing.Size(262, 31);
            this.Warranty_Document_No_Check.TabIndex = 12;
            //
            //Label12
            //
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label12.Location = new System.Drawing.Point(858, 182);
            this.Label12.Name = "Label12";
            this.Label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label12.Size = new System.Drawing.Size(58, 25);
            this.Label12.TabIndex = 200;
            this.Label12.Text = "شعبه :";
            //
            //Warranty_Document_Branch
            //
            this.Warranty_Document_Branch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Warranty_Document_Branch.Location = new System.Drawing.Point(529, 179);
            this.Warranty_Document_Branch.Name = "Warranty_Document_Branch";
            this.Warranty_Document_Branch.Size = new System.Drawing.Size(327, 31);
            this.Warranty_Document_Branch.TabIndex = 16;
            //
            //Label5
            //
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label5.Location = new System.Drawing.Point(1115, 113);
            this.Label5.Name = "Label5";
            this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label5.Size = new System.Drawing.Size(128, 25);
            this.Label5.TabIndex = 197;
            this.Label5.Text = "شـماره قرارداد :";
            //
            //Warranty_Document_Contract_Number
            //
            this.Warranty_Document_Contract_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Warranty_Document_Contract_Number.Location = new System.Drawing.Point(772, 110);
            this.Warranty_Document_Contract_Number.Name = "Warranty_Document_Contract_Number";
            this.Warranty_Document_Contract_Number.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Warranty_Document_Contract_Number.Size = new System.Drawing.Size(337, 31);
            this.Warranty_Document_Contract_Number.TabIndex = 7;
            //
            //Label4
            //
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label4.Location = new System.Drawing.Point(849, 76);
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label4.Size = new System.Drawing.Size(145, 25);
            this.Label4.TabIndex = 196;
            this.Label4.Text = "شـماره ضمانتنامه :";
            //
            //Warranty_Document_Number
            //
            this.Warranty_Document_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Warranty_Document_Number.Location = new System.Drawing.Point(497, 75);
            this.Warranty_Document_Number.Name = "Warranty_Document_Number";
            this.Warranty_Document_Number.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Warranty_Document_Number.Size = new System.Drawing.Size(348, 31);
            this.Warranty_Document_Number.TabIndex = 4;
            //
            //Label1
            //
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label1.Location = new System.Drawing.Point(1117, 36);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label1.Size = new System.Drawing.Size(123, 25);
            this.Label1.TabIndex = 192;
            this.Label1.Text = "کـــد مـشـتـرک :";
            //
            //Label14
            //
            this.Label14.AutoSize = true;
            this.Label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label14.Location = new System.Drawing.Point(1115, 145);
            this.Label14.Name = "Label14";
            this.Label14.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label14.Size = new System.Drawing.Size(132, 25);
            this.Label14.TabIndex = 207;
            this.Label14.Text = "نوع ضمانت نامه:";
            //
            //ToolStrip
            //
            this.ToolStrip.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.B_Product, this.Delet_B, this.Edit_B, this.Search_B, this.Save_B, this.B_Excel, this.Print, this.Log_File, this.B_Picture, this.Abort_B });
            this.ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(1252, 26);
            this.ToolStrip.TabIndex = 0;
            this.ToolStrip.Text = "ToolStrip1";
            //
            //B_Product
            //
            this.B_Product.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.B_New, this.B_Old, this.B_Extension, this.B_Refund });
            this.B_Product.Image = (System.Drawing.Image)resources.GetObject("B_Product.Image");
            this.B_Product.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.B_Product.Name = "B_Product";
            this.B_Product.Size = new System.Drawing.Size(87, 23);
            this.B_Product.Text = "عملیات";
            this.B_Product.Visible = false;
            //
            //B_New
            //
            this.B_New.Image = (System.Drawing.Image)resources.GetObject("B_New.Image");
            this.B_New.Name = "B_New";
            this.B_New.Size = new System.Drawing.Size(224, 24);
            this.B_New.Text = "ثبت اطلاعات جـــدیـــد";
            //
            //B_Old
            //
            this.B_Old.Image = (System.Drawing.Image)resources.GetObject("B_Old.Image");
            this.B_Old.Name = "B_Old";
            this.B_Old.Size = new System.Drawing.Size(224, 24);
            this.B_Old.Text = "ثبت اطلاعات قـــبــلی";
            //
            //B_Extension
            //
            this.B_Extension.Image = (System.Drawing.Image)resources.GetObject("B_Extension.Image");
            this.B_Extension.Name = "B_Extension";
            this.B_Extension.Size = new System.Drawing.Size(224, 24);
            this.B_Extension.Text = "تمدید اسنـاد ضمانتی";
            //
            //B_Refund
            //
            this.B_Refund.Image = (System.Drawing.Image)resources.GetObject("B_Refund.Image");
            this.B_Refund.Name = "B_Refund";
            this.B_Refund.Size = new System.Drawing.Size(224, 24);
            this.B_Refund.Text = "اعلام استردادی اسناد";
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
            //Edit_B
            //
            this.Edit_B.Image = (System.Drawing.Image)resources.GetObject("Edit_B.Image");
            this.Edit_B.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Edit_B.Name = "Edit_B";
            this.Edit_B.Size = new System.Drawing.Size(76, 23);
            this.Edit_B.Text = "ویرایش";
            //
            //Search_B
            //
            this.Search_B.Image = (System.Drawing.Image)resources.GetObject("Search_B.Image");
            this.Search_B.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Search_B.Name = "Search_B";
            this.Search_B.Size = new System.Drawing.Size(81, 23);
            this.Search_B.Text = "جستجو";
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
            //B_Excel
            //
            this.B_Excel.Image = (System.Drawing.Image)resources.GetObject("B_Excel.Image");
            this.B_Excel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.B_Excel.Name = "B_Excel";
            this.B_Excel.Size = new System.Drawing.Size(70, 23);
            this.B_Excel.Text = "اکسل";
            //
            //Print
            //
            this.Print.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.Details_Print, this.Short_Print });
            this.Print.Image = (System.Drawing.Image)resources.GetObject("Print.Image");
            this.Print.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(67, 23);
            this.Print.Text = "چاپ";
            //
            //Details_Print
            //
            this.Details_Print.Name = "Details_Print";
            this.Details_Print.Size = new System.Drawing.Size(217, 24);
            this.Details_Print.Text = "صورت ریـــــــز گزارش";
            //
            //Short_Print
            //
            this.Short_Print.Name = "Short_Print";
            this.Short_Print.Size = new System.Drawing.Size(217, 24);
            this.Short_Print.Text = "صورت خلاصـه گزارش";
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
            //B_Picture
            //
            this.B_Picture.Image = (System.Drawing.Image)resources.GetObject("B_Picture.Image");
            this.B_Picture.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.B_Picture.Name = "B_Picture";
            this.B_Picture.Size = new System.Drawing.Size(63, 23);
            this.B_Picture.Text = "تصویر";
            //
            //Abort_B
            //
            this.Abort_B.Image = (System.Drawing.Image)resources.GetObject("Abort_B.Image");
            this.Abort_B.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Abort_B.Name = "Abort_B";
            this.Abort_B.Size = new System.Drawing.Size(74, 23);
            this.Abort_B.Text = "انصراف";
            //
            //Label9
            //
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label9.Location = new System.Drawing.Point(438, 182);
            this.Label9.Name = "Label9";
            this.Label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label9.Size = new System.Drawing.Size(91, 25);
            this.Label9.TabIndex = 203;
            this.Label9.Text = "مــبلغ چک :";
            //
            //Label15
            //
            this.Label15.AutoSize = true;
            this.Label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label15.Location = new System.Drawing.Point(1151, 255);
            this.Label15.Name = "Label15";
            this.Label15.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label15.Size = new System.Drawing.Size(92, 25);
            this.Label15.TabIndex = 208;
            this.Label15.Text = "توضیحات :";
            //
            //Label11
            //
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label11.Location = new System.Drawing.Point(1136, 222);
            this.Label11.Name = "Label11";
            this.Label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label11.Size = new System.Drawing.Size(112, 20);
            this.Label11.TabIndex = 204;
            this.Label11.Text = "مبلغ چک به حروف :";
            //
            //Label8
            //
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label8.Location = new System.Drawing.Point(257, 148);
            this.Label8.Name = "Label8";
            this.Label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label8.Size = new System.Drawing.Size(111, 25);
            this.Label8.TabIndex = 202;
            this.Label8.Text = "شماره حساب:";
            //
            //GroupBox1
            //
            this.GroupBox1.Controls.Add(this.Az_Ta);
            this.GroupBox1.Controls.Add(this.Label19);
//            this.GroupBox1.Controls.Add(this.Warranty_Document_From_Date);
//            this.GroupBox1.Controls.Add(this.Warranty_Document_Until_Date);
            this.GroupBox1.Location = new System.Drawing.Point(302, 24);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(419, 46);
            this.GroupBox1.TabIndex = 253;
            this.GroupBox1.TabStop = false;
            //
            //Az_Ta
            //
            this.Az_Ta.AutoSize = true;
            this.Az_Ta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Az_Ta.Location = new System.Drawing.Point(244, 13);
            this.Az_Ta.Name = "Az_Ta";
            this.Az_Ta.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Az_Ta.Size = new System.Drawing.Size(119, 24);
            this.Az_Ta.TabIndex = 251;
            this.Az_Ta.Text = "از تاریخ دریافت :";
            //
            //Label19
            //
            this.Label19.AutoSize = true;
            this.Label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label19.Location = new System.Drawing.Point(110, 13);
            this.Label19.Name = "Label19";
            this.Label19.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label19.Size = new System.Drawing.Size(24, 24);
            this.Label19.TabIndex = 253;
            this.Label19.Text = "تا:";
            //
            //Warranty_Document_From_Date
            //
//            this.Warranty_Document_From_Date.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
//            this.Warranty_Document_From_Date.AutoSize = true;
            //this.Warranty_Document_From_Date.BackColor = System.Drawing.SystemColors.ControlLightLight;
            //this.Warranty_Document_From_Date.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            //this.Warranty_Document_From_Date.Location = new System.Drawing.Point(137, 11);
            //this.Warranty_Document_From_Date.Name = "Warranty_Document_From_Date";
            //this.Warranty_Document_From_Date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            //this.Warranty_Document_From_Date.Size = new System.Drawing.Size(108, 32);
            //this.Warranty_Document_From_Date.T_D = "";
            //this.Warranty_Document_From_Date.TabIndex = 0;
            //
            //Warranty_Document_Until_Date
            //
            //this.Warranty_Document_Until_Date.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            //this.Warranty_Document_Until_Date.AutoSize = true;
            //this.Warranty_Document_Until_Date.BackColor = System.Drawing.SystemColors.ControlLightLight;
            //this.Warranty_Document_Until_Date.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            //this.Warranty_Document_Until_Date.Location = new System.Drawing.Point(4, 10);
            //this.Warranty_Document_Until_Date.Name = "Warranty_Document_Until_Date";
            //this.Warranty_Document_Until_Date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            //this.Warranty_Document_Until_Date.Size = new System.Drawing.Size(121, 32);
            //this.Warranty_Document_Until_Date.T_D = "";
            //this.Warranty_Document_Until_Date.TabIndex = 1;
            ////
            //Warranty_Document_No_Date
            //
            //this.Warranty_Document_No_Date.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            //this.Warranty_Document_No_Date.AutoSize = true;
            //this.Warranty_Document_No_Date.BackColor = System.Drawing.SystemColors.ControlLightLight;
            //this.Warranty_Document_No_Date.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            //this.Warranty_Document_No_Date.Location = new System.Drawing.Point(1008, 75);
            //this.Warranty_Document_No_Date.Name = "Warranty_Document_No_Date";
            //this.Warranty_Document_No_Date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            //this.Warranty_Document_No_Date.Size = new System.Drawing.Size(121, 32);
            //this.Warranty_Document_No_Date.T_D = "";
            //this.Warranty_Document_No_Date.TabIndex = 3;
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
            this.DV.Size = new System.Drawing.Size(1252, 244);
            this.DV.TabIndex = 0;
            //
            //Warranty_Document
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7.0F, 16.0F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1252, 534);
            this.Controls.Add(this.SplitContainer1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Warranty_Document";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ch_Add_A";
            this.SplitContainer1.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel1.PerformLayout();
            this.SplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.SplitContainer1).EndInit();
            this.SplitContainer1.ResumeLayout(false);
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.DV).EndInit();
            this.ResumeLayout(false);

        }
        internal System.Windows.Forms.SplitContainer SplitContainer1;
        internal System.Windows.Forms.ToolStrip ToolStrip;
        internal System.Windows.Forms.ToolStripButton Edit_B;
        internal System.Windows.Forms.ToolStripButton Delet_B;
        internal System.Windows.Forms.ToolStripButton Save_B;
        internal System.Windows.Forms.ToolStripButton Search_B;
        internal System.Windows.Forms.ToolStripButton Abort_B;
        internal System.Windows.Forms.ToolStripButton B_Excel;
        internal System.Windows.Forms.DataGridView DV;
        internal System.Windows.Forms.TextBox Warranty_Document_Description;
        internal System.Windows.Forms.ComboBox Warranty_Document_Case;
        internal System.Windows.Forms.TextBox Warranty_Document_Bank;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.TextBox Warranty_Document_Amount;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox Warranty_Document_Account_Number;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.TextBox Warranty_Document_No_Check;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.TextBox Warranty_Document_Branch;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox Warranty_Document_Contract_Number;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox Warranty_Document_Number;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.TextBox Warranty_Document_Subscription;
        internal System.Windows.Forms.TextBox L_Mab;
        internal System.Windows.Forms.ComboBox Warranty_Document_Operation;
        internal System.Windows.Forms.Label Label17;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.Label Label18;
        internal System.Windows.Forms.Button B_Warranty_Document_Subscription;
        internal System.Windows.Forms.ToolStripButton B_Picture;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label19;
        internal System.Windows.Forms.Label Az_Ta;
        internal System.Windows.Forms.ToolStripDropDownButton B_Product;
        internal System.Windows.Forms.ToolStripMenuItem B_New;
        internal System.Windows.Forms.ToolStripMenuItem B_Old;
        internal System.Windows.Forms.ToolStripMenuItem B_Extension;
        internal System.Windows.Forms.ToolStripMenuItem B_Refund;
        internal System.Windows.Forms.ToolStripButton Log_File;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label20;
        internal Ansaripour.Rtl_Date Warranty_Document_Until_Date;
        internal Ansaripour.Rtl_Date Warranty_Document_From_Date;
        internal Ansaripour.Rtl_Date Warranty_Document_Date;
        internal Ansaripour.Rtl_Date Warranty_Document_Extended_Date;
        internal Ansaripour.Rtl_Date Warranty_Document_Due_Date;
        internal Ansaripour.Rtl_Date Warranty_Document_Refund_Date;
        internal Ansaripour.Rtl_Date Warranty_Document_Contract_Date;
        internal Ansaripour.Rtl_Date Warranty_Document_No_Date;
        internal System.Windows.Forms.ToolStripDropDownButton Print;
        internal System.Windows.Forms.ToolStripMenuItem Details_Print;
        internal System.Windows.Forms.ToolStripMenuItem Short_Print;
    }
}