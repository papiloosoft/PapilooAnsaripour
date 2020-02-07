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
	public partial class ST_Request_Goods
	{
		public ST_Request_Goods()
		{
			InitializeComponent();
		}

		public string Var_Clas;
		public bool Result;
		private string Id_Personal;
		private string Id_Stock;
		private string Id_Refrence;
		private int Bed;
		private int Bes;
		private bool Add; //جداسازي ذخيره جديد و ويرايش
		private bool Edit;
		private bool Del;
		private string f_serch; //تابع متغیر فرمول جستجو
		private string f_Select; //تابع متغیر فرمول جستجو
		private string F_Report;
		private bool test;
		private int err;
		private Resizer rs = new Resizer();
		private void TabControl1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			DV.Rows.Clear();
			DV.Columns.Clear();
			DV.Controls.Clear();
		}
		private void Dv_Get()
		{
			DV.Rows.Clear();
			DV.Columns.Clear();
			DV.Controls.Clear();
			switch (Convert.ToInt32(Var_Clas))
			{
				case 0:
					DV.Columns.Add("row", "رديف");
					DV.Columns.Add("Number_Ask_Refrence", "درخواست");
					DV.Columns.Add("Date_Ask_Refrence", "تاریخ");
					DV.Columns.Add("Personal_Ask_Refrence", "طرف حساب");
					DV.Columns.Add("Id_Personal", "");
					DV.Columns.Add("Description_Ask_Refrence", "محل مصرف");
					DV.Columns.Add("Area_St_Refrence", "");
					DV.Columns.Add("Class_St_Refrence", "");
					DV.Columns.Add("Id_St_Refrence", "");
					DV.Columns["Area_St_Refrence"].Visible = false;
					DV.Columns["Id_St_Refrence"].Visible = false;
					DV.Columns["Id_Personal"].Visible = false;
					DV.Columns["row"].Width = 80;
					DV.Columns["Number_Ask_Refrence"].Width = 100;
					DV.Columns["Date_Ask_Refrence"].Width = 150;
					DV.Columns["Personal_Ask_Refrence"].Width = 300;
					DV.Columns["Description_Ask_Refrence"].Width = 400;
					break;
				case 1:
					switch (TabControl1.SelectedIndex)
					{
						case 0:
							DV.Columns.Add("row", "رديف");
							DV.Columns.Add("Number_Ask_Refrence", "درخواست");
							DV.Columns.Add("Date_Ask_Refrence", "تاریخ");
							DV.Columns.Add("Personal_Ask_Refrence", "طرف حساب");
							DV.Columns.Add("Id_Personal", "");
							DV.Columns.Add("Description_Ask_Refrence", "محل مصرف");
							DV.Columns.Add("Area_St_Refrence", "");
							DV.Columns.Add("Class_St_Refrence", "");
							DV.Columns.Add("Id_St_Refrence", "");
							DV.Columns["Area_St_Refrence"].Visible = false;
							DV.Columns["Id_St_Refrence"].Visible = false;
							DV.Columns["Id_Personal"].Visible = false;
							DV.Columns["row"].Width = 80;
							DV.Columns["Number_Ask_Refrence"].Width = 100;
							DV.Columns["Date_Ask_Refrence"].Width = 150;
							DV.Columns["Personal_Ask_Refrence"].Width = 300;
							DV.Columns["Description_Ask_Refrence"].Width = 400;
							break;
						case 1:
							DV.Columns.Add("row", "رديف");
							DV.Columns.Add("Number_Buy_Refrence", "درخواست خرید");
							DV.Columns.Add("Date_Buy_Refrence", "تاریخ درخواست خرید");
							DV.Columns.Add("Number_Ask_Refrence", "درخواست کالا");
							DV.Columns.Add("Area_St_Refrence", "");
							DV.Columns.Add("Class_St_Refrence", "");
							DV.Columns.Add("Id_St_Refrence", "");
							DV.Columns["Area_St_Refrence"].Visible = false;
							DV.Columns["Id_St_Refrence"].Visible = false;
							DV.Columns["row"].Width = 80;
							DV.Columns["Number_Buy_Refrence"].Width = 200;
							DV.Columns["Date_Buy_Refrence"].Width = 250;
							DV.Columns["Number_Ask_Refrence"].Width = 200;
							break;
					}
					break;
				case 2:
					switch (TabControl1.SelectedIndex)
					{
						case 0:
							DV.Columns.Add("row", "رديف");
							DV.Columns.Add("Number_Buy_Refrence", "درخواست خرید");

//====================================================================================================
//End of the allowed output for the Free Edition of Instant C#.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-instant-csharp.html
//====================================================================================================
