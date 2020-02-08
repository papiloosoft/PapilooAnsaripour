using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;

using System;
using System.Globalization;

namespace Ansaripour
{
    public partial class RTLMonthCalendar : System.Windows.Forms.UserControl
    {
        //UserControl overrides dispose to clean up the component list.
        [System.Diagnostics.DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        //Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        //NOTE: The following procedure is required by the Windows Form Designer
        //It can be modified using the Windows Form Designer.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RTLMonthCalendar));
            this.lblDay2 = new System.Windows.Forms.Label();
            this.lblDay3 = new System.Windows.Forms.Label();
            this.lblDay4 = new System.Windows.Forms.Label();
            this.lblDay5 = new System.Windows.Forms.Label();
            this.lblDay6 = new System.Windows.Forms.Label();
            this.lblDay7 = new System.Windows.Forms.Label();
            this.lblDay8 = new System.Windows.Forms.Label();
            this.lblDay9 = new System.Windows.Forms.Label();
            this.lblDay10 = new System.Windows.Forms.Label();
            this.lblDay11 = new System.Windows.Forms.Label();
            this.lblDay12 = new System.Windows.Forms.Label();
            this.lblDay13 = new System.Windows.Forms.Label();
            this.lblDay14 = new System.Windows.Forms.Label();
            this.lblDay15 = new System.Windows.Forms.Label();
            this.lblDay16 = new System.Windows.Forms.Label();
            this.lblDay17 = new System.Windows.Forms.Label();
            this.lblDay18 = new System.Windows.Forms.Label();
            this.lblDay19 = new System.Windows.Forms.Label();
            this.lblDay20 = new System.Windows.Forms.Label();
            this.lblDay21 = new System.Windows.Forms.Label();
            this.lblDay22 = new System.Windows.Forms.Label();
            this.lblDay23 = new System.Windows.Forms.Label();
            this.lblDay24 = new System.Windows.Forms.Label();
            this.lblDay25 = new System.Windows.Forms.Label();
            this.lblDay26 = new System.Windows.Forms.Label();
            this.lblDay27 = new System.Windows.Forms.Label();
            this.lblDay28 = new System.Windows.Forms.Label();
            this.lblDay29 = new System.Windows.Forms.Label();
            this.lblDay30 = new System.Windows.Forms.Label();
            this.lblDay31 = new System.Windows.Forms.Label();
            this.lblDay32 = new System.Windows.Forms.Label();
            this.lblDay33 = new System.Windows.Forms.Label();
            this.lblDay34 = new System.Windows.Forms.Label();
            this.lblDay35 = new System.Windows.Forms.Label();
            this.lblDay36 = new System.Windows.Forms.Label();
            this.lblDay37 = new System.Windows.Forms.Label();
            this.lblDay38 = new System.Windows.Forms.Label();
            this.lblDay39 = new System.Windows.Forms.Label();
            this.lblDay40 = new System.Windows.Forms.Label();
            this.lblDay41 = new System.Windows.Forms.Label();
            this.lblDay42 = new System.Windows.Forms.Label();
            this.lblWeekDay1 = new System.Windows.Forms.Label();
            this.lblWeekDay2 = new System.Windows.Forms.Label();
            this.lblWeekDay3 = new System.Windows.Forms.Label();
            this.lblWeekDay4 = new System.Windows.Forms.Label();
            this.lblWeekDay5 = new System.Windows.Forms.Label();
            this.lblWeekDay6 = new System.Windows.Forms.Label();
            this.lblWeekDay7 = new System.Windows.Forms.Label();
            this.lblLine = new System.Windows.Forms.Label();
            this.picToday = new System.Windows.Forms.PictureBox();
            this.lblTodayTitle = new System.Windows.Forms.Label();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnPriorMonth = new System.Windows.Forms.Label();
            this.btnNextMonth = new System.Windows.Forms.Label();
            this.btnPriorYear = new System.Windows.Forms.Label();
            this.btnNextYear = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblDay1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)this.picToday).BeginInit();
            this.SuspendLayout();
            //
            //lblDay2
            //
            this.lblDay2.Location = new System.Drawing.Point(0, 0);
            this.lblDay2.Name = "lblDay2";
            this.lblDay2.Size = new System.Drawing.Size(100, 23);
            this.lblDay2.TabIndex = 0;
            //
            //lblDay3
            //
            this.lblDay3.Location = new System.Drawing.Point(0, 0);
            this.lblDay3.Name = "lblDay3";
            this.lblDay3.Size = new System.Drawing.Size(100, 23);
            this.lblDay3.TabIndex = 0;
            //
            //lblDay4
            //
            this.lblDay4.Location = new System.Drawing.Point(0, 0);
            this.lblDay4.Name = "lblDay4";
            this.lblDay4.Size = new System.Drawing.Size(100, 23);
            this.lblDay4.TabIndex = 0;
            //
            //lblDay5
            //
            this.lblDay5.Location = new System.Drawing.Point(0, 0);
            this.lblDay5.Name = "lblDay5";
            this.lblDay5.Size = new System.Drawing.Size(100, 23);
            this.lblDay5.TabIndex = 0;
            //
            //lblDay6
            //
            this.lblDay6.Location = new System.Drawing.Point(0, 0);
            this.lblDay6.Name = "lblDay6";
            this.lblDay6.Size = new System.Drawing.Size(100, 23);
            this.lblDay6.TabIndex = 0;
            //
            //lblDay7
            //
            this.lblDay7.BackColor = System.Drawing.Color.White;
            this.lblDay7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDay7.Location = new System.Drawing.Point(0, 0);
            this.lblDay7.Name = "lblDay7";
            this.lblDay7.Size = new System.Drawing.Size(100, 23);
            this.lblDay7.TabIndex = 0;
            //
            //lblDay8
            //
            this.lblDay8.Location = new System.Drawing.Point(0, 0);
            this.lblDay8.Name = "lblDay8";
            this.lblDay8.Size = new System.Drawing.Size(100, 23);
            this.lblDay8.TabIndex = 0;
            //
            //lblDay9
            //
            this.lblDay9.Location = new System.Drawing.Point(0, 0);
            this.lblDay9.Name = "lblDay9";
            this.lblDay9.Size = new System.Drawing.Size(100, 23);
            this.lblDay9.TabIndex = 0;
            //
            //lblDay10
            //
            this.lblDay10.Location = new System.Drawing.Point(0, 0);
            this.lblDay10.Name = "lblDay10";
            this.lblDay10.Size = new System.Drawing.Size(100, 23);
            this.lblDay10.TabIndex = 0;
            //
            //lblDay11
            //
            this.lblDay11.Location = new System.Drawing.Point(0, 0);
            this.lblDay11.Name = "lblDay11";
            this.lblDay11.Size = new System.Drawing.Size(100, 23);
            this.lblDay11.TabIndex = 0;
            //
            //lblDay12
            //
            this.lblDay12.Location = new System.Drawing.Point(0, 0);
            this.lblDay12.Name = "lblDay12";
            this.lblDay12.Size = new System.Drawing.Size(100, 23);
            this.lblDay12.TabIndex = 0;
            //
            //lblDay13
            //
            this.lblDay13.Location = new System.Drawing.Point(0, 0);
            this.lblDay13.Name = "lblDay13";
            this.lblDay13.Size = new System.Drawing.Size(100, 23);
            this.lblDay13.TabIndex = 0;
            //
            //lblDay14
            //
            this.lblDay14.Location = new System.Drawing.Point(0, 0);
            this.lblDay14.Name = "lblDay14";
            this.lblDay14.Size = new System.Drawing.Size(100, 23);
            this.lblDay14.TabIndex = 0;
            //
            //lblDay15
            //
            this.lblDay15.Location = new System.Drawing.Point(0, 0);
            this.lblDay15.Name = "lblDay15";
            this.lblDay15.Size = new System.Drawing.Size(100, 23);
            this.lblDay15.TabIndex = 0;
            //
            //lblDay16
            //
            this.lblDay16.Location = new System.Drawing.Point(0, 0);
            this.lblDay16.Name = "lblDay16";
            this.lblDay16.Size = new System.Drawing.Size(100, 23);
            this.lblDay16.TabIndex = 0;
            //
            //lblDay17
            //
            this.lblDay17.Location = new System.Drawing.Point(0, 0);
            this.lblDay17.Name = "lblDay17";
            this.lblDay17.Size = new System.Drawing.Size(100, 23);
            this.lblDay17.TabIndex = 0;
            //
            //lblDay18
            //
            this.lblDay18.Location = new System.Drawing.Point(0, 0);
            this.lblDay18.Name = "lblDay18";
            this.lblDay18.Size = new System.Drawing.Size(100, 23);
            this.lblDay18.TabIndex = 0;
            //
            //lblDay19
            //
            this.lblDay19.Location = new System.Drawing.Point(0, 0);
            this.lblDay19.Name = "lblDay19";
            this.lblDay19.Size = new System.Drawing.Size(100, 23);
            this.lblDay19.TabIndex = 0;
            //
            //lblDay20
            //
            this.lblDay20.Location = new System.Drawing.Point(0, 0);
            this.lblDay20.Name = "lblDay20";
            this.lblDay20.Size = new System.Drawing.Size(100, 23);
            this.lblDay20.TabIndex = 0;
            //
            //lblDay21
            //
            this.lblDay21.Location = new System.Drawing.Point(0, 0);
            this.lblDay21.Name = "lblDay21";
            this.lblDay21.Size = new System.Drawing.Size(100, 23);
            this.lblDay21.TabIndex = 0;
            //
            //lblDay22
            //
            this.lblDay22.Location = new System.Drawing.Point(0, 0);
            this.lblDay22.Name = "lblDay22";
            this.lblDay22.Size = new System.Drawing.Size(100, 23);
            this.lblDay22.TabIndex = 0;
            //
            //lblDay23
            //
            this.lblDay23.Location = new System.Drawing.Point(0, 0);
            this.lblDay23.Name = "lblDay23";
            this.lblDay23.Size = new System.Drawing.Size(100, 23);
            this.lblDay23.TabIndex = 0;
            //
            //lblDay24
            //
            this.lblDay24.Location = new System.Drawing.Point(0, 0);
            this.lblDay24.Name = "lblDay24";
            this.lblDay24.Size = new System.Drawing.Size(100, 23);
            this.lblDay24.TabIndex = 0;
            //
            //lblDay25
            //
            this.lblDay25.Location = new System.Drawing.Point(0, 0);
            this.lblDay25.Name = "lblDay25";
            this.lblDay25.Size = new System.Drawing.Size(100, 23);
            this.lblDay25.TabIndex = 0;
            //
            //lblDay26
            //
            this.lblDay26.Location = new System.Drawing.Point(0, 0);
            this.lblDay26.Name = "lblDay26";
            this.lblDay26.Size = new System.Drawing.Size(100, 23);
            this.lblDay26.TabIndex = 0;
            //
            //lblDay27
            //
            this.lblDay27.Location = new System.Drawing.Point(0, 0);
            this.lblDay27.Name = "lblDay27";
            this.lblDay27.Size = new System.Drawing.Size(100, 23);
            this.lblDay27.TabIndex = 0;
            //
            //lblDay28
            //
            this.lblDay28.Location = new System.Drawing.Point(0, 0);
            this.lblDay28.Name = "lblDay28";
            this.lblDay28.Size = new System.Drawing.Size(100, 23);
            this.lblDay28.TabIndex = 0;
            //
            //lblDay29
            //
            this.lblDay29.Location = new System.Drawing.Point(0, 0);
            this.lblDay29.Name = "lblDay29";
            this.lblDay29.Size = new System.Drawing.Size(100, 23);
            this.lblDay29.TabIndex = 0;
            //
            //lblDay30
            //
            this.lblDay30.Location = new System.Drawing.Point(0, 0);
            this.lblDay30.Name = "lblDay30";
            this.lblDay30.Size = new System.Drawing.Size(100, 23);
            this.lblDay30.TabIndex = 0;
            //
            //lblDay31
            //
            this.lblDay31.Location = new System.Drawing.Point(0, 0);
            this.lblDay31.Name = "lblDay31";
            this.lblDay31.Size = new System.Drawing.Size(100, 23);
            this.lblDay31.TabIndex = 0;
            //
            //lblDay32
            //
            this.lblDay32.Location = new System.Drawing.Point(0, 0);
            this.lblDay32.Name = "lblDay32";
            this.lblDay32.Size = new System.Drawing.Size(100, 23);
            this.lblDay32.TabIndex = 0;
            //
            //lblDay33
            //
            this.lblDay33.Location = new System.Drawing.Point(0, 0);
            this.lblDay33.Name = "lblDay33";
            this.lblDay33.Size = new System.Drawing.Size(100, 23);
            this.lblDay33.TabIndex = 0;
            //
            //lblDay34
            //
            this.lblDay34.Location = new System.Drawing.Point(0, 0);
            this.lblDay34.Name = "lblDay34";
            this.lblDay34.Size = new System.Drawing.Size(100, 23);
            this.lblDay34.TabIndex = 0;
            //
            //lblDay35
            //
            this.lblDay35.Location = new System.Drawing.Point(0, 0);
            this.lblDay35.Name = "lblDay35";
            this.lblDay35.Size = new System.Drawing.Size(100, 23);
            this.lblDay35.TabIndex = 0;
            //
            //lblDay36
            //
            this.lblDay36.Location = new System.Drawing.Point(0, 0);
            this.lblDay36.Name = "lblDay36";
            this.lblDay36.Size = new System.Drawing.Size(100, 23);
            this.lblDay36.TabIndex = 0;
            //
            //lblDay37
            //
            this.lblDay37.Location = new System.Drawing.Point(0, 0);
            this.lblDay37.Name = "lblDay37";
            this.lblDay37.Size = new System.Drawing.Size(100, 23);
            this.lblDay37.TabIndex = 0;
            //
            //lblDay38
            //
            this.lblDay38.Location = new System.Drawing.Point(0, 0);
            this.lblDay38.Name = "lblDay38";
            this.lblDay38.Size = new System.Drawing.Size(100, 23);
            this.lblDay38.TabIndex = 0;
            //
            //lblDay39
            //
            this.lblDay39.Location = new System.Drawing.Point(0, 0);
            this.lblDay39.Name = "lblDay39";
            this.lblDay39.Size = new System.Drawing.Size(100, 23);
            this.lblDay39.TabIndex = 0;
            //
            //lblDay40
            //
            this.lblDay40.Location = new System.Drawing.Point(0, 0);
            this.lblDay40.Name = "lblDay40";
            this.lblDay40.Size = new System.Drawing.Size(100, 23);
            this.lblDay40.TabIndex = 0;
            //
            //lblDay41
            //
            this.lblDay41.Location = new System.Drawing.Point(0, 0);
            this.lblDay41.Name = "lblDay41";
            this.lblDay41.Size = new System.Drawing.Size(100, 23);
            this.lblDay41.TabIndex = 0;
            //
            //lblDay42
            //
            this.lblDay42.Location = new System.Drawing.Point(0, 0);
            this.lblDay42.Name = "lblDay42";
            this.lblDay42.Size = new System.Drawing.Size(100, 23);
            this.lblDay42.TabIndex = 0;
            //
            //lblWeekDay1
            //
            this.lblWeekDay1.AutoEllipsis = true;
            this.lblWeekDay1.ForeColor = System.Drawing.Color.Blue;
            this.lblWeekDay1.Location = new System.Drawing.Point(286, 33);
            this.lblWeekDay1.Name = "lblWeekDay1";
            this.lblWeekDay1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblWeekDay1.Size = new System.Drawing.Size(29, 13);
            this.lblWeekDay1.TabIndex = 3;
            this.lblWeekDay1.Text = "شنبه";
            this.lblWeekDay1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            //lblWeekDay2
            //
            this.lblWeekDay2.AutoEllipsis = true;
            this.lblWeekDay2.ForeColor = System.Drawing.Color.Blue;
            this.lblWeekDay2.Location = new System.Drawing.Point(237, 33);
            this.lblWeekDay2.Name = "lblWeekDay2";
            this.lblWeekDay2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblWeekDay2.Size = new System.Drawing.Size(40, 13);
            this.lblWeekDay2.TabIndex = 4;
            this.lblWeekDay2.Text = "یکشنبه";
            this.lblWeekDay2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            //lblWeekDay3
            //
            this.lblWeekDay3.AutoEllipsis = true;
            this.lblWeekDay3.ForeColor = System.Drawing.Color.Blue;
            this.lblWeekDay3.Location = new System.Drawing.Point(191, 33);
            this.lblWeekDay3.Name = "lblWeekDay3";
            this.lblWeekDay3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblWeekDay3.Size = new System.Drawing.Size(40, 13);
            this.lblWeekDay3.TabIndex = 5;
            this.lblWeekDay3.Text = "دوشنبه";
            this.lblWeekDay3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            //lblWeekDay4
            //
            this.lblWeekDay4.AutoEllipsis = true;
            this.lblWeekDay4.ForeColor = System.Drawing.Color.Blue;
            this.lblWeekDay4.Location = new System.Drawing.Point(145, 33);
            this.lblWeekDay4.Name = "lblWeekDay4";
            this.lblWeekDay4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblWeekDay4.Size = new System.Drawing.Size(46, 13);
            this.lblWeekDay4.TabIndex = 6;
            this.lblWeekDay4.Text = "سه شنبه";
            this.lblWeekDay4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            //lblWeekDay5
            //
            this.lblWeekDay5.AutoEllipsis = true;
            this.lblWeekDay5.ForeColor = System.Drawing.Color.Blue;
            this.lblWeekDay5.Location = new System.Drawing.Point(89, 33);
            this.lblWeekDay5.Name = "lblWeekDay5";
            this.lblWeekDay5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblWeekDay5.Size = new System.Drawing.Size(51, 13);
            this.lblWeekDay5.TabIndex = 7;
            this.lblWeekDay5.Text = "چهارشنبه";
            this.lblWeekDay5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            //lblWeekDay6
            //
            this.lblWeekDay6.AutoEllipsis = true;
            this.lblWeekDay6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.lblWeekDay6.ForeColor = System.Drawing.Color.Blue;
            this.lblWeekDay6.Location = new System.Drawing.Point(34, 33);
            this.lblWeekDay6.Name = "lblWeekDay6";
            this.lblWeekDay6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblWeekDay6.Size = new System.Drawing.Size(59, 13);
            this.lblWeekDay6.TabIndex = 8;
            this.lblWeekDay6.Text = "پنجشنبه";
            this.lblWeekDay6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            //lblWeekDay7
            //
            this.lblWeekDay7.AutoEllipsis = true;
            this.lblWeekDay7.ForeColor = System.Drawing.Color.Red;
            this.lblWeekDay7.Location = new System.Drawing.Point(9, 33);
            this.lblWeekDay7.Name = "lblWeekDay7";
            this.lblWeekDay7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblWeekDay7.Size = new System.Drawing.Size(30, 13);
            this.lblWeekDay7.TabIndex = 9;
            this.lblWeekDay7.Text = "جمعه";
            this.lblWeekDay7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            //lblLine
            //
            this.lblLine.BackColor = System.Drawing.Color.Black;
            this.lblLine.Location = new System.Drawing.Point(5, 47);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(318, 1);
            this.lblLine.TabIndex = 52;
            this.lblLine.Text = " ";
            //
            //picToday
            //
            this.picToday.Image = (System.Drawing.Image)resources.GetObject("picToday.Image");
            this.picToday.Location = new System.Drawing.Point(301, 144);
            this.picToday.Name = "picToday";
            this.picToday.Size = new System.Drawing.Size(16, 16);
            this.picToday.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picToday.TabIndex = 53;
            this.picToday.TabStop = false;
            //
            //lblTodayTitle
            //
            this.lblTodayTitle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.lblTodayTitle.Location = new System.Drawing.Point(162, 143);
            this.lblTodayTitle.Name = "lblTodayTitle";
            this.lblTodayTitle.Size = new System.Drawing.Size(133, 26);
            this.lblTodayTitle.TabIndex = 55;
            this.lblTodayTitle.Text = "ÇãÑæÒ : 1384/01/01";
            //
            //btnPriorMonth
            //
            this.btnPriorMonth.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPriorMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.btnPriorMonth.Image = (System.Drawing.Image)resources.GetObject("btnPriorMonth.Image");
            this.btnPriorMonth.Location = new System.Drawing.Point(268, 7);
            this.btnPriorMonth.Name = "btnPriorMonth";
            this.btnPriorMonth.Size = new System.Drawing.Size(22, 16);
            this.btnPriorMonth.TabIndex = 59;
            this.btnPriorMonth.Text = "  ";
            this.ToolTip1.SetToolTip(this.btnPriorMonth, "ãÇå ÞÈá");
            //
            //btnNextMonth
            //
            this.btnNextMonth.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNextMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.btnNextMonth.Image = (System.Drawing.Image)resources.GetObject("btnNextMonth.Image");
            this.btnNextMonth.Location = new System.Drawing.Point(27, 5);
            this.btnNextMonth.Name = "btnNextMonth";
            this.btnNextMonth.Size = new System.Drawing.Size(22, 16);
            this.btnNextMonth.TabIndex = 60;
            this.btnNextMonth.Text = "  ";
            this.ToolTip1.SetToolTip(this.btnNextMonth, "ãÇå ÈÚÏ");
            //
            //btnPriorYear
            //
            this.btnPriorYear.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPriorYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.btnPriorYear.Image = (System.Drawing.Image)resources.GetObject("btnPriorYear.Image");
            this.btnPriorYear.Location = new System.Drawing.Point(293, 7);
            this.btnPriorYear.Name = "btnPriorYear";
            this.btnPriorYear.Size = new System.Drawing.Size(22, 16);
            this.btnPriorYear.TabIndex = 61;
            this.btnPriorYear.Text = "  ";
            this.ToolTip1.SetToolTip(this.btnPriorYear, "ãÇå ÞÈá");
            //
            //btnNextYear
            //
            this.btnNextYear.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNextYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.btnNextYear.Image = (System.Drawing.Image)resources.GetObject("btnNextYear.Image");
            this.btnNextYear.Location = new System.Drawing.Point(3, 5);
            this.btnNextYear.Name = "btnNextYear";
            this.btnNextYear.Size = new System.Drawing.Size(22, 16);
            this.btnNextYear.TabIndex = 62;
            this.btnNextYear.Text = "  ";
            this.ToolTip1.SetToolTip(this.btnNextYear, "ãÇå ÈÚÏ");
            //
            //lblTitle
            //
            this.lblTitle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(331, 30);
            this.lblTitle.TabIndex = 58;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            //ImageList1
            //
            this.ImageList1.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("ImageList1.ImageStream");
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList1.Images.SetKeyName(0, "");
            this.ImageList1.Images.SetKeyName(1, "Today.bmp");
            //
            //lblDay1
            //
            this.lblDay1.Location = new System.Drawing.Point(0, 0);
            this.lblDay1.Name = "lblDay1";
            this.lblDay1.Size = new System.Drawing.Size(100, 23);
            this.lblDay1.TabIndex = 63;
            //
            //RTLMonthCalendar
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6.0F, 13.0F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnNextYear);
            this.Controls.Add(this.btnPriorYear);
            this.Controls.Add(this.btnNextMonth);
            this.Controls.Add(this.btnPriorMonth);
            this.Controls.Add(this.lblTodayTitle);
            this.Controls.Add(this.picToday);
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.lblWeekDay1);
            this.Controls.Add(this.lblWeekDay2);
            this.Controls.Add(this.lblWeekDay3);
            this.Controls.Add(this.lblWeekDay4);
            this.Controls.Add(this.lblWeekDay5);
            this.Controls.Add(this.lblWeekDay6);
            this.Controls.Add(this.lblWeekDay7);
            this.Controls.Add(this.lblDay2);
            this.Controls.Add(this.lblDay3);
            this.Controls.Add(this.lblDay4);
            this.Controls.Add(this.lblDay5);
            this.Controls.Add(this.lblDay6);
            this.Controls.Add(this.lblDay7);
            this.Controls.Add(this.lblDay8);
            this.Controls.Add(this.lblDay9);
            this.Controls.Add(this.lblDay10);
            this.Controls.Add(this.lblDay11);
            this.Controls.Add(this.lblDay12);
            this.Controls.Add(this.lblDay13);
            this.Controls.Add(this.lblDay14);
            this.Controls.Add(this.lblDay15);
            this.Controls.Add(this.lblDay16);
            this.Controls.Add(this.lblDay17);
            this.Controls.Add(this.lblDay18);
            this.Controls.Add(this.lblDay19);
            this.Controls.Add(this.lblDay20);
            this.Controls.Add(this.lblDay21);
            this.Controls.Add(this.lblDay22);
            this.Controls.Add(this.lblDay23);
            this.Controls.Add(this.lblDay24);
            this.Controls.Add(this.lblDay25);
            this.Controls.Add(this.lblDay26);
            this.Controls.Add(this.lblDay27);
            this.Controls.Add(this.lblDay28);
            this.Controls.Add(this.lblDay29);
            this.Controls.Add(this.lblDay30);
            this.Controls.Add(this.lblDay31);
            this.Controls.Add(this.lblDay32);
            this.Controls.Add(this.lblDay33);
            this.Controls.Add(this.lblDay34);
            this.Controls.Add(this.lblDay35);
            this.Controls.Add(this.lblDay36);
            this.Controls.Add(this.lblDay37);
            this.Controls.Add(this.lblDay38);
            this.Controls.Add(this.lblDay39);
            this.Controls.Add(this.lblDay40);
            this.Controls.Add(this.lblDay41);
            this.Controls.Add(this.lblDay42);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblDay1);
            this.Name = "RTLMonthCalendar";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(331, 169);
            ((System.ComponentModel.ISupportInitialize)this.picToday).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal System.Windows.Forms.Label lblDay2;
        internal System.Windows.Forms.Label lblDay3;
        internal System.Windows.Forms.Label lblDay4;
        internal System.Windows.Forms.Label lblDay5;
        internal System.Windows.Forms.Label lblDay6;
        internal System.Windows.Forms.Label lblDay7;
        internal System.Windows.Forms.Label lblDay8;
        internal System.Windows.Forms.Label lblDay9;
        internal System.Windows.Forms.Label lblDay10;
        internal System.Windows.Forms.Label lblDay11;
        internal System.Windows.Forms.Label lblDay12;
        internal System.Windows.Forms.Label lblDay13;
        internal System.Windows.Forms.Label lblDay14;
        internal System.Windows.Forms.Label lblDay15;
        internal System.Windows.Forms.Label lblDay16;
        internal System.Windows.Forms.Label lblDay17;
        internal System.Windows.Forms.Label lblDay18;
        internal System.Windows.Forms.Label lblDay19;
        internal System.Windows.Forms.Label lblDay20;
        internal System.Windows.Forms.Label lblDay21;
        internal System.Windows.Forms.Label lblDay22;
        internal System.Windows.Forms.Label lblDay23;
        internal System.Windows.Forms.Label lblDay24;
        internal System.Windows.Forms.Label lblDay25;
        internal System.Windows.Forms.Label lblDay26;
        internal System.Windows.Forms.Label lblDay27;
        internal System.Windows.Forms.Label lblDay28;
        internal System.Windows.Forms.Label lblDay29;
        internal System.Windows.Forms.Label lblDay30;
        internal System.Windows.Forms.Label lblDay31;
        internal System.Windows.Forms.Label lblDay32;
        internal System.Windows.Forms.Label lblDay33;
        internal System.Windows.Forms.Label lblDay34;
        internal System.Windows.Forms.Label lblDay35;
        internal System.Windows.Forms.Label lblDay36;
        internal System.Windows.Forms.Label lblDay37;
        internal System.Windows.Forms.Label lblDay38;
        internal System.Windows.Forms.Label lblDay39;
        internal System.Windows.Forms.Label lblDay40;
        internal System.Windows.Forms.Label lblDay41;
        internal System.Windows.Forms.Label lblDay42;

        internal System.Windows.Forms.Label lblWeekDay1;
        internal System.Windows.Forms.Label lblWeekDay2;
        internal System.Windows.Forms.Label lblWeekDay3;
        internal System.Windows.Forms.Label lblWeekDay4;
        internal System.Windows.Forms.Label lblWeekDay5;
        internal System.Windows.Forms.Label lblWeekDay6;
        internal System.Windows.Forms.Label lblWeekDay7;
        internal System.Windows.Forms.Label lblLine;
        internal System.Windows.Forms.PictureBox picToday;
        internal System.Windows.Forms.Label lblTodayTitle;
        internal System.Windows.Forms.ToolTip ToolTip1;
        internal System.Windows.Forms.Label lblTitle;
        internal System.Windows.Forms.ImageList ImageList1;
        internal System.Windows.Forms.Label btnPriorMonth;
        internal System.Windows.Forms.Label btnNextMonth;
        internal System.Windows.Forms.Label btnPriorYear;
        internal System.Windows.Forms.Label btnNextYear;
        internal System.Windows.Forms.Label lblDay1;

    }
}