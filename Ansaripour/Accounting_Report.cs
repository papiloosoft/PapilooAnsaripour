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
	public partial class Accounting_Report
	{
		public Accounting_Report()
		{
			InitializeComponent();
		}

		private string f_serch; //تابع متغیر فرمول جستجو
		private string f_Select; //تابع متغیر فرمول جستجو
		private int err;
		public string Reports;
		private string Acc_Area;
		private string Acc_Id_From;
		private string Acc_Code_From;
		private string Acc_Name_From;
		private string Acc_Id_Until;
		private string Acc_Code_Until;
		private string Acc_Name_Until;
		private string Acc_Id_Detailed_One_From;
		private string Acc_Code_Detailed_One_From;
		private string Acc_Name_Detailed_One_From;
		private string Acc_Id_Detailed_One_Until;
		private string Acc_Code_Detailed_One_Until;
		private string Acc_Name_Detailed_One_Until;
		private string Acc_Id_Detailed_Two_From;
		private string Acc_Code_Detailed_Two_From;
		private string Acc_Name_Detailed_Two_From;
		private string Acc_Id_Detailed_Two_Until;
		private string Acc_Code_Detailed_Two_Until;
		private string Acc_Name_Detailed_Two_Until;
		private string Acc_Id_Detailed_Three_From;
		private string Acc_Code_Detailed_Three_From;
		private string Acc_Name_Detailed_Three_From;
		private string Acc_Id_Detailed_Three_Until;
		private string Acc_Code_Detailed_Three_Until;
		private string Acc_Name_Detailed_Three_Until;
		private string Acc_Id_Detailed_Four_From;
		private string Acc_Code_Detailed_Four_From;
		private string Acc_Name_Detailed_Four_From;
		private string Acc_Id_Detailed_Four_Until;
		private string Acc_Code_Detailed_Four_Until;
		private string Acc_Name_Detailed_Four_Until;
		private string Acc_Id_Detailed_Five_From;
		private string Acc_Code_Detailed_Five_From;
		private string Acc_Name_Detailed_Five_From;
		private string Acc_Id_Detailed_Five_Until;
		private string Acc_Code_Detailed_Five_Until;
		private string Acc_Name_Detailed_Five_Until;
		private Resizer rs = new Resizer();
		private void Accounting_Report_Load(object sender, System.EventArgs e)
		{
			rs.FindAllControls(this);
			Accounting_Header_Class_0.Checked = true;
			Accounting_Header_Class_1.Checked = false;
			Accounting_Header_Class_2.Checked = true;
			Accounting_Header_Class_3.Checked = true;
			Accounting_Header_Class_4.Checked = true;
			Accounting_Header_Class_5.Checked = true;
			if (MDIParent1.DefaultInstance.N_Admin.Text == "False")
			{
				Accounting_Area_All.Checked = false;
				Accounting_Area_All.Enabled = false;
				Accounting_Area_one.Checked = true;
			}
		}
		private void Error_Get()
		{
			//بررسی محدودیت ها
			err = 0;
			if (Accounting_Details_Acc_Main_From.Text.Length != 0)
			{
				DataSet Acc = data.PDataset("select * from Accounting_Account where Acc_class='Accounting_Account' And Acc_Group=1 And Acc_Code='" + Accounting_Details_Acc_Main_From.Text + "'");
				if (!(Acc.Tables[0].Rows.Count == 0))
				{
					foreach (DataRow Dr in Acc.Tables[0].Rows)
					{
						if (string.IsNullOrEmpty(Convert.ToString(Dr["Acc_Id"])) == false)
						{
							Acc_Code_From = Convert.ToString(Dr["Acc_Code"]);
							Acc_Name_From = Convert.ToString(Dr["Acc_Name"]);
							Acc_Id_From = Convert.ToString(Dr["Acc_Id"]);
							Accounting_Details_Acc_Main_From.Text = Convert.ToString(Dr["Acc_Code"]);
							L_Accounting_Details_Acc_Main_From.Text = Convert.ToString(Dr["Acc_Name"]);
						}
					}
				}
				else
				{
					err = 1;
				}
			}
			else
			{
				L_Accounting_Details_Acc_Main_From.Text = "";
			}
			if (Accounting_Details_Acc_Main_Until.Text.Length != 0)
			{
				DataSet Acc = data.PDataset("select * from Accounting_Account where Acc_class='Accounting_Account' And Acc_Group=1 And Acc_Code='" + Accounting_Details_Acc_Main_Until.Text + "'");
				if (!(Acc.Tables[0].Rows.Count == 0))
				{
					foreach (DataRow Dr in Acc.Tables[0].Rows)
					{
						if (string.IsNullOrEmpty(Convert.ToString(Dr["Acc_Id"])) == false)
						{
							Acc_Code_Until = Convert.ToString(Dr["Acc_Code"]);
							Acc_Name_Until = Convert.ToString(Dr["Acc_Name"]);
							Acc_Id_Until = Convert.ToString(Dr["Acc_Id"]);
							Accounting_Details_Acc_Main_Until.Text = Convert.ToString(Dr["Acc_Code"]);
							L_Accounting_Details_Acc_Main_Until.Text = Convert.ToString(Dr["Acc_Name"]);
						}
					}
				}
				else
				{
					err = 2;
				}
			}
			else
			{
				L_Accounting_Details_Acc_Main_Until.Text = "";
			}
			if (Accounting_Details_Detailed_One_Main_From.Text.Length != 0)
			{
				DataSet Acc = data.PDataset("select * from Accounting_Account where Acc_class='Accounting_Detailed' And Acc_Group=1 And Acc_Code='" + Accounting_Details_Detailed_One_Main_From.Text + "'");

//====================================================================================================
//End of the allowed output for the Free Edition of Instant C#.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-instant-csharp.html
//====================================================================================================
