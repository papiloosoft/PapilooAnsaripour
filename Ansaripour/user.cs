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
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;

using System.Drawing;

namespace Ansaripour
{
	public partial class user
	{
		public user()
		{
			InitializeComponent();
		}

		private bool Add; //indicator if add button was pressed
		private Resizer rs = new Resizer();
//INSTANT C# NOTE: These were formerly VB static local variables:
		private bool TreeCheckBoxes_noEntraNode;

		private void user_Load(System.Object sender, System.EventArgs e)
		{
			rs.FindAllControls(this);
			data_load();
		}
		private void data_load()
		{
			username.Enabled = false;
			password.Enabled = false;
			Area.Enabled = false;
			Admin.Enabled = false;
			Description.Enabled = false;
			B_Save.Enabled = false;
			B_Delet.Enabled = false;
			Dv.Rows.Clear();
			Dv.Columns.Clear();
			Dv.DefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Regular, GraphicsUnit.Point);
			Dv.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Regular, GraphicsUnit.Point);
			Dv.Columns.Add("row", "رديف");
			Dv.Columns.Add("Username", "نام کاربری");
			Dv.Columns.Add("password", "");
			Dv.Columns.Add("Description", "");
			Dv.Columns.Add("Name_Area", "");
			Dv.Columns.Add("Area", "");
			Dv.Columns.Add("ID", "");
			Dv.Columns.Add("Admin", "");
			Dv.Columns["password"].Visible = false;
			Dv.Columns["Description"].Visible = false;
			Dv.Columns["Name_Area"].Visible = false;
			Dv.Columns["Admin"].Visible = false;
			Dv.Columns["ID"].Visible = false;
			Dv.Columns["row"].Width = 100;
			Dv.Columns["Username"].Width = 400;
			Dv.AllowUserToAddRows = false;
			Dv.EditMode = DataGridViewEditMode.EditProgrammatically;
			DataSet serch = data.PDataset("SELECT  A.*, B.* FROM  Security_Users AS A LEFT OUTER JOIN Area AS B ON " + "A.Area = B.Id_Area ");
			foreach (DataRow Dr in serch.Tables[0].Rows)
			{
				Dv.Rows.Add();
				System.Windows.Forms.DataGridViewRow tempVar = Dv.Rows[Dv.Rows.Count - 1];
				tempVar.Cells["row"].Value = Dv.Rows.Count;
				tempVar.Cells["Username"].Value = Dr["Username"];
				tempVar.Cells["password"].Value = Dr["password"];
				tempVar.Cells["Description"].Value = Dr["Description"];
				tempVar.Cells["Name_Area"].Value = Dr["Id_Area"].ToString() + " - " + Dr["Department_Area"].ToString();
				tempVar.Cells["Admin"].Value = Dr["Admin"];
				tempVar.Cells["ID"].Value = Dr["ID"];
			}
		}
		private void list()
		{
			//------(خدمات)----------------------------------------------------------------------------------------------------------------
			tvData.Nodes.Clear();
			TreeNode Services = tvData.Nodes.Add(MDIParent1.DefaultInstance.DefaultInstance.Services.Text);
			Services.ForeColor = Color.FromArgb(1, 32, 96, 147);
			TreeNode Services_Sale_Managing = Services.Nodes.Add(MDIParent1.DefaultInstance.DefaultInstance.Services_Sale_Managing.Text);
			Services_Sale_Managing.ForeColor = Color.FromArgb(1, 255, 96, 150);
			TreeNode Base_Seasonal_Product_Type = Services_Sale_Managing.Nodes.Add(MDIParent1.DefaultInstance.DefaultInstance.Base_Seasonal_Product_Type.Text);
			Base_Seasonal_Product_Type.ForeColor = Color.FromArgb(1, 227, 121, 68);
			TreeNode Services_Order_Add = Services.Nodes.Add(MDIParent1.DefaultInstance.DefaultInstance.Services_Order_Add.Text);
			Services_Order_Add.ForeColor = Color.FromArgb(1, 255, 96, 150);
			TreeNode Services_Seasonal_Buy_Sales = Services.Nodes.Add(MDIParent1.DefaultInstance.DefaultInstance.Services_Seasonal_Buy_Sales.Text);
			Services_Seasonal_Buy_Sales.ForeColor = Color.FromArgb(1, 255, 96, 150);
			TreeNode Services_Seasonal_Buy = Services_Seasonal_Buy_Sales.Nodes.Add(MDIParent1.DefaultInstance.DefaultInstance.Services_Seasonal_Buy.Text);
			Services_Seasonal_Buy.ForeColor = Color.FromArgb(1, 227, 121, 68);
			TreeNode Services_Seasonal_Sale = Services_Seasonal_Buy_Sales.Nodes.Add(MDIParent1.DefaultInstance.DefaultInstance.Services_Seasonal_Sale.Text);
			Services_Seasonal_Sale.ForeColor = Color.FromArgb(1, 227, 121, 68);
			TreeNode Services_Seasonal_Contractor = Services_Seasonal_Buy_Sales.Nodes.Add(MDIParent1.DefaultInstance.DefaultInstance.Services_Seasonal_Contractor.Text);
			Services_Seasonal_Contractor.ForeColor = Color.FromArgb(1, 227, 121, 68);
			TreeNode Services_Seasonal_Employer = Services_Seasonal_Buy_Sales.Nodes.Add(MDIParent1.DefaultInstance.DefaultInstance.Services_Seasonal_Employer.Text);
			Services_Seasonal_Employer.ForeColor = Color.FromArgb(1, 227, 121, 68);
			TreeNode Services_Seasonal_Export = Services_Seasonal_Buy_Sales.Nodes.Add(MDIParent1.DefaultInstance.DefaultInstance.Services_Seasonal_Export.Text);
			Services_Seasonal_Export.ForeColor = Color.FromArgb(1, 227, 121, 68);
			TreeNode Services_Seasonal_Importation = Services_Seasonal_Buy_Sales.Nodes.Add(MDIParent1.DefaultInstance.DefaultInstance.Services_Seasonal_Importation.Text);
			Services_Seasonal_Importation.ForeColor = Color.FromArgb(1, 227, 121, 68);
			TreeNode Services_Seasonal_Contract_Work = Services_Seasonal_Buy_Sales.Nodes.Add(MDIParent1.DefaultInstance.DefaultInstance.Services_Seasonal_Contract_Work.Text);
			Services_Seasonal_Contract_Work.ForeColor = Color.FromArgb(1, 227, 121, 68);
			TreeNode Services_Seasonal_Rent = Services_Seasonal_Buy_Sales.Nodes.Add(MDIParent1.DefaultInstance.DefaultInstance.Services_Seasonal_Rent.Text);
			Services_Seasonal_Rent.ForeColor = Color.FromArgb(1, 227, 121, 68);
			TreeNode Services_Seasonal_Presell = Services_Seasonal_Buy_Sales.Nodes.Add(MDIParent1.DefaultInstance.DefaultInstance.Services_Seasonal_Presell.Text);
			Services_Seasonal_Presell.ForeColor = Color.FromArgb(1, 227, 121, 68);
			TreeNode Services_Edit_Access = Services.Nodes.Add(MDIParent1.DefaultInstance.DefaultInstance.Services_Edit_Access.Text);
			Services_Edit_Access.ForeColor = Color.FromArgb(1, 255, 96, 150);
			TreeNode Services_Delete_Access = Services.Nodes.Add(MDIParent1.DefaultInstance.DefaultInstance.Services_Delete_Access.Text);
			Services_Delete_Access.ForeColor = Color.FromArgb(1, 255, 96, 150);
			//------(حسابداری)----------------------------------------------------------------------------------------------------------------
			TreeNode Accounting = tvData.Nodes.Add(MDIParent1.DefaultInstance.DefaultInstance.Accounting.Text);
			Accounting.ForeColor = Color.FromArgb(1, 32, 96, 147);
			TreeNode Accounting_Add = Accounting.Nodes.Add(MDIParent1.DefaultInstance.DefaultInstance.Accounting_Add.Text);
			Accounting_Add.ForeColor = Color.FromArgb(1, 255, 96, 150);
			TreeNode Accounting_View = Accounting.Nodes.Add(MDIParent1.DefaultInstance.DefaultInstance.Accounting_View.Text);
			Accounting_View.ForeColor = Color.FromArgb(1, 255, 96, 150);

//====================================================================================================
//End of the allowed output for the Free Edition of Instant C#.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-instant-csharp.html
//====================================================================================================
