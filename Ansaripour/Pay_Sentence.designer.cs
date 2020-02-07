using System.Drawing.Imaging;

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
	public partial class Pay_Sentence : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pay_Sentence));
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
			this.B_New = new System.Windows.Forms.ToolStripButton();
			this.B_Edit = new System.Windows.Forms.ToolStripButton();
			this.B_Delet = new System.Windows.Forms.ToolStripButton();
			this.B_Save = new System.Windows.Forms.ToolStripButton();
			this.B_Search = new System.Windows.Forms.ToolStripButton();
			this.B_Excel = new System.Windows.Forms.ToolStripButton();
			this.B_Picture = new System.Windows.Forms.ToolStripButton();
			this.B_Print = new System.Windows.Forms.ToolStripButton();
			this.B_Abort = new System.Windows.Forms.ToolStripButton();
			this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
			this.TabControl1 = new System.Windows.Forms.TabControl();
			this.TabPage2 = new System.Windows.Forms.TabPage();
			this.B_Pay_Personal = new System.Windows.Forms.Button();
			this.Num_Pay_Sentence = new System.Windows.Forms.TextBox();
			this.Pay_Personal_Detailed = new System.Windows.Forms.TextBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.GroupBox6 = new System.Windows.Forms.GroupBox();
			this.Label41 = new System.Windows.Forms.Label();
			this.Label40 = new System.Windows.Forms.Label();
			this.Date_Of_Pay_Sentence = new Ansaripour.Rtl_Date();
			this.Date_Until_Pay_Sentence = new Ansaripour.Rtl_Date();
			this.Label39 = new System.Windows.Forms.Label();
			this.Active_Pay_Sentence = new System.Windows.Forms.ComboBox();
			this.Label37 = new System.Windows.Forms.Label();
			this.GroupBox5 = new System.Windows.Forms.GroupBox();
			this.Turn_4_Pay_Sentence = new System.Windows.Forms.RadioButton();
			this.Turn_3_Pay_Sentence = new System.Windows.Forms.RadioButton();
			this.Turn_2_Pay_Sentence = new System.Windows.Forms.RadioButton();
			this.Turn_1_Pay_Sentence = new System.Windows.Forms.RadioButton();
			this.Label36 = new System.Windows.Forms.Label();
			this.Label38 = new System.Windows.Forms.Label();
			this.Time_Until_Pay_Sentence = new Ansaripour.Rtl_Time();
			this.Time_Of_Pay_Sentence = new Ansaripour.Rtl_Time();
			this.GroupBox3 = new System.Windows.Forms.GroupBox();
			this.Address_Pay_Sentence = new System.Windows.Forms.TextBox();
			this.B_City_Pay_Sentence = new System.Windows.Forms.Button();
			this.City_Pay_Sentence = new System.Windows.Forms.TextBox();
			this.B_Organization_Pay_Sentence = new System.Windows.Forms.Button();
			this.Organization_Pay_Sentence = new System.Windows.Forms.TextBox();
			this.Label24 = new System.Windows.Forms.Label();
			this.Label25 = new System.Windows.Forms.Label();
			this.Label26 = new System.Windows.Forms.Label();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.Group_Pay_Sentence = new System.Windows.Forms.TextBox();
			this.Cod_Job_Pay_Sentence = new System.Windows.Forms.TextBox();
			this.Job_Pay_Sentence = new System.Windows.Forms.TextBox();
			this.Label20 = new System.Windows.Forms.Label();
			this.Label19 = new System.Windows.Forms.Label();
			this.Label18 = new System.Windows.Forms.Label();
			this.Date_Pay_Sentence = new Ansaripour.Rtl_Date();
			this.TabPage3 = new System.Windows.Forms.TabPage();
			this.GroupBox4 = new System.Windows.Forms.GroupBox();
			this.Others_2_Pay_Sentence = new System.Windows.Forms.MaskedTextBox();
			this.Label33 = new System.Windows.Forms.Label();
			this.Others_1_Pay_Sentence = new System.Windows.Forms.MaskedTextBox();
			this.Label30 = new System.Windows.Forms.Label();
			this.Transportation_Pay_Sentence = new System.Windows.Forms.MaskedTextBox();
			this.Label31 = new System.Windows.Forms.Label();
			this.Housing_Pay_Sentence = new System.Windows.Forms.MaskedTextBox();
			this.Label32 = new System.Windows.Forms.Label();
			this.Children_Pay_Sentence = new System.Windows.Forms.MaskedTextBox();
			this.Label34 = new System.Windows.Forms.Label();
			this.laborer_Pay_Sentence = new System.Windows.Forms.MaskedTextBox();
			this.Label35 = new System.Windows.Forms.Label();
			this.GroupBox2 = new System.Windows.Forms.GroupBox();
			this.Base_Pay_Sentence = new System.Windows.Forms.TextBox();
			this.Amazing_Pay_Sentence = new System.Windows.Forms.MaskedTextBox();
			this.Label29 = new System.Windows.Forms.Label();
			this.Guardianship_Pay_Sentence = new System.Windows.Forms.MaskedTextBox();
			this.Label28 = new System.Windows.Forms.Label();
			this.Years_Pay_Sentence = new System.Windows.Forms.MaskedTextBox();
			this.Label27 = new System.Windows.Forms.Label();
			this.Difficulty_Pay_Sentence = new System.Windows.Forms.MaskedTextBox();
			this.Label21 = new System.Windows.Forms.Label();
			this.Attraction_Pay_Sentence = new System.Windows.Forms.MaskedTextBox();

//====================================================================================================
//End of the allowed output for the Free Edition of Instant C#.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-instant-csharp.html
//====================================================================================================
