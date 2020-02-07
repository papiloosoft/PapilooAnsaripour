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

using System.Drawing.Imaging;

namespace Ansaripour
{
	public partial class Pay_Sentence
	{
		public Pay_Sentence()
		{
			InitializeComponent();
		}

		private Resizer rs = new Resizer();
		private string Id_Subscription;
		private string Id_Area;
		private string Id_City;
		private void Pay_Sentence_Load(object sender, System.EventArgs e)
		{
			rs.FindAllControls(this);
		}
		private void Pay_Sentence_Resize(object sender, System.EventArgs e)
		{
			rs.ResizeAllControls(this);
		}
		private void B_Pay_Personal_Click(System.Object sender, System.EventArgs e)
		{
			Pay_Personal OBJCHILD = new Pay_Personal();
			OBJCHILD.Text = "فرم جستجو بر اساس اشخاص و طرف حساب ها ";
			OBJCHILD.Result = true;
			OBJCHILD.ShowDialog();
			if (!string.IsNullOrEmpty(modMessage.Mod_Pay_Personal_Id.ToString()))
			{
				Id_Subscription = modMessage.Mod_Pay_Personal_Id.ToString();
				Pay_Personal_Detailed.Text = modMessage.Mod_Pay_Personal_Detailed.ToString() + ":" + modMessage.Mod_Pay_Personal_Code.ToString();
			}
		}
		private void B_Organization_Pay_Sentence_Click(System.Object sender, System.EventArgs e)
		{
			modMessage.ShowSerch("فرم جستجو بر اساس بخش", "شرح بخش", "شرح شرکت", "Area", "Department_Area", "Company_Area", "", "", "", "", "ID_Area", "", "", "", "", "", "", "");
			if (string.IsNullOrEmpty(modMessage.C_H_code.ToString()) == false)
			{
				Id_Area = modMessage.C_H_code.ToString();
				Organization_Pay_Sentence.Text = modMessage.C_H_code.ToString() + " - " + modMessage.C_Sh_code.ToString();
			}
		}
		private void B_City_Pay_Sentence_Click(System.Object sender, System.EventArgs e)
		{
			Base_Information OBJCHILD = new Base_Information();
			OBJCHILD.Text = "فرم ورود اطلاعات طبقه بندی  مراکز / شهرها ";
			OBJCHILD.Var_Clas = "Estate_City";
			OBJCHILD.Var_Area = "Estate_Area";
			OBJCHILD.Result = true;
			OBJCHILD.ShowDialog();
			if (!string.IsNullOrEmpty(modMessage.Mod_Base_Information_Id.ToString()))
			{
				Id_City = modMessage.Mod_Base_Information_Id.ToString();
				City_Pay_Sentence.Text = modMessage.Mod_Base_Information_Name.ToString() + ":" + modMessage.Mod_Base_Information_Code.ToString();
			}
		}
	}

}