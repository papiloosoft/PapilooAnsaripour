
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
    public partial class user : System.Windows.Forms.Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(user));
            System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.SplitContainer2 = new System.Windows.Forms.SplitContainer();
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Admin = new System.Windows.Forms.CheckBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Pass_View = new System.Windows.Forms.CheckBox();
            this.Description = new System.Windows.Forms.RichTextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.B_Area = new System.Windows.Forms.Button();
            this.Area = new System.Windows.Forms.TextBox();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.B_New = new System.Windows.Forms.ToolStripButton();
            this.B_Edit = new System.Windows.Forms.ToolStripButton();
            this.B_Delet = new System.Windows.Forms.ToolStripButton();
            this.B_Save = new System.Windows.Forms.ToolStripButton();
            this.B_Picture = new System.Windows.Forms.ToolStripButton();
            this.B_Search = new System.Windows.Forms.ToolStripButton();
            this.B_Online = new System.Windows.Forms.ToolStripButton();
            this.B_Abort = new System.Windows.Forms.ToolStripButton();
            this.Dv = new System.Windows.Forms.DataGridView();
            this.tvData = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)this.SplitContainer1).BeginInit();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.SplitContainer2).BeginInit();
            this.SplitContainer2.Panel1.SuspendLayout();
            this.SplitContainer2.Panel2.SuspendLayout();
            this.SplitContainer2.SuspendLayout();
            this.ToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.Dv).BeginInit();
            this.SuspendLayout();
            //
            //SplitContainer1
            //
            this.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.SplitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SplitContainer1.Name = "SplitContainer1";
            //
            //SplitContainer1.Panel1
            //
            this.SplitContainer1.Panel1.Controls.Add(this.SplitContainer2);
            this.SplitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            //
            //SplitContainer1.Panel2
            //
            this.SplitContainer1.Panel2.Controls.Add(this.tvData);
            this.SplitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SplitContainer1.Size = new System.Drawing.Size(1131, 504);
            this.SplitContainer1.SplitterDistance = 577;
            this.SplitContainer1.TabIndex = 264;
            //
            //SplitContainer2
            //
            this.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer2.Location = new System.Drawing.Point(0, 0);
            this.SplitContainer2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SplitContainer2.Name = "SplitContainer2";
            this.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            //
            //SplitContainer2.Panel1
            //
            this.SplitContainer2.Panel1.Controls.Add(this.password);
            this.SplitContainer2.Panel1.Controls.Add(this.username);
            this.SplitContainer2.Panel1.Controls.Add(this.Label6);
            this.SplitContainer2.Panel1.Controls.Add(this.Admin);
            this.SplitContainer2.Panel1.Controls.Add(this.Label5);
            this.SplitContainer2.Panel1.Controls.Add(this.Pass_View);
            this.SplitContainer2.Panel1.Controls.Add(this.Description);
            this.SplitContainer2.Panel1.Controls.Add(this.Label4);
            this.SplitContainer2.Panel1.Controls.Add(this.Label3);
            this.SplitContainer2.Panel1.Controls.Add(this.Label2);
            this.SplitContainer2.Panel1.Controls.Add(this.Label1);
            this.SplitContainer2.Panel1.Controls.Add(this.B_Area);
            this.SplitContainer2.Panel1.Controls.Add(this.Area);
            this.SplitContainer2.Panel1.Controls.Add(this.ToolStrip1);
            this.SplitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            //
            //SplitContainer2.Panel2
            //
            this.SplitContainer2.Panel2.Controls.Add(this.Dv);
            this.SplitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SplitContainer2.Size = new System.Drawing.Size(577, 504);
            this.SplitContainer2.SplitterDistance = 246;
            this.SplitContainer2.TabIndex = 264;
            //
            //password
            //
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.password.Location = new System.Drawing.Point(152, 75);
            this.password.Name = "password";
            this.password.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.password.Size = new System.Drawing.Size(302, 31);
            this.password.TabIndex = 293;
            //
            //username
            //
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.username.Location = new System.Drawing.Point(152, 35);
            this.username.Name = "username";
            this.username.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.username.Size = new System.Drawing.Size(361, 31);
            this.username.TabIndex = 292;
            //
            //Label6
            //
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label6.Location = new System.Drawing.Point(23, 37);
            this.Label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label6.Name = "Label6";
            this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label6.Size = new System.Drawing.Size(128, 23);
            this.Label6.TabIndex = 291;
            this.Label6.Text = "مدیر سیستم :";
            //
            //Admin
            //
            this.Admin.AutoSize = true;
            this.Admin.Location = new System.Drawing.Point(8, 44);
            this.Admin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(15, 14);
            this.Admin.TabIndex = 290;
            this.Admin.UseVisualStyleBackColor = true;
            //
            //Label5
            //
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label5.Location = new System.Drawing.Point(26, 75);
            this.Label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label5.Name = "Label5";
            this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label5.Size = new System.Drawing.Size(122, 23);
            this.Label5.TabIndex = 289;
            this.Label5.Text = "نمایش رمـــز :";
            //
            //Pass_View
            //
            this.Pass_View.AutoSize = true;
            this.Pass_View.Location = new System.Drawing.Point(8, 82);
            this.Pass_View.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Pass_View.Name = "Pass_View";
            this.Pass_View.Size = new System.Drawing.Size(15, 14);
            this.Pass_View.TabIndex = 288;
            this.Pass_View.UseVisualStyleBackColor = true;
            //
            //Description
            //
            this.Description.Location = new System.Drawing.Point(8, 157);
            this.Description.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(493, 80);
            this.Description.TabIndex = 287;
            this.Description.Text = "";
            //
            //Label4
            //
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label4.Location = new System.Drawing.Point(505, 154);
            this.Label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label4.Size = new System.Drawing.Size(61, 23);
            this.Label4.TabIndex = 286;
            this.Label4.Text = "پیغام :";
            //
            //Label3
            //
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label3.Location = new System.Drawing.Point(456, 118);
            this.Label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label3.Size = new System.Drawing.Size(117, 23);
            this.Label3.TabIndex = 285;
            this.Label3.Text = "انتخاب بخش:";
            //
            //Label2
            //
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label2.Location = new System.Drawing.Point(455, 76);
            this.Label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label2.Size = new System.Drawing.Size(117, 23);
            this.Label2.TabIndex = 284;
            this.Label2.Text = "رمــز عـبـــور :";
            //
            //Label1
            //
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label1.Location = new System.Drawing.Point(516, 37);
            this.Label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label1.Size = new System.Drawing.Size(52, 23);
            this.Label1.TabIndex = 283;
            this.Label1.Text = "کاربر:";
            //
            //B_Area
            //
            this.B_Area.Enabled = false;
            this.B_Area.Image = (System.Drawing.Image)resources.GetObject("B_Area.Image");
            this.B_Area.Location = new System.Drawing.Point(11, 121);
            this.B_Area.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.B_Area.Name = "B_Area";
            this.B_Area.Size = new System.Drawing.Size(29, 27);
            this.B_Area.TabIndex = 282;
            this.B_Area.UseVisualStyleBackColor = true;
            //
            //Area
            //
            this.Area.Enabled = false;
            this.Area.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Area.Location = new System.Drawing.Point(42, 118);
            this.Area.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Area.Name = "Area";
            this.Area.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Area.Size = new System.Drawing.Size(412, 31);
            this.Area.TabIndex = 281;
            //
            //ToolStrip1
            //
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.B_New, this.B_Edit, this.B_Delet, this.B_Save, this.B_Picture, this.B_Search, this.B_Online, this.B_Abort });
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ToolStrip1.Size = new System.Drawing.Size(577, 25);
            this.ToolStrip1.TabIndex = 268;
            this.ToolStrip1.Text = "ToolStrip1";
            //
            //B_New
            //
            this.B_New.Image = (System.Drawing.Image)resources.GetObject("B_New.Image");
            this.B_New.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.B_New.Name = "B_New";
            this.B_New.Size = new System.Drawing.Size(50, 22);
            this.B_New.Text = "جدید";
            //
            //B_Edit
            //
            this.B_Edit.Image = (System.Drawing.Image)resources.GetObject("B_Edit.Image");
            this.B_Edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.B_Edit.Name = "B_Edit";
            this.B_Edit.Size = new System.Drawing.Size(63, 22);
            this.B_Edit.Text = "ویرایش";
            //
            //B_Delet
            //
            this.B_Delet.Image = (System.Drawing.Image)resources.GetObject("B_Delet.Image");
            this.B_Delet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.B_Delet.Name = "B_Delet";
            this.B_Delet.Size = new System.Drawing.Size(52, 22);
            this.B_Delet.Text = "حذف";
            this.B_Delet.ToolTipText = "حذف";
            //
            //B_Save
            //
            this.B_Save.Enabled = false;
            this.B_Save.Image = (System.Drawing.Image)resources.GetObject("B_Save.Image");
            this.B_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.B_Save.Name = "B_Save";
            this.B_Save.Size = new System.Drawing.Size(54, 22);
            this.B_Save.Text = "ذخیره";
            //
            //B_Picture
            //
            this.B_Picture.Image = (System.Drawing.Image)resources.GetObject("B_Picture.Image");
            this.B_Picture.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.B_Picture.Name = "B_Picture";
            this.B_Picture.Size = new System.Drawing.Size(59, 22);
            this.B_Picture.Text = "تصویر";
            //
            //B_Search
            //
            this.B_Search.Image = (System.Drawing.Image)resources.GetObject("B_Search.Image");
            this.B_Search.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.B_Search.Name = "B_Search";
            this.B_Search.Size = new System.Drawing.Size(61, 22);
            this.B_Search.Text = "جستجو";
            //
            //B_Online
            //
            this.B_Online.Image = (System.Drawing.Image)resources.GetObject("B_Online.Image");
            this.B_Online.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.B_Online.Name = "B_Online";
            this.B_Online.Size = new System.Drawing.Size(90, 22);
            this.B_Online.Text = "کنترل کاربران";
            //
            //B_Abort
            //
            this.B_Abort.Image = (System.Drawing.Image)resources.GetObject("B_Abort.Image");
            this.B_Abort.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.B_Abort.Name = "B_Abort";
            this.B_Abort.Size = new System.Drawing.Size(64, 22);
            this.B_Abort.Text = "انصراف";
            //
            //Dv
            //
            DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            DataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1;
            this.Dv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            DataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dv.DefaultCellStyle = DataGridViewCellStyle2;
            this.Dv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.Dv.Location = new System.Drawing.Point(0, 0);
            this.Dv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dv.Name = "Dv";
            this.Dv.Size = new System.Drawing.Size(577, 254);
            this.Dv.TabIndex = 73;
            //
            //tvData
            //
            this.tvData.CheckBoxes = true;
            this.tvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvData.Location = new System.Drawing.Point(0, 0);
            this.tvData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tvData.Name = "tvData";
            this.tvData.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tvData.RightToLeftLayout = true;
            this.tvData.Size = new System.Drawing.Size(550, 504);
            this.tvData.TabIndex = 274;
            //
            //user
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(9.0F, 19.0F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1131, 504);
            this.Controls.Add(this.SplitContainer1);
            this.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "user";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "سیستم معرفی کاربر سیستم";
            this.SplitContainer1.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.SplitContainer1).EndInit();
            this.SplitContainer1.ResumeLayout(false);
            this.SplitContainer2.Panel1.ResumeLayout(false);
            this.SplitContainer2.Panel1.PerformLayout();
            this.SplitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.SplitContainer2).EndInit();
            this.SplitContainer2.ResumeLayout(false);
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.Dv).EndInit();
            this.ResumeLayout(false);

        }
        internal System.Windows.Forms.SplitContainer SplitContainer1;
        internal System.Windows.Forms.TreeView tvData;
        internal System.Windows.Forms.SplitContainer SplitContainer2;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton B_New;
        internal System.Windows.Forms.ToolStripButton B_Edit;
        internal System.Windows.Forms.ToolStripButton B_Delet;
        internal System.Windows.Forms.ToolStripButton B_Save;
        internal System.Windows.Forms.ToolStripButton B_Search;
        internal System.Windows.Forms.ToolStripButton B_Abort;
        internal System.Windows.Forms.TextBox Area;
        internal System.Windows.Forms.Button B_Area;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.RichTextBox Description;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.CheckBox Pass_View;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.CheckBox Admin;
        internal System.Windows.Forms.ToolStripButton B_Online;
        internal System.Windows.Forms.DataGridView Dv;
        internal System.Windows.Forms.ToolStripButton B_Picture;
        internal System.Windows.Forms.TextBox password;
        internal System.Windows.Forms.TextBox username;
    }
}