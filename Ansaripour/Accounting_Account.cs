
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
	public partial class Accounting_Account
	{
		public Accounting_Account()
		{
			InitializeComponent();
		}

		private bool Add; //جداسازی ذخیره جدید و ویرایش
		private bool Edit; //جداسازی ذخیره جدید و ویرایش
		private bool Detailed; //جداسازی تفصیلی
		private string f_serch; //تابع متغیر فرمول جستجو
		public bool Result;
		private int err;
		private string Group;
		public string Var_Data;
		public string Var_Group;
		public string Var_Operation;
		public string Var_Id;
		public string Var_Level;
		private Resizer rs = new Resizer();
		private void Reset()
		{
			Save_B.Enabled = false;
			Acc_Group.Enabled = false;
			Acc_Operation.Enabled = false;
			Delet_Level.ForeColor = Color.Black;
			Delet_Level.Enabled = true;
			Add = false;
			Edit = false;
			Detailed = false;
			Acc_Num.Text = "";
			Acc_Code.Text = "";
			Acc_Code.Enabled = true;
			Acc_Name.Text = "";
			Acc_Case.Text = "";
			Acc_Level.Text = "";
			Acc_Group.SelectedIndex = -1;
			Acc_Operation.SelectedIndex = -1;
			Var_Id = "";
			Var_Level = "";
		}
		private void Acc_Num_TextChanged(System.Object sender, System.EventArgs e)
		{
			if (Acc_Code.Enabled == false)
			{
				if (string.IsNullOrEmpty(Acc_Level.Text))
				{
					Acc_Code.Text = Acc_Num.Text;
				}
				else
				{
					Acc_Code.Text = data.Is_Number(Acc_Level.Text) + Acc_Num.Text;
				}
			}
		}
		private void Acc_Group_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			if (Acc_Group.SelectedIndex == 0)
			{
				Acc_Operation.SelectedIndex = -1;
				Acc_Operation.Enabled = false;
				Acc_Case.Enabled = false;
			}
			else
			{
				Acc_Operation.SelectedIndex = 0;
				Acc_Operation.Enabled = true;
				Acc_Case.Enabled = true;
			}
		}
		private void Hesab_Load(object sender, EventArgs e)
		{
			rs.FindAllControls(this);
			Acc_Group.Items.Add("زیر گـروه دارد");
			Acc_Group.Items.Add("زیر گروه ندارد");
			switch (Var_Data)
			{
				case "Accounting_Account":
				{
					Acc_Operation.Items.Add("آزاد بدون محدودیت در گردش یا مانده");
					Acc_Operation.Items.Add("مانده باید بدهکار باشد");
					Acc_Operation.Items.Add("مانده باید بستانکار باشد");
					Acc_Operation.Items.Add("فقط گردش بدهکار مورد قبول است");
					Acc_Operation.Items.Add("فقط گردش بستانکار مورد قبول است");
					break;
				}
				case "Accounting_Detailed":
				{
					Acc_Operation.Items.Add("آزاد بدون محدودیت در گردش یا مانده");
					Acc_Operation.Items.Add("مانده باید بدهکار باشد");
					Acc_Operation.Items.Add("مانده باید بستانکار باشد");
					Acc_Operation.Items.Add("فقط گردش بدهکار مورد قبول است");
					Acc_Operation.Items.Add("فقط گردش بستانکار مورد قبول است");
					break;
				}
				case "Accounting_City":
				{
				break;
				}
				case "Estate_Asset":
				{
					Label5.Text = "محاسبه استهلاک" + ":";
					Acc_Operation.Items.Add("بدون روش محاسبه استهلاک");
					Acc_Operation.Items.Add("روش محاسبه خـط مـستقیم");
					Acc_Operation.Items.Add("روش محاسبه نـــزولـــی");
					Acc_Operation.Items.Add("روش محاسبه ساعت کارکرد");
					Acc_Operation.Items.Add("روش محاسبه میزان تولید");
					Acc_Operation.Items.Add("روش محاسبه مجموع سنوات");
					Label4.Text = "نرخ به درصد" + ":";
					Acc_Case.Enabled = false;
					break;
				}
				case "Estate_Plan":
				{
					Label5.Text = "تامین اعتبار" + ":";
					Acc_Operation.Items.Add("طــــرح انتفاعی");
					Acc_Operation.Items.Add("طرح غیر انتفاعی");
					Label4.Text = "درصد مشارکت" + ":";

//====================================================================================================
//End of the allowed output for the Free Edition of Instant C#.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-instant-csharp.html
//====================================================================================================
