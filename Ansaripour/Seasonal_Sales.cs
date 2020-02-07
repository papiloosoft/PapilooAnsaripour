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
using System.Linq;
using System.Xml.Linq;

using static System.IO.Directory;
using System.Windows.Forms;
using Microsoft.Office.Interop;

namespace Ansaripour
{
	public partial class Seasonal_Sales
	{
		public Seasonal_Sales()
		{
			InitializeComponent();
		}

		private string Id_Subscription;
		private string Seasonal_Id;
		private string Seasonal_Product_Type_Id;
		public string Var_Clas;
		private bool Add; //جداسازی ذخیره جدید و ویرایش
		private int T_id; //پیش فرض شماره ثبت
		private string f_serch; //تابع متغیر فرمول جستجو
		private string f_Select; //تابع متغیر فرمول جستجو
		private string R_C;
		private string ch;
		private string log;
		private string Log_Details;
		private Resizer rs = new Resizer();
		private void Seasonal_Sales_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				SendKeys.Send("{TAB}");
			}
		}
		//--------------------------------
		private void Seasonal_Sales_Load(object sender, System.EventArgs e)
		{
			rs.FindAllControls(this);
			Seasonal_Year.Text = MDIParent1.DefaultInstance.N_Fiscal_Year_Area.Text;
		}
		private void Seasonal_Gross_Price_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back))
			{
				e.Handled = false;
			}
			else
			{
				e.Handled = true;
			}
		}
		private void Seasonal_Gross_Price_Leave(object sender, System.EventArgs e)
		{
			Seasonal_Pure_Price.Text = (Convert.ToInt64(Seasonal_Gross_Price.Text.Replace(",", "")) - Convert.ToInt64(Seasonal_Discount_Price.Text.Replace(",", ""))).ToString();
		}
		private void Seasonal_Gross_Price_TextChanged(dynamic sender, System.EventArgs e)
		{
			sender.Text = NumericHelper.Val(sender.Text.Trim().Replace(",", "")).ToString("#,0"); //& aa
			sender.SelectionStart = sender.TextLength;
			double _Value = Convert.ToInt64(sender.Text.Replace(",", ""));
		}
		private void reset()
		{
			Add = false;
			DV.Rows.Clear();
			DV.Columns.Clear();
			B_Save.Enabled = false;
			Seasonal_Date.T_D = "";
			Seasonal_Subscription.Text = "";
			B_Seasonal_Company.Enabled = true;
			Id_Subscription = "";
			Seasonal_Operation.SelectedIndex = -1;
			Seasonal_Year.Text = MDIParent1.DefaultInstance.N_Fiscal_Year_Area.Text;
			Seasonal_Subscription.Text = "";
			Seasonal_Product_Type.SelectedIndex = -1;
			Seasonal_Product_Name.Text = "";
			Seasonal_Product_Id.Text = "";
			Seasonal_Documents_Number.Text = "";
			Seasonal_Documents_Date.T_D = "";
			Seasonal_Bill_Number.Text = "";
			Seasonal_Bill_Date.T_D = "";
			Seasonal_Gross_Price.Text = "";
			Seasonal_Discount_Price.Text = "";
			Seasonal_Pure_Price.Text = "";
			Seasonal_Valu_Price_check.Checked = false;
			Seasonal_Valu_Price.Text = "";
			Seasonal_Complications_Price.Text = "";
			Seasonal_Complications.Text = "";
			Seasonal_Description.Text = "";
		}
		//----------------------------------------------------------------
		private void Log_Details_Get()
		{
			Log_Details = "";
			if (DV.SelectedCells.Count > 0)
			{
				Log_Details += DV.CurrentRow.Cells["Seasonal_Id"].Value.ToString() + "-";
				Log_Details += DV.CurrentRow.Cells["Seasonal_Date"].Value.ToString() + "-" + DV.CurrentRow.Cells["Seasonal_Year"].Value.ToString() + "-";
				Log_Details += DV.CurrentRow.Cells["Seasonal_Operation"].Value.ToString() + "-" + DV.CurrentRow.Cells["Seasonal_Subscription"].Value.ToString() + "-";
				Log_Details += DV.CurrentRow.Cells["Id_Subscription"].Value.ToString() + "-" + DV.CurrentRow.Cells["Seasonal_Product_Type"].Value.ToString();
				Log_Details += DV.CurrentRow.Cells["Seasonal_Product_Name"].Value.ToString() + "-" + DV.CurrentRow.Cells["Seasonal_Product_Id"].Value.ToString() + "-";
				Log_Details += DV.CurrentRow.Cells["Seasonal_Documents_Number"].Value.ToString() + "-" + DV.CurrentRow.Cells["Seasonal_Documents_Date"].Value.ToString() + "-";
				Log_Details += DV.CurrentRow.Cells["Seasonal_Bill_Number"].Value.ToString() + "-" + DV.CurrentRow.Cells["Seasonal_Bill_Date"].Value.ToString() + "-";
				Log_Details += DV.CurrentRow.Cells["Seasonal_Gross_Price"].Value.ToString() + "-" + DV.CurrentRow.Cells["Seasonal_Discount_Price"].Value.ToString() + "-";
				Log_Details += DV.CurrentRow.Cells["Seasonal_Pure_Price"].Value.ToString() + "-" + DV.CurrentRow.Cells["Seasonal_Valu_Price"].Value.ToString() + "-";
				Log_Details += DV.CurrentRow.Cells["Seasonal_Complications_Price"].Value.ToString() + "-" + DV.CurrentRow.Cells["Seasonal_Complications"].Value.ToString() + "-";
				Log_Details += DV.CurrentRow.Cells["Seasonal_Description"].Value.ToString() + "-" + DV.CurrentRow.Cells["Seasonal_Area"].Value.ToString();
			}
			else
			{
				Log_Details += Seasonal_Date.T_D + "-" + Seasonal_Year.Text + "-";
				Log_Details += Seasonal_Operation.Text + "-" + Seasonal_Subscription.Text + "-";
				Log_Details += Id_Subscription + "-" + Seasonal_Product_Type.Text + "-";
				Log_Details += Seasonal_Product_Name.Text + "-" + Seasonal_Product_Id.Text + "-";
				Log_Details += Seasonal_Documents_Number.Text + "-" + Seasonal_Documents_Date.T_D + "-";
				Log_Details += Seasonal_Bill_Number.Text + "-" + Seasonal_Bill_Date.T_D + "-";
				Log_Details += Seasonal_Gross_Price.Text + "-" + Seasonal_Discount_Price.Text + "-";
				Log_Details += Seasonal_Pure_Price.Text + "-" + Seasonal_Valu_Price.Text + "-";
				Log_Details += Seasonal_Complications_Price.Text + "-" + Seasonal_Complications.Text + "-";
				Log_Details += Seasonal_Description.Text + "-" + MDIParent1.DefaultInstance.N_Id_Area.Text;
			}
			Log_Save();
		}
		private void Log_Save()
		{

//====================================================================================================
//End of the allowed output for the Free Edition of Instant C#.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-instant-csharp.html
//====================================================================================================
