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
	public partial class Repair
	{
		public Repair()
		{
			InitializeComponent();
		}

		private bool Add;
		private bool Edit;
		private bool Del;
		private string f_serch; //تابع متغیر فرمول جستجو
		private bool test;
		private int err;
		private Resizer rs = new Resizer();
		private void New_Load()
		{
			DV.Rows.Clear();
			DV.Columns.Clear();
			Dv_Stock.Rows.Clear();
			Dv_Stock.Columns.Clear();
			Dv_Stock.Controls.Clear();
			Dv_Stock.Columns.Add("row", "رديف");
			Dv_Stock.Columns.Add("Goods_Code", "کد کالا");
			Dv_Stock.Columns.Add("Goods_Name", "شرح کالا");
			Dv_Stock.Columns.Add("Goods_Module", "واحد کالا");
			Dv_Stock.Columns.Add("Technical_Specifications", "مشخصات فنی");
			Dv_Stock.Columns.Add("Useful_life", "عمر مفید");
			Dv_Stock.Columns.Add("order_point", "نقطه سفارش");
			Dv_Stock.Columns.Add("Limit_Order", "حد سفارش");
			Dv_Stock.Columns.Add("Goods_Id", "");
			Dv_Stock.Columns["Goods_Id"].Visible = false;
			Dv_Stock.Columns["row"].Width = 80;
			Dv_Stock.Columns["Goods_Code"].Width = 100;
			Dv_Stock.Columns["Goods_Name"].Width = 250;
			Dv_Stock.Columns["Goods_Module"].Width = 100;
			Dv_Stock.Columns["Technical_Specifications"].Width = 200;
			Dv_Stock.Columns["Useful_life"].Width = 100;
			Dv_Stock.Columns["order_point"].Width = 100;
			Dv_Stock.Columns["Limit_Order"].Width = 100;
			Dv_Stock.AllowUserToAddRows = true;
			Dv_Stock.EditMode = DataGridViewEditMode.EditOnKeystroke;
			Dv_Stock.ReadOnly = false;
			Dv_Stock.SelectionMode = DataGridViewSelectionMode.CellSelect;
			Dv_Stock.RowsDefaultCellStyle.BackColor = Color.LightGray;
			Dv_Stock.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
			Repair_Name.Text = "";
			Repair_Code.Text = "";
			Repair_Serial.Text = "";
			Repair_Seating.Text = "";
			Repair_Manufacturing_Country.Text = "";
			Repair_Manufacturer.Text = "";
			Repair_Model_Making.Text = "";
			Repair_Production_Date.T_D = "";
			Repair_Use_Date.T_D = "";
			Repair_Dimensions_Device.Text = "";
			Repair_Working_Dimensions.Text = "";
			Repair_Weight_Device.Text = "";
			Repair_Production_Capacity.Text = "";
			Repair_Ability_Work.Text = "";
			Repair_Capacity.Text = "";
			Repair_Energy.Text = "";
			Repair_Name_Engine.Text = "";
			Repair_Engine_Manufacturer.Text = "";
			Repair_Power_Cable.SelectedIndex = -1;
			Repair_Voltage.Text = "";
			Repair_Power.Text = "";
			Repair_Stream.Text = "";
			Repair_Frequency.Text = "";
			Repair_RPM.Text = "";
			Repair_Phase.Text = "";
			Repair_Kind_Stream.Text = "";
			Repair_Kind_Fuse.Text = "";
			Repair_Connector_Type.Text = "";
			Repair_Power_Factor.Text = "";
			Repair_Flow_Rate.Text = "";
			Repair_Key_Issues.Text = "";
			Repair_Cable_Size.Text = "";
			Repair_Description.Text = "";
		}
		private void BTN_Click(System.Object sender, System.EventArgs e)
		{
			test = false;
			modMessage.C_C_code = "";
			modMessage.ShowSerch("فرم جستجو بر اساس کد و شرح کالا", "شرح کالا", "کد کالا", "St_Goods", "Goods_Name", "Goods_Code", "St_Goods_Module", "Goods_Module", "Goods_Module_Id", "", "Goods_Id", "Goods_Module_Name", "", "", "", "", "", "");
			if (Dv_Stock.CurrentRow.Index > 0)
			{
				foreach (DataGridViewRow row in Dv_Stock.Rows)
				{
					if (Convert.ToString(row.Cells["Goods_Code"].Value) == modMessage.C_C_code.ToString())
					{
						test = true;
					}
				}
			}
			if (test)
			{
				modMessage.ShowMessage("کاربر محترم" + " :" + MDIParent1.DefaultInstance.I_N.Text, " این کد کالا  تکراری است", frmMessage.mIcon.mwarning, frmMessage.mButtons.mAccept);
			}
			else
			{
				if (!string.IsNullOrEmpty(modMessage.C_F_code.ToString()))
				{
					Dv_Stock.CurrentRow.Cells["Goods_Code"].Value = modMessage.C_C_code.ToString();
					Dv_Stock.CurrentRow.Cells["Goods_Name"].Value = modMessage.C_Sh_code.ToString();

//====================================================================================================
//End of the allowed output for the Free Edition of Instant C#.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-instant-csharp.html
//====================================================================================================
