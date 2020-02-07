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
	public partial class Repair_Cost
	{
		public Repair_Cost()
		{
			InitializeComponent();
		}

		private bool Add; //جداسازي ذخيره جديد و ويرايش
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
			Dv_Stock.Columns.Add("Goods_Number", "تعداد");
			Dv_Stock.Columns.Add("Repairman_Name", "نام تعمیرکار");
			Dv_Stock.Columns.Add("Expertise", "نوع تخصص");
			Dv_Stock.Columns.Add("Time_Work", "ساعت کارکرد");
			Dv_Stock.Columns.Add("Goods_Id", "");
			Dv_Stock.Columns.Add("Id_Cost_Attachment", "");
			Dv_Stock.Columns["Goods_Id"].Visible = false;
			Dv_Stock.Columns["Id_Cost_Attachment"].Visible = false;
			Dv_Stock.Columns["row"].Width = 80;
			Dv_Stock.Columns["Goods_Code"].Width = 100;
			Dv_Stock.Columns["Goods_Name"].Width = 250;
			Dv_Stock.Columns["Goods_Module"].Width = 100;
			Dv_Stock.Columns["Goods_Number"].Width = 100;
			Dv_Stock.Columns["Repairman_Name"].Width = 200;
			Dv_Stock.Columns["Expertise"].Width = 100;
			Dv_Stock.Columns["Time_Work"].Width = 100;
			Dv_Stock.AllowUserToAddRows = true;
			Dv_Stock.EditMode = DataGridViewEditMode.EditOnKeystroke;
			Dv_Stock.ReadOnly = false;
			Dv_Stock.SelectionMode = DataGridViewSelectionMode.CellSelect;
			Dv_Stock.RowsDefaultCellStyle.BackColor = Color.LightGray;
			Dv_Stock.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
			Cost_Id_Total.Text = "";
			Cost_Id_Request.Text = "";
			Cost_Num_Request.Text = "";
			Cost_Date_Request.T_D = "";
			Cost_Time_Request.T_Text = "";
			Cost_Date_Sabt.T_D = "";
			Cost_Repair_description.Text = "";
			Cost_Work_description.Text = "";
			Cost_Start_Date_Work.T_D = "";
			Cost_Start_Time_Work.T_Text = "";
			Cost_End_Date_Work.T_D = "";
			Cost_End_Time_Work.T_Text = "";
			Cost_Stop_Defect.Text = "";
			Cost_Time_Stop_Repair.Text = "";
			Cost_Time_Stop_Work.Text = "";
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
					Dv_Stock.CurrentRow.Cells["Goods_Module"].Value = modMessage.C_I_code.ToString();
					Dv_Stock.CurrentRow.Cells["Goods_Id"].Value = modMessage.C_H_code.ToString();
					Dv_Stock.CurrentRow.Cells["Goods_Name"].ReadOnly = true;
					Dv_Stock.CurrentRow.Cells["Goods_Module"].ReadOnly = true;
				}
			}
		}
		private void Dv_Stock_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
		{
			Del = true;
		}
		private void Dv_Stock_CellEndEdit(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
		{
			switch (Dv_Stock.CurrentCell.ColumnIndex)
			{
				case 1:
					test = false;
					DataSet serch = data.PDataset("select A.*,B.* from St_Goods A left join St_Goods_Module B on A.Goods_Module=B.Goods_Module_Code where  Goods_Code='" + Dv_Stock.CurrentRow.Cells["Goods_Code"].Value.ToString() + "'");
					if (serch.Tables[0].Rows.Count != 0)
					{
						foreach (DataRow Dr in serch.Tables[0].Rows)
						{
							int a = 0;
							if (Dv_Stock.CurrentRow.Index >= 0)
							{
								foreach (DataGridViewRow row in Dv_Stock.Rows)
								{

//====================================================================================================
//End of the allowed output for the Free Edition of Instant C#.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-instant-csharp.html
//====================================================================================================
