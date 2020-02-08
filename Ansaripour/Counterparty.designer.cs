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
    public partial class Counterparty : System.Windows.Forms.Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Counterparty));
            System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.L_Counterparty_Id = new System.Windows.Forms.Label();
            this.L_Counterparty_Family = new System.Windows.Forms.Label();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.New_B = new System.Windows.Forms.ToolStripButton();
            this.Edit_B = new System.Windows.Forms.ToolStripButton();
            this.Delet_B = new System.Windows.Forms.ToolStripButton();
            this.Save_B = new System.Windows.Forms.ToolStripButton();
            this.Picture_B = new System.Windows.Forms.ToolStripButton();
            this.Search_B = new System.Windows.Forms.ToolStripButton();
            this.Excel_B = new System.Windows.Forms.ToolStripButton();
            this.Print_B = new System.Windows.Forms.ToolStripButton();
            this.Abort_B = new System.Windows.Forms.ToolStripButton();
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Counterparty_Address = new System.Windows.Forms.TextBox();
            this.Counterparty_Bank_Number = new System.Windows.Forms.TextBox();
            this.Counterparty_Economic_Code = new System.Windows.Forms.TextBox();
            this.Counterparty_National_Code = new System.Windows.Forms.TextBox();
            this.Counterparty_Postal_Code = new System.Windows.Forms.TextBox();
            this.Counterparty_Mobile = new System.Windows.Forms.TextBox();
            this.Counterparty_Manager = new System.Windows.Forms.TextBox();
            this.Counterparty_Fax = new System.Windows.Forms.TextBox();
            this.Counterparty_Phone = new System.Windows.Forms.TextBox();
            this.Counterparty_Registration_Number = new System.Windows.Forms.TextBox();
            this.Counterparty_Family = new System.Windows.Forms.TextBox();
            this.Counterparty_Name = new System.Windows.Forms.TextBox();
            this.Counterparty_Subscribe = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.L_Counterparty_Email = new System.Windows.Forms.Label();
            this.Counterparty_Email = new System.Windows.Forms.TextBox();
            this.L_Counterparty_Name = new System.Windows.Forms.Label();
            this.L_Counterparty_Manager = new System.Windows.Forms.Label();
            this.L_Counterparty_Phone = new System.Windows.Forms.Label();
            this.L_Counterparty_City = new System.Windows.Forms.Label();
            this.Counterparty_City = new System.Windows.Forms.TextBox();
            this.B_Counterparty_City = new System.Windows.Forms.Button();
            this.L_Counterparty_State = new System.Windows.Forms.Label();
            this.Counterparty_State = new System.Windows.Forms.TextBox();
            this.B_Counterparty_State = new System.Windows.Forms.Button();
            this.L_Counterparty_Personality_Type = new System.Windows.Forms.Label();
            this.Counterparty_Buyer_Type = new System.Windows.Forms.ComboBox();
            this.Counterparty_Personality_Type = new System.Windows.Forms.ComboBox();
            this.L_Counterparty_NationalCode = new System.Windows.Forms.Label();
            this.L_Counterparty_Mobile = new System.Windows.Forms.Label();
            this.L_Counterparty_Address = new System.Windows.Forms.Label();
            this.L_Counterparty_Economic_Code = new System.Windows.Forms.Label();
            this.L_Counterparty_Postal_Code = new System.Windows.Forms.Label();
            this.L_Counterparty_Buyer_Type = new System.Windows.Forms.Label();
            this.DV = new System.Windows.Forms.DataGridView();
            this.ToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.SplitContainer1).BeginInit();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.DV).BeginInit();
            this.SuspendLayout();
            //
            //L_Counterparty_Id
            //
            this.L_Counterparty_Id.AutoSize = true;
            this.L_Counterparty_Id.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.L_Counterparty_Id.Location = new System.Drawing.Point(911, 36);
            this.L_Counterparty_Id.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.L_Counterparty_Id.Name = "L_Counterparty_Id";
            this.L_Counterparty_Id.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.L_Counterparty_Id.Size = new System.Drawing.Size(32, 19);
            this.L_Counterparty_Id.TabIndex = 56;
            this.L_Counterparty_Id.Text = "کد:";
            //
            //L_Counterparty_Family
            //
            this.L_Counterparty_Family.AutoSize = true;
            this.L_Counterparty_Family.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.L_Counterparty_Family.Location = new System.Drawing.Point(443, 67);
            this.L_Counterparty_Family.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.L_Counterparty_Family.Name = "L_Counterparty_Family";
            this.L_Counterparty_Family.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.L_Counterparty_Family.Size = new System.Drawing.Size(167, 19);
            this.L_Counterparty_Family.TabIndex = 66;
            this.L_Counterparty_Family.Text = "نام خانوادگی / شرکت :";
            //
            //ToolStrip1
            //
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.New_B, this.Edit_B, this.Delet_B, this.Save_B, this.Picture_B, this.Search_B, this.Excel_B, this.Print_B, this.Abort_B });
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ToolStrip1.Size = new System.Drawing.Size(960, 25);
            this.ToolStrip1.TabIndex = 20;
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
            //Picture_B
            //
            this.Picture_B.Image = (System.Drawing.Image)resources.GetObject("Picture_B.Image");
            this.Picture_B.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Picture_B.Name = "Picture_B";
            this.Picture_B.Size = new System.Drawing.Size(59, 22);
            this.Picture_B.Text = "تصویر";
            //
            //Search_B
            //
            this.Search_B.Image = (System.Drawing.Image)resources.GetObject("Search_B.Image");
            this.Search_B.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Search_B.Name = "Search_B";
            this.Search_B.Size = new System.Drawing.Size(61, 22);
            this.Search_B.Text = "جستجو";
            //
            //Excel_B
            //
            this.Excel_B.Image = (System.Drawing.Image)resources.GetObject("Excel_B.Image");
            this.Excel_B.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Excel_B.Name = "Excel_B";
            this.Excel_B.Size = new System.Drawing.Size(54, 22);
            this.Excel_B.Text = "اکسل";
            //
            //Print_B
            //
            this.Print_B.Image = (System.Drawing.Image)resources.GetObject("Print_B.Image");
            this.Print_B.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Print_B.Name = "Print_B";
            this.Print_B.Size = new System.Drawing.Size(48, 22);
            this.Print_B.Text = "چاپ";
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
            this.SplitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SplitContainer1.Panel1.Controls.Add(this.Counterparty_Address);
            this.SplitContainer1.Panel1.Controls.Add(this.Counterparty_Bank_Number);
            this.SplitContainer1.Panel1.Controls.Add(this.Counterparty_Economic_Code);
            this.SplitContainer1.Panel1.Controls.Add(this.Counterparty_National_Code);
            this.SplitContainer1.Panel1.Controls.Add(this.Counterparty_Postal_Code);
            this.SplitContainer1.Panel1.Controls.Add(this.Counterparty_Mobile);
            this.SplitContainer1.Panel1.Controls.Add(this.Counterparty_Manager);
            this.SplitContainer1.Panel1.Controls.Add(this.Counterparty_Fax);
            this.SplitContainer1.Panel1.Controls.Add(this.Counterparty_Phone);
            this.SplitContainer1.Panel1.Controls.Add(this.Counterparty_Registration_Number);
            this.SplitContainer1.Panel1.Controls.Add(this.Counterparty_Family);
            this.SplitContainer1.Panel1.Controls.Add(this.Counterparty_Name);
            this.SplitContainer1.Panel1.Controls.Add(this.Counterparty_Subscribe);
            this.SplitContainer1.Panel1.Controls.Add(this.Label2);
            this.SplitContainer1.Panel1.Controls.Add(this.Label6);
            this.SplitContainer1.Panel1.Controls.Add(this.Label1);
            this.SplitContainer1.Panel1.Controls.Add(this.L_Counterparty_Email);
            this.SplitContainer1.Panel1.Controls.Add(this.Counterparty_Email);
            this.SplitContainer1.Panel1.Controls.Add(this.L_Counterparty_Name);
            this.SplitContainer1.Panel1.Controls.Add(this.L_Counterparty_Manager);
            this.SplitContainer1.Panel1.Controls.Add(this.L_Counterparty_Phone);
            this.SplitContainer1.Panel1.Controls.Add(this.L_Counterparty_City);
            this.SplitContainer1.Panel1.Controls.Add(this.Counterparty_City);
            this.SplitContainer1.Panel1.Controls.Add(this.B_Counterparty_City);
            this.SplitContainer1.Panel1.Controls.Add(this.L_Counterparty_State);
            this.SplitContainer1.Panel1.Controls.Add(this.Counterparty_State);
            this.SplitContainer1.Panel1.Controls.Add(this.B_Counterparty_State);
            this.SplitContainer1.Panel1.Controls.Add(this.L_Counterparty_Personality_Type);
            this.SplitContainer1.Panel1.Controls.Add(this.Counterparty_Buyer_Type);
            this.SplitContainer1.Panel1.Controls.Add(this.Counterparty_Personality_Type);
            this.SplitContainer1.Panel1.Controls.Add(this.L_Counterparty_NationalCode);
            this.SplitContainer1.Panel1.Controls.Add(this.L_Counterparty_Mobile);
            this.SplitContainer1.Panel1.Controls.Add(this.L_Counterparty_Address);
            this.SplitContainer1.Panel1.Controls.Add(this.L_Counterparty_Economic_Code);
            this.SplitContainer1.Panel1.Controls.Add(this.L_Counterparty_Postal_Code);
            this.SplitContainer1.Panel1.Controls.Add(this.ToolStrip1);
            this.SplitContainer1.Panel1.Controls.Add(this.L_Counterparty_Family);
            this.SplitContainer1.Panel1.Controls.Add(this.L_Counterparty_Id);
            this.SplitContainer1.Panel1.Controls.Add(this.L_Counterparty_Buyer_Type);
            this.SplitContainer1.Panel1.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.SplitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            //
            //SplitContainer1.Panel2
            //
            this.SplitContainer1.Panel2.Controls.Add(this.DV);
            this.SplitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SplitContainer1.Size = new System.Drawing.Size(960, 588);
            this.SplitContainer1.SplitterDistance = 293;
            this.SplitContainer1.TabIndex = 65;
            //
            //Counterparty_Address
            //
            this.Counterparty_Address.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Counterparty_Address.Location = new System.Drawing.Point(8, 261);
            this.Counterparty_Address.Name = "Counterparty_Address";
            this.Counterparty_Address.Size = new System.Drawing.Size(877, 27);
            this.Counterparty_Address.TabIndex = 19;
            //
            //Counterparty_Bank_Number
            //
            this.Counterparty_Bank_Number.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Counterparty_Bank_Number.Location = new System.Drawing.Point(8, 229);
            this.Counterparty_Bank_Number.Name = "Counterparty_Bank_Number";
            this.Counterparty_Bank_Number.Size = new System.Drawing.Size(846, 27);
            this.Counterparty_Bank_Number.TabIndex = 18;
            //
            //Counterparty_Economic_Code
            //
            this.Counterparty_Economic_Code.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Counterparty_Economic_Code.Location = new System.Drawing.Point(8, 164);
            this.Counterparty_Economic_Code.Name = "Counterparty_Economic_Code";
            this.Counterparty_Economic_Code.Size = new System.Drawing.Size(207, 27);
            this.Counterparty_Economic_Code.TabIndex = 12;
            //
            //Counterparty_National_Code
            //
            this.Counterparty_National_Code.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Counterparty_National_Code.Location = new System.Drawing.Point(350, 163);
            this.Counterparty_National_Code.Name = "Counterparty_National_Code";
            this.Counterparty_National_Code.Size = new System.Drawing.Size(176, 27);
            this.Counterparty_National_Code.TabIndex = 11;
            //
            //Counterparty_Postal_Code
            //
            this.Counterparty_Postal_Code.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Counterparty_Postal_Code.Location = new System.Drawing.Point(656, 163);
            this.Counterparty_Postal_Code.Name = "Counterparty_Postal_Code";
            this.Counterparty_Postal_Code.Size = new System.Drawing.Size(198, 27);
            this.Counterparty_Postal_Code.TabIndex = 10;
            //
            //Counterparty_Mobile
            //
            this.Counterparty_Mobile.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Counterparty_Mobile.Location = new System.Drawing.Point(8, 128);
            this.Counterparty_Mobile.Name = "Counterparty_Mobile";
            this.Counterparty_Mobile.Size = new System.Drawing.Size(207, 27);
            this.Counterparty_Mobile.TabIndex = 9;
            //
            //Counterparty_Manager
            //
            this.Counterparty_Manager.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Counterparty_Manager.Location = new System.Drawing.Point(350, 131);
            this.Counterparty_Manager.Name = "Counterparty_Manager";
            this.Counterparty_Manager.Size = new System.Drawing.Size(464, 27);
            this.Counterparty_Manager.TabIndex = 8;
            //
            //Counterparty_Fax
            //
            this.Counterparty_Fax.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Counterparty_Fax.Location = new System.Drawing.Point(8, 95);
            this.Counterparty_Fax.Name = "Counterparty_Fax";
            this.Counterparty_Fax.Size = new System.Drawing.Size(207, 27);
            this.Counterparty_Fax.TabIndex = 7;
            //
            //Counterparty_Phone
            //
            this.Counterparty_Phone.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Counterparty_Phone.Location = new System.Drawing.Point(350, 97);
            this.Counterparty_Phone.Name = "Counterparty_Phone";
            this.Counterparty_Phone.Size = new System.Drawing.Size(176, 27);
            this.Counterparty_Phone.TabIndex = 6;
            //
            //Counterparty_Registration_Number
            //
            this.Counterparty_Registration_Number.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Counterparty_Registration_Number.Location = new System.Drawing.Point(632, 98);
            this.Counterparty_Registration_Number.Name = "Counterparty_Registration_Number";
            this.Counterparty_Registration_Number.Size = new System.Drawing.Size(208, 27);
            this.Counterparty_Registration_Number.TabIndex = 5;
            //
            //Counterparty_Family
            //
            this.Counterparty_Family.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Counterparty_Family.Location = new System.Drawing.Point(8, 64);
            this.Counterparty_Family.Name = "Counterparty_Family";
            this.Counterparty_Family.Size = new System.Drawing.Size(433, 27);
            this.Counterparty_Family.TabIndex = 4;
            //
            //Counterparty_Name
            //
            this.Counterparty_Name.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Counterparty_Name.Location = new System.Drawing.Point(612, 64);
            this.Counterparty_Name.Name = "Counterparty_Name";
            this.Counterparty_Name.Size = new System.Drawing.Size(295, 27);
            this.Counterparty_Name.TabIndex = 3;
            //
            //Counterparty_Subscribe
            //
            this.Counterparty_Subscribe.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Counterparty_Subscribe.Location = new System.Drawing.Point(754, 32);
            this.Counterparty_Subscribe.Name = "Counterparty_Subscribe";
            this.Counterparty_Subscribe.Size = new System.Drawing.Size(153, 27);
            this.Counterparty_Subscribe.TabIndex = 0;
            //
            //Label2
            //
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label2.Location = new System.Drawing.Point(854, 232);
            this.Label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label2.Size = new System.Drawing.Size(104, 19);
            this.Label2.TabIndex = 219;
            this.Label2.Text = "حساب بانکی:";
            //
            //Label6
            //
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label6.Location = new System.Drawing.Point(837, 100);
            this.Label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label6.Name = "Label6";
            this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label6.Size = new System.Drawing.Size(95, 19);
            this.Label6.TabIndex = 217;
            this.Label6.Text = "شماره ثبت :";
            //
            //Label1
            //
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label1.Location = new System.Drawing.Point(219, 98);
            this.Label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label1.Size = new System.Drawing.Size(111, 19);
            this.Label1.TabIndex = 215;
            this.Label1.Text = "شماره فاکس :";
            //
            //L_Counterparty_Email
            //
            this.L_Counterparty_Email.AutoSize = true;
            this.L_Counterparty_Email.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.L_Counterparty_Email.Location = new System.Drawing.Point(784, 200);
            this.L_Counterparty_Email.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.L_Counterparty_Email.Name = "L_Counterparty_Email";
            this.L_Counterparty_Email.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.L_Counterparty_Email.Size = new System.Drawing.Size(144, 19);
            this.L_Counterparty_Email.TabIndex = 214;
            this.L_Counterparty_Email.Text = "نشانی الکترونیکی :";
            //
            //Counterparty_Email
            //
            this.Counterparty_Email.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Counterparty_Email.Location = new System.Drawing.Point(561, 196);
            this.Counterparty_Email.Name = "Counterparty_Email";
            this.Counterparty_Email.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Counterparty_Email.Size = new System.Drawing.Size(219, 27);
            this.Counterparty_Email.TabIndex = 13;
            //
            //L_Counterparty_Name
            //
            this.L_Counterparty_Name.AutoSize = true;
            this.L_Counterparty_Name.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.L_Counterparty_Name.Location = new System.Drawing.Point(909, 67);
            this.L_Counterparty_Name.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.L_Counterparty_Name.Name = "L_Counterparty_Name";
            this.L_Counterparty_Name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.L_Counterparty_Name.Size = new System.Drawing.Size(38, 19);
            this.L_Counterparty_Name.TabIndex = 212;
            this.L_Counterparty_Name.Text = "نام :";
            //
            //L_Counterparty_Manager
            //
            this.L_Counterparty_Manager.AutoSize = true;
            this.L_Counterparty_Manager.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.L_Counterparty_Manager.Location = new System.Drawing.Point(811, 134);
            this.L_Counterparty_Manager.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.L_Counterparty_Manager.Name = "L_Counterparty_Manager";
            this.L_Counterparty_Manager.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.L_Counterparty_Manager.Size = new System.Drawing.Size(117, 19);
            this.L_Counterparty_Manager.TabIndex = 210;
            this.L_Counterparty_Manager.Text = "نام(مدیر عامل) :";
            //
            //L_Counterparty_Phone
            //
            this.L_Counterparty_Phone.AutoSize = true;
            this.L_Counterparty_Phone.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.L_Counterparty_Phone.Location = new System.Drawing.Point(524, 100);
            this.L_Counterparty_Phone.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.L_Counterparty_Phone.Name = "L_Counterparty_Phone";
            this.L_Counterparty_Phone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.L_Counterparty_Phone.Size = new System.Drawing.Size(108, 19);
            this.L_Counterparty_Phone.TabIndex = 207;
            this.L_Counterparty_Phone.Text = "شماره تماس :";
            //
            //L_Counterparty_City
            //
            this.L_Counterparty_City.AutoSize = true;
            this.L_Counterparty_City.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.L_Counterparty_City.Location = new System.Drawing.Point(219, 200);
            this.L_Counterparty_City.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.L_Counterparty_City.Name = "L_Counterparty_City";
            this.L_Counterparty_City.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.L_Counterparty_City.Size = new System.Drawing.Size(52, 19);
            this.L_Counterparty_City.TabIndex = 206;
            this.L_Counterparty_City.Text = "شهر :";
            //
            //Counterparty_City
            //
            this.Counterparty_City.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Counterparty_City.Location = new System.Drawing.Point(38, 196);
            this.Counterparty_City.Name = "Counterparty_City";
            this.Counterparty_City.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Counterparty_City.Size = new System.Drawing.Size(177, 27);
            this.Counterparty_City.TabIndex = 16;
            //
            //B_Counterparty_City
            //
            this.B_Counterparty_City.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.B_Counterparty_City.Image = (System.Drawing.Image)resources.GetObject("B_Counterparty_City.Image");
            this.B_Counterparty_City.Location = new System.Drawing.Point(7, 196);
            this.B_Counterparty_City.Name = "B_Counterparty_City";
            this.B_Counterparty_City.Size = new System.Drawing.Size(29, 27);
            this.B_Counterparty_City.TabIndex = 17;
            this.B_Counterparty_City.UseVisualStyleBackColor = true;
            //
            //L_Counterparty_State
            //
            this.L_Counterparty_State.AutoSize = true;
            this.L_Counterparty_State.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.L_Counterparty_State.Location = new System.Drawing.Point(488, 200);
            this.L_Counterparty_State.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.L_Counterparty_State.Name = "L_Counterparty_State";
            this.L_Counterparty_State.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.L_Counterparty_State.Size = new System.Drawing.Size(62, 19);
            this.L_Counterparty_State.TabIndex = 203;
            this.L_Counterparty_State.Text = "استان :";
            //
            //Counterparty_State
            //
            this.Counterparty_State.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Counterparty_State.Location = new System.Drawing.Point(336, 196);
            this.Counterparty_State.Name = "Counterparty_State";
            this.Counterparty_State.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Counterparty_State.Size = new System.Drawing.Size(150, 27);
            this.Counterparty_State.TabIndex = 14;
            //
            //B_Counterparty_State
            //
            this.B_Counterparty_State.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.B_Counterparty_State.Image = (System.Drawing.Image)resources.GetObject("B_Counterparty_State.Image");
            this.B_Counterparty_State.Location = new System.Drawing.Point(306, 197);
            this.B_Counterparty_State.Name = "B_Counterparty_State";
            this.B_Counterparty_State.Size = new System.Drawing.Size(29, 27);
            this.B_Counterparty_State.TabIndex = 15;
            this.B_Counterparty_State.UseVisualStyleBackColor = true;
            //
            //L_Counterparty_Personality_Type
            //
            this.L_Counterparty_Personality_Type.AutoSize = true;
            this.L_Counterparty_Personality_Type.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.L_Counterparty_Personality_Type.Location = new System.Drawing.Point(646, 36);
            this.L_Counterparty_Personality_Type.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.L_Counterparty_Personality_Type.Name = "L_Counterparty_Personality_Type";
            this.L_Counterparty_Personality_Type.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.L_Counterparty_Personality_Type.Size = new System.Drawing.Size(106, 19);
            this.L_Counterparty_Personality_Type.TabIndex = 199;
            this.L_Counterparty_Personality_Type.Text = "نوع شخصیت :";
            //
            //Counterparty_Buyer_Type
            //
            this.Counterparty_Buyer_Type.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Counterparty_Buyer_Type.FormattingEnabled = true;
            this.Counterparty_Buyer_Type.Items.AddRange(new object[] { "مودی مشمول ثبت نام در نظام مالیاتی /سایر مودیان", "مشمولین حقیقی ماده 81 ق . م.م", "اشخاصی که ملزم به ثبت نام در نظام مالیاتی نیستند" });
            this.Counterparty_Buyer_Type.Location = new System.Drawing.Point(8, 33);
            this.Counterparty_Buyer_Type.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Counterparty_Buyer_Type.Name = "Counterparty_Buyer_Type";
            this.Counterparty_Buyer_Type.Size = new System.Drawing.Size(433, 27);
            this.Counterparty_Buyer_Type.TabIndex = 2;
            //
            //Counterparty_Personality_Type
            //
            this.Counterparty_Personality_Type.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Counterparty_Personality_Type.FormattingEnabled = true;
            this.Counterparty_Personality_Type.Items.AddRange(new object[] { "حقوقی", "حـقیقی" });
            this.Counterparty_Personality_Type.Location = new System.Drawing.Point(545, 32);
            this.Counterparty_Personality_Type.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Counterparty_Personality_Type.Name = "Counterparty_Personality_Type";
            this.Counterparty_Personality_Type.Size = new System.Drawing.Size(98, 27);
            this.Counterparty_Personality_Type.TabIndex = 1;
            //
            //L_Counterparty_NationalCode
            //
            this.L_Counterparty_NationalCode.AutoSize = true;
            this.L_Counterparty_NationalCode.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.L_Counterparty_NationalCode.Location = new System.Drawing.Point(524, 166);
            this.L_Counterparty_NationalCode.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.L_Counterparty_NationalCode.Name = "L_Counterparty_NationalCode";
            this.L_Counterparty_NationalCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.L_Counterparty_NationalCode.Size = new System.Drawing.Size(135, 19);
            this.L_Counterparty_NationalCode.TabIndex = 194;
            this.L_Counterparty_NationalCode.Text = "شناسه /کد ملی :";
            //
            //L_Counterparty_Mobile
            //
            this.L_Counterparty_Mobile.AutoSize = true;
            this.L_Counterparty_Mobile.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.L_Counterparty_Mobile.Location = new System.Drawing.Point(219, 131);
            this.L_Counterparty_Mobile.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.L_Counterparty_Mobile.Name = "L_Counterparty_Mobile";
            this.L_Counterparty_Mobile.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.L_Counterparty_Mobile.Size = new System.Drawing.Size(110, 19);
            this.L_Counterparty_Mobile.TabIndex = 188;
            this.L_Counterparty_Mobile.Text = "شماره همراه :";
            //
            //L_Counterparty_Address
            //
            this.L_Counterparty_Address.AutoSize = true;
            this.L_Counterparty_Address.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.L_Counterparty_Address.Location = new System.Drawing.Point(884, 264);
            this.L_Counterparty_Address.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.L_Counterparty_Address.Name = "L_Counterparty_Address";
            this.L_Counterparty_Address.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.L_Counterparty_Address.Size = new System.Drawing.Size(56, 19);
            this.L_Counterparty_Address.TabIndex = 185;
            this.L_Counterparty_Address.Text = "آدرس :";
            //
            //L_Counterparty_Economic_Code
            //
            this.L_Counterparty_Economic_Code.AutoSize = true;
            this.L_Counterparty_Economic_Code.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.L_Counterparty_Economic_Code.Location = new System.Drawing.Point(219, 167);
            this.L_Counterparty_Economic_Code.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.L_Counterparty_Economic_Code.Name = "L_Counterparty_Economic_Code";
            this.L_Counterparty_Economic_Code.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.L_Counterparty_Economic_Code.Size = new System.Drawing.Size(97, 19);
            this.L_Counterparty_Economic_Code.TabIndex = 181;
            this.L_Counterparty_Economic_Code.Text = "کد اقتصادی :";
            //
            //L_Counterparty_Postal_Code
            //
            this.L_Counterparty_Postal_Code.AutoSize = true;
            this.L_Counterparty_Postal_Code.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.L_Counterparty_Postal_Code.Location = new System.Drawing.Point(853, 167);
            this.L_Counterparty_Postal_Code.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.L_Counterparty_Postal_Code.Name = "L_Counterparty_Postal_Code";
            this.L_Counterparty_Postal_Code.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.L_Counterparty_Postal_Code.Size = new System.Drawing.Size(85, 19);
            this.L_Counterparty_Postal_Code.TabIndex = 180;
            this.L_Counterparty_Postal_Code.Text = "کد پستی :";
            //
            //L_Counterparty_Buyer_Type
            //
            this.L_Counterparty_Buyer_Type.AutoSize = true;
            this.L_Counterparty_Buyer_Type.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.L_Counterparty_Buyer_Type.Location = new System.Drawing.Point(443, 36);
            this.L_Counterparty_Buyer_Type.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.L_Counterparty_Buyer_Type.Name = "L_Counterparty_Buyer_Type";
            this.L_Counterparty_Buyer_Type.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.L_Counterparty_Buyer_Type.Size = new System.Drawing.Size(87, 19);
            this.L_Counterparty_Buyer_Type.TabIndex = 200;
            this.L_Counterparty_Buyer_Type.Text = "نوع خریدار :";
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
            this.DV.Size = new System.Drawing.Size(960, 291);
            this.DV.TabIndex = 0;
            //
            //Counterparty
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(12.0F, 25.0F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(960, 588);
            this.Controls.Add(this.SplitContainer1);
            this.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.Name = "Counterparty";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اشخاص و طرف حساب ها";
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.SplitContainer1.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel1.PerformLayout();
            this.SplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.SplitContainer1).EndInit();
            this.SplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.DV).EndInit();
            this.ResumeLayout(false);

        }
        internal System.Windows.Forms.Label L_Counterparty_Id;
        internal System.Windows.Forms.Label L_Counterparty_Family;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton New_B;
        internal System.Windows.Forms.ToolStripButton Edit_B;
        internal System.Windows.Forms.ToolStripButton Delet_B;
        internal System.Windows.Forms.ToolStripButton Save_B;
        internal System.Windows.Forms.ToolStripButton Search_B;
        internal System.Windows.Forms.ToolStripButton Print_B;
        internal System.Windows.Forms.ToolStripButton Abort_B;
        internal System.Windows.Forms.SplitContainer SplitContainer1;
        internal System.Windows.Forms.Label L_Counterparty_Postal_Code;
        internal System.Windows.Forms.Label L_Counterparty_Address;
        internal System.Windows.Forms.Label L_Counterparty_Mobile;
        internal System.Windows.Forms.Label L_Counterparty_NationalCode;
        internal System.Windows.Forms.Label L_Counterparty_Personality_Type;
        internal System.Windows.Forms.ComboBox Counterparty_Buyer_Type;
        internal System.Windows.Forms.ComboBox Counterparty_Personality_Type;
        internal System.Windows.Forms.Label L_Counterparty_Buyer_Type;
        internal System.Windows.Forms.TextBox Counterparty_State;
        internal System.Windows.Forms.Button B_Counterparty_State;
        internal System.Windows.Forms.Label L_Counterparty_City;
        internal System.Windows.Forms.TextBox Counterparty_City;
        internal System.Windows.Forms.Button B_Counterparty_City;
        internal System.Windows.Forms.Label L_Counterparty_State;
        internal System.Windows.Forms.Label L_Counterparty_Economic_Code;
        internal System.Windows.Forms.Label L_Counterparty_Name;
        internal System.Windows.Forms.Label L_Counterparty_Manager;
        internal System.Windows.Forms.Label L_Counterparty_Phone;
        internal System.Windows.Forms.Label L_Counterparty_Email;
        internal System.Windows.Forms.TextBox Counterparty_Email;
        internal System.Windows.Forms.DataGridView DV;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.ToolStripButton Picture_B;
        internal System.Windows.Forms.TextBox Counterparty_Phone;
        internal System.Windows.Forms.TextBox Counterparty_Registration_Number;
        internal System.Windows.Forms.TextBox Counterparty_Family;
        internal System.Windows.Forms.TextBox Counterparty_Name;
        internal System.Windows.Forms.TextBox Counterparty_Subscribe;
        internal System.Windows.Forms.TextBox Counterparty_Address;
        internal System.Windows.Forms.TextBox Counterparty_Bank_Number;
        internal System.Windows.Forms.TextBox Counterparty_Economic_Code;
        internal System.Windows.Forms.TextBox Counterparty_National_Code;
        internal System.Windows.Forms.TextBox Counterparty_Postal_Code;
        internal System.Windows.Forms.TextBox Counterparty_Mobile;
        internal System.Windows.Forms.TextBox Counterparty_Manager;
        internal System.Windows.Forms.TextBox Counterparty_Fax;
        internal System.Windows.Forms.ToolStripButton Excel_B;
    }
}