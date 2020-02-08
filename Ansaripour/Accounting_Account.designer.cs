
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
    public partial class Accounting_Account : System.Windows.Forms.Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accounting_Account));
            System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Acc_Case = new System.Windows.Forms.TextBox();
            this.Acc_Code = new System.Windows.Forms.TextBox();
            this.Acc_Num = new System.Windows.Forms.TextBox();
            this.Acc_Level = new System.Windows.Forms.TextBox();
            this.Acc_Name = new System.Windows.Forms.TextBox();
            this.Delet_Level = new System.Windows.Forms.Button();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Acc_Operation = new System.Windows.Forms.ComboBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.B_Level = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.Acc_Group = new System.Windows.Forms.ComboBox();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.New_B = new System.Windows.Forms.ToolStripButton();
            this.Edit_B = new System.Windows.Forms.ToolStripButton();
            this.Save_B = new System.Windows.Forms.ToolStripButton();
            this.Delet_B = new System.Windows.Forms.ToolStripButton();
            this.Search_B = new System.Windows.Forms.ToolStripButton();
            this.Relation_B = new System.Windows.Forms.ToolStripButton();
            this.Excel_B = new System.Windows.Forms.ToolStripButton();
            this.Picture_B = new System.Windows.Forms.ToolStripButton();
            this.Chap = new System.Windows.Forms.ToolStripButton();
            this.Abort_B = new System.Windows.Forms.ToolStripButton();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.SplitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tvData = new System.Windows.Forms.TreeView();
            this.DV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)this.SplitContainer1).BeginInit();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            this.ToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.SplitContainer2).BeginInit();
            this.SplitContainer2.Panel1.SuspendLayout();
            this.SplitContainer2.Panel2.SuspendLayout();
            this.SplitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.DV).BeginInit();
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
            this.SplitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SplitContainer1.Panel1.Controls.Add(this.Acc_Case);
            this.SplitContainer1.Panel1.Controls.Add(this.Acc_Code);
            this.SplitContainer1.Panel1.Controls.Add(this.Acc_Num);
            this.SplitContainer1.Panel1.Controls.Add(this.Acc_Level);
            this.SplitContainer1.Panel1.Controls.Add(this.Acc_Name);
            this.SplitContainer1.Panel1.Controls.Add(this.Delet_Level);
            this.SplitContainer1.Panel1.Controls.Add(this.Label6);
            this.SplitContainer1.Panel1.Controls.Add(this.Label5);
            this.SplitContainer1.Panel1.Controls.Add(this.Acc_Operation);
            this.SplitContainer1.Panel1.Controls.Add(this.Label4);
            this.SplitContainer1.Panel1.Controls.Add(this.Label8);
            this.SplitContainer1.Panel1.Controls.Add(this.B_Level);
            this.SplitContainer1.Panel1.Controls.Add(this.Label3);
            this.SplitContainer1.Panel1.Controls.Add(this.Acc_Group);
            this.SplitContainer1.Panel1.Controls.Add(this.ToolStrip1);
            this.SplitContainer1.Panel1.Controls.Add(this.Label2);
            this.SplitContainer1.Panel1.Controls.Add(this.Label1);
            this.SplitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            //
            //SplitContainer1.Panel2
            //
            this.SplitContainer1.Panel2.Controls.Add(this.SplitContainer2);
            this.SplitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SplitContainer1.Size = new System.Drawing.Size(1032, 526);
            this.SplitContainer1.SplitterDistance = 132;
            this.SplitContainer1.TabIndex = 65;
            //
            //Acc_Case
            //
            this.Acc_Case.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Acc_Case.Location = new System.Drawing.Point(10, 95);
            this.Acc_Case.Name = "Acc_Case";
            this.Acc_Case.Size = new System.Drawing.Size(56, 31);
            this.Acc_Case.TabIndex = 193;
            //
            //Acc_Code
            //
            this.Acc_Code.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Acc_Code.Location = new System.Drawing.Point(803, 60);
            this.Acc_Code.Name = "Acc_Code";
            this.Acc_Code.Size = new System.Drawing.Size(112, 31);
            this.Acc_Code.TabIndex = 192;
            //
            //Acc_Num
            //
            this.Acc_Num.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Acc_Num.Location = new System.Drawing.Point(729, 26);
            this.Acc_Num.Name = "Acc_Num";
            this.Acc_Num.Size = new System.Drawing.Size(112, 31);
            this.Acc_Num.TabIndex = 191;
            //
            //Acc_Level
            //
            this.Acc_Level.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Acc_Level.Location = new System.Drawing.Point(43, 26);
            this.Acc_Level.Name = "Acc_Level";
            this.Acc_Level.Size = new System.Drawing.Size(490, 31);
            this.Acc_Level.TabIndex = 190;
            //
            //Acc_Name
            //
            this.Acc_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Acc_Name.Location = new System.Drawing.Point(10, 61);
            this.Acc_Name.Name = "Acc_Name";
            this.Acc_Name.Size = new System.Drawing.Size(678, 31);
            this.Acc_Name.TabIndex = 189;
            //
            //Delet_Level
            //
            this.Delet_Level.Enabled = false;
            this.Delet_Level.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Delet_Level.Location = new System.Drawing.Point(533, 27);
            this.Delet_Level.Name = "Delet_Level";
            this.Delet_Level.Size = new System.Drawing.Size(15, 30);
            this.Delet_Level.TabIndex = 188;
            this.Delet_Level.Text = "X";
            this.Delet_Level.UseVisualStyleBackColor = true;
            //
            //Label6
            //
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label6.Location = new System.Drawing.Point(915, 61);
            this.Label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label6.Name = "Label6";
            this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label6.Size = new System.Drawing.Size(111, 23);
            this.Label6.TabIndex = 186;
            this.Label6.Text = "کـــد حساب:";
            //
            //Label5
            //
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label5.Location = new System.Drawing.Point(486, 99);
            this.Label5.Name = "Label5";
            this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label5.Size = new System.Drawing.Size(118, 25);
            this.Label5.TabIndex = 185;
            this.Label5.Text = "کنترل عملیات :";
            //
            //Acc_Operation
            //
            this.Acc_Operation.Enabled = false;
            this.Acc_Operation.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Acc_Operation.FormattingEnabled = true;
            this.Acc_Operation.Location = new System.Drawing.Point(220, 98);
            this.Acc_Operation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Acc_Operation.Name = "Acc_Operation";
            this.Acc_Operation.Size = new System.Drawing.Size(263, 27);
            this.Acc_Operation.TabIndex = 184;
            //
            //Label4
            //
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label4.Location = new System.Drawing.Point(63, 99);
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label4.Size = new System.Drawing.Size(150, 25);
            this.Label4.TabIndex = 183;
            this.Label4.Text = "درج علامت خاص :";
            //
            //Label8
            //
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Label8.Location = new System.Drawing.Point(877, 98);
            this.Label8.Name = "Label8";
            this.Label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label8.Size = new System.Drawing.Size(150, 25);
            this.Label8.TabIndex = 181;
            this.Label8.Text = "وضعیت زیر گروه :";
            //
            //B_Level
            //
            this.B_Level.Image = (System.Drawing.Image)resources.GetObject("B_Level.Image");
            this.B_Level.Location = new System.Drawing.Point(10, 29);
            this.B_Level.Name = "B_Level";
            this.B_Level.Size = new System.Drawing.Size(29, 27);
            this.B_Level.TabIndex = 180;
            this.B_Level.UseVisualStyleBackColor = true;
            //
            //Label3
            //
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label3.Location = new System.Drawing.Point(543, 28);
            this.Label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label3.Size = new System.Drawing.Size(189, 23);
            this.Label3.TabIndex = 179;
            this.Label3.Text = "کد حساب (سر گروه) :";
            //
            //Acc_Group
            //
            this.Acc_Group.Enabled = false;
            this.Acc_Group.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Acc_Group.FormattingEnabled = true;
            this.Acc_Group.Location = new System.Drawing.Point(661, 97);
            this.Acc_Group.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Acc_Group.Name = "Acc_Group";
            this.Acc_Group.Size = new System.Drawing.Size(215, 27);
            this.Acc_Group.TabIndex = 178;
            //
            //ToolStrip1
            //
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.New_B, this.Edit_B, this.Save_B, this.Delet_B, this.Search_B, this.Relation_B, this.Excel_B, this.Picture_B, this.Chap, this.Abort_B });
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ToolStrip1.Size = new System.Drawing.Size(1032, 25);
            this.ToolStrip1.TabIndex = 176;
            this.ToolStrip1.Text = "ToolStrip1";
            //
            //New_B
            //
            this.New_B.Image = (System.Drawing.Image)resources.GetObject("New_B.Image");
            this.New_B.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.New_B.Name = "New_B";
            this.New_B.Size = new System.Drawing.Size(50, 22);
            this.New_B.Text = "جدید";
            //
            //Edit_B
            //
            this.Edit_B.Image = (System.Drawing.Image)resources.GetObject("Edit_B.Image");
            this.Edit_B.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Edit_B.Name = "Edit_B";
            this.Edit_B.Size = new System.Drawing.Size(63, 22);
            this.Edit_B.Text = "ویرایش";
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
            //Delet_B
            //
            this.Delet_B.Image = (System.Drawing.Image)resources.GetObject("Delet_B.Image");
            this.Delet_B.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Delet_B.Name = "Delet_B";
            this.Delet_B.Size = new System.Drawing.Size(52, 22);
            this.Delet_B.Text = "حذف";
            this.Delet_B.ToolTipText = "حذف";
            //
            //Search_B
            //
            this.Search_B.Image = (System.Drawing.Image)resources.GetObject("Search_B.Image");
            this.Search_B.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Search_B.Name = "Search_B";
            this.Search_B.Size = new System.Drawing.Size(61, 22);
            this.Search_B.Text = "جستجو";
            //
            //Relation_B
            //
            this.Relation_B.Image = (System.Drawing.Image)resources.GetObject("Relation_B.Image");
            this.Relation_B.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Relation_B.Name = "Relation_B";
            this.Relation_B.Size = new System.Drawing.Size(55, 22);
            this.Relation_B.Text = "ارتباط";
            //
            //Excel_B
            //
            this.Excel_B.Image = (System.Drawing.Image)resources.GetObject("Excel_B.Image");
            this.Excel_B.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Excel_B.Name = "Excel_B";
            this.Excel_B.Size = new System.Drawing.Size(54, 22);
            this.Excel_B.Text = "اکسل";
            //
            //Picture_B
            //
            this.Picture_B.Image = (System.Drawing.Image)resources.GetObject("Picture_B.Image");
            this.Picture_B.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Picture_B.Name = "Picture_B";
            this.Picture_B.Size = new System.Drawing.Size(59, 22);
            this.Picture_B.Text = "تصویر";
            //
            //Chap
            //
            this.Chap.Image = (System.Drawing.Image)resources.GetObject("Chap.Image");
            this.Chap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Chap.Name = "Chap";
            this.Chap.Size = new System.Drawing.Size(48, 22);
            this.Chap.Text = "چاپ";
            //
            //Abort_B
            //
            this.Abort_B.Image = (System.Drawing.Image)resources.GetObject("Abort_B.Image");
            this.Abort_B.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Abort_B.Name = "Abort_B";
            this.Abort_B.Size = new System.Drawing.Size(64, 22);
            this.Abort_B.Text = "انصراف";
            //
            //Label2
            //
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label2.Location = new System.Drawing.Point(687, 64);
            this.Label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label2.Size = new System.Drawing.Size(116, 23);
            this.Label2.TabIndex = 68;
            this.Label2.Text = "شرح حساب:";
            //
            //Label1
            //
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label1.Location = new System.Drawing.Point(837, 28);
            this.Label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label1.Size = new System.Drawing.Size(193, 23);
            this.Label1.TabIndex = 56;
            this.Label1.Text = "کـــد حساب (در گروه) :";
            //
            //SplitContainer2
            //
            this.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.SplitContainer2.Location = new System.Drawing.Point(0, 0);
            this.SplitContainer2.Name = "SplitContainer2";
            //
            //SplitContainer2.Panel1
            //
            this.SplitContainer2.Panel1.Controls.Add(this.tvData);
            this.SplitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            //
            //SplitContainer2.Panel2
            //
            this.SplitContainer2.Panel2.Controls.Add(this.DV);
            this.SplitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SplitContainer2.Size = new System.Drawing.Size(1032, 390);
            this.SplitContainer2.SplitterDistance = 371;
            this.SplitContainer2.TabIndex = 1;
            //
            //tvData
            //
            this.tvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvData.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.tvData.Location = new System.Drawing.Point(0, 0);
            this.tvData.Name = "tvData";
            this.tvData.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tvData.RightToLeftLayout = true;
            this.tvData.Size = new System.Drawing.Size(371, 390);
            this.tvData.TabIndex = 0;
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
            this.DV.Size = new System.Drawing.Size(657, 390);
            this.DV.TabIndex = 2;
            //
            //Accounting_Account
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(12.0F, 25.0F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1032, 526);
            this.Controls.Add(this.SplitContainer1);
            this.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Accounting_Account";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "درخت حسابها";
            this.SplitContainer1.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel1.PerformLayout();
            this.SplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.SplitContainer1).EndInit();
            this.SplitContainer1.ResumeLayout(false);
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.SplitContainer2.Panel1.ResumeLayout(false);
            this.SplitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.SplitContainer2).EndInit();
            this.SplitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.DV).EndInit();
            this.ResumeLayout(false);

        }
        internal System.Windows.Forms.SplitContainer SplitContainer1;
        internal System.Windows.Forms.SplitContainer SplitContainer2;
        internal System.Windows.Forms.TreeView tvData;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton New_B;
        internal System.Windows.Forms.ToolStripButton Edit_B;
        internal System.Windows.Forms.ToolStripButton Save_B;
        internal System.Windows.Forms.ToolStripButton Search_B;
        internal System.Windows.Forms.ToolStripButton Abort_B;
        internal System.Windows.Forms.ToolStripButton Chap;
        internal System.Windows.Forms.ToolStripButton Excel_B;
        internal System.Windows.Forms.DataGridView DV;
        internal System.Windows.Forms.ComboBox Acc_Group;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.ToolStripButton Relation_B;
        internal System.Windows.Forms.Button B_Level;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.ComboBox Acc_Operation;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.ToolStripButton Picture_B;
        internal System.Windows.Forms.ToolStripButton Delet_B;
        internal System.Windows.Forms.Button Delet_Level;
        internal System.Windows.Forms.TextBox Acc_Code;
        internal System.Windows.Forms.TextBox Acc_Num;
        internal System.Windows.Forms.TextBox Acc_Level;
        internal System.Windows.Forms.TextBox Acc_Name;
        internal System.Windows.Forms.TextBox Acc_Case;
    }
