//====================================================================================================
//The Free Edition of Instant C# limits conversion output to 100 lines per file.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-instant-csharp.html
//====================================================================================================

//INSTANT C# NOTE: Formerly VB project-level imports:
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;

using System;
using System.IO;

namespace Ansaripour
{
	public partial class Area
	{
		public Area()
		{
			InitializeComponent();
		}

		private bool Add; //جداسازی ذخیره جدید و ویرایش
		private string f_serch; //تابع متغیر فرمول جستجو
		private int err;
		private string ch;
		private int T_id; //پیش فرض شماره ثبت
		private Resizer rs = new Resizer();
		private void New_B_Click(System.Object sender, System.EventArgs e)
		{
			Save_B.Enabled = true;
			Code_Area.Text = "";
			Department_Area.Text = "";
			Company_Area.Text = "";
			Add = true;
			if (Add)
			{
				DataSet PrSet = data.PDataset("select max(Code_Area) from Area ");
				foreach (DataRow Dr in PrSet.Tables[0].Rows)
				{
					if (Convert.IsDBNull(Dr[0]))
					{
						Code_Area.Text = "01";
					}
					else
					{
						switch (((string)((Dr[0].ToString() + 1).Trim(' '))).Length)
						{
							case 1:
								Code_Area.Text = "0" + (Dr[0].ToString() + 1);
								break;
							default:
								Code_Area.Text = Dr[0].ToString() + 1;
								break;
						}
					}
				}
			}
		}
		private void Edit_B_Click(System.Object sender, System.EventArgs e)
		{
			Save_B.Enabled = true;
			Add = false;
		}
		private void Delet_B_Click(System.Object sender, System.EventArgs e)
		{
			modMessage.ShowMessage("کاربر محترم" + " :" + MDIParent1.DefaultInstance.I_N.Text, " آیا از حذف اطلاعات خود مطمئن هستید؟", frmMessage.mIcon.mQuestion, frmMessage.mButtons.myes_No);
			if (modMessage.MessageValue == 5)
			{
				DataSet test_finvchbk = data.PDataset("select * from Estate where Estate_Area =" + Code_Area.Text + "");
				if (test_finvchbk.Tables[0].Rows.Count > 0)
				{
					err = 1;
				}
				switch (err)
				{
					case 1:
						modMessage.ShowMessage("کاربر محترم" + " :" + MDIParent1.DefaultInstance.I_N.Text, "این کد حساب در قسمت اسناد دارای ثبت اطلاعات می باشد شما قادر به حذف آن نمی باشید", frmMessage.mIcon.mwarning, frmMessage.mButtons.mAccept);
						break;
					default:
						DataSet delete = data.PDataset("DELETE  FROM  Area  where Id_Area LIKE N'" + DV.CurrentRow.Cells["Id_Area"].Value.ToString() + "'");
						DV.Rows.Remove(DV.CurrentRow);
						modMessage.ShowMessage("کاربر محترم" + " :" + MDIParent1.DefaultInstance.I_N.Text, "اطلاعات مورد نظر شما از سیستم حذف شده است", frmMessage.mIcon.mTrash, frmMessage.mButtons.mAccept);
						break;
				}
			}
		}
		private void Search_B_Click(System.Object sender, System.EventArgs e)
		{
			DV.Rows.Clear();
			DV.Columns.Clear();
			DV.Columns.Add("row", "ردیف");
			DV.Columns.Add("Code_Area", "کد بخش");
			DV.Columns.Add("Department_Area", "نام بخش");
			DV.Columns.Add("Company_Area", "نام شرکت");
			DV.Columns.Add("Fiscal_Year_Area", "");
			DV.Columns.Add("Registration_Number_Area", "");
			DV.Columns.Add("Economic_Number_Area", "");
			DV.Columns.Add("National_Code_Area", "");
			DV.Columns.Add("Postal_Code_Area", "");
			DV.Columns.Add("Phone_Number_Area", "");
			DV.Columns.Add("Fax_Number_Area", "");
			DV.Columns.Add("Email_Area", "");
			DV.Columns.Add("General_Manager_Area", "");
			DV.Columns.Add("Mobile_Number_Area", "");
			DV.Columns.Add("Address_Area", "");
			DV.Columns.Add("Id_Area", "");
			DV.Columns["Fiscal_Year_Area"].Visible = false;
			DV.Columns["Registration_Number_Area"].Visible = false;
			DV.Columns["Economic_Number_Area"].Visible = false;
			DV.Columns["National_Code_Area"].Visible = false;
			DV.Columns["Postal_Code_Area"].Visible = false;
			DV.Columns["Phone_Number_Area"].Visible = false;
			DV.Columns["Fax_Number_Area"].Visible = false;
			DV.Columns["Email_Area"].Visible = false;
			DV.Columns["General_Manager_Area"].Visible = false;
			DV.Columns["Mobile_Number_Area"].Visible = false;
			DV.Columns["Address_Area"].Visible = false;
			DV.Columns["Id_Area"].Visible = false;
			DV.Columns["row"].Width = 100;
			DV.Columns["Code_Area"].Width = 200;
			DV.Columns["Department_Area"].Width = 800;
			DV.Columns["Company_Area"].Width = 200;
			DV.AllowUserToAddRows = false;
			DV.EditMode = DataGridViewEditMode.EditProgrammatically;
			f_serch = "";
			if (!string.IsNullOrEmpty(Code_Area.Text))
			{
				f_serch += " and Code_Area like N'" + Code_Area.Text + "'";
			}
			if (!string.IsNullOrEmpty(Department_Area.Text))
			{
				f_serch += "and Department_Area LIKE  N'%" + Department_Area.Text + "%'";
			}

//====================================================================================================
//End of the allowed output for the Free Edition of Instant C#.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-instant-csharp.html
//====================================================================================================
