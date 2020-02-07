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
	public partial class Repair_Report
	{
		public Repair_Report()
		{
			InitializeComponent();
		}

		private string f_serch; //تابع متغیر فرمول جستجو
		private Resizer rs = new Resizer();
		   private void Search_B_Click(System.Object sender, System.EventArgs e)
		   {
			DV.Rows.Clear();
			DV.Columns.Clear();
			DV.Columns.Add("row", "ردیف");
			DV.Columns.Add("Cost_Id_Total", "کد و نام دستگاه");
			DV.Columns.Add("Cost_Num_Failure", "مجموع تعداد خرابی");
			DV.Columns.Add("Cost_Time_Stop_Repair", "مجموع ساعت تعمیرات ");
			DV.Columns.Add("Cost_Time_Befor_Work", "مجموع کارکرد دستگاه");
			DV.Columns.Add("Cost_MTTR", "MTTR شاخص");
			DV.Columns.Add("Cost_MTBF", "MTBF شاخص");
			DV.Columns["row"].Width = 50;
			DV.Columns["Cost_Id_Total"].Width = 300;
			DV.Columns["Cost_Num_Failure"].Width = 120;
			DV.Columns["Cost_Time_Stop_Repair"].Width = 120;
			DV.Columns["Cost_Time_Befor_Work"].Width = 120;
			DV.Columns["Cost_MTTR"].Width = 100;
			DV.Columns["Cost_MTBF"].Width = 100;
			DV.AllowUserToAddRows = false;
			DV.EditMode = DataGridViewEditMode.EditProgrammatically;
			f_serch = "";
			if (Cost_Id_Total.Text.Length != 0)
			{
				f_serch += "and Cost_Id_Total LIKE N'" + data.Is_Number(Cost_Id_Total.Text) + "'";
			}
			if (Cost_Id_Request.Text.Length != 0)
			{
				f_serch += "and Cost_Id_Request LIKE N'" + data.Is_Number(Cost_Id_Request.Text) + "'";
			}
			if (Cost_Num_Request.Text.Length != 0)
			{
				f_serch += "and Cost_Num_Request LIKE N'" + Cost_Num_Request.Text + "'";
			}
			if (data.Is_date(Az_Cost_Date_Request.T_D))
			{
				f_serch += "and Cost_Date_Request >= '" + NumericHelper.Val((Az_Cost_Date_Request.T_D).Replace("/", "")) + "'";
			}
			if (data.Is_date(Ta_Cost_Date_Request.T_D))
			{
				f_serch += "and Cost_Date_Request <= '" + NumericHelper.Val((Ta_Cost_Date_Request.T_D).Replace("/", "")) + "'";
			}
			if (data.Is_date(Az_Cost_Date_Sabt.T_D))
			{
				f_serch += "and Cost_Date_Sabt >= '" + NumericHelper.Val((Az_Cost_Date_Sabt.T_D).Replace("/", "")) + "'";
			}
			if (data.Is_date(Ta_Cost_Date_Sabt.T_D))
			{
				f_serch += "and Cost_Date_Sabt <= '" + NumericHelper.Val((Ta_Cost_Date_Sabt.T_D).Replace("/", "")) + "'";
			}
			if (Cost_Repair_description.Text.Length != 0)
			{
				f_serch += "and Cost_Repair_description LIKE N'%" + Cost_Repair_description.Text + "%'";
			}
			if (Cost_Work_description.Text.Length != 0)
			{
				f_serch += "and Cost_Work_description LIKE N'%" + Cost_Work_description.Text + "%'";
			}
			if (Cost_Stop_Defect.Text.Length != 0)
			{
				f_serch += "and Cost_Stop_Defect LIKE N'" + data.Is_Number(Cost_Stop_Defect.Text) + "'";
			}
			if (MDIParent1.DefaultInstance.N_Admin.Text == "False")
			{
				f_serch += "and Repair_Area = " + MDIParent1.DefaultInstance.N_Id_Area.Text + "";
			}
			f_serch = Microsoft.VisualBasic.Strings.Replace(f_serch, "and", "", 1, 1);
			if (string.IsNullOrEmpty(f_serch))
			{
				modMessage.ShowMessage("کاربر محترم" + " :" + MDIParent1.DefaultInstance.I_N.Text, " موردی برای جستجو مشخص نشده آیا کلیه اقلام جستجو شوند ؟", frmMessage.mIcon.mserch, frmMessage.mButtons.myes_No);
				if (modMessage.MessageValue == 5)
				{
					f_serch = "SELECT repair_code,Repair_Name,Count(Cost_Id_Total)as C_Count ," + "sum(CAST(SUBSTRING([Cost_Time_Stop_Repair],1,2) AS int)) AS Hrs_Stop ," + "sum(CAST(SUBSTRING([Cost_Time_Stop_Repair],4,5) AS int)) AS Min_Stop ," + "sum(CAST(SUBSTRING([Cost_Time_Befor_Work],1,2) AS int)) AS Hrs_Befor ," + "sum(CAST(SUBSTRING([Cost_Time_Befor_Work],4,5) AS int)) AS Min_Befor " + "FROM Repair_Cost A LEFT JOIN Repair_Total B on a.Cost_Id_Total=b.Repair_Id GROUP BY repair_code,Repair_Name";
				}
				else
				{
					return;
				}
			}
			else
			{
				f_serch = "SELECT repair_code,Repair_Name,Count(Cost_Id_Total)as C_Count ," + "sum(CAST(SUBSTRING([Cost_Time_Stop_Repair],1,2) AS int)) AS Hrs_Stop ," + "sum(CAST(SUBSTRING([Cost_Time_Stop_Repair],4,5) AS int)) AS Min_Stop ," + "sum(CAST(SUBSTRING([Cost_Time_Befor_Work],1,2) AS int)) AS Hrs_Befor ," + "sum(CAST(SUBSTRING([Cost_Time_Befor_Work],4,5) AS int)) AS Min_Befor " + "FROM Repair_Cost A LEFT JOIN Repair_Total B on a.Cost_Id_Total=b.Repair_Id where " + f_serch + " GROUP BY repair_code,Repair_Name";
			}
			DataSet serch = data.PDataset("" + f_serch + "");
			if (serch.Tables[0].Rows.Count == 0)
			{
				modMessage.ShowMessage("کاربر محترم" + " :" + MDIParent1.DefaultInstance.I_N.Text, " اطلاعات مورد نظر شما در سیستم وجود ندارد", frmMessage.mIcon.mserch, frmMessage.mButtons.mAccept);
			}
			else
			{
				foreach (DataRow Dr in serch.Tables[0].Rows)
				{
					DV.Rows.Add();
					System.Windows.Forms.DataGridViewRow tempVar = DV.Rows[DV.Rows.Count - 1];
					tempVar.Cells["row"].Value = DV.Rows.Count;
					tempVar.Cells["Cost_Id_Total"].Value = Dr["repair_code"].ToString() + "-" + Dr["Repair_Name"].ToString();
					tempVar.Cells["Cost_Num_Failure"].Value = Dr["C_Count"];
					int hh_Stop = 0;
					int mm_Stop = 0;
					int hh_Befor = 0;
					int mm_Befor = 0;
					if (Convert.ToInt32(Dr["Min_Stop"]) > 59)
					{
						hh_Stop = ((Dr["Hrs_Stop"] * 60) + Dr["Min_Stop"]) / 60;
						mm_Stop = Convert.ToInt32(((Dr["Hrs_Stop"] * 60) + Dr["Min_Stop"]) - (hh_Stop * 60));
					}
					else
					{
						hh_Stop = Convert.ToInt32(Dr["Hrs_Stop"]);
						mm_Stop = Convert.ToInt32(Dr["Min_Stop"]);
					}
					tempVar.Cells["Cost_Time_Stop_Repair"].Value = hh_Stop + ":" + mm_Stop;
					if (Convert.ToInt32(Dr["Min_Befor"]) > 59)
					{
						hh_Befor = ((Dr["Hrs_Befor"] * 60) + Dr["Min_Befor"]) / 60;
						mm_Befor = Convert.ToInt32(((Dr["Hrs_Befor"] * 60) + Dr["Min_Befor"]) - (hh_Befor * 60));
					}
					else
					{
						hh_Befor = Convert.ToInt32(Dr["Hrs_Befor"]);
						mm_Befor = Convert.ToInt32(Dr["Min_Befor"]);
					}
					if (Check.Checked == true)
					{
						tempVar.Cells["Cost_Time_Befor_Work"].Value = Cost_Time_Befor_Work.Text;
						tempVar.Cells["Cost_MTTR"].Value = Math.Round(((NumericHelper.Val(hh_Stop) * 60) + NumericHelper.Val(mm_Stop)) / Dr["C_Count"], 2);
						tempVar.Cells["Cost_MTBF"].Value = Math.Round(Dr["C_Count"] / ((NumericHelper.Val(Cost_Time_Befor_Work.Text.Substring(0, 2)) * 60) + NumericHelper.Val(Cost_Time_Befor_Work.Text.Substring(3, 5))), 2);
					}

//====================================================================================================
//End of the allowed output for the Free Edition of Instant C#.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-instant-csharp.html
//====================================================================================================
