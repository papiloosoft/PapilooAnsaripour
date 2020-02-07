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

using static System.IO.Directory;

namespace Ansaripour
{
	public partial class bank
	{
		public bank()
		{
			InitializeComponent();
		}

		private int Add; //indicator if add button was pressed
		private int err;
		private string f_serch; //تابع متغیر فرمول جستجو
		private Resizer rs = new Resizer();
		private void data_load()
		{
			Bank_Department.Enabled = false;
			Bank_Name.Enabled = false;
			Bank_Code.Enabled = false;
			Bank_Account.Enabled = false;
			Bank_Department.Text = "";
			Bank_Name.Text = "";
			Bank_Code.Text = "";
			Bank_Account.Text = "";
			B_SAVE.Enabled = false;
			B_DELE.Enabled = false;
			ListView1.Clear();
			ListView1.Columns.Add("ردیف", 50, HorizontalAlignment.Right);
			ListView1.Columns.Add("نام بانک", 130, HorizontalAlignment.Center);
			ListView1.Columns.Add("شعبه", 200, HorizontalAlignment.Center);
			ListView1.Columns.Add("کد بانک", 100, HorizontalAlignment.Center);
			ListView1.Columns.Add("حساب", 200, HorizontalAlignment.Center);
			f_serch = "";
			f_serch = "SELECT * FROM  bank";
			if (MDIParent1.DefaultInstance.N_Admin.Text == "False")
			{
				f_serch += " where Bank_Area=" + MDIParent1.DefaultInstance.N_Id_Area.Text + "";
			}
			DataSet PrSet = data.PDataset("" + f_serch + "");
			foreach (DataRow Dr in PrSet.Tables[0].Rows)
			{
				ListViewItem lv = ListView1.Items.Add(ListView1.Items.Count + 1);
				lv.SubItems.Add(Dr["Bank_Department"]);
				lv.SubItems.Add(Dr["Bank_Name"]);
				lv.SubItems.Add(Dr["Bank_Code"]);
				lv.SubItems.Add(Dr["Bank_Account"]);
				lv.SubItems.Add(Dr["Bank_Id"]);
				lv.SubItems.Add(Dr["Bank_Check_number_Of"] + 1);
				lv.SubItems.Add(Dr["Bank_Chech_Number"]);
				lv.SubItems.Add(Dr["Bank_Check_number_To"]);
				lv.SubItems.Add(Dr["Bank_Check"]);
				lv.SubItems.Add(Dr["Bank_Payment"]);
				lv.SubItems.Add(Dr["Bank_Name_Case1"]);
				lv.SubItems.Add(Dr["Bank_Name_Case2"]);
				lv.SubItems.Add(Dr["Bank_Name_Case3"]);
				lv.SubItems.Add(Dr["Bank_Name_Case4"]);
				lv.SubItems.Add(Dr["Bank_Name_Case5"]);
				lv.SubItems.Add(Dr["Bank_Post_Case1"]);
				lv.SubItems.Add(Dr["Bank_Post_Case2"]);
				lv.SubItems.Add(Dr["Bank_Post_Case3"]);
				lv.SubItems.Add(Dr["Bank_Post_Case4"]);
				lv.SubItems.Add(Dr["Bank_Post_Case5"]);
				lv.SubItems.Add(Dr["Bank_Case"]);
			}
		}
		private void bank_Load(object sender, System.EventArgs e)
		{
			rs.FindAllControls(this);
			data_load();
		}
		private void bank_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				SendKeys.Send("{TAB}");
			}
		}
		private void ListView1_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			if (ListView1.SelectedItems.Count > 0)
			{
				B_DELE.Enabled = true;
				E_Chek.Enabled = true;
				Bank_Department.Text = ListView1.SelectedItems[0].SubItems[1].Text;
				Bank_Name.Text = ListView1.SelectedItems[0].SubItems[2].Text;
				Bank_Code.Text = ListView1.SelectedItems[0].SubItems[3].Text;
				Bank_Account.Text = ListView1.SelectedItems[0].SubItems[4].Text;
				Bank_Check_number_Of.Text = ListView1.SelectedItems[0].SubItems[6].Text;
				Bank_Chech_Number.Text = ListView1.SelectedItems[0].SubItems[7].Text;
				Bank_Check_number_To.Text = ListView1.SelectedItems[0].SubItems[8].Text;
				Bank_Check.Text = ListView1.SelectedItems[0].SubItems[9].Text;
				Bank_Payment.Text = ListView1.SelectedItems[0].SubItems[10].Text;
				Bank_Name_Case1.Text = ListView1.SelectedItems[0].SubItems[11].Text;
				Bank_Name_Case2.Text = ListView1.SelectedItems[0].SubItems[12].Text;
				Bank_Name_Case3.Text = ListView1.SelectedItems[0].SubItems[13].Text;
				Bank_Name_Case4.Text = ListView1.SelectedItems[0].SubItems[14].Text;
				Bank_Name_Case5.Text = ListView1.SelectedItems[0].SubItems[15].Text;
				Bank_Post_Case1.Text = ListView1.SelectedItems[0].SubItems[16].Text;
				Bank_Post_Case2.Text = ListView1.SelectedItems[0].SubItems[17].Text;
				Bank_Post_Case3.Text = ListView1.SelectedItems[0].SubItems[18].Text;
				Bank_Post_Case4.Text = ListView1.SelectedItems[0].SubItems[19].Text;
				Bank_Post_Case5.Text = ListView1.SelectedItems[0].SubItems[20].Text;
				ComboBox1.SelectedIndex = Convert.ToInt32(ListView1.SelectedItems[0].SubItems[21].Text);
			}
		}
		private void B_NEW_Click(System.Object sender, System.EventArgs e)
		{
			B_SAVE.Enabled = true;
			E_Chek.Enabled = false;
			Bank_Department.Enabled = true;
			Bank_Name.Enabled = true;
			Bank_Code.Enabled = true;

//====================================================================================================
//End of the allowed output for the Free Edition of Instant C#.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-instant-csharp.html
//====================================================================================================
