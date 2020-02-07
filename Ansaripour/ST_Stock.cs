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
	public partial class ST_Stock
	{
		public ST_Stock()
		{
			InitializeComponent();
		}

		private bool Add; //جداسازی ذخیره جدید و ویرایش
		private string f_serch; //تابع متغیر فرمول جستجو
		private int err;
		private Resizer rs = new Resizer();
		private void Hesab_Load(object sender, EventArgs e)
		{
			rs.FindAllControls(this);
			R_Load();
		}
		private void R_Load()
		{
			DV.Rows.Clear();
			DV.Columns.Clear();
			DV.Columns.Add("row", "ردیف");
			DV.Columns.Add("C_Hesab", "کد انبار");
			DV.Columns.Add("C_Name", "نام انبار");
			DV.Columns.Add("M_Stock", "");
			DV.Columns.Add("C_Address", "");
			DV.Columns.Add("C_Receipt", "");
			DV.Columns.Add("C_Request", "");
			DV.Columns.Add("C_Direct", "");
			DV.Columns.Add("C_Negative", "");
			DV.Columns.Add("ID_Stock", "");
			DV.Columns["M_Stock"].Visible = false;
			DV.Columns["C_Address"].Visible = false;
			DV.Columns["C_Receipt"].Visible = false;
			DV.Columns["C_Request"].Visible = false;
			DV.Columns["C_Direct"].Visible = false;
			DV.Columns["C_Negative"].Visible = false;
			DV.Columns["ID_Stock"].Visible = false;
			DV.Columns["row"].Width = 100;
			DV.Columns["C_Hesab"].Width = 200;
			DV.Columns["C_Name"].Width = 600;
			DV.AllowUserToAddRows = false;
			DV.EditMode = DataGridViewEditMode.EditProgrammatically;
			DataSet serch = data.PDataset("select * from ST_Stock where Area_Stock='" + MDIParent1.DefaultInstance.N_Id_Area.Text + "' order by Code_Stock");
			foreach (DataRow Dr in serch.Tables[0].Rows)
			{
				DV.Rows.Add();
				System.Windows.Forms.DataGridViewRow tempVar = DV.Rows[DV.Rows.Count - 1];
				tempVar.Cells["row"].Value = DV.Rows.Count;
				tempVar.Cells["C_Hesab"].Value = Dr["Code_Stock"];
				tempVar.Cells["C_Name"].Value = Dr["Name_Stock"];
				tempVar.Cells["M_Stock"].Value = Dr["M_Stock"];
				tempVar.Cells["C_Address"].Value = Dr["C_Address"];
				tempVar.Cells["C_Receipt"].Value = Dr["C_Receipt"];
				tempVar.Cells["C_Request"].Value = Dr["C_Request"];
				tempVar.Cells["C_Direct"].Value = Dr["C_Direct"];
				tempVar.Cells["C_Negative"].Value = Dr["C_Negative"];
				tempVar.Cells["ID_Stock"].Value = Dr["ID_Stock"];
			}
		}
		private void New_B_Click(System.Object sender, System.EventArgs e)
		{
			Save_B.Enabled = true;
			C_Hesab.Enabled = true;
			C_name.Enabled = true;
			M_Stock.Enabled = true;
			C_Address.Enabled = true;
			C_Receipt.Enabled = true;
			C_Request.Enabled = true;
			C_Direct.Enabled = true;
			C_Negative.Enabled = true;
			C_Hesab.Text = "";
			C_name.Text = "";
			M_Stock.SelectedIndex = -1;
			C_Address.Text = "";
			C_Receipt.Checked = false;
			C_Request.Checked = false;
			C_Direct.Checked = false;
			C_Negative.Checked = false;
			Add = true;
			if (Add)
			{
				DataSet PrSet = data.PDataset("select max(Code_Stock) from ST_Stock ");
				foreach (DataRow Dr in PrSet.Tables[0].Rows)
				{
					if (Convert.IsDBNull(Dr[0]))
					{
						C_Hesab.Text = "01";
					}
					else
					{
						switch (((string)((Dr[0].ToString() + 1).Trim(' '))).Length)
						{
							case 1:
								C_Hesab.Text = "0" + (Dr[0].ToString() + 1);
								break;
							default:
								C_Hesab.Text = Dr[0].ToString() + 1;
								break;
						}
					}
				}
			}
		}
		private void Edit_B_Click(System.Object sender, System.EventArgs e)
		{
			if (MDIParent1.DefaultInstance.Base_Information_Warehouse_Edit_Access.Tag == "0")
			{
				modMessage.ShowMessage("کاربر محترم" + " :" + MDIParent1.DefaultInstance.I_N.Text, " کاربری شما جهت ویرایش اطلاعات نمی باشد", frmMessage.mIcon.mlock, frmMessage.mButtons.mAccept);
			}
			else
			{
				Save_B.Enabled = true;
				C_Hesab.Enabled = true;
				C_name.Enabled = true;
				M_Stock.Enabled = true;

//====================================================================================================
//End of the allowed output for the Free Edition of Instant C#.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-instant-csharp.html
//====================================================================================================
