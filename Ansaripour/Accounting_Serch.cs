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
	public partial class Accounting_Serch
	{
		public Accounting_Serch()
		{
			InitializeComponent();
		}

		private string f_serch; //تابع متغیر فرمول جستجو
		private string ma_serch; //تابع متغیر فرمول جستجو
		private string maText;
		private string mbText;
		public void ConfigForm(string ATitle, string BTitle, string CTitle, string AText, string BText, string A_serch)
		{
			this.Text = ATitle;
			ma_serch = A_serch;
			BTi.Text = BTitle;
			CTi.Text = CTitle;
			maText = AText;
			mbText = BText;
		}
		private void Dv_Get()
		{
			Dv.Rows.Clear();
			Dv.Columns.Clear();
			Dv.Columns.Add("row", "ردیف");
			Dv.Columns.Add("Acc_Code", CTi.Text);
			Dv.Columns.Add("Acc_Name", BTi.Text);
			Dv.Columns.Add("Acc_Id", "");
			Dv.Columns.Add("Acc_Num", "");
			Dv.Columns.Add("Acc_level", "");
			Dv.Columns.Add("Acc_Operation", "");
			Dv.Columns.Add("Acc_Case", "");
			Dv.Columns.Add("Acc_Class", "");
			Dv.Columns.Add("Acc_Group", "");
			Dv.Columns["row"].Width = 50;
			Dv.Columns["Acc_Code"].Width = 100;
			Dv.Columns["Acc_Name"].Width = 365;
			Dv.Columns["Acc_Id"].Visible = false;
			Dv.Columns["Acc_Num"].Visible = false;
			Dv.Columns["Acc_level"].Visible = false;
			Dv.Columns["Acc_Operation"].Visible = false;
			Dv.Columns["Acc_Case"].Visible = false;
			Dv.Columns["Acc_Class"].Visible = false;
			Dv.Columns["Acc_Group"].Visible = false;
			Dv.AllowUserToAddRows = false;
			Dv.EditMode = DataGridViewEditMode.EditProgrammatically;
		}
		private void B_Serch_Click(System.Object sender, System.EventArgs e)
		{
			Dv_Get();
			f_serch = "";
			if (Name_Hesab.Text.Length != 0)
			{
				f_serch += " and  " + maText + " Like N'%" + Name_Hesab.Text + "%'";
			}
			if (Code_Hesab.Text.Length != 0)
			{
				f_serch += " and  " + mbText + " LIKE  N'%" + Code_Hesab.Text + "%'";
			}
			f_serch = Microsoft.VisualBasic.Strings.Replace(f_serch, "and", "", 1, 1);
			if (string.IsNullOrEmpty(f_serch))
			{
				this.Cursor = Cursors.Default;
				modMessage.ShowMessage("کاربر محترم" + " :" + MDIParent1.DefaultInstance.I_N.Text, "موردي براي جستجو مشخص نشده است", frmMessage.mIcon.mzoom, frmMessage.mButtons.mAccept);
				return;
			}
			else
			{
				f_serch = "Select * from Accounting_Account where " + f_serch + " And " + ma_serch + "";
			}
			DataSet serch = data.PDataset("" + f_serch + "");
			Id_Code.Text = serch.Tables[0].Rows.Count + "مورد";
			foreach (DataRow Dr in serch.Tables[0].Rows)
			{
				Dv.Rows.Add();
				System.Windows.Forms.DataGridViewRow tempVar = Dv.Rows[Dv.Rows.Count - 1];
				tempVar.Cells["row"].Value = Dv.Rows.Count;
				tempVar.Cells["Acc_Code"].Value = Dr["Acc_Code"];
				tempVar.Cells["Acc_Name"].Value = Dr["Acc_Name"];
				tempVar.Cells["Acc_Id"].Value = Dr["Acc_Id"];
				tempVar.Cells["Acc_Num"].Value = Dr["Acc_Num"];
				tempVar.Cells["Acc_level"].Value = Dr["Acc_level"];
				tempVar.Cells["Acc_Operation"].Value = Dr["Acc_Operation"];
				tempVar.Cells["Acc_Case"].Value = Dr["Acc_Case"];
				tempVar.Cells["Acc_Class"].Value = Dr["Acc_Class"];
				tempVar.Cells["Acc_Group"].Value = Dr["Acc_Group"];
			}
			this.Cursor = Cursors.Default;
		}
		private void button_02_Click_1(System.Object sender, System.EventArgs e)
		{
			Dv_Get();
			f_serch = "Select * from Accounting_Account where " + ma_serch + "";
			DataSet serch = data.PDataset("" + f_serch + "");
			Id_Code.Text = serch.Tables[0].Rows.Count + "مورد";
			foreach (DataRow Dr in serch.Tables[0].Rows)
			{
				Dv.Rows.Add();
				System.Windows.Forms.DataGridViewRow tempVar = Dv.Rows[Dv.Rows.Count - 1];
				tempVar.Cells["row"].Value = Dv.Rows.Count;
				tempVar.Cells["Acc_Code"].Value = Dr["Acc_Code"];
				tempVar.Cells["Acc_Name"].Value = Dr["Acc_Name"];
				tempVar.Cells["Acc_Id"].Value = Dr["Acc_Id"];
				tempVar.Cells["Acc_Num"].Value = Dr["Acc_Num"];
				tempVar.Cells["Acc_level"].Value = Dr["Acc_level"];
				tempVar.Cells["Acc_Operation"].Value = Dr["Acc_Operation"];
				tempVar.Cells["Acc_Case"].Value = Dr["Acc_Case"];
				tempVar.Cells["Acc_Class"].Value = Dr["Acc_Class"];
				tempVar.Cells["Acc_Group"].Value = Dr["Acc_Group"];
			}
			this.Cursor = Cursors.Default;
		}
		private void button_02_Click(System.Object sender, System.EventArgs e)
		{

//====================================================================================================
//End of the allowed output for the Free Edition of Instant C#.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-instant-csharp.html
//====================================================================================================
