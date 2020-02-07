using System.IO.Directory;

//====================================================================================================
//The Free Edition of Instant C# limits conversion output to 100 lines per file.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-instant-csharp.html
//====================================================================================================

//INSTANT C# NOTE: Formerly VB project-level imports:
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

//====================================================================================================
//End of the allowed output for the Free Edition of Instant C#.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-instant-csharp.html
//====================================================================================================
