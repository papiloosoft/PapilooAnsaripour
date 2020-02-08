
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
    public partial class ST_Goods : System.Windows.Forms.Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ST_Goods));
            System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Goods_Description = new System.Windows.Forms.TextBox();
            this.Goods_Technical_Code = new System.Windows.Forms.TextBox();
            this.Goods_Module = new System.Windows.Forms.TextBox();
            this.Goods_Group = new System.Windows.Forms.TextBox();
            this.Goods_name = new System.Windows.Forms.TextBox();
            this.Goods_Code = new System.Windows.Forms.TextBox();
            this.Good_Case = new System.Windows.Forms.ComboBox();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.New_B = new System.Windows.Forms.ToolStripButton();
            this.Edit_B = new System.Windows.Forms.ToolStripButton();
            this.Delet_B = new System.Windows.Forms.ToolStripButton();
            this.Save_B = new System.Windows.Forms.ToolStripButton();
            this.Search_B = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.Abort_B = new System.Windows.Forms.ToolStripButton();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.B_Goods_Module = new System.Windows.Forms.Button();
            this.Label5 = new System.Windows.Forms.Label();
            this.B_Goods_Group = new System.Windows.Forms.Button();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.DV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)this.SplitContainer1).BeginInit();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            this.ToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.DV).BeginInit();
            this.SuspendLayout();
            //
            //Label1
            //
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label1.Location = new System.Drawing.Point(833, 80);
            this.Label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label1.Size = new System.Drawing.Size(130, 23);
            this.Label1.TabIndex = 56;
            this.Label1.Text = "کـــــد کــــــالا :";
            //
            //Label3
            //
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label3.Location = new System.Drawing.Point(499, 79);
            this.Label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label3.Size = new System.Drawing.Size(95, 23);
            this.Label3.TabIndex = 66;
            this.Label3.Text = "شرح کالا :";
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
            this.SplitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SplitContainer1.Panel1.Controls.Add(this.Goods_Description);
            this.SplitContainer1.Panel1.Controls.Add(this.Goods_Technical_Code);
            this.SplitContainer1.Panel1.Controls.Add(this.Goods_Module);
            this.SplitContainer1.Panel1.Controls.Add(this.Goods_Group);
            this.SplitContainer1.Panel1.Controls.Add(this.Goods_name);
            this.SplitContainer1.Panel1.Controls.Add(this.Goods_Code);
            this.SplitContainer1.Panel1.Controls.Add(this.Good_Case);
            this.SplitContainer1.Panel1.Controls.Add(this.ToolStrip1);
            this.SplitContainer1.Panel1.Controls.Add(this.Label8);
            this.SplitContainer1.Panel1.Controls.Add(this.Label7);
            this.SplitContainer1.Panel1.Controls.Add(this.B_Goods_Module);
            this.SplitContainer1.Panel1.Controls.Add(this.Label5);
            this.SplitContainer1.Panel1.Controls.Add(this.B_Goods_Group);
            this.SplitContainer1.Panel1.Controls.Add(this.Label6);
            this.SplitContainer1.Panel1.Controls.Add(this.Label2);
            this.SplitContainer1.Panel1.Controls.Add(this.Label3);
            this.SplitContainer1.Panel1.Controls.Add(this.Label1);
            this.SplitContainer1.Panel1.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.SplitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            //
            //SplitContainer1.Panel2
            //
            this.SplitContainer1.Panel2.Controls.Add(this.DV);
            this.SplitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SplitContainer1.Size = new System.Drawing.Size(968, 526);
            this.SplitContainer1.SplitterDistance = 218;
            this.SplitContainer1.TabIndex = 65;
            //
            //Goods_Description
            //
            this.Goods_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Goods_Description.Location = new System.Drawing.Point(8, 172);
            this.Goods_Description.Name = "Goods_Description";
            this.Goods_Description.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Goods_Description.Size = new System.Drawing.Size(824, 31);
            this.Goods_Description.TabIndex = 8;
            //
            //Goods_Technical_Code
            //
            this.Goods_Technical_Code.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Goods_Technical_Code.Location = new System.Drawing.Point(8, 118);
            this.Goods_Technical_Code.Name = "Goods_Technical_Code";
            this.Goods_Technical_Code.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Goods_Technical_Code.Size = new System.Drawing.Size(341, 31);
            this.Goods_Technical_Code.TabIndex = 7;
            //
            //Goods_Module
            //
            this.Goods_Module.Enabled = false;
            this.Goods_Module.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Goods_Module.Location = new System.Drawing.Point(38, 33);
            this.Goods_Module.Name = "Goods_Module";
            this.Goods_Module.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Goods_Module.Size = new System.Drawing.Size(311, 31);
            this.Goods_Module.TabIndex = 4;
            //
            //Goods_Group
            //
            this.Goods_Group.Enabled = false;
            this.Goods_Group.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Goods_Group.Location = new System.Drawing.Point(530, 33);
            this.Goods_Group.Name = "Goods_Group";
            this.Goods_Group.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Goods_Group.Size = new System.Drawing.Size(302, 31);
            this.Goods_Group.TabIndex = 2;
            //
            //Goods_name
            //
            this.Goods_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Goods_name.Location = new System.Drawing.Point(8, 76);
            this.Goods_name.Name = "Goods_name";
            this.Goods_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Goods_name.Size = new System.Drawing.Size(492, 31);
            this.Goods_name.TabIndex = 1;
            //
            //Goods_Code
            //
            this.Goods_Code.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Goods_Code.Location = new System.Drawing.Point(594, 76);
            this.Goods_Code.Name = "Goods_Code";
            this.Goods_Code.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Goods_Code.Size = new System.Drawing.Size(238, 31);
            this.Goods_Code.TabIndex = 0;
            //
            //Good_Case
            //
            this.Good_Case.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Good_Case.FormattingEnabled = true;
            this.Good_Case.Items.AddRange(new object[] { "کالای خریداری/ساخته شده", "کالا و اقلام مــــصــــرفـــــــــی", "مـــــــــــــواد اولـــــــــیـــــــــــه", "کـــــــــالای در جریان سـاخت", "ضـــــــــــایـــــــــــــــعــــــــــات" });
            this.Good_Case.Location = new System.Drawing.Point(505, 125);
            this.Good_Case.Name = "Good_Case";
            this.Good_Case.Size = new System.Drawing.Size(327, 24);
            this.Good_Case.TabIndex = 6;
            //
            //ToolStrip1
            //
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.New_B, this.Edit_B, this.Delet_B, this.Save_B, this.Search_B, this.ToolStripButton1, this.Abort_B });
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ToolStrip1.Size = new System.Drawing.Size(968, 25);
            this.ToolStrip1.TabIndex = 9;
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
            //ToolStripButton1
            //
            this.ToolStripButton1.Image = (System.Drawing.Image)resources.GetObject("ToolStripButton1.Image");
            this.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton1.Name = "ToolStripButton1";
            this.ToolStripButton1.Size = new System.Drawing.Size(48, 22);
            this.ToolStripButton1.Text = "چاپ";
            //
            //Abort_B
            //
            this.Abort_B.Image = (System.Drawing.Image)resources.GetObject("Abort_B.Image");
            this.Abort_B.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Abort_B.Name = "Abort_B";
            this.Abort_B.Size = new System.Drawing.Size(64, 22);
            this.Abort_B.Text = "انصراف";
            //
            //Label8
            //
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label8.Location = new System.Drawing.Point(359, 122);
            this.Label8.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label8.Name = "Label8";
            this.Label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label8.Size = new System.Drawing.Size(145, 23);
            this.Label8.TabIndex = 195;
            this.Label8.Text = "کــــــد فنی کالا :";
            //
            //Label7
            //
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label7.Location = new System.Drawing.Point(833, 124);
            this.Label7.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label7.Name = "Label7";
            this.Label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label7.Size = new System.Drawing.Size(130, 23);
            this.Label7.TabIndex = 192;
            this.Label7.Text = "ماهیـت کـــالا :";
            //
            //B_Goods_Module
            //
            this.B_Goods_Module.Image = (System.Drawing.Image)resources.GetObject("B_Goods_Module.Image");
            this.B_Goods_Module.Location = new System.Drawing.Point(8, 35);
            this.B_Goods_Module.Name = "B_Goods_Module";
            this.B_Goods_Module.Size = new System.Drawing.Size(29, 27);
            this.B_Goods_Module.TabIndex = 5;
            this.B_Goods_Module.UseVisualStyleBackColor = true;
            //
            //Label5
            //
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label5.Location = new System.Drawing.Point(359, 36);
            this.Label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label5.Name = "Label5";
            this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label5.Size = new System.Drawing.Size(137, 23);
            this.Label5.TabIndex = 189;
            this.Label5.Text = "واحـد شمارش :";
            //
            //B_Goods_Group
            //
            this.B_Goods_Group.Image = (System.Drawing.Image)resources.GetObject("B_Goods_Group.Image");
            this.B_Goods_Group.Location = new System.Drawing.Point(501, 36);
            this.B_Goods_Group.Name = "B_Goods_Group";
            this.B_Goods_Group.Size = new System.Drawing.Size(29, 27);
            this.B_Goods_Group.TabIndex = 3;
            this.B_Goods_Group.UseVisualStyleBackColor = true;
            //
            //Label6
            //
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label6.Location = new System.Drawing.Point(836, 176);
            this.Label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label6.Name = "Label6";
            this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label6.Size = new System.Drawing.Size(125, 23);
            this.Label6.TabIndex = 184;
            this.Label6.Text = "تــــوضیــحــات:";
            //
            //Label2
            //
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label2.Location = new System.Drawing.Point(834, 35);
            this.Label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label2.Size = new System.Drawing.Size(131, 23);
            this.Label2.TabIndex = 178;
            this.Label2.Text = " گــروه کـــــالا :";
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
            this.DV.Size = new System.Drawing.Size(968, 304);
            this.DV.TabIndex = 0;
            //
            //ST_Goods
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(12.0F, 25.0F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(968, 526);
            this.Controls.Add(this.SplitContainer1);
            this.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.Name = "ST_Goods";
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
            ((System.ComponentModel.ISupportInitialize)this.DV).EndInit();
            this.ResumeLayout(false);

        }
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.SplitContainer SplitContainer1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.DataGridView DV;
        internal System.Windows.Forms.Button B_Goods_Group;
        internal System.Windows.Forms.Button B_Goods_Module;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton New_B;
        internal System.Windows.Forms.ToolStripButton Edit_B;
        internal System.Windows.Forms.ToolStripButton Delet_B;
        internal System.Windows.Forms.ToolStripButton Save_B;
        internal System.Windows.Forms.ToolStripButton Search_B;
        internal System.Windows.Forms.ToolStripButton ToolStripButton1;
        internal System.Windows.Forms.ToolStripButton Abort_B;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.ComboBox Good_Case;
        internal System.Windows.Forms.TextBox Goods_Description;
        internal System.Windows.Forms.TextBox Goods_Technical_Code;
        internal System.Windows.Forms.TextBox Goods_Module;
        internal System.Windows.Forms.TextBox Goods_Group;
        internal System.Windows.Forms.TextBox Goods_name;
        internal System.Windows.Forms.TextBox Goods_Code;
    }
}

