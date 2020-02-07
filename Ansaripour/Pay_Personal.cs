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

using System.Drawing.Imaging;

namespace Ansaripour
{
	public partial class Pay_Personal
	{
		public Pay_Personal()
		{
			InitializeComponent();
		}

		public bool Result;
		private bool Add; //جداسازی ذخیره جدید و ویرایش
		private string f_serch; //تابع متغیر فرمول جستجو
		private int err;
		private Resizer rs = new Resizer();
		private void R_Load()
		{
			DV.Rows.Clear();
			DV.Columns.Clear();
			Pay_Personal_Code.Text = "";
			Pay_Personal_Name.Text = "";
			Pay_Personal_Family.Text = "";
			Pay_Personal_Father.Text = "";
			Pay_Personal_Date_Berthday.T_D = "";
			Pay_Personal_Place_Berthday.Text = "";
			Pay_Personal_Cirtificate_Id.Text = "";
			Pay_Personal_National_Id.Text = "";
			Pay_Personal_Sex.SelectedIndex = -1;
			Pay_Personal_Soldier.SelectedIndex = -1;
			Pay_Personal_Marry.SelectedIndex = -1;
			Pay_Personal_Discipline.Text = "";
			Pay_Personal_Diploma.SelectedIndex = -1;
			Pay_Personal_Insurance.Text = "";
			Pay_Personal_Account.Text = "";
			Pay_Personal_Tell.Text = "";
			Pay_Personal_Address.Text = "";
		}
		private void DV_CellEnter(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
		{
			if (DV.SelectedCells.Count > 0)
			{
				Pay_Personal_Code.Text = Convert.ToString(DV.CurrentRow.Cells["Pay_Personal_Code"].Value);
				Pay_Personal_Name.Text = Convert.ToString(DV.CurrentRow.Cells["Pay_Personal_Name"].Value);
				Pay_Personal_Family.Text = Convert.ToString(DV.CurrentRow.Cells["Pay_Personal_Family"].Value);
				Pay_Personal_Father.Text = Convert.ToString(DV.CurrentRow.Cells["Pay_Personal_Father"].Value);
				Pay_Personal_Date_Berthday.T_D = Convert.ToString(DV.CurrentRow.Cells["Pay_Personal_Date_Berthday"].Value);
				Pay_Personal_Place_Berthday.Text = Convert.ToString(DV.CurrentRow.Cells["Pay_Personal_Place_Berthday"].Value);
				Pay_Personal_Cirtificate_Id.Text = Convert.ToString(DV.CurrentRow.Cells["Pay_Personal_Cirtificate_Id"].Value);
				Pay_Personal_National_Id.Text = Convert.ToString(DV.CurrentRow.Cells["Pay_Personal_National_Id"].Value);
				Pay_Personal_Sex.SelectedIndex = Convert.ToInt32(DV.CurrentRow.Cells["Pay_Personal_Sex"].Value);
				Pay_Personal_Soldier.SelectedIndex = Convert.ToInt32(DV.CurrentRow.Cells["Pay_Personal_Soldier"].Value);
				Pay_Personal_Marry.SelectedIndex = Convert.ToInt32(DV.CurrentRow.Cells["Pay_Personal_Marry"].Value);
				Pay_Personal_Discipline.Text = Convert.ToString(DV.CurrentRow.Cells["Pay_Personal_Discipline"].Value);
				Pay_Personal_Diploma.SelectedIndex = Convert.ToInt32(DV.CurrentRow.Cells["Pay_Personal_Diploma"].Value);
				Pay_Personal_Insurance.Text = Convert.ToString(DV.CurrentRow.Cells["Pay_Personal_Insurance"].Value);
				Pay_Personal_Account.Text = Convert.ToString(DV.CurrentRow.Cells["Pay_Personal_Account"].Value);
				Pay_Personal_Tell.Text = Convert.ToString(DV.CurrentRow.Cells["Pay_Personal_Tell"].Value);
				Pay_Personal_Address.Text = Convert.ToString(DV.CurrentRow.Cells["Pay_Personal_Address"].Value);
				if (Result == true)
				{
					this.Close();
					modMessage.Mod_Pay_Personal_Id = Convert.ToString(DV.CurrentRow.Cells["Pay_Personal_Id"].Value);
					modMessage.Mod_Pay_Personal_Code = Convert.ToString(DV.CurrentRow.Cells["Pay_Personal_Code"].Value);
					modMessage.Mod_Pay_Personal_Detailed = DV.CurrentRow.Cells["Pay_Personal_Name"].Value.ToString() + " " + DV.CurrentRow.Cells["Pay_Personal_Family"].Value.ToString();
				}
			}
		}
		private void B_New_Click(System.Object sender, System.EventArgs e)
		{
			B_Save.Enabled = true;
			R_Load();
			Add = true;
			if (Add)
			{
				DataSet PrSet = data.PDataset("select max(Pay_Personal_Code) from Pay_Personal");
				foreach (DataRow Dr in PrSet.Tables[0].Rows)
				{
					if (Convert.IsDBNull(Dr[0]))
					{
						Pay_Personal_Code.Text = "1";
					}
					else
					{
						Pay_Personal_Code.Text = Dr[0].ToString() + 1;
					}
				}
			}
		}
		private void B_Edit_Click(System.Object sender, System.EventArgs e)
		{
			if (MDIParent1.DefaultInstance.Base_Information_PayRoll_Edit_Access.Tag == "0")
			{
				modMessage.ShowMessage("کاربر محترم" + " :" + MDIParent1.DefaultInstance.I_N.Text, " کاربری شما جهت ویرایش اطلاعات نمی باشد", frmMessage.mIcon.mlock, frmMessage.mButtons.mAccept);
			}
			else
			{
				B_Save.Enabled = true;
				Add = false;
			}
		}
		private void B_Delet_Click(System.Object sender, System.EventArgs e)
		{
			if (MDIParent1.DefaultInstance.Base_Information_PayRoll_Delete_Access.Tag == "0")
			{
				modMessage.ShowMessage("کاربر محترم" + " :" + MDIParent1.DefaultInstance.I_N.Text, " کاربری شما جهت حذف اطلاعات نمی باشد", frmMessage.mIcon.mlock, frmMessage.mButtons.mAccept);
			}
			else
			{
				modMessage.ShowMessage("کاربر محترم" + " :" + MDIParent1.DefaultInstance.I_N.Text, " آیا از حذف اطلاعات خود مطمئن هستید؟", frmMessage.mIcon.mQuestion, frmMessage.mButtons.myes_No);
				if (modMessage.MessageValue == 5)
				{
					DataSet delete = data.PDataset("DELETE  FROM  Pay_Personal  where Pay_Personal_Id LIKE N'" + DV.CurrentRow.Cells["Pay_Personal_Id"].Value.ToString() + "'");
					DV.Rows.Remove(DV.CurrentRow);
					modMessage.ShowMessage("کاربر محترم" + " :" + MDIParent1.DefaultInstance.I_N.Text, "اطلاعات مورد نظر شما از سیستم حذف شده است", frmMessage.mIcon.mTrash, frmMessage.mButtons.mAccept);
				}
			}
		}
		private void B_Save_Click(System.Object sender, System.EventArgs e)
		{
			err = 0;
			if (!NumericHelper.IsNumeric(Pay_Personal_Code.Text))
			{
				err = 1;
			}
			if (Pay_Personal_Name.Text.Length == 0)
			{
				err = 2;
			}
			if (Pay_Personal_Family.Text.Length == 0)
			{
				err = 3;
			}
			if (Add)
			{
				DataSet test = data.PDataset("select * from Pay_Personal where Pay_Personal_Code like N'" + Pay_Personal_Code.Text + "'");

//====================================================================================================
//End of the allowed output for the Free Edition of Instant C#.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-instant-csharp.html
//====================================================================================================
