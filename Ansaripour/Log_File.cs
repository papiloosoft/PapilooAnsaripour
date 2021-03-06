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
	public partial class Log_File
	{
		public Log_File()
		{
			InitializeComponent();
		}

		private string maText;
		private string mbText;
		private string mcText;
		private string User_Id;
		private string f_serch; //تابع متغیر فرمول جستجو
		public void ConfigForm(string ATitle, string AText, string BText, string CText)
		{
			this.Text = ATitle;
			maText = AText;
			mbText = BText;
			mcText = CText;
		}
		private void Log_File_Load(object sender, System.EventArgs e)
		{
			switch (Convert.ToInt32(mcText))
			{
				case 0:
					B_User.Enabled = false;
					Button_1.Enabled = false;
					Button_2.Enabled = false;
					break;
				case 1:
					B_User.Enabled = true;
					Button_1.Enabled = true;
					Button_2.Enabled = true;
					break;
				case 2:
					L_User.Visible = false;
					B_User.Visible = false;
					User.Visible = false;
					break;
			}
			this.Cursor = Cursors.WaitCursor;
			Dv.Rows.Clear();
			Dv.Columns.Clear();
			Dv.Columns.Add("row", "ردیف");
			Dv.Columns.Add("Log_Date", "تاریخ");
			Dv.Columns.Add("Log_Time", "زمان");
			Dv.Columns.Add("Log_Operation", "شرح عملیات");
			Dv.Columns.Add("Log_User_Id", "کاربر");
			Dv.Columns.Add("Log_Details", "");
			Dv.Columns["Log_Details"].Visible = false;
			Dv.Columns["row"].Width = 50;
			Dv.Columns["Log_Date"].Width = 100;
			Dv.Columns["Log_Time"].Width = 120;
			Dv.Columns["Log_Operation"].Width = 200;
			Dv.Columns["Log_User_Id"].Width = 220;
			Dv.AllowUserToAddRows = false;
			Dv.EditMode = DataGridViewEditMode.EditProgrammatically;
			DataSet serch = data.PDataset("select A.*,B.* from Log_File A left join Security_Users B on A.Log_User_Id=B.Id where A.Log_Process='" + mbText + "' and A.Log_Table='" + maText + "'");
			Id_Code.Text = serch.Tables[0].Rows.Count + "مورد";
			foreach (DataRow Dr in serch.Tables[0].Rows)
			{
				Dv.Rows.Add();
				System.Windows.Forms.DataGridViewRow tempVar = Dv.Rows[Dv.Rows.Count - 1];
				tempVar.Cells["row"].Value = Dv.Rows.Count;
				tempVar.Cells["Log_Date"].Value = (Dr["Log_Date"]).ToString().Substring(0, 4) + "/" + (Dr["Log_Date"]).ToString().Substring(4, 2) + "/" + (Dr["Log_Date"]).ToString().Substring(6, 2);
				tempVar.Cells["Log_Time"].Value = Dr["Log_Time"];
				tempVar.Cells["Log_Operation"].Value = Dr["Log_Operation"];
				tempVar.Cells["Log_User_Id"].Value = Dr["Username"];
				tempVar.Cells["Log_Details"].Value = Dr["Log_Details"];
			}
			this.Cursor = Cursors.Default;
		}
		private void Dv_CellEnter(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
		{
			if (Dv.SelectedCells.Count > 0)
			{
				if (Convert.ToBoolean(Dv.CurrentRow.Cells["Log_Details"].Value) == System.DBNull.Value != true)
				{
					Log_Details.Text = Convert.ToString(Dv.CurrentRow.Cells["Log_Details"].Value);
				}
				else
				{
					Log_Details.Text = "";
				}
			}
		}
		private void Button_1_Click(System.Object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			Dv.Rows.Clear();
			Dv.Columns.Clear();
			Dv.Columns.Add("row", "ردیف");
			Dv.Columns.Add("Log_Date", "تاریخ");
			Dv.Columns.Add("Log_Time", "زمان");
			Dv.Columns.Add("Log_Operation", "شرح عملیات");
			Dv.Columns.Add("Log_User_Id", "کاربر");
			Dv.Columns.Add("Log_Details", "");
			Dv.Columns["Log_Details"].Visible = false;
			Dv.Columns["row"].Width = 50;
			Dv.Columns["Log_Date"].Width = 100;
			Dv.Columns["Log_Time"].Width = 120;
			Dv.Columns["Log_Operation"].Width = 200;
			Dv.Columns["Log_User_Id"].Width = 220;
			Dv.AllowUserToAddRows = false;
			Dv.EditMode = DataGridViewEditMode.EditProgrammatically;
			f_serch = "";
			f_serch = "select A.*,B.* from Log_File A left join Security_Users B on A.Log_User_Id=B.Id ";
			if (User.Text.Length == 0)
			{
				modMessage.ShowMessage("کاربر محترم" + " :" + MDIParent1.DefaultInstance.I_N.Text, " کاربری جهت جستجوی اطلاعات انتخاب نشده! کلیه اطلاعات نمایش داده می شوند", frmMessage.mIcon.mzoom, frmMessage.mButtons.mAccept);
			}
			else
			{
				f_serch += "where A.Log_User_Id LIKE N'" + User_Id + "'";
			}

//====================================================================================================
//End of the allowed output for the Free Edition of Instant C#.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-instant-csharp.html
//====================================================================================================
