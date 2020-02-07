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
	public partial class Order_Add
	{
		public Order_Add()
		{
			InitializeComponent();
		}

		private string Id_Subscription;
		// Private Id_Order_Add As String
		private bool Add; //جداسازی ذخیره جدید و ویرایش
		private string f_serch; //تابع متغیر فرمول جستجو
		private string f_Select; //تابع متغیر فرمول جستجو
		private bool test;
		private string log;
		private int err;
		private bool Edit;
		private DataGridView dgvClicked;
		private Resizer rs = new Resizer();
		private void B_Order_Add_Click(System.Object sender, System.EventArgs e)
		{
			log = "ثبت سفارش جدید";
			Save_B.Enabled = true;
			reset();
			Dv1_Get();
			Dv2_Get();
			Dv_Request_Get();
			Dv_Details_Get();
			Add = true;
			if (Dv_Details.RowCount < 20)
			{
				Dv_Details.AllowUserToAddRows = true;
			}
			Dv_Details.EditMode = DataGridViewEditMode.EditOnKeystroke;
			Dv_Details.ReadOnly = false;
			Dv_Details.SelectionMode = DataGridViewSelectionMode.CellSelect;
			Dv_Details.RowsDefaultCellStyle.BackColor = Color.LightGray;
			Dv_Details.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
		}
		private void B_Picture_Click(System.Object sender, System.EventArgs e)
		{
			if (DV.SelectedCells.Count > 0)
			{
				modMessage.ShowPicture("فرم الصاق تصویر ثبت سفارشات ", "Order", Convert.ToString(DV.CurrentRow.Cells["Order_Id"].Value));
			}
			else
			{
				modMessage.ShowMessage("کاربر محترم" + " :" + MDIParent1.DefaultInstance.I_N.Text, " انتخابی برای نمایش وجود ندارد", frmMessage.mIcon.mInfo, frmMessage.mButtons.mAccept);
			}
		}
		private void Dv_Get()
		{
			DV.Rows.Clear();
			DV.Columns.Clear();
			DV.Columns.Add("row", "رديف");
			DV.Columns.Add("Order_Number", "شماره سفارش");
			DV.Columns.Add("Order_Date", "تاریخ سفارش");
			DV.Columns.Add("Order_Time", "زمان سفارش");
			DV.Columns.Add("Order_Subscription", "سفارش دهنده");
			DV.Columns.Add("Order_Id", "");
			DV.Columns.Add("Id_Service", "");
			DV.Columns.Add("Order_Subscription_Id", "");
			DV.Columns.Add("Order_In_Description", "");
			DV.Columns.Add("Order_Description", "");
			DV.Columns.Add("Order_PrePayment", "");
			DV.Columns.Add("Order_Factor", "");
			DV.Columns.Add("Order_Discount", "");
			DV.Columns.Add("Order_Tax", "");
			DV.Columns.Add("Id_User", "");
			DV.Columns["Order_Id"].Visible = false;
			DV.Columns["Id_Service"].Visible = false;
			DV.Columns["Order_Subscription_Id"].Visible = false;
			DV.Columns["Order_In_Description"].Visible = false;
			DV.Columns["Order_Description"].Visible = false;
			DV.Columns["Order_PrePayment"].Visible = false;
			DV.Columns["Order_Factor"].Visible = false;
			DV.Columns["Order_Discount"].Visible = false;
			DV.Columns["Order_Tax"].Visible = false;
			DV.Columns["Id_User"].Visible = false;
			DV.Columns["row"].Width = 40;
			DV.Columns["Order_Number"].Width = 120;
			DV.Columns["Order_Date"].Width = 120;
			DV.Columns["Order_Time"].Width = 120;
			DV.Columns["Order_Subscription"].Width = 700;
			DV.AllowUserToAddRows = false;
			DV.EditMode = DataGridViewEditMode.EditProgrammatically;
		}
		private void Dv1_Get()
		{
			Dv1.Rows.Clear();
			Dv1.Columns.Clear();
			Dv1.Controls.Clear();
			Dv1.Columns.Add("row", "رديف");
			Dv1.Columns.Add("Order_Service_Code", "کد");
			Dv1.Columns.Add("Order_Service_Descriptions", "شرح خدمت");
			Dv1.Columns.Add("Order_Service_Id", "");
			Dv1.Columns.Add("Order_Service_Information_Id", "");
			Dv1.Columns.Add("Order_Service_Start_Date", "");
			Dv1.Columns.Add("Order_Service_End_Date", "");
			Dv1.Columns.Add("Order_Service_End_Time", "");
			Dv1.Columns.Add("Order_Service_Description", "");
			Dv1.Columns["Order_Service_Id"].Visible = false;
			Dv1.Columns["Order_Service_Information_Id"].Visible = false;
			Dv1.Columns["Order_Service_Start_Date"].Visible = false;
			Dv1.Columns["Order_Service_End_Date"].Visible = false;
			Dv1.Columns["Order_Service_End_Time"].Visible = false;
			Dv1.Columns["Order_Service_Description"].Visible = false;
			Dv1.Columns["row"].Width = 40;

//====================================================================================================
//End of the allowed output for the Free Edition of Instant C#.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-instant-csharp.html
//====================================================================================================
