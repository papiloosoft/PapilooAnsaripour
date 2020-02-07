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
	public partial class ST_Goods
	{
		public ST_Goods()
		{
			InitializeComponent();
		}

		private string Goods_Id;
		private string Group_Id;
		private string Module_Id;
		private bool Add; //جداسازي ذخيره جديد و ويرايش
		private string f_serch; //تابع متغیر فرمول جستجو
		private string f_Select; //تابع متغیر فرمول جستجو
		private int err;
		private string ch;
		private int T_id; //پيش فرض شماره ثبت
		private Resizer rs = new Resizer();
		private void reset()
		{
			Goods_Code.Text = "";
			Goods_name.Text = "";
			Goods_Group.Text = "";
			Goods_Module.Text = "";
			Good_Case.SelectedIndex = -1;
			Goods_Technical_Code.Text = "";
			Goods_Description.Text = "";
			DV.Rows.Clear();
			DV.Columns.Clear();
		}
		private void Dv_Get()
		{
			DV.Rows.Clear();
			DV.Columns.Clear();
			DV.Columns.Add("row", "رديف");
			DV.Columns.Add("Goods_Code", "کد کالا");
			DV.Columns.Add("Goods_Name", "شرح کالا");
			DV.Columns.Add("Goods_Group_Name", "گروه کالا");
			DV.Columns.Add("Goods_Module", "واحد سنجش");
			DV.Columns.Add("Goods_Case", "ماهیت کالا");
			DV.Columns.Add("Goods_Technical_Code", "کد فنی کالا");
			DV.Columns.Add("Goods_Description", "توضيحات");
			DV.Columns.Add("Goods_Id", "");
			DV.Columns.Add("Group_Id", "");
			DV.Columns.Add("Module_Id", "");
			DV.Columns["Goods_Id"].Visible = false;
			DV.Columns["Group_Id"].Visible = false;
			DV.Columns["Module_Id"].Visible = false;
			DV.Columns["row"].Width = 100;
			DV.Columns["Goods_Code"].Width = 200;
			DV.Columns["Goods_Name"].Width = 250;
			DV.Columns["Goods_Group_Name"].Width = 100;
			DV.Columns["Goods_Module"].Width = 120;
			DV.Columns["Goods_Case"].Width = 180;
			DV.Columns["Goods_Technical_Code"].Width = 120;
			DV.Columns["Goods_Description"].Width = 400;
			DV.AllowUserToAddRows = false;
			DV.EditMode = DataGridViewEditMode.EditProgrammatically;
		}
		private void Item_Serch()
		{
			f_serch = "";
			if (!string.IsNullOrEmpty(Goods_Code.Text))
			{
				f_serch += " and Goods_Code like N'%" + Goods_Code.Text + "%'";
			}
			if (!string.IsNullOrEmpty(Goods_name.Text))
			{
				f_serch += "and Goods_name LIKE  N'%" + Goods_name.Text + "%'";
			}
			if (!string.IsNullOrEmpty(Goods_Group.Text))
			{
				f_serch += "and Goods_Group LIKE  N'" + Group_Id + "%'";
			}
			if (!string.IsNullOrEmpty(Goods_Module.Text))
			{
				f_serch += "and Goods_Module LIKE  N'" + Module_Id + "%'";
			}
			if (!string.IsNullOrEmpty(Good_Case.Text))
			{
				f_serch += "and  Goods_Case LIKE N'" + Good_Case.SelectedIndex + "%'";
			}
			if (!string.IsNullOrEmpty(Goods_Technical_Code.Text))
			{
				f_serch += "and Goods_Technical_Code LIKE  N'" + Goods_Technical_Code.Text + "%'";
			}
			if (!string.IsNullOrEmpty(Goods_Description.Text))
			{
				f_serch += "and Goods_Description LIKE  N'%" + Goods_Description.Text + "%'";
			}
			if (string.IsNullOrEmpty(f_serch))
			{
				modMessage.ShowMessage("کاربر محترم" + " :" + MDIParent1.DefaultInstance.I_N.Text, " آیا همه موارد جستجو شود؟", frmMessage.mIcon.mQuestion, frmMessage.mButtons.myes_No);
				if (modMessage.MessageValue == 5)
				{
					Select_Serch();
					Tabel_Serch();
				}
				else
				{
					return;
				}
			}
			else
			{
				f_serch += " where" + Microsoft.VisualBasic.Strings.Replace(f_serch, "and", "", 1, 1);
				Select_Serch();
				Tabel_Serch();
			}
		}
		private void Select_Serch()
		{
			f_Select = "";
			f_Select = "SELECT     A.*,";
			f_Select += "B.Base_Information_Id as Group_Id,B.Base_Information_Code as Group_Code,B.Base_Information_Name as Group_Name,";
			f_Select += "C.Base_Information_Id as Module_Id,C.Base_Information_Code as Module_Code,C.Base_Information_Name as Module_Name ";
			f_Select += "from  St_Goods AS A LEFT OUTER JOIN Base_Information AS B ON ";
			f_Select += "A.Goods_Group = B.Base_Information_Id LEFT OUTER JOIN Base_Information AS C ON ";
			f_Select += "A.Goods_Module = C.Base_Information_Id " + f_serch + "";
		}
		private void Tabel_Serch()
		{
			DataSet serch = data.PDataset("" + f_Select + "");
			foreach (DataRow Dr in serch.Tables[0].Rows)
			{
				DV.Rows.Add();

//====================================================================================================
//End of the allowed output for the Free Edition of Instant C#.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-instant-csharp.html
//====================================================================================================
