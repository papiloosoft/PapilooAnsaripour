using System.IO;
using System.Text;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
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
    public partial class Pictures : System.Windows.Forms.Form
    {
        //sddsdsdsd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pictures));
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.New_B = new System.Windows.Forms.ToolStripButton();
            this.Edit_B = new System.Windows.Forms.ToolStripButton();
            this.Delet_B = new System.Windows.Forms.ToolStripButton();
            this.Save_B = new System.Windows.Forms.ToolStripButton();
            this.Product_B = new System.Windows.Forms.ToolStripDropDownButton();
            this.B_Save_File = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Add_Size = new System.Windows.Forms.ToolStripButton();
            this.CurrentSize = new System.Windows.Forms.ToolStripTextBox();
            this.Reduce_Size = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.B_First = new System.Windows.Forms.ToolStripButton();
            this.B_Perview = new System.Windows.Forms.ToolStripButton();
            this.Number_Text = new System.Windows.Forms.ToolStripTextBox();
            this.B_Next = new System.Windows.Forms.ToolStripButton();
            this.B_Last = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.B_Rotate = new System.Windows.Forms.ToolStripButton();
            this.PrintPage = new System.Windows.Forms.ToolStripButton();
            this.Abort_B = new System.Windows.Forms.ToolStripButton();
            this.P_Pic = new System.Windows.Forms.PictureBox();
            this.PrintGraphicControl = new System.Drawing.Printing.PrintDocument();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblCurrentSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.P_Pic).BeginInit();
            this.StatusStrip1.SuspendLayout();
            this.SuspendLayout();
            //
            //ToolStrip1
            //
            this.ToolStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.New_B, this.Edit_B, this.Save_B, this.Delet_B, this.Product_B, this.ToolStripSeparator1, this.Add_Size, this.CurrentSize, this.Reduce_Size, this.ToolStripSeparator2, this.B_First, this.B_Perview, this.Number_Text, this.B_Next, this.B_Last, this.ToolStripSeparator3, this.B_Rotate, this.PrintPage, this.Abort_B });
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ToolStrip1.Size = new System.Drawing.Size(752, 27);
            this.ToolStrip1.TabIndex = 177;
            this.ToolStrip1.Text = "ToolStrip1";
            //
            //New_B
            //
            this.New_B.Image = (System.Drawing.Image)resources.GetObject("New_B.Image");
            this.New_B.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.New_B.Name = "New_B";
            this.New_B.Size = new System.Drawing.Size(59, 24);
            this.New_B.Text = "جدید";
            //
            //Edit_B
            //
            this.Edit_B.Image = (System.Drawing.Image)resources.GetObject("Edit_B.Image");
            this.Edit_B.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Edit_B.Name = "Edit_B";
            this.Edit_B.Size = new System.Drawing.Size(75, 24);
            this.Edit_B.Text = "ویرایش";
            //
            //Delet_B
            //
            this.Delet_B.Image = (System.Drawing.Image)resources.GetObject("Delet_B.Image");
            this.Delet_B.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Delet_B.Name = "Delet_B";
            this.Delet_B.Size = new System.Drawing.Size(61, 24);
            this.Delet_B.Text = "حذف";
            this.Delet_B.ToolTipText = "حذف";
            //
            //Save_B
            //
            this.Save_B.Enabled = false;
            this.Save_B.Image = (System.Drawing.Image)resources.GetObject("Save_B.Image");
            this.Save_B.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Save_B.Name = "Save_B";
            this.Save_B.Size = new System.Drawing.Size(64, 24);
            this.Save_B.Text = "ذخیره";
            //
            //Product_B
            //
            this.Product_B.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.B_Save_File });
            this.Product_B.Image = (System.Drawing.Image)resources.GetObject("Product_B.Image");
            this.Product_B.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Product_B.Name = "Product_B";
            this.Product_B.Size = new System.Drawing.Size(84, 24);
            this.Product_B.Text = "عملیات";
            //
            //B_Save_File
            //
            this.B_Save_File.Image = (System.Drawing.Image)resources.GetObject("B_Save_File.Image");
            this.B_Save_File.Name = "B_Save_File";
            this.B_Save_File.Size = new System.Drawing.Size(234, 24);
            this.B_Save_File.Text = "ذخیره عکس بصورت فایل";
            //
            //ToolStripSeparator1
            //
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            //
            //Add_Size
            //
            this.Add_Size.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Add_Size.Image = (System.Drawing.Image)resources.GetObject("Add_Size.Image");
            this.Add_Size.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Add_Size.Name = "Add_Size";
            this.Add_Size.Size = new System.Drawing.Size(23, 24);
            this.Add_Size.Text = "افزایش سایز عکس";
            //
            //CurrentSize
            //
            this.CurrentSize.Enabled = false;
            this.CurrentSize.Name = "CurrentSize";
            this.CurrentSize.Size = new System.Drawing.Size(27, 27);
            this.CurrentSize.Text = "100";
            //
            //Reduce_Size
            //
            this.Reduce_Size.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Reduce_Size.Image = (System.Drawing.Image)resources.GetObject("Reduce_Size.Image");
            this.Reduce_Size.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Reduce_Size.Name = "Reduce_Size";
            this.Reduce_Size.Size = new System.Drawing.Size(23, 24);
            this.Reduce_Size.Text = "کاهش سایز عکس";
            //
            //ToolStripSeparator2
            //
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            //
            //B_First
            //
            this.B_First.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.B_First.Image = (System.Drawing.Image)resources.GetObject("B_First.Image");
            this.B_First.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.B_First.Name = "B_First";
            this.B_First.Size = new System.Drawing.Size(23, 24);
            this.B_First.Text = "اولین رکورد";
            //
            //B_Perview
            //
            this.B_Perview.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.B_Perview.Image = (System.Drawing.Image)resources.GetObject("B_Perview.Image");
            this.B_Perview.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.B_Perview.Name = "B_Perview";
            this.B_Perview.Size = new System.Drawing.Size(23, 24);
            this.B_Perview.Text = "رکورد قبلی";
            //
            //Number_Text
            //
            this.Number_Text.Enabled = false;
            this.Number_Text.Name = "Number_Text";
            this.Number_Text.Size = new System.Drawing.Size(50, 27);
            //
            //B_Next
            //
            this.B_Next.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.B_Next.Image = (System.Drawing.Image)resources.GetObject("B_Next.Image");
            this.B_Next.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.B_Next.Name = "B_Next";
            this.B_Next.Size = new System.Drawing.Size(23, 24);
            this.B_Next.Text = "رکورد بعدی";
            //
            //B_Last
            //
            this.B_Last.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.B_Last.Image = (System.Drawing.Image)resources.GetObject("B_Last.Image");
            this.B_Last.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.B_Last.Name = "B_Last";
            this.B_Last.Size = new System.Drawing.Size(23, 24);
            this.B_Last.Text = "آخرین رکورد";
            //
            //ToolStripSeparator3
            //
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            this.ToolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            //
            //B_Rotate
            //
            this.B_Rotate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.B_Rotate.Image = (System.Drawing.Image)resources.GetObject("B_Rotate.Image");
            this.B_Rotate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.B_Rotate.Name = "B_Rotate";
            this.B_Rotate.Size = new System.Drawing.Size(23, 24);
            this.B_Rotate.Text = "چرخش تصویر";
            //
            //PrintPage
            //
            this.PrintPage.Image = (System.Drawing.Image)resources.GetObject("PrintPage.Image");
            this.PrintPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PrintPage.Name = "PrintPage";
            this.PrintPage.Size = new System.Drawing.Size(56, 24);
            this.PrintPage.Text = "چاپ";
            //
            //Abort_B
            //
            this.Abort_B.Image = (System.Drawing.Image)resources.GetObject("Abort_B.Image");
            this.Abort_B.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Abort_B.Name = "Abort_B";
            this.Abort_B.Size = new System.Drawing.Size(76, 24);
            this.Abort_B.Text = "انصراف";
            //
            //P_Pic
            //
            this.P_Pic.BackColor = System.Drawing.SystemColors.ControlDark;
            this.P_Pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.P_Pic.Location = new System.Drawing.Point(0, 27);
            this.P_Pic.Name = "P_Pic";
            this.P_Pic.Size = new System.Drawing.Size(752, 578);
            this.P_Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.P_Pic.TabIndex = 231;
            this.P_Pic.TabStop = false;
            //
            //PrintGraphicControl
            //
            this.PrintGraphicControl.DocumentName = "Demo Graphic Print";
            //
            //StatusStrip1
            //
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.lblCurrentSize });
            this.StatusStrip1.Location = new System.Drawing.Point(0, 583);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Size = new System.Drawing.Size(752, 22);
            this.StatusStrip1.TabIndex = 232;
            this.StatusStrip1.Text = "StatusStrip1";
            //
            //lblCurrentSize
            //
            this.lblCurrentSize.Name = "lblCurrentSize";
            this.lblCurrentSize.Size = new System.Drawing.Size(65, 17);
            this.lblCurrentSize.Text = "سایز عکس :";
            //
            //Pictures
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6.0F, 13.0F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 605);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.P_Pic);
            this.Controls.Add(this.ToolStrip1);
            this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            this.Name = "Pictures";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "تصاویر";
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.P_Pic).EndInit();
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton New_B;
        internal System.Windows.Forms.ToolStripButton Edit_B;
        internal System.Windows.Forms.ToolStripButton Delet_B;
        internal System.Windows.Forms.ToolStripButton Save_B;
        internal System.Windows.Forms.ToolStripButton PrintPage;
        internal System.Windows.Forms.ToolStripButton Abort_B;
        internal System.Windows.Forms.PictureBox P_Pic;
        internal System.Windows.Forms.ToolStripButton B_First;
        internal System.Windows.Forms.ToolStripButton B_Perview;
        internal System.Windows.Forms.ToolStripButton B_Next;
        internal System.Windows.Forms.ToolStripButton B_Last;
        internal System.Drawing.Printing.PrintDocument PrintGraphicControl;
        internal System.Windows.Forms.ToolStripButton B_Rotate;
        internal System.Windows.Forms.ToolStripTextBox Number_Text;
        internal System.Windows.Forms.StatusStrip StatusStrip1;
        internal System.Windows.Forms.ToolStripStatusLabel lblCurrentSize;
        internal System.Windows.Forms.ToolStripDropDownButton Product_B;
        internal System.Windows.Forms.ToolStripMenuItem B_Save_File;
        internal System.Windows.Forms.ToolStripButton Add_Size;
        internal System.Windows.Forms.ToolStripTextBox CurrentSize;
        internal System.Windows.Forms.ToolStripButton Reduce_Size;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator3;
    }
}