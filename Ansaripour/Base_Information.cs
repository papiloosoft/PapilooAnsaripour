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
	public partial class Base_Information
	{
		public Base_Information()
		{
			InitializeComponent();
		}

		private bool Add; //جداسازی ذخیره جدید و ویرایش
		private string f_serch; //تابع متغیر فرمول جستجو
		private int err;
		private int leng;
		private string B_clas;
		public string Var_Clas;
		public string Var_Area;
		public bool Result;
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
			DV.Columns.Add("Base_Information_Code", "کد");
			DV.Columns.Add("Base_Information_Name", "شرح کد");
			DV.Columns.Add("Base_Information_Id", "");
			DV.Columns["Base_Information_Id"].Visible = false;
			DV.Columns["row"].Width = 100;
			DV.Columns["Base_Information_Code"].Width = 200;
			DV.Columns["Base_Information_Name"].Width = 600;
			DV.AllowUserToAddRows = false;
			DV.EditMode = DataGridViewEditMode.EditProgrammatically;
			f_serch = "";
			f_serch = "select * from Base_Information where Base_Information_Class = '" + Var_Clas + "'";
			switch (Var_Clas)
			{
				case "Estate_City":
				case "Estate_No_Personnel":
					if (MDIParent1.DefaultInstance.N_Admin.Text == "False")
					{
						f_serch += " and Base_Information_Area='" + MDIParent1.DefaultInstance.N_Id_Area.Text + "'";
					}
					break;
			}
			DataSet PrSet = data.PDataset("" + f_serch + " order by Base_Information_Code");
			foreach (DataRow Dr in PrSet.Tables[0].Rows)
			{
				DV.Rows.Add();
				System.Windows.Forms.DataGridViewRow tempVar = DV.Rows[DV.Rows.Count - 1];
				tempVar.Cells["row"].Value = DV.Rows.Count;
				tempVar.Cells["Base_Information_Code"].Value = Dr["Base_Information_Code"];
				tempVar.Cells["Base_Information_Name"].Value = Dr["Base_Information_Name"];
				tempVar.Cells["Base_Information_Id"].Value = Dr["Base_Information_Id"];
			}
		}
		private void New_B_Click(System.Object sender, System.EventArgs e)
		{
			Save_B.Enabled = true;
			Base_Information_Code.Text = "";
			Base_Information_Name.Text = "";
			Add = true;
			if (Add)
			{
				DataSet PrSet = data.PDataset("select max(Base_Information_Code) from Base_Information where Base_Information_Class = '" + Var_Clas + "'");
				foreach (DataRow Dr in PrSet.Tables[0].Rows)
				{
					switch (Var_Clas)
					{
						case "Repair_Seating":
						case "Repair_Energy":
						case "Repair_Phase":
						case "Repair_Kind_Stream":
						case "Repair_Kind_Fuse":
						case "Repair_Connector_Type":
						case "Repair_Stop_Defect":
						case "Recovery_Document_Case":
						case "Warranty_Document_Case":
						case "Unit_Goods":
						case "Group_Goods":
						case "Estate_City":
						case "Estate_Cost_Code":
						case "Case_Rooms":
						case "Case_Restaurant":
						case "Order_Service":
						case "Order_Opertor":
						case "Order_Out_Service":
						case "Order_Rate":
							if (Convert.IsDBNull(Dr[0]))
							{
								Base_Information_Code.Text = "01";
							}
							else
							{
								switch (((string)((Dr[0].ToString() + 1).Trim(' '))).Length)
								{
									case 1:
										Base_Information_Code.Text = "0" + (Dr[0].ToString() + 1);
										break;
									default:
										Base_Information_Code.Text = Dr[0].ToString() + 1;
										break;
								}
							}
							break;
						case "Estate_No_Personnel":
							if (Convert.IsDBNull(Dr[0]))
							{
								Base_Information_Code.Text = "00001";
							}
							else
							{
								switch (((string)((Dr[0].ToString() + 1).Trim(' '))).Length)
								{
									case 1:

//====================================================================================================
//End of the allowed output for the Free Edition of Instant C#.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-instant-csharp.html
//====================================================================================================
