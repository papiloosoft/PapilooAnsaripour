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
	public partial class Accounting_Relation
	{
		public Accounting_Relation()
		{
			InitializeComponent();
		}

		private bool test;
		private string f_serch; //تابع متغیر فرمول جستجو
		private string maText;
		private string Var_Data;
		public void ConfigForm(string ATitle, string AText, string BText)
		{
			this.Text = ATitle;
			maText = AText;
			Var_Data = BText;
		}
		private void GridView_Load()
		{
			Dv1.Rows.Clear();
			Dv1.Columns.Clear();
			Dv1.Controls.Clear();
			Dv1.Columns.Add("row", "رديف");
			Dv1.Columns.Add("Acc_Code", "کد تفصیلی");
			Dv1.Columns.Add("Acc_Name", "شرح تفصیلی");
			Dv1.Columns.Add("Relation_Id", "");
			Dv1.Columns.Add("Relation_Account", "");
			Dv1.Columns.Add("Relation_Detailed", "");
			Dv1.Columns.Add("Relation_Num_Detailed", "");
			Dv1.Columns["Relation_Id"].Visible = false;
			Dv1.Columns["Relation_Account"].Visible = false;
			Dv1.Columns["Relation_Detailed"].Visible = false;
			Dv1.Columns["Relation_Num_Detailed"].Visible = false;
			Dv1.Columns["row"].Width = 80;
			Dv1.Columns["Acc_Code"].Width = 100;
			Dv1.Columns["Acc_Name"].Width = 300;
			Dv1.AllowUserToAddRows = false;
			Dv1.EditMode = DataGridViewEditMode.EditProgrammatically;
			Dv2.Rows.Clear();
			Dv2.Columns.Clear();
			Dv2.Controls.Clear();
			Dv2.Columns.Add("row", "رديف");
			Dv2.Columns.Add("Acc_Code", "کد تفصیلی");
			Dv2.Columns.Add("Acc_Name", "شرح تفصیلی");
			Dv2.Columns.Add("Relation_Id", "");
			Dv2.Columns.Add("Relation_Account", "");
			Dv2.Columns.Add("Relation_Detailed", "");
			Dv2.Columns.Add("Relation_Num_Detailed", "");
			Dv2.Columns["Relation_Id"].Visible = false;
			Dv2.Columns["Relation_Account"].Visible = false;
			Dv2.Columns["Relation_Detailed"].Visible = false;
			Dv2.Columns["Relation_Num_Detailed"].Visible = false;
			Dv2.Columns["row"].Width = 80;
			Dv2.Columns["Acc_Code"].Width = 100;
			Dv2.Columns["Acc_Name"].Width = 300;
			Dv2.AllowUserToAddRows = false;
			Dv2.EditMode = DataGridViewEditMode.EditProgrammatically;
			Dv3.Rows.Clear();
			Dv3.Columns.Clear();
			Dv3.Controls.Clear();
			Dv3.Columns.Add("row", "رديف");
			Dv3.Columns.Add("Acc_Code", "کد تفصیلی");
			Dv3.Columns.Add("Acc_Name", "شرح تفصیلی");
			Dv3.Columns.Add("Relation_Id", "");
			Dv3.Columns.Add("Relation_Account", "");
			Dv3.Columns.Add("Relation_Detailed", "");
			Dv3.Columns.Add("Relation_Num_Detailed", "");
			Dv3.Columns["Relation_Id"].Visible = false;
			Dv3.Columns["Relation_Account"].Visible = false;
			Dv3.Columns["Relation_Detailed"].Visible = false;
			Dv3.Columns["Relation_Num_Detailed"].Visible = false;
			Dv3.Columns["row"].Width = 80;
			Dv3.Columns["Acc_Code"].Width = 100;
			Dv3.Columns["Acc_Name"].Width = 300;
			Dv3.AllowUserToAddRows = false;
			Dv3.EditMode = DataGridViewEditMode.EditProgrammatically;
			Dv4.Rows.Clear();
			Dv4.Columns.Clear();
			Dv4.Controls.Clear();
			Dv4.Columns.Add("row", "رديف");
			Dv4.Columns.Add("Acc_Code", "کد تفصیلی");
			Dv4.Columns.Add("Acc_Name", "شرح تفصیلی");
			Dv4.Columns.Add("Relation_Id", "");
			Dv4.Columns.Add("Relation_Account", "");
			Dv4.Columns.Add("Relation_Detailed", "");
			Dv4.Columns.Add("Relation_Num_Detailed", "");
			Dv4.Columns["Relation_Id"].Visible = false;
			Dv4.Columns["Relation_Account"].Visible = false;
			Dv4.Columns["Relation_Detailed"].Visible = false;
			Dv4.Columns["Relation_Num_Detailed"].Visible = false;
			Dv4.Columns["row"].Width = 80;
			Dv4.Columns["Acc_Code"].Width = 100;
			Dv4.Columns["Acc_Name"].Width = 300;
			Dv4.AllowUserToAddRows = false;
			Dv4.EditMode = DataGridViewEditMode.EditProgrammatically;
			Dv5.Rows.Clear();

//====================================================================================================
//End of the allowed output for the Free Edition of Instant C#.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-instant-csharp.html
//====================================================================================================
