
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
    public partial class bank : System.Windows.Forms.Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bank));
            this.B_EXIT = new System.Windows.Forms.Button();
            this.B_SAVE = new System.Windows.Forms.Button();
            this.B_DELE = new System.Windows.Forms.Button();
            this.B_NEW = new System.Windows.Forms.Button();
            this.B_EDIT = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.ListView1 = new System.Windows.Forms.ListView();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.E_Chek = new System.Windows.Forms.Button();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.B_Bank_Chech = new System.Windows.Forms.Button();
            this.B_Bank_Payment = new System.Windows.Forms.Button();
            this.Label11 = new System.Windows.Forms.Label();
            this.ComboBox2 = new System.Windows.Forms.ComboBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label17 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.Label16 = new System.Windows.Forms.Label();
            this.Label18 = new System.Windows.Forms.Label();
            this.Label19 = new System.Windows.Forms.Label();
            this.Label20 = new System.Windows.Forms.Label();
            this.Label21 = new System.Windows.Forms.Label();
            this.Bank_Name = new System.Windows.Forms.TextBox();
            this.Bank_Code = new System.Windows.Forms.TextBox();
            this.Bank_Department = new System.Windows.Forms.TextBox();
            this.Bank_Account = new System.Windows.Forms.TextBox();
            this.Bank_Check_number_Of = new System.Windows.Forms.TextBox();
            this.Bank_Chech_Number = new System.Windows.Forms.TextBox();
            this.Bank_Check_number_To = new System.Windows.Forms.TextBox();
            this.Bank_Check = new System.Windows.Forms.TextBox();
            this.Bank_Payment = new System.Windows.Forms.TextBox();
            this.Bank_Post_Case1 = new System.Windows.Forms.TextBox();
            this.Bank_Post_Case2 = new System.Windows.Forms.TextBox();
            this.Bank_Post_Case3 = new System.Windows.Forms.TextBox();
            this.Bank_Post_Case4 = new System.Windows.Forms.TextBox();
            this.Bank_Post_Case5 = new System.Windows.Forms.TextBox();
            this.Bank_Name_Case1 = new System.Windows.Forms.TextBox();
            this.Bank_Name_Case2 = new System.Windows.Forms.TextBox();
            this.Bank_Name_Case3 = new System.Windows.Forms.TextBox();
            this.Bank_Name_Case4 = new System.Windows.Forms.TextBox();
            this.Bank_Name_Case5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            //B_EXIT
            //
            this.B_EXIT.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.B_EXIT.Location = new System.Drawing.Point(717, 417);
            this.B_EXIT.Margin = new System.Windows.Forms.Padding(4);
            this.B_EXIT.Name = "B_EXIT";
            this.B_EXIT.Size = new System.Drawing.Size(117, 56);
            this.B_EXIT.TabIndex = 28;
            this.B_EXIT.Text = "خروج";
            this.B_EXIT.UseVisualStyleBackColor = true;
            //
            //B_SAVE
            //
            this.B_SAVE.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.B_SAVE.Location = new System.Drawing.Point(717, 355);
            this.B_SAVE.Margin = new System.Windows.Forms.Padding(4);
            this.B_SAVE.Name = "B_SAVE";
            this.B_SAVE.Size = new System.Drawing.Size(117, 56);
            this.B_SAVE.TabIndex = 27;
            this.B_SAVE.Text = "ذخیره";
            this.B_SAVE.UseVisualStyleBackColor = true;
            //
            //B_DELE
            //
            this.B_DELE.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.B_DELE.Location = new System.Drawing.Point(717, 229);
            this.B_DELE.Margin = new System.Windows.Forms.Padding(4);
            this.B_DELE.Name = "B_DELE";
            this.B_DELE.Size = new System.Drawing.Size(117, 56);
            this.B_DELE.TabIndex = 25;
            this.B_DELE.Text = "حذف";
            this.B_DELE.UseVisualStyleBackColor = true;
            //
            //B_NEW
            //
            this.B_NEW.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.B_NEW.Location = new System.Drawing.Point(717, 101);

            //
            //B_NEW
            //
            this.B_NEW.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.B_NEW.Location = new System.Drawing.Point(717, 101);
            this.B_NEW.Margin = new System.Windows.Forms.Padding(4);
            this.B_NEW.Name = "B_NEW";
            this.B_NEW.Size = new System.Drawing.Size(117, 56);
            this.B_NEW.TabIndex = 23;
            this.B_NEW.Text = "جدید";
            this.B_NEW.UseVisualStyleBackColor = true;
            //
            //B_EDIT
            //
            this.B_EDIT.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.B_EDIT.Location = new System.Drawing.Point(717, 166);
            this.B_EDIT.Margin = new System.Windows.Forms.Padding(4);
            this.B_EDIT.Name = "B_EDIT";
            this.B_EDIT.Size = new System.Drawing.Size(117, 56);
            this.B_EDIT.TabIndex = 24;
            this.B_EDIT.Text = "ویرایش ";
            this.B_EDIT.UseVisualStyleBackColor = true;
            //
            //Label2
            //
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label2.Location = new System.Drawing.Point(374, 12);
            this.Label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label2.Size = new System.Drawing.Size(69, 23);
            this.Label2.TabIndex = 51;
            this.Label2.Text = "شعبه :";
            //
            //Label1
            //
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label1.Location = new System.Drawing.Point(753, 12);
            this.Label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label1.Size = new System.Drawing.Size(85, 23);
            this.Label1.TabIndex = 50;
            this.Label1.Text = "نام بانک :";
            //
            //ListView1
            //
            this.ListView1.FullRowSelect = true;
            this.ListView1.GridLines = true;
            this.ListView1.HideSelection = false;
            this.ListView1.Location = new System.Drawing.Point(3, 101);
            this.ListView1.Margin = new System.Windows.Forms.Padding(4);
            this.ListView1.MultiSelect = false;
            this.ListView1.Name = "ListView1";
            this.ListView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ListView1.RightToLeftLayout = true;
            this.ListView1.Size = new System.Drawing.Size(710, 378);
            this.ListView1.TabIndex = 4;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.View = System.Windows.Forms.View.Details;
            //
            //Label3
            //
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label3.Location = new System.Drawing.Point(755, 57);
            this.Label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label3.Size = new System.Drawing.Size(82, 23);
            this.Label3.TabIndex = 53;
            this.Label3.Text = "کد بانک :";
            //
            //Label4
            //
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label4.Location = new System.Drawing.Point(374, 56);
            this.Label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label4.Size = new System.Drawing.Size(136, 23);
            this.Label4.TabIndex = 16;
            this.Label4.Text = "شماره حساب :";
            //
            //E_Chek
            //
            this.E_Chek.Enabled = false;
            this.E_Chek.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.E_Chek.Location = new System.Drawing.Point(717, 292);
            this.E_Chek.Margin = new System.Windows.Forms.Padding(4);
            this.E_Chek.Name = "E_Chek";
            this.E_Chek.Size = new System.Drawing.Size(117, 56);
            this.E_Chek.TabIndex = 26;
            this.E_Chek.Text = "تنظیمات صدور چک";
            this.E_Chek.UseVisualStyleBackColor = true;
            //
            //Label5
            //
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label5.Location = new System.Drawing.Point(587, 116);
            this.Label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label5.Name = "Label5";
            this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label5.Size = new System.Drawing.Size(125, 23);
            this.Label5.TabIndex = 19;
            this.Label5.Text = "شماره چک از:";
            //
            //Label6
            //
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label6.Location = new System.Drawing.Point(366, 116);
            this.Label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label6.Name = "Label6";
            this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label6.Size = new System.Drawing.Size(67, 23);
            this.Label6.TabIndex = 21;
            this.Label6.Text = "تعداد  :";
            //
            //Label7
            //
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label7.Location = new System.Drawing.Point(164, 112);
            this.Label7.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label7.Name = "Label7";
            this.Label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label7.Size = new System.Drawing.Size(130, 23);
            this.Label7.TabIndex = 23;
            this.Label7.Text = "شماره چک تا :";
            //
            //Label8
            //
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label8.Location = new System.Drawing.Point(459, 209);
            this.Label8.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label8.Name = "Label8";
            this.Label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label8.Size = new System.Drawing.Size(161, 23);
            this.Label8.TabIndex = 25;
            this.Label8.Text = "نام فایل چاپ چک :";
            //
            //Label9
            //
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label9.Location = new System.Drawing.Point(219, 162);
            this.Label9.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label9.Name = "Label9";
            this.Label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label9.Size = new System.Drawing.Size(139, 23);
            this.Label9.TabIndex = 55;
            this.Label9.Text = "وضعیت حساب :";
            //
            //ComboBox1
            //
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Items.AddRange(new object[] { "غیر فعال برای چک بانک", "فعال کردن برای چک بانک" });
            this.ComboBox1.Location = new System.Drawing.Point(361, 162);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(226, 27);
            this.ComboBox1.TabIndex = 8;
            //
            //Label10
            //
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label10.Location = new System.Drawing.Point(461, 245);
            this.Label10.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label10.Name = "Label10";
            this.Label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label10.Size = new System.Drawing.Size(204, 23);
            this.Label10.TabIndex = 57;
            this.Label10.Text = "نام فایل دستور پرداخت :";
            //
            //B_Bank_Chech
            //
            this.B_Bank_Chech.Image = (System.Drawing.Image)resources.GetObject("B_Bank_Chech.Image");
            this.B_Bank_Chech.Location = new System.Drawing.Point(232, 204);
            this.B_Bank_Chech.Name = "B_Bank_Chech";
            this.B_Bank_Chech.Size = new System.Drawing.Size(37, 33);
            this.B_Bank_Chech.TabIndex = 11;
            this.B_Bank_Chech.UseVisualStyleBackColor = true;
            //
            //B_Bank_Payment
            //
            this.B_Bank_Payment.Image = (System.Drawing.Image)resources.GetObject("B_Bank_Payment.Image");
            this.B_Bank_Payment.Location = new System.Drawing.Point(233, 241);
            this.B_Bank_Payment.Name = "B_Bank_Payment";
            this.B_Bank_Payment.Size = new System.Drawing.Size(37, 33);
            this.B_Bank_Payment.TabIndex = 12;
            this.B_Bank_Payment.UseVisualStyleBackColor = true;
            //
            //Label11
            //
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label11.Location = new System.Drawing.Point(586, 164);
            this.Label11.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label11.Name = "Label11";
            this.Label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label11.Size = new System.Drawing.Size(128, 23);
            this.Label11.TabIndex = 61;
            this.Label11.Text = "نــوع حـسـاب :";
            //
            //ComboBox2
            //
            this.ComboBox2.FormattingEnabled = true;
            this.ComboBox2.Items.AddRange(new object[] { "نـــــــــقـــــدی", "تــــــعـــهـــدی" });
            this.ComboBox2.Location = new System.Drawing.Point(5, 162);
            this.ComboBox2.Name = "ComboBox2";
            this.ComboBox2.Size = new System.Drawing.Size(208, 27);
            this.ComboBox2.TabIndex = 9;
            //
            //Label12
            //
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label12.Location = new System.Drawing.Point(553, 293);
            this.Label12.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label12.Name = "Label12";
            this.Label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label12.Size = new System.Drawing.Size(147, 23);
            this.Label12.TabIndex = 63;
            this.Label12.Text = "عنوان امضاء اول :";
            //
            //Label13
            //
            this.Label13.AutoSize = true;
            this.Label13.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label13.Location = new System.Drawing.Point(553, 333);
            this.Label13.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label13.Name = "Label13";
            this.Label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label13.Size = new System.Drawing.Size(150, 23);
            this.Label13.TabIndex = 65;
            this.Label13.Text = "عنوان امضاء دوم :";
            //
            //Label14
            //
            this.Label14.AutoSize = true;
            this.Label14.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label14.Location = new System.Drawing.Point(552, 371);
            this.Label14.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label14.Name = "Label14";
            this.Label14.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label14.Size = new System.Drawing.Size(160, 23);
            this.Label14.TabIndex = 67;
            this.Label14.Text = "عنوان امضاء سوم :";
            //
            //Label17
            //
            this.Label17.AutoSize = true;
            this.Label17.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label17.Location = new System.Drawing.Point(548, 408);
            this.Label17.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label17.Name = "Label17";
            this.Label17.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label17.Size = new System.Drawing.Size(169, 23);
            this.Label17.TabIndex = 72;
            this.Label17.Text = "عنوان امضاء چهارم :";
            //
            //Label15
            //
            this.Label15.AutoSize = true;
            this.Label15.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label15.Location = new System.Drawing.Point(193, 292);
            this.Label15.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label15.Name = "Label15";
            this.Label15.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label15.Size = new System.Drawing.Size(167, 23);
            this.Label15.TabIndex = 80;
            this.Label15.Text = "نام و نام خانوادگی :";
            //
            //Label16
            //
            this.Label16.AutoSize = true;
            this.Label16.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label16.Location = new System.Drawing.Point(193, 329);
            this.Label16.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label16.Name = "Label16";
            this.Label16.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label16.Size = new System.Drawing.Size(167, 23);
            this.Label16.TabIndex = 81;
            this.Label16.Text = "نام و نام خانوادگی :";
            //
            //Label18
            //
            this.Label18.AutoSize = true;
            this.Label18.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label18.Location = new System.Drawing.Point(193, 370);
            this.Label18.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label18.Name = "Label18";
            this.Label18.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label18.Size = new System.Drawing.Size(167, 23);
            this.Label18.TabIndex = 82;
            this.Label18.Text = "نام و نام خانوادگی :";
            //
            //Label19
            //
            this.Label19.AutoSize = true;
            this.Label19.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label19.Location = new System.Drawing.Point(193, 411);
            this.Label19.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label19.Name = "Label19";
            this.Label19.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label19.Size = new System.Drawing.Size(167, 23);
            this.Label19.TabIndex = 83;
            this.Label19.Text = "نام و نام خانوادگی :";
            //
            //Label20
            //
            this.Label20.AutoSize = true;
            this.Label20.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label20.Location = new System.Drawing.Point(193, 451);
            this.Label20.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label20.Name = "Label20";
            this.Label20.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label20.Size = new System.Drawing.Size(167, 23);
            this.Label20.TabIndex = 87;
            this.Label20.Text = "نام و نام خانوادگی :";
            //
            //Label21
            //
            this.Label21.AutoSize = true;
            this.Label21.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.Label21.Location = new System.Drawing.Point(548, 448);
            this.Label21.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label21.Name = "Label21";
            this.Label21.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label21.Size = new System.Drawing.Size(160, 23);
            this.Label21.TabIndex = 85;
            this.Label21.Text = "عنوان امضاء پنجم :";
            //
            //Bank_Name
            //
            this.Bank_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Bank_Name.Location = new System.Drawing.Point(519, 8);
            this.Bank_Name.Name = "Bank_Name";
            this.Bank_Name.Size = new System.Drawing.Size(234, 31);
            this.Bank_Name.TabIndex = 0;
            //
            //Bank_Code
            //
            this.Bank_Code.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Bank_Code.Location = new System.Drawing.Point(519, 52);
            this.Bank_Code.Name = "Bank_Code";
            this.Bank_Code.Size = new System.Drawing.Size(234, 31);
            this.Bank_Code.TabIndex = 2;
            //
            //Bank_Department
            //
            this.Bank_Department.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Bank_Department.Location = new System.Drawing.Point(5, 8);
            this.Bank_Department.Name = "Bank_Department";
            this.Bank_Department.Size = new System.Drawing.Size(368, 31);
            this.Bank_Department.TabIndex = 1;
            //
            //Bank_Account
            //
            this.Bank_Account.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Bank_Account.Location = new System.Drawing.Point(5, 53);
            this.Bank_Account.Name = "Bank_Account";
            this.Bank_Account.Size = new System.Drawing.Size(368, 31);
            this.Bank_Account.TabIndex = 3;
            //
            //Bank_Check_number_Of
            //
            this.Bank_Check_number_Of.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Bank_Check_number_Of.Location = new System.Drawing.Point(440, 114);
            this.Bank_Check_number_Of.Name = "Bank_Check_number_Of";
            this.Bank_Check_number_Of.Size = new System.Drawing.Size(147, 31);
            this.Bank_Check_number_Of.TabIndex = 5;
            //
            //Bank_Chech_Number
            //
            this.Bank_Chech_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Bank_Chech_Number.Location = new System.Drawing.Point(295, 114);
            this.Bank_Chech_Number.Name = "Bank_Chech_Number";
            this.Bank_Chech_Number.Size = new System.Drawing.Size(65, 31);
            this.Bank_Chech_Number.TabIndex = 6;
            //
            //Bank_Check_number_To
            //
            this.Bank_Check_number_To.Enabled = false;
            this.Bank_Check_number_To.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Bank_Check_number_To.Location = new System.Drawing.Point(5, 108);
            this.Bank_Check_number_To.Name = "Bank_Check_number_To";
            this.Bank_Check_number_To.Size = new System.Drawing.Size(147, 31);
            this.Bank_Check_number_To.TabIndex = 7;
            //
            //Bank_Check
            //
            this.Bank_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Bank_Check.Location = new System.Drawing.Point(268, 205);
            this.Bank_Check.Name = "Bank_Check";
            this.Bank_Check.Size = new System.Drawing.Size(188, 31);
            this.Bank_Check.TabIndex = 10;
            //
            //Bank_Payment
            //
            this.Bank_Payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Bank_Payment.Location = new System.Drawing.Point(269, 242);
            this.Bank_Payment.Name = "Bank_Payment";
            this.Bank_Payment.Size = new System.Drawing.Size(188, 31);
            this.Bank_Payment.TabIndex = 11;
            //
            //Bank_Post_Case1
            //
            this.Bank_Post_Case1.Enabled = false;
            this.Bank_Post_Case1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Bank_Post_Case1.Location = new System.Drawing.Point(361, 290);
            this.Bank_Post_Case1.Name = "Bank_Post_Case1";
            this.Bank_Post_Case1.Size = new System.Drawing.Size(188, 31);
            this.Bank_Post_Case1.TabIndex = 13;
            //
            //Bank_Post_Case2
            //
            this.Bank_Post_Case2.Enabled = false;
            this.Bank_Post_Case2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Bank_Post_Case2.Location = new System.Drawing.Point(361, 329);
            this.Bank_Post_Case2.Name = "Bank_Post_Case2";
            this.Bank_Post_Case2.Size = new System.Drawing.Size(188, 31);
            this.Bank_Post_Case2.TabIndex = 15;
            //
            //Bank_Post_Case3
            //
            this.Bank_Post_Case3.Enabled = false;
            this.Bank_Post_Case3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Bank_Post_Case3.Location = new System.Drawing.Point(362, 367);
            this.Bank_Post_Case3.Name = "Bank_Post_Case3";
            this.Bank_Post_Case3.Size = new System.Drawing.Size(188, 31);
            this.Bank_Post_Case3.TabIndex = 17;
            //
            //Bank_Post_Case4
            //
            this.Bank_Post_Case4.Enabled = false;
            this.Bank_Post_Case4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Bank_Post_Case4.Location = new System.Drawing.Point(362, 404);
            this.Bank_Post_Case4.Name = "Bank_Post_Case4";
            this.Bank_Post_Case4.Size = new System.Drawing.Size(188, 31);
            this.Bank_Post_Case4.TabIndex = 19;
            //
            //Bank_Post_Case5
            //
            this.Bank_Post_Case5.Enabled = false;
            this.Bank_Post_Case5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Bank_Post_Case5.Location = new System.Drawing.Point(361, 444);
            this.Bank_Post_Case5.Name = "Bank_Post_Case5";
            this.Bank_Post_Case5.Size = new System.Drawing.Size(188, 31);
            this.Bank_Post_Case5.TabIndex = 21;
            //
            //Bank_Name_Case1
            //
            this.Bank_Name_Case1.Enabled = false;
            this.Bank_Name_Case1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Bank_Name_Case1.Location = new System.Drawing.Point(4, 288);
            this.Bank_Name_Case1.Name = "Bank_Name_Case1";
            this.Bank_Name_Case1.Size = new System.Drawing.Size(188, 31);
            this.Bank_Name_Case1.TabIndex = 14;
            //
            //Bank_Name_Case2
            //
            this.Bank_Name_Case2.Enabled = false;
            this.Bank_Name_Case2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Bank_Name_Case2.Location = new System.Drawing.Point(4, 326);
            this.Bank_Name_Case2.Name = "Bank_Name_Case2";
            this.Bank_Name_Case2.Size = new System.Drawing.Size(188, 31);
            this.Bank_Name_Case2.TabIndex = 16;
            //
            //Bank_Name_Case3
            //
            this.Bank_Name_Case3.Enabled = false;
            this.Bank_Name_Case3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Bank_Name_Case3.Location = new System.Drawing.Point(4, 367);
            this.Bank_Name_Case3.Name = "Bank_Name_Case3";
            this.Bank_Name_Case3.Size = new System.Drawing.Size(188, 31);
            this.Bank_Name_Case3.TabIndex = 18;
            //
            //Bank_Name_Case4
            //
            this.Bank_Name_Case4.Enabled = false;
            this.Bank_Name_Case4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Bank_Name_Case4.Location = new System.Drawing.Point(4, 408);
            this.Bank_Name_Case4.Name = "Bank_Name_Case4";
            this.Bank_Name_Case4.Size = new System.Drawing.Size(188, 31);
            this.Bank_Name_Case4.TabIndex = 20;
            //
            //Bank_Name_Case5
            //
            this.Bank_Name_Case5.Enabled = false;
            this.Bank_Name_Case5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Bank_Name_Case5.Location = new System.Drawing.Point(4, 448);
            this.Bank_Name_Case5.Name = "Bank_Name_Case5";
            this.Bank_Name_Case5.Size = new System.Drawing.Size(188, 31);
            this.Bank_Name_Case5.TabIndex = 22;
            //
            //bank
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(9.0F, 19.0F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(840, 484);
            this.Controls.Add(this.ListView1);
            this.Controls.Add(this.Bank_Name_Case5);
            this.Controls.Add(this.Bank_Name_Case4);
            this.Controls.Add(this.Bank_Name_Case3);
            this.Controls.Add(this.Bank_Name_Case2);
            this.Controls.Add(this.Bank_Name_Case1);
            this.Controls.Add(this.Bank_Post_Case5);
            this.Controls.Add(this.Bank_Post_Case4);
            this.Controls.Add(this.Bank_Post_Case3);
            this.Controls.Add(this.Bank_Post_Case2);
            this.Controls.Add(this.Bank_Post_Case1);
            this.Controls.Add(this.Bank_Payment);
            this.Controls.Add(this.Bank_Check);
            this.Controls.Add(this.Bank_Account);
            this.Controls.Add(this.Bank_Department);
            this.Controls.Add(this.Bank_Code);
            this.Controls.Add(this.Bank_Name);
            this.Controls.Add(this.Label19);
            this.Controls.Add(this.Label18);
            this.Controls.Add(this.Label16);
            this.Controls.Add(this.Label15);
            this.Controls.Add(this.Label14);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.ComboBox1);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.E_Chek);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.B_EXIT);
            this.Controls.Add(this.B_SAVE);
            this.Controls.Add(this.B_DELE);
            this.Controls.Add(this.B_NEW);
            this.Controls.Add(this.B_EDIT);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.B_Bank_Payment);
            this.Controls.Add(this.B_Bank_Chech);
            this.Controls.Add(this.ComboBox2);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.Label17);
            this.Controls.Add(this.Label20);
            this.Controls.Add(this.Label21);
            this.Controls.Add(this.Bank_Check_number_To);
            this.Controls.Add(this.Bank_Chech_Number);
            this.Controls.Add(this.Bank_Check_number_Of);
            this.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "bank";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فرم ثبت اطلاعات حساب بانکها";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal System.Windows.Forms.Button B_EXIT;
        internal System.Windows.Forms.Button B_SAVE;
        internal System.Windows.Forms.Button B_DELE;
        internal System.Windows.Forms.Button B_NEW;
        internal System.Windows.Forms.Button B_EDIT;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ListView ListView1;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Button E_Chek;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.ComboBox ComboBox1;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Button B_Bank_Chech;
        internal System.Windows.Forms.Button B_Bank_Payment;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.ComboBox ComboBox2;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.Label Label17;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.Label Label18;
        internal System.Windows.Forms.Label Label19;
        internal System.Windows.Forms.Label Label20;
        internal System.Windows.Forms.Label Label21;
        internal System.Windows.Forms.TextBox Bank_Name;
        internal System.Windows.Forms.TextBox Bank_Code;
        internal System.Windows.Forms.TextBox Bank_Department;
        internal System.Windows.Forms.TextBox Bank_Account;
        internal System.Windows.Forms.TextBox Bank_Check_number_Of;
        internal System.Windows.Forms.TextBox Bank_Chech_Number;
        internal System.Windows.Forms.TextBox Bank_Check_number_To;
        internal System.Windows.Forms.TextBox Bank_Check;
        internal System.Windows.Forms.TextBox Bank_Payment;
        internal System.Windows.Forms.TextBox Bank_Post_Case1;
        internal System.Windows.Forms.TextBox Bank_Post_Case2;
        internal System.Windows.Forms.TextBox Bank_Post_Case3;
        internal System.Windows.Forms.TextBox Bank_Post_Case4;
        internal System.Windows.Forms.TextBox Bank_Post_Case5;
        internal System.Windows.Forms.TextBox Bank_Name_Case1;
        internal System.Windows.Forms.TextBox Bank_Name_Case2;
        internal System.Windows.Forms.TextBox Bank_Name_Case3;
        internal System.Windows.Forms.TextBox Bank_Name_Case4;
        internal System.Windows.Forms.TextBox Bank_Name_Case5;
    }
}