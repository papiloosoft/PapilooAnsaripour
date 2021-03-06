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
    public partial class frm_sms : System.Windows.Forms.Form
    {
        //Form overrides dispose to clean up the component list.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_sms));
            System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TabMassage = new System.Windows.Forms.TabControl();
            this.sms_1 = new System.Windows.Forms.TabPage();
            this.GroupBox6 = new System.Windows.Forms.GroupBox();
            this.Sms_Sefid_5 = new System.Windows.Forms.TextBox();
            this.Label20 = new System.Windows.Forms.Label();
            this.Sms_Sefid_4 = new System.Windows.Forms.TextBox();
            this.Label21 = new System.Windows.Forms.Label();
            this.Sms_Sefid_3 = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Sms_Sefid_2 = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.B_Sefid_Abort = new System.Windows.Forms.Button();
            this.B_Sefid_Delete = new System.Windows.Forms.Button();
            this.B_Sefid_Add = new System.Windows.Forms.Button();
            this.B_Sefid_Save = new System.Windows.Forms.Button();
            this.DV_Sefid = new System.Windows.Forms.DataGridView();
            this.Sms_txt_Sefid = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.CheckBox_Sefid = new System.Windows.Forms.CheckBox();
            this.Label_Sms = new System.Windows.Forms.Label();
            this.B_Txt_mobile = new System.Windows.Forms.Button();
            this.cmdSendMsg = new System.Windows.Forms.Button();
            this.Label24 = new System.Windows.Forms.Label();
            this.txt_Message = new System.Windows.Forms.TextBox();
            this.txt_mobile = new System.Windows.Forms.TextBox();
            this.Label23 = new System.Windows.Forms.Label();
            this.sms_2 = new System.Windows.Forms.TabPage();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Dv_Mobile_Group = new System.Windows.Forms.DataGridView();
            this.TextBox_5_Sefid_Group = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.TextBox_4_Sefid_Group = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.TextBox_3_Sefid_Group = new System.Windows.Forms.TextBox();
            this.Label22 = new System.Windows.Forms.Label();
            this.TextBox_2_Sefid_Group = new System.Windows.Forms.TextBox();
            this.Label25 = new System.Windows.Forms.Label();
            this.Dv_Sefid_Group = new System.Windows.Forms.DataGridView();
            this.TextBox_Sefid_Group = new System.Windows.Forms.TextBox();
            this.Label27 = new System.Windows.Forms.Label();
            this.CheckBox_Sefid_Group = new System.Windows.Forms.CheckBox();
            this.Button_Group = new System.Windows.Forms.Button();
            this.Label31 = new System.Windows.Forms.Label();
            this.Sms_Sefid_Group = new System.Windows.Forms.TextBox();
            this.TextBox_Group = new System.Windows.Forms.TextBox();
            this.Label33 = new System.Windows.Forms.Label();
            this.B_Send_Sms_Sefid_Group = new System.Windows.Forms.Button();
            this.sms_3 = new System.Windows.Forms.TabPage();
            this.GroupBox7 = new System.Windows.Forms.GroupBox();
            this.lblMsgCount = new System.Windows.Forms.Label();
            this.cmdMsgDelete = new System.Windows.Forms.Button();
            this.cmdInboxRefresh = new System.Windows.Forms.Button();
            this.Label29 = new System.Windows.Forms.Label();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.chkInboxRefresh = new System.Windows.Forms.CheckBox();
            this.chkInConcatenate = new System.Windows.Forms.CheckBox();
            this.cboMsgMemory = new System.Windows.Forms.ComboBox();
            this.Label28 = new System.Windows.Forms.Label();
            this.lstInbox = new System.Windows.Forms.ListView();
            this.clmTime = (System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader());
            this.clmMessage = (System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader());
            this.clmFrom = (System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader());
            this.sms_4 = new System.Windows.Forms.TabPage();
            this.GroupBox13 = new System.Windows.Forms.GroupBox();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.ListView1 = new System.Windows.Forms.ListView();
            this.ColumnHeader1 = (System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader());
            this.ColumnHeader2 = (System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader());
            this.ColumnHeader3 = (System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader());
            this.GroupBox12 = new System.Windows.Forms.GroupBox();
            this.TextBox6 = new System.Windows.Forms.TextBox();
            this.Label44 = new System.Windows.Forms.Label();
            this.TextBox5 = new System.Windows.Forms.TextBox();
            this.Label43 = new System.Windows.Forms.Label();
            this.TextBox4 = new System.Windows.Forms.TextBox();
            this.Label42 = new System.Windows.Forms.Label();
            this.TextBox3 = new System.Windows.Forms.TextBox();
            this.Label41 = new System.Windows.Forms.Label();
            this.Button2 = new System.Windows.Forms.Button();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.Label40 = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.sms_5 = new System.Windows.Forms.TabPage();
            this.TBG_Logs = new System.Windows.Forms.DataGridView();
            this.GroupBox11 = new System.Windows.Forms.GroupBox();
            this.Delete_All_Logs = new System.Windows.Forms.Button();
            this.Reply_Send_SMS_4ALL = new System.Windows.Forms.Button();
            this.GroupBox10 = new System.Windows.Forms.GroupBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Warranty_Document_From_Date = new Ansaripour.Rtl_Date();
            this.Warranty_Document_Until_Date = new Ansaripour.Rtl_Date();
            this.Estate_Plaque = new System.Windows.Forms.ComboBox();
            this.Label39 = new System.Windows.Forms.Label();
            this.MemberTXT = new System.Windows.Forms.TextBox();
            this.Reply_Send_SMS = new System.Windows.Forms.Button();
            this.sms_6 = new System.Windows.Forms.TabPage();
            this.SettingGroupBox = new System.Windows.Forms.GroupBox();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.Tab_Warranty_Document = new System.Windows.Forms.TabControl();
            this.Sms_Services = new System.Windows.Forms.TabPage();
            this.Sms_Accounting = new System.Windows.Forms.TabPage();
            this.Sms_Repair = new System.Windows.Forms.TabPage();
            this.Sms_PayRoll = new System.Windows.Forms.TabPage();
            this.GroupBox16 = new System.Windows.Forms.GroupBox();
            this.CheckedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.CheckedListBox3 = new System.Windows.Forms.CheckedListBox();
            this.Button15 = new System.Windows.Forms.Button();
            this.Button16 = new System.Windows.Forms.Button();
            this.GroupBox17 = new System.Windows.Forms.GroupBox();
            this.Label26 = new System.Windows.Forms.Label();
            this.TextBox18 = new System.Windows.Forms.TextBox();
            this.Button17 = new System.Windows.Forms.Button();
            this.Sms_Warehouse = new System.Windows.Forms.TabPage();
            this.Sms_Assets = new System.Windows.Forms.TabPage();
            this.Sms_Payable = new System.Windows.Forms.TabPage();
            this.Sms_Text_Payable_Payment = new System.Windows.Forms.TextBox();
            this.Label13 = new System.Windows.Forms.Label();
            this.Sms_Payable_Payment = new System.Windows.Forms.CheckBox();
            this.Sms_Collection_Document = new System.Windows.Forms.TabPage();
            this.Sms_Text_Collection_Document_Extradition = new System.Windows.Forms.TextBox();
            this.Label19 = new System.Windows.Forms.Label();
            this.Sms_Collection_Document_Extradition = new System.Windows.Forms.CheckBox();
            this.Sms_Text_Collection_Document_Back = new System.Windows.Forms.TextBox();
            this.Label18 = new System.Windows.Forms.Label();
            this.Sms_Collection_Document_Back = new System.Windows.Forms.CheckBox();
            this.Sms_Text_Collection_Document_Notice = new System.Windows.Forms.TextBox();
            this.Sms_Text_Collection_Document_Assignment = new System.Windows.Forms.TextBox();
            this.Sms_Text_Collection_Document_Add = new System.Windows.Forms.TextBox();
            this.Label15 = new System.Windows.Forms.Label();
            this.Label16 = new System.Windows.Forms.Label();
            this.Label17 = new System.Windows.Forms.Label();
            this.Sms_Collection_Document_Notice = new System.Windows.Forms.CheckBox();
            this.Sms_Collection_Document_Assignment = new System.Windows.Forms.CheckBox();
            this.Sms_Collection_Document_Add = new System.Windows.Forms.CheckBox();
            this.Sms_Warranty_Document = new System.Windows.Forms.TabPage();
            this.Sms_Text_Warranty_Document_Refund = new System.Windows.Forms.TextBox();
            this.Sms_Text_Warranty_Document_Extended = new System.Windows.Forms.TextBox();
            this.Sms_Text_Warranty_Document_Add = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Sms_Warranty_Document_Refund = new System.Windows.Forms.CheckBox();
            this.Sms_Warranty_Document_Extended = new System.Windows.Forms.CheckBox();
            this.Sms_Warranty_Document_Add = new System.Windows.Forms.CheckBox();
            this.GroupStarterMatn = new System.Windows.Forms.GroupBox();
            this.View_sms_SetUp = new System.Windows.Forms.CheckBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.Sms_txt_Ulr_Sender = new System.Windows.Forms.TextBox();
            this.Sms_txt_Signature = new System.Windows.Forms.TextBox();
            this.Label32 = new System.Windows.Forms.Label();
            this.Sms_txt_smsSender = new System.Windows.Forms.TextBox();
            this.Label36 = new System.Windows.Forms.Label();
            this.SAVE_Setting = new System.Windows.Forms.Button();
            this.LogsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TellBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PishNevisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PishNevisBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ProgsessTimer = new System.Windows.Forms.Timer(this.components);
            this.TabMassage.SuspendLayout();
            this.sms_1.SuspendLayout();
            this.GroupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.DV_Sefid).BeginInit();
            this.sms_2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.Dv_Mobile_Group).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.Dv_Sefid_Group).BeginInit();
            this.sms_3.SuspendLayout();
            this.GroupBox7.SuspendLayout();
            this.sms_4.SuspendLayout();
            this.GroupBox13.SuspendLayout();
            this.GroupBox12.SuspendLayout();
            this.sms_5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.TBG_Logs).BeginInit();
            this.GroupBox11.SuspendLayout();
            this.GroupBox10.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            this.sms_6.SuspendLayout();
            this.SettingGroupBox.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.Tab_Warranty_Document.SuspendLayout();
            this.Sms_PayRoll.SuspendLayout();
            this.GroupBox16.SuspendLayout();
            this.GroupBox17.SuspendLayout();
            this.Sms_Payable.SuspendLayout();
            this.Sms_Collection_Document.SuspendLayout();
            this.Sms_Warranty_Document.SuspendLayout();
            this.GroupStarterMatn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.LogsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.TellBookBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.PishNevisBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.PishNevisBindingSource1).BeginInit();
            this.SuspendLayout();
            //
            //TabMassage
            //
            this.TabMassage.Controls.Add(this.sms_1);
            this.TabMassage.Controls.Add(this.sms_2);
            this.TabMassage.Controls.Add(this.sms_3);
            this.TabMassage.Controls.Add(this.sms_4);
            this.TabMassage.Controls.Add(this.sms_5);
            this.TabMassage.Controls.Add(this.sms_6);
            this.TabMassage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabMassage.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.TabMassage.Location = new System.Drawing.Point(0, 0);
            this.TabMassage.Name = "TabMassage";
            this.TabMassage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TabMassage.RightToLeftLayout = true;
            this.TabMassage.SelectedIndex = 0;
            this.TabMassage.Size = new System.Drawing.Size(869, 516);
            this.TabMassage.TabIndex = 3;
            this.TabMassage.TabStop = false;
            //
            //sms_1
            //
            this.sms_1.Controls.Add(this.GroupBox6);
            this.sms_1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.sms_1.Location = new System.Drawing.Point(4, 22);
            this.sms_1.Name = "sms_1";
            this.sms_1.Padding = new System.Windows.Forms.Padding(3);
            this.sms_1.Size = new System.Drawing.Size(861, 490);
            this.sms_1.TabIndex = 1;
            this.sms_1.Text = "ارسال پیام تک";
            this.sms_1.UseVisualStyleBackColor = true;
            //
            //GroupBox6
            //
            this.GroupBox6.Controls.Add(this.Sms_Sefid_5);
            this.GroupBox6.Controls.Add(this.Label20);
            this.GroupBox6.Controls.Add(this.Sms_Sefid_4);
            this.GroupBox6.Controls.Add(this.Label21);
            this.GroupBox6.Controls.Add(this.Sms_Sefid_3);
            this.GroupBox6.Controls.Add(this.Label6);
            this.GroupBox6.Controls.Add(this.Sms_Sefid_2);
            this.GroupBox6.Controls.Add(this.Label5);
            this.GroupBox6.Controls.Add(this.B_Sefid_Abort);
            this.GroupBox6.Controls.Add(this.B_Sefid_Delete);
            this.GroupBox6.Controls.Add(this.B_Sefid_Add);
            this.GroupBox6.Controls.Add(this.B_Sefid_Save);
            this.GroupBox6.Controls.Add(this.DV_Sefid);
            this.GroupBox6.Controls.Add(this.Sms_txt_Sefid);
            this.GroupBox6.Controls.Add(this.Label4);
            this.GroupBox6.Controls.Add(this.CheckBox_Sefid);
            this.GroupBox6.Controls.Add(this.Label_Sms);
            this.GroupBox6.Controls.Add(this.B_Txt_mobile);
            this.GroupBox6.Controls.Add(this.cmdSendMsg);
            this.GroupBox6.Controls.Add(this.Label24);
            this.GroupBox6.Controls.Add(this.txt_Message);
            this.GroupBox6.Controls.Add(this.txt_mobile);
            this.GroupBox6.Controls.Add(this.Label23);
            this.GroupBox6.Location = new System.Drawing.Point(6, 6);
            this.GroupBox6.Name = "GroupBox6";
            this.GroupBox6.Size = new System.Drawing.Size(852, 476);
            this.GroupBox6.TabIndex = 3;
            this.GroupBox6.TabStop = false;
            this.GroupBox6.Text = "جزئیات ارسال تک  : ";
            //
            //Sms_Sefid_5
            //
            this.Sms_Sefid_5.Enabled = false;
            this.Sms_Sefid_5.Font = new System.Drawing.Font("Tahoma", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Sms_Sefid_5.Location = new System.Drawing.Point(6, 306);
            this.Sms_Sefid_5.Name = "Sms_Sefid_5";
            this.Sms_Sefid_5.Size = new System.Drawing.Size(291, 22);
            this.Sms_Sefid_5.TabIndex = 312;
            //
            //Label20
            //
            this.Label20.AutoSize = true;
            this.Label20.Location = new System.Drawing.Point(299, 310);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(122, 13);
            this.Label20.TabIndex = 311;
            this.Label20.Text = "متن متغییر پنجم  پیامک :";
            //
            //Sms_Sefid_4
            //
            this.Sms_Sefid_4.Enabled = false;
            this.Sms_Sefid_4.Font = new System.Drawing.Font("Tahoma", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Sms_Sefid_4.Location = new System.Drawing.Point(423, 306);
            this.Sms_Sefid_4.Name = "Sms_Sefid_4";
            this.Sms_Sefid_4.Size = new System.Drawing.Size(291, 22);
            this.Sms_Sefid_4.TabIndex = 310;
            //
            //Label21
            //
            this.Label21.AutoSize = true;
            this.Label21.Location = new System.Drawing.Point(719, 310);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(127, 13);
            this.Label21.TabIndex = 309;
            this.Label21.Text = "متن متغییر چهارم  پیامک :";
            //
            //Sms_Sefid_3
            //
            this.Sms_Sefid_3.Enabled = false;
            this.Sms_Sefid_3.Font = new System.Drawing.Font("Tahoma", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Sms_Sefid_3.Location = new System.Drawing.Point(6, 278);
            this.Sms_Sefid_3.Name = "Sms_Sefid_3";
            this.Sms_Sefid_3.Size = new System.Drawing.Size(291, 22);
            this.Sms_Sefid_3.TabIndex = 308;
            //
            //Label6
            //
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(299, 282);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(123, 13);
            this.Label6.TabIndex = 307;
            this.Label6.Text = "متن متغییر سوم  پیامک :";
            //
            //Sms_Sefid_2
            //
            this.Sms_Sefid_2.Enabled = false;
            this.Sms_Sefid_2.Font = new System.Drawing.Font("Tahoma", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Sms_Sefid_2.Location = new System.Drawing.Point(423, 278);
            this.Sms_Sefid_2.Name = "Sms_Sefid_2";
            this.Sms_Sefid_2.Size = new System.Drawing.Size(291, 22);
            this.Sms_Sefid_2.TabIndex = 306;
            //
            //Label5
            //
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(719, 282);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(117, 13);
            this.Label5.TabIndex = 305;
            this.Label5.Text = "متن متغییر دوم  پیامک :";
            //
            //B_Sefid_Abort
            //
            this.B_Sefid_Abort.BackgroundImage = (System.Drawing.Image)resources.GetObject("B_Sefid_Abort.BackgroundImage");
            this.B_Sefid_Abort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.B_Sefid_Abort.Enabled = false;
            this.B_Sefid_Abort.Location = new System.Drawing.Point(482, 16);
            this.B_Sefid_Abort.Name = "B_Sefid_Abort";
            this.B_Sefid_Abort.Size = new System.Drawing.Size(25, 22);
            this.B_Sefid_Abort.TabIndex = 304;
            this.B_Sefid_Abort.UseVisualStyleBackColor = true;
            //
            //B_Sefid_Delete
            //
            this.B_Sefid_Delete.BackgroundImage = (System.Drawing.Image)resources.GetObject("B_Sefid_Delete.BackgroundImage");
            this.B_Sefid_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.B_Sefid_Delete.Enabled = false;
            this.B_Sefid_Delete.Location = new System.Drawing.Point(544, 16);
            this.B_Sefid_Delete.Name = "B_Sefid_Delete";
            this.B_Sefid_Delete.Size = new System.Drawing.Size(25, 22);
            this.B_Sefid_Delete.TabIndex = 303;
            this.B_Sefid_Delete.UseVisualStyleBackColor = true;
            //
            //B_Sefid_Add
            //
            this.B_Sefid_Add.BackgroundImage = (System.Drawing.Image)resources.GetObject("B_Sefid_Add.BackgroundImage");
            this.B_Sefid_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.B_Sefid_Add.Enabled = false;
            this.B_Sefid_Add.Location = new System.Drawing.Point(575, 16);
            this.B_Sefid_Add.Name = "B_Sefid_Add";
            this.B_Sefid_Add.Size = new System.Drawing.Size(25, 22);
            this.B_Sefid_Add.TabIndex = 302;
            this.B_Sefid_Add.UseVisualStyleBackColor = true;
            //
            //B_Sefid_Save
            //
            this.B_Sefid_Save.BackgroundImage = (System.Drawing.Image)resources.GetObject("B_Sefid_Save.BackgroundImage");
            this.B_Sefid_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.B_Sefid_Save.Enabled = false;
            this.B_Sefid_Save.Location = new System.Drawing.Point(513, 16);
            this.B_Sefid_Save.Name = "B_Sefid_Save";
            this.B_Sefid_Save.Size = new System.Drawing.Size(25, 22);
            this.B_Sefid_Save.TabIndex = 300;
            this.B_Sefid_Save.UseVisualStyleBackColor = true;
            //
            //DV_Sefid
            //
            DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            DataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DV_Sefid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1;
            this.DV_Sefid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            DataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DV_Sefid.DefaultCellStyle = DataGridViewCellStyle2;
            this.DV_Sefid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.DV_Sefid.Enabled = false;
            this.DV_Sefid.EnableHeadersVisualStyles = false;
            this.DV_Sefid.Location = new System.Drawing.Point(6, 71);
            this.DV_Sefid.Name = "DV_Sefid";
            this.DV_Sefid.Size = new System.Drawing.Size(843, 174);
            this.DV_Sefid.TabIndex = 299;
            //
            //Sms_txt_Sefid
            //
            this.Sms_txt_Sefid.Enabled = false;
            this.Sms_txt_Sefid.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Sms_txt_Sefid.Location = new System.Drawing.Point(6, 44);
            this.Sms_txt_Sefid.Name = "Sms_txt_Sefid";
            this.Sms_txt_Sefid.Size = new System.Drawing.Size(777, 21);
            this.Sms_txt_Sefid.TabIndex = 298;
            //
            //Label4
            //
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(788, 48);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(62, 13);
            this.Label4.TabIndex = 297;
            this.Label4.Text = "متن پیامک :";
            //
            //CheckBox_Sefid
            //
            this.CheckBox_Sefid.AutoSize = true;
            this.CheckBox_Sefid.Location = new System.Drawing.Point(614, 18);
            this.CheckBox_Sefid.Name = "CheckBox_Sefid";
            this.CheckBox_Sefid.Size = new System.Drawing.Size(227, 17);
            this.CheckBox_Sefid.TabIndex = 296;
            this.CheckBox_Sefid.Text = "ارسال پیامک با استفاده از قالب پیامک سفید";
            this.CheckBox_Sefid.UseVisualStyleBackColor = true;
            //
            //Label_Sms
            //
            this.Label_Sms.Location = new System.Drawing.Point(6, 252);
            this.Label_Sms.Name = "Label_Sms";
            this.Label_Sms.Size = new System.Drawing.Size(571, 20);
            this.Label_Sms.TabIndex = 45;
            this.Label_Sms.Text = "*";
            this.Label_Sms.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            //B_Txt_mobile
            //
            this.B_Txt_mobile.Image = (System.Drawing.Image)resources.GetObject("B_Txt_mobile.Image");
            this.B_Txt_mobile.Location = new System.Drawing.Point(583, 251);
            this.B_Txt_mobile.Name = "B_Txt_mobile";
            this.B_Txt_mobile.Size = new System.Drawing.Size(22, 21);
            this.B_Txt_mobile.TabIndex = 44;
            this.B_Txt_mobile.UseVisualStyleBackColor = true;
            //
            //cmdSendMsg
            //
            this.cmdSendMsg.Location = new System.Drawing.Point(668, 443);
            this.cmdSendMsg.Name = "cmdSendMsg";
            this.cmdSendMsg.Size = new System.Drawing.Size(126, 32);
            this.cmdSendMsg.TabIndex = 6;
            this.cmdSendMsg.Text = "ارسال پیام";
            //
            //Label24
            //
            this.Label24.Location = new System.Drawing.Point(800, 337);
            this.Label24.Name = "Label24";
            this.Label24.Size = new System.Drawing.Size(52, 15);
            this.Label24.TabIndex = 5;
            this.Label24.Text = "متن پیام :";
            //
            //txt_Message
            //
            this.txt_Message.Location = new System.Drawing.Point(6, 334);
            this.txt_Message.Multiline = true;
            this.txt_Message.Name = "txt_Message";
            this.txt_Message.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Message.Size = new System.Drawing.Size(788, 106);
            this.txt_Message.TabIndex = 4;
            //
            //txt_mobile
            //
            this.txt_mobile.Location = new System.Drawing.Point(607, 251);
            this.txt_mobile.Name = "txt_mobile";
            this.txt_mobile.Size = new System.Drawing.Size(199, 21);
            this.txt_mobile.TabIndex = 3;
            //
            //Label23
            //
            this.Label23.Location = new System.Drawing.Point(788, 252);
            this.Label23.Name = "Label23";
            this.Label23.Size = new System.Drawing.Size(64, 16);
            this.Label23.TabIndex = 2;
            this.Label23.Text = "شماره :";
            this.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            //sms_2
            //
            this.sms_2.Controls.Add(this.GroupBox1);
            this.sms_2.Location = new System.Drawing.Point(4, 22);
            this.sms_2.Name = "sms_2";
            this.sms_2.Size = new System.Drawing.Size(861, 490);
            this.sms_2.TabIndex = 6;
            this.sms_2.Text = "ارسال پیام گروهی";
            this.sms_2.UseVisualStyleBackColor = true;
            //
            //GroupBox1
            //
            this.GroupBox1.Controls.Add(this.Dv_Mobile_Group);
            this.GroupBox1.Controls.Add(this.TextBox_5_Sefid_Group);
            this.GroupBox1.Controls.Add(this.Label10);
            this.GroupBox1.Controls.Add(this.TextBox_4_Sefid_Group);
            this.GroupBox1.Controls.Add(this.Label11);
            this.GroupBox1.Controls.Add(this.TextBox_3_Sefid_Group);
            this.GroupBox1.Controls.Add(this.Label22);
            this.GroupBox1.Controls.Add(this.TextBox_2_Sefid_Group);
            this.GroupBox1.Controls.Add(this.Label25);
            this.GroupBox1.Controls.Add(this.Dv_Sefid_Group);
            this.GroupBox1.Controls.Add(this.TextBox_Sefid_Group);
            this.GroupBox1.Controls.Add(this.Label27);
            this.GroupBox1.Controls.Add(this.CheckBox_Sefid_Group);
            this.GroupBox1.Controls.Add(this.Button_Group);
            this.GroupBox1.Controls.Add(this.Label31);
            this.GroupBox1.Controls.Add(this.Sms_Sefid_Group);
            this.GroupBox1.Controls.Add(this.TextBox_Group);
            this.GroupBox1.Controls.Add(this.Label33);
            this.GroupBox1.Controls.Add(this.B_Send_Sms_Sefid_Group);
            this.GroupBox1.Location = new System.Drawing.Point(6, 6);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(852, 481);
            this.GroupBox1.TabIndex = 4;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "جزئیات ارسال گروهی  : ";
            //
            //Dv_Mobile_Group
            //
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            DataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dv_Mobile_Group.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3;
            this.Dv_Mobile_Group.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            DataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dv_Mobile_Group.DefaultCellStyle = DataGridViewCellStyle4;
            this.Dv_Mobile_Group.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.Dv_Mobile_Group.Enabled = false;
            this.Dv_Mobile_Group.EnableHeadersVisualStyles = false;
            this.Dv_Mobile_Group.Location = new System.Drawing.Point(6, 211);
            this.Dv_Mobile_Group.Name = "Dv_Mobile_Group";
            this.Dv_Mobile_Group.Size = new System.Drawing.Size(569, 108);
            this.Dv_Mobile_Group.TabIndex = 335;
            //
            //TextBox_5_Sefid_Group
            //
            this.TextBox_5_Sefid_Group.Enabled = false;
            this.TextBox_5_Sefid_Group.Font = new System.Drawing.Font("Tahoma", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.TextBox_5_Sefid_Group.Location = new System.Drawing.Point(6, 356);
            this.TextBox_5_Sefid_Group.Name = "TextBox_5_Sefid_Group";
            this.TextBox_5_Sefid_Group.Size = new System.Drawing.Size(291, 22);
            this.TextBox_5_Sefid_Group.TabIndex = 334;
            //
            //Label10
            //
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(299, 360);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(122, 13);
            this.Label10.TabIndex = 333;
            this.Label10.Text = "متن متغییر پنجم  پیامک :";
            //
            //TextBox_4_Sefid_Group
            //
            this.TextBox_4_Sefid_Group.Enabled = false;
            this.TextBox_4_Sefid_Group.Font = new System.Drawing.Font("Tahoma", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.TextBox_4_Sefid_Group.Location = new System.Drawing.Point(423, 356);
            this.TextBox_4_Sefid_Group.Name = "TextBox_4_Sefid_Group";
            this.TextBox_4_Sefid_Group.Size = new System.Drawing.Size(291, 22);
            this.TextBox_4_Sefid_Group.TabIndex = 332;
            //
            //Label11
            //
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(719, 360);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(127, 13);
            this.Label11.TabIndex = 331;
            this.Label11.Text = "متن متغییر چهارم  پیامک :";
            //
            //TextBox_3_Sefid_Group
            //
            this.TextBox_3_Sefid_Group.Enabled = false;
            this.TextBox_3_Sefid_Group.Font = new System.Drawing.Font("Tahoma", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.TextBox_3_Sefid_Group.Location = new System.Drawing.Point(6, 328);
            this.TextBox_3_Sefid_Group.Name = "TextBox_3_Sefid_Group";
            this.TextBox_3_Sefid_Group.Size = new System.Drawing.Size(291, 22);
            this.TextBox_3_Sefid_Group.TabIndex = 330;
            //
            //Label22
            //
            this.Label22.AutoSize = true;
            this.Label22.Location = new System.Drawing.Point(299, 332);
            this.Label22.Name = "Label22";
            this.Label22.Size = new System.Drawing.Size(123, 13);
            this.Label22.TabIndex = 329;
            this.Label22.Text = "متن متغییر سوم  پیامک :";
            //
            //TextBox_2_Sefid_Group
            //
            this.TextBox_2_Sefid_Group.Enabled = false;
            this.TextBox_2_Sefid_Group.Font = new System.Drawing.Font("Tahoma", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.TextBox_2_Sefid_Group.Location = new System.Drawing.Point(423, 328);
            this.TextBox_2_Sefid_Group.Name = "TextBox_2_Sefid_Group";
            this.TextBox_2_Sefid_Group.Size = new System.Drawing.Size(291, 22);
            this.TextBox_2_Sefid_Group.TabIndex = 328;
            //
            //Label25
            //
            this.Label25.AutoSize = true;
            this.Label25.Location = new System.Drawing.Point(719, 332);
            this.Label25.Name = "Label25";
            this.Label25.Size = new System.Drawing.Size(117, 13);
            this.Label25.TabIndex = 327;
            this.Label25.Text = "متن متغییر دوم  پیامک :";
            //
            //Dv_Sefid_Group
            //
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            DataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dv_Sefid_Group.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5;
            this.Dv_Sefid_Group.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            DataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dv_Sefid_Group.DefaultCellStyle = DataGridViewCellStyle6;
            this.Dv_Sefid_Group.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.Dv_Sefid_Group.Enabled = false;
            this.Dv_Sefid_Group.EnableHeadersVisualStyles = false;
            this.Dv_Sefid_Group.Location = new System.Drawing.Point(6, 68);
            this.Dv_Sefid_Group.Name = "Dv_Sefid_Group";
            this.Dv_Sefid_Group.Size = new System.Drawing.Size(843, 140);
            this.Dv_Sefid_Group.TabIndex = 322;
            //
            //TextBox_Sefid_Group
            //
            this.TextBox_Sefid_Group.Enabled = false;
            this.TextBox_Sefid_Group.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.TextBox_Sefid_Group.Location = new System.Drawing.Point(6, 41);
            this.TextBox_Sefid_Group.Name = "TextBox_Sefid_Group";
            this.TextBox_Sefid_Group.Size = new System.Drawing.Size(777, 21);
            this.TextBox_Sefid_Group.TabIndex = 321;
            //
            //Label27
            //
            this.Label27.AutoSize = true;
            this.Label27.Location = new System.Drawing.Point(788, 45);
            this.Label27.Name = "Label27";
            this.Label27.Size = new System.Drawing.Size(62, 13);
            this.Label27.TabIndex = 320;
            this.Label27.Text = "متن پیامک :";
            //
            //CheckBox_Sefid_Group
            //
            this.CheckBox_Sefid_Group.AutoSize = true;
            this.CheckBox_Sefid_Group.Enabled = false;
            this.CheckBox_Sefid_Group.Location = new System.Drawing.Point(614, 15);
            this.CheckBox_Sefid_Group.Name = "CheckBox_Sefid_Group";
            this.CheckBox_Sefid_Group.Size = new System.Drawing.Size(227, 17);
            this.CheckBox_Sefid_Group.TabIndex = 319;
            this.CheckBox_Sefid_Group.Text = "ارسال پیامک با استفاده از قالب پیامک سفید";
            this.CheckBox_Sefid_Group.UseVisualStyleBackColor = true;
            //
            //Button_Group
            //
            this.Button_Group.Enabled = false;
            this.Button_Group.Image = (System.Drawing.Image)resources.GetObject("Button_Group.Image");
            this.Button_Group.Location = new System.Drawing.Point(581, 235);
            this.Button_Group.Name = "Button_Group";
            this.Button_Group.Size = new System.Drawing.Size(22, 21);
            this.Button_Group.TabIndex = 317;
            this.Button_Group.UseVisualStyleBackColor = true;
            //
            //Label31
            //
            this.Label31.Location = new System.Drawing.Point(800, 383);
            this.Label31.Name = "Label31";
            this.Label31.Size = new System.Drawing.Size(52, 15);
            this.Label31.TabIndex = 316;
            this.Label31.Text = "متن پیام :";
            //
            //Sms_Sefid_Group
            //
            this.Sms_Sefid_Group.Enabled = false;
            this.Sms_Sefid_Group.Location = new System.Drawing.Point(142, 383);
            this.Sms_Sefid_Group.Multiline = true;
            this.Sms_Sefid_Group.Name = "Sms_Sefid_Group";
            this.Sms_Sefid_Group.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Sms_Sefid_Group.Size = new System.Drawing.Size(652, 54);
            this.Sms_Sefid_Group.TabIndex = 315;
            //
            //TextBox_Group
            //
            this.TextBox_Group.Enabled = false;
            this.TextBox_Group.Location = new System.Drawing.Point(605, 235);
            this.TextBox_Group.Name = "TextBox_Group";
            this.TextBox_Group.Size = new System.Drawing.Size(242, 21);
            this.TextBox_Group.TabIndex = 314;
            //
            //Label33
            //
            this.Label33.Location = new System.Drawing.Point(778, 214);
            this.Label33.Name = "Label33";
            this.Label33.Size = new System.Drawing.Size(74, 16);
            this.Label33.TabIndex = 313;
            this.Label33.Text = "انتخاب گروه :";
            this.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            //B_Send_Sms_Sefid_Group
            //
            this.B_Send_Sms_Sefid_Group.Enabled = false;
            this.B_Send_Sms_Sefid_Group.Location = new System.Drawing.Point(10, 384);
            this.B_Send_Sms_Sefid_Group.Name = "B_Send_Sms_Sefid_Group";
            this.B_Send_Sms_Sefid_Group.Size = new System.Drawing.Size(126, 53);
            this.B_Send_Sms_Sefid_Group.TabIndex = 6;
            this.B_Send_Sms_Sefid_Group.Text = "ارسال پیام";
            //
            //sms_3
            //
            this.sms_3.Controls.Add(this.GroupBox7);
            this.sms_3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.sms_3.Location = new System.Drawing.Point(4, 22);
            this.sms_3.Name = "sms_3";
            this.sms_3.Padding = new System.Windows.Forms.Padding(3);
            this.sms_3.Size = new System.Drawing.Size(861, 490);
            this.sms_3.TabIndex = 0;
            this.sms_3.Text = "صندوق دریافت";
            this.sms_3.UseVisualStyleBackColor = true;
            //
            //GroupBox7
            //
            this.GroupBox7.Controls.Add(this.lblMsgCount);
            this.GroupBox7.Controls.Add(this.cmdMsgDelete);
            this.GroupBox7.Controls.Add(this.cmdInboxRefresh);
            this.GroupBox7.Controls.Add(this.Label29);
            this.GroupBox7.Controls.Add(this.txtInterval);
            this.GroupBox7.Controls.Add(this.chkInboxRefresh);
            this.GroupBox7.Controls.Add(this.chkInConcatenate);
            this.GroupBox7.Controls.Add(this.cboMsgMemory);
            this.GroupBox7.Controls.Add(this.Label28);
            this.GroupBox7.Controls.Add(this.lstInbox);
            this.GroupBox7.Location = new System.Drawing.Point(6, 6);
            this.GroupBox7.Name = "GroupBox7";
            this.GroupBox7.Size = new System.Drawing.Size(847, 391);
            this.GroupBox7.TabIndex = 1;
            this.GroupBox7.TabStop = false;
            this.GroupBox7.Text = "صندوق دریافت  : ";
            //
            //lblMsgCount
            //
            this.lblMsgCount.Location = new System.Drawing.Point(13, 348);
            this.lblMsgCount.Name = "lblMsgCount";
            this.lblMsgCount.Size = new System.Drawing.Size(385, 34);
            this.lblMsgCount.TabIndex = 9;
            this.lblMsgCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            //cmdMsgDelete
            //
            this.cmdMsgDelete.Location = new System.Drawing.Point(417, 353);
            this.cmdMsgDelete.Name = "cmdMsgDelete";
            this.cmdMsgDelete.Size = new System.Drawing.Size(88, 25);
            this.cmdMsgDelete.TabIndex = 8;
            this.cmdMsgDelete.Text = "حذف";
            //
            //cmdInboxRefresh
            //
            this.cmdInboxRefresh.Location = new System.Drawing.Point(522, 353);
            this.cmdInboxRefresh.Name = "cmdInboxRefresh";
            this.cmdInboxRefresh.Size = new System.Drawing.Size(88, 25);
            this.cmdInboxRefresh.TabIndex = 7;
            this.cmdInboxRefresh.Text = "بازخوانی";
            //
            //Label29
            //
            this.Label29.Location = new System.Drawing.Point(417, 56);
            this.Label29.Name = "Label29";
            this.Label29.Size = new System.Drawing.Size(38, 16);
            this.Label29.TabIndex = 6;
            this.Label29.Text = "ثانیه";
            this.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            //txtInterval
            //
            this.txtInterval.Enabled = false;
            this.txtInterval.Location = new System.Drawing.Point(457, 53);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(32, 21);
            this.txtInterval.TabIndex = 5;
            //
            //chkInboxRefresh
            //
            this.chkInboxRefresh.Location = new System.Drawing.Point(491, 56);
            this.chkInboxRefresh.Name = "chkInboxRefresh";
            this.chkInboxRefresh.Size = new System.Drawing.Size(114, 18);
            this.chkInboxRefresh.TabIndex = 4;
            this.chkInboxRefresh.Text = "خواندن اطلاعات هر";
            //
            //chkInConcatenate
            //
            this.chkInConcatenate.Location = new System.Drawing.Point(469, 25);
            this.chkInConcatenate.Name = "chkInConcatenate";
            this.chkInConcatenate.Size = new System.Drawing.Size(136, 20);
            this.chkInConcatenate.TabIndex = 3;
            this.chkInConcatenate.Text = "بررسی پیام ها";
            //
            //cboMsgMemory
            //
            this.cboMsgMemory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMsgMemory.Location = new System.Drawing.Point(194, 21);
            this.cboMsgMemory.Name = "cboMsgMemory";
            this.cboMsgMemory.Size = new System.Drawing.Size(96, 21);
            this.cboMsgMemory.TabIndex = 2;
            //
            //Label28
            //
            this.Label28.Location = new System.Drawing.Point(282, 22);
            this.Label28.Name = "Label28";
            this.Label28.Size = new System.Drawing.Size(100, 16);
            this.Label28.TabIndex = 1;
            this.Label28.Text = "خواندن پیام ها از :";
            this.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            //lstInbox
            //
            this.lstInbox.CheckBoxes = true;
            this.lstInbox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { this.clmTime, this.clmMessage, this.clmFrom });
            this.lstInbox.FullRowSelect = true;
            this.lstInbox.GridLines = true;
            this.lstInbox.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstInbox.Location = new System.Drawing.Point(10, 86);
            this.lstInbox.MultiSelect = false;
            this.lstInbox.Name = "lstInbox";
            this.lstInbox.RightToLeftLayout = true;
            this.lstInbox.Size = new System.Drawing.Size(831, 254);
            this.lstInbox.TabIndex = 0;
            this.lstInbox.UseCompatibleStateImageBehavior = false;
            this.lstInbox.View = System.Windows.Forms.View.Details;
            //
            //clmTime
            //
            this.clmTime.DisplayIndex = 2;
            this.clmTime.Text = "تاریخ";
            this.clmTime.Width = 160;
            //
            //clmMessage
            //
            this.clmMessage.Text = "متن پیام";
            this.clmMessage.Width = 316;
            //
            //clmFrom
            //
            this.clmFrom.DisplayIndex = 0;
            this.clmFrom.Text = "مخاطب";
            this.clmFrom.Width = 120;
            //
            //sms_4
            //
            this.sms_4.Controls.Add(this.GroupBox13);
            this.sms_4.Controls.Add(this.GroupBox12);
            this.sms_4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.sms_4.Location = new System.Drawing.Point(4, 22);
            this.sms_4.Name = "sms_4";
            this.sms_4.Size = new System.Drawing.Size(861, 490);
            this.sms_4.TabIndex = 2;
            this.sms_4.Text = "ایجاد مسابقه";
            this.sms_4.UseVisualStyleBackColor = true;
            //
            //GroupBox13
            //
            this.GroupBox13.Controls.Add(this.Button3);
            this.GroupBox13.Controls.Add(this.Button4);
            this.GroupBox13.Controls.Add(this.ListView1);
            this.GroupBox13.Enabled = false;
            this.GroupBox13.Location = new System.Drawing.Point(7, 160);
            this.GroupBox13.Name = "GroupBox13";
            this.GroupBox13.Size = new System.Drawing.Size(846, 267);
            this.GroupBox13.TabIndex = 2;
            this.GroupBox13.TabStop = false;
            this.GroupBox13.Text = "نمایش نتایج : ";
            //
            //Button3
            //
            this.Button3.Location = new System.Drawing.Point(413, 206);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(88, 25);
            this.Button3.TabIndex = 10;
            this.Button3.Text = "حذف";
            //
            //Button4
            //
            this.Button4.Location = new System.Drawing.Point(522, 206);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(88, 25);
            this.Button4.TabIndex = 9;
            this.Button4.Text = "بازخوانی";
            //
            //ListView1
            //
            this.ListView1.CheckBoxes = true;
            this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { this.ColumnHeader1, this.ColumnHeader2, this.ColumnHeader3 });
            this.ListView1.FullRowSelect = true;
            this.ListView1.GridLines = true;
            this.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ListView1.Location = new System.Drawing.Point(9, 20);
            this.ListView1.MultiSelect = false;
            this.ListView1.Name = "ListView1";
            this.ListView1.RightToLeftLayout = true;
            this.ListView1.Size = new System.Drawing.Size(831, 180);
            this.ListView1.TabIndex = 1;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.View = System.Windows.Forms.View.Details;
            //
            //ColumnHeader1
            //
            this.ColumnHeader1.DisplayIndex = 2;
            this.ColumnHeader1.Text = "تاریخ";
            this.ColumnHeader1.Width = 160;
            //
            //ColumnHeader2
            //
            this.ColumnHeader2.Text = "پــاســخ";
            this.ColumnHeader2.Width = 316;
            //
            //ColumnHeader3
            //
            this.ColumnHeader3.DisplayIndex = 0;
            this.ColumnHeader3.Text = "مخاطب";
            this.ColumnHeader3.Width = 120;
            //
            //GroupBox12
            //
            this.GroupBox12.Controls.Add(this.TextBox6);
            this.GroupBox12.Controls.Add(this.Label44);
            this.GroupBox12.Controls.Add(this.TextBox5);
            this.GroupBox12.Controls.Add(this.Label43);
            this.GroupBox12.Controls.Add(this.TextBox4);
            this.GroupBox12.Controls.Add(this.Label42);
            this.GroupBox12.Controls.Add(this.TextBox3);
            this.GroupBox12.Controls.Add(this.Label41);
            this.GroupBox12.Controls.Add(this.Button2);
            this.GroupBox12.Controls.Add(this.TextBox2);
            this.GroupBox12.Controls.Add(this.Label40);
            this.GroupBox12.Controls.Add(this.TextBox1);
            this.GroupBox12.Controls.Add(this.Label14);
            this.GroupBox12.Controls.Add(this.Button1);
            this.GroupBox12.Location = new System.Drawing.Point(7, 7);
            this.GroupBox12.Name = "GroupBox12";
            this.GroupBox12.Size = new System.Drawing.Size(846, 151);
            this.GroupBox12.TabIndex = 1;
            this.GroupBox12.TabStop = false;
            this.GroupBox12.Text = "ایجاد مسابقه : ";
            //
            //TextBox6
            //
            this.TextBox6.Location = new System.Drawing.Point(15, 109);
            this.TextBox6.Name = "TextBox6";
            this.TextBox6.Size = new System.Drawing.Size(138, 21);
            this.TextBox6.TabIndex = 13;
            //
            //Label44
            //
            this.Label44.AutoSize = true;
            this.Label44.Location = new System.Drawing.Point(159, 112);
            this.Label44.Name = "Label44";
            this.Label44.Size = new System.Drawing.Size(45, 13);
            this.Label44.TabIndex = 12;
            this.Label44.Text = "گزینه د :";
            //
            //TextBox5
            //
            this.TextBox5.Location = new System.Drawing.Point(15, 82);
            this.TextBox5.Name = "TextBox5";
            this.TextBox5.Size = new System.Drawing.Size(138, 21);
            this.TextBox5.TabIndex = 11;
            //
            //Label43
            //
            this.Label43.AutoSize = true;
            this.Label43.Location = new System.Drawing.Point(159, 85);
            this.Label43.Name = "Label43";
            this.Label43.Size = new System.Drawing.Size(47, 13);
            this.Label43.TabIndex = 10;
            this.Label43.Text = "گزینه ج :";
            //
            //TextBox4
            //
            this.TextBox4.Location = new System.Drawing.Point(15, 55);
            this.TextBox4.Name = "TextBox4";
            this.TextBox4.Size = new System.Drawing.Size(138, 21);
            this.TextBox4.TabIndex = 9;
            //
            //Label42
            //
            this.Label42.AutoSize = true;
            this.Label42.Location = new System.Drawing.Point(159, 58);
            this.Label42.Name = "Label42";
            this.Label42.Size = new System.Drawing.Size(49, 13);
            this.Label42.TabIndex = 8;
            this.Label42.Text = "گزینه ب :";
            //
            //TextBox3
            //
            this.TextBox3.Location = new System.Drawing.Point(15, 28);
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.Size = new System.Drawing.Size(138, 21);
            this.TextBox3.TabIndex = 7;
            //
            //Label41
            //
            this.Label41.AutoSize = true;
            this.Label41.Location = new System.Drawing.Point(159, 31);
            this.Label41.Name = "Label41";
            this.Label41.Size = new System.Drawing.Size(56, 13);
            this.Label41.TabIndex = 6;
            this.Label41.Text = "گزینه الف :";
            //
            //Button2
            //
            this.Button2.Location = new System.Drawing.Point(595, 97);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(75, 25);
            this.Button2.TabIndex = 5;
            this.Button2.Text = "پاک کردن";
            this.Button2.UseVisualStyleBackColor = true;
            //
            //TextBox2
            //
            this.TextBox2.Location = new System.Drawing.Point(475, 59);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(276, 21);
            this.TextBox2.TabIndex = 4;
            //
            //Label40
            //
            this.Label40.AutoSize = true;
            this.Label40.Location = new System.Drawing.Point(754, 62);
            this.Label40.Name = "Label40";
            this.Label40.Size = new System.Drawing.Size(82, 13);
            this.Label40.TabIndex = 3;
            this.Label40.Text = "سوال مسابقه : ";
            //
            //TextBox1
            //
            this.TextBox1.Location = new System.Drawing.Point(475, 20);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(276, 21);
            this.TextBox1.TabIndex = 2;
            //
            //Label14
            //
            this.Label14.AutoSize = true;
            this.Label14.Location = new System.Drawing.Point(757, 23);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(79, 13);
            this.Label14.TabIndex = 1;
            this.Label14.Text = "عنوان مسابقه :";
            //
            //Button1
            //
            this.Button1.Location = new System.Drawing.Point(676, 97);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 25);
            this.Button1.TabIndex = 0;
            this.Button1.Text = "ثـبـت";
            this.Button1.UseVisualStyleBackColor = true;
            //
            //sms_5
            //
            this.sms_5.Controls.Add(this.TBG_Logs);
            this.sms_5.Controls.Add(this.GroupBox11);
            this.sms_5.Controls.Add(this.GroupBox10);
            this.sms_5.Location = new System.Drawing.Point(4, 22);
            this.sms_5.Name = "sms_5";
            this.sms_5.Padding = new System.Windows.Forms.Padding(3);
            this.sms_5.Size = new System.Drawing.Size(861, 490);
            this.sms_5.TabIndex = 7;
            this.sms_5.Text = "خطاهای ارسالی";
            this.sms_5.UseVisualStyleBackColor = true;
            //
            //TBG_Logs
            //
            DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            DataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TBG_Logs.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7;
            this.TBG_Logs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            DataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TBG_Logs.DefaultCellStyle = DataGridViewCellStyle8;
            this.TBG_Logs.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.TBG_Logs.Location = new System.Drawing.Point(6, 3);
            this.TBG_Logs.Name = "TBG_Logs";
            this.TBG_Logs.Size = new System.Drawing.Size(847, 321);
            this.TBG_Logs.TabIndex = 32;
            //
            //GroupBox11
            //
            this.GroupBox11.Controls.Add(this.Delete_All_Logs);
            this.GroupBox11.Controls.Add(this.Reply_Send_SMS_4ALL);
            this.GroupBox11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.GroupBox11.Location = new System.Drawing.Point(6, 330);
            this.GroupBox11.Name = "GroupBox11";
            this.GroupBox11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GroupBox11.Size = new System.Drawing.Size(299, 97);
            this.GroupBox11.TabIndex = 31;
            this.GroupBox11.TabStop = false;
            //
            //Delete_All_Logs
            //
            this.Delete_All_Logs.Enabled = false;
            this.Delete_All_Logs.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Delete_All_Logs.Location = new System.Drawing.Point(7, 56);
            this.Delete_All_Logs.Name = "Delete_All_Logs";
            this.Delete_All_Logs.Size = new System.Drawing.Size(285, 34);
            this.Delete_All_Logs.TabIndex = 30;
            this.Delete_All_Logs.Text = "حذف همه";
            this.Delete_All_Logs.UseVisualStyleBackColor = true;
            //
            //Reply_Send_SMS_4ALL
            //
            this.Reply_Send_SMS_4ALL.Enabled = false;
            this.Reply_Send_SMS_4ALL.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Reply_Send_SMS_4ALL.Location = new System.Drawing.Point(7, 17);
            this.Reply_Send_SMS_4ALL.Name = "Reply_Send_SMS_4ALL";
            this.Reply_Send_SMS_4ALL.Size = new System.Drawing.Size(285, 34);
            this.Reply_Send_SMS_4ALL.TabIndex = 29;
            this.Reply_Send_SMS_4ALL.Text = "ارسال مجدد تمامی پیام ها";
            this.Reply_Send_SMS_4ALL.UseVisualStyleBackColor = true;
            //
            //GroupBox10
            //
            this.GroupBox10.Controls.Add(this.Label3);
            this.GroupBox10.Controls.Add(this.GroupBox4);
            this.GroupBox10.Controls.Add(this.Estate_Plaque);
            this.GroupBox10.Controls.Add(this.Label39);
            this.GroupBox10.Controls.Add(this.MemberTXT);
            this.GroupBox10.Controls.Add(this.Reply_Send_SMS);
            this.GroupBox10.Location = new System.Drawing.Point(311, 330);
            this.GroupBox10.Name = "GroupBox10";
            this.GroupBox10.Size = new System.Drawing.Size(542, 97);
            this.GroupBox10.TabIndex = 0;
            this.GroupBox10.TabStop = false;
            this.GroupBox10.Text = "ارسال مجدد پیام : ";
            //
            //Label3
            //
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(233, 67);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(42, 13);
            this.Label3.TabIndex = 258;
            this.Label3.Text = "همراه :";
            //
            //GroupBox4
            //
            this.GroupBox4.Controls.Add(this.Label2);
            this.GroupBox4.Controls.Add(this.Label1);
            this.GroupBox4.Controls.Add(this.Warranty_Document_From_Date);
            this.GroupBox4.Controls.Add(this.Warranty_Document_Until_Date);
            this.GroupBox4.Location = new System.Drawing.Point(274, 47);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(262, 46);
            this.GroupBox4.TabIndex = 255;
            this.GroupBox4.TabStop = false;
            //
            //Label2
            //
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(109, 21);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(13, 13);
            this.Label2.TabIndex = 257;
            this.Label2.Text = "تا";
            //
            //Label1
            //
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(226, 20);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(35, 13);
            this.Label1.TabIndex = 256;
            this.Label1.Text = "تاریخ :";
            //
            //Warranty_Document_From_Date
            //
            this.Warranty_Document_From_Date.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Warranty_Document_From_Date.AutoSize = true;
            this.Warranty_Document_From_Date.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Warranty_Document_From_Date.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Warranty_Document_From_Date.Location = new System.Drawing.Point(123, 12);
            this.Warranty_Document_From_Date.Name = "Warranty_Document_From_Date";
            this.Warranty_Document_From_Date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Warranty_Document_From_Date.Size = new System.Drawing.Size(121, 32);
            this.Warranty_Document_From_Date.T_D = "";
            this.Warranty_Document_From_Date.TabIndex = 0;
            //
            //Warranty_Document_Until_Date
            //
            this.Warranty_Document_Until_Date.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Warranty_Document_Until_Date.AutoSize = true;
            this.Warranty_Document_Until_Date.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Warranty_Document_Until_Date.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Warranty_Document_Until_Date.Location = new System.Drawing.Point(4, 12);
            this.Warranty_Document_Until_Date.Name = "Warranty_Document_Until_Date";
            this.Warranty_Document_Until_Date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Warranty_Document_Until_Date.Size = new System.Drawing.Size(121, 32);
            this.Warranty_Document_Until_Date.T_D = "";
            this.Warranty_Document_Until_Date.TabIndex = 1;
            //
            //Estate_Plaque
            //
            this.Estate_Plaque.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Estate_Plaque.FormattingEnabled = true;
            this.Estate_Plaque.Items.AddRange(new object[] { "قطع بودن اینترنت یا شبکه مخابراتی" });
            this.Estate_Plaque.Location = new System.Drawing.Point(6, 16);
            this.Estate_Plaque.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Estate_Plaque.Name = "Estate_Plaque";
            this.Estate_Plaque.Size = new System.Drawing.Size(438, 27);
            this.Estate_Plaque.TabIndex = 26;
            //
            //Label39
            //
            this.Label39.AutoSize = true;
            this.Label39.Location = new System.Drawing.Point(450, 25);
            this.Label39.Name = "Label39";
            this.Label39.Size = new System.Drawing.Size(89, 13);
            this.Label39.TabIndex = 25;
            this.Label39.Text = "علت عدم ارسال :";
            //
            //MemberTXT
            //
            this.MemberTXT.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MemberTXT.Location = new System.Drawing.Point(87, 61);
            this.MemberTXT.Name = "MemberTXT";
            this.MemberTXT.ReadOnly = true;
            this.MemberTXT.Size = new System.Drawing.Size(140, 21);
            this.MemberTXT.TabIndex = 24;
            //
            //Reply_Send_SMS
            //
            this.Reply_Send_SMS.Location = new System.Drawing.Point(6, 58);
            this.Reply_Send_SMS.Name = "Reply_Send_SMS";
            this.Reply_Send_SMS.Size = new System.Drawing.Size(75, 25);
            this.Reply_Send_SMS.TabIndex = 23;
            this.Reply_Send_SMS.Text = "جستجو";
            this.Reply_Send_SMS.UseVisualStyleBackColor = true;
            //
            //sms_6
            //
            this.sms_6.Controls.Add(this.SettingGroupBox);
            this.sms_6.Location = new System.Drawing.Point(4, 22);
            this.sms_6.Name = "sms_6";
            this.sms_6.Size = new System.Drawing.Size(861, 490);
            this.sms_6.TabIndex = 5;
            this.sms_6.Text = "تنظیمات";
            this.sms_6.UseVisualStyleBackColor = true;
            //
            //SettingGroupBox
            //
            this.SettingGroupBox.Controls.Add(this.GroupBox3);
            this.SettingGroupBox.Controls.Add(this.GroupStarterMatn);
            this.SettingGroupBox.Controls.Add(this.SAVE_Setting);
            this.SettingGroupBox.Location = new System.Drawing.Point(7, 6);
            this.SettingGroupBox.Name = "SettingGroupBox";
            this.SettingGroupBox.Size = new System.Drawing.Size(846, 476);
            this.SettingGroupBox.TabIndex = 2;
            this.SettingGroupBox.TabStop = false;
            this.SettingGroupBox.Text = "تنظیمات : ";
            //
            //GroupBox3
            //
            this.GroupBox3.Controls.Add(this.Tab_Warranty_Document);
            this.GroupBox3.Location = new System.Drawing.Point(6, 136);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(834, 304);
            this.GroupBox3.TabIndex = 33;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "تنظیمات ارسال پیام کوتاه :";
            //
            //Tab_Warranty_Document
            //
            this.Tab_Warranty_Document.Controls.Add(this.Sms_Services);
            this.Tab_Warranty_Document.Controls.Add(this.Sms_Accounting);
            this.Tab_Warranty_Document.Controls.Add(this.Sms_Repair);
            this.Tab_Warranty_Document.Controls.Add(this.Sms_PayRoll);
            this.Tab_Warranty_Document.Controls.Add(this.Sms_Warehouse);
            this.Tab_Warranty_Document.Controls.Add(this.Sms_Assets);
            this.Tab_Warranty_Document.Controls.Add(this.Sms_Payable);
            this.Tab_Warranty_Document.Controls.Add(this.Sms_Collection_Document);
            this.Tab_Warranty_Document.Controls.Add(this.Sms_Warranty_Document);
            this.Tab_Warranty_Document.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tab_Warranty_Document.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Tab_Warranty_Document.Location = new System.Drawing.Point(3, 17);
            this.Tab_Warranty_Document.Name = "Tab_Warranty_Document";
            this.Tab_Warranty_Document.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Tab_Warranty_Document.RightToLeftLayout = true;
            this.Tab_Warranty_Document.SelectedIndex = 0;
            this.Tab_Warranty_Document.Size = new System.Drawing.Size(828, 284);
            this.Tab_Warranty_Document.TabIndex = 4;
            this.Tab_Warranty_Document.TabStop = false;
            //
            //Sms_Services
            //
            this.Sms_Services.Location = new System.Drawing.Point(4, 22);
            this.Sms_Services.Name = "Sms_Services";
            this.Sms_Services.Size = new System.Drawing.Size(820, 258);
            this.Sms_Services.TabIndex = 6;
            this.Sms_Services.Text = "خدمات";
            this.Sms_Services.UseVisualStyleBackColor = true;
            //
            //Sms_Accounting
            //
            this.Sms_Accounting.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Sms_Accounting.Location = new System.Drawing.Point(4, 22);
            this.Sms_Accounting.Name = "Sms_Accounting";
            this.Sms_Accounting.Padding = new System.Windows.Forms.Padding(3);
            this.Sms_Accounting.Size = new System.Drawing.Size(820, 258);
            this.Sms_Accounting.TabIndex = 0;
            this.Sms_Accounting.Text = "حسابداری";
            this.Sms_Accounting.UseVisualStyleBackColor = true;
            //
            //Sms_Repair
            //
            this.Sms_Repair.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Sms_Repair.Location = new System.Drawing.Point(4, 22);
            this.Sms_Repair.Name = "Sms_Repair";
            this.Sms_Repair.Size = new System.Drawing.Size(820, 258);
            this.Sms_Repair.TabIndex = 2;
            this.Sms_Repair.Text = "تعمیر و نگهداری";
            this.Sms_Repair.UseVisualStyleBackColor = true;
            //
            //Sms_PayRoll
            //
            this.Sms_PayRoll.Controls.Add(this.GroupBox16);
            this.Sms_PayRoll.Controls.Add(this.GroupBox17);
            this.Sms_PayRoll.Location = new System.Drawing.Point(4, 22);
            this.Sms_PayRoll.Name = "Sms_PayRoll";
            this.Sms_PayRoll.Padding = new System.Windows.Forms.Padding(3);
            this.Sms_PayRoll.Size = new System.Drawing.Size(820, 258);
            this.Sms_PayRoll.TabIndex = 7;
            this.Sms_PayRoll.Text = "حقوق و دستمزد";
            this.Sms_PayRoll.UseVisualStyleBackColor = true;
            //
            //GroupBox16
            //
            this.GroupBox16.Controls.Add(this.CheckedListBox2);
            this.GroupBox16.Controls.Add(this.CheckedListBox3);
            this.GroupBox16.Controls.Add(this.Button15);
            this.GroupBox16.Controls.Add(this.Button16);
            this.GroupBox16.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.GroupBox16.Location = new System.Drawing.Point(6, 301);
            this.GroupBox16.Name = "GroupBox16";
            this.GroupBox16.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GroupBox16.Size = new System.Drawing.Size(299, 97);
            this.GroupBox16.TabIndex = 31;
            this.GroupBox16.TabStop = false;
            //
            //CheckedListBox2
            //
            this.CheckedListBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.CheckedListBox2.CheckOnClick = true;
            this.CheckedListBox2.FormattingEnabled = true;
            this.CheckedListBox2.Location = new System.Drawing.Point(19, 0);
            this.CheckedListBox2.Name = "CheckedListBox2";
            this.CheckedListBox2.Size = new System.Drawing.Size(10, 4);
            this.CheckedListBox2.TabIndex = 36;
            this.CheckedListBox2.Visible = false;
            //
            //CheckedListBox3
            //
            this.CheckedListBox3.CheckOnClick = true;
            this.CheckedListBox3.FormattingEnabled = true;
            this.CheckedListBox3.Location = new System.Drawing.Point(0, 0);
            this.CheckedListBox3.Name = "CheckedListBox3";
            this.CheckedListBox3.Size = new System.Drawing.Size(13, 4);
            this.CheckedListBox3.TabIndex = 37;
            this.CheckedListBox3.Visible = false;
            //
            //Button15
            //
            this.Button15.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Button15.Location = new System.Drawing.Point(177, 56);
            this.Button15.Name = "Button15";
            this.Button15.Size = new System.Drawing.Size(115, 34);
            this.Button15.TabIndex = 30;
            this.Button15.Text = "حذف همه";
            this.Button15.UseVisualStyleBackColor = true;
            //
            //Button16
            //
            this.Button16.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)178);
            this.Button16.Location = new System.Drawing.Point(7, 17);
            this.Button16.Name = "Button16";
            this.Button16.Size = new System.Drawing.Size(285, 34);
            this.Button16.TabIndex = 29;
            this.Button16.Text = "ارسال مجدد تمامی پیام ها";
            this.Button16.UseVisualStyleBackColor = true;
            //
            //GroupBox17
            //
            this.GroupBox17.Controls.Add(this.Label26);
            this.GroupBox17.Controls.Add(this.TextBox18);
            this.GroupBox17.Controls.Add(this.Button17);
            this.GroupBox17.Location = new System.Drawing.Point(311, 301);
            this.GroupBox17.Name = "GroupBox17";
            this.GroupBox17.Size = new System.Drawing.Size(315, 97);
            this.GroupBox17.TabIndex = 0;
            this.GroupBox17.TabStop = false;
            this.GroupBox17.Text = "ارسال مجدد پیام : ";
            //
            //Label26
            //
            this.Label26.AutoSize = true;
            this.Label26.Location = new System.Drawing.Point(259, 32);
            this.Label26.Name = "Label26";
            this.Label26.Size = new System.Drawing.Size(47, 13);
            this.Label26.TabIndex = 25;
            this.Label26.Text = "مخاطب :";
            //
            //TextBox18
            //
            this.TextBox18.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TextBox18.Location = new System.Drawing.Point(105, 29);
            this.TextBox18.Name = "TextBox18";
            this.TextBox18.ReadOnly = true;
            this.TextBox18.Size = new System.Drawing.Size(148, 21);
            this.TextBox18.TabIndex = 24;
            //
            //Button17
            //
            this.Button17.Location = new System.Drawing.Point(16, 27);
            this.Button17.Name = "Button17";
            this.Button17.Size = new System.Drawing.Size(75, 25);
            this.Button17.TabIndex = 23;
            this.Button17.Text = "ارســال";
            this.Button17.UseVisualStyleBackColor = true;
            //
            //Sms_Warehouse
            //
            this.Sms_Warehouse.Location = new System.Drawing.Point(4, 22);
            this.Sms_Warehouse.Name = "Sms_Warehouse";
            this.Sms_Warehouse.Size = new System.Drawing.Size(820, 258);
            this.Sms_Warehouse.TabIndex = 8;
            this.Sms_Warehouse.Text = "انبار";
            this.Sms_Warehouse.UseVisualStyleBackColor = true;
            //
            //Sms_Assets
            //
            this.Sms_Assets.Location = new System.Drawing.Point(4, 22);
            this.Sms_Assets.Name = "Sms_Assets";
            this.Sms_Assets.Size = new System.Drawing.Size(820, 258);
            this.Sms_Assets.TabIndex = 9;
            this.Sms_Assets.Text = "اموال";
            this.Sms_Assets.UseVisualStyleBackColor = true;
            //
            //Sms_Payable
            //
            this.Sms_Payable.Controls.Add(this.Sms_Text_Payable_Payment);
            this.Sms_Payable.Controls.Add(this.Label13);
            this.Sms_Payable.Controls.Add(this.Sms_Payable_Payment);
            this.Sms_Payable.Location = new System.Drawing.Point(4, 22);
            this.Sms_Payable.Name = "Sms_Payable";
            this.Sms_Payable.Size = new System.Drawing.Size(820, 258);
            this.Sms_Payable.TabIndex = 10;
            this.Sms_Payable.Text = "چک بانک";
            this.Sms_Payable.UseVisualStyleBackColor = true;
            //
            //Sms_Text_Payable_Payment
            //
            this.Sms_Text_Payable_Payment.Font = new System.Drawing.Font("Tahoma", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Sms_Text_Payable_Payment.Location = new System.Drawing.Point(3, 29);
            this.Sms_Text_Payable_Payment.Name = "Sms_Text_Payable_Payment";
            this.Sms_Text_Payable_Payment.Size = new System.Drawing.Size(747, 22);
            this.Sms_Text_Payable_Payment.TabIndex = 293;
            //
            //Label13
            //
            this.Label13.AutoSize = true;
            this.Label13.Location = new System.Drawing.Point(750, 34);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(62, 13);
            this.Label13.TabIndex = 292;
            this.Label13.Text = "متن پیامک :";
            //
            //Sms_Payable_Payment
            //
            this.Sms_Payable_Payment.AutoSize = true;
            this.Sms_Payable_Payment.Location = new System.Drawing.Point(641, 7);
            this.Sms_Payable_Payment.Name = "Sms_Payable_Payment";
            this.Sms_Payable_Payment.Size = new System.Drawing.Size(174, 17);
            this.Sms_Payable_Payment.TabIndex = 16;
            this.Sms_Payable_Payment.Text = "ارسال پیام کوتاه بعد از صدور چک";
            this.Sms_Payable_Payment.UseVisualStyleBackColor = true;
            //
            //Sms_Collection_Document
            //
            this.Sms_Collection_Document.Controls.Add(this.Sms_Text_Collection_Document_Extradition);
            this.Sms_Collection_Document.Controls.Add(this.Label19);
            this.Sms_Collection_Document.Controls.Add(this.Sms_Collection_Document_Extradition);
            this.Sms_Collection_Document.Controls.Add(this.Sms_Text_Collection_Document_Back);
            this.Sms_Collection_Document.Controls.Add(this.Label18);
            this.Sms_Collection_Document.Controls.Add(this.Sms_Collection_Document_Back);
            this.Sms_Collection_Document.Controls.Add(this.Sms_Text_Collection_Document_Notice);
            this.Sms_Collection_Document.Controls.Add(this.Sms_Text_Collection_Document_Assignment);
            this.Sms_Collection_Document.Controls.Add(this.Sms_Text_Collection_Document_Add);
            this.Sms_Collection_Document.Controls.Add(this.Label15);
            this.Sms_Collection_Document.Controls.Add(this.Label16);
            this.Sms_Collection_Document.Controls.Add(this.Label17);
            this.Sms_Collection_Document.Controls.Add(this.Sms_Collection_Document_Notice);
            this.Sms_Collection_Document.Controls.Add(this.Sms_Collection_Document_Assignment);
            this.Sms_Collection_Document.Controls.Add(this.Sms_Collection_Document_Add);
            this.Sms_Collection_Document.Location = new System.Drawing.Point(4, 22);
            this.Sms_Collection_Document.Name = "Sms_Collection_Document";
            this.Sms_Collection_Document.Size = new System.Drawing.Size(820, 258);
            this.Sms_Collection_Document.TabIndex = 11;
            this.Sms_Collection_Document.Text = "اسناد وصولی";
            this.Sms_Collection_Document.UseVisualStyleBackColor = true;
            //
            //Sms_Text_Collection_Document_Extradition
            //
            this.Sms_Text_Collection_Document_Extradition.Font = new System.Drawing.Font("Tahoma", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Sms_Text_Collection_Document_Extradition.Location = new System.Drawing.Point(6, 223);
            this.Sms_Text_Collection_Document_Extradition.Name = "Sms_Text_Collection_Document_Extradition";
            this.Sms_Text_Collection_Document_Extradition.Size = new System.Drawing.Size(747, 22);
            this.Sms_Text_Collection_Document_Extradition.TabIndex = 312;
            //
            //Label19
            //
            this.Label19.AutoSize = true;
            this.Label19.Location = new System.Drawing.Point(753, 228);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(62, 13);
            this.Label19.TabIndex = 311;
            this.Label19.Text = "متن پیامک :";
            //
            //Sms_Collection_Document_Extradition
            //
            this.Sms_Collection_Document_Extradition.AutoSize = true;
            this.Sms_Collection_Document_Extradition.Location = new System.Drawing.Point(545, 200);
            this.Sms_Collection_Document_Extradition.Name = "Sms_Collection_Document_Extradition";
            this.Sms_Collection_Document_Extradition.Size = new System.Drawing.Size(267, 17);
            this.Sms_Collection_Document_Extradition.TabIndex = 310;
            this.Sms_Collection_Document_Extradition.Text = "ارسال پیام کوتاه بعد از  اعلام استرداد اسناد دریافتنی";
            this.Sms_Collection_Document_Extradition.UseVisualStyleBackColor = true;
            //
            //Sms_Text_Collection_Document_Back
            //
            this.Sms_Text_Collection_Document_Back.Font = new System.Drawing.Font("Tahoma", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Sms_Text_Collection_Document_Back.Location = new System.Drawing.Point(6, 174);
            this.Sms_Text_Collection_Document_Back.Name = "Sms_Text_Collection_Document_Back";
            this.Sms_Text_Collection_Document_Back.Size = new System.Drawing.Size(747, 22);
            this.Sms_Text_Collection_Document_Back.TabIndex = 309;
            //
            //Label18
            //
            this.Label18.AutoSize = true;
            this.Label18.Location = new System.Drawing.Point(753, 179);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(62, 13);
            this.Label18.TabIndex = 308;
            this.Label18.Text = "متن پیامک :";
            //
            //Sms_Collection_Document_Back
            //
            this.Sms_Collection_Document_Back.AutoSize = true;
            this.Sms_Collection_Document_Back.Location = new System.Drawing.Point(541, 153);
            this.Sms_Collection_Document_Back.Name = "Sms_Collection_Document_Back";
            this.Sms_Collection_Document_Back.Size = new System.Drawing.Size(271, 17);
            this.Sms_Collection_Document_Back.TabIndex = 307;
            this.Sms_Collection_Document_Back.Text = "ارسال پیام کوتاه بعد از  اعلام برگشتی اسناد دریافتنی";
            this.Sms_Collection_Document_Back.UseVisualStyleBackColor = true;
            //
            //Sms_Text_Collection_Document_Notice
            //
            this.Sms_Text_Collection_Document_Notice.Font = new System.Drawing.Font("Tahoma", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Sms_Text_Collection_Document_Notice.Location = new System.Drawing.Point(6, 125);
            this.Sms_Text_Collection_Document_Notice.Name = "Sms_Text_Collection_Document_Notice";
            this.Sms_Text_Collection_Document_Notice.Size = new System.Drawing.Size(747, 22);
            this.Sms_Text_Collection_Document_Notice.TabIndex = 306;
            //
            //Sms_Text_Collection_Document_Assignment
            //
            this.Sms_Text_Collection_Document_Assignment.Font = new System.Drawing.Font("Tahoma", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Sms_Text_Collection_Document_Assignment.Location = new System.Drawing.Point(6, 76);
            this.Sms_Text_Collection_Document_Assignment.Name = "Sms_Text_Collection_Document_Assignment";
            this.Sms_Text_Collection_Document_Assignment.Size = new System.Drawing.Size(747, 22);
            this.Sms_Text_Collection_Document_Assignment.TabIndex = 305;
            //
            //Sms_Text_Collection_Document_Add
            //
            this.Sms_Text_Collection_Document_Add.Font = new System.Drawing.Font("Tahoma", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Sms_Text_Collection_Document_Add.Location = new System.Drawing.Point(6, 26);
            this.Sms_Text_Collection_Document_Add.Name = "Sms_Text_Collection_Document_Add";
            this.Sms_Text_Collection_Document_Add.Size = new System.Drawing.Size(747, 22);
            this.Sms_Text_Collection_Document_Add.TabIndex = 304;
            //
            //Label15
            //
            this.Label15.AutoSize = true;
            this.Label15.Location = new System.Drawing.Point(753, 130);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(62, 13);
            this.Label15.TabIndex = 303;
            this.Label15.Text = "متن پیامک :";
            //
            //Label16
            //
            this.Label16.AutoSize = true;
            this.Label16.Location = new System.Drawing.Point(753, 80);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(62, 13);
            this.Label16.TabIndex = 302;
            this.Label16.Text = "متن پیامک :";
            //
            //Label17
            //
            this.Label17.AutoSize = true;
            this.Label17.Location = new System.Drawing.Point(753, 30);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(62, 13);
            this.Label17.TabIndex = 301;
            this.Label17.Text = "متن پیامک :";
            //
            //Sms_Collection_Document_Notice
            //
            this.Sms_Collection_Document_Notice.AutoSize = true;
            this.Sms_Collection_Document_Notice.Location = new System.Drawing.Point(555, 103);
            this.Sms_Collection_Document_Notice.Name = "Sms_Collection_Document_Notice";
            this.Sms_Collection_Document_Notice.Size = new System.Drawing.Size(257, 17);
            this.Sms_Collection_Document_Notice.TabIndex = 300;
            this.Sms_Collection_Document_Notice.Text = "ارسال پیام کوتاه بعد از  اعلام وصول اسناد دریافتنی";
            this.Sms_Collection_Document_Notice.UseVisualStyleBackColor = true;
            //
            //Sms_Collection_Document_Assignment
            //
            this.Sms_Collection_Document_Assignment.AutoSize = true;
            this.Sms_Collection_Document_Assignment.Location = new System.Drawing.Point(573, 53);
            this.Sms_Collection_Document_Assignment.Name = "Sms_Collection_Document_Assignment";
            this.Sms_Collection_Document_Assignment.Size = new System.Drawing.Size(239, 17);
            this.Sms_Collection_Document_Assignment.TabIndex = 299;
            this.Sms_Collection_Document_Assignment.Text = "ارسال پیام کوتاه بعد از واگذاری اسناد دریافتنی ";
            this.Sms_Collection_Document_Assignment.UseVisualStyleBackColor = true;
            //
            //Sms_Collection_Document_Add
            //
            this.Sms_Collection_Document_Add.AutoSize = true;
            this.Sms_Collection_Document_Add.Location = new System.Drawing.Point(595, 5);
            this.Sms_Collection_Document_Add.Name = "Sms_Collection_Document_Add";
            this.Sms_Collection_Document_Add.Size = new System.Drawing.Size(217, 17);
            this.Sms_Collection_Document_Add.TabIndex = 298;
            this.Sms_Collection_Document_Add.Text = "ارسال پیام کوتاه بعد از ثبت اسناد دریافتنی";
            this.Sms_Collection_Document_Add.UseVisualStyleBackColor = true;
            //
            //Sms_Warranty_Document
            //
            this.Sms_Warranty_Document.Controls.Add(this.Sms_Text_Warranty_Document_Refund);
            this.Sms_Warranty_Document.Controls.Add(this.Sms_Text_Warranty_Document_Extended);
            this.Sms_Warranty_Document.Controls.Add(this.Sms_Text_Warranty_Document_Add);
            this.Sms_Warranty_Document.Controls.Add(this.Label9);
            this.Sms_Warranty_Document.Controls.Add(this.Label8);
            this.Sms_Warranty_Document.Controls.Add(this.Label7);
            this.Sms_Warranty_Document.Controls.Add(this.Sms_Warranty_Document_Refund);
            this.Sms_Warranty_Document.Controls.Add(this.Sms_Warranty_Document_Extended);
            this.Sms_Warranty_Document.Controls.Add(this.Sms_Warranty_Document_Add);
            this.Sms_Warranty_Document.Location = new System.Drawing.Point(4, 22);
            this.Sms_Warranty_Document.Name = "Sms_Warranty_Document";
            this.Sms_Warranty_Document.Size = new System.Drawing.Size(820, 258);
            this.Sms_Warranty_Document.TabIndex = 12;
            this.Sms_Warranty_Document.Text = "اسناد ضمانتی";
            this.Sms_Warranty_Document.UseVisualStyleBackColor = true;
            //
            //Sms_Text_Warranty_Document_Refund
            //
            this.Sms_Text_Warranty_Document_Refund.Font = new System.Drawing.Font("Tahoma", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Sms_Text_Warranty_Document_Refund.Location = new System.Drawing.Point(7, 158);
            this.Sms_Text_Warranty_Document_Refund.Name = "Sms_Text_Warranty_Document_Refund";
            this.Sms_Text_Warranty_Document_Refund.Size = new System.Drawing.Size(747, 22);
            this.Sms_Text_Warranty_Document_Refund.TabIndex = 297;
            //
            //Sms_Text_Warranty_Document_Extended
            //
            this.Sms_Text_Warranty_Document_Extended.Font = new System.Drawing.Font("Tahoma", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Sms_Text_Warranty_Document_Extended.Location = new System.Drawing.Point(7, 94);
            this.Sms_Text_Warranty_Document_Extended.Name = "Sms_Text_Warranty_Document_Extended";
            this.Sms_Text_Warranty_Document_Extended.Size = new System.Drawing.Size(747, 22);
            this.Sms_Text_Warranty_Document_Extended.TabIndex = 296;
            //
            //Sms_Text_Warranty_Document_Add
            //
            this.Sms_Text_Warranty_Document_Add.Font = new System.Drawing.Font("Tahoma", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            this.Sms_Text_Warranty_Document_Add.Location = new System.Drawing.Point(7, 34);
            this.Sms_Text_Warranty_Document_Add.Name = "Sms_Text_Warranty_Document_Add";
            this.Sms_Text_Warranty_Document_Add.Size = new System.Drawing.Size(747, 22);
            this.Sms_Text_Warranty_Document_Add.TabIndex = 295;
            //
            //Label9
            //
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(754, 163);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(62, 13);
            this.Label9.TabIndex = 294;
            this.Label9.Text = "متن پیامک :";
            //
            //Label8
            //
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(754, 98);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(62, 13);
            this.Label8.TabIndex = 292;
            this.Label8.Text = "متن پیامک :";
            //
            //Label7
            //
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(754, 38);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(62, 13);
            this.Label7.TabIndex = 290;
            this.Label7.Text = "متن پیامک :";
            //
            //Sms_Warranty_Document_Refund
            //
            this.Sms_Warranty_Document_Refund.AutoSize = true;
            this.Sms_Warranty_Document_Refund.Location = new System.Drawing.Point(578, 136);
            this.Sms_Warranty_Document_Refund.Name = "Sms_Warranty_Document_Refund";
            this.Sms_Warranty_Document_Refund.Size = new System.Drawing.Size(235, 17);
            this.Sms_Warranty_Document_Refund.TabIndex = 16;
            this.Sms_Warranty_Document_Refund.Text = "ارسال پیام کوتاه بعد از استرداد اسناد انتظامی";
            this.Sms_Warranty_Document_Refund.UseVisualStyleBackColor = true;
            //
            //Sms_Warranty_Document_Extended
            //
            this.Sms_Warranty_Document_Extended.AutoSize = true;
            this.Sms_Warranty_Document_Extended.Location = new System.Drawing.Point(588, 71);
            this.Sms_Warranty_Document_Extended.Name = "Sms_Warranty_Document_Extended";
            this.Sms_Warranty_Document_Extended.Size = new System.Drawing.Size(224, 17);
            this.Sms_Warranty_Document_Extended.TabIndex = 15;
            this.Sms_Warranty_Document_Extended.Text = "ارسال پیام کوتاه بعد از تمدید اسناد انتظامی";
            this.Sms_Warranty_Document_Extended.UseVisualStyleBackColor = true;
            //
            //Sms_Warranty_Document_Add
            //
            this.Sms_Warranty_Document_Add.AutoSize = true;
            this.Sms_Warranty_Document_Add.Location = new System.Drawing.Point(596, 11);
            this.Sms_Warranty_Document_Add.Name = "Sms_Warranty_Document_Add";
            this.Sms_Warranty_Document_Add.Size = new System.Drawing.Size(216, 17);
            this.Sms_Warranty_Document_Add.TabIndex = 14;
            this.Sms_Warranty_Document_Add.Text = "ارسال پیام کوتاه بعد از ثبت اسناد انتظامی";
            this.Sms_Warranty_Document_Add.UseVisualStyleBackColor = true;
            //
            //GroupStarterMatn
            //
            this.GroupStarterMatn.Controls.Add(this.View_sms_SetUp);
            this.GroupStarterMatn.Controls.Add(this.Label12);
            this.GroupStarterMatn.Controls.Add(this.Sms_txt_Ulr_Sender);
            this.GroupStarterMatn.Controls.Add(this.Sms_txt_Signature);
            this.GroupStarterMatn.Controls.Add(this.Label32);
            this.GroupStarterMatn.Controls.Add(this.Sms_txt_smsSender);
            this.GroupStarterMatn.Controls.Add(this.Label36);
            this.GroupStarterMatn.Location = new System.Drawing.Point(6, 16);
            this.GroupStarterMatn.Name = "GroupStarterMatn";
            this.GroupStarterMatn.Size = new System.Drawing.Size(834, 118);
            this.GroupStarterMatn.TabIndex = 32;
            this.GroupStarterMatn.TabStop = false;
            this.GroupStarterMatn.Text = "نمایش اطلاعات :";
            //
            //View_sms_SetUp
            //
            this.View_sms_SetUp.AutoSize = true;
            this.View_sms_SetUp.Location = new System.Drawing.Point(732, 0);
            this.View_sms_SetUp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.View_sms_SetUp.Name = "View_sms_SetUp";
            this.View_sms_SetUp.Size = new System.Drawing.Size(15, 14);
            this.View_sms_SetUp.TabIndex = 289;
            this.View_sms_SetUp.UseVisualStyleBackColor = true;
            //
            //Label12
            //
            this.Label12.AutoSize = true;
            this.Label12.Location = new System.Drawing.Point(641, 23);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(176, 13);
            this.Label12.TabIndex = 36;
            this.Label12.Text = "آدرس اینترنتی ســامــانــه پیام کوتاه :";
            //
            //Sms_txt_Ulr_Sender
            //
            this.Sms_txt_Ulr_Sender.Location = new System.Drawing.Point(7, 20);
            this.Sms_txt_Ulr_Sender.Name = "Sms_txt_Ulr_Sender";
            this.Sms_txt_Ulr_Sender.PasswordChar = (char)42;
            this.Sms_txt_Ulr_Sender.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Sms_txt_Ulr_Sender.Size = new System.Drawing.Size(628, 21);
            this.Sms_txt_Ulr_Sender.TabIndex = 37;
            //
            //Sms_txt_Signature
            //
            this.Sms_txt_Signature.Location = new System.Drawing.Point(7, 87);
            this.Sms_txt_Signature.Name = "Sms_txt_Signature";
            this.Sms_txt_Signature.PasswordChar = (char)42;
            this.Sms_txt_Signature.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Sms_txt_Signature.Size = new System.Drawing.Size(628, 21);
            this.Sms_txt_Signature.TabIndex = 35;
            //
            //Label32
            //
            this.Label32.AutoSize = true;
            this.Label32.Location = new System.Drawing.Point(641, 57);
            this.Label32.Name = "Label32";
            this.Label32.Size = new System.Drawing.Size(181, 13);
            this.Label32.TabIndex = 25;
            this.Label32.Text = "شــــمــــاره ارسـال سامانه پیام کوتاه :";
            //
            //Sms_txt_smsSender
            //
            this.Sms_txt_smsSender.Location = new System.Drawing.Point(7, 54);
            this.Sms_txt_smsSender.Name = "Sms_txt_smsSender";
            this.Sms_txt_smsSender.PasswordChar = (char)42;
            this.Sms_txt_smsSender.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Sms_txt_smsSender.Size = new System.Drawing.Size(628, 21);
            this.Sms_txt_smsSender.TabIndex = 34;
            //
            //Label36
            //
            this.Label36.AutoSize = true;
            this.Label36.Location = new System.Drawing.Point(641, 90);
            this.Label36.Name = "Label36";
            this.Label36.Size = new System.Drawing.Size(181, 13);
            this.Label36.TabIndex = 29;
            this.Label36.Text = "کد امضای دیجیتالی سامانه پیام کوتاه :";
            //
            //SAVE_Setting
            //
            this.SAVE_Setting.Location = new System.Drawing.Point(703, 441);
            this.SAVE_Setting.Name = "SAVE_Setting";
            this.SAVE_Setting.Size = new System.Drawing.Size(137, 33);
            this.SAVE_Setting.TabIndex = 1;
            this.SAVE_Setting.Text = "ذخـیـره تـنـظـیـمـات";
            this.SAVE_Setting.UseVisualStyleBackColor = true;
            //
            //LogsBindingSource
            //
            this.LogsBindingSource.DataMember = "Logs";
            //
            //TellBookBindingSource
            //
            this.TellBookBindingSource.DataMember = "TellBook";
            //
            //PishNevisBindingSource
            //
            this.PishNevisBindingSource.DataMember = "PishNevis";
            //
            //PishNevisBindingSource1
            //
            this.PishNevisBindingSource1.DataMember = "PishNevis";
            //
            //ProgsessTimer
            //
            this.ProgsessTimer.Interval = 15;
            //
            //frm_sms
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6.0F, 13.0F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 516);
            this.Controls.Add(this.TabMassage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            this.Name = "frm_sms";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TabMassage.ResumeLayout(false);
            this.sms_1.ResumeLayout(false);
            this.GroupBox6.ResumeLayout(false);
            this.GroupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.DV_Sefid).EndInit();
            this.sms_2.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.Dv_Mobile_Group).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.Dv_Sefid_Group).EndInit();
            this.sms_3.ResumeLayout(false);
            this.GroupBox7.ResumeLayout(false);
            this.GroupBox7.PerformLayout();
            this.sms_4.ResumeLayout(false);
            this.GroupBox13.ResumeLayout(false);
            this.GroupBox12.ResumeLayout(false);
            this.GroupBox12.PerformLayout();
            this.sms_5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.TBG_Logs).EndInit();
            this.GroupBox11.ResumeLayout(false);
            this.GroupBox10.ResumeLayout(false);
            this.GroupBox10.PerformLayout();
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            this.sms_6.ResumeLayout(false);
            this.SettingGroupBox.ResumeLayout(false);
            this.GroupBox3.ResumeLayout(false);
            this.Tab_Warranty_Document.ResumeLayout(false);
            this.Sms_PayRoll.ResumeLayout(false);
            this.GroupBox16.ResumeLayout(false);
            this.GroupBox17.ResumeLayout(false);
            this.GroupBox17.PerformLayout();
            this.Sms_Payable.ResumeLayout(false);
            this.Sms_Payable.PerformLayout();
            this.Sms_Collection_Document.ResumeLayout(false);
            this.Sms_Collection_Document.PerformLayout();
            this.Sms_Warranty_Document.ResumeLayout(false);
            this.Sms_Warranty_Document.PerformLayout();
            this.GroupStarterMatn.ResumeLayout(false);
            this.GroupStarterMatn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.LogsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.TellBookBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.PishNevisBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.PishNevisBindingSource1).EndInit();
            this.ResumeLayout(false);

        }
        internal System.Windows.Forms.TabControl TabMassage;
        internal System.Windows.Forms.TabPage sms_3;
        internal System.Windows.Forms.TabPage sms_1;
        internal System.Windows.Forms.TabPage sms_4;
        internal System.Windows.Forms.GroupBox GroupBox7;
        internal System.Windows.Forms.Label lblMsgCount;
        internal System.Windows.Forms.Button cmdMsgDelete;
        internal System.Windows.Forms.Button cmdInboxRefresh;
        internal System.Windows.Forms.Label Label29;
        internal System.Windows.Forms.TextBox txtInterval;
        internal System.Windows.Forms.CheckBox chkInboxRefresh;
        internal System.Windows.Forms.CheckBox chkInConcatenate;
        internal System.Windows.Forms.ComboBox cboMsgMemory;
        internal System.Windows.Forms.Label Label28;
        internal System.Windows.Forms.ListView lstInbox;
        internal System.Windows.Forms.ColumnHeader clmFrom;
        internal System.Windows.Forms.ColumnHeader clmMessage;
        internal System.Windows.Forms.ColumnHeader clmTime;
        internal System.Windows.Forms.GroupBox GroupBox6;
        internal System.Windows.Forms.Button cmdSendMsg;
        internal System.Windows.Forms.Label Label24;
        internal System.Windows.Forms.TextBox txt_Message;
        internal System.Windows.Forms.TextBox txt_mobile;
        internal System.Windows.Forms.Label Label23;
        internal System.Windows.Forms.DataGridViewTextBoxColumn NameDataGridViewTextBoxColumn;
        internal System.Windows.Forms.DataGridViewTextBoxColumn FamilyDataGridViewTextBoxColumn;
        internal System.Windows.Forms.DataGridViewTextBoxColumn MobDataGridViewTextBoxColumn;
        internal System.Windows.Forms.DataGridViewTextBoxColumn ViewDataGridViewTextBoxColumn;
        internal System.Windows.Forms.TabPage sms_6;
        internal System.Windows.Forms.GroupBox SettingGroupBox;
        internal System.Windows.Forms.Button SAVE_Setting;
        internal System.Windows.Forms.TabPage sms_2;
        internal System.Windows.Forms.Timer ProgsessTimer;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button B_Send_Sms_Sefid_Group;
        internal System.Windows.Forms.BindingSource TellBookBindingSource;
        internal System.Windows.Forms.DataGridViewTextBoxColumn IDDataGridViewTextBoxColumn;
        internal System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
        internal System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn2;
        internal System.Windows.Forms.DataGridViewTextBoxColumn ShenasDataGridViewTextBoxColumn;
        internal System.Windows.Forms.DataGridViewTextBoxColumn MellicartDataGridViewTextBoxColumn;
        internal System.Windows.Forms.DataGridViewTextBoxColumn ShoghlDataGridViewTextBoxColumn;
        internal System.Windows.Forms.DataGridViewTextBoxColumn VaziyatDataGridViewTextBoxColumn;
        internal System.Windows.Forms.DataGridViewTextBoxColumn FarzandDataGridViewTextBoxColumn;
        internal System.Windows.Forms.DataGridViewTextBoxColumn MadrakDataGridViewTextBoxColumn;
        internal System.Windows.Forms.DataGridViewTextBoxColumn BdateDataGridViewTextBoxColumn;
        internal System.Windows.Forms.DataGridViewTextBoxColumn SanavatDataGridViewTextBoxColumn;
        internal System.Windows.Forms.DataGridViewTextBoxColumn PersoneliDataGridViewTextBoxColumn;
        internal System.Windows.Forms.DataGridViewTextBoxColumn ShhesabDataGridViewTextBoxColumn;
        internal System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn3;
        internal System.Windows.Forms.DataGridViewTextBoxColumn HomeDataGridViewTextBoxColumn;
        internal System.Windows.Forms.DataGridViewTextBoxColumn AddressDataGridViewTextBoxColumn;
        internal System.Windows.Forms.DataGridViewTextBoxColumn GroupDataGridViewTextBoxColumn;
        internal System.Windows.Forms.Label Label32;
        internal System.Windows.Forms.Label Label36;
        internal System.Windows.Forms.GroupBox GroupStarterMatn;
        internal System.Windows.Forms.TextBox Sms_txt_Signature;
        internal System.Windows.Forms.TextBox Sms_txt_smsSender;
        internal System.Windows.Forms.TabPage sms_5;
        internal System.Windows.Forms.GroupBox GroupBox10;
        internal System.Windows.Forms.BindingSource LogsBindingSource;
        internal System.Windows.Forms.DataGridViewTextBoxColumn IDDataGridViewTextBoxColumn1;
        internal System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn4;
        internal System.Windows.Forms.DataGridViewTextBoxColumn TXTDataGridViewTextBoxColumn;
        internal System.Windows.Forms.DataGridViewTextBoxColumn DatesDataGridViewTextBoxColumn;
        internal System.Windows.Forms.DataGridViewTextBoxColumn VaziyatDataGridViewTextBoxColumn1;
        internal System.Windows.Forms.DataGridViewTextBoxColumn BakhshDataGridViewTextBoxColumn;
        internal System.Windows.Forms.Label Label39;
        internal System.Windows.Forms.Button Reply_Send_SMS;
        internal System.Windows.Forms.Button Delete_All_Logs;
        internal System.Windows.Forms.Button Reply_Send_SMS_4ALL;
        internal System.Windows.Forms.GroupBox GroupBox11;
        internal System.Windows.Forms.GroupBox GroupBox12;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.TextBox TextBox2;
        internal System.Windows.Forms.Label Label40;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.TextBox TextBox6;
        internal System.Windows.Forms.Label Label44;
        internal System.Windows.Forms.TextBox TextBox5;
        internal System.Windows.Forms.Label Label43;
        internal System.Windows.Forms.TextBox TextBox4;
        internal System.Windows.Forms.Label Label42;
        internal System.Windows.Forms.TextBox TextBox3;
        internal System.Windows.Forms.Label Label41;
        internal System.Windows.Forms.GroupBox GroupBox13;
        internal System.Windows.Forms.ListView ListView1;
        internal System.Windows.Forms.ColumnHeader ColumnHeader1;
        internal System.Windows.Forms.ColumnHeader ColumnHeader2;
        internal System.Windows.Forms.ColumnHeader ColumnHeader3;
        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.Button Button4;
        internal System.Windows.Forms.BindingSource PishNevisBindingSource;
        internal System.Windows.Forms.BindingSource PishNevisBindingSource1;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.TextBox Sms_txt_Ulr_Sender;
        internal System.Windows.Forms.CheckBox View_sms_SetUp;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.TabControl Tab_Warranty_Document;
        internal System.Windows.Forms.TabPage Sms_Services;
        internal System.Windows.Forms.TabPage Sms_Accounting;
        internal System.Windows.Forms.TabPage Sms_Repair;
        internal System.Windows.Forms.TabPage Sms_PayRoll;
        internal System.Windows.Forms.GroupBox GroupBox16;
        internal System.Windows.Forms.CheckedListBox CheckedListBox2;
        internal System.Windows.Forms.CheckedListBox CheckedListBox3;
        internal System.Windows.Forms.Button Button15;
        internal System.Windows.Forms.Button Button16;
        internal System.Windows.Forms.GroupBox GroupBox17;
        internal System.Windows.Forms.Label Label26;
        internal System.Windows.Forms.TextBox TextBox18;
        internal System.Windows.Forms.Button Button17;
        internal System.Windows.Forms.TabPage Sms_Warehouse;
        internal System.Windows.Forms.TabPage Sms_Assets;
        internal System.Windows.Forms.TabPage Sms_Payable;
        internal System.Windows.Forms.TabPage Sms_Collection_Document;
        internal System.Windows.Forms.TabPage Sms_Warranty_Document;
        internal System.Windows.Forms.CheckBox Sms_Warranty_Document_Add;
        internal System.Windows.Forms.CheckBox Sms_Warranty_Document_Refund;
        internal System.Windows.Forms.CheckBox Sms_Warranty_Document_Extended;
        internal System.Windows.Forms.DataGridView TBG_Logs;
        internal System.Windows.Forms.ComboBox Estate_Plaque;
        internal System.Windows.Forms.TextBox MemberTXT;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.GroupBox GroupBox4;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal Ansaripour.Rtl_Date Warranty_Document_From_Date;
        internal Ansaripour.Rtl_Date Warranty_Document_Until_Date;
        internal System.Windows.Forms.CheckBox Sms_Payable_Payment;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.TextBox Sms_Text_Payable_Payment;
        internal System.Windows.Forms.TextBox Sms_Text_Warranty_Document_Refund;
        internal System.Windows.Forms.TextBox Sms_Text_Warranty_Document_Extended;
        internal System.Windows.Forms.TextBox Sms_Text_Warranty_Document_Add;
        internal System.Windows.Forms.TextBox Sms_Text_Collection_Document_Notice;
        internal System.Windows.Forms.TextBox Sms_Text_Collection_Document_Assignment;
        internal System.Windows.Forms.TextBox Sms_Text_Collection_Document_Add;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.Label Label17;
        internal System.Windows.Forms.CheckBox Sms_Collection_Document_Notice;
        internal System.Windows.Forms.CheckBox Sms_Collection_Document_Assignment;
        internal System.Windows.Forms.CheckBox Sms_Collection_Document_Add;
        internal System.Windows.Forms.TextBox Sms_Text_Collection_Document_Back;
        internal System.Windows.Forms.Label Label18;
        internal System.Windows.Forms.CheckBox Sms_Collection_Document_Back;
        internal System.Windows.Forms.TextBox Sms_Text_Collection_Document_Extradition;
        internal System.Windows.Forms.Label Label19;
        internal System.Windows.Forms.CheckBox Sms_Collection_Document_Extradition;
        internal System.Windows.Forms.Button B_Txt_mobile;
        internal System.Windows.Forms.Label Label_Sms;
        internal System.Windows.Forms.Button B_Sefid_Save;
        internal System.Windows.Forms.DataGridView DV_Sefid;
        internal System.Windows.Forms.TextBox Sms_txt_Sefid;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.CheckBox CheckBox_Sefid;
        internal System.Windows.Forms.Button B_Sefid_Delete;
        internal System.Windows.Forms.Button B_Sefid_Add;
        internal System.Windows.Forms.Button B_Sefid_Abort;
        internal System.Windows.Forms.TextBox Sms_Sefid_5;
        internal System.Windows.Forms.Label Label20;
        internal System.Windows.Forms.TextBox Sms_Sefid_4;
        internal System.Windows.Forms.Label Label21;
        internal System.Windows.Forms.TextBox Sms_Sefid_3;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox Sms_Sefid_2;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.DataGridView Dv_Mobile_Group;
        internal System.Windows.Forms.TextBox TextBox_5_Sefid_Group;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.TextBox TextBox_4_Sefid_Group;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.TextBox TextBox_3_Sefid_Group;
        internal System.Windows.Forms.Label Label22;
        internal System.Windows.Forms.TextBox TextBox_2_Sefid_Group;
        internal System.Windows.Forms.Label Label25;
        internal System.Windows.Forms.DataGridView Dv_Sefid_Group;
        internal System.Windows.Forms.TextBox TextBox_Sefid_Group;
        internal System.Windows.Forms.Label Label27;
        internal System.Windows.Forms.CheckBox CheckBox_Sefid_Group;
        internal System.Windows.Forms.Label Label31;
        internal System.Windows.Forms.TextBox Sms_Sefid_Group;
        internal System.Windows.Forms.Button Button_Group;
        internal System.Windows.Forms.TextBox TextBox_Group;
        internal System.Windows.Forms.Label Label33;
    }
}