
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
    public partial class B_Control : System.Windows.Forms.UserControl
    {
        //UserControl overrides dispose to clean up the component list.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(B_Control));
            this.B_Last = new System.Windows.Forms.Button();
            this.B_Per = new System.Windows.Forms.Button();
            this.B_Next = new System.Windows.Forms.Button();
            this.B_First = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            //B_Last
            //
            this.B_Last.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.B_Last.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.B_Last.ForeColor = System.Drawing.Color.Black;
            this.B_Last.Image = (System.Drawing.Image)resources.GetObject("B_Last.Image");
            this.B_Last.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.B_Last.Location = new System.Drawing.Point(3, 3);
            this.B_Last.Name = "B_Last";
            this.B_Last.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.B_Last.Size = new System.Drawing.Size(55, 54);
            this.B_Last.TabIndex = 0;
            this.B_Last.Text = "انتها";
            this.B_Last.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.B_Last.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.B_Last.UseVisualStyleBackColor = true;
            //
            //B_Per
            //
            this.B_Per.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.B_Per.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.B_Per.ForeColor = System.Drawing.Color.Black;
            this.B_Per.Image = (System.Drawing.Image)resources.GetObject("B_Per.Image");
            this.B_Per.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.B_Per.Location = new System.Drawing.Point(58, 3);
            this.B_Per.Name = "B_Per";
            this.B_Per.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.B_Per.Size = new System.Drawing.Size(55, 54);
            this.B_Per.TabIndex = 1;
            this.B_Per.Text = "قبلی";
            this.B_Per.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.B_Per.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.B_Per.UseVisualStyleBackColor = true;
            //
            //B_Next
            //
            this.B_Next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.B_Next.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.B_Next.ForeColor = System.Drawing.Color.Black;
            this.B_Next.Image = (System.Drawing.Image)resources.GetObject("B_Next.Image");
            this.B_Next.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.B_Next.Location = new System.Drawing.Point(113, 3);
            this.B_Next.Name = "B_Next";
            this.B_Next.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.B_Next.Size = new System.Drawing.Size(55, 54);
            this.B_Next.TabIndex = 2;
            this.B_Next.Text = "بعدی";
            this.B_Next.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.B_Next.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.B_Next.UseVisualStyleBackColor = true;
            //
            //B_First
            //
            this.B_First.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.B_First.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.B_First.ForeColor = System.Drawing.Color.Black;
            this.B_First.Image = (System.Drawing.Image)resources.GetObject("B_First.Image");
            this.B_First.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.B_First.Location = new System.Drawing.Point(168, 3);
            this.B_First.Name = "B_First";
            this.B_First.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.B_First.Size = new System.Drawing.Size(55, 54);
            this.B_First.TabIndex = 3;
            this.B_First.Text = "ابتدا";
            this.B_First.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.B_First.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.B_First.UseVisualStyleBackColor = true;
            //
            //B_Control
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6.0F, 13.0F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.B_First);
            this.Controls.Add(this.B_Next);
            this.Controls.Add(this.B_Per);
            this.Controls.Add(this.B_Last);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "B_Control";
            this.Size = new System.Drawing.Size(226, 61);
            this.ResumeLayout(false);

            //INSTANT C# NOTE: Converted design-time event handler wireups:
            B_First.Click += new System.EventHandler(B_First_Click);
            B_Next.Click += new System.EventHandler(B_Next_Click);
            B_Per.Click += new System.EventHandler(B_Per_Click);
            B_Last.Click += new System.EventHandler(B_Last_Click);
        }
        internal System.Windows.Forms.Button B_Last;
        internal System.Windows.Forms.Button B_Per;
        internal System.Windows.Forms.Button B_Next;
        internal System.Windows.Forms.Button B_First;


    }