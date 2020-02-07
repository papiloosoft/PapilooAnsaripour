using Microsoft.Office.Interop;

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
			this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.New_B, this.Edit_B, this.Delet_B, this.Save_B, this.Picture_B, this.Search_B, this.Excel_B, this.Print_B, this.Abort_B});

//====================================================================================================
//End of the allowed output for the Free Edition of Instant C#.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-instant-csharp.html
//====================================================================================================
