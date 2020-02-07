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

using Microsoft.Office.Interop;

namespace Ansaripour
{
	public partial class Counterparty
	{
		public Counterparty()
		{
			InitializeComponent();
		}

		private bool Add; //جداسازی ذخیره جدید و ویرایش
		private string f_serch; //تابع متغیر فرمول جستجو
		public bool Result;
		private int err;
		private string ch;
		private int T_id; //پیش فرض شماره ثبت
		private string State_Id;
		private string City_Id;
		private Resizer rs = new Resizer();
		private void R_Load()
		{
			DV.Rows.Clear();
			DV.Columns.Clear();
			Counterparty_Subscribe.Text = "";
			Counterparty_National_Code.BackColor = Color.White;
			Counterparty_Personality_Type.SelectedIndex = -1;
			Counterparty_Buyer_Type.SelectedIndex = -1;
			Counterparty_Name.Text = "";
			Counterparty_Family.Text = "";
			Counterparty_Manager.Text = "";
			Counterparty_Registration_Number.Text = "";
			Counterparty_Phone.Text = "";
			Counterparty_Fax.Text = "";
			Counterparty_Mobile.Text = "";
			Counterparty_Postal_Code.Text = "";
			Counterparty_National_Code.Text = "";
			Counterparty_Economic_Code.Text = "";
			Counterparty_Email.Text = "";
			Counterparty_State.Text = "";
			Counterparty_City.Text = "";
			Counterparty_Bank_Number.Text = "";
			Counterparty_Address.Text = "";
		}
		private void Dv_Get()
		{
			DV.Rows.Clear();
			DV.Columns.Clear();
			DV.Columns.Add("row", "ردیف");
			DV.Columns.Add("Counterparty_ID", "آی دی");
			DV.Columns.Add("Counterparty_Subscribe", "اشتراک");
			DV.Columns.Add("Counterparty_Personality_Type", "نوع شخصیت");
			DV.Columns.Add("Counterparty_Buyer_Type", "نوع خریدار");
			DV.Columns.Add("Counterparty_Name", "نام");
			DV.Columns.Add("Counterparty_Family", "شرکت / نام خانوادگی");
			DV.Columns.Add("Counterparty_Manager", "نام مدیر");
			DV.Columns.Add("Counterparty_Registration_Number", "شماره ثبت");
			DV.Columns.Add("Counterparty_Phone", "شماره تلفن ثابت");
			DV.Columns.Add("Counterparty_Fax", "شماره فاکس");
			DV.Columns.Add("Counterparty_Mobile", "شماره همراه");
			DV.Columns.Add("Counterparty_Postal_Code", "کد پستی");
			DV.Columns.Add("Counterparty_National_Code", "شناسه/کد ملی");
			DV.Columns.Add("Counterparty_Economic_Code", "کد اقتصادی");
			DV.Columns.Add("Counterparty_Email", "ایمیل");
			DV.Columns.Add("Counterparty_State", "استان");
			DV.Columns.Add("Counterparty_City", "شهر");
			DV.Columns.Add("Counterparty_Bank_Number", "شماره حساب");
			DV.Columns.Add("Counterparty_Address", "آدرس");
			DV.Columns.Add("Counterparty_Area", "منطقه");
			DV.Columns.Add("State_Id", "");
			DV.Columns.Add("City_Id", "");
			DV.Columns["row"].Width = 50;
			DV.Columns["Counterparty_ID"].Visible = false;
			DV.Columns["Counterparty_Subscribe"].Width = 80;
			DV.Columns["Counterparty_Personality_Type"].Visible = false;
			DV.Columns["Counterparty_Buyer_Type"].Visible = false;
			DV.Columns["Counterparty_Name"].Width = 300;
			DV.Columns["Counterparty_Family"].Width = 300;
			DV.Columns["Counterparty_Manager"].Visible = false;
			DV.Columns["Counterparty_Registration_Number"].Visible = false;
			DV.Columns["Counterparty_Phone"].Visible = false;
			DV.Columns["Counterparty_Fax"].Visible = false;
			DV.Columns["Counterparty_Postal_Code"].Visible = false;
			DV.Columns["Counterparty_National_Code"].Width = 120;
			DV.Columns["Counterparty_Economic_Code"].Width = 120;
			DV.Columns["Counterparty_Email"].Visible = false;
			DV.Columns["Counterparty_State"].Visible = false;
			DV.Columns["Counterparty_City"].Visible = false;
			DV.Columns["Counterparty_Bank_Number"].Visible = false;
			DV.Columns["Counterparty_Address"].Width = 300;
			DV.Columns["Counterparty_Area"].Visible = false;
			DV.Columns["State_Id"].Visible = false;
			DV.Columns["City_Id"].Visible = false;
			DV.AllowUserToAddRows = false;
			DV.EditMode = DataGridViewEditMode.EditProgrammatically;
		}
		private void I_Serch()
		{
			f_serch = "";
			if (!string.IsNullOrEmpty(Counterparty_Subscribe.Text))
			{
				f_serch += " and Counterparty_Subscribe like N'" + Counterparty_Subscribe.Text + "'";
			}

//====================================================================================================
//End of the allowed output for the Free Edition of Instant C#.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-instant-csharp.html
//====================================================================================================
